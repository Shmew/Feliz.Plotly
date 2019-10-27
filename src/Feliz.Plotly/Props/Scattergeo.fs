namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattergeo =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScattergeoAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScattergeoAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScattergeoAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScattergeoAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScattergeoAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScattergeoAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScattergeoAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkScattergeoAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkScattergeoAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScattergeoAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkScattergeoAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkScattergeoAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScattergeoAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScattergeoAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScattergeoAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScattergeoAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScattergeoAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScattergeoAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScattergeoAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScattergeoAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScattergeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScattergeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScattergeoAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScattergeoAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScattergeoAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: bool) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: string) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: int) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (value: float) = Interop.mkScattergeoAttr "lon" (value |> Array.singleton)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<bool []>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<string>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<string []>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<int>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<int []>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<seq<float>>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float list>) = Interop.mkScattergeoAttr "lon" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the longitude coordinates (in degrees East).
    static member inline lon (values: seq<float []>) = Interop.mkScattergeoAttr "lon" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: bool) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: string) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: int) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (value: float) = Interop.mkScattergeoAttr "lat" (value |> Array.singleton)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<bool []>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<string>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<string []>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<int>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<int []>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<seq<float>>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float list>) = Interop.mkScattergeoAttr "lat" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the latitude coordinates (in degrees North).
    static member inline lat (values: seq<float []>) = Interop.mkScattergeoAttr "lat" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: bool) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: string) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: int) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (value: float) = Interop.mkScattergeoAttr "locations" (value |> Array.singleton)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<bool []>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<string>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<string []>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<int>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<int []>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<seq<float>>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float list>) = Interop.mkScattergeoAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
    static member inline locations (values: seq<float []>) = Interop.mkScattergeoAttr "locations" (values |> Array.ofSeq)
    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    static member inline mode (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "mode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScattergeoAttr "text" value
    /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScattergeoAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScattergeoAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScattergeoAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScattergeoAttr "hovertext" value
    /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScattergeoAttr "hovertext" (values |> Array.ofSeq)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScattergeoAttr "textfont" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkScattergeoAttr "line" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScattergeoAttr "connectgaps" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScattergeoAttr "marker" (createObj !!properties)
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScattergeoAttr "fillcolor" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScattergeoAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScattergeoAttr "unselected" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IScattergeoProperty list) = Interop.mkScattergeoAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScattergeoAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScattergeoAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
    static member inline geo (value: string) = Interop.mkScattergeoAttr "geo" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScattergeoAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScattergeoAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScattergeoAttr "metasrc" value
    /// Sets the source reference on plot.ly for  lon .
    static member inline lonsrc (value: string) = Interop.mkScattergeoAttr "lonsrc" value
    /// Sets the source reference on plot.ly for  lat .
    static member inline latsrc (value: string) = Interop.mkScattergeoAttr "latsrc" value
    /// Sets the source reference on plot.ly for  locations .
    static member inline locationssrc (value: string) = Interop.mkScattergeoAttr "locationssrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScattergeoAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScattergeoAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScattergeoAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScattergeoAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScattergeoAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScattergeoAttr "hovertemplatesrc" value

[<AutoOpen>]
module scattergeo =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IScattergeoProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkScattergeoAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScattergeoAttr "visible" "legendonly"
        static member inline false' = Interop.mkScattergeoAttr "visible" "false"
        static member inline true' = Interop.mkScattergeoAttr "visible" "true"

    /// Determines the set of locations used to match entries in `locations` to regions on the map.
    [<Erase>]
    type locationmode =
        static member inline ISO3 = Interop.mkScattergeoAttr "locationmode" "ISO-3"
        static member inline USAStates = Interop.mkScattergeoAttr "locationmode" "USA-states"
        static member inline countryNames = Interop.mkScattergeoAttr "locationmode" "country names"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScattergeoAttr "mode" "none"
        static member inline lines = Interop.mkScattergeoAttr "mode" "lines"
        static member inline markers = Interop.mkScattergeoAttr "mode" "markers"
        static member inline text = Interop.mkScattergeoAttr "mode" "text"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScattergeoAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScattergeoAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScattergeoAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScattergeoAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScattergeoAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScattergeoAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScattergeoAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScattergeoAttr "textposition" "top left"
        static member inline topRight = Interop.mkScattergeoAttr "textposition" "top right"

    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScattergeoAttr "fill" "none"
        static member inline toself = Interop.mkScattergeoAttr "fill" "toself"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScattergeoAttr "hoverinfo" "all"
        static member inline none = Interop.mkScattergeoAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScattergeoAttr "hoverinfo" "skip"
        static member inline lat = Interop.mkScattergeoAttr "hoverinfo" "lat"
        static member inline location = Interop.mkScattergeoAttr "hoverinfo" "location"
        static member inline lon = Interop.mkScattergeoAttr "hoverinfo" "lon"
        static member inline name = Interop.mkScattergeoAttr "hoverinfo" "name"
        static member inline text = Interop.mkScattergeoAttr "hoverinfo" "text"

