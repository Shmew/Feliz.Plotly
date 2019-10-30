namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type colorbar =
    /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
    static member inline thickness (value: int) = Interop.mkColorbarAttr "thickness" value
    /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
    static member inline thickness (value: float) = Interop.mkColorbarAttr "thickness" value
    /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
    static member inline len (value: int) = Interop.mkColorbarAttr "len" value
    /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
    static member inline len (value: float) = Interop.mkColorbarAttr "len" value
    /// Sets the x position of the color bar (in plot fraction).
    static member inline x (value: int) = Interop.mkColorbarAttr "x" value
    /// Sets the x position of the color bar (in plot fraction).
    static member inline x (value: float) = Interop.mkColorbarAttr "x" value
    /// Sets the amount of padding (in px) along the x direction.
    static member inline xpad (value: int) = Interop.mkColorbarAttr "xpad" value
    /// Sets the amount of padding (in px) along the x direction.
    static member inline xpad (value: float) = Interop.mkColorbarAttr "xpad" value
    /// Sets the y position of the color bar (in plot fraction).
    static member inline y (value: int) = Interop.mkColorbarAttr "y" value
    /// Sets the y position of the color bar (in plot fraction).
    static member inline y (value: float) = Interop.mkColorbarAttr "y" value
    /// Sets the amount of padding (in px) along the y direction.
    static member inline ypad (value: int) = Interop.mkColorbarAttr "ypad" value
    /// Sets the amount of padding (in px) along the y direction.
    static member inline ypad (value: float) = Interop.mkColorbarAttr "ypad" value
    /// Sets the axis line color.
    static member inline outlinecolor (value: string) = Interop.mkColorbarAttr "outlinecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline outlinewidth (value: int) = Interop.mkColorbarAttr "outlinewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline outlinewidth (value: float) = Interop.mkColorbarAttr "outlinewidth" value
    /// Sets the axis line color.
    static member inline bordercolor (value: string) = Interop.mkColorbarAttr "bordercolor" value
    /// Sets the width (in px) or the border enclosing this color bar.
    static member inline borderwidth (value: int) = Interop.mkColorbarAttr "borderwidth" value
    /// Sets the width (in px) or the border enclosing this color bar.
    static member inline borderwidth (value: float) = Interop.mkColorbarAttr "borderwidth" value
    /// Sets the color of padded area.
    static member inline bgcolor (value: string) = Interop.mkColorbarAttr "bgcolor" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkColorbarAttr "nticks" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: bool) = Interop.mkColorbarAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<bool>) = Interop.mkColorbarAttr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: System.DateTime) = Interop.mkColorbarAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<System.DateTime>) = Interop.mkColorbarAttr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: int) = Interop.mkColorbarAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<int>) = Interop.mkColorbarAttr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: float) = Interop.mkColorbarAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<float>) = Interop.mkColorbarAttr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: string) = Interop.mkColorbarAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<string>) = Interop.mkColorbarAttr "tick0" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: bool) = Interop.mkColorbarAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<bool>) = Interop.mkColorbarAttr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: System.DateTime) = Interop.mkColorbarAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<System.DateTime>) = Interop.mkColorbarAttr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: int) = Interop.mkColorbarAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<int>) = Interop.mkColorbarAttr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: float) = Interop.mkColorbarAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<float>) = Interop.mkColorbarAttr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: string) = Interop.mkColorbarAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<string>) = Interop.mkColorbarAttr "dtick" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkColorbarAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkColorbarAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTime) = Interop.mkColorbarAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkColorbarAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkColorbarAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkColorbarAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkColorbarAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkColorbarAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkColorbarAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkColorbarAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool list>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool []>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string list>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string []>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int list>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int []>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float list>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float []>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkColorbarAttr "tickvals" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkColorbarAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkColorbarAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkColorbarAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkColorbarAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkColorbarAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkColorbarAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkColorbarAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkColorbarAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkColorbarAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkColorbarAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int []>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkColorbarAttr "ticktext" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkColorbarAttr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkColorbarAttr "ticklen" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkColorbarAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkColorbarAttr "tickwidth" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkColorbarAttr "tickcolor" value
    /// Determines whether or not the tick labels are drawn.
    static member inline showticklabels (value: bool) = Interop.mkColorbarAttr "showticklabels" value
    /// Sets the color bar's tick label font
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkColorbarAttr "tickfont" (createObj !!properties)
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkColorbarAttr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkColorbarAttr "tickangle" value
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkColorbarAttr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkColorbarAttr "tickformatstops" (createObj !!properties)
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkColorbarAttr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkColorbarAttr "ticksuffix" value
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkColorbarAttr "separatethousands" value
    static member inline title (properties: #ITitleProperty list) = Interop.mkColorbarAttr "title" (createObj !!properties)
    /// Sets the source reference on plot.ly for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkColorbarAttr "tickvalssrc" value
    /// Sets the source reference on plot.ly for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkColorbarAttr "ticktextsrc" value

[<AutoOpen>]
module colorbar =
    /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
    [<Erase>]
    type thicknessmode =
        static member inline fraction = Interop.mkColorbarAttr "thicknessmode" "fraction"
        static member inline pixels = Interop.mkColorbarAttr "thicknessmode" "pixels"

    /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
    [<Erase>]
    type lenmode =
        static member inline fraction = Interop.mkColorbarAttr "lenmode" "fraction"
        static member inline pixels = Interop.mkColorbarAttr "lenmode" "pixels"

    /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
    [<Erase>]
    type xanchor =
        static member inline center = Interop.mkColorbarAttr "xanchor" "center"
        static member inline left = Interop.mkColorbarAttr "xanchor" "left"
        static member inline right = Interop.mkColorbarAttr "xanchor" "right"

    /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
    [<Erase>]
    type yanchor =
        static member inline bottom = Interop.mkColorbarAttr "yanchor" "bottom"
        static member inline middle = Interop.mkColorbarAttr "yanchor" "middle"
        static member inline top = Interop.mkColorbarAttr "yanchor" "top"

    /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkColorbarAttr "tickmode" "array"
        static member inline auto = Interop.mkColorbarAttr "tickmode" "auto"
        static member inline linear = Interop.mkColorbarAttr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkColorbarAttr "ticks" ""
        static member inline inside = Interop.mkColorbarAttr "ticks" "inside"
        static member inline outside = Interop.mkColorbarAttr "ticks" "outside"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkColorbarAttr "showtickprefix" "all"
        static member inline first = Interop.mkColorbarAttr "showtickprefix" "first"
        static member inline last = Interop.mkColorbarAttr "showtickprefix" "last"
        static member inline none = Interop.mkColorbarAttr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkColorbarAttr "showticksuffix" "all"
        static member inline first = Interop.mkColorbarAttr "showticksuffix" "first"
        static member inline last = Interop.mkColorbarAttr "showticksuffix" "last"
        static member inline none = Interop.mkColorbarAttr "showticksuffix" "none"

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkColorbarAttr "exponentformat" "B"
        static member inline E = Interop.mkColorbarAttr "exponentformat" "E"
        static member inline SI = Interop.mkColorbarAttr "exponentformat" "SI"
        static member inline e = Interop.mkColorbarAttr "exponentformat" "e"
        static member inline none = Interop.mkColorbarAttr "exponentformat" "none"
        static member inline power = Interop.mkColorbarAttr "exponentformat" "power"

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkColorbarAttr "showexponent" "all"
        static member inline first = Interop.mkColorbarAttr "showexponent" "first"
        static member inline last = Interop.mkColorbarAttr "showexponent" "last"
        static member inline none = Interop.mkColorbarAttr "showexponent" "none"

