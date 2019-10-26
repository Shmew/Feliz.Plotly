namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type radialaxis =
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
    static member inline range (values: seq<int>) = Interop.mkRadialaxisAttr "range" (values |> Array.ofSeq)
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
    static member inline range (values: seq<float>) = Interop.mkRadialaxisAttr "range" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkRadialaxisAttr "domain" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkRadialaxisAttr "domain" (values |> Array.ofSeq)
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
    static member inline orientation (value: int) = Interop.mkRadialaxisAttr "orientation" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
    static member inline orientation (value: float) = Interop.mkRadialaxisAttr "orientation" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this radial axis will be shown on the figure.
    static member inline showline (value: bool) = Interop.mkRadialaxisAttr "showline" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the radial axis ticks will feature tick labels.
    static member inline showticklabels (value: bool) = Interop.mkRadialaxisAttr "showticklabels" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
    static member inline ticklen (value: int) = Interop.mkRadialaxisAttr "ticklen" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
    static member inline ticklen (value: float) = Interop.mkRadialaxisAttr "ticklen" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this radial axis.
    static member inline tickcolor (value: string) = Interop.mkRadialaxisAttr "tickcolor" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
    static member inline ticksuffix (value: string) = Interop.mkRadialaxisAttr "ticksuffix" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
    static member inline endpadding (value: int) = Interop.mkRadialaxisAttr "endpadding" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
    static member inline endpadding (value: float) = Interop.mkRadialaxisAttr "endpadding" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
    static member inline visible (value: bool) = Interop.mkRadialaxisAttr "visible" value

[<AutoOpen>]
module radialaxis =
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the radial axis tick labels.
    [<Erase>]
    type tickorientation =
        static member inline horizontal = Interop.mkRadialaxisAttr "tickorientation" "horizontal"
        static member inline vertical = Interop.mkRadialaxisAttr "tickorientation" "vertical"

