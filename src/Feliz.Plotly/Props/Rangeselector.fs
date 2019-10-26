namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type rangeselector =
    /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
    static member inline visible (value: bool) = Interop.mkRangeselectorAttr "visible" value
    static member inline buttons (properties: #IButtonsProperty list) = Interop.mkRangeselectorAttr "buttons" (createObj !!properties)
    /// Sets the x position (in normalized coordinates) of the range selector.
    static member inline x (value: int) = Interop.mkRangeselectorAttr "x" value
    /// Sets the x position (in normalized coordinates) of the range selector.
    static member inline x (value: float) = Interop.mkRangeselectorAttr "x" value
    /// Sets the y position (in normalized coordinates) of the range selector.
    static member inline y (value: int) = Interop.mkRangeselectorAttr "y" value
    /// Sets the y position (in normalized coordinates) of the range selector.
    static member inline y (value: float) = Interop.mkRangeselectorAttr "y" value
    /// Sets the font of the range selector button text.
    static member inline font (properties: #IFontProperty list) = Interop.mkRangeselectorAttr "font" (createObj !!properties)
    /// Sets the background color of the range selector buttons.
    static member inline bgcolor (value: string) = Interop.mkRangeselectorAttr "bgcolor" value
    /// Sets the background color of the active range selector button.
    static member inline activecolor (value: string) = Interop.mkRangeselectorAttr "activecolor" value
    /// Sets the color of the border enclosing the range selector.
    static member inline bordercolor (value: string) = Interop.mkRangeselectorAttr "bordercolor" value
    /// Sets the width (in px) of the border enclosing the range selector.
    static member inline borderwidth (value: int) = Interop.mkRangeselectorAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the range selector.
    static member inline borderwidth (value: float) = Interop.mkRangeselectorAttr "borderwidth" value

[<AutoOpen>]
module rangeselector =
    /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkRangeselectorAttr "xanchor" "auto"
        static member inline center = Interop.mkRangeselectorAttr "xanchor" "center"
        static member inline left = Interop.mkRangeselectorAttr "xanchor" "left"
        static member inline right = Interop.mkRangeselectorAttr "xanchor" "right"

    /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkRangeselectorAttr "yanchor" "auto"
        static member inline bottom = Interop.mkRangeselectorAttr "yanchor" "bottom"
        static member inline middle = Interop.mkRangeselectorAttr "yanchor" "middle"
        static member inline top = Interop.mkRangeselectorAttr "yanchor" "top"

