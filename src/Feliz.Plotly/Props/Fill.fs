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
    static member inline color (values: seq<seq<string>>) = Interop.mkFillAttr "color" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<string list>) = Interop.mkFillAttr "color" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
    static member inline color (values: seq<string []>) = Interop.mkFillAttr "color" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkFillAttr "colorsrc" value
    /// Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has an effect only when `type` is set to *fill*.
    static member inline outlinecolor (value: string) = Interop.mkFillAttr "outlinecolor" value

