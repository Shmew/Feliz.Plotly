namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type cumulative =
    /// If true, display the cumulative distribution by summing the binned values. Use the `direction` and `centralbin` attributes to tune the accumulation method. Note: in this mode, the *density* `histnorm` settings behave the same as their equivalents without *density*: ** and *density* both rise to the number of data points, and *probability* and *probability density* both rise to the number of sample points.
    static member inline enabled (value: bool) = Interop.mkCumulativeAttr "enabled" value

[<AutoOpen>]
module cumulative =
    /// Only applies if cumulative is enabled. If *increasing* (default) we sum all prior bins, so the result increases from left to right. If *decreasing* we sum later bins so the result decreases from left to right.
    [<Erase>]
    type direction =
        static member inline decreasing = Interop.mkCumulativeAttr "direction" "decreasing"
        static member inline increasing = Interop.mkCumulativeAttr "direction" "increasing"

    /// Only applies if cumulative is enabled. Sets whether the current bin is included, excluded, or has half of its value included in the current cumulative value. *include* is the default for compatibility with various other tools, however it introduces a half-bin bias to the results. *exclude* makes the opposite half-bin bias, and *half* removes it.
    [<Erase>]
    type currentbin =
        static member inline exclude = Interop.mkCumulativeAttr "currentbin" "exclude"
        static member inline half = Interop.mkCumulativeAttr "currentbin" "half"
        static member inline include' = Interop.mkCumulativeAttr "currentbin" "include"

