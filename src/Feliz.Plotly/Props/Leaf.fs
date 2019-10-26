namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type leaf =
    /// Sets the opacity of the leaves. With colorscale it is defaulted to 1; otherwise it is defaulted to 0.7
    static member inline opacity (value: int) = Interop.mkLeafAttr "opacity" value
    /// Sets the opacity of the leaves. With colorscale it is defaulted to 1; otherwise it is defaulted to 0.7
    static member inline opacity (value: float) = Interop.mkLeafAttr "opacity" value

