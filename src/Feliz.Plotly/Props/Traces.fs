namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type traces =
    static member inline bar (properties: #IBarProperty list) = Interop.mkTracesAttr "bar" (createObj !!(properties @ [ unbox (Interop.mkBarAttr "type" "bar") ]))
    static member inline barpolar (properties: #IBarpolarProperty list) = Interop.mkTracesAttr "barpolar" (createObj !!(properties @ [ unbox (Interop.mkBarpolarAttr "type" "barpolar") ]))
    static member inline box (properties: #IBoxProperty list) = Interop.mkTracesAttr "box" (createObj !!(properties @ [ unbox (Interop.mkBoxAttr "type" "box") ]))
    static member inline candlestick (properties: #ICandlestickProperty list) = Interop.mkTracesAttr "candlestick" (createObj !!(properties @ [ unbox (Interop.mkCandlestickAttr "type" "candlestick") ]))
    static member inline carpet (properties: #ICarpetProperty list) = Interop.mkTracesAttr "carpet" (createObj !!(properties @ [ unbox (Interop.mkCarpetAttr "type" "carpet") ]))
    static member inline choropleth (properties: #IChoroplethProperty list) = Interop.mkTracesAttr "choropleth" (createObj !!(properties @ [ unbox (Interop.mkChoroplethAttr "type" "choropleth") ]))
    static member inline choroplethmapbox (properties: #IChoroplethmapboxProperty list) = Interop.mkTracesAttr "choroplethmapbox" (createObj !!(properties @ [ unbox (Interop.mkChoroplethmapboxAttr "type" "choroplethmapbox") ]))
    static member inline cone (properties: #IConeProperty list) = Interop.mkTracesAttr "cone" (createObj !!(properties @ [ unbox (Interop.mkConeAttr "type" "cone") ]))
    static member inline contour (properties: #IContourProperty list) = Interop.mkTracesAttr "contour" (createObj !!(properties @ [ unbox (Interop.mkContourAttr "type" "contour") ]))
    static member inline contourcarpet (properties: #IContourcarpetProperty list) = Interop.mkTracesAttr "contourcarpet" (createObj !!(properties @ [ unbox (Interop.mkContourcarpetAttr "type" "contourcarpet") ]))
    static member inline densitymapbox (properties: #IDensitymapboxProperty list) = Interop.mkTracesAttr "densitymapbox" (createObj !!(properties @ [ unbox (Interop.mkDensitymapboxAttr "type" "densitymapbox") ]))
    static member inline funnel (properties: #IFunnelProperty list) = Interop.mkTracesAttr "funnel" (createObj !!(properties @ [ unbox (Interop.mkFunnelAttr "type" "funnel") ]))
    static member inline funnelarea (properties: #IFunnelareaProperty list) = Interop.mkTracesAttr "funnelarea" (createObj !!(properties @ [ unbox (Interop.mkFunnelareaAttr "type" "funnelarea") ]))
    static member inline heatmap (properties: #IHeatmapProperty list) = Interop.mkTracesAttr "heatmap" (createObj !!(properties @ [ unbox (Interop.mkHeatmapAttr "type" "heatmap") ]))
    static member inline heatmapgl (properties: #IHeatmapglProperty list) = Interop.mkTracesAttr "heatmapgl" (createObj !!(properties @ [ unbox (Interop.mkHeatmapglAttr "type" "heatmapgl") ]))
    static member inline histogram (properties: #IHistogramProperty list) = Interop.mkTracesAttr "histogram" (createObj !!(properties @ [ unbox (Interop.mkHistogramAttr "type" "histogram") ]))
    static member inline histogram2d (properties: #IHistogram2dProperty list) = Interop.mkTracesAttr "histogram2d" (createObj !!(properties @ [ unbox (Interop.mkHistogram2dAttr "type" "histogram2d") ]))
    static member inline histogram2dcontour (properties: #IHistogram2dcontourProperty list) = Interop.mkTracesAttr "histogram2dcontour" (createObj !!(properties @ [ unbox (Interop.mkHistogram2dcontourAttr "type" "histogram2dcontour") ]))
    static member inline image (properties: #IImageProperty list) = Interop.mkTracesAttr "image" (createObj !!(properties @ [ unbox (Interop.mkImageAttr "type" "image") ]))
    static member inline indicator (properties: #IIndicatorProperty list) = Interop.mkTracesAttr "indicator" (createObj !!(properties @ [ unbox (Interop.mkIndicatorAttr "type" "indicator") ]))
    static member inline isosurface (properties: #IIsosurfaceProperty list) = Interop.mkTracesAttr "isosurface" (createObj !!(properties @ [ unbox (Interop.mkIsosurfaceAttr "type" "isosurface") ]))
    static member inline mesh3d (properties: #IMesh3dProperty list) = Interop.mkTracesAttr "mesh3d" (createObj !!(properties @ [ unbox (Interop.mkMesh3dAttr "type" "mesh3d") ]))
    static member inline ohlc (properties: #IOhlcProperty list) = Interop.mkTracesAttr "ohlc" (createObj !!(properties @ [ unbox (Interop.mkOhlcAttr "type" "ohlc") ]))
    static member inline parcats (properties: #IParcatsProperty list) = Interop.mkTracesAttr "parcats" (createObj !!(properties @ [ unbox (Interop.mkParcatsAttr "type" "parcats") ]))
    static member inline parcoords (properties: #IParcoordsProperty list) = Interop.mkTracesAttr "parcoords" (createObj !!(properties @ [ unbox (Interop.mkParcoordsAttr "type" "parcoords") ]))
    static member inline pie (properties: #IPieProperty list) = Interop.mkTracesAttr "pie" (createObj !!(properties @ [ unbox (Interop.mkPieAttr "type" "pie") ]))
    static member inline pointcloud (properties: #IPointcloudProperty list) = Interop.mkTracesAttr "pointcloud" (createObj !!(properties @ [ unbox (Interop.mkPointcloudAttr "type" "pointcloud") ]))
    static member inline sankey (properties: #ISankeyProperty list) = Interop.mkTracesAttr "sankey" (createObj !!(properties @ [ unbox (Interop.mkSankeyAttr "type" "sankey") ]))
    static member inline scatter (properties: #IScatterProperty list) = Interop.mkTracesAttr "scatter" (createObj !!(properties @ [ unbox (Interop.mkScatterAttr "type" "scatter") ]))
    static member inline scatter3d (properties: #IScatter3dProperty list) = Interop.mkTracesAttr "scatter3d" (createObj !!(properties @ [ unbox (Interop.mkScatter3dAttr "type" "scatter3d") ]))
    static member inline scattercarpet (properties: #IScattercarpetProperty list) = Interop.mkTracesAttr "scattercarpet" (createObj !!(properties @ [ unbox (Interop.mkScattercarpetAttr "type" "scattercarpet") ]))
    static member inline scattergeo (properties: #IScattergeoProperty list) = Interop.mkTracesAttr "scattergeo" (createObj !!(properties @ [ unbox (Interop.mkScattergeoAttr "type" "scattergeo") ]))
    static member inline scattergl (properties: #IScatterglProperty list) = Interop.mkTracesAttr "scattergl" (createObj !!(properties @ [ unbox (Interop.mkScatterglAttr "type" "scattergl") ]))
    static member inline scattermapbox (properties: #IScattermapboxProperty list) = Interop.mkTracesAttr "scattermapbox" (createObj !!(properties @ [ unbox (Interop.mkScattermapboxAttr "type" "scattermapbox") ]))
    static member inline scatterpolar (properties: #IScatterpolarProperty list) = Interop.mkTracesAttr "scatterpolar" (createObj !!(properties @ [ unbox (Interop.mkScatterpolarAttr "type" "scatterpolar") ]))
    static member inline scatterpolargl (properties: #IScatterpolarglProperty list) = Interop.mkTracesAttr "scatterpolargl" (createObj !!(properties @ [ unbox (Interop.mkScatterpolarglAttr "type" "scatterpolargl") ]))
    static member inline scatterternary (properties: #IScatterternaryProperty list) = Interop.mkTracesAttr "scatterternary" (createObj !!(properties @ [ unbox (Interop.mkScatterternaryAttr "type" "scatterternary") ]))
    static member inline splom (properties: #ISplomProperty list) = Interop.mkTracesAttr "splom" (createObj !!(properties @ [ unbox (Interop.mkSplomAttr "type" "splom") ]))
    static member inline streamtube (properties: #IStreamtubeProperty list) = Interop.mkTracesAttr "streamtube" (createObj !!(properties @ [ unbox (Interop.mkStreamtubeAttr "type" "streamtube") ]))
    static member inline sunburst (properties: #ISunburstProperty list) = Interop.mkTracesAttr "sunburst" (createObj !!(properties @ [ unbox (Interop.mkSunburstAttr "type" "sunburst") ]))
    static member inline surface (properties: #ISurfaceProperty list) = Interop.mkTracesAttr "surface" (createObj !!(properties @ [ unbox (Interop.mkSurfaceAttr "type" "surface") ]))
    static member inline table (properties: #ITableProperty list) = Interop.mkTracesAttr "table" (createObj !!(properties @ [ unbox (Interop.mkTableAttr "type" "table") ]))
    static member inline treemap (properties: #ITreemapProperty list) = Interop.mkTracesAttr "treemap" (createObj !!(properties @ [ unbox (Interop.mkTreemapAttr "type" "treemap") ]))
    static member inline violin (properties: #IViolinProperty list) = Interop.mkTracesAttr "violin" (createObj !!(properties @ [ unbox (Interop.mkViolinAttr "type" "violin") ]))
    static member inline volume (properties: #IVolumeProperty list) = Interop.mkTracesAttr "volume" (createObj !!(properties @ [ unbox (Interop.mkVolumeAttr "type" "volume") ]))
    static member inline waterfall (properties: #IWaterfallProperty list) = Interop.mkTracesAttr "waterfall" (createObj !!(properties @ [ unbox (Interop.mkWaterfallAttr "type" "waterfall") ]))

