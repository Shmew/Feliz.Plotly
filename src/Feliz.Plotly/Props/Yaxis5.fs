namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type yaxis5 =
    /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
    static member inline visible (value: bool) = Interop.mkYaxis5Attr "visible" value
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkYaxis5Attr "color" value
    static member inline title (properties: #ITitleProperty list) = Interop.mkYaxis5Attr "title" (createObj !!properties)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: bool) = Interop.mkYaxis5Attr "range" (value |> Array.singleton)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<bool>) = Interop.mkYaxis5Attr "range" (values |> Array.ofSeq)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: int) = Interop.mkYaxis5Attr "range" (value |> Array.singleton)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<int>) = Interop.mkYaxis5Attr "range" (values |> Array.ofSeq)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: float) = Interop.mkYaxis5Attr "range" (value |> Array.singleton)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<float>) = Interop.mkYaxis5Attr "range" (values |> Array.ofSeq)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: string) = Interop.mkYaxis5Attr "range" (value |> Array.singleton)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<string>) = Interop.mkYaxis5Attr "range" (values |> Array.ofSeq)
    /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
    static member inline fixedrange (value: bool) = Interop.mkYaxis5Attr "fixedrange" value
    /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
    static member inline scaleanchor (value: string) = Interop.mkYaxis5Attr "scaleanchor" value
    /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
    static member inline scaleratio (value: int) = Interop.mkYaxis5Attr "scaleratio" value
    /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
    static member inline scaleratio (value: float) = Interop.mkYaxis5Attr "scaleratio" value
    /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
    static member inline matches (value: string) = Interop.mkYaxis5Attr "matches" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkYaxis5Attr "nticks" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: bool) = Interop.mkYaxis5Attr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<bool>) = Interop.mkYaxis5Attr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: string) = Interop.mkYaxis5Attr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<string>) = Interop.mkYaxis5Attr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: int) = Interop.mkYaxis5Attr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<int>) = Interop.mkYaxis5Attr "tick0" (values |> Array.ofSeq)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: float) = Interop.mkYaxis5Attr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<float>) = Interop.mkYaxis5Attr "tick0" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: bool) = Interop.mkYaxis5Attr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<bool>) = Interop.mkYaxis5Attr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: string) = Interop.mkYaxis5Attr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<string>) = Interop.mkYaxis5Attr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: int) = Interop.mkYaxis5Attr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<int>) = Interop.mkYaxis5Attr "dtick" (values |> Array.ofSeq)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: float) = Interop.mkYaxis5Attr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<float>) = Interop.mkYaxis5Attr "dtick" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkYaxis5Attr "tickvals" (value |> Array.singleton)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkYaxis5Attr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkYaxis5Attr "tickvals" (value |> Array.singleton)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkYaxis5Attr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkYaxis5Attr "tickvals" (value |> Array.singleton)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkYaxis5Attr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkYaxis5Attr "tickvals" (value |> Array.singleton)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkYaxis5Attr "tickvals" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkYaxis5Attr "ticktext" (value |> Array.singleton)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkYaxis5Attr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkYaxis5Attr "ticktext" (value |> Array.singleton)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkYaxis5Attr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkYaxis5Attr "ticktext" (value |> Array.singleton)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkYaxis5Attr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkYaxis5Attr "ticktext" (value |> Array.singleton)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkYaxis5Attr "ticktext" (values |> Array.ofSeq)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkYaxis5Attr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkYaxis5Attr "ticklen" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkYaxis5Attr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkYaxis5Attr "tickwidth" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkYaxis5Attr "tickcolor" value
    /// Determines whether or not the tick labels are drawn.
    static member inline showticklabels (value: bool) = Interop.mkYaxis5Attr "showticklabels" value
    /// Determines whether long tick labels automatically grow the figure margins.
    static member inline automargin (value: bool) = Interop.mkYaxis5Attr "automargin" value
    /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
    static member inline showspikes (value: bool) = Interop.mkYaxis5Attr "showspikes" value
    /// Sets the spike color. If undefined, will use the series color
    static member inline spikecolor (value: string) = Interop.mkYaxis5Attr "spikecolor" value
    /// Sets the width (in px) of the zero line.
    static member inline spikethickness (value: int) = Interop.mkYaxis5Attr "spikethickness" value
    /// Sets the width (in px) of the zero line.
    static member inline spikethickness (value: float) = Interop.mkYaxis5Attr "spikethickness" value
    /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
    static member inline spikedash (value: string) = Interop.mkYaxis5Attr "spikedash" value
    /// Sets the tick font.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkYaxis5Attr "tickfont" (createObj !!properties)
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkYaxis5Attr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkYaxis5Attr "tickangle" value
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkYaxis5Attr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkYaxis5Attr "ticksuffix" value
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkYaxis5Attr "separatethousands" value
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkYaxis5Attr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkYaxis5Attr "tickformatstops" (createObj !!properties)
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline hoverformat (value: string) = Interop.mkYaxis5Attr "hoverformat" value
    /// Determines whether or not a line bounding this axis is drawn.
    static member inline showline (value: bool) = Interop.mkYaxis5Attr "showline" value
    /// Sets the axis line color.
    static member inline linecolor (value: string) = Interop.mkYaxis5Attr "linecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: int) = Interop.mkYaxis5Attr "linewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: float) = Interop.mkYaxis5Attr "linewidth" value
    /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
    static member inline showgrid (value: bool) = Interop.mkYaxis5Attr "showgrid" value
    /// Sets the color of the grid lines.
    static member inline gridcolor (value: string) = Interop.mkYaxis5Attr "gridcolor" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: int) = Interop.mkYaxis5Attr "gridwidth" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: float) = Interop.mkYaxis5Attr "gridwidth" value
    /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
    static member inline zeroline (value: bool) = Interop.mkYaxis5Attr "zeroline" value
    /// Sets the line color of the zero line.
    static member inline zerolinecolor (value: string) = Interop.mkYaxis5Attr "zerolinecolor" value
    /// Sets the width (in px) of the zero line.
    static member inline zerolinewidth (value: int) = Interop.mkYaxis5Attr "zerolinewidth" value
    /// Sets the width (in px) of the zero line.
    static member inline zerolinewidth (value: float) = Interop.mkYaxis5Attr "zerolinewidth" value
    /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
    static member inline showdividers (value: bool) = Interop.mkYaxis5Attr "showdividers" value
    /// Sets the color of the dividers Only has an effect on *multicategory* axes.
    static member inline dividercolor (value: string) = Interop.mkYaxis5Attr "dividercolor" value
    /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
    static member inline dividerwidth (value: int) = Interop.mkYaxis5Attr "dividerwidth" value
    /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
    static member inline dividerwidth (value: float) = Interop.mkYaxis5Attr "dividerwidth" value
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (value: int) = Interop.mkYaxis5Attr "domain" (value |> Array.singleton)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (values: seq<int>) = Interop.mkYaxis5Attr "domain" (values |> Array.ofSeq)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (value: float) = Interop.mkYaxis5Attr "domain" (value |> Array.singleton)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (values: seq<float>) = Interop.mkYaxis5Attr "domain" (values |> Array.ofSeq)
    /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
    static member inline position (value: int) = Interop.mkYaxis5Attr "position" value
    /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
    static member inline position (value: float) = Interop.mkYaxis5Attr "position" value
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkYaxis5Attr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkYaxis5Attr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkYaxis5Attr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkYaxis5Attr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkYaxis5Attr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkYaxis5Attr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkYaxis5Attr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkYaxis5Attr "categoryarray" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkYaxis5Attr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkYaxis5Attr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkYaxis5Attr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkYaxis5Attr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkYaxis5Attr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkYaxis5Attr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkYaxis5Attr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkYaxis5Attr "uirevision" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkYaxis5Attr "tickvalssrc" value
    /// Sets the source reference on plot.ly for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkYaxis5Attr "ticktextsrc" value
    /// Sets the source reference on plot.ly for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkYaxis5Attr "categoryarraysrc" value

