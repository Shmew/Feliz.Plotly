namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type angularaxis =
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
    static member inline range (values: seq<int>) = Interop.mkAngularaxisAttr "range" (values |> Array.ofSeq)
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
    static member inline range (values: seq<float>) = Interop.mkAngularaxisAttr "range" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkAngularaxisAttr "domain" (values |> Array.ofSeq)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkAngularaxisAttr "domain" (values |> Array.ofSeq)
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this angular axis will be shown on the figure.
    static member inline showline (value: bool) = Interop.mkAngularaxisAttr "showline" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the angular axis ticks will feature tick labels.
    static member inline showticklabels (value: bool) = Interop.mkAngularaxisAttr "showticklabels" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
    static member inline ticklen (value: int) = Interop.mkAngularaxisAttr "ticklen" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
    static member inline ticklen (value: float) = Interop.mkAngularaxisAttr "ticklen" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this angular axis.
    static member inline tickcolor (value: string) = Interop.mkAngularaxisAttr "tickcolor" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
    static member inline ticksuffix (value: string) = Interop.mkAngularaxisAttr "ticksuffix" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
    static member inline endpadding (value: int) = Interop.mkAngularaxisAttr "endpadding" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
    static member inline endpadding (value: float) = Interop.mkAngularaxisAttr "endpadding" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
    static member inline visible (value: bool) = Interop.mkAngularaxisAttr "visible" value

[<AutoOpen>]
module angularaxis =
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the angular axis tick labels.
    [<Erase>]
    type tickorientation =
        static member inline horizontal = Interop.mkAngularaxisAttr "tickorientation" "horizontal"
        static member inline vertical = Interop.mkAngularaxisAttr "tickorientation" "vertical"

