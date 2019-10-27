namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type angularaxis =
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: int) = Interop.mkAngularaxisAttr "domain" (value |> Array.singleton)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkAngularaxisAttr "domain" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: float) = Interop.mkAngularaxisAttr "domain" (value |> Array.singleton)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkAngularaxisAttr "domain" (values |> Array.ofSeq)

