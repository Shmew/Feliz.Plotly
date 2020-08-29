namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type transition =
    /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
    static member inline duration (value: int) = Interop.mkTransitionAttr "duration" value
    /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
    static member inline duration (value: float) = Interop.mkTransitionAttr "duration" value

[<Erase;RequireQualifiedAccess>]
module transition =
    /// The easing function used for the transition
    [<Erase>]
    type easing =
        static member inline back = Interop.mkTransitionAttr "easing" "back"
        static member inline backIn = Interop.mkTransitionAttr "easing" "back-in"
        static member inline backInOut = Interop.mkTransitionAttr "easing" "back-in-out"
        static member inline backOut = Interop.mkTransitionAttr "easing" "back-out"
        static member inline bounce = Interop.mkTransitionAttr "easing" "bounce"
        static member inline bounceIn = Interop.mkTransitionAttr "easing" "bounce-in"
        static member inline bounceInOut = Interop.mkTransitionAttr "easing" "bounce-in-out"
        static member inline bounceOut = Interop.mkTransitionAttr "easing" "bounce-out"
        static member inline circle = Interop.mkTransitionAttr "easing" "circle"
        static member inline circleIn = Interop.mkTransitionAttr "easing" "circle-in"
        static member inline circleInOut = Interop.mkTransitionAttr "easing" "circle-in-out"
        static member inline circleOut = Interop.mkTransitionAttr "easing" "circle-out"
        static member inline cubic = Interop.mkTransitionAttr "easing" "cubic"
        static member inline cubicIn = Interop.mkTransitionAttr "easing" "cubic-in"
        static member inline cubicInOut = Interop.mkTransitionAttr "easing" "cubic-in-out"
        static member inline cubicOut = Interop.mkTransitionAttr "easing" "cubic-out"
        static member inline elastic = Interop.mkTransitionAttr "easing" "elastic"
        static member inline elasticIn = Interop.mkTransitionAttr "easing" "elastic-in"
        static member inline elasticInOut = Interop.mkTransitionAttr "easing" "elastic-in-out"
        static member inline elasticOut = Interop.mkTransitionAttr "easing" "elastic-out"
        static member inline exp = Interop.mkTransitionAttr "easing" "exp"
        static member inline expIn = Interop.mkTransitionAttr "easing" "exp-in"
        static member inline expInOut = Interop.mkTransitionAttr "easing" "exp-in-out"
        static member inline expOut = Interop.mkTransitionAttr "easing" "exp-out"
        static member inline linear = Interop.mkTransitionAttr "easing" "linear"
        static member inline linearIn = Interop.mkTransitionAttr "easing" "linear-in"
        static member inline linearInOut = Interop.mkTransitionAttr "easing" "linear-in-out"
        static member inline linearOut = Interop.mkTransitionAttr "easing" "linear-out"
        static member inline quad = Interop.mkTransitionAttr "easing" "quad"
        static member inline quadIn = Interop.mkTransitionAttr "easing" "quad-in"
        static member inline quadInOut = Interop.mkTransitionAttr "easing" "quad-in-out"
        static member inline quadOut = Interop.mkTransitionAttr "easing" "quad-out"
        static member inline sin = Interop.mkTransitionAttr "easing" "sin"
        static member inline sinIn = Interop.mkTransitionAttr "easing" "sin-in"
        static member inline sinInOut = Interop.mkTransitionAttr "easing" "sin-in-out"
        static member inline sinOut = Interop.mkTransitionAttr "easing" "sin-out"

    /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
    [<Erase>]
    type ordering =
        static member inline layoutFirst = Interop.mkTransitionAttr "ordering" "layout first"
        static member inline tracesFirst = Interop.mkTransitionAttr "ordering" "traces first"

