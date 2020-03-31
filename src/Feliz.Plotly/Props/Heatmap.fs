namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type heatmap =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkHeatmapAttr "autocolorscale" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkHeatmapAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkHeatmapAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkHeatmapAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkHeatmapAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkHeatmapAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkHeatmapAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkHeatmapAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in. It is defaulted to true if `z` is a one dimensional array and `zsmooth` is not false; otherwise it is defaulted to false.
    static member inline connectgaps (value: bool) = Interop.mkHeatmapAttr "connectgaps" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkHeatmapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkHeatmapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkHeatmapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkHeatmapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkHeatmapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkHeatmapAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkHeatmapAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkHeatmapAttr "customdatasrc" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkHeatmapAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkHeatmapAttr "dx" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkHeatmapAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkHeatmapAttr "dy" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IHeatmapProperty list) = Interop.mkHeatmapAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkHeatmapAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkHeatmapAttr "hoverlabel" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data have hover labels associated with them.
    static member inline hoverongaps (value: bool) = Interop.mkHeatmapAttr "hoverongaps" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkHeatmapAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkHeatmapAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkHeatmapAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: bool) = Interop.mkHeatmapAttr "hovertext" (value |> Array.singleton)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: System.DateTime) = Interop.mkHeatmapAttr "hovertext" (value |> Array.singleton)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: float) = Interop.mkHeatmapAttr "hovertext" (value |> Array.singleton)
    /// Same as `text`.
    static member inline hovertext (values: seq<float>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: int) = Interop.mkHeatmapAttr "hovertext" (value |> Array.singleton)
    /// Same as `text`.
    static member inline hovertext (values: seq<int>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkHeatmapAttr "hovertext" (value |> Array.singleton)
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool list>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool []>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<string>>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string list>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string []>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<int>>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int list>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int []>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<float>>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float list>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float []>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<PlotData>) = Interop.mkHeatmapAttr "hovertext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool option>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int option>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float option>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string option>) = Interop.mkHeatmapAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkHeatmapAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkHeatmapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkHeatmapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkHeatmapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkHeatmapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkHeatmapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkHeatmapAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkHeatmapAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkHeatmapAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkHeatmapAttr "legendgroup" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkHeatmapAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkHeatmapAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkHeatmapAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkHeatmapAttr "opacity" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkHeatmapAttr "reversescale" value
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkHeatmapAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkHeatmapAttr "showscale" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkHeatmapAttr "stream" (createObj !!properties)
    /// Sets the text elements associated with each z value.
    static member inline text (value: bool) = Interop.mkHeatmapAttr "text" (value |> Array.singleton)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTime) = Interop.mkHeatmapAttr "text" (value |> Array.singleton)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: float) = Interop.mkHeatmapAttr "text" (value |> Array.singleton)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: int) = Interop.mkHeatmapAttr "text" (value |> Array.singleton)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: string) = Interop.mkHeatmapAttr "text" (value |> Array.singleton)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool list>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool []>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<string>>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string list>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string []>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<int>>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int list>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int []>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<float>>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float list>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float []>) = Interop.mkHeatmapAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<PlotData>) = Interop.mkHeatmapAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool option>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float option>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string option>) = Interop.mkHeatmapAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkHeatmapAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkHeatmapAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Transposes the z data.
    static member inline transpose (value: bool) = Interop.mkHeatmapAttr "transpose" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkHeatmapAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkHeatmapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkHeatmapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkHeatmapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkHeatmapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkHeatmapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkHeatmapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkHeatmapAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkHeatmapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkHeatmapAttr "uirevision" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkHeatmapAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTime) = Interop.mkHeatmapAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkHeatmapAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkHeatmapAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkHeatmapAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool list>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool []>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<string>>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string list>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string []>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<int>>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int list>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int []>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<float>>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float list>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float []>) = Interop.mkHeatmapAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<PlotData>) = Interop.mkHeatmapAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool option>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int option>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float option>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string option>) = Interop.mkHeatmapAttr "x" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkHeatmapAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkHeatmapAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: System.DateTime) = Interop.mkHeatmapAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkHeatmapAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkHeatmapAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkHeatmapAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkHeatmapAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkHeatmapAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkHeatmapAttr "x0" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkHeatmapAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkHeatmapAttr "xaxis" value
    /// Sets the horizontal gap (in pixels) between bricks.
    static member inline xgap (value: int) = Interop.mkHeatmapAttr "xgap" value
    /// Sets the horizontal gap (in pixels) between bricks.
    static member inline xgap (value: float) = Interop.mkHeatmapAttr "xgap" value
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkHeatmapAttr "xsrc" value
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkHeatmapAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTime) = Interop.mkHeatmapAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkHeatmapAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkHeatmapAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkHeatmapAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool list>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool []>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<string>>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string list>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string []>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<int>>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int list>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int []>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<float>>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float list>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float []>) = Interop.mkHeatmapAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<PlotData>) = Interop.mkHeatmapAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool option>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int option>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float option>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string option>) = Interop.mkHeatmapAttr "y" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkHeatmapAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkHeatmapAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: System.DateTime) = Interop.mkHeatmapAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkHeatmapAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkHeatmapAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkHeatmapAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkHeatmapAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkHeatmapAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkHeatmapAttr "y0" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkHeatmapAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkHeatmapAttr "yaxis" value
    /// Sets the vertical gap (in pixels) between bricks.
    static member inline ygap (value: int) = Interop.mkHeatmapAttr "ygap" value
    /// Sets the vertical gap (in pixels) between bricks.
    static member inline ygap (value: float) = Interop.mkHeatmapAttr "ygap" value
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkHeatmapAttr "ysrc" value
    /// Sets the z data.
    static member inline z (value: bool) = Interop.mkHeatmapAttr "z" (value |> Array.singleton)
    /// Sets the z data.
    static member inline z (values: seq<bool>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: System.DateTime) = Interop.mkHeatmapAttr "z" (value |> Array.singleton)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: float) = Interop.mkHeatmapAttr "z" (value |> Array.singleton)
    /// Sets the z data.
    static member inline z (values: seq<float>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: int) = Interop.mkHeatmapAttr "z" (value |> Array.singleton)
    /// Sets the z data.
    static member inline z (values: seq<int>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: string) = Interop.mkHeatmapAttr "z" (value |> Array.singleton)
    /// Sets the z data.
    static member inline z (values: seq<string>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<bool>>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool list>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool []>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<string>>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string list>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string []>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<int>>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int list>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int []>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<float>>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float list>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float []>) = Interop.mkHeatmapAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<PlotData>) = Interop.mkHeatmapAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool option>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int option>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float option>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string option>) = Interop.mkHeatmapAttr "z" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkHeatmapAttr "zauto" value
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline zhoverformat (value: string) = Interop.mkHeatmapAttr "zhoverformat" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkHeatmapAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkHeatmapAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkHeatmapAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkHeatmapAttr "zmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkHeatmapAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkHeatmapAttr "zmin" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkHeatmapAttr "zsrc" value

