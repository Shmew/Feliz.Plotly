namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type carpet =
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkCarpetAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkCarpetAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkCarpetAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkCarpetAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkCarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkCarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkCarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkCarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkCarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkCarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkCarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkCarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkCarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkCarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkCarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkCarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option []>) = Interop.mkCarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkCarpetAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkCarpetAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkCarpetAttr "ids" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkCarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkCarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkCarpetAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkCarpetAttr "ids" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkCarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkCarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkCarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkCarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkCarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkCarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkCarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkCarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkCarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkCarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option []>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkCarpetAttr "customdata" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkCarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkCarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkCarpetAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkCarpetAttr "customdata" (values |> ResizeArray)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkCarpetAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkCarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkCarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkCarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkCarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkCarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkCarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkCarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkCarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkCarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkCarpetAttr "uirevision" (values |> Array.ofSeq)
    /// An identifier for this carpet, so that `scattercarpet` and `contourcarpet` traces can specify a carpet plot on which they lie
    static member inline carpet (value: string) = Interop.mkCarpetAttr "carpet" value
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (value: bool) = Interop.mkCarpetAttr "x" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<bool>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (value: System.DateTime) = Interop.mkCarpetAttr "x" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<System.DateTime>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (value: float) = Interop.mkCarpetAttr "x" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<float>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (value: int) = Interop.mkCarpetAttr "x" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<int>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (value: string) = Interop.mkCarpetAttr "x" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<string>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<seq<bool>>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<bool list>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<bool []>) = Interop.mkCarpetAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<seq<string>>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<string list>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<string []>) = Interop.mkCarpetAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<seq<int>>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<int list>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<int option []>) = Interop.mkCarpetAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<seq<float>>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<float list>) = Interop.mkCarpetAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<float []>) = Interop.mkCarpetAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<PlotData>) = Interop.mkCarpetAttr "x" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<bool option>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<int option>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<float option>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
    static member inline x (values: seq<string option>) = Interop.mkCarpetAttr "x" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (value: bool) = Interop.mkCarpetAttr "y" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<bool>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (value: System.DateTime) = Interop.mkCarpetAttr "y" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<System.DateTime>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (value: float) = Interop.mkCarpetAttr "y" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<float>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (value: int) = Interop.mkCarpetAttr "y" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<int>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (value: string) = Interop.mkCarpetAttr "y" (value |> Array.singleton |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<string>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<seq<bool>>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<bool list>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<bool []>) = Interop.mkCarpetAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<seq<string>>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<string list>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<string []>) = Interop.mkCarpetAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<seq<int>>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<int list>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<int option []>) = Interop.mkCarpetAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<seq<float>>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<float list>) = Interop.mkCarpetAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<float []>) = Interop.mkCarpetAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<PlotData>) = Interop.mkCarpetAttr "y" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<bool option>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<int option>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<float option>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline y (values: seq<string option>) = Interop.mkCarpetAttr "y" (values |> ResizeArray)
    /// An array containing values of the first parameter value
    static member inline a (value: bool) = Interop.mkCarpetAttr "a" (value |> Array.singleton)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<bool>) = Interop.mkCarpetAttr "a" (values |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (value: System.DateTime) = Interop.mkCarpetAttr "a" (value |> Array.singleton)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<System.DateTime>) = Interop.mkCarpetAttr "a" (values |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (value: float) = Interop.mkCarpetAttr "a" (value |> Array.singleton)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<float>) = Interop.mkCarpetAttr "a" (values |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (value: int) = Interop.mkCarpetAttr "a" (value |> Array.singleton)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<int>) = Interop.mkCarpetAttr "a" (values |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (value: string) = Interop.mkCarpetAttr "a" (value |> Array.singleton)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<string>) = Interop.mkCarpetAttr "a" (values |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<seq<bool>>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<bool list>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<bool []>) = Interop.mkCarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<seq<string>>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<string list>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<string []>) = Interop.mkCarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<seq<int>>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<int list>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<int option []>) = Interop.mkCarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<seq<float>>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<float list>) = Interop.mkCarpetAttr "a" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<float []>) = Interop.mkCarpetAttr "a" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<PlotData>) = Interop.mkCarpetAttr "a" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<bool option>) = Interop.mkCarpetAttr "a" (values |> ResizeArray)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "a" (values |> ResizeArray)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<int option>) = Interop.mkCarpetAttr "a" (values |> ResizeArray)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<float option>) = Interop.mkCarpetAttr "a" (values |> ResizeArray)
    /// An array containing values of the first parameter value
    static member inline a (values: seq<string option>) = Interop.mkCarpetAttr "a" (values |> ResizeArray)
    /// Alternate to `a`. Builds a linear space of a coordinates. Use with `da` where `a0` is the starting coordinate and `da` the step.
    static member inline a0 (value: int) = Interop.mkCarpetAttr "a0" value
    /// Alternate to `a`. Builds a linear space of a coordinates. Use with `da` where `a0` is the starting coordinate and `da` the step.
    static member inline a0 (value: float) = Interop.mkCarpetAttr "a0" value
    /// Sets the a coordinate step. See `a0` for more info.
    static member inline da (value: int) = Interop.mkCarpetAttr "da" value
    /// Sets the a coordinate step. See `a0` for more info.
    static member inline da (value: float) = Interop.mkCarpetAttr "da" value
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (value: bool) = Interop.mkCarpetAttr "b" (value |> Array.singleton)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<bool>) = Interop.mkCarpetAttr "b" (values |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (value: System.DateTime) = Interop.mkCarpetAttr "b" (value |> Array.singleton)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<System.DateTime>) = Interop.mkCarpetAttr "b" (values |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (value: float) = Interop.mkCarpetAttr "b" (value |> Array.singleton)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<float>) = Interop.mkCarpetAttr "b" (values |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (value: int) = Interop.mkCarpetAttr "b" (value |> Array.singleton)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<int>) = Interop.mkCarpetAttr "b" (values |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (value: string) = Interop.mkCarpetAttr "b" (value |> Array.singleton)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<string>) = Interop.mkCarpetAttr "b" (values |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<seq<bool>>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<bool list>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<bool []>) = Interop.mkCarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<seq<string>>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<string list>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<string []>) = Interop.mkCarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<seq<int>>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<int list>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<int option []>) = Interop.mkCarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<seq<float>>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<float list>) = Interop.mkCarpetAttr "b" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<float []>) = Interop.mkCarpetAttr "b" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<PlotData>) = Interop.mkCarpetAttr "b" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<bool option>) = Interop.mkCarpetAttr "b" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<System.DateTime option>) = Interop.mkCarpetAttr "b" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<int option>) = Interop.mkCarpetAttr "b" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<float option>) = Interop.mkCarpetAttr "b" (values |> ResizeArray)
    /// A two dimensional array of y coordinates at each carpet point.
    static member inline b (values: seq<string option>) = Interop.mkCarpetAttr "b" (values |> ResizeArray)
    /// Alternate to `b`. Builds a linear space of a coordinates. Use with `db` where `b0` is the starting coordinate and `db` the step.
    static member inline b0 (value: int) = Interop.mkCarpetAttr "b0" value
    /// Alternate to `b`. Builds a linear space of a coordinates. Use with `db` where `b0` is the starting coordinate and `db` the step.
    static member inline b0 (value: float) = Interop.mkCarpetAttr "b0" value
    /// Sets the b coordinate step. See `b0` for more info.
    static member inline db (value: int) = Interop.mkCarpetAttr "db" value
    /// Sets the b coordinate step. See `b0` for more info.
    static member inline db (value: float) = Interop.mkCarpetAttr "db" value
    /// The shift applied to each successive row of data in creating a cheater plot. Only used if `x` is been ommitted.
    static member inline cheaterslope (value: int) = Interop.mkCarpetAttr "cheaterslope" value
    /// The shift applied to each successive row of data in creating a cheater plot. Only used if `x` is been ommitted.
    static member inline cheaterslope (value: float) = Interop.mkCarpetAttr "cheaterslope" value
    static member inline aaxis (properties: #IAaxisProperty list) = Interop.mkCarpetAttr "aaxis" (createObj !!properties)
    static member inline baxis (properties: #IBaxisProperty list) = Interop.mkCarpetAttr "baxis" (createObj !!properties)
    /// The default font used for axis & tick labels on this carpet
    static member inline font (properties: #IFontProperty list) = Interop.mkCarpetAttr "font" (createObj !!properties)
    /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
    static member inline color (value: string) = Interop.mkCarpetAttr "color" value
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkCarpetAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkCarpetAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkCarpetAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkCarpetAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkCarpetAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkCarpetAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkCarpetAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkCarpetAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkCarpetAttr "ysrc" value
    /// Sets the source reference on plot.ly for  a .
    static member inline asrc (value: string) = Interop.mkCarpetAttr "asrc" value
    /// Sets the source reference on plot.ly for  b .
    static member inline bsrc (value: string) = Interop.mkCarpetAttr "bsrc" value

[<AutoOpen>]
module carpet =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkCarpetAttr "visible" "legendonly"
        static member inline false' = Interop.mkCarpetAttr "visible" false
        static member inline true' = Interop.mkCarpetAttr "visible" true

