namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type densitymapbox =
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkDensitymapboxAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkDensitymapboxAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkDensitymapboxAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkDensitymapboxAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkDensitymapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkDensitymapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkDensitymapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkDensitymapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkDensitymapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkDensitymapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkDensitymapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkDensitymapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDensitymapboxAttr "ids" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkDensitymapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkDensitymapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkDensitymapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkDensitymapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkDensitymapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkDensitymapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkDensitymapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkDensitymapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDensitymapboxAttr "customdata" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkDensitymapboxAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkDensitymapboxAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkDensitymapboxAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkDensitymapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkDensitymapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkDensitymapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkDensitymapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkDensitymapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkDensitymapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkDensitymapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkDensitymapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: bool) = Interop.mkDensitymapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool>) = Interop.mkDensitymapboxAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: string) = Interop.mkDensitymapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string>) = Interop.mkDensitymapboxAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: int) = Interop.mkDensitymapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int>) = Interop.mkDensitymapboxAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: float) = Interop.mkDensitymapboxAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float>) = Interop.mkDensitymapboxAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<bool>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool list>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool []>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<string>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string list>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string []>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<int>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int list>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int []>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<float>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float list>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float []>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDensitymapboxAttr "lon" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: bool) = Interop.mkDensitymapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool>) = Interop.mkDensitymapboxAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: string) = Interop.mkDensitymapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string>) = Interop.mkDensitymapboxAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: int) = Interop.mkDensitymapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int>) = Interop.mkDensitymapboxAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: float) = Interop.mkDensitymapboxAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float>) = Interop.mkDensitymapboxAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<bool>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool list>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool []>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<string>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string list>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string []>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<int>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int list>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int []>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<float>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float list>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float []>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDensitymapboxAttr "lat" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (value: bool) = Interop.mkDensitymapboxAttr "z" (value |> Array.singleton)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<bool>) = Interop.mkDensitymapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (value: string) = Interop.mkDensitymapboxAttr "z" (value |> Array.singleton)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<string>) = Interop.mkDensitymapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (value: int) = Interop.mkDensitymapboxAttr "z" (value |> Array.singleton)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<int>) = Interop.mkDensitymapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (value: float) = Interop.mkDensitymapboxAttr "z" (value |> Array.singleton)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<float>) = Interop.mkDensitymapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<seq<bool>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<bool list>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<bool []>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<seq<string>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<string list>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<string []>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<seq<int>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<int list>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<int []>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<seq<float>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<float list>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<float []>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the points' weight. For example, a value of 10 would be equivalent to having 10 points of weight 1 in the same spot
    static member inline z (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDensitymapboxAttr "z" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the radius of influence of one `lon` / `lat` point in pixels. Increasing the value makes the densitymapbox trace smoother, but less detailed.
    static member inline radius (value: int) = Interop.mkDensitymapboxAttr "radius" value
    /// Sets the radius of influence of one `lon` / `lat` point in pixels. Increasing the value makes the densitymapbox trace smoother, but less detailed.
    static member inline radius (value: float) = Interop.mkDensitymapboxAttr "radius" value
    /// Sets the radius of influence of one `lon` / `lat` point in pixels. Increasing the value makes the densitymapbox trace smoother, but less detailed.
    static member inline radius (values: seq<int>) = Interop.mkDensitymapboxAttr "radius" (values |> Array.ofSeq)
    /// Sets the radius of influence of one `lon` / `lat` point in pixels. Increasing the value makes the densitymapbox trace smoother, but less detailed.
    static member inline radius (values: seq<float>) = Interop.mkDensitymapboxAttr "radius" (values |> Array.ofSeq)
    /// Determines if the densitymapbox trace will be inserted before the layer with the specified ID. By default, densitymapbox traces are placed below the first layer of type symbol If set to '', the layer will be inserted above every existing layer.
    static member inline below (value: string) = Interop.mkDensitymapboxAttr "below" value
    /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkDensitymapboxAttr "text" value
    /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkDensitymapboxAttr "text" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkDensitymapboxAttr "hovertext" value
    /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkDensitymapboxAttr "hovertext" (values |> Array.ofSeq)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IDensitymapboxProperty list) = Interop.mkDensitymapboxAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkDensitymapboxAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkDensitymapboxAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkDensitymapboxAttr "zauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkDensitymapboxAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkDensitymapboxAttr "zmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkDensitymapboxAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkDensitymapboxAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkDensitymapboxAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkDensitymapboxAttr "zmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkDensitymapboxAttr "colorscale" (value |> Array.singleton)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string>) = Interop.mkDensitymapboxAttr "colorscale" (values |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkDensitymapboxAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkDensitymapboxAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkDensitymapboxAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkDensitymapboxAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkDensitymapboxAttr "coloraxis" value
    /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
    static member inline subplot (value: string) = Interop.mkDensitymapboxAttr "subplot" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkDensitymapboxAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkDensitymapboxAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkDensitymapboxAttr "metasrc" value
    /// Sets the source reference on plot.ly for  lon .
    static member inline lonsrc (value: string) = Interop.mkDensitymapboxAttr "lonsrc" value
    /// Sets the source reference on plot.ly for  lat .
    static member inline latsrc (value: string) = Interop.mkDensitymapboxAttr "latsrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkDensitymapboxAttr "zsrc" value
    /// Sets the source reference on plot.ly for  radius .
    static member inline radiussrc (value: string) = Interop.mkDensitymapboxAttr "radiussrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkDensitymapboxAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkDensitymapboxAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkDensitymapboxAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkDensitymapboxAttr "hovertemplatesrc" value

[<AutoOpen>]
module densitymapbox =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkDensitymapboxAttr "visible" "legendonly"
        static member inline false' = Interop.mkDensitymapboxAttr "visible" "false"
        static member inline true' = Interop.mkDensitymapboxAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkDensitymapboxAttr "hoverinfo" "all"
        static member inline none = Interop.mkDensitymapboxAttr "hoverinfo" "none"
        static member inline skip = Interop.mkDensitymapboxAttr "hoverinfo" "skip"
        static member inline lat = Interop.mkDensitymapboxAttr "hoverinfo" "lat"
        static member inline lon = Interop.mkDensitymapboxAttr "hoverinfo" "lon"
        static member inline name = Interop.mkDensitymapboxAttr "hoverinfo" "name"
        static member inline text = Interop.mkDensitymapboxAttr "hoverinfo" "text"
        static member inline z = Interop.mkDensitymapboxAttr "hoverinfo" "z"

