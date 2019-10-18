namespace Fable.Plotly.Generator

module Render =
    open System
    open Utils
    open Domain

    /// Indents a string with 4 spaces per `numLevels` given
    let indent numLevels = String.indent 4 numLevels

    module GetLines =
        /// Returns the head of a string list if the length is over the threshold
        let private trimTreeToHead (threshold: int) (tree: string list) =
            match tree with
            | tree when tree.Length > threshold ->
                tree.Head |> List.singleton
            | tree -> tree

        /// Returns the head and tail of a string list as a new list if the length is over the threshold
        let private firstLastTree (threshold: int) (parentTree: string list) =
            if parentTree.Length > threshold then
                [ parentTree.Head; parentTree |> List.last ]
            else parentTree

        /// Gets the code lines for the implementation of a single component overload.
        /// Does not include docs.
        let singleComponentOverload (comp: Component) (compOverload: ComponentOverload) =
            let filterMethod (tree: string list) =
                tree |> List.filter ((<>) (comp.MethodName |> String.upperFirst))

            let baseInterfaceTree =
                comp.ParentNameTree
                |> function
                | tree when tree.IsEmpty -> [ "Plot" ]
                | tree -> tree
                |> List.distinct

            let baseInterface =
                baseInterfaceTree
                |> trimTreeToHead 3
                |> String.concat ""

            let attrStr =
                match (comp.ParentNameTree |> filterMethod) with
                | [ s ] -> s
                | _ ->
                    if baseInterfaceTree.Length > 1 then 
                        baseInterfaceTree |> filterMethod |> trimTreeToHead 3 |> String.concat ""
                    else baseInterface

            if compOverload.SkipAttr then
                comp.ParentNameTree
                |> filterMethod
                |> function
                | tree when tree.IsEmpty -> [ "Plot" ]
                | tree -> tree
                |> List.last
                |> String.lowerFirst
            else comp.MethodName
            |> fun inputAttr ->
                sprintf "static member %s%s %s = Interop.mk%sAttr \"%s\" %s"
                    (if compOverload.IsInline then "inline "
                     else "") comp.MethodName
                    (baseInterface |> compOverload.ParamFun) attrStr
                    inputAttr compOverload.PropsCode |> List.singleton

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropRegularOverload (prop: Prop) (propOverload: RegularPropOverload) =
            let bodyCode =
                match propOverload.BodyCode with
                | ValueExprOnly expr ->
                    sprintf "Interop.mk%sAttr \"%s\" %s" (prop.ParentNameTree |> trimTreeToHead 3 |> String.concat "") prop.RealPropName
                        expr
                | CustomBody code -> code
            sprintf "static member %s%s %s = %s"
                (if propOverload.IsInline then "inline "
                 else "") prop.MethodName propOverload.ParamsCode bodyCode |> List.singleton

        /// Builds the base interface for enumerable props
        let enumBaseInterface (prop: Prop) =
            prop.ParentNameTree
            |> trimTreeToHead 4
            |> function
            | tree when tree.Length = 2 -> 
                tree |> List.filter (fun s -> s <> (prop.MethodName |> String.upperFirst))
            | tree when tree.Length > 2 && prop.PropType <> ValType.EnumeratedArray ->
                tree |> (List.rev >> List.tail >> List.rev)
            | tree -> tree
            |> String.concat ""

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropEnumOverload (prop: Prop) (propOverload: EnumPropOverload) =
            sprintf "static member %s%s %s= Interop.mk%sAttr \"%s\" %s"
                (if propOverload.IsInline then "inline "
                 else "") propOverload.MethodName
                (match propOverload.ParamsCode with
                 | Some s -> s + " "
                 | None -> "") (enumBaseInterface prop) prop.RealPropName propOverload.ValueCode
            |> emptStringToNone
            |> List.singleton

        /// Gets all props within a `Component`
        let getCompProps (comp: Component) =
            comp.Props
            |> List.choose (fun p ->
                if p.Components.IsEmpty then None
                else Some [ p.Components ])
            |> (List.concat >> List.concat)

        /// Builds non-extension prop strings for a given component
        let regularNonExtensionPropsForComponent (comp: Component) indentLevel =
            let propsAndRegularNonExtensionOverloads =
                comp.Props
                |> List.choose (fun p ->
                    let regularNonExtensionOverloads = p.RegularOverloads |> List.filter (fun o -> not o.IsExtension)
                    if regularNonExtensionOverloads.IsEmpty then None
                    else Some(p, regularNonExtensionOverloads))

            let compProps = getCompProps comp

            match propsAndRegularNonExtensionOverloads.IsEmpty, compProps.IsEmpty with
            | true, true -> []
            | true, false ->
                [ "[<Erase>]" |> indent indentLevel
                  sprintf "type %s = " comp.MethodName |> indent indentLevel
                  for comp in compProps do
                      for overload in comp.Overloads do
                          yield! singleComponentOverload comp overload |> List.map (indent (indentLevel + 1)) ]
            | _ ->
                let allOverloadsAreInline =
                    propsAndRegularNonExtensionOverloads
                    |> List.forall (fun (_, os) -> os |> List.forall (fun o -> o.IsInline))
                [ if allOverloadsAreInline then "[<Erase>]" |> indent indentLevel
                  sprintf "type %s =" comp.MethodName |> indent indentLevel

                  for comp in compProps do
                      for overload in comp.Overloads do
                          yield! singleComponentOverload comp overload |> List.map (indent (indentLevel + 1))

                  for prop, overloads in propsAndRegularNonExtensionOverloads do
                      for overload in overloads do
                          yield! prop.DocLines
                                 |> List.map
                                     (String.prefix "/// "
                                      >> String.trim
                                      >> indent (indentLevel + 1))
                          yield! singlePropRegularOverload prop overload |> List.map (indent (indentLevel + 1)) ]

        /// Builds extension prop strings for a component
        let regularExtensionPropsForComponent (comp: Component) indentLevel =
            let propsAndRegularExtensionOverloads =
                comp.Props
                |> List.choose (fun p ->
                    let regularExtensionOverloads = p.RegularOverloads |> List.filter (fun o -> o.IsExtension)
                    if regularExtensionOverloads.IsEmpty then None
                    else Some(p, regularExtensionOverloads))

            if propsAndRegularExtensionOverloads.IsEmpty then
                []
            else
                [ "[<AutoOpen>]" |> indent indentLevel
                  sprintf "module %sExtensions =" comp.MethodName |> indent indentLevel
                  ""
                  sprintf "type %s with" comp.MethodName |> indent (indentLevel + 1)

                  for prop, overloads in propsAndRegularExtensionOverloads do
                      for overload in overloads do
                          yield! prop.DocLines
                                 |> List.map
                                     (String.prefix "/// "
                                      >> String.trim
                                      >> indent (indentLevel + 2))
                          yield! singlePropRegularOverload prop overload |> List.map (indent (indentLevel + 2)) ]

        /// Builds enumeration prop strings for a component
        let enumPropsForComponent (comp: Component) indentLevel =
            let propsAndEnumOverloads =
                comp.Props
                |> List.choose (fun p ->
                    if p.EnumOverloads.IsEmpty then None
                    else Some(p, p.EnumOverloads))

            if propsAndEnumOverloads.IsEmpty then
                []
            else
                [ for prop, _ in propsAndEnumOverloads do
                    if prop.PropType = ValType.EnumeratedArray then
                        let baseInterface = if indentLevel > 1 then prop.ParentNameTree |> trimTreeToHead 3 |> String.concat "" else enumBaseInterface prop
                        sprintf "/// Use a list of enumerated values" |> indent (indentLevel + 1)
                        sprintf "let inline %ss (properties: #I%sProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mk%sAttr \"%s\""
                            prop.MethodName baseInterface baseInterface prop.RealPropName
                        |> indent (indentLevel + 1)
                        ""
                  for prop, overloads in propsAndEnumOverloads do
                    let allOverloadsAreInline = overloads |> List.forall (fun o -> o.IsInline)
                    yield! prop.DocLines
                           |> List.map
                               (String.prefix "/// "
                                >> String.trim
                                >> indent (indentLevel + 1))
                    if allOverloadsAreInline then "[<Erase>]" |> indent (indentLevel + 1)
                    sprintf "type %s =" prop.MethodName |> indent (indentLevel + 1)
                    for overload in overloads do
                        yield! overload.DocLines
                               |> List.map
                                   (String.prefix "/// "
                                    >> String.trim
                                    >> indent (indentLevel + 2))
                        yield! singlePropEnumOverload prop overload |> List.map (indent (indentLevel + 2))
                    "" ]

        /// Gets all prop strings for a component
        let rec propsForComponent indentStart (comp: Component) =
            let regularProps = regularNonExtensionPropsForComponent comp indentStart
            let regularExtensionProps = regularExtensionPropsForComponent comp indentStart
            let enumProps = enumPropsForComponent comp indentStart
            let compProps = getCompProps comp |> List.collect (propsForComponent (indentStart + 1))

            [ if not regularProps.IsEmpty then
                yield! regularProps
                ""
              if not regularExtensionProps.IsEmpty then
                  yield! regularExtensionProps
                  ""
              if enumProps.Length + compProps.Length > 0 then
                  sprintf "[<AutoOpen>]" |> indent indentStart
                  sprintf "module %s =" comp.MethodName |> indent indentStart
              yield! enumProps
              yield! compProps ]

        /// Gets all component strings for a component
        let rec subComponentsForComponent depth (comp: Component) =
            let actualDepth = depth + 1

            let compComps = getCompProps comp |> List.collect (subComponentsForComponent actualDepth)

            if depth = 0 then []
            else [ comp ]
            |> List.append compComps

        /// Gets all distict components within a component list based on the `ParentNameTree` and method name
        let private getComponentsDistinctParentAndMethod (comps: Component list) =
            comps
            |> List.collect (subComponentsForComponent 0)
            |> List.append comps
            |> List.distinctBy (fun c -> ((c.ParentNameTree |> String.concat ""), c.MethodName))

        /// Builds the interface strings from a `Component list`
        let buildInterfaces (comps: Component list) =
            let buildInterfaceStrs (comp: Component) =
                let interfaceCompStr (comp: Component) =
                    comp.ParentNameTree
                    |> List.distinct
                    |> firstLastTree 3
                    |> String.concat ""
                    |> sprintf "type I%sProperty = interface end"

                let interfacePropStr (prop: Prop) =
                    let enumAttrs =
                        if not prop.EnumOverloads.IsEmpty then
                            if prop.ParentNameTree.Length <= 4 then
                                prop.ParentNameTree
                                |> (List.rev
                                    >> List.tail
                                    >> List.rev)
                            else prop.ParentNameTree
                            |> (firstLastTree 4 >> String.concat "")
                            |> List.singleton
                        else
                            []

                    let regularAttrs =
                        if not prop.RegularOverloads.IsEmpty then
                            prop.ParentNameTree
                            |> firstLastTree 4
                            |> String.concat ""
                            |> List.singleton
                        else
                            []

                    enumAttrs @ regularAttrs |> List.map (sprintf "type I%sProperty = interface end")


                [ yield! comp.Props |> List.collect interfacePropStr
                  interfaceCompStr comp ]
                |> List.map (indent 1)

            comps
            |> getComponentsDistinctParentAndMethod
            |> List.collect buildInterfaceStrs
            |> List.distinct
            |> List.sort

        /// Builds the interop strings from a `Component list`
        let buildInterops (comps: Component list) =
            let buildInteropStrs (comp: Component) =
                let interopCompStr (comp: Component) =
                    comp.ParentNameTree @ [ comp.MethodName |> String.upperFirst ]
                    |> List.distinct
                    |> firstLastTree 3
                    |> String.concat ""
                    |> fun prop ->
                        sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)" 
                            prop prop

                let interopPropStr (prop: Prop) =
                    let enumAttrs =
                        if not prop.EnumOverloads.IsEmpty then
                            if prop.ParentNameTree.Length <= 4 then
                                prop.ParentNameTree
                                |> (List.rev
                                    >> List.tail
                                    >> List.rev)
                            else prop.ParentNameTree
                            |> (firstLastTree 4 >> String.concat "")
                            |> fun prop ->
                                sprintf
                                    "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)"
                                    prop prop
                            |> List.singleton
                        else
                            []

                    let regularAttrs =
                        if not prop.RegularOverloads.IsEmpty then
                            prop.ParentNameTree
                            |> (firstLastTree 4 >> String.concat "")
                            |> fun prop ->
                                sprintf
                                    "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)"
                                    prop prop
                            |> List.singleton
                        else
                            []

                    enumAttrs @ regularAttrs


                [ yield! comp.Props |> List.collect interopPropStr
                  interopCompStr comp ]
                |> List.map (indent 1)

            comps
            |> getComponentsDistinctParentAndMethod
            |> List.collect buildInteropStrs
            |> List.distinct
            |> List.sort

    /// Generate the interop file
    let interopDocument (api: ComponentApi) =
        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          "[<RequireQualifiedAccess>]"
          "module Interop ="
          sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)"
              api.ComponentContainerTypeName api.ComponentContainerTypeName |> indent 1
          yield! GetLines.buildInterops api.Components
          "" ]
        |> String.concat Environment.NewLine

    /// Generate the interfaces type file
    let typesDocument (api: ComponentApi) =
        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          "open System.ComponentModel"
          ""
          "[<AutoOpen;EditorBrowsable(EditorBrowsableState.Never)>]"
          "module Types ="
          sprintf "type I%sProperty = interface end" api.ComponentContainerTypeName |> indent 1
          yield! (GetLines.buildInterfaces api.Components |> List.distinct)
          "" ]
        |> String.concat Environment.NewLine

    /// Generate the base level Plotly component file
    let componentDocument (api: ComponentApi) =
        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          if not api.ComponentsPrelude.IsEmpty then "open System.ComponentModel"
          "open Browser.Types"
          "open Fable.Core"
          "open Fable.Core.JsInterop"
          "open Fable.React"
          "open Feliz"
          ""
          if not api.ComponentsPrelude.IsEmpty then
              "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
              sprintf "module %sHelpers =" api.ComponentContainerTypeName
              ""
              yield! api.ComponentsPrelude
              ""
          if not api.TypePostlude.IsEmpty then
              "[<Erase>]"
              sprintf "type %s =" (api.ComponentContainerTypeName |> String.lowerFirst)
              for doc, cont in api.TypePostlude do
                  if doc
                     |> String.IsNullOrEmpty
                     |> not
                  then
                      doc
                      |> String.prefix "/// "
                      |> String.trim
                      |> indent 1
                  cont |> indent 1
              ""
          if not api.Bindings.IsEmpty then
              "[<Erase>]"
              sprintf "type %s =" api.ComponentContainerName
              for (docs, binding) in api.Bindings do
                  if docs
                     |> String.IsNullOrEmpty
                     |> not
                  then
                      docs
                      |> String.prefix "/// "
                      |> String.trim
                      |> indent 1
                  binding |> indent 1
              "" ]
        |> String.concat Environment.NewLine

    /// Builds the props documents with chunking if enabled
    let propsDocument (chunk: bool) (api: ComponentApi) =
        let buildDoc (comps: Component list) =
            [ sprintf "namespace %s" api.Namespace
              ""
              "(*////////////////////////////////"
              "/// THIS FILE IS AUTO-GENERATED //"
              "////////////////////////////////*)"
              ""
              "open Fable.Core"
              "open Fable.Core.JsInterop"
              "open Feliz"
              ""
              if not api.PropsPrelude.IsEmpty then
                  yield! api.PropsPrelude
                  ""
              for comp in comps do
                  yield! GetLines.propsForComponent 0 comp
              "" ]
            |> String.concat Environment.NewLine

        if chunk then
            api.Components
            |> List.map (fun comp ->
                comp.MethodName,
                comp
                |> List.singleton
                |> buildDoc)
        else
            [ "Props", buildDoc api.Components ]
