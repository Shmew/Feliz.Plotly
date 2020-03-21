namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type errorZ =
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: bool) = Interop.mkErrorZAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: System.DateTime) = Interop.mkErrorZAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<System.DateTime>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: float) = Interop.mkErrorZAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: int) = Interop.mkErrorZAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (value: string) = Interop.mkErrorZAttr "array" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<bool>>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool list>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool []>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<string>>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string list>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string []>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<int>>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int list>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int []>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<seq<float>>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float list>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float []>) = Interop.mkErrorZAttr "array" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<PlotData>) = Interop.mkErrorZAttr "array" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<bool option>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<System.DateTime option>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<int option>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<float option>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
    static member inline array (values: seq<string option>) = Interop.mkErrorZAttr "array" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: bool) = Interop.mkErrorZAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: System.DateTime) = Interop.mkErrorZAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<System.DateTime>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: float) = Interop.mkErrorZAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: int) = Interop.mkErrorZAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (value: string) = Interop.mkErrorZAttr "arrayminus" (value |> Array.singleton)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<bool>>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool list>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool []>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<string>>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string list>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string []>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<int>>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int list>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int []>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<seq<float>>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float list>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float []>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<PlotData>) = Interop.mkErrorZAttr "arrayminus" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<bool option>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<System.DateTime option>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<int option>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<float option>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
    static member inline arrayminus (values: seq<string option>) = Interop.mkErrorZAttr "arrayminus" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  arrayminus .
    static member inline arrayminussrc (value: string) = Interop.mkErrorZAttr "arrayminussrc" value
    /// Sets the source reference on plot.ly for  array .
    static member inline arraysrc (value: string) = Interop.mkErrorZAttr "arraysrc" value
    /// Sets the stoke color of the error bars.
    static member inline color (value: string) = Interop.mkErrorZAttr "color" value
    /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
    static member inline symmetric (value: bool) = Interop.mkErrorZAttr "symmetric" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: int) = Interop.mkErrorZAttr "thickness" value
    /// Sets the thickness (in px) of the error bars.
    static member inline thickness (value: float) = Interop.mkErrorZAttr "thickness" value
    static member inline traceref (value: int) = Interop.mkErrorZAttr "traceref" value
    static member inline tracerefminus (value: int) = Interop.mkErrorZAttr "tracerefminus" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: int) = Interop.mkErrorZAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
    static member inline value (value: float) = Interop.mkErrorZAttr "value" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: int) = Interop.mkErrorZAttr "valueminus" value
    /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
    static member inline valueminus (value: float) = Interop.mkErrorZAttr "valueminus" value
    /// Determines whether or not this set of error bars is visible.
    static member inline visible (value: bool) = Interop.mkErrorZAttr "visible" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: int) = Interop.mkErrorZAttr "width" value
    /// Sets the width (in px) of the cross-bar at both ends of the error bars.
    static member inline width (value: float) = Interop.mkErrorZAttr "width" value

[<RequireQualifiedAccess>]
module errorZ =
    /// Sets the stoke color of the error bars.
    [<Erase>]
    type color =
        /// Sets the stoke color of the error bars.
        static member inline rgb (r,g,b) = Interop.mkErrorZAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the stoke color of the error bars.
        static member inline rgba (r,g,b,a) = Interop.mkErrorZAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the stoke color of the error bars.
        static member inline hsl (h,s,l) = Interop.mkErrorZAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
    [<Erase>]
    type type' =
        static member inline constant = Interop.mkErrorZAttr "type" "constant"
        static member inline data = Interop.mkErrorZAttr "type" "data"
        static member inline percent = Interop.mkErrorZAttr "type" "percent"
        static member inline sqrt = Interop.mkErrorZAttr "type" "sqrt"

