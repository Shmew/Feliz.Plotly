namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type image =
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkImageAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkImageAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkImageAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkImageAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkImageAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkImageAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkImageAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkImageAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkImageAttr "customdatasrc" value
    /// Set the pixel's horizontal size.
    static member inline dx (value: int) = Interop.mkImageAttr "dx" value
    /// Set the pixel's horizontal size.
    static member inline dx (value: float) = Interop.mkImageAttr "dx" value
    /// Set the pixel's vertical size
    static member inline dy (value: int) = Interop.mkImageAttr "dy" value
    /// Set the pixel's vertical size
    static member inline dy (value: float) = Interop.mkImageAttr "dy" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IImageProperty list) = Interop.mkImageAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkImageAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkImageAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `z`, `color` and `colormodel`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkImageAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `z`, `color` and `colormodel`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkImageAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkImageAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: bool) = Interop.mkImageAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: System.DateTime) = Interop.mkImageAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: float) = Interop.mkImageAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: int) = Interop.mkImageAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkImageAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<bool>>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool list>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool []>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<string>>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string list>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string []>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<int>>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int list>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int []>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<float>>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float list>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float []>) = Interop.mkImageAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<PlotData>) = Interop.mkImageAttr "hovertext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool option>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime option>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int option>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float option>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string option>) = Interop.mkImageAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkImageAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkImageAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkImageAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkImageAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkImageAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkImageAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkImageAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkImageAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkImageAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkImageAttr "idssrc" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkImageAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkImageAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkImageAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkImageAttr "opacity" value
    /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
    static member inline sizex (value: int) = Interop.mkImageAttr "sizex" value
    /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
    static member inline sizex (value: float) = Interop.mkImageAttr "sizex" value
    /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
    static member inline sizey (value: int) = Interop.mkImageAttr "sizey" value
    /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
    static member inline sizey (value: float) = Interop.mkImageAttr "sizey" value
    /// Specifies the URL of the image to be used. The URL must be accessible from the domain where the plot code is run, and can be either relative or absolute.
    static member inline source (value: string) = Interop.mkImageAttr "source" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkImageAttr "stream" (createObj !!properties)
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkImageAttr "templateitemname" value
    /// Sets the text elements associated with each z value.
    static member inline text (value: bool) = Interop.mkImageAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTime) = Interop.mkImageAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: float) = Interop.mkImageAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: int) = Interop.mkImageAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: string) = Interop.mkImageAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<bool>>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool list>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool []>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<string>>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string list>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string []>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<int>>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int list>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int []>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<float>>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float list>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float []>) = Interop.mkImageAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<PlotData>) = Interop.mkImageAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool option>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float option>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string option>) = Interop.mkImageAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkImageAttr "textsrc" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkImageAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkImageAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkImageAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkImageAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkImageAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkImageAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkImageAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkImageAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkImageAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkImageAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkImageAttr "uirevision" (values |> ResizeArray)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: bool) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<bool>) = Interop.mkImageAttr "x" (values |> ResizeArray)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: System.DateTime) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<System.DateTime>) = Interop.mkImageAttr "x" (values |> ResizeArray)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: int) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<int>) = Interop.mkImageAttr "x" (values |> ResizeArray)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: float) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<float>) = Interop.mkImageAttr "x" (values |> ResizeArray)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: string) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<string>) = Interop.mkImageAttr "x" (values |> ResizeArray)
    /// Set the image's x position.
    static member inline x0 (value: bool) = Interop.mkImageAttr "x0" value
    /// Set the image's x position.
    static member inline x0 (values: seq<bool>) = Interop.mkImageAttr "x0" (values |> ResizeArray)
    /// Set the image's x position.
    static member inline x0 (value: System.DateTime) = Interop.mkImageAttr "x0" value
    /// Set the image's x position.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkImageAttr "x0" (values |> ResizeArray)
    /// Set the image's x position.
    static member inline x0 (value: int) = Interop.mkImageAttr "x0" value
    /// Set the image's x position.
    static member inline x0 (values: seq<int>) = Interop.mkImageAttr "x0" (values |> ResizeArray)
    /// Set the image's x position.
    static member inline x0 (value: float) = Interop.mkImageAttr "x0" value
    /// Set the image's x position.
    static member inline x0 (values: seq<float>) = Interop.mkImageAttr "x0" (values |> ResizeArray)
    /// Set the image's x position.
    static member inline x0 (value: string) = Interop.mkImageAttr "x0" value
    /// Set the image's x position.
    static member inline x0 (values: seq<string>) = Interop.mkImageAttr "x0" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkImageAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkImageAttr "xaxis" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: bool) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<bool>) = Interop.mkImageAttr "y" (values |> ResizeArray)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: System.DateTime) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<System.DateTime>) = Interop.mkImageAttr "y" (values |> ResizeArray)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: int) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<int>) = Interop.mkImageAttr "y" (values |> ResizeArray)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: float) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<float>) = Interop.mkImageAttr "y" (values |> ResizeArray)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: string) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<string>) = Interop.mkImageAttr "y" (values |> ResizeArray)
    /// Set the image's y position.
    static member inline y0 (value: bool) = Interop.mkImageAttr "y0" value
    /// Set the image's y position.
    static member inline y0 (values: seq<bool>) = Interop.mkImageAttr "y0" (values |> ResizeArray)
    /// Set the image's y position.
    static member inline y0 (value: System.DateTime) = Interop.mkImageAttr "y0" value
    /// Set the image's y position.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkImageAttr "y0" (values |> ResizeArray)
    /// Set the image's y position.
    static member inline y0 (value: int) = Interop.mkImageAttr "y0" value
    /// Set the image's y position.
    static member inline y0 (values: seq<int>) = Interop.mkImageAttr "y0" (values |> ResizeArray)
    /// Set the image's y position.
    static member inline y0 (value: float) = Interop.mkImageAttr "y0" value
    /// Set the image's y position.
    static member inline y0 (values: seq<float>) = Interop.mkImageAttr "y0" (values |> ResizeArray)
    /// Set the image's y position.
    static member inline y0 (value: string) = Interop.mkImageAttr "y0" value
    /// Set the image's y position.
    static member inline y0 (values: seq<string>) = Interop.mkImageAttr "y0" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkImageAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkImageAttr "yaxis" value
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (value: bool) = Interop.mkImageAttr "z" (value |> Array.singleton)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<bool>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (value: System.DateTime) = Interop.mkImageAttr "z" (value |> Array.singleton)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<System.DateTime>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (value: float) = Interop.mkImageAttr "z" (value |> Array.singleton)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<float>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (value: int) = Interop.mkImageAttr "z" (value |> Array.singleton)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<int>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (value: string) = Interop.mkImageAttr "z" (value |> Array.singleton)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<string>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<seq<bool>>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<bool list>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<bool []>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<seq<string>>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<string list>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<string []>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<seq<int>>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<int list>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<int []>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<seq<float>>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<float list>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<float []>) = Interop.mkImageAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<PlotData>) = Interop.mkImageAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<bool option>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<int option>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<float option>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
    static member inline z (values: seq<string option>) = Interop.mkImageAttr "z" (values |> ResizeArray)
    /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
    static member inline zmax (value: int) = Interop.mkImageAttr "zmax" (value |> Array.singleton |> ResizeArray)
    /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
    static member inline zmax (values: seq<int>) = Interop.mkImageAttr "zmax" (values |> ResizeArray)
    /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
    static member inline zmax (value: float) = Interop.mkImageAttr "zmax" (value |> Array.singleton |> ResizeArray)
    /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
    static member inline zmax (values: seq<float>) = Interop.mkImageAttr "zmax" (values |> ResizeArray)
    /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
    static member inline zmin (value: int) = Interop.mkImageAttr "zmin" (value |> Array.singleton |> ResizeArray)
    /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
    static member inline zmin (values: seq<int>) = Interop.mkImageAttr "zmin" (values |> ResizeArray)
    /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
    static member inline zmin (value: float) = Interop.mkImageAttr "zmin" (value |> Array.singleton |> ResizeArray)
    /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
    static member inline zmin (values: seq<float>) = Interop.mkImageAttr "zmin" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkImageAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module image =
    /// Color model used to map the numerical color components described in `z` into colors.
    [<Erase>]
    type colormodel =
        static member inline hsl = Interop.mkImageAttr "colormodel" "hsl"
        static member inline hsla = Interop.mkImageAttr "colormodel" "hsla"
        static member inline rgb = Interop.mkImageAttr "colormodel" "rgb"
        static member inline rgba = Interop.mkImageAttr "colormodel" "rgba"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkImageAttr "hoverinfo" "all"
        static member inline none = Interop.mkImageAttr "hoverinfo" "none"
        static member inline skip = Interop.mkImageAttr "hoverinfo" "skip"
        static member inline color = Interop.mkImageAttr "hoverinfo" "color"
        static member inline name = Interop.mkImageAttr "hoverinfo" "name"
        static member inline text = Interop.mkImageAttr "hoverinfo" "text"
        static member inline x = Interop.mkImageAttr "hoverinfo" "x"
        static member inline y = Interop.mkImageAttr "hoverinfo" "y"
        static member inline z = Interop.mkImageAttr "hoverinfo" "z"

    /// Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
    [<Erase>]
    type layer =
        static member inline above = Interop.mkImageAttr "layer" "above"
        static member inline below = Interop.mkImageAttr "layer" "below"

    /// Specifies which dimension of the image to constrain.
    [<Erase>]
    type sizing =
        static member inline contain = Interop.mkImageAttr "sizing" "contain"
        static member inline fill = Interop.mkImageAttr "sizing" "fill"
        static member inline stretch = Interop.mkImageAttr "sizing" "stretch"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkImageAttr "visible" "legendonly"
        static member inline false' = Interop.mkImageAttr "visible" false
        static member inline true' = Interop.mkImageAttr "visible" true

    /// Sets the anchor for the x position
    [<Erase>]
    type xanchor =
        static member inline center = Interop.mkImageAttr "xanchor" "center"
        static member inline left = Interop.mkImageAttr "xanchor" "left"
        static member inline right = Interop.mkImageAttr "xanchor" "right"

    /// Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to an x data coordinate If set to *paper*, the `x` position refers to the distance from the left of plot in normalized coordinates where *0* (*1*) corresponds to the left (right).
    [<Erase>]
    type xref =
        static member inline paper = Interop.mkImageAttr "xref" "paper"
        static member inline custom (value: string) = Interop.mkImageAttr "xref" value
        static member inline x (anchorId: int) = Interop.mkImageAttr "xref" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// Sets the anchor for the y position.
    [<Erase>]
    type yanchor =
        static member inline bottom = Interop.mkImageAttr "yanchor" "bottom"
        static member inline middle = Interop.mkImageAttr "yanchor" "middle"
        static member inline top = Interop.mkImageAttr "yanchor" "top"

    /// Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y data coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plot in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
    [<Erase>]
    type yref =
        static member inline paper = Interop.mkImageAttr "yref" "paper"
        static member inline custom (value: string) = Interop.mkImageAttr "yref" value
        static member inline y (anchorId: int) = Interop.mkImageAttr "yref" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))

