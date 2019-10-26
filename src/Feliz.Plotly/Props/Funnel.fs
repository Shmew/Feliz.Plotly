namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type funnel =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkFunnelAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkFunnelAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkFunnelAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkFunnelAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkFunnelAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkFunnelAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkFunnelAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkFunnelAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkFunnelAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkFunnelAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkFunnelAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkFunnelAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkFunnelAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkFunnelAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkFunnelAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkFunnelAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkFunnelAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkFunnelAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkFunnelAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkFunnelAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkFunnelAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkFunnelAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkFunnelAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkFunnelAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkFunnelAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkFunnelAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkFunnelAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkFunnelAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkFunnelAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkFunnelAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkFunnelAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkFunnelAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkFunnelAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkFunnelAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkFunnelAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkFunnelAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkFunnelAttr "x" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: bool) = Interop.mkFunnelAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<bool>) = Interop.mkFunnelAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: string) = Interop.mkFunnelAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<string>) = Interop.mkFunnelAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: int) = Interop.mkFunnelAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<int>) = Interop.mkFunnelAttr "x0" (values |> Array.ofSeq)
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (value: float) = Interop.mkFunnelAttr "x0" value
    /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
    static member inline x0 (values: seq<float>) = Interop.mkFunnelAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: int) = Interop.mkFunnelAttr "dx" value
    /// Sets the x coordinate step. See `x0` for more info.
    static member inline dx (value: float) = Interop.mkFunnelAttr "dx" value
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkFunnelAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkFunnelAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkFunnelAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkFunnelAttr "y" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: bool) = Interop.mkFunnelAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<bool>) = Interop.mkFunnelAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: string) = Interop.mkFunnelAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<string>) = Interop.mkFunnelAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: int) = Interop.mkFunnelAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<int>) = Interop.mkFunnelAttr "y0" (values |> Array.ofSeq)
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (value: float) = Interop.mkFunnelAttr "y0" value
    /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
    static member inline y0 (values: seq<float>) = Interop.mkFunnelAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: int) = Interop.mkFunnelAttr "dy" value
    /// Sets the y coordinate step. See `y0` for more info.
    static member inline dy (value: float) = Interop.mkFunnelAttr "dy" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkFunnelAttr "hovertext" value
    /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkFunnelAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious` and `percentTotal`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkFunnelAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious` and `percentTotal`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkFunnelAttr "hovertemplate" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious`, `percentTotal`, `label` and `value`.
    static member inline texttemplate (value: string) = Interop.mkFunnelAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious`, `percentTotal`, `label` and `value`.
    static member inline texttemplate (values: seq<string>) = Interop.mkFunnelAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkFunnelAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkFunnelAttr "text" (values |> Array.ofSeq)
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: int) = Interop.mkFunnelAttr "textangle" value
    /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
    static member inline textangle (value: float) = Interop.mkFunnelAttr "textangle" value
    /// Sets the font used for `text`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkFunnelAttr "textfont" (createObj !!properties)
    /// Sets the font used for `text` lying inside the bar.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkFunnelAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `text` lying outside the bar.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkFunnelAttr "outsidetextfont" (createObj !!properties)
    /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
    static member inline cliponaxis (value: bool) = Interop.mkFunnelAttr "cliponaxis" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: int) = Interop.mkFunnelAttr "offset" value
    /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
    static member inline offset (value: float) = Interop.mkFunnelAttr "offset" value
    /// Sets the bar width (in position axis units).
    static member inline width (value: int) = Interop.mkFunnelAttr "width" value
    /// Sets the bar width (in position axis units).
    static member inline width (value: float) = Interop.mkFunnelAttr "width" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkFunnelAttr "marker" (createObj !!properties)
    static member inline connector (properties: #IConnectorProperty list) = Interop.mkFunnelAttr "connector" (createObj !!properties)
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkFunnelAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkFunnelAttr "alignmentgroup" value
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkFunnelAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkFunnelAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkFunnelAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkFunnelAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkFunnelAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkFunnelAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkFunnelAttr "ysrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkFunnelAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkFunnelAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkFunnelAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkFunnelAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkFunnelAttr "textsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkFunnelAttr "textpositionsrc" value

[<AutoOpen>]
module funnel =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IFunnelProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkFunnelAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkFunnelAttr "visible" "legendonly"
        static member inline false' = Interop.mkFunnelAttr "visible" "false"
        static member inline true' = Interop.mkFunnelAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkFunnelAttr "hoverinfo" "all"
        static member inline none = Interop.mkFunnelAttr "hoverinfo" "none"
        static member inline skip = Interop.mkFunnelAttr "hoverinfo" "skip"
        static member inline name = Interop.mkFunnelAttr "hoverinfo" "name"
        static member inline percentInitial = Interop.mkFunnelAttr "hoverinfo" "percent initial"
        static member inline percentInitialAndName = Interop.mkFunnelAttr "hoverinfo" "percent initial+name"
        static member inline percentInitialAndText = Interop.mkFunnelAttr "hoverinfo" "percent initial+text"
        static member inline percentInitialAndTextName = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+name"
        static member inline percentInitialAndTextX = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+x"
        static member inline percentInitialAndTextXName = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+x+name"
        static member inline percentInitialAndTextY = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+y"
        static member inline percentInitialAndTextYName = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+y+name"
        static member inline percentInitialAndTextYX = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+y+x"
        static member inline percentInitialAndTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent initial+text+y+x+name"
        static member inline percentInitialAndX = Interop.mkFunnelAttr "hoverinfo" "percent initial+x"
        static member inline percentInitialAndXName = Interop.mkFunnelAttr "hoverinfo" "percent initial+x+name"
        static member inline percentInitialAndY = Interop.mkFunnelAttr "hoverinfo" "percent initial+y"
        static member inline percentInitialAndYName = Interop.mkFunnelAttr "hoverinfo" "percent initial+y+name"
        static member inline percentInitialAndYX = Interop.mkFunnelAttr "hoverinfo" "percent initial+y+x"
        static member inline percentInitialAndYXName = Interop.mkFunnelAttr "hoverinfo" "percent initial+y+x+name"
        static member inline percentPrevious = Interop.mkFunnelAttr "hoverinfo" "percent previous"
        static member inline percentPreviousAndName = Interop.mkFunnelAttr "hoverinfo" "percent previous+name"
        static member inline percentPreviousAndPercentInitial = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial"
        static member inline percentPreviousAndPercentInitialName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+name"
        static member inline percentPreviousAndPercentInitialText = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text"
        static member inline percentPreviousAndPercentInitialTextName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+name"
        static member inline percentPreviousAndPercentInitialTextX = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+x"
        static member inline percentPreviousAndPercentInitialTextXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+x+name"
        static member inline percentPreviousAndPercentInitialTextY = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+y"
        static member inline percentPreviousAndPercentInitialTextYName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+y+name"
        static member inline percentPreviousAndPercentInitialTextYX = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+y+x"
        static member inline percentPreviousAndPercentInitialTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+text+y+x+name"
        static member inline percentPreviousAndPercentInitialX = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+x"
        static member inline percentPreviousAndPercentInitialXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+x+name"
        static member inline percentPreviousAndPercentInitialY = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+y"
        static member inline percentPreviousAndPercentInitialYName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+y+name"
        static member inline percentPreviousAndPercentInitialYX = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+y+x"
        static member inline percentPreviousAndPercentInitialYXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+percent initial+y+x+name"
        static member inline percentPreviousAndText = Interop.mkFunnelAttr "hoverinfo" "percent previous+text"
        static member inline percentPreviousAndTextName = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+name"
        static member inline percentPreviousAndTextX = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+x"
        static member inline percentPreviousAndTextXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+x+name"
        static member inline percentPreviousAndTextY = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+y"
        static member inline percentPreviousAndTextYName = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+y+name"
        static member inline percentPreviousAndTextYX = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+y+x"
        static member inline percentPreviousAndTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+text+y+x+name"
        static member inline percentPreviousAndX = Interop.mkFunnelAttr "hoverinfo" "percent previous+x"
        static member inline percentPreviousAndXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+x+name"
        static member inline percentPreviousAndY = Interop.mkFunnelAttr "hoverinfo" "percent previous+y"
        static member inline percentPreviousAndYName = Interop.mkFunnelAttr "hoverinfo" "percent previous+y+name"
        static member inline percentPreviousAndYX = Interop.mkFunnelAttr "hoverinfo" "percent previous+y+x"
        static member inline percentPreviousAndYXName = Interop.mkFunnelAttr "hoverinfo" "percent previous+y+x+name"
        static member inline percentTotal = Interop.mkFunnelAttr "hoverinfo" "percent total"
        static member inline percentTotalAndName = Interop.mkFunnelAttr "hoverinfo" "percent total+name"
        static member inline percentTotalAndPercentInitial = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial"
        static member inline percentTotalAndPercentInitialName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+name"
        static member inline percentTotalAndPercentInitialText = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text"
        static member inline percentTotalAndPercentInitialTextName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+name"
        static member inline percentTotalAndPercentInitialTextX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+x"
        static member inline percentTotalAndPercentInitialTextXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+x+name"
        static member inline percentTotalAndPercentInitialTextY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+y"
        static member inline percentTotalAndPercentInitialTextYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+y+name"
        static member inline percentTotalAndPercentInitialTextYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+y+x"
        static member inline percentTotalAndPercentInitialTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+text+y+x+name"
        static member inline percentTotalAndPercentInitialX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+x"
        static member inline percentTotalAndPercentInitialXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+x+name"
        static member inline percentTotalAndPercentInitialY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+y"
        static member inline percentTotalAndPercentInitialYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+y+name"
        static member inline percentTotalAndPercentInitialYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+y+x"
        static member inline percentTotalAndPercentInitialYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent initial+y+x+name"
        static member inline percentTotalAndPercentPrevious = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous"
        static member inline percentTotalAndPercentPreviousName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+name"
        static member inline percentTotalAndPercentPreviousPercentInitial = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial"
        static member inline percentTotalAndPercentPreviousPercentInitialName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+name"
        static member inline percentTotalAndPercentPreviousPercentInitialText = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text"
        static member inline percentTotalAndPercentPreviousPercentInitialTextName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+name"
        static member inline percentTotalAndPercentPreviousPercentInitialTextX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+x"
        static member inline percentTotalAndPercentPreviousPercentInitialTextXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+x+name"
        static member inline percentTotalAndPercentPreviousPercentInitialTextY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+y"
        static member inline percentTotalAndPercentPreviousPercentInitialTextYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+y+name"
        static member inline percentTotalAndPercentPreviousPercentInitialTextYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+y+x"
        static member inline percentTotalAndPercentPreviousPercentInitialTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+text+y+x+name"
        static member inline percentTotalAndPercentPreviousPercentInitialX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+x"
        static member inline percentTotalAndPercentPreviousPercentInitialXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+x+name"
        static member inline percentTotalAndPercentPreviousPercentInitialY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+y"
        static member inline percentTotalAndPercentPreviousPercentInitialYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+y+name"
        static member inline percentTotalAndPercentPreviousPercentInitialYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+y+x"
        static member inline percentTotalAndPercentPreviousPercentInitialYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+percent initial+y+x+name"
        static member inline percentTotalAndPercentPreviousText = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text"
        static member inline percentTotalAndPercentPreviousTextName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+name"
        static member inline percentTotalAndPercentPreviousTextX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+x"
        static member inline percentTotalAndPercentPreviousTextXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+x+name"
        static member inline percentTotalAndPercentPreviousTextY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+y"
        static member inline percentTotalAndPercentPreviousTextYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+y+name"
        static member inline percentTotalAndPercentPreviousTextYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+y+x"
        static member inline percentTotalAndPercentPreviousTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+text+y+x+name"
        static member inline percentTotalAndPercentPreviousX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+x"
        static member inline percentTotalAndPercentPreviousXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+x+name"
        static member inline percentTotalAndPercentPreviousY = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+y"
        static member inline percentTotalAndPercentPreviousYName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+y+name"
        static member inline percentTotalAndPercentPreviousYX = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+y+x"
        static member inline percentTotalAndPercentPreviousYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+percent previous+y+x+name"
        static member inline percentTotalAndText = Interop.mkFunnelAttr "hoverinfo" "percent total+text"
        static member inline percentTotalAndTextName = Interop.mkFunnelAttr "hoverinfo" "percent total+text+name"
        static member inline percentTotalAndTextX = Interop.mkFunnelAttr "hoverinfo" "percent total+text+x"
        static member inline percentTotalAndTextXName = Interop.mkFunnelAttr "hoverinfo" "percent total+text+x+name"
        static member inline percentTotalAndTextY = Interop.mkFunnelAttr "hoverinfo" "percent total+text+y"
        static member inline percentTotalAndTextYName = Interop.mkFunnelAttr "hoverinfo" "percent total+text+y+name"
        static member inline percentTotalAndTextYX = Interop.mkFunnelAttr "hoverinfo" "percent total+text+y+x"
        static member inline percentTotalAndTextYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+text+y+x+name"
        static member inline percentTotalAndX = Interop.mkFunnelAttr "hoverinfo" "percent total+x"
        static member inline percentTotalAndXName = Interop.mkFunnelAttr "hoverinfo" "percent total+x+name"
        static member inline percentTotalAndY = Interop.mkFunnelAttr "hoverinfo" "percent total+y"
        static member inline percentTotalAndYName = Interop.mkFunnelAttr "hoverinfo" "percent total+y+name"
        static member inline percentTotalAndYX = Interop.mkFunnelAttr "hoverinfo" "percent total+y+x"
        static member inline percentTotalAndYXName = Interop.mkFunnelAttr "hoverinfo" "percent total+y+x+name"
        static member inline text = Interop.mkFunnelAttr "hoverinfo" "text"
        static member inline textAndName = Interop.mkFunnelAttr "hoverinfo" "text+name"
        static member inline textAndX = Interop.mkFunnelAttr "hoverinfo" "text+x"
        static member inline textAndXName = Interop.mkFunnelAttr "hoverinfo" "text+x+name"
        static member inline textAndY = Interop.mkFunnelAttr "hoverinfo" "text+y"
        static member inline textAndYName = Interop.mkFunnelAttr "hoverinfo" "text+y+name"
        static member inline textAndYX = Interop.mkFunnelAttr "hoverinfo" "text+y+x"
        static member inline textAndYXName = Interop.mkFunnelAttr "hoverinfo" "text+y+x+name"
        static member inline x = Interop.mkFunnelAttr "hoverinfo" "x"
        static member inline xAndName = Interop.mkFunnelAttr "hoverinfo" "x+name"
        static member inline y = Interop.mkFunnelAttr "hoverinfo" "y"
        static member inline yAndName = Interop.mkFunnelAttr "hoverinfo" "y+name"
        static member inline yAndX = Interop.mkFunnelAttr "hoverinfo" "y+x"
        static member inline yAndXName = Interop.mkFunnelAttr "hoverinfo" "y+x+name"

    /// Determines which trace information appear on the graph. In the case of having multiple funnels, percentages & totals are computed separately (per trace).
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkFunnelAttr "textinfo" "none"
        static member inline label = Interop.mkFunnelAttr "textinfo" "label"
        static member inline percentInitial = Interop.mkFunnelAttr "textinfo" "percent initial"
        static member inline percentInitialAndLabel = Interop.mkFunnelAttr "textinfo" "percent initial+label"
        static member inline percentInitialAndText = Interop.mkFunnelAttr "textinfo" "percent initial+text"
        static member inline percentInitialAndTextLabel = Interop.mkFunnelAttr "textinfo" "percent initial+text+label"
        static member inline percentPrevious = Interop.mkFunnelAttr "textinfo" "percent previous"
        static member inline percentPreviousAndLabel = Interop.mkFunnelAttr "textinfo" "percent previous+label"
        static member inline percentPreviousAndPercentInitial = Interop.mkFunnelAttr "textinfo" "percent previous+percent initial"
        static member inline percentPreviousAndPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "percent previous+percent initial+label"
        static member inline percentPreviousAndPercentInitialText = Interop.mkFunnelAttr "textinfo" "percent previous+percent initial+text"
        static member inline percentPreviousAndPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "percent previous+percent initial+text+label"
        static member inline percentPreviousAndText = Interop.mkFunnelAttr "textinfo" "percent previous+text"
        static member inline percentPreviousAndTextLabel = Interop.mkFunnelAttr "textinfo" "percent previous+text+label"
        static member inline percentTotal = Interop.mkFunnelAttr "textinfo" "percent total"
        static member inline percentTotalAndLabel = Interop.mkFunnelAttr "textinfo" "percent total+label"
        static member inline percentTotalAndPercentInitial = Interop.mkFunnelAttr "textinfo" "percent total+percent initial"
        static member inline percentTotalAndPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent initial+label"
        static member inline percentTotalAndPercentInitialText = Interop.mkFunnelAttr "textinfo" "percent total+percent initial+text"
        static member inline percentTotalAndPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent initial+text+label"
        static member inline percentTotalAndPercentPrevious = Interop.mkFunnelAttr "textinfo" "percent total+percent previous"
        static member inline percentTotalAndPercentPreviousLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+label"
        static member inline percentTotalAndPercentPreviousPercentInitial = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+percent initial"
        static member inline percentTotalAndPercentPreviousPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+percent initial+label"
        static member inline percentTotalAndPercentPreviousPercentInitialText = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+percent initial+text"
        static member inline percentTotalAndPercentPreviousPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+percent initial+text+label"
        static member inline percentTotalAndPercentPreviousText = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+text"
        static member inline percentTotalAndPercentPreviousTextLabel = Interop.mkFunnelAttr "textinfo" "percent total+percent previous+text+label"
        static member inline percentTotalAndText = Interop.mkFunnelAttr "textinfo" "percent total+text"
        static member inline percentTotalAndTextLabel = Interop.mkFunnelAttr "textinfo" "percent total+text+label"
        static member inline text = Interop.mkFunnelAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkFunnelAttr "textinfo" "text+label"
        static member inline value = Interop.mkFunnelAttr "textinfo" "value"
        static member inline valueAndLabel = Interop.mkFunnelAttr "textinfo" "value+label"
        static member inline valueAndPercentInitial = Interop.mkFunnelAttr "textinfo" "value+percent initial"
        static member inline valueAndPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "value+percent initial+label"
        static member inline valueAndPercentInitialText = Interop.mkFunnelAttr "textinfo" "value+percent initial+text"
        static member inline valueAndPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent initial+text+label"
        static member inline valueAndPercentPrevious = Interop.mkFunnelAttr "textinfo" "value+percent previous"
        static member inline valueAndPercentPreviousLabel = Interop.mkFunnelAttr "textinfo" "value+percent previous+label"
        static member inline valueAndPercentPreviousPercentInitial = Interop.mkFunnelAttr "textinfo" "value+percent previous+percent initial"
        static member inline valueAndPercentPreviousPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "value+percent previous+percent initial+label"
        static member inline valueAndPercentPreviousPercentInitialText = Interop.mkFunnelAttr "textinfo" "value+percent previous+percent initial+text"
        static member inline valueAndPercentPreviousPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent previous+percent initial+text+label"
        static member inline valueAndPercentPreviousText = Interop.mkFunnelAttr "textinfo" "value+percent previous+text"
        static member inline valueAndPercentPreviousTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent previous+text+label"
        static member inline valueAndPercentTotal = Interop.mkFunnelAttr "textinfo" "value+percent total"
        static member inline valueAndPercentTotalLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+label"
        static member inline valueAndPercentTotalPercentInitial = Interop.mkFunnelAttr "textinfo" "value+percent total+percent initial"
        static member inline valueAndPercentTotalPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent initial+label"
        static member inline valueAndPercentTotalPercentInitialText = Interop.mkFunnelAttr "textinfo" "value+percent total+percent initial+text"
        static member inline valueAndPercentTotalPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent initial+text+label"
        static member inline valueAndPercentTotalPercentPrevious = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous"
        static member inline valueAndPercentTotalPercentPreviousLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+label"
        static member inline valueAndPercentTotalPercentPreviousPercentInitial = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+percent initial"
        static member inline valueAndPercentTotalPercentPreviousPercentInitialLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+percent initial+label"
        static member inline valueAndPercentTotalPercentPreviousPercentInitialText = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+percent initial+text"
        static member inline valueAndPercentTotalPercentPreviousPercentInitialTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+percent initial+text+label"
        static member inline valueAndPercentTotalPercentPreviousText = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+text"
        static member inline valueAndPercentTotalPercentPreviousTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+percent previous+text+label"
        static member inline valueAndPercentTotalText = Interop.mkFunnelAttr "textinfo" "value+percent total+text"
        static member inline valueAndPercentTotalTextLabel = Interop.mkFunnelAttr "textinfo" "value+percent total+text+label"
        static member inline valueAndText = Interop.mkFunnelAttr "textinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkFunnelAttr "textinfo" "value+text+label"

    /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
    [<Erase>]
    type textposition =
        static member inline auto = Interop.mkFunnelAttr "textposition" "auto"
        static member inline inside = Interop.mkFunnelAttr "textposition" "inside"
        static member inline none = Interop.mkFunnelAttr "textposition" "none"
        static member inline outside = Interop.mkFunnelAttr "textposition" "outside"

    /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
    [<Erase>]
    type insidetextanchor =
        static member inline end' = Interop.mkFunnelAttr "insidetextanchor" "end"
        static member inline middle = Interop.mkFunnelAttr "insidetextanchor" "middle"
        static member inline start = Interop.mkFunnelAttr "insidetextanchor" "start"

    /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
    [<Erase>]
    type constraintext =
        static member inline both = Interop.mkFunnelAttr "constraintext" "both"
        static member inline inside = Interop.mkFunnelAttr "constraintext" "inside"
        static member inline none = Interop.mkFunnelAttr "constraintext" "none"
        static member inline outside = Interop.mkFunnelAttr "constraintext" "outside"

    /// Sets the orientation of the funnels. With *v* (*h*), the value of the each bar spans along the vertical (horizontal). By default funnels are tend to be oriented horizontally; unless only *y* array is presented or orientation is set to *v*. Also regarding graphs including only 'horizontal' funnels, *autorange* on the *y-axis* are set to *reversed*.
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkFunnelAttr "orientation" "h"
        static member inline v = Interop.mkFunnelAttr "orientation" "v"

