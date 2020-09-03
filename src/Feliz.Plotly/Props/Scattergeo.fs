namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattergeo =
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScattergeoAttr "connectgaps" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkScattergeoAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScattergeoAttr "customdatasrc" value
    /// Sets the key in GeoJSON features which is used as id to match the items included in the `locations` array. Only has an effect when `geojson` is set. Support nested property, for example *properties.name*.
    static member inline featureidkey (value: string) = Interop.mkScattergeoAttr "featureidkey" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScattergeoAttr "fillcolor" value
    /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
    static member inline geo (anchorId: int) = Interop.mkScattergeoAttr "geo" (sprintf "geo%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
    static member inline geo (value: string) = Interop.mkScattergeoAttr "geo" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: bool) = Interop.mkScattergeoAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<bool>) = Interop.mkScattergeoAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: System.DateTime) = Interop.mkScattergeoAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: int) = Interop.mkScattergeoAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<int>) = Interop.mkScattergeoAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: float) = Interop.mkScattergeoAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<float>) = Interop.mkScattergeoAttr "geojson" (values |> ResizeArray)
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (value: string) = Interop.mkScattergeoAttr "geojson" value
    /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used when `locations` is set. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
    static member inline geojson (values: seq<string>) = Interop.mkScattergeoAttr "geojson" (values |> ResizeArray)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScattergeoAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScattergeoAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScattergeoAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScattergeoAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScattergeoAttr "hovertemplatesrc" value
    /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScattergeoAttr "hovertext" value
    /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScattergeoAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScattergeoAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkScattergeoAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkScattergeoAttr "idssrc" value
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: bool) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: System.DateTime) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: float) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: int) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: string) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool []>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<string>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string []>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<int>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int []>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<float>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float []>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<PlotData>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool option>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<System.DateTime option>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int option>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float option>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string option>) = Interop.mkScattergeoAttr "lat" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  lat .
    static member inline latsrc (value: string) = Interop.mkScattergeoAttr "latsrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScattergeoAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkScattergeoAttr "line" (createObj !!properties)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: bool) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: System.DateTime) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: float) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: int) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: string) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool []>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<string>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string []>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<int>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int []>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<float>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float []>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<PlotData>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool option>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<System.DateTime option>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int option>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float option>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string option>) = Interop.mkScattergeoAttr "locations" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  locations .
    static member inline locationssrc (value: string) = Interop.mkScattergeoAttr "locationssrc" value
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: bool) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: System.DateTime) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: float) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: int) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: string) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool []>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<string>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string []>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<int>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int []>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<float>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float []>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<PlotData>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool option>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<System.DateTime option>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int option>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float option>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string option>) = Interop.mkScattergeoAttr "lon" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  lon .
    static member inline lonsrc (value: string) = Interop.mkScattergeoAttr "lonsrc" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScattergeoAttr "marker" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkScattergeoAttr "metasrc" value
    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    static member inline mode (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "mode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScattergeoAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScattergeoAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScattergeoAttr "opacity" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScattergeoAttr "selected" (createObj !!properties)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScattergeoAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScattergeoAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScattergeoAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScattergeoAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScattergeoAttr "showlegend" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScattergeoAttr "stream" (createObj !!properties)
    /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScattergeoAttr "text" value
    /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScattergeoAttr "text" (values |> ResizeArray)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScattergeoAttr "textfont" (createObj !!properties)
    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    static member inline textposition (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "textposition" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScattergeoAttr "textpositionsrc" value
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkScattergeoAttr "textsrc" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScattergeoAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScattergeoAttr "texttemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScattergeoAttr "texttemplatesrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScattergeoAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScattergeoAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScattergeoAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkScattergeoAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScattergeoAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScattergeoAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScattergeoAttr "uirevision" (values |> ResizeArray)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScattergeoAttr "unselected" (createObj !!properties)

[<Erase;RequireQualifiedAccess>]
module scattergeo =
    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScattergeoAttr "fill" "none"
        static member inline toself = Interop.mkScattergeoAttr "fill" "toself"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScattergeoAttr "hoverinfo" "all"
        static member inline none = Interop.mkScattergeoAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScattergeoAttr "hoverinfo" "skip"
        static member inline lat = Interop.mkScattergeoAttr "hoverinfo" "lat"
        static member inline location = Interop.mkScattergeoAttr "hoverinfo" "location"
        static member inline lon = Interop.mkScattergeoAttr "hoverinfo" "lon"
        static member inline name = Interop.mkScattergeoAttr "hoverinfo" "name"
        static member inline text = Interop.mkScattergeoAttr "hoverinfo" "text"

    /// Determines the set of locations used to match entries in `locations` to regions on the map. Values *ISO-3*, *USA-states*, *country names* correspond to features on the base map and value *geojson-id* corresponds to features from a custom GeoJSON linked to the `geojson` attribute.
    [<Erase>]
    type locationmode =
        static member inline ISO3 = Interop.mkScattergeoAttr "locationmode" "ISO-3"
        static member inline USAStates = Interop.mkScattergeoAttr "locationmode" "USA-states"
        static member inline countryNames = Interop.mkScattergeoAttr "locationmode" "country names"
        static member inline geojsonId = Interop.mkScattergeoAttr "locationmode" "geojson-id"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScattergeoAttr "mode" "none"
        static member inline lines = Interop.mkScattergeoAttr "mode" "lines"
        static member inline markers = Interop.mkScattergeoAttr "mode" "markers"
        static member inline text = Interop.mkScattergeoAttr "mode" "text"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScattergeoAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScattergeoAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScattergeoAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScattergeoAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScattergeoAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScattergeoAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScattergeoAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScattergeoAttr "textposition" "top left"
        static member inline topRight = Interop.mkScattergeoAttr "textposition" "top right"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScattergeoAttr "visible" "legendonly"
        static member inline false' = Interop.mkScattergeoAttr "visible" false
        static member inline true' = Interop.mkScattergeoAttr "visible" true

