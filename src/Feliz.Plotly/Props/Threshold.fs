namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type threshold =
    static member inline line (properties: #ILineProperty list) = Interop.mkThresholdAttr "line" (createObj !!properties)
    /// Sets the thickness of the threshold line as a fraction of the thickness of the gauge.
    static member inline thickness (value: int) = Interop.mkThresholdAttr "thickness" value
    /// Sets the thickness of the threshold line as a fraction of the thickness of the gauge.
    static member inline thickness (value: float) = Interop.mkThresholdAttr "thickness" value
    /// Sets a treshold value drawn as a line.
    static member inline value (value: int) = Interop.mkThresholdAttr "value" value
    /// Sets a treshold value drawn as a line.
    static member inline value (value: float) = Interop.mkThresholdAttr "value" value

