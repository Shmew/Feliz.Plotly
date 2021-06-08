namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type treemap =
    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    static member inline count (properties: #ITreemapProperty list) = Interop.mkTreemapAttr "count" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkTreemapAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkTreemapAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkTreemapAttr "customdatasrc" value
    static member inline domain (properties: #IDomainProperty list) = Interop.mkTreemapAttr "domain" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #ITreemapProperty list) = Interop.mkTreemapAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkTreemapAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkTreemapAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkTreemapAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkTreemapAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkTreemapAttr "hovertemplatesrc" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkTreemapAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkTreemapAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkTreemapAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkTreemapAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkTreemapAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkTreemapAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkTreemapAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkTreemapAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkTreemapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkTreemapAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkTreemapAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkTreemapAttr "idssrc" value
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkTreemapAttr "insidetextfont" (createObj !!properties)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: bool) = Interop.mkTreemapAttr "labels" (value |> Array.singleton |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: System.DateTime) = Interop.mkTreemapAttr "labels" (value |> Array.singleton |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<System.DateTime>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: float) = Interop.mkTreemapAttr "labels" (value |> Array.singleton |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: int) = Interop.mkTreemapAttr "labels" (value |> Array.singleton |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: string) = Interop.mkTreemapAttr "labels" (value |> Array.singleton |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<bool>>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool list>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool []>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<string>>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string list>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string []>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<int>>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int list>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int []>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<float>>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float list>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float []>) = Interop.mkTreemapAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<PlotData>) = Interop.mkTreemapAttr "labels" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool option>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int option>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float option>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string option>) = Interop.mkTreemapAttr "labels" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  labels .
    static member inline labelssrc (value: string) = Interop.mkTreemapAttr "labelssrc" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: bool) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<bool>) = Interop.mkTreemapAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: System.DateTime) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<System.DateTime>) = Interop.mkTreemapAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: int) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<int>) = Interop.mkTreemapAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: float) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<float>) = Interop.mkTreemapAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: string) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<string>) = Interop.mkTreemapAttr "level" (values |> ResizeArray)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkTreemapAttr "marker" (createObj !!properties)
    /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
    static member inline maxdepth (value: int) = Interop.mkTreemapAttr "maxdepth" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkTreemapAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkTreemapAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkTreemapAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkTreemapAttr "opacity" value
    /// Sets the font used for `textinfo` lying outside the sector. This option refers to the root of the hierarchy presented on top left corner of a treemap graph. Please note that if a hierarchy has multiple root nodes, this option won't have any effect and `insidetextfont` would be used.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkTreemapAttr "outsidetextfont" (createObj !!properties)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: bool) = Interop.mkTreemapAttr "parents" (value |> Array.singleton |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: System.DateTime) = Interop.mkTreemapAttr "parents" (value |> Array.singleton |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<System.DateTime>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: float) = Interop.mkTreemapAttr "parents" (value |> Array.singleton |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: int) = Interop.mkTreemapAttr "parents" (value |> Array.singleton |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: string) = Interop.mkTreemapAttr "parents" (value |> Array.singleton |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<bool>>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool list>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool []>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<string>>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string list>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string []>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<int>>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int list>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int []>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<float>>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float list>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float []>) = Interop.mkTreemapAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<PlotData>) = Interop.mkTreemapAttr "parents" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool option>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int option>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float option>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string option>) = Interop.mkTreemapAttr "parents" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  parents .
    static member inline parentssrc (value: string) = Interop.mkTreemapAttr "parentssrc" value
    static member inline pathbar (properties: #IPathbarProperty list) = Interop.mkTreemapAttr "pathbar" (createObj !!properties)
    static member inline root (properties: #IRootProperty list) = Interop.mkTreemapAttr "root" (createObj !!properties)
    /// Determines whether or not the sectors are reordered from largest to smallest.
    static member inline sort (value: bool) = Interop.mkTreemapAttr "sort" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkTreemapAttr "stream" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: bool) = Interop.mkTreemapAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: System.DateTime) = Interop.mkTreemapAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<System.DateTime>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: float) = Interop.mkTreemapAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: int) = Interop.mkTreemapAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkTreemapAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<bool>>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool list>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool []>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<string>>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string list>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string []>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<int>>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int list>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int []>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<float>>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float list>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float []>) = Interop.mkTreemapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<PlotData>) = Interop.mkTreemapAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool option>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int option>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float option>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string option>) = Interop.mkTreemapAttr "text" (values |> ResizeArray)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkTreemapAttr "textfont" (createObj !!properties)
    /// Determines which trace information appear on the graph.
    static member inline textinfo (properties: #ITreemapProperty list) = Interop.mkTreemapAttr "textinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkTreemapAttr "textsrc" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (value: string) = Interop.mkTreemapAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (values: seq<string>) = Interop.mkTreemapAttr "texttemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkTreemapAttr "texttemplatesrc" value
    static member inline tiling (properties: #ITilingProperty list) = Interop.mkTreemapAttr "tiling" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkTreemapAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkTreemapAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkTreemapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkTreemapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkTreemapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkTreemapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkTreemapAttr "uirevision" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: bool) = Interop.mkTreemapAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: System.DateTime) = Interop.mkTreemapAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<System.DateTime>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: float) = Interop.mkTreemapAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: int) = Interop.mkTreemapAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: string) = Interop.mkTreemapAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<bool>>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool list>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool []>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<string>>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string list>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string []>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<int>>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int list>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int []>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<float>>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float list>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float []>) = Interop.mkTreemapAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<PlotData>) = Interop.mkTreemapAttr "values" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool option>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<System.DateTime option>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int option>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float option>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string option>) = Interop.mkTreemapAttr "values" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  values .
    static member inline valuessrc (value: string) = Interop.mkTreemapAttr "valuessrc" value

[<Erase;RequireQualifiedAccess>]
module treemap =
    /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
    [<Erase>]
    type branchvalues =
        static member inline remainder = Interop.mkTreemapAttr "branchvalues" "remainder"
        static member inline total = Interop.mkTreemapAttr "branchvalues" "total"

    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    [<Erase>]
    type count =
        static member inline branches = Interop.mkTreemapAttr "count" "branches"
        static member inline leaves = Interop.mkTreemapAttr "count" "leaves"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkTreemapAttr "hoverinfo" "all"
        static member inline none = Interop.mkTreemapAttr "hoverinfo" "none"
        static member inline skip = Interop.mkTreemapAttr "hoverinfo" "skip"
        static member inline currentPath = Interop.mkTreemapAttr "hoverinfo" "current path"
        static member inline label = Interop.mkTreemapAttr "hoverinfo" "label"
        static member inline name = Interop.mkTreemapAttr "hoverinfo" "name"
        static member inline percentEntry = Interop.mkTreemapAttr "hoverinfo" "percent entry"
        static member inline percentParent = Interop.mkTreemapAttr "hoverinfo" "percent parent"
        static member inline percentRoot = Interop.mkTreemapAttr "hoverinfo" "percent root"
        static member inline text = Interop.mkTreemapAttr "hoverinfo" "text"
        static member inline value = Interop.mkTreemapAttr "hoverinfo" "value"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkTreemapAttr "textinfo" "none"
        static member inline currentPath = Interop.mkTreemapAttr "textinfo" "current path"
        static member inline label = Interop.mkTreemapAttr "textinfo" "label"
        static member inline percentEntry = Interop.mkTreemapAttr "textinfo" "percent entry"
        static member inline percentParent = Interop.mkTreemapAttr "textinfo" "percent parent"
        static member inline percentRoot = Interop.mkTreemapAttr "textinfo" "percent root"
        static member inline text = Interop.mkTreemapAttr "textinfo" "text"
        static member inline value = Interop.mkTreemapAttr "textinfo" "value"

    /// Sets the positions of the `text` elements.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkTreemapAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkTreemapAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkTreemapAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkTreemapAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkTreemapAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkTreemapAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkTreemapAttr "textposition" "top center"
        static member inline topLeft = Interop.mkTreemapAttr "textposition" "top left"
        static member inline topRight = Interop.mkTreemapAttr "textposition" "top right"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkTreemapAttr "visible" "legendonly"
        static member inline false' = Interop.mkTreemapAttr "visible" false
        static member inline true' = Interop.mkTreemapAttr "visible" true

