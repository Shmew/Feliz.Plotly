namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type heatmapgl =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkHeatmapglAttr "autocolorscale" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkHeatmapglAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkHeatmapglAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkHeatmapglAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkHeatmapglAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkHeatmapglAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkHeatmapglAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkHeatmapglAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkHeatmapglAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkHeatmapglAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkHeatmapglAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkHeatmapglAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkHeatmapglAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkHeatmapglAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkHeatmapglAttr "customdatasrc" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkHeatmapglAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkHeatmapglAttr "dx" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkHeatmapglAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkHeatmapglAttr "dy" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IHeatmapglProperty list) = Interop.mkHeatmapglAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkHeatmapglAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkHeatmapglAttr "hoverlabel" (createObj !!properties)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkHeatmapglAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkHeatmapglAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkHeatmapglAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkHeatmapglAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkHeatmapglAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkHeatmapglAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkHeatmapglAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkHeatmapglAttr "idssrc" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkHeatmapglAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkHeatmapglAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkHeatmapglAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkHeatmapglAttr "opacity" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkHeatmapglAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkHeatmapglAttr "showscale" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkHeatmapglAttr "stream" (createObj !!properties)
    /// Sets the text elements associated with each z value.
    static member inline text (value: bool) = Interop.mkHeatmapglAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTime) = Interop.mkHeatmapglAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: float) = Interop.mkHeatmapglAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: int) = Interop.mkHeatmapglAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: string) = Interop.mkHeatmapglAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool list>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool []>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string list>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string []>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int list>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int []>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float list>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float []>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<PlotData>) = Interop.mkHeatmapglAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool option>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float option>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string option>) = Interop.mkHeatmapglAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkHeatmapglAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkHeatmapglAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Transposes the z data.
    static member inline transpose (value: bool) = Interop.mkHeatmapglAttr "transpose" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkHeatmapglAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkHeatmapglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkHeatmapglAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkHeatmapglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkHeatmapglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkHeatmapglAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkHeatmapglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkHeatmapglAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkHeatmapglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkHeatmapglAttr "uirevision" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkHeatmapglAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTime) = Interop.mkHeatmapglAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkHeatmapglAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkHeatmapglAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkHeatmapglAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool list>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool []>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string list>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string []>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int list>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int []>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float list>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float []>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<PlotData>) = Interop.mkHeatmapglAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool option>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int option>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float option>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string option>) = Interop.mkHeatmapglAttr "x" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkHeatmapglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkHeatmapglAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: System.DateTime) = Interop.mkHeatmapglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkHeatmapglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkHeatmapglAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkHeatmapglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkHeatmapglAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkHeatmapglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkHeatmapglAttr "x0" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkHeatmapglAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkHeatmapglAttr "xaxis" value
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkHeatmapglAttr "xsrc" value
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkHeatmapglAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTime) = Interop.mkHeatmapglAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkHeatmapglAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkHeatmapglAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkHeatmapglAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool list>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool []>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string list>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string []>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int list>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int []>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float list>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float []>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<PlotData>) = Interop.mkHeatmapglAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool option>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int option>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float option>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string option>) = Interop.mkHeatmapglAttr "y" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkHeatmapglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkHeatmapglAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: System.DateTime) = Interop.mkHeatmapglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkHeatmapglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkHeatmapglAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkHeatmapglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkHeatmapglAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkHeatmapglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkHeatmapglAttr "y0" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkHeatmapglAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkHeatmapglAttr "yaxis" value
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkHeatmapglAttr "ysrc" value
    /// Sets the z data.
    static member inline z (value: bool) = Interop.mkHeatmapglAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: System.DateTime) = Interop.mkHeatmapglAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: float) = Interop.mkHeatmapglAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: int) = Interop.mkHeatmapglAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: string) = Interop.mkHeatmapglAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<bool>>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool list>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool []>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<string>>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string list>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string []>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<int>>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int list>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int []>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<float>>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float list>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float []>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<PlotData>) = Interop.mkHeatmapglAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool option>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int option>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float option>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string option>) = Interop.mkHeatmapglAttr "z" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkHeatmapglAttr "zauto" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkHeatmapglAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkHeatmapglAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkHeatmapglAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkHeatmapglAttr "zmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkHeatmapglAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkHeatmapglAttr "zmin" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkHeatmapglAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module heatmapgl =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkHeatmapglAttr "hoverinfo" "all"
        static member inline none = Interop.mkHeatmapglAttr "hoverinfo" "none"
        static member inline skip = Interop.mkHeatmapglAttr "hoverinfo" "skip"
        static member inline name = Interop.mkHeatmapglAttr "hoverinfo" "name"
        static member inline text = Interop.mkHeatmapglAttr "hoverinfo" "text"
        static member inline x = Interop.mkHeatmapglAttr "hoverinfo" "x"
        static member inline y = Interop.mkHeatmapglAttr "hoverinfo" "y"
        static member inline z = Interop.mkHeatmapglAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkHeatmapglAttr "visible" "legendonly"
        static member inline false' = Interop.mkHeatmapglAttr "visible" false
        static member inline true' = Interop.mkHeatmapglAttr "visible" true

    /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
    [<Erase>]
    type xtype =
        static member inline array = Interop.mkHeatmapglAttr "xtype" "array"
        static member inline scaled = Interop.mkHeatmapglAttr "xtype" "scaled"

    /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
    [<Erase>]
    type ytype =
        static member inline array = Interop.mkHeatmapglAttr "ytype" "array"
        static member inline scaled = Interop.mkHeatmapglAttr "ytype" "scaled"

    /// Picks a smoothing algorithm use to smooth `z` data.
    [<Erase>]
    type zsmooth =
        static member inline fast = Interop.mkHeatmapglAttr "zsmooth" "fast"
        static member inline false' = Interop.mkHeatmapglAttr "zsmooth" false

