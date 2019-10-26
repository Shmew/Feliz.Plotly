namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type violin =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkViolinAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkViolinAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkViolinAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkViolinAttr "opacity" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkViolinAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkViolinAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkViolinAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkViolinAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkViolinAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkViolinAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkViolinAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkViolinAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkViolinAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkViolinAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkViolinAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkViolinAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkViolinAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkViolinAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkViolinAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkViolinAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkViolinAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkViolinAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkViolinAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkViolinAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkViolinAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkViolinAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkViolinAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkViolinAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkViolinAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkViolinAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkViolinAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkViolinAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<bool>) = Interop.mkViolinAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<string>) = Interop.mkViolinAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<int>) = Interop.mkViolinAttr "y" (values |> Array.ofSeq)
    /// Sets the y sample data or coordinates. See overview for more info.
    static member inline y (values: seq<float>) = Interop.mkViolinAttr "y" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<bool>) = Interop.mkViolinAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<string>) = Interop.mkViolinAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<int>) = Interop.mkViolinAttr "x" (values |> Array.ofSeq)
    /// Sets the x sample data or coordinates. See overview for more info.
    static member inline x (values: seq<float>) = Interop.mkViolinAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: bool) = Interop.mkViolinAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<bool>) = Interop.mkViolinAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: string) = Interop.mkViolinAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<string>) = Interop.mkViolinAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: int) = Interop.mkViolinAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<int>) = Interop.mkViolinAttr "x0" (values |> Array.ofSeq)
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (value: float) = Interop.mkViolinAttr "x0" value
    /// Sets the x coordinate of the box. See overview for more info.
    static member inline x0 (values: seq<float>) = Interop.mkViolinAttr "x0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: bool) = Interop.mkViolinAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<bool>) = Interop.mkViolinAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: string) = Interop.mkViolinAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<string>) = Interop.mkViolinAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: int) = Interop.mkViolinAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<int>) = Interop.mkViolinAttr "y0" (values |> Array.ofSeq)
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (value: float) = Interop.mkViolinAttr "y0" value
    /// Sets the y coordinate of the box. See overview for more info.
    static member inline y0 (values: seq<float>) = Interop.mkViolinAttr "y0" (values |> Array.ofSeq)
    /// Sets the trace name. The trace name appear as the legend item and on hover. For violin traces, the name will also be used for the position coordinate, if `x` and `x0` (`y` and `y0` if horizontal) are missing and the position axis is categorical. Note that the trace name is also used as a default value for attribute `scalegroup` (please see its description for details).
    static member inline name (value: string) = Interop.mkViolinAttr "name" value
    /// Sets the bandwidth used to compute the kernel density estimate. By default, the bandwidth is determined by Silverman's rule of thumb.
    static member inline bandwidth (value: int) = Interop.mkViolinAttr "bandwidth" value
    /// Sets the bandwidth used to compute the kernel density estimate. By default, the bandwidth is determined by Silverman's rule of thumb.
    static member inline bandwidth (value: float) = Interop.mkViolinAttr "bandwidth" value
    /// If there are multiple violins that should be sized according to to some metric (see `scalemode`), link them by providing a non-empty group id here shared by every trace in the same group. If a violin's `width` is undefined, `scalegroup` will default to the trace's name. In this case, violins with the same names will be linked together
    static member inline scalegroup (value: string) = Interop.mkViolinAttr "scalegroup" value
    /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
    static member inline span (values: seq<bool>) = Interop.mkViolinAttr "span" (values |> Array.ofSeq)
    /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
    static member inline span (values: seq<int>) = Interop.mkViolinAttr "span" (values |> Array.ofSeq)
    /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
    static member inline span (values: seq<float>) = Interop.mkViolinAttr "span" (values |> Array.ofSeq)
    /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
    static member inline span (values: seq<string>) = Interop.mkViolinAttr "span" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkViolinAttr "line" (createObj !!properties)
    /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
    static member inline fillcolor (value: string) = Interop.mkViolinAttr "fillcolor" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the violins.
    static member inline jitter (value: int) = Interop.mkViolinAttr "jitter" value
    /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the violins.
    static member inline jitter (value: float) = Interop.mkViolinAttr "jitter" value
    /// Sets the position of the sample points in relation to the violins. If *0*, the sample points are places over the center of the violins. Positive (negative) values correspond to positions to the right (left) for vertical violins and above (below) for horizontal violins.
    static member inline pointpos (value: int) = Interop.mkViolinAttr "pointpos" value
    /// Sets the position of the sample points in relation to the violins. If *0*, the sample points are places over the center of the violins. Positive (negative) values correspond to positions to the right (left) for vertical violins and above (below) for horizontal violins.
    static member inline pointpos (value: float) = Interop.mkViolinAttr "pointpos" value
    /// Sets the width of the violin in data coordinates. If *0* (default value) the width is automatically selected based on the positions of other violin traces in the same subplot.
    static member inline width (value: int) = Interop.mkViolinAttr "width" value
    /// Sets the width of the violin in data coordinates. If *0* (default value) the width is automatically selected based on the positions of other violin traces in the same subplot.
    static member inline width (value: float) = Interop.mkViolinAttr "width" value
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkViolinAttr "marker" (createObj !!properties)
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (value: string) = Interop.mkViolinAttr "text" value
    /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline text (values: seq<string>) = Interop.mkViolinAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkViolinAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkViolinAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkViolinAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkViolinAttr "hovertemplate" (values |> Array.ofSeq)
    static member inline box (properties: #IBoxProperty list) = Interop.mkViolinAttr "box" (createObj !!properties)
    static member inline meanline (properties: #IMeanlineProperty list) = Interop.mkViolinAttr "meanline" (createObj !!properties)
    /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
    static member inline offsetgroup (value: string) = Interop.mkViolinAttr "offsetgroup" value
    /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
    static member inline alignmentgroup (value: string) = Interop.mkViolinAttr "alignmentgroup" value
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkViolinAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkViolinAttr "unselected" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkViolinAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkViolinAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkViolinAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkViolinAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkViolinAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkViolinAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkViolinAttr "ysrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkViolinAttr "xsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkViolinAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkViolinAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkViolinAttr "hovertemplatesrc" value

[<AutoOpen>]
module violin =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkViolinAttr "visible" "legendonly"
        static member inline false' = Interop.mkViolinAttr "visible" "false"
        static member inline true' = Interop.mkViolinAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkViolinAttr "hoverinfo" "all"
        static member inline none = Interop.mkViolinAttr "hoverinfo" "none"
        static member inline skip = Interop.mkViolinAttr "hoverinfo" "skip"
        static member inline name = Interop.mkViolinAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkViolinAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkViolinAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkViolinAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkViolinAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkViolinAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkViolinAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkViolinAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkViolinAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkViolinAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkViolinAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkViolinAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkViolinAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkViolinAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkViolinAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkViolinAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkViolinAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkViolinAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkViolinAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkViolinAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkViolinAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkViolinAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkViolinAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkViolinAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkViolinAttr "hoverinfo" "x"
        static member inline y = Interop.mkViolinAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkViolinAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkViolinAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkViolinAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkViolinAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkViolinAttr "hoverinfo" "z+y+x"

    /// Sets the orientation of the violin(s). If *v* (*h*), the distribution is visualized along the vertical (horizontal).
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkViolinAttr "orientation" "h"
        static member inline v = Interop.mkViolinAttr "orientation" "v"

    /// Sets the metric by which the width of each violin is determined.*width* means each violin has the same (max) width*count* means the violins are scaled by the number of sample points makingup each violin.
    [<Erase>]
    type scalemode =
        static member inline count = Interop.mkViolinAttr "scalemode" "count"
        static member inline width = Interop.mkViolinAttr "scalemode" "width"

    /// Sets the method by which the span in data space where the density function will be computed. *soft* means the span goes from the sample's minimum value minus two bandwidths to the sample's maximum value plus two bandwidths. *hard* means the span goes from the sample's minimum to its maximum value. For custom span settings, use mode *manual* and fill in the `span` attribute.
    [<Erase>]
    type spanmode =
        static member inline hard = Interop.mkViolinAttr "spanmode" "hard"
        static member inline manual = Interop.mkViolinAttr "spanmode" "manual"
        static member inline soft = Interop.mkViolinAttr "spanmode" "soft"

    /// If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the violins are shown with no sample points
    [<Erase>]
    type points =
        static member inline all = Interop.mkViolinAttr "points" "all"
        static member inline outliers = Interop.mkViolinAttr "points" "outliers"
        static member inline suspectedoutliers = Interop.mkViolinAttr "points" "suspectedoutliers"
        static member inline false' = Interop.mkViolinAttr "points" "false"

    /// Determines on which side of the position value the density function making up one half of a violin is plotted. Useful when comparing two violin traces under *overlay* mode, where one trace has `side` set to *positive* and the other to *negative*.
    [<Erase>]
    type side =
        static member inline both = Interop.mkViolinAttr "side" "both"
        static member inline negative = Interop.mkViolinAttr "side" "negative"
        static member inline positive = Interop.mkViolinAttr "side" "positive"

    /// Do the hover effects highlight individual violins or sample points or the kernel density estimate or any combination of them?
    [<Erase>]
    type hoveron =
        static member inline all = Interop.mkViolinAttr "hoveron" "all"
        static member inline kde = Interop.mkViolinAttr "hoveron" "kde"
        static member inline kdeAndPoints = Interop.mkViolinAttr "hoveron" "kde+points"
        static member inline kdeAndPointsViolins = Interop.mkViolinAttr "hoveron" "kde+points+violins"
        static member inline kdeAndViolins = Interop.mkViolinAttr "hoveron" "kde+violins"
        static member inline points = Interop.mkViolinAttr "hoveron" "points"
        static member inline pointsAndViolins = Interop.mkViolinAttr "hoveron" "points+violins"
        static member inline violins = Interop.mkViolinAttr "hoveron" "violins"

