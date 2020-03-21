namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type steps =
    static member inline step (properties: #IStepProperty list) = Interop.mkStepsAttr "step" (createObj !!properties)

