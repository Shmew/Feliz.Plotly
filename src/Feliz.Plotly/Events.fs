namespace Feliz.Plotly

module Events =
    open Browser.Types
    open Fable.Core
    open System

    [<StringEnum; RequireQualifiedAccess>]
    type Easing =
        | Linear | Quad | Cubic | Sin | Exp | Circle | Elastic | Back | Bounce 
        | [<CompiledName "linear-in">] LinearIn
        | [<CompiledName "quad-in">] QuadIn
        | [<CompiledName "cubic-in">] CubicIn
        | [<CompiledName "sin-in">] SinIn
        | [<CompiledName "exp-in">] ExpIn
        | [<CompiledName "circle-in">] CircleIn
        | [<CompiledName "elastic-in">] ElasticIn
        | [<CompiledName "back-in">] BackIn
        | [<CompiledName "bounce-in">] BounceIn
        | [<CompiledName "linear-out">] LinearOut
        | [<CompiledName "quad-out">] QuadOut
        | [<CompiledName "cubic-out">] CubicOut
        | [<CompiledName "sin-out">] SinOut
        | [<CompiledName "exp-out">] ExpOut
        | [<CompiledName "circle-out">] CircleOut
        | [<CompiledName "elastic-out">] ElasticOut
        | [<CompiledName "back-out">] BackOut
        | [<CompiledName "bounce-out">] BounceOut
        | [<CompiledName "linear-in-out">] LinearInOut
        | [<CompiledName "quad-in-out">] QuadInOut
        | [<CompiledName "cubic-in-out">] CubicInOut
        | [<CompiledName "sin-in-out">] SinInOut
        | [<CompiledName "exp-in-out">] ExpInOut
        | [<CompiledName "circle-in-out">] CircleInOut
        | [<CompiledName "elastic-in-out">] ElasticInOut
        | [<CompiledName "back-in-out">] BackInOut
        | [<CompiledName "bounce-in-out">] BounceInOut

    let (|Bool|_|) (value: U5<bool, DateTime, float, int, string> option) =
        match value with
        | Some(U5.Case1 b) -> Some b
        | _ -> None

    let (|DateTime|_|) (value: U5<bool, DateTime, float, int, string> option) =
        match value with
        | Some(U5.Case2 dt) -> Some dt
        | _ -> None

    let (|Float|_|) (value: U5<bool, DateTime, float, int, string> option) =
        match value with
        | Some(U5.Case3 f) -> Some f
        | _ -> None

    let (|Int|_|) (value: U5<bool, DateTime, float, int, string> option) =
        match value with
        | Some(U5.Case4 i) -> Some i
        | _ -> None

    let (|String|_|) (value: U5<bool, DateTime, float, int, string> option) =
        match value with
        | Some(U5.Case5 s) -> Some s
        | _ -> None

    type PlotDatum =
        /// index in data of the trace associated with the selected point
        abstract curveNumber: int with get
        /// Index of the selected point
        abstract pointNumber: int option with get
        /// Array of indices of the points aggregated into selected bin
        ///
        /// This value only exists when the trace is something like a histogram
        abstract pointNumbers: ResizeArray<int> option with get
        abstract x: U5<bool, DateTime, float, int, string> option with get
        abstract y: U5<bool, DateTime, float, int, string> option with get
        abstract z: U5<bool, DateTime, float, int, string> option with get
        abstract lat: U5<bool, DateTime, float, int, string> option with get
        abstract lon: U5<bool, DateTime, float, int, string> option with get
        /// The trace as sent to Plotly associated with the selected point
        abstract data: obj with get
        /// Same as `data` but with default values included
        abstract fullData: obj with get
        /// The x-axis object (i.e layout.xaxis) associated with the selected point
        abstract xaxis: obj with get
        /// The y-axis object (i.e layout.yaxis) associated with the selected point
        abstract yaxis: obj with get
        /// The z-axis object (i.e layout.zaxis) associated with the selected point
        abstract zaxis: obj option with get
        /// The location of a map trace
        abstract location: string option with get
        /// The text value associated with the selected point
        abstract text: string option with get

    type PlotMouseEvent =
        /// Collection of trace points for the given event
        abstract points: ResizeArray<PlotDatum> with get
        abstract event: MouseEvent with get
        
    type SelectionRange =
        abstract x: ResizeArray<float> with get
        abstract y: ResizeArray<float> with get
    
    type PlotSelectionEvent =
        /// Collection of trace points for the given event
        abstract points: ResizeArray<PlotDatum> with get
        abstract range: SelectionRange option with get
        abstract lassoPoints: SelectionRange option with get
    
    type PlotRestyleEvent = ResizeArray<obj>
        
    type Center =
        abstract x: int option with get
        abstract y: int option with get
        abstract z: int option with get

    type Scene =
        abstract center: Center with get

    type Eye =
        abstract x: int option with get
        abstract y: int option with get
        abstract z: int option with get

    type Up =
        abstract x: int option with get
        abstract y: int option with get
        abstract z: int option with get

    type PlotRelayoutEvent =
        [<Emit("$0[\"xaxis.range[0]\"]")>]
        abstract ``xaxis.range[0]``: U5<bool, DateTime, float, int, string> option with get
        [<Emit("$0[\"xaxis.range[1]\"]")>]
        abstract ``xaxis.range[1]``: U5<bool, DateTime, float, int, string> option with get
        [<Emit("$0[\"yaxis.range[0]\"]")>]
        abstract ``yaxis.range[0]``: U5<bool, DateTime, float, int, string> option with get
        [<Emit("$0[\"yaxis.range[1]\"]")>]
        abstract ``yaxis.range[1]``: U5<bool, DateTime, float, int, string> option with get
        [<Emit("$0[\"xaxis.autorange\"]")>]
        abstract ``xaxis.autorange``: bool option with get
        [<Emit("$0[\"yaxis.autorange\"]")>]
        abstract ``yaxis.autorange``: bool option with get
        abstract scene: Scene option with get
        abstract eye: Eye option with get
        abstract up: Up option with get
    
    type ClickAnnotationEvent =
        /// The index of the annotation
        abstract index: int with get
        /// The annotation as sent to Plotly associated with the selected point
        abstract annotation: obj with get
        /// Same as `annotation` but with default values included
        abstract fullAnnotation: obj with get
        abstract event: MouseEvent with get
    
    type Frame =
        /// An identifier that specifies the group to which the frame belongs,
        /// used by animate to select a subset of frames.
        abstract group: string with get
        /// A label by which to identify the frame
        abstract name: string with get
        /// A list of trace indices that identify the respective traces in the
        /// data attribute
        abstract traces: ResizeArray<float> with get
        /// The name of the frame into which this frame's properties are merged
        /// before applying. This is used to unify properties and avoid needing
        /// to specify the same values for the same properties in multiple frames.
        abstract baseframe: string with get
        /// A list of traces this frame modifies. The format is identical to the
        /// normal trace definition.
        abstract data: obj option with get
        /// Layout properties which this frame modifies. The format is identical
        /// to the normal layout definition.
        abstract layout: obj option with get

    type Figure =
        abstract data: obj with get
        abstract layout: obj with get
        abstract frames: ResizeArray<Frame> option with get

    type FrameAnimation =
        abstract duration: float with get
        abstract redraw: bool with get
    
    type Transition =
        /// Sets the duration of the slider transition
        abstract duration: float with get
        /// Sets the easing function of the slider transition
        abstract easing: Easing with get

    type Animation =
        abstract frame: FrameAnimation with get
        abstract transition: Transition with get

    type FrameAnimationEvent =
        abstract name: string with get
        abstract frame: Frame with get
        abstract animation: Animation with get
    
    type LegendClickEvent =
        abstract event: MouseEvent with get
        abstract node: HTMLElement with get
        /// index in data of the trace associated with the selected point
        abstract curveNumber: int with get
        abstract expandedIndex: int with get
        abstract data: obj option with get
        abstract layout: obj option with get
        abstract frames: ResizeArray<Frame> with get
        abstract config: obj option with get
        abstract fullData: obj with get
        abstract fullLayout: obj with get

    type SliderChangeEvent =
        abstract slider: obj with get
        abstract step: int with get
        abstract interaction: bool with get
        abstract previousActive: int with get

    type SliderStartEvent =
        abstract slider: obj with get

    type SliderEndEvent =
        abstract slider: obj with get
        abstract step: int with get

    type BeforePlotEvent =
        abstract data: obj with get
        abstract layout: obj with get
        abstract config: obj with get

    type ButtonClickedEvent =
        abstract menu: obj with get
        abstract button: obj with get
        abstract active: int with get
