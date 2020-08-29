namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type choropleth =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkChoroplethAttr "autocolorscale" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkChoroplethAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkChoroplethAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkChoroplethAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkChoroplethAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkChoroplethAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkChoroplethAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkChoroplethAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkChoroplethAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkChoroplethAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkChoroplethAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkChoroplethAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkChoroplethAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkChoroplethAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkChoroplethAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkChoroplethAttr "customdatasrc" value
    /// Sets the key in GeoJSON features which is used as id to match the items included in the `locations` array. Only has an effect when `geojson` is set. Support nested property, for example *properties.name*.
    static member inline featureidkey (value: string) = Interop.mkChoroplethAttr "featureidkey" value
    /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
    static member inline geo (anchorId: int) = Interop.mkChoroplethAttr "geo" (sprintf "geo%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
    static member inline geo (value: string) = Interop.mkChoroplethAttr "geo" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: bool) = Interop.mkChoroplethAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<bool>) = Interop.mkChoroplethAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: System.DateTime) = Interop.mkChoroplethAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: int) = Interop.mkChoroplethAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<int>) = Interop.mkChoroplethAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: float) = Interop.mkChoroplethAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<float>) = Interop.mkChoroplethAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: string) = Interop.mkChoroplethAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<string>) = Interop.mkChoroplethAttr "geojson" (values |> ResizeArray)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IChoroplethProperty list) = Interop.mkChoroplethAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkChoroplethAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkChoroplethAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkChoroplethAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkChoroplethAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkChoroplethAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkChoroplethAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkChoroplethAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkChoroplethAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkChoroplethAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkChoroplethAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkChoroplethAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkChoroplethAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkChoroplethAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkChoroplethAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkChoroplethAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkChoroplethAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkChoroplethAttr "legendgroup" value
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (value: bool) = Interop.mkChoroplethAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<bool>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (value: System.DateTime) = Interop.mkChoroplethAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (value: float) = Interop.mkChoroplethAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<float>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (value: int) = Interop.mkChoroplethAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<int>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (value: string) = Interop.mkChoroplethAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<string>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<bool list>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<bool []>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<seq<string>>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<string list>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<string []>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<seq<int>>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<int list>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<int []>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<seq<float>>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<float list>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<float []>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<PlotData>) = Interop.mkChoroplethAttr "locations" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<bool option>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<System.DateTime option>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<int option>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<float option>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
    static member inline locations (values: seq<string option>) = Interop.mkChoroplethAttr "locations" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  locations .
    static member inline locationssrc (value: string) = Interop.mkChoroplethAttr "locationssrc" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkChoroplethAttr "marker" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkChoroplethAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkChoroplethAttr "name" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkChoroplethAttr "reversescale" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkChoroplethAttr "selected" (createObj !!properties)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkChoroplethAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkChoroplethAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkChoroplethAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkChoroplethAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkChoroplethAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkChoroplethAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkChoroplethAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkChoroplethAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkChoroplethAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkChoroplethAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkChoroplethAttr "showscale" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkChoroplethAttr "stream" (createObj !!properties)
    /// Sets the text elements associated with each location.
    static member inline text (value: string) = Interop.mkChoroplethAttr "text" value
    /// Sets the text elements associated with each location.
    static member inline text (values: seq<string>) = Interop.mkChoroplethAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkChoroplethAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkChoroplethAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkChoroplethAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkChoroplethAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkChoroplethAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkChoroplethAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkChoroplethAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkChoroplethAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkChoroplethAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkChoroplethAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkChoroplethAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkChoroplethAttr "uirevision" (values |> ResizeArray)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkChoroplethAttr "unselected" (createObj !!properties)
    /// Sets the color values.
    static member inline z (value: bool) = Interop.mkChoroplethAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<bool>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (value: System.DateTime) = Interop.mkChoroplethAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<System.DateTime>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (value: float) = Interop.mkChoroplethAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<float>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (value: int) = Interop.mkChoroplethAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<int>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (value: string) = Interop.mkChoroplethAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<string>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<seq<bool>>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<bool list>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<bool []>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<seq<string>>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<string list>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<string []>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<seq<int>>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<int list>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<int []>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<seq<float>>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<float list>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<float []>) = Interop.mkChoroplethAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<PlotData>) = Interop.mkChoroplethAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<bool option>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<int option>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<float option>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Sets the color values.
    static member inline z (values: seq<string option>) = Interop.mkChoroplethAttr "z" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkChoroplethAttr "zauto" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkChoroplethAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkChoroplethAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkChoroplethAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkChoroplethAttr "zmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkChoroplethAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkChoroplethAttr "zmin" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkChoroplethAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module choropleth =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkChoroplethAttr "hoverinfo" "all"
        static member inline none = Interop.mkChoroplethAttr "hoverinfo" "none"
        static member inline skip = Interop.mkChoroplethAttr "hoverinfo" "skip"
        static member inline location = Interop.mkChoroplethAttr "hoverinfo" "location"
        static member inline name = Interop.mkChoroplethAttr "hoverinfo" "name"
        static member inline text = Interop.mkChoroplethAttr "hoverinfo" "text"
        static member inline z = Interop.mkChoroplethAttr "hoverinfo" "z"

    /// Determines the set of locations used to match entries in `locations` to regions on the map. Values *ISO-3*, *USA-states*, *country names* correspond to features on the base map and value *geojson-id* corresponds to features from a custom GeoJSON linked to the `geojson` attribute.
    [<Erase>]
    type locationmode =
        static member inline ISO3 = Interop.mkChoroplethAttr "locationmode" "ISO-3"
        static member inline USAStates = Interop.mkChoroplethAttr "locationmode" "USA-states"
        static member inline countryNames = Interop.mkChoroplethAttr "locationmode" "country names"
        static member inline geojsonId = Interop.mkChoroplethAttr "locationmode" "geojson-id"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkChoroplethAttr "visible" "legendonly"
        static member inline false' = Interop.mkChoroplethAttr "visible" false
        static member inline true' = Interop.mkChoroplethAttr "visible" true

