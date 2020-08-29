namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type delta =
    static member inline decreasing (properties: #IDecreasingProperty list) = Interop.mkDeltaAttr "decreasing" (createObj !!properties)
    /// Set the font used to display the delta
    static member inline font (properties: #IFontProperty list) = Interop.mkDeltaAttr "font" (createObj !!properties)
    static member inline increasing (properties: #IIncreasingProperty list) = Interop.mkDeltaAttr "increasing" (createObj !!properties)
    /// Sets the reference value to compute the delta. By default, it is set to the current value.
    static member inline reference (value: int) = Interop.mkDeltaAttr "reference" value
    /// Sets the reference value to compute the delta. By default, it is set to the current value.
    static member inline reference (value: float) = Interop.mkDeltaAttr "reference" value
    /// Show relative change
    static member inline relative (value: bool) = Interop.mkDeltaAttr "relative" value
    /// Sets the value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline valueformat (value: string) = Interop.mkDeltaAttr "valueformat" value

[<Erase;RequireQualifiedAccess>]
module delta =
    /// Sets the position of delta with respect to the number.
    [<Erase>]
    type position =
        static member inline bottom = Interop.mkDeltaAttr "position" "bottom"
        static member inline left = Interop.mkDeltaAttr "position" "left"
        static member inline right = Interop.mkDeltaAttr "position" "right"
        static member inline top = Interop.mkDeltaAttr "position" "top"

