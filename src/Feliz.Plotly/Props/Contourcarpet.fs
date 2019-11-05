namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type contourcarpet =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkContourcarpetAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkContourcarpetAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkContourcarpetAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkContourcarpetAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkContourcarpetAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkContourcarpetAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkContourcarpetAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkContourcarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkContourcarpetAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkContourcarpetAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkContourcarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkContourcarpetAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkContourcarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkContourcarpetAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkContourcarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option []>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkContourcarpetAttr "ids" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkContourcarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkContourcarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkContourcarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkContourcarpetAttr "ids" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkContourcarpetAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkContourcarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkContourcarpetAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkContourcarpetAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkContourcarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkContourcarpetAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkContourcarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkContourcarpetAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkContourcarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option []>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkContourcarpetAttr "customdata" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkContourcarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkContourcarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkContourcarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkContourcarpetAttr "customdata" (values |> ResizeArray)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkContourcarpetAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkContourcarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkContourcarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkContourcarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkContourcarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkContourcarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkContourcarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkContourcarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkContourcarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkContourcarpetAttr "uirevision" (values |> Array.ofSeq)
    /// The `carpet` of the carpet axes on which this contour trace lies
    static member inline carpet (value: string) = Interop.mkContourcarpetAttr "carpet" value
    /// Sets the z data.
    static member inline z (value: bool) = Interop.mkContourcarpetAttr "z" value
    /// Sets the z data.
    static member inline z (values: seq<bool>) = Interop.mkContourcarpetAttr "z" (values |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (value: System.DateTime) = Interop.mkContourcarpetAttr "z" value
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "z" (values |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (value: int) = Interop.mkContourcarpetAttr "z" value
    /// Sets the z data.
    static member inline z (values: seq<int>) = Interop.mkContourcarpetAttr "z" (values |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (value: float) = Interop.mkContourcarpetAttr "z" value
    /// Sets the z data.
    static member inline z (values: seq<float>) = Interop.mkContourcarpetAttr "z" (values |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (value: string) = Interop.mkContourcarpetAttr "z" value
    /// Sets the z data.
    static member inline z (values: seq<string>) = Interop.mkContourcarpetAttr "z" (values |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<bool list>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<bool []>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<string list>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<string []>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<int list>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<int option []>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<float list>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<float []>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<PlotData>) = Interop.mkContourcarpetAttr "z" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the z data.
    static member inline z (values: seq<bool option>) = Interop.mkContourcarpetAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<int option>) = Interop.mkContourcarpetAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<float option>) = Interop.mkContourcarpetAttr "z" (values |> ResizeArray)
    /// Sets the z data.
    static member inline z (values: seq<string option>) = Interop.mkContourcarpetAttr "z" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline a (value: bool) = Interop.mkContourcarpetAttr "a" value
    /// Sets the x coordinates.
    static member inline a (values: seq<bool>) = Interop.mkContourcarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (value: System.DateTime) = Interop.mkContourcarpetAttr "a" value
    /// Sets the x coordinates.
    static member inline a (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (value: int) = Interop.mkContourcarpetAttr "a" value
    /// Sets the x coordinates.
    static member inline a (values: seq<int>) = Interop.mkContourcarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (value: float) = Interop.mkContourcarpetAttr "a" value
    /// Sets the x coordinates.
    static member inline a (values: seq<float>) = Interop.mkContourcarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (value: string) = Interop.mkContourcarpetAttr "a" value
    /// Sets the x coordinates.
    static member inline a (values: seq<string>) = Interop.mkContourcarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<bool list>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<bool []>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<string list>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<string []>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<int list>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<int option []>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<float list>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<float []>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<PlotData>) = Interop.mkContourcarpetAttr "a" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline a (values: seq<bool option>) = Interop.mkContourcarpetAttr "a" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline a (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "a" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline a (values: seq<int option>) = Interop.mkContourcarpetAttr "a" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline a (values: seq<float option>) = Interop.mkContourcarpetAttr "a" (values |> ResizeArray)
    /// Sets the x coordinates.
    static member inline a (values: seq<string option>) = Interop.mkContourcarpetAttr "a" (values |> ResizeArray)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (value: bool) = Interop.mkContourcarpetAttr "a0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (values: seq<bool>) = Interop.mkContourcarpetAttr "a0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (value: System.DateTime) = Interop.mkContourcarpetAttr "a0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "a0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (value: int) = Interop.mkContourcarpetAttr "a0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (values: seq<int>) = Interop.mkContourcarpetAttr "a0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (value: float) = Interop.mkContourcarpetAttr "a0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (values: seq<float>) = Interop.mkContourcarpetAttr "a0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (value: string) = Interop.mkContourcarpetAttr "a0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline a0 (values: seq<string>) = Interop.mkContourcarpetAttr "a0" (values |> Array.ofSeq)
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline da (value: int) = Interop.mkContourcarpetAttr "da" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline da (value: float) = Interop.mkContourcarpetAttr "da" value
    /// Sets the y coordinates.
    static member inline b (value: bool) = Interop.mkContourcarpetAttr "b" value
    /// Sets the y coordinates.
    static member inline b (values: seq<bool>) = Interop.mkContourcarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (value: System.DateTime) = Interop.mkContourcarpetAttr "b" value
    /// Sets the y coordinates.
    static member inline b (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (value: int) = Interop.mkContourcarpetAttr "b" value
    /// Sets the y coordinates.
    static member inline b (values: seq<int>) = Interop.mkContourcarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (value: float) = Interop.mkContourcarpetAttr "b" value
    /// Sets the y coordinates.
    static member inline b (values: seq<float>) = Interop.mkContourcarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (value: string) = Interop.mkContourcarpetAttr "b" value
    /// Sets the y coordinates.
    static member inline b (values: seq<string>) = Interop.mkContourcarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<bool list>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<bool []>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<string list>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<string []>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<int list>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<int option []>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<float list>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<float []>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<PlotData>) = Interop.mkContourcarpetAttr "b" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline b (values: seq<bool option>) = Interop.mkContourcarpetAttr "b" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline b (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "b" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline b (values: seq<int option>) = Interop.mkContourcarpetAttr "b" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline b (values: seq<float option>) = Interop.mkContourcarpetAttr "b" (values |> ResizeArray)
    /// Sets the y coordinates.
    static member inline b (values: seq<string option>) = Interop.mkContourcarpetAttr "b" (values |> ResizeArray)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (value: bool) = Interop.mkContourcarpetAttr "b0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (values: seq<bool>) = Interop.mkContourcarpetAttr "b0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (value: System.DateTime) = Interop.mkContourcarpetAttr "b0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "b0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (value: int) = Interop.mkContourcarpetAttr "b0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (values: seq<int>) = Interop.mkContourcarpetAttr "b0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (value: float) = Interop.mkContourcarpetAttr "b0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (values: seq<float>) = Interop.mkContourcarpetAttr "b0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (value: string) = Interop.mkContourcarpetAttr "b0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline b0 (values: seq<string>) = Interop.mkContourcarpetAttr "b0" (values |> Array.ofSeq)
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline db (value: int) = Interop.mkContourcarpetAttr "db" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline db (value: float) = Interop.mkContourcarpetAttr "db" value
    /// Sets the text elements associated with each z value.
    static member inline text (value: bool) = Interop.mkContourcarpetAttr "text" value
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool>) = Interop.mkContourcarpetAttr "text" (values |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (value: System.DateTime) = Interop.mkContourcarpetAttr "text" value
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "text" (values |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (value: int) = Interop.mkContourcarpetAttr "text" value
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int>) = Interop.mkContourcarpetAttr "text" (values |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (value: float) = Interop.mkContourcarpetAttr "text" value
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float>) = Interop.mkContourcarpetAttr "text" (values |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (value: string) = Interop.mkContourcarpetAttr "text" value
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string>) = Interop.mkContourcarpetAttr "text" (values |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool list>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool []>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string list>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string []>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int list>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option []>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float list>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float []>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<PlotData>) = Interop.mkContourcarpetAttr "text" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<bool option>) = Interop.mkContourcarpetAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<int option>) = Interop.mkContourcarpetAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<float option>) = Interop.mkContourcarpetAttr "text" (values |> ResizeArray)
    /// Sets the text elements associated with each z value.
    static member inline text (values: seq<string option>) = Interop.mkContourcarpetAttr "text" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: bool) = Interop.mkContourcarpetAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<bool>) = Interop.mkContourcarpetAttr "hovertext" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: System.DateTime) = Interop.mkContourcarpetAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime>) = Interop.mkContourcarpetAttr "hovertext" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: int) = Interop.mkContourcarpetAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<int>) = Interop.mkContourcarpetAttr "hovertext" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: float) = Interop.mkContourcarpetAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<float>) = Interop.mkContourcarpetAttr "hovertext" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkContourcarpetAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkContourcarpetAttr "hovertext" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<bool>>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool list>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool []>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<string>>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<string list>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<string []>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<int>>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<int list>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<int option []>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<seq<float>>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<float list>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<float []>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<PlotData>) = Interop.mkContourcarpetAttr "hovertext" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (values: seq<bool option>) = Interop.mkContourcarpetAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<System.DateTime option>) = Interop.mkContourcarpetAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<int option>) = Interop.mkContourcarpetAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<float option>) = Interop.mkContourcarpetAttr "hovertext" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (values: seq<string option>) = Interop.mkContourcarpetAttr "hovertext" (values |> ResizeArray)
    /// Transposes the z data.
    static member inline transpose (value: bool) = Interop.mkContourcarpetAttr "transpose" value
    /// Sets the fill color if `contours.type` is *constraint*. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkContourcarpetAttr "fillcolor" value
    /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
    static member inline autocontour (value: bool) = Interop.mkContourcarpetAttr "autocontour" value
    /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
    static member inline ncontours (value: int) = Interop.mkContourcarpetAttr "ncontours" value
    static member inline contours (properties: #IContoursProperty list) = Interop.mkContourcarpetAttr "contours" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkContourcarpetAttr "line" (createObj !!properties)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkContourcarpetAttr "zauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkContourcarpetAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkContourcarpetAttr "zmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkContourcarpetAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkContourcarpetAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkContourcarpetAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkContourcarpetAttr "zmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkContourcarpetAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkContourcarpetAttr "colorscale" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkContourcarpetAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkContourcarpetAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkContourcarpetAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkContourcarpetAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkContourcarpetAttr "coloraxis" value
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (axisId: int) = Interop.mkContourcarpetAttr "xaxis" (sprintf "x%s" (if axisId > 1 then (axisId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkContourcarpetAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (axisId: int) = Interop.mkContourcarpetAttr "yaxis" (sprintf "y%s" (if axisId > 1 then (axisId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkContourcarpetAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkContourcarpetAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkContourcarpetAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkContourcarpetAttr "metasrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkContourcarpetAttr "zsrc" value
    /// Sets the source reference on plot.ly for  a .
    static member inline asrc (value: string) = Interop.mkContourcarpetAttr "asrc" value
    /// Sets the source reference on plot.ly for  b .
    static member inline bsrc (value: string) = Interop.mkContourcarpetAttr "bsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkContourcarpetAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkContourcarpetAttr "hovertextsrc" value

[<AutoOpen>]
module contourcarpet =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkContourcarpetAttr "visible" "legendonly"
        static member inline false' = Interop.mkContourcarpetAttr "visible" false
        static member inline true' = Interop.mkContourcarpetAttr "visible" true

    /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
    [<Erase>]
    type atype =
        static member inline array = Interop.mkContourcarpetAttr "atype" "array"
        static member inline scaled = Interop.mkContourcarpetAttr "atype" "scaled"

    /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
    [<Erase>]
    type btype =
        static member inline array = Interop.mkContourcarpetAttr "btype" "array"
        static member inline scaled = Interop.mkContourcarpetAttr "btype" "scaled"

