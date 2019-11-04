namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<Erase>]
type plot =
    /// Create the plotly traces
    static member inline traces (properties: #ITracesProperty list) = Bindings.extractTraces properties
    /// Create the plotly config
    static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr "config" (createObj !!properties)
    /// Create the plotly layout
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr "layout" (createObj !!properties)
    /// When provided, causes the plot to update when the revision is incremented.
    static member inline revision (value: int) = Interop.mkPlotAttr "revision" value
    /// When provided, causes the plot to update when the revision is incremented.
    static member inline revision (value: float) = Interop.mkPlotAttr "revision" value
    /// Callback executed after plot is initialized.
    static member inline onInitialized (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr "onInitialized" handler
    /// Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.
    static member inline onUpdate (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr "onUpdate" handler
    /// Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.
    static member inline onPurge (handler: obj -> HTMLElement -> unit) = Interop.mkPlotAttr "onPurge" handler
    /// Callback executed when a plotly.js API method rejects
    static member inline onError (handler: ErrorEvent -> unit) = Interop.mkPlotAttr "onError" handler
    /// Id assigned to the <div> into which the plot is rendered.
    static member inline divId (value: string) = Interop.mkPlotAttr "divId" value
    /// Class applied to the <div> into which the plot is rendered
    static member inline className (value: string) = Interop.mkPlotAttr "className" value
    /// Styles the <div> into which the plot is rendered
    static member inline style (properties: #IStyleAttribute list) = Interop.mkAttr "style" (createObj !!properties)
    /// Assign the graph div to window.gd for debugging
    static member inline debug (value: bool) = Interop.mkPlotAttr "debug" value
    /// When true, adds a call to Plotly.Plot.resize() as a window.resize event handler
    static member inline useResizeHandler (value: bool) = Interop.mkPlotAttr "useResizeHandler" value
    static member inline onAfterExport (handler: unit -> unit) = Interop.mkPlotAttr "onClick" handler
    static member inline onAfterPlot (handler: unit -> unit) = Interop.mkPlotAttr "onAfterPlot" handler
    static member inline onAnimated (handler: unit -> unit) = Interop.mkPlotAttr "onAnimated" handler
    static member inline onAnimatingFrame (handler: Bindings.Plotly.FrameAnimationEvent -> unit) = Interop.mkPlotAttr "onAnimatingFrame" handler
    static member inline onAnimationInterrupted (handler: unit -> unit) = Interop.mkPlotAttr "onAnimationInterrupted" handler
    static member inline onAutoSize (handler: unit -> unit) = Interop.mkPlotAttr "onAutoSize" handler
    static member inline onBeforeExport (handler: unit -> unit) = Interop.mkPlotAttr "onBeforeExport" handler
    static member inline onButtonClicked (handler: Bindings.Plotly.ButtonClickEvent -> unit) = Interop.mkPlotAttr "onButtonClicked" handler
    static member inline onClick (handler: Bindings.Plotly.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onClick" handler
    static member inline onClickAnnotation (handler: Bindings.Plotly.ClickAnnotationEvent -> unit) = Interop.mkPlotAttr "onClickAnnotation" handler
    static member inline onDeselect (handler: unit -> unit) = Interop.mkPlotAttr "onDeselect" handler
    static member inline onDoubleClick (handler: unit -> unit) = Interop.mkPlotAttr "onDoubleClick" handler
    static member inline onFramework (handler: unit -> unit) = Interop.mkPlotAttr "onFramework" handler
    static member inline onHover (handler: Bindings.Plotly.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onHover" handler
    static member inline onLegendClick (handler: Bindings.Plotly.LegendClickEvent -> unit) = Interop.mkPlotAttr "onLegendClick" handler
    static member inline onLegendDoubleClick (handler: Bindings.Plotly.LegendClickEvent -> unit) = Interop.mkPlotAttr "onLegendDoubleClick" handler
    static member inline onRelayout (handler: Bindings.Plotly.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr "onRelayout" handler
    static member inline onRestyle (handler: Bindings.Plotly.PlotRestyleEvent -> unit) = Interop.mkPlotAttr "onRestyle" handler
    static member inline onRedraw (handler: unit -> unit) = Interop.mkPlotAttr "onRedraw" handler
    static member inline onSelected (handler: Bindings.Plotly.PlotSelectionEvent -> unit) = Interop.mkPlotAttr "onSelected" handler
    static member inline onSelecting (handler: Bindings.Plotly.PlotSelectionEvent -> unit) = Interop.mkPlotAttr "onSelecting" handler
    static member inline onSliderChange (handler: Bindings.Plotly.SliderChangeEvent -> unit) = Interop.mkPlotAttr "onSliderChange" handler
    static member inline onSliderEnd (handler: Bindings.Plotly.SliderEndEvent -> unit) = Interop.mkPlotAttr "onSliderEnd" handler
    static member inline onSliderStart (handler: Bindings.Plotly.SliderStartEvent -> unit) = Interop.mkPlotAttr "onSliderStart" handler
    static member inline onTransitioning (handler: unit -> unit) = Interop.mkPlotAttr "onTransitioning" handler
    static member inline onTransitionInterrupted (handler: unit -> unit) = Interop.mkPlotAttr "onTransitionInterrupted" handler
    static member inline onUnhover (handler: Bindings.Plotly.PlotMouseEvent -> unit) = Interop.mkPlotAttr "onUnhover" handler

[<Erase>]
type Plotly =
    /// Create a Plotly plot component.
    static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.createPlot (createObj !!props)
