namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type selected =
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkSelectedAttr "marker" (createObj !!properties)
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkSelectedAttr "textfont" (createObj !!properties)

