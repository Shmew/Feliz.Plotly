namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type box =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkBoxAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkBoxAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkBoxAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkBoxAttr "opacity" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkBoxAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkBoxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkBoxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkBoxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkBoxAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkBoxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkBoxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkBoxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkBoxAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkBoxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkBoxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkBoxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkBoxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkBoxAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkBoxAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkBoxAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkBoxAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkBoxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkBoxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkBoxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkBoxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkBoxAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool>) = Interop.mkBoxAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string>) = Interop.mkBoxAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int>) = Interop.mkBoxAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float>) = Interop.mkBoxAttr "y" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool>) = Interop.mkBoxAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string>) = Interop.mkBoxAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int>) = Interop.mkBoxAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float>) = Interop.mkBoxAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: bool) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<bool>) = Interop.mkBoxAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: string) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<string>) = Interop.mkBoxAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: int) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<int>) = Interop.mkBoxAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: float) = Interop.mkBoxAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<float>) = Interop.mkBoxAttr "x0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: bool) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<bool>) = Interop.mkBoxAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: string) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<string>) = Interop.mkBoxAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: int) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<int>) = Interop.mkBoxAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: float) = Interop.mkBoxAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<float>) = Interop.mkBoxAttr "y0" (values |> Array.ofSeq)
    /// Sets the trace name. The trace name appear as the legend item and on hover. For box traces, the name will also be used for the position coordinate, if `x` and `x0` (`y` and `y0` if horizontal) are missing and the position axis is categorical
    static member inline name (value: string) = Interop.mkBoxAttr "name" value
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (value: string) = Interop.mkBoxAttr "text" value
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (values: seq<string>) = Interop.mkBoxAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkBoxAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkBoxAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkBoxAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkBoxAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: int) = Interop.mkBoxAttr "whiskerwidth" value
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: float) = Interop.mkBoxAttr "whiskerwidth" value
    /// Determines whether or not notches should be drawn.
    static member inline notched (value: bool) = Interop.mkBoxAttr "notched" value
    /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
    static member inline notchwidth (value: int) = Interop.mkBoxAttr "notchwidth" value
    /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
    static member inline notchwidth (value: float) = Interop.mkBoxAttr "notchwidth" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
    static member inline jitter (value: int) = Interop.mkBoxAttr "jitter" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
    static member inline jitter (value: float) = Interop.mkBoxAttr "jitter" value
    /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
    static member inline pointpos (value: int) = Interop.mkBoxAttr "pointpos" value
    /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
    static member inline pointpos (value: float) = Interop.mkBoxAttr "pointpos" value
    /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
    static member inline width (value: int) = Interop.mkBoxAttr "width" value
    /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
    static member inline width (value: float) = Interop.mkBoxAttr "width" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkBoxAttr "marker" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkBoxAttr "line" (createObj !!properties)
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkBoxAttr "fillcolor" value
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkBoxAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkBoxAttr "alignmentgroup" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkBoxAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkBoxAttr "unselected" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkBoxAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkBoxAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkBoxAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkBoxAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkBoxAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkBoxAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkBoxAttr "ysrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkBoxAttr "xsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkBoxAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkBoxAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkBoxAttr "hovertemplatesrc" value

[<AutoOpen>]
module box =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkBoxAttr "visible" "legendonly"
        static member inline false' = Interop.mkBoxAttr "visible" "false"
        static member inline true' = Interop.mkBoxAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkBoxAttr "hoverinfo" "all"
        static member inline none = Interop.mkBoxAttr "hoverinfo" "none"
        static member inline skip = Interop.mkBoxAttr "hoverinfo" "skip"
        static member inline name = Interop.mkBoxAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkBoxAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkBoxAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkBoxAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkBoxAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkBoxAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkBoxAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkBoxAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkBoxAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkBoxAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkBoxAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkBoxAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkBoxAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkBoxAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkBoxAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkBoxAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkBoxAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkBoxAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkBoxAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkBoxAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkBoxAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkBoxAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkBoxAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkBoxAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkBoxAttr "hoverinfo" "x"
        static member inline y = Interop.mkBoxAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkBoxAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkBoxAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkBoxAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkBoxAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkBoxAttr "hoverinfo" "z+y+x"

    /// If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the box(es) are shown with no sample points
    [<Erase>]
    type boxpoints =
        static member inline all = Interop.mkBoxAttr "boxpoints" "all"
        static member inline outliers = Interop.mkBoxAttr "boxpoints" "outliers"
        static member inline suspectedoutliers = Interop.mkBoxAttr "boxpoints" "suspectedoutliers"
        static member inline false' = Interop.mkBoxAttr "boxpoints" "false"

    /// If *true*, the mean of the box(es)' underlying distribution is drawn as a dashed line inside the box(es). If *sd* the standard deviation is also drawn.
    [<Erase>]
    type boxmean =
        static member inline sd = Interop.mkBoxAttr "boxmean" "sd"
        static member inline false' = Interop.mkBoxAttr "boxmean" "false"
        static member inline true' = Interop.mkBoxAttr "boxmean" "true"

    /// Sets the orientation of the box(es). If *v* (*h*), the distribution is visualized along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkBoxAttr "orientation" "h"
        static member inline v = Interop.mkBoxAttr "orientation" "v"

    /// Do the hover effects highlight individual boxes  or sample points or both?
    [<Erase>]
    type hoveron =
        static member inline boxes = Interop.mkBoxAttr "hoveron" "boxes"
        static member inline points = Interop.mkBoxAttr "hoveron" "points"
        static member inline pointsAndBoxes = Interop.mkBoxAttr "hoveron" "points+boxes"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkBoxAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkBoxAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkBoxAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkBoxAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkBoxAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkBoxAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkBoxAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkBoxAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkBoxAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkBoxAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkBoxAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkBoxAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkBoxAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkBoxAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkBoxAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkBoxAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkBoxAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkBoxAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkBoxAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkBoxAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkBoxAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkBoxAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkBoxAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkBoxAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkBoxAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkBoxAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkBoxAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkBoxAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkBoxAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkBoxAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkBoxAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkBoxAttr "ycalendar" "ummalqura"

