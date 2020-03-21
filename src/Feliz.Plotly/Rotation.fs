namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type rotation =
    /// Rotates the map along meridians (in degrees North).
    static member inline lat (value: int) = Interop.mkRotationAttr "lat" value
    /// Rotates the map along meridians (in degrees North).
    static member inline lat (value: float) = Interop.mkRotationAttr "lat" value
    /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
    static member inline lon (value: int) = Interop.mkRotationAttr "lon" value
    /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
    static member inline lon (value: float) = Interop.mkRotationAttr "lon" value
    /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
    static member inline roll (value: int) = Interop.mkRotationAttr "roll" value
    /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
    static member inline roll (value: float) = Interop.mkRotationAttr "roll" value

