namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type pathbar =
    /// Sets the font used inside `pathbar`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkPathbarAttr "textfont" (createObj !!properties)
    /// Sets the thickness of `pathbar` (in px). If not specified the `pathbar.textfont.size` is used with 3 pixles extra padding on each side.
    static member inline thickness (value: int) = Interop.mkPathbarAttr "thickness" value
    /// Sets the thickness of `pathbar` (in px). If not specified the `pathbar.textfont.size` is used with 3 pixles extra padding on each side.
    static member inline thickness (value: float) = Interop.mkPathbarAttr "thickness" value
    /// Determines if the path bar is drawn i.e. outside the trace `domain` and with one pixel gap.
    static member inline visible (value: bool) = Interop.mkPathbarAttr "visible" value

[<Erase;RequireQualifiedAccess>]
module pathbar =
    /// Determines which shape is used for edges between `barpath` labels.
    [<Erase>]
    type edgeshape =
        static member inline rightSlant = Interop.mkPathbarAttr "edgeshape" "/"
        static member inline pointedLeft = Interop.mkPathbarAttr "edgeshape" "<"
        static member inline pointedRight = Interop.mkPathbarAttr "edgeshape" ">"
        static member inline leftSlant = Interop.mkPathbarAttr "edgeshape" "\\"
        static member inline straight = Interop.mkPathbarAttr "edgeshape" "|"

    /// Determines on which side of the the treemap the `pathbar` should be presented.
    [<Erase>]
    type side =
        static member inline bottom = Interop.mkPathbarAttr "side" "bottom"
        static member inline top = Interop.mkPathbarAttr "side" "top"

