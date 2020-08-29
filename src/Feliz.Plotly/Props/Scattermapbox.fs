namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattermapbox =
    /// Determines if this scattermapbox trace's layers are to be inserted before the layer with the specified ID. By default, scattermapbox layers are inserted above all the base layers. To place the scattermapbox layers above every other layer, set `below` to *''*.
    static member inline below (value: string) = Interop.mkScattermapboxAttr "below" value
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScattermapboxAttr "connectgaps" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScattermapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkScattermapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScattermapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScattermapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScattermapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkScattermapboxAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkScattermapboxAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScattermapboxAttr "customdatasrc" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScattermapboxAttr "fillcolor" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IScattermapboxProperty list) = Interop.mkScattermapboxAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScattermapboxAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScattermapboxAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScattermapboxAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScattermapboxAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScattermapboxAttr "hovertemplatesrc" value
    /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScattermapboxAttr "hovertext" value
    /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScattermapboxAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScattermapboxAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScattermapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkScattermapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScattermapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScattermapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScattermapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkScattermapboxAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkScattermapboxAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkScattermapboxAttr "idssrc" value
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: bool) = Interop.mkScattermapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: System.DateTime) = Interop.mkScattermapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: float) = Interop.mkScattermapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: int) = Interop.mkScattermapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: string) = Interop.mkScattermapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<bool>>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool list>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool []>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<string>>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string list>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string []>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<int>>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int list>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int []>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<float>>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float list>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float []>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<PlotData>) = Interop.mkScattermapboxAttr "lat" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool option>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<System.DateTime option>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int option>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float option>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string option>) = Interop.mkScattermapboxAttr "lat" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  lat .
    static member inline latsrc (value: string) = Interop.mkScattermapboxAttr "latsrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScattermapboxAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkScattermapboxAttr "line" (createObj !!properties)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: bool) = Interop.mkScattermapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: System.DateTime) = Interop.mkScattermapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: float) = Interop.mkScattermapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: int) = Interop.mkScattermapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: string) = Interop.mkScattermapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<bool>>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool list>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool []>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<string>>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string list>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string []>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<int>>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int list>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int []>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<float>>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float list>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float []>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<PlotData>) = Interop.mkScattermapboxAttr "lon" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool option>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<System.DateTime option>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int option>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float option>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string option>) = Interop.mkScattermapboxAttr "lon" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  lon .
    static member inline lonsrc (value: string) = Interop.mkScattermapboxAttr "lonsrc" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScattermapboxAttr "marker" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkScattermapboxAttr "metasrc" value
    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover.
    static member inline mode (properties: #IScattermapboxProperty list) = Interop.mkScattermapboxAttr "mode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScattermapboxAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScattermapboxAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScattermapboxAttr "opacity" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScattermapboxAttr "selected" (createObj !!properties)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScattermapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScattermapboxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkScattermapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScattermapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScattermapboxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScattermapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScattermapboxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScattermapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScattermapboxAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScattermapboxAttr "showlegend" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScattermapboxAttr "stream" (createObj !!properties)
    /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
    static member inline subplot (anchorId: int) = Interop.mkScattermapboxAttr "subplot" (sprintf "mapbox%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
    static member inline subplot (value: string) = Interop.mkScattermapboxAttr "subplot" value
    /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScattermapboxAttr "text" value
    /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScattermapboxAttr "text" (values |> ResizeArray)
    /// Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size). Has an effect only when `type` is set to *symbol*.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScattermapboxAttr "textfont" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkScattermapboxAttr "textsrc" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScattermapboxAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScattermapboxAttr "texttemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScattermapboxAttr "texttemplatesrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScattermapboxAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScattermapboxAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScattermapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScattermapboxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkScattermapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkScattermapboxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScattermapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScattermapboxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScattermapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScattermapboxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScattermapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScattermapboxAttr "uirevision" (values |> ResizeArray)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScattermapboxAttr "unselected" (createObj !!properties)

[<Erase;RequireQualifiedAccess>]
module scattermapbox =
    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScattermapboxAttr "fill" "none"
        static member inline toself = Interop.mkScattermapboxAttr "fill" "toself"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScattermapboxAttr "hoverinfo" "all"
        static member inline none = Interop.mkScattermapboxAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScattermapboxAttr "hoverinfo" "skip"
        static member inline lat = Interop.mkScattermapboxAttr "hoverinfo" "lat"
        static member inline lon = Interop.mkScattermapboxAttr "hoverinfo" "lon"
        static member inline name = Interop.mkScattermapboxAttr "hoverinfo" "name"
        static member inline text = Interop.mkScattermapboxAttr "hoverinfo" "text"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScattermapboxAttr "mode" "none"
        static member inline lines = Interop.mkScattermapboxAttr "mode" "lines"
        static member inline markers = Interop.mkScattermapboxAttr "mode" "markers"
        static member inline text = Interop.mkScattermapboxAttr "mode" "text"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScattermapboxAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScattermapboxAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScattermapboxAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScattermapboxAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScattermapboxAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScattermapboxAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScattermapboxAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScattermapboxAttr "textposition" "top left"
        static member inline topRight = Interop.mkScattermapboxAttr "textposition" "top right"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScattermapboxAttr "visible" "legendonly"
        static member inline false' = Interop.mkScattermapboxAttr "visible" false
        static member inline true' = Interop.mkScattermapboxAttr "visible" true

