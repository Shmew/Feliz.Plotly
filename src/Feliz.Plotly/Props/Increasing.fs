namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type increasing =
    /// Sets the color for increasing value.
    static member inline color (value: string) = Interop.mkIncreasingAttr "color" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkIncreasingAttr "fillcolor" value
    static member inline line (properties: #ILineProperty list) = Interop.mkIncreasingAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkIncreasingAttr "marker" (createObj !!properties)
    /// Sets the symbol to display for increasing value
    static member inline symbol (value: string) = Interop.mkIncreasingAttr "symbol" value

[<Erase;RequireQualifiedAccess>]
module increasing =
    /// Sets the color for increasing value.
    [<Erase>]
    type color =
        /// Sets the color for increasing value.
        static member inline rgb (r,g,b) = Interop.mkIncreasingAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color for increasing value.
        static member inline rgba (r,g,b,a) = Interop.mkIncreasingAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color for increasing value.
        static member inline hsl (h,s,l) = Interop.mkIncreasingAttr "color" (Feliz.color.hsl(h,s,l))

