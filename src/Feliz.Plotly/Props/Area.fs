namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type area =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkAreaAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkAreaAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkAreaAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkAreaAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkAreaAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkAreaAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkAreaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkAreaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkAreaAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkAreaAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkAreaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkAreaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkAreaAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkAreaAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkAreaAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkAreaAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkAreaAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkAreaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkAreaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkAreaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkAreaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkAreaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkAreaAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkAreaAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkAreaAttr "uirevision" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the radial coordinates for legacy polar chart only.
    static member inline r (values: seq<bool>) = Interop.mkAreaAttr "r" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the radial coordinates for legacy polar chart only.
    static member inline r (values: seq<string>) = Interop.mkAreaAttr "r" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the radial coordinates for legacy polar chart only.
    static member inline r (values: seq<int>) = Interop.mkAreaAttr "r" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the radial coordinates for legacy polar chart only.
    static member inline r (values: seq<float>) = Interop.mkAreaAttr "r" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the angular coordinates for legacy polar chart only.
    static member inline t (values: seq<bool>) = Interop.mkAreaAttr "t" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the angular coordinates for legacy polar chart only.
    static member inline t (values: seq<string>) = Interop.mkAreaAttr "t" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the angular coordinates for legacy polar chart only.
    static member inline t (values: seq<int>) = Interop.mkAreaAttr "t" (values |> Array.ofSeq)
    /// Area traces are deprecated! Please switch to the *barpolar* trace type. Sets the angular coordinates for legacy polar chart only.
    static member inline t (values: seq<float>) = Interop.mkAreaAttr "t" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkAreaAttr "marker" (createObj !!properties)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkAreaAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkAreaAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkAreaAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkAreaAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  r .
    static member inline rsrc (value: string) = Interop.mkAreaAttr "rsrc" value
    /// Sets the source reference on plot.ly for  t .
    static member inline tsrc (value: string) = Interop.mkAreaAttr "tsrc" value

[<AutoOpen>]
module area =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkAreaAttr "visible" "legendonly"
        static member inline false' = Interop.mkAreaAttr "visible" "false"
        static member inline true' = Interop.mkAreaAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkAreaAttr "hoverinfo" "all"
        static member inline none = Interop.mkAreaAttr "hoverinfo" "none"
        static member inline skip = Interop.mkAreaAttr "hoverinfo" "skip"
        static member inline name = Interop.mkAreaAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkAreaAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkAreaAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkAreaAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkAreaAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkAreaAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkAreaAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkAreaAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkAreaAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkAreaAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkAreaAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkAreaAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkAreaAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkAreaAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkAreaAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkAreaAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkAreaAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkAreaAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkAreaAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkAreaAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkAreaAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkAreaAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkAreaAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkAreaAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkAreaAttr "hoverinfo" "x"
        static member inline y = Interop.mkAreaAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkAreaAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkAreaAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkAreaAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkAreaAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkAreaAttr "hoverinfo" "z+y+x"

