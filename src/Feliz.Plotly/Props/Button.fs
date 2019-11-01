namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type button =
    /// Determines whether or not this button is visible.
    static member inline visible (value: bool) = Interop.mkButtonAttr "visible" value
    /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
    static member inline count (value: int) = Interop.mkButtonAttr "count" value
    /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
    static member inline count (value: float) = Interop.mkButtonAttr "count" value
    /// Sets the text label to appear on the button.
    static member inline label (value: string) = Interop.mkButtonAttr "label" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkButtonAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkButtonAttr "templateitemname" value
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (value: bool) = Interop.mkButtonAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (values: seq<bool>) = Interop.mkButtonAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (value: System.DateTime) = Interop.mkButtonAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (values: seq<System.DateTime>) = Interop.mkButtonAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (value: int) = Interop.mkButtonAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (values: seq<int>) = Interop.mkButtonAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (value: float) = Interop.mkButtonAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (values: seq<float>) = Interop.mkButtonAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (value: string) = Interop.mkButtonAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
    static member inline args (values: seq<string>) = Interop.mkButtonAttr "args" (values |> ResizeArray)
    /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_buttonclicked` method and executing the API command manually without losing the benefit of the updatemenu automatically binding to the state of the plot through the specification of `method` and `args`.
    static member inline execute (value: bool) = Interop.mkButtonAttr "execute" value

[<AutoOpen>]
module button =
    /// The unit of measurement that the `count` value will set the range by.
    [<Erase>]
    type step =
        static member inline all = Interop.mkButtonAttr "step" "all"
        static member inline day = Interop.mkButtonAttr "step" "day"
        static member inline hour = Interop.mkButtonAttr "step" "hour"
        static member inline minute = Interop.mkButtonAttr "step" "minute"
        static member inline month = Interop.mkButtonAttr "step" "month"
        static member inline second = Interop.mkButtonAttr "step" "second"
        static member inline year = Interop.mkButtonAttr "step" "year"

    /// Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar.
    [<Erase>]
    type stepmode =
        static member inline backward = Interop.mkButtonAttr "stepmode" "backward"
        static member inline todate = Interop.mkButtonAttr "stepmode" "todate"

    /// Sets the Plotly method to be called on click. If the `skip` method is used, the API updatemenu will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to updatemenu events manually via JavaScript.
    [<Erase>]
    type method =
        static member inline animate = Interop.mkButtonAttr "method" "animate"
        static member inline relayout = Interop.mkButtonAttr "method" "relayout"
        static member inline restyle = Interop.mkButtonAttr "method" "restyle"
        static member inline skip = Interop.mkButtonAttr "method" "skip"
        static member inline update = Interop.mkButtonAttr "method" "update"

