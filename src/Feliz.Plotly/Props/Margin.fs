namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type margin =
    /// Sets the left margin (in px).
    static member inline l (value: int) = Interop.mkMarginAttr "l" value
    /// Sets the left margin (in px).
    static member inline l (value: float) = Interop.mkMarginAttr "l" value
    /// Sets the right margin (in px).
    static member inline r (value: int) = Interop.mkMarginAttr "r" value
    /// Sets the right margin (in px).
    static member inline r (value: float) = Interop.mkMarginAttr "r" value
    /// Sets the top margin (in px).
    static member inline t (value: int) = Interop.mkMarginAttr "t" value
    /// Sets the top margin (in px).
    static member inline t (value: float) = Interop.mkMarginAttr "t" value
    /// Sets the bottom margin (in px).
    static member inline b (value: int) = Interop.mkMarginAttr "b" value
    /// Sets the bottom margin (in px).
    static member inline b (value: float) = Interop.mkMarginAttr "b" value
    /// Sets the amount of padding (in px) between the plotting area and the axis lines
    static member inline pad (value: int) = Interop.mkMarginAttr "pad" value
    /// Sets the amount of padding (in px) between the plotting area and the axis lines
    static member inline pad (value: float) = Interop.mkMarginAttr "pad" value
    /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
    static member inline autoexpand (value: bool) = Interop.mkMarginAttr "autoexpand" value

