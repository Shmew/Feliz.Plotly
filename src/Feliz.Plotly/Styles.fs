namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type styles =
    static member inline style (properties: #IStyleProperty list) = Interop.mkStylesAttr "style" (createObj !!properties)

