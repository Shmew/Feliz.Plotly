namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type colorscale =
    /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequential (value: string) = Interop.mkColorscaleAttr "sequential" (value |> Array.singleton)
    /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequential (values: seq<string>) = Interop.mkColorscaleAttr "sequential" (values |> Array.ofSeq)
    /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequentialminus (value: string) = Interop.mkColorscaleAttr "sequentialminus" (value |> Array.singleton)
    /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequentialminus (values: seq<string>) = Interop.mkColorscaleAttr "sequentialminus" (values |> Array.ofSeq)
    /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
    static member inline diverging (value: string) = Interop.mkColorscaleAttr "diverging" (value |> Array.singleton)
    /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
    static member inline diverging (values: seq<string>) = Interop.mkColorscaleAttr "diverging" (values |> Array.ofSeq)

