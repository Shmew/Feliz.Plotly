namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type funnelarea =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkFunnelareaAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkFunnelareaAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkFunnelareaAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkFunnelareaAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkFunnelareaAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkFunnelareaAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkFunnelareaAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkFunnelareaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkFunnelareaAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkFunnelareaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkFunnelareaAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkFunnelareaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkFunnelareaAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkFunnelareaAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkFunnelareaAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkFunnelareaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkFunnelareaAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkFunnelareaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkFunnelareaAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkFunnelareaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkFunnelareaAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkFunnelareaAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkFunnelareaAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkFunnelareaAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkFunnelareaAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkFunnelareaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkFunnelareaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkFunnelareaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkFunnelareaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkFunnelareaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkFunnelareaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkFunnelareaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkFunnelareaAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (value: bool) = Interop.mkFunnelareaAttr "labels" (value |> Array.singleton)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<bool>) = Interop.mkFunnelareaAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (value: string) = Interop.mkFunnelareaAttr "labels" (value |> Array.singleton)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<string>) = Interop.mkFunnelareaAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (value: int) = Interop.mkFunnelareaAttr "labels" (value |> Array.singleton)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<int>) = Interop.mkFunnelareaAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (value: float) = Interop.mkFunnelareaAttr "labels" (value |> Array.singleton)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<float>) = Interop.mkFunnelareaAttr "labels" (values |> Array.ofSeq)
    /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
    static member inline label0 (value: int) = Interop.mkFunnelareaAttr "label0" value
    /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
    static member inline label0 (value: float) = Interop.mkFunnelareaAttr "label0" value
    /// Sets the label step. See `label0` for more info.
    static member inline dlabel (value: int) = Interop.mkFunnelareaAttr "dlabel" value
    /// Sets the label step. See `label0` for more info.
    static member inline dlabel (value: float) = Interop.mkFunnelareaAttr "dlabel" value
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (value: bool) = Interop.mkFunnelareaAttr "values" (value |> Array.singleton)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<bool>) = Interop.mkFunnelareaAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (value: string) = Interop.mkFunnelareaAttr "values" (value |> Array.singleton)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<string>) = Interop.mkFunnelareaAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (value: int) = Interop.mkFunnelareaAttr "values" (value |> Array.singleton)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<int>) = Interop.mkFunnelareaAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (value: float) = Interop.mkFunnelareaAttr "values" (value |> Array.singleton)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<float>) = Interop.mkFunnelareaAttr "values" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkFunnelareaAttr "marker" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: bool) = Interop.mkFunnelareaAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkFunnelareaAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkFunnelareaAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkFunnelareaAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: int) = Interop.mkFunnelareaAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkFunnelareaAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: float) = Interop.mkFunnelareaAttr "text" (value |> Array.singleton)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkFunnelareaAttr "text" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkFunnelareaAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkFunnelareaAttr "hovertext" (values |> Array.ofSeq)
    /// If there are multiple funnelareas that should be sized according to their totals, link them by providing a non-empty group id here shared by every trace in the same group.
    static member inline scalegroup (value: string) = Interop.mkFunnelareaAttr "scalegroup" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`.
    static member inline texttemplate (value: string) = Interop.mkFunnelareaAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`.
    static member inline texttemplate (values: seq<string>) = Interop.mkFunnelareaAttr "texttemplate" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkFunnelareaAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkFunnelareaAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkFunnelareaAttr "textfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkFunnelareaAttr "insidetextfont" (createObj !!properties)
    static member inline title (properties: #ITitleProperty list) = Interop.mkFunnelareaAttr "title" (createObj !!properties)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkFunnelareaAttr "domain" (createObj !!properties)
    /// Sets the ratio between height and width
    static member inline aspectratio (value: int) = Interop.mkFunnelareaAttr "aspectratio" value
    /// Sets the ratio between height and width
    static member inline aspectratio (value: float) = Interop.mkFunnelareaAttr "aspectratio" value
    /// Sets the ratio between bottom length and maximum top length.
    static member inline baseratio (value: int) = Interop.mkFunnelareaAttr "baseratio" value
    /// Sets the ratio between bottom length and maximum top length.
    static member inline baseratio (value: float) = Interop.mkFunnelareaAttr "baseratio" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkFunnelareaAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkFunnelareaAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkFunnelareaAttr "metasrc" value
    /// Sets the source reference on plot.ly for  labels .
    static member inline labelssrc (value: string) = Interop.mkFunnelareaAttr "labelssrc" value
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkFunnelareaAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkFunnelareaAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkFunnelareaAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkFunnelareaAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkFunnelareaAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkFunnelareaAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkFunnelareaAttr "textpositionsrc" value

[<AutoOpen>]
module funnelarea =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IFunnelareaProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkFunnelareaAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkFunnelareaAttr "visible" "legendonly"
        static member inline false' = Interop.mkFunnelareaAttr "visible" "false"
        static member inline true' = Interop.mkFunnelareaAttr "visible" "true"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkFunnelareaAttr "textinfo" "none"
        static member inline label = Interop.mkFunnelareaAttr "textinfo" "label"
        static member inline percent = Interop.mkFunnelareaAttr "textinfo" "percent"
        static member inline percentAndLabel = Interop.mkFunnelareaAttr "textinfo" "percent+label"
        static member inline percentAndText = Interop.mkFunnelareaAttr "textinfo" "percent+text"
        static member inline percentAndTextLabel = Interop.mkFunnelareaAttr "textinfo" "percent+text+label"
        static member inline percentAndValue = Interop.mkFunnelareaAttr "textinfo" "percent+value"
        static member inline percentAndValueLabel = Interop.mkFunnelareaAttr "textinfo" "percent+value+label"
        static member inline percentAndValueText = Interop.mkFunnelareaAttr "textinfo" "percent+value+text"
        static member inline percentAndValueTextLabel = Interop.mkFunnelareaAttr "textinfo" "percent+value+text+label"
        static member inline text = Interop.mkFunnelareaAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkFunnelareaAttr "textinfo" "text+label"
        static member inline value = Interop.mkFunnelareaAttr "textinfo" "value"
        static member inline valueAndLabel = Interop.mkFunnelareaAttr "textinfo" "value+label"
        static member inline valueAndText = Interop.mkFunnelareaAttr "textinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkFunnelareaAttr "textinfo" "value+text+label"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkFunnelareaAttr "hoverinfo" "all"
        static member inline none = Interop.mkFunnelareaAttr "hoverinfo" "none"
        static member inline skip = Interop.mkFunnelareaAttr "hoverinfo" "skip"
        static member inline label = Interop.mkFunnelareaAttr "hoverinfo" "label"
        static member inline name = Interop.mkFunnelareaAttr "hoverinfo" "name"
        static member inline nameAndLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+label"
        static member inline nameAndPercent = Interop.mkFunnelareaAttr "hoverinfo" "name+percent"
        static member inline nameAndPercentLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+label"
        static member inline nameAndPercentText = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+text"
        static member inline nameAndPercentTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+text+label"
        static member inline nameAndPercentValue = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+value"
        static member inline nameAndPercentValueLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+value+label"
        static member inline nameAndPercentValueText = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+value+text"
        static member inline nameAndPercentValueTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+percent+value+text+label"
        static member inline nameAndText = Interop.mkFunnelareaAttr "hoverinfo" "name+text"
        static member inline nameAndTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+text+label"
        static member inline nameAndValue = Interop.mkFunnelareaAttr "hoverinfo" "name+value"
        static member inline nameAndValueLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+value+label"
        static member inline nameAndValueText = Interop.mkFunnelareaAttr "hoverinfo" "name+value+text"
        static member inline nameAndValueTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "name+value+text+label"
        static member inline percent = Interop.mkFunnelareaAttr "hoverinfo" "percent"
        static member inline percentAndLabel = Interop.mkFunnelareaAttr "hoverinfo" "percent+label"
        static member inline percentAndText = Interop.mkFunnelareaAttr "hoverinfo" "percent+text"
        static member inline percentAndTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "percent+text+label"
        static member inline percentAndValue = Interop.mkFunnelareaAttr "hoverinfo" "percent+value"
        static member inline percentAndValueLabel = Interop.mkFunnelareaAttr "hoverinfo" "percent+value+label"
        static member inline percentAndValueText = Interop.mkFunnelareaAttr "hoverinfo" "percent+value+text"
        static member inline percentAndValueTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "percent+value+text+label"
        static member inline text = Interop.mkFunnelareaAttr "hoverinfo" "text"
        static member inline textAndLabel = Interop.mkFunnelareaAttr "hoverinfo" "text+label"
        static member inline value = Interop.mkFunnelareaAttr "hoverinfo" "value"
        static member inline valueAndLabel = Interop.mkFunnelareaAttr "hoverinfo" "value+label"
        static member inline valueAndText = Interop.mkFunnelareaAttr "hoverinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkFunnelareaAttr "hoverinfo" "value+text+label"

    /// Specifies the location of the `textinfo`.
    [<Erase>]
    type textposition =
        static member inline inside = Interop.mkFunnelareaAttr "textposition" "inside"
        static member inline none = Interop.mkFunnelareaAttr "textposition" "none"

