namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type number =
    /// Sets the value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline valueformat (value: string) = Interop.mkNumberAttr "valueformat" value
    /// Set the font used to display main number
    static member inline font (properties: #IFontProperty list) = Interop.mkNumberAttr "font" (createObj !!properties)
    /// Sets a prefix appearing before the number.
    static member inline prefix (value: string) = Interop.mkNumberAttr "prefix" value
    /// Sets a suffix appearing next to the number.
    static member inline suffix (value: string) = Interop.mkNumberAttr "suffix" value

