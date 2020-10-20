namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type shape =
    /// Determines whether the shape could be activated for edit or not. Has no effect when the older editable shapes mode is enabled via `config.editable` or `config.edits.shapePosition`.
    static member inline editable (value: bool) = Interop.mkShapeAttr "editable" value
    /// Sets the color filling the shape's interior. Only applies to closed shapes.
    static member inline fillcolor (value: string) = Interop.mkShapeAttr "fillcolor" value
    static member inline line (properties: #ILineProperty list) = Interop.mkShapeAttr "line" (createObj !!properties)
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkShapeAttr "name" value
    /// Sets the opacity of the shape.
    static member inline opacity (value: int) = Interop.mkShapeAttr "opacity" value
    /// Sets the opacity of the shape.
    static member inline opacity (value: float) = Interop.mkShapeAttr "opacity" value
    /// For `type` *path* - a valid SVG path with the pixel values replaced by data values in `xsizemode`/`ysizemode` being *scaled* and taken unmodified as pixels relative to `xanchor` and `yanchor` in case of *pixel* size mode. There are a few restrictions / quirks only absolute instructions, not relative. So the allowed segments are: M, L, H, V, Q, C, T, S, and Z arcs (A) are not allowed because radius rx and ry are relative. In the future we could consider supporting relative commands, but we would have to decide on how to handle date and log axes. Note that even as is, Q and C Bezier paths that are smooth on linear axes may not be smooth on log, and vice versa. no chained \"polybezier\" commands - specify the segment type for each one. On category axes, values are numbers scaled to the serial numbers of categories because using the categories themselves there would be no way to describe fractional positions On data axes: because space and T are both normal components of path strings, we can't use either to separate date from time parts. Therefore we'll use underscore for this purpose: 2015-02-21_13:45:56.789
    static member inline path (value: string) = Interop.mkShapeAttr "path" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkShapeAttr "templateitemname" value
    /// Determines whether or not this shape is visible.
    static member inline visible (value: bool) = Interop.mkShapeAttr "visible" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: bool) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<bool>) = Interop.mkShapeAttr "x0" (values |> ResizeArray)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: System.DateTime) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<System.DateTime>) = Interop.mkShapeAttr "x0" (values |> ResizeArray)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: int) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<int>) = Interop.mkShapeAttr "x0" (values |> ResizeArray)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: float) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<float>) = Interop.mkShapeAttr "x0" (values |> ResizeArray)
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (value: string) = Interop.mkShapeAttr "x0" value
    /// Sets the shape's starting x position. See `type` and `xsizemode` for more info.
    static member inline x0 (values: seq<string>) = Interop.mkShapeAttr "x0" (values |> ResizeArray)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: bool) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<bool>) = Interop.mkShapeAttr "x1" (values |> ResizeArray)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: System.DateTime) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<System.DateTime>) = Interop.mkShapeAttr "x1" (values |> ResizeArray)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: int) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<int>) = Interop.mkShapeAttr "x1" (values |> ResizeArray)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: float) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<float>) = Interop.mkShapeAttr "x1" (values |> ResizeArray)
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (value: string) = Interop.mkShapeAttr "x1" value
    /// Sets the shape's end x position. See `type` and `xsizemode` for more info.
    static member inline x1 (values: seq<string>) = Interop.mkShapeAttr "x1" (values |> ResizeArray)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: bool) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<bool>) = Interop.mkShapeAttr "xanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: System.DateTime) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<System.DateTime>) = Interop.mkShapeAttr "xanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: int) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<int>) = Interop.mkShapeAttr "xanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: float) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<float>) = Interop.mkShapeAttr "xanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (value: string) = Interop.mkShapeAttr "xanchor" value
    /// Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*.
    static member inline xanchor (values: seq<string>) = Interop.mkShapeAttr "xanchor" (values |> ResizeArray)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: bool) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<bool>) = Interop.mkShapeAttr "y0" (values |> ResizeArray)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: System.DateTime) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<System.DateTime>) = Interop.mkShapeAttr "y0" (values |> ResizeArray)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: int) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<int>) = Interop.mkShapeAttr "y0" (values |> ResizeArray)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: float) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<float>) = Interop.mkShapeAttr "y0" (values |> ResizeArray)
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (value: string) = Interop.mkShapeAttr "y0" value
    /// Sets the shape's starting y position. See `type` and `ysizemode` for more info.
    static member inline y0 (values: seq<string>) = Interop.mkShapeAttr "y0" (values |> ResizeArray)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: bool) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<bool>) = Interop.mkShapeAttr "y1" (values |> ResizeArray)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: System.DateTime) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<System.DateTime>) = Interop.mkShapeAttr "y1" (values |> ResizeArray)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: int) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<int>) = Interop.mkShapeAttr "y1" (values |> ResizeArray)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: float) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<float>) = Interop.mkShapeAttr "y1" (values |> ResizeArray)
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (value: string) = Interop.mkShapeAttr "y1" value
    /// Sets the shape's end y position. See `type` and `ysizemode` for more info.
    static member inline y1 (values: seq<string>) = Interop.mkShapeAttr "y1" (values |> ResizeArray)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: bool) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<bool>) = Interop.mkShapeAttr "yanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: System.DateTime) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<System.DateTime>) = Interop.mkShapeAttr "yanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: int) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<int>) = Interop.mkShapeAttr "yanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: float) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<float>) = Interop.mkShapeAttr "yanchor" (values |> ResizeArray)
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (value: string) = Interop.mkShapeAttr "yanchor" value
    /// Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*.
    static member inline yanchor (values: seq<string>) = Interop.mkShapeAttr "yanchor" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module shape =
    /// Determines which regions of complex paths constitute the interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
    [<Erase>]
    type fillrule =
        static member inline evenodd = Interop.mkShapeAttr "fillrule" "evenodd"
        static member inline nonzero = Interop.mkShapeAttr "fillrule" "nonzero"

    /// Specifies whether shapes are drawn below or above traces.
    [<Erase>]
    type layer =
        static member inline above = Interop.mkShapeAttr "layer" "above"
        static member inline below = Interop.mkShapeAttr "layer" "below"

    /// Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode.
    [<Erase>]
    type type' =
        static member inline circle = Interop.mkShapeAttr "type" "circle"
        static member inline line = Interop.mkShapeAttr "type" "line"
        static member inline path = Interop.mkShapeAttr "type" "path"
        static member inline rect = Interop.mkShapeAttr "type" "rect"

    /// Sets the shape's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, then you must convert the date to unix time in milliseconds.
    [<Erase>]
    type xref =
        static member inline paper = Interop.mkShapeAttr "xref" "paper"
        static member inline custom (value: string) = Interop.mkShapeAttr "xref" value
        static member inline x (anchorId: int) = Interop.mkShapeAttr "xref" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction.
    [<Erase>]
    type xsizemode =
        static member inline pixel = Interop.mkShapeAttr "xsizemode" "pixel"
        static member inline scaled = Interop.mkShapeAttr "xsizemode" "scaled"

    /// Sets the annotation's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis.
    [<Erase>]
    type yref =
        static member inline paper = Interop.mkShapeAttr "yref" "paper"
        static member inline custom (value: string) = Interop.mkShapeAttr "yref" value
        static member inline y (anchorId: int) = Interop.mkShapeAttr "yref" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`, `y1` and y coordinates within `path` refer to data values on the y axis or a fraction of the plot area's height (`yref` set to *paper*). If set to *pixel*, `yanchor` specifies the y position in terms of data or plot fraction but `y0`, `y1` and y coordinates within `path` are pixels relative to `yanchor`. This way, the shape can have a fixed height while maintaining a position relative to data or plot fraction.
    [<Erase>]
    type ysizemode =
        static member inline pixel = Interop.mkShapeAttr "ysizemode" "pixel"
        static member inline scaled = Interop.mkShapeAttr "ysizemode" "scaled"

