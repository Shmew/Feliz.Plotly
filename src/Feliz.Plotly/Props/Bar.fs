namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type bar =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkBarAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkBarAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkBarAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkBarAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkBarAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkBarAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkBarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkBarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkBarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkBarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkBarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkBarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkBarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkBarAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkBarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkBarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkBarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkBarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkBarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkBarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkBarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkBarAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkBarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkBarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkBarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkBarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkBarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkBarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkBarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkBarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IBarProperty list) = Interop.mkBarAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkBarAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkBarAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkBarAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkBarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkBarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkBarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkBarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkBarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkBarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkBarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkBarAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkBarAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkBarAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkBarAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkBarAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkBarAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkBarAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkBarAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkBarAttr "x" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkBarAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkBarAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkBarAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkBarAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkBarAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkBarAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkBarAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkBarAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkBarAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkBarAttr "dx" value
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkBarAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkBarAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkBarAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkBarAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkBarAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkBarAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkBarAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkBarAttr "y" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkBarAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkBarAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkBarAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkBarAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkBarAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkBarAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkBarAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkBarAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkBarAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkBarAttr "dy" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkBarAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkBarAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (value: string) = Interop.mkBarAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (values: seq<string>) = Interop.mkBarAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkBarAttr "hovertext" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkBarAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkBarAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkBarAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: int) = Interop.mkBarAttr "textangle" value
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: float) = Interop.mkBarAttr "textangle" value
    /// Sets the font used for `text`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkBarAttr "textfont" (createObj !!properties)
    /// Sets the font used for `text` lying inside the bar.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkBarAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `text` lying outside the bar.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkBarAttr "outsidetextfont" (createObj !!properties)
    /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
    static member inline cliponaxis (value: bool) = Interop.mkBarAttr "cliponaxis" value
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: bool) = Interop.mkBarAttr "base" value
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<bool>) = Interop.mkBarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: string) = Interop.mkBarAttr "base" value
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<string>) = Interop.mkBarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: int) = Interop.mkBarAttr "base" value
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<int>) = Interop.mkBarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: float) = Interop.mkBarAttr "base" value
    /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<float>) = Interop.mkBarAttr "base" (values |> Array.ofSeq)
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: int) = Interop.mkBarAttr "offset" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: float) = Interop.mkBarAttr "offset" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (values: seq<int>) = Interop.mkBarAttr "offset" (values |> Array.ofSeq)
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (values: seq<float>) = Interop.mkBarAttr "offset" (values |> Array.ofSeq)
    /// Sets the bar width (in position axis units).
    static member inline width (value: int) = Interop.mkBarAttr "width" value
    /// Sets the bar width (in position axis units).
    static member inline width (value: float) = Interop.mkBarAttr "width" value
    /// Sets the bar width (in position axis units).
    static member inline width (values: seq<int>) = Interop.mkBarAttr "width" (values |> Array.ofSeq)
    /// Sets the bar width (in position axis units).
    static member inline width (values: seq<float>) = Interop.mkBarAttr "width" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkBarAttr "marker" (createObj !!properties)
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkBarAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkBarAttr "alignmentgroup" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkBarAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkBarAttr "unselected" (createObj !!properties)
    static member inline errorX (properties: #IErrorXProperty list) = Interop.mkBarAttr "error_x" (createObj !!properties)
    static member inline errorY (properties: #IErrorYProperty list) = Interop.mkBarAttr "error_y" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkBarAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkBarAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkBarAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkBarAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkBarAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkBarAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkBarAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkBarAttr "ysrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkBarAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkBarAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkBarAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkBarAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkBarAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  base .
    static member inline basesrc (value: string) = Interop.mkBarAttr "basesrc" value
    /// Sets the source reference on plot.ly for  offset .
    static member inline offsetsrc (value: string) = Interop.mkBarAttr "offsetsrc" value
    /// Sets the source reference on plot.ly for  width .
    static member inline widthsrc (value: string) = Interop.mkBarAttr "widthsrc" value
    /// Sets the source reference on plot.ly for  r .
    static member inline rsrc (value: string) = Interop.mkBarAttr "rsrc" value
    /// Sets the source reference on plot.ly for  t .
    static member inline tsrc (value: string) = Interop.mkBarAttr "tsrc" value

[<AutoOpen>]
module bar =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IBarProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkBarAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkBarAttr "visible" "legendonly"
        static member inline false' = Interop.mkBarAttr "visible" "false"
        static member inline true' = Interop.mkBarAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkBarAttr "hoverinfo" "all"
        static member inline none = Interop.mkBarAttr "hoverinfo" "none"
        static member inline skip = Interop.mkBarAttr "hoverinfo" "skip"
        static member inline name = Interop.mkBarAttr "hoverinfo" "name"
        static member inline text = Interop.mkBarAttr "hoverinfo" "text"
        static member inline x = Interop.mkBarAttr "hoverinfo" "x"
        static member inline y = Interop.mkBarAttr "hoverinfo" "y"
        static member inline z = Interop.mkBarAttr "hoverinfo" "z"

    /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
    [<Erase>]
    type textposition =
        static member inline auto = Interop.mkBarAttr "textposition" "auto"
        static member inline inside = Interop.mkBarAttr "textposition" "inside"
        static member inline none = Interop.mkBarAttr "textposition" "none"
        static member inline outside = Interop.mkBarAttr "textposition" "outside"

    /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
    [<Erase>]
    type insidetextanchor =
        static member inline end' = Interop.mkBarAttr "insidetextanchor" "end"
        static member inline middle = Interop.mkBarAttr "insidetextanchor" "middle"
        static member inline start = Interop.mkBarAttr "insidetextanchor" "start"

    /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
    [<Erase>]
    type constraintext =
        static member inline both = Interop.mkBarAttr "constraintext" "both"
        static member inline inside = Interop.mkBarAttr "constraintext" "inside"
        static member inline none = Interop.mkBarAttr "constraintext" "none"
        static member inline outside = Interop.mkBarAttr "constraintext" "outside"

    /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkBarAttr "orientation" "h"
        static member inline v = Interop.mkBarAttr "orientation" "v"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkBarAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkBarAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkBarAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkBarAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkBarAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkBarAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkBarAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkBarAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkBarAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkBarAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkBarAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkBarAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkBarAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkBarAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkBarAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkBarAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkBarAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkBarAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkBarAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkBarAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkBarAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkBarAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkBarAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkBarAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkBarAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkBarAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkBarAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkBarAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkBarAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkBarAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkBarAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkBarAttr "ycalendar" "ummalqura"

