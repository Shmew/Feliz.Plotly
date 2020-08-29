namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type updatemenu =
    /// Determines which button (by index starting from 0) is considered active.
    static member inline active (value: int) = Interop.mkUpdatemenuAttr "active" value
    /// Sets the background color of the update menu buttons.
    static member inline bgcolor (value: string) = Interop.mkUpdatemenuAttr "bgcolor" value
    /// Sets the color of the border enclosing the update menu.
    static member inline bordercolor (value: string) = Interop.mkUpdatemenuAttr "bordercolor" value
    /// Sets the width (in px) of the border enclosing the update menu.
    static member inline borderwidth (value: int) = Interop.mkUpdatemenuAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the update menu.
    static member inline borderwidth (value: float) = Interop.mkUpdatemenuAttr "borderwidth" value
    static member inline buttons (properties: #IButtonsProperty list) = Interop.mkUpdatemenuAttr "buttons" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Sets the font of the update menu button text.
    static member inline font (properties: #IFontProperty list) = Interop.mkUpdatemenuAttr "font" (createObj !!properties)
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkUpdatemenuAttr "name" value
    /// Sets the padding around the buttons or dropdown menu.
    static member inline pad (properties: #IPadProperty list) = Interop.mkUpdatemenuAttr "pad" (createObj !!properties)
    /// Highlights active dropdown item or active button if true.
    static member inline showactive (value: bool) = Interop.mkUpdatemenuAttr "showactive" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkUpdatemenuAttr "templateitemname" value
    /// Determines whether or not the update menu is visible.
    static member inline visible (value: bool) = Interop.mkUpdatemenuAttr "visible" value
    /// Sets the x position (in normalized coordinates) of the update menu.
    static member inline x (value: int) = Interop.mkUpdatemenuAttr "x" value
    /// Sets the x position (in normalized coordinates) of the update menu.
    static member inline x (value: float) = Interop.mkUpdatemenuAttr "x" value
    /// Sets the y position (in normalized coordinates) of the update menu.
    static member inline y (value: int) = Interop.mkUpdatemenuAttr "y" value
    /// Sets the y position (in normalized coordinates) of the update menu.
    static member inline y (value: float) = Interop.mkUpdatemenuAttr "y" value

[<Erase;RequireQualifiedAccess>]
module updatemenu =
    /// Determines the direction in which the buttons are laid out, whether in a dropdown menu or a row/column of buttons. For `left` and `up`, the buttons will still appear in left-to-right or top-to-bottom order respectively.
    [<Erase>]
    type direction =
        static member inline down = Interop.mkUpdatemenuAttr "direction" "down"
        static member inline left = Interop.mkUpdatemenuAttr "direction" "left"
        static member inline right = Interop.mkUpdatemenuAttr "direction" "right"
        static member inline up = Interop.mkUpdatemenuAttr "direction" "up"

    /// Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically
    [<Erase>]
    type type' =
        static member inline buttons = Interop.mkUpdatemenuAttr "type" "buttons"
        static member inline dropdown = Interop.mkUpdatemenuAttr "type" "dropdown"

    /// Sets the update menu's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkUpdatemenuAttr "xanchor" "auto"
        static member inline center = Interop.mkUpdatemenuAttr "xanchor" "center"
        static member inline left = Interop.mkUpdatemenuAttr "xanchor" "left"
        static member inline right = Interop.mkUpdatemenuAttr "xanchor" "right"

    /// Sets the update menu's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkUpdatemenuAttr "yanchor" "auto"
        static member inline bottom = Interop.mkUpdatemenuAttr "yanchor" "bottom"
        static member inline middle = Interop.mkUpdatemenuAttr "yanchor" "middle"
        static member inline top = Interop.mkUpdatemenuAttr "yanchor" "top"

