namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type streamtube =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkStreamtubeAttr "autocolorscale" value
    /// Determines whether or not the color domain is computed with respect to the input data (here u/v/w norm) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkStreamtubeAttr "cauto" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkStreamtubeAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkStreamtubeAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkStreamtubeAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkStreamtubeAttr "cmid" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkStreamtubeAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkStreamtubeAttr "cmin" value
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkStreamtubeAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkStreamtubeAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkStreamtubeAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkStreamtubeAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkStreamtubeAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkStreamtubeAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkStreamtubeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkStreamtubeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkStreamtubeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkStreamtubeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkStreamtubeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkStreamtubeAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkStreamtubeAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkStreamtubeAttr "customdatasrc" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IStreamtubeProperty list) = Interop.mkStreamtubeAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkStreamtubeAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkStreamtubeAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `tubex`, `tubey`, `tubez`, `tubeu`, `tubev`, `tubew`, `norm` and `divergence`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkStreamtubeAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `tubex`, `tubey`, `tubez`, `tubeu`, `tubev`, `tubew`, `norm` and `divergence`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkStreamtubeAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkStreamtubeAttr "hovertemplatesrc" value
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkStreamtubeAttr "hovertext" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkStreamtubeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkStreamtubeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkStreamtubeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkStreamtubeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkStreamtubeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkStreamtubeAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkStreamtubeAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkStreamtubeAttr "idssrc" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkStreamtubeAttr "legendgroup" value
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkStreamtubeAttr "lighting" (createObj !!properties)
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkStreamtubeAttr "lightposition" (createObj !!properties)
    /// The maximum number of displayed segments in a streamtube.
    static member inline maxdisplayed (value: int) = Interop.mkStreamtubeAttr "maxdisplayed" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkStreamtubeAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkStreamtubeAttr "name" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkStreamtubeAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkStreamtubeAttr "opacity" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkStreamtubeAttr "reversescale" value
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (anchorId: int) = Interop.mkStreamtubeAttr "scene" (sprintf "scene%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkStreamtubeAttr "scene" value
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkStreamtubeAttr "showlegend" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkStreamtubeAttr "showscale" value
    /// The scaling factor for the streamtubes. The default is 1, which avoids two max divergence tubes from touching at adjacent starting positions.
    static member inline sizeref (value: int) = Interop.mkStreamtubeAttr "sizeref" value
    /// The scaling factor for the streamtubes. The default is 1, which avoids two max divergence tubes from touching at adjacent starting positions.
    static member inline sizeref (value: float) = Interop.mkStreamtubeAttr "sizeref" value
    static member inline starts (properties: #IStartsProperty list) = Interop.mkStreamtubeAttr "starts" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkStreamtubeAttr "stream" (createObj !!properties)
    /// Sets a text element associated with this trace. If trace `hoverinfo` contains a *text* flag, this text element will be seen in all hover labels. Note that streamtube traces do not support array `text` values.
    static member inline text (value: string) = Interop.mkStreamtubeAttr "text" value
    /// Sets the x components of the vector field.
    static member inline u (value: bool) = Interop.mkStreamtubeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (value: System.DateTime) = Interop.mkStreamtubeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (value: float) = Interop.mkStreamtubeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (value: int) = Interop.mkStreamtubeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (value: string) = Interop.mkStreamtubeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool list>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool []>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string list>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string []>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int list>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int []>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float list>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float []>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<PlotData>) = Interop.mkStreamtubeAttr "u" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool option>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int option>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float option>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string option>) = Interop.mkStreamtubeAttr "u" (values |> ResizeArray)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkStreamtubeAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkStreamtubeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkStreamtubeAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkStreamtubeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkStreamtubeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkStreamtubeAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkStreamtubeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkStreamtubeAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkStreamtubeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkStreamtubeAttr "uirevision" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  u .
    static member inline usrc (value: string) = Interop.mkStreamtubeAttr "usrc" value
    /// Sets the y components of the vector field.
    static member inline v (value: bool) = Interop.mkStreamtubeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (value: System.DateTime) = Interop.mkStreamtubeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (value: float) = Interop.mkStreamtubeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (value: int) = Interop.mkStreamtubeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (value: string) = Interop.mkStreamtubeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool list>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool []>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string list>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string []>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int list>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int []>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float list>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float []>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<PlotData>) = Interop.mkStreamtubeAttr "v" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool option>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int option>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float option>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string option>) = Interop.mkStreamtubeAttr "v" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  v .
    static member inline vsrc (value: string) = Interop.mkStreamtubeAttr "vsrc" value
    /// Sets the z components of the vector field.
    static member inline w (value: bool) = Interop.mkStreamtubeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (value: System.DateTime) = Interop.mkStreamtubeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (value: float) = Interop.mkStreamtubeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (value: int) = Interop.mkStreamtubeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (value: string) = Interop.mkStreamtubeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool list>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool []>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string list>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string []>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int list>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int []>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float list>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float []>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<PlotData>) = Interop.mkStreamtubeAttr "w" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool option>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int option>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float option>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string option>) = Interop.mkStreamtubeAttr "w" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  w .
    static member inline wsrc (value: string) = Interop.mkStreamtubeAttr "wsrc" value
    /// Sets the x coordinates of the vector field.
    static member inline x (value: bool) = Interop.mkStreamtubeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<bool>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (value: System.DateTime) = Interop.mkStreamtubeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (value: float) = Interop.mkStreamtubeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<float>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (value: int) = Interop.mkStreamtubeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<int>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (value: string) = Interop.mkStreamtubeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<string>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<bool list>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<bool []>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<string list>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<string []>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<int list>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<int []>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<float list>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<float []>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<PlotData>) = Interop.mkStreamtubeAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<bool option>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<int option>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<float option>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field.
    static member inline x (values: seq<string option>) = Interop.mkStreamtubeAttr "x" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkStreamtubeAttr "xsrc" value
    /// Sets the y coordinates of the vector field.
    static member inline y (value: bool) = Interop.mkStreamtubeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<bool>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (value: System.DateTime) = Interop.mkStreamtubeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (value: float) = Interop.mkStreamtubeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<float>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (value: int) = Interop.mkStreamtubeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<int>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (value: string) = Interop.mkStreamtubeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<string>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<bool list>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<bool []>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<string list>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<string []>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<int list>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<int []>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<float list>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<float []>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<PlotData>) = Interop.mkStreamtubeAttr "y" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<bool option>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<int option>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<float option>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field.
    static member inline y (values: seq<string option>) = Interop.mkStreamtubeAttr "y" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  y .
    static member inline ysrc (value: string) = Interop.mkStreamtubeAttr "ysrc" value
    /// Sets the z coordinates of the vector field.
    static member inline z (value: bool) = Interop.mkStreamtubeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<bool>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (value: System.DateTime) = Interop.mkStreamtubeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<System.DateTime>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (value: float) = Interop.mkStreamtubeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<float>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (value: int) = Interop.mkStreamtubeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<int>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (value: string) = Interop.mkStreamtubeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<string>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<seq<bool>>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<bool list>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<bool []>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<seq<string>>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<string list>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<string []>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<seq<int>>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<int list>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<int []>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<seq<float>>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<float list>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<float []>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<PlotData>) = Interop.mkStreamtubeAttr "z" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<bool option>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<int option>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<float option>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field.
    static member inline z (values: seq<string option>) = Interop.mkStreamtubeAttr "z" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  z .
    static member inline zsrc (value: string) = Interop.mkStreamtubeAttr "zsrc" value

