namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type waterfall =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkWaterfallAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkWaterfallAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkWaterfallAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkWaterfallAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkWaterfallAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkWaterfallAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkWaterfallAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkWaterfallAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkWaterfallAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkWaterfallAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkWaterfallAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkWaterfallAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkWaterfallAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkWaterfallAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkWaterfallAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkWaterfallAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkWaterfallAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkWaterfallAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkWaterfallAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkWaterfallAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkWaterfallAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkWaterfallAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkWaterfallAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkWaterfallAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkWaterfallAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkWaterfallAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkWaterfallAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkWaterfallAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkWaterfallAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkWaterfallAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkWaterfallAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkWaterfallAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkWaterfallAttr "uirevision" (values |> Array.ofSeq)
    /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
    static member inline measure (values: seq<bool>) = Interop.mkWaterfallAttr "measure" (values |> Array.ofSeq)
    /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
    static member inline measure (values: seq<string>) = Interop.mkWaterfallAttr "measure" (values |> Array.ofSeq)
    /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
    static member inline measure (values: seq<int>) = Interop.mkWaterfallAttr "measure" (values |> Array.ofSeq)
    /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
    static member inline measure (values: seq<float>) = Interop.mkWaterfallAttr "measure" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in position axis units).
    static member inline base' (value: int) = Interop.mkWaterfallAttr "base" value
    /// Sets where the bar base is drawn (in position axis units).
    static member inline base' (value: float) = Interop.mkWaterfallAttr "base" value
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkWaterfallAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkWaterfallAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkWaterfallAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkWaterfallAttr "x" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkWaterfallAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkWaterfallAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkWaterfallAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkWaterfallAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkWaterfallAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkWaterfallAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkWaterfallAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkWaterfallAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkWaterfallAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkWaterfallAttr "dx" value
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkWaterfallAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkWaterfallAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkWaterfallAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkWaterfallAttr "y" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkWaterfallAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkWaterfallAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkWaterfallAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkWaterfallAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkWaterfallAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkWaterfallAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkWaterfallAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkWaterfallAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkWaterfallAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkWaterfallAttr "dy" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkWaterfallAttr "hovertext" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkWaterfallAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta` and `final`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkWaterfallAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta` and `final`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkWaterfallAttr "hovertemplate" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta`, `final` and `label`.
    static member inline texttemplate (value: string) = Interop.mkWaterfallAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta`, `final` and `label`.
    static member inline texttemplate (values: seq<string>) = Interop.mkWaterfallAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkWaterfallAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkWaterfallAttr "text" (values |> Array.ofSeq)
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: int) = Interop.mkWaterfallAttr "textangle" value
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: float) = Interop.mkWaterfallAttr "textangle" value
    /// Sets the font used for `text`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkWaterfallAttr "textfont" (createObj !!properties)
    /// Sets the font used for `text` lying inside the bar.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkWaterfallAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `text` lying outside the bar.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkWaterfallAttr "outsidetextfont" (createObj !!properties)
    /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
    static member inline cliponaxis (value: bool) = Interop.mkWaterfallAttr "cliponaxis" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: int) = Interop.mkWaterfallAttr "offset" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: float) = Interop.mkWaterfallAttr "offset" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (values: seq<int>) = Interop.mkWaterfallAttr "offset" (values |> Array.ofSeq)
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (values: seq<float>) = Interop.mkWaterfallAttr "offset" (values |> Array.ofSeq)
    /// Sets the bar width (in position axis units).
    static member inline width (value: int) = Interop.mkWaterfallAttr "width" value
    /// Sets the bar width (in position axis units).
    static member inline width (value: float) = Interop.mkWaterfallAttr "width" value
    /// Sets the bar width (in position axis units).
    static member inline width (values: seq<int>) = Interop.mkWaterfallAttr "width" (values |> Array.ofSeq)
    /// Sets the bar width (in position axis units).
    static member inline width (values: seq<float>) = Interop.mkWaterfallAttr "width" (values |> Array.ofSeq)
    static member inline increasing (properties: #IIncreasingProperty list) = Interop.mkWaterfallAttr "increasing" (createObj !!properties)
    static member inline decreasing (properties: #IDecreasingProperty list) = Interop.mkWaterfallAttr "decreasing" (createObj !!properties)
    static member inline totals (properties: #ITotalsProperty list) = Interop.mkWaterfallAttr "totals" (createObj !!properties)
    static member inline connector (properties: #IConnectorProperty list) = Interop.mkWaterfallAttr "connector" (createObj !!properties)
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkWaterfallAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkWaterfallAttr "alignmentgroup" value
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkWaterfallAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkWaterfallAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkWaterfallAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkWaterfallAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkWaterfallAttr "metasrc" value
    /// Sets the source reference on plot.ly for  measure .
    static member inline measuresrc (value: string) = Interop.mkWaterfallAttr "measuresrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkWaterfallAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkWaterfallAttr "ysrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkWaterfallAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkWaterfallAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkWaterfallAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkWaterfallAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkWaterfallAttr "textsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkWaterfallAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  offset .
    static member inline offsetsrc (value: string) = Interop.mkWaterfallAttr "offsetsrc" value
    /// Sets the source reference on plot.ly for  width .
    static member inline widthsrc (value: string) = Interop.mkWaterfallAttr "widthsrc" value

[<AutoOpen>]
module waterfall =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IWaterfallProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkWaterfallAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkWaterfallAttr "visible" "legendonly"
        static member inline false' = Interop.mkWaterfallAttr "visible" "false"
        static member inline true' = Interop.mkWaterfallAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkWaterfallAttr "hoverinfo" "all"
        static member inline none = Interop.mkWaterfallAttr "hoverinfo" "none"
        static member inline skip = Interop.mkWaterfallAttr "hoverinfo" "skip"
        static member inline delta = Interop.mkWaterfallAttr "hoverinfo" "delta"
        static member inline deltaAndInitial = Interop.mkWaterfallAttr "hoverinfo" "delta+initial"
        static member inline deltaAndInitialName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+name"
        static member inline deltaAndInitialText = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text"
        static member inline deltaAndInitialTextName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+name"
        static member inline deltaAndInitialTextX = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+x"
        static member inline deltaAndInitialTextXName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+x+name"
        static member inline deltaAndInitialTextY = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+y"
        static member inline deltaAndInitialTextYName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+y+name"
        static member inline deltaAndInitialTextYX = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+y+x"
        static member inline deltaAndInitialTextYXName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+text+y+x+name"
        static member inline deltaAndInitialX = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+x"
        static member inline deltaAndInitialXName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+x+name"
        static member inline deltaAndInitialY = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+y"
        static member inline deltaAndInitialYName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+y+name"
        static member inline deltaAndInitialYX = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+y+x"
        static member inline deltaAndInitialYXName = Interop.mkWaterfallAttr "hoverinfo" "delta+initial+y+x+name"
        static member inline deltaAndName = Interop.mkWaterfallAttr "hoverinfo" "delta+name"
        static member inline deltaAndText = Interop.mkWaterfallAttr "hoverinfo" "delta+text"
        static member inline deltaAndTextName = Interop.mkWaterfallAttr "hoverinfo" "delta+text+name"
        static member inline deltaAndTextX = Interop.mkWaterfallAttr "hoverinfo" "delta+text+x"
        static member inline deltaAndTextXName = Interop.mkWaterfallAttr "hoverinfo" "delta+text+x+name"
        static member inline deltaAndTextY = Interop.mkWaterfallAttr "hoverinfo" "delta+text+y"
        static member inline deltaAndTextYName = Interop.mkWaterfallAttr "hoverinfo" "delta+text+y+name"
        static member inline deltaAndTextYX = Interop.mkWaterfallAttr "hoverinfo" "delta+text+y+x"
        static member inline deltaAndTextYXName = Interop.mkWaterfallAttr "hoverinfo" "delta+text+y+x+name"
        static member inline deltaAndX = Interop.mkWaterfallAttr "hoverinfo" "delta+x"
        static member inline deltaAndXName = Interop.mkWaterfallAttr "hoverinfo" "delta+x+name"
        static member inline deltaAndY = Interop.mkWaterfallAttr "hoverinfo" "delta+y"
        static member inline deltaAndYName = Interop.mkWaterfallAttr "hoverinfo" "delta+y+name"
        static member inline deltaAndYX = Interop.mkWaterfallAttr "hoverinfo" "delta+y+x"
        static member inline deltaAndYXName = Interop.mkWaterfallAttr "hoverinfo" "delta+y+x+name"
        static member inline final = Interop.mkWaterfallAttr "hoverinfo" "final"
        static member inline finalAndDelta = Interop.mkWaterfallAttr "hoverinfo" "final+delta"
        static member inline finalAndDeltaInitial = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial"
        static member inline finalAndDeltaInitialName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+name"
        static member inline finalAndDeltaInitialText = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text"
        static member inline finalAndDeltaInitialTextName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+name"
        static member inline finalAndDeltaInitialTextX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+x"
        static member inline finalAndDeltaInitialTextXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+x+name"
        static member inline finalAndDeltaInitialTextY = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+y"
        static member inline finalAndDeltaInitialTextYName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+y+name"
        static member inline finalAndDeltaInitialTextYX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+y+x"
        static member inline finalAndDeltaInitialTextYXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+text+y+x+name"
        static member inline finalAndDeltaInitialX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+x"
        static member inline finalAndDeltaInitialXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+x+name"
        static member inline finalAndDeltaInitialY = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+y"
        static member inline finalAndDeltaInitialYName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+y+name"
        static member inline finalAndDeltaInitialYX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+y+x"
        static member inline finalAndDeltaInitialYXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+initial+y+x+name"
        static member inline finalAndDeltaName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+name"
        static member inline finalAndDeltaText = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text"
        static member inline finalAndDeltaTextName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+name"
        static member inline finalAndDeltaTextX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+x"
        static member inline finalAndDeltaTextXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+x+name"
        static member inline finalAndDeltaTextY = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+y"
        static member inline finalAndDeltaTextYName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+y+name"
        static member inline finalAndDeltaTextYX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+y+x"
        static member inline finalAndDeltaTextYXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+text+y+x+name"
        static member inline finalAndDeltaX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+x"
        static member inline finalAndDeltaXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+x+name"
        static member inline finalAndDeltaY = Interop.mkWaterfallAttr "hoverinfo" "final+delta+y"
        static member inline finalAndDeltaYName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+y+name"
        static member inline finalAndDeltaYX = Interop.mkWaterfallAttr "hoverinfo" "final+delta+y+x"
        static member inline finalAndDeltaYXName = Interop.mkWaterfallAttr "hoverinfo" "final+delta+y+x+name"
        static member inline finalAndInitial = Interop.mkWaterfallAttr "hoverinfo" "final+initial"
        static member inline finalAndInitialName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+name"
        static member inline finalAndInitialText = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text"
        static member inline finalAndInitialTextName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+name"
        static member inline finalAndInitialTextX = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+x"
        static member inline finalAndInitialTextXName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+x+name"
        static member inline finalAndInitialTextY = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+y"
        static member inline finalAndInitialTextYName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+y+name"
        static member inline finalAndInitialTextYX = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+y+x"
        static member inline finalAndInitialTextYXName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+text+y+x+name"
        static member inline finalAndInitialX = Interop.mkWaterfallAttr "hoverinfo" "final+initial+x"
        static member inline finalAndInitialXName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+x+name"
        static member inline finalAndInitialY = Interop.mkWaterfallAttr "hoverinfo" "final+initial+y"
        static member inline finalAndInitialYName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+y+name"
        static member inline finalAndInitialYX = Interop.mkWaterfallAttr "hoverinfo" "final+initial+y+x"
        static member inline finalAndInitialYXName = Interop.mkWaterfallAttr "hoverinfo" "final+initial+y+x+name"
        static member inline finalAndName = Interop.mkWaterfallAttr "hoverinfo" "final+name"
        static member inline finalAndText = Interop.mkWaterfallAttr "hoverinfo" "final+text"
        static member inline finalAndTextName = Interop.mkWaterfallAttr "hoverinfo" "final+text+name"
        static member inline finalAndTextX = Interop.mkWaterfallAttr "hoverinfo" "final+text+x"
        static member inline finalAndTextXName = Interop.mkWaterfallAttr "hoverinfo" "final+text+x+name"
        static member inline finalAndTextY = Interop.mkWaterfallAttr "hoverinfo" "final+text+y"
        static member inline finalAndTextYName = Interop.mkWaterfallAttr "hoverinfo" "final+text+y+name"
        static member inline finalAndTextYX = Interop.mkWaterfallAttr "hoverinfo" "final+text+y+x"
        static member inline finalAndTextYXName = Interop.mkWaterfallAttr "hoverinfo" "final+text+y+x+name"
        static member inline finalAndX = Interop.mkWaterfallAttr "hoverinfo" "final+x"
        static member inline finalAndXName = Interop.mkWaterfallAttr "hoverinfo" "final+x+name"
        static member inline finalAndY = Interop.mkWaterfallAttr "hoverinfo" "final+y"
        static member inline finalAndYName = Interop.mkWaterfallAttr "hoverinfo" "final+y+name"
        static member inline finalAndYX = Interop.mkWaterfallAttr "hoverinfo" "final+y+x"
        static member inline finalAndYXName = Interop.mkWaterfallAttr "hoverinfo" "final+y+x+name"
        static member inline initial = Interop.mkWaterfallAttr "hoverinfo" "initial"
        static member inline initialAndName = Interop.mkWaterfallAttr "hoverinfo" "initial+name"
        static member inline initialAndText = Interop.mkWaterfallAttr "hoverinfo" "initial+text"
        static member inline initialAndTextName = Interop.mkWaterfallAttr "hoverinfo" "initial+text+name"
        static member inline initialAndTextX = Interop.mkWaterfallAttr "hoverinfo" "initial+text+x"
        static member inline initialAndTextXName = Interop.mkWaterfallAttr "hoverinfo" "initial+text+x+name"
        static member inline initialAndTextY = Interop.mkWaterfallAttr "hoverinfo" "initial+text+y"
        static member inline initialAndTextYName = Interop.mkWaterfallAttr "hoverinfo" "initial+text+y+name"
        static member inline initialAndTextYX = Interop.mkWaterfallAttr "hoverinfo" "initial+text+y+x"
        static member inline initialAndTextYXName = Interop.mkWaterfallAttr "hoverinfo" "initial+text+y+x+name"
        static member inline initialAndX = Interop.mkWaterfallAttr "hoverinfo" "initial+x"
        static member inline initialAndXName = Interop.mkWaterfallAttr "hoverinfo" "initial+x+name"
        static member inline initialAndY = Interop.mkWaterfallAttr "hoverinfo" "initial+y"
        static member inline initialAndYName = Interop.mkWaterfallAttr "hoverinfo" "initial+y+name"
        static member inline initialAndYX = Interop.mkWaterfallAttr "hoverinfo" "initial+y+x"
        static member inline initialAndYXName = Interop.mkWaterfallAttr "hoverinfo" "initial+y+x+name"
        static member inline name = Interop.mkWaterfallAttr "hoverinfo" "name"
        static member inline text = Interop.mkWaterfallAttr "hoverinfo" "text"
        static member inline textAndName = Interop.mkWaterfallAttr "hoverinfo" "text+name"
        static member inline textAndX = Interop.mkWaterfallAttr "hoverinfo" "text+x"
        static member inline textAndXName = Interop.mkWaterfallAttr "hoverinfo" "text+x+name"
        static member inline textAndY = Interop.mkWaterfallAttr "hoverinfo" "text+y"
        static member inline textAndYName = Interop.mkWaterfallAttr "hoverinfo" "text+y+name"
        static member inline textAndYX = Interop.mkWaterfallAttr "hoverinfo" "text+y+x"
        static member inline textAndYXName = Interop.mkWaterfallAttr "hoverinfo" "text+y+x+name"
        static member inline x = Interop.mkWaterfallAttr "hoverinfo" "x"
        static member inline xAndName = Interop.mkWaterfallAttr "hoverinfo" "x+name"
        static member inline y = Interop.mkWaterfallAttr "hoverinfo" "y"
        static member inline yAndName = Interop.mkWaterfallAttr "hoverinfo" "y+name"
        static member inline yAndX = Interop.mkWaterfallAttr "hoverinfo" "y+x"
        static member inline yAndXName = Interop.mkWaterfallAttr "hoverinfo" "y+x+name"

    /// Determines which trace information appear on the graph. In the case of having multiple waterfalls, totals are computed separately (per trace).
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkWaterfallAttr "textinfo" "none"
        static member inline delta = Interop.mkWaterfallAttr "textinfo" "delta"
        static member inline deltaAndInitial = Interop.mkWaterfallAttr "textinfo" "delta+initial"
        static member inline deltaAndInitialLabel = Interop.mkWaterfallAttr "textinfo" "delta+initial+label"
        static member inline deltaAndInitialText = Interop.mkWaterfallAttr "textinfo" "delta+initial+text"
        static member inline deltaAndInitialTextLabel = Interop.mkWaterfallAttr "textinfo" "delta+initial+text+label"
        static member inline deltaAndLabel = Interop.mkWaterfallAttr "textinfo" "delta+label"
        static member inline deltaAndText = Interop.mkWaterfallAttr "textinfo" "delta+text"
        static member inline deltaAndTextLabel = Interop.mkWaterfallAttr "textinfo" "delta+text+label"
        static member inline final = Interop.mkWaterfallAttr "textinfo" "final"
        static member inline finalAndDelta = Interop.mkWaterfallAttr "textinfo" "final+delta"
        static member inline finalAndDeltaInitial = Interop.mkWaterfallAttr "textinfo" "final+delta+initial"
        static member inline finalAndDeltaInitialLabel = Interop.mkWaterfallAttr "textinfo" "final+delta+initial+label"
        static member inline finalAndDeltaInitialText = Interop.mkWaterfallAttr "textinfo" "final+delta+initial+text"
        static member inline finalAndDeltaInitialTextLabel = Interop.mkWaterfallAttr "textinfo" "final+delta+initial+text+label"
        static member inline finalAndDeltaLabel = Interop.mkWaterfallAttr "textinfo" "final+delta+label"
        static member inline finalAndDeltaText = Interop.mkWaterfallAttr "textinfo" "final+delta+text"
        static member inline finalAndDeltaTextLabel = Interop.mkWaterfallAttr "textinfo" "final+delta+text+label"
        static member inline finalAndInitial = Interop.mkWaterfallAttr "textinfo" "final+initial"
        static member inline finalAndInitialLabel = Interop.mkWaterfallAttr "textinfo" "final+initial+label"
        static member inline finalAndInitialText = Interop.mkWaterfallAttr "textinfo" "final+initial+text"
        static member inline finalAndInitialTextLabel = Interop.mkWaterfallAttr "textinfo" "final+initial+text+label"
        static member inline finalAndLabel = Interop.mkWaterfallAttr "textinfo" "final+label"
        static member inline finalAndText = Interop.mkWaterfallAttr "textinfo" "final+text"
        static member inline finalAndTextLabel = Interop.mkWaterfallAttr "textinfo" "final+text+label"
        static member inline initial = Interop.mkWaterfallAttr "textinfo" "initial"
        static member inline initialAndLabel = Interop.mkWaterfallAttr "textinfo" "initial+label"
        static member inline initialAndText = Interop.mkWaterfallAttr "textinfo" "initial+text"
        static member inline initialAndTextLabel = Interop.mkWaterfallAttr "textinfo" "initial+text+label"
        static member inline label = Interop.mkWaterfallAttr "textinfo" "label"
        static member inline text = Interop.mkWaterfallAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkWaterfallAttr "textinfo" "text+label"

    /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
    [<Erase>]
    type textposition =
        static member inline auto = Interop.mkWaterfallAttr "textposition" "auto"
        static member inline inside = Interop.mkWaterfallAttr "textposition" "inside"
        static member inline none = Interop.mkWaterfallAttr "textposition" "none"
        static member inline outside = Interop.mkWaterfallAttr "textposition" "outside"

    /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
    [<Erase>]
    type insidetextanchor =
        static member inline end' = Interop.mkWaterfallAttr "insidetextanchor" "end"
        static member inline middle = Interop.mkWaterfallAttr "insidetextanchor" "middle"
        static member inline start = Interop.mkWaterfallAttr "insidetextanchor" "start"

    /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
    [<Erase>]
    type constraintext =
        static member inline both = Interop.mkWaterfallAttr "constraintext" "both"
        static member inline inside = Interop.mkWaterfallAttr "constraintext" "inside"
        static member inline none = Interop.mkWaterfallAttr "constraintext" "none"
        static member inline outside = Interop.mkWaterfallAttr "constraintext" "outside"

    /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkWaterfallAttr "orientation" "h"
        static member inline v = Interop.mkWaterfallAttr "orientation" "v"

