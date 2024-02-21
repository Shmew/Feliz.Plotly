namespace Fable.Plotly.Generator

module Render =
    open System
    open Utils
    open Domain

    /// Indents a string with 4 spaces per `numLevels` given
    let indent numLevels = String.indent 4 numLevels

    module GetLines =
        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropRegularOverload (prop: Prop) (propOverload: RegularPropOverload) =
            let bodyCode =
                match propOverload.BodyCode with
                | ValueExprOnly expr ->
                    sprintf "Interop.mk%sAttr \"%s\" %s" prop.ParentNameTree.Head prop.RealPropName expr
                | CustomBody code -> code

            let paramsCode =
                match propOverload.ParamsCode with
                | "" -> ""
                | _ -> sprintf " %s" propOverload.ParamsCode

            sprintf "static member %s%s%s = %s"
                (if propOverload.IsInline then "inline "
                 else "") prop.MethodName paramsCode bodyCode |> List.singleton

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropEnumOverload (prop: Prop) (propOverload: EnumPropOverload) =
            sprintf "static member %s%s %s= Interop.mk%sAttr \"%s\" %s"
                (if propOverload.IsInline then "inline "
                 else "")
                propOverload.MethodName
                (match propOverload.ParamsCode with
                 | Some s -> s + " "
                 | None -> "")
                prop.ParentNameTree.Head
                prop.RealPropName
                propOverload.ValueCode
            |> emptStringToNone
            |> List.singleton

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropCustomOverload (propOverload: CustomPropOverload) =
            let paramsCode =
                match propOverload.ParamsCode with
                | "" -> ""
                | _ -> sprintf " %s" propOverload.ParamsCode

            sprintf "static member %s%s%s = %s"
                (if propOverload.IsInline then "inline "
                 else "") propOverload.MethodName paramsCode propOverload.BodyCode
            |> List.singleton

        /// Builds non-extension prop strings for a given component
        let regularNonExtensionPropsForComponent (comp: Component) indentLevel =
            let propsAndRegularNonExtensionOverloads =
                comp.Props
                |> List.choose (fun p ->
                    let regularNonExtensionOverloads = p.RegularOverloads |> List.filter (fun o -> not o.IsExtension)
                    if regularNonExtensionOverloads.IsEmpty then None
                    else Some(p, regularNonExtensionOverloads))

            match propsAndRegularNonExtensionOverloads.IsEmpty with
            | true -> []
            | false ->
                let allOverloadsAreInline =
                    propsAndRegularNonExtensionOverloads
                    |> List.forall (fun (_, os) -> os |> List.forall (fun o -> o.IsInline))
                [ if allOverloadsAreInline then "[<Erase>]" |> indent indentLevel
                  sprintf "type %s =" comp.MethodName |> indent indentLevel

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
                [ "[<AutoOpen;Erase>]" |> indent indentLevel
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
        let enumAndCustomPropsForComponent (comp: Component) indentLevel =
            let propsEnumOverloadsAndCustomOverloads =
                comp.Props
                |> List.choose (fun p ->
                    match p.EnumOverloads, p.CustomOverloads with
                    | [], [] -> None
                    | _ -> Some (p, p.EnumOverloads, p.CustomOverloads))

            if propsEnumOverloadsAndCustomOverloads.IsEmpty  then
                []
            else
                [ for prop, overloads, customOverloads in propsEnumOverloadsAndCustomOverloads do
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
                    for overload in customOverloads do
                        yield!
                            if List.isEmpty overload.DocLines then prop.DocLines
                            else overload.DocLines
                            |> List.map
                                (String.prefix "/// "
                                 >> String.trim
                                 >> indent (indentLevel + 2))
                        yield! singlePropCustomOverload overload |> List.map (indent (indentLevel + 2))
                    "" ]

        /// Gets all prop strings for a component
        let rec propsForComponent indentStart (comp: Component) =
            let regularProps = regularNonExtensionPropsForComponent comp indentStart
            let regularExtensionProps = regularExtensionPropsForComponent comp indentStart
            let enumAndCustomProps = enumAndCustomPropsForComponent comp indentStart

            [ if not regularProps.IsEmpty then
                yield! regularProps
                ""
              if not regularExtensionProps.IsEmpty then
                  yield! regularExtensionProps
                  ""
              if enumAndCustomProps.Length > 0 then
                  sprintf "[<Erase;RequireQualifiedAccess>]" |> indent indentStart
                  sprintf "module %s =" comp.MethodName |> indent indentStart
              yield! enumAndCustomProps ]

        let propHeadStrings (strFun: string -> string) (filterFun: string -> bool) (comp: Component) =
            let propStr (prop: Prop) =
                if not prop.RegularOverloads.IsEmpty || not prop.EnumOverloads.IsEmpty then
                    prop.ParentNameTree
                    |> List.tryHead
                    |> Option.bind (fun res ->
                        if filterFun res then None
                        else strFun res |> List.singleton |> Some)
                    |> function
                    | Some res -> res
                    | None -> []
                else []

            comp.Props |> List.collect propStr

        /// Builds the interface strings from a `Component list`
        let buildInterfaces (comps: Component list) (manualInterfaces: string list) =
            let baseInterfaceStr s = sprintf "type I%sProperty = interface end" s |> indent 1

            let filterFun s = List.contains s manualInterfaces

            comps
            |> List.collect (propHeadStrings baseInterfaceStr filterFun)
            |> List.distinct
            |> List.sort

        /// Builds the interop strings from a `Component list`
        let buildInterops (comps: Component list) (preludeInterfaces: string list) (postludeInterfaces: string list) =
            let baseInteropStr s =
                sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)" s s
                |> indent 1

            let allManualInterfaces = preludeInterfaces @ postludeInterfaces

            let filterFun s =
                List.contains s allManualInterfaces

            let compInterop =
                comps
                |> List.collect (propHeadStrings baseInteropStr filterFun)
                |> List.distinct
                |> List.sort

            [ yield! preludeInterfaces |> List.map baseInteropStr
              yield! compInterop
              yield! postludeInterfaces |> List.map baseInteropStr ]

        let rec buildCustomPropType (indentLevel: int) (isInline: bool) (propType: CustomPropertyType) =
            let props =
                propType.Properties
                |> List.map (fun value ->
                    sprintf "static member inline %s = unbox<I%sProperty> \"%s\""
                        value (String.upperFirst propType.Name) value
                    |> indent indentLevel)

            let enums = [
                for propOverload in propType.Enums do
                    yield! propOverload.DocLines
                           |> List.map
                              (String.prefix "/// "
                               >> String.trim
                               >> indent indentLevel)
                    yield
                        sprintf "static member %s%s %s= Interop.mk%sAttr \"%s\" %s"
                            (if propOverload.IsInline then "inline "
                             else "")
                            propOverload.MethodName
                            (match propOverload.ParamsCode with
                             | Some s -> s + " "
                             | None -> "")
                            (String.upperFirst propType.ParentNameTree.Head)
                            propType.ActualName
                            propOverload.ValueCode
                        |> indent indentLevel
            ]

            let funcs =
                propType.Functions
                |> List.collect (fun (docs, value) ->
                    [ if System.String.IsNullOrEmpty docs |> not then
                        sprintf "/// %s" docs |> indent indentLevel
                      value |> indent indentLevel ])
                |> List.append enums

            let children =
                propType.Children
                |> List.map (buildCustomPropType (indentLevel + 1) isInline >> String.concat Environment.NewLine)
                |> function
                | [] -> []
                | children ->
                    [ ""
                      "[<Erase;RequireQualifiedAccess>]"
                      sprintf "module %s =" propType.Name
                      yield! children ]

            [ if isInline then "[<Erase>]" |> indent (indentLevel - 1)
              sprintf "type %s =" propType.Name |> indent (indentLevel - 1)
              yield! props
              yield! funcs
              yield! children ]

    /// Generate the interop file
    let interopDocument (api: ComponentApi) =
        let makeInterop s =
            sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)" s s

        let preludeInterfaces =
            api.TypePrelude
            |> List.map fst

        let postludeInterfaces =
            api.TypePostlude
            |> List.map fst

        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          "open Fable.Core"
          ""
          "[<Erase;RequireQualifiedAccess>]"
          "module Interop ="
          makeInterop api.ComponentContainerTypeName |> indent 1
          yield! GetLines.buildInterops api.Components preludeInterfaces postludeInterfaces
          "" ]
        |> String.concat Environment.NewLine

    /// Generate the interfaces type file
    let typesDocument (api: ComponentApi) =
        let buildCustomInterfaceName name =
            sprintf "I%sProperty" name

        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          "open Fable.Core"
          "open System.ComponentModel"
          ""
          "[<AutoOpen;EditorBrowsable(EditorBrowsableState.Never);Erase>]"
          "module Types ="
          sprintf "type I%sProperty = interface end" api.ComponentContainerTypeName |> indent 1
          if not api.TypePrelude.IsEmpty then
              for (interfaceName, interfaceBody) in api.TypePrelude do
                  sprintf "type %s = %s" (buildCustomInterfaceName interfaceName) interfaceBody |> indent 1
          yield! (GetLines.buildInterfaces api.Components (api.TypePrelude @ api.TypePostlude |> List.map fst) |> List.distinct)
          if not api.TypePostlude.IsEmpty then
              for (interfaceName, interfaceBody) in api.TypePostlude do
                  sprintf "type %s = %s" (buildCustomInterfaceName interfaceName) interfaceBody |> indent 1
          "" ]
        |> String.concat Environment.NewLine

    /// Generate custom defined properties with chunking if enabled.
    let customPropsDocument (chunk: bool) (api: ComponentApi) =
        let buildDoc (comps: CustomPropertyType list) =
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
              for customPropTypes in comps do
                  yield! GetLines.buildCustomPropType 1 true customPropTypes
                  "" ]
            |> String.concat Environment.NewLine

        if api.CustomPropertyTypes.IsEmpty then []
        else
            if chunk then
                api.CustomPropertyTypes
                |> List.map (fun comp ->
                    comp.Name,
                    comp
                    |> List.singleton
                    |> buildDoc)
            else
                [ "CustomProps", buildDoc api.CustomPropertyTypes ]

    /// Generate the base level Plotly component file.
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
          "open Feliz"
          ""
          if not api.ComponentsPrelude.IsEmpty then
              "[<AutoOpen;EditorBrowsable(EditorBrowsableState.Never)>]"
              sprintf "module %sHelpers =" api.ComponentContainerTypeName
              ""
              yield! api.ComponentsPrelude
              ""
          if not api.BindingsPrelude.IsEmpty then
              "[<Erase>]"
              sprintf "type %s =" (api.ComponentContainerTypeName |> String.lowerFirst)
              for doc, cont in api.BindingsPrelude do
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

    /// Builds the props documents with chunking if enabled.
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

    /// Builds the props documents with chunking if enabled.
    let localesDocument (api: ComponentApi) (localeType: CustomPropertyType) =
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
          yield! GetLines.buildCustomPropType 1 false localeType
          "" ]
        |> String.concat Environment.NewLine
