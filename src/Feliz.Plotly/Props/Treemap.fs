namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type treemap =
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkTreemapAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkTreemapAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkTreemapAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkTreemapAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkTreemapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkTreemapAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkTreemapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkTreemapAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkTreemapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkTreemapAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkTreemapAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkTreemapAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkTreemapAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkTreemapAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkTreemapAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkTreemapAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkTreemapAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkTreemapAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkTreemapAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkTreemapAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkTreemapAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkTreemapAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkTreemapAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkTreemapAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkTreemapAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: bool) = Interop.mkTreemapAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<bool>) = Interop.mkTreemapAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: string) = Interop.mkTreemapAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<string>) = Interop.mkTreemapAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: int) = Interop.mkTreemapAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<int>) = Interop.mkTreemapAttr "labels" (values |> Array.ofSeq)
    /// Sets the labels of each of the sectors.
    static member inline labels (value: float) = Interop.mkTreemapAttr "labels" (value |> Array.singleton)
    /// Sets the labels of each of the sectors.
    static member inline labels (values: seq<float>) = Interop.mkTreemapAttr "labels" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: bool) = Interop.mkTreemapAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<bool>) = Interop.mkTreemapAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: string) = Interop.mkTreemapAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<string>) = Interop.mkTreemapAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: int) = Interop.mkTreemapAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<int>) = Interop.mkTreemapAttr "parents" (values |> Array.ofSeq)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (value: float) = Interop.mkTreemapAttr "parents" (value |> Array.singleton)
    /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
    static member inline parents (values: seq<float>) = Interop.mkTreemapAttr "parents" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: bool) = Interop.mkTreemapAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<bool>) = Interop.mkTreemapAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: string) = Interop.mkTreemapAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<string>) = Interop.mkTreemapAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: int) = Interop.mkTreemapAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<int>) = Interop.mkTreemapAttr "values" (values |> Array.ofSeq)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (value: float) = Interop.mkTreemapAttr "values" (value |> Array.singleton)
    /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
    static member inline values (values: seq<float>) = Interop.mkTreemapAttr "values" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: bool) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<bool>) = Interop.mkTreemapAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: string) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<string>) = Interop.mkTreemapAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: int) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<int>) = Interop.mkTreemapAttr "level" (values |> Array.ofSeq)
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (value: float) = Interop.mkTreemapAttr "level" value
    /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
    static member inline level (values: seq<float>) = Interop.mkTreemapAttr "level" (values |> Array.ofSeq)
    /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
    static member inline maxdepth (value: int) = Interop.mkTreemapAttr "maxdepth" value
    static member inline tiling (properties: #ITilingProperty list) = Interop.mkTreemapAttr "tiling" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkTreemapAttr "marker" (createObj !!properties)
    static member inline pathbar (properties: #IPathbarProperty list) = Interop.mkTreemapAttr "pathbar" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: bool) = Interop.mkTreemapAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkTreemapAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkTreemapAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkTreemapAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: int) = Interop.mkTreemapAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkTreemapAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: float) = Interop.mkTreemapAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkTreemapAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (value: string) = Interop.mkTreemapAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
    static member inline texttemplate (values: seq<string>) = Interop.mkTreemapAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkTreemapAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkTreemapAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkTreemapAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkTreemapAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkTreemapAttr "textfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkTreemapAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying outside the sector.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkTreemapAttr "outsidetextfont" (createObj !!properties)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkTreemapAttr "domain" (createObj !!properties)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkTreemapAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkTreemapAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkTreemapAttr "metasrc" value
    /// Sets the source reference on plot.ly for  labels .
    static member inline labelssrc (value: string) = Interop.mkTreemapAttr "labelssrc" value
    /// Sets the source reference on plot.ly for  parents .
    static member inline parentssrc (value: string) = Interop.mkTreemapAttr "parentssrc" value
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkTreemapAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkTreemapAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkTreemapAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkTreemapAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkTreemapAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkTreemapAttr "hovertemplatesrc" value

[<AutoOpen>]
module treemap =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkTreemapAttr "visible" "legendonly"
        static member inline false' = Interop.mkTreemapAttr "visible" "false"
        static member inline true' = Interop.mkTreemapAttr "visible" "true"

    /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
    [<Erase>]
    type branchvalues =
        static member inline remainder = Interop.mkTreemapAttr "branchvalues" "remainder"
        static member inline total = Interop.mkTreemapAttr "branchvalues" "total"

    /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
    [<Erase>]
    type count =
        static member inline branches = Interop.mkTreemapAttr "count" "branches"
        static member inline leaves = Interop.mkTreemapAttr "count" "leaves"
        static member inline leavesAndBranches = Interop.mkTreemapAttr "count" "leaves+branches"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkTreemapAttr "textinfo" "none"
        static member inline currentPath = Interop.mkTreemapAttr "textinfo" "current path"
        static member inline currentPathAndLabel = Interop.mkTreemapAttr "textinfo" "current path+label"
        static member inline currentPathAndText = Interop.mkTreemapAttr "textinfo" "current path+text"
        static member inline currentPathAndTextLabel = Interop.mkTreemapAttr "textinfo" "current path+text+label"
        static member inline currentPathAndValue = Interop.mkTreemapAttr "textinfo" "current path+value"
        static member inline currentPathAndValueLabel = Interop.mkTreemapAttr "textinfo" "current path+value+label"
        static member inline currentPathAndValueText = Interop.mkTreemapAttr "textinfo" "current path+value+text"
        static member inline currentPathAndValueTextLabel = Interop.mkTreemapAttr "textinfo" "current path+value+text+label"
        static member inline label = Interop.mkTreemapAttr "textinfo" "label"
        static member inline percentEntry = Interop.mkTreemapAttr "textinfo" "percent entry"
        static member inline percentEntryAndCurrentPath = Interop.mkTreemapAttr "textinfo" "percent entry+current path"
        static member inline percentEntryAndCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent entry+current path+label"
        static member inline percentEntryAndCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent entry+current path+text"
        static member inline percentEntryAndCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+current path+text+label"
        static member inline percentEntryAndCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent entry+current path+value"
        static member inline percentEntryAndCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent entry+current path+value+label"
        static member inline percentEntryAndCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent entry+current path+value+text"
        static member inline percentEntryAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+current path+value+text+label"
        static member inline percentEntryAndLabel = Interop.mkTreemapAttr "textinfo" "percent entry+label"
        static member inline percentEntryAndPercentRoot = Interop.mkTreemapAttr "textinfo" "percent entry+percent root"
        static member inline percentEntryAndPercentRootCurrentPath = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path"
        static member inline percentEntryAndPercentRootCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+label"
        static member inline percentEntryAndPercentRootCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+text"
        static member inline percentEntryAndPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+text+label"
        static member inline percentEntryAndPercentRootCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+value"
        static member inline percentEntryAndPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+value+label"
        static member inline percentEntryAndPercentRootCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+value+text"
        static member inline percentEntryAndPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+current path+value+text+label"
        static member inline percentEntryAndPercentRootLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+label"
        static member inline percentEntryAndPercentRootText = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+text"
        static member inline percentEntryAndPercentRootTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+text+label"
        static member inline percentEntryAndPercentRootValue = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+value"
        static member inline percentEntryAndPercentRootValueLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+value+label"
        static member inline percentEntryAndPercentRootValueText = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+value+text"
        static member inline percentEntryAndPercentRootValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+percent root+value+text+label"
        static member inline percentEntryAndText = Interop.mkTreemapAttr "textinfo" "percent entry+text"
        static member inline percentEntryAndTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+text+label"
        static member inline percentEntryAndValue = Interop.mkTreemapAttr "textinfo" "percent entry+value"
        static member inline percentEntryAndValueLabel = Interop.mkTreemapAttr "textinfo" "percent entry+value+label"
        static member inline percentEntryAndValueText = Interop.mkTreemapAttr "textinfo" "percent entry+value+text"
        static member inline percentEntryAndValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent entry+value+text+label"
        static member inline percentParent = Interop.mkTreemapAttr "textinfo" "percent parent"
        static member inline percentParentAndCurrentPath = Interop.mkTreemapAttr "textinfo" "percent parent+current path"
        static member inline percentParentAndCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent parent+current path+label"
        static member inline percentParentAndCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent parent+current path+text"
        static member inline percentParentAndCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+current path+text+label"
        static member inline percentParentAndCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent parent+current path+value"
        static member inline percentParentAndCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+current path+value+label"
        static member inline percentParentAndCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent parent+current path+value+text"
        static member inline percentParentAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+current path+value+text+label"
        static member inline percentParentAndLabel = Interop.mkTreemapAttr "textinfo" "percent parent+label"
        static member inline percentParentAndPercentEntry = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry"
        static member inline percentParentAndPercentEntryCurrentPath = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path"
        static member inline percentParentAndPercentEntryCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+label"
        static member inline percentParentAndPercentEntryCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+text"
        static member inline percentParentAndPercentEntryCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+text+label"
        static member inline percentParentAndPercentEntryCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+value"
        static member inline percentParentAndPercentEntryCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+value+label"
        static member inline percentParentAndPercentEntryCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+value+text"
        static member inline percentParentAndPercentEntryCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+current path+value+text+label"
        static member inline percentParentAndPercentEntryLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+label"
        static member inline percentParentAndPercentEntryPercentRoot = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root"
        static member inline percentParentAndPercentEntryPercentRootCurrentPath = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+current path+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+label"
        static member inline percentParentAndPercentEntryPercentRootText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+text"
        static member inline percentParentAndPercentEntryPercentRootTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+text+label"
        static member inline percentParentAndPercentEntryPercentRootValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+value"
        static member inline percentParentAndPercentEntryPercentRootValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+value+label"
        static member inline percentParentAndPercentEntryPercentRootValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+value+text"
        static member inline percentParentAndPercentEntryPercentRootValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+percent root+value+text+label"
        static member inline percentParentAndPercentEntryText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+text"
        static member inline percentParentAndPercentEntryTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+text+label"
        static member inline percentParentAndPercentEntryValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+value"
        static member inline percentParentAndPercentEntryValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+value+label"
        static member inline percentParentAndPercentEntryValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+value+text"
        static member inline percentParentAndPercentEntryValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent entry+value+text+label"
        static member inline percentParentAndPercentRoot = Interop.mkTreemapAttr "textinfo" "percent parent+percent root"
        static member inline percentParentAndPercentRootCurrentPath = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path"
        static member inline percentParentAndPercentRootCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+label"
        static member inline percentParentAndPercentRootCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+text"
        static member inline percentParentAndPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+text+label"
        static member inline percentParentAndPercentRootCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+value"
        static member inline percentParentAndPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+value+label"
        static member inline percentParentAndPercentRootCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+value+text"
        static member inline percentParentAndPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+current path+value+text+label"
        static member inline percentParentAndPercentRootLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+label"
        static member inline percentParentAndPercentRootText = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+text"
        static member inline percentParentAndPercentRootTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+text+label"
        static member inline percentParentAndPercentRootValue = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+value"
        static member inline percentParentAndPercentRootValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+value+label"
        static member inline percentParentAndPercentRootValueText = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+value+text"
        static member inline percentParentAndPercentRootValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+percent root+value+text+label"
        static member inline percentParentAndText = Interop.mkTreemapAttr "textinfo" "percent parent+text"
        static member inline percentParentAndTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+text+label"
        static member inline percentParentAndValue = Interop.mkTreemapAttr "textinfo" "percent parent+value"
        static member inline percentParentAndValueLabel = Interop.mkTreemapAttr "textinfo" "percent parent+value+label"
        static member inline percentParentAndValueText = Interop.mkTreemapAttr "textinfo" "percent parent+value+text"
        static member inline percentParentAndValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent parent+value+text+label"
        static member inline percentRoot = Interop.mkTreemapAttr "textinfo" "percent root"
        static member inline percentRootAndCurrentPath = Interop.mkTreemapAttr "textinfo" "percent root+current path"
        static member inline percentRootAndCurrentPathLabel = Interop.mkTreemapAttr "textinfo" "percent root+current path+label"
        static member inline percentRootAndCurrentPathText = Interop.mkTreemapAttr "textinfo" "percent root+current path+text"
        static member inline percentRootAndCurrentPathTextLabel = Interop.mkTreemapAttr "textinfo" "percent root+current path+text+label"
        static member inline percentRootAndCurrentPathValue = Interop.mkTreemapAttr "textinfo" "percent root+current path+value"
        static member inline percentRootAndCurrentPathValueLabel = Interop.mkTreemapAttr "textinfo" "percent root+current path+value+label"
        static member inline percentRootAndCurrentPathValueText = Interop.mkTreemapAttr "textinfo" "percent root+current path+value+text"
        static member inline percentRootAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent root+current path+value+text+label"
        static member inline percentRootAndLabel = Interop.mkTreemapAttr "textinfo" "percent root+label"
        static member inline percentRootAndText = Interop.mkTreemapAttr "textinfo" "percent root+text"
        static member inline percentRootAndTextLabel = Interop.mkTreemapAttr "textinfo" "percent root+text+label"
        static member inline percentRootAndValue = Interop.mkTreemapAttr "textinfo" "percent root+value"
        static member inline percentRootAndValueLabel = Interop.mkTreemapAttr "textinfo" "percent root+value+label"
        static member inline percentRootAndValueText = Interop.mkTreemapAttr "textinfo" "percent root+value+text"
        static member inline percentRootAndValueTextLabel = Interop.mkTreemapAttr "textinfo" "percent root+value+text+label"
        static member inline text = Interop.mkTreemapAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkTreemapAttr "textinfo" "text+label"
        static member inline value = Interop.mkTreemapAttr "textinfo" "value"
        static member inline valueAndLabel = Interop.mkTreemapAttr "textinfo" "value+label"
        static member inline valueAndText = Interop.mkTreemapAttr "textinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkTreemapAttr "textinfo" "value+text+label"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkTreemapAttr "hoverinfo" "all"
        static member inline none = Interop.mkTreemapAttr "hoverinfo" "none"
        static member inline skip = Interop.mkTreemapAttr "hoverinfo" "skip"
        static member inline currentPath = Interop.mkTreemapAttr "hoverinfo" "current path"
        static member inline currentPathAndLabel = Interop.mkTreemapAttr "hoverinfo" "current path+label"
        static member inline currentPathAndName = Interop.mkTreemapAttr "hoverinfo" "current path+name"
        static member inline currentPathAndNameLabel = Interop.mkTreemapAttr "hoverinfo" "current path+name+label"
        static member inline currentPathAndNameText = Interop.mkTreemapAttr "hoverinfo" "current path+name+text"
        static member inline currentPathAndNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "current path+name+text+label"
        static member inline currentPathAndNameValue = Interop.mkTreemapAttr "hoverinfo" "current path+name+value"
        static member inline currentPathAndNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "current path+name+value+label"
        static member inline currentPathAndNameValueText = Interop.mkTreemapAttr "hoverinfo" "current path+name+value+text"
        static member inline currentPathAndNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "current path+name+value+text+label"
        static member inline currentPathAndText = Interop.mkTreemapAttr "hoverinfo" "current path+text"
        static member inline currentPathAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "current path+text+label"
        static member inline currentPathAndValue = Interop.mkTreemapAttr "hoverinfo" "current path+value"
        static member inline currentPathAndValueLabel = Interop.mkTreemapAttr "hoverinfo" "current path+value+label"
        static member inline currentPathAndValueText = Interop.mkTreemapAttr "hoverinfo" "current path+value+text"
        static member inline currentPathAndValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "current path+value+text+label"
        static member inline label = Interop.mkTreemapAttr "hoverinfo" "label"
        static member inline name = Interop.mkTreemapAttr "hoverinfo" "name"
        static member inline nameAndLabel = Interop.mkTreemapAttr "hoverinfo" "name+label"
        static member inline nameAndText = Interop.mkTreemapAttr "hoverinfo" "name+text"
        static member inline nameAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "name+text+label"
        static member inline nameAndValue = Interop.mkTreemapAttr "hoverinfo" "name+value"
        static member inline nameAndValueLabel = Interop.mkTreemapAttr "hoverinfo" "name+value+label"
        static member inline nameAndValueText = Interop.mkTreemapAttr "hoverinfo" "name+value+text"
        static member inline nameAndValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "name+value+text+label"
        static member inline percentEntry = Interop.mkTreemapAttr "hoverinfo" "percent entry"
        static member inline percentEntryAndCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path"
        static member inline percentEntryAndCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+label"
        static member inline percentEntryAndCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name"
        static member inline percentEntryAndCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+label"
        static member inline percentEntryAndCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+text"
        static member inline percentEntryAndCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+text+label"
        static member inline percentEntryAndCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+value"
        static member inline percentEntryAndCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+value+label"
        static member inline percentEntryAndCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+value+text"
        static member inline percentEntryAndCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+name+value+text+label"
        static member inline percentEntryAndCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+text"
        static member inline percentEntryAndCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+text+label"
        static member inline percentEntryAndCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+value"
        static member inline percentEntryAndCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+value+label"
        static member inline percentEntryAndCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+value+text"
        static member inline percentEntryAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+current path+value+text+label"
        static member inline percentEntryAndLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+label"
        static member inline percentEntryAndName = Interop.mkTreemapAttr "hoverinfo" "percent entry+name"
        static member inline percentEntryAndNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+label"
        static member inline percentEntryAndNameText = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+text"
        static member inline percentEntryAndNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+text+label"
        static member inline percentEntryAndNameValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+value"
        static member inline percentEntryAndNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+value+label"
        static member inline percentEntryAndNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+value+text"
        static member inline percentEntryAndNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+name+value+text+label"
        static member inline percentEntryAndPercentRoot = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root"
        static member inline percentEntryAndPercentRootCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path"
        static member inline percentEntryAndPercentRootCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+label"
        static member inline percentEntryAndPercentRootCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name"
        static member inline percentEntryAndPercentRootCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+label"
        static member inline percentEntryAndPercentRootCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+text"
        static member inline percentEntryAndPercentRootCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+text+label"
        static member inline percentEntryAndPercentRootCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+value"
        static member inline percentEntryAndPercentRootCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+value+label"
        static member inline percentEntryAndPercentRootCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+value+text"
        static member inline percentEntryAndPercentRootCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+name+value+text+label"
        static member inline percentEntryAndPercentRootCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+text"
        static member inline percentEntryAndPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+text+label"
        static member inline percentEntryAndPercentRootCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+value"
        static member inline percentEntryAndPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+value+label"
        static member inline percentEntryAndPercentRootCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+value+text"
        static member inline percentEntryAndPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+current path+value+text+label"
        static member inline percentEntryAndPercentRootLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+label"
        static member inline percentEntryAndPercentRootName = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name"
        static member inline percentEntryAndPercentRootNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+label"
        static member inline percentEntryAndPercentRootNameText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+text"
        static member inline percentEntryAndPercentRootNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+text+label"
        static member inline percentEntryAndPercentRootNameValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+value"
        static member inline percentEntryAndPercentRootNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+value+label"
        static member inline percentEntryAndPercentRootNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+value+text"
        static member inline percentEntryAndPercentRootNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+name+value+text+label"
        static member inline percentEntryAndPercentRootText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+text"
        static member inline percentEntryAndPercentRootTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+text+label"
        static member inline percentEntryAndPercentRootValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+value"
        static member inline percentEntryAndPercentRootValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+value+label"
        static member inline percentEntryAndPercentRootValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+value+text"
        static member inline percentEntryAndPercentRootValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+percent root+value+text+label"
        static member inline percentEntryAndText = Interop.mkTreemapAttr "hoverinfo" "percent entry+text"
        static member inline percentEntryAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+text+label"
        static member inline percentEntryAndValue = Interop.mkTreemapAttr "hoverinfo" "percent entry+value"
        static member inline percentEntryAndValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+value+label"
        static member inline percentEntryAndValueText = Interop.mkTreemapAttr "hoverinfo" "percent entry+value+text"
        static member inline percentEntryAndValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent entry+value+text+label"
        static member inline percentParent = Interop.mkTreemapAttr "hoverinfo" "percent parent"
        static member inline percentParentAndCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path"
        static member inline percentParentAndCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+label"
        static member inline percentParentAndCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name"
        static member inline percentParentAndCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+label"
        static member inline percentParentAndCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+text"
        static member inline percentParentAndCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+text+label"
        static member inline percentParentAndCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+value"
        static member inline percentParentAndCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+value+label"
        static member inline percentParentAndCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+value+text"
        static member inline percentParentAndCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+name+value+text+label"
        static member inline percentParentAndCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+text"
        static member inline percentParentAndCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+text+label"
        static member inline percentParentAndCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+value"
        static member inline percentParentAndCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+value+label"
        static member inline percentParentAndCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+value+text"
        static member inline percentParentAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+current path+value+text+label"
        static member inline percentParentAndLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+label"
        static member inline percentParentAndName = Interop.mkTreemapAttr "hoverinfo" "percent parent+name"
        static member inline percentParentAndNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+label"
        static member inline percentParentAndNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+text"
        static member inline percentParentAndNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+text+label"
        static member inline percentParentAndNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+value"
        static member inline percentParentAndNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+value+label"
        static member inline percentParentAndNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+value+text"
        static member inline percentParentAndNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+name+value+text+label"
        static member inline percentParentAndPercentEntry = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry"
        static member inline percentParentAndPercentEntryCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path"
        static member inline percentParentAndPercentEntryCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+label"
        static member inline percentParentAndPercentEntryCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name"
        static member inline percentParentAndPercentEntryCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+label"
        static member inline percentParentAndPercentEntryCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+text"
        static member inline percentParentAndPercentEntryCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+text+label"
        static member inline percentParentAndPercentEntryCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+value"
        static member inline percentParentAndPercentEntryCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+value+label"
        static member inline percentParentAndPercentEntryCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+value+text"
        static member inline percentParentAndPercentEntryCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+name+value+text+label"
        static member inline percentParentAndPercentEntryCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+text"
        static member inline percentParentAndPercentEntryCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+text+label"
        static member inline percentParentAndPercentEntryCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+value"
        static member inline percentParentAndPercentEntryCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+value+label"
        static member inline percentParentAndPercentEntryCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+value+text"
        static member inline percentParentAndPercentEntryCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+current path+value+text+label"
        static member inline percentParentAndPercentEntryLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+label"
        static member inline percentParentAndPercentEntryName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name"
        static member inline percentParentAndPercentEntryNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+label"
        static member inline percentParentAndPercentEntryNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+text"
        static member inline percentParentAndPercentEntryNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+text+label"
        static member inline percentParentAndPercentEntryNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+value"
        static member inline percentParentAndPercentEntryNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+value+label"
        static member inline percentParentAndPercentEntryNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+value+text"
        static member inline percentParentAndPercentEntryNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRoot = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root"
        static member inline percentParentAndPercentEntryPercentRootCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+text+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+label"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+text"
        static member inline percentParentAndPercentEntryPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+current path+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+label"
        static member inline percentParentAndPercentEntryPercentRootName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name"
        static member inline percentParentAndPercentEntryPercentRootNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+label"
        static member inline percentParentAndPercentEntryPercentRootNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+text"
        static member inline percentParentAndPercentEntryPercentRootNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+text+label"
        static member inline percentParentAndPercentEntryPercentRootNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+value"
        static member inline percentParentAndPercentEntryPercentRootNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+label"
        static member inline percentParentAndPercentEntryPercentRootNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+text"
        static member inline percentParentAndPercentEntryPercentRootNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+name+value+text+label"
        static member inline percentParentAndPercentEntryPercentRootText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+text"
        static member inline percentParentAndPercentEntryPercentRootTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+text+label"
        static member inline percentParentAndPercentEntryPercentRootValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+value"
        static member inline percentParentAndPercentEntryPercentRootValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+value+label"
        static member inline percentParentAndPercentEntryPercentRootValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+value+text"
        static member inline percentParentAndPercentEntryPercentRootValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+percent root+value+text+label"
        static member inline percentParentAndPercentEntryText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+text"
        static member inline percentParentAndPercentEntryTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+text+label"
        static member inline percentParentAndPercentEntryValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+value"
        static member inline percentParentAndPercentEntryValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+value+label"
        static member inline percentParentAndPercentEntryValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+value+text"
        static member inline percentParentAndPercentEntryValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent entry+value+text+label"
        static member inline percentParentAndPercentRoot = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root"
        static member inline percentParentAndPercentRootCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path"
        static member inline percentParentAndPercentRootCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+label"
        static member inline percentParentAndPercentRootCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name"
        static member inline percentParentAndPercentRootCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+label"
        static member inline percentParentAndPercentRootCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+text"
        static member inline percentParentAndPercentRootCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+text+label"
        static member inline percentParentAndPercentRootCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+value"
        static member inline percentParentAndPercentRootCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+value+label"
        static member inline percentParentAndPercentRootCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+value+text"
        static member inline percentParentAndPercentRootCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+name+value+text+label"
        static member inline percentParentAndPercentRootCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+text"
        static member inline percentParentAndPercentRootCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+text+label"
        static member inline percentParentAndPercentRootCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+value"
        static member inline percentParentAndPercentRootCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+value+label"
        static member inline percentParentAndPercentRootCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+value+text"
        static member inline percentParentAndPercentRootCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+current path+value+text+label"
        static member inline percentParentAndPercentRootLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+label"
        static member inline percentParentAndPercentRootName = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name"
        static member inline percentParentAndPercentRootNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+label"
        static member inline percentParentAndPercentRootNameText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+text"
        static member inline percentParentAndPercentRootNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+text+label"
        static member inline percentParentAndPercentRootNameValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+value"
        static member inline percentParentAndPercentRootNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+value+label"
        static member inline percentParentAndPercentRootNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+value+text"
        static member inline percentParentAndPercentRootNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+name+value+text+label"
        static member inline percentParentAndPercentRootText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+text"
        static member inline percentParentAndPercentRootTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+text+label"
        static member inline percentParentAndPercentRootValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+value"
        static member inline percentParentAndPercentRootValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+value+label"
        static member inline percentParentAndPercentRootValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+value+text"
        static member inline percentParentAndPercentRootValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+percent root+value+text+label"
        static member inline percentParentAndText = Interop.mkTreemapAttr "hoverinfo" "percent parent+text"
        static member inline percentParentAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+text+label"
        static member inline percentParentAndValue = Interop.mkTreemapAttr "hoverinfo" "percent parent+value"
        static member inline percentParentAndValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+value+label"
        static member inline percentParentAndValueText = Interop.mkTreemapAttr "hoverinfo" "percent parent+value+text"
        static member inline percentParentAndValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent parent+value+text+label"
        static member inline percentRoot = Interop.mkTreemapAttr "hoverinfo" "percent root"
        static member inline percentRootAndCurrentPath = Interop.mkTreemapAttr "hoverinfo" "percent root+current path"
        static member inline percentRootAndCurrentPathLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+label"
        static member inline percentRootAndCurrentPathName = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name"
        static member inline percentRootAndCurrentPathNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+label"
        static member inline percentRootAndCurrentPathNameText = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+text"
        static member inline percentRootAndCurrentPathNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+text+label"
        static member inline percentRootAndCurrentPathNameValue = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+value"
        static member inline percentRootAndCurrentPathNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+value+label"
        static member inline percentRootAndCurrentPathNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+value+text"
        static member inline percentRootAndCurrentPathNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+name+value+text+label"
        static member inline percentRootAndCurrentPathText = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+text"
        static member inline percentRootAndCurrentPathTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+text+label"
        static member inline percentRootAndCurrentPathValue = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+value"
        static member inline percentRootAndCurrentPathValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+value+label"
        static member inline percentRootAndCurrentPathValueText = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+value+text"
        static member inline percentRootAndCurrentPathValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+current path+value+text+label"
        static member inline percentRootAndLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+label"
        static member inline percentRootAndName = Interop.mkTreemapAttr "hoverinfo" "percent root+name"
        static member inline percentRootAndNameLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+name+label"
        static member inline percentRootAndNameText = Interop.mkTreemapAttr "hoverinfo" "percent root+name+text"
        static member inline percentRootAndNameTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+name+text+label"
        static member inline percentRootAndNameValue = Interop.mkTreemapAttr "hoverinfo" "percent root+name+value"
        static member inline percentRootAndNameValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+name+value+label"
        static member inline percentRootAndNameValueText = Interop.mkTreemapAttr "hoverinfo" "percent root+name+value+text"
        static member inline percentRootAndNameValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+name+value+text+label"
        static member inline percentRootAndText = Interop.mkTreemapAttr "hoverinfo" "percent root+text"
        static member inline percentRootAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+text+label"
        static member inline percentRootAndValue = Interop.mkTreemapAttr "hoverinfo" "percent root+value"
        static member inline percentRootAndValueLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+value+label"
        static member inline percentRootAndValueText = Interop.mkTreemapAttr "hoverinfo" "percent root+value+text"
        static member inline percentRootAndValueTextLabel = Interop.mkTreemapAttr "hoverinfo" "percent root+value+text+label"
        static member inline text = Interop.mkTreemapAttr "hoverinfo" "text"
        static member inline textAndLabel = Interop.mkTreemapAttr "hoverinfo" "text+label"
        static member inline value = Interop.mkTreemapAttr "hoverinfo" "value"
        static member inline valueAndLabel = Interop.mkTreemapAttr "hoverinfo" "value+label"
        static member inline valueAndText = Interop.mkTreemapAttr "hoverinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkTreemapAttr "hoverinfo" "value+text+label"

    /// Sets the positions of the `text` elements.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkTreemapAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkTreemapAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkTreemapAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkTreemapAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkTreemapAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkTreemapAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkTreemapAttr "textposition" "top center"
        static member inline topLeft = Interop.mkTreemapAttr "textposition" "top left"
        static member inline topRight = Interop.mkTreemapAttr "textposition" "top right"

