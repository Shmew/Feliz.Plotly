namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type histogram =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkHistogramAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkHistogramAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkHistogramAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkHistogramAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkHistogramAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkHistogramAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkHistogramAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkHistogramAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkHistogramAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkHistogramAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkHistogramAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkHistogramAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkHistogramAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkHistogramAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkHistogramAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkHistogramAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkHistogramAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkHistogramAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkHistogramAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkHistogramAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkHistogramAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkHistogramAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkHistogramAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkHistogramAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkHistogramAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkHistogramAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkHistogramAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkHistogramAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkHistogramAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkHistogramAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkHistogramAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkHistogramAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkHistogramAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkHistogramAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkHistogramAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkHistogramAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkHistogramAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkHistogramAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkHistogramAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkHistogramAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkHistogramAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkHistogramAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkHistogramAttr "selectedpoints" (values |> Array.ofSeq)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IHistogramProperty list) = Interop.mkHistogramAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkHistogramAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkHistogramAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkHistogramAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkHistogramAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkHistogramAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkHistogramAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkHistogramAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkHistogramAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkHistogramAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkHistogramAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkHistogramAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkHistogramAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkHistogramAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: bool) = Interop.mkHistogramAttr "x" value
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool>) = Interop.mkHistogramAttr "x" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: System.DateTime) = Interop.mkHistogramAttr "x" value
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<System.DateTime>) = Interop.mkHistogramAttr "x" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: int) = Interop.mkHistogramAttr "x" value
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int>) = Interop.mkHistogramAttr "x" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: float) = Interop.mkHistogramAttr "x" value
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float>) = Interop.mkHistogramAttr "x" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (value: string) = Interop.mkHistogramAttr "x" value
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string>) = Interop.mkHistogramAttr "x" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<bool>>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool list>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<bool []>) = Interop.mkHistogramAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<string>>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string list>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<string []>) = Interop.mkHistogramAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<int>>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int list>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<int []>) = Interop.mkHistogramAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<seq<float>>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float list>) = Interop.mkHistogramAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<float []>) = Interop.mkHistogramAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkHistogramAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the sample data to be binned on the x axis.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkHistogramAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: bool) = Interop.mkHistogramAttr "y" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool>) = Interop.mkHistogramAttr "y" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: System.DateTime) = Interop.mkHistogramAttr "y" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<System.DateTime>) = Interop.mkHistogramAttr "y" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: int) = Interop.mkHistogramAttr "y" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int>) = Interop.mkHistogramAttr "y" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: float) = Interop.mkHistogramAttr "y" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float>) = Interop.mkHistogramAttr "y" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (value: string) = Interop.mkHistogramAttr "y" value
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string>) = Interop.mkHistogramAttr "y" (values |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<bool>>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool list>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<bool []>) = Interop.mkHistogramAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<string>>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string list>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<string []>) = Interop.mkHistogramAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<int>>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int list>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<int []>) = Interop.mkHistogramAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<seq<float>>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float list>) = Interop.mkHistogramAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<float []>) = Interop.mkHistogramAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkHistogramAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the sample data to be binned on the y axis.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkHistogramAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
    static member inline text (value: string) = Interop.mkHistogramAttr "text" value
    /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
    static member inline text (values: seq<string>) = Interop.mkHistogramAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkHistogramAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkHistogramAttr "hovertext" (values |> Array.ofSeq)
    static member inline cumulative (properties: #ICumulativeProperty list) = Interop.mkHistogramAttr "cumulative" (createObj !!properties)
    /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `xbins.size` is provided.
    static member inline nbinsx (value: int) = Interop.mkHistogramAttr "nbinsx" value
    static member inline xbins (properties: #IXbinsProperty list) = Interop.mkHistogramAttr "xbins" (createObj !!properties)
    /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `ybins.size` is provided.
    static member inline nbinsy (value: int) = Interop.mkHistogramAttr "nbinsy" value
    static member inline ybins (properties: #IYbinsProperty list) = Interop.mkHistogramAttr "ybins" (createObj !!properties)
    /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobinx` is not needed. However, we accept `autobinx: true` or `false` and will update `xbins` accordingly before deleting `autobinx` from the trace.
    static member inline autobinx (value: bool) = Interop.mkHistogramAttr "autobinx" value
    /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobiny` is not needed. However, we accept `autobiny: true` or `false` and will update `ybins` accordingly before deleting `autobiny` from the trace.
    static member inline autobiny (value: bool) = Interop.mkHistogramAttr "autobiny" value
    /// Set a group of histogram traces which will have compatible bin settings. Note that traces on the same subplot and with the same *orientation* under `barmode` *stack*, *relative* and *group* are forced into the same bingroup, Using `bingroup`, traces under `barmode` *overlay* and on different axes (of the same axis type) can have compatible bin settings. Note that histogram and histogram2d* trace can share the same `bingroup`
    static member inline bingroup (value: string) = Interop.mkHistogramAttr "bingroup" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `binNumber` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkHistogramAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `binNumber` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkHistogramAttr "hovertemplate" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkHistogramAttr "marker" (createObj !!properties)
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkHistogramAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkHistogramAttr "alignmentgroup" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkHistogramAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkHistogramAttr "unselected" (createObj !!properties)
    static member inline errorX (properties: #IErrorXProperty list) = Interop.mkHistogramAttr "error_x" (createObj !!properties)
    static member inline errorY (properties: #IErrorYProperty list) = Interop.mkHistogramAttr "error_y" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkHistogramAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkHistogramAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkHistogramAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkHistogramAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkHistogramAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkHistogramAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkHistogramAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkHistogramAttr "ysrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkHistogramAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkHistogramAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkHistogramAttr "hovertemplatesrc" value

[<AutoOpen>]
module histogram =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkHistogramAttr "visible" "legendonly"
        static member inline false' = Interop.mkHistogramAttr "visible" "false"
        static member inline true' = Interop.mkHistogramAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkHistogramAttr "hoverinfo" "all"
        static member inline none = Interop.mkHistogramAttr "hoverinfo" "none"
        static member inline skip = Interop.mkHistogramAttr "hoverinfo" "skip"
        static member inline name = Interop.mkHistogramAttr "hoverinfo" "name"
        static member inline text = Interop.mkHistogramAttr "hoverinfo" "text"
        static member inline x = Interop.mkHistogramAttr "hoverinfo" "x"
        static member inline y = Interop.mkHistogramAttr "hoverinfo" "y"
        static member inline z = Interop.mkHistogramAttr "hoverinfo" "z"

    /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkHistogramAttr "orientation" "h"
        static member inline v = Interop.mkHistogramAttr "orientation" "v"

    /// Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
    [<Erase>]
    type histfunc =
        static member inline avg = Interop.mkHistogramAttr "histfunc" "avg"
        static member inline count = Interop.mkHistogramAttr "histfunc" "count"
        static member inline max = Interop.mkHistogramAttr "histfunc" "max"
        static member inline min = Interop.mkHistogramAttr "histfunc" "min"
        static member inline sum = Interop.mkHistogramAttr "histfunc" "sum"

    /// Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
    [<Erase>]
    type histnorm =
        static member inline none = Interop.mkHistogramAttr "histnorm" ""
        static member inline density = Interop.mkHistogramAttr "histnorm" "density"
        static member inline percent = Interop.mkHistogramAttr "histnorm" "percent"
        static member inline probabilityDensity = Interop.mkHistogramAttr "histnorm" "probability density"
        static member inline probability = Interop.mkHistogramAttr "histnorm" "probability"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkHistogramAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkHistogramAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkHistogramAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkHistogramAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkHistogramAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkHistogramAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkHistogramAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkHistogramAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkHistogramAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkHistogramAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkHistogramAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkHistogramAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkHistogramAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkHistogramAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkHistogramAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkHistogramAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkHistogramAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkHistogramAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkHistogramAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkHistogramAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkHistogramAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkHistogramAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkHistogramAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkHistogramAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkHistogramAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkHistogramAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkHistogramAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkHistogramAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkHistogramAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkHistogramAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkHistogramAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkHistogramAttr "ycalendar" "ummalqura"

