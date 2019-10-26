namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type errorX =
    /// Determines whether or not this set of error bars is visible.
    static member inline visible (value: bool) = Interop.mkErrorXAttr "visible" value
    /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
    static member inline symmetric (value: bool) = Interop.mkErrorXAttr "symmetric" value
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool>) = Interop.mkErrorXAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string>) = Interop.mkErrorXAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int>) = Interop.mkErrorXAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float>) = Interop.mkErrorXAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool>) = Interop.mkErrorXAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string>) = Interop.mkErrorXAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int>) = Interop.mkErrorXAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float>) = Interop.mkErrorXAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: int) = Interop.mkErrorXAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: float) = Interop.mkErrorXAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: int) = Interop.mkErrorXAttr "valueminus" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: float) = Interop.mkErrorXAttr "valueminus" value
    static member inline traceref (value: int) = Interop.mkErrorXAttr "traceref" value
    static member inline tracerefminus (value: int) = Interop.mkErrorXAttr "tracerefminus" value
    static member inline copyYstyle (value: bool) = Interop.mkErrorXAttr "copy_ystyle" value
    /// Sets the stoke color of the error bars.
    static member inline color (value: string) = Interop.mkErrorXAttr "color" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: int) = Interop.mkErrorXAttr "thickness" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: float) = Interop.mkErrorXAttr "thickness" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: int) = Interop.mkErrorXAttr "width" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: float) = Interop.mkErrorXAttr "width" value
    /// Sets the source reference on plot.ly for  array .
    static member inline arraysrc (value: string) = Interop.mkErrorXAttr "arraysrc" value
    /// Sets the source reference on plot.ly for  arrayminus .
    static member inline arrayminussrc (value: string) = Interop.mkErrorXAttr "arrayminussrc" value
    static member inline copyZstyle (value: bool) = Interop.mkErrorXAttr "copy_zstyle" value

[<AutoOpen>]
module errorX =
    /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
    [<Erase>]
    type type' =
        static member inline constant = Interop.mkErrorXAttr "type" "constant"
        static member inline data = Interop.mkErrorXAttr "type" "data"
        static member inline percent = Interop.mkErrorXAttr "type" "percent"
        static member inline sqrt = Interop.mkErrorXAttr "type" "sqrt"

