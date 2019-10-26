namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type lonaxis =
    /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
    static member inline range (values: seq<int>) = Interop.mkLonaxisAttr "range" (values |> Array.ofSeq)
    /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
    static member inline range (values: seq<float>) = Interop.mkLonaxisAttr "range" (values |> Array.ofSeq)
    /// Sets whether or not graticule are shown on the map.
    static member inline showgrid (value: bool) = Interop.mkLonaxisAttr "showgrid" value
    /// Sets the graticule's starting tick longitude/latitude.
    static member inline tick0 (value: int) = Interop.mkLonaxisAttr "tick0" value
    /// Sets the graticule's starting tick longitude/latitude.
    static member inline tick0 (value: float) = Interop.mkLonaxisAttr "tick0" value
    /// Sets the graticule's longitude/latitude tick step.
    static member inline dtick (value: int) = Interop.mkLonaxisAttr "dtick" value
    /// Sets the graticule's longitude/latitude tick step.
    static member inline dtick (value: float) = Interop.mkLonaxisAttr "dtick" value
    /// Sets the graticule's stroke color.
    static member inline gridcolor (value: string) = Interop.mkLonaxisAttr "gridcolor" value
    /// Sets the graticule's stroke width (in px).
    static member inline gridwidth (value: int) = Interop.mkLonaxisAttr "gridwidth" value
    /// Sets the graticule's stroke width (in px).
    static member inline gridwidth (value: float) = Interop.mkLonaxisAttr "gridwidth" value

