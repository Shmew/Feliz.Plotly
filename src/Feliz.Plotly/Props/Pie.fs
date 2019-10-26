namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type pie =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkPieAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkPieAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkPieAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkPieAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkPieAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkPieAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkPieAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkPieAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkPieAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkPieAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkPieAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkPieAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkPieAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkPieAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkPieAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkPieAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkPieAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkPieAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkPieAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkPieAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkPieAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkPieAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkPieAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkPieAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkPieAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<bool>) = Interop.mkPieAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<string>) = Interop.mkPieAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<int>) = Interop.mkPieAttr "labels" (values |> Array.ofSeq)
    /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
    static member inline labels (values: seq<float>) = Interop.mkPieAttr "labels" (values |> Array.ofSeq)
    /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
    static member inline label0 (value: int) = Interop.mkPieAttr "label0" value
    /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
    static member inline label0 (value: float) = Interop.mkPieAttr "label0" value
    /// Sets the label step. See `label0` for more info.
    static member inline dlabel (value: int) = Interop.mkPieAttr "dlabel" value
    /// Sets the label step. See `label0` for more info.
    static member inline dlabel (value: float) = Interop.mkPieAttr "dlabel" value
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<bool>) = Interop.mkPieAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<string>) = Interop.mkPieAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<int>) = Interop.mkPieAttr "values" (values |> Array.ofSeq)
    /// Sets the values of the sectors. If omitted, we count occurrences of each label.
    static member inline values (values: seq<float>) = Interop.mkPieAttr "values" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkPieAttr "marker" (createObj !!properties)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<bool>) = Interop.mkPieAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkPieAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<int>) = Interop.mkPieAttr "text" (values |> Array.ofSeq)
    /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<float>) = Interop.mkPieAttr "text" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkPieAttr "hovertext" value
    /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkPieAttr "hovertext" (values |> Array.ofSeq)
    /// If there are multiple pie charts that should be sized according to their totals, link them by providing a non-empty group id here shared by every trace in the same group.
    static member inline scalegroup (value: string) = Interop.mkPieAttr "scalegroup" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkPieAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkPieAttr "hovertemplate" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`.
    static member inline texttemplate (value: string) = Interop.mkPieAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`.
    static member inline texttemplate (values: seq<string>) = Interop.mkPieAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets the font used for `textinfo`.
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkPieAttr "textfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying inside the sector.
    static member inline insidetextfont (properties: #IInsidetextfontProperty list) = Interop.mkPieAttr "insidetextfont" (createObj !!properties)
    /// Sets the font used for `textinfo` lying outside the sector.
    static member inline outsidetextfont (properties: #IOutsidetextfontProperty list) = Interop.mkPieAttr "outsidetextfont" (createObj !!properties)
    static member inline title (properties: #ITitleProperty list) = Interop.mkPieAttr "title" (createObj !!properties)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkPieAttr "domain" (createObj !!properties)
    /// Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.
    static member inline hole (value: int) = Interop.mkPieAttr "hole" value
    /// Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.
    static member inline hole (value: float) = Interop.mkPieAttr "hole" value
    /// Determines whether or not the sectors are reordered from largest to smallest.
    static member inline sort (value: bool) = Interop.mkPieAttr "sort" value
    /// Instead of the first slice starting at 12 o'clock, rotate to some other angle.
    static member inline rotation (value: int) = Interop.mkPieAttr "rotation" value
    /// Instead of the first slice starting at 12 o'clock, rotate to some other angle.
    static member inline rotation (value: float) = Interop.mkPieAttr "rotation" value
    /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
    static member inline pull (value: int) = Interop.mkPieAttr "pull" value
    /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
    static member inline pull (value: float) = Interop.mkPieAttr "pull" value
    /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
    static member inline pull (values: seq<int>) = Interop.mkPieAttr "pull" (values |> Array.ofSeq)
    /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
    static member inline pull (values: seq<float>) = Interop.mkPieAttr "pull" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkPieAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkPieAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkPieAttr "metasrc" value
    /// Sets the source reference on plot.ly for  labels .
    static member inline labelssrc (value: string) = Interop.mkPieAttr "labelssrc" value
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkPieAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkPieAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkPieAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkPieAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkPieAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkPieAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkPieAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  pull .
    static member inline pullsrc (value: string) = Interop.mkPieAttr "pullsrc" value

[<AutoOpen>]
module pie =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IPieProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkPieAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkPieAttr "visible" "legendonly"
        static member inline false' = Interop.mkPieAttr "visible" "false"
        static member inline true' = Interop.mkPieAttr "visible" "true"

    /// Determines which trace information appear on the graph.
    [<Erase>]
    type textinfo =
        static member inline none = Interop.mkPieAttr "textinfo" "none"
        static member inline label = Interop.mkPieAttr "textinfo" "label"
        static member inline percent = Interop.mkPieAttr "textinfo" "percent"
        static member inline percentAndLabel = Interop.mkPieAttr "textinfo" "percent+label"
        static member inline percentAndText = Interop.mkPieAttr "textinfo" "percent+text"
        static member inline percentAndTextLabel = Interop.mkPieAttr "textinfo" "percent+text+label"
        static member inline percentAndValue = Interop.mkPieAttr "textinfo" "percent+value"
        static member inline percentAndValueLabel = Interop.mkPieAttr "textinfo" "percent+value+label"
        static member inline percentAndValueText = Interop.mkPieAttr "textinfo" "percent+value+text"
        static member inline percentAndValueTextLabel = Interop.mkPieAttr "textinfo" "percent+value+text+label"
        static member inline text = Interop.mkPieAttr "textinfo" "text"
        static member inline textAndLabel = Interop.mkPieAttr "textinfo" "text+label"
        static member inline value = Interop.mkPieAttr "textinfo" "value"
        static member inline valueAndLabel = Interop.mkPieAttr "textinfo" "value+label"
        static member inline valueAndText = Interop.mkPieAttr "textinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkPieAttr "textinfo" "value+text+label"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkPieAttr "hoverinfo" "all"
        static member inline none = Interop.mkPieAttr "hoverinfo" "none"
        static member inline skip = Interop.mkPieAttr "hoverinfo" "skip"
        static member inline label = Interop.mkPieAttr "hoverinfo" "label"
        static member inline name = Interop.mkPieAttr "hoverinfo" "name"
        static member inline nameAndLabel = Interop.mkPieAttr "hoverinfo" "name+label"
        static member inline nameAndPercent = Interop.mkPieAttr "hoverinfo" "name+percent"
        static member inline nameAndPercentLabel = Interop.mkPieAttr "hoverinfo" "name+percent+label"
        static member inline nameAndPercentText = Interop.mkPieAttr "hoverinfo" "name+percent+text"
        static member inline nameAndPercentTextLabel = Interop.mkPieAttr "hoverinfo" "name+percent+text+label"
        static member inline nameAndPercentValue = Interop.mkPieAttr "hoverinfo" "name+percent+value"
        static member inline nameAndPercentValueLabel = Interop.mkPieAttr "hoverinfo" "name+percent+value+label"
        static member inline nameAndPercentValueText = Interop.mkPieAttr "hoverinfo" "name+percent+value+text"
        static member inline nameAndPercentValueTextLabel = Interop.mkPieAttr "hoverinfo" "name+percent+value+text+label"
        static member inline nameAndText = Interop.mkPieAttr "hoverinfo" "name+text"
        static member inline nameAndTextLabel = Interop.mkPieAttr "hoverinfo" "name+text+label"
        static member inline nameAndValue = Interop.mkPieAttr "hoverinfo" "name+value"
        static member inline nameAndValueLabel = Interop.mkPieAttr "hoverinfo" "name+value+label"
        static member inline nameAndValueText = Interop.mkPieAttr "hoverinfo" "name+value+text"
        static member inline nameAndValueTextLabel = Interop.mkPieAttr "hoverinfo" "name+value+text+label"
        static member inline percent = Interop.mkPieAttr "hoverinfo" "percent"
        static member inline percentAndLabel = Interop.mkPieAttr "hoverinfo" "percent+label"
        static member inline percentAndText = Interop.mkPieAttr "hoverinfo" "percent+text"
        static member inline percentAndTextLabel = Interop.mkPieAttr "hoverinfo" "percent+text+label"
        static member inline percentAndValue = Interop.mkPieAttr "hoverinfo" "percent+value"
        static member inline percentAndValueLabel = Interop.mkPieAttr "hoverinfo" "percent+value+label"
        static member inline percentAndValueText = Interop.mkPieAttr "hoverinfo" "percent+value+text"
        static member inline percentAndValueTextLabel = Interop.mkPieAttr "hoverinfo" "percent+value+text+label"
        static member inline text = Interop.mkPieAttr "hoverinfo" "text"
        static member inline textAndLabel = Interop.mkPieAttr "hoverinfo" "text+label"
        static member inline value = Interop.mkPieAttr "hoverinfo" "value"
        static member inline valueAndLabel = Interop.mkPieAttr "hoverinfo" "value+label"
        static member inline valueAndText = Interop.mkPieAttr "hoverinfo" "value+text"
        static member inline valueAndTextLabel = Interop.mkPieAttr "hoverinfo" "value+text+label"

    /// Specifies the location of the `textinfo`.
    [<Erase>]
    type textposition =
        static member inline auto = Interop.mkPieAttr "textposition" "auto"
        static member inline inside = Interop.mkPieAttr "textposition" "inside"
        static member inline none = Interop.mkPieAttr "textposition" "none"
        static member inline outside = Interop.mkPieAttr "textposition" "outside"

    /// Specifies the direction at which succeeding sectors follow one another.
    [<Erase>]
    type direction =
        static member inline clockwise = Interop.mkPieAttr "direction" "clockwise"
        static member inline counterclockwise = Interop.mkPieAttr "direction" "counterclockwise"

