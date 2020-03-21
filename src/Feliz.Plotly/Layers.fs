namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type layers =
    static member inline layer (properties: #ILayerProperty list) = Interop.mkLayersAttr "layer" (createObj !!properties)

