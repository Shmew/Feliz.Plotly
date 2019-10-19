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

module rec ApiParser =
    open ParserUtils

    /// Parses a `JsonValue` with given information and returns a `Prop`
    let parseProp componentTree propName (jVal: JsonValue) =
        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> snakeCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let propType = ValType.getType propName jVal

        let propOverloads = ValType.getOverloadStrings propType |> List.map (fun s -> s ||> RegularPropOverload.create)

        let enumOverloads =
            match propType with
            | ValType.Enumerated
            | ValType.EnumeratedArray
                ->
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
                    |> List.allCombinations
                    |> List.map (List.map (JsonValue.asString >> trimJson) >> (String.concat "+"))
                let extras =
                    match jVal.TryGetProperty("extras") with
                    | Some extras -> extras.AsArray() |> List.ofArray |> List.map (JsonValue.asString)
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
                    
                    EnumPropOverload.create methodName valueCode
                    |> EnumPropOverload.setParamsCode paramsCode
                | _ -> EnumPropOverload.create methodName (sprintf "\"%s\"" (trimJson v)))
            |> List.distinct

        let nestedComponents =
            let skipTypes = [ "type"; "meta"; "categories"; "role"; "editType"; "animatable"; "role"; "items"]
            match propName, propType with
            | "transforms", ValType.Component ->
                [ parseComponent (componentTree @ [ propName ]) propName schema?transforms ]
            | t, ValType.Component when List.contains t skipTypes -> []
            | _, ValType.Component -> [ parseComponent (componentTree @ [ propName ]) propName jVal ]
            | _ -> []

        let addRegularOverloads prop = (prop, propOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

        let addEnumOverloads prop = (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

        let addComponents prop = (prop, nestedComponents) ||> Seq.fold (flip Prop.addComponent)

        Prop.create propType propName propMethodName
        |> Prop.setDocs (getDocs jVal)
        |> Prop.addParentComponentTree
            (if propType |> ValType.isPrimative then componentTree
             else (componentTree @ [ propName ]))
        |> addRegularOverloads
        |> addEnumOverloads
        |> addComponents

    /// Parses a `JsonValue` with given information and returns a `Component`
    let parseComponent (parentTree: string list) (componentName: string) (jVal: JsonValue) =
        let skipComp = [ "_deprecated"; "_isSubplotObj" ]
        let jumpComp = [ "attributes"; "layoutAttributes"; "items" ]
        let jumpArrayComp = [ "annotations" ]

        let jumpAttributes (props: (string * JsonValue) []) =
            props
            |> Array.collect
                (Array.singleton
                 >> (fun prop ->
                 match prop |> Array.head with
                 | attribs when List.contains (attribs |> fst) jumpComp ->
                     attribs
                     |> snd
                     |> fun j -> j.Properties
                 | _ -> prop)
                 >> (Array.filter (fun p -> Array.contains (fst p) (skipComp |> Array.ofList) |> not)))

        let props =
            jVal.Properties
            |> Array.filter (fun (name, _) -> List.contains name skipComp |> not)
            |> jumpAttributes
            |> Array.map (fun p -> p ||> parseProp parentTree)

        let addProps comp = (comp, props) ||> Array.fold (flip Component.addProp)

        Component.create componentName
        |> Component.setDocs (getDocs jVal)
        |> Component.addParentComponentTree parentTree
        |> addProps
        |> fun comp ->
            match comp.ParentNameTree.Head = "Data" && comp.ParentNameTree.Length = 2, jVal.TryGetProperty("type") with
            | true, Some t ->
                let traceType = t.AsString()
                let propsCodes =
                    [ sprintf "(createObj !!(properties @ [ Interop.mkData%sAttr \"type\" \"%s\" ]))" (traceType |> String.upperFirst) componentName ]

                let paramFuns =
                    [ sprintf "(properties: I%sProperty list)" ]

                comp.Overloads 
                |> List.map2 ComponentOverload.setPropsCode propsCodes
                |> List.map2 ComponentOverload.setParamFun paramFuns
                |> List.map (ComponentOverload.setSkipAttr true)
                |> fun overloads -> { comp with Overloads = overloads }
            | _ -> 
                if List.contains componentName jumpArrayComp then
                    let propsCode =
                        [ "(properties |> Seq.map (Bindings.getKV >> snd) |> Array.ofSeq)" ]
                    
                    comp.Overloads
                    |> List.map2 ComponentOverload.setPropsCode propsCode
                    |> fun overloads -> { comp with Overloads = overloads }
                else comp

    /// Parse the Plotly.js json schema
    let parseApi() =
        let components =
            [ schema?config |> parseComponent [ "Config" ] "config"
              schema?layout |> parseComponent [ "Layout" ] "layout"
              schema?traces |> parseComponent [ "Data" ] "data" ]

        let addAllComponents api = (api, components) ||> List.fold (flip ComponentApi.addComponent)

        let bindings =
            [ "Create a Plotly plot component.",
              "static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.createPlot (createObj !!props)" ]

        let typePostlude =
            [ "Create the plotly data sets",
              "static member inline data (properties: #IDataProperty list) = Bindings.extractData properties"
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
