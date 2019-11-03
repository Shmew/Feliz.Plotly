namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type hoverlabel =
    /// Sets the background color of the hover labels for this trace
    static member inline bgcolor (value: string) = Interop.mkHoverlabelAttr "bgcolor" value
    /// Sets the background color of the hover labels for this trace
    static member inline bgcolor (values: seq<string>) = Interop.mkHoverlabelAttr "bgcolor" (values |> ResizeArray)
    /// Sets the background color of the hover labels for this trace
    static member inline bgcolor (values: seq<int>) = Interop.mkHoverlabelAttr "bgcolor" (values |> Array.ofSeq)
    /// Sets the background color of the hover labels for this trace
    static member inline bgcolor (values: seq<float>) = Interop.mkHoverlabelAttr "bgcolor" (values |> Array.ofSeq)
    /// Sets the border color of the hover labels for this trace.
    static member inline bordercolor (value: string) = Interop.mkHoverlabelAttr "bordercolor" value
    /// Sets the border color of the hover labels for this trace.
    static member inline bordercolor (values: seq<string>) = Interop.mkHoverlabelAttr "bordercolor" (values |> ResizeArray)
    /// Sets the border color of the hover labels for this trace.
    static member inline bordercolor (values: seq<int>) = Interop.mkHoverlabelAttr "bordercolor" (values |> Array.ofSeq)
    /// Sets the border color of the hover labels for this trace.
    static member inline bordercolor (values: seq<float>) = Interop.mkHoverlabelAttr "bordercolor" (values |> Array.ofSeq)
    /// Sets the font used in hover labels.
    static member inline font (properties: #IFontProperty list) = Interop.mkHoverlabelAttr "font" (createObj !!properties)
    /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
    static member inline align (properties: #IHoverlabelProperty list) = Interop.mkHoverlabelAttr "align" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
    static member inline namelength (value: int) = Interop.mkHoverlabelAttr "namelength" value
    /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
    static member inline namelength (values: seq<int>) = Interop.mkHoverlabelAttr "namelength" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  bgcolor .
    static member inline bgcolorsrc (value: string) = Interop.mkHoverlabelAttr "bgcolorsrc" value
    /// Sets the source reference on plot.ly for  bordercolor .
    static member inline bordercolorsrc (value: string) = Interop.mkHoverlabelAttr "bordercolorsrc" value
    /// Sets the source reference on plot.ly for  align .
    static member inline alignsrc (value: string) = Interop.mkHoverlabelAttr "alignsrc" value
    /// Sets the source reference on plot.ly for  namelength .
    static member inline namelengthsrc (value: string) = Interop.mkHoverlabelAttr "namelengthsrc" value
    /// Show hover information (open, close, high, low) in separate labels.
    static member inline split (value: bool) = Interop.mkHoverlabelAttr "split" value

[<AutoOpen>]
module hoverlabel =
    /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
    [<Erase>]
    type align =
        static member inline auto = Interop.mkHoverlabelAttr "align" "auto"
        static member inline left = Interop.mkHoverlabelAttr "align" "left"
        static member inline right = Interop.mkHoverlabelAttr "align" "right"

