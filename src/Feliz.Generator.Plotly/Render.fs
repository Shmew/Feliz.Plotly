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
            let attrValue = prop.ParentNameTree |> List.head
            let bodyCode =
                match propOverload.BodyCode with
                | ValueExprOnly expr -> sprintf "Interop.mk%sAttr \"%s\" %s" attrValue prop.RealPropName expr
                | CustomBody code -> code
            sprintf "static member %s%s %s = %s"
                (if propOverload.IsInline then "inline "
                 else "") prop.MethodName propOverload.ParamsCode bodyCode |> List.singleton

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropEnumOverload (prop: Prop) (propOverload: EnumPropOverload) =
            sprintf "static member %s%s %s= Interop.mk%sAttr \"%s\" %s"
                (if propOverload.IsInline then "inline "
                 else "") propOverload.MethodName
                (match propOverload.ParamsCode with
                 | Some s -> s + " "
                 | None -> "") (prop.ParentNameTree.Head) prop.RealPropName propOverload.ValueCode
            |> emptStringToNone
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
                [ for prop, overloads in propsAndEnumOverloads do
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

            [ if not regularProps.IsEmpty then
                yield! regularProps
                ""
              if not regularExtensionProps.IsEmpty then
                  yield! regularExtensionProps
                  ""
              if enumProps.Length > 0 then
                  sprintf "[<AutoOpen>]" |> indent indentStart
                  sprintf "module %s =" comp.MethodName |> indent indentStart
              yield! enumProps ]

        let propHeadStrings (strFun: string -> string) (comp: Component) =
            let propStr (prop: Prop) =
                if not prop.RegularOverloads.IsEmpty || not prop.EnumOverloads.IsEmpty then
                    prop.ParentNameTree
                    |> List.head
                    |> strFun
                    |> List.singleton
                else
                    []

            comp.Props |> List.collect propStr

        /// Builds the interface strings from a `Component list`
        let buildInterfaces (comps: Component list) =
            let baseInterfaceStr s = sprintf "type I%sProperty = interface end" s |> indent 1

            comps
            |> List.collect (propHeadStrings baseInterfaceStr)
            |> List.distinct
            |> List.sort

        /// Builds the interop strings from a `Component list`
        let buildInterops (comps: Component list) =
            let baseInteropStr s =
                sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)" s s
                |> indent 1

            comps
            |> List.collect (propHeadStrings baseInteropStr)
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
