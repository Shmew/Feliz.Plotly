namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type rangeslider =
    /// Sets the background color of the range slider.
    static member inline bgcolor (value: string) = Interop.mkRangesliderAttr "bgcolor" value
    /// Sets the border color of the range slider.
    static member inline bordercolor (value: string) = Interop.mkRangesliderAttr "bordercolor" value
    /// Sets the border width of the range slider.
    static member inline borderwidth (value: int) = Interop.mkRangesliderAttr "borderwidth" value
    /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
    static member inline autorange (value: bool) = Interop.mkRangesliderAttr "autorange" value
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: bool) = Interop.mkRangesliderAttr "range" (value |> Array.singleton)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<bool>) = Interop.mkRangesliderAttr "range" (values |> Array.ofSeq)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: System.DateTime) = Interop.mkRangesliderAttr "range" (value |> Array.singleton)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<System.DateTime>) = Interop.mkRangesliderAttr "range" (values |> Array.ofSeq)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: int) = Interop.mkRangesliderAttr "range" (value |> Array.singleton)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<int>) = Interop.mkRangesliderAttr "range" (values |> Array.ofSeq)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: float) = Interop.mkRangesliderAttr "range" (value |> Array.singleton)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<float>) = Interop.mkRangesliderAttr "range" (values |> Array.ofSeq)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: string) = Interop.mkRangesliderAttr "range" (value |> Array.singleton)
    /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<string>) = Interop.mkRangesliderAttr "range" (values |> Array.ofSeq)
    /// The height of the range slider as a fraction of the total plot area height.
    static member inline thickness (value: int) = Interop.mkRangesliderAttr "thickness" value
    /// The height of the range slider as a fraction of the total plot area height.
    static member inline thickness (value: float) = Interop.mkRangesliderAttr "thickness" value
    /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
    static member inline visible (value: bool) = Interop.mkRangesliderAttr "visible" value
    static member inline yaxis (properties: #IYaxisProperty list) = Interop.mkRangesliderAttr "yaxis" (createObj !!properties)

