namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type parcats =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkParcatsAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkParcatsAttr "uid" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkParcatsAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkParcatsAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkParcatsAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkParcatsAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkParcatsAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkParcatsAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkParcatsAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkParcatsAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkParcatsAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkParcatsAttr "uirevision" (values |> Array.ofSeq)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkParcatsAttr "domain" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `count`, `probability`, `category`, `categorycount`, `colorcount` and `bandcolorcount`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkParcatsAttr "hovertemplate" value
    /// Sort paths so that like colors are bundled together within each category.
    static member inline bundlecolors (value: bool) = Interop.mkParcatsAttr "bundlecolors" value
    /// Sets the font for the `dimension` labels.
    static member inline labelfont (properties: #ILabelfontProperty list) = Interop.mkParcatsAttr "labelfont" (createObj !!properties)
    /// Sets the font for the `category` labels.
    static member inline tickfont (properties: #ITickfontProperty list) = Interop.mkParcatsAttr "tickfont" (createObj !!properties)
    static member inline dimensions (properties: #IDimensionsProperty list) = Interop.mkParcatsAttr "dimensions" (createObj !!properties)
    static member inline line (properties: #ILineProperty list) = Interop.mkParcatsAttr "line" (createObj !!properties)
    /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
    static member inline counts (value: int) = Interop.mkParcatsAttr "counts" value
    /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
    static member inline counts (value: float) = Interop.mkParcatsAttr "counts" value
    /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
    static member inline counts (values: seq<int>) = Interop.mkParcatsAttr "counts" (values |> Array.ofSeq)
    /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
    static member inline counts (values: seq<float>) = Interop.mkParcatsAttr "counts" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkParcatsAttr "metasrc" value
    /// Sets the source reference on plot.ly for  counts .
    static member inline countssrc (value: string) = Interop.mkParcatsAttr "countssrc" value

[<AutoOpen>]
module parcats =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkParcatsAttr "visible" "legendonly"
        static member inline false' = Interop.mkParcatsAttr "visible" "false"
        static member inline true' = Interop.mkParcatsAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkParcatsAttr "hoverinfo" "all"
        static member inline none = Interop.mkParcatsAttr "hoverinfo" "none"
        static member inline skip = Interop.mkParcatsAttr "hoverinfo" "skip"
        static member inline count = Interop.mkParcatsAttr "hoverinfo" "count"
        static member inline probability = Interop.mkParcatsAttr "hoverinfo" "probability"
        static member inline probabilityAndCount = Interop.mkParcatsAttr "hoverinfo" "probability+count"

    /// Sets the hover interaction mode for the parcats diagram. If `category`, hover interaction take place per category. If `color`, hover interactions take place per color per category. If `dimension`, hover interactions take place across all categories per dimension.
    [<Erase>]
    type hoveron =
        static member inline category = Interop.mkParcatsAttr "hoveron" "category"
        static member inline color = Interop.mkParcatsAttr "hoveron" "color"
        static member inline dimension = Interop.mkParcatsAttr "hoveron" "dimension"

    /// Sets the drag interaction mode for categories and dimensions. If `perpendicular`, the categories can only move along a line perpendicular to the paths. If `freeform`, the categories can freely move on the plane. If `fixed`, the categories and dimensions are stationary.
    [<Erase>]
    type arrangement =
        static member inline fixed' = Interop.mkParcatsAttr "arrangement" "fixed"
        static member inline freeform = Interop.mkParcatsAttr "arrangement" "freeform"
        static member inline perpendicular = Interop.mkParcatsAttr "arrangement" "perpendicular"

    /// Sets the path sorting algorithm. If `forward`, sort paths based on dimension categories from left to right. If `backward`, sort paths based on dimensions categories from right to left.
    [<Erase>]
    type sortpaths =
        static member inline backward = Interop.mkParcatsAttr "sortpaths" "backward"
        static member inline forward = Interop.mkParcatsAttr "sortpaths" "forward"

