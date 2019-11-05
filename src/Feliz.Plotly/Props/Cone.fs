namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type cone =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkConeAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkConeAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkConeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkConeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkConeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkConeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkConeAttr "ids" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkConeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkConeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option []>) = Interop.mkConeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkConeAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkConeAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkConeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkConeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkConeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkConeAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkConeAttr "ids" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkConeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkConeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkConeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkConeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkConeAttr "customdata" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkConeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkConeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option []>) = Interop.mkConeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkConeAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkConeAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkConeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkConeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkConeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkConeAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkConeAttr "customdata" (values |> ResizeArray)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkConeAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkConeAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: bool) = Interop.mkConeAttr "x" value
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<bool>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: System.DateTime) = Interop.mkConeAttr "x" value
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<System.DateTime>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: int) = Interop.mkConeAttr "x" value
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<int>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: float) = Interop.mkConeAttr "x" value
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<float>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: string) = Interop.mkConeAttr "x" value
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<string>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<seq<bool>>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<bool list>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<bool []>) = Interop.mkConeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<seq<string>>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<string list>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<string []>) = Interop.mkConeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<seq<int>>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<int list>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<int option []>) = Interop.mkConeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<seq<float>>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<float list>) = Interop.mkConeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<float []>) = Interop.mkConeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<bool option>) = Interop.mkConeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkConeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<int option>) = Interop.mkConeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<float option>) = Interop.mkConeAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<string option>) = Interop.mkConeAttr "x" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: bool) = Interop.mkConeAttr "y" value
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<bool>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: System.DateTime) = Interop.mkConeAttr "y" value
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<System.DateTime>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: int) = Interop.mkConeAttr "y" value
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<int>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: float) = Interop.mkConeAttr "y" value
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<float>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: string) = Interop.mkConeAttr "y" value
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<string>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<seq<bool>>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<bool list>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<bool []>) = Interop.mkConeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<seq<string>>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<string list>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<string []>) = Interop.mkConeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<seq<int>>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<int list>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<int option []>) = Interop.mkConeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<seq<float>>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<float list>) = Interop.mkConeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<float []>) = Interop.mkConeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<bool option>) = Interop.mkConeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<System.DateTime option>) = Interop.mkConeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<int option>) = Interop.mkConeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<float option>) = Interop.mkConeAttr "y" (values |> ResizeArray)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<string option>) = Interop.mkConeAttr "y" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: bool) = Interop.mkConeAttr "z" value
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<bool>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: System.DateTime) = Interop.mkConeAttr "z" value
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<System.DateTime>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: int) = Interop.mkConeAttr "z" value
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<int>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: float) = Interop.mkConeAttr "z" value
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<float>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: string) = Interop.mkConeAttr "z" value
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<string>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<seq<bool>>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<bool list>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<bool []>) = Interop.mkConeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<seq<string>>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<string list>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<string []>) = Interop.mkConeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<seq<int>>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<int list>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<int option []>) = Interop.mkConeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<seq<float>>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<float list>) = Interop.mkConeAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<float []>) = Interop.mkConeAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "z" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "z" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<bool option>) = Interop.mkConeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<System.DateTime option>) = Interop.mkConeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<int option>) = Interop.mkConeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<float option>) = Interop.mkConeAttr "z" (values |> ResizeArray)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<string option>) = Interop.mkConeAttr "z" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (value: bool) = Interop.mkConeAttr "u" value
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: System.DateTime) = Interop.mkConeAttr "u" value
    /// Sets the x components of the vector field.
    static member inline u (values: seq<System.DateTime>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: int) = Interop.mkConeAttr "u" value
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: float) = Interop.mkConeAttr "u" value
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: string) = Interop.mkConeAttr "u" value
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<bool>>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool list>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool []>) = Interop.mkConeAttr "u" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<string>>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string list>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string []>) = Interop.mkConeAttr "u" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<int>>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int list>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int option []>) = Interop.mkConeAttr "u" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<seq<float>>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float list>) = Interop.mkConeAttr "u" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float []>) = Interop.mkConeAttr "u" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "u" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "u" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool option>) = Interop.mkConeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<System.DateTime option>) = Interop.mkConeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int option>) = Interop.mkConeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float option>) = Interop.mkConeAttr "u" (values |> ResizeArray)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string option>) = Interop.mkConeAttr "u" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (value: bool) = Interop.mkConeAttr "v" value
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: System.DateTime) = Interop.mkConeAttr "v" value
    /// Sets the y components of the vector field.
    static member inline v (values: seq<System.DateTime>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: int) = Interop.mkConeAttr "v" value
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: float) = Interop.mkConeAttr "v" value
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: string) = Interop.mkConeAttr "v" value
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<bool>>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool list>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool []>) = Interop.mkConeAttr "v" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<string>>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string list>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string []>) = Interop.mkConeAttr "v" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<int>>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int list>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int option []>) = Interop.mkConeAttr "v" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<seq<float>>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float list>) = Interop.mkConeAttr "v" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float []>) = Interop.mkConeAttr "v" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "v" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "v" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool option>) = Interop.mkConeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<System.DateTime option>) = Interop.mkConeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int option>) = Interop.mkConeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float option>) = Interop.mkConeAttr "v" (values |> ResizeArray)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string option>) = Interop.mkConeAttr "v" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (value: bool) = Interop.mkConeAttr "w" value
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: System.DateTime) = Interop.mkConeAttr "w" value
    /// Sets the z components of the vector field.
    static member inline w (values: seq<System.DateTime>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: int) = Interop.mkConeAttr "w" value
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: float) = Interop.mkConeAttr "w" value
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: string) = Interop.mkConeAttr "w" value
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<bool>>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool list>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool []>) = Interop.mkConeAttr "w" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<string>>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string list>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string []>) = Interop.mkConeAttr "w" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<int>>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int list>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int option []>) = Interop.mkConeAttr "w" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<seq<float>>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float list>) = Interop.mkConeAttr "w" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float []>) = Interop.mkConeAttr "w" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkConeAttr "w" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkConeAttr "w" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool option>) = Interop.mkConeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<System.DateTime option>) = Interop.mkConeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int option>) = Interop.mkConeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float option>) = Interop.mkConeAttr "w" (values |> ResizeArray)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string option>) = Interop.mkConeAttr "w" (values |> ResizeArray)
    /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
    static member inline sizeref (value: int) = Interop.mkConeAttr "sizeref" value
    /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
    static member inline sizeref (value: float) = Interop.mkConeAttr "sizeref" value
    /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkConeAttr "text" value
    /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkConeAttr "text" (values |> ResizeArray)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkConeAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkConeAttr "hovertext" (values |> ResizeArray)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkConeAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkConeAttr "hovertemplate" (values |> ResizeArray)
    /// Determines whether or not the color domain is computed with respect to the input data (here u/v/w norm) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkConeAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkConeAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkConeAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkConeAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkConeAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkConeAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkConeAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkConeAttr "colorscale" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string list>) = Interop.mkConeAttr "colorscale" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkConeAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkConeAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkConeAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkConeAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkConeAttr "coloraxis" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkConeAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkConeAttr "opacity" value
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkConeAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkConeAttr "lighting" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IConeProperty list) = Interop.mkConeAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkConeAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkConeAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkConeAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkConeAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkConeAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkConeAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkConeAttr "zsrc" value
    /// Sets the source reference on plot.ly for  u .
    static member inline usrc (value: string) = Interop.mkConeAttr "usrc" value
    /// Sets the source reference on plot.ly for  v .
    static member inline vsrc (value: string) = Interop.mkConeAttr "vsrc" value
    /// Sets the source reference on plot.ly for  w .
    static member inline wsrc (value: string) = Interop.mkConeAttr "wsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkConeAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkConeAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkConeAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkConeAttr "hoverinfosrc" value

