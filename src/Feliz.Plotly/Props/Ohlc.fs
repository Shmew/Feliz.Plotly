namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type ohlc =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkOhlcAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkOhlcAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkOhlcAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkOhlcAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkOhlcAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkOhlcAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkOhlcAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkOhlcAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkOhlcAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkOhlcAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkOhlcAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkOhlcAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkOhlcAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkOhlcAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkOhlcAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkOhlcAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkOhlcAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkOhlcAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkOhlcAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkOhlcAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkOhlcAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkOhlcAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkOhlcAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkOhlcAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkOhlcAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkOhlcAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkOhlcAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkOhlcAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkOhlcAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkOhlcAttr "selectedpoints" (values |> Array.ofSeq)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IOhlcProperty list) = Interop.mkOhlcAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    static member inline stream (properties: #IStreamProperty list) = Interop.mkOhlcAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkOhlcAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkOhlcAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkOhlcAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkOhlcAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkOhlcAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkOhlcAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkOhlcAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkOhlcAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkOhlcAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: bool) = Interop.mkOhlcAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<bool>) = Interop.mkOhlcAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: string) = Interop.mkOhlcAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<string>) = Interop.mkOhlcAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: int) = Interop.mkOhlcAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<int>) = Interop.mkOhlcAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: float) = Interop.mkOhlcAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<float>) = Interop.mkOhlcAttr "x" (values |> Array.ofSeq)
    /// Sets the open values.
    static member inline open' (value: bool) = Interop.mkOhlcAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<bool>) = Interop.mkOhlcAttr "open" (values |> Array.ofSeq)
    /// Sets the open values.
    static member inline open' (value: string) = Interop.mkOhlcAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<string>) = Interop.mkOhlcAttr "open" (values |> Array.ofSeq)
    /// Sets the open values.
    static member inline open' (value: int) = Interop.mkOhlcAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<int>) = Interop.mkOhlcAttr "open" (values |> Array.ofSeq)
    /// Sets the open values.
    static member inline open' (value: float) = Interop.mkOhlcAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<float>) = Interop.mkOhlcAttr "open" (values |> Array.ofSeq)
    /// Sets the high values.
    static member inline high (value: bool) = Interop.mkOhlcAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<bool>) = Interop.mkOhlcAttr "high" (values |> Array.ofSeq)
    /// Sets the high values.
    static member inline high (value: string) = Interop.mkOhlcAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<string>) = Interop.mkOhlcAttr "high" (values |> Array.ofSeq)
    /// Sets the high values.
    static member inline high (value: int) = Interop.mkOhlcAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<int>) = Interop.mkOhlcAttr "high" (values |> Array.ofSeq)
    /// Sets the high values.
    static member inline high (value: float) = Interop.mkOhlcAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<float>) = Interop.mkOhlcAttr "high" (values |> Array.ofSeq)
    /// Sets the low values.
    static member inline low (value: bool) = Interop.mkOhlcAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<bool>) = Interop.mkOhlcAttr "low" (values |> Array.ofSeq)
    /// Sets the low values.
    static member inline low (value: string) = Interop.mkOhlcAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<string>) = Interop.mkOhlcAttr "low" (values |> Array.ofSeq)
    /// Sets the low values.
    static member inline low (value: int) = Interop.mkOhlcAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<int>) = Interop.mkOhlcAttr "low" (values |> Array.ofSeq)
    /// Sets the low values.
    static member inline low (value: float) = Interop.mkOhlcAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<float>) = Interop.mkOhlcAttr "low" (values |> Array.ofSeq)
    /// Sets the close values.
    static member inline close (value: bool) = Interop.mkOhlcAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<bool>) = Interop.mkOhlcAttr "close" (values |> Array.ofSeq)
    /// Sets the close values.
    static member inline close (value: string) = Interop.mkOhlcAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<string>) = Interop.mkOhlcAttr "close" (values |> Array.ofSeq)
    /// Sets the close values.
    static member inline close (value: int) = Interop.mkOhlcAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<int>) = Interop.mkOhlcAttr "close" (values |> Array.ofSeq)
    /// Sets the close values.
    static member inline close (value: float) = Interop.mkOhlcAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<float>) = Interop.mkOhlcAttr "close" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkOhlcAttr "line" (createObj !!properties)
    static member inline increasing (properties: #IIncreasingProperty list) = Interop.mkOhlcAttr "increasing" (createObj !!properties)
    static member inline decreasing (properties: #IDecreasingProperty list) = Interop.mkOhlcAttr "decreasing" (createObj !!properties)
    /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
    static member inline text (value: string) = Interop.mkOhlcAttr "text" value
    /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
    static member inline text (values: seq<string>) = Interop.mkOhlcAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkOhlcAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkOhlcAttr "hovertext" (values |> Array.ofSeq)
    /// Sets the width of the open/close tick marks relative to the *x* minimal interval.
    static member inline tickwidth (value: int) = Interop.mkOhlcAttr "tickwidth" value
    /// Sets the width of the open/close tick marks relative to the *x* minimal interval.
    static member inline tickwidth (value: float) = Interop.mkOhlcAttr "tickwidth" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkOhlcAttr "hoverlabel" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkOhlcAttr "xaxis" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkOhlcAttr "yaxis" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkOhlcAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkOhlcAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkOhlcAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkOhlcAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkOhlcAttr "xsrc" value
    /// Sets the source reference on plot.ly for  open .
    static member inline opensrc (value: string) = Interop.mkOhlcAttr "opensrc" value
    /// Sets the source reference on plot.ly for  high .
    static member inline highsrc (value: string) = Interop.mkOhlcAttr "highsrc" value
    /// Sets the source reference on plot.ly for  low .
    static member inline lowsrc (value: string) = Interop.mkOhlcAttr "lowsrc" value
    /// Sets the source reference on plot.ly for  close .
    static member inline closesrc (value: string) = Interop.mkOhlcAttr "closesrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkOhlcAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkOhlcAttr "hovertextsrc" value

[<AutoOpen>]
module ohlc =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkOhlcAttr "visible" "legendonly"
        static member inline false' = Interop.mkOhlcAttr "visible" "false"
        static member inline true' = Interop.mkOhlcAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkOhlcAttr "hoverinfo" "all"
        static member inline none = Interop.mkOhlcAttr "hoverinfo" "none"
        static member inline skip = Interop.mkOhlcAttr "hoverinfo" "skip"
        static member inline name = Interop.mkOhlcAttr "hoverinfo" "name"
        static member inline text = Interop.mkOhlcAttr "hoverinfo" "text"
        static member inline x = Interop.mkOhlcAttr "hoverinfo" "x"
        static member inline y = Interop.mkOhlcAttr "hoverinfo" "y"
        static member inline z = Interop.mkOhlcAttr "hoverinfo" "z"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkOhlcAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkOhlcAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkOhlcAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkOhlcAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkOhlcAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkOhlcAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkOhlcAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkOhlcAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkOhlcAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkOhlcAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkOhlcAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkOhlcAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkOhlcAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkOhlcAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkOhlcAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkOhlcAttr "xcalendar" "ummalqura"

