namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type decreasing =
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkDecreasingAttr "marker" (createObj !!properties)
    /// Sets the symbol to display for increasing value
    static member inline symbol (value: string) = Interop.mkDecreasingAttr "symbol" value
    /// Sets the color for increasing value.
    static member inline color (value: string) = Interop.mkDecreasingAttr "color" value
    static member inline line (properties: #ILineProperty list) = Interop.mkDecreasingAttr "line" (createObj !!properties)
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkDecreasingAttr "fillcolor" value

