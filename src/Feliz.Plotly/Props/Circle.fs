namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type circle =
    /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
    static member inline radius (value: int) = Interop.mkCircleAttr "radius" value
    /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
    static member inline radius (value: float) = Interop.mkCircleAttr "radius" value

