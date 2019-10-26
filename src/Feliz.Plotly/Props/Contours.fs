namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type contours =
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: int) = Interop.mkContoursAttr "start" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: float) = Interop.mkContoursAttr "start" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: int) = Interop.mkContoursAttr "end" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: float) = Interop.mkContoursAttr "end" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: int) = Interop.mkContoursAttr "size" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: float) = Interop.mkContoursAttr "size" value
    /// Determines whether or not the contour lines are drawn. Has an effect only if `contours.coloring` is set to *fill*.
    static member inline showlines (value: bool) = Interop.mkContoursAttr "showlines" value
    /// Determines whether to label the contour lines with their values.
    static member inline showlabels (value: bool) = Interop.mkContoursAttr "showlabels" value
    /// Sets the font used for labeling the contour levels. The default color comes from the lines, if shown. The default family and size come from `layout.font`.
    static member inline labelfont (properties: #ILabelfontProperty list) = Interop.mkContoursAttr "labelfont" (createObj !!properties)
    /// Sets the contour label formatting rule using d3 formatting mini-language which is very similar to Python, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline labelformat (value: string) = Interop.mkContoursAttr "labelformat" value
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (value: bool) = Interop.mkContoursAttr "value" value
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (values: seq<bool>) = Interop.mkContoursAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (value: string) = Interop.mkContoursAttr "value" value
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (values: seq<string>) = Interop.mkContoursAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (value: int) = Interop.mkContoursAttr "value" value
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (values: seq<int>) = Interop.mkContoursAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (value: float) = Interop.mkContoursAttr "value" value
    /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,<,>=,>,<=) *value* is expected to be a number. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) *value* is expected to be an array of two numbers where the first is the lower bound and the second is the upper bound.
    static member inline value (values: seq<float>) = Interop.mkContoursAttr "value" (values |> Array.ofSeq)
    static member inline x (properties: #IXProperty list) = Interop.mkContoursAttr "x" (createObj !!properties)
    static member inline y (properties: #IYProperty list) = Interop.mkContoursAttr "y" (createObj !!properties)
    static member inline z (properties: #IZProperty list) = Interop.mkContoursAttr "z" (createObj !!properties)

[<AutoOpen>]
module contours =
    /// If `levels`, the data is represented as a contour plot with multiple levels displayed. If `constraint`, the data is represented as constraints with the invalid region shaded as specified by the `operation` and `value` parameters.
    [<Erase>]
    type type' =
        static member inline constraint' = Interop.mkContoursAttr "type" "constraint"
        static member inline levels = Interop.mkContoursAttr "type" "levels"

    /// Determines the coloring method showing the contour values. If *fill*, coloring is done evenly between each contour level If *heatmap*, a heatmap gradient coloring is applied between each contour level. If *lines*, coloring is done on the contour lines. If *none*, no coloring is applied on this trace.
    [<Erase>]
    type coloring =
        static member inline fill = Interop.mkContoursAttr "coloring" "fill"
        static member inline heatmap = Interop.mkContoursAttr "coloring" "heatmap"
        static member inline lines = Interop.mkContoursAttr "coloring" "lines"
        static member inline none = Interop.mkContoursAttr "coloring" "none"

    /// Sets the constraint operation. *=* keeps regions equal to `value` *<* and *<=* keep regions less than `value` *>* and *>=* keep regions greater than `value` *[]*, *()*, *[)*, and *(]* keep regions inside `value[0]` to `value[1]` *][*, *)(*, *](*, *)[* keep regions outside `value[0]` to value[1]` Open vs. closed intervals make no difference to constraint display, but all versions are allowed for consistency with filter transforms.
    [<Erase>]
    type operation =
        static member inline exclusiveRange = Interop.mkContoursAttr "operation" "()"
        static member inline rightIncLeftExcRange = Interop.mkContoursAttr "operation" "(]"
        static member inline exclusiveBounds = Interop.mkContoursAttr "operation" ")("
        static member inline leftExcRightIncBounds = Interop.mkContoursAttr "operation" ")["
        static member inline lt = Interop.mkContoursAttr "operation" "<"
        static member inline ltEq = Interop.mkContoursAttr "operation" "<="
        static member inline eq = Interop.mkContoursAttr "operation" "="
        static member inline gt = Interop.mkContoursAttr "operation" ">"
        static member inline gtEq = Interop.mkContoursAttr "operation" ">="
        static member inline leftIncLRightExcRange = Interop.mkContoursAttr "operation" "[)"
        static member inline rightExcLeftIncBounds = Interop.mkContoursAttr "operation" "]("
        static member inline custom (value: string) = Interop.mkContoursAttr "operation" value

