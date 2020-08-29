namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type fill =
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (value: string) = Interop.mkFillAttr "color" value
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<string>) = Interop.mkFillAttr "color" (values |> ResizeArray)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<int>) = Interop.mkFillAttr "color" (values |> ResizeArray)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<float>) = Interop.mkFillAttr "color" (values |> ResizeArray)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<seq<string>>) = Interop.mkFillAttr "color" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<string list>) = Interop.mkFillAttr "color" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<string []>) = Interop.mkFillAttr "color" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkFillAttr "colorsrc" value
    /// Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has an effect only when `type` is set to *fill*.
    static member inline outlinecolor (value: string) = Interop.mkFillAttr "outlinecolor" value

[<Erase;RequireQualifiedAccess>]
module fill =
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    [<Erase>]
    type color =
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        static member inline rgb (r,g,b) = Interop.mkFillAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        static member inline rgba (r,g,b,a) = Interop.mkFillAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        static member inline hsl (h,s,l) = Interop.mkFillAttr "color" (Feliz.color.hsl(h,s,l))

