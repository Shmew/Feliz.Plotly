namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type yaxis =
    /// Determines whether long tick labels automatically grow the figure margins.
    static member inline automargin (value: bool) = Interop.mkYaxisAttr "automargin" value
    /// Sets the background color of this axis' wall.
    static member inline backgroundcolor (value: string) = Interop.mkYaxisAttr "backgroundcolor" value
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkYaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTime) = Interop.mkYaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkYaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkYaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkYaxisAttr "categoryarray" (value |> Array.singleton)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<bool>>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool list>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool []>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<string>>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string list>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string []>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<int>>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int list>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int []>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<float>>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float list>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float []>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<PlotData>) = Interop.mkYaxisAttr "categoryarray" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool option>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime option>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float option>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string option>) = Interop.mkYaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkYaxisAttr "categoryarraysrc" value
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkYaxisAttr "color" value
    /// Sets the color of the dividers Only has an effect on *multicategory* axes.
    static member inline dividercolor (value: string) = Interop.mkYaxisAttr "dividercolor" value
    /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
    static member inline dividerwidth (value: int) = Interop.mkYaxisAttr "dividerwidth" value
    /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
    static member inline dividerwidth (value: float) = Interop.mkYaxisAttr "dividerwidth" value
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (value: int) = Interop.mkYaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (values: seq<int>) = Interop.mkYaxisAttr "domain" (values |> ResizeArray)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (value: float) = Interop.mkYaxisAttr "domain" (value |> Array.singleton |> ResizeArray)
    /// Sets the domain of this axis (in plot fraction).
    static member inline domain (values: seq<float>) = Interop.mkYaxisAttr "domain" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: bool) = Interop.mkYaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<bool>) = Interop.mkYaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: System.DateTime) = Interop.mkYaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<System.DateTime>) = Interop.mkYaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: int) = Interop.mkYaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<int>) = Interop.mkYaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: float) = Interop.mkYaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<float>) = Interop.mkYaxisAttr "dtick" (values |> ResizeArray)
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (value: string) = Interop.mkYaxisAttr "dtick" value
    /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
    static member inline dtick (values: seq<string>) = Interop.mkYaxisAttr "dtick" (values |> ResizeArray)
    /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
    static member inline fixedrange (value: bool) = Interop.mkYaxisAttr "fixedrange" value
    /// Sets the color of the grid lines.
    static member inline gridcolor (value: string) = Interop.mkYaxisAttr "gridcolor" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: int) = Interop.mkYaxisAttr "gridwidth" value
    /// Sets the width (in px) of the grid lines.
    static member inline gridwidth (value: float) = Interop.mkYaxisAttr "gridwidth" value
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline hoverformat (value: string) = Interop.mkYaxisAttr "hoverformat" value
    /// Sets the axis line color.
    static member inline linecolor (value: string) = Interop.mkYaxisAttr "linecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: int) = Interop.mkYaxisAttr "linewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: float) = Interop.mkYaxisAttr "linewidth" value
    /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
    static member inline matches (value: string) = Interop.mkYaxisAttr "matches" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkYaxisAttr "nticks" value
    /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
    static member inline position (value: int) = Interop.mkYaxisAttr "position" value
    /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
    static member inline position (value: float) = Interop.mkYaxisAttr "position" value
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: bool) = Interop.mkYaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<bool>) = Interop.mkYaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: System.DateTime) = Interop.mkYaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<System.DateTime>) = Interop.mkYaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: float) = Interop.mkYaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<float>) = Interop.mkYaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: int) = Interop.mkYaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<int>) = Interop.mkYaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: string) = Interop.mkYaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<string>) = Interop.mkYaxisAttr "range" (values |> ResizeArray)
    static member inline rangebreaks (properties: #IRangebreaksProperty list) = Interop.mkYaxisAttr "rangebreaks" (createObj !!properties)
    /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
    static member inline scaleratio (value: int) = Interop.mkYaxisAttr "scaleratio" value
    /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
    static member inline scaleratio (value: float) = Interop.mkYaxisAttr "scaleratio" value
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkYaxisAttr "separatethousands" value
    /// Sets whether or not this axis is labeled
    static member inline showaxeslabels (value: bool) = Interop.mkYaxisAttr "showaxeslabels" value
    /// Sets whether or not this axis' wall has a background color.
    static member inline showbackground (value: bool) = Interop.mkYaxisAttr "showbackground" value
    /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
    static member inline showdividers (value: bool) = Interop.mkYaxisAttr "showdividers" value
    /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
    static member inline showgrid (value: bool) = Interop.mkYaxisAttr "showgrid" value
    /// Determines whether or not a line bounding this axis is drawn.
    static member inline showline (value: bool) = Interop.mkYaxisAttr "showline" value
    /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
    static member inline showspikes (value: bool) = Interop.mkYaxisAttr "showspikes" value
    /// Determines whether or not the tick labels are drawn.
    static member inline showticklabels (value: bool) = Interop.mkYaxisAttr "showticklabels" value
    /// Sets the spike color. If undefined, will use the series color
    static member inline spikecolor (value: string) = Interop.mkYaxisAttr "spikecolor" value
    /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
    static member inline spikemode (properties: #IYaxisProperty list) = Interop.mkYaxisAttr "spikemode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
    static member inline spikesides (value: bool) = Interop.mkYaxisAttr "spikesides" value
    /// Sets the width (in px) of the zero line.
    static member inline spikethickness (value: int) = Interop.mkYaxisAttr "spikethickness" value
    /// Sets the width (in px) of the zero line.
    static member inline spikethickness (value: float) = Interop.mkYaxisAttr "spikethickness" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: bool) = Interop.mkYaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<bool>) = Interop.mkYaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: System.DateTime) = Interop.mkYaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<System.DateTime>) = Interop.mkYaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: int) = Interop.mkYaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<int>) = Interop.mkYaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: float) = Interop.mkYaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<float>) = Interop.mkYaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (value: string) = Interop.mkYaxisAttr "tick0" value
    /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline tick0 (values: seq<string>) = Interop.mkYaxisAttr "tick0" (values |> ResizeArray)
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkYaxisAttr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkYaxisAttr "tickangle" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkYaxisAttr "tickcolor" value
    /// Sets the tick font.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkYaxisAttr "tickfont" (createObj !!properties)
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkYaxisAttr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkYaxisAttr "tickformatstops" (createObj !!properties)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkYaxisAttr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkYaxisAttr "ticklen" value
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkYaxisAttr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkYaxisAttr "ticksuffix" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkYaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkYaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkYaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkYaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkYaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int []>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<PlotData>) = Interop.mkYaxisAttr "ticktext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool option>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime option>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int option>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float option>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string option>) = Interop.mkYaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkYaxisAttr "ticktextsrc" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkYaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTime) = Interop.mkYaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkYaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkYaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkYaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool list>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool []>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string list>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string []>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int list>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int []>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float list>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float []>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<PlotData>) = Interop.mkYaxisAttr "tickvals" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool option>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime option>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int option>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float option>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string option>) = Interop.mkYaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkYaxisAttr "tickvalssrc" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkYaxisAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkYaxisAttr "tickwidth" value
    static member inline title (properties: #ITitleProperty list) = Interop.mkYaxisAttr "title" (createObj !!properties)
    static member inline title (value: string) = Interop.mkYaxisAttr "title" (createObj !!((Interop.mkTitleAttr "text" value) |> Array.singleton))
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkYaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkYaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkYaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkYaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkYaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkYaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkYaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkYaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkYaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkYaxisAttr "uirevision" (values |> ResizeArray)
    /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
    static member inline visible (value: bool) = Interop.mkYaxisAttr "visible" value
    /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
    static member inline zeroline (value: bool) = Interop.mkYaxisAttr "zeroline" value
    /// Sets the line color of the zero line.
    static member inline zerolinecolor (value: string) = Interop.mkYaxisAttr "zerolinecolor" value
    /// Sets the width (in px) of the zero line.
    static member inline zerolinewidth (value: int) = Interop.mkYaxisAttr "zerolinewidth" value
    /// Sets the width (in px) of the zero line.
    static member inline zerolinewidth (value: float) = Interop.mkYaxisAttr "zerolinewidth" value

[<Erase;RequireQualifiedAccess>]
module yaxis =
    /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
    [<Erase>]
    type anchor =
        static member inline free = Interop.mkYaxisAttr "anchor" "free"
        static member inline custom (value: string) = Interop.mkYaxisAttr "anchor" value
        static member inline x (anchorId: int) = Interop.mkYaxisAttr "anchor" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
        static member inline y (anchorId: int) = Interop.mkYaxisAttr "anchor" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
    [<Erase>]
    type autorange =
        static member inline reversed = Interop.mkYaxisAttr "autorange" "reversed"
        static member inline false' = Interop.mkYaxisAttr "autorange" false
        static member inline true' = Interop.mkYaxisAttr "autorange" true

    /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
    [<Erase>]
    type calendar =
        static member inline chinese = Interop.mkYaxisAttr "calendar" "chinese"
        static member inline coptic = Interop.mkYaxisAttr "calendar" "coptic"
        static member inline discworld = Interop.mkYaxisAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkYaxisAttr "calendar" "ethiopian"
        static member inline gregorian = Interop.mkYaxisAttr "calendar" "gregorian"
        static member inline hebrew = Interop.mkYaxisAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkYaxisAttr "calendar" "islamic"
        static member inline jalali = Interop.mkYaxisAttr "calendar" "jalali"
        static member inline julian = Interop.mkYaxisAttr "calendar" "julian"
        static member inline mayan = Interop.mkYaxisAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkYaxisAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkYaxisAttr "calendar" "nepali"
        static member inline persian = Interop.mkYaxisAttr "calendar" "persian"
        static member inline taiwan = Interop.mkYaxisAttr "calendar" "taiwan"
        static member inline thai = Interop.mkYaxisAttr "calendar" "thai"
        static member inline ummalqura = Interop.mkYaxisAttr "calendar" "ummalqura"

    /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkYaxisAttr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkYaxisAttr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkYaxisAttr "categoryorder" "category descending"
        static member inline maxAscending = Interop.mkYaxisAttr "categoryorder" "max ascending"
        static member inline maxDescending = Interop.mkYaxisAttr "categoryorder" "max descending"
        static member inline meanAscending = Interop.mkYaxisAttr "categoryorder" "mean ascending"
        static member inline meanDescending = Interop.mkYaxisAttr "categoryorder" "mean descending"
        static member inline medianAscending = Interop.mkYaxisAttr "categoryorder" "median ascending"
        static member inline medianDescending = Interop.mkYaxisAttr "categoryorder" "median descending"
        static member inline minAscending = Interop.mkYaxisAttr "categoryorder" "min ascending"
        static member inline minDescending = Interop.mkYaxisAttr "categoryorder" "min descending"
        static member inline sumAscending = Interop.mkYaxisAttr "categoryorder" "sum ascending"
        static member inline sumDescending = Interop.mkYaxisAttr "categoryorder" "sum descending"
        static member inline totalAscending = Interop.mkYaxisAttr "categoryorder" "total ascending"
        static member inline totalDescending = Interop.mkYaxisAttr "categoryorder" "total descending"
        static member inline trace = Interop.mkYaxisAttr "categoryorder" "trace"

    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    [<Erase>]
    type color =
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgb (r,g,b) = Interop.mkYaxisAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgba (r,g,b,a) = Interop.mkYaxisAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline hsl (h,s,l) = Interop.mkYaxisAttr "color" (Feliz.color.hsl(h,s,l))

    /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
    [<Erase>]
    type constrain =
        static member inline domain = Interop.mkYaxisAttr "constrain" "domain"
        static member inline range = Interop.mkYaxisAttr "constrain" "range"

    /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
    [<Erase>]
    type constraintoward =
        static member inline bottom = Interop.mkYaxisAttr "constraintoward" "bottom"
        static member inline center = Interop.mkYaxisAttr "constraintoward" "center"
        static member inline left = Interop.mkYaxisAttr "constraintoward" "left"
        static member inline middle = Interop.mkYaxisAttr "constraintoward" "middle"
        static member inline right = Interop.mkYaxisAttr "constraintoward" "right"
        static member inline top = Interop.mkYaxisAttr "constraintoward" "top"

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkYaxisAttr "exponentformat" "B"
        static member inline E = Interop.mkYaxisAttr "exponentformat" "E"
        static member inline SI = Interop.mkYaxisAttr "exponentformat" "SI"
        static member inline e = Interop.mkYaxisAttr "exponentformat" "e"
        static member inline none = Interop.mkYaxisAttr "exponentformat" "none"
        static member inline power = Interop.mkYaxisAttr "exponentformat" "power"

    /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
    [<Erase>]
    type layer =
        static member inline aboveTraces = Interop.mkYaxisAttr "layer" "above traces"
        static member inline belowTraces = Interop.mkYaxisAttr "layer" "below traces"

    /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
    [<Erase>]
    type mirror =
        static member inline all = Interop.mkYaxisAttr "mirror" "all"
        static member inline allticks = Interop.mkYaxisAttr "mirror" "allticks"
        static member inline ticks = Interop.mkYaxisAttr "mirror" "ticks"
        static member inline false' = Interop.mkYaxisAttr "mirror" false
        static member inline true' = Interop.mkYaxisAttr "mirror" true

    /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
    [<Erase>]
    type overlaying =
        static member inline free = Interop.mkYaxisAttr "overlaying" "free"
        static member inline custom (value: string) = Interop.mkYaxisAttr "overlaying" value
        static member inline x (anchorId: int) = Interop.mkYaxisAttr "overlaying" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
        static member inline y (anchorId: int) = Interop.mkYaxisAttr "overlaying" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
    [<Erase>]
    type rangemode =
        static member inline auto = Interop.mkYaxisAttr "rangemode" "auto"
        static member inline fixed' = Interop.mkYaxisAttr "rangemode" "fixed"
        static member inline match' = Interop.mkYaxisAttr "rangemode" "match"
        static member inline nonnegative = Interop.mkYaxisAttr "rangemode" "nonnegative"
        static member inline normal = Interop.mkYaxisAttr "rangemode" "normal"
        static member inline tozero = Interop.mkYaxisAttr "rangemode" "tozero"

    /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
    [<Erase>]
    type scaleanchor =
        static member inline custom (value: string) = Interop.mkYaxisAttr "scaleanchor" value
        static member inline x (anchorId: int) = Interop.mkYaxisAttr "scaleanchor" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
        static member inline y (anchorId: int) = Interop.mkYaxisAttr "scaleanchor" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkYaxisAttr "showexponent" "all"
        static member inline first = Interop.mkYaxisAttr "showexponent" "first"
        static member inline last = Interop.mkYaxisAttr "showexponent" "last"
        static member inline none = Interop.mkYaxisAttr "showexponent" "none"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkYaxisAttr "showtickprefix" "all"
        static member inline first = Interop.mkYaxisAttr "showtickprefix" "first"
        static member inline last = Interop.mkYaxisAttr "showtickprefix" "last"
        static member inline none = Interop.mkYaxisAttr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkYaxisAttr "showticksuffix" "all"
        static member inline first = Interop.mkYaxisAttr "showticksuffix" "first"
        static member inline last = Interop.mkYaxisAttr "showticksuffix" "last"
        static member inline none = Interop.mkYaxisAttr "showticksuffix" "none"

    /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
    [<Erase>]
    type side =
        static member inline bottom = Interop.mkYaxisAttr "side" "bottom"
        static member inline left = Interop.mkYaxisAttr "side" "left"
        static member inline right = Interop.mkYaxisAttr "side" "right"
        static member inline top = Interop.mkYaxisAttr "side" "top"

    /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
    [<Erase>]
    type spikedash =
        static member inline dash = Interop.mkYaxisAttr "spikedash" "dash"
        static member inline dashdot = Interop.mkYaxisAttr "spikedash" "dashdot"
        static member inline dot = Interop.mkYaxisAttr "spikedash" "dot"
        static member inline longdash = Interop.mkYaxisAttr "spikedash" "longdash"
        static member inline longdashdot = Interop.mkYaxisAttr "spikedash" "longdashdot"
        static member inline solid = Interop.mkYaxisAttr "spikedash" "solid"
        static member inline custom (value: string) = Interop.mkYaxisAttr "spikedash" value

    /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
    [<Erase>]
    type spikemode =
        static member inline across = Interop.mkYaxisAttr "spikemode" "across"
        static member inline marker = Interop.mkYaxisAttr "spikemode" "marker"
        static member inline toaxis = Interop.mkYaxisAttr "spikemode" "toaxis"

    /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
    [<Erase>]
    type spikesnap =
        static member inline cursor = Interop.mkYaxisAttr "spikesnap" "cursor"
        static member inline data = Interop.mkYaxisAttr "spikesnap" "data"
        static member inline hoveredData = Interop.mkYaxisAttr "spikesnap" "hovered data"

    /// Determines where tick labels are drawn with respect to their corresponding ticks and grid lines. Only has an effect for axes of `type` *date* When set to *period*, tick labels are drawn in the middle of the period between ticks.
    [<Erase>]
    type ticklabelmode =
        static member inline instant = Interop.mkYaxisAttr "ticklabelmode" "instant"
        static member inline period = Interop.mkYaxisAttr "ticklabelmode" "period"

    /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkYaxisAttr "tickmode" "array"
        static member inline auto = Interop.mkYaxisAttr "tickmode" "auto"
        static member inline linear = Interop.mkYaxisAttr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkYaxisAttr "ticks" ""
        static member inline inside = Interop.mkYaxisAttr "ticks" "inside"
        static member inline outside = Interop.mkYaxisAttr "ticks" "outside"

    /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
    [<Erase>]
    type tickson =
        static member inline boundaries = Interop.mkYaxisAttr "tickson" "boundaries"
        static member inline labels = Interop.mkYaxisAttr "tickson" "labels"

    /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
    [<Erase>]
    type type' =
        static member inline dash = Interop.mkYaxisAttr "type" "-"
        static member inline category = Interop.mkYaxisAttr "type" "category"
        static member inline date = Interop.mkYaxisAttr "type" "date"
        static member inline linear = Interop.mkYaxisAttr "type" "linear"
        static member inline log = Interop.mkYaxisAttr "type" "log"
        static member inline multicategory = Interop.mkYaxisAttr "type" "multicategory"

