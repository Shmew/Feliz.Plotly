namespace Fable.Plotly.Generator

open FSharp.Data
open FSharp.Data.JsonExtensions
open Domain

module ParserUtils =
    open Fake.IO
    open Fake.IO.FileSystemOperators

    /// The Plotly.js schema
    let schema =
        File.readAsString (__SOURCE_DIRECTORY__ @@ "../../paket-files/generator/plotly/plotly.js/dist/plot-schema.json")
        |> JsonValue.Parse

    /// Returns `true` if the `JsonValue` is a component
    let private isComp (jVal: JsonValue) =
        jVal
        |> JsonValue.tryGetProp "role"
        |> Option.map (JsonValue.asString >> ((=) "object"))
        |> function
        | Some b -> b
        | None -> false

    /// Gets the description from the specified `JsonValue` when it is a component
    let private getCompDoc (jVal: JsonValue) =
        jVal.TryGetProperty("meta")
        |> Option.bind (JsonValue.tryGetProp "description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the description from the specified `JsonValue` when it is a prop
    let private getPropDoc (jVal: JsonValue) =
        jVal.TryGetProperty("description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the documentation of a specified `JsonValue`
    let getDocs (jVal: JsonValue) =
        if isComp jVal then getCompDoc jVal
        else getPropDoc jVal
        |> List.map (fun s -> s.Trim().Trim('"'))
        |> List.filter (fun s -> s <> "")

    let trimBypass (s: string) =
        if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7)
        else s

    let trimBypassWith (s: string) trueFun falseFun =
        if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7) |> trueFun
        else falseFun s

    let skips =
        schema?defs?metaKeys.AsArray()
        |> Array.toList
        |> List.map (JsonValue.asString >> trimJson)

    let traceChildrenWithJson =
        schema?traces.Properties

    let traceChildren =
        traceChildrenWithJson
        |> Array.map fst
        |> List.ofArray

    let transformsChildren =
        schema?transforms.Properties
        |> Array.map fst
        |> List.ofArray

    let hasEnums (jVal: JsonValue) =
        jVal.TryGetProperty("valType")
        |> Option.map (JsonExtensions.AsString >> ((=) "enumerated"))
        |> Option.defaultValue false
            
    /// Gets anchor static mapping attributes
    let layoutAnchorMappings (compName: string) (propName: string) =
        [ "polar"; "geo"; "mapbox"; "ternary" ] 
        |> List.tryFind compName.Contains
        |> function
        | _ when propName = "xaxes" || propName = "yaxes" -> {| Value = propName; Array = true |}
        | _ when propName.StartsWith "x" || propName.StartsWith "y" -> {| Value = propName.Substring(0,1); Array = false |}
        | _ when List.contains propName [ "coloraxis"; "scene" ] -> {| Value = propName; Array = false |}
        | _ when compName = "Choropleth" && propName = "geo" -> {| Value = propName; Array = false |}
        | Some aName -> {| Value = aName; Array = false |}
        | _ -> failwith "Invalid anchor mapping call."

