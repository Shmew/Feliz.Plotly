namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type box =
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkBoxAttr "alignmentgroup" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkBoxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkBoxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkBoxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkBoxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkBoxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkBoxAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkBoxAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkBoxAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkBoxAttr "customdatasrc" value
    /// Sets the x coordinate step for multi-box traces set using q1/median/q3.
    static member inline dx (value: int) = Interop.mkBoxAttr "dx" value
    /// Sets the x coordinate step for multi-box traces set using q1/median/q3.
    static member inline dx (value: float) = Interop.mkBoxAttr "dx" value
    /// Sets the y coordinate step for multi-box traces set using q1/median/q3.
    static member inline dy (value: int) = Interop.mkBoxAttr "dy" value
    /// Sets the y coordinate step for multi-box traces set using q1/median/q3.
    static member inline dy (value: float) = Interop.mkBoxAttr "dy" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkBoxAttr "fillcolor" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IBoxProperty list) = Interop.mkBoxAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkBoxAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkBoxAttr "hoverlabel" (createObj !!properties)
    /// Do the hover effects highlight individual boxes  or sample points or both?
    static member inline hoveron (properties: #IBoxProperty list) = Interop.mkBoxAttr "hoveron" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkBoxAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkBoxAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkBoxAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkBoxAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkBoxAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkBoxAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkBoxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkBoxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkBoxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkBoxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkBoxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkBoxAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkBoxAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkBoxAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkBoxAttr "idssrc" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
    static member inline jitter (value: int) = Interop.mkBoxAttr "jitter" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
    static member inline jitter (value: float) = Interop.mkBoxAttr "jitter" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkBoxAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkBoxAttr "line" (createObj !!properties)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (value: bool) = Interop.mkBoxAttr "lowerfence" (value |> Array.singleton)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<bool>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (value: System.DateTime) = Interop.mkBoxAttr "lowerfence" (value |> Array.singleton)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<System.DateTime>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (value: float) = Interop.mkBoxAttr "lowerfence" (value |> Array.singleton)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<float>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (value: int) = Interop.mkBoxAttr "lowerfence" (value |> Array.singleton)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<int>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (value: string) = Interop.mkBoxAttr "lowerfence" (value |> Array.singleton)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<string>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<seq<bool>>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<bool list>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<bool []>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<seq<string>>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<string list>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<string []>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<seq<int>>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<int list>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<int []>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<seq<float>>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<float list>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<float []>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<PlotData>) = Interop.mkBoxAttr "lowerfence" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<bool option>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<System.DateTime option>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<int option>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<float option>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the lower fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `lowerfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point below 1.5 times the IQR.
    static member inline lowerfence (values: seq<string option>) = Interop.mkBoxAttr "lowerfence" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  lowerfence .
    static member inline lowerfencesrc (value: string) = Interop.mkBoxAttr "lowerfencesrc" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkBoxAttr "marker" (createObj !!properties)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (value: bool) = Interop.mkBoxAttr "mean" (value |> Array.singleton)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<bool>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (value: System.DateTime) = Interop.mkBoxAttr "mean" (value |> Array.singleton)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<System.DateTime>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (value: float) = Interop.mkBoxAttr "mean" (value |> Array.singleton)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<float>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (value: int) = Interop.mkBoxAttr "mean" (value |> Array.singleton)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<int>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (value: string) = Interop.mkBoxAttr "mean" (value |> Array.singleton)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<string>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<seq<bool>>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<bool list>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<bool []>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<seq<string>>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<string list>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<string []>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<seq<int>>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<int list>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<int []>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<seq<float>>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<float list>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<float []>) = Interop.mkBoxAttr "mean" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<PlotData>) = Interop.mkBoxAttr "mean" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<bool option>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<System.DateTime option>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<int option>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<float option>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the mean values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `mean` is not provided but a sample (in `y` or `x`) is set, we compute the mean for each box using the sample values.
    static member inline mean (values: seq<string option>) = Interop.mkBoxAttr "mean" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  mean .
    static member inline meansrc (value: string) = Interop.mkBoxAttr "meansrc" value
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (value: bool) = Interop.mkBoxAttr "median" (value |> Array.singleton)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<bool>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (value: System.DateTime) = Interop.mkBoxAttr "median" (value |> Array.singleton)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<System.DateTime>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (value: float) = Interop.mkBoxAttr "median" (value |> Array.singleton)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<float>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (value: int) = Interop.mkBoxAttr "median" (value |> Array.singleton)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<int>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (value: string) = Interop.mkBoxAttr "median" (value |> Array.singleton)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<string>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<seq<bool>>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<bool list>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<bool []>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<seq<string>>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<string list>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<string []>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<seq<int>>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<int list>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<int []>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<seq<float>>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<float list>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<float []>) = Interop.mkBoxAttr "median" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<PlotData>) = Interop.mkBoxAttr "median" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<bool option>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<System.DateTime option>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<int option>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<float option>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the median values. There should be as many items as the number of boxes desired.
    static member inline median (values: seq<string option>) = Interop.mkBoxAttr "median" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  median .
    static member inline mediansrc (value: string) = Interop.mkBoxAttr "mediansrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkBoxAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover. For box traces, the name will also be used for the position coordinate, if `x` and `x0` (`y` and `y0` if horizontal) are missing and the position axis is categorical
    static member inline name (value: string) = Interop.mkBoxAttr "name" value
    /// Determines whether or not notches are drawn. Notches displays a confidence interval around the median. We compute the confidence interval as median +/- 1.57 * IQR / sqrt(N), where IQR is the interquartile range and N is the sample size. If two boxes' notches do not overlap there is 95% confidence their medians differ. See https://sites.google.com/site/davidsstatistics/home/notched-box-plots for more info. Defaults to *false* unless `notchwidth` or `notchspan` is set.
    static member inline notched (value: bool) = Interop.mkBoxAttr "notched" value
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (value: bool) = Interop.mkBoxAttr "notchspan" (value |> Array.singleton)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<bool>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (value: System.DateTime) = Interop.mkBoxAttr "notchspan" (value |> Array.singleton)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<System.DateTime>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (value: float) = Interop.mkBoxAttr "notchspan" (value |> Array.singleton)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<float>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (value: int) = Interop.mkBoxAttr "notchspan" (value |> Array.singleton)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<int>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (value: string) = Interop.mkBoxAttr "notchspan" (value |> Array.singleton)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<string>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<seq<bool>>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<bool list>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<bool []>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<seq<string>>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<string list>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<string []>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<seq<int>>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<int list>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<int []>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<seq<float>>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<float list>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<float []>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<PlotData>) = Interop.mkBoxAttr "notchspan" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<bool option>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<System.DateTime option>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<int option>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<float option>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the notch span from the boxes' `median` values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `notchspan` is not provided but a sample (in `y` or `x`) is set, we compute it as 1.57 * IQR / sqrt(N), where N is the sample size.
    static member inline notchspan (values: seq<string option>) = Interop.mkBoxAttr "notchspan" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  notchspan .
    static member inline notchspansrc (value: string) = Interop.mkBoxAttr "notchspansrc" value
    /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
    static member inline notchwidth (value: int) = Interop.mkBoxAttr "notchwidth" value
    /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
    static member inline notchwidth (value: float) = Interop.mkBoxAttr "notchwidth" value
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkBoxAttr "offsetgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkBoxAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkBoxAttr "opacity" value
    /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
    static member inline pointpos (value: int) = Interop.mkBoxAttr "pointpos" value
    /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
    static member inline pointpos (value: float) = Interop.mkBoxAttr "pointpos" value
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (value: bool) = Interop.mkBoxAttr "q1" (value |> Array.singleton)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<bool>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (value: System.DateTime) = Interop.mkBoxAttr "q1" (value |> Array.singleton)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<System.DateTime>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (value: float) = Interop.mkBoxAttr "q1" (value |> Array.singleton)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<float>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (value: int) = Interop.mkBoxAttr "q1" (value |> Array.singleton)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<int>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (value: string) = Interop.mkBoxAttr "q1" (value |> Array.singleton)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<string>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<seq<bool>>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<bool list>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<bool []>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<seq<string>>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<string list>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<string []>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<seq<int>>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<int list>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<int []>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<seq<float>>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<float list>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<float []>) = Interop.mkBoxAttr "q1" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<PlotData>) = Interop.mkBoxAttr "q1" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<bool option>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<System.DateTime option>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<int option>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<float option>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the Quartile 1 values. There should be as many items as the number of boxes desired.
    static member inline q1 (values: seq<string option>) = Interop.mkBoxAttr "q1" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  q1 .
    static member inline q1src (value: string) = Interop.mkBoxAttr "q1src" value
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (value: bool) = Interop.mkBoxAttr "q3" (value |> Array.singleton)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<bool>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (value: System.DateTime) = Interop.mkBoxAttr "q3" (value |> Array.singleton)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<System.DateTime>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (value: float) = Interop.mkBoxAttr "q3" (value |> Array.singleton)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<float>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (value: int) = Interop.mkBoxAttr "q3" (value |> Array.singleton)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<int>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (value: string) = Interop.mkBoxAttr "q3" (value |> Array.singleton)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<string>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<seq<bool>>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<bool list>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<bool []>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<seq<string>>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<string list>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<string []>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<seq<int>>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<int list>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<int []>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<seq<float>>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<float list>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<float []>) = Interop.mkBoxAttr "q3" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<PlotData>) = Interop.mkBoxAttr "q3" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<bool option>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<System.DateTime option>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<int option>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<float option>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the Quartile 3 values. There should be as many items as the number of boxes desired.
    static member inline q3 (values: seq<string option>) = Interop.mkBoxAttr "q3" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  q3 .
    static member inline q3src (value: string) = Interop.mkBoxAttr "q3src" value
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (value: bool) = Interop.mkBoxAttr "sd" (value |> Array.singleton)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<bool>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (value: System.DateTime) = Interop.mkBoxAttr "sd" (value |> Array.singleton)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<System.DateTime>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (value: float) = Interop.mkBoxAttr "sd" (value |> Array.singleton)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<float>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (value: int) = Interop.mkBoxAttr "sd" (value |> Array.singleton)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<int>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (value: string) = Interop.mkBoxAttr "sd" (value |> Array.singleton)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<string>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<seq<bool>>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<bool list>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<bool []>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<seq<string>>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<string list>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<string []>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<seq<int>>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<int list>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<int []>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<seq<float>>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<float list>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<float []>) = Interop.mkBoxAttr "sd" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<PlotData>) = Interop.mkBoxAttr "sd" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<bool option>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<System.DateTime option>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<int option>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<float option>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the standard deviation values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `sd` is not provided but a sample (in `y` or `x`) is set, we compute the standard deviation for each box using the sample values.
    static member inline sd (values: seq<string option>) = Interop.mkBoxAttr "sd" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  sd .
    static member inline sdsrc (value: string) = Interop.mkBoxAttr "sdsrc" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkBoxAttr "selected" (createObj !!properties)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkBoxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkBoxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkBoxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkBoxAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkBoxAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkBoxAttr "showlegend" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkBoxAttr "stream" (createObj !!properties)
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (value: string) = Interop.mkBoxAttr "text" value
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (values: seq<string>) = Interop.mkBoxAttr "text" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkBoxAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkBoxAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkBoxAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkBoxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkBoxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkBoxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkBoxAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkBoxAttr "uirevision" (values |> ResizeArray)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkBoxAttr "unselected" (createObj !!properties)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (value: bool) = Interop.mkBoxAttr "upperfence" (value |> Array.singleton)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<bool>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (value: System.DateTime) = Interop.mkBoxAttr "upperfence" (value |> Array.singleton)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<System.DateTime>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (value: float) = Interop.mkBoxAttr "upperfence" (value |> Array.singleton)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<float>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (value: int) = Interop.mkBoxAttr "upperfence" (value |> Array.singleton)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<int>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (value: string) = Interop.mkBoxAttr "upperfence" (value |> Array.singleton)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<string>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<seq<bool>>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<bool list>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<bool []>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<seq<string>>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<string list>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<string []>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<seq<int>>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<int list>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<int []>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<seq<float>>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<float list>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<float []>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<PlotData>) = Interop.mkBoxAttr "upperfence" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<bool option>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<System.DateTime option>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<int option>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<float option>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the upper fence values. There should be as many items as the number of boxes desired. This attribute has effect only under the q1/median/q3 signature. If `upperfence` is not provided but a sample (in `y` or `x`) is set, we compute the lower as the last sample point above 1.5 times the IQR.
    static member inline upperfence (values: seq<string option>) = Interop.mkBoxAttr "upperfence" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  upperfence .
    static member inline upperfencesrc (value: string) = Interop.mkBoxAttr "upperfencesrc" value
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: int) = Interop.mkBoxAttr "whiskerwidth" value
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: float) = Interop.mkBoxAttr "whiskerwidth" value
    /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
    static member inline width (value: int) = Interop.mkBoxAttr "width" value
    /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
    static member inline width (value: float) = Interop.mkBoxAttr "width" value
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (value: bool) = Interop.mkBoxAttr "x" (value |> Array.singleton)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (value: System.DateTime) = Interop.mkBoxAttr "x" (value |> Array.singleton)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<System.DateTime>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (value: float) = Interop.mkBoxAttr "x" (value |> Array.singleton)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (value: int) = Interop.mkBoxAttr "x" (value |> Array.singleton)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (value: string) = Interop.mkBoxAttr "x" (value |> Array.singleton)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<seq<bool>>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool list>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool []>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<seq<string>>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string list>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string []>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<seq<int>>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int list>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int []>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<seq<float>>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float list>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float []>) = Interop.mkBoxAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<PlotData>) = Interop.mkBoxAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool option>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int option>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float option>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string option>) = Interop.mkBoxAttr "x" (values |> ResizeArray)
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (value: bool) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (values: seq<bool>) = Interop.mkBoxAttr "x0" (values |> ResizeArray)
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (value: System.DateTime) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkBoxAttr "x0" (values |> ResizeArray)
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (value: int) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (values: seq<int>) = Interop.mkBoxAttr "x0" (values |> ResizeArray)
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (value: float) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (values: seq<float>) = Interop.mkBoxAttr "x0" (values |> ResizeArray)
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (value: string) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline x0 (values: seq<string>) = Interop.mkBoxAttr "x0" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkBoxAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkBoxAttr "xaxis" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkBoxAttr "xsrc" value
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (value: bool) = Interop.mkBoxAttr "y" (value |> Array.singleton)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (value: System.DateTime) = Interop.mkBoxAttr "y" (value |> Array.singleton)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<System.DateTime>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (value: float) = Interop.mkBoxAttr "y" (value |> Array.singleton)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (value: int) = Interop.mkBoxAttr "y" (value |> Array.singleton)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (value: string) = Interop.mkBoxAttr "y" (value |> Array.singleton)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<seq<bool>>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool list>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool []>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<seq<string>>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string list>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string []>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<seq<int>>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int list>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int []>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<seq<float>>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float list>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float []>) = Interop.mkBoxAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<PlotData>) = Interop.mkBoxAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool option>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int option>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float option>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string option>) = Interop.mkBoxAttr "y" (values |> ResizeArray)
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (value: bool) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (values: seq<bool>) = Interop.mkBoxAttr "y0" (values |> ResizeArray)
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (value: System.DateTime) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkBoxAttr "y0" (values |> ResizeArray)
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (value: int) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (values: seq<int>) = Interop.mkBoxAttr "y0" (values |> ResizeArray)
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (value: float) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (values: seq<float>) = Interop.mkBoxAttr "y0" (values |> ResizeArray)
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (value: string) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate for single-box traces or the starting coordinate for multi-box traces set using q1/median/q3. See overview for more info.
    static member inline y0 (values: seq<string>) = Interop.mkBoxAttr "y0" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkBoxAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkBoxAttr "yaxis" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkBoxAttr "ysrc" value

[<RequireQualifiedAccess>]
module box =
    /// If *true*, the mean of the box(es)' underlying distribution is drawn as a dashed line inside the box(es). If *sd* the standard deviation is also drawn. Defaults to *true* when `mean` is set. Defaults to *sd* when `sd` is set Otherwise defaults to *false*.
    [<Erase>]
    type boxmean =
        static member inline sd = Interop.mkBoxAttr "boxmean" "sd"
        static member inline false' = Interop.mkBoxAttr "boxmean" false
        static member inline true' = Interop.mkBoxAttr "boxmean" true

    /// If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the box(es) are shown with no sample points Defaults to *suspectedoutliers* when `marker.outliercolor` or `marker.line.outliercolor` is set. Defaults to *all* under the q1/median/q3 signature. Otherwise defaults to *outliers*.
    [<Erase>]
    type boxpoints =
        static member inline all = Interop.mkBoxAttr "boxpoints" "all"
        static member inline outliers = Interop.mkBoxAttr "boxpoints" "outliers"
        static member inline suspectedoutliers = Interop.mkBoxAttr "boxpoints" "suspectedoutliers"
        static member inline false' = Interop.mkBoxAttr "boxpoints" false

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkBoxAttr "hoverinfo" "all"
        static member inline none = Interop.mkBoxAttr "hoverinfo" "none"
        static member inline skip = Interop.mkBoxAttr "hoverinfo" "skip"
        static member inline name = Interop.mkBoxAttr "hoverinfo" "name"
        static member inline text = Interop.mkBoxAttr "hoverinfo" "text"
        static member inline x = Interop.mkBoxAttr "hoverinfo" "x"
        static member inline y = Interop.mkBoxAttr "hoverinfo" "y"
        static member inline z = Interop.mkBoxAttr "hoverinfo" "z"

    /// Do the hover effects highlight individual boxes  or sample points or both?
    [<Erase>]
    type hoveron =
        static member inline boxes = Interop.mkBoxAttr "hoveron" "boxes"
        static member inline points = Interop.mkBoxAttr "hoveron" "points"

    /// Sets the orientation of the box(es). If *v* (*h*), the distribution is visualized along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkBoxAttr "orientation" "h"
        static member inline v = Interop.mkBoxAttr "orientation" "v"

    /// Sets the method used to compute the sample's Q1 and Q3 quartiles. The *linear* method uses the 25th percentile for Q1 and 75th percentile for Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html). The *exclusive* method uses the median to divide the ordered dataset into two halves if the sample is odd, it does not include the median in either half - Q1 is then the median of the lower half and Q3 the median of the upper half. The *inclusive* method also uses the median to divide the ordered dataset into two halves but if the sample is odd, it includes the median in both halves - Q1 is then the median of the lower half and Q3 the median of the upper half.
    [<Erase>]
    type quartilemethod =
        static member inline exclusive = Interop.mkBoxAttr "quartilemethod" "exclusive"
        static member inline inclusive = Interop.mkBoxAttr "quartilemethod" "inclusive"
        static member inline linear = Interop.mkBoxAttr "quartilemethod" "linear"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkBoxAttr "visible" "legendonly"
        static member inline false' = Interop.mkBoxAttr "visible" false
        static member inline true' = Interop.mkBoxAttr "visible" true

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkBoxAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkBoxAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkBoxAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkBoxAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkBoxAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkBoxAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkBoxAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkBoxAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkBoxAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkBoxAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkBoxAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkBoxAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkBoxAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkBoxAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkBoxAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkBoxAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkBoxAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkBoxAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkBoxAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkBoxAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkBoxAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkBoxAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkBoxAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkBoxAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkBoxAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkBoxAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkBoxAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkBoxAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkBoxAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkBoxAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkBoxAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkBoxAttr "ycalendar" "ummalqura"

