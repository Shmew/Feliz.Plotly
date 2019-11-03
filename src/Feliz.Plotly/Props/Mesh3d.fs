namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type mesh3d =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkMesh3dAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkMesh3dAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkMesh3dAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkMesh3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkMesh3dAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkMesh3dAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkMesh3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkMesh3dAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkMesh3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkMesh3dAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkMesh3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option []>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkMesh3dAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkMesh3dAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkMesh3dAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkMesh3dAttr "ids" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkMesh3dAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkMesh3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkMesh3dAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkMesh3dAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkMesh3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkMesh3dAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkMesh3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkMesh3dAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkMesh3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option []>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkMesh3dAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkMesh3dAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkMesh3dAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkMesh3dAttr "customdata" (values |> ResizeArray)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkMesh3dAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkMesh3dAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkMesh3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkMesh3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkMesh3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkMesh3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkMesh3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkMesh3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkMesh3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkMesh3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkMesh3dAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (value: bool) = Interop.mkMesh3dAttr "x" value
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<bool>) = Interop.mkMesh3dAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (value: System.DateTime) = Interop.mkMesh3dAttr "x" value
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (value: int) = Interop.mkMesh3dAttr "x" value
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<int>) = Interop.mkMesh3dAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (value: float) = Interop.mkMesh3dAttr "x" value
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<float>) = Interop.mkMesh3dAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (value: string) = Interop.mkMesh3dAttr "x" value
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<string>) = Interop.mkMesh3dAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<bool list>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<bool []>) = Interop.mkMesh3dAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<seq<string>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<string list>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<string []>) = Interop.mkMesh3dAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<seq<int>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<int list>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<int option []>) = Interop.mkMesh3dAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<seq<float>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<float list>) = Interop.mkMesh3dAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<float []>) = Interop.mkMesh3dAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<bool option>) = Interop.mkMesh3dAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<int option>) = Interop.mkMesh3dAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<float option>) = Interop.mkMesh3dAttr "x" (values |> ResizeArray)
    /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline x (values: seq<string option>) = Interop.mkMesh3dAttr "x" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (value: bool) = Interop.mkMesh3dAttr "y" value
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<bool>) = Interop.mkMesh3dAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (value: System.DateTime) = Interop.mkMesh3dAttr "y" value
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (value: int) = Interop.mkMesh3dAttr "y" value
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<int>) = Interop.mkMesh3dAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (value: float) = Interop.mkMesh3dAttr "y" value
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<float>) = Interop.mkMesh3dAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (value: string) = Interop.mkMesh3dAttr "y" value
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<string>) = Interop.mkMesh3dAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<bool list>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<bool []>) = Interop.mkMesh3dAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<seq<string>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<string list>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<string []>) = Interop.mkMesh3dAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<seq<int>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<int list>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<int option []>) = Interop.mkMesh3dAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<seq<float>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<float list>) = Interop.mkMesh3dAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<float []>) = Interop.mkMesh3dAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<bool option>) = Interop.mkMesh3dAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<int option>) = Interop.mkMesh3dAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<float option>) = Interop.mkMesh3dAttr "y" (values |> ResizeArray)
    /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline y (values: seq<string option>) = Interop.mkMesh3dAttr "y" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (value: bool) = Interop.mkMesh3dAttr "z" value
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<bool>) = Interop.mkMesh3dAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (value: System.DateTime) = Interop.mkMesh3dAttr "z" value
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (value: int) = Interop.mkMesh3dAttr "z" value
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<int>) = Interop.mkMesh3dAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (value: float) = Interop.mkMesh3dAttr "z" value
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<float>) = Interop.mkMesh3dAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (value: string) = Interop.mkMesh3dAttr "z" value
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<string>) = Interop.mkMesh3dAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<bool list>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<bool []>) = Interop.mkMesh3dAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<seq<string>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<string list>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<string []>) = Interop.mkMesh3dAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<seq<int>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<int list>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<int option []>) = Interop.mkMesh3dAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<seq<float>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<float list>) = Interop.mkMesh3dAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<float []>) = Interop.mkMesh3dAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "z" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<bool option>) = Interop.mkMesh3dAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<int option>) = Interop.mkMesh3dAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<float option>) = Interop.mkMesh3dAttr "z" (values |> ResizeArray)
    /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
    static member inline z (values: seq<string option>) = Interop.mkMesh3dAttr "z" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (value: bool) = Interop.mkMesh3dAttr "i" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<bool>) = Interop.mkMesh3dAttr "i" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (value: System.DateTime) = Interop.mkMesh3dAttr "i" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "i" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (value: int) = Interop.mkMesh3dAttr "i" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<int>) = Interop.mkMesh3dAttr "i" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (value: float) = Interop.mkMesh3dAttr "i" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<float>) = Interop.mkMesh3dAttr "i" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (value: string) = Interop.mkMesh3dAttr "i" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<string>) = Interop.mkMesh3dAttr "i" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<bool list>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<bool []>) = Interop.mkMesh3dAttr "i" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<seq<string>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<string list>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<string []>) = Interop.mkMesh3dAttr "i" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<seq<int>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<int list>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<int option []>) = Interop.mkMesh3dAttr "i" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<seq<float>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<float list>) = Interop.mkMesh3dAttr "i" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<float []>) = Interop.mkMesh3dAttr "i" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "i" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<bool option>) = Interop.mkMesh3dAttr "i" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "i" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<int option>) = Interop.mkMesh3dAttr "i" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<float option>) = Interop.mkMesh3dAttr "i" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
    static member inline i (values: seq<string option>) = Interop.mkMesh3dAttr "i" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (value: bool) = Interop.mkMesh3dAttr "j" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<bool>) = Interop.mkMesh3dAttr "j" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (value: System.DateTime) = Interop.mkMesh3dAttr "j" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "j" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (value: int) = Interop.mkMesh3dAttr "j" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<int>) = Interop.mkMesh3dAttr "j" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (value: float) = Interop.mkMesh3dAttr "j" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<float>) = Interop.mkMesh3dAttr "j" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (value: string) = Interop.mkMesh3dAttr "j" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<string>) = Interop.mkMesh3dAttr "j" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<bool list>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<bool []>) = Interop.mkMesh3dAttr "j" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<seq<string>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<string list>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<string []>) = Interop.mkMesh3dAttr "j" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<seq<int>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<int list>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<int option []>) = Interop.mkMesh3dAttr "j" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<seq<float>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<float list>) = Interop.mkMesh3dAttr "j" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<float []>) = Interop.mkMesh3dAttr "j" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "j" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<bool option>) = Interop.mkMesh3dAttr "j" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "j" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<int option>) = Interop.mkMesh3dAttr "j" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<float option>) = Interop.mkMesh3dAttr "j" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
    static member inline j (values: seq<string option>) = Interop.mkMesh3dAttr "j" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (value: bool) = Interop.mkMesh3dAttr "k" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<bool>) = Interop.mkMesh3dAttr "k" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (value: System.DateTime) = Interop.mkMesh3dAttr "k" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "k" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (value: int) = Interop.mkMesh3dAttr "k" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<int>) = Interop.mkMesh3dAttr "k" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (value: float) = Interop.mkMesh3dAttr "k" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<float>) = Interop.mkMesh3dAttr "k" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (value: string) = Interop.mkMesh3dAttr "k" value
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<string>) = Interop.mkMesh3dAttr "k" (values |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<bool list>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<bool []>) = Interop.mkMesh3dAttr "k" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<seq<string>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<string list>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<string []>) = Interop.mkMesh3dAttr "k" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<seq<int>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<int list>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<int option []>) = Interop.mkMesh3dAttr "k" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<seq<float>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<float list>) = Interop.mkMesh3dAttr "k" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<float []>) = Interop.mkMesh3dAttr "k" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "k" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<bool option>) = Interop.mkMesh3dAttr "k" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "k" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<int option>) = Interop.mkMesh3dAttr "k" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<float option>) = Interop.mkMesh3dAttr "k" (values |> ResizeArray)
    /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
    static member inline k (values: seq<string option>) = Interop.mkMesh3dAttr "k" (values |> ResizeArray)
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkMesh3dAttr "text" value
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkMesh3dAttr "text" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkMesh3dAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkMesh3dAttr "hovertext" (values |> ResizeArray)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkMesh3dAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkMesh3dAttr "hovertemplate" (values |> ResizeArray)
    /// Determines how the mesh surface triangles are derived from the set of vertices (points) represented by the `x`, `y` and `z` arrays, if the `i`, `j`, `k` arrays are not supplied. For general use of `mesh3d` it is preferred that `i`, `j`, `k` are supplied. If *-1*, Delaunay triangulation is used, which is mainly suitable if the mesh is a single, more or less layer surface that is perpendicular to `delaunayaxis`. In case the `delaunayaxis` intersects the mesh surface at more than one point it will result triangles that are very long in the dimension of `delaunayaxis`. If *>0*, the alpha-shape algorithm is used. In this case, the positive `alphahull` value signals the use of the alpha-shape algorithm, _and_ its value acts as the parameter for the mesh fitting. If *0*,  the convex-hull algorithm is used. It is suitable for convex bodies or if the intention is to enclose the `x`, `y` and `z` point set into a convex hull.
    static member inline alphahull (value: int) = Interop.mkMesh3dAttr "alphahull" value
    /// Determines how the mesh surface triangles are derived from the set of vertices (points) represented by the `x`, `y` and `z` arrays, if the `i`, `j`, `k` arrays are not supplied. For general use of `mesh3d` it is preferred that `i`, `j`, `k` are supplied. If *-1*, Delaunay triangulation is used, which is mainly suitable if the mesh is a single, more or less layer surface that is perpendicular to `delaunayaxis`. In case the `delaunayaxis` intersects the mesh surface at more than one point it will result triangles that are very long in the dimension of `delaunayaxis`. If *>0*, the alpha-shape algorithm is used. In this case, the positive `alphahull` value signals the use of the alpha-shape algorithm, _and_ its value acts as the parameter for the mesh fitting. If *0*,  the convex-hull algorithm is used. It is suitable for convex bodies or if the intention is to enclose the `x`, `y` and `z` point set into a convex hull.
    static member inline alphahull (value: float) = Interop.mkMesh3dAttr "alphahull" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (value: bool) = Interop.mkMesh3dAttr "intensity" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<bool>) = Interop.mkMesh3dAttr "intensity" (values |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (value: System.DateTime) = Interop.mkMesh3dAttr "intensity" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "intensity" (values |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (value: int) = Interop.mkMesh3dAttr "intensity" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<int>) = Interop.mkMesh3dAttr "intensity" (values |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (value: float) = Interop.mkMesh3dAttr "intensity" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<float>) = Interop.mkMesh3dAttr "intensity" (values |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (value: string) = Interop.mkMesh3dAttr "intensity" value
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<string>) = Interop.mkMesh3dAttr "intensity" (values |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<bool list>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<bool []>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<seq<string>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<string list>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<string []>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<seq<int>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<int list>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<int option []>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<seq<float>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<float list>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<float []>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "intensity" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<bool option>) = Interop.mkMesh3dAttr "intensity" (values |> ResizeArray)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "intensity" (values |> ResizeArray)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<int option>) = Interop.mkMesh3dAttr "intensity" (values |> ResizeArray)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<float option>) = Interop.mkMesh3dAttr "intensity" (values |> ResizeArray)
    /// Sets the vertex intensity values, used for plotting fields on meshes
    static member inline intensity (values: seq<string option>) = Interop.mkMesh3dAttr "intensity" (values |> ResizeArray)
    /// Sets the color of the whole mesh
    static member inline color (value: string) = Interop.mkMesh3dAttr "color" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (value: bool) = Interop.mkMesh3dAttr "vertexcolor" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<bool>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (value: System.DateTime) = Interop.mkMesh3dAttr "vertexcolor" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (value: int) = Interop.mkMesh3dAttr "vertexcolor" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<int>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (value: float) = Interop.mkMesh3dAttr "vertexcolor" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<float>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (value: string) = Interop.mkMesh3dAttr "vertexcolor" value
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<string>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<bool list>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<bool []>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<seq<string>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<string list>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<string []>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<seq<int>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<int list>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<int option []>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<seq<float>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<float list>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<float []>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "vertexcolor" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<bool option>) = Interop.mkMesh3dAttr "vertexcolor" (values |> ResizeArray)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "vertexcolor" (values |> ResizeArray)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<int option>) = Interop.mkMesh3dAttr "vertexcolor" (values |> ResizeArray)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<float option>) = Interop.mkMesh3dAttr "vertexcolor" (values |> ResizeArray)
    /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
    static member inline vertexcolor (values: seq<string option>) = Interop.mkMesh3dAttr "vertexcolor" (values |> ResizeArray)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (value: bool) = Interop.mkMesh3dAttr "facecolor" value
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<bool>) = Interop.mkMesh3dAttr "facecolor" (values |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (value: System.DateTime) = Interop.mkMesh3dAttr "facecolor" value
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<System.DateTime>) = Interop.mkMesh3dAttr "facecolor" (values |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (value: int) = Interop.mkMesh3dAttr "facecolor" value
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<int>) = Interop.mkMesh3dAttr "facecolor" (values |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (value: float) = Interop.mkMesh3dAttr "facecolor" value
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<float>) = Interop.mkMesh3dAttr "facecolor" (values |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (value: string) = Interop.mkMesh3dAttr "facecolor" value
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<string>) = Interop.mkMesh3dAttr "facecolor" (values |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<seq<bool>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<bool list>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<bool []>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<seq<string>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<string list>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<string []>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<seq<int>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<int list>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<int option []>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<seq<float>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<float list>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<float []>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkMesh3dAttr "facecolor" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<bool option>) = Interop.mkMesh3dAttr "facecolor" (values |> ResizeArray)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<System.DateTime option>) = Interop.mkMesh3dAttr "facecolor" (values |> ResizeArray)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<int option>) = Interop.mkMesh3dAttr "facecolor" (values |> ResizeArray)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<float option>) = Interop.mkMesh3dAttr "facecolor" (values |> ResizeArray)
    /// Sets the color of each face Overrides *color* and *vertexcolor*.
    static member inline facecolor (values: seq<string option>) = Interop.mkMesh3dAttr "facecolor" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here `intensity`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkMesh3dAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as `intensity` and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkMesh3dAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as `intensity` and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkMesh3dAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as `intensity` and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkMesh3dAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as `intensity` and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkMesh3dAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `intensity`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkMesh3dAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `intensity`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkMesh3dAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkMesh3dAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkMesh3dAttr "colorscale" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkMesh3dAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkMesh3dAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkMesh3dAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkMesh3dAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkMesh3dAttr "coloraxis" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkMesh3dAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkMesh3dAttr "opacity" value
    /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
    static member inline flatshading (value: bool) = Interop.mkMesh3dAttr "flatshading" value
    static member inline contour (properties: #IContourProperty list) = Interop.mkMesh3dAttr "contour" (createObj !!properties)
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkMesh3dAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkMesh3dAttr "lighting" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IMesh3dProperty list) = Interop.mkMesh3dAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkMesh3dAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkMesh3dAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkMesh3dAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkMesh3dAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkMesh3dAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkMesh3dAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkMesh3dAttr "zsrc" value
    /// Sets the source reference on plot.ly for  i .
    static member inline isrc (value: string) = Interop.mkMesh3dAttr "isrc" value
    /// Sets the source reference on plot.ly for  j .
    static member inline jsrc (value: string) = Interop.mkMesh3dAttr "jsrc" value
    /// Sets the source reference on plot.ly for  k .
    static member inline ksrc (value: string) = Interop.mkMesh3dAttr "ksrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkMesh3dAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkMesh3dAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkMesh3dAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  intensity .
    static member inline intensitysrc (value: string) = Interop.mkMesh3dAttr "intensitysrc" value
    /// Sets the source reference on plot.ly for  vertexcolor .
    static member inline vertexcolorsrc (value: string) = Interop.mkMesh3dAttr "vertexcolorsrc" value
    /// Sets the source reference on plot.ly for  facecolor .
    static member inline facecolorsrc (value: string) = Interop.mkMesh3dAttr "facecolorsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkMesh3dAttr "hoverinfosrc" value

