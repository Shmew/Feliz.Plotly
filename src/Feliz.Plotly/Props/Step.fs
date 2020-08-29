namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type step =
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (value: bool) = Interop.mkStepAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (values: seq<bool>) = Interop.mkStepAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (value: System.DateTime) = Interop.mkStepAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (values: seq<System.DateTime>) = Interop.mkStepAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (value: float) = Interop.mkStepAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (values: seq<float>) = Interop.mkStepAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (value: int) = Interop.mkStepAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (values: seq<int>) = Interop.mkStepAttr "args" (values |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (value: string) = Interop.mkStepAttr "args" (value |> Array.singleton |> ResizeArray)
    /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
    static member inline args (values: seq<string>) = Interop.mkStepAttr "args" (values |> ResizeArray)
    /// Sets the background color of the arc.
    static member inline color (value: string) = Interop.mkStepAttr "color" value
    /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_sliderchange` method and executing the API command manually without losing the benefit of the slider automatically binding to the state of the plot through the specification of `method` and `args`.
    static member inline execute (value: bool) = Interop.mkStepAttr "execute" value
    /// Sets the text label to appear on the slider
    static member inline label (value: string) = Interop.mkStepAttr "label" value
    static member inline line (properties: #ILineProperty list) = Interop.mkStepAttr "line" (createObj !!properties)
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkStepAttr "name" value
    /// Sets the range of this axis.
    static member inline range (value: int) = Interop.mkStepAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis.
    static member inline range (values: seq<int>) = Interop.mkStepAttr "range" (values |> ResizeArray)
    /// Sets the range of this axis.
    static member inline range (value: float) = Interop.mkStepAttr "range" (value |> Array.singleton |> ResizeArray)
    /// Sets the range of this axis.
    static member inline range (values: seq<float>) = Interop.mkStepAttr "range" (values |> ResizeArray)
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkStepAttr "templateitemname" value
    /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
    static member inline thickness (value: int) = Interop.mkStepAttr "thickness" value
    /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
    static member inline thickness (value: float) = Interop.mkStepAttr "thickness" value
    /// Sets the value of the slider step, used to refer to the step programatically. Defaults to the slider label if not provided.
    static member inline value (value: string) = Interop.mkStepAttr "value" value
    /// Determines whether or not this step is included in the slider.
    static member inline visible (value: bool) = Interop.mkStepAttr "visible" value

[<Erase;RequireQualifiedAccess>]
module step =
    /// Sets the background color of the arc.
    [<Erase>]
    type color =
        /// Sets the background color of the arc.
        static member inline rgb (r,g,b) = Interop.mkStepAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the background color of the arc.
        static member inline rgba (r,g,b,a) = Interop.mkStepAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the background color of the arc.
        static member inline hsl (h,s,l) = Interop.mkStepAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript.
    [<Erase>]
    type method =
        static member inline animate = Interop.mkStepAttr "method" "animate"
        static member inline relayout = Interop.mkStepAttr "method" "relayout"
        static member inline restyle = Interop.mkStepAttr "method" "restyle"
        static member inline skip = Interop.mkStepAttr "method" "skip"
        static member inline update = Interop.mkStepAttr "method" "update"