[<RequireQualifiedAccess>]
module heatmap =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkHeatmapAttr "hoverinfo" "all"
        static member inline none = Interop.mkHeatmapAttr "hoverinfo" "none"
        static member inline skip = Interop.mkHeatmapAttr "hoverinfo" "skip"
        static member inline name = Interop.mkHeatmapAttr "hoverinfo" "name"
        static member inline text = Interop.mkHeatmapAttr "hoverinfo" "text"
        static member inline x = Interop.mkHeatmapAttr "hoverinfo" "x"
        static member inline y = Interop.mkHeatmapAttr "hoverinfo" "y"
        static member inline z = Interop.mkHeatmapAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkHeatmapAttr "visible" "legendonly"
        static member inline false' = Interop.mkHeatmapAttr "visible" false
        static member inline true' = Interop.mkHeatmapAttr "visible" true

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkHeatmapAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkHeatmapAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkHeatmapAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkHeatmapAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkHeatmapAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkHeatmapAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkHeatmapAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkHeatmapAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkHeatmapAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkHeatmapAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkHeatmapAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkHeatmapAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkHeatmapAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkHeatmapAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkHeatmapAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkHeatmapAttr "xcalendar" "ummalqura"

    /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
    [<Erase>]
    type xtype =
        static member inline array = Interop.mkHeatmapAttr "xtype" "array"
        static member inline scaled = Interop.mkHeatmapAttr "xtype" "scaled"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkHeatmapAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkHeatmapAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkHeatmapAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkHeatmapAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkHeatmapAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkHeatmapAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkHeatmapAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkHeatmapAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkHeatmapAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkHeatmapAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkHeatmapAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkHeatmapAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkHeatmapAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkHeatmapAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkHeatmapAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkHeatmapAttr "ycalendar" "ummalqura"

    /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
    [<Erase>]
    type ytype =
        static member inline array = Interop.mkHeatmapAttr "ytype" "array"
        static member inline scaled = Interop.mkHeatmapAttr "ytype" "scaled"

    /// Picks a smoothing algorithm use to smooth `z` data.
    [<Erase>]
    type zsmooth =
        static member inline best = Interop.mkHeatmapAttr "zsmooth" "best"
        static member inline fast = Interop.mkHeatmapAttr "zsmooth" "fast"
        static member inline false' = Interop.mkHeatmapAttr "zsmooth" false

