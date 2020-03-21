namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type animation =
    static member inline frame (properties: #IFrameProperty list) = Interop.mkAnimationAttr "frame" (createObj !!properties)
    /// Play frames starting at the current frame instead of the beginning.
    static member inline fromcurrent (value: bool) = Interop.mkAnimationAttr "fromcurrent" value
    static member inline transition (properties: #ITransitionProperty list) = Interop.mkAnimationAttr "transition" (createObj !!properties)

[<RequireQualifiedAccess>]
module animation =
    /// The direction in which to play the frames triggered by the animation call
    [<Erase>]
    type direction =
        static member inline forward = Interop.mkAnimationAttr "direction" "forward"
        static member inline reverse = Interop.mkAnimationAttr "direction" "reverse"

    /// Describes how a new animate call interacts with currently-running animations. If `immediate`, current animations are interrupted and the new animation is started. If `next`, the current frame is allowed to complete, after which the new animation is started. If `afterall` all existing frames are animated to completion before the new animation is started.
    [<Erase>]
    type mode =
        static member inline afterall = Interop.mkAnimationAttr "mode" "afterall"
        static member inline immediate = Interop.mkAnimationAttr "mode" "immediate"
        static member inline next = Interop.mkAnimationAttr "mode" "next"

