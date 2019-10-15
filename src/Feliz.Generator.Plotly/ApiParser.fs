namespace Fable.Plotly.Generator

open FSharp.Data
open FSharp.Data.JsonExtensions
open Domain

module ParserUtils =
    open Fake.IO
    open Fake.IO.FileSystemOperators

    let schema =
        File.readAsString (__SOURCE_DIRECTORY__ @@ "../../paket-files/generator/plotly/plotly.js/dist/plot-schema.json")
        |> JsonValue.Parse

    let isObj (jVal: JsonValue) =
        jVal
        |> JsonValue.tryGetProp "role"
        |> Option.map (JsonValue.asString >> ((=) "object"))
        |> function
        | Some b -> b
        | None -> false

    let getObjDoc (jVal: JsonValue) =
        jVal.TryGetProperty("meta")
        |> Option.bind (JsonValue.tryGetProp "description")
        |> Option.map JsonValue.asString
        |> Option.toList

    let getPropDoc (jVal: JsonValue) =
        jVal.TryGetProperty("description")
        |> Option.map JsonValue.asString
        |> Option.toList

    let getDocs (jVal: JsonValue) =
        if isObj jVal then getObjDoc jVal
        else getPropDoc jVal
        |> List.map (fun s -> s.Trim().Trim('"'))
        |> List.filter (fun s -> s <> "")

    [<RequireQualifiedAccess>]
    type ValType =
        | Any
        | Bool
        | DataArray
        | Enumerated
        | EnumeratedWithCustom
        | InfoArray of ValType
        | Int
        | List of ValType
        | Number
        | NumList of ValType
        | String
        | Component

    [<RequireQualifiedAccess>]
    type PropType =
        | Val of ValType
        | Component of PropType list

    module ValType =
        [<AutoOpen>]
        module private Impl =
            let boolStr = "(value: bool)", "value"
            let boolSeqStr = "(values: seq<bool>)", "values"
            let stringStr = "(value: string)", "value"
            let stringSeqStr = "(values: seq<string>)", "values"
            let intStr = "(value: int)", "value"
            let intSeqStr = "(values: seq<int>)", "values"
            let floatStr = "(value: float)", "value"
            let floatSeqStr = "(values: seq<float>)", "values"

            let getPrimativeOverloadSeq =
                function
                | ValType.Bool -> [ boolSeqStr ]
                | ValType.Int -> [ intSeqStr ]
                | ValType.Number -> [ intSeqStr; floatSeqStr ]
                | ValType.String -> [ stringSeqStr ]
                | ValType.Enumerated -> []
                | ValType.Any -> [ boolSeqStr; intSeqStr; floatSeqStr; stringSeqStr ]
                | s ->
                    printfn "%s" (s.ToString())
                    [ "(value: TODO)", "value" ]

        let rec getType propName (jVal: JsonValue) =
            let hasValType = jVal.TryGetProperty("valType").IsSome

            let isEnumeratedWithCustom() =
                let jValHasRegex =
                    jVal?values.AsArray()
                    |> Array.filter (fun s -> s.AsString() |> String.containsRegex)
                    |> Array.length > 1

                jVal?valType.AsString() = "enumerated" && jValHasRegex

            match propName, hasValType with
            | "scaleanchor", true -> ValType.String
            | "overlaying", true when isEnumeratedWithCustom() -> ValType.EnumeratedWithCustom
            | "anchor", true when isEnumeratedWithCustom() -> ValType.EnumeratedWithCustom
            | "matches", true when jVal?valType.AsString() = "enumerated" -> ValType.String
            | _, true ->
                match jVal?valType
                      |> JsonValue.asString
                      |> fun s -> s.Trim('"') with
                | "angle" -> ValType.Number
                | "any" -> ValType.Any
                | "boolean" -> ValType.Bool
                | "color" -> ValType.String
                | "colorlist" -> ValType.List ValType.String
                | "colorscale" -> ValType.List ValType.String
                | "data_array" -> ValType.DataArray
                | "enumerated" -> ValType.Enumerated
                | "flaglist" -> ValType.List ValType.String
                | "info_array" ->
                    if jVal?items.AsArray().Length < 1 then jVal?items
                    else jVal?items.AsArray().[0]
                    |> getType propName
                    |> ValType.InfoArray
                | "integer" -> ValType.Int
                | "number" -> ValType.Number
                | "string" -> ValType.String
                | "subplotid" -> ValType.List ValType.String
                | _ -> ValType.Any
            | _ -> ValType.Component

        let getOverloadStrings =
            function
            | ValType.Any -> [ boolStr; boolSeqStr; stringStr; stringSeqStr; intStr; intSeqStr; floatStr; floatSeqStr ]
            | ValType.Bool -> [ boolStr ]
            | ValType.DataArray -> [ boolSeqStr; stringSeqStr; intSeqStr; floatSeqStr ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedWithCustom -> [ stringStr ]
            | ValType.InfoArray vt ->
                match vt with
                | ValType.List vtPrim -> vtPrim
                | _ -> vt
                |> getPrimativeOverloadSeq
            | ValType.Int -> [ intStr ]
            | ValType.List vt -> getPrimativeOverloadSeq vt
            | ValType.Number -> [ intStr; floatStr ]
            | ValType.NumList vt -> getPrimativeOverloadSeq vt
            | ValType.String -> [ stringStr ]
            | ValType.Component -> []

        let isPrimative (vType: ValType) =
            match vType with
            | ValType.Enumerated
            | ValType.EnumeratedWithCustom
            | ValType.Component -> false
            | _ -> true

module rec ApiParser =
    open ParserUtils

    let parseProp componentTree propName (jVal: JsonValue) =
        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let propType = ValType.getType propName jVal

        let propOverloads = ValType.getOverloadStrings propType |> List.map (fun s -> s ||> RegularPropOverload.create)

        let enumOverloads =
            if propType = ValType.Enumerated then
                jVal?values.AsArray()
                |> Array.map JsonValue.asString
                |> List.ofArray
            elif propType = ValType.EnumeratedWithCustom then
                jVal?values.AsArray()
                |> Array.choose (fun j ->
                    match j |> JsonValue.asString with
                    | s when String.containsRegex s -> None
                    | s -> Some s)
                |> List.ofArray
            else
                []
            |> List.map (fun v ->
                let methodName =
                    v
                    |> emptStringToNone
                    |> trimJson
                    |> fixMethodNameOperators propMethodName
                    |> dashStringToDash
                    |> spaceCaseTokebabCase
                    |> kebabCaseToCamelCase
                    |> replaceAddSymbol
                    |> prefixUnderscoreOrNegativeToNumbers
                    |> appendApostropheToReservedKeywords
                EnumPropOverload.create methodName v)

        let nestedComponents =
            let skipTypes = [ "type"; "meta"; "categories"; "role"; "editType"; "animatable"; "role"; "editType" ]
            match propName, propType with
            | "transforms", ValType.Component ->
                [ parseComponent (componentTree @ [ propName ]) propName schema?transforms ]
            | t, ValType.Component when List.contains t skipTypes -> []
            | _, ValType.Component -> [ parseComponent (componentTree @ [ propName ]) propName jVal ]
            | _ -> []

        let addRegularOverloads prop = (prop, propOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

        let addEnumOverloads prop = (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

        let addComponents prop = (prop, nestedComponents) ||> Seq.fold (flip Prop.addComponent)

        Prop.create propName propMethodName
        |> Prop.setDocs (getDocs jVal)
        |> Prop.addParentComponentTree
            (if propType |> ValType.isPrimative then componentTree
             else (componentTree @ [ propName ]))
        |> addRegularOverloads
        |> addEnumOverloads
        |> addComponents

    let parseComponent (parentTree: string list) (componentName: string) (jVal: JsonValue) =
        let skipComp = [ "_deprecated"; "items"; "_isSubplotObj" ]

        let chunkAttributes (props: (string * JsonValue) []) =
            props
            |> Array.collect
                (Array.singleton
                 >> (fun prop ->
                 match prop |> Array.head with
                 | attribs when (attribs |> fst) = "attributes" || (attribs |> fst) = "layoutAttributes" ->
                     attribs
                     |> snd
                     |> fun j -> j.Properties
                 | _ -> prop)
                 >> (Array.filter (fun p -> Array.contains (fst p) (skipComp |> Array.ofList) |> not)))

        let props =
            jVal.Properties
            |> Array.filter (fun (name, _) -> List.contains name skipComp |> not)
            |> chunkAttributes
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
                    [ sprintf "(createObj !!(properties @ [ Interop.mkData%sAttr \"type\" \"%s\" ]))" (traceType |> String.upperFirst) componentName
                      sprintf "(properties @ [ (true, [ Interop.mkData%sAttr \"type\" \"%s\" ]) ] |> Bindings.Internal.withConditionals)" (traceType |> String.upperFirst) componentName ]

                let paramFuns =
                    [ sprintf "(properties: I%sProperty list)";
                      sprintf "(properties: (bool * I%sProperty list) list)" ]

                comp.Overloads 
                |> List.map2 ComponentOverload.setPropsCode propsCodes
                |> List.map2 ComponentOverload.setParamFun paramFuns
                |> List.map (ComponentOverload.setSkipAttr true)
                |> fun overloads -> { comp with Overloads = overloads }
            | _ -> comp

    let parseApi() =
        let components =
            [ schema?config |> parseComponent [ "Config" ] "config"
              schema?layout |> parseComponent [ "Layout" ] "layout"
              schema?traces |> parseComponent [ "Data" ] "data" ]

        let addAllComponents api = (api, components) ||> List.fold (flip ComponentApi.addComponent)

        let bindings =
            [ "Create a Plotly plot component.",
              "static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.Internal.createPlot (createObj !!props)" ]

        let typePostlude =
            [ "Create the plotly data sets",
              "static member inline data (properties: #IDataProperty list) : IPlotProperty = unbox (properties |> Array.ofList)"
              "Create the plotly data sets",
              "static member data (properties: (bool * IDataProperty list) list)  : IPlotProperty = unbox (properties |> Bindings.Internal.withConditionalsAsArray)"
              "Create the plotly config",
              "static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr \"config\" (createObj !!properties)"
              "Create the plotly config",
              "static member config (properties: (bool * IConfigProperty list) list) = Interop.mkPlotAttr \"config\" (properties |> Bindings.Internal.withConditionals)"
              "Create the plotly layout",
              "static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr \"layout\" (createObj !!properties)"
              "Create the plotly layout",
              "static member layout (properties: (bool * ILayoutProperty list) list) = Interop.mkPlotAttr \"layout\" (properties |> Bindings.Internal.withConditionals)"
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
              "Styles the <div> into which the plot is rendered",
              "static member style (properties: (bool * IStyleAttribute list) list) = Interop.mkAttr \"style\" (properties |> Bindings.Internal.withConditionals)"
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
