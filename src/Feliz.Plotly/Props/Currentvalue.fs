namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type currentvalue =
    /// Sets the font of the current value label text.
    static member inline font (properties: #IFontProperty list) = Interop.mkCurrentvalueAttr "font" (createObj !!properties)
    /// The amount of space, in pixels, between the current value label and the slider.
    static member inline offset (value: int) = Interop.mkCurrentvalueAttr "offset" value
    /// The amount of space, in pixels, between the current value label and the slider.
    static member inline offset (value: float) = Interop.mkCurrentvalueAttr "offset" value
    /// When currentvalue.visible is true, this sets the prefix of the label.
    static member inline prefix (value: string) = Interop.mkCurrentvalueAttr "prefix" value
    /// When currentvalue.visible is true, this sets the suffix of the label.
    static member inline suffix (value: string) = Interop.mkCurrentvalueAttr "suffix" value
    /// Shows the currently-selected value above the slider.
    static member inline visible (value: bool) = Interop.mkCurrentvalueAttr "visible" value

[<Erase;RequireQualifiedAccess>]
module currentvalue =
    /// The alignment of the value readout relative to the length of the slider.
    [<Erase>]
    type xanchor =
        static member inline center = Interop.mkCurrentvalueAttr "xanchor" "center"
        static member inline left = Interop.mkCurrentvalueAttr "xanchor" "left"
        static member inline right = Interop.mkCurrentvalueAttr "xanchor" "right"

