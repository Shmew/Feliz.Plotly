namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type stream =
    /// The stream id number links a data trace on a plot with a stream. See https://plot.ly/settings for more details.
    static member inline token (value: string) = Interop.mkStreamAttr "token" value
    /// Sets the maximum number of points to keep on the plots from an incoming stream. If `maxpoints` is set to *50*, only the newest 50 points will be displayed on the plot.
    static member inline maxpoints (value: int) = Interop.mkStreamAttr "maxpoints" value
    /// Sets the maximum number of points to keep on the plots from an incoming stream. If `maxpoints` is set to *50*, only the newest 50 points will be displayed on the plot.
    static member inline maxpoints (value: float) = Interop.mkStreamAttr "maxpoints" value

