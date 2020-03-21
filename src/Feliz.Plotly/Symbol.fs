namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type symbol =
    /// Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list: https://www.mapbox.com/maki-icons/
    static member inline icon (value: string) = Interop.mkSymbolAttr "icon" value
    /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
    static member inline iconsize (value: int) = Interop.mkSymbolAttr "iconsize" value
    /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
    static member inline iconsize (value: float) = Interop.mkSymbolAttr "iconsize" value
    /// Sets the symbol text (mapbox.layer.layout.text-field).
    static member inline text (value: string) = Interop.mkSymbolAttr "text" value
    /// Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size). Has an effect only when `type` is set to *symbol*.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkSymbolAttr "textfont" (createObj !!properties)

[<RequireQualifiedAccess>]
module symbol =
    /// Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry
    [<Erase>]
    type placement =
        static member inline line = Interop.mkSymbolAttr "placement" "line"
        static member inline lineCenter = Interop.mkSymbolAttr "placement" "line-center"
        static member inline point = Interop.mkSymbolAttr "placement" "point"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkSymbolAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkSymbolAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkSymbolAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkSymbolAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkSymbolAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkSymbolAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkSymbolAttr "textposition" "top center"
        static member inline topLeft = Interop.mkSymbolAttr "textposition" "top left"
        static member inline topRight = Interop.mkSymbolAttr "textposition" "top right"

