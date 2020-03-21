namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type border =
    /// Specifies what fraction of the marker area is covered with the border.
    static member inline arearatio (value: int) = Interop.mkBorderAttr "arearatio" value
    /// Specifies what fraction of the marker area is covered with the border.
    static member inline arearatio (value: float) = Interop.mkBorderAttr "arearatio" value
    /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
    static member inline color (value: string) = Interop.mkBorderAttr "color" value

[<RequireQualifiedAccess>]
module border =
    /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
    [<Erase>]
    type color =
        /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
        static member inline rgb (r,g,b) = Interop.mkBorderAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
        static member inline rgba (r,g,b,a) = Interop.mkBorderAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
        static member inline hsl (h,s,l) = Interop.mkBorderAttr "color" (Feliz.color.hsl(h,s,l))

