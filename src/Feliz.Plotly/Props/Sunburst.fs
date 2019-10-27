namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type sunburst =
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkSunburstAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkSunburstAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkSunburstAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkSunburstAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkSunburstAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkSunburstAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkSunburstAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkSunburstAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkSunburstAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkSunburstAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkSunburstAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkSunburstAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkSunburstAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkSunburstAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkSunburstAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkSunburstAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkSunburstAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkSunburstAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkSunburstAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkSunburstAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkSunburstAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkSunburstAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: bool) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool>) = Interop.mkSunburstAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: string) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string>) = Interop.mkSunburstAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: int) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int>) = Interop.mkSunburstAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: float) = Interop.mkSunburstAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float>) = Interop.mkSunburstAttr "labels" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: bool) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool>) = Interop.mkSunburstAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: string) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string>) = Interop.mkSunburstAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: int) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int>) = Interop.mkSunburstAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: float) = Interop.mkSunburstAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float>) = Interop.mkSunburstAttr "parents" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: bool) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool>) = Interop.mkSunburstAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: string) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string>) = Interop.mkSunburstAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: int) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int>) = Interop.mkSunburstAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: float) = Interop.mkSunburstAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float>) = Interop.mkSunburstAttr "values" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: bool) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<bool>) = Interop.mkSunburstAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: string) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<string>) = Interop.mkSunburstAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: int) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<int>) = Interop.mkSunburstAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: float) = Interop.mkSunburstAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<float>) = Interop.mkSunburstAttr "level" (values |> Array.ofSeq)
    /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
    static member inline maxdepth (value: int) = Interop.mkSunburstAttr "maxdepth" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkSunburstAttr "marker" (createObj !!properties)
    static member inline leaf (properties: #ILeafProperty list) = Interop.mkSunburstAttr "leaf" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: bool) = Interop.mkSunburstAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkSunburstAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkSunburstAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkSunburstAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: int) = Interop.mkSunburstAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkSunburstAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: float) = Interop.mkSunburstAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkSunburstAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (value: string) = Interop.mkSunburstAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (values: seq<string>) = Interop.mkSunburstAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkSunburstAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkSunburstAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkSunburstAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkSunburstAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkSunburstAttr "textfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkSunburstAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying outside the sector.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkSunburstAttr "outsidetextfont" (createObj !!properties)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkSunburstAttr "domain" (createObj !!properties)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkSunburstAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkSunburstAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkSunburstAttr "metasrc" value
    /// Sets the source reference on plot.ly for  labels .
    static member inline labelssrc (value: string) = Interop.mkSunburstAttr "labelssrc" value
    /// Sets the source reference on plot.ly for  parents .
    static member inline parentssrc (value: string) = Interop.mkSunburstAttr "parentssrc" value
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkSunburstAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkSunburstAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkSunburstAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkSunburstAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkSunburstAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkSunburstAttr "hovertemplatesrc" value

[<AutoOpen>]
module sunburst =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkSunburstAttr "visible" "legendonly"
        static member inline false' = Interop.mkSunburstAttr "visible" "false"
        static member inline true' = Interop.mkSunburstAttr "visible" "true"

    /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
    [<Erase>]
    type branchvalues =
        static member inline remainder = Interop.mkSunburstAttr "branchvalues" "remainder"
        static member inline total = Interop.mkSunburstAttr "branchvalues" "total"

    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    [<Erase>]
    type count =
        static member inline branches = Interop.mkSunburstAttr "count" "branches"
        static member inline leaves = Interop.mkSunburstAttr "count" "leaves"
        static member inline leavesAndBranches = Interop.mkSunburstAttr "count" "leaves+branches"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkSunburstAttr "textinfo" "none"
        static member inline currentPath = Interop.mkSunburstAttr "textinfo" "current path"
        static member inline currentPathAndLabel = Interop.mkSunburstAttr "textinfo" "current path+label"
        static member inline currentPathAndText = Interop.mkSunburstAttr "textinfo" "current path+text"
        static member inline currentPathAndTextLabel = Interop.mkSunburstAttr "textinfo" "current path+text+label"
        static member inline currentPathAndValue = Interop.mkSunburstAttr "textinfo" "current path+value"
        static member inline currentPathAndValueLabel = Interop.mkSunburstAttr "textinfo" "current path+value+label"
        static member inline currentPathAndValueText = Interop.mkSunburstAttr "textinfo" "current path+value+text"
        static member inline currentPathAndValueTextLabel = Interop.mkSunburstAttr "textinfo" "current path+value+text+label"
        static member inline label = Interop.mkSunburstAttr "textinfo" "label"
        static member inline percentEntry = Interop.mkSunburstAttr "textinfo" "percent entry"
        static member inline percentEntryAndCurrentPath = Interop.mkSunburstAttr "textinfo" "percent entry+current path"
        static member inline percentEntryAndCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent entry+current path+label"
        static member inline percentEntryAndCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent entry+current path+text"
        static member inline percentEntryAndCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+current path+text+label"
        static member inline percentEntryAndCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent entry+current path+value"
        static member inline percentEntryAndCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent entry+current path+value+label"
        static member inline percentEntryAndCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent entry+current path+value+text"
        static member inline percentEntryAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+current path+value+text+label"
        static member inline percentEntryAndLabel = Interop.mkSunburstAttr "textinfo" "percent entry+label"
        static member inline percentEntryAndPercentRoot = Interop.mkSunburstAttr "textinfo" "percent entry+percent root"
        static member inline percentEntryAndPercentRootCurrentPath = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path"
        static member inline percentEntryAndPercentRootCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+label"
        static member inline percentEntryAndPercentRootCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+text"
        static member inline percentEntryAndPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+text+label"
        static member inline percentEntryAndPercentRootCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+value"
        static member inline percentEntryAndPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+value+label"
        static member inline percentEntryAndPercentRootCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+value+text"
        static member inline percentEntryAndPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+current path+value+text+label"
        static member inline percentEntryAndPercentRootLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+label"
        static member inline percentEntryAndPercentRootText = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+text"
        static member inline percentEntryAndPercentRootTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+text+label"
        static member inline percentEntryAndPercentRootValue = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+value"
        static member inline percentEntryAndPercentRootValueLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+value+label"
        static member inline percentEntryAndPercentRootValueText = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+value+text"
        static member inline percentEntryAndPercentRootValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+percent root+value+text+label"
        static member inline percentEntryAndText = Interop.mkSunburstAttr "textinfo" "percent entry+text"
        static member inline percentEntryAndTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+text+label"
        static member inline percentEntryAndValue = Interop.mkSunburstAttr "textinfo" "percent entry+value"
        static member inline percentEntryAndValueLabel = Interop.mkSunburstAttr "textinfo" "percent entry+value+label"
        static member inline percentEntryAndValueText = Interop.mkSunburstAttr "textinfo" "percent entry+value+text"
        static member inline percentEntryAndValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent entry+value+text+label"
        static member inline percentParent = Interop.mkSunburstAttr "textinfo" "percent parent"
        static member inline percentParentAndCurrentPath = Interop.mkSunburstAttr "textinfo" "percent parent+current path"
        static member inline percentParentAndCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent parent+current path+label"
        static member inline percentParentAndCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent parent+current path+text"
        static member inline percentParentAndCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+current path+text+label"
        static member inline percentParentAndCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent parent+current path+value"
        static member inline percentParentAndCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+current path+value+label"
        static member inline percentParentAndCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent parent+current path+value+text"
        static member inline percentParentAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+current path+value+text+label"
        static member inline percentParentAndLabel = Interop.mkSunburstAttr "textinfo" "percent parent+label"
        static member inline percentParentAndPercentEntry = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry"
        static member inline percentParentAndPercentEntryCurrentPath = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path"
        static member inline percentParentAndPercentEntryCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+label"
        static member inline percentParentAndPercentEntryCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+text"
        static member inline percentParentAndPercentEntryCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+text+label"
        static member inline percentParentAndPercentEntryCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+value"
        static member inline percentParentAndPercentEntryCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+value+label"
        static member inline percentParentAndPercentEntryCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+value+text"
        static member inline percentParentAndPercentEntryCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+current path+value+text+label"
        static member inline percentParentAndPercentEntryLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+label"
        static member inline percentParentAndPercentEntryPercentRoot = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root"
        static member inline percentParentAndPercentEntryPercentRootCurrentPath = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+current path+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+label"
        static member inline percentParentAndPercentEntryPercentRootText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+text"
        static member inline percentParentAndPercentEntryPercentRootTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+text+label"
        static member inline percentParentAndPercentEntryPercentRootValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+value"
        static member inline percentParentAndPercentEntryPercentRootValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+value+label"
        static member inline percentParentAndPercentEntryPercentRootValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+value+text"
        static member inline percentParentAndPercentEntryPercentRootValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+percent root+value+text+label"
        static member inline percentParentAndPercentEntryText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+text"
        static member inline percentParentAndPercentEntryTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+text+label"
        static member inline percentParentAndPercentEntryValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+value"
        static member inline percentParentAndPercentEntryValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+value+label"
        static member inline percentParentAndPercentEntryValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+value+text"
        static member inline percentParentAndPercentEntryValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent entry+value+text+label"
        static member inline percentParentAndPercentRoot = Interop.mkSunburstAttr "textinfo" "percent parent+percent root"
        static member inline percentParentAndPercentRootCurrentPath = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path"
        static member inline percentParentAndPercentRootCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+label"
        static member inline percentParentAndPercentRootCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+text"
        static member inline percentParentAndPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+text+label"
        static member inline percentParentAndPercentRootCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+value"
        static member inline percentParentAndPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+value+label"
        static member inline percentParentAndPercentRootCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+value+text"
        static member inline percentParentAndPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+current path+value+text+label"
        static member inline percentParentAndPercentRootLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+label"
        static member inline percentParentAndPercentRootText = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+text"
        static member inline percentParentAndPercentRootTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+text+label"
        static member inline percentParentAndPercentRootValue = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+value"
        static member inline percentParentAndPercentRootValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+value+label"
        static member inline percentParentAndPercentRootValueText = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+value+text"
        static member inline percentParentAndPercentRootValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+percent root+value+text+label"
        static member inline percentParentAndText = Interop.mkSunburstAttr "textinfo" "percent parent+text"
        static member inline percentParentAndTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+text+label"
        static member inline percentParentAndValue = Interop.mkSunburstAttr "textinfo" "percent parent+value"
        static member inline percentParentAndValueLabel = Interop.mkSunburstAttr "textinfo" "percent parent+value+label"
        static member inline percentParentAndValueText = Interop.mkSunburstAttr "textinfo" "percent parent+value+text"
        static member inline percentParentAndValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent parent+value+text+label"
        static member inline percentRoot = Interop.mkSunburstAttr "textinfo" "percent root"
        static member inline percentRootAndCurrentPath = Interop.mkSunburstAttr "textinfo" "percent root+current path"
        static member inline percentRootAndCurrentPathLabel = Interop.mkSunburstAttr "textinfo" "percent root+current path+label"
        static member inline percentRootAndCurrentPathText = Interop.mkSunburstAttr "textinfo" "percent root+current path+text"
        static member inline percentRootAndCurrentPathTextLabel = Interop.mkSunburstAttr "textinfo" "percent root+current path+text+label"
        static member inline percentRootAndCurrentPathValue = Interop.mkSunburstAttr "textinfo" "percent root+current path+value"
        static member inline percentRootAndCurrentPathValueLabel = Interop.mkSunburstAttr "textinfo" "percent root+current path+value+label"
        static member inline percentRootAndCurrentPathValueText = Interop.mkSunburstAttr "textinfo" "percent root+current path+value+text"
        static member inline percentRootAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent root+current path+value+text+label"
        static member inline percentRootAndLabel = Interop.mkSunburstAttr "textinfo" "percent root+label"
        static member inline percentRootAndText = Interop.mkSunburstAttr "textinfo" "percent root+text"
        static member inline percentRootAndTextLabel = Interop.mkSunburstAttr "textinfo" "percent root+text+label"
        static member inline percentRootAndValue = Interop.mkSunburstAttr "textinfo" "percent root+value"
        static member inline percentRootAndValueLabel = Interop.mkSunburstAttr "textinfo" "percent root+value+label"
        static member inline percentRootAndValueText = Interop.mkSunburstAttr "textinfo" "percent root+value+text"
        static member inline percentRootAndValueTextLabel = Interop.mkSunburstAttr "textinfo" "percent root+value+text+label"
        static member inline text = Interop.mkSunburstAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkSunburstAttr "textinfo" "text+label"
        static member inline value = Interop.mkSunburstAttr "textinfo" "value"
        static member inline valueAndLabel = Interop.mkSunburstAttr "textinfo" "value+label"
        static member inline valueAndText = Interop.mkSunburstAttr "textinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkSunburstAttr "textinfo" "value+text+label"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkSunburstAttr "hoverinfo" "all"
        static member inline none = Interop.mkSunburstAttr "hoverinfo" "none"
        static member inline skip = Interop.mkSunburstAttr "hoverinfo" "skip"
        static member inline currentPath = Interop.mkSunburstAttr "hoverinfo" "current path"
        static member inline currentPathAndLabel = Interop.mkSunburstAttr "hoverinfo" "current path+label"
        static member inline currentPathAndName = Interop.mkSunburstAttr "hoverinfo" "current path+name"
        static member inline currentPathAndNameLabel = Interop.mkSunburstAttr "hoverinfo" "current path+name+label"
        static member inline currentPathAndNameText = Interop.mkSunburstAttr "hoverinfo" "current path+name+text"
        static member inline currentPathAndNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "current path+name+text+label"
        static member inline currentPathAndNameValue = Interop.mkSunburstAttr "hoverinfo" "current path+name+value"
        static member inline currentPathAndNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "current path+name+value+label"
        static member inline currentPathAndNameValueText = Interop.mkSunburstAttr "hoverinfo" "current path+name+value+text"
        static member inline currentPathAndNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "current path+name+value+text+label"
        static member inline currentPathAndText = Interop.mkSunburstAttr "hoverinfo" "current path+text"
        static member inline currentPathAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "current path+text+label"
        static member inline currentPathAndValue = Interop.mkSunburstAttr "hoverinfo" "current path+value"
        static member inline currentPathAndValueLabel = Interop.mkSunburstAttr "hoverinfo" "current path+value+label"
        static member inline currentPathAndValueText = Interop.mkSunburstAttr "hoverinfo" "current path+value+text"
        static member inline currentPathAndValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "current path+value+text+label"
        static member inline label = Interop.mkSunburstAttr "hoverinfo" "label"
        static member inline name = Interop.mkSunburstAttr "hoverinfo" "name"
        static member inline nameAndLabel = Interop.mkSunburstAttr "hoverinfo" "name+label"
        static member inline nameAndText = Interop.mkSunburstAttr "hoverinfo" "name+text"
        static member inline nameAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "name+text+label"
        static member inline nameAndValue = Interop.mkSunburstAttr "hoverinfo" "name+value"
        static member inline nameAndValueLabel = Interop.mkSunburstAttr "hoverinfo" "name+value+label"
        static member inline nameAndValueText = Interop.mkSunburstAttr "hoverinfo" "name+value+text"
        static member inline nameAndValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "name+value+text+label"
        static member inline percentEntry = Interop.mkSunburstAttr "hoverinfo" "percent entry"
        static member inline percentEntryAndCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path"
        static member inline percentEntryAndCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+label"
        static member inline percentEntryAndCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name"
        static member inline percentEntryAndCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+label"
        static member inline percentEntryAndCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+text"
        static member inline percentEntryAndCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+text+label"
        static member inline percentEntryAndCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+value"
        static member inline percentEntryAndCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+value+label"
        static member inline percentEntryAndCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+value+text"
        static member inline percentEntryAndCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+name+value+text+label"
        static member inline percentEntryAndCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+text"
        static member inline percentEntryAndCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+text+label"
        static member inline percentEntryAndCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+value"
        static member inline percentEntryAndCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+value+label"
        static member inline percentEntryAndCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+value+text"
        static member inline percentEntryAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+current path+value+text+label"
        static member inline percentEntryAndLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+label"
        static member inline percentEntryAndName = Interop.mkSunburstAttr "hoverinfo" "percent entry+name"
        static member inline percentEntryAndNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+label"
        static member inline percentEntryAndNameText = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+text"
        static member inline percentEntryAndNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+text+label"
        static member inline percentEntryAndNameValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+value"
        static member inline percentEntryAndNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+value+label"
        static member inline percentEntryAndNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+value+text"
        static member inline percentEntryAndNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+name+value+text+label"
        static member inline percentEntryAndPercentRoot = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root"
        static member inline percentEntryAndPercentRootCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path"
        static member inline percentEntryAndPercentRootCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+label"
        static member inline percentEntryAndPercentRootCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name"
        static member inline percentEntryAndPercentRootCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+label"
        static member inline percentEntryAndPercentRootCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+text"
        static member inline percentEntryAndPercentRootCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+text+label"
        static member inline percentEntryAndPercentRootCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+value"
        static member inline percentEntryAndPercentRootCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+value+label"
        static member inline percentEntryAndPercentRootCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+value+text"
        static member inline percentEntryAndPercentRootCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+name+value+text+label"
        static member inline percentEntryAndPercentRootCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+text"
        static member inline percentEntryAndPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+text+label"
        static member inline percentEntryAndPercentRootCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+value"
        static member inline percentEntryAndPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+value+label"
        static member inline percentEntryAndPercentRootCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+value+text"
        static member inline percentEntryAndPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+current path+value+text+label"
        static member inline percentEntryAndPercentRootLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+label"
        static member inline percentEntryAndPercentRootName = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name"
        static member inline percentEntryAndPercentRootNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+label"
        static member inline percentEntryAndPercentRootNameText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+text"
        static member inline percentEntryAndPercentRootNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+text+label"
        static member inline percentEntryAndPercentRootNameValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+value"
        static member inline percentEntryAndPercentRootNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+value+label"
        static member inline percentEntryAndPercentRootNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+value+text"
        static member inline percentEntryAndPercentRootNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+name+value+text+label"
        static member inline percentEntryAndPercentRootText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+text"
        static member inline percentEntryAndPercentRootTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+text+label"
        static member inline percentEntryAndPercentRootValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+value"
        static member inline percentEntryAndPercentRootValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+value+label"
        static member inline percentEntryAndPercentRootValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+value+text"
        static member inline percentEntryAndPercentRootValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+percent root+value+text+label"
        static member inline percentEntryAndText = Interop.mkSunburstAttr "hoverinfo" "percent entry+text"
        static member inline percentEntryAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+text+label"
        static member inline percentEntryAndValue = Interop.mkSunburstAttr "hoverinfo" "percent entry+value"
        static member inline percentEntryAndValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+value+label"
        static member inline percentEntryAndValueText = Interop.mkSunburstAttr "hoverinfo" "percent entry+value+text"
        static member inline percentEntryAndValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent entry+value+text+label"
        static member inline percentParent = Interop.mkSunburstAttr "hoverinfo" "percent parent"
        static member inline percentParentAndCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path"
        static member inline percentParentAndCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+label"
        static member inline percentParentAndCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name"
        static member inline percentParentAndCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+label"
        static member inline percentParentAndCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+text"
        static member inline percentParentAndCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+text+label"
        static member inline percentParentAndCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+value"
        static member inline percentParentAndCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+value+label"
        static member inline percentParentAndCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+value+text"
        static member inline percentParentAndCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+name+value+text+label"
        static member inline percentParentAndCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+text"
        static member inline percentParentAndCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+text+label"
        static member inline percentParentAndCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+value"
        static member inline percentParentAndCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+value+label"
        static member inline percentParentAndCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+value+text"
        static member inline percentParentAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+current path+value+text+label"
        static member inline percentParentAndLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+label"
        static member inline percentParentAndName = Interop.mkSunburstAttr "hoverinfo" "percent parent+name"
        static member inline percentParentAndNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+label"
        static member inline percentParentAndNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+text"
        static member inline percentParentAndNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+text+label"
        static member inline percentParentAndNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+value"
        static member inline percentParentAndNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+value+label"
        static member inline percentParentAndNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+value+text"
        static member inline percentParentAndNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+name+value+text+label"
        static member inline percentParentAndPercentEntry = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry"
        static member inline percentParentAndPercentEntryCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path"
        static member inline percentParentAndPercentEntryCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+label"
        static member inline percentParentAndPercentEntryCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name"
        static member inline percentParentAndPercentEntryCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+label"
        static member inline percentParentAndPercentEntryCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+text"
        static member inline percentParentAndPercentEntryCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+text+label"
        static member inline percentParentAndPercentEntryCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+value"
        static member inline percentParentAndPercentEntryCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+value+label"
        static member inline percentParentAndPercentEntryCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+value+text"
        static member inline percentParentAndPercentEntryCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+name+value+text+label"
        static member inline percentParentAndPercentEntryCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+text"
        static member inline percentParentAndPercentEntryCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+text+label"
        static member inline percentParentAndPercentEntryCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+value"
        static member inline percentParentAndPercentEntryCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+value+label"
        static member inline percentParentAndPercentEntryCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+value+text"
        static member inline percentParentAndPercentEntryCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+current path+value+text+label"
        static member inline percentParentAndPercentEntryLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+label"
        static member inline percentParentAndPercentEntryName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name"
        static member inline percentParentAndPercentEntryNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+label"
        static member inline percentParentAndPercentEntryNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+text"
        static member inline percentParentAndPercentEntryNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+text+label"
        static member inline percentParentAndPercentEntryNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+value"
        static member inline percentParentAndPercentEntryNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+value+label"
        static member inline percentParentAndPercentEntryNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+value+text"
        static member inline percentParentAndPercentEntryNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRoot = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root"
        static member inline percentParentAndPercentEntryPercentRootCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+label"
        static member inline percentParentAndPercentEntryPercentRootName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name"
        static member inline percentParentAndPercentEntryPercentRootNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+label"
        static member inline percentParentAndPercentEntryPercentRootNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+text"
        static member inline percentParentAndPercentEntryPercentRootNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+text+label"
        static member inline percentParentAndPercentEntryPercentRootNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+value"
        static member inline percentParentAndPercentEntryPercentRootNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+label"
        static member inline percentParentAndPercentEntryPercentRootNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+text"
        static member inline percentParentAndPercentEntryPercentRootNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+text"
        static member inline percentParentAndPercentEntryPercentRootTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+text+label"
        static member inline percentParentAndPercentEntryPercentRootValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+value"
        static member inline percentParentAndPercentEntryPercentRootValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+value+label"
        static member inline percentParentAndPercentEntryPercentRootValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+value+text"
        static member inline percentParentAndPercentEntryPercentRootValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+percent root+value+text+label"
        static member inline percentParentAndPercentEntryText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+text"
        static member inline percentParentAndPercentEntryTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+text+label"
        static member inline percentParentAndPercentEntryValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+value"
        static member inline percentParentAndPercentEntryValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+value+label"
        static member inline percentParentAndPercentEntryValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+value+text"
        static member inline percentParentAndPercentEntryValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent entry+value+text+label"
        static member inline percentParentAndPercentRoot = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root"
        static member inline percentParentAndPercentRootCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path"
        static member inline percentParentAndPercentRootCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+label"
        static member inline percentParentAndPercentRootCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name"
        static member inline percentParentAndPercentRootCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+label"
        static member inline percentParentAndPercentRootCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+text"
        static member inline percentParentAndPercentRootCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+text+label"
        static member inline percentParentAndPercentRootCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+value"
        static member inline percentParentAndPercentRootCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+value+label"
        static member inline percentParentAndPercentRootCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+value+text"
        static member inline percentParentAndPercentRootCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+name+value+text+label"
        static member inline percentParentAndPercentRootCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+text"
        static member inline percentParentAndPercentRootCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+text+label"
        static member inline percentParentAndPercentRootCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+value"
        static member inline percentParentAndPercentRootCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+value+label"
        static member inline percentParentAndPercentRootCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+value+text"
        static member inline percentParentAndPercentRootCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+current path+value+text+label"
        static member inline percentParentAndPercentRootLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+label"
        static member inline percentParentAndPercentRootName = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name"
        static member inline percentParentAndPercentRootNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+label"
        static member inline percentParentAndPercentRootNameText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+text"
        static member inline percentParentAndPercentRootNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+text+label"
        static member inline percentParentAndPercentRootNameValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+value"
        static member inline percentParentAndPercentRootNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+value+label"
        static member inline percentParentAndPercentRootNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+value+text"
        static member inline percentParentAndPercentRootNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+name+value+text+label"
        static member inline percentParentAndPercentRootText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+text"
        static member inline percentParentAndPercentRootTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+text+label"
        static member inline percentParentAndPercentRootValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+value"
        static member inline percentParentAndPercentRootValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+value+label"
        static member inline percentParentAndPercentRootValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+value+text"
        static member inline percentParentAndPercentRootValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+percent root+value+text+label"
        static member inline percentParentAndText = Interop.mkSunburstAttr "hoverinfo" "percent parent+text"
        static member inline percentParentAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+text+label"
        static member inline percentParentAndValue = Interop.mkSunburstAttr "hoverinfo" "percent parent+value"
        static member inline percentParentAndValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+value+label"
        static member inline percentParentAndValueText = Interop.mkSunburstAttr "hoverinfo" "percent parent+value+text"
        static member inline percentParentAndValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent parent+value+text+label"
        static member inline percentRoot = Interop.mkSunburstAttr "hoverinfo" "percent root"
        static member inline percentRootAndCurrentPath = Interop.mkSunburstAttr "hoverinfo" "percent root+current path"
        static member inline percentRootAndCurrentPathLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+label"
        static member inline percentRootAndCurrentPathName = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name"
        static member inline percentRootAndCurrentPathNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+label"
        static member inline percentRootAndCurrentPathNameText = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+text"
        static member inline percentRootAndCurrentPathNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+text+label"
        static member inline percentRootAndCurrentPathNameValue = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+value"
        static member inline percentRootAndCurrentPathNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+value+label"
        static member inline percentRootAndCurrentPathNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+value+text"
        static member inline percentRootAndCurrentPathNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+name+value+text+label"
        static member inline percentRootAndCurrentPathText = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+text"
        static member inline percentRootAndCurrentPathTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+text+label"
        static member inline percentRootAndCurrentPathValue = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+value"
        static member inline percentRootAndCurrentPathValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+value+label"
        static member inline percentRootAndCurrentPathValueText = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+value+text"
        static member inline percentRootAndCurrentPathValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+current path+value+text+label"
        static member inline percentRootAndLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+label"
        static member inline percentRootAndName = Interop.mkSunburstAttr "hoverinfo" "percent root+name"
        static member inline percentRootAndNameLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+name+label"
        static member inline percentRootAndNameText = Interop.mkSunburstAttr "hoverinfo" "percent root+name+text"
        static member inline percentRootAndNameTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+name+text+label"
        static member inline percentRootAndNameValue = Interop.mkSunburstAttr "hoverinfo" "percent root+name+value"
        static member inline percentRootAndNameValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+name+value+label"
        static member inline percentRootAndNameValueText = Interop.mkSunburstAttr "hoverinfo" "percent root+name+value+text"
        static member inline percentRootAndNameValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+name+value+text+label"
        static member inline percentRootAndText = Interop.mkSunburstAttr "hoverinfo" "percent root+text"
        static member inline percentRootAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+text+label"
        static member inline percentRootAndValue = Interop.mkSunburstAttr "hoverinfo" "percent root+value"
        static member inline percentRootAndValueLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+value+label"
        static member inline percentRootAndValueText = Interop.mkSunburstAttr "hoverinfo" "percent root+value+text"
        static member inline percentRootAndValueTextLabel = Interop.mkSunburstAttr "hoverinfo" "percent root+value+text+label"
        static member inline text = Interop.mkSunburstAttr "hoverinfo" "text"
        static member inline textAndLabel = Interop.mkSunburstAttr "hoverinfo" "text+label"
        static member inline value = Interop.mkSunburstAttr "hoverinfo" "value"
        static member inline valueAndLabel = Interop.mkSunburstAttr "hoverinfo" "value+label"
        static member inline valueAndText = Interop.mkSunburstAttr "hoverinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkSunburstAttr "hoverinfo" "value+text+label"

