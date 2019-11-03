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

    let traceChildren =
        schema?traces.Properties
        |> Array.map fst
        |> List.ofArray

module rec ApiParser =
    open ParserUtils

    /// Parses a `JsonValue` with given information and returns a `Prop`
    let parseProp componentTree propName (jVal: JsonValue) =
        let jumpArray = [ "annotations"; "dimensions" ]

        let isSkip =
            [ "meta"; "categories"; "animatable"; "type"; "layoutAttributes"; "requiredOpts"; "otherOpts"; "valType"; "transform" ]
            |> List.contains propName

        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> snakeCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let propType = 
            match (componentTree |> List.rev |> List.head), propName with
            | "Line", "color"
            | "Line", "width" ->
                { PrimSpecOverrides.empty with
                    ArrayOk = true, true }
            | _ -> PrimSpecOverrides.empty
            |> fun overs -> ValType.getType propName overs jVal

        let propOverloads =
            if isSkip then
                []
            else
                ValType.getOverloadStrings
                    (componentTree
                     |> List.rev
                     |> List.head) (propMethodName |> String.upperFirst) propType
                |> List.map (fun (paramsCode, valueCode) ->
                    if List.contains propMethodName traceChildren && componentTree
                                                                     |> List.head = "Traces" then
                        (paramsCode,
                         sprintf "(createObj !!(properties @ [ unbox (Interop.mk%sAttr \"type\" \"%s\") ]))"
                             (propMethodName |> String.upperFirst) propMethodName) ||> RegularPropOverload.create
                    elif List.contains propMethodName jumpArray then
                        (paramsCode, "(properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)")
                        ||> RegularPropOverload.create
                    else RegularPropOverload.create paramsCode valueCode)

        let enumOverloads =
            match propType with
            | ValType.Enumerated
            | ValType.EnumeratedArray ->
                jVal?values.AsArray()
                |> Array.map JsonValue.asString
                |> List.ofArray
            | ValType.EnumeratedWithCustom ->
                jVal?values.AsArray()
                |> Array.map (fun j ->
                    match j |> JsonValue.asString with
                    | s when String.containsRegex s -> "custom"
                    | s -> s)
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
            |> List.map (fun v ->
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
                | ValType.EnumeratedWithCustom when v = "custom" ->
                    let paramsCode, valueCode = ValType.stringStr

                    EnumPropOverload.create methodName valueCode |> EnumPropOverload.setParamsCode paramsCode
                | _ -> EnumPropOverload.create methodName (sprintf "\"%s\"" (trimJson v)))
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
            |> Array.choose (fun (pName, pJ) ->
                if pJ.TryGetProperty("description")
                   |> Option.map (fun j -> j.AsString().Contains("deprecated"))
                   |> Option.defaultValue false
                then None
                else parseProp parentTree pName pJ |> Some)
            |> Array.distinctBy (fun p -> p.MethodName)

        let addProps comp = (comp, props) ||> Array.fold (flip Component.addProp)

        Component.create componentName
        |> Component.setDocs (getDocs jVal)
        |> Component.addParentComponentTree parentTree
        |> addProps

    /// Parses the root schema for components with the given name returning a JsonValue of a collected set of properties
    let getAllAttributes (property: string) =
        let rec getAttributes attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> function
            | attribs when attribs
                           |> Array.filter (fun (name, j) -> name = property && j.TryGetProperty("valType").IsNone)
                           |> Array.length > 0 ->
                attribs
                |> Array.partition (fun (name, j) -> name = property && j.TryGetProperty("valType").IsNone)
                ||> fun matches others ->
                    let addedAttribList =
                        matches
                        |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                        |> Array.append attribList
                    Array.append addedAttribList (Array.collect (fun (pName, j) -> getAttributes [||] pName j) others)
            | _ ->
                Array.append attribList (Array.collect (fun (pName, j) -> getAttributes [||] pName j) jVal.Properties)

        getAttributes [||] property schema
        |> Array.collect (snd >> JsonExtensions.Properties)
        |> Array.distinct
        |> JsonValue.Record

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

        let expandIf =
            [ ("layout", "xaxis")
              ("layout", "yaxis") ]

        let rec allComponentNames (jVal: JsonValue): string list =
            let props =
                match jumps |> List.choose (jVal.TryGetProperty) with
                | j when j.Length > 0 -> (j |> List.head).Properties
                | _ -> jVal.Properties
                |> List.ofArray
                |> List.filter (fun (name, j) -> List.contains name skips
                                                 |> not
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
            |> List.collect (fun name ->
                if List.contains name (expandIf |> List.map snd) then
                    [ 2 .. 5 ]
                    |> List.map (fun i -> true, sprintf "%s%i" name i)
                    |> List.append [ false, name ]
                else
                    (false, name) |> List.singleton)

        result
        |> List.map
            (((fun (b, n) ->
              n |> fixComponentName,
              if b then n.Substring(0, (n.Length - 1))
              else n
              |> getAllAttributes
              |> fun res ->
                  if n = "layout" then
                      res.Properties
                      |> Array.append (getAllAttributes "layoutAttributes" |> JsonExtensions.Properties)
                      |> JsonValue.Record
                  else
                      res)
              >> (fun (n, j) ->
              let others, expanded =
                  j.Properties |> Array.partition (fun (propN, _) -> List.contains (n, propN) expandIf)
              others
              |> Array.collect
                  (fun (propN, propJ) -> [| 2 .. 5 |] |> Array.map (fun i -> sprintf "%s%i" propN i, propJ))
              |> Array.append expanded
              |> JsonValue.Record
              |> fun res -> n, res))
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
              "",
              "static member inline onAfterExport (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "",
              "static member inline onAfterPlot (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onAfterPlot\" handler"
              "",
              "static member inline onAnimated (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onAnimated\" handler"
              "",
              "static member inline onAnimatingFrame (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onAnimatingFrame\" handler"
              "",
              "static member inline onAnimationInterrupted (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onAnimationInterrupted\" handler"
              "",
              "static member inline onAutoSize (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onAutoSize\" handler"
              "",
              "static member inline onBeforeExport (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onBeforeExport\" handler"
              "",
              "static member inline onButtonClicked (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onButtonClicked\" handler"
              "", "static member inline onClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "",
              "static member inline onClickAnnotation (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onClickAnnotation\" handler"
              "",
              "static member inline onDeselect (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onDeselect\" handler"
              "",
              "static member inline onDoubleClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onDoubleClick\" handler"
              "",
              "static member inline onFramework (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onFramework\" handler"
              "", "static member inline onHover (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onHover\" handler"
              "",
              "static member inline onLegendClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onLegendClick\" handler"
              "",
              "static member inline onLegendDoubleClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onLegendDoubleClick\" handler"
              "",
              "static member inline onRelayout (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onRelayout\" handler"
              "",
              "static member inline onRestyle (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onRestyle\" handler"
              "",
              "static member inline onRedraw (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onRedraw\" handler"
              "",
              "static member inline onSelected (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onSelected\" handler"
              "",
              "static member inline onSelecting (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onSelecting\" handler"
              "",
              "static member inline onSliderChange (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onSliderChange\" handler"
              "",
              "static member inline onSliderEnd (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onSliderEnd\" handler"
              "",
              "static member inline onSliderStart (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onSliderStart\" handler"
              "",
              "static member inline onTransitioning (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onTransitioning\" handler"
              "",
              "static member inline onTransitionInterrupted (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onTransitionInterrupted\" handler"
              "",
              "static member inline onUnhover (handler: MouseEvent -> unit) = Interop.mkPlotAttr \"onUnhover\" handler" ]

        let api = ComponentApi.create "Feliz.Plotly" "Plot" "Plotly" bindings typePostlude |> addAllComponents

        { GeneratorComponentApi = api
          PlotlyComponents = components }
