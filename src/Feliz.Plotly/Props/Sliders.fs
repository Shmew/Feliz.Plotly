namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type sliders =
    static member inline slider (properties: #ISliderProperty list) = Interop.mkSlidersAttr "slider" (createObj !!properties)

