namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type center =
    static member inline x (value: int) = Interop.mkCenterAttr "x" value
    static member inline x (value: float) = Interop.mkCenterAttr "x" value
    static member inline y (value: int) = Interop.mkCenterAttr "y" value
    static member inline y (value: float) = Interop.mkCenterAttr "y" value
    static member inline z (value: int) = Interop.mkCenterAttr "z" value
    static member inline z (value: float) = Interop.mkCenterAttr "z" value
    /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
    static member inline lon (value: int) = Interop.mkCenterAttr "lon" value
    /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
    static member inline lon (value: float) = Interop.mkCenterAttr "lon" value
    /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
    static member inline lat (value: int) = Interop.mkCenterAttr "lat" value
    /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
    static member inline lat (value: float) = Interop.mkCenterAttr "lat" value

