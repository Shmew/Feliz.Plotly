namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type radialaxis =
    /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
    static member inline angle (value: int) = Interop.mkRadialaxisAttr "angle" value
    /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
    static member inline angle (value: float) = Interop.mkRadialaxisAttr "angle" value
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkRadialaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTime) = Interop.mkRadialaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkRadialaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkRadialaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkRadialaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<bool>>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool list>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool []>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<string>>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string list>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string []>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<int>>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int list>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int []>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<float>>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float list>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float []>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<PlotData>) = Interop.mkRadialaxisAttr "categoryarray" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool option>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime option>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float option>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string option>) = Interop.mkRadialaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkRadialaxisAttr "categoryarraysrc" value
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkRadialaxisAttr "color" value
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: int) = Interop.mkRadialaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkRadialaxisAttr "domain" (values |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: float) = Interop.mkRadialaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkRadialaxisAttr "domain" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: bool) = Interop.mkRadialaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<bool>) = Interop.mkRadialaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: System.DateTime) = Interop.mkRadialaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: int) = Interop.mkRadialaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<int>) = Interop.mkRadialaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: float) = Interop.mkRadialaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<float>) = Interop.mkRadialaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: string) = Interop.mkRadialaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<string>) = Interop.mkRadialaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the color of the grid lines.
    static member inline gridcolor (value: string) = Interop.mkRadialaxisAttr "gridcolor" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: int) = Interop.mkRadialaxisAttr "gridwidth" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: float) = Interop.mkRadialaxisAttr "gridwidth" value
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline hoverformat (value: string) = Interop.mkRadialaxisAttr "hoverformat" value
    /// Sets the axis line color.
    static member inline linecolor (value: string) = Interop.mkRadialaxisAttr "linecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: int) = Interop.mkRadialaxisAttr "linewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: float) = Interop.mkRadialaxisAttr "linewidth" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkRadialaxisAttr "nticks" value
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: bool) = Interop.mkRadialaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<bool>) = Interop.mkRadialaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: System.DateTime) = Interop.mkRadialaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: float) = Interop.mkRadialaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<float>) = Interop.mkRadialaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: int) = Interop.mkRadialaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<int>) = Interop.mkRadialaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: string) = Interop.mkRadialaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<string>) = Interop.mkRadialaxisAttr "range" (values |> ResizeArray)
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkRadialaxisAttr "separatethousands" value
    /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
    static member inline showgrid (value: bool) = Interop.mkRadialaxisAttr "showgrid" value
    /// Determines whether or not a line bounding this axis is drawn.
    static member inline showline (value: bool) = Interop.mkRadialaxisAttr "showline" value
    /// Determines whether or not the tick labels are drawn.
    static member inline showticklabels (value: bool) = Interop.mkRadialaxisAttr "showticklabels" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: bool) = Interop.mkRadialaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<bool>) = Interop.mkRadialaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: System.DateTime) = Interop.mkRadialaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: int) = Interop.mkRadialaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<int>) = Interop.mkRadialaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: float) = Interop.mkRadialaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<float>) = Interop.mkRadialaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: string) = Interop.mkRadialaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<string>) = Interop.mkRadialaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkRadialaxisAttr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkRadialaxisAttr "tickangle" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkRadialaxisAttr "tickcolor" value
    /// Sets the tick font.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkRadialaxisAttr "tickfont" (createObj !!properties)
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkRadialaxisAttr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkRadialaxisAttr "tickformatstops" (createObj !!properties)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkRadialaxisAttr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkRadialaxisAttr "ticklen" value
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkRadialaxisAttr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkRadialaxisAttr "ticksuffix" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkRadialaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkRadialaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkRadialaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkRadialaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkRadialaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int []>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<PlotData>) = Interop.mkRadialaxisAttr "ticktext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool option>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime option>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int option>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float option>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string option>) = Interop.mkRadialaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkRadialaxisAttr "ticktextsrc" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkRadialaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTime) = Interop.mkRadialaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkRadialaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkRadialaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkRadialaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool list>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool []>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string list>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string []>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int list>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int []>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float list>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float []>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<PlotData>) = Interop.mkRadialaxisAttr "tickvals" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool option>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime option>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int option>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float option>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string option>) = Interop.mkRadialaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkRadialaxisAttr "tickvalssrc" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkRadialaxisAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkRadialaxisAttr "tickwidth" value
    static member inline title (properties: #ITitleProperty list) = Interop.mkRadialaxisAttr "title" (createObj !!properties)
    static member inline title (value: string) = Interop.mkRadialaxisAttr "title" (createObj !!((Interop.mkTitleAttr "text" value) |> Array.singleton))
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkRadialaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkRadialaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkRadialaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkRadialaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: int) = Interop.mkRadialaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkRadialaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: float) = Interop.mkRadialaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkRadialaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: string) = Interop.mkRadialaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkRadialaxisAttr "uirevision" (values |> ResizeArray)
    /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
    static member inline visible (value: bool) = Interop.mkRadialaxisAttr "visible" value

