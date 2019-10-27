namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattergl =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScatterglAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScatterglAttr "legendgroup" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScatterglAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScatterglAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScatterglAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScatterglAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScatterglAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScatterglAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScatterglAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScatterglAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScatterglAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScatterglAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScatterglAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScatterglAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScatterglAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScatterglAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScatterglAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScatterglAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScatterglAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScatterglAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScatterglAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScatterglAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScatterglAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScatterglAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScatterglAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScatterglAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScatterglAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScatterglAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScatterglAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScatterglAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScatterglAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScatterglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScatterglAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScatterglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScatterglAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScatterglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScatterglAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScatterglAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScatterglAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: bool) = Interop.mkScatterglAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkScatterglAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: string) = Interop.mkScatterglAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkScatterglAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: int) = Interop.mkScatterglAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkScatterglAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (value: float) = Interop.mkScatterglAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkScatterglAttr "x" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkScatterglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkScatterglAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkScatterglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkScatterglAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkScatterglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkScatterglAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkScatterglAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkScatterglAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkScatterglAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkScatterglAttr "dx" value
    /// Sets the y coordinates.
    static member inline y (value: bool) = Interop.mkScatterglAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkScatterglAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: string) = Interop.mkScatterglAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkScatterglAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: int) = Interop.mkScatterglAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkScatterglAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (value: float) = Interop.mkScatterglAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkScatterglAttr "y" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkScatterglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkScatterglAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkScatterglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkScatterglAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkScatterglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkScatterglAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkScatterglAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkScatterglAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkScatterglAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkScatterglAttr "dy" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScatterglAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScatterglAttr "text" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScatterglAttr "hovertext" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScatterglAttr "hovertext" (values |> Array.ofSeq)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScatterglAttr "textfont" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkScatterglAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScatterglAttr "marker" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScatterglAttr "connectgaps" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScatterglAttr "fillcolor" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScatterglAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScatterglAttr "unselected" (createObj !!properties)
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScatterglAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScatterglAttr "opacity" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScatterglAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScatterglAttr "hovertemplate" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (value: string) = Interop.mkScatterglAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (values: seq<string>) = Interop.mkScatterglAttr "texttemplate" (values |> Array.ofSeq)
    static member inline errorX (properties: #IErrorXProperty list) = Interop.mkScatterglAttr "error_x" (createObj !!properties)
    static member inline errorY (properties: #IErrorYProperty list) = Interop.mkScatterglAttr "error_y" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkScatterglAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkScatterglAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScatterglAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScatterglAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScatterglAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScatterglAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkScatterglAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkScatterglAttr "ysrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScatterglAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScatterglAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScatterglAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScatterglAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScatterglAttr "texttemplatesrc" value

[<AutoOpen>]
module scattergl =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IScatterglProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkScatterglAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScatterglAttr "visible" "legendonly"
        static member inline false' = Interop.mkScatterglAttr "visible" "false"
        static member inline true' = Interop.mkScatterglAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScatterglAttr "hoverinfo" "all"
        static member inline none = Interop.mkScatterglAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScatterglAttr "hoverinfo" "skip"
        static member inline name = Interop.mkScatterglAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkScatterglAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkScatterglAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkScatterglAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkScatterglAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkScatterglAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkScatterglAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkScatterglAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkScatterglAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkScatterglAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkScatterglAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkScatterglAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkScatterglAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkScatterglAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkScatterglAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkScatterglAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkScatterglAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkScatterglAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkScatterglAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkScatterglAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkScatterglAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkScatterglAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkScatterglAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkScatterglAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkScatterglAttr "hoverinfo" "x"
        static member inline y = Interop.mkScatterglAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkScatterglAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkScatterglAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkScatterglAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkScatterglAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkScatterglAttr "hoverinfo" "z+y+x"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScatterglAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScatterglAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScatterglAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScatterglAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScatterglAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScatterglAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScatterglAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScatterglAttr "textposition" "top left"
        static member inline topRight = Interop.mkScatterglAttr "textposition" "top right"

    /// Determines the drawing mode for this scatter trace.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScatterglAttr "mode" "none"
        static member inline lines = Interop.mkScatterglAttr "mode" "lines"
        static member inline markers = Interop.mkScatterglAttr "mode" "markers"
        static member inline markersAndLines = Interop.mkScatterglAttr "mode" "markers+lines"
        static member inline text = Interop.mkScatterglAttr "mode" "text"
        static member inline textAndLines = Interop.mkScatterglAttr "mode" "text+lines"
        static member inline textAndMarkers = Interop.mkScatterglAttr "mode" "text+markers"
        static member inline textAndMarkersLines = Interop.mkScatterglAttr "mode" "text+markers+lines"

    /// Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScatterglAttr "fill" "none"
        static member inline tonext = Interop.mkScatterglAttr "fill" "tonext"
        static member inline tonextx = Interop.mkScatterglAttr "fill" "tonextx"
        static member inline tonexty = Interop.mkScatterglAttr "fill" "tonexty"
        static member inline toself = Interop.mkScatterglAttr "fill" "toself"
        static member inline tozerox = Interop.mkScatterglAttr "fill" "tozerox"
        static member inline tozeroy = Interop.mkScatterglAttr "fill" "tozeroy"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkScatterglAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkScatterglAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkScatterglAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkScatterglAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkScatterglAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkScatterglAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkScatterglAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkScatterglAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkScatterglAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkScatterglAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkScatterglAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkScatterglAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkScatterglAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkScatterglAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkScatterglAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkScatterglAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkScatterglAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkScatterglAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkScatterglAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkScatterglAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkScatterglAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkScatterglAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkScatterglAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkScatterglAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkScatterglAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkScatterglAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkScatterglAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkScatterglAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkScatterglAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkScatterglAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkScatterglAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkScatterglAttr "ycalendar" "ummalqura"

