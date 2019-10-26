namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type gauge =
    /// Set the appearance of the gauge's value
    static member inline bar (properties: #IBarProperty list) = Interop.mkGaugeAttr "bar" (createObj !!properties)
    /// Sets the gauge background color.
    static member inline bgcolor (value: string) = Interop.mkGaugeAttr "bgcolor" value
    /// Sets the color of the border enclosing the gauge.
    static member inline bordercolor (value: string) = Interop.mkGaugeAttr "bordercolor" value
    /// Sets the width (in px) of the border enclosing the gauge.
    static member inline borderwidth (value: int) = Interop.mkGaugeAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the gauge.
    static member inline borderwidth (value: float) = Interop.mkGaugeAttr "borderwidth" value
    static member inline axis (properties: #IAxisProperty list) = Interop.mkGaugeAttr "axis" (createObj !!properties)
    static member inline steps (properties: #IStepsProperty list) = Interop.mkGaugeAttr "steps" (createObj !!properties)
    static member inline threshold (properties: #IThresholdProperty list) = Interop.mkGaugeAttr "threshold" (createObj !!properties)

[<AutoOpen>]
module gauge =
    /// Set the shape of the gauge
    [<Erase>]
    type shape =
        static member inline angular = Interop.mkGaugeAttr "shape" "angular"
        static member inline bullet = Interop.mkGaugeAttr "shape" "bullet"

