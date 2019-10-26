namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type meanline =
    /// Determines if a line corresponding to the sample's mean is shown inside the violins. If `box.visible` is turned on, the mean line is drawn inside the inner box. Otherwise, the mean line is drawn from one side of the violin to other.
    static member inline visible (value: bool) = Interop.mkMeanlineAttr "visible" value
    /// Sets the mean line color.
    static member inline color (value: string) = Interop.mkMeanlineAttr "color" value
    /// Sets the mean line width.
    static member inline width (value: int) = Interop.mkMeanlineAttr "width" value
    /// Sets the mean line width.
    static member inline width (value: float) = Interop.mkMeanlineAttr "width" value

