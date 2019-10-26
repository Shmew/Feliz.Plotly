namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type pointcloud =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkPointcloudAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkPointcloudAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkPointcloudAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkPointcloudAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkPointcloudAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkPointcloudAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkPointcloudAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkPointcloudAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkPointcloudAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkPointcloudAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkPointcloudAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkPointcloudAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkPointcloudAttr "x" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkPointcloudAttr "y" (values |> Array.ofSeq)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<bool>) = Interop.mkPointcloudAttr "xy" (values |> Array.ofSeq)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<string>) = Interop.mkPointcloudAttr "xy" (values |> Array.ofSeq)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<int>) = Interop.mkPointcloudAttr "xy" (values |> Array.ofSeq)
    /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
    static member inline xy (values: seq<float>) = Interop.mkPointcloudAttr "xy" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<bool>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<string>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<int>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
    static member inline indices (values: seq<float>) = Interop.mkPointcloudAttr "indices" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<bool>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<string>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<int>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
    static member inline xbounds (values: seq<float>) = Interop.mkPointcloudAttr "xbounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<bool>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<string>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<int>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
    static member inline ybounds (values: seq<float>) = Interop.mkPointcloudAttr "ybounds" (values |> Array.ofSeq)
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkPointcloudAttr "text" value
    /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkPointcloudAttr "text" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkPointcloudAttr "marker" (createObj !!properties)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (values: seq<string>) = Interop.mkPointcloudAttr "xaxis" (values |> Array.ofSeq)
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (values: seq<string>) = Interop.mkPointcloudAttr "yaxis" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkPointcloudAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkPointcloudAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkPointcloudAttr "metasrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkPointcloudAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkPointcloudAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkPointcloudAttr "ysrc" value
    /// Sets the source reference on plot.ly for  xy .
    static member inline xysrc (value: string) = Interop.mkPointcloudAttr "xysrc" value
    /// Sets the source reference on plot.ly for  indices .
    static member inline indicessrc (value: string) = Interop.mkPointcloudAttr "indicessrc" value
    /// Sets the source reference on plot.ly for  xbounds .
    static member inline xboundssrc (value: string) = Interop.mkPointcloudAttr "xboundssrc" value
    /// Sets the source reference on plot.ly for  ybounds .
    static member inline yboundssrc (value: string) = Interop.mkPointcloudAttr "yboundssrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkPointcloudAttr "textsrc" value

[<AutoOpen>]
module pointcloud =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkPointcloudAttr "visible" "legendonly"
        static member inline false' = Interop.mkPointcloudAttr "visible" "false"
        static member inline true' = Interop.mkPointcloudAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkPointcloudAttr "hoverinfo" "all"
        static member inline none = Interop.mkPointcloudAttr "hoverinfo" "none"
        static member inline skip = Interop.mkPointcloudAttr "hoverinfo" "skip"
        static member inline name = Interop.mkPointcloudAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkPointcloudAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkPointcloudAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkPointcloudAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkPointcloudAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkPointcloudAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkPointcloudAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkPointcloudAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkPointcloudAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkPointcloudAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkPointcloudAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkPointcloudAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkPointcloudAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkPointcloudAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkPointcloudAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkPointcloudAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkPointcloudAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkPointcloudAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkPointcloudAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkPointcloudAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkPointcloudAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkPointcloudAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkPointcloudAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkPointcloudAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkPointcloudAttr "hoverinfo" "x"
        static member inline y = Interop.mkPointcloudAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkPointcloudAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkPointcloudAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkPointcloudAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkPointcloudAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkPointcloudAttr "hoverinfo" "z+y+x"