[<RequireQualifiedAccess>]
module radialaxis =
    /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
    [<Erase>]
    type autorange =
        static member inline reversed = Interop.mkRadialaxisAttr "autorange" "reversed"
        static member inline false' = Interop.mkRadialaxisAttr "autorange" false
        static member inline true' = Interop.mkRadialaxisAttr "autorange" true

    /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
    [<Erase>]
    type calendar =
        static member inline chinese = Interop.mkRadialaxisAttr "calendar" "chinese"
        static member inline coptic = Interop.mkRadialaxisAttr "calendar" "coptic"
        static member inline discworld = Interop.mkRadialaxisAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkRadialaxisAttr "calendar" "ethiopian"
        static member inline gregorian = Interop.mkRadialaxisAttr "calendar" "gregorian"
        static member inline hebrew = Interop.mkRadialaxisAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkRadialaxisAttr "calendar" "islamic"
        static member inline jalali = Interop.mkRadialaxisAttr "calendar" "jalali"
        static member inline julian = Interop.mkRadialaxisAttr "calendar" "julian"
        static member inline mayan = Interop.mkRadialaxisAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkRadialaxisAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkRadialaxisAttr "calendar" "nepali"
        static member inline persian = Interop.mkRadialaxisAttr "calendar" "persian"
        static member inline taiwan = Interop.mkRadialaxisAttr "calendar" "taiwan"
        static member inline thai = Interop.mkRadialaxisAttr "calendar" "thai"
        static member inline ummalqura = Interop.mkRadialaxisAttr "calendar" "ummalqura"

    /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkRadialaxisAttr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkRadialaxisAttr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkRadialaxisAttr "categoryorder" "category descending"
        static member inline maxAscending = Interop.mkRadialaxisAttr "categoryorder" "max ascending"
        static member inline maxDescending = Interop.mkRadialaxisAttr "categoryorder" "max descending"
        static member inline meanAscending = Interop.mkRadialaxisAttr "categoryorder" "mean ascending"
        static member inline meanDescending = Interop.mkRadialaxisAttr "categoryorder" "mean descending"
        static member inline medianAscending = Interop.mkRadialaxisAttr "categoryorder" "median ascending"
        static member inline medianDescending = Interop.mkRadialaxisAttr "categoryorder" "median descending"
        static member inline minAscending = Interop.mkRadialaxisAttr "categoryorder" "min ascending"
        static member inline minDescending = Interop.mkRadialaxisAttr "categoryorder" "min descending"
        static member inline sumAscending = Interop.mkRadialaxisAttr "categoryorder" "sum ascending"
        static member inline sumDescending = Interop.mkRadialaxisAttr "categoryorder" "sum descending"
        static member inline totalAscending = Interop.mkRadialaxisAttr "categoryorder" "total ascending"
        static member inline totalDescending = Interop.mkRadialaxisAttr "categoryorder" "total descending"
        static member inline trace = Interop.mkRadialaxisAttr "categoryorder" "trace"

    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    [<Erase>]
    type color =
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgb (r,g,b) = Interop.mkRadialaxisAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgba (r,g,b,a) = Interop.mkRadialaxisAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline hsl (h,s,l) = Interop.mkRadialaxisAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkRadialaxisAttr "exponentformat" "B"
        static member inline E = Interop.mkRadialaxisAttr "exponentformat" "E"
        static member inline SI = Interop.mkRadialaxisAttr "exponentformat" "SI"
        static member inline e = Interop.mkRadialaxisAttr "exponentformat" "e"
        static member inline none = Interop.mkRadialaxisAttr "exponentformat" "none"
        static member inline power = Interop.mkRadialaxisAttr "exponentformat" "power"

    /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
    [<Erase>]
    type layer =
        static member inline aboveTraces = Interop.mkRadialaxisAttr "layer" "above traces"
        static member inline belowTraces = Interop.mkRadialaxisAttr "layer" "below traces"

    /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
    [<Erase>]
    type rangemode =
        static member inline nonnegative = Interop.mkRadialaxisAttr "rangemode" "nonnegative"
        static member inline normal = Interop.mkRadialaxisAttr "rangemode" "normal"
        static member inline tozero = Interop.mkRadialaxisAttr "rangemode" "tozero"

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkRadialaxisAttr "showexponent" "all"
        static member inline first = Interop.mkRadialaxisAttr "showexponent" "first"
        static member inline last = Interop.mkRadialaxisAttr "showexponent" "last"
        static member inline none = Interop.mkRadialaxisAttr "showexponent" "none"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkRadialaxisAttr "showtickprefix" "all"
        static member inline first = Interop.mkRadialaxisAttr "showtickprefix" "first"
        static member inline last = Interop.mkRadialaxisAttr "showtickprefix" "last"
        static member inline none = Interop.mkRadialaxisAttr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkRadialaxisAttr "showticksuffix" "all"
        static member inline first = Interop.mkRadialaxisAttr "showticksuffix" "first"
        static member inline last = Interop.mkRadialaxisAttr "showticksuffix" "last"
        static member inline none = Interop.mkRadialaxisAttr "showticksuffix" "none"

    /// Determines on which side of radial axis line the tick and tick labels appear.
    [<Erase>]
    type side =
        static member inline clockwise = Interop.mkRadialaxisAttr "side" "clockwise"
        static member inline counterclockwise = Interop.mkRadialaxisAttr "side" "counterclockwise"

    /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkRadialaxisAttr "tickmode" "array"
        static member inline auto = Interop.mkRadialaxisAttr "tickmode" "auto"
        static member inline linear = Interop.mkRadialaxisAttr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkRadialaxisAttr "ticks" ""
        static member inline inside = Interop.mkRadialaxisAttr "ticks" "inside"
        static member inline outside = Interop.mkRadialaxisAttr "ticks" "outside"

    /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
    [<Erase>]
    type type' =
        static member inline dash = Interop.mkRadialaxisAttr "type" "-"
        static member inline category = Interop.mkRadialaxisAttr "type" "category"
        static member inline date = Interop.mkRadialaxisAttr "type" "date"
        static member inline linear = Interop.mkRadialaxisAttr "type" "linear"
        static member inline log = Interop.mkRadialaxisAttr "type" "log"

