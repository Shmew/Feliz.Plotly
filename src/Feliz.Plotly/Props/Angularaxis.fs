namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type angularaxis =
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkAngularaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTime) = Interop.mkAngularaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkAngularaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkAngularaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkAngularaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<bool>>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool list>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool []>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<string>>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string list>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string []>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<int>>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int list>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int []>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<float>>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float list>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float []>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<PlotData>) = Interop.mkAngularaxisAttr "categoryarray" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool option>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime option>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float option>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string option>) = Interop.mkAngularaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkAngularaxisAttr "categoryarraysrc" value
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkAngularaxisAttr "color" value
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: int) = Interop.mkAngularaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<int>) = Interop.mkAngularaxisAttr "domain" (values |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (value: float) = Interop.mkAngularaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Polar chart subplots are not supported yet. This key has currently no effect.
    static member inline domain (values: seq<float>) = Interop.mkAngularaxisAttr "domain" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: bool) = Interop.mkAngularaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<bool>) = Interop.mkAngularaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: System.DateTime) = Interop.mkAngularaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: int) = Interop.mkAngularaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<int>) = Interop.mkAngularaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: float) = Interop.mkAngularaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<float>) = Interop.mkAngularaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: string) = Interop.mkAngularaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<string>) = Interop.mkAngularaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the color of the grid lines.
    static member inline gridcolor (value: string) = Interop.mkAngularaxisAttr "gridcolor" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: int) = Interop.mkAngularaxisAttr "gridwidth" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: float) = Interop.mkAngularaxisAttr "gridwidth" value
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline hoverformat (value: string) = Interop.mkAngularaxisAttr "hoverformat" value
    /// Sets the axis line color.
    static member inline linecolor (value: string) = Interop.mkAngularaxisAttr "linecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: int) = Interop.mkAngularaxisAttr "linewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: float) = Interop.mkAngularaxisAttr "linewidth" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkAngularaxisAttr "nticks" value
    /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
    static member inline period (value: int) = Interop.mkAngularaxisAttr "period" value
    /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
    static member inline period (value: float) = Interop.mkAngularaxisAttr "period" value
    /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
    static member inline rotation (value: int) = Interop.mkAngularaxisAttr "rotation" value
    /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
    static member inline rotation (value: float) = Interop.mkAngularaxisAttr "rotation" value
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkAngularaxisAttr "separatethousands" value
    /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
    static member inline showgrid (value: bool) = Interop.mkAngularaxisAttr "showgrid" value
    /// Determines whether or not a line bounding this axis is drawn.
    static member inline showline (value: bool) = Interop.mkAngularaxisAttr "showline" value
    /// Determines whether or not the tick labels are drawn.
    static member inline showticklabels (value: bool) = Interop.mkAngularaxisAttr "showticklabels" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: bool) = Interop.mkAngularaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<bool>) = Interop.mkAngularaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: System.DateTime) = Interop.mkAngularaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: int) = Interop.mkAngularaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<int>) = Interop.mkAngularaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: float) = Interop.mkAngularaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<float>) = Interop.mkAngularaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: string) = Interop.mkAngularaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<string>) = Interop.mkAngularaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkAngularaxisAttr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkAngularaxisAttr "tickangle" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkAngularaxisAttr "tickcolor" value
    /// Sets the tick font.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkAngularaxisAttr "tickfont" (createObj !!properties)
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkAngularaxisAttr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkAngularaxisAttr "tickformatstops" (createObj !!properties)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkAngularaxisAttr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkAngularaxisAttr "ticklen" value
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkAngularaxisAttr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkAngularaxisAttr "ticksuffix" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkAngularaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkAngularaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkAngularaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkAngularaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkAngularaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int []>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<PlotData>) = Interop.mkAngularaxisAttr "ticktext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool option>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime option>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int option>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float option>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string option>) = Interop.mkAngularaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkAngularaxisAttr "ticktextsrc" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkAngularaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTime) = Interop.mkAngularaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkAngularaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkAngularaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkAngularaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool list>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool []>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string list>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string []>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int list>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int []>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float list>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float []>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<PlotData>) = Interop.mkAngularaxisAttr "tickvals" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool option>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime option>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int option>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float option>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string option>) = Interop.mkAngularaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkAngularaxisAttr "tickvalssrc" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkAngularaxisAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkAngularaxisAttr "tickwidth" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkAngularaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkAngularaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkAngularaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkAngularaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: int) = Interop.mkAngularaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkAngularaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: float) = Interop.mkAngularaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkAngularaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (value: string) = Interop.mkAngularaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkAngularaxisAttr "uirevision" (values |> ResizeArray)
    /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
    static member inline visible (value: bool) = Interop.mkAngularaxisAttr "visible" value

