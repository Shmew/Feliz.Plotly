namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type radialaxis =
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: int) = Interop.mkRadialaxisAttr "domain" (value |> Array.singleton)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkRadialaxisAttr "domain" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: float) = Interop.mkRadialaxisAttr "domain" (value |> Array.singleton)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkRadialaxisAttr "domain" (values |> Array.ofSeq)

