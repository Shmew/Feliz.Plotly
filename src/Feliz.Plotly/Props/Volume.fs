namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type volume =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkVolumeAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkVolumeAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkVolumeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkVolumeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkVolumeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkVolumeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkVolumeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkVolumeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkVolumeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkVolumeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkVolumeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkVolumeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkVolumeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkVolumeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkVolumeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkVolumeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkVolumeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkVolumeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkVolumeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkVolumeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkVolumeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkVolumeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkVolumeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkVolumeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkVolumeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkVolumeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkVolumeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkVolumeAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkVolumeAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkVolumeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkVolumeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkVolumeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkVolumeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkVolumeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkVolumeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkVolumeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkVolumeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkVolumeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkVolumeAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: bool) = Interop.mkVolumeAttr "x" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool>) = Interop.mkVolumeAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: System.DateTime) = Interop.mkVolumeAttr "x" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<System.DateTime>) = Interop.mkVolumeAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: int) = Interop.mkVolumeAttr "x" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int>) = Interop.mkVolumeAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: float) = Interop.mkVolumeAttr "x" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float>) = Interop.mkVolumeAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: string) = Interop.mkVolumeAttr "x" value
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string>) = Interop.mkVolumeAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<bool>>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool list>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool []>) = Interop.mkVolumeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<string>>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string list>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string []>) = Interop.mkVolumeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<int>>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int list>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int []>) = Interop.mkVolumeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<seq<float>>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float list>) = Interop.mkVolumeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float []>) = Interop.mkVolumeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: bool) = Interop.mkVolumeAttr "y" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool>) = Interop.mkVolumeAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: System.DateTime) = Interop.mkVolumeAttr "y" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<System.DateTime>) = Interop.mkVolumeAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: int) = Interop.mkVolumeAttr "y" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int>) = Interop.mkVolumeAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: float) = Interop.mkVolumeAttr "y" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float>) = Interop.mkVolumeAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: string) = Interop.mkVolumeAttr "y" value
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string>) = Interop.mkVolumeAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<bool>>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool list>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool []>) = Interop.mkVolumeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<string>>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string list>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string []>) = Interop.mkVolumeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<int>>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int list>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int []>) = Interop.mkVolumeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<seq<float>>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float list>) = Interop.mkVolumeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float []>) = Interop.mkVolumeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: bool) = Interop.mkVolumeAttr "z" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool>) = Interop.mkVolumeAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: System.DateTime) = Interop.mkVolumeAttr "z" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<System.DateTime>) = Interop.mkVolumeAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: int) = Interop.mkVolumeAttr "z" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int>) = Interop.mkVolumeAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: float) = Interop.mkVolumeAttr "z" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float>) = Interop.mkVolumeAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: string) = Interop.mkVolumeAttr "z" value
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string>) = Interop.mkVolumeAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<bool>>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool list>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool []>) = Interop.mkVolumeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<string>>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string list>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string []>) = Interop.mkVolumeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<int>>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int list>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int []>) = Interop.mkVolumeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<seq<float>>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float list>) = Interop.mkVolumeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float []>) = Interop.mkVolumeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "z" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "z" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: bool) = Interop.mkVolumeAttr "value" value
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool>) = Interop.mkVolumeAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: System.DateTime) = Interop.mkVolumeAttr "value" value
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<System.DateTime>) = Interop.mkVolumeAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: int) = Interop.mkVolumeAttr "value" value
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int>) = Interop.mkVolumeAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: float) = Interop.mkVolumeAttr "value" value
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float>) = Interop.mkVolumeAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: string) = Interop.mkVolumeAttr "value" value
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string>) = Interop.mkVolumeAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<bool>>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool list>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool []>) = Interop.mkVolumeAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<string>>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string list>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string []>) = Interop.mkVolumeAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<int>>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int list>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int []>) = Interop.mkVolumeAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<seq<float>>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float list>) = Interop.mkVolumeAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float []>) = Interop.mkVolumeAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkVolumeAttr "value" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkVolumeAttr "value" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: int) = Interop.mkVolumeAttr "isomin" value
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: float) = Interop.mkVolumeAttr "isomin" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: int) = Interop.mkVolumeAttr "isomax" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: float) = Interop.mkVolumeAttr "isomax" value
    static member inline surface (properties: #ISurfaceProperty list) = Interop.mkVolumeAttr "surface" (createObj !!properties)
    static member inline spaceframe (properties: #ISpaceframeProperty list) = Interop.mkVolumeAttr "spaceframe" (createObj !!properties)
    static member inline slices (properties: #ISlicesProperty list) = Interop.mkVolumeAttr "slices" (createObj !!properties)
    static member inline caps (properties: #ICapsProperty list) = Interop.mkVolumeAttr "caps" (createObj !!properties)
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkVolumeAttr "text" value
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkVolumeAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkVolumeAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkVolumeAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkVolumeAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkVolumeAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkVolumeAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkVolumeAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkVolumeAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkVolumeAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkVolumeAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkVolumeAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkVolumeAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkVolumeAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkVolumeAttr "colorscale" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkVolumeAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkVolumeAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkVolumeAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkVolumeAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkVolumeAttr "coloraxis" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkVolumeAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkVolumeAttr "opacity" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (value: bool) = Interop.mkVolumeAttr "opacityscale" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (values: seq<bool>) = Interop.mkVolumeAttr "opacityscale" (values |> Array.ofSeq)
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (value: System.DateTime) = Interop.mkVolumeAttr "opacityscale" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (values: seq<System.DateTime>) = Interop.mkVolumeAttr "opacityscale" (values |> Array.ofSeq)
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (value: int) = Interop.mkVolumeAttr "opacityscale" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (values: seq<int>) = Interop.mkVolumeAttr "opacityscale" (values |> Array.ofSeq)
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (value: float) = Interop.mkVolumeAttr "opacityscale" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (values: seq<float>) = Interop.mkVolumeAttr "opacityscale" (values |> Array.ofSeq)
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (value: string) = Interop.mkVolumeAttr "opacityscale" value
    /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
    static member inline opacityscale (values: seq<string>) = Interop.mkVolumeAttr "opacityscale" (values |> Array.ofSeq)
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkVolumeAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkVolumeAttr "lighting" (createObj !!properties)
    /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
    static member inline flatshading (value: bool) = Interop.mkVolumeAttr "flatshading" value
    static member inline contour (properties: #IContourProperty list) = Interop.mkVolumeAttr "contour" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IVolumeProperty list) = Interop.mkVolumeAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkVolumeAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkVolumeAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkVolumeAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkVolumeAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkVolumeAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkVolumeAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkVolumeAttr "zsrc" value
    /// Sets the source reference on plot.ly for  value .
    static member inline valuesrc (value: string) = Interop.mkVolumeAttr "valuesrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkVolumeAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkVolumeAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkVolumeAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkVolumeAttr "hoverinfosrc" value

[<AutoOpen>]
module volume =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkVolumeAttr "visible" "legendonly"
        static member inline false' = Interop.mkVolumeAttr "visible" "false"
        static member inline true' = Interop.mkVolumeAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkVolumeAttr "hoverinfo" "all"
        static member inline none = Interop.mkVolumeAttr "hoverinfo" "none"
        static member inline skip = Interop.mkVolumeAttr "hoverinfo" "skip"
        static member inline name = Interop.mkVolumeAttr "hoverinfo" "name"
        static member inline text = Interop.mkVolumeAttr "hoverinfo" "text"
        static member inline x = Interop.mkVolumeAttr "hoverinfo" "x"
        static member inline y = Interop.mkVolumeAttr "hoverinfo" "y"
        static member inline z = Interop.mkVolumeAttr "hoverinfo" "z"