[<Erase;RequireQualifiedAccess>]
module angularaxis =
    /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkAngularaxisAttr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkAngularaxisAttr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkAngularaxisAttr "categoryorder" "category descending"
        static member inline maxAscending = Interop.mkAngularaxisAttr "categoryorder" "max ascending"
        static member inline maxDescending = Interop.mkAngularaxisAttr "categoryorder" "max descending"
        static member inline meanAscending = Interop.mkAngularaxisAttr "categoryorder" "mean ascending"
        static member inline meanDescending = Interop.mkAngularaxisAttr "categoryorder" "mean descending"
        static member inline medianAscending = Interop.mkAngularaxisAttr "categoryorder" "median ascending"
        static member inline medianDescending = Interop.mkAngularaxisAttr "categoryorder" "median descending"
        static member inline minAscending = Interop.mkAngularaxisAttr "categoryorder" "min ascending"
        static member inline minDescending = Interop.mkAngularaxisAttr "categoryorder" "min descending"
        static member inline sumAscending = Interop.mkAngularaxisAttr "categoryorder" "sum ascending"
        static member inline sumDescending = Interop.mkAngularaxisAttr "categoryorder" "sum descending"
        static member inline totalAscending = Interop.mkAngularaxisAttr "categoryorder" "total ascending"
        static member inline totalDescending = Interop.mkAngularaxisAttr "categoryorder" "total descending"
        static member inline trace = Interop.mkAngularaxisAttr "categoryorder" "trace"

    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    [<Erase>]
    type color =
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgb (r,g,b) = Interop.mkAngularaxisAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgba (r,g,b,a) = Interop.mkAngularaxisAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline hsl (h,s,l) = Interop.mkAngularaxisAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the direction corresponding to positive angles.
    [<Erase>]
    type direction =
        static member inline clockwise = Interop.mkAngularaxisAttr "direction" "clockwise"
        static member inline counterclockwise = Interop.mkAngularaxisAttr "direction" "counterclockwise"

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkAngularaxisAttr "exponentformat" "B"
        static member inline E = Interop.mkAngularaxisAttr "exponentformat" "E"
        static member inline SI = Interop.mkAngularaxisAttr "exponentformat" "SI"
        static member inline e = Interop.mkAngularaxisAttr "exponentformat" "e"
        static member inline none = Interop.mkAngularaxisAttr "exponentformat" "none"
        static member inline power = Interop.mkAngularaxisAttr "exponentformat" "power"

    /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
    [<Erase>]
    type layer =
        static member inline aboveTraces = Interop.mkAngularaxisAttr "layer" "above traces"
        static member inline belowTraces = Interop.mkAngularaxisAttr "layer" "below traces"

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkAngularaxisAttr "showexponent" "all"
        static member inline first = Interop.mkAngularaxisAttr "showexponent" "first"
        static member inline last = Interop.mkAngularaxisAttr "showexponent" "last"
        static member inline none = Interop.mkAngularaxisAttr "showexponent" "none"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkAngularaxisAttr "showtickprefix" "all"
        static member inline first = Interop.mkAngularaxisAttr "showtickprefix" "first"
        static member inline last = Interop.mkAngularaxisAttr "showtickprefix" "last"
        static member inline none = Interop.mkAngularaxisAttr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkAngularaxisAttr "showticksuffix" "all"
        static member inline first = Interop.mkAngularaxisAttr "showticksuffix" "first"
        static member inline last = Interop.mkAngularaxisAttr "showticksuffix" "last"
        static member inline none = Interop.mkAngularaxisAttr "showticksuffix" "none"

    /// Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
    [<Erase>]
    type thetaunit =
        static member inline degrees = Interop.mkAngularaxisAttr "thetaunit" "degrees"
        static member inline radians = Interop.mkAngularaxisAttr "thetaunit" "radians"

    /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkAngularaxisAttr "tickmode" "array"
        static member inline auto = Interop.mkAngularaxisAttr "tickmode" "auto"
        static member inline linear = Interop.mkAngularaxisAttr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkAngularaxisAttr "ticks" ""
        static member inline inside = Interop.mkAngularaxisAttr "ticks" "inside"
        static member inline outside = Interop.mkAngularaxisAttr "ticks" "outside"

    /// Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
    [<Erase>]
    type type' =
        static member inline dash = Interop.mkAngularaxisAttr "type" "-"
        static member inline category = Interop.mkAngularaxisAttr "type" "category"
        static member inline linear = Interop.mkAngularaxisAttr "type" "linear"

