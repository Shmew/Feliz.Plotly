namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type frame =
    /// The duration in milliseconds of each frame. If greater than the frame duration, it will be limited to the frame duration.
    static member inline duration (value: int) = Interop.mkFrameAttr "duration" value
    /// The duration in milliseconds of each frame. If greater than the frame duration, it will be limited to the frame duration.
    static member inline duration (value: float) = Interop.mkFrameAttr "duration" value
    /// Redraw the plot at completion of the transition. This is desirable for transitions that include properties that cannot be transitioned, but may significantly slow down updates that do not require a full redraw of the plot
    static member inline redraw (value: bool) = Interop.mkFrameAttr "redraw" value