[<AutoOpen>]
module mesh3d =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkMesh3dAttr "visible" "legendonly"
        static member inline false' = Interop.mkMesh3dAttr "visible" "false"
        static member inline true' = Interop.mkMesh3dAttr "visible" "true"

    /// Sets the Delaunay axis, which is the axis that is perpendicular to the surface of the Delaunay triangulation. It has an effect if `i`, `j`, `k` are not provided and `alphahull` is set to indicate Delaunay triangulation.
    [<Erase>]
    type delaunayaxis =
        static member inline x = Interop.mkMesh3dAttr "delaunayaxis" "x"
        static member inline y = Interop.mkMesh3dAttr "delaunayaxis" "y"
        static member inline z = Interop.mkMesh3dAttr "delaunayaxis" "z"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkMesh3dAttr "hoverinfo" "all"
        static member inline none = Interop.mkMesh3dAttr "hoverinfo" "none"
        static member inline skip = Interop.mkMesh3dAttr "hoverinfo" "skip"
        static member inline name = Interop.mkMesh3dAttr "hoverinfo" "name"
        static member inline text = Interop.mkMesh3dAttr "hoverinfo" "text"
        static member inline x = Interop.mkMesh3dAttr "hoverinfo" "x"
        static member inline y = Interop.mkMesh3dAttr "hoverinfo" "y"
        static member inline z = Interop.mkMesh3dAttr "hoverinfo" "z"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkMesh3dAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkMesh3dAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkMesh3dAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkMesh3dAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkMesh3dAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkMesh3dAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkMesh3dAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkMesh3dAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkMesh3dAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkMesh3dAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkMesh3dAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkMesh3dAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkMesh3dAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkMesh3dAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkMesh3dAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkMesh3dAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkMesh3dAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkMesh3dAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkMesh3dAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkMesh3dAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkMesh3dAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkMesh3dAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkMesh3dAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkMesh3dAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkMesh3dAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkMesh3dAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkMesh3dAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkMesh3dAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkMesh3dAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkMesh3dAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkMesh3dAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkMesh3dAttr "ycalendar" "ummalqura"

    /// Sets the calendar system to use with `z` date data.
    [<Erase>]
    type zcalendar =
        static member inline chinese = Interop.mkMesh3dAttr "zcalendar" "chinese"
        static member inline coptic = Interop.mkMesh3dAttr "zcalendar" "coptic"
        static member inline discworld = Interop.mkMesh3dAttr "zcalendar" "discworld"
        static member inline ethiopian = Interop.mkMesh3dAttr "zcalendar" "ethiopian"
        static member inline gregorian = Interop.mkMesh3dAttr "zcalendar" "gregorian"
        static member inline hebrew = Interop.mkMesh3dAttr "zcalendar" "hebrew"
        static member inline islamic = Interop.mkMesh3dAttr "zcalendar" "islamic"
        static member inline jalali = Interop.mkMesh3dAttr "zcalendar" "jalali"
        static member inline julian = Interop.mkMesh3dAttr "zcalendar" "julian"
        static member inline mayan = Interop.mkMesh3dAttr "zcalendar" "mayan"
        static member inline nanakshahi = Interop.mkMesh3dAttr "zcalendar" "nanakshahi"
        static member inline nepali = Interop.mkMesh3dAttr "zcalendar" "nepali"
        static member inline persian = Interop.mkMesh3dAttr "zcalendar" "persian"
        static member inline taiwan = Interop.mkMesh3dAttr "zcalendar" "taiwan"
        static member inline thai = Interop.mkMesh3dAttr "zcalendar" "thai"
        static member inline ummalqura = Interop.mkMesh3dAttr "zcalendar" "ummalqura"

