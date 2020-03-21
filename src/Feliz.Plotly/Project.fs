namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type project =
    /// Determines whether or not these contour lines are projected on the x plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
    static member inline x (value: bool) = Interop.mkProjectAttr "x" value
    /// Determines whether or not these contour lines are projected on the y plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
    static member inline y (value: bool) = Interop.mkProjectAttr "y" value
    /// Determines whether or not these contour lines are projected on the z plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
    static member inline z (value: bool) = Interop.mkProjectAttr "z" value