module rec ApiParser =
    open ParserUtils

    let manualDeprecated = 
        [ ("layout", [ "radialaxis"; "angularaxis" ]) ]

    let isManualDeprecated componentName (name: string) =
        match List.filter (fst >> fun n -> n = componentName) manualDeprecated with
        | fList when fList.Length > 0 -> 
            fList 
            |> List.exists (snd >> List.exists (fun n -> n = name)) 
        | _ -> false

    /// Filter all JsonValue properties if deprecated
    let parseWithfilterDeprecated componentName parentTree (props: (string * JsonValue) []) =
        props
        |> Array.choose (fun (pName, pJ) ->
            if pJ.TryGetProperty("description")
               |> Option.map (fun j -> j.AsString().Contains("deprecated!"))
               |> Option.defaultValue false || pName = "_deprecated" 
               || isManualDeprecated componentName pName
            then None
            else parseProp parentTree pName pJ |> Some)

    /// Parses a `JsonValue` with given information and returns a `Prop`
    let parseProp componentTree propName (jVal: JsonValue) =
        let jumpArray = [ "annotations"; "dimensions"; "styles"; "transforms" ]
        let typeAdders = [ "Traces"; "Transforms" ]
        let typeAdderChildren = traceChildren @ transformsChildren

        let isSkip =
            [ "meta"; "categories"; "animatable"; "type"; "layoutAttributes"; "requiredOpts"; "otherOpts"; "valType"; "transform" ]
            |> List.contains propName

        let isExpanded =
            let isExpandedLayout = 
                [ "xaxis"; "yaxis"; "geo"; "ternary"; "polar"; "mapbox"; "coloraxis"; "scene" ]
                |> List.contains propName 

            match (componentTree
                   |> List.rev
                   |> List.head), propName with
            | "Layout", _ when isExpandedLayout -> true
            | _ -> false

        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> snakeCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let componentParent = componentTree |> List.rev |> List.head

        let mNameUpper = propMethodName |> String.upperFirst

        let axisInt axisIdentity isArray =
            if isArray then
                [ ValType.intSeqStrCustom "anchorIds"
                    (sprintf "anchorIds |> Seq.map (fun anchorId -> (sprintf \"%s%s\" %s) |> ResizeArray)" axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")")
                  ValType.intStrCustom "anchorId"
                    (sprintf "(sprintf \"%s%s\" %s |> Array.singleton |> ResizeArray)" axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")") ]
            else
                ValType.intStrCustom "anchorId"
                    (sprintf "(sprintf \"%s%s\" %s)" axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")")
                |> List.singleton

        let propType =
            let isPropAxis = 
                [ "xaxis"; "yaxis"; "subplot"; "geo"; "coloraxis"; "scene" ]
                |> List.contains propName

            match componentParent, propName with
            | "Line", "color"
            | "Line", "width" -> { PrimSpecOverrides.empty with ArrayOk = true, true }
            | "Style", "value" ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          schema?traces
                          |> JsonExtensions.Properties
                          |> Array.map
                              (fst
                               >> String.upperFirst
                               >> ValType.compStrExplicit)
                          |> List.ofArray }
            | _, "theta" -> { PrimSpecOverrides.empty with IsCalcType = true, false }
            | _ when componentParent <> "Layout" && isPropAxis ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          layoutAnchorMappings componentParent propName
                          |> fun res -> axisInt res.Value res.Array }
            | _ when isExpanded ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          let pNameUpper = propName |> String.upperFirst
                          [ pNameUpper |> ValType.compStrExplicitExpanded ] }
            | _ -> PrimSpecOverrides.empty
            |> fun overs -> ValType.getType propName overs jVal

        let propOverloads =
            if isSkip then
                []
            else
                let explicitOverloadStrings =
                    ValType.getExplicitOverloadStrings propType
                    |> fun expOverStrs ->
                        if isExpanded then
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) ->
                                let bodyCode =
                                    sprintf "Interop.mk%sAttr %s %s" componentParent
                                        (sprintf "(sprintf \"%s%s\" id)" propMethodName "%i") valueCode
                                RegularPropOverload.createCustom paramsCode bodyCode)
                        else
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) -> RegularPropOverload.create paramsCode valueCode)

                ValType.getOverloadStrings componentParent mNameUpper propType
                |> List.map (fun (paramsCode, valueCode) ->
                    if List.contains propMethodName typeAdderChildren
                       && List.contains (componentTree |> List.head) typeAdders then
                        (paramsCode,
                         sprintf "(createObj !!(properties @ [ unbox (Interop.mk%sAttr \"type\" \"%s\") ]))"
                             (propMethodName |> String.upperFirst) propMethodName) ||> RegularPropOverload.create
                    elif List.contains propMethodName jumpArray then
                        (paramsCode, "(properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)")
                        ||> RegularPropOverload.create
                    else RegularPropOverload.create paramsCode valueCode)
                |> List.append explicitOverloadStrings

        let enumOverloads =
            let isAnchorOrOverlay =
                (componentParent = "Xaxis" || componentParent = "Yaxis") 
                    && (propName = "overlaying" || propName = "anchor" || propName = "scaleanchor")

            let isXAxisRef = [ "xref"; "axref" ] |> List.contains propName
            let isYAxisRef = [ "yref"; "ayref" ] |> List.contains propName

            match propType with
            | ValType.Enumerated
            | ValType.EnumeratedArray ->
                jVal?values.AsArray()
                |> Array.map JsonValue.asString
                |> List.ofArray
            | ValType.EnumeratedWithCustom ->
                jVal?values.AsArray()
                |> Array.collect (fun j ->
                    match j |> JsonValue.asString with
                    | s when String.containsRegex s && isAnchorOrOverlay -> [| "x"; "y" |]
                    | s when String.containsRegex s && isXAxisRef -> [| "x" |]
                    | s when String.containsRegex s && isYAxisRef -> [| "y" |]
                    | s when String.containsRegex s -> [||]
                    | s -> s |> Array.singleton)
                |> Array.append [| "custom" |]
                |> List.ofArray
            | ValType.FlagList ->
                let flagCombinations =
                    jVal?flags.AsArray()
                    |> List.ofArray
                    |> List.map (JsonValue.asString >> trimJson)

                let extras =
                    match jVal.TryGetProperty("extras") with
                    | Some extras ->
                        extras.AsArray()
                        |> List.ofArray
                        |> List.map (JsonValue.asString)
                    | None -> []

                extras @ flagCombinations
            | _ -> []
            |> List.sort
            |> List.collect (fun v ->
                let methodName =
                    v
                    |> emptStringToNone
                    |> trimJson
                    |> replaceAddSymbol
                    |> fixMethodNameOperators propMethodName
                    |> dashStringToDash
                    |> spaceCaseTokebabCase
                    |> kebabCaseToCamelCase
                    |> snakeCaseToCamelCase
                    |> prefixUnderscoreOrNegativeToNumbers
                    |> appendApostropheToReservedKeywords

                match propType with
                | ValType.EnumeratedWithCustom when (isAnchorOrOverlay || isXAxisRef || isYAxisRef ) && (v = "x" || v = "y") ->
                    axisInt v false 
                    |> List.unzip
                    ||> List.map2 (fun paramsCode valueCode ->
                        EnumPropOverload.create methodName valueCode
                        |> EnumPropOverload.setParamsCode paramsCode)
                | ValType.EnumeratedWithCustom when v = "custom" && componentParent = "Line" && propName = "dash" ->
                    let valueCode, paramsCode = [ ValType.intSeqResizeStr; ValType.floatSeqResizeStr ] |> List.unzip

                    paramsCode
                    |> List.map2
                        (fun pCode vCode ->
                        EnumPropOverload.create methodName vCode |> EnumPropOverload.setParamsCode pCode) valueCode

                | ValType.EnumeratedWithCustom when v = "custom" ->
                    let paramsCode, valueCode = ValType.stringStr

                    EnumPropOverload.create methodName valueCode
                    |> EnumPropOverload.setParamsCode paramsCode
                    |> List.singleton
                | _ ->
                    match v with
                    | "true"
                    | "false" -> sprintf "%s" (trimJson v)
                    | _ -> sprintf "\"%s\"" (trimJson v)
                    |> EnumPropOverload.create methodName
                    |> List.singleton)
            |> List.distinct

        let addRegularOverloads prop = (prop, propOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

        let addEnumOverloads prop = (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

        Prop.create propType propName propMethodName
        |> Prop.setDocs (getDocs jVal)
        |> Prop.addParentComponentTree
            (if propType |> ValType.isPrimative then componentTree
             else (componentTree @ [ propName ]))
        |> addRegularOverloads
        |> addEnumOverloads

    /// Parses a `JsonValue` with given information and returns a `Component`
    let parseComponent (parentTree: string list) (componentName: string) (jVal: JsonValue) =
        let jumpComp = [ "attributes"; "items"; "traces" ]
        let jumpCompIf = [ ("Layout", "layoutAttributes") ]
        let parentTree = parentTree |> List.map trimBypass

        let rec performJumps (name: string) (j: JsonValue) =
            if List.contains name jumpComp then j.Properties |> Array.collect (fun (name, j) -> performJumps name j)
            else (name, j) |> Array.singleton

        let filterAttributes (props: (string * JsonValue) []) =
            let isJumpCompIf name =
                List.contains name (jumpCompIf |> List.map snd)
                && List.contains parentTree.Head (jumpCompIf |> List.map fst)

            props
            |> Array.collect
                (Array.singleton
                 >> (fun prop ->
                 match prop |> Array.head with
                 | attribs when attribs
                                |> fst
                                |> isJumpCompIf ->
                     attribs
                     |> snd
                     |> fun j -> j.Properties
                 | (name, j) when List.contains name jumpComp -> performJumps name j
                 | _ -> prop)
                 >> (fun prop ->
                 prop
                 |> Array.filter
                     (fun p ->
                     Array.contains (fst p)
                         ((skips |> List.filter (fun skip -> List.contains skip (jumpCompIf |> List.map snd) |> not))
                          |> Array.ofList) |> not)))

        let props =
            jVal.Properties
            |> filterAttributes
            |> parseWithfilterDeprecated componentName parentTree
            |> Array.distinctBy (fun p -> p.MethodName)

        let addProps comp = (comp, props) ||> Array.fold (flip Component.addProp)

        Component.create componentName
        |> Component.setDocs (getDocs jVal)
        |> Component.addParentComponentTree parentTree
        |> addProps

    /// Parses the root schema for enumerated values with the given component name and enum name returning a JsonValue of the collected values.
    let getAllEnumAttributes (property: string) (enumName: string) =
        let rec getEnumValues attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) -> name = enumName && j |> hasEnums && parent = property)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                Array.append addedAttribList (Array.collect (fun (pName, j) -> getEnumValues [||] pName j) others)

        getEnumValues [||] property schema
        |> (Array.collect (snd >> JsonExtensions.Properties)
            >> Array.collect (fun (name, jVal) ->
                if name = "values" then jVal.AsArray()
                else [||]))
        |> Array.distinct
        |> JsonValue.Array

    /// Parses given JsonValue for components with the given name returning a JsonValue of a collected set of properties.
    let getAttributesOf (source: JsonValue) (property: string) =
        let rec getAttributes attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) -> name = property && j.TryGetProperty("valType").IsNone)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                Array.append addedAttribList (Array.collect (fun (pName, j) -> getAttributes [||] pName j) others)

        getAttributes [||] property source
        |> Array.collect (snd >> JsonExtensions.Properties)
        |> Array.distinct
        |> Array.map (fun (name, jVal) ->
            if jVal |> hasEnums then
                let fullEnums = getAllEnumAttributes property name
                jVal.Properties
                |> Array.map (fun (n, j) ->
                    if n = "values" then (n, fullEnums)
                    else (n, j))
                |> JsonValue.Record
                |> fun newJ -> (name, newJ)
            else
                (name, jVal))
        |> JsonValue.Record

    /// Parses the root schema for components with the given name returning a JsonValue of a collected set of properties.
    let getAllAttributes (property: string) = getAttributesOf schema property

    /// Gets a list of all components within the schema with their collected properties
    let getAllComponents() =
        let fixComponentName =
            trimJson
            >> spaceCaseTokebabCase
            >> kebabCaseToCamelCase
            >> snakeCaseToCamelCase
            >> replaceAddSymbol
            >> appendApostropheToReservedKeywords

        let jumps = [ "attributes"; "items"; "layoutAttributes" ]
        let subLayouts = [ "ternary"; "geo"; "mapbox"; "polar" ]

        let rec allComponentNames (jVal: JsonValue): string list =
            let props =
                match jumps |> List.choose (jVal.TryGetProperty) with
                | j when j.Length > 0 -> (j |> List.head).Properties
                | _ -> jVal.Properties
                |> List.ofArray
                |> List.filter (fun (name, j) -> 
                    List.contains name skips |> not
                        && j.TryGetProperty("valType").IsNone)

            let newNames =
                props
                |> List.map fst
                |> List.distinct

            props
            |> List.collect (fun (name, j) ->
                if j.TryGetProperty("valType").IsNone then allComponentNames j
                else [ name ])
            |> List.append newNames
            |> List.distinct

        let result =
            let schemaSkips = [ "defs" ]
            let compSkips = [ "type"; "transform" ]

            schema.Properties
            |> Array.filter (fun (name, _) -> List.contains name schemaSkips |> not)
            |> JsonValue.Record
            |> allComponentNames
            |> List.filter (fun name -> List.contains name compSkips |> not)
            |> List.distinct

        result
        |> List.map
            (((fun n ->
             n |> fixComponentName,
             getAllAttributes n
             |> fun res ->
                 match n, List.filter ((=) n) subLayouts with
                 | "layout", _ ->
                     res.Properties
                     |> Array.append (getAllAttributes "layoutAttributes" |> JsonExtensions.Properties)
                     |> JsonValue.Record
                 | _, subL when subL.Length > 0 ->
                     traceChildrenWithJson
                     |> Array.choose (fun (traceName, traceJson) ->
                         if traceName.Contains(n) then
                             getAttributesOf traceJson "layoutAttributes"
                             |> JsonExtensions.Properties
                             |> Some
                         else None)
                     |> Array.concat
                     |> Array.distinct
                     |> Array.append res.Properties
                     |> JsonValue.Record
                 | _ -> res))
             >> (fun (n, j) ->
                match List.filter (fun (name, _) -> name = n) manualDeprecated |> List.collect snd with
                | res when res.Length > 0 ->
                    n,
                    j.Properties |> Array.filter (fun (pName, _) -> List.contains pName res |> not)
                    |> JsonValue.Record
                | _ -> (n,j))
             >> (fun (n, j) -> parseComponent [ n |> String.upperFirst ] n j))

    /// Parse the Plotly.js json schema
    let parseApi() =
        let components = getAllComponents()

        let addAllComponents api = (api, components) ||> List.fold (flip ComponentApi.addComponent)

        let bindings =
            [ "Create a Plotly plot component.",
              "static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.createPlot (createObj !!props)" ]

        let typePostlude =
            [ "Create the plotly traces",
              "static member inline traces (properties: #ITracesProperty list) = Bindings.extractTraces properties"
              "Create the plotly config",
              "static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr \"config\" (createObj !!properties)"
              "Create the plotly layout",
              "static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr \"layout\" (createObj !!properties)"
              "When provided, causes the plot to update when the revision is incremented.",
              "static member inline revision (value: int) = Interop.mkPlotAttr \"revision\" value"
              "When provided, causes the plot to update when the revision is incremented.",
              "static member inline revision (value: float) = Interop.mkPlotAttr \"revision\" value"
              "Callback executed after plot is initialized.",
              "static member inline onInitialized (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr \"onInitialized\" handler"
              "Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.",
              "static member inline onUpdate (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr \"onUpdate\" handler"
              "Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.",
              "static member inline onPurge (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr \"onPurge\" handler"
              "Callback executed when a plotly.js API method rejects",
              "static member inline onError (handler: ErrorEvent -> unit) = Interop.mkPlotAttr \"onError\" handler"
              "Id assigned to the <div> into which the plot is rendered.",
              "static member inline divId (value: string) = Interop.mkPlotAttr \"divId\" value"
              "Class applied to the <div> into which the plot is rendered",
              "static member inline className (value: string) = Interop.mkPlotAttr \"className\" value"
              "Styles the <div> into which the plot is rendered",
              "static member inline style (properties: #IStyleAttribute list) = Interop.mkAttr \"style\" (createObj !!properties)"
              "Assign the graph div to window.gd for debugging",
              "static member inline debug (value: bool) = Interop.mkPlotAttr \"debug\" value"
              "When true, adds a call to Plotly.Plot.resize() as a window.resize event handler",
              "static member inline useResizeHandler (value: bool) = Interop.mkPlotAttr \"useResizeHandler\" value"
              "", "static member inline onAfterExport (handler: unit -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "",
              "static member inline onAfterPlot (handler: unit -> unit) = Interop.mkPlotAttr \"onAfterPlot\" handler"
              "", "static member inline onAnimated (handler: unit -> unit) = Interop.mkPlotAttr \"onAnimated\" handler"
              "",
              "static member inline onAnimatingFrame (handler: Bindings.FrameAnimationEvent -> unit) = Interop.mkPlotAttr \"onAnimatingFrame\" handler"
              "",
              "static member inline onAnimationInterrupted (handler: unit -> unit) = Interop.mkPlotAttr \"onAnimationInterrupted\" handler"
              "", "static member inline onAutoSize (handler: unit -> unit) = Interop.mkPlotAttr \"onAutoSize\" handler"
              "",
              "static member inline onBeforeExport (handler: unit -> unit) = Interop.mkPlotAttr \"onBeforeExport\" handler"
              "",
              "static member inline onButtonClicked (handler: Bindings.ButtonClickEvent -> unit) = Interop.mkPlotAttr \"onButtonClicked\" handler"
              "",
              "static member inline onClick (handler: Bindings.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "",
              "static member inline onClickAnnotation (handler: Bindings.ClickAnnotationEvent -> unit) = Interop.mkPlotAttr \"onClickAnnotation\" handler"
              "", "static member inline onDeselect (handler: unit -> unit) = Interop.mkPlotAttr \"onDeselect\" handler"
              "",
              "static member inline onDoubleClick (handler: unit -> unit) = Interop.mkPlotAttr \"onDoubleClick\" handler"
              "",
              "static member inline onFramework (handler: unit -> unit) = Interop.mkPlotAttr \"onFramework\" handler"
              "",
              "static member inline onHover (handler: Bindings.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onHover\" handler"
              "",
              "static member inline onLegendClick (handler: Bindings.LegendClickEvent -> unit) = Interop.mkPlotAttr \"onLegendClick\" handler"
              "",
              "static member inline onLegendDoubleClick (handler: Bindings.LegendClickEvent -> unit) = Interop.mkPlotAttr \"onLegendDoubleClick\" handler"
              "",
              "static member inline onRelayout (handler: Bindings.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr \"onRelayout\" handler"
              "",
              "static member inline onRestyle (handler: Bindings.PlotRestyleEvent -> unit) = Interop.mkPlotAttr \"onRestyle\" handler"
              "", "static member inline onRedraw (handler: unit -> unit) = Interop.mkPlotAttr \"onRedraw\" handler"
              "",
              "static member inline onSelected (handler: Bindings.PlotSelectionEvent -> unit) = Interop.mkPlotAttr \"onSelected\" handler"
              "",
              "static member inline onSelecting (handler: Bindings.PlotSelectionEvent -> unit) = Interop.mkPlotAttr \"onSelecting\" handler"
              "",
              "static member inline onSliderChange (handler: Bindings.SliderChangeEvent -> unit) = Interop.mkPlotAttr \"onSliderChange\" handler"
              "",
              "static member inline onSliderEnd (handler: Bindings.SliderEndEvent -> unit) = Interop.mkPlotAttr \"onSliderEnd\" handler"
              "",
              "static member inline onSliderStart (handler: Bindings.SliderStartEvent -> unit) = Interop.mkPlotAttr \"onSliderStart\" handler"
              "",
              "static member inline onTransitioning (handler: unit -> unit) = Interop.mkPlotAttr \"onTransitioning\" handler"
              "",
              "static member inline onTransitionInterrupted (handler: unit -> unit) = Interop.mkPlotAttr \"onTransitionInterrupted\" handler"
              "",
              "static member inline onUnhover (handler: Bindings.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onUnhover\" handler" ]

        let api = ComponentApi.create "Feliz.Plotly" "Plot" "Plotly" bindings typePostlude |> addAllComponents

        { GeneratorComponentApi = api
          PlotlyComponents = components }
