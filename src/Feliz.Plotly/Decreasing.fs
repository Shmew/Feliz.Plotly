namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type decreasing =
    /// Sets the color for increasing value.
    static member inline color (value: string) = Interop.mkDecreasingAttr "color" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkDecreasingAttr "fillcolor" value
    static member inline line (properties: #ILineProperty list) = Interop.mkDecreasingAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkDecreasingAttr "marker" (createObj !!properties)
    /// Sets the symbol to display for increasing value
    static member inline symbol (value: string) = Interop.mkDecreasingAttr "symbol" value

[<RequireQualifiedAccess>]
module decreasing =
    /// Sets the color for increasing value.
    [<Erase>]
    type color =
        /// Sets the color for increasing value.
        static member inline rgb (r,g,b) = Interop.mkDecreasingAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color for increasing value.
        static member inline rgba (r,g,b,a) = Interop.mkDecreasingAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color for increasing value.
        static member inline hsl (h,s,l) = Interop.mkDecreasingAttr "color" (Feliz.color.hsl(h,s,l))

