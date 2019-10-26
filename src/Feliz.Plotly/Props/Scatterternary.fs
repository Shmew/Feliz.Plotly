namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scatterternary =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScatterternaryAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScatterternaryAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScatterternaryAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScatterternaryAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScatterternaryAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScatterternaryAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScatterternaryAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScatterternaryAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScatterternaryAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScatterternaryAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScatterternaryAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScatterternaryAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScatterternaryAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScatterternaryAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkScatterternaryAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkScatterternaryAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkScatterternaryAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkScatterternaryAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkScatterternaryAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkScatterternaryAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkScatterternaryAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkScatterternaryAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScatterternaryAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScatterternaryAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScatterternaryAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScatterternaryAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScatterternaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScatterternaryAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScatterternaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScatterternaryAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScatterternaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScatterternaryAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScatterternaryAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline a (values: seq<bool>) = Interop.mkScatterternaryAttr "a" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline a (values: seq<string>) = Interop.mkScatterternaryAttr "a" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline a (values: seq<int>) = Interop.mkScatterternaryAttr "a" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline a (values: seq<float>) = Interop.mkScatterternaryAttr "a" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline b (values: seq<bool>) = Interop.mkScatterternaryAttr "b" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline b (values: seq<string>) = Interop.mkScatterternaryAttr "b" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline b (values: seq<int>) = Interop.mkScatterternaryAttr "b" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline b (values: seq<float>) = Interop.mkScatterternaryAttr "b" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline c (values: seq<bool>) = Interop.mkScatterternaryAttr "c" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline c (values: seq<string>) = Interop.mkScatterternaryAttr "c" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline c (values: seq<int>) = Interop.mkScatterternaryAttr "c" (values |> Array.ofSeq)
    /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
    static member inline c (values: seq<float>) = Interop.mkScatterternaryAttr "c" (values |> Array.ofSeq)
    /// The number each triplet should sum to, if only two of `a`, `b`, and `c` are provided. This overrides `ternary<i>.sum` to normalize this specific trace, but does not affect the values displayed on the axes. 0 (or missing) means to use ternary<i>.sum
    static member inline sum (value: int) = Interop.mkScatterternaryAttr "sum" value
    /// The number each triplet should sum to, if only two of `a`, `b`, and `c` are provided. This overrides `ternary<i>.sum` to normalize this specific trace, but does not affect the values displayed on the axes. 0 (or missing) means to use ternary<i>.sum
    static member inline sum (value: float) = Interop.mkScatterternaryAttr "sum" value
    /// Sets text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScatterternaryAttr "text" value
    /// Sets text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScatterternaryAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b`, `c` and `text`.
    static member inline texttemplate (value: string) = Interop.mkScatterternaryAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b`, `c` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkScatterternaryAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScatterternaryAttr "hovertext" value
    /// Sets hover text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScatterternaryAttr "hovertext" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkScatterternaryAttr "line" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScatterternaryAttr "connectgaps" value
    /// Determines whether or not markers and text nodes are clipped about the subplot axes. To show markers and text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
    static member inline cliponaxis (value: bool) = Interop.mkScatterternaryAttr "cliponaxis" value
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkScatterternaryAttr "fillcolor" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScatterternaryAttr "marker" (createObj !!properties)
    /// Sets the text font.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScatterternaryAttr "textfont" (createObj !!properties)
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkScatterternaryAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkScatterternaryAttr "unselected" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScatterternaryAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScatterternaryAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets a reference between this trace's data coordinates and a ternary subplot. If *ternary* (the default value), the data refer to `layout.ternary`. If *ternary2*, the data refer to `layout.ternary2`, and so on.
    static member inline subplot (values: seq<string>) = Interop.mkScatterternaryAttr "subplot" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScatterternaryAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScatterternaryAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScatterternaryAttr "metasrc" value
    /// Sets the source reference on plot.ly for  a .
    static member inline asrc (value: string) = Interop.mkScatterternaryAttr "asrc" value
    /// Sets the source reference on plot.ly for  b .
    static member inline bsrc (value: string) = Interop.mkScatterternaryAttr "bsrc" value
    /// Sets the source reference on plot.ly for  c .
    static member inline csrc (value: string) = Interop.mkScatterternaryAttr "csrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScatterternaryAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScatterternaryAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScatterternaryAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScatterternaryAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScatterternaryAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScatterternaryAttr "hovertemplatesrc" value

[<AutoOpen>]
module scatterternary =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IScatterternaryProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkScatterternaryAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScatterternaryAttr "visible" "legendonly"
        static member inline false' = Interop.mkScatterternaryAttr "visible" "false"
        static member inline true' = Interop.mkScatterternaryAttr "visible" "true"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScatterternaryAttr "mode" "none"
        static member inline lines = Interop.mkScatterternaryAttr "mode" "lines"
        static member inline markers = Interop.mkScatterternaryAttr "mode" "markers"
        static member inline markersAndLines = Interop.mkScatterternaryAttr "mode" "markers+lines"
        static member inline text = Interop.mkScatterternaryAttr "mode" "text"
        static member inline textAndLines = Interop.mkScatterternaryAttr "mode" "text+lines"
        static member inline textAndMarkers = Interop.mkScatterternaryAttr "mode" "text+markers"
        static member inline textAndMarkersLines = Interop.mkScatterternaryAttr "mode" "text+markers+lines"

    /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
    [<Erase>]
    type fill =
        static member inline none = Interop.mkScatterternaryAttr "fill" "none"
        static member inline tonext = Interop.mkScatterternaryAttr "fill" "tonext"
        static member inline toself = Interop.mkScatterternaryAttr "fill" "toself"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScatterternaryAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScatterternaryAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScatterternaryAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScatterternaryAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScatterternaryAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScatterternaryAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScatterternaryAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScatterternaryAttr "textposition" "top left"
        static member inline topRight = Interop.mkScatterternaryAttr "textposition" "top right"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScatterternaryAttr "hoverinfo" "all"
        static member inline none = Interop.mkScatterternaryAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScatterternaryAttr "hoverinfo" "skip"
        static member inline a = Interop.mkScatterternaryAttr "hoverinfo" "a"
        static member inline b = Interop.mkScatterternaryAttr "hoverinfo" "b"
        static member inline bAndA = Interop.mkScatterternaryAttr "hoverinfo" "b+a"
        static member inline c = Interop.mkScatterternaryAttr "hoverinfo" "c"
        static member inline cAndA = Interop.mkScatterternaryAttr "hoverinfo" "c+a"
        static member inline cAndB = Interop.mkScatterternaryAttr "hoverinfo" "c+b"
        static member inline cAndBA = Interop.mkScatterternaryAttr "hoverinfo" "c+b+a"
        static member inline name = Interop.mkScatterternaryAttr "hoverinfo" "name"
        static member inline nameAndA = Interop.mkScatterternaryAttr "hoverinfo" "name+a"
        static member inline nameAndB = Interop.mkScatterternaryAttr "hoverinfo" "name+b"
        static member inline nameAndBA = Interop.mkScatterternaryAttr "hoverinfo" "name+b+a"
        static member inline nameAndC = Interop.mkScatterternaryAttr "hoverinfo" "name+c"
        static member inline nameAndCA = Interop.mkScatterternaryAttr "hoverinfo" "name+c+a"
        static member inline nameAndCB = Interop.mkScatterternaryAttr "hoverinfo" "name+c+b"
        static member inline nameAndCBA = Interop.mkScatterternaryAttr "hoverinfo" "name+c+b+a"
        static member inline nameAndText = Interop.mkScatterternaryAttr "hoverinfo" "name+text"
        static member inline nameAndTextA = Interop.mkScatterternaryAttr "hoverinfo" "name+text+a"
        static member inline nameAndTextB = Interop.mkScatterternaryAttr "hoverinfo" "name+text+b"
        static member inline nameAndTextBA = Interop.mkScatterternaryAttr "hoverinfo" "name+text+b+a"
        static member inline nameAndTextC = Interop.mkScatterternaryAttr "hoverinfo" "name+text+c"
        static member inline nameAndTextCA = Interop.mkScatterternaryAttr "hoverinfo" "name+text+c+a"
        static member inline nameAndTextCB = Interop.mkScatterternaryAttr "hoverinfo" "name+text+c+b"
        static member inline nameAndTextCBA = Interop.mkScatterternaryAttr "hoverinfo" "name+text+c+b+a"
        static member inline text = Interop.mkScatterternaryAttr "hoverinfo" "text"
        static member inline textAndA = Interop.mkScatterternaryAttr "hoverinfo" "text+a"
        static member inline textAndB = Interop.mkScatterternaryAttr "hoverinfo" "text+b"
        static member inline textAndBA = Interop.mkScatterternaryAttr "hoverinfo" "text+b+a"
        static member inline textAndC = Interop.mkScatterternaryAttr "hoverinfo" "text+c"
        static member inline textAndCA = Interop.mkScatterternaryAttr "hoverinfo" "text+c+a"
        static member inline textAndCB = Interop.mkScatterternaryAttr "hoverinfo" "text+c+b"
        static member inline textAndCBA = Interop.mkScatterternaryAttr "hoverinfo" "text+c+b+a"

    /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
    [<Erase>]
    type hoveron =
        static member inline fills = Interop.mkScatterternaryAttr "hoveron" "fills"
        static member inline fillsAndPoints = Interop.mkScatterternaryAttr "hoveron" "fills+points"
        static member inline points = Interop.mkScatterternaryAttr "hoveron" "points"

