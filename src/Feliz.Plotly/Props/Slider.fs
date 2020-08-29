namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type slider =
    /// Determines which button (by index starting from 0) is considered active.
    static member inline active (value: int) = Interop.mkSliderAttr "active" value
    /// Determines which button (by index starting from 0) is considered active.
    static member inline active (value: float) = Interop.mkSliderAttr "active" value
    /// Sets the background color of the slider grip while dragging.
    static member inline activebgcolor (value: string) = Interop.mkSliderAttr "activebgcolor" value
    /// Sets the background color of the slider.
    static member inline bgcolor (value: string) = Interop.mkSliderAttr "bgcolor" value
    /// Sets the color of the border enclosing the slider.
    static member inline bordercolor (value: string) = Interop.mkSliderAttr "bordercolor" value
    /// Sets the width (in px) of the border enclosing the slider.
    static member inline borderwidth (value: int) = Interop.mkSliderAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the slider.
    static member inline borderwidth (value: float) = Interop.mkSliderAttr "borderwidth" value
    static member inline currentvalue (properties: #ICurrentvalueProperty list) = Interop.mkSliderAttr "currentvalue" (createObj !!properties)
    /// Sets the font of the slider step labels.
    static member inline font (properties: #IFontProperty list) = Interop.mkSliderAttr "font" (createObj !!properties)
    /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
    static member inline len (value: int) = Interop.mkSliderAttr "len" value
    /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
    static member inline len (value: float) = Interop.mkSliderAttr "len" value
    /// Sets the length in pixels of minor step tick marks
    static member inline minorticklen (value: int) = Interop.mkSliderAttr "minorticklen" value
    /// Sets the length in pixels of minor step tick marks
    static member inline minorticklen (value: float) = Interop.mkSliderAttr "minorticklen" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkSliderAttr "name" value
    /// Set the padding of the slider component along each side.
    static member inline pad (properties: #IPadProperty list) = Interop.mkSliderAttr "pad" (createObj !!properties)
    static member inline steps (properties: #IStepsProperty list) = Interop.mkSliderAttr "steps" (createObj !!properties)
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkSliderAttr "templateitemname" value
    /// Sets the color of the border enclosing the slider.
    static member inline tickcolor (value: string) = Interop.mkSliderAttr "tickcolor" value
    /// Sets the length in pixels of step tick marks
    static member inline ticklen (value: int) = Interop.mkSliderAttr "ticklen" value
    /// Sets the length in pixels of step tick marks
    static member inline ticklen (value: float) = Interop.mkSliderAttr "ticklen" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkSliderAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkSliderAttr "tickwidth" value
    static member inline transition (properties: #ITransitionProperty list) = Interop.mkSliderAttr "transition" (createObj !!properties)
    /// Determines whether or not the slider is visible.
    static member inline visible (value: bool) = Interop.mkSliderAttr "visible" value
    /// Sets the x position (in normalized coordinates) of the slider.
    static member inline x (value: int) = Interop.mkSliderAttr "x" value
    /// Sets the x position (in normalized coordinates) of the slider.
    static member inline x (value: float) = Interop.mkSliderAttr "x" value
    /// Sets the y position (in normalized coordinates) of the slider.
    static member inline y (value: int) = Interop.mkSliderAttr "y" value
    /// Sets the y position (in normalized coordinates) of the slider.
    static member inline y (value: float) = Interop.mkSliderAttr "y" value

[<Erase;RequireQualifiedAccess>]
module slider =
    /// Determines whether this slider length is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
    [<Erase>]
    type lenmode =
        static member inline fraction = Interop.mkSliderAttr "lenmode" "fraction"
        static member inline pixels = Interop.mkSliderAttr "lenmode" "pixels"

    /// Sets the slider's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkSliderAttr "xanchor" "auto"
        static member inline center = Interop.mkSliderAttr "xanchor" "center"
        static member inline left = Interop.mkSliderAttr "xanchor" "left"
        static member inline right = Interop.mkSliderAttr "xanchor" "right"

    /// Sets the slider's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkSliderAttr "yanchor" "auto"
        static member inline bottom = Interop.mkSliderAttr "yanchor" "bottom"
        static member inline middle = Interop.mkSliderAttr "yanchor" "middle"
        static member inline top = Interop.mkSliderAttr "yanchor" "top"

