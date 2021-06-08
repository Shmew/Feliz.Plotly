namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type histogram2dcontour =
    /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobinx` is not needed. However, we accept `autobinx: true` or `false` and will update `xbins` accordingly before deleting `autobinx` from the trace.
    static member inline autobinx (value: bool) = Interop.mkHistogram2dcontourAttr "autobinx" value
    /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobiny` is not needed. However, we accept `autobiny: true` or `false` and will update `ybins` accordingly before deleting `autobiny` from the trace.
    static member inline autobiny (value: bool) = Interop.mkHistogram2dcontourAttr "autobiny" value
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkHistogram2dcontourAttr "autocolorscale" value
    /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
    static member inline autocontour (value: bool) = Interop.mkHistogram2dcontourAttr "autocontour" value
    /// Set the `xbingroup` and `ybingroup` default prefix For example, setting a `bingroup` of *1* on two histogram2d traces will make them their x-bins and y-bins match separately.
    static member inline bingroup (value: string) = Interop.mkHistogram2dcontourAttr "bingroup" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkHistogram2dcontourAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkHistogram2dcontourAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkHistogram2dcontourAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkHistogram2dcontourAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    static member inline contours (properties: #IContoursProperty list) = Interop.mkHistogram2dcontourAttr "contours" (createObj !!properties)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkHistogram2dcontourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkHistogram2dcontourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkHistogram2dcontourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkHistogram2dcontourAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkHistogram2dcontourAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkHistogram2dcontourAttr "customdatasrc" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IHistogram2dcontourProperty list) = Interop.mkHistogram2dcontourAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkHistogram2dcontourAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkHistogram2dcontourAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkHistogram2dcontourAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkHistogram2dcontourAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkHistogram2dcontourAttr "hovertemplatesrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkHistogram2dcontourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkHistogram2dcontourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkHistogram2dcontourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkHistogram2dcontourAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkHistogram2dcontourAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkHistogram2dcontourAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkHistogram2dcontourAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkHistogram2dcontourAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkHistogram2dcontourAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkHistogram2dcontourAttr "marker" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkHistogram2dcontourAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkHistogram2dcontourAttr "name" value
    /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `xbins.size` is provided.
    static member inline nbinsx (value: int) = Interop.mkHistogram2dcontourAttr "nbinsx" value
    /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `ybins.size` is provided.
    static member inline nbinsy (value: int) = Interop.mkHistogram2dcontourAttr "nbinsy" value
    /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
    static member inline ncontours (value: int) = Interop.mkHistogram2dcontourAttr "ncontours" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkHistogram2dcontourAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkHistogram2dcontourAttr "opacity" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkHistogram2dcontourAttr "reversescale" value
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkHistogram2dcontourAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkHistogram2dcontourAttr "showscale" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkHistogram2dcontourAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkHistogram2dcontourAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkHistogram2dcontourAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkHistogram2dcontourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkHistogram2dcontourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkHistogram2dcontourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkHistogram2dcontourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkHistogram2dcontourAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkHistogram2dcontourAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkHistogram2dcontourAttr "uirevision" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: bool) = Interop.mkHistogram2dcontourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: float) = Interop.mkHistogram2dcontourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: int) = Interop.mkHistogram2dcontourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: string) = Interop.mkHistogram2dcontourAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<bool>>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool list>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool []>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<int>>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int list>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int []>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<float>>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float list>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float []>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<PlotData>) = Interop.mkHistogram2dcontourAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool option>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int option>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float option>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string option>) = Interop.mkHistogram2dcontourAttr "x" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkHistogram2dcontourAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkHistogram2dcontourAttr "xaxis" value
    /// Set a group of histogram traces which will have compatible x-bin settings. Using `xbingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible x-bin settings. Note that the same `xbingroup` value can be used to set (1D) histogram `bingroup`
    static member inline xbingroup (value: string) = Interop.mkHistogram2dcontourAttr "xbingroup" value
    static member inline xbins (properties: #IXbinsProperty list) = Interop.mkHistogram2dcontourAttr "xbins" (createObj !!properties)
    /// Sets the hover text formatting rule for `x`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `xaxis.hoverformat`.
    static member inline xhoverformat (value: string) = Interop.mkHistogram2dcontourAttr "xhoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkHistogram2dcontourAttr "xsrc" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: bool) = Interop.mkHistogram2dcontourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: float) = Interop.mkHistogram2dcontourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: int) = Interop.mkHistogram2dcontourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: string) = Interop.mkHistogram2dcontourAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<bool>>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool list>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool []>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<int>>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int list>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int []>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<float>>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float list>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float []>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<PlotData>) = Interop.mkHistogram2dcontourAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool option>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int option>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float option>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string option>) = Interop.mkHistogram2dcontourAttr "y" (values |> ResizeArray)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkHistogram2dcontourAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkHistogram2dcontourAttr "yaxis" value
    /// Set a group of histogram traces which will have compatible y-bin settings. Using `ybingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible y-bin settings. Note that the same `ybingroup` value can be used to set (1D) histogram `bingroup`
    static member inline ybingroup (value: string) = Interop.mkHistogram2dcontourAttr "ybingroup" value
    static member inline ybins (properties: #IYbinsProperty list) = Interop.mkHistogram2dcontourAttr "ybins" (createObj !!properties)
    /// Sets the hover text formatting rule for `y`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `yaxis.hoverformat`.
    static member inline yhoverformat (value: string) = Interop.mkHistogram2dcontourAttr "yhoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkHistogram2dcontourAttr "ysrc" value
    /// Sets the aggregation data.
    static member inline z (value: bool) = Interop.mkHistogram2dcontourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<bool>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (value: System.DateTime) = Interop.mkHistogram2dcontourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<System.DateTime>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (value: float) = Interop.mkHistogram2dcontourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<float>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (value: int) = Interop.mkHistogram2dcontourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<int>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (value: string) = Interop.mkHistogram2dcontourAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<string>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<seq<bool>>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<bool list>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<bool []>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<seq<string>>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<string list>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<string []>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<seq<int>>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<int list>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<int []>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<seq<float>>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<float list>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<float []>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<PlotData>) = Interop.mkHistogram2dcontourAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<bool option>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<int option>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<float option>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Sets the aggregation data.
    static member inline z (values: seq<string option>) = Interop.mkHistogram2dcontourAttr "z" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkHistogram2dcontourAttr "zauto" value
    /// Sets the hover text formatting rule for `z`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format By default the values are formatted using generic number format.
    static member inline zhoverformat (value: string) = Interop.mkHistogram2dcontourAttr "zhoverformat" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkHistogram2dcontourAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkHistogram2dcontourAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkHistogram2dcontourAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkHistogram2dcontourAttr "zmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkHistogram2dcontourAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkHistogram2dcontourAttr "zmin" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkHistogram2dcontourAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module histogram2dcontour =
    /// Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
    [<Erase>]
    type histfunc =
        static member inline avg = Interop.mkHistogram2dcontourAttr "histfunc" "avg"
        static member inline count = Interop.mkHistogram2dcontourAttr "histfunc" "count"
        static member inline max = Interop.mkHistogram2dcontourAttr "histfunc" "max"
        static member inline min = Interop.mkHistogram2dcontourAttr "histfunc" "min"
        static member inline sum = Interop.mkHistogram2dcontourAttr "histfunc" "sum"

    /// Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
    [<Erase>]
    type histnorm =
        static member inline none = Interop.mkHistogram2dcontourAttr "histnorm" ""
        static member inline density = Interop.mkHistogram2dcontourAttr "histnorm" "density"
        static member inline percent = Interop.mkHistogram2dcontourAttr "histnorm" "percent"
        static member inline probabilityDensity = Interop.mkHistogram2dcontourAttr "histnorm" "probability density"
        static member inline probability = Interop.mkHistogram2dcontourAttr "histnorm" "probability"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkHistogram2dcontourAttr "hoverinfo" "all"
        static member inline none = Interop.mkHistogram2dcontourAttr "hoverinfo" "none"
        static member inline skip = Interop.mkHistogram2dcontourAttr "hoverinfo" "skip"
        static member inline name = Interop.mkHistogram2dcontourAttr "hoverinfo" "name"
        static member inline text = Interop.mkHistogram2dcontourAttr "hoverinfo" "text"
        static member inline x = Interop.mkHistogram2dcontourAttr "hoverinfo" "x"
        static member inline y = Interop.mkHistogram2dcontourAttr "hoverinfo" "y"
        static member inline z = Interop.mkHistogram2dcontourAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkHistogram2dcontourAttr "visible" "legendonly"
        static member inline false' = Interop.mkHistogram2dcontourAttr "visible" false
        static member inline true' = Interop.mkHistogram2dcontourAttr "visible" true

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkHistogram2dcontourAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkHistogram2dcontourAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkHistogram2dcontourAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkHistogram2dcontourAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkHistogram2dcontourAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkHistogram2dcontourAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkHistogram2dcontourAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkHistogram2dcontourAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkHistogram2dcontourAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkHistogram2dcontourAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkHistogram2dcontourAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkHistogram2dcontourAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkHistogram2dcontourAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkHistogram2dcontourAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkHistogram2dcontourAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkHistogram2dcontourAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkHistogram2dcontourAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkHistogram2dcontourAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkHistogram2dcontourAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkHistogram2dcontourAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkHistogram2dcontourAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkHistogram2dcontourAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkHistogram2dcontourAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkHistogram2dcontourAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkHistogram2dcontourAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkHistogram2dcontourAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkHistogram2dcontourAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkHistogram2dcontourAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkHistogram2dcontourAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkHistogram2dcontourAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkHistogram2dcontourAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkHistogram2dcontourAttr "ycalendar" "ummalqura"

