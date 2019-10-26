namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type unselected =
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkUnselectedAttr "marker" (createObj !!properties)
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkUnselectedAttr "textfont" (createObj !!properties)