[<AutoOpen>]
module yaxis5 =
    /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
    [<Erase>]
    type type' =
        static member inline dash = Interop.mkYaxis5Attr "type" "-"
        static member inline category = Interop.mkYaxis5Attr "type" "category"
        static member inline date = Interop.mkYaxis5Attr "type" "date"
        static member inline linear = Interop.mkYaxis5Attr "type" "linear"
        static member inline log = Interop.mkYaxis5Attr "type" "log"
        static member inline multicategory = Interop.mkYaxis5Attr "type" "multicategory"

    /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
    [<Erase>]
    type autorange =
        static member inline reversed = Interop.mkYaxis5Attr "autorange" "reversed"
        static member inline false' = Interop.mkYaxis5Attr "autorange" "false"
        static member inline true' = Interop.mkYaxis5Attr "autorange" "true"

    /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
    [<Erase>]
    type rangemode =
        static member inline nonnegative = Interop.mkYaxis5Attr "rangemode" "nonnegative"
        static member inline normal = Interop.mkYaxis5Attr "rangemode" "normal"
        static member inline tozero = Interop.mkYaxis5Attr "rangemode" "tozero"

    /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
    [<Erase>]
    type constrain =
        static member inline domain = Interop.mkYaxis5Attr "constrain" "domain"
        static member inline range = Interop.mkYaxis5Attr "constrain" "range"

    /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
    [<Erase>]
    type constraintoward =
        static member inline bottom = Interop.mkYaxis5Attr "constraintoward" "bottom"
        static member inline center = Interop.mkYaxis5Attr "constraintoward" "center"
        static member inline left = Interop.mkYaxis5Attr "constraintoward" "left"
        static member inline middle = Interop.mkYaxis5Attr "constraintoward" "middle"
        static member inline right = Interop.mkYaxis5Attr "constraintoward" "right"
        static member inline top = Interop.mkYaxis5Attr "constraintoward" "top"

    /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkYaxis5Attr "tickmode" "array"
        static member inline auto = Interop.mkYaxis5Attr "tickmode" "auto"
        static member inline linear = Interop.mkYaxis5Attr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkYaxis5Attr "ticks" ""
        static member inline inside = Interop.mkYaxis5Attr "ticks" "inside"
        static member inline outside = Interop.mkYaxis5Attr "ticks" "outside"

    /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
    [<Erase>]
    type tickson =
        static member inline boundaries = Interop.mkYaxis5Attr "tickson" "boundaries"
        static member inline labels = Interop.mkYaxis5Attr "tickson" "labels"

    /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
    [<Erase>]
    type mirror =
        static member inline all = Interop.mkYaxis5Attr "mirror" "all"
        static member inline allticks = Interop.mkYaxis5Attr "mirror" "allticks"
        static member inline ticks = Interop.mkYaxis5Attr "mirror" "ticks"
        static member inline false' = Interop.mkYaxis5Attr "mirror" "false"
        static member inline true' = Interop.mkYaxis5Attr "mirror" "true"

    /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
    [<Erase>]
    type spikemode =
        static member inline across = Interop.mkYaxis5Attr "spikemode" "across"
        static member inline acrossAndToaxis = Interop.mkYaxis5Attr "spikemode" "across+toaxis"
        static member inline marker = Interop.mkYaxis5Attr "spikemode" "marker"
        static member inline markerAndAcross = Interop.mkYaxis5Attr "spikemode" "marker+across"
        static member inline markerAndAcrossToaxis = Interop.mkYaxis5Attr "spikemode" "marker+across+toaxis"
        static member inline markerAndToaxis = Interop.mkYaxis5Attr "spikemode" "marker+toaxis"
        static member inline toaxis = Interop.mkYaxis5Attr "spikemode" "toaxis"

    /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
    [<Erase>]
    type spikesnap =
        static member inline cursor = Interop.mkYaxis5Attr "spikesnap" "cursor"
        static member inline data = Interop.mkYaxis5Attr "spikesnap" "data"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkYaxis5Attr "showtickprefix" "all"
        static member inline first = Interop.mkYaxis5Attr "showtickprefix" "first"
        static member inline last = Interop.mkYaxis5Attr "showtickprefix" "last"
        static member inline none = Interop.mkYaxis5Attr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkYaxis5Attr "showticksuffix" "all"
        static member inline first = Interop.mkYaxis5Attr "showticksuffix" "first"
        static member inline last = Interop.mkYaxis5Attr "showticksuffix" "last"
        static member inline none = Interop.mkYaxis5Attr "showticksuffix" "none"

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkYaxis5Attr "showexponent" "all"
        static member inline first = Interop.mkYaxis5Attr "showexponent" "first"
        static member inline last = Interop.mkYaxis5Attr "showexponent" "last"
        static member inline none = Interop.mkYaxis5Attr "showexponent" "none"

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkYaxis5Attr "exponentformat" "B"
        static member inline E = Interop.mkYaxis5Attr "exponentformat" "E"
        static member inline SI = Interop.mkYaxis5Attr "exponentformat" "SI"
        static member inline e = Interop.mkYaxis5Attr "exponentformat" "e"
        static member inline none = Interop.mkYaxis5Attr "exponentformat" "none"
        static member inline power = Interop.mkYaxis5Attr "exponentformat" "power"

    /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
    [<Erase>]
    type anchor =
        static member inline free = Interop.mkYaxis5Attr "anchor" "free"
        static member inline custom (value: string) = Interop.mkYaxis5Attr "anchor" value

    /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
    [<Erase>]
    type side =
        static member inline bottom = Interop.mkYaxis5Attr "side" "bottom"
        static member inline left = Interop.mkYaxis5Attr "side" "left"
        static member inline right = Interop.mkYaxis5Attr "side" "right"
        static member inline top = Interop.mkYaxis5Attr "side" "top"

    /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
    [<Erase>]
    type overlaying =
        static member inline free = Interop.mkYaxis5Attr "overlaying" "free"
        static member inline custom (value: string) = Interop.mkYaxis5Attr "overlaying" value

    /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
    [<Erase>]
    type layer =
        static member inline aboveTraces = Interop.mkYaxis5Attr "layer" "above traces"
        static member inline belowTraces = Interop.mkYaxis5Attr "layer" "below traces"

    /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkYaxis5Attr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkYaxis5Attr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkYaxis5Attr "categoryorder" "category descending"
        static member inline maxAscending = Interop.mkYaxis5Attr "categoryorder" "max ascending"
        static member inline maxDescending = Interop.mkYaxis5Attr "categoryorder" "max descending"
        static member inline meanAscending = Interop.mkYaxis5Attr "categoryorder" "mean ascending"
        static member inline meanDescending = Interop.mkYaxis5Attr "categoryorder" "mean descending"
        static member inline medianAscending = Interop.mkYaxis5Attr "categoryorder" "median ascending"
        static member inline medianDescending = Interop.mkYaxis5Attr "categoryorder" "median descending"
        static member inline minAscending = Interop.mkYaxis5Attr "categoryorder" "min ascending"
        static member inline minDescending = Interop.mkYaxis5Attr "categoryorder" "min descending"
        static member inline sumAscending = Interop.mkYaxis5Attr "categoryorder" "sum ascending"
        static member inline sumDescending = Interop.mkYaxis5Attr "categoryorder" "sum descending"
        static member inline totalAscending = Interop.mkYaxis5Attr "categoryorder" "total ascending"
        static member inline totalDescending = Interop.mkYaxis5Attr "categoryorder" "total descending"
        static member inline trace = Interop.mkYaxis5Attr "categoryorder" "trace"

    /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
    [<Erase>]
    type calendar =
        static member inline chinese = Interop.mkYaxis5Attr "calendar" "chinese"
        static member inline coptic = Interop.mkYaxis5Attr "calendar" "coptic"
        static member inline discworld = Interop.mkYaxis5Attr "calendar" "discworld"
        static member inline ethiopian = Interop.mkYaxis5Attr "calendar" "ethiopian"
        static member inline gregorian = Interop.mkYaxis5Attr "calendar" "gregorian"
        static member inline hebrew = Interop.mkYaxis5Attr "calendar" "hebrew"
        static member inline islamic = Interop.mkYaxis5Attr "calendar" "islamic"
        static member inline jalali = Interop.mkYaxis5Attr "calendar" "jalali"
        static member inline julian = Interop.mkYaxis5Attr "calendar" "julian"
        static member inline mayan = Interop.mkYaxis5Attr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkYaxis5Attr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkYaxis5Attr "calendar" "nepali"
        static member inline persian = Interop.mkYaxis5Attr "calendar" "persian"
        static member inline taiwan = Interop.mkYaxis5Attr "calendar" "taiwan"
        static member inline thai = Interop.mkYaxis5Attr "calendar" "thai"
        static member inline ummalqura = Interop.mkYaxis5Attr "calendar" "ummalqura"

