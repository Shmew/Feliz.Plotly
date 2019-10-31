namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type surface =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkSurfaceAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkSurfaceAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkSurfaceAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkSurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkSurfaceAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkSurfaceAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkSurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkSurfaceAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkSurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkSurfaceAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkSurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkSurfaceAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkSurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkSurfaceAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkSurfaceAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkSurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkSurfaceAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkSurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkSurfaceAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkSurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkSurfaceAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkSurfaceAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkSurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkSurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkSurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkSurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkSurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkSurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkSurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkSurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkSurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (value: bool) = Interop.mkSurfaceAttr "z" value
    /// Sets the z coordinates.
    static member inline z (values: seq<bool>) = Interop.mkSurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (value: System.DateTime) = Interop.mkSurfaceAttr "z" value
    /// Sets the z coordinates.
    static member inline z (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (value: int) = Interop.mkSurfaceAttr "z" value
    /// Sets the z coordinates.
    static member inline z (values: seq<int>) = Interop.mkSurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (value: float) = Interop.mkSurfaceAttr "z" value
    /// Sets the z coordinates.
    static member inline z (values: seq<float>) = Interop.mkSurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (value: string) = Interop.mkSurfaceAttr "z" value
    /// Sets the z coordinates.
    static member inline z (values: seq<string>) = Interop.mkSurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<bool list>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<bool []>) = Interop.mkSurfaceAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<seq<string>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<string list>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<string []>) = Interop.mkSurfaceAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<seq<int>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<int list>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<int []>) = Interop.mkSurfaceAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<seq<float>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<float list>) = Interop.mkSurfaceAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<float []>) = Interop.mkSurfaceAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "z" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkSurfaceAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkSurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: System.DateTime) = Interop.mkSurfaceAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkSurfaceAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkSurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkSurfaceAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkSurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkSurfaceAttr "x" value
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkSurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool list>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool []>) = Interop.mkSurfaceAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<string>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string list>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string []>) = Interop.mkSurfaceAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<int>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int list>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int []>) = Interop.mkSurfaceAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<seq<float>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float list>) = Interop.mkSurfaceAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float []>) = Interop.mkSurfaceAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkSurfaceAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkSurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: System.DateTime) = Interop.mkSurfaceAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkSurfaceAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkSurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkSurfaceAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkSurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkSurfaceAttr "y" value
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkSurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool list>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool []>) = Interop.mkSurfaceAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<string>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string list>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string []>) = Interop.mkSurfaceAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<int>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int list>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int []>) = Interop.mkSurfaceAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<seq<float>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float list>) = Interop.mkSurfaceAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float []>) = Interop.mkSurfaceAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the text elements associated with each z value. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkSurfaceAttr "text" value
    /// Sets the text elements associated with each z value. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkSurfaceAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkSurfaceAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkSurfaceAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkSurfaceAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkSurfaceAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in.
    static member inline connectgaps (value: bool) = Interop.mkSurfaceAttr "connectgaps" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (value: bool) = Interop.mkSurfaceAttr "surfacecolor" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<bool>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (value: System.DateTime) = Interop.mkSurfaceAttr "surfacecolor" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<System.DateTime>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (value: int) = Interop.mkSurfaceAttr "surfacecolor" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<int>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (value: float) = Interop.mkSurfaceAttr "surfacecolor" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<float>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (value: string) = Interop.mkSurfaceAttr "surfacecolor" value
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<string>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<seq<bool>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<bool list>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<bool []>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<seq<string>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<string list>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<string []>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<seq<int>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<int list>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<int []>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<seq<float>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<float list>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<float []>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the surface color values, used for setting a color scale independent of `z`.
    static member inline surfacecolor (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkSurfaceAttr "surfacecolor" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here z or surfacecolor) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkSurfaceAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkSurfaceAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkSurfaceAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkSurfaceAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkSurfaceAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as z or surfacecolor. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkSurfaceAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as z or surfacecolor. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkSurfaceAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkSurfaceAttr "colorscale" (value |> Array.singleton)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string>) = Interop.mkSurfaceAttr "colorscale" (values |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkSurfaceAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkSurfaceAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkSurfaceAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkSurfaceAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkSurfaceAttr "coloraxis" value
    static member inline contours (properties: #IContoursProperty list) = Interop.mkSurfaceAttr "contours" (createObj !!properties)
    /// Determines whether or not a surface is drawn. For example, set `hidesurface` to *false* `contours.x.show` to *true* and `contours.y.show` to *true* to draw a wire frame plot.
    static member inline hidesurface (value: bool) = Interop.mkSurfaceAttr "hidesurface" value
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkSurfaceAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkSurfaceAttr "lighting" (createObj !!properties)
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkSurfaceAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkSurfaceAttr "opacity" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #ISurfaceProperty list) = Interop.mkSurfaceAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkSurfaceAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkSurfaceAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkSurfaceAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkSurfaceAttr "metasrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkSurfaceAttr "zsrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkSurfaceAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkSurfaceAttr "ysrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkSurfaceAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkSurfaceAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkSurfaceAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  surfacecolor .
    static member inline surfacecolorsrc (value: string) = Interop.mkSurfaceAttr "surfacecolorsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkSurfaceAttr "hoverinfosrc" value
    /// Hides/displays surfaces between minimum and maximum iso-values.
    static member inline show (value: bool) = Interop.mkSurfaceAttr "show" value
    /// Sets the number of iso-surfaces between minimum and maximum iso-values. By default this value is 2 meaning that only minimum and maximum surfaces would be drawn.
    static member inline count (value: int) = Interop.mkSurfaceAttr "count" value
    /// Sets the fill ratio of the iso-surface. The default fill value of the surface is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: int) = Interop.mkSurfaceAttr "fill" value
    /// Sets the fill ratio of the iso-surface. The default fill value of the surface is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: float) = Interop.mkSurfaceAttr "fill" value
    /// Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
    static member inline pattern (properties: #ISurfaceProperty list) = Interop.mkSurfaceAttr "pattern" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")

[<AutoOpen>]
module surface =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkSurfaceAttr "visible" "legendonly"
        static member inline false' = Interop.mkSurfaceAttr "visible" "false"
        static member inline true' = Interop.mkSurfaceAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkSurfaceAttr "hoverinfo" "all"
        static member inline none = Interop.mkSurfaceAttr "hoverinfo" "none"
        static member inline skip = Interop.mkSurfaceAttr "hoverinfo" "skip"
        static member inline name = Interop.mkSurfaceAttr "hoverinfo" "name"
        static member inline text = Interop.mkSurfaceAttr "hoverinfo" "text"
        static member inline x = Interop.mkSurfaceAttr "hoverinfo" "x"
        static member inline y = Interop.mkSurfaceAttr "hoverinfo" "y"
        static member inline z = Interop.mkSurfaceAttr "hoverinfo" "z"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkSurfaceAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkSurfaceAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkSurfaceAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkSurfaceAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkSurfaceAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkSurfaceAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkSurfaceAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkSurfaceAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkSurfaceAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkSurfaceAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkSurfaceAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkSurfaceAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkSurfaceAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkSurfaceAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkSurfaceAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkSurfaceAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkSurfaceAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkSurfaceAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkSurfaceAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkSurfaceAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkSurfaceAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkSurfaceAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkSurfaceAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkSurfaceAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkSurfaceAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkSurfaceAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkSurfaceAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkSurfaceAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkSurfaceAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkSurfaceAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkSurfaceAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkSurfaceAttr "ycalendar" "ummalqura"

    /// Sets the calendar system to use with `z` date data.
    [<Erase>]
    type zcalendar =
        static member inline chinese = Interop.mkSurfaceAttr "zcalendar" "chinese"
        static member inline coptic = Interop.mkSurfaceAttr "zcalendar" "coptic"
        static member inline discworld = Interop.mkSurfaceAttr "zcalendar" "discworld"
        static member inline ethiopian = Interop.mkSurfaceAttr "zcalendar" "ethiopian"
        static member inline gregorian = Interop.mkSurfaceAttr "zcalendar" "gregorian"
        static member inline hebrew = Interop.mkSurfaceAttr "zcalendar" "hebrew"
        static member inline islamic = Interop.mkSurfaceAttr "zcalendar" "islamic"
        static member inline jalali = Interop.mkSurfaceAttr "zcalendar" "jalali"
        static member inline julian = Interop.mkSurfaceAttr "zcalendar" "julian"
        static member inline mayan = Interop.mkSurfaceAttr "zcalendar" "mayan"
        static member inline nanakshahi = Interop.mkSurfaceAttr "zcalendar" "nanakshahi"
        static member inline nepali = Interop.mkSurfaceAttr "zcalendar" "nepali"
        static member inline persian = Interop.mkSurfaceAttr "zcalendar" "persian"
        static member inline taiwan = Interop.mkSurfaceAttr "zcalendar" "taiwan"
        static member inline thai = Interop.mkSurfaceAttr "zcalendar" "thai"
        static member inline ummalqura = Interop.mkSurfaceAttr "zcalendar" "ummalqura"

    /// Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
    [<Erase>]
    type pattern =
        static member inline all = Interop.mkSurfaceAttr "pattern" "all"
        static member inline even = Interop.mkSurfaceAttr "pattern" "even"
        static member inline odd = Interop.mkSurfaceAttr "pattern" "odd"
        static member inline A = Interop.mkSurfaceAttr "pattern" "A"
        static member inline B = Interop.mkSurfaceAttr "pattern" "B"
        static member inline C = Interop.mkSurfaceAttr "pattern" "C"
        static member inline D = Interop.mkSurfaceAttr "pattern" "D"
        static member inline E = Interop.mkSurfaceAttr "pattern" "E"

