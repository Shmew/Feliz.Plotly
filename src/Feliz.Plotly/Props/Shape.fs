namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type shape =
    /// Determines whether or not this shape is visible.
    static member inline visible (value: bool) = Interop.mkShapeAttr "visible" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: bool) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<bool>) = Interop.mkShapeAttr "xanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: string) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<string>) = Interop.mkShapeAttr "xanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: int) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<int>) = Interop.mkShapeAttr "xanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: float) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<float>) = Interop.mkShapeAttr "xanchor" (values |> Array.ofSeq)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: bool) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<bool>) = Interop.mkShapeAttr "x0" (values |> Array.ofSeq)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: string) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<string>) = Interop.mkShapeAttr "x0" (values |> Array.ofSeq)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: int) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<int>) = Interop.mkShapeAttr "x0" (values |> Array.ofSeq)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: float) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<float>) = Interop.mkShapeAttr "x0" (values |> Array.ofSeq)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: bool) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<bool>) = Interop.mkShapeAttr "x1" (values |> Array.ofSeq)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: string) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<string>) = Interop.mkShapeAttr "x1" (values |> Array.ofSeq)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: int) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<int>) = Interop.mkShapeAttr "x1" (values |> Array.ofSeq)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: float) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<float>) = Interop.mkShapeAttr "x1" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: bool) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<bool>) = Interop.mkShapeAttr "yanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: string) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<string>) = Interop.mkShapeAttr "yanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: int) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<int>) = Interop.mkShapeAttr "yanchor" (values |> Array.ofSeq)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: float) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<float>) = Interop.mkShapeAttr "yanchor" (values |> Array.ofSeq)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: bool) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<bool>) = Interop.mkShapeAttr "y0" (values |> Array.ofSeq)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: string) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<string>) = Interop.mkShapeAttr "y0" (values |> Array.ofSeq)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: int) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<int>) = Interop.mkShapeAttr "y0" (values |> Array.ofSeq)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: float) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<float>) = Interop.mkShapeAttr "y0" (values |> Array.ofSeq)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: bool) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<bool>) = Interop.mkShapeAttr "y1" (values |> Array.ofSeq)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: string) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<string>) = Interop.mkShapeAttr "y1" (values |> Array.ofSeq)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: int) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<int>) = Interop.mkShapeAttr "y1" (values |> Array.ofSeq)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: float) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<float>) = Interop.mkShapeAttr "y1" (values |> Array.ofSeq)
    /// For `type` *path* - a valid SVG path with the pixel values replaced by data values in `xsizemode`/`ysizemode` being *scaled* and taken unmodified as pixels relative to `xanchor` and `yanchor` in case of *pixel* size mode. There are a few restrictions / quirks only absolute instructions, not relative. So the allowed segments are: M, L, H, V, Q, C, T, S, and Z arcs (A) are not allowed because radius rx and ry are relative. In the future we could consider supporting relative commands, but we would have to decide on how to handle date and log axes. Note that even as is, Q and C Bezier paths that are smooth on linear axes may not be smooth on log, and vice versa. no chained \"polybezier\" commands - specify the segment type for each one. On category axes, values are numbers scaled to the serial numbers of categories because using the categories themselves there would be no way to describe fractional positions On data axes: because space and T are both normal components of path strings, we can't use either to separate date from time parts. Therefore we'll use underscore for this purpose: 2015-02-21_13:45:56.789
    static member inline path (value: string) = Interop.mkShapeAttr "path" value
    /// Sets the opacity of the shape.
    static member inline opacity (value: int) = Interop.mkShapeAttr "opacity" value
    /// Sets the opacity of the shape.
    static member inline opacity (value: float) = Interop.mkShapeAttr "opacity" value
    static member inline line (properties: #ILineProperty list) = Interop.mkShapeAttr "line" (createObj !!properties)
    /// Sets the color filling the shape's interior.
    static member inline fillcolor (value: string) = Interop.mkShapeAttr "fillcolor" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkShapeAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkShapeAttr "templateitemname" value

[<AutoOpen>]
module shape =
    /// Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode.
    [<Erase>]
    type type' =
        static member inline circle = Interop.mkShapeAttr "type" "circle"
        static member inline line = Interop.mkShapeAttr "type" "line"
        static member inline path = Interop.mkShapeAttr "type" "path"
        static member inline rect = Interop.mkShapeAttr "type" "rect"

    /// Specifies whether shapes are drawn below or above traces.
    [<Erase>]
    type layer =
        static member inline above = Interop.mkShapeAttr "layer" "above"
        static member inline below = Interop.mkShapeAttr "layer" "below"

    /// Sets the shape's x coordinate axis. If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate. If set to *paper*, the `x` position refers to the distance from the left side of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right) side. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, then you must convert the date to unix time in milliseconds.
    [<Erase>]
    type xref =
        static member inline paper = Interop.mkShapeAttr "xref" "paper"
        static member inline custom (value: string) = Interop.mkShapeAttr "xref" value

    /// Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction.
    [<Erase>]
    type xsizemode =
        static member inline pixel = Interop.mkShapeAttr "xsizemode" "pixel"
        static member inline scaled = Interop.mkShapeAttr "xsizemode" "scaled"

    /// Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
    [<Erase>]
    type yref =
        static member inline paper = Interop.mkShapeAttr "yref" "paper"
        static member inline custom (value: string) = Interop.mkShapeAttr "yref" value

    /// Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`, `y1` and y coordinates within `path` refer to data values on the y axis or a fraction of the plot area's height (`yref` set to *paper*). If set to *pixel*, `yanchor` specifies the y position in terms of data or plot fraction but `y0`, `y1` and y coordinates within `path` are pixels relative to `yanchor`. This way, the shape can have a fixed height while maintaining a position relative to data or plot fraction.
    [<Erase>]
    type ysizemode =
        static member inline pixel = Interop.mkShapeAttr "ysizemode" "pixel"
        static member inline scaled = Interop.mkShapeAttr "ysizemode" "scaled"

