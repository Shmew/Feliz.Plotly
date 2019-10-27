namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type errorY =
    /// Determines whether or not this set of error bars is visible.
    static member inline visible (value: bool) = Interop.mkErrorYAttr "visible" value
    /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
    static member inline symmetric (value: bool) = Interop.mkErrorYAttr "symmetric" value
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: bool) = Interop.mkErrorYAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: string) = Interop.mkErrorYAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: int) = Interop.mkErrorYAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: float) = Interop.mkErrorYAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<bool>>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool list>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool []>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<string>>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string list>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string []>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<int>>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int list>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int []>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<float>>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float list>) = Interop.mkErrorYAttr "array" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float []>) = Interop.mkErrorYAttr "array" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: bool) = Interop.mkErrorYAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: string) = Interop.mkErrorYAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: int) = Interop.mkErrorYAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: float) = Interop.mkErrorYAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<bool>>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool list>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool []>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<string>>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string list>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string []>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<int>>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int list>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int []>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<float>>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float list>) = Interop.mkErrorYAttr "arrayminus" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float []>) = Interop.mkErrorYAttr "arrayminus" (values |> Array.ofSeq)
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: int) = Interop.mkErrorYAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: float) = Interop.mkErrorYAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: int) = Interop.mkErrorYAttr "valueminus" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: float) = Interop.mkErrorYAttr "valueminus" value
    static member inline traceref (value: int) = Interop.mkErrorYAttr "traceref" value
    static member inline tracerefminus (value: int) = Interop.mkErrorYAttr "tracerefminus" value
    /// Sets the stoke color of the error bars.
    static member inline color (value: string) = Interop.mkErrorYAttr "color" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: int) = Interop.mkErrorYAttr "thickness" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: float) = Interop.mkErrorYAttr "thickness" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: int) = Interop.mkErrorYAttr "width" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: float) = Interop.mkErrorYAttr "width" value
    /// Sets the source reference on plot.ly for  array .
    static member inline arraysrc (value: string) = Interop.mkErrorYAttr "arraysrc" value
    /// Sets the source reference on plot.ly for  arrayminus .
    static member inline arrayminussrc (value: string) = Interop.mkErrorYAttr "arrayminussrc" value
    static member inline copyZstyle (value: bool) = Interop.mkErrorYAttr "copy_zstyle" value

[<AutoOpen>]
module errorY =
    /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
    [<Erase>]
    type type' =
        static member inline constant = Interop.mkErrorYAttr "type" "constant"
        static member inline data = Interop.mkErrorYAttr "type" "data"
        static member inline percent = Interop.mkErrorYAttr "type" "percent"
        static member inline sqrt = Interop.mkErrorYAttr "type" "sqrt"
