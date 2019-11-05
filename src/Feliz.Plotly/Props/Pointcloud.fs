namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type pointcloud =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkPointcloudAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkPointcloudAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkPointcloudAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkPointcloudAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkPointcloudAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkPointcloudAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkPointcloudAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkPointcloudAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkPointcloudAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkPointcloudAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkPointcloudAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option []>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkPointcloudAttr "ids" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkPointcloudAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkPointcloudAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkPointcloudAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkPointcloudAttr "ids" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkPointcloudAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkPointcloudAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkPointcloudAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkPointcloudAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkPointcloudAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option []>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkPointcloudAttr "customdata" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkPointcloudAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkPointcloudAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkPointcloudAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkPointcloudAttr "customdata" (values |> ResizeArray)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IPointcloudProperty list) = Interop.mkPointcloudAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkPointcloudAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkPointcloudAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkPointcloudAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTime) = Interop.mkPointcloudAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkPointcloudAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkPointcloudAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkPointcloudAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool list>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool []>) = Interop.mkPointcloudAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<string>>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string list>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string []>) = Interop.mkPointcloudAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<int>>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int list>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int option []>) = Interop.mkPointcloudAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<float>>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float list>) = Interop.mkPointcloudAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float []>) = Interop.mkPointcloudAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<PlotData>) = Interop.mkPointcloudAttr "x" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool option>) = Interop.mkPointcloudAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<int option>) = Interop.mkPointcloudAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<float option>) = Interop.mkPointcloudAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline x (values: seq<string option>) = Interop.mkPointcloudAttr "x" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkPointcloudAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTime) = Interop.mkPointcloudAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkPointcloudAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkPointcloudAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkPointcloudAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool list>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool []>) = Interop.mkPointcloudAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<string>>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string list>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string []>) = Interop.mkPointcloudAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<int>>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int list>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int option []>) = Interop.mkPointcloudAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<float>>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float list>) = Interop.mkPointcloudAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float []>) = Interop.mkPointcloudAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<PlotData>) = Interop.mkPointcloudAttr "y" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool option>) = Interop.mkPointcloudAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<int option>) = Interop.mkPointcloudAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<float option>) = Interop.mkPointcloudAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline y (values: seq<string option>) = Interop.mkPointcloudAttr "y" (values |> ResizeArray)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<int>) = Interop.mkPointcloudAttr "xy" (values |> Seq.map float32 |> Array.ofSeq)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<float>) = Interop.mkPointcloudAttr "xy" (values |> Seq.map float32 |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (value: bool) = Interop.mkPointcloudAttr "indices" value
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<bool>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (value: System.DateTime) = Interop.mkPointcloudAttr "indices" value
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (value: int) = Interop.mkPointcloudAttr "indices" value
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<int>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (value: float) = Interop.mkPointcloudAttr "indices" value
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<float>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (value: string) = Interop.mkPointcloudAttr "indices" value
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<string>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<bool list>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<bool []>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<seq<string>>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<string list>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<string []>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<seq<int>>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<int list>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<int option []>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<seq<float>>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<float list>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<float []>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<PlotData>) = Interop.mkPointcloudAttr "indices" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<bool option>) = Interop.mkPointcloudAttr "indices" (values |> ResizeArray)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "indices" (values |> ResizeArray)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<int option>) = Interop.mkPointcloudAttr "indices" (values |> ResizeArray)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<float option>) = Interop.mkPointcloudAttr "indices" (values |> ResizeArray)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<string option>) = Interop.mkPointcloudAttr "indices" (values |> ResizeArray)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (value: bool) = Interop.mkPointcloudAttr "xbounds" value
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<bool>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (value: System.DateTime) = Interop.mkPointcloudAttr "xbounds" value
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (value: int) = Interop.mkPointcloudAttr "xbounds" value
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<int>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (value: float) = Interop.mkPointcloudAttr "xbounds" value
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<float>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (value: string) = Interop.mkPointcloudAttr "xbounds" value
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<string>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<bool list>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<bool []>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<seq<string>>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<string list>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<string []>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<seq<int>>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<int list>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<int option []>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<seq<float>>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<float list>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<float []>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<PlotData>) = Interop.mkPointcloudAttr "xbounds" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<bool option>) = Interop.mkPointcloudAttr "xbounds" (values |> ResizeArray)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "xbounds" (values |> ResizeArray)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<int option>) = Interop.mkPointcloudAttr "xbounds" (values |> ResizeArray)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<float option>) = Interop.mkPointcloudAttr "xbounds" (values |> ResizeArray)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<string option>) = Interop.mkPointcloudAttr "xbounds" (values |> ResizeArray)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (value: bool) = Interop.mkPointcloudAttr "ybounds" value
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<bool>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (value: System.DateTime) = Interop.mkPointcloudAttr "ybounds" value
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<System.DateTime>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (value: int) = Interop.mkPointcloudAttr "ybounds" value
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<int>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (value: float) = Interop.mkPointcloudAttr "ybounds" value
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<float>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (value: string) = Interop.mkPointcloudAttr "ybounds" value
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<string>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<seq<bool>>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<bool list>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<bool []>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<seq<string>>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<string list>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<string []>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<seq<int>>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<int list>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<int option []>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<seq<float>>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<float list>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<float []>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<PlotData>) = Interop.mkPointcloudAttr "ybounds" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<bool option>) = Interop.mkPointcloudAttr "ybounds" (values |> ResizeArray)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<System.DateTime option>) = Interop.mkPointcloudAttr "ybounds" (values |> ResizeArray)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<int option>) = Interop.mkPointcloudAttr "ybounds" (values |> ResizeArray)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<float option>) = Interop.mkPointcloudAttr "ybounds" (values |> ResizeArray)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<string option>) = Interop.mkPointcloudAttr "ybounds" (values |> ResizeArray)
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkPointcloudAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkPointcloudAttr "text" (values |> ResizeArray)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkPointcloudAttr "marker" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (axisId: int) = Interop.mkPointcloudAttr "xaxis" (sprintf "x%s" (if axisId > 1 then (axisId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkPointcloudAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (axisId: int) = Interop.mkPointcloudAttr "yaxis" (sprintf "y%s" (if axisId > 1 then (axisId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkPointcloudAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkPointcloudAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkPointcloudAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkPointcloudAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkPointcloudAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkPointcloudAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkPointcloudAttr "ysrc" value
    /// Sets the source reference on plot.ly for  xy .
    static member inline xysrc (value: string) = Interop.mkPointcloudAttr "xysrc" value
    /// Sets the source reference on plot.ly for  indices .
    static member inline indicessrc (value: string) = Interop.mkPointcloudAttr "indicessrc" value
    /// Sets the source reference on plot.ly for  xbounds .
    static member inline xboundssrc (value: string) = Interop.mkPointcloudAttr "xboundssrc" value
    /// Sets the source reference on plot.ly for  ybounds .
    static member inline yboundssrc (value: string) = Interop.mkPointcloudAttr "yboundssrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkPointcloudAttr "textsrc" value

[<AutoOpen>]
module pointcloud =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkPointcloudAttr "visible" "legendonly"
        static member inline false' = Interop.mkPointcloudAttr "visible" false
        static member inline true' = Interop.mkPointcloudAttr "visible" true

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkPointcloudAttr "hoverinfo" "all"
        static member inline none = Interop.mkPointcloudAttr "hoverinfo" "none"
        static member inline skip = Interop.mkPointcloudAttr "hoverinfo" "skip"
        static member inline name = Interop.mkPointcloudAttr "hoverinfo" "name"
        static member inline text = Interop.mkPointcloudAttr "hoverinfo" "text"
        static member inline x = Interop.mkPointcloudAttr "hoverinfo" "x"
        static member inline y = Interop.mkPointcloudAttr "hoverinfo" "y"
        static member inline z = Interop.mkPointcloudAttr "hoverinfo" "z"

