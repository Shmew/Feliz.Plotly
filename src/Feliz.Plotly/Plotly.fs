namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type plot =
    /// Create the plotly traces.
    static member inline traces (properties: #ITracesProperty list) = Bindings.extractTraces properties
    /// Create the plotly config.
    static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr "config" (createObj !!properties)
    /// Create the plotly layout.
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr "layout" (createObj !!properties)
    /// Create plot frames.
    static member inline frames (properties: #IFramesProperty list) = Interop.mkPlotAttr "frames" (createObj !!properties)
    /// When provided, causes the plot to update when the revision is incremented.
    static member inline revision (value: int) = Interop.mkPlotAttr "revision" value
    /// When provided, causes the plot to update when the revision is incremented.
    static member inline revision (value: float) = Interop.mkPlotAttr "revision" value
    /// Callback executed after plot is initialized.
    static member inline onInitialized (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr "onInitialized" handler
    /// Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.
    static member inline onUpdate (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr "onUpdate" handler
    /// Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.
    static member inline onPurge (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr "onPurge" handler
    /// Callback executed when a plotly.js API method rejects.
    static member inline onError (handler: ErrorEvent -> unit) = Interop.mkPlotAttr "onError" handler
    /// Id assigned to the <div> into which the plot is rendered.
    static member inline divId (value: string) = Interop.mkPlotAttr "divId" value
    /// Class applied to the <div> into which the plot is rendered.
    static member inline className (value: string) = Interop.mkPlotAttr "className" value
    /// Styles the <div> into which the plot is rendered.
    static member inline style (properties: #IStyleAttribute list) = Interop.mkPlotAttr "style" (createObj !!properties)
    /// Assign the graph div to window.gd for debugging.
    static member inline debug (value: bool) = Interop.mkPlotAttr "debug" value
    /// When true, adds a call to Plotly.Plot.resize() as a window.resize event handler.
    static member inline useResizeHandler (value: bool) = Interop.mkPlotAttr "useResizeHandler" value
    /// Callback executed when the plot is exported.
    static member inline onAfterExport (handler: unit -> unit) = Interop.mkPlotAttr "onClick" handler
    /// Callback executed when the plot is drawn.
    static member inline onAfterPlot (handler: unit -> unit) = Interop.mkPlotAttr "onAfterPlot" handler
    /// Callback executed when the plot has been animated.
    static member inline onAnimated (handler: unit -> unit) = Interop.mkPlotAttr "onAnimated" handler
    /// Callback executed when there is an animating frame.
    static member inline onAnimatingFrame (handler: Events.FrameAnimationEvent -> unit) = Interop.mkPlotAttr "onAnimatingFrame" handler
    /// Callback executed when an animation gets interrupted.
    static member inline onAnimationInterrupted (handler: unit -> unit) = Interop.mkPlotAttr "onAnimationInterrupted" handler
    /// Callback executed when the plot resizes automatically.
    static member inline onAutoSize (handler: unit -> unit) = Interop.mkPlotAttr "onAutoSize" handler
    /// Callback executed when a plot is being exported, before the export occurs.
    static member inline onBeforeExport (handler: unit -> unit) = Interop.mkPlotAttr "onBeforeExport" handler
    /// Callback executed when a plot is about to be hovered.
    static member inline onBeforeHover (handler: unit -> unit) = Interop.mkPlotAttr "onBeforeHover" handler
    /// Callback executed when a menu button is clicked.
    static member inline onButtonClicked (handler: Events.ButtonClickedEvent -> unit) = Interop.mkPlotAttr "onButtonClicked" handler
    /// Callback executed when a plot item is clicked.
    static member inline onClick (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onClick" handler
    /// Callback executed when an annotation is clicked.
    static member inline onClickAnnotation (handler: Events.ClickAnnotationEvent -> unit) = Interop.mkPlotAttr "onClickAnnotation" handler
    /// Callback executed when a plot item is deselected.
    static member inline onDeselect (handler: unit -> unit) = Interop.mkPlotAttr "onDeselect" handler
    /// Callback executed when a plot point is double clicked.
    static member inline onDoubleClick (handler: unit -> unit) = Interop.mkPlotAttr "onDoubleClick" handler
    /// Callback executed when a plot creates or re-creates a framework.
    static member inline onFramework (handler: unit -> unit) = Interop.mkPlotAttr "onFramework" handler
    /// Callback executed when a plot item is hovered over.
    static member inline onHover (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onHover" handler
    /// Callback executed when the legend is clicked.
    static member inline onLegendClick (handler: Events.LegendClickEvent -> unit) = Interop.mkPlotAttr "onLegendClick" handler
    /// Callback executed when the legend is double clicked.
    static member inline onLegendDoubleClick (handler: Events.LegendClickEvent -> unit) = Interop.mkPlotAttr "onLegendDoubleClick" handler
    /// Callback executed when the plot performs a relayout.
    static member inline onRelayout (handler: Events.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr "onRelayout" handler
    /// Callback executed when the plot is performing a relayout.
    static member inline onRelayouting (handler: Events.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr "onRelayouting" handler
    /// Callback executed when the plot performs a restyle.
    static member inline onRestyle (handler: Events.PlotRestyleEvent -> unit) = Interop.mkPlotAttr "onRestyle" handler
    /// Callback executed when the plot is redrawn.
    static member inline onRedraw (handler: unit -> unit) = Interop.mkPlotAttr "onRedraw" handler
    /// Callback executed when a plot item is selected.
    static member inline onSelected (handler: Events.PlotSelectionEvent -> unit) = Interop.mkPlotAttr "onSelected" handler
    /// Callback executed when a plot item is about to be selected.
    static member inline onSelecting (handler: Events.PlotSelectionEvent -> unit) = Interop.mkPlotAttr "onSelecting" handler
    /// Callback executed when a plot slider is changing.
    static member inline onSliderChange (handler: Events.SliderChangeEvent -> unit) = Interop.mkPlotAttr "onSliderChange" handler
    /// Callback executed when a plot slider finished changing.
    static member inline onSliderEnd (handler: Events.SliderEndEvent -> unit) = Interop.mkPlotAttr "onSliderEnd" handler
    /// Callback executed when a plot slider is about to change.
    static member inline onSliderStart (handler: Events.SliderStartEvent -> unit) = Interop.mkPlotAttr "onSliderStart" handler
    /// Callback executed when a sunburst trace is clicked.
    static member inline onSunburstClick (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onSunburstClick" handler
    /// Callback executed when a plot is performing a transition.
    static member inline onTransitioning (handler: unit -> unit) = Interop.mkPlotAttr "onTransitioning" handler
    /// Callback executed when a plot transition is interrupted.
    static member inline onTransitionInterrupted (handler: unit -> unit) = Interop.mkPlotAttr "onTransitionInterrupted" handler
    /// Callback executed when a plot item is unhovered.
    static member inline onUnhover (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onUnhover" handler

[<Erase>]
type Plotly =
    /// Create a Plotly plot component.
    static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.createPlot (createObj !!props)
