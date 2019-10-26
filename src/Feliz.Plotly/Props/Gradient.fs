namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type gradient =
    /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
    static member inline color (value: string) = Interop.mkGradientAttr "color" value
    /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
    static member inline color (values: seq<string>) = Interop.mkGradientAttr "color" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  type .
    static member inline typesrc (value: string) = Interop.mkGradientAttr "typesrc" value
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkGradientAttr "colorsrc" value

[<AutoOpen>]
module gradient =
    /// Use a list of enumerated values
    let inline type's (properties: #IGradientProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkGradientAttr "type"

    /// Sets the type of gradient used to fill the markers
    [<Erase>]
    type type' =
        static member inline horizontal = Interop.mkGradientAttr "type" "horizontal"
        static member inline none = Interop.mkGradientAttr "type" "none"
        static member inline radial = Interop.mkGradientAttr "type" "radial"
        static member inline vertical = Interop.mkGradientAttr "type" "vertical"

