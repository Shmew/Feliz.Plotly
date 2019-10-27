namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type cone =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkConeAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkConeAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkConeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkConeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkConeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkConeAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkConeAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkConeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkConeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkConeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkConeAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkConeAttr "customdata" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkConeAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkConeAttr "stream" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkConeAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkConeAttr "uirevision" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: bool) = Interop.mkConeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<bool>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: string) = Interop.mkConeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<string>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: int) = Interop.mkConeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<int>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (value: float) = Interop.mkConeAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates of the vector field and of the displayed cones.
    static member inline x (values: seq<float>) = Interop.mkConeAttr "x" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: bool) = Interop.mkConeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<bool>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: string) = Interop.mkConeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<string>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: int) = Interop.mkConeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<int>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (value: float) = Interop.mkConeAttr "y" (value |> Array.singleton)
    /// Sets the y coordinates of the vector field and of the displayed cones.
    static member inline y (values: seq<float>) = Interop.mkConeAttr "y" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: bool) = Interop.mkConeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<bool>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: string) = Interop.mkConeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<string>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: int) = Interop.mkConeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<int>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (value: float) = Interop.mkConeAttr "z" (value |> Array.singleton)
    /// Sets the z coordinates of the vector field and of the displayed cones.
    static member inline z (values: seq<float>) = Interop.mkConeAttr "z" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: bool) = Interop.mkConeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<bool>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: string) = Interop.mkConeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<string>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: int) = Interop.mkConeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<int>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the x components of the vector field.
    static member inline u (value: float) = Interop.mkConeAttr "u" (value |> Array.singleton)
    /// Sets the x components of the vector field.
    static member inline u (values: seq<float>) = Interop.mkConeAttr "u" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: bool) = Interop.mkConeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<bool>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: string) = Interop.mkConeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<string>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: int) = Interop.mkConeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<int>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the y components of the vector field.
    static member inline v (value: float) = Interop.mkConeAttr "v" (value |> Array.singleton)
    /// Sets the y components of the vector field.
    static member inline v (values: seq<float>) = Interop.mkConeAttr "v" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: bool) = Interop.mkConeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<bool>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: string) = Interop.mkConeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<string>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: int) = Interop.mkConeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<int>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Sets the z components of the vector field.
    static member inline w (value: float) = Interop.mkConeAttr "w" (value |> Array.singleton)
    /// Sets the z components of the vector field.
    static member inline w (values: seq<float>) = Interop.mkConeAttr "w" (values |> Array.ofSeq)
    /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
    static member inline sizeref (value: int) = Interop.mkConeAttr "sizeref" value
    /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
    static member inline sizeref (value: float) = Interop.mkConeAttr "sizeref" value
    /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (value: string) = Interop.mkConeAttr "text" value
    /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
    static member inline text (values: seq<string>) = Interop.mkConeAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkConeAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkConeAttr "hovertext" (values |> Array.ofSeq)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkConeAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkConeAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here u/v/w norm) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
    static member inline cauto (value: bool) = Interop.mkConeAttr "cauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: int) = Interop.mkConeAttr "cmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
    static member inline cmin (value: float) = Interop.mkConeAttr "cmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: int) = Interop.mkConeAttr "cmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
    static member inline cmax (value: float) = Interop.mkConeAttr "cmax" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: int) = Interop.mkConeAttr "cmid" value
    /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
    static member inline cmid (value: float) = Interop.mkConeAttr "cmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkConeAttr "colorscale" (value |> Array.singleton)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string>) = Interop.mkConeAttr "colorscale" (values |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkConeAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkConeAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkConeAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkConeAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkConeAttr "coloraxis" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: int) = Interop.mkConeAttr "opacity" value
    /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
    static member inline opacity (value: float) = Interop.mkConeAttr "opacity" value
    static member inline lightposition (properties: #ILightpositionProperty list) = Interop.mkConeAttr "lightposition" (createObj !!properties)
    static member inline lighting (properties: #ILightingProperty list) = Interop.mkConeAttr "lighting" (createObj !!properties)
    /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
    static member inline scene (value: string) = Interop.mkConeAttr "scene" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkConeAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkConeAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkConeAttr "metasrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkConeAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkConeAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkConeAttr "zsrc" value
    /// Sets the source reference on plot.ly for  u .
    static member inline usrc (value: string) = Interop.mkConeAttr "usrc" value
    /// Sets the source reference on plot.ly for  v .
    static member inline vsrc (value: string) = Interop.mkConeAttr "vsrc" value
    /// Sets the source reference on plot.ly for  w .
    static member inline wsrc (value: string) = Interop.mkConeAttr "wsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkConeAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkConeAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkConeAttr "hovertemplatesrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkConeAttr "hoverinfosrc" value

[<AutoOpen>]
module cone =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkConeAttr "visible" "legendonly"
        static member inline false' = Interop.mkConeAttr "visible" "false"
        static member inline true' = Interop.mkConeAttr "visible" "true"

    /// Determines whether `sizeref` is set as a *scaled* (i.e unitless) scalar (normalized by the max u/v/w norm in the vector field) or as *absolute* value (in the same units as the vector field).
    [<Erase>]
    type sizemode =
        static member inline absolute = Interop.mkConeAttr "sizemode" "absolute"
        static member inline scaled = Interop.mkConeAttr "sizemode" "scaled"

    /// Sets the cones' anchor with respect to their x/y/z positions. Note that *cm* denote the cone's center of mass which corresponds to 1/4 from the tail to tip.
    [<Erase>]
    type anchor =
        static member inline center = Interop.mkConeAttr "anchor" "center"
        static member inline cm = Interop.mkConeAttr "anchor" "cm"
        static member inline tail = Interop.mkConeAttr "anchor" "tail"
        static member inline tip = Interop.mkConeAttr "anchor" "tip"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkConeAttr "hoverinfo" "all"
        static member inline none = Interop.mkConeAttr "hoverinfo" "none"
        static member inline skip = Interop.mkConeAttr "hoverinfo" "skip"
        static member inline name = Interop.mkConeAttr "hoverinfo" "name"
        static member inline nameAndNorm = Interop.mkConeAttr "hoverinfo" "name+norm"
        static member inline nameAndNormU = Interop.mkConeAttr "hoverinfo" "name+norm+u"
        static member inline nameAndNormUX = Interop.mkConeAttr "hoverinfo" "name+norm+u+x"
        static member inline nameAndNormUY = Interop.mkConeAttr "hoverinfo" "name+norm+u+y"
        static member inline nameAndNormUYX = Interop.mkConeAttr "hoverinfo" "name+norm+u+y+x"
        static member inline nameAndNormUZ = Interop.mkConeAttr "hoverinfo" "name+norm+u+z"
        static member inline nameAndNormUZX = Interop.mkConeAttr "hoverinfo" "name+norm+u+z+x"
        static member inline nameAndNormUZY = Interop.mkConeAttr "hoverinfo" "name+norm+u+z+y"
        static member inline nameAndNormUZYX = Interop.mkConeAttr "hoverinfo" "name+norm+u+z+y+x"
        static member inline nameAndNormV = Interop.mkConeAttr "hoverinfo" "name+norm+v"
        static member inline nameAndNormVU = Interop.mkConeAttr "hoverinfo" "name+norm+v+u"
        static member inline nameAndNormVUX = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+x"
        static member inline nameAndNormVUY = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+y"
        static member inline nameAndNormVUYX = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+y+x"
        static member inline nameAndNormVUZ = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+z"
        static member inline nameAndNormVUZX = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+z+x"
        static member inline nameAndNormVUZY = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+z+y"
        static member inline nameAndNormVUZYX = Interop.mkConeAttr "hoverinfo" "name+norm+v+u+z+y+x"
        static member inline nameAndNormVX = Interop.mkConeAttr "hoverinfo" "name+norm+v+x"
        static member inline nameAndNormVY = Interop.mkConeAttr "hoverinfo" "name+norm+v+y"
        static member inline nameAndNormVYX = Interop.mkConeAttr "hoverinfo" "name+norm+v+y+x"
        static member inline nameAndNormVZ = Interop.mkConeAttr "hoverinfo" "name+norm+v+z"
        static member inline nameAndNormVZX = Interop.mkConeAttr "hoverinfo" "name+norm+v+z+x"
        static member inline nameAndNormVZY = Interop.mkConeAttr "hoverinfo" "name+norm+v+z+y"
        static member inline nameAndNormVZYX = Interop.mkConeAttr "hoverinfo" "name+norm+v+z+y+x"
        static member inline nameAndNormW = Interop.mkConeAttr "hoverinfo" "name+norm+w"
        static member inline nameAndNormWU = Interop.mkConeAttr "hoverinfo" "name+norm+w+u"
        static member inline nameAndNormWUX = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+x"
        static member inline nameAndNormWUY = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+y"
        static member inline nameAndNormWUYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+y+x"
        static member inline nameAndNormWUZ = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+z"
        static member inline nameAndNormWUZX = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+z+x"
        static member inline nameAndNormWUZY = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+z+y"
        static member inline nameAndNormWUZYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+u+z+y+x"
        static member inline nameAndNormWV = Interop.mkConeAttr "hoverinfo" "name+norm+w+v"
        static member inline nameAndNormWVU = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u"
        static member inline nameAndNormWVUX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+x"
        static member inline nameAndNormWVUY = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+y"
        static member inline nameAndNormWVUYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+y+x"
        static member inline nameAndNormWVUZ = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+z"
        static member inline nameAndNormWVUZX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+z+x"
        static member inline nameAndNormWVUZY = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+z+y"
        static member inline nameAndNormWVUZYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+u+z+y+x"
        static member inline nameAndNormWVX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+x"
        static member inline nameAndNormWVY = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+y"
        static member inline nameAndNormWVYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+y+x"
        static member inline nameAndNormWVZ = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+z"
        static member inline nameAndNormWVZX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+z+x"
        static member inline nameAndNormWVZY = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+z+y"
        static member inline nameAndNormWVZYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+v+z+y+x"
        static member inline nameAndNormWX = Interop.mkConeAttr "hoverinfo" "name+norm+w+x"
        static member inline nameAndNormWY = Interop.mkConeAttr "hoverinfo" "name+norm+w+y"
        static member inline nameAndNormWYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+y+x"
        static member inline nameAndNormWZ = Interop.mkConeAttr "hoverinfo" "name+norm+w+z"
        static member inline nameAndNormWZX = Interop.mkConeAttr "hoverinfo" "name+norm+w+z+x"
        static member inline nameAndNormWZY = Interop.mkConeAttr "hoverinfo" "name+norm+w+z+y"
        static member inline nameAndNormWZYX = Interop.mkConeAttr "hoverinfo" "name+norm+w+z+y+x"
        static member inline nameAndNormX = Interop.mkConeAttr "hoverinfo" "name+norm+x"
        static member inline nameAndNormY = Interop.mkConeAttr "hoverinfo" "name+norm+y"
        static member inline nameAndNormYX = Interop.mkConeAttr "hoverinfo" "name+norm+y+x"
        static member inline nameAndNormZ = Interop.mkConeAttr "hoverinfo" "name+norm+z"
        static member inline nameAndNormZX = Interop.mkConeAttr "hoverinfo" "name+norm+z+x"
        static member inline nameAndNormZY = Interop.mkConeAttr "hoverinfo" "name+norm+z+y"
        static member inline nameAndNormZYX = Interop.mkConeAttr "hoverinfo" "name+norm+z+y+x"
        static member inline nameAndText = Interop.mkConeAttr "hoverinfo" "name+text"
        static member inline nameAndTextNorm = Interop.mkConeAttr "hoverinfo" "name+text+norm"
        static member inline nameAndTextNormU = Interop.mkConeAttr "hoverinfo" "name+text+norm+u"
        static member inline nameAndTextNormUX = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+x"
        static member inline nameAndTextNormUY = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+y"
        static member inline nameAndTextNormUYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+y+x"
        static member inline nameAndTextNormUZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+z"
        static member inline nameAndTextNormUZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+z+x"
        static member inline nameAndTextNormUZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+z+y"
        static member inline nameAndTextNormUZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+u+z+y+x"
        static member inline nameAndTextNormV = Interop.mkConeAttr "hoverinfo" "name+text+norm+v"
        static member inline nameAndTextNormVU = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u"
        static member inline nameAndTextNormVUX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+x"
        static member inline nameAndTextNormVUY = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+y"
        static member inline nameAndTextNormVUYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+y+x"
        static member inline nameAndTextNormVUZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+z"
        static member inline nameAndTextNormVUZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+z+x"
        static member inline nameAndTextNormVUZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+z+y"
        static member inline nameAndTextNormVUZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+u+z+y+x"
        static member inline nameAndTextNormVX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+x"
        static member inline nameAndTextNormVY = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+y"
        static member inline nameAndTextNormVYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+y+x"
        static member inline nameAndTextNormVZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+z"
        static member inline nameAndTextNormVZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+z+x"
        static member inline nameAndTextNormVZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+z+y"
        static member inline nameAndTextNormVZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+v+z+y+x"
        static member inline nameAndTextNormW = Interop.mkConeAttr "hoverinfo" "name+text+norm+w"
        static member inline nameAndTextNormWU = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u"
        static member inline nameAndTextNormWUX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+x"
        static member inline nameAndTextNormWUY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+y"
        static member inline nameAndTextNormWUYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+y+x"
        static member inline nameAndTextNormWUZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+z"
        static member inline nameAndTextNormWUZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+z+x"
        static member inline nameAndTextNormWUZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+z+y"
        static member inline nameAndTextNormWUZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+u+z+y+x"
        static member inline nameAndTextNormWV = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v"
        static member inline nameAndTextNormWVU = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u"
        static member inline nameAndTextNormWVUX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+x"
        static member inline nameAndTextNormWVUY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+y"
        static member inline nameAndTextNormWVUYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+y+x"
        static member inline nameAndTextNormWVUZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+z"
        static member inline nameAndTextNormWVUZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+z+x"
        static member inline nameAndTextNormWVUZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+z+y"
        static member inline nameAndTextNormWVUZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+u+z+y+x"
        static member inline nameAndTextNormWVX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+x"
        static member inline nameAndTextNormWVY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+y"
        static member inline nameAndTextNormWVYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+y+x"
        static member inline nameAndTextNormWVZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+z"
        static member inline nameAndTextNormWVZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+z+x"
        static member inline nameAndTextNormWVZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+z+y"
        static member inline nameAndTextNormWVZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+v+z+y+x"
        static member inline nameAndTextNormWX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+x"
        static member inline nameAndTextNormWY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+y"
        static member inline nameAndTextNormWYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+y+x"
        static member inline nameAndTextNormWZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+z"
        static member inline nameAndTextNormWZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+z+x"
        static member inline nameAndTextNormWZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+z+y"
        static member inline nameAndTextNormWZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+w+z+y+x"
        static member inline nameAndTextNormX = Interop.mkConeAttr "hoverinfo" "name+text+norm+x"
        static member inline nameAndTextNormY = Interop.mkConeAttr "hoverinfo" "name+text+norm+y"
        static member inline nameAndTextNormYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+y+x"
        static member inline nameAndTextNormZ = Interop.mkConeAttr "hoverinfo" "name+text+norm+z"
        static member inline nameAndTextNormZX = Interop.mkConeAttr "hoverinfo" "name+text+norm+z+x"
        static member inline nameAndTextNormZY = Interop.mkConeAttr "hoverinfo" "name+text+norm+z+y"
        static member inline nameAndTextNormZYX = Interop.mkConeAttr "hoverinfo" "name+text+norm+z+y+x"
        static member inline nameAndTextU = Interop.mkConeAttr "hoverinfo" "name+text+u"
        static member inline nameAndTextUX = Interop.mkConeAttr "hoverinfo" "name+text+u+x"
        static member inline nameAndTextUY = Interop.mkConeAttr "hoverinfo" "name+text+u+y"
        static member inline nameAndTextUYX = Interop.mkConeAttr "hoverinfo" "name+text+u+y+x"
        static member inline nameAndTextUZ = Interop.mkConeAttr "hoverinfo" "name+text+u+z"
        static member inline nameAndTextUZX = Interop.mkConeAttr "hoverinfo" "name+text+u+z+x"
        static member inline nameAndTextUZY = Interop.mkConeAttr "hoverinfo" "name+text+u+z+y"
        static member inline nameAndTextUZYX = Interop.mkConeAttr "hoverinfo" "name+text+u+z+y+x"
        static member inline nameAndTextV = Interop.mkConeAttr "hoverinfo" "name+text+v"
        static member inline nameAndTextVU = Interop.mkConeAttr "hoverinfo" "name+text+v+u"
        static member inline nameAndTextVUX = Interop.mkConeAttr "hoverinfo" "name+text+v+u+x"
        static member inline nameAndTextVUY = Interop.mkConeAttr "hoverinfo" "name+text+v+u+y"
        static member inline nameAndTextVUYX = Interop.mkConeAttr "hoverinfo" "name+text+v+u+y+x"
        static member inline nameAndTextVUZ = Interop.mkConeAttr "hoverinfo" "name+text+v+u+z"
        static member inline nameAndTextVUZX = Interop.mkConeAttr "hoverinfo" "name+text+v+u+z+x"
        static member inline nameAndTextVUZY = Interop.mkConeAttr "hoverinfo" "name+text+v+u+z+y"
        static member inline nameAndTextVUZYX = Interop.mkConeAttr "hoverinfo" "name+text+v+u+z+y+x"
        static member inline nameAndTextVX = Interop.mkConeAttr "hoverinfo" "name+text+v+x"
        static member inline nameAndTextVY = Interop.mkConeAttr "hoverinfo" "name+text+v+y"
        static member inline nameAndTextVYX = Interop.mkConeAttr "hoverinfo" "name+text+v+y+x"
        static member inline nameAndTextVZ = Interop.mkConeAttr "hoverinfo" "name+text+v+z"
        static member inline nameAndTextVZX = Interop.mkConeAttr "hoverinfo" "name+text+v+z+x"
        static member inline nameAndTextVZY = Interop.mkConeAttr "hoverinfo" "name+text+v+z+y"
        static member inline nameAndTextVZYX = Interop.mkConeAttr "hoverinfo" "name+text+v+z+y+x"
        static member inline nameAndTextW = Interop.mkConeAttr "hoverinfo" "name+text+w"
        static member inline nameAndTextWU = Interop.mkConeAttr "hoverinfo" "name+text+w+u"
        static member inline nameAndTextWUX = Interop.mkConeAttr "hoverinfo" "name+text+w+u+x"
        static member inline nameAndTextWUY = Interop.mkConeAttr "hoverinfo" "name+text+w+u+y"
        static member inline nameAndTextWUYX = Interop.mkConeAttr "hoverinfo" "name+text+w+u+y+x"
        static member inline nameAndTextWUZ = Interop.mkConeAttr "hoverinfo" "name+text+w+u+z"
        static member inline nameAndTextWUZX = Interop.mkConeAttr "hoverinfo" "name+text+w+u+z+x"
        static member inline nameAndTextWUZY = Interop.mkConeAttr "hoverinfo" "name+text+w+u+z+y"
        static member inline nameAndTextWUZYX = Interop.mkConeAttr "hoverinfo" "name+text+w+u+z+y+x"
        static member inline nameAndTextWV = Interop.mkConeAttr "hoverinfo" "name+text+w+v"
        static member inline nameAndTextWVU = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u"
        static member inline nameAndTextWVUX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+x"
        static member inline nameAndTextWVUY = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+y"
        static member inline nameAndTextWVUYX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+y+x"
        static member inline nameAndTextWVUZ = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+z"
        static member inline nameAndTextWVUZX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+z+x"
        static member inline nameAndTextWVUZY = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+z+y"
        static member inline nameAndTextWVUZYX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+u+z+y+x"
        static member inline nameAndTextWVX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+x"
        static member inline nameAndTextWVY = Interop.mkConeAttr "hoverinfo" "name+text+w+v+y"
        static member inline nameAndTextWVYX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+y+x"
        static member inline nameAndTextWVZ = Interop.mkConeAttr "hoverinfo" "name+text+w+v+z"
        static member inline nameAndTextWVZX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+z+x"
        static member inline nameAndTextWVZY = Interop.mkConeAttr "hoverinfo" "name+text+w+v+z+y"
        static member inline nameAndTextWVZYX = Interop.mkConeAttr "hoverinfo" "name+text+w+v+z+y+x"
        static member inline nameAndTextWX = Interop.mkConeAttr "hoverinfo" "name+text+w+x"
        static member inline nameAndTextWY = Interop.mkConeAttr "hoverinfo" "name+text+w+y"
        static member inline nameAndTextWYX = Interop.mkConeAttr "hoverinfo" "name+text+w+y+x"
        static member inline nameAndTextWZ = Interop.mkConeAttr "hoverinfo" "name+text+w+z"
        static member inline nameAndTextWZX = Interop.mkConeAttr "hoverinfo" "name+text+w+z+x"
        static member inline nameAndTextWZY = Interop.mkConeAttr "hoverinfo" "name+text+w+z+y"
        static member inline nameAndTextWZYX = Interop.mkConeAttr "hoverinfo" "name+text+w+z+y+x"
        static member inline nameAndTextX = Interop.mkConeAttr "hoverinfo" "name+text+x"
        static member inline nameAndTextY = Interop.mkConeAttr "hoverinfo" "name+text+y"
        static member inline nameAndTextYX = Interop.mkConeAttr "hoverinfo" "name+text+y+x"
        static member inline nameAndTextZ = Interop.mkConeAttr "hoverinfo" "name+text+z"
        static member inline nameAndTextZX = Interop.mkConeAttr "hoverinfo" "name+text+z+x"
        static member inline nameAndTextZY = Interop.mkConeAttr "hoverinfo" "name+text+z+y"
        static member inline nameAndTextZYX = Interop.mkConeAttr "hoverinfo" "name+text+z+y+x"
        static member inline nameAndU = Interop.mkConeAttr "hoverinfo" "name+u"
        static member inline nameAndUX = Interop.mkConeAttr "hoverinfo" "name+u+x"
        static member inline nameAndUY = Interop.mkConeAttr "hoverinfo" "name+u+y"
        static member inline nameAndUYX = Interop.mkConeAttr "hoverinfo" "name+u+y+x"
        static member inline nameAndUZ = Interop.mkConeAttr "hoverinfo" "name+u+z"
        static member inline nameAndUZX = Interop.mkConeAttr "hoverinfo" "name+u+z+x"
        static member inline nameAndUZY = Interop.mkConeAttr "hoverinfo" "name+u+z+y"
        static member inline nameAndUZYX = Interop.mkConeAttr "hoverinfo" "name+u+z+y+x"
        static member inline nameAndV = Interop.mkConeAttr "hoverinfo" "name+v"
        static member inline nameAndVU = Interop.mkConeAttr "hoverinfo" "name+v+u"
        static member inline nameAndVUX = Interop.mkConeAttr "hoverinfo" "name+v+u+x"
        static member inline nameAndVUY = Interop.mkConeAttr "hoverinfo" "name+v+u+y"
        static member inline nameAndVUYX = Interop.mkConeAttr "hoverinfo" "name+v+u+y+x"
        static member inline nameAndVUZ = Interop.mkConeAttr "hoverinfo" "name+v+u+z"
        static member inline nameAndVUZX = Interop.mkConeAttr "hoverinfo" "name+v+u+z+x"
        static member inline nameAndVUZY = Interop.mkConeAttr "hoverinfo" "name+v+u+z+y"
        static member inline nameAndVUZYX = Interop.mkConeAttr "hoverinfo" "name+v+u+z+y+x"
        static member inline nameAndVX = Interop.mkConeAttr "hoverinfo" "name+v+x"
        static member inline nameAndVY = Interop.mkConeAttr "hoverinfo" "name+v+y"
        static member inline nameAndVYX = Interop.mkConeAttr "hoverinfo" "name+v+y+x"
        static member inline nameAndVZ = Interop.mkConeAttr "hoverinfo" "name+v+z"
        static member inline nameAndVZX = Interop.mkConeAttr "hoverinfo" "name+v+z+x"
        static member inline nameAndVZY = Interop.mkConeAttr "hoverinfo" "name+v+z+y"
        static member inline nameAndVZYX = Interop.mkConeAttr "hoverinfo" "name+v+z+y+x"
        static member inline nameAndW = Interop.mkConeAttr "hoverinfo" "name+w"
        static member inline nameAndWU = Interop.mkConeAttr "hoverinfo" "name+w+u"
        static member inline nameAndWUX = Interop.mkConeAttr "hoverinfo" "name+w+u+x"
        static member inline nameAndWUY = Interop.mkConeAttr "hoverinfo" "name+w+u+y"
        static member inline nameAndWUYX = Interop.mkConeAttr "hoverinfo" "name+w+u+y+x"
        static member inline nameAndWUZ = Interop.mkConeAttr "hoverinfo" "name+w+u+z"
        static member inline nameAndWUZX = Interop.mkConeAttr "hoverinfo" "name+w+u+z+x"
        static member inline nameAndWUZY = Interop.mkConeAttr "hoverinfo" "name+w+u+z+y"
        static member inline nameAndWUZYX = Interop.mkConeAttr "hoverinfo" "name+w+u+z+y+x"
        static member inline nameAndWV = Interop.mkConeAttr "hoverinfo" "name+w+v"
        static member inline nameAndWVU = Interop.mkConeAttr "hoverinfo" "name+w+v+u"
        static member inline nameAndWVUX = Interop.mkConeAttr "hoverinfo" "name+w+v+u+x"
        static member inline nameAndWVUY = Interop.mkConeAttr "hoverinfo" "name+w+v+u+y"
        static member inline nameAndWVUYX = Interop.mkConeAttr "hoverinfo" "name+w+v+u+y+x"
        static member inline nameAndWVUZ = Interop.mkConeAttr "hoverinfo" "name+w+v+u+z"
        static member inline nameAndWVUZX = Interop.mkConeAttr "hoverinfo" "name+w+v+u+z+x"
        static member inline nameAndWVUZY = Interop.mkConeAttr "hoverinfo" "name+w+v+u+z+y"
        static member inline nameAndWVUZYX = Interop.mkConeAttr "hoverinfo" "name+w+v+u+z+y+x"
        static member inline nameAndWVX = Interop.mkConeAttr "hoverinfo" "name+w+v+x"
        static member inline nameAndWVY = Interop.mkConeAttr "hoverinfo" "name+w+v+y"
        static member inline nameAndWVYX = Interop.mkConeAttr "hoverinfo" "name+w+v+y+x"
        static member inline nameAndWVZ = Interop.mkConeAttr "hoverinfo" "name+w+v+z"
        static member inline nameAndWVZX = Interop.mkConeAttr "hoverinfo" "name+w+v+z+x"
        static member inline nameAndWVZY = Interop.mkConeAttr "hoverinfo" "name+w+v+z+y"
        static member inline nameAndWVZYX = Interop.mkConeAttr "hoverinfo" "name+w+v+z+y+x"
        static member inline nameAndWX = Interop.mkConeAttr "hoverinfo" "name+w+x"
        static member inline nameAndWY = Interop.mkConeAttr "hoverinfo" "name+w+y"
        static member inline nameAndWYX = Interop.mkConeAttr "hoverinfo" "name+w+y+x"
        static member inline nameAndWZ = Interop.mkConeAttr "hoverinfo" "name+w+z"
        static member inline nameAndWZX = Interop.mkConeAttr "hoverinfo" "name+w+z+x"
        static member inline nameAndWZY = Interop.mkConeAttr "hoverinfo" "name+w+z+y"
        static member inline nameAndWZYX = Interop.mkConeAttr "hoverinfo" "name+w+z+y+x"
        static member inline nameAndX = Interop.mkConeAttr "hoverinfo" "name+x"
        static member inline nameAndY = Interop.mkConeAttr "hoverinfo" "name+y"
        static member inline nameAndYX = Interop.mkConeAttr "hoverinfo" "name+y+x"
        static member inline nameAndZ = Interop.mkConeAttr "hoverinfo" "name+z"
        static member inline nameAndZX = Interop.mkConeAttr "hoverinfo" "name+z+x"
        static member inline nameAndZY = Interop.mkConeAttr "hoverinfo" "name+z+y"
        static member inline nameAndZYX = Interop.mkConeAttr "hoverinfo" "name+z+y+x"
        static member inline norm = Interop.mkConeAttr "hoverinfo" "norm"
        static member inline normAndU = Interop.mkConeAttr "hoverinfo" "norm+u"
        static member inline normAndUX = Interop.mkConeAttr "hoverinfo" "norm+u+x"
        static member inline normAndUY = Interop.mkConeAttr "hoverinfo" "norm+u+y"
        static member inline normAndUYX = Interop.mkConeAttr "hoverinfo" "norm+u+y+x"
        static member inline normAndUZ = Interop.mkConeAttr "hoverinfo" "norm+u+z"
        static member inline normAndUZX = Interop.mkConeAttr "hoverinfo" "norm+u+z+x"
        static member inline normAndUZY = Interop.mkConeAttr "hoverinfo" "norm+u+z+y"
        static member inline normAndUZYX = Interop.mkConeAttr "hoverinfo" "norm+u+z+y+x"
        static member inline normAndV = Interop.mkConeAttr "hoverinfo" "norm+v"
        static member inline normAndVU = Interop.mkConeAttr "hoverinfo" "norm+v+u"
        static member inline normAndVUX = Interop.mkConeAttr "hoverinfo" "norm+v+u+x"
        static member inline normAndVUY = Interop.mkConeAttr "hoverinfo" "norm+v+u+y"
        static member inline normAndVUYX = Interop.mkConeAttr "hoverinfo" "norm+v+u+y+x"
        static member inline normAndVUZ = Interop.mkConeAttr "hoverinfo" "norm+v+u+z"
        static member inline normAndVUZX = Interop.mkConeAttr "hoverinfo" "norm+v+u+z+x"
        static member inline normAndVUZY = Interop.mkConeAttr "hoverinfo" "norm+v+u+z+y"
        static member inline normAndVUZYX = Interop.mkConeAttr "hoverinfo" "norm+v+u+z+y+x"
        static member inline normAndVX = Interop.mkConeAttr "hoverinfo" "norm+v+x"
        static member inline normAndVY = Interop.mkConeAttr "hoverinfo" "norm+v+y"
        static member inline normAndVYX = Interop.mkConeAttr "hoverinfo" "norm+v+y+x"
        static member inline normAndVZ = Interop.mkConeAttr "hoverinfo" "norm+v+z"
        static member inline normAndVZX = Interop.mkConeAttr "hoverinfo" "norm+v+z+x"
        static member inline normAndVZY = Interop.mkConeAttr "hoverinfo" "norm+v+z+y"
        static member inline normAndVZYX = Interop.mkConeAttr "hoverinfo" "norm+v+z+y+x"
        static member inline normAndW = Interop.mkConeAttr "hoverinfo" "norm+w"
        static member inline normAndWU = Interop.mkConeAttr "hoverinfo" "norm+w+u"
        static member inline normAndWUX = Interop.mkConeAttr "hoverinfo" "norm+w+u+x"
        static member inline normAndWUY = Interop.mkConeAttr "hoverinfo" "norm+w+u+y"
        static member inline normAndWUYX = Interop.mkConeAttr "hoverinfo" "norm+w+u+y+x"
        static member inline normAndWUZ = Interop.mkConeAttr "hoverinfo" "norm+w+u+z"
        static member inline normAndWUZX = Interop.mkConeAttr "hoverinfo" "norm+w+u+z+x"
        static member inline normAndWUZY = Interop.mkConeAttr "hoverinfo" "norm+w+u+z+y"
        static member inline normAndWUZYX = Interop.mkConeAttr "hoverinfo" "norm+w+u+z+y+x"
        static member inline normAndWV = Interop.mkConeAttr "hoverinfo" "norm+w+v"
        static member inline normAndWVU = Interop.mkConeAttr "hoverinfo" "norm+w+v+u"
        static member inline normAndWVUX = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+x"
        static member inline normAndWVUY = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+y"
        static member inline normAndWVUYX = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+y+x"
        static member inline normAndWVUZ = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+z"
        static member inline normAndWVUZX = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+z+x"
        static member inline normAndWVUZY = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+z+y"
        static member inline normAndWVUZYX = Interop.mkConeAttr "hoverinfo" "norm+w+v+u+z+y+x"
        static member inline normAndWVX = Interop.mkConeAttr "hoverinfo" "norm+w+v+x"
        static member inline normAndWVY = Interop.mkConeAttr "hoverinfo" "norm+w+v+y"
        static member inline normAndWVYX = Interop.mkConeAttr "hoverinfo" "norm+w+v+y+x"
        static member inline normAndWVZ = Interop.mkConeAttr "hoverinfo" "norm+w+v+z"
        static member inline normAndWVZX = Interop.mkConeAttr "hoverinfo" "norm+w+v+z+x"
        static member inline normAndWVZY = Interop.mkConeAttr "hoverinfo" "norm+w+v+z+y"
        static member inline normAndWVZYX = Interop.mkConeAttr "hoverinfo" "norm+w+v+z+y+x"
        static member inline normAndWX = Interop.mkConeAttr "hoverinfo" "norm+w+x"
        static member inline normAndWY = Interop.mkConeAttr "hoverinfo" "norm+w+y"
        static member inline normAndWYX = Interop.mkConeAttr "hoverinfo" "norm+w+y+x"
        static member inline normAndWZ = Interop.mkConeAttr "hoverinfo" "norm+w+z"
        static member inline normAndWZX = Interop.mkConeAttr "hoverinfo" "norm+w+z+x"
        static member inline normAndWZY = Interop.mkConeAttr "hoverinfo" "norm+w+z+y"
        static member inline normAndWZYX = Interop.mkConeAttr "hoverinfo" "norm+w+z+y+x"
        static member inline normAndX = Interop.mkConeAttr "hoverinfo" "norm+x"
        static member inline normAndY = Interop.mkConeAttr "hoverinfo" "norm+y"
        static member inline normAndYX = Interop.mkConeAttr "hoverinfo" "norm+y+x"
        static member inline normAndZ = Interop.mkConeAttr "hoverinfo" "norm+z"
        static member inline normAndZX = Interop.mkConeAttr "hoverinfo" "norm+z+x"
        static member inline normAndZY = Interop.mkConeAttr "hoverinfo" "norm+z+y"
        static member inline normAndZYX = Interop.mkConeAttr "hoverinfo" "norm+z+y+x"
        static member inline text = Interop.mkConeAttr "hoverinfo" "text"
        static member inline textAndNorm = Interop.mkConeAttr "hoverinfo" "text+norm"
        static member inline textAndNormU = Interop.mkConeAttr "hoverinfo" "text+norm+u"
        static member inline textAndNormUX = Interop.mkConeAttr "hoverinfo" "text+norm+u+x"
        static member inline textAndNormUY = Interop.mkConeAttr "hoverinfo" "text+norm+u+y"
        static member inline textAndNormUYX = Interop.mkConeAttr "hoverinfo" "text+norm+u+y+x"
        static member inline textAndNormUZ = Interop.mkConeAttr "hoverinfo" "text+norm+u+z"
        static member inline textAndNormUZX = Interop.mkConeAttr "hoverinfo" "text+norm+u+z+x"
        static member inline textAndNormUZY = Interop.mkConeAttr "hoverinfo" "text+norm+u+z+y"
        static member inline textAndNormUZYX = Interop.mkConeAttr "hoverinfo" "text+norm+u+z+y+x"
        static member inline textAndNormV = Interop.mkConeAttr "hoverinfo" "text+norm+v"
        static member inline textAndNormVU = Interop.mkConeAttr "hoverinfo" "text+norm+v+u"
        static member inline textAndNormVUX = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+x"
        static member inline textAndNormVUY = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+y"
        static member inline textAndNormVUYX = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+y+x"
        static member inline textAndNormVUZ = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+z"
        static member inline textAndNormVUZX = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+z+x"
        static member inline textAndNormVUZY = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+z+y"
        static member inline textAndNormVUZYX = Interop.mkConeAttr "hoverinfo" "text+norm+v+u+z+y+x"
        static member inline textAndNormVX = Interop.mkConeAttr "hoverinfo" "text+norm+v+x"
        static member inline textAndNormVY = Interop.mkConeAttr "hoverinfo" "text+norm+v+y"
        static member inline textAndNormVYX = Interop.mkConeAttr "hoverinfo" "text+norm+v+y+x"
        static member inline textAndNormVZ = Interop.mkConeAttr "hoverinfo" "text+norm+v+z"
        static member inline textAndNormVZX = Interop.mkConeAttr "hoverinfo" "text+norm+v+z+x"
        static member inline textAndNormVZY = Interop.mkConeAttr "hoverinfo" "text+norm+v+z+y"
        static member inline textAndNormVZYX = Interop.mkConeAttr "hoverinfo" "text+norm+v+z+y+x"
        static member inline textAndNormW = Interop.mkConeAttr "hoverinfo" "text+norm+w"
        static member inline textAndNormWU = Interop.mkConeAttr "hoverinfo" "text+norm+w+u"
        static member inline textAndNormWUX = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+x"
        static member inline textAndNormWUY = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+y"
        static member inline textAndNormWUYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+y+x"
        static member inline textAndNormWUZ = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+z"
        static member inline textAndNormWUZX = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+z+x"
        static member inline textAndNormWUZY = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+z+y"
        static member inline textAndNormWUZYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+u+z+y+x"
        static member inline textAndNormWV = Interop.mkConeAttr "hoverinfo" "text+norm+w+v"
        static member inline textAndNormWVU = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u"
        static member inline textAndNormWVUX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+x"
        static member inline textAndNormWVUY = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+y"
        static member inline textAndNormWVUYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+y+x"
        static member inline textAndNormWVUZ = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+z"
        static member inline textAndNormWVUZX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+z+x"
        static member inline textAndNormWVUZY = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+z+y"
        static member inline textAndNormWVUZYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+u+z+y+x"
        static member inline textAndNormWVX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+x"
        static member inline textAndNormWVY = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+y"
        static member inline textAndNormWVYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+y+x"
        static member inline textAndNormWVZ = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+z"
        static member inline textAndNormWVZX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+z+x"
        static member inline textAndNormWVZY = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+z+y"
        static member inline textAndNormWVZYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+v+z+y+x"
        static member inline textAndNormWX = Interop.mkConeAttr "hoverinfo" "text+norm+w+x"
        static member inline textAndNormWY = Interop.mkConeAttr "hoverinfo" "text+norm+w+y"
        static member inline textAndNormWYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+y+x"
        static member inline textAndNormWZ = Interop.mkConeAttr "hoverinfo" "text+norm+w+z"
        static member inline textAndNormWZX = Interop.mkConeAttr "hoverinfo" "text+norm+w+z+x"
        static member inline textAndNormWZY = Interop.mkConeAttr "hoverinfo" "text+norm+w+z+y"
        static member inline textAndNormWZYX = Interop.mkConeAttr "hoverinfo" "text+norm+w+z+y+x"
        static member inline textAndNormX = Interop.mkConeAttr "hoverinfo" "text+norm+x"
        static member inline textAndNormY = Interop.mkConeAttr "hoverinfo" "text+norm+y"
        static member inline textAndNormYX = Interop.mkConeAttr "hoverinfo" "text+norm+y+x"
        static member inline textAndNormZ = Interop.mkConeAttr "hoverinfo" "text+norm+z"
        static member inline textAndNormZX = Interop.mkConeAttr "hoverinfo" "text+norm+z+x"
        static member inline textAndNormZY = Interop.mkConeAttr "hoverinfo" "text+norm+z+y"
        static member inline textAndNormZYX = Interop.mkConeAttr "hoverinfo" "text+norm+z+y+x"
        static member inline textAndU = Interop.mkConeAttr "hoverinfo" "text+u"
        static member inline textAndUX = Interop.mkConeAttr "hoverinfo" "text+u+x"
        static member inline textAndUY = Interop.mkConeAttr "hoverinfo" "text+u+y"
        static member inline textAndUYX = Interop.mkConeAttr "hoverinfo" "text+u+y+x"
        static member inline textAndUZ = Interop.mkConeAttr "hoverinfo" "text+u+z"
        static member inline textAndUZX = Interop.mkConeAttr "hoverinfo" "text+u+z+x"
        static member inline textAndUZY = Interop.mkConeAttr "hoverinfo" "text+u+z+y"
        static member inline textAndUZYX = Interop.mkConeAttr "hoverinfo" "text+u+z+y+x"
        static member inline textAndV = Interop.mkConeAttr "hoverinfo" "text+v"
        static member inline textAndVU = Interop.mkConeAttr "hoverinfo" "text+v+u"
        static member inline textAndVUX = Interop.mkConeAttr "hoverinfo" "text+v+u+x"
        static member inline textAndVUY = Interop.mkConeAttr "hoverinfo" "text+v+u+y"
        static member inline textAndVUYX = Interop.mkConeAttr "hoverinfo" "text+v+u+y+x"
        static member inline textAndVUZ = Interop.mkConeAttr "hoverinfo" "text+v+u+z"
        static member inline textAndVUZX = Interop.mkConeAttr "hoverinfo" "text+v+u+z+x"
        static member inline textAndVUZY = Interop.mkConeAttr "hoverinfo" "text+v+u+z+y"
        static member inline textAndVUZYX = Interop.mkConeAttr "hoverinfo" "text+v+u+z+y+x"
        static member inline textAndVX = Interop.mkConeAttr "hoverinfo" "text+v+x"
        static member inline textAndVY = Interop.mkConeAttr "hoverinfo" "text+v+y"
        static member inline textAndVYX = Interop.mkConeAttr "hoverinfo" "text+v+y+x"
        static member inline textAndVZ = Interop.mkConeAttr "hoverinfo" "text+v+z"
        static member inline textAndVZX = Interop.mkConeAttr "hoverinfo" "text+v+z+x"
        static member inline textAndVZY = Interop.mkConeAttr "hoverinfo" "text+v+z+y"
        static member inline textAndVZYX = Interop.mkConeAttr "hoverinfo" "text+v+z+y+x"
        static member inline textAndW = Interop.mkConeAttr "hoverinfo" "text+w"
        static member inline textAndWU = Interop.mkConeAttr "hoverinfo" "text+w+u"
        static member inline textAndWUX = Interop.mkConeAttr "hoverinfo" "text+w+u+x"
        static member inline textAndWUY = Interop.mkConeAttr "hoverinfo" "text+w+u+y"
        static member inline textAndWUYX = Interop.mkConeAttr "hoverinfo" "text+w+u+y+x"
        static member inline textAndWUZ = Interop.mkConeAttr "hoverinfo" "text+w+u+z"
        static member inline textAndWUZX = Interop.mkConeAttr "hoverinfo" "text+w+u+z+x"
        static member inline textAndWUZY = Interop.mkConeAttr "hoverinfo" "text+w+u+z+y"
        static member inline textAndWUZYX = Interop.mkConeAttr "hoverinfo" "text+w+u+z+y+x"
        static member inline textAndWV = Interop.mkConeAttr "hoverinfo" "text+w+v"
        static member inline textAndWVU = Interop.mkConeAttr "hoverinfo" "text+w+v+u"
        static member inline textAndWVUX = Interop.mkConeAttr "hoverinfo" "text+w+v+u+x"
        static member inline textAndWVUY = Interop.mkConeAttr "hoverinfo" "text+w+v+u+y"
        static member inline textAndWVUYX = Interop.mkConeAttr "hoverinfo" "text+w+v+u+y+x"
        static member inline textAndWVUZ = Interop.mkConeAttr "hoverinfo" "text+w+v+u+z"
        static member inline textAndWVUZX = Interop.mkConeAttr "hoverinfo" "text+w+v+u+z+x"
        static member inline textAndWVUZY = Interop.mkConeAttr "hoverinfo" "text+w+v+u+z+y"
        static member inline textAndWVUZYX = Interop.mkConeAttr "hoverinfo" "text+w+v+u+z+y+x"
        static member inline textAndWVX = Interop.mkConeAttr "hoverinfo" "text+w+v+x"
        static member inline textAndWVY = Interop.mkConeAttr "hoverinfo" "text+w+v+y"
        static member inline textAndWVYX = Interop.mkConeAttr "hoverinfo" "text+w+v+y+x"
        static member inline textAndWVZ = Interop.mkConeAttr "hoverinfo" "text+w+v+z"
        static member inline textAndWVZX = Interop.mkConeAttr "hoverinfo" "text+w+v+z+x"
        static member inline textAndWVZY = Interop.mkConeAttr "hoverinfo" "text+w+v+z+y"
        static member inline textAndWVZYX = Interop.mkConeAttr "hoverinfo" "text+w+v+z+y+x"
        static member inline textAndWX = Interop.mkConeAttr "hoverinfo" "text+w+x"
        static member inline textAndWY = Interop.mkConeAttr "hoverinfo" "text+w+y"
        static member inline textAndWYX = Interop.mkConeAttr "hoverinfo" "text+w+y+x"
        static member inline textAndWZ = Interop.mkConeAttr "hoverinfo" "text+w+z"
        static member inline textAndWZX = Interop.mkConeAttr "hoverinfo" "text+w+z+x"
        static member inline textAndWZY = Interop.mkConeAttr "hoverinfo" "text+w+z+y"
        static member inline textAndWZYX = Interop.mkConeAttr "hoverinfo" "text+w+z+y+x"
        static member inline textAndX = Interop.mkConeAttr "hoverinfo" "text+x"
        static member inline textAndY = Interop.mkConeAttr "hoverinfo" "text+y"
        static member inline textAndYX = Interop.mkConeAttr "hoverinfo" "text+y+x"
        static member inline textAndZ = Interop.mkConeAttr "hoverinfo" "text+z"
        static member inline textAndZX = Interop.mkConeAttr "hoverinfo" "text+z+x"
        static member inline textAndZY = Interop.mkConeAttr "hoverinfo" "text+z+y"
        static member inline textAndZYX = Interop.mkConeAttr "hoverinfo" "text+z+y+x"
        static member inline u = Interop.mkConeAttr "hoverinfo" "u"
        static member inline uAndX = Interop.mkConeAttr "hoverinfo" "u+x"
        static member inline uAndY = Interop.mkConeAttr "hoverinfo" "u+y"
        static member inline uAndYX = Interop.mkConeAttr "hoverinfo" "u+y+x"
        static member inline uAndZ = Interop.mkConeAttr "hoverinfo" "u+z"
        static member inline uAndZX = Interop.mkConeAttr "hoverinfo" "u+z+x"
        static member inline uAndZY = Interop.mkConeAttr "hoverinfo" "u+z+y"
        static member inline uAndZYX = Interop.mkConeAttr "hoverinfo" "u+z+y+x"
        static member inline v = Interop.mkConeAttr "hoverinfo" "v"
        static member inline vAndU = Interop.mkConeAttr "hoverinfo" "v+u"
        static member inline vAndUX = Interop.mkConeAttr "hoverinfo" "v+u+x"
        static member inline vAndUY = Interop.mkConeAttr "hoverinfo" "v+u+y"
        static member inline vAndUYX = Interop.mkConeAttr "hoverinfo" "v+u+y+x"
        static member inline vAndUZ = Interop.mkConeAttr "hoverinfo" "v+u+z"
        static member inline vAndUZX = Interop.mkConeAttr "hoverinfo" "v+u+z+x"
        static member inline vAndUZY = Interop.mkConeAttr "hoverinfo" "v+u+z+y"
        static member inline vAndUZYX = Interop.mkConeAttr "hoverinfo" "v+u+z+y+x"
        static member inline vAndX = Interop.mkConeAttr "hoverinfo" "v+x"
        static member inline vAndY = Interop.mkConeAttr "hoverinfo" "v+y"
        static member inline vAndYX = Interop.mkConeAttr "hoverinfo" "v+y+x"
        static member inline vAndZ = Interop.mkConeAttr "hoverinfo" "v+z"
        static member inline vAndZX = Interop.mkConeAttr "hoverinfo" "v+z+x"
        static member inline vAndZY = Interop.mkConeAttr "hoverinfo" "v+z+y"
        static member inline vAndZYX = Interop.mkConeAttr "hoverinfo" "v+z+y+x"
        static member inline w = Interop.mkConeAttr "hoverinfo" "w"
        static member inline wAndU = Interop.mkConeAttr "hoverinfo" "w+u"
        static member inline wAndUX = Interop.mkConeAttr "hoverinfo" "w+u+x"
        static member inline wAndUY = Interop.mkConeAttr "hoverinfo" "w+u+y"
        static member inline wAndUYX = Interop.mkConeAttr "hoverinfo" "w+u+y+x"
        static member inline wAndUZ = Interop.mkConeAttr "hoverinfo" "w+u+z"
        static member inline wAndUZX = Interop.mkConeAttr "hoverinfo" "w+u+z+x"
        static member inline wAndUZY = Interop.mkConeAttr "hoverinfo" "w+u+z+y"
        static member inline wAndUZYX = Interop.mkConeAttr "hoverinfo" "w+u+z+y+x"
        static member inline wAndV = Interop.mkConeAttr "hoverinfo" "w+v"
        static member inline wAndVU = Interop.mkConeAttr "hoverinfo" "w+v+u"
        static member inline wAndVUX = Interop.mkConeAttr "hoverinfo" "w+v+u+x"
        static member inline wAndVUY = Interop.mkConeAttr "hoverinfo" "w+v+u+y"
        static member inline wAndVUYX = Interop.mkConeAttr "hoverinfo" "w+v+u+y+x"
        static member inline wAndVUZ = Interop.mkConeAttr "hoverinfo" "w+v+u+z"
        static member inline wAndVUZX = Interop.mkConeAttr "hoverinfo" "w+v+u+z+x"
        static member inline wAndVUZY = Interop.mkConeAttr "hoverinfo" "w+v+u+z+y"
        static member inline wAndVUZYX = Interop.mkConeAttr "hoverinfo" "w+v+u+z+y+x"
        static member inline wAndVX = Interop.mkConeAttr "hoverinfo" "w+v+x"
        static member inline wAndVY = Interop.mkConeAttr "hoverinfo" "w+v+y"
        static member inline wAndVYX = Interop.mkConeAttr "hoverinfo" "w+v+y+x"
        static member inline wAndVZ = Interop.mkConeAttr "hoverinfo" "w+v+z"
        static member inline wAndVZX = Interop.mkConeAttr "hoverinfo" "w+v+z+x"
        static member inline wAndVZY = Interop.mkConeAttr "hoverinfo" "w+v+z+y"
        static member inline wAndVZYX = Interop.mkConeAttr "hoverinfo" "w+v+z+y+x"
        static member inline wAndX = Interop.mkConeAttr "hoverinfo" "w+x"
        static member inline wAndY = Interop.mkConeAttr "hoverinfo" "w+y"
        static member inline wAndYX = Interop.mkConeAttr "hoverinfo" "w+y+x"
        static member inline wAndZ = Interop.mkConeAttr "hoverinfo" "w+z"
        static member inline wAndZX = Interop.mkConeAttr "hoverinfo" "w+z+x"
        static member inline wAndZY = Interop.mkConeAttr "hoverinfo" "w+z+y"
        static member inline wAndZYX = Interop.mkConeAttr "hoverinfo" "w+z+y+x"
        static member inline x = Interop.mkConeAttr "hoverinfo" "x"
        static member inline y = Interop.mkConeAttr "hoverinfo" "y"
        static member inline yAndX = Interop.mkConeAttr "hoverinfo" "y+x"
        static member inline z = Interop.mkConeAttr "hoverinfo" "z"
        static member inline zAndX = Interop.mkConeAttr "hoverinfo" "z+x"
        static member inline zAndY = Interop.mkConeAttr "hoverinfo" "z+y"
        static member inline zAndYX = Interop.mkConeAttr "hoverinfo" "z+y+x"

