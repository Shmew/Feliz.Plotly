namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type locales =
    /// Register a locale to be used with the plot, takes the name of the locale (such as en-US), and configuration.
    static member inline locale (name: string) (properties: ILocaleProperty list) = Interop.mkLocalesAttr name (createObj !!properties)
