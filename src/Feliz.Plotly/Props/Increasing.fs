namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type increasing =
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkIncreasingAttr "marker" (createObj !!properties)
    /// Sets the symbol to display for increasing value
    static member inline symbol (value: string) = Interop.mkIncreasingAttr "symbol" value
    /// Sets the color for increasing value.
    static member inline color (value: string) = Interop.mkIncreasingAttr "color" value
    static member inline line (properties: #ILineProperty list) = Interop.mkIncreasingAttr "line" (createObj !!properties)
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkIncreasingAttr "fillcolor" value

