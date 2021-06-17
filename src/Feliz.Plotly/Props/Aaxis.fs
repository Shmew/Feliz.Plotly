namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type aaxis =
    /// The stride between grid lines along the axis
    static member inline arraydtick (value: int) = Interop.mkAaxisAttr "arraydtick" value
    /// The starting index of grid lines along the axis
    static member inline arraytick0 (value: int) = Interop.mkAaxisAttr "arraytick0" value
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTime) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTimeOffset) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTimeOffset>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkAaxisAttr "categoryarray" (value |> Array.singleton |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<bool>>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool list>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool []>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<string>>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string list>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string []>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<int>>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int list>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int []>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<float>>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float list>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float []>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<PlotData>) = Interop.mkAaxisAttr "categoryarray" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTimeOffset option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string option>) = Interop.mkAaxisAttr "categoryarray" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkAaxisAttr "categoryarraysrc" value
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkAaxisAttr "color" value
    /// The stride between grid lines along the axis
    static member inline dtick (value: int) = Interop.mkAaxisAttr "dtick" value
    /// The stride between grid lines along the axis
    static member inline dtick (value: float) = Interop.mkAaxisAttr "dtick" value
    /// Determines whether or not a line is drawn at along the final value of this axis. If *true*, the end line is drawn on top of the grid lines.
    static member inline endline (value: bool) = Interop.mkAaxisAttr "endline" value
    /// Sets the line color of the end line.
    static member inline endlinecolor (value: string) = Interop.mkAaxisAttr "endlinecolor" value
    /// Sets the width (in px) of the end line.
    static member inline endlinewidth (value: int) = Interop.mkAaxisAttr "endlinewidth" value
    /// Sets the width (in px) of the end line.
    static member inline endlinewidth (value: float) = Interop.mkAaxisAttr "endlinewidth" value
    /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
    static member inline fixedrange (value: bool) = Interop.mkAaxisAttr "fixedrange" value
    /// Sets the axis line color.
    static member inline gridcolor (value: string) = Interop.mkAaxisAttr "gridcolor" value
    /// Sets the width (in px) of the axis line.
    static member inline gridwidth (value: int) = Interop.mkAaxisAttr "gridwidth" value
    /// Sets the width (in px) of the axis line.
    static member inline gridwidth (value: float) = Interop.mkAaxisAttr "gridwidth" value
    /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline hoverformat (value: string) = Interop.mkAaxisAttr "hoverformat" value
    /// Extra padding between label and the axis
    static member inline labelpadding (value: int) = Interop.mkAaxisAttr "labelpadding" value
    /// Sets a axis label prefix.
    static member inline labelprefix (value: string) = Interop.mkAaxisAttr "labelprefix" value
    /// Sets a axis label suffix.
    static member inline labelsuffix (value: string) = Interop.mkAaxisAttr "labelsuffix" value
    /// Sets the axis line color.
    static member inline linecolor (value: string) = Interop.mkAaxisAttr "linecolor" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: int) = Interop.mkAaxisAttr "linewidth" value
    /// Sets the width (in px) of the axis line.
    static member inline linewidth (value: float) = Interop.mkAaxisAttr "linewidth" value
    /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
    static member inline min (value: int) = Interop.mkAaxisAttr "min" value
    /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
    static member inline min (value: float) = Interop.mkAaxisAttr "min" value
    /// Hide SI prefix for 10^n if |n| is below this number
    static member inline minexponent (value: int) = Interop.mkAaxisAttr "minexponent" value
    /// Hide SI prefix for 10^n if |n| is below this number
    static member inline minexponent (value: float) = Interop.mkAaxisAttr "minexponent" value
    /// Sets the color of the grid lines.
    static member inline minorgridcolor (value: string) = Interop.mkAaxisAttr "minorgridcolor" value
    /// Sets the number of minor grid ticks per major grid tick
    static member inline minorgridcount (value: int) = Interop.mkAaxisAttr "minorgridcount" value
    /// Sets the width (in px) of the grid lines.
    static member inline minorgridwidth (value: int) = Interop.mkAaxisAttr "minorgridwidth" value
    /// Sets the width (in px) of the grid lines.
    static member inline minorgridwidth (value: float) = Interop.mkAaxisAttr "minorgridwidth" value
    /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
    static member inline nticks (value: int) = Interop.mkAaxisAttr "nticks" value
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: bool) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<bool>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: System.DateTime) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: System.DateTimeOffset) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<System.DateTime>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<System.DateTimeOffset>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: float) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<float>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: int) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<int>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (value: string) = Interop.mkAaxisAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
    static member inline range (values: seq<string>) = Interop.mkAaxisAttr "range" (values |> ResizeArray)
    /// If \"true\", even 4-digit integers are separated
    static member inline separatethousands (value: bool) = Interop.mkAaxisAttr "separatethousands" value
    /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
    static member inline showgrid (value: bool) = Interop.mkAaxisAttr "showgrid" value
    /// Determines whether or not a line bounding this axis is drawn.
    static member inline showline (value: bool) = Interop.mkAaxisAttr "showline" value
    static member inline smoothing (value: int) = Interop.mkAaxisAttr "smoothing" value
    static member inline smoothing (value: float) = Interop.mkAaxisAttr "smoothing" value
    /// Determines whether or not a line is drawn at along the starting value of this axis. If *true*, the start line is drawn on top of the grid lines.
    static member inline startline (value: bool) = Interop.mkAaxisAttr "startline" value
    /// Sets the line color of the start line.
    static member inline startlinecolor (value: string) = Interop.mkAaxisAttr "startlinecolor" value
    /// Sets the width (in px) of the start line.
    static member inline startlinewidth (value: int) = Interop.mkAaxisAttr "startlinewidth" value
    /// Sets the width (in px) of the start line.
    static member inline startlinewidth (value: float) = Interop.mkAaxisAttr "startlinewidth" value
    /// The starting index of grid lines along the axis
    static member inline tick0 (value: int) = Interop.mkAaxisAttr "tick0" value
    /// The starting index of grid lines along the axis
    static member inline tick0 (value: float) = Interop.mkAaxisAttr "tick0" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: int) = Interop.mkAaxisAttr "tickangle" value
    /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
    static member inline tickangle (value: float) = Interop.mkAaxisAttr "tickangle" value
    /// Sets the tick color.
    static member inline tickcolor (value: string) = Interop.mkAaxisAttr "tickcolor" value
    /// Sets the tick font.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkAaxisAttr "tickfont" (createObj !!properties)
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-time-format#locale_format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkAaxisAttr "tickformat" value
    static member inline tickformatstops (properties: #ITickformatstopsProperty list) = Interop.mkAaxisAttr "tickformatstops" (createObj !!properties)
    /// Sets the tick length (in px).
    static member inline ticklen (value: int) = Interop.mkAaxisAttr "ticklen" value
    /// Sets the tick length (in px).
    static member inline ticklen (value: float) = Interop.mkAaxisAttr "ticklen" value
    /// Sets a tick label prefix.
    static member inline tickprefix (value: string) = Interop.mkAaxisAttr "tickprefix" value
    /// Sets a tick label suffix.
    static member inline ticksuffix (value: string) = Interop.mkAaxisAttr "ticksuffix" value
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: System.DateTimeOffset) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTimeOffset>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: float) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: int) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (value: string) = Interop.mkAaxisAttr "ticktext" (value |> Array.singleton |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int []>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<PlotData>) = Interop.mkAaxisAttr "ticktext" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<bool option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTime option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<System.DateTimeOffset option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<int option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<float option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
    static member inline ticktext (values: seq<string option>) = Interop.mkAaxisAttr "ticktext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkAaxisAttr "ticktextsrc" value
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: bool) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTime) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: System.DateTimeOffset) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTimeOffset>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: float) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: int) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (value: string) = Interop.mkAaxisAttr "tickvals" (value |> Array.singleton |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool list>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool []>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string list>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string []>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int list>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int []>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float list>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float []>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<PlotData>) = Interop.mkAaxisAttr "tickvals" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<bool option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTime option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<System.DateTimeOffset option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<int option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<float option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
    static member inline tickvals (values: seq<string option>) = Interop.mkAaxisAttr "tickvals" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkAaxisAttr "tickvalssrc" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: int) = Interop.mkAaxisAttr "tickwidth" value
    /// Sets the tick width (in px).
    static member inline tickwidth (value: float) = Interop.mkAaxisAttr "tickwidth" value
    static member inline title (properties: #ITitleProperty list) = Interop.mkAaxisAttr "title" (createObj !!properties)
    static member inline title (value: string) = Interop.mkAaxisAttr "title" (createObj !!((Interop.mkTitleAttr "text" value) |> Array.singleton))
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: System.DateTimeOffset) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<System.DateTimeOffset>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: int) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: float) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (value: string) = Interop.mkAaxisAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkAaxisAttr "uirevision" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module aaxis =
    /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
    [<Erase>]
    type autorange =
        static member inline reversed = Interop.mkAaxisAttr "autorange" "reversed"
        static member inline false' = Interop.mkAaxisAttr "autorange" false
        static member inline true' = Interop.mkAaxisAttr "autorange" true

    /// Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers.
    [<Erase>]
    type autotypenumbers =
        static member inline convertTypes = Interop.mkAaxisAttr "autotypenumbers" "convert types"
        static member inline strict = Interop.mkAaxisAttr "autotypenumbers" "strict"

    /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkAaxisAttr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkAaxisAttr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkAaxisAttr "categoryorder" "category descending"
        static member inline trace = Interop.mkAaxisAttr "categoryorder" "trace"

    [<Erase>]
    type cheatertype =
        static member inline index = Interop.mkAaxisAttr "cheatertype" "index"
        static member inline value = Interop.mkAaxisAttr "cheatertype" "value"

    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    [<Erase>]
    type color =
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgb (r,g,b) = Interop.mkAaxisAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline rgba (r,g,b,a) = Interop.mkAaxisAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline hsl (h,s,l) = Interop.mkAaxisAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
    [<Erase>]
    type exponentformat =
        static member inline B = Interop.mkAaxisAttr "exponentformat" "B"
        static member inline E = Interop.mkAaxisAttr "exponentformat" "E"
        static member inline SI = Interop.mkAaxisAttr "exponentformat" "SI"
        static member inline e = Interop.mkAaxisAttr "exponentformat" "e"
        static member inline none = Interop.mkAaxisAttr "exponentformat" "none"
        static member inline power = Interop.mkAaxisAttr "exponentformat" "power"

    /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
    [<Erase>]
    type layer =
        static member inline aboveTraces = Interop.mkAaxisAttr "layer" "above traces"
        static member inline belowTraces = Interop.mkAaxisAttr "layer" "below traces"

    /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data.
    [<Erase>]
    type rangemode =
        static member inline nonnegative = Interop.mkAaxisAttr "rangemode" "nonnegative"
        static member inline normal = Interop.mkAaxisAttr "rangemode" "normal"
        static member inline tozero = Interop.mkAaxisAttr "rangemode" "tozero"

    /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
    [<Erase>]
    type showexponent =
        static member inline all = Interop.mkAaxisAttr "showexponent" "all"
        static member inline first = Interop.mkAaxisAttr "showexponent" "first"
        static member inline last = Interop.mkAaxisAttr "showexponent" "last"
        static member inline none = Interop.mkAaxisAttr "showexponent" "none"

    /// Determines whether axis labels are drawn on the low side, the high side, both, or neither side of the axis.
    [<Erase>]
    type showticklabels =
        static member inline both = Interop.mkAaxisAttr "showticklabels" "both"
        static member inline end' = Interop.mkAaxisAttr "showticklabels" "end"
        static member inline none = Interop.mkAaxisAttr "showticklabels" "none"
        static member inline start = Interop.mkAaxisAttr "showticklabels" "start"

    /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
    [<Erase>]
    type showtickprefix =
        static member inline all = Interop.mkAaxisAttr "showtickprefix" "all"
        static member inline first = Interop.mkAaxisAttr "showtickprefix" "first"
        static member inline last = Interop.mkAaxisAttr "showtickprefix" "last"
        static member inline none = Interop.mkAaxisAttr "showtickprefix" "none"

    /// Same as `showtickprefix` but for tick suffixes.
    [<Erase>]
    type showticksuffix =
        static member inline all = Interop.mkAaxisAttr "showticksuffix" "all"
        static member inline first = Interop.mkAaxisAttr "showticksuffix" "first"
        static member inline last = Interop.mkAaxisAttr "showticksuffix" "last"
        static member inline none = Interop.mkAaxisAttr "showticksuffix" "none"

    [<Erase>]
    type tickmode =
        static member inline array = Interop.mkAaxisAttr "tickmode" "array"
        static member inline auto = Interop.mkAaxisAttr "tickmode" "auto"
        static member inline linear = Interop.mkAaxisAttr "tickmode" "linear"

    /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
    [<Erase>]
    type ticks =
        static member inline none = Interop.mkAaxisAttr "ticks" ""
        static member inline inside = Interop.mkAaxisAttr "ticks" "inside"
        static member inline outside = Interop.mkAaxisAttr "ticks" "outside"

    /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
    [<Erase>]
    type type' =
        static member inline dash = Interop.mkAaxisAttr "type" "-"
        static member inline category = Interop.mkAaxisAttr "type" "category"
        static member inline date = Interop.mkAaxisAttr "type" "date"
        static member inline linear = Interop.mkAaxisAttr "type" "linear"

