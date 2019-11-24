namespace Feliz.Plotly

module rec Bindings =
    open Browser.Types
    open Fable.Core
    open Fable.Core.JsInterop
    open Fable.React
    open System

    let plotly: obj = importAll "plotly.js/dist/plotly"
    let plotFactory: obj -> obj = importDefault "react-plotly.js/factory.js"
    let plotComponent = plotFactory plotly
    let createPlot props: ReactElement = 
        ReactBindings.React.createElement (plotComponent, props, [])
    
    let getKV value : string * obj = unbox value

    let extractTraces (properties: #ITracesProperty list) =
        properties 
        |> List.map (getKV >> snd) 
        |> ResizeArray 
        |> Interop.mkPlotAttr "data"
                    
    type [<AllowNullLiteral>] StaticPlots =
        abstract resize: root: Root -> unit
    
    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set
    
    type [<AllowNullLiteral>] PlotScatterDataPoint =
        abstract curveNumber: float with get, set
        abstract data: PlotData with get, set
        abstract pointIndex: float with get, set
        abstract pointNumber: float with get, set
        abstract x: float with get, set
        abstract xaxis: LayoutAxis with get, set
        abstract y: float with get, set
        abstract yaxis: LayoutAxis with get, set
    
    type [<AllowNullLiteral>] PlotDatum =
        abstract curveNumber: float with get, set
        abstract data: PlotData with get, set
        abstract pointIndex: float with get, set
        abstract pointNumber: float with get, set
        abstract x: Datum with get, set
        abstract xaxis: LayoutAxis with get, set
        abstract y: Datum with get, set
        abstract yaxis: LayoutAxis with get, set
    
    type [<AllowNullLiteral>] PlotMouseEvent =
        abstract points: ResizeArray<PlotDatum> with get, set
        abstract ``event``: MouseEvent with get, set
    
    type [<AllowNullLiteral>] PlotCoordinate =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract pointNumber: float with get, set
    
    type [<AllowNullLiteral>] SelectionRange =
        abstract x: ResizeArray<float> with get, set
        abstract y: ResizeArray<float> with get, set
    
    type PlotSelectedData = obj
    
    type [<AllowNullLiteral>] PlotSelectionEvent =
        abstract points: ResizeArray<PlotDatum> with get, set
        abstract range: SelectionRange option with get, set
        abstract lassoPoints: SelectionRange option with get, set
    
    type PlotRestyleEvent = obj option * ResizeArray<float>
    
    type [<AllowNullLiteral>] PlotAxis =
        abstract range: float * float with get, set
        abstract autorange: bool with get, set
    
    type [<AllowNullLiteral>] PlotScene =
        abstract center: Point with get, set
        abstract eye: Point with get, set
        abstract up: Point with get, set
    
    type [<AllowNullLiteral>] PlotRelayoutEvent =
        abstract xaxis: PlotAxis with get, set
        abstract yaxis: PlotAxis with get, set
        abstract scene: PlotScene with get, set
    
    type [<AllowNullLiteral>] ClickAnnotationEvent =
        abstract index: float with get, set
        abstract annotation: Annotations with get, set
        abstract fullAnnotation: Annotations with get, set
        abstract ``event``: MouseEvent with get, set
    
    type [<AllowNullLiteral>] FrameAnimationEvent =
        abstract name: string with get, set
        abstract frame: Frame with get, set
        abstract animation: Animation with get, set
    
    type [<AllowNullLiteral>] LegendClickEvent =
        abstract ``event``: MouseEvent with get, set
        abstract node: PlotlyHTMLElement with get, set
        abstract curveNumber: float with get, set
        abstract expandedIndex: float with get, set
        abstract data: ResizeArray<Data> with get, set
        abstract layout: obj with get, set
        abstract frames: ResizeArray<Frame> with get, set
        abstract config: obj with get, set
        abstract fullData: ResizeArray<Data> with get, set
        abstract fullLayout: obj with get, set
    
    type [<AllowNullLiteral>] SliderChangeEvent =
        abstract slider: Slider with get, set
        abstract step: SliderStep with get, set
        abstract interaction: bool with get, set
        abstract previousActive: float with get, set
    
    type [<AllowNullLiteral>] SliderStartEvent =
        abstract slider: Slider with get, set
    
    type [<AllowNullLiteral>] SliderEndEvent =
        abstract slider: Slider with get, set
        abstract step: SliderStep with get, set
    
    type [<AllowNullLiteral>] BeforePlotEvent =
        abstract data: ResizeArray<Data> with get, set
        abstract layout: obj with get, set
        abstract config: obj with get, set
    
    type [<AllowNullLiteral>] PlotlyHTMLElement =
        inherit HTMLElement
        abstract on: ``event``: U3<string, string, string> * callback: (PlotMouseEvent -> unit) -> unit
        abstract on: ``event``: U2<string, string> * callback: (PlotSelectionEvent -> unit) -> unit
        [<Emit "$0.on('plotly_restyle',$1)">] abstract on_plotly_restyle: callback: (PlotRestyleEvent -> unit) -> unit
        [<Emit "$0.on('plotly_relayout',$1)">] abstract on_plotly_relayout: callback: (PlotRelayoutEvent -> unit) -> unit
        [<Emit "$0.on('plotly_clickannotation',$1)">] abstract on_plotly_clickannotation: callback: (ClickAnnotationEvent -> unit) -> unit
        [<Emit "$0.on('plotly_animatingframe',$1)">] abstract on_plotly_animatingframe: callback: (FrameAnimationEvent -> unit) -> unit
        abstract on: ``event``: U2<string, string> * callback: (LegendClickEvent -> bool) -> unit
        [<Emit "$0.on('plotly_sliderchange',$1)">] abstract on_plotly_sliderchange: callback: (SliderChangeEvent -> unit) -> unit
        [<Emit "$0.on('plotly_sliderend',$1)">] abstract on_plotly_sliderend: callback: (SliderEndEvent -> unit) -> unit
        [<Emit "$0.on('plotly_sliderstart',$1)">] abstract on_plotly_sliderstart: callback: (SliderStartEvent -> unit) -> unit
        [<Emit "$0.on('plotly_event',$1)">] abstract on_plotly_event: callback: (obj option -> unit) -> unit
        [<Emit "$0.on('plotly_beforeplot',$1)">] abstract on_plotly_beforeplot: callback: (BeforePlotEvent -> bool) -> unit
        abstract on: ``event``: obj * callback: (unit -> unit) -> unit
        abstract removeAllListeners: (string -> unit) with get, set
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type ImageFormat =
        | Jpeg
        | Png
        | Webp
        | Svg
    
    type [<AllowNullLiteral>] ToImgopts =
        abstract format: ImageFormat with get, set
        abstract width: float with get, set
        abstract height: float with get, set
    
    type [<AllowNullLiteral>] DownloadImgopts =
        abstract format: ImageFormat with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract filename: string with get, set
    
    type Root = U2<string, HTMLElement>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Root =
        let ofString v: Root = v |> U2.Case1
        let isString (v: Root) = match v with U2.Case1 _ -> true | _ -> false
        let asString (v: Root) = match v with U2.Case1 o -> Some o | _ -> None
        let ofHTMLElement v: Root = v |> U2.Case2
        //let isHTMLElement (v: Root) = match v with U2.Case2 _ -> true | _ -> false
        //let asHTMLElement (v: Root) = match v with U2.Case2 o -> Some o | _ -> None
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type XAnchor =
        | Left
        | Center
        | Right
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type YAnchor =
        | Top
        | Center
        | Right
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type XAnchorAuto =
        | Auto
        | Left
        | Center
        | Right
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type YAnchorAuto =
        | Auto
        | Top
        | Center
        | Right
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Layout =
        [<StringEnum>]
        type Direction =
            | Clockwise
            | CounterClockwise
    
        [<StringEnum>]
        type DragMode =
            | Zoom
            | Pan
            | Select
            | Lasso
            | Orbit
            | Turntable
    
        [<StringEnum>]
        type BarMode =
            | Stack
            | Group
            | Overlay
            | Relative
    
        [<StringEnum>]
        type SelectDirection =
            | H
            | V
            | D
            | Any
    
    type [<AllowNullLiteral>] Layout =
        abstract title: U2<string, obj> with get, set
        abstract titlefont: obj with get, set // Partial<Font>
        abstract autosize: bool with get, set
        abstract showlegend: bool with get, set
        abstract paper_bgcolor: Color with get, set
        abstract plot_bgcolor: Color with get, set
        abstract separators: string with get, set
        abstract hidesources: bool with get, set
        abstract xaxis: obj with get, set // Partial<LayoutAxis> for all *axis methods
        abstract xaxis2: obj with get, set
        abstract xaxis3: obj with get, set
        abstract xaxis4: obj with get, set
        abstract xaxis5: obj with get, set
        abstract xaxis6: obj with get, set
        abstract xaxis7: obj with get, set
        abstract xaxis8: obj with get, set
        abstract xaxis9: obj with get, set
        abstract yaxis: obj with get, set
        abstract yaxis2: obj with get, set
        abstract yaxis3: obj with get, set
        abstract yaxis4: obj with get, set
        abstract yaxis5: obj with get, set
        abstract yaxis6: obj with get, set
        abstract yaxis7: obj with get, set
        abstract yaxis8: obj with get, set
        abstract yaxis9: obj with get, set
        abstract margin: obj with get, set // Partial<Margin>
        abstract height: float with get, set
        abstract width: float with get, set
        abstract hovermode: U4<string, string, string, obj> with get, set
        abstract hoverlabel: obj with get, set // Partial<HoverLabel>
        abstract calendar: Calendar with get, set
        abstract ``xaxis.range``: Datum * Datum with get, set
        abstract ``xaxis.range[0]``: Datum with get, set
        abstract ``xaxis.range[1]``: Datum with get, set
        abstract ``yaxis.range``: Datum * Datum with get, set
        abstract ``yaxis.range[0]``: Datum with get, set
        abstract ``yaxis.range[1]``: Datum with get, set
        abstract ``yaxis.type``: AxisType with get, set
        abstract ``xaxis.type``: AxisType with get, set
        abstract ``xaxis.autorange``: bool with get, set
        abstract ``yaxis.autorange``: bool with get, set
        abstract ternary: TypeLiteral_03 with get, set
        abstract geo: TypeLiteral_03 with get, set
        abstract mapbox: TypeLiteral_03 with get, set
        abstract radialaxis: obj with get, set // Partial<Axis>
        abstract angularaxis: TypeLiteral_03 with get, set
        abstract direction: Layout.Direction with get, set
        abstract dragmode: Layout.DragMode with get, set
        abstract orientation: float with get, set
        abstract annotations: Annotations [] with get, set // Array<Partial<Annotations>>
        abstract shapes: obj [] with get, set // Array<Partial<Shape>>
        abstract images: obj [] with get, set // Array<Partial<Image>>
        abstract updatemenus: TypeLiteral_03 with get, set
        abstract sliders: obj [] with get, set // Array<Partial<Slider>>
        abstract legend: obj with get, set // Partial<Legend>
        abstract font: obj with get, set // Partial<Font>
        abstract scene: obj with get, set // Partial<Scene>
        abstract barmode: Layout.BarMode with get, set
        abstract bargap: float with get, set
        abstract bargroupgap: float with get, set
        abstract selectdirection: Layout.SelectDirection with get, set
    
    type [<AllowNullLiteral>] Legend =
        inherit Label
        abstract traceorder: U3<string, string, string> with get, set
        abstract x: float with get, set
        abstract y: float with get, set
        abstract borderwidth: float with get, set
        abstract orientation: U2<string, string> with get, set
        abstract tracegroupgap: float with get, set
        abstract xanchor: XAnchorAuto with get, set
        abstract yanchor: YAnchorAuto with get, set
    
    [<StringEnum; RequireQualifiedAccess>]
    type AxisType =
        | [<CompiledName "-">]  Dash
        | Linear
        | Log
        | Date
        | Category
    
    [<StringEnum; RequireQualifiedAccess>]
    type TickMode =
        | Auto
        | Linear
        | Array
    
    [<StringEnum; RequireQualifiedAccess>]
    type Ticks =
        | Outside
        | Inside
        | [<CompiledName "">] None
    
    [<StringEnum; RequireQualifiedAccess>]
    type ShowOptions =
        | All
        | First
        | Last
        | None
    
    [<StringEnum; RequireQualifiedAccess>]
    type ExponentFormat =
        | None
        | [<CompiledName "e">] LowerE
        | [<CompiledName "E">] UpperE
        | Power
        | SI
        | B
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Axis =
        [<StringEnum; RequireQualifiedAccess>]
        type RangeMode =
            | Normal
            | [<CompiledName "tozero">] ToZero
            | [<CompiledName "nonnegative">] NonNegative
    
        [<StringEnum; RequireQualifiedAccess>]
        type Mirror =
            | Ticks
            | All
            | [<CompiledName "allticks">] AllTicks
    
        [<StringEnum; RequireQualifiedAccess>]
        type CategoryOrder =
            | Trace
            | [<CompiledName "category ascending">] Ascending
            | [<CompiledName "category descending">] Descending
            | Array
    
        [<StringEnum; RequireQualifiedAccess>]
        type Constrain =
            | Range
            | Domain
    
        [<StringEnum; RequireQualifiedAccess>]
        type ConstrainToward =
            | Left
            | Center
            | Right
            | Top
            | Middle
            | Bottom
    
        [<StringEnum; RequireQualifiedAccess>]
        type Name =
            | X | X2 | X3 | X4 | X5 | X6 | X7 | X8 | X9
            | Y | Y2 | Y3 | Y4 | Y5 | Y6 | Y7 | Y8 | Y9
    
        [<StringEnum; RequireQualifiedAccess>]
        type Positioning =
            | Free 
            | X | X2 | X3 | X4 | X5 | X6 | X7 | X8 | X9
            | Y | Y2 | Y3 | Y4 | Y5 | Y6 | Y7 | Y8 | Y9
    
        [<StringEnum; RequireQualifiedAccess>]
        type Side =
            | Top
            | Bottom
            | Left
            | Right
    
        [<StringEnum; RequireQualifiedAccess>]
        type Layer =
            | [<CompiledName "above traces">] AboveTraces
            | [<CompiledName "below traces">] BelowTraces
    
    type [<AllowNullLiteral>] Axis =
        abstract visible: bool with get, set
        abstract color: Color with get, set
        abstract title: string with get, set
        abstract titlefont: obj with get, set
        abstract ``type``: AxisType with get, set
        abstract autorange: U2<bool, string> with get, set
        abstract rangemode: Axis.RangeMode with get, set
        abstract range: ResizeArray<obj option> with get, set
        abstract tickmode: TickMode with get, set
        abstract nticks: float with get, set
        abstract tick0: U2<float, string> with get, set
        abstract dtick: U2<float, string> with get, set
        abstract tickvals: ResizeArray<obj option> with get, set
        abstract ticktext: ResizeArray<string> with get, set
        abstract ticks: Ticks with get, set
        abstract mirror: U2<bool, Axis.Mirror> with get, set
        abstract ticklen: float with get, set
        abstract tickwidth: float with get, set
        abstract tickcolor: Color with get, set
        abstract showticklabels: bool with get, set
        abstract showspikes: bool with get, set
        abstract spikecolor: Color with get, set
        abstract spikethickness: float with get, set
        abstract categoryorder: U4<string, string, string, string> with get, set
        abstract categoryarray: ResizeArray<obj option> with get, set
        abstract tickfont: obj with get, set
        abstract tickangle: float with get, set
        abstract tickprefix: string with get, set
        abstract showtickprefix: ShowOptions with get, set
        abstract ticksuffix: string with get, set
        abstract showticksuffix: ShowOptions with get, set
        abstract showexponent: ShowOptions with get, set
        abstract exponentformat: ExponentFormat with get, set
        abstract separatethousands: bool with get, set
        abstract tickformat: string with get, set
        abstract hoverformat: string with get, set
        abstract showline: bool with get, set
        abstract linecolor: Color with get, set
        abstract linewidth: float with get, set
        abstract showgrid: bool with get, set
        abstract gridcolor: Color with get, set
        abstract gridwidth: float with get, set
        abstract zeroline: bool with get, set
        abstract zerolinecolor: Color with get, set
        abstract zerolinewidth: float with get, set
        abstract calendar: Calendar with get, set
    
    type [<StringEnum; RequireQualifiedAccess>] Calendar =
        | Gregorian
        | Chinese
        | Coptic
        | Discworld
        | Ethiopian
        | Hebrew
        | Islamic
        | Julian
        | Mayan
        | Nanakshahi
        | Nepali
        | Persian
        | Jalali
        | Taiwan
        | Thai
        | Ummalqura
    
    type [<AllowNullLiteral>] LayoutAxis =
        inherit Axis
        abstract fixedrange: bool with get, set
        abstract scaleanchor: Axis.Name with get, set
        abstract scaleratio: float with get, set
        abstract constrain: Axis.Constrain with get, set
        abstract constraintoward: Axis.ConstrainToward with get, set
        abstract spikedash: string with get, set
        abstract spikemode: string with get, set
        abstract anchor: Axis.Positioning with get, set
        abstract side: Axis.Side with get, set
        abstract overlaying: Axis.Positioning with get, set
        abstract layer: Axis.Layer with get, set
        abstract domain: ResizeArray<float> with get, set
        abstract position: float with get, set
        abstract rangeslider: obj with get, set
        abstract rangeselector: obj with get, set
        abstract automargin: bool with get, set
    
    type [<AllowNullLiteral>] SceneAxis =
        inherit Axis
        abstract spikesides: bool with get, set
        abstract showbackground: bool with get, set
        abstract backgroundcolor: Color with get, set
        abstract showaxeslabels: bool with get, set
    
    type [<AllowNullLiteral>] ShapeLine =
        abstract color: string with get, set
        abstract width: float with get, set
        abstract dash: Dash with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Shape =
        [<StringEnum; RequireQualifiedAccess>]
        type Layer =
            | Below
            | Above
    
        [<StringEnum; RequireQualifiedAccess>]
        type Type =
            | Rect
            | Circle
            | Line
            | Path
    
        [<StringEnum; RequireQualifiedAccess>]
        type Xref =
            | X
            | Paper
    
        [<StringEnum; RequireQualifiedAccess>]
        type Yref =
            | Y
            | Paper
    
    type [<AllowNullLiteral>] Shape =
        abstract visible: bool with get, set
        abstract layer: Shape.Layer with get, set
        abstract ``type``: Shape.Type with get, set
        abstract path: string with get, set
        abstract xref: Shape.Xref with get, set
        abstract yref: Shape.Yref with get, set
        abstract x0: Datum with get, set
        abstract y0: Datum with get, set
        abstract x1: Datum with get, set
        abstract y1: Datum with get, set
        abstract fillcolor: string with get, set
        abstract opacity: float with get, set
        abstract line: obj with get, set
    
    type [<AllowNullLiteral>] Margin =
        abstract t: float with get, set
        abstract b: float with get, set
        abstract l: float with get, set
        abstract r: float with get, set
    
    type [<StringEnum; RequireQualifiedAccess>] ModeBarDefaultButtons =
        | Lasso2d
        | Select2d
        | SendDataToCloud
        | AutoScale2d
        | Zoom2d
        | Pan2d
        | ZoomIn2d
        | ZoomOut2d
        | ResetScale2d
        | HoverClosestCartesian
        | HoverCompareCartesian
        | Zoom3d
        | Pan3d
        | OrbitRotation
        | TableRotation
        | ResetCameraDefault3d
        | ResetCameraLastSave3d
        | HoverClosest3d
        | ZoomInGeo
        | ZoomOutGeo
        | ResetGeo
        | HoverClosestGeo
        | HoverClosestGl2d
        | HoverClosestPie
        | ToggleHover
        | ToImage
        | ResetViews
        | ToggleSpikelines
    
    type [<AllowNullLiteral>] ButtonClickEvent =
        [<Emit "$0($1...)">] abstract Invoke: gd: PlotlyHTMLElement * ev: MouseEvent -> unit
    
    type [<AllowNullLiteral>] Icon =
        abstract width: float with get, set
        abstract path: string with get, set
        abstract ascent: float with get, set
        abstract descent: float with get, set
    
    type [<AllowNullLiteral>] ModeBarButton =
        /// name / id of the buttons (for tracking) 
        abstract name: string with get, set
        /// text that appears while hovering over the button,
        /// enter null, false or '' for no hover text
        abstract title: string with get, set
        /// svg icon object associated with the button
        /// can be linked to Plotly.Icons to use the default plotly icons
        abstract icon: U2<string, Icon> with get, set
        /// icon positioning 
        abstract gravity: string option with get, set
        /// click handler associated with the button, a function of
        /// 'gd' (the main graph object) and
        /// 'ev' (the event object)
        abstract click: ButtonClickEvent with get, set
        /// attribute associated with button,
        /// use this with 'val' to keep track of the state
        abstract attr: string option with get, set
        /// initial 'attr' value, can be a function of gd 
        abstract ``val``: obj option with get, set
        /// is the button a toggle button? 
        abstract toggle: bool option with get, set
    
    type Datum =
        U3<string, float, DateTime> option
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Datum =
        let ofStringOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case1
        let ofString v: Datum = v |> U3.Case1 |> Some
        let isString (v: Datum) = match v with None -> false | Some o -> match o with U3.Case1 _ -> true | _ -> false
        let asString (v: Datum) = match v with None -> None | Some o -> match o with U3.Case1 o -> Some o | _ -> None
        let ofFloatOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case2
        let ofFloat v: Datum = v |> U3.Case2 |> Some
        let isFloat (v: Datum) = match v with None -> false | Some o -> match o with U3.Case2 _ -> true | _ -> false
        let asFloat (v: Datum) = match v with None -> None | Some o -> match o with U3.Case2 o -> Some o | _ -> None
        let ofDateTimeOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case3
        let ofDateTime v: Datum = v |> U3.Case3 |> Some
        let isDateTime (v: Datum) = match v with None -> false | Some o -> match o with U3.Case3 _ -> true | _ -> false
        let asDateTime (v: Datum) = match v with None -> None | Some o -> match o with U3.Case3 o -> Some o | _ -> None
    
    type [<AllowNullLiteral>] ErrorOptions =
        abstract visible: bool with get, set
        abstract symmetric: bool with get, set
        abstract color: Color with get, set
        abstract thickness: float with get, set
        abstract width: float with get, set
        abstract opacity: float with get, set
    
    //export type ErrorBar = Partial<ErrorOptions> & ({
        // type: 'constant' | 'percent',
        // value: number,
        // valueminus?: number
    //} | {
        // type: 'data',
        // array: Datum[],
        // arrayminus?: Datum[]
    //});
    
    type [<AllowNullLiteral>] ErrorBar =
        interface end
    
    //[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    //module ErrorBar =
    //    let ofType v: ErrorBar = v |> U6.Case1
    //    let isType (v: ErrorBar) = match v with U6.Case1 _ -> true | _ -> false
    //    let asType (v: ErrorBar) = match v with U6.Case1 o -> Some o | _ -> None
    //    let ofValue v: ErrorBar = v |> U6.Case2
    //    let isValue (v: ErrorBar) = match v with U6.Case2 _ -> true | _ -> false
    //    let asValue (v: ErrorBar) = match v with U6.Case2 o -> Some o | _ -> None
    //    let ofValueminus v: ErrorBar = v |> U6.Case3
    //    let isValueminus (v: ErrorBar) = match v with U6.Case3 _ -> true | _ -> false
    //    let asValueminus (v: ErrorBar) = match v with U6.Case3 o -> Some o | _ -> None
    //    let ofType v: ErrorBar = v |> U6.Case4
    //    let isType (v: ErrorBar) = match v with U6.Case4 _ -> true | _ -> false
    //    let asType (v: ErrorBar) = match v with U6.Case4 o -> Some o | _ -> None
    //    let ofArray v: ErrorBar = v |> U6.Case5
    //    let isArray (v: ErrorBar) = match v with U6.Case5 _ -> true | _ -> false
    //    let asArray (v: ErrorBar) = match v with U6.Case5 o -> Some o | _ -> None
    //    let ofArrayminus v: ErrorBar = v |> U6.Case6
    //    let isArrayminus (v: ErrorBar) = match v with U6.Case6 _ -> true | _ -> false
    //    let asArrayminus (v: ErrorBar) = match v with U6.Case6 o -> Some o | _ -> None
    
    [<StringEnum; RequireQualifiedAccess>]
    type Dash =
        | Solid
        | Dot
        | Dash
        | Longdash
        | Dashdot
        | Longdashdot
    
    type Data = PlotData // Partial<PlotData>
    
    type Color = U4<string, float, U2<string, float> [] option, U2<string, float> option [] []>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Color =
        let ofString v: Color = v |> U4.Case1
        let isString (v: Color) = match v with U4.Case1 _ -> true | _ -> false
        let asString (v: Color) = match v with U4.Case1 o -> Some o | _ -> None
        let ofFloat v: Color = v |> U4.Case2
        let isFloat (v: Color) = match v with U4.Case2 _ -> true | _ -> false
        let asFloat (v: Color) = match v with U4.Case2 o -> Some o | _ -> None
        let ofArray v: Color = v |> U4.Case3
        //let isArray (v: Color) = match v with U4.Case3 _ -> true | _ -> false
        //let asArray (v: Color) = match v with U4.Case3 o -> Some o | _ -> None
        let ofArray2D v: Color = v |> U4.Case4
        //let isArray2D (v: Color) = match v with U4.Case4 _ -> true | _ -> false
        //let asArray2D (v: Color) = match v with U4.Case4 o -> Some o | _ -> None
    
    type ColorScale = U3<string, ResizeArray<string>, (float * string) []>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ColorScale =
        let ofString v: ColorScale = v |> U3.Case1
        let isString (v: ColorScale) = match v with U3.Case1 _ -> true | _ -> false
        let asString (v: ColorScale) = match v with U3.Case1 o -> Some o | _ -> None
        let ofStringArray v: ColorScale = v |> U3.Case2
        let isStringArray (v: ColorScale) = match v with U3.Case2 _ -> true | _ -> false
        let asStringArray (v: ColorScale) = match v with U3.Case2 o -> Some o | _ -> None
        let ofArray v: ColorScale = v |> U3.Case3
        let isArray (v: ColorScale) = match v with U3.Case3 _ -> true | _ -> false
        let asArray (v: ColorScale) = match v with U3.Case3 o -> Some o | _ -> None
    
    type DataTransform = obj // Partial<Transform>
    
    type ScatterData = PlotData
    
    [<StringEnum; RequireQualifiedAccess>]
    type Orientation =
        | V
        | H
    
    [<StringEnum; RequireQualifiedAccess>]
    type MarkerSizeMode =
        | Diameter
        | Area
    
    [<StringEnum; RequireQualifiedAccess>]
    type LineShape =
        | Linear
        | Spline
        | Hv
        | Vh
        | Hvh
        | Vhv
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module PlotData =
        [<StringEnum; RequireQualifiedAccess>]
        type Type =
            | Bar
            | Box
            | Candlestick
            | Choropleth
            | Contour
            | Heatmap
            | Histogram
            | Mesh3d
            | Ohlc
            | Paroords
            | Pie
            | [<CompiledName "pointcloud">] PointCloud
            | Scatter
            | Scatter3d
            | [<CompiledName "scatterternary">] ScatterGeo
            | [<CompiledName "scattergl">] ScatterGL
            | [<CompiledName "scatterpolar">] ScatterPolar
            | [<CompiledName "scatterternary">] ScatterTernary
            | Surface
    
        [<StringEnum; RequireQualifiedAccess>]
        type Mode =
            | Lines
            | Markers
            | Text
            | [<CompiledName "lines+markers">] LinesAndMarkers
            | [<CompiledName "text+markers">] TextAndMarkers
            | [<CompiledName "text+lines">] TextAndLines
            | [<CompiledName "text+lines+markers">] TextLinesAndMarkers
            | None
    
        [<StringEnum; RequireQualifiedAccess>]
        type HoverOn =
            | Points
            | Fills
    
        [<StringEnum; RequireQualifiedAccess>]
        type HoverInfo =
            | All 
            | Name 
            | None 
            | Skip 
            | Text 
            | X 
            | [<CompiledName "x+text">] XAndText
            | [<CompiledName "x+name">] XAndName
            | [<CompiledName "x+y">] XAndY
            | [<CompiledName "x+y+text">] XYAndText
            | [<CompiledName "x+y+name">] XYAndName
            | [<CompiledName "x+y+z">] XYAndY
            | [<CompiledName "x+y+z+text">] XYZAndText
            | [<CompiledName "x+y+z+name">] XYZAndName
            | [<CompiledName "y+name">] YAndName
            | [<CompiledName "y+x">] YAndX
            | [<CompiledName "y+text">] YAndText
            | [<CompiledName "y+x+text">] YXAndText
            | [<CompiledName "y+x+name">] YXAndName
            | [<CompiledName "y+z">] YAndZ
            | [<CompiledName "y+z+text">] YZAndText
            | [<CompiledName "y+z+name">] YZAndName
            | [<CompiledName "y+x+z">] YXAndZ
            | [<CompiledName "y+x+z+text">] YXZAndText
            | [<CompiledName "y+x+z+name">] YXZAndName
            | [<CompiledName "z+x">] ZAndX
            | [<CompiledName "z+x+text">] ZXAndText
            | [<CompiledName "z+x+name">] ZXAndName
            | [<CompiledName "z+y+x">] ZYAndX
            | [<CompiledName "z+y+x+text">] ZYXandText
            | [<CompiledName "z+y+x+name">] ZYXAndName
            | [<CompiledName "z+x+y">] ZXAndY
            | [<CompiledName "z+x+y+text">] ZXYAndText
            | [<CompiledName "z+x+y+name">] ZXYAndName
    
        [<StringEnum; RequireQualifiedAccess>]
        type TextInfo =
            | Label 
            | [<CompiledName "label+text">] LabelAndText
            | [<CompiledName "label+value">] LabelAndValue 
            | [<CompiledName "label+percent">] LabelAndPercent
            | [<CompiledName "label+text+value">] LabelTextAndValue
            | [<CompiledName "label+text+percent">] LabelTextAndPercent
            | [<CompiledName "label+value+percent">] LabelValueAndPercent
            | Text 
            | [<CompiledName "text+value">] TextAndValue
            | [<CompiledName "text+percent">] TextAndPercent
            | [<CompiledName "text+value+percent">] TextValueAndPercent
            | Value 
            | [<CompiledName "value+percent">] ValueAndPercent
            | Percent 
            | None
    
        [<StringEnum; RequireQualifiedAccess>]
        type TextPosition =
            | TopLeft 
            | TopCenter 
            | TopRight 
            | MiddleLeft
            | MiddleCenter 
            | MiddleRight 
            | BottomLeft 
            | BottomCenter 
            | BottomRight 
            | Inside
    
        [<StringEnum; RequireQualifiedAccess>]
        type Fill =
            | None 
            | [<CompiledName "tozeroy">] ToZeroY
            | [<CompiledName "tozerox">] ToZeroX
            | [<CompiledName "tonexty">] ToNextY
            | [<CompiledName "tonextx">] ToNextX
            | [<CompiledName "toself">] ToSelf
            | [<CompiledName "tonext">] ToNext
    
        [<StringEnum; RequireQualifiedAccess>]
        type BoxMean =
            | Sd 
    
        [<StringEnum; RequireQualifiedAccess>]
        type ZSmooth =
            | Fast
            | Best
    
    type [<AllowNullLiteral>] PlotData =
        abstract ``type``: PlotData.Type with get, set
        abstract x: U3<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, 'T []> with get, set
        abstract y: U3<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, 'T []> with get, set
        abstract z: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, 'T []> with get, set
        abstract xy: obj with get, set
        abstract error_x: ErrorBar with get, set
        abstract error_y: ErrorBar with get, set
        abstract xaxis: string with get, set
        abstract yaxis: string with get, set
        abstract text: U2<string, ResizeArray<string>> with get, set
        abstract line: obj with get, set // Partial<ScatterLine>
        abstract ``line.color``: Color with get, set
        abstract ``line.width``: float with get, set
        abstract ``line.dash``: Dash with get, set
        abstract ``line.shape``: LineShape with get, set
        abstract ``line.smoothing``: float with get, set
        abstract ``line.simplify``: bool with get, set
        abstract marker: obj with get, set // Partial<PlotMarker>
        abstract ``marker.symbol``: U2<string, ResizeArray<string>> with get, set
        abstract ``marker.color``: Color with get, set
        abstract ``marker.opacity``: U2<float, ResizeArray<float>> with get, set
        abstract ``marker.size``: U2<float, ResizeArray<float>> with get, set
        abstract ``marker.maxdisplayed``: float with get, set
        abstract ``marker.sizeref``: float with get, set
        abstract ``marker.sizemax``: float with get, set
        abstract ``marker.sizemin``: float with get, set
        abstract ``marker.sizemode``: MarkerSizeMode with get, set
        abstract ``marker.showscale``: bool with get, set
        abstract ``marker.line``: obj with get, set // Partial<ScatterMarkerLine>
        abstract ``marker.colorbar``: TypeLiteral_03 with get, set
        abstract mode: PlotData.Mode with get, set
        abstract hoveron: PlotData.HoverOn with get, set
        abstract hoverinfo: PlotData.HoverInfo with get, set
        abstract hoverlabel: obj with get, set // Partial<HoverLabel>
        abstract hovertemplate: U2<string, ResizeArray<string>> with get, set
        abstract textinfo: PlotData.TextInfo with get, set
        abstract textposition: PlotData.TextPosition with get, set
        abstract fill: PlotData.Fill with get, set
        abstract fillcolor: string with get, set
        abstract legendgroup: string with get, set
        abstract name: string with get, set
        abstract stackgroup: string with get, set
        abstract connectgaps: bool with get, set
        abstract visible: U2<bool, string> with get, set
        abstract transforms: ResizeArray<DataTransform> with get, set
        abstract orientation: Orientation with get, set
        abstract width: U2<float, ResizeArray<float>> with get, set
        abstract boxmean: U2<bool, PlotData.BoxMean> with get, set
        abstract colorscale: ColorScale with get, set
        abstract zsmooth: U2<PlotData.ZSmooth, bool> with get, set
        abstract ygap: float with get, set
        abstract xgap: float with get, set
        abstract transpose: bool with get, set
        abstract autobinx: bool with get, set
        abstract xbins: XBins with get, set
        abstract values: ResizeArray<Datum> with get, set
        abstract labels: ResizeArray<Datum> with get, set
        abstract hole: float with get, set
        abstract rotation: float with get, set
        abstract theta: ResizeArray<Datum> with get, set
        abstract r: ResizeArray<Datum> with get, set
    
    /// These interfaces are based on attribute descriptions in
    /// https://github.com/plotly/plotly.js/tree/9d6144304308fc3007f0facf2535d38ea3e9b26c/src/transforms
    type [<AllowNullLiteral>] TransformStyle =
        abstract target: U4<float, string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract value: obj with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module TransformAggregation =
        [<StringEnum; RequireQualifiedAccess>]
        type Func =
            | Count
            | Sum
            | Avg
            | Median
            | Mode
            | Rms
            | Stddev
            | Min
            | Max
            | First
            | Last
    
        [<StringEnum; RequireQualifiedAccess>]
        type FuncMode =
            | Sample
            | Population
    
    type [<AllowNullLiteral>] TransformAggregation =
        abstract target: string with get, set
        abstract func: TransformAggregation.Func option with get, set
        abstract funcmode: TransformAggregation.FuncMode option with get, set
        abstract enabled: bool option with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Transform =
        [<StringEnum; RequireQualifiedAccess>]
        type Type =
            | Aggregate
            | Filter
            | [<CompiledName "groupby">] GroupBy
            | Sort
    
        [<StringEnum; RequireQualifiedAccess>]
        type Order =
            | Ascending
            | Descending
    
    type [<AllowNullLiteral>] Transform =
        abstract ``type``: Transform.Type with get, set
        abstract enabled: bool with get, set
        abstract target: U4<float, string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract operation: string with get, set
        abstract aggregations: ResizeArray<TransformAggregation> with get, set
        abstract preservegaps: bool with get, set
        abstract groups: U3<string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract nameformat: string with get, set
        abstract styles: ResizeArray<TransformStyle> with get, set
        abstract value: obj option with get, set
        abstract order: Transform.Order with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ColorBar =
        [<StringEnum; RequireQualifiedAccess>]
        type TitleSide =
            | Right
            | Top
            | Bottom
    
    [<StringEnum; RequireQualifiedAccess>]
    type SizeMode =
        | Fraction
        | Pixels
    
    type [<AllowNullLiteral>] ColorBar =
        abstract thicknessmode: SizeMode with get, set
        abstract thickness: float with get, set
        abstract lenmode: SizeMode with get, set
        abstract len: float with get, set
        abstract x: float with get, set
        abstract xanchor: XAnchor with get, set
        abstract xpad: float with get, set
        abstract y: float with get, set
        abstract yanchor: YAnchor with get, set
        abstract ypad: float with get, set
        abstract outlinecolor: Color with get, set
        abstract outlinewidth: float with get, set
        abstract bordercolor: Color with get, set
        abstract borderwidth: Color with get, set
        abstract bgcolor: Color with get, set
        abstract tickmode: TickMode with get, set
        abstract nticks: float with get, set
        abstract tick0: U2<float, string> with get, set
        abstract dtick: U2<float, string> with get, set
        abstract tickvals: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, 'T []> with get, set
        abstract ticktext: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, 'T []> with get, set
        abstract ticks: Ticks with get, set
        abstract ticklen: float with get, set
        abstract tickwidth: float with get, set
        abstract tickcolor: Color with get, set
        abstract showticklabels: bool with get, set
        abstract tickfont: Font with get, set
        abstract tickangle: float with get, set
        abstract tickformat: string with get, set
        abstract tickformatstops: TickFormatStops with get, set
        abstract tickprefix: string with get, set
        abstract showtickprefix: ShowOptions with get, set
        abstract ticksuffix: string with get, set
        abstract showticksuffix: ShowOptions with get, set
        abstract separatethousands: bool with get, set
        abstract exponentformat: ExponentFormat with get, set
        abstract showexponent: ShowOptions with get, set
        abstract title: string with get, set
        abstract titlefont: Font with get, set
        abstract titleside: ColorBar.TitleSide with get, set
        abstract tickvalssrc: obj option with get, set
        abstract ticktextsrc: obj option with get, set
    
    /// Any combination of "x", "y", "z", "text", "name" joined with a "+" OR "all" or "none" or "skip".
    /// examples: "x", "y", "x+y", "x+y+z", "all"
    /// default: "all"
    type [<AllowNullLiteral>] PlotMarker =
        abstract symbol: U2<string, ResizeArray<string>> with get, set
        abstract color: U2<Color, ResizeArray<Color>> with get, set
        abstract colors: ResizeArray<Color> with get, set
        abstract colorscale: ColorScale with get, set
        abstract cauto: bool with get, set
        abstract cmax: float with get, set
        abstract cmin: float with get, set
        abstract autocolorscale: bool with get, set
        abstract reversescale: bool with get, set
        abstract opacity: U2<float, ResizeArray<float>> with get, set
        abstract size: U2<float, ResizeArray<float>> with get, set
        abstract maxdisplayed: float with get, set
        abstract sizeref: float with get, set
        abstract sizemax: float with get, set
        abstract sizemin: float with get, set
        abstract sizemode: MarkerSizeMode with get, set
        abstract showscale: bool with get, set
        abstract line: obj with get, set
        abstract width: float with get, set
        abstract colorbar: obj with get, set
        abstract gradient: Gradient with get, set
    
    type ScatterMarker = PlotMarker
    
    type [<AllowNullLiteral>] ScatterMarkerLine =
        abstract width: U2<float, ResizeArray<float>> with get, set
        abstract color: Color with get, set
        abstract colorscale: ColorScale with get, set
        abstract cauto: bool with get, set
        abstract cmax: float with get, set
        abstract cmin: float with get, set
        abstract autocolorscale: bool with get, set
        abstract reversescale: bool with get, set
    
    type [<AllowNullLiteral>] ScatterLine =
        abstract color: Color with get, set
        abstract width: float with get, set
        abstract dash: Dash with get, set
        abstract shape: LineShape with get, set
        abstract smoothing: float with get, set
        abstract simplify: bool with get, set
    
    type [<AllowNullLiteral>] Font =
        /// HTML font family - the typeface that will be applied by the web browser.
        /// The web browser will only be able to apply a font if it is available on the system
        /// which it operates. Provide multiple font families, separated by commas, to indicate
        /// the preference in which to apply fonts if they aren't available on the system.
        /// The plotly service (at https://plot.ly or on-premise) generates images on a server,
        /// where only a select number of fonts are installed and supported.
        /// These include *Arial*, *Balto*, *Courier New*, *Droid Sans*, *Droid Serif*,
        /// *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*,
        /// *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        abstract family: string with get, set
        abstract size: float with get, set
        abstract color: Color with get, set
    
    type [<AllowNullLiteral>] Edits =
        abstract annotationPosition: bool with get, set
        abstract annotationTail: bool with get, set
        abstract annotationText: bool with get, set
        abstract axisTitleText: bool with get, set
        abstract colorbarPosition: bool with get, set
        abstract colorbarTitleText: bool with get, set
        abstract legendPosition: bool with get, set
        abstract legendText: bool with get, set
        abstract shapePosition: bool with get, set
        abstract titleText: bool with get, set
    
    // toImageButtonOptions
    //Partial<{
        //	filename: string;
        //	scale: number;
        //	format: 'png' | 'svg' | 'jpeg' | 'webp';
        //	height: number;
        //	width: number;
    //}>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Config =
        [<StringEnum; RequireQualifiedAccess>]
        type DoubleClick =
            | Autosize
            | Reset
            | [<CompiledName "reset+autosize">] ResetAndAutosize
    
        [<StringEnum; RequireQualifiedAccess>]
        type DisplayModeBar =
            | Hover
    
    type [<AllowNullLiteral>] Config =
        /// override the defaults for the toImageButton 
        abstract toImageButtonOptions: obj with get, set
        /// no interactivity, for export or image generation 
        abstract staticPlot: bool with get, set
        /// we can edit titles, move annotations, etc 
        abstract editable: bool with get, set
        abstract edits: U2<Config.DoubleClick, bool> with get, set // Partial<Edits>
        /// DO autosize once regardless of layout.autosize (use default width or height values otherwise) 
        abstract autosizable: bool with get, set
        /// set the length of the undo/redo queue 
        abstract queueLength: float with get, set
        /// if we DO autosize, do we fill the container or the screen? 
        abstract fillFrame: bool with get, set
        /// if we DO autosize, set the frame margins in percents of plot size 
        abstract frameMargins: float with get, set
        /// mousewheel or two-finger scroll zooms the plot 
        abstract scrollZoom: bool with get, set
        /// double click interaction (false, 'reset', 'autosize' or 'reset+autosize') 
        abstract doubleClick: U4<string, string, string, obj> with get, set
        /// new users see some hints about interactivity 
        abstract showTips: bool with get, set
        /// enable axis pan/zoom drag handles 
        abstract showAxisDragHandles: bool with get, set
        /// enable direct range entry at the pan/zoom drag points (drag handles must be enabled above) 
        abstract showAxisRangeEntryBoxes: bool with get, set
        /// link to open this plot in plotly 
        abstract showLink: bool with get, set
        /// if we show a link, does it contain data or just link to a plotly file? 
        abstract sendData: bool with get, set
        /// text appearing in the sendData link 
        abstract linkText: string with get, set
        /// false or function adding source(s) to linkText <text> 
        abstract showSources: bool with get, set
        /// display the mode bar (true, false, or 'hover') 
        abstract displayModeBar: U2<Config.DisplayModeBar, bool> with get, set
        /// remove mode bar button by name (see ./components/modebar/buttons.js for the list of names) 
        abstract modeBarButtonsToRemove: ResizeArray<ModeBarDefaultButtons> with get, set
        /// add mode bar button using config objects (see ./components/modebar/buttons.js for list of arguments) 
        abstract modeBarButtonsToAdd: U2<ResizeArray<ModeBarDefaultButtons>, ResizeArray<ModeBarButton>> with get, set
        /// fully custom mode bar buttons as nested array, where the outer
        /// arrays represents button groups, and the inner arrays have
        /// buttons config objects or names of default buttons
        /// (see ./components/modebar/buttons.js for more info)
        abstract modeBarButtons: U3<ResizeArray<ResizeArray<ModeBarDefaultButtons>>, ResizeArray<ResizeArray<ModeBarButton>>, obj> with get, set
        /// add the plotly logo on the end of the mode bar 
        abstract displaylogo: bool with get, set
        /// increase the pixel ratio for Gl plot images 
        abstract plotGlPixelRatio: float with get, set
        /// function to add the background color to a different container
        /// or 'opaque' to ensure there's white behind it
        /// or 'transparent'
        abstract setBackground: (unit -> string) with get, set
        /// URL to topojson files used in geo charts 
        abstract topojsonURL: string with get, set
        /// Mapbox access token (required to plot mapbox trace types)
        /// If using an Mapbox Atlas server, set this option to '',
        /// so that plotly.js won't attempt to authenticate to the public Mapbox server.
        abstract mapboxAccessToken: string with get, set
        /// Turn all console logging on or off (errors will be thrown)
        /// This should ONLY be set via Plotly.setPlotConfig
        /// only accepts 0, 1, and 2
        abstract logging: U2<bool, float> with get, set
        /// Set global transform to be applied to all traces with no specification needed 
        abstract globalTransforms: ResizeArray<obj option> with get, set
        /// Which localization should we use? Should be a string like 'en' or 'en-US' 
        abstract locale: string with get, set
        /// Make the chart responsive to window size 
        abstract responsive: bool with get, set
    
    type [<AllowNullLiteral>] RangeSlider =
        abstract visible: bool with get, set
        abstract thickness: float with get, set
        abstract range: Datum * Datum with get, set
        abstract borderwidth: float with get, set
        abstract bordercolor: string with get, set
        abstract bgcolor: string with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module RangeSelectorButton =
        [<StringEnum; RequireQualifiedAccess>]
        type Step =
            | Second
            | Minute
            | Hour
            | Day
            | Month
            | Year
            | All
    
        [<StringEnum; RequireQualifiedAccess>]
        type StepMode =
            | Backward
            | [<CompiledName "todate">] ToDate
    
    type [<AllowNullLiteral>] RangeSelectorButton =
        abstract step:RangeSelectorButton.Step with get, set
        abstract stepmode: RangeSelectorButton.StepMode with get, set
        abstract count: float with get, set
        abstract label: string with get, set
    
    type [<AllowNullLiteral>] RangeSelector =
        inherit Label
        abstract buttons: obj [] with get, set // Array<Partial<RangeSelectorButton>>
        abstract visible: bool with get, set
        abstract x: float with get, set
        abstract xanchor: XAnchorAuto with get, set
        abstract y: float with get, set
        abstract yanchor: YAnchorAuto with get, set
        abstract activecolor: string with get, set
        abstract borderwidth: float with get, set
    
    type [<AllowNullLiteral>] Camera =
        abstract up: obj with get, set // Partial<Point>
        abstract center: obj with get, set // Partial<Point>
        abstract eye: obj with get, set // Partial<Point>
    
    type [<AllowNullLiteral>] Label =
        /// Sets the background color of all hover labels on graph. 
        abstract bgcolor: string with get, set
        /// Sets the border color of all hover labels on graph. 
        abstract bordercolor: string with get, set
        /// Sets the default hover label font used by all traces on the graph. 
        abstract font: obj with get, set // Partial<Font>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module HoverLabel =
        [<StringEnum; RequireQualifiedAccess>]
        type Align =
            | Left
            | Right
            | Auto
    
    type [<AllowNullLiteral>] HoverLabel =
        inherit Label
        /// Sets the horizontal alignment of the text content within hover label box. 
        abstract align: HoverLabel.Align with get, set
        /// Sets the default length (in number of characters) (default 15) of the trace name
        /// in the hover labels for all traces.
        /// -1 shows the whole name regardless of length.
        abstract namelength: float with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Annotations =
        [<StringEnum; RequireQualifiedAccess>]
        type Align =
            | Left
            | Center
            | Right
    
        [<StringEnum; RequireQualifiedAccess>]
        type VAlign =
            | Top
            | Middle
            | Bottom
    
        [<StringEnum; RequireQualifiedAccess>]
        type ArrowSide =
            | End
            | Start
    
        [<StringEnum; RequireQualifiedAccess>]
        type AXRef =
            | Pixel 
            | X | X2 | X3 | X4 | X5 | X6 | X7 | X8 | X9
    
        [<StringEnum; RequireQualifiedAccess>]
        type AYRef =
            | Pixel 
            | Y | Y2 | Y3 | Y4 | Y5 | Y6 | Y7 | Y8 | Y9
    
        [<StringEnum; RequireQualifiedAccess>]
        type XAnchor =
            | Auto
            | Left
            | Center
            | Right
    
        [<StringEnum; RequireQualifiedAccess>]
        type YAnchor =
            | Auto
            | Top
            | Middle
            | Bottom
    
        [<StringEnum; RequireQualifiedAccess>]
        type ClickToShow =
            | [<CompiledName "onoff">] OnOff
            | [<CompiledName "onout">] OnOut
    
    [<StringEnum; RequireQualifiedAccess>]
    type XRef =
        | Paper 
        | X
    
    [<StringEnum; RequireQualifiedAccess>]
    type YRef =
        | Paper 
        | Y
    
    type [<AllowNullLiteral>] Annotations =
        inherit Label
        /// Determines whether or not this annotation is visible. 
        abstract visible: bool with get, set
        /// Sets the text associated with this annotation.
        /// Plotly uses a subset of HTML tags to do things like
        /// newline (<br>), bold (<b></b>), italics (<i></i>),
        /// hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub>
        /// <span> are also supported.
        abstract text: string with get, set
        /// Sets the angle at which the `text` is drawn with respect to the horizontal. 
        abstract textangle: string with get, set
        /// Sets an explicit width for the text box. null (default) lets the
        /// text set the box width. Wider text will be clipped.
        /// There is no automatic wrapping; use <br> to start a new line.
        abstract width: float with get, set
        /// Sets an explicit height for the text box. null (default) lets the
        /// text set the box height. Taller text will be clipped.
        abstract height: float with get, set
        /// Sets the opacity of the annotation (text + arrow). 
        abstract opacity: float with get, set
        /// Sets the horizontal alignment of the `text` within the box.
        /// Has an effect only if `text` spans more two or more lines
        /// (i.e. `text` contains one or more <br> HTML tags) or if an
        /// explicit width is set to override the text width.
        abstract align: Annotations.Align with get, set
        /// Sets the vertical alignment of the `text` within the box.
        /// Has an effect only if an explicit height is set to override the text height.
        abstract valign: Annotations.VAlign with get, set
        /// Sets the padding (in px) between the `text` and the enclosing border. 
        abstract borderpad: float with get, set
        /// Sets the width (in px) of the border enclosing the annotation `text`. 
        abstract borderwidth: float with get, set
        /// Determines whether or not the annotation is drawn with an arrow.
        /// If *true*, `text` is placed near the arrow's tail.
        /// If *false*, `text` lines up with the `x` and `y` provided.
        abstract showarrow: bool with get, set
        /// Sets the color of the annotation arrow. 
        abstract arrowcolor: string with get, set
        /// Sets the end annotation arrow head style. 
        abstract arrowhead: float with get, set
        /// Sets the start annotation arrow head style. 
        abstract startarrowhead: float with get, set
        /// Sets the annotation arrow head position. 
        abstract arrowside: Annotations.ArrowSide with get, set
        /// Sets the size of the end annotation arrow head, relative to `arrowwidth`.
        /// A value of 1 (default) gives a head about 3x as wide as the line.
        abstract arrowsize: float with get, set
        /// Sets the size of the start annotation arrow head, relative to `arrowwidth`.
        /// A value of 1 (default) gives a head about 3x as wide as the line.
        abstract startarrowsize: float with get, set
        /// Sets the width (in px) of annotation arrow line. 
        abstract arrowwidth: float with get, set
        /// Sets a distance, in pixels, to move the end arrowhead away from the
        /// position it is pointing at, for example to point at the edge of
        /// a marker independent of zoom. Note that this shortens the arrow
        /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
        /// which moves everything by this amount.
        abstract standoff: float with get, set
        /// Sets a distance, in pixels, to move the start arrowhead away from the
        /// position it is pointing at, for example to point at the edge of
        /// a marker independent of zoom. Note that this shortens the arrow
        /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
        /// which moves everything by this amount.
        abstract startstandoff: float with get, set
        /// Sets the x component of the arrow tail about the arrow head.
        /// If `axref` is `pixel`, a positive (negative)
        /// component corresponds to an arrow pointing
        /// from right to left (left to right).
        /// If `axref` is an axis, this is an absolute value on that axis,
        /// like `x`, NOT a relative value.
        abstract ax: float with get, set
        /// Sets the y component of the arrow tail about the arrow head.
        /// If `ayref` is `pixel`, a positive (negative)
        /// component corresponds to an arrow pointing
        /// from bottom to top (top to bottom).
        /// If `ayref` is an axis, this is an absolute value on that axis,
        /// like `y`, NOT a relative value.
        abstract ay: float with get, set
        /// Indicates in what terms the tail of the annotation (ax,ay)
        /// is specified. If `pixel`, `ax` is a relative offset in pixels
        /// from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is
        /// specified in the same terms as that axis. This is useful
        /// for trendline annotations which should continue to indicate
        /// the correct trend when zoomed.
        abstract axref: string with get, set
        /// Indicates in what terms the tail of the annotation (ax,ay)
        /// is specified. If `pixel`, `ay` is a relative offset in pixels
        /// from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is
        /// specified in the same terms as that axis. This is useful
        /// for trendline annotations which should continue to indicate
        /// the correct trend when zoomed.
        abstract ayref: string with get, set
        /// Sets the annotation's x coordinate axis.
        /// If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate
        /// If set to *paper*, the `x` position refers to the distance from
        /// the left side of the plotting area in normalized coordinates
        /// where 0 (1) corresponds to the left (right) side.
        abstract xref: XRef with get, set
        /// Sets the annotation's x position.
        /// If the axis `type` is *log*, then you must take the log of your desired range.
        /// If the axis `type` is *date*, it should be date strings, like date data,
        /// though Date objects and unix milliseconds will be accepted and converted to strings.
        /// If the axis `type` is *category*, it should be numbers, using the scale where each
        /// category is assigned a serial number from zero in the order it appears.
        abstract x: U2<float, string> with get, set
        /// Sets the text box's horizontal position anchor
        /// This anchor binds the `x` position to the *left*, *center* or *right* of the annotation.
        /// For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the
        /// right-most portion of the annotation lines up with the right-most edge of the plotting area.
        /// If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there
        /// is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
        abstract xanchor: Annotations.XAnchor with get, set
        /// Shifts the position of the whole annotation and arrow to the
        /// right (positive) or left (negative) by this many pixels.
        abstract xshift: float with get, set
        /// Sets the annotation's y coordinate axis.
        /// If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate
        /// If set to *paper*, the `y` position refers to the distance from
        /// the bottom of the plotting area in normalized coordinates
        /// where 0 (1) corresponds to the bottom (top).
        abstract yref: YRef with get, set
        /// Sets the annotation's y position.
        /// If the axis `type` is *log*, then you must take the log of your desired range.
        /// If the axis `type` is *date*, it should be date strings, like date data,
        /// though Date objects and unix milliseconds will be accepted and converted to strings.
        /// If the axis `type` is *category*, it should be numbers, using the scale where each
        /// category is assigned a serial number from zero in the order it appears.
        abstract y: U2<float, string> with get, set
        /// Sets the text box's vertical position anchor
        /// This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation.
        /// For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the
        /// top-most portion of the annotation lines up with the top-most edge of the plotting area.
        /// If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if
        /// there is an arrow, whereas for paper-referenced with no arrow, the anchor picked
        /// corresponds to the closest side.
        abstract yanchor: Annotations.YAnchor with get, set
        /// Shifts the position of the whole annotation and arrow up
        /// (positive) or down (negative) by this many pixels.
        abstract yshift: float with get, set
        /// Makes this annotation respond to clicks on the plot.
        /// If you click a data point that exactly matches the `x` and `y` values of this annotation,
        /// and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same
        /// point again to make it disappear, so if you click multiple points, you can show multiple
        /// annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not)
        /// will hide this annotation. If you need to show/hide this annotation in response to different
        /// `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label
        /// the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
        abstract clicktoshow: U2<bool, Annotations.ClickToShow> with get, set
        /// Toggle this annotation when clicking a data point whose `x` value
        /// is `xclick` rather than the annotation's `x` value.
        abstract xclick: obj option with get, set
        /// Toggle this annotation when clicking a data point whose `y` value
        /// is `yclick` rather than the annotation's `y` value.
        abstract yclick: obj option with get, set
        /// Sets text to appear when hovering over this annotation.
        /// If omitted or blank, no hover label will appear.
        abstract hovertext: string with get, set
        abstract hoverlabel: obj with get, set // Partial<HoverLabel>
        /// Determines whether the annotation text box captures mouse move and click events,
        /// or allows those events to pass through to data points in the plot that may be
        /// behind the annotation. By default `captureevents` is *false* unless `hovertext`
        /// is provided. If you use the event `plotly_clickannotation` without `hovertext`
        /// you must explicitly enable `captureevents`.
        abstract captureevents: bool with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Image =
        [<StringEnum; RequireQualifiedAccess>]
        type Layer =
            | Below
            | Above
    
        [<StringEnum; RequireQualifiedAccess>]
        type Sizing =
            | Fill
            | Contain
            | Stretch
    
        [<StringEnum; RequireQualifiedAccess>]
        type XAnchor =
            | Left
            | Center
            | Right
    
        [<StringEnum; RequireQualifiedAccess>]
        type YAnchor =
            | Top
            | Middle
            | Bottom
            
        [<StringEnum; RequireQualifiedAccess>]
        type Xref =
            | X
            | Paper
    
        [<StringEnum; RequireQualifiedAccess>]
        type Yref =
            | Y
            | Paper
    
    type [<AllowNullLiteral>] Image =
        abstract visible: bool with get, set
        abstract source: string with get, set
        abstract layer: Image.Layer with get, set
        abstract sizex: float with get, set
        abstract sizey: float with get, set
        abstract sizing: Image.Sizing with get, set
        abstract opacity: float with get, set
        abstract x: U2<float, string> with get, set
        abstract y: U2<float, string> with get, set
        abstract xanchor: Image.XAnchor with get, set
        abstract yanchor: Image.YAnchor with get, set
        abstract xref: Image.Xref with get, set
        abstract yref: Image.Yref with get, set
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type SceneAspectMode =
        | Auto
        | Cube
        | Data
        | Manual
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type SceneDragMode =
        | Orbit
        | Turntable
        | Zoom
        | Pan
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type SceneHoverMode =
        | Closest
    
    type [<AllowNullLiteral>] Scene =
        abstract bgcolor: string with get, set
        abstract camera: obj with get, set // Partial<Camera>
        abstract domain: obj with get, set // Partial<Domain>
        abstract aspectmode: SceneAspectMode with get, set
        abstract aspectratio: obj with get, set // Partial<Point>
        abstract xaxis: obj with get, set // Partial<SceneAxis>
        abstract yaxis: obj with get, set // Partial<SceneAxis>
        abstract zaxis: obj with get, set // Partial<SceneAxis>
        abstract dragmode: U2<SceneDragMode, bool> with get, set
        abstract hovermode: U2<SceneHoverMode, bool> with get, set
        abstract annotations: U2<obj, obj []> with get, set // Partial<Annotations> | Array<Partial<Annotations>>
        abstract captureevents: bool with get, set
    
    type [<AllowNullLiteral>] Domain =
        abstract x: ResizeArray<float> with get, set
        abstract y: ResizeArray<float> with get, set
    
    type [<AllowNullLiteral>] Frame =
        /// An identifier that specifies the group to which the frame belongs,
        /// used by animate to select a subset of frames.
        abstract group: string with get, set
        /// A label by which to identify the frame
        abstract name: string with get, set
        /// A list of trace indices that identify the respective traces in the
        /// data attribute
        abstract traces: ResizeArray<float> with get, set
        /// The name of the frame into which this frame's properties are merged
        /// before applying. This is used to unify properties and avoid needing
        /// to specify the same values for the same properties in multiple frames.
        abstract baseframe: string with get, set
        /// A list of traces this frame modifies. The format is identical to the
        /// normal trace definition.
        abstract data: ResizeArray<Data> with get, set
        /// Layout properties which this frame modifies. The format is identical
        /// to the normal layout definition.
        abstract layout: obj with get, set // Partial<Layout>
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Transition =
        [<StringEnum; RequireQualifiedAccess>]
        type Easing =
            | Linear | Quad | Cubic | Sin | Exp | Circle | Elastic | Back | Bounce 
            | [<CompiledName "linear-in">] LinearIn
            | [<CompiledName "quad-in ">] QuadIn
            | [<CompiledName "cubic-in ">] CubicIn
            | [<CompiledName "sin-in ">] SinIn
            | [<CompiledName "exp-in ">] ExpIn
            | [<CompiledName "circle-in ">] CircleIn
            | [<CompiledName "elastic-in">] ElasticIn
            | [<CompiledName "back-in">] BackIn
            | [<CompiledName "bounce-in ">] BounceIn
            | [<CompiledName "linear-out ">] LinearOut
            | [<CompiledName "quad-out ">] QuadOut
            | [<CompiledName "cubic-out">] CubicOut
            | [<CompiledName "sin-out ">] SinOut
            | [<CompiledName "exp-out ">] ExpOut
            | [<CompiledName "circle-out ">] CircleOut
            | [<CompiledName "elastic-out ">] ElasticOut
            | [<CompiledName "back-out ">] BackOut
            | [<CompiledName "bounce-out ">] BounceOut
            | [<CompiledName "linear-in-out ">] LinearInOut
            | [<CompiledName "quad-in-out ">] QuadInOut
            | [<CompiledName "cubic-in-out ">] CubicInOut
            | [<CompiledName "sin-in-out ">] SinInOut
            | [<CompiledName "exp-in-out ">] ExpInOut
            | [<CompiledName "circle-in-out ">] CircleInOut
            | [<CompiledName "elastic-in-out ">] ElasticInOut
            | [<CompiledName "back-in-out ">] BackInOut
            | [<CompiledName "bounce-in-out">] BounceInOut
    
    type [<AllowNullLiteral>] Transition =
        /// Sets the duration of the slider transition
        abstract duration: float with get, set
        /// Sets the easing function of the slider transition
        abstract easing: Transition.Easing with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module SliderStep =
        [<StringEnum; RequireQualifiedAccess>]
        type Method =
            | Animate
            | Relayout
            | Restyle
            | Skip
            | Update
    
    type [<AllowNullLiteral>] SliderStep =
        /// Determines whether or not this step is included in the slider.
        abstract visible: bool with get, set
        /// Sets the Plotly method to be called when the slider value is changed.
        /// If the `skip` method is used, the API slider will function as normal
        /// but will perform no API calls and will not bind automatically to state
        /// updates. This may be used to create a component interface and attach to
        /// slider events manually via JavaScript.
        abstract ``method``: SliderStep.Method with get, set
        /// Sets the arguments values to be passed to the Plotly
        /// method set in `method` on slide.
        abstract args: ResizeArray<obj option> with get, set
        /// Sets the text label to appear on the slider
        abstract label: string with get, set
        /// Sets the value of the slider step, used to refer to the step programatically.
        /// Defaults to the slider label if not provided.
        abstract value: string with get, set
        /// When true, the API method is executed. When false, all other behaviors are the same
        /// and command execution is skipped. This may be useful when hooking into, for example,
        /// the `plotly_sliderchange` method and executing the API command manually without losing
        /// the benefit of the slider automatically binding to the state of the plot through the
        /// specification of `method` and `args`.
        abstract execute: bool with get, set
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Padding =
        [<StringEnum; RequireQualifiedAccess>]
        type EditType =
            | ArrayDraw
    
    type [<AllowNullLiteral>] Padding =
        /// The amount of padding (in px) along the top of the component.
        abstract t: float with get, set
        /// The amount of padding (in px) on the right side of the component.
        abstract r: float with get, set
        /// The amount of padding (in px) along the bottom of the component.
        abstract b: float with get, set
        /// The amount of padding (in px) on the left side of the component.
        abstract l: float with get, set
        abstract editType: Padding.EditType with get, set
    
    type [<AllowNullLiteral>] Slider =
        /// Determines whether or not the slider is visible.
        abstract visible: bool with get, set
        /// Determines which button (by index starting from 0) is
        /// considered active.
        abstract active: float with get, set
        abstract steps: obj [] with get, set // Array<Partial<SliderStep>>
        /// Determines whether this slider length
        /// is set in units of plot *fraction* or in *pixels.
        /// Use `len` to set the value.
        abstract lenmode: SizeMode with get, set
        /// Sets the length of the slider
        /// This measure excludes the padding of both ends.
        /// That is, the slider's length is this length minus the
        /// padding on both ends.
        abstract len: float with get, set
        /// Sets the x position (in normalized coordinates) of the slider.
        abstract x: float with get, set
        /// Sets the y position (in normalized coordinates) of the slider.
        abstract y: float with get, set
        /// Set the padding of the slider component along each side.
        abstract pad: obj with get, set // Partial<Padding>
        /// Sets the slider's horizontal position anchor.
        /// This anchor binds the `x` position to the *left*, *center*
        /// or *right* of the range selector.
        abstract xanchor: XAnchorAuto with get, set
        /// Sets the slider's vertical position anchor
        /// This anchor binds the `y` position to the *top*, *middle*
        /// or *bottom* of the range selector.
        abstract yanchor: YAnchorAuto with get, set
        abstract transition: Transition with get, set
        abstract currentvalue: SliderValue with get, set
        /// Sets the font of the slider step labels.
        abstract font: Font with get, set
        /// Sets the background color of the slider grip
        /// while dragging.
        abstract activebgcolor: Color with get, set
        /// Sets the background color of the slider.
        abstract bgcolor: Color with get, set
        /// Sets the color of the border enclosing the slider.
        abstract bordercolor: Color with get, set
        /// Sets the width (in px) of the border enclosing the slider.
        abstract borderwidth: float with get, set
        /// Sets the length in pixels of step tick marks
        abstract ticklen: float with get, set
        /// Sets the color of the border enclosing the slider.
        abstract tickcolor: Color with get, set
        /// Sets the tick width (in px).
        abstract tickwidth: float with get, set
        /// Sets the length in pixels of minor step tick marks
        abstract minorticklen: float with get, set
    
    type [<AllowNullLiteral>] TypeLiteral_03 =
        interface end
    
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Gradient =
        [<StringEnum; RequireQualifiedAccess>]
        type Type =
            | Radial
            | Horizontal
            | Vertical
            | None
    
    type [<AllowNullLiteral>] Gradient =
        abstract ``type``: Gradient.Type with get, set
        abstract color: Color with get, set
        abstract typesrc: obj option with get, set // any
        abstract colorsrc: obj option with get, set // any
    
    type [<AllowNullLiteral>] TickFormatStops =
        abstract dtickrange: ResizeArray<obj option> with get, set
        abstract value: string with get, set
    
    type [<AllowNullLiteral>] FrameAnimation =
        abstract duration: float with get, set
        abstract redraw: bool with get, set
    
    type [<AllowNullLiteral>] Animation =
        abstract frame: FrameAnimation with get, set
        abstract transition: Transition with get, set
    
    type [<AllowNullLiteral>] XBins =
        abstract start: U2<float, string> with get, set
        abstract ``end``: U2<float, string> with get, set
        abstract size: U2<float, string> with get, set
    
    type [<AllowNullLiteral>] SliderValue =
        /// Shows the currently-selected value above the slider.
        abstract visible: bool with get, set
        /// The alignment of the value readout relative to the length of the slider.
        abstract xanchor: XAnchor with get, set
        /// The amount of space, in pixels, between the current value label
        /// and the slider.
        abstract offset: float with get, set
        /// When currentvalue.visible is true, this sets the prefix of the label.
        abstract prefix: string with get, set
        /// When currentvalue.visible is true, this sets the suffix of the label.
        abstract suffix: string with get, set
        /// Sets the font of the current value label text.
        abstract font: obj with get, set // Partial<Font>