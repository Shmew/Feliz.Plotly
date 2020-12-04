namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type sunburst =
    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    static member inline count (properties: #ISunburstProperty list) = Interop.mkSunburstAttr "count" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkSunburstAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkSunburstAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkSunburstAttr "customdatasrc" value
    static member inline domain (properties: #IDomainProperty list) = Interop.mkSunburstAttr "domain" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #ISunburstProperty list) = Interop.mkSunburstAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkSunburstAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkSunburstAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkSunburstAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkSunburstAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkSunburstAttr "hovertemplatesrc" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkSunburstAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkSunburstAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkSunburstAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkSunburstAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkSunburstAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkSunburstAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkSunburstAttr "idssrc" value
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkSunburstAttr "insidetextfont" (createObj !!properties)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: bool) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: System.DateTime) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<System.DateTime>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: float) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: int) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: string) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<bool>>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool list>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool []>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<string>>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string list>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string []>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<int>>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int list>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int []>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<seq<float>>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float list>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float []>) = Interop.mkSunburstAttr "labels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<PlotData>) = Interop.mkSunburstAttr "labels" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool option>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int option>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float option>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string option>) = Interop.mkSunburstAttr "labels" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  labels .
    static member inline labelssrc (value: string) = Interop.mkSunburstAttr "labelssrc" value
    static member inline leaf (properties: #ILeafProperty list) = Interop.mkSunburstAttr "leaf" (createObj !!properties)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: bool) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<bool>) = Interop.mkSunburstAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: System.DateTime) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<System.DateTime>) = Interop.mkSunburstAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: int) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<int>) = Interop.mkSunburstAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: float) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<float>) = Interop.mkSunburstAttr "level" (values |> ResizeArray)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: string) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<string>) = Interop.mkSunburstAttr "level" (values |> ResizeArray)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkSunburstAttr "marker" (createObj !!properties)
    /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
    static member inline maxdepth (value: int) = Interop.mkSunburstAttr "maxdepth" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkSunburstAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkSunburstAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkSunburstAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkSunburstAttr "opacity" value
    /// Sets the font used for `textinfo` lying outside the sector. This option refers to the root of the hierarchy presented at the center of a sunburst graph. Please note that if a hierarchy has multiple root nodes, this option won't have any effect and `insidetextfont` would be used.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkSunburstAttr "outsidetextfont" (createObj !!properties)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: bool) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: System.DateTime) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<System.DateTime>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: float) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: int) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: string) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<bool>>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool list>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool []>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<string>>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string list>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string []>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<int>>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int list>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int []>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<seq<float>>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float list>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float []>) = Interop.mkSunburstAttr "parents" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<PlotData>) = Interop.mkSunburstAttr "parents" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool option>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int option>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float option>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string option>) = Interop.mkSunburstAttr "parents" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  parents .
    static member inline parentssrc (value: string) = Interop.mkSunburstAttr "parentssrc" value
    static member inline root (properties: #IRootProperty list) = Interop.mkSunburstAttr "root" (createObj !!properties)
    /// Rotates the whole diagram counterclockwise by some angle. By default the first slice starts at 3 o'clock.
    static member inline rotation (value: int) = Interop.mkSunburstAttr "rotation" value
    /// Rotates the whole diagram counterclockwise by some angle. By default the first slice starts at 3 o'clock.
    static member inline rotation (value: float) = Interop.mkSunburstAttr "rotation" value
    /// Determines whether or not the sectors are reordered from largest to smallest.
    static member inline sort (value: bool) = Interop.mkSunburstAttr "sort" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkSunburstAttr "stream" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: bool) = Interop.mkSunburstAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: System.DateTime) = Interop.mkSunburstAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<System.DateTime>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: float) = Interop.mkSunburstAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: int) = Interop.mkSunburstAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkSunburstAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<bool>>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool list>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool []>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<string>>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string list>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string []>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<int>>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int list>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int []>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<seq<float>>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float list>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float []>) = Interop.mkSunburstAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<PlotData>) = Interop.mkSunburstAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool option>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int option>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float option>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string option>) = Interop.mkSunburstAttr "text" (values |> ResizeArray)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkSunburstAttr "textfont" (createObj !!properties)
    /// Determines which trace information appear on the graph.
    static member inline textinfo (properties: #ISunburstProperty list) = Interop.mkSunburstAttr "textinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkSunburstAttr "textsrc" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (value: string) = Interop.mkSunburstAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (values: seq<string>) = Interop.mkSunburstAttr "texttemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkSunburstAttr "texttemplatesrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkSunburstAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkSunburstAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkSunburstAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkSunburstAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkSunburstAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkSunburstAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkSunburstAttr "uirevision" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: bool) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: System.DateTime) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<System.DateTime>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: float) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: int) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: string) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<bool>>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool list>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool []>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<string>>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string list>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string []>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<int>>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int list>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int []>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<seq<float>>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float list>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float []>) = Interop.mkSunburstAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<PlotData>) = Interop.mkSunburstAttr "values" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool option>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<System.DateTime option>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int option>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float option>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string option>) = Interop.mkSunburstAttr "values" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  values .
    static member inline valuessrc (value: string) = Interop.mkSunburstAttr "valuessrc" value

[<Erase;RequireQualifiedAccess>]
module sunburst =
    /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
    [<Erase>]
    type branchvalues =
        static member inline remainder = Interop.mkSunburstAttr "branchvalues" "remainder"
        static member inline total = Interop.mkSunburstAttr "branchvalues" "total"

    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    [<Erase>]
    type count =
        static member inline branches = Interop.mkSunburstAttr "count" "branches"
        static member inline leaves = Interop.mkSunburstAttr "count" "leaves"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkSunburstAttr "hoverinfo" "all"
        static member inline none = Interop.mkSunburstAttr "hoverinfo" "none"
        static member inline skip = Interop.mkSunburstAttr "hoverinfo" "skip"
        static member inline currentPath = Interop.mkSunburstAttr "hoverinfo" "current path"
        static member inline label = Interop.mkSunburstAttr "hoverinfo" "label"
        static member inline name = Interop.mkSunburstAttr "hoverinfo" "name"
        static member inline percentEntry = Interop.mkSunburstAttr "hoverinfo" "percent entry"
        static member inline percentParent = Interop.mkSunburstAttr "hoverinfo" "percent parent"
        static member inline percentRoot = Interop.mkSunburstAttr "hoverinfo" "percent root"
        static member inline text = Interop.mkSunburstAttr "hoverinfo" "text"
        static member inline value = Interop.mkSunburstAttr "hoverinfo" "value"

    /// Controls the orientation of the text inside chart sectors. When set to *auto*, text may be oriented in any direction in order to be as big as possible in the middle of a sector. The *horizontal* option orients text to be parallel with the bottom of the chart, and may make text smaller in order to achieve that goal. The *radial* option orients text along the radius of the sector. The *tangential* option orients text perpendicular to the radius of the sector.
    [<Erase>]
    type insidetextorientation =
        static member inline auto = Interop.mkSunburstAttr "insidetextorientation" "auto"
        static member inline horizontal = Interop.mkSunburstAttr "insidetextorientation" "horizontal"
        static member inline radial = Interop.mkSunburstAttr "insidetextorientation" "radial"
        static member inline tangential = Interop.mkSunburstAttr "insidetextorientation" "tangential"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkSunburstAttr "textinfo" "none"
        static member inline currentPath = Interop.mkSunburstAttr "textinfo" "current path"
        static member inline label = Interop.mkSunburstAttr "textinfo" "label"
        static member inline percentEntry = Interop.mkSunburstAttr "textinfo" "percent entry"
        static member inline percentParent = Interop.mkSunburstAttr "textinfo" "percent parent"
        static member inline percentRoot = Interop.mkSunburstAttr "textinfo" "percent root"
        static member inline text = Interop.mkSunburstAttr "textinfo" "text"
        static member inline value = Interop.mkSunburstAttr "textinfo" "value"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkSunburstAttr "visible" "legendonly"
        static member inline false' = Interop.mkSunburstAttr "visible" false
        static member inline true' = Interop.mkSunburstAttr "visible" true

