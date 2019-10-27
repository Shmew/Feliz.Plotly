namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type isosurface =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkIsosurfaceAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkIsosurfaceAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkIsosurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkIsosurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkIsosurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkIsosurfaceAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkIsosurfaceAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkIsosurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkIsosurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkIsosurfaceAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkIsosurfaceAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkIsosurfaceAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkIsosurfaceAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkIsosurfaceAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkIsosurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkIsosurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkIsosurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkIsosurfaceAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkIsosurfaceAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: bool) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<bool>) = Interop.mkIsosurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: string) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<string>) = Interop.mkIsosurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: int) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<int>) = Interop.mkIsosurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (value: float) = Interop.mkIsosurfaceAttr "x" (value |> Array.singleton)
    /// Sets the X coordinates of the vertices on X axis.
    static member inline x (values: seq<float>) = Interop.mkIsosurfaceAttr "x" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: bool) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<bool>) = Interop.mkIsosurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: string) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<string>) = Interop.mkIsosurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: int) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<int>) = Interop.mkIsosurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (value: float) = Interop.mkIsosurfaceAttr "y" (value |> Array.singleton)
    /// Sets the Y coordinates of the vertices on Y axis.
    static member inline y (values: seq<float>) = Interop.mkIsosurfaceAttr "y" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: bool) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<bool>) = Interop.mkIsosurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: string) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<string>) = Interop.mkIsosurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: int) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<int>) = Interop.mkIsosurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (value: float) = Interop.mkIsosurfaceAttr "z" (value |> Array.singleton)
    /// Sets the Z coordinates of the vertices on Z axis.
    static member inline z (values: seq<float>) = Interop.mkIsosurfaceAttr "z" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: bool) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<bool>) = Interop.mkIsosurfaceAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: string) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<string>) = Interop.mkIsosurfaceAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: int) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<int>) = Interop.mkIsosurfaceAttr "value" (values |> Array.ofSeq)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (value: float) = Interop.mkIsosurfaceAttr "value" (value |> Array.singleton)
    /// Sets the 4th dimension (value) of the vertices.
    static member inline value (values: seq<float>) = Interop.mkIsosurfaceAttr "value" (values |> Array.ofSeq)
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: int) = Interop.mkIsosurfaceAttr "isomin" value
    /// Sets the minimum boundary for iso-surface plot.
    static member inline isomin (value: float) = Interop.mkIsosurfaceAttr "isomin" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: int) = Interop.mkIsosurfaceAttr "isomax" value
    /// Sets the maximum boundary for iso-surface plot.
    static member inline isomax (value: float) = Interop.mkIsosurfaceAttr "isomax" value
    static member inline surface (properties: #ISurfaceProperty list) = Interop.mkIsosurfaceAttr "surface" (createObj !!properties)
    static member inline spaceframe (properties: #ISpaceframeProperty list) = Interop.mkIsosurfaceAttr "spaceframe" (createObj !!properties)
    static member inline slices (properties: #ISlicesProperty list) = Interop.mkIsosurfaceAttr "slices" (createObj !!properties)
    static member inline caps (properties: #ICapsProperty list) = Interop.mkIsosurfaceAttr "caps" (createObj !!properties)
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkIsosurfaceAttr "text" value
    /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkIsosurfaceAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkIsosurfaceAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkIsosurfaceAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkIsosurfaceAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkIsosurfaceAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkIsosurfaceAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkIsosurfaceAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkIsosurfaceAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkIsosurfaceAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkIsosurfaceAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkIsosurfaceAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkIsosurfaceAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkIsosurfaceAttr "colorscale" (value |> Array.singleton)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string>) = Interop.mkIsosurfaceAttr "colorscale" (values |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkIsosurfaceAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkIsosurfaceAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkIsosurfaceAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkIsosurfaceAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkIsosurfaceAttr "coloraxis" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkIsosurfaceAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkIsosurfaceAttr "opacity" value
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkIsosurfaceAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkIsosurfaceAttr "lighting" (createObj !!properties)
    /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
    static member inline flatshading (value: bool) = Interop.mkIsosurfaceAttr "flatshading" value
    static member inline contour (properties: #IContourProperty list) = Interop.mkIsosurfaceAttr "contour" (createObj !!properties)
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkIsosurfaceAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkIsosurfaceAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkIsosurfaceAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkIsosurfaceAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkIsosurfaceAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkIsosurfaceAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkIsosurfaceAttr "zsrc" value
    /// Sets the source reference on plot.ly for  value .
    static member inline valuesrc (value: string) = Interop.mkIsosurfaceAttr "valuesrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkIsosurfaceAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkIsosurfaceAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkIsosurfaceAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkIsosurfaceAttr "hoverinfosrc" value

[<AutoOpen>]
module isosurface =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkIsosurfaceAttr "visible" "legendonly"
        static member inline false' = Interop.mkIsosurfaceAttr "visible" "false"
        static member inline true' = Interop.mkIsosurfaceAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkIsosurfaceAttr "hoverinfo" "all"
        static member inline none = Interop.mkIsosurfaceAttr "hoverinfo" "none"
        static member inline skip = Interop.mkIsosurfaceAttr "hoverinfo" "skip"
        static member inline name = Interop.mkIsosurfaceAttr "hoverinfo" "name"
        static member inline nameAndText = Interop.mkIsosurfaceAttr "hoverinfo" "name+text"
        static member inline nameAndTextX = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkIsosurfaceAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndX = Interop.mkIsosurfaceAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkIsosurfaceAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkIsosurfaceAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkIsosurfaceAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkIsosurfaceAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkIsosurfaceAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkIsosurfaceAttr "hoverinfo" "name+z+y+x"
        static member inline text = Interop.mkIsosurfaceAttr "hoverinfo" "text"
        static member inline textAndX = Interop.mkIsosurfaceAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkIsosurfaceAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkIsosurfaceAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkIsosurfaceAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkIsosurfaceAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkIsosurfaceAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkIsosurfaceAttr "hoverinfo" "text+z+y+x"
        static member inline x = Interop.mkIsosurfaceAttr "hoverinfo" "x"
        static member inline y = Interop.mkIsosurfaceAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkIsosurfaceAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkIsosurfaceAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkIsosurfaceAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkIsosurfaceAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkIsosurfaceAttr "hoverinfo" "z+y+x"

