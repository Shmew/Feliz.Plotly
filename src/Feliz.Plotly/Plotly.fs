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
type Plot =
    static member inline config (properties: #IConfigProperty list) = Interop.mkConfigAttr "config" (createObj !!properties)
    static member config (properties: (bool * IConfigProperty list) list) = Interop.mkConfigAttr "config" (properties |> Bindings.Internal.withConditionals)
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "layout" (createObj !!properties)
    static member layout (properties: (bool * ILayoutProperty list) list) = Interop.mkLayoutAttr "layout" (properties |> Bindings.Internal.withConditionals)
    static member inline data (properties: #IDataProperty list) = Interop.mkDataAttr "data" (createObj !!properties)
    static member data (properties: (bool * IDataProperty list) list) = Interop.mkDataAttr "data" (properties |> Bindings.Internal.withConditionals)
    static member inline edits (properties: #IEditsProperty list) = Interop.mkEditsAttr "edits" (createObj !!properties)
    static member edits (properties: (bool * IEditsProperty list) list) = Interop.mkEditsAttr "edits" (properties |> Bindings.Internal.withConditionals)
    static member inline font (properties: #IFontProperty list) = Interop.mkFontAttr "font" (createObj !!properties)
    static member font (properties: (bool * IFontProperty list) list) = Interop.mkFontAttr "font" (properties |> Bindings.Internal.withConditionals)
    static member inline title (properties: #ITitleProperty list) = Interop.mkTitleAttr "title" (createObj !!properties)
    static member title (properties: (bool * ITitleProperty list) list) = Interop.mkTitleAttr "title" (properties |> Bindings.Internal.withConditionals)
    static member inline margin (properties: #IMarginProperty list) = Interop.mkMarginAttr "margin" (createObj !!properties)
    static member margin (properties: (bool * IMarginProperty list) list) = Interop.mkMarginAttr "margin" (properties |> Bindings.Internal.withConditionals)
    static member inline modebar (properties: #IModebarProperty list) = Interop.mkModebarAttr "modebar" (createObj !!properties)
    static member modebar (properties: (bool * IModebarProperty list) list) = Interop.mkModebarAttr "modebar" (properties |> Bindings.Internal.withConditionals)
    static member inline transition (properties: #ITransitionProperty list) = Interop.mkTransitionAttr "transition" (createObj !!properties)
    static member transition (properties: (bool * ITransitionProperty list) list) = Interop.mkTransitionAttr "transition" (properties |> Bindings.Internal.withConditionals)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkHoverlabelAttr "hoverlabel" (createObj !!properties)
    static member hoverlabel (properties: (bool * IHoverlabelProperty list) list) = Interop.mkHoverlabelAttr "hoverlabel" (properties |> Bindings.Internal.withConditionals)
    static member inline grid (properties: #IGridProperty list) = Interop.mkGridAttr "grid" (createObj !!properties)
    static member grid (properties: (bool * IGridProperty list) list) = Interop.mkGridAttr "grid" (properties |> Bindings.Internal.withConditionals)
    static member inline xaxis (properties: #IXaxisProperty list) = Interop.mkXaxisAttr "xaxis" (createObj !!properties)
    static member xaxis (properties: (bool * IXaxisProperty list) list) = Interop.mkXaxisAttr "xaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline yaxis (properties: #IYaxisProperty list) = Interop.mkYaxisAttr "yaxis" (createObj !!properties)
    static member yaxis (properties: (bool * IYaxisProperty list) list) = Interop.mkYaxisAttr "yaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline ternary (properties: #ITernaryProperty list) = Interop.mkTernaryAttr "ternary" (createObj !!properties)
    static member ternary (properties: (bool * ITernaryProperty list) list) = Interop.mkTernaryAttr "ternary" (properties |> Bindings.Internal.withConditionals)
    static member inline scene (properties: #ISceneProperty list) = Interop.mkSceneAttr "scene" (createObj !!properties)
    static member scene (properties: (bool * ISceneProperty list) list) = Interop.mkSceneAttr "scene" (properties |> Bindings.Internal.withConditionals)
    static member inline geo (properties: #IGeoProperty list) = Interop.mkGeoAttr "geo" (createObj !!properties)
    static member geo (properties: (bool * IGeoProperty list) list) = Interop.mkGeoAttr "geo" (properties |> Bindings.Internal.withConditionals)
    static member inline mapbox (properties: #IMapboxProperty list) = Interop.mkMapboxAttr "mapbox" (createObj !!properties)
    static member mapbox (properties: (bool * IMapboxProperty list) list) = Interop.mkMapboxAttr "mapbox" (properties |> Bindings.Internal.withConditionals)
    static member inline polar (properties: #IPolarProperty list) = Interop.mkPolarAttr "polar" (createObj !!properties)
    static member polar (properties: (bool * IPolarProperty list) list) = Interop.mkPolarAttr "polar" (properties |> Bindings.Internal.withConditionals)
    static member inline radialaxis (properties: #IRadialaxisProperty list) = Interop.mkRadialaxisAttr "radialaxis" (createObj !!properties)
    static member radialaxis (properties: (bool * IRadialaxisProperty list) list) = Interop.mkRadialaxisAttr "radialaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline angularaxis (properties: #IAngularaxisProperty list) = Interop.mkAngularaxisAttr "angularaxis" (createObj !!properties)
    static member angularaxis (properties: (bool * IAngularaxisProperty list) list) = Interop.mkAngularaxisAttr "angularaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline editType (properties: #IEditTypeProperty list) = Interop.mkEditTypeAttr "editType" (createObj !!properties)
    static member editType (properties: (bool * IEditTypeProperty list) list) = Interop.mkEditTypeAttr "editType" (properties |> Bindings.Internal.withConditionals)
    static member inline legend (properties: #ILegendProperty list) = Interop.mkLegendAttr "legend" (createObj !!properties)
    static member legend (properties: (bool * ILegendProperty list) list) = Interop.mkLegendAttr "legend" (properties |> Bindings.Internal.withConditionals)
    static member inline annotations (properties: #IAnnotationsProperty list) = Interop.mkAnnotationsAttr "annotations" (createObj !!properties)
    static member annotations (properties: (bool * IAnnotationsProperty list) list) = Interop.mkAnnotationsAttr "annotations" (properties |> Bindings.Internal.withConditionals)
    static member inline shapes (properties: #IShapesProperty list) = Interop.mkShapesAttr "shapes" (createObj !!properties)
    static member shapes (properties: (bool * IShapesProperty list) list) = Interop.mkShapesAttr "shapes" (properties |> Bindings.Internal.withConditionals)
    static member inline images (properties: #IImagesProperty list) = Interop.mkImagesAttr "images" (createObj !!properties)
    static member images (properties: (bool * IImagesProperty list) list) = Interop.mkImagesAttr "images" (properties |> Bindings.Internal.withConditionals)
    static member inline updatemenus (properties: #IUpdatemenusProperty list) = Interop.mkUpdatemenusAttr "updatemenus" (createObj !!properties)
    static member updatemenus (properties: (bool * IUpdatemenusProperty list) list) = Interop.mkUpdatemenusAttr "updatemenus" (properties |> Bindings.Internal.withConditionals)
    static member inline sliders (properties: #ISlidersProperty list) = Interop.mkSlidersAttr "sliders" (createObj !!properties)
    static member sliders (properties: (bool * ISlidersProperty list) list) = Interop.mkSlidersAttr "sliders" (properties |> Bindings.Internal.withConditionals)
    static member inline colorscale (properties: #IColorscaleProperty list) = Interop.mkColorscaleAttr "colorscale" (createObj !!properties)
    static member colorscale (properties: (bool * IColorscaleProperty list) list) = Interop.mkColorscaleAttr "colorscale" (properties |> Bindings.Internal.withConditionals)
    static member inline coloraxis (properties: #IColoraxisProperty list) = Interop.mkColoraxisAttr "coloraxis" (createObj !!properties)
    static member coloraxis (properties: (bool * IColoraxisProperty list) list) = Interop.mkColoraxisAttr "coloraxis" (properties |> Bindings.Internal.withConditionals)
    static member inline scatter (properties: #IScatterProperty list) = Interop.mkScatterAttr "scatter" (createObj !!properties)
    static member scatter (properties: (bool * IScatterProperty list) list) = Interop.mkScatterAttr "scatter" (properties |> Bindings.Internal.withConditionals)
    static member inline bar (properties: #IBarProperty list) = Interop.mkBarAttr "bar" (createObj !!properties)
    static member bar (properties: (bool * IBarProperty list) list) = Interop.mkBarAttr "bar" (properties |> Bindings.Internal.withConditionals)
    static member inline box (properties: #IBoxProperty list) = Interop.mkBoxAttr "box" (createObj !!properties)
    static member box (properties: (bool * IBoxProperty list) list) = Interop.mkBoxAttr "box" (properties |> Bindings.Internal.withConditionals)
    static member inline heatmap (properties: #IHeatmapProperty list) = Interop.mkHeatmapAttr "heatmap" (createObj !!properties)
    static member heatmap (properties: (bool * IHeatmapProperty list) list) = Interop.mkHeatmapAttr "heatmap" (properties |> Bindings.Internal.withConditionals)
    static member inline histogram (properties: #IHistogramProperty list) = Interop.mkHistogramAttr "histogram" (createObj !!properties)
    static member histogram (properties: (bool * IHistogramProperty list) list) = Interop.mkHistogramAttr "histogram" (properties |> Bindings.Internal.withConditionals)
    static member inline histogram2d (properties: #IHistogram2dProperty list) = Interop.mkHistogram2dAttr "histogram2d" (createObj !!properties)
    static member histogram2d (properties: (bool * IHistogram2dProperty list) list) = Interop.mkHistogram2dAttr "histogram2d" (properties |> Bindings.Internal.withConditionals)
    static member inline histogram2dcontour (properties: #IHistogram2dcontourProperty list) = Interop.mkHistogram2dcontourAttr "histogram2dcontour" (createObj !!properties)
    static member histogram2dcontour (properties: (bool * IHistogram2dcontourProperty list) list) = Interop.mkHistogram2dcontourAttr "histogram2dcontour" (properties |> Bindings.Internal.withConditionals)
    static member inline contour (properties: #IContourProperty list) = Interop.mkContourAttr "contour" (createObj !!properties)
    static member contour (properties: (bool * IContourProperty list) list) = Interop.mkContourAttr "contour" (properties |> Bindings.Internal.withConditionals)
    static member inline scatterternary (properties: #IScatterternaryProperty list) = Interop.mkScatterternaryAttr "scatterternary" (createObj !!properties)
    static member scatterternary (properties: (bool * IScatterternaryProperty list) list) = Interop.mkScatterternaryAttr "scatterternary" (properties |> Bindings.Internal.withConditionals)
    static member inline violin (properties: #IViolinProperty list) = Interop.mkViolinAttr "violin" (createObj !!properties)
    static member violin (properties: (bool * IViolinProperty list) list) = Interop.mkViolinAttr "violin" (properties |> Bindings.Internal.withConditionals)
    static member inline funnel (properties: #IFunnelProperty list) = Interop.mkFunnelAttr "funnel" (createObj !!properties)
    static member funnel (properties: (bool * IFunnelProperty list) list) = Interop.mkFunnelAttr "funnel" (properties |> Bindings.Internal.withConditionals)
    static member inline waterfall (properties: #IWaterfallProperty list) = Interop.mkWaterfallAttr "waterfall" (createObj !!properties)
    static member waterfall (properties: (bool * IWaterfallProperty list) list) = Interop.mkWaterfallAttr "waterfall" (properties |> Bindings.Internal.withConditionals)
    static member inline pie (properties: #IPieProperty list) = Interop.mkPieAttr "pie" (createObj !!properties)
    static member pie (properties: (bool * IPieProperty list) list) = Interop.mkPieAttr "pie" (properties |> Bindings.Internal.withConditionals)
    static member inline sunburst (properties: #ISunburstProperty list) = Interop.mkSunburstAttr "sunburst" (createObj !!properties)
    static member sunburst (properties: (bool * ISunburstProperty list) list) = Interop.mkSunburstAttr "sunburst" (properties |> Bindings.Internal.withConditionals)
    static member inline treemap (properties: #ITreemapProperty list) = Interop.mkTreemapAttr "treemap" (createObj !!properties)
    static member treemap (properties: (bool * ITreemapProperty list) list) = Interop.mkTreemapAttr "treemap" (properties |> Bindings.Internal.withConditionals)
    static member inline funnelarea (properties: #IFunnelareaProperty list) = Interop.mkFunnelareaAttr "funnelarea" (createObj !!properties)
    static member funnelarea (properties: (bool * IFunnelareaProperty list) list) = Interop.mkFunnelareaAttr "funnelarea" (properties |> Bindings.Internal.withConditionals)
    static member inline scatter3d (properties: #IScatter3dProperty list) = Interop.mkScatter3dAttr "scatter3d" (createObj !!properties)
    static member scatter3d (properties: (bool * IScatter3dProperty list) list) = Interop.mkScatter3dAttr "scatter3d" (properties |> Bindings.Internal.withConditionals)
    static member inline surface (properties: #ISurfaceProperty list) = Interop.mkSurfaceAttr "surface" (createObj !!properties)
    static member surface (properties: (bool * ISurfaceProperty list) list) = Interop.mkSurfaceAttr "surface" (properties |> Bindings.Internal.withConditionals)
    static member inline isosurface (properties: #IIsosurfaceProperty list) = Interop.mkIsosurfaceAttr "isosurface" (createObj !!properties)
    static member isosurface (properties: (bool * IIsosurfaceProperty list) list) = Interop.mkIsosurfaceAttr "isosurface" (properties |> Bindings.Internal.withConditionals)
    static member inline volume (properties: #IVolumeProperty list) = Interop.mkVolumeAttr "volume" (createObj !!properties)
    static member volume (properties: (bool * IVolumeProperty list) list) = Interop.mkVolumeAttr "volume" (properties |> Bindings.Internal.withConditionals)
    static member inline mesh3d (properties: #IMesh3dProperty list) = Interop.mkMesh3dAttr "mesh3d" (createObj !!properties)
    static member mesh3d (properties: (bool * IMesh3dProperty list) list) = Interop.mkMesh3dAttr "mesh3d" (properties |> Bindings.Internal.withConditionals)
    static member inline cone (properties: #IConeProperty list) = Interop.mkConeAttr "cone" (createObj !!properties)
    static member cone (properties: (bool * IConeProperty list) list) = Interop.mkConeAttr "cone" (properties |> Bindings.Internal.withConditionals)
    static member inline streamtube (properties: #IStreamtubeProperty list) = Interop.mkStreamtubeAttr "streamtube" (createObj !!properties)
    static member streamtube (properties: (bool * IStreamtubeProperty list) list) = Interop.mkStreamtubeAttr "streamtube" (properties |> Bindings.Internal.withConditionals)
    static member inline scattergeo (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "scattergeo" (createObj !!properties)
    static member scattergeo (properties: (bool * IScattergeoProperty list) list) = Interop.mkScattergeoAttr "scattergeo" (properties |> Bindings.Internal.withConditionals)
    static member inline choropleth (properties: #IChoroplethProperty list) = Interop.mkChoroplethAttr "choropleth" (createObj !!properties)
    static member choropleth (properties: (bool * IChoroplethProperty list) list) = Interop.mkChoroplethAttr "choropleth" (properties |> Bindings.Internal.withConditionals)
    static member inline scattergl (properties: #IScatterglProperty list) = Interop.mkScatterglAttr "scattergl" (createObj !!properties)
    static member scattergl (properties: (bool * IScatterglProperty list) list) = Interop.mkScatterglAttr "scattergl" (properties |> Bindings.Internal.withConditionals)
    static member inline splom (properties: #ISplomProperty list) = Interop.mkSplomAttr "splom" (createObj !!properties)
    static member splom (properties: (bool * ISplomProperty list) list) = Interop.mkSplomAttr "splom" (properties |> Bindings.Internal.withConditionals)
    static member inline pointcloud (properties: #IPointcloudProperty list) = Interop.mkPointcloudAttr "pointcloud" (createObj !!properties)
    static member pointcloud (properties: (bool * IPointcloudProperty list) list) = Interop.mkPointcloudAttr "pointcloud" (properties |> Bindings.Internal.withConditionals)
    static member inline heatmapgl (properties: #IHeatmapglProperty list) = Interop.mkHeatmapglAttr "heatmapgl" (createObj !!properties)
    static member heatmapgl (properties: (bool * IHeatmapglProperty list) list) = Interop.mkHeatmapglAttr "heatmapgl" (properties |> Bindings.Internal.withConditionals)
    static member inline parcoords (properties: #IParcoordsProperty list) = Interop.mkParcoordsAttr "parcoords" (createObj !!properties)
    static member parcoords (properties: (bool * IParcoordsProperty list) list) = Interop.mkParcoordsAttr "parcoords" (properties |> Bindings.Internal.withConditionals)
    static member inline parcats (properties: #IParcatsProperty list) = Interop.mkParcatsAttr "parcats" (createObj !!properties)
    static member parcats (properties: (bool * IParcatsProperty list) list) = Interop.mkParcatsAttr "parcats" (properties |> Bindings.Internal.withConditionals)
    static member inline scattermapbox (properties: #IScattermapboxProperty list) = Interop.mkScattermapboxAttr "scattermapbox" (createObj !!properties)
    static member scattermapbox (properties: (bool * IScattermapboxProperty list) list) = Interop.mkScattermapboxAttr "scattermapbox" (properties |> Bindings.Internal.withConditionals)
    static member inline choroplethmapbox (properties: #IChoroplethmapboxProperty list) = Interop.mkChoroplethmapboxAttr "choroplethmapbox" (createObj !!properties)
    static member choroplethmapbox (properties: (bool * IChoroplethmapboxProperty list) list) = Interop.mkChoroplethmapboxAttr "choroplethmapbox" (properties |> Bindings.Internal.withConditionals)
    static member inline densitymapbox (properties: #IDensitymapboxProperty list) = Interop.mkDensitymapboxAttr "densitymapbox" (createObj !!properties)
    static member densitymapbox (properties: (bool * IDensitymapboxProperty list) list) = Interop.mkDensitymapboxAttr "densitymapbox" (properties |> Bindings.Internal.withConditionals)
    static member inline sankey (properties: #ISankeyProperty list) = Interop.mkSankeyAttr "sankey" (createObj !!properties)
    static member sankey (properties: (bool * ISankeyProperty list) list) = Interop.mkSankeyAttr "sankey" (properties |> Bindings.Internal.withConditionals)
    static member inline indicator (properties: #IIndicatorProperty list) = Interop.mkIndicatorAttr "indicator" (createObj !!properties)
    static member indicator (properties: (bool * IIndicatorProperty list) list) = Interop.mkIndicatorAttr "indicator" (properties |> Bindings.Internal.withConditionals)
    static member inline table (properties: #ITableProperty list) = Interop.mkTableAttr "table" (createObj !!properties)
    static member table (properties: (bool * ITableProperty list) list) = Interop.mkTableAttr "table" (properties |> Bindings.Internal.withConditionals)
    static member inline carpet (properties: #ICarpetProperty list) = Interop.mkCarpetAttr "carpet" (createObj !!properties)
    static member carpet (properties: (bool * ICarpetProperty list) list) = Interop.mkCarpetAttr "carpet" (properties |> Bindings.Internal.withConditionals)
    static member inline scattercarpet (properties: #IScattercarpetProperty list) = Interop.mkScattercarpetAttr "scattercarpet" (createObj !!properties)
    static member scattercarpet (properties: (bool * IScattercarpetProperty list) list) = Interop.mkScattercarpetAttr "scattercarpet" (properties |> Bindings.Internal.withConditionals)
    static member inline contourcarpet (properties: #IContourcarpetProperty list) = Interop.mkContourcarpetAttr "contourcarpet" (createObj !!properties)
    static member contourcarpet (properties: (bool * IContourcarpetProperty list) list) = Interop.mkContourcarpetAttr "contourcarpet" (properties |> Bindings.Internal.withConditionals)
    static member inline ohlc (properties: #IOhlcProperty list) = Interop.mkOhlcAttr "ohlc" (createObj !!properties)
    static member ohlc (properties: (bool * IOhlcProperty list) list) = Interop.mkOhlcAttr "ohlc" (properties |> Bindings.Internal.withConditionals)
    static member inline candlestick (properties: #ICandlestickProperty list) = Interop.mkCandlestickAttr "candlestick" (createObj !!properties)
    static member candlestick (properties: (bool * ICandlestickProperty list) list) = Interop.mkCandlestickAttr "candlestick" (properties |> Bindings.Internal.withConditionals)
    static member inline scatterpolar (properties: #IScatterpolarProperty list) = Interop.mkScatterpolarAttr "scatterpolar" (createObj !!properties)
    static member scatterpolar (properties: (bool * IScatterpolarProperty list) list) = Interop.mkScatterpolarAttr "scatterpolar" (properties |> Bindings.Internal.withConditionals)
    static member inline scatterpolargl (properties: #IScatterpolarglProperty list) = Interop.mkScatterpolarglAttr "scatterpolargl" (createObj !!properties)
    static member scatterpolargl (properties: (bool * IScatterpolarglProperty list) list) = Interop.mkScatterpolarglAttr "scatterpolargl" (properties |> Bindings.Internal.withConditionals)
    static member inline barpolar (properties: #IBarpolarProperty list) = Interop.mkBarpolarAttr "barpolar" (createObj !!properties)
    static member barpolar (properties: (bool * IBarpolarProperty list) list) = Interop.mkBarpolarAttr "barpolar" (properties |> Bindings.Internal.withConditionals)
    static member inline area (properties: #IAreaProperty list) = Interop.mkAreaAttr "area" (createObj !!properties)
    static member area (properties: (bool * IAreaProperty list) list) = Interop.mkAreaAttr "area" (properties |> Bindings.Internal.withConditionals)
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
