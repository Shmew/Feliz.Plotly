namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type buttons =
    /// Sets the specifications for each buttons. By default, a range selector comes with no buttons.
    static member inline button (properties: #IButtonProperty list) = Interop.mkButtonsAttr "button" (createObj !!properties)

