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
    static member inline color (values: seq<string>) = Interop.mkGradientAttr "color" (values |> ResizeArray)
    /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
    static member inline color (values: seq<int>) = Interop.mkGradientAttr "color" (values |> ResizeArray)
    /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
    static member inline color (values: seq<float>) = Interop.mkGradientAttr "color" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkGradientAttr "colorsrc" value
    /// Sets the source reference on Chart Studio Cloud for  type .
    static member inline typesrc (value: string) = Interop.mkGradientAttr "typesrc" value

[<Erase;RequireQualifiedAccess>]
module gradient =
    /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
    [<Erase>]
    type color =
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        static member inline rgb (r,g,b) = Interop.mkGradientAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        static member inline rgba (r,g,b,a) = Interop.mkGradientAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        static member inline hsl (h,s,l) = Interop.mkGradientAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the type of gradient used to fill the markers
    [<Erase>]
    type type' =
        static member inline horizontal = Interop.mkGradientAttr "type" "horizontal"
        static member inline none = Interop.mkGradientAttr "type" "none"
        static member inline radial = Interop.mkGradientAttr "type" "radial"
        static member inline vertical = Interop.mkGradientAttr "type" "vertical"

