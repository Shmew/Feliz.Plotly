namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type spaceframe =
    /// Displays/hides tetrahedron shapes between minimum and maximum iso-values. Often useful when either caps or surfaces are disabled or filled with values less than 1.
    static member inline show (value: bool) = Interop.mkSpaceframeAttr "show" value
    /// Sets the fill ratio of the `spaceframe` elements. The default fill value is 0.15 meaning that only 15% of the area of every faces of tetras would be shaded. Applying a greater `fill` ratio would allow the creation of stronger elements or could be sued to have entirely closed areas (in case of using 1).
    static member inline fill (value: int) = Interop.mkSpaceframeAttr "fill" value
    /// Sets the fill ratio of the `spaceframe` elements. The default fill value is 0.15 meaning that only 15% of the area of every faces of tetras would be shaded. Applying a greater `fill` ratio would allow the creation of stronger elements or could be sued to have entirely closed areas (in case of using 1).
    static member inline fill (value: float) = Interop.mkSpaceframeAttr "fill" value

