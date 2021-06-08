namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type marker =
    /// Flag to draw all symbols, even if they overlap.
    static member inline allowoverlap (value: bool) = Interop.mkMarkerAttr "allowoverlap" value
    /// Sets the marker orientation from true North, in degrees clockwise. When using the *auto* default, no rotation would be applied in perspective views which is different from using a zero angle.
    static member inline angle (value: int) = Interop.mkMarkerAttr "angle" value
    /// Sets the marker orientation from true North, in degrees clockwise. When using the *auto* default, no rotation would be applied in perspective views which is different from using a zero angle.
    static member inline angle (value: float) = Interop.mkMarkerAttr "angle" value
    /// Sets the marker orientation from true North, in degrees clockwise. When using the *auto* default, no rotation would be applied in perspective views which is different from using a zero angle.
    static member inline angle (values: seq<int>) = Interop.mkMarkerAttr "angle" (values |> ResizeArray)
    /// Sets the marker orientation from true North, in degrees clockwise. When using the *auto* default, no rotation would be applied in perspective views which is different from using a zero angle.
    static member inline angle (values: seq<float>) = Interop.mkMarkerAttr "angle" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  angle .
    static member inline anglesrc (value: string) = Interop.mkMarkerAttr "anglesrc" value
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `marker.colorscale`. Has an effect only if in `marker.color`is set to a numerical array. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkMarkerAttr "autocolorscale" value
    /// Determines if colors are blended together for a translucency effect in case `opacity` is specified as a value less then `1`. Setting `blend` to `true` reduces zoom/pan speed if used with large numbers of points.
    static member inline blend (value: bool) = Interop.mkMarkerAttr "blend" value
    static member inline border (properties: #IBorderProperty list) = Interop.mkMarkerAttr "border" (createObj !!properties)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `marker.color`) or the bounds set in `marker.cmin` and `marker.cmax`  Has an effect only if in `marker.color`is set to a numerical array. Defaults to `false` when `marker.cmin` and `marker.cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkMarkerAttr "cauto" value
    /// Sets the upper bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkMarkerAttr "cmax" value
    /// Sets the upper bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkMarkerAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `marker.cmin` and/or `marker.cmax` to be equidistant to this point. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color`. Has no effect when `marker.cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkMarkerAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `marker.cmin` and/or `marker.cmax` to be equidistant to this point. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color`. Has no effect when `marker.cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkMarkerAttr "cmid" value
    /// Sets the lower bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkMarkerAttr "cmin" value
    /// Sets the lower bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkMarkerAttr "cmin" value
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (value: string) = Interop.mkMarkerAttr "color" value
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (values: seq<string>) = Interop.mkMarkerAttr "color" (values |> ResizeArray)
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (value: int) = Interop.mkMarkerAttr "color" (value |> Array.singleton)
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (values: seq<int>) = Interop.mkMarkerAttr "color" (values |> ResizeArray)
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (value: float) = Interop.mkMarkerAttr "color" (value |> Array.singleton)
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    static member inline color (values: seq<float>) = Interop.mkMarkerAttr "color" (values |> ResizeArray)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (anchorId: int) = Interop.mkMarkerAttr "coloraxis" (sprintf "coloraxis%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkMarkerAttr "coloraxis" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkMarkerAttr "colorbar" (createObj !!properties)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (value: bool) = Interop.mkMarkerAttr "colors" (value |> Array.singleton |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<bool>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (value: System.DateTime) = Interop.mkMarkerAttr "colors" (value |> Array.singleton |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<System.DateTime>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (value: float) = Interop.mkMarkerAttr "colors" (value |> Array.singleton |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<float>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (value: int) = Interop.mkMarkerAttr "colors" (value |> Array.singleton |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<int>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (value: string) = Interop.mkMarkerAttr "colors" (value |> Array.singleton |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<string>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<seq<bool>>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<bool list>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<bool []>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<seq<string>>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<string list>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<string []>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<seq<int>>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<int list>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<int []>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<seq<float>>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<float list>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<float []>) = Interop.mkMarkerAttr "colors" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<PlotData>) = Interop.mkMarkerAttr "colors" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<bool option>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<System.DateTime option>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<int option>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<float option>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
    static member inline colors (values: seq<string option>) = Interop.mkMarkerAttr "colors" (values |> ResizeArray)
    /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkMarkerAttr "colorscale" value
    /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<seq<string>>) = Interop.mkMarkerAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkMarkerAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string []>) = Interop.mkMarkerAttr "colorscale" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkMarkerAttr "colorsrc" value
    /// Sets the source reference on Chart Studio Cloud for  colors .
    static member inline colorssrc (value: string) = Interop.mkMarkerAttr "colorssrc" value
    static member inline gradient (properties: #IGradientProperty list) = Interop.mkMarkerAttr "gradient" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkMarkerAttr "line" (createObj !!properties)
    /// Sets a maximum number of points to be drawn on the graph. *0* corresponds to no limit.
    static member inline maxdisplayed (value: int) = Interop.mkMarkerAttr "maxdisplayed" value
    /// Sets a maximum number of points to be drawn on the graph. *0* corresponds to no limit.
    static member inline maxdisplayed (value: float) = Interop.mkMarkerAttr "maxdisplayed" value
    /// Sets the marker opacity.
    static member inline opacity (value: int) = Interop.mkMarkerAttr "opacity" value
    /// Sets the marker opacity.
    static member inline opacity (value: float) = Interop.mkMarkerAttr "opacity" value
    /// Sets the marker opacity.
    static member inline opacity (values: seq<int>) = Interop.mkMarkerAttr "opacity" (values |> ResizeArray)
    /// Sets the marker opacity.
    static member inline opacity (values: seq<float>) = Interop.mkMarkerAttr "opacity" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  opacity .
    static member inline opacitysrc (value: string) = Interop.mkMarkerAttr "opacitysrc" value
    /// Sets the color of the outlier sample points.
    static member inline outliercolor (value: string) = Interop.mkMarkerAttr "outliercolor" value
    static member inline pad (properties: #IPadProperty list) = Interop.mkMarkerAttr "pad" (createObj !!properties)
    static member inline pattern (properties: #IPatternProperty list) = Interop.mkMarkerAttr "pattern" (createObj !!properties)
    /// Reverses the color mapping if true. Has an effect only if in `marker.color`is set to a numerical array. If true, `marker.cmin` will correspond to the last color in the array and `marker.cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkMarkerAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace. Has an effect only if in `marker.color`is set to a numerical array.
    static member inline showscale (value: bool) = Interop.mkMarkerAttr "showscale" value
    /// Sets the marker size (in px).
    static member inline size (value: int) = Interop.mkMarkerAttr "size" value
    /// Sets the marker size (in px).
    static member inline size (value: float) = Interop.mkMarkerAttr "size" value
    /// Sets the marker size (in px).
    static member inline size (values: seq<int>) = Interop.mkMarkerAttr "size" (values |> ResizeArray)
    /// Sets the marker size (in px).
    static member inline size (values: seq<float>) = Interop.mkMarkerAttr "size" (values |> ResizeArray)
    /// Sets the maximum size (in px) of the rendered marker points. Effective when the `pointcloud` shows only few points.
    static member inline sizemax (value: int) = Interop.mkMarkerAttr "sizemax" value
    /// Sets the maximum size (in px) of the rendered marker points. Effective when the `pointcloud` shows only few points.
    static member inline sizemax (value: float) = Interop.mkMarkerAttr "sizemax" value
    /// Has an effect only if `marker.size` is set to a numerical array. Sets the minimum size (in px) of the rendered marker points.
    static member inline sizemin (value: int) = Interop.mkMarkerAttr "sizemin" value
    /// Has an effect only if `marker.size` is set to a numerical array. Sets the minimum size (in px) of the rendered marker points.
    static member inline sizemin (value: float) = Interop.mkMarkerAttr "sizemin" value
    /// Has an effect only if `marker.size` is set to a numerical array. Sets the scale factor used to determine the rendered size of marker points. Use with `sizemin` and `sizemode`.
    static member inline sizeref (value: int) = Interop.mkMarkerAttr "sizeref" value
    /// Has an effect only if `marker.size` is set to a numerical array. Sets the scale factor used to determine the rendered size of marker points. Use with `sizemin` and `sizemode`.
    static member inline sizeref (value: float) = Interop.mkMarkerAttr "sizeref" value
    /// Sets the source reference on Chart Studio Cloud for  size .
    static member inline sizesrc (value: string) = Interop.mkMarkerAttr "sizesrc" value
    /// Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
    static member inline symbol (properties: #IMarkerProperty list) = Interop.mkMarkerAttr "symbol" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  symbol .
    static member inline symbolsrc (value: string) = Interop.mkMarkerAttr "symbolsrc" value

[<Erase;RequireQualifiedAccess>]
module marker =
    /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
    [<Erase>]
    type color =
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        static member inline rgb (r,g,b) = Interop.mkMarkerAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        static member inline rgba (r,g,b,a) = Interop.mkMarkerAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        static member inline hsl (h,s,l) = Interop.mkMarkerAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines if the sector colors are faded towards the background from the leaves up to the headers. This option is unavailable when a `colorscale` is present, defaults to false when `marker.colors` is set, but otherwise defaults to true. When set to *reversed*, the fading direction is inverted, that is the top elements within hierarchy are drawn with fully saturated colors while the leaves are faded towards the background color.
    [<Erase>]
    type depthfade =
        static member inline reversed = Interop.mkMarkerAttr "depthfade" "reversed"
        static member inline false' = Interop.mkMarkerAttr "depthfade" false
        static member inline true' = Interop.mkMarkerAttr "depthfade" true

    /// Has an effect only if `marker.size` is set to a numerical array. Sets the rule for which the data in `size` is converted to pixels.
    [<Erase>]
    type sizemode =
        static member inline area = Interop.mkMarkerAttr "sizemode" "area"
        static member inline diameter = Interop.mkMarkerAttr "sizemode" "diameter"

    /// Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
    [<Erase>]
    type symbol =
        static member inline _0 = Interop.mkMarkerAttr "symbol" "0"
        static member inline _1 = Interop.mkMarkerAttr "symbol" "1"
        static member inline _10 = Interop.mkMarkerAttr "symbol" "10"
        static member inline _100 = Interop.mkMarkerAttr "symbol" "100"
        static member inline _101 = Interop.mkMarkerAttr "symbol" "101"
        static member inline _102 = Interop.mkMarkerAttr "symbol" "102"
        static member inline _103 = Interop.mkMarkerAttr "symbol" "103"
        static member inline _104 = Interop.mkMarkerAttr "symbol" "104"
        static member inline _105 = Interop.mkMarkerAttr "symbol" "105"
        static member inline _106 = Interop.mkMarkerAttr "symbol" "106"
        static member inline _107 = Interop.mkMarkerAttr "symbol" "107"
        static member inline _108 = Interop.mkMarkerAttr "symbol" "108"
        static member inline _109 = Interop.mkMarkerAttr "symbol" "109"
        static member inline _11 = Interop.mkMarkerAttr "symbol" "11"
        static member inline _110 = Interop.mkMarkerAttr "symbol" "110"
        static member inline _111 = Interop.mkMarkerAttr "symbol" "111"
        static member inline _112 = Interop.mkMarkerAttr "symbol" "112"
        static member inline _113 = Interop.mkMarkerAttr "symbol" "113"
        static member inline _114 = Interop.mkMarkerAttr "symbol" "114"
        static member inline _115 = Interop.mkMarkerAttr "symbol" "115"
        static member inline _116 = Interop.mkMarkerAttr "symbol" "116"
        static member inline _117 = Interop.mkMarkerAttr "symbol" "117"
        static member inline _118 = Interop.mkMarkerAttr "symbol" "118"
        static member inline _119 = Interop.mkMarkerAttr "symbol" "119"
        static member inline _12 = Interop.mkMarkerAttr "symbol" "12"
        static member inline _120 = Interop.mkMarkerAttr "symbol" "120"
        static member inline _121 = Interop.mkMarkerAttr "symbol" "121"
        static member inline _122 = Interop.mkMarkerAttr "symbol" "122"
        static member inline _123 = Interop.mkMarkerAttr "symbol" "123"
        static member inline _124 = Interop.mkMarkerAttr "symbol" "124"
        static member inline _125 = Interop.mkMarkerAttr "symbol" "125"
        static member inline _126 = Interop.mkMarkerAttr "symbol" "126"
        static member inline _127 = Interop.mkMarkerAttr "symbol" "127"
        static member inline _128 = Interop.mkMarkerAttr "symbol" "128"
        static member inline _129 = Interop.mkMarkerAttr "symbol" "129"
        static member inline _13 = Interop.mkMarkerAttr "symbol" "13"
        static member inline _130 = Interop.mkMarkerAttr "symbol" "130"
        static member inline _131 = Interop.mkMarkerAttr "symbol" "131"
        static member inline _132 = Interop.mkMarkerAttr "symbol" "132"
        static member inline _133 = Interop.mkMarkerAttr "symbol" "133"
        static member inline _134 = Interop.mkMarkerAttr "symbol" "134"
        static member inline _135 = Interop.mkMarkerAttr "symbol" "135"
        static member inline _136 = Interop.mkMarkerAttr "symbol" "136"
        static member inline _137 = Interop.mkMarkerAttr "symbol" "137"
        static member inline _138 = Interop.mkMarkerAttr "symbol" "138"
        static member inline _139 = Interop.mkMarkerAttr "symbol" "139"
        static member inline _14 = Interop.mkMarkerAttr "symbol" "14"
        static member inline _140 = Interop.mkMarkerAttr "symbol" "140"
        static member inline _141 = Interop.mkMarkerAttr "symbol" "141"
        static member inline _142 = Interop.mkMarkerAttr "symbol" "142"
        static member inline _143 = Interop.mkMarkerAttr "symbol" "143"
        static member inline _144 = Interop.mkMarkerAttr "symbol" "144"
        static member inline _145 = Interop.mkMarkerAttr "symbol" "145"
        static member inline _146 = Interop.mkMarkerAttr "symbol" "146"
        static member inline _147 = Interop.mkMarkerAttr "symbol" "147"
        static member inline _148 = Interop.mkMarkerAttr "symbol" "148"
        static member inline _149 = Interop.mkMarkerAttr "symbol" "149"
        static member inline _15 = Interop.mkMarkerAttr "symbol" "15"
        static member inline _150 = Interop.mkMarkerAttr "symbol" "150"
        static member inline _151 = Interop.mkMarkerAttr "symbol" "151"
        static member inline _152 = Interop.mkMarkerAttr "symbol" "152"
        static member inline _16 = Interop.mkMarkerAttr "symbol" "16"
        static member inline _17 = Interop.mkMarkerAttr "symbol" "17"
        static member inline _18 = Interop.mkMarkerAttr "symbol" "18"
        static member inline _19 = Interop.mkMarkerAttr "symbol" "19"
        static member inline _2 = Interop.mkMarkerAttr "symbol" "2"
        static member inline _20 = Interop.mkMarkerAttr "symbol" "20"
        static member inline _200 = Interop.mkMarkerAttr "symbol" "200"
        static member inline _201 = Interop.mkMarkerAttr "symbol" "201"
        static member inline _202 = Interop.mkMarkerAttr "symbol" "202"
        static member inline _203 = Interop.mkMarkerAttr "symbol" "203"
        static member inline _204 = Interop.mkMarkerAttr "symbol" "204"
        static member inline _205 = Interop.mkMarkerAttr "symbol" "205"
        static member inline _206 = Interop.mkMarkerAttr "symbol" "206"
        static member inline _207 = Interop.mkMarkerAttr "symbol" "207"
        static member inline _208 = Interop.mkMarkerAttr "symbol" "208"
        static member inline _209 = Interop.mkMarkerAttr "symbol" "209"
        static member inline _21 = Interop.mkMarkerAttr "symbol" "21"
        static member inline _210 = Interop.mkMarkerAttr "symbol" "210"
        static member inline _211 = Interop.mkMarkerAttr "symbol" "211"
        static member inline _212 = Interop.mkMarkerAttr "symbol" "212"
        static member inline _213 = Interop.mkMarkerAttr "symbol" "213"
        static member inline _214 = Interop.mkMarkerAttr "symbol" "214"
        static member inline _215 = Interop.mkMarkerAttr "symbol" "215"
        static member inline _216 = Interop.mkMarkerAttr "symbol" "216"
        static member inline _217 = Interop.mkMarkerAttr "symbol" "217"
        static member inline _218 = Interop.mkMarkerAttr "symbol" "218"
        static member inline _219 = Interop.mkMarkerAttr "symbol" "219"
        static member inline _22 = Interop.mkMarkerAttr "symbol" "22"
        static member inline _220 = Interop.mkMarkerAttr "symbol" "220"
        static member inline _221 = Interop.mkMarkerAttr "symbol" "221"
        static member inline _222 = Interop.mkMarkerAttr "symbol" "222"
        static member inline _223 = Interop.mkMarkerAttr "symbol" "223"
        static member inline _224 = Interop.mkMarkerAttr "symbol" "224"
        static member inline _23 = Interop.mkMarkerAttr "symbol" "23"
        static member inline _236 = Interop.mkMarkerAttr "symbol" "236"
        static member inline _24 = Interop.mkMarkerAttr "symbol" "24"
        static member inline _25 = Interop.mkMarkerAttr "symbol" "25"
        static member inline _26 = Interop.mkMarkerAttr "symbol" "26"
        static member inline _27 = Interop.mkMarkerAttr "symbol" "27"
        static member inline _28 = Interop.mkMarkerAttr "symbol" "28"
        static member inline _29 = Interop.mkMarkerAttr "symbol" "29"
        static member inline _3 = Interop.mkMarkerAttr "symbol" "3"
        static member inline _30 = Interop.mkMarkerAttr "symbol" "30"
        static member inline _300 = Interop.mkMarkerAttr "symbol" "300"
        static member inline _301 = Interop.mkMarkerAttr "symbol" "301"
        static member inline _302 = Interop.mkMarkerAttr "symbol" "302"
        static member inline _303 = Interop.mkMarkerAttr "symbol" "303"
        static member inline _304 = Interop.mkMarkerAttr "symbol" "304"
        static member inline _305 = Interop.mkMarkerAttr "symbol" "305"
        static member inline _306 = Interop.mkMarkerAttr "symbol" "306"
        static member inline _307 = Interop.mkMarkerAttr "symbol" "307"
        static member inline _308 = Interop.mkMarkerAttr "symbol" "308"
        static member inline _309 = Interop.mkMarkerAttr "symbol" "309"
        static member inline _31 = Interop.mkMarkerAttr "symbol" "31"
        static member inline _310 = Interop.mkMarkerAttr "symbol" "310"
        static member inline _311 = Interop.mkMarkerAttr "symbol" "311"
        static member inline _312 = Interop.mkMarkerAttr "symbol" "312"
        static member inline _313 = Interop.mkMarkerAttr "symbol" "313"
        static member inline _314 = Interop.mkMarkerAttr "symbol" "314"
        static member inline _315 = Interop.mkMarkerAttr "symbol" "315"
        static member inline _316 = Interop.mkMarkerAttr "symbol" "316"
        static member inline _317 = Interop.mkMarkerAttr "symbol" "317"
        static member inline _318 = Interop.mkMarkerAttr "symbol" "318"
        static member inline _319 = Interop.mkMarkerAttr "symbol" "319"
        static member inline _32 = Interop.mkMarkerAttr "symbol" "32"
        static member inline _320 = Interop.mkMarkerAttr "symbol" "320"
        static member inline _321 = Interop.mkMarkerAttr "symbol" "321"
        static member inline _322 = Interop.mkMarkerAttr "symbol" "322"
        static member inline _323 = Interop.mkMarkerAttr "symbol" "323"
        static member inline _324 = Interop.mkMarkerAttr "symbol" "324"
        static member inline _33 = Interop.mkMarkerAttr "symbol" "33"
        static member inline _336 = Interop.mkMarkerAttr "symbol" "336"
        static member inline _34 = Interop.mkMarkerAttr "symbol" "34"
        static member inline _35 = Interop.mkMarkerAttr "symbol" "35"
        static member inline _36 = Interop.mkMarkerAttr "symbol" "36"
        static member inline _37 = Interop.mkMarkerAttr "symbol" "37"
        static member inline _38 = Interop.mkMarkerAttr "symbol" "38"
        static member inline _39 = Interop.mkMarkerAttr "symbol" "39"
        static member inline _4 = Interop.mkMarkerAttr "symbol" "4"
        static member inline _40 = Interop.mkMarkerAttr "symbol" "40"
        static member inline _41 = Interop.mkMarkerAttr "symbol" "41"
        static member inline _42 = Interop.mkMarkerAttr "symbol" "42"
        static member inline _43 = Interop.mkMarkerAttr "symbol" "43"
        static member inline _44 = Interop.mkMarkerAttr "symbol" "44"
        static member inline _45 = Interop.mkMarkerAttr "symbol" "45"
        static member inline _46 = Interop.mkMarkerAttr "symbol" "46"
        static member inline _47 = Interop.mkMarkerAttr "symbol" "47"
        static member inline _48 = Interop.mkMarkerAttr "symbol" "48"
        static member inline _49 = Interop.mkMarkerAttr "symbol" "49"
        static member inline _5 = Interop.mkMarkerAttr "symbol" "5"
        static member inline _50 = Interop.mkMarkerAttr "symbol" "50"
        static member inline _51 = Interop.mkMarkerAttr "symbol" "51"
        static member inline _52 = Interop.mkMarkerAttr "symbol" "52"
        static member inline _6 = Interop.mkMarkerAttr "symbol" "6"
        static member inline _7 = Interop.mkMarkerAttr "symbol" "7"
        static member inline _8 = Interop.mkMarkerAttr "symbol" "8"
        static member inline _9 = Interop.mkMarkerAttr "symbol" "9"
        static member inline arrowBarDown = Interop.mkMarkerAttr "symbol" "arrow-bar-down"
        static member inline arrowBarDownOpen = Interop.mkMarkerAttr "symbol" "arrow-bar-down-open"
        static member inline arrowBarLeft = Interop.mkMarkerAttr "symbol" "arrow-bar-left"
        static member inline arrowBarLeftOpen = Interop.mkMarkerAttr "symbol" "arrow-bar-left-open"
        static member inline arrowBarRight = Interop.mkMarkerAttr "symbol" "arrow-bar-right"
        static member inline arrowBarRightOpen = Interop.mkMarkerAttr "symbol" "arrow-bar-right-open"
        static member inline arrowBarUp = Interop.mkMarkerAttr "symbol" "arrow-bar-up"
        static member inline arrowBarUpOpen = Interop.mkMarkerAttr "symbol" "arrow-bar-up-open"
        static member inline arrowDown = Interop.mkMarkerAttr "symbol" "arrow-down"
        static member inline arrowDownOpen = Interop.mkMarkerAttr "symbol" "arrow-down-open"
        static member inline arrowLeft = Interop.mkMarkerAttr "symbol" "arrow-left"
        static member inline arrowLeftOpen = Interop.mkMarkerAttr "symbol" "arrow-left-open"
        static member inline arrowRight = Interop.mkMarkerAttr "symbol" "arrow-right"
        static member inline arrowRightOpen = Interop.mkMarkerAttr "symbol" "arrow-right-open"
        static member inline arrowUp = Interop.mkMarkerAttr "symbol" "arrow-up"
        static member inline arrowUpOpen = Interop.mkMarkerAttr "symbol" "arrow-up-open"
        static member inline asterisk = Interop.mkMarkerAttr "symbol" "asterisk"
        static member inline asteriskOpen = Interop.mkMarkerAttr "symbol" "asterisk-open"
        static member inline bowtie = Interop.mkMarkerAttr "symbol" "bowtie"
        static member inline bowtieOpen = Interop.mkMarkerAttr "symbol" "bowtie-open"
        static member inline circle = Interop.mkMarkerAttr "symbol" "circle"
        static member inline circleCross = Interop.mkMarkerAttr "symbol" "circle-cross"
        static member inline circleCrossOpen = Interop.mkMarkerAttr "symbol" "circle-cross-open"
        static member inline circleDot = Interop.mkMarkerAttr "symbol" "circle-dot"
        static member inline circleOpen = Interop.mkMarkerAttr "symbol" "circle-open"
        static member inline circleOpenDot = Interop.mkMarkerAttr "symbol" "circle-open-dot"
        static member inline circleX = Interop.mkMarkerAttr "symbol" "circle-x"
        static member inline circleXOpen = Interop.mkMarkerAttr "symbol" "circle-x-open"
        static member inline cross = Interop.mkMarkerAttr "symbol" "cross"
        static member inline crossDot = Interop.mkMarkerAttr "symbol" "cross-dot"
        static member inline crossOpen = Interop.mkMarkerAttr "symbol" "cross-open"
        static member inline crossOpenDot = Interop.mkMarkerAttr "symbol" "cross-open-dot"
        static member inline crossThin = Interop.mkMarkerAttr "symbol" "cross-thin"
        static member inline crossThinOpen = Interop.mkMarkerAttr "symbol" "cross-thin-open"
        static member inline diamond = Interop.mkMarkerAttr "symbol" "diamond"
        static member inline diamondCross = Interop.mkMarkerAttr "symbol" "diamond-cross"
        static member inline diamondCrossOpen = Interop.mkMarkerAttr "symbol" "diamond-cross-open"
        static member inline diamondDot = Interop.mkMarkerAttr "symbol" "diamond-dot"
        static member inline diamondOpen = Interop.mkMarkerAttr "symbol" "diamond-open"
        static member inline diamondOpenDot = Interop.mkMarkerAttr "symbol" "diamond-open-dot"
        static member inline diamondTall = Interop.mkMarkerAttr "symbol" "diamond-tall"
        static member inline diamondTallDot = Interop.mkMarkerAttr "symbol" "diamond-tall-dot"
        static member inline diamondTallOpen = Interop.mkMarkerAttr "symbol" "diamond-tall-open"
        static member inline diamondTallOpenDot = Interop.mkMarkerAttr "symbol" "diamond-tall-open-dot"
        static member inline diamondWide = Interop.mkMarkerAttr "symbol" "diamond-wide"
        static member inline diamondWideDot = Interop.mkMarkerAttr "symbol" "diamond-wide-dot"
        static member inline diamondWideOpen = Interop.mkMarkerAttr "symbol" "diamond-wide-open"
        static member inline diamondWideOpenDot = Interop.mkMarkerAttr "symbol" "diamond-wide-open-dot"
        static member inline diamondX = Interop.mkMarkerAttr "symbol" "diamond-x"
        static member inline diamondXOpen = Interop.mkMarkerAttr "symbol" "diamond-x-open"
        static member inline hash = Interop.mkMarkerAttr "symbol" "hash"
        static member inline hashDot = Interop.mkMarkerAttr "symbol" "hash-dot"
        static member inline hashOpen = Interop.mkMarkerAttr "symbol" "hash-open"
        static member inline hashOpenDot = Interop.mkMarkerAttr "symbol" "hash-open-dot"
        static member inline hexagon = Interop.mkMarkerAttr "symbol" "hexagon"
        static member inline hexagonDot = Interop.mkMarkerAttr "symbol" "hexagon-dot"
        static member inline hexagonOpen = Interop.mkMarkerAttr "symbol" "hexagon-open"
        static member inline hexagonOpenDot = Interop.mkMarkerAttr "symbol" "hexagon-open-dot"
        static member inline hexagon2 = Interop.mkMarkerAttr "symbol" "hexagon2"
        static member inline hexagon2Dot = Interop.mkMarkerAttr "symbol" "hexagon2-dot"
        static member inline hexagon2Open = Interop.mkMarkerAttr "symbol" "hexagon2-open"
        static member inline hexagon2OpenDot = Interop.mkMarkerAttr "symbol" "hexagon2-open-dot"
        static member inline hexagram = Interop.mkMarkerAttr "symbol" "hexagram"
        static member inline hexagramDot = Interop.mkMarkerAttr "symbol" "hexagram-dot"
        static member inline hexagramOpen = Interop.mkMarkerAttr "symbol" "hexagram-open"
        static member inline hexagramOpenDot = Interop.mkMarkerAttr "symbol" "hexagram-open-dot"
        static member inline hourglass = Interop.mkMarkerAttr "symbol" "hourglass"
        static member inline hourglassOpen = Interop.mkMarkerAttr "symbol" "hourglass-open"
        static member inline lineEw = Interop.mkMarkerAttr "symbol" "line-ew"
        static member inline lineEwOpen = Interop.mkMarkerAttr "symbol" "line-ew-open"
        static member inline lineNe = Interop.mkMarkerAttr "symbol" "line-ne"
        static member inline lineNeOpen = Interop.mkMarkerAttr "symbol" "line-ne-open"
        static member inline lineNs = Interop.mkMarkerAttr "symbol" "line-ns"
        static member inline lineNsOpen = Interop.mkMarkerAttr "symbol" "line-ns-open"
        static member inline lineNw = Interop.mkMarkerAttr "symbol" "line-nw"
        static member inline lineNwOpen = Interop.mkMarkerAttr "symbol" "line-nw-open"
        static member inline octagon = Interop.mkMarkerAttr "symbol" "octagon"
        static member inline octagonDot = Interop.mkMarkerAttr "symbol" "octagon-dot"
        static member inline octagonOpen = Interop.mkMarkerAttr "symbol" "octagon-open"
        static member inline octagonOpenDot = Interop.mkMarkerAttr "symbol" "octagon-open-dot"
        static member inline pentagon = Interop.mkMarkerAttr "symbol" "pentagon"
        static member inline pentagonDot = Interop.mkMarkerAttr "symbol" "pentagon-dot"
        static member inline pentagonOpen = Interop.mkMarkerAttr "symbol" "pentagon-open"
        static member inline pentagonOpenDot = Interop.mkMarkerAttr "symbol" "pentagon-open-dot"
        static member inline square = Interop.mkMarkerAttr "symbol" "square"
        static member inline squareCross = Interop.mkMarkerAttr "symbol" "square-cross"
        static member inline squareCrossOpen = Interop.mkMarkerAttr "symbol" "square-cross-open"
        static member inline squareDot = Interop.mkMarkerAttr "symbol" "square-dot"
        static member inline squareOpen = Interop.mkMarkerAttr "symbol" "square-open"
        static member inline squareOpenDot = Interop.mkMarkerAttr "symbol" "square-open-dot"
        static member inline squareX = Interop.mkMarkerAttr "symbol" "square-x"
        static member inline squareXOpen = Interop.mkMarkerAttr "symbol" "square-x-open"
        static member inline star = Interop.mkMarkerAttr "symbol" "star"
        static member inline starDiamond = Interop.mkMarkerAttr "symbol" "star-diamond"
        static member inline starDiamondDot = Interop.mkMarkerAttr "symbol" "star-diamond-dot"
        static member inline starDiamondOpen = Interop.mkMarkerAttr "symbol" "star-diamond-open"
        static member inline starDiamondOpenDot = Interop.mkMarkerAttr "symbol" "star-diamond-open-dot"
        static member inline starDot = Interop.mkMarkerAttr "symbol" "star-dot"
        static member inline starOpen = Interop.mkMarkerAttr "symbol" "star-open"
        static member inline starOpenDot = Interop.mkMarkerAttr "symbol" "star-open-dot"
        static member inline starSquare = Interop.mkMarkerAttr "symbol" "star-square"
        static member inline starSquareDot = Interop.mkMarkerAttr "symbol" "star-square-dot"
        static member inline starSquareOpen = Interop.mkMarkerAttr "symbol" "star-square-open"
        static member inline starSquareOpenDot = Interop.mkMarkerAttr "symbol" "star-square-open-dot"
        static member inline starTriangleDown = Interop.mkMarkerAttr "symbol" "star-triangle-down"
        static member inline starTriangleDownDot = Interop.mkMarkerAttr "symbol" "star-triangle-down-dot"
        static member inline starTriangleDownOpen = Interop.mkMarkerAttr "symbol" "star-triangle-down-open"
        static member inline starTriangleDownOpenDot = Interop.mkMarkerAttr "symbol" "star-triangle-down-open-dot"
        static member inline starTriangleUp = Interop.mkMarkerAttr "symbol" "star-triangle-up"
        static member inline starTriangleUpDot = Interop.mkMarkerAttr "symbol" "star-triangle-up-dot"
        static member inline starTriangleUpOpen = Interop.mkMarkerAttr "symbol" "star-triangle-up-open"
        static member inline starTriangleUpOpenDot = Interop.mkMarkerAttr "symbol" "star-triangle-up-open-dot"
        static member inline triangleDown = Interop.mkMarkerAttr "symbol" "triangle-down"
        static member inline triangleDownDot = Interop.mkMarkerAttr "symbol" "triangle-down-dot"
        static member inline triangleDownOpen = Interop.mkMarkerAttr "symbol" "triangle-down-open"
        static member inline triangleDownOpenDot = Interop.mkMarkerAttr "symbol" "triangle-down-open-dot"
        static member inline triangleLeft = Interop.mkMarkerAttr "symbol" "triangle-left"
        static member inline triangleLeftDot = Interop.mkMarkerAttr "symbol" "triangle-left-dot"
        static member inline triangleLeftOpen = Interop.mkMarkerAttr "symbol" "triangle-left-open"
        static member inline triangleLeftOpenDot = Interop.mkMarkerAttr "symbol" "triangle-left-open-dot"
        static member inline triangleNe = Interop.mkMarkerAttr "symbol" "triangle-ne"
        static member inline triangleNeDot = Interop.mkMarkerAttr "symbol" "triangle-ne-dot"
        static member inline triangleNeOpen = Interop.mkMarkerAttr "symbol" "triangle-ne-open"
        static member inline triangleNeOpenDot = Interop.mkMarkerAttr "symbol" "triangle-ne-open-dot"
        static member inline triangleNw = Interop.mkMarkerAttr "symbol" "triangle-nw"
        static member inline triangleNwDot = Interop.mkMarkerAttr "symbol" "triangle-nw-dot"
        static member inline triangleNwOpen = Interop.mkMarkerAttr "symbol" "triangle-nw-open"
        static member inline triangleNwOpenDot = Interop.mkMarkerAttr "symbol" "triangle-nw-open-dot"
        static member inline triangleRight = Interop.mkMarkerAttr "symbol" "triangle-right"
        static member inline triangleRightDot = Interop.mkMarkerAttr "symbol" "triangle-right-dot"
        static member inline triangleRightOpen = Interop.mkMarkerAttr "symbol" "triangle-right-open"
        static member inline triangleRightOpenDot = Interop.mkMarkerAttr "symbol" "triangle-right-open-dot"
        static member inline triangleSe = Interop.mkMarkerAttr "symbol" "triangle-se"
        static member inline triangleSeDot = Interop.mkMarkerAttr "symbol" "triangle-se-dot"
        static member inline triangleSeOpen = Interop.mkMarkerAttr "symbol" "triangle-se-open"
        static member inline triangleSeOpenDot = Interop.mkMarkerAttr "symbol" "triangle-se-open-dot"
        static member inline triangleSw = Interop.mkMarkerAttr "symbol" "triangle-sw"
        static member inline triangleSwDot = Interop.mkMarkerAttr "symbol" "triangle-sw-dot"
        static member inline triangleSwOpen = Interop.mkMarkerAttr "symbol" "triangle-sw-open"
        static member inline triangleSwOpenDot = Interop.mkMarkerAttr "symbol" "triangle-sw-open-dot"
        static member inline triangleUp = Interop.mkMarkerAttr "symbol" "triangle-up"
        static member inline triangleUpDot = Interop.mkMarkerAttr "symbol" "triangle-up-dot"
        static member inline triangleUpOpen = Interop.mkMarkerAttr "symbol" "triangle-up-open"
        static member inline triangleUpOpenDot = Interop.mkMarkerAttr "symbol" "triangle-up-open-dot"
        static member inline x = Interop.mkMarkerAttr "symbol" "x"
        static member inline xDot = Interop.mkMarkerAttr "symbol" "x-dot"
        static member inline xOpen = Interop.mkMarkerAttr "symbol" "x-open"
        static member inline xOpenDot = Interop.mkMarkerAttr "symbol" "x-open-dot"
        static member inline xThin = Interop.mkMarkerAttr "symbol" "x-thin"
        static member inline xThinOpen = Interop.mkMarkerAttr "symbol" "x-thin-open"
        static member inline yDown = Interop.mkMarkerAttr "symbol" "y-down"
        static member inline yDownOpen = Interop.mkMarkerAttr "symbol" "y-down-open"
        static member inline yLeft = Interop.mkMarkerAttr "symbol" "y-left"
        static member inline yLeftOpen = Interop.mkMarkerAttr "symbol" "y-left-open"
        static member inline yRight = Interop.mkMarkerAttr "symbol" "y-right"
        static member inline yRightOpen = Interop.mkMarkerAttr "symbol" "y-right-open"
        static member inline yUp = Interop.mkMarkerAttr "symbol" "y-up"
        static member inline yUpOpen = Interop.mkMarkerAttr "symbol" "y-up-open"

