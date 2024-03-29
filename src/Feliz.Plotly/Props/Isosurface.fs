namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type isosurface =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkIsosurfaceAttr "autocolorscale" value
    static member inline caps (properties: #ICapsProperty list) = Interop.mkIsosurfaceAttr "caps" (createObj !!properties)
    /// Determines whether or not the color domain is computed with respect to the input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkIsosurfaceAttr "cauto" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkIsosurfaceAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkIsosurfaceAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkIsosurfaceAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkIsosurfaceAttr "cmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkIsosurfaceAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkIsosurfaceAttr "cmin" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkIsosurfaceAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkIsosurfaceAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkIsosurfaceAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkIsosurfaceAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkIsosurfaceAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkIsosurfaceAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    static member inline contour (properties: #IContourProperty list) = Interop.mkIsosurfaceAttr "contour" (createObj !!properties)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkIsosurfaceAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkIsosurfaceAttr "customdatasrc" value
    /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
    static member inline flatshading (value: bool) = Interop.mkIsosurfaceAttr "flatshading" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IIsosurfaceProperty list) = Interop.mkIsosurfaceAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkIsosurfaceAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkIsosurfaceAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkIsosurfaceAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkIsosurfaceAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkIsosurfaceAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkIsosurfaceAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkIsosurfaceAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkIsosurfaceAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkIsosurfaceAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkIsosurfaceAttr "idssrc" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: int) = Interop.mkIsosurfaceAttr "isomax" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: float) = Interop.mkIsosurfaceAttr "isomax" value
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: int) = Interop.mkIsosurfaceAttr "isomin" value
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: float) = Interop.mkIsosurfaceAttr "isomin" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkIsosurfaceAttr "legendgroup" value
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkIsosurfaceAttr "lighting" (createObj !!properties)
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkIsosurfaceAttr "lightposition" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkIsosurfaceAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkIsosurfaceAttr "name" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkIsosurfaceAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkIsosurfaceAttr "opacity" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkIsosurfaceAttr "reversescale" value
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (anchorId: int) = Interop.mkIsosurfaceAttr "scene" (sprintf "scene%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkIsosurfaceAttr "scene" value
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkIsosurfaceAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkIsosurfaceAttr "showscale" value
    static member inline slices (properties: #ISlicesProperty list) = Interop.mkIsosurfaceAttr "slices" (createObj !!properties)
    static member inline spaceframe (properties: #ISpaceframeProperty list) = Interop.mkIsosurfaceAttr "spaceframe" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkIsosurfaceAttr "stream" (createObj !!properties)
    static member inline surface (properties: #ISurfaceProperty list) = Interop.mkIsosurfaceAttr "surface" (createObj !!properties)
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkIsosurfaceAttr "text" value
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkIsosurfaceAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkIsosurfaceAttr "textsrc" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkIsosurfaceAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkIsosurfaceAttr "uirevision" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: bool) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: System.DateTime) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: float) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: int) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: string) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool list>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool []>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string list>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string []>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int list>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int []>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float list>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float []>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "value" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string option>) = Interop.mkIsosurfaceAttr "value" (values |> ResizeArray)
    /// Sets the hover text formatting rule for `value`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format By default the values are formatted using generic number format.
    static member inline valuehoverformat (value: string) = Interop.mkIsosurfaceAttr "valuehoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  value .
    static member inline valuesrc (value: string) = Interop.mkIsosurfaceAttr "valuesrc" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: bool) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: System.DateTime) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: float) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: int) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: string) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool list>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool []>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string list>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string []>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int list>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int []>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float list>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float []>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string option>) = Interop.mkIsosurfaceAttr "x" (values |> ResizeArray)
    /// Sets the hover text formatting rule for `x`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `xaxis.hoverformat`.
    static member inline xhoverformat (value: string) = Interop.mkIsosurfaceAttr "xhoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkIsosurfaceAttr "xsrc" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: bool) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: System.DateTime) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: float) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: int) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: string) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool list>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool []>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string list>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string []>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int list>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int []>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float list>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float []>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string option>) = Interop.mkIsosurfaceAttr "y" (values |> ResizeArray)
    /// Sets the hover text formatting rule for `y`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `yaxis.hoverformat`.
    static member inline yhoverformat (value: string) = Interop.mkIsosurfaceAttr "yhoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkIsosurfaceAttr "ysrc" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: bool) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: System.DateTime) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: System.DateTimeOffset) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<System.DateTime>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<System.DateTimeOffset>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: float) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: int) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: string) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<bool>>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool list>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool []>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<string>>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string list>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string []>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<int>>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int list>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int []>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<float>>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float list>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float []>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<PlotData>) = Interop.mkIsosurfaceAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<System.DateTimeOffset option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string option>) = Interop.mkIsosurfaceAttr "z" (values |> ResizeArray)
    /// Sets the hover text formatting rule for `z`  using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format By default the values are formatted using `zaxis.hoverformat`.
    static member inline zhoverformat (value: string) = Interop.mkIsosurfaceAttr "zhoverformat" value
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkIsosurfaceAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module isosurface =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkIsosurfaceAttr "hoverinfo" "all"
        static member inline none = Interop.mkIsosurfaceAttr "hoverinfo" "none"
        static member inline skip = Interop.mkIsosurfaceAttr "hoverinfo" "skip"
        static member inline name = Interop.mkIsosurfaceAttr "hoverinfo" "name"
        static member inline text = Interop.mkIsosurfaceAttr "hoverinfo" "text"
        static member inline x = Interop.mkIsosurfaceAttr "hoverinfo" "x"
        static member inline y = Interop.mkIsosurfaceAttr "hoverinfo" "y"
        static member inline z = Interop.mkIsosurfaceAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkIsosurfaceAttr "visible" "legendonly"
        static member inline false' = Interop.mkIsosurfaceAttr "visible" false
        static member inline true' = Interop.mkIsosurfaceAttr "visible" true

