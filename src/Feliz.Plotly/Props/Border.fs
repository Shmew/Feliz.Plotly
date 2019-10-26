namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type border =
    /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
    static member inline color (value: string) = Interop.mkBorderAttr "color" value
    /// Specifies what fraction of the marker area is covered with the border.
    static member inline arearatio (value: int) = Interop.mkBorderAttr "arearatio" value
    /// Specifies what fraction of the marker area is covered with the border.
    static member inline arearatio (value: float) = Interop.mkBorderAttr "arearatio" value

