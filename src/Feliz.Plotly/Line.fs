namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type line =
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `marker.line.colorscale`. Has an effect only if in `marker.line.color`is set to a numerical array. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkLineAttr "autocolorscale" value
    /// Determines whether or not the color domain is computed with respect to the input data (here in `marker.line.color`) or the bounds set in `marker.line.cmin` and `marker.line.cmax`  Has an effect only if in `marker.line.color`is set to a numerical array. Defaults to `false` when `marker.line.cmin` and `marker.line.cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkLineAttr "cauto" value
    /// Sets the upper bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkLineAttr "cmax" value
    /// Sets the upper bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkLineAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `marker.line.cmin` and/or `marker.line.cmax` to be equidistant to this point. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color`. Has no effect when `marker.line.cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkLineAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `marker.line.cmin` and/or `marker.line.cmax` to be equidistant to this point. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color`. Has no effect when `marker.line.cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkLineAttr "cmid" value
    /// Sets the lower bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkLineAttr "cmin" value
    /// Sets the lower bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkLineAttr "cmin" value
    /// Sets the line color.
    static member inline color (value: string) = Interop.mkLineAttr "color" value
    /// Sets the line color.
    static member inline color (values: seq<string>) = Interop.mkLineAttr "color" (values |> ResizeArray)
    /// Sets the line color.
    static member inline color (values: seq<int>) = Interop.mkLineAttr "color" (values |> ResizeArray)
    /// Sets the line color.
    static member inline color (values: seq<float>) = Interop.mkLineAttr "color" (values |> ResizeArray)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkLineAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkLineAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkLineAttr "colorbar" (createObj !!properties)
    /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkLineAttr "colorscale" value
    /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkLineAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkLineAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkLineAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkLineAttr "colorsrc" value
    /// Sets the source reference on plot.ly for  dash .
    static member inline dashsrc (value: string) = Interop.mkLineAttr "dashsrc" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `count` and `probability`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkLineAttr "hovertemplate" value
    /// Sets the border line color of the outlier sample points. Defaults to marker.color
    static member inline outliercolor (value: string) = Interop.mkLineAttr "outliercolor" value
    /// Sets the border line width (in px) of the outlier sample points.
    static member inline outlierwidth (value: int) = Interop.mkLineAttr "outlierwidth" value
    /// Sets the border line width (in px) of the outlier sample points.
    static member inline outlierwidth (value: float) = Interop.mkLineAttr "outlierwidth" value
    /// Reverses the color mapping if true. Has an effect only if in `marker.line.color`is set to a numerical array. If true, `marker.line.cmin` will correspond to the last color in the array and `marker.line.cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkLineAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace. Has an effect only if in `line.color`is set to a numerical array.
    static member inline showscale (value: bool) = Interop.mkLineAttr "showscale" value
    /// Simplifies lines by removing nearly-collinear points. When transitioning lines, it may be desirable to disable this so that the number of points along the resulting SVG path is unaffected.
    static member inline simplify (value: bool) = Interop.mkLineAttr "simplify" value
    /// Has an effect only if `shape` is set to *spline* Sets the amount of smoothing. *0* corresponds to no smoothing (equivalent to a *linear* shape).
    static member inline smoothing (value: int) = Interop.mkLineAttr "smoothing" value
    /// Has an effect only if `shape` is set to *spline* Sets the amount of smoothing. *0* corresponds to no smoothing (equivalent to a *linear* shape).
    static member inline smoothing (value: float) = Interop.mkLineAttr "smoothing" value
    /// Sets the line width (in px).
    static member inline width (value: int) = Interop.mkLineAttr "width" value
    /// Sets the line width (in px).
    static member inline width (value: float) = Interop.mkLineAttr "width" value
    /// Sets the line width (in px).
    static member inline width (values: seq<int>) = Interop.mkLineAttr "width" (values |> ResizeArray)
    /// Sets the line width (in px).
    static member inline width (values: seq<float>) = Interop.mkLineAttr "width" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  width .
    static member inline widthsrc (value: string) = Interop.mkLineAttr "widthsrc" value

[<RequireQualifiedAccess>]
module line =
    /// Sets the line color.
    [<Erase>]
    type color =
        /// Sets the line color.
        static member inline rgb (r,g,b) = Interop.mkLineAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the line color.
        static member inline rgba (r,g,b,a) = Interop.mkLineAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the line color.
        static member inline hsl (h,s,l) = Interop.mkLineAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
    [<Erase>]
    type dash =
        static member inline dash = Interop.mkLineAttr "dash" "dash"
        static member inline dashdot = Interop.mkLineAttr "dash" "dashdot"
        static member inline dot = Interop.mkLineAttr "dash" "dot"
        static member inline longdash = Interop.mkLineAttr "dash" "longdash"
        static member inline longdashdot = Interop.mkLineAttr "dash" "longdashdot"
        static member inline solid = Interop.mkLineAttr "dash" "solid"
        static member inline custom (values: seq<int>) = Interop.mkLineAttr "dash" (values |> ResizeArray)
        static member inline custom (values: seq<float>) = Interop.mkLineAttr "dash" (values |> ResizeArray)

    /// Determines the line shape. With *spline* the lines are drawn using spline interpolation. The other available values correspond to step-wise line shapes.
    [<Erase>]
    type shape =
        static member inline hspline = Interop.mkLineAttr "shape" "hspline"
        static member inline hv = Interop.mkLineAttr "shape" "hv"
        static member inline hvh = Interop.mkLineAttr "shape" "hvh"
        static member inline linear = Interop.mkLineAttr "shape" "linear"
        static member inline spline = Interop.mkLineAttr "shape" "spline"
        static member inline vh = Interop.mkLineAttr "shape" "vh"
        static member inline vhv = Interop.mkLineAttr "shape" "vhv"

