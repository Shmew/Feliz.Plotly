namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scatter3d =
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkScatter3dAttr "showlegend" value
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkScatter3dAttr "legendgroup" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkScatter3dAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkScatter3dAttr "opacity" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkScatter3dAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkScatter3dAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkScatter3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkScatter3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkScatter3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkScatter3dAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkScatter3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkScatter3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkScatter3dAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkScatter3dAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkScatter3dAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkScatter3dAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkScatter3dAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkScatter3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkScatter3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkScatter3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkScatter3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkScatter3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkScatter3dAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkScatter3dAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkScatter3dAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<bool>) = Interop.mkScatter3dAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<string>) = Interop.mkScatter3dAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<int>) = Interop.mkScatter3dAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates.
    static member inline x (values: seq<float>) = Interop.mkScatter3dAttr "x" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<bool>) = Interop.mkScatter3dAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<string>) = Interop.mkScatter3dAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<int>) = Interop.mkScatter3dAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates.
    static member inline y (values: seq<float>) = Interop.mkScatter3dAttr "y" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<bool>) = Interop.mkScatter3dAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<string>) = Interop.mkScatter3dAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<int>) = Interop.mkScatter3dAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates.
    static member inline z (values: seq<float>) = Interop.mkScatter3dAttr "z" (values |> Array.ofSeq)
    /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkScatter3dAttr "text" value
    /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkScatter3dAttr "text" (values |> Array.ofSeq)
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (value: string) = Interop.mkScatter3dAttr "texttemplate" value
    /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
    static member inline texttemplate (values: seq<string>) = Interop.mkScatter3dAttr "texttemplate" (values |> Array.ofSeq)
    /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (value: string) = Interop.mkScatter3dAttr "hovertext" value
    /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
    static member inline hovertext (values: seq<string>) = Interop.mkScatter3dAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkScatter3dAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkScatter3dAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the surface fill color.
    static member inline surfacecolor (value: string) = Interop.mkScatter3dAttr "surfacecolor" value
    static member inline projection (properties: #IProjectionProperty list) = Interop.mkScatter3dAttr "projection" (createObj !!properties)
    /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
    static member inline connectgaps (value: bool) = Interop.mkScatter3dAttr "connectgaps" value
    static member inline line (properties: #ILineProperty list) = Interop.mkScatter3dAttr "line" (createObj !!properties)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkScatter3dAttr "marker" (createObj !!properties)
    static member inline textfont (properties: #ITextfontProperty list) = Interop.mkScatter3dAttr "textfont" (createObj !!properties)
    static member inline errorX (properties: #IErrorXProperty list) = Interop.mkScatter3dAttr "error_x" (createObj !!properties)
    static member inline errorY (properties: #IErrorYProperty list) = Interop.mkScatter3dAttr "error_y" (createObj !!properties)
    static member inline errorZ (properties: #IErrorZProperty list) = Interop.mkScatter3dAttr "error_z" (createObj !!properties)
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (values: seq<string>) = Interop.mkScatter3dAttr "scene" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkScatter3dAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkScatter3dAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkScatter3dAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkScatter3dAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkScatter3dAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkScatter3dAttr "zsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkScatter3dAttr "textsrc" value
    /// Sets the source reference on plot.ly for  texttemplate .
    static member inline texttemplatesrc (value: string) = Interop.mkScatter3dAttr "texttemplatesrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkScatter3dAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkScatter3dAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  textposition .
    static member inline textpositionsrc (value: string) = Interop.mkScatter3dAttr "textpositionsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkScatter3dAttr "hoverinfosrc" value

[<AutoOpen>]
module scatter3d =
    /// Use a list of enumerated values
    let inline textpositions (properties: #IScatter3dProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkScatter3dAttr "textposition"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkScatter3dAttr "visible" "legendonly"
        static member inline false' = Interop.mkScatter3dAttr "visible" "false"
        static member inline true' = Interop.mkScatter3dAttr "visible" "true"

    /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
    [<Erase>]
    type mode =
        static member inline none = Interop.mkScatter3dAttr "mode" "none"
        static member inline lines = Interop.mkScatter3dAttr "mode" "lines"
        static member inline markers = Interop.mkScatter3dAttr "mode" "markers"
        static member inline markersAndLines = Interop.mkScatter3dAttr "mode" "markers+lines"
        static member inline text = Interop.mkScatter3dAttr "mode" "text"
        static member inline textAndLines = Interop.mkScatter3dAttr "mode" "text+lines"
        static member inline textAndMarkers = Interop.mkScatter3dAttr "mode" "text+markers"
        static member inline textAndMarkersLines = Interop.mkScatter3dAttr "mode" "text+markers+lines"

    /// If *-1*, the scatter points are not fill with a surface If *0*, *1*, *2*, the scatter points are filled with a Delaunay surface about the x, y, z respectively.
    [<Erase>]
    type surfaceaxis =
        static member inline neg1 = Interop.mkScatter3dAttr "surfaceaxis" "-1"
        static member inline _0 = Interop.mkScatter3dAttr "surfaceaxis" "0"
        static member inline _1 = Interop.mkScatter3dAttr "surfaceaxis" "1"
        static member inline _2 = Interop.mkScatter3dAttr "surfaceaxis" "2"

    /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
    [<Erase>]
    type textposition =
        static member inline bottomCenter = Interop.mkScatter3dAttr "textposition" "bottom center"
        static member inline bottomLeft = Interop.mkScatter3dAttr "textposition" "bottom left"
        static member inline bottomRight = Interop.mkScatter3dAttr "textposition" "bottom right"
        static member inline middleCenter = Interop.mkScatter3dAttr "textposition" "middle center"
        static member inline middleLeft = Interop.mkScatter3dAttr "textposition" "middle left"
        static member inline middleRight = Interop.mkScatter3dAttr "textposition" "middle right"
        static member inline topCenter = Interop.mkScatter3dAttr "textposition" "top center"
        static member inline topLeft = Interop.mkScatter3dAttr "textposition" "top left"
        static member inline topRight = Interop.mkScatter3dAttr "textposition" "top right"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkScatter3dAttr "hoverinfo" "all"
        static member inline none = Interop.mkScatter3dAttr "hoverinfo" "none"
        static member inline skip = Interop.mkScatter3dAttr "hoverinfo" "skip"
        static member inline name = Interop.mkScatter3dAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkScatter3dAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkScatter3dAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkScatter3dAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkScatter3dAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkScatter3dAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkScatter3dAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkScatter3dAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkScatter3dAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkScatter3dAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkScatter3dAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkScatter3dAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkScatter3dAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkScatter3dAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkScatter3dAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkScatter3dAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkScatter3dAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkScatter3dAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkScatter3dAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkScatter3dAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkScatter3dAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkScatter3dAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkScatter3dAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkScatter3dAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkScatter3dAttr "hoverinfo" "x"
        static member inline y = Interop.mkScatter3dAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkScatter3dAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkScatter3dAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkScatter3dAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkScatter3dAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkScatter3dAttr "hoverinfo" "z+y+x"

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkScatter3dAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkScatter3dAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkScatter3dAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkScatter3dAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkScatter3dAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkScatter3dAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkScatter3dAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkScatter3dAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkScatter3dAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkScatter3dAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkScatter3dAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkScatter3dAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkScatter3dAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkScatter3dAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkScatter3dAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkScatter3dAttr "xcalendar" "ummalqura"

    /// Sets the calendar system to use with `y` date data.
    [<Erase>]
    type ycalendar =
        static member inline chinese = Interop.mkScatter3dAttr "ycalendar" "chinese"
        static member inline coptic = Interop.mkScatter3dAttr "ycalendar" "coptic"
        static member inline discworld = Interop.mkScatter3dAttr "ycalendar" "discworld"
        static member inline ethiopian = Interop.mkScatter3dAttr "ycalendar" "ethiopian"
        static member inline gregorian = Interop.mkScatter3dAttr "ycalendar" "gregorian"
        static member inline hebrew = Interop.mkScatter3dAttr "ycalendar" "hebrew"
        static member inline islamic = Interop.mkScatter3dAttr "ycalendar" "islamic"
        static member inline jalali = Interop.mkScatter3dAttr "ycalendar" "jalali"
        static member inline julian = Interop.mkScatter3dAttr "ycalendar" "julian"
        static member inline mayan = Interop.mkScatter3dAttr "ycalendar" "mayan"
        static member inline nanakshahi = Interop.mkScatter3dAttr "ycalendar" "nanakshahi"
        static member inline nepali = Interop.mkScatter3dAttr "ycalendar" "nepali"
        static member inline persian = Interop.mkScatter3dAttr "ycalendar" "persian"
        static member inline taiwan = Interop.mkScatter3dAttr "ycalendar" "taiwan"
        static member inline thai = Interop.mkScatter3dAttr "ycalendar" "thai"
        static member inline ummalqura = Interop.mkScatter3dAttr "ycalendar" "ummalqura"

    /// Sets the calendar system to use with `z` date data.
    [<Erase>]
    type zcalendar =
        static member inline chinese = Interop.mkScatter3dAttr "zcalendar" "chinese"
        static member inline coptic = Interop.mkScatter3dAttr "zcalendar" "coptic"
        static member inline discworld = Interop.mkScatter3dAttr "zcalendar" "discworld"
        static member inline ethiopian = Interop.mkScatter3dAttr "zcalendar" "ethiopian"
        static member inline gregorian = Interop.mkScatter3dAttr "zcalendar" "gregorian"
        static member inline hebrew = Interop.mkScatter3dAttr "zcalendar" "hebrew"
        static member inline islamic = Interop.mkScatter3dAttr "zcalendar" "islamic"
        static member inline jalali = Interop.mkScatter3dAttr "zcalendar" "jalali"
        static member inline julian = Interop.mkScatter3dAttr "zcalendar" "julian"
        static member inline mayan = Interop.mkScatter3dAttr "zcalendar" "mayan"
        static member inline nanakshahi = Interop.mkScatter3dAttr "zcalendar" "nanakshahi"
        static member inline nepali = Interop.mkScatter3dAttr "zcalendar" "nepali"
        static member inline persian = Interop.mkScatter3dAttr "zcalendar" "persian"
        static member inline taiwan = Interop.mkScatter3dAttr "zcalendar" "taiwan"
        static member inline thai = Interop.mkScatter3dAttr "zcalendar" "thai"
        static member inline ummalqura = Interop.mkScatter3dAttr "zcalendar" "ummalqura"