[<Erase;RequireQualifiedAccess>]
module streamtube =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkStreamtubeAttr "hoverinfo" "all"
        static member inline none = Interop.mkStreamtubeAttr "hoverinfo" "none"
        static member inline skip = Interop.mkStreamtubeAttr "hoverinfo" "skip"
        static member inline divergence = Interop.mkStreamtubeAttr "hoverinfo" "divergence"
        static member inline name = Interop.mkStreamtubeAttr "hoverinfo" "name"
        static member inline norm = Interop.mkStreamtubeAttr "hoverinfo" "norm"
        static member inline text = Interop.mkStreamtubeAttr "hoverinfo" "text"
        static member inline u = Interop.mkStreamtubeAttr "hoverinfo" "u"
        static member inline v = Interop.mkStreamtubeAttr "hoverinfo" "v"
        static member inline w = Interop.mkStreamtubeAttr "hoverinfo" "w"
        static member inline x = Interop.mkStreamtubeAttr "hoverinfo" "x"
        static member inline y = Interop.mkStreamtubeAttr "hoverinfo" "y"
        static member inline z = Interop.mkStreamtubeAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkStreamtubeAttr "visible" "legendonly"
        static member inline false' = Interop.mkStreamtubeAttr "visible" false
        static member inline true' = Interop.mkStreamtubeAttr "visible" true

