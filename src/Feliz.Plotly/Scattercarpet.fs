namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattercarpet =
    /// Sets the a-axis coordinates.
    static member inline a (value: bool) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<bool>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (value: System.DateTime) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (value: float) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<float>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (value: int) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<int>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (value: string) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<string>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<seq<bool>>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<bool list>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<bool []>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<seq<string>>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<string list>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<string []>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<seq<int>>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<int list>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<int []>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<seq<float>>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<float list>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<float []>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<PlotData>) = Interop.mkScattercarpetAttr "a" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<bool option>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<System.DateTime option>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<int option>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<float option>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<string option>) = Interop.mkScattercarpetAttr "a" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  a .
    static member inline asrc (value: string) = Interop.mkScattercarpetAttr "asrc" value
    /// Sets the b-axis coordinates.
    static member inline b (value: bool) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<bool>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (value: System.DateTime) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (value: float) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<float>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (value: int) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<int>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (value: string) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<string>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<seq<bool>>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<bool list>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<bool []>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<seq<string>>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<string list>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<string []>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<seq<int>>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<int list>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<int []>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<seq<float>>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<float list>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<float []>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<PlotData>) = Interop.mkScattercarpetAttr "b" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<bool option>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<System.DateTime option>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<int option>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<float option>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<string option>) = Interop.mkScattercarpetAttr "b" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  b .
    static member inline bsrc (value: string) = Interop.mkScattercarpetAttr "bsrc" value
    /// An identifier for this carpet, so that `scattercarpet` and `contourcarpet` traces can specify a carpet plot on which they lie
    static member inline carpet (value: string) = Interop.mkScattercarpetAttr "carpet" value
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScattercarpetAttr "connectgaps" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkScattercarpetAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkScattercarpetAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScattercarpetAttr "customdatasrc" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScattercarpetAttr "fillcolor" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IScattercarpetProperty list) = Interop.mkScattercarpetAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScattercarpetAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScattercarpetAttr "hoverlabel" (createObj !!properties)
    /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
    static member inline hoveron (properties: #IScattercarpetProperty list) = Interop.mkScattercarpetAttr "hoveron" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScattercarpetAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScattercarpetAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScattercarpetAttr "hovertemplatesrc" value
    /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScattercarpetAttr "hovertext" value
    /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScattercarpetAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScattercarpetAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkScattercarpetAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkScattercarpetAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScattercarpetAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScattercarpetAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkScattercarpetAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScattercarpetAttr "marker" (createObj !!properties)
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScattercarpetAttr "metasrc" value
    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    static member inline mode (properties: #IScattercarpetProperty list) = Interop.mkScattercarpetAttr "mode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScattercarpetAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScattercarpetAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScattercarpetAttr "opacity" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScattercarpetAttr "selected" (createObj !!properties)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScattercarpetAttr "showlegend" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScattercarpetAttr "stream" (createObj !!properties)
    /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScattercarpetAttr "text" value
    /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScattercarpetAttr "text" (values |> ResizeArray)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScattercarpetAttr "textfont" (createObj !!properties)
    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    static member inline textposition (properties: #IScattercarpetProperty list) = Interop.mkScattercarpetAttr "textposition" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScattercarpetAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScattercarpetAttr "textsrc" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScattercarpetAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScattercarpetAttr "texttemplate" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScattercarpetAttr "texttemplatesrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScattercarpetAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScattercarpetAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScattercarpetAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkScattercarpetAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScattercarpetAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScattercarpetAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScattercarpetAttr "uirevision" (values |> ResizeArray)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScattercarpetAttr "unselected" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkScattercarpetAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkScattercarpetAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkScattercarpetAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkScattercarpetAttr "yaxis" value

[<RequireQualifiedAccess>]
module scattercarpet =
    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScattercarpetAttr "fill" "none"
        static member inline tonext = Interop.mkScattercarpetAttr "fill" "tonext"
        static member inline toself = Interop.mkScattercarpetAttr "fill" "toself"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScattercarpetAttr "hoverinfo" "all"
        static member inline none = Interop.mkScattercarpetAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScattercarpetAttr "hoverinfo" "skip"
        static member inline a = Interop.mkScattercarpetAttr "hoverinfo" "a"
        static member inline b = Interop.mkScattercarpetAttr "hoverinfo" "b"
        static member inline name = Interop.mkScattercarpetAttr "hoverinfo" "name"
        static member inline text = Interop.mkScattercarpetAttr "hoverinfo" "text"

    /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
    [<Erase>]
    type hoveron =
        static member inline fills = Interop.mkScattercarpetAttr "hoveron" "fills"
        static member inline points = Interop.mkScattercarpetAttr "hoveron" "points"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScattercarpetAttr "mode" "none"
        static member inline lines = Interop.mkScattercarpetAttr "mode" "lines"
        static member inline markers = Interop.mkScattercarpetAttr "mode" "markers"
        static member inline text = Interop.mkScattercarpetAttr "mode" "text"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScattercarpetAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScattercarpetAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScattercarpetAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScattercarpetAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScattercarpetAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScattercarpetAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScattercarpetAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScattercarpetAttr "textposition" "top left"
        static member inline topRight = Interop.mkScattercarpetAttr "textposition" "top right"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScattercarpetAttr "visible" "legendonly"
        static member inline false' = Interop.mkScattercarpetAttr "visible" false
        static member inline true' = Interop.mkScattercarpetAttr "visible" true

