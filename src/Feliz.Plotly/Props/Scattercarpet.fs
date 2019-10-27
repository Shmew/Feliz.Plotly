namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scattercarpet =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScattercarpetAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScattercarpetAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScattercarpetAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScattercarpetAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScattercarpetAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScattercarpetAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScattercarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScattercarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScattercarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkScattercarpetAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScattercarpetAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScattercarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScattercarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScattercarpetAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkScattercarpetAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScattercarpetAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScattercarpetAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScattercarpetAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScattercarpetAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScattercarpetAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScattercarpetAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScattercarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScattercarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScattercarpetAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScattercarpetAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScattercarpetAttr "uirevision" (values |> Array.ofSeq)
    /// An identifier for this carpet, so that `scattercarpet` and `contourcarpet` traces can specify a carpet plot on which they lie
    static member inline carpet (value: string) = Interop.mkScattercarpetAttr "carpet" value
    /// Sets the a-axis coordinates.
    static member inline a (value: bool) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<bool>) = Interop.mkScattercarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the a-axis coordinates.
    static member inline a (value: string) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<string>) = Interop.mkScattercarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the a-axis coordinates.
    static member inline a (value: int) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<int>) = Interop.mkScattercarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the a-axis coordinates.
    static member inline a (value: float) = Interop.mkScattercarpetAttr "a" (value |> Array.singleton)
    /// Sets the a-axis coordinates.
    static member inline a (values: seq<float>) = Interop.mkScattercarpetAttr "a" (values |> Array.ofSeq)
    /// Sets the b-axis coordinates.
    static member inline b (value: bool) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<bool>) = Interop.mkScattercarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the b-axis coordinates.
    static member inline b (value: string) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<string>) = Interop.mkScattercarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the b-axis coordinates.
    static member inline b (value: int) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<int>) = Interop.mkScattercarpetAttr "b" (values |> Array.ofSeq)
    /// Sets the b-axis coordinates.
    static member inline b (value: float) = Interop.mkScattercarpetAttr "b" (value |> Array.singleton)
    /// Sets the b-axis coordinates.
    static member inline b (values: seq<float>) = Interop.mkScattercarpetAttr "b" (values |> Array.ofSeq)
    /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScattercarpetAttr "text" value
    /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScattercarpetAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScattercarpetAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScattercarpetAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScattercarpetAttr "hovertext" value
    /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScattercarpetAttr "hovertext" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkScattercarpetAttr "line" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScattercarpetAttr "connectgaps" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScattercarpetAttr "fillcolor" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScattercarpetAttr "marker" (createObj !!properties)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScattercarpetAttr "textfont" (createObj !!properties)
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScattercarpetAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScattercarpetAttr "unselected" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScattercarpetAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScattercarpetAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkScattercarpetAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkScattercarpetAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScattercarpetAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScattercarpetAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScattercarpetAttr "metasrc" value
    /// Sets the source reference on plot.ly for  a .
    static member inline asrc (value: string) = Interop.mkScattercarpetAttr "asrc" value
    /// Sets the source reference on plot.ly for  b .
    static member inline bsrc (value: string) = Interop.mkScattercarpetAttr "bsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScattercarpetAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScattercarpetAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScattercarpetAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScattercarpetAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScattercarpetAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScattercarpetAttr "hovertemplatesrc" value

[<AutoOpen>]
module scattercarpet =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IScattercarpetProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkScattercarpetAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScattercarpetAttr "visible" "legendonly"
        static member inline false' = Interop.mkScattercarpetAttr "visible" "false"
        static member inline true' = Interop.mkScattercarpetAttr "visible" "true"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScattercarpetAttr "mode" "none"
        static member inline lines = Interop.mkScattercarpetAttr "mode" "lines"
        static member inline markers = Interop.mkScattercarpetAttr "mode" "markers"
        static member inline markersAndLines = Interop.mkScattercarpetAttr "mode" "markers+lines"
        static member inline text = Interop.mkScattercarpetAttr "mode" "text"
        static member inline textAndLines = Interop.mkScattercarpetAttr "mode" "text+lines"
        static member inline textAndMarkers = Interop.mkScattercarpetAttr "mode" "text+markers"
        static member inline textAndMarkersLines = Interop.mkScattercarpetAttr "mode" "text+markers+lines"

    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScattercarpetAttr "fill" "none"
        static member inline tonext = Interop.mkScattercarpetAttr "fill" "tonext"
        static member inline toself = Interop.mkScattercarpetAttr "fill" "toself"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScattercarpetAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScattercarpetAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScattercarpetAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScattercarpetAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScattercarpetAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScattercarpetAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScattercarpetAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScattercarpetAttr "textposition" "top left"
        static member inline topRight = Interop.mkScattercarpetAttr "textposition" "top right"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScattercarpetAttr "hoverinfo" "all"
        static member inline none = Interop.mkScattercarpetAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScattercarpetAttr "hoverinfo" "skip"
        static member inline a = Interop.mkScattercarpetAttr "hoverinfo" "a"
        static member inline b = Interop.mkScattercarpetAttr "hoverinfo" "b"
        static member inline bAndA = Interop.mkScattercarpetAttr "hoverinfo" "b+a"
        static member inline name = Interop.mkScattercarpetAttr "hoverinfo" "name"
        static member inline nameAndA = Interop.mkScattercarpetAttr "hoverinfo" "name+a"
        static member inline nameAndB = Interop.mkScattercarpetAttr "hoverinfo" "name+b"
        static member inline nameAndBA = Interop.mkScattercarpetAttr "hoverinfo" "name+b+a"
        static member inline nameAndText = Interop.mkScattercarpetAttr "hoverinfo" "name+text"
        static member inline nameAndTextA = Interop.mkScattercarpetAttr "hoverinfo" "name+text+a"
        static member inline nameAndTextB = Interop.mkScattercarpetAttr "hoverinfo" "name+text+b"
        static member inline nameAndTextBA = Interop.mkScattercarpetAttr "hoverinfo" "name+text+b+a"
        static member inline text = Interop.mkScattercarpetAttr "hoverinfo" "text"
        static member inline textAndA = Interop.mkScattercarpetAttr "hoverinfo" "text+a"
        static member inline textAndB = Interop.mkScattercarpetAttr "hoverinfo" "text+b"
        static member inline textAndBA = Interop.mkScattercarpetAttr "hoverinfo" "text+b+a"

    /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
    [<Erase>]
    type hoveron =
        static member inline fills = Interop.mkScattercarpetAttr "hoveron" "fills"
        static member inline fillsAndPoints = Interop.mkScattercarpetAttr "hoveron" "fills+points"
        static member inline points = Interop.mkScattercarpetAttr "hoveron" "points"

