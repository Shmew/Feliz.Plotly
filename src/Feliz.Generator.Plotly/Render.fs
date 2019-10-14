namespace Fable.Plotly.Generator

module Render =
    open System
    open Utils
    open Domain

    let indent numLevels = String.indent 4 numLevels

    module GetLines =
        /// static member inline data (properties: #IDataProperty list) = Interop.mkPlotAttr "Data" (createObj !!properties)

        /// Gets the code lines for the implementation of a single component overload.
        /// Does not include docs.
        let singleComponentOverload (comp: Component) (interopFun: string) (compOverload: ComponentOverload) =
            sprintf "static member %s%s %s = Interop.%s \"%s\" %s"
                (if compOverload.IsInline then "inline "
                 else "") comp.MethodName compOverload.ParamsCode interopFun comp.MethodName compOverload.PropsCode
            |> List.singleton

        /// Gets the code lines for the implementation of a single regular (non-enum)
        /// prop overload. Does not include docs.
        let singlePropRegularOverload (prop: Prop) (propOverload: RegularPropOverload) =
            let bodyCode =
                match propOverload.BodyCode with
                | ValueExprOnly expr -> sprintf "Interop.mk%sAttr \"%s\" %s" prop.ParentComponentName prop.RealPropName expr
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
                 | None -> "") prop.ParentComponentName prop.RealPropName propOverload.ValueCode
            |> emptStringToNone
            |> List.singleton

        let regularNonExtensionPropsForComponent (comp: Component) indentLevel =
            let propsAndRegularNonExtensionOverloads =
                comp.Props
                |> List.choose (fun p ->
                    let regularNonExtensionOverloads = p.RegularOverloads |> List.filter (fun o -> not o.IsExtension)
                    if regularNonExtensionOverloads.IsEmpty then None
                    else Some(p, regularNonExtensionOverloads))

            if propsAndRegularNonExtensionOverloads.IsEmpty then
                []
            else
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

        let compPropsForComponent (comp: Component) =
            comp.Props
            |> List.choose (fun p ->
                if p.Components.IsEmpty then None
                else Some [ p.Components ])
            |> (List.concat >> List.concat)

        let getCompStrList comp indentLevel =
            comp.Overloads
            |> List.collect (fun overload ->
                singleComponentOverload comp
                    (comp.ParentComponentName
                     |> String.upperFirst
                     |> sprintf "mk%sAttr") overload
                |> List.map (indent (indentLevel + 1)))

        let rec propsForComponent indentStart (comp: Component) =
            let regularProps = regularNonExtensionPropsForComponent comp indentStart
            let regularExtensionProps = regularExtensionPropsForComponent comp indentStart
            let enumProps = enumPropsForComponent comp indentStart

            let compProps = compPropsForComponent comp |> List.collect (propsForComponent (indentStart + 1))

            [ if not regularProps.IsEmpty then
                yield! regularProps
                ""
              if not regularExtensionProps.IsEmpty then
                  yield! regularExtensionProps
                  ""
              if enumProps.Length + compProps.Length > 0 then
                  sprintf "module %s =" comp.MethodName |> indent indentStart
              yield! enumProps
              yield! compProps ]

        let rec subComponentsForComponent depth (comp: Component) =
            let actualDepth = depth + 1

            let compComps = compPropsForComponent comp |> List.collect (subComponentsForComponent actualDepth)

            if depth = 0 then []
            else [ comp ]
            |> List.append compComps

        let private getComponentsDistinct (comps: Component list) =
            comps
            |> List.collect (subComponentsForComponent 0)
            |> List.append comps
            |> List.distinctBy (fun c -> c.MethodName)

        let private getComponents (comps: Component list) =
            comps
            |> List.collect compPropsForComponent
            |> List.append comps
            |> List.distinct

        let buildComponentsForComponent (comps: Component list) =
            let buildLine comp overload =
                singleComponentOverload comp
                    ((comp.MethodName |> String.upperFirst)
                     |> sprintf "mk%sAttr") overload

            comps
            |> getComponents
            |> List.collect (fun c -> c.Overloads |> List.collect (buildLine c))
            |> List.map (indent 1)

        let buildInterfaces (comps: Component list) =
            let interfaceStr (comp: Component) =
                [ sprintf "type I%sProperty = interface end" (comp.MethodName |> String.upperFirst)
                  "" ]

            comps
            |> getComponentsDistinct
            |> List.collect interfaceStr

        let buildInterops (comps: Component list) =
            let interopStr (comp: Component) =
                sprintf "let inline mk%sAttr (key: string) (value: obj) : I%sProperty = unbox (key, value)" (comp.MethodName |> String.upperFirst) comp.ParentComponentName
                |> indent 1

            comps
            |> getComponentsDistinct
            |> List.map interopStr

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

    let typesDocument (api: ComponentApi) =
        [ sprintf "namespace %s" api.Namespace
          ""
          "(*////////////////////////////////"
          "/// THIS FILE IS AUTO-GENERATED //"
          "////////////////////////////////*)"
          ""
          sprintf "type I%sProperty = interface end" api.ComponentContainerTypeName
          ""
          yield! GetLines.buildInterfaces api.Components
          "" ]
        |> String.concat Environment.NewLine

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
          "[<Erase>]"
          sprintf "type %s =" api.ComponentContainerTypeName
          yield! GetLines.buildComponentsForComponent api.Components
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
          if api.Bindings.Length > 0 then
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

    let propsDocument (chunk: bool) (api: ComponentApi) =
        let buildDoc (comps: Component list) =
            [ sprintf "namespace %s" api.Namespace
              ""
              "(*////////////////////////////////"
              "/// THIS FILE IS AUTO-GENERATED //"
              "////////////////////////////////*)"
              ""
              "open System"
              "open Browser.Types"
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
