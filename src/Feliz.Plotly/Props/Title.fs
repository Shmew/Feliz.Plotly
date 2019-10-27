namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type title =
    /// Sets the title of this indicator.
    static member inline text (value: string) = Interop.mkTitleAttr "text" value
    /// Set the font used to display the title
    static member inline font (properties: #IFontProperty list) = Interop.mkTitleAttr "font" (createObj !!properties)
    /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
    static member inline x (value: int) = Interop.mkTitleAttr "x" value
    /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
    static member inline x (value: float) = Interop.mkTitleAttr "x" value
    /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
    static member inline y (value: int) = Interop.mkTitleAttr "y" value
    /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
    static member inline y (value: float) = Interop.mkTitleAttr "y" value
    /// Sets the padding of the title. Each padding value only applies when the corresponding `xanchor`/`yanchor` value is set accordingly. E.g. for left padding to take effect, `xanchor` must be set to *left*. The same rule applies if `xanchor`/`yanchor` is determined automatically. Padding is muted if the respective anchor value is *middle*/*center*.
    static member inline pad (properties: #IPadProperty list) = Interop.mkTitleAttr "pad" (createObj !!properties)

[<AutoOpen>]
module title =
    /// Sets the horizontal alignment of the title. It defaults to `center` except for bullet charts for which it defaults to right.
    [<Erase>]
    type align =
        static member inline center = Interop.mkTitleAttr "align" "center"
        static member inline left = Interop.mkTitleAttr "align" "left"
        static member inline right = Interop.mkTitleAttr "align" "right"

    /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
    [<Erase>]
    type xref =
        static member inline container = Interop.mkTitleAttr "xref" "container"
        static member inline paper = Interop.mkTitleAttr "xref" "paper"

    /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
    [<Erase>]
    type yref =
        static member inline container = Interop.mkTitleAttr "yref" "container"
        static member inline paper = Interop.mkTitleAttr "yref" "paper"

    /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkTitleAttr "xanchor" "auto"
        static member inline center = Interop.mkTitleAttr "xanchor" "center"
        static member inline left = Interop.mkTitleAttr "xanchor" "left"
        static member inline right = Interop.mkTitleAttr "xanchor" "right"

    /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkTitleAttr "yanchor" "auto"
        static member inline bottom = Interop.mkTitleAttr "yanchor" "bottom"
        static member inline middle = Interop.mkTitleAttr "yanchor" "middle"
        static member inline top = Interop.mkTitleAttr "yanchor" "top"

