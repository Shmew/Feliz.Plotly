namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type barpolar =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkBarpolarAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkBarpolarAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkBarpolarAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkBarpolarAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkBarpolarAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkBarpolarAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkBarpolarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkBarpolarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkBarpolarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkBarpolarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkBarpolarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkBarpolarAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkBarpolarAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkBarpolarAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkBarpolarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkBarpolarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkBarpolarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkBarpolarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkBarpolarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkBarpolarAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkBarpolarAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkBarpolarAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkBarpolarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkBarpolarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkBarpolarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkBarpolarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkBarpolarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkBarpolarAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkBarpolarAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkBarpolarAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkBarpolarAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkBarpolarAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkBarpolarAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkBarpolarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkBarpolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkBarpolarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkBarpolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkBarpolarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkBarpolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkBarpolarAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkBarpolarAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the radial coordinates
    static member inline r (value: bool) = Interop.mkBarpolarAttr "r" (value |> Array.singleton)
    /// Sets the radial coordinates
    static member inline r (values: seq<bool>) = Interop.mkBarpolarAttr "r" (values |> Array.ofSeq)
    /// Sets the radial coordinates
    static member inline r (value: string) = Interop.mkBarpolarAttr "r" (value |> Array.singleton)
    /// Sets the radial coordinates
    static member inline r (values: seq<string>) = Interop.mkBarpolarAttr "r" (values |> Array.ofSeq)
    /// Sets the radial coordinates
    static member inline r (value: int) = Interop.mkBarpolarAttr "r" (value |> Array.singleton)
    /// Sets the radial coordinates
    static member inline r (values: seq<int>) = Interop.mkBarpolarAttr "r" (values |> Array.ofSeq)
    /// Sets the radial coordinates
    static member inline r (value: float) = Interop.mkBarpolarAttr "r" (value |> Array.singleton)
    /// Sets the radial coordinates
    static member inline r (values: seq<float>) = Interop.mkBarpolarAttr "r" (values |> Array.ofSeq)
    /// Sets the angular coordinates
    static member inline theta (value: bool) = Interop.mkBarpolarAttr "theta" (value |> Array.singleton)
    /// Sets the angular coordinates
    static member inline theta (values: seq<bool>) = Interop.mkBarpolarAttr "theta" (values |> Array.ofSeq)
    /// Sets the angular coordinates
    static member inline theta (value: string) = Interop.mkBarpolarAttr "theta" (value |> Array.singleton)
    /// Sets the angular coordinates
    static member inline theta (values: seq<string>) = Interop.mkBarpolarAttr "theta" (values |> Array.ofSeq)
    /// Sets the angular coordinates
    static member inline theta (value: int) = Interop.mkBarpolarAttr "theta" (value |> Array.singleton)
    /// Sets the angular coordinates
    static member inline theta (values: seq<int>) = Interop.mkBarpolarAttr "theta" (values |> Array.ofSeq)
    /// Sets the angular coordinates
    static member inline theta (value: float) = Interop.mkBarpolarAttr "theta" (value |> Array.singleton)
    /// Sets the angular coordinates
    static member inline theta (values: seq<float>) = Interop.mkBarpolarAttr "theta" (values |> Array.ofSeq)
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (value: bool) = Interop.mkBarpolarAttr "r0" value
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (values: seq<bool>) = Interop.mkBarpolarAttr "r0" (values |> Array.ofSeq)
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (value: string) = Interop.mkBarpolarAttr "r0" value
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (values: seq<string>) = Interop.mkBarpolarAttr "r0" (values |> Array.ofSeq)
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (value: int) = Interop.mkBarpolarAttr "r0" value
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (values: seq<int>) = Interop.mkBarpolarAttr "r0" (values |> Array.ofSeq)
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (value: float) = Interop.mkBarpolarAttr "r0" value
    /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
    static member inline r0 (values: seq<float>) = Interop.mkBarpolarAttr "r0" (values |> Array.ofSeq)
    /// Sets the r coordinate step.
    static member inline dr (value: int) = Interop.mkBarpolarAttr "dr" value
    /// Sets the r coordinate step.
    static member inline dr (value: float) = Interop.mkBarpolarAttr "dr" value
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (value: bool) = Interop.mkBarpolarAttr "theta0" value
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (values: seq<bool>) = Interop.mkBarpolarAttr "theta0" (values |> Array.ofSeq)
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (value: string) = Interop.mkBarpolarAttr "theta0" value
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (values: seq<string>) = Interop.mkBarpolarAttr "theta0" (values |> Array.ofSeq)
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (value: int) = Interop.mkBarpolarAttr "theta0" value
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (values: seq<int>) = Interop.mkBarpolarAttr "theta0" (values |> Array.ofSeq)
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (value: float) = Interop.mkBarpolarAttr "theta0" value
    /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
    static member inline theta0 (values: seq<float>) = Interop.mkBarpolarAttr "theta0" (values |> Array.ofSeq)
    /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
    static member inline dtheta (value: int) = Interop.mkBarpolarAttr "dtheta" value
    /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
    static member inline dtheta (value: float) = Interop.mkBarpolarAttr "dtheta" value
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: bool) = Interop.mkBarpolarAttr "base" value
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<bool>) = Interop.mkBarpolarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: string) = Interop.mkBarpolarAttr "base" value
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<string>) = Interop.mkBarpolarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: int) = Interop.mkBarpolarAttr "base" value
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<int>) = Interop.mkBarpolarAttr "base" (values |> Array.ofSeq)
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (value: float) = Interop.mkBarpolarAttr "base" value
    /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
    static member inline base' (values: seq<float>) = Interop.mkBarpolarAttr "base" (values |> Array.ofSeq)
    /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
    static member inline offset (value: int) = Interop.mkBarpolarAttr "offset" value
    /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
    static member inline offset (value: float) = Interop.mkBarpolarAttr "offset" value
    /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
    static member inline offset (values: seq<int>) = Interop.mkBarpolarAttr "offset" (values |> Array.ofSeq)
    /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
    static member inline offset (values: seq<float>) = Interop.mkBarpolarAttr "offset" (values |> Array.ofSeq)
    /// Sets the bar angular width (in *thetaunit* units).
    static member inline width (value: int) = Interop.mkBarpolarAttr "width" value
    /// Sets the bar angular width (in *thetaunit* units).
    static member inline width (value: float) = Interop.mkBarpolarAttr "width" value
    /// Sets the bar angular width (in *thetaunit* units).
    static member inline width (values: seq<int>) = Interop.mkBarpolarAttr "width" (values |> Array.ofSeq)
    /// Sets the bar angular width (in *thetaunit* units).
    static member inline width (values: seq<float>) = Interop.mkBarpolarAttr "width" (values |> Array.ofSeq)
    /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
    static member inline text (value: string) = Interop.mkBarpolarAttr "text" value
    /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
    static member inline text (values: seq<string>) = Interop.mkBarpolarAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkBarpolarAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkBarpolarAttr "hovertext" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkBarpolarAttr "marker" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IBarpolarProperty list) = Interop.mkBarpolarAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkBarpolarAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkBarpolarAttr "hovertemplate" (values |> Array.ofSeq)
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkBarpolarAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkBarpolarAttr "unselected" (createObj !!properties)
    /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
    static member inline subplot (value: string) = Interop.mkBarpolarAttr "subplot" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkBarpolarAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkBarpolarAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkBarpolarAttr "metasrc" value
    /// Sets the source reference on plot.ly for  r .
    static member inline rsrc (value: string) = Interop.mkBarpolarAttr "rsrc" value
    /// Sets the source reference on plot.ly for  theta .
    static member inline thetasrc (value: string) = Interop.mkBarpolarAttr "thetasrc" value
    /// Sets the source reference on plot.ly for  base .
    static member inline basesrc (value: string) = Interop.mkBarpolarAttr "basesrc" value
    /// Sets the source reference on plot.ly for  offset .
    static member inline offsetsrc (value: string) = Interop.mkBarpolarAttr "offsetsrc" value
    /// Sets the source reference on plot.ly for  width .
    static member inline widthsrc (value: string) = Interop.mkBarpolarAttr "widthsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkBarpolarAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkBarpolarAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkBarpolarAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkBarpolarAttr "hovertemplatesrc" value

[<AutoOpen>]
module barpolar =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkBarpolarAttr "visible" "legendonly"
        static member inline false' = Interop.mkBarpolarAttr "visible" "false"
        static member inline true' = Interop.mkBarpolarAttr "visible" "true"

    /// Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
    [<Erase>]
    type thetaunit =
        static member inline degrees = Interop.mkBarpolarAttr "thetaunit" "degrees"
        static member inline gradians = Interop.mkBarpolarAttr "thetaunit" "gradians"
        static member inline radians = Interop.mkBarpolarAttr "thetaunit" "radians"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkBarpolarAttr "hoverinfo" "all"
        static member inline none = Interop.mkBarpolarAttr "hoverinfo" "none"
        static member inline skip = Interop.mkBarpolarAttr "hoverinfo" "skip"
        static member inline name = Interop.mkBarpolarAttr "hoverinfo" "name"
        static member inline r = Interop.mkBarpolarAttr "hoverinfo" "r"
        static member inline text = Interop.mkBarpolarAttr "hoverinfo" "text"
        static member inline theta = Interop.mkBarpolarAttr "hoverinfo" "theta"