[<AutoOpen>]
module cone =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkConeAttr "visible" "legendonly"
        static member inline false' = Interop.mkConeAttr "visible" false
        static member inline true' = Interop.mkConeAttr "visible" true

    /// Determines whether `sizeref` is set as a *scaled* (i.e unitless) scalar (normalized by the max u/v/w norm in the vector field) or as *absolute* value (in the same units as the vector field).
    [<Erase>]
    type sizemode =
        static member inline absolute = Interop.mkConeAttr "sizemode" "absolute"
        static member inline scaled = Interop.mkConeAttr "sizemode" "scaled"

    /// Sets the cones' anchor with respect to their x/y/z positions. Note that *cm* denote the cone's center of mass which corresponds to 1/4 from the tail to tip.
    [<Erase>]
    type anchor =
        static member inline center = Interop.mkConeAttr "anchor" "center"
        static member inline cm = Interop.mkConeAttr "anchor" "cm"
        static member inline tail = Interop.mkConeAttr "anchor" "tail"
        static member inline tip = Interop.mkConeAttr "anchor" "tip"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkConeAttr "hoverinfo" "all"
        static member inline none = Interop.mkConeAttr "hoverinfo" "none"
        static member inline skip = Interop.mkConeAttr "hoverinfo" "skip"
        static member inline name = Interop.mkConeAttr "hoverinfo" "name"
        static member inline norm = Interop.mkConeAttr "hoverinfo" "norm"
        static member inline text = Interop.mkConeAttr "hoverinfo" "text"
        static member inline u = Interop.mkConeAttr "hoverinfo" "u"
        static member inline v = Interop.mkConeAttr "hoverinfo" "v"
        static member inline w = Interop.mkConeAttr "hoverinfo" "w"
        static member inline x = Interop.mkConeAttr "hoverinfo" "x"
        static member inline y = Interop.mkConeAttr "hoverinfo" "y"
        static member inline z = Interop.mkConeAttr "hoverinfo" "z"

