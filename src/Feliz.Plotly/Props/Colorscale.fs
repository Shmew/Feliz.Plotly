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
    static member inline sequential (value: string) = Interop.mkColorscaleAttr "sequential" value
    /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequential (values: seq<string list>) = Interop.mkColorscaleAttr "sequential" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequentialminus (value: string) = Interop.mkColorscaleAttr "sequentialminus" value
    /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
    static member inline sequentialminus (values: seq<string list>) = Interop.mkColorscaleAttr "sequentialminus" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
    static member inline diverging (value: string) = Interop.mkColorscaleAttr "diverging" value
    /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
    static member inline diverging (values: seq<string list>) = Interop.mkColorscaleAttr "diverging" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)

