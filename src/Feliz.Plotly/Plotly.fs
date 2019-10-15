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
    /// Create the plotly data sets
    static member inline data (properties: #IDataProperty list) = Interop.mkPlotAttr "data" (createObj !!properties)
    /// Create the plotly data sets
    static member data (properties: (bool * IDataProperty list) list) = Interop.mkPlotAttr "data" (properties |> Bindings.Internal.withConditionals)
    /// Create the plotly config
    static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr "config" (createObj !!properties)
    /// Create the plotly config
    static member config (properties: (bool * IConfigProperty list) list) = Interop.mkPlotAttr "config" (properties |> Bindings.Internal.withConditionals)
    /// Create the plotly layout
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr "layout" (createObj !!properties)
    /// Create the plotly layout
    static member layout (properties: (bool * ILayoutProperty list) list) = Interop.mkPlotAttr "layout" (properties |> Bindings.Internal.withConditionals)
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
    /// Styles the <div> into which the plot is rendered
    static member style (properties: (bool * IStyleAttribute list) list) = Interop.mkAttr "style" (properties |> Bindings.Internal.withConditionals)
    /// Assign the graph div to window.gd for debugging
    static member inline debug (value: bool) = Interop.mkPlotAttr "debug" value
    /// When true, adds a call to Plotly.Plot.resize() as a window.resize event handler
    static member inline useResizeHandler (value: bool) = Interop.mkPlotAttr "useResizeHandler" value
    static member inline onAfterExport (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onClick" handler
    static member inline onAfterPlot (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onAfterPlot" handler
    static member inline onAnimated (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onAnimated" handler
    static member inline onAnimatingFrame (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onAnimatingFrame" handler
    static member inline onAnimationInterrupted (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onAnimationInterrupted" handler
    static member inline onAutoSize (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onAutoSize" handler
    static member inline onBeforeExport (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onBeforeExport" handler
    static member inline onButtonClicked (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onButtonClicked" handler
    static member inline onClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onClick" handler
    static member inline onClickAnnotation (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onClickAnnotation" handler
    static member inline onDeselect (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onDeselect" handler
    static member inline onDoubleClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onDoubleClick" handler
    static member inline onFramework (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onFramework" handler
    static member inline onHover (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onHover" handler
    static member inline onLegendClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onLegendClick" handler
    static member inline onLegendDoubleClick (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onLegendDoubleClick" handler
    static member inline onRelayout (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onRelayout" handler
    static member inline onRestyle (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onRestyle" handler
    static member inline onRedraw (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onRedraw" handler
    static member inline onSelected (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onSelected" handler
    static member inline onSelecting (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onSelecting" handler
    static member inline onSliderChange (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onSliderChange" handler
    static member inline onSliderEnd (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onSliderEnd" handler
    static member inline onSliderStart (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onSliderStart" handler
    static member inline onTransitioning (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onTransitioning" handler
    static member inline onTransitionInterrupted (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onTransitionInterrupted" handler
    static member inline onUnhover (handler: MouseEvent -> unit) = Interop.mkPlotAttr "onUnhover" handler

[<Erase>]
type Plotly =
    /// Create a Plotly plot component.
    static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.Internal.createPlot (createObj !!props)
