namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type newshape =
    /// Sets the color filling new shapes' interior. Please note that if using a fillcolor with alpha greater than half, drag inside the active shape starts moving the shape underneath, otherwise a new shape could be started over.
    static member inline fillcolor (value: string) = Interop.mkNewshapeAttr "fillcolor" value
    static member inline line (properties: #ILineProperty list) = Interop.mkNewshapeAttr "line" (createObj !!properties)
    /// Sets the opacity of new shapes.
    static member inline opacity (value: int) = Interop.mkNewshapeAttr "opacity" value
    /// Sets the opacity of new shapes.
    static member inline opacity (value: float) = Interop.mkNewshapeAttr "opacity" value

[<RequireQualifiedAccess>]
module newshape =
    /// When `dragmode` is set to *drawrect*, *drawline* or *drawcircle* this limits the drag to be horizontal, vertical or diagonal. Using *diagonal* there is no limit e.g. in drawing lines in any direction. *ortho* limits the draw to be either horizontal or vertical. *horizontal* allows horizontal extend. *vertical* allows vertical extend.
    [<Erase>]
    type drawdirection =
        static member inline diagonal = Interop.mkNewshapeAttr "drawdirection" "diagonal"
        static member inline horizontal = Interop.mkNewshapeAttr "drawdirection" "horizontal"
        static member inline ortho = Interop.mkNewshapeAttr "drawdirection" "ortho"
        static member inline vertical = Interop.mkNewshapeAttr "drawdirection" "vertical"

    /// Determines the path's interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
    [<Erase>]
    type fillrule =
        static member inline evenodd = Interop.mkNewshapeAttr "fillrule" "evenodd"
        static member inline nonzero = Interop.mkNewshapeAttr "fillrule" "nonzero"

    /// Specifies whether new shapes are drawn below or above traces.
    [<Erase>]
    type layer =
        static member inline above = Interop.mkNewshapeAttr "layer" "above"
        static member inline below = Interop.mkNewshapeAttr "layer" "below"

