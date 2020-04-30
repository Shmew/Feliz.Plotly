namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type activeshape =
    /// Sets the color filling the active shape' interior.
    static member inline fillcolor (value: string) = Interop.mkActiveshapeAttr "fillcolor" value
    /// Sets the opacity of the active shape.
    static member inline opacity (value: int) = Interop.mkActiveshapeAttr "opacity" value
    /// Sets the opacity of the active shape.
    static member inline opacity (value: float) = Interop.mkActiveshapeAttr "opacity" value

