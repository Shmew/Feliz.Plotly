namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type slices =
    static member inline x (properties: #IXProperty list) = Interop.mkSlicesAttr "x" (createObj !!properties)
    static member inline y (properties: #IYProperty list) = Interop.mkSlicesAttr "y" (createObj !!properties)
    static member inline z (properties: #IZProperty list) = Interop.mkSlicesAttr "z" (createObj !!properties)

