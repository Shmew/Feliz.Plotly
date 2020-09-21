namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type rangebreak =
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<string>) = Interop.mkRangebreakAttr "bounds" (values |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<float>) = Interop.mkRangebreakAttr "bounds" (values |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<int>) = Interop.mkRangebreakAttr "bounds" (values |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (days: seq<System.DayOfWeek>) = Interop.mkRangebreakAttr "bounds" (unbox<seq<int>> days)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<string option>) = Interop.mkRangebreakAttr "bounds" (values |> Seq.map (Option.defaultValue null) |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<float option>) = Interop.mkRangebreakAttr "bounds" (values |> Seq.map (Option.defaultValue (unbox<float> null)) |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (values: seq<int option>) = Interop.mkRangebreakAttr "bounds" (values |> Seq.map (Option.defaultValue (unbox<int> null)) |> ResizeArray)
    /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
    static member inline bounds (days: seq<System.DayOfWeek option>) = Interop.mkRangebreakAttr "bounds" (unbox<seq<int option>> days |> Seq.map (Option.defaultValue (unbox<int> null)) |> ResizeArray)
    /// Sets the size of each `values` item. The default is one day in milliseconds.
    static member inline dvalue (value: int) = Interop.mkRangebreakAttr "dvalue" value
    /// Sets the size of each `values` item. The default is one day in milliseconds.
    static member inline dvalue (value: float) = Interop.mkRangebreakAttr "dvalue" value
    /// Determines whether this axis rangebreak is enabled or disabled. Please note that `rangebreaks` only work for *date* axis type.
    static member inline enabled (value: bool) = Interop.mkRangebreakAttr "enabled" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkRangebreakAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkRangebreakAttr "templateitemname" value
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (value: bool) = Interop.mkRangebreakAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (values: seq<bool>) = Interop.mkRangebreakAttr "values" (values |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (value: System.DateTime) = Interop.mkRangebreakAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (values: seq<System.DateTime>) = Interop.mkRangebreakAttr "values" (values |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (value: float) = Interop.mkRangebreakAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (values: seq<float>) = Interop.mkRangebreakAttr "values" (values |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (value: int) = Interop.mkRangebreakAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (values: seq<int>) = Interop.mkRangebreakAttr "values" (values |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (value: string) = Interop.mkRangebreakAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
    static member inline values (values: seq<string>) = Interop.mkRangebreakAttr "values" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module rangebreak =
    /// Determines a pattern on the time line that generates breaks. If *day of week* - days of the week in English e.g. 'Sunday' or `sun` (matching is case-insensitive and considers only the first three characters), as well as Sunday-based integers between 0 and 6. If *hour* - hour (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples: - { pattern: 'day of week', bounds: [6, 1] }  or simply { bounds: ['sat', 'mon'] }   breaks from Saturday to Monday (i.e. skips the weekends). - { pattern: 'hour', bounds: [17, 8] }   breaks from 5pm to 8am (i.e. skips non-work hours).
    [<Erase>]
    type pattern =
        static member inline none = Interop.mkRangebreakAttr "pattern" ""
        static member inline dayOfWeek = Interop.mkRangebreakAttr "pattern" "day of week"
        static member inline hour = Interop.mkRangebreakAttr "pattern" "hour"

