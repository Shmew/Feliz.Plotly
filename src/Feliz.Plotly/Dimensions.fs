namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type dimensions =
    static member inline dimension (properties: #IDimensionProperty list) = Interop.mkDimensionsAttr "dimension" (createObj !!properties)

