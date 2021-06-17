namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type contour =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkContourAttr "autocolorscale" value
    /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
    static member inline autocontour (value: bool) = Interop.mkContourAttr "autocontour" value
    /// Sets the color of the contour lines.
    static member inline color (value: string) = Interop.mkContourAttr "color" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkContourAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkContourAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkContourAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkContourAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkContourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkContourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkContourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in. It is defaulted to true if `z` is a one dimensional array otherwise it is defaulted to false.
    static member inline connectgaps (value: bool) = Interop.mkContourAttr "connectgaps" value
    static member inline contours (properties: #IContoursProperty list) = Interop.mkContourAttr "contours" (createObj !!properties)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTimeOffset) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkContourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkContourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkContourAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkContourAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkContourAttr "customdatasrc" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkContourAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkContourAttr "dx" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkContourAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkContourAttr "dy" value
    /// Sets the fill color if `contours.type` is *constraint*. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkContourAttr "fillcolor" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IContourProperty list) = Interop.mkContourAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkContourAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkContourAttr "hoverlabel" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data have hover labels associated with them.
    static member inline hoverongaps (value: bool) = Interop.mkContourAttr "hoverongaps" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkContourAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkContourAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkContourAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: bool) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: System.DateTime) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: System.DateTimeOffset) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: float) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: int) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkContourAttr "hovertext" (value |> Array.singleton |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<bool>>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool list>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool []>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<string>>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string list>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string []>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<int>>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int list>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int []>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<float>>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float list>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float []>) = Interop.mkContourAttr "hovertext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<PlotData>) = Interop.mkContourAttr "hovertext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string option>) = Interop.mkContourAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkContourAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTimeOffset) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkContourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkContourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkContourAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkContourAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkContourAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkContourAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkContourAttr "line" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkContourAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkContourAttr "name" value
    /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
    static member inline ncontours (value: int) = Interop.mkContourAttr "ncontours" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkContourAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkContourAttr "opacity" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkContourAttr "reversescale" value
    /// Sets whether or not dynamic contours are shown on hover
    static member inline show (value: bool) = Interop.mkContourAttr "show" value
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkContourAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkContourAttr "showscale" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkContourAttr "stream" (createObj !!properties)
    /// Sets the text elements associated with each z value.
    static member inline text (value: bool) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTime) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTimeOffset) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: float) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: int) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (value: string) = Interop.mkContourAttr "text" (value |> Array.singleton |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<bool>>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool list>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool []>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<string>>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string list>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string []>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<int>>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int list>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int []>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<float>>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float list>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float []>) = Interop.mkContourAttr "text" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<PlotData>) = Interop.mkContourAttr "text" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string option>) = Interop.mkContourAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkContourAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkContourAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Transposes the z data.
    static member inline transpose (value: bool) = Interop.mkContourAttr "transpose" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkContourAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTimeOffset) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkContourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkContourAttr "uirevision" (values |> ResizeArray)
    /// Sets the width of the contour lines.
    static member inline width (value: int) = Interop.mkContourAttr "width" value
    /// Sets the width of the contour lines.
    static member inline width (value: float) = Interop.mkContourAttr "width" value
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTime) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTimeOffset) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkContourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<bool>>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool list>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool []>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<string>>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string list>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string []>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<int>>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int list>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int []>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<float>>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float list>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float []>) = Interop.mkContourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<PlotData>) = Interop.mkContourAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string option>) = Interop.mkContourAttr "x" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: System.DateTime) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: System.DateTimeOffset) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkContourAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkContourAttr "x0" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkContourAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkContourAttr "xaxis" value
    /// Sets the hover text formatting rule for `x`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `xaxis.hoverformat`.
    static member inline xhoverformat (value: string) = Interop.mkContourAttr "xhoverformat" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: bool) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<bool>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: System.DateTime) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: System.DateTimeOffset) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<System.DateTime>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: int) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<int>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: float) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<float>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (value: string) = Interop.mkContourAttr "xperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the x axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline xperiod (values: seq<string>) = Interop.mkContourAttr "xperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: bool) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<bool>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: System.DateTime) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: System.DateTimeOffset) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<System.DateTime>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: int) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<int>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: float) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<float>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (value: string) = Interop.mkContourAttr "xperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the x0 axis. When `x0period` is round number of weeks, the `x0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline xperiod0 (values: seq<string>) = Interop.mkContourAttr "xperiod0" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkContourAttr "xsrc" value
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTime) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTimeOffset) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkContourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<bool>>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool list>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool []>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<string>>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string list>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string []>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<int>>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int list>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int []>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<float>>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float list>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float []>) = Interop.mkContourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<PlotData>) = Interop.mkContourAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string option>) = Interop.mkContourAttr "y" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: System.DateTime) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: System.DateTimeOffset) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkContourAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkContourAttr "y0" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkContourAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkContourAttr "yaxis" value
    /// Sets the hover text formatting rule for `y`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `yaxis.hoverformat`.
    static member inline yhoverformat (value: string) = Interop.mkContourAttr "yhoverformat" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: bool) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<bool>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: System.DateTime) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: System.DateTimeOffset) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<System.DateTime>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: int) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<int>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: float) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<float>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (value: string) = Interop.mkContourAttr "yperiod" value
    /// Only relevant when the axis `type` is *date*. Sets the period positioning in milliseconds or *M<n>* on the y axis. Special values in the form of *M<n>* could be used to declare the number of months. In this case `n` must be a positive integer.
    static member inline yperiod (values: seq<string>) = Interop.mkContourAttr "yperiod" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: bool) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<bool>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: System.DateTime) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: System.DateTimeOffset) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<System.DateTime>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: int) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<int>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: float) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<float>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (value: string) = Interop.mkContourAttr "yperiod0" value
    /// Only relevant when the axis `type` is *date*. Sets the base for period positioning in milliseconds or date string on the y0 axis. When `y0period` is round number of weeks, the `y0period0` by default would be on a Sunday i.e. 2000-01-02, otherwise it would be at 2000-01-01.
    static member inline yperiod0 (values: seq<string>) = Interop.mkContourAttr "yperiod0" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkContourAttr "ysrc" value
    /// Sets the z data.
    static member inline z (value: bool) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: System.DateTime) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: System.DateTimeOffset) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTimeOffset>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: float) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: int) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (value: string) = Interop.mkContourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<bool>>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool list>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool []>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<string>>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string list>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string []>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<int>>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int list>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int []>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<seq<float>>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float list>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float []>) = Interop.mkContourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<PlotData>) = Interop.mkContourAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<bool option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTimeOffset option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string option>) = Interop.mkContourAttr "z" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkContourAttr "zauto" value
    /// Sets the hover text formatting rule for `z`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format By default the values are formatted using generic number format.
    static member inline zhoverformat (value: string) = Interop.mkContourAttr "zhoverformat" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkContourAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkContourAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkContourAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkContourAttr "zmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkContourAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkContourAttr "zmin" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkContourAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module contour =
    /// Sets the color of the contour lines.
    [<Erase>]
    type color =
        /// Sets the color of the contour lines.
        static member inline rgb (r,g,b) = Interop.mkContourAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the contour lines.
        static member inline rgba (r,g,b,a) = Interop.mkContourAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the contour lines.
        static member inline hsl (h,s,l) = Interop.mkContourAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkContourAttr "hoverinfo" "all"
        static member inline none = Interop.mkContourAttr "hoverinfo" "none"
        static member inline skip = Interop.mkContourAttr "hoverinfo" "skip"
        static member inline name = Interop.mkContourAttr "hoverinfo" "name"
        static member inline text = Interop.mkContourAttr "hoverinfo" "text"
        static member inline x = Interop.mkContourAttr "hoverinfo" "x"
        static member inline y = Interop.mkContourAttr "hoverinfo" "y"
        static member inline z = Interop.mkContourAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkContourAttr "visible" "legendonly"
        static member inline false' = Interop.mkContourAttr "visible" false
        static member inline true' = Interop.mkContourAttr "visible" true

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkContourAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkContourAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkContourAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkContourAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkContourAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkContourAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkContourAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkContourAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkContourAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkContourAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkContourAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkContourAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkContourAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkContourAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkContourAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkContourAttr "xcalendar" "ummalqura"

    /// Only relevant when the axis `type` is *date*. Sets the alignment of data points on the x axis.
    [<Erase>]
    type xperiodalignment =
        static member inline end' = Interop.mkContourAttr "xperiodalignment" "end"
        static member inline middle = Interop.mkContourAttr "xperiodalignment" "middle"
        static member inline start = Interop.mkContourAttr "xperiodalignment" "start"

    /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
    [<Erase>]
    type xtype =
        static member inline array = Interop.mkContourAttr "xtype" "array"
        static member inline scaled = Interop.mkContourAttr "xtype" "scaled"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkContourAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkContourAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkContourAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkContourAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkContourAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkContourAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkContourAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkContourAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkContourAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkContourAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkContourAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkContourAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkContourAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkContourAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkContourAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkContourAttr "ycalendar" "ummalqura"

    /// Only relevant when the axis `type` is *date*. Sets the alignment of data points on the y axis.
    [<Erase>]
    type yperiodalignment =
        static member inline end' = Interop.mkContourAttr "yperiodalignment" "end"
        static member inline middle = Interop.mkContourAttr "yperiodalignment" "middle"
        static member inline start = Interop.mkContourAttr "yperiodalignment" "start"

    /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
    [<Erase>]
    type ytype =
        static member inline array = Interop.mkContourAttr "ytype" "array"
        static member inline scaled = Interop.mkContourAttr "ytype" "scaled"

