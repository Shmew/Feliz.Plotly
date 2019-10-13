namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type layout =
    /// Determines whether or not a layout width or height that has been left undefined by the user is initialized on each relayout. Note that, regardless of this attribute, an undefined layout width or height is always initialized on the first call to plot.
    static member inline autosize (value: bool) = Interop.mkPlotAttr "autosize" value
    /// Sets the plot's width (in px).
    static member inline width (value: int) = Interop.mkPlotAttr "width" value
    /// Sets the plot's width (in px).
    static member inline width (value: float) = Interop.mkPlotAttr "width" value
    /// Sets the plot's height (in px).
    static member inline height (value: int) = Interop.mkPlotAttr "height" value
    /// Sets the plot's height (in px).
    static member inline height (value: float) = Interop.mkPlotAttr "height" value
    /// Sets the color of paper where the graph is drawn.
    static member inline paper_bgcolor (value: string) = Interop.mkPlotAttr "paper_bgcolor" value
    /// Sets the color of plotting area in-between x and y axes.
    static member inline plot_bgcolor (value: string) = Interop.mkPlotAttr "plot_bgcolor" value
    /// Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default.
    static member inline separators (value: string) = Interop.mkPlotAttr "separators" value
    /// Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the plotly service (at https://plot.ly or on-premise).
    static member inline hidesources (value: bool) = Interop.mkPlotAttr "hidesources" value
    /// Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`.
    static member inline showlegend (value: bool) = Interop.mkPlotAttr "showlegend" value
    /// Sets the default trace colors.
    static member inline colorway (values: seq<string>) = Interop.mkPlotAttr "colorway" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: bool) = Interop.mkPlotAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<bool>) = Interop.mkPlotAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: string) = Interop.mkPlotAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<string>) = Interop.mkPlotAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: int) = Interop.mkPlotAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<int>) = Interop.mkPlotAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: float) = Interop.mkPlotAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<float>) = Interop.mkPlotAttr "datarevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: bool) = Interop.mkPlotAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<bool>) = Interop.mkPlotAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: string) = Interop.mkPlotAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<string>) = Interop.mkPlotAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: int) = Interop.mkPlotAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<int>) = Interop.mkPlotAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: float) = Interop.mkPlotAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<float>) = Interop.mkPlotAttr "editrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: bool) = Interop.mkPlotAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<bool>) = Interop.mkPlotAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: string) = Interop.mkPlotAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<string>) = Interop.mkPlotAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: int) = Interop.mkPlotAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<int>) = Interop.mkPlotAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: float) = Interop.mkPlotAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<float>) = Interop.mkPlotAttr "selectionrevision" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: bool) = Interop.mkPlotAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<bool>) = Interop.mkPlotAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: string) = Interop.mkPlotAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<string>) = Interop.mkPlotAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: int) = Interop.mkPlotAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<int>) = Interop.mkPlotAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: float) = Interop.mkPlotAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<float>) = Interop.mkPlotAttr "template" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: bool) = Interop.mkPlotAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<bool>) = Interop.mkPlotAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: string) = Interop.mkPlotAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<string>) = Interop.mkPlotAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: int) = Interop.mkPlotAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<int>) = Interop.mkPlotAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: float) = Interop.mkPlotAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<float>) = Interop.mkPlotAttr "meta" values
    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    static member inline clickmode (values: seq<string>) = Interop.mkPlotAttr "clickmode" values
    /// Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict.
    static member inline hoverdistance (value: int) = Interop.mkPlotAttr "hoverdistance" value
    /// Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills.
    static member inline spikedistance (value: int) = Interop.mkPlotAttr "spikedistance" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: int) = Interop.mkPlotAttr "orientation" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: float) = Interop.mkPlotAttr "orientation" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkPlotAttr "metasrc" value

module layout =
    /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
    [<Erase>]
    type dragmode =
        static member inline zoom = Interop.mkPlotAttr "dragmode" "zoom"
        static member inline pan = Interop.mkPlotAttr "dragmode" "pan"
        static member inline select = Interop.mkPlotAttr "dragmode" "select"
        static member inline lasso = Interop.mkPlotAttr "dragmode" "lasso"
        static member inline orbit = Interop.mkPlotAttr "dragmode" "orbit"
        static member inline turntable = Interop.mkPlotAttr "dragmode" "turntable"
        static member inline false' = Interop.mkPlotAttr "dragmode" false

    /// Determines the mode of hover interactions. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
    [<Erase>]
    type hovermode =
        static member inline x = Interop.mkPlotAttr "hovermode" "x"
        static member inline y = Interop.mkPlotAttr "hovermode" "y"
        static member inline closest = Interop.mkPlotAttr "hovermode" "closest"
        static member inline false' = Interop.mkPlotAttr "hovermode" false

    /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
    [<Erase>]
    type selectdirection =
        static member inline h = Interop.mkPlotAttr "selectdirection" "h"
        static member inline v = Interop.mkPlotAttr "selectdirection" "v"
        static member inline d = Interop.mkPlotAttr "selectdirection" "d"
        static member inline any = Interop.mkPlotAttr "selectdirection" "any"

    /// Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
    [<Erase>]
    type calendar =
        static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
        static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
        static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
        static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
        static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
        static member inline julian = Interop.mkPlotAttr "calendar" "julian"
        static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
        static member inline persian = Interop.mkPlotAttr "calendar" "persian"
        static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
        static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
        static member inline thai = Interop.mkPlotAttr "calendar" "thai"
        static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the direction corresponding to positive angles in legacy polar charts.
    [<Erase>]
    type direction =
        static member inline clockwise = Interop.mkPlotAttr "direction" "clockwise"
        static member inline counterclockwise = Interop.mkPlotAttr "direction" "counterclockwise"

    [<Erase>]
    type font =
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        static member inline family (value: string) = Interop.mkPlotAttr "family" value
        static member inline size (value: int) = Interop.mkPlotAttr "size" value
        static member inline size (value: float) = Interop.mkPlotAttr "size" value
        static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type title =
        /// Sets the plot's title. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
        static member inline text (value: string) = Interop.mkPlotAttr "text" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: int) = Interop.mkPlotAttr "x" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: float) = Interop.mkPlotAttr "x" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: int) = Interop.mkPlotAttr "y" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: float) = Interop.mkPlotAttr "y" value

    module title =
        /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
        [<Erase>]
        type xref =
            static member inline container = Interop.mkPlotAttr "xref" "container"
            static member inline paper = Interop.mkPlotAttr "xref" "paper"

        /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
        [<Erase>]
        type yref =
            static member inline container = Interop.mkPlotAttr "yref" "container"
            static member inline paper = Interop.mkPlotAttr "yref" "paper"

        /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkPlotAttr "xanchor" "auto"
            static member inline left = Interop.mkPlotAttr "xanchor" "left"
            static member inline center = Interop.mkPlotAttr "xanchor" "center"
            static member inline right = Interop.mkPlotAttr "xanchor" "right"

        /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkPlotAttr "yanchor" "auto"
            static member inline top = Interop.mkPlotAttr "yanchor" "top"
            static member inline middle = Interop.mkPlotAttr "yanchor" "middle"
            static member inline bottom = Interop.mkPlotAttr "yanchor" "bottom"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkPlotAttr "family" value
            static member inline size (value: int) = Interop.mkPlotAttr "size" value
            static member inline size (value: float) = Interop.mkPlotAttr "size" value
            static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type pad =
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: int) = Interop.mkPlotAttr "t" value
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: float) = Interop.mkPlotAttr "t" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: int) = Interop.mkPlotAttr "r" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: float) = Interop.mkPlotAttr "r" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: int) = Interop.mkPlotAttr "b" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: float) = Interop.mkPlotAttr "b" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: int) = Interop.mkPlotAttr "l" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: float) = Interop.mkPlotAttr "l" value

    [<Erase>]
    type margin =
        /// Sets the left margin (in px).
        static member inline l (value: int) = Interop.mkPlotAttr "l" value
        /// Sets the left margin (in px).
        static member inline l (value: float) = Interop.mkPlotAttr "l" value
        /// Sets the right margin (in px).
        static member inline r (value: int) = Interop.mkPlotAttr "r" value
        /// Sets the right margin (in px).
        static member inline r (value: float) = Interop.mkPlotAttr "r" value
        /// Sets the top margin (in px).
        static member inline t (value: int) = Interop.mkPlotAttr "t" value
        /// Sets the top margin (in px).
        static member inline t (value: float) = Interop.mkPlotAttr "t" value
        /// Sets the bottom margin (in px).
        static member inline b (value: int) = Interop.mkPlotAttr "b" value
        /// Sets the bottom margin (in px).
        static member inline b (value: float) = Interop.mkPlotAttr "b" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: int) = Interop.mkPlotAttr "pad" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: float) = Interop.mkPlotAttr "pad" value
        /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
        static member inline autoexpand (value: bool) = Interop.mkPlotAttr "autoexpand" value

    [<Erase>]
    type modebar =
        /// Sets the background color of the modebar.
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Sets the color of the icons in the modebar.
        static member inline color (value: string) = Interop.mkPlotAttr "color" value
        /// Sets the color of the active or hovered on icons in the modebar.
        static member inline activecolor (value: string) = Interop.mkPlotAttr "activecolor" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module modebar =
        /// Sets the orientation of the modebar.
        [<Erase>]
        type orientation =
            static member inline v = Interop.mkPlotAttr "orientation" "v"
            static member inline h = Interop.mkPlotAttr "orientation" "h"

    [<Erase>]
    type transition =
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: int) = Interop.mkPlotAttr "duration" value
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: float) = Interop.mkPlotAttr "duration" value

    module transition =
        /// The easing function used for the transition
        [<Erase>]
        type easing =
            static member inline linear = Interop.mkPlotAttr "easing" "linear"
            static member inline quad = Interop.mkPlotAttr "easing" "quad"
            static member inline cubic = Interop.mkPlotAttr "easing" "cubic"
            static member inline sin = Interop.mkPlotAttr "easing" "sin"
            static member inline exp = Interop.mkPlotAttr "easing" "exp"
            static member inline circle = Interop.mkPlotAttr "easing" "circle"
            static member inline elastic = Interop.mkPlotAttr "easing" "elastic"
            static member inline back = Interop.mkPlotAttr "easing" "back"
            static member inline bounce = Interop.mkPlotAttr "easing" "bounce"
            static member inline linearIn = Interop.mkPlotAttr "easing" "linear-in"
            static member inline quadIn = Interop.mkPlotAttr "easing" "quad-in"
            static member inline cubicIn = Interop.mkPlotAttr "easing" "cubic-in"
            static member inline sinIn = Interop.mkPlotAttr "easing" "sin-in"
            static member inline expIn = Interop.mkPlotAttr "easing" "exp-in"
            static member inline circleIn = Interop.mkPlotAttr "easing" "circle-in"
            static member inline elasticIn = Interop.mkPlotAttr "easing" "elastic-in"
            static member inline backIn = Interop.mkPlotAttr "easing" "back-in"
            static member inline bounceIn = Interop.mkPlotAttr "easing" "bounce-in"
            static member inline linearOut = Interop.mkPlotAttr "easing" "linear-out"
            static member inline quadOut = Interop.mkPlotAttr "easing" "quad-out"
            static member inline cubicOut = Interop.mkPlotAttr "easing" "cubic-out"
            static member inline sinOut = Interop.mkPlotAttr "easing" "sin-out"
            static member inline expOut = Interop.mkPlotAttr "easing" "exp-out"
            static member inline circleOut = Interop.mkPlotAttr "easing" "circle-out"
            static member inline elasticOut = Interop.mkPlotAttr "easing" "elastic-out"
            static member inline backOut = Interop.mkPlotAttr "easing" "back-out"
            static member inline bounceOut = Interop.mkPlotAttr "easing" "bounce-out"
            static member inline linearInOut = Interop.mkPlotAttr "easing" "linear-in-out"
            static member inline quadInOut = Interop.mkPlotAttr "easing" "quad-in-out"
            static member inline cubicInOut = Interop.mkPlotAttr "easing" "cubic-in-out"
            static member inline sinInOut = Interop.mkPlotAttr "easing" "sin-in-out"
            static member inline expInOut = Interop.mkPlotAttr "easing" "exp-in-out"
            static member inline circleInOut = Interop.mkPlotAttr "easing" "circle-in-out"
            static member inline elasticInOut = Interop.mkPlotAttr "easing" "elastic-in-out"
            static member inline backInOut = Interop.mkPlotAttr "easing" "back-in-out"
            static member inline bounceInOut = Interop.mkPlotAttr "easing" "bounce-in-out"

        /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
        [<Erase>]
        type ordering =
            static member inline layoutFirst = Interop.mkPlotAttr "ordering" "layout first"
            static member inline tracesFirst = Interop.mkPlotAttr "ordering" "traces first"

    [<Erase>]
    type hoverlabel =
        /// Sets the background color of all hover labels on graph
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Sets the border color of all hover labels on graph.
        static member inline bordercolor (value: string) = Interop.mkPlotAttr "bordercolor" value
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        static member inline namelength (value: int) = Interop.mkPlotAttr "namelength" value

    module hoverlabel =
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        [<Erase>]
        type align =
            static member inline left = Interop.mkPlotAttr "align" "left"
            static member inline right = Interop.mkPlotAttr "align" "right"
            static member inline auto = Interop.mkPlotAttr "align" "auto"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkPlotAttr "family" value
            static member inline size (value: int) = Interop.mkPlotAttr "size" value
            static member inline size (value: float) = Interop.mkPlotAttr "size" value
            static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type grid =
        /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline rows (value: int) = Interop.mkPlotAttr "rows" value
        /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline columns (value: int) = Interop.mkPlotAttr "columns" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: int) = Interop.mkPlotAttr "xgap" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: float) = Interop.mkPlotAttr "xgap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: int) = Interop.mkPlotAttr "ygap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: float) = Interop.mkPlotAttr "ygap" value

    module grid =
        /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
        [<Erase>]
        type roworder =
            static member inline topToBottom = Interop.mkPlotAttr "roworder" "top to bottom"
            static member inline bottomToTop = Interop.mkPlotAttr "roworder" "bottom to top"

        /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
        [<Erase>]
        type pattern =
            static member inline independent = Interop.mkPlotAttr "pattern" "independent"
            static member inline coupled = Interop.mkPlotAttr "pattern" "coupled"

        /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
        [<Erase>]
        type xside =
            static member inline bottom = Interop.mkPlotAttr "xside" "bottom"
            static member inline bottomPlot = Interop.mkPlotAttr "xside" "bottom plot"
            static member inline topPlot = Interop.mkPlotAttr "xside" "top plot"
            static member inline top = Interop.mkPlotAttr "xside" "top"

        /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
        [<Erase>]
        type yside =
            static member inline left = Interop.mkPlotAttr "yside" "left"
            static member inline leftPlot = Interop.mkPlotAttr "yside" "left plot"
            static member inline rightPlot = Interop.mkPlotAttr "yside" "right plot"
            static member inline right = Interop.mkPlotAttr "yside" "right"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values

    [<Erase>]
    type xaxis =
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkPlotAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkPlotAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkPlotAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkPlotAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkPlotAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkPlotAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkPlotAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkPlotAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkPlotAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkPlotAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkPlotAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkPlotAttr "spikedash" value
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        static member inline spikemode (values: seq<string>) = Interop.mkPlotAttr "spikemode" values
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkPlotAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkPlotAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkPlotAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkPlotAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkPlotAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkPlotAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkPlotAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkPlotAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkPlotAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkPlotAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkPlotAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkPlotAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkPlotAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkPlotAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value

    module xaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkPlotAttr "type" "-"
            static member inline linear = Interop.mkPlotAttr "type" "linear"
            static member inline log = Interop.mkPlotAttr "type" "log"
            static member inline date = Interop.mkPlotAttr "type" "date"
            static member inline category = Interop.mkPlotAttr "type" "category"
            static member inline multicategory = Interop.mkPlotAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline true' = Interop.mkPlotAttr "autorange" true
            static member inline false' = Interop.mkPlotAttr "autorange" false
            static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline normal = Interop.mkPlotAttr "rangemode" "normal"
            static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
            static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline range = Interop.mkPlotAttr "constrain" "range"
            static member inline domain = Interop.mkPlotAttr "constrain" "domain"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline left = Interop.mkPlotAttr "constraintoward" "left"
            static member inline center = Interop.mkPlotAttr "constraintoward" "center"
            static member inline right = Interop.mkPlotAttr "constraintoward" "right"
            static member inline top = Interop.mkPlotAttr "constraintoward" "top"
            static member inline middle = Interop.mkPlotAttr "constraintoward" "middle"
            static member inline bottom = Interop.mkPlotAttr "constraintoward" "bottom"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
            static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
            static member inline array = Interop.mkPlotAttr "tickmode" "array"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline outside = Interop.mkPlotAttr "ticks" "outside"
            static member inline inside = Interop.mkPlotAttr "ticks" "inside"
            static member inline none = Interop.mkPlotAttr "ticks" ""

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline labels = Interop.mkPlotAttr "tickson" "labels"
            static member inline boundaries = Interop.mkPlotAttr "tickson" "boundaries"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline true' = Interop.mkPlotAttr "mirror" true
            static member inline ticks = Interop.mkPlotAttr "mirror" "ticks"
            static member inline false' = Interop.mkPlotAttr "mirror" false
            static member inline all = Interop.mkPlotAttr "mirror" "all"
            static member inline allticks = Interop.mkPlotAttr "mirror" "allticks"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline data = Interop.mkPlotAttr "spikesnap" "data"
            static member inline cursor = Interop.mkPlotAttr "spikesnap" "cursor"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
            static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
            static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
            static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
            static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
            static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
            static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkPlotAttr "showexponent" "all"
            static member inline first = Interop.mkPlotAttr "showexponent" "first"
            static member inline last = Interop.mkPlotAttr "showexponent" "last"
            static member inline none = Interop.mkPlotAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline none = Interop.mkPlotAttr "exponentformat" "none"
            static member inline e = Interop.mkPlotAttr "exponentformat" "e"
            static member inline E = Interop.mkPlotAttr "exponentformat" "E"
            static member inline power = Interop.mkPlotAttr "exponentformat" "power"
            static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
            static member inline B = Interop.mkPlotAttr "exponentformat" "B"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkPlotAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline top = Interop.mkPlotAttr "side" "top"
            static member inline bottom = Interop.mkPlotAttr "side" "bottom"
            static member inline left = Interop.mkPlotAttr "side" "left"
            static member inline right = Interop.mkPlotAttr "side" "right"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkPlotAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
            static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
            static member inline array = Interop.mkPlotAttr "categoryorder" "array"
            static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
            static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
            static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
            static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
            static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
            static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
            static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
            static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
            static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
            static member inline julian = Interop.mkPlotAttr "calendar" "julian"
            static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
            static member inline persian = Interop.mkPlotAttr "calendar" "persian"
            static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
            static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
            static member inline thai = Interop.mkPlotAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkPlotAttr "text" value

        module title =
            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type tickfont =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkPlotAttr "family" value
            static member inline size (value: int) = Interop.mkPlotAttr "size" value
            static member inline size (value: float) = Interop.mkPlotAttr "size" value
            static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type rangeslider =
            /// Sets the background color of the range slider.
            static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
            /// Sets the border color of the range slider.
            static member inline bordercolor (value: string) = Interop.mkPlotAttr "bordercolor" value
            /// Sets the border width of the range slider.
            static member inline borderwidth (value: int) = Interop.mkPlotAttr "borderwidth" value
            /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
            static member inline autorange (value: bool) = Interop.mkPlotAttr "autorange" value
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: int) = Interop.mkPlotAttr "thickness" value
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: float) = Interop.mkPlotAttr "thickness" value
            /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value

        module rangeslider =
            [<Erase>]
            type yaxis =
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values

            module yaxis =
                /// Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used.
                [<Erase>]
                type rangemode =
                    static member inline auto = Interop.mkPlotAttr "rangemode" "auto"
                    static member inline fixed' = Interop.mkPlotAttr "rangemode" "fixed"
                    static member inline match' = Interop.mkPlotAttr "rangemode" "match"

        [<Erase>]
        type rangeselector =
            /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: int) = Interop.mkPlotAttr "x" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: float) = Interop.mkPlotAttr "x" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: int) = Interop.mkPlotAttr "y" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: float) = Interop.mkPlotAttr "y" value
            /// Sets the background color of the range selector buttons.
            static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
            /// Sets the background color of the active range selector button.
            static member inline activecolor (value: string) = Interop.mkPlotAttr "activecolor" value
            /// Sets the color of the border enclosing the range selector.
            static member inline bordercolor (value: string) = Interop.mkPlotAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: int) = Interop.mkPlotAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: float) = Interop.mkPlotAttr "borderwidth" value

        module rangeselector =
            /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkPlotAttr "xanchor" "auto"
                static member inline left = Interop.mkPlotAttr "xanchor" "left"
                static member inline center = Interop.mkPlotAttr "xanchor" "center"
                static member inline right = Interop.mkPlotAttr "xanchor" "right"

            /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkPlotAttr "yanchor" "auto"
                static member inline top = Interop.mkPlotAttr "yanchor" "top"
                static member inline middle = Interop.mkPlotAttr "yanchor" "middle"
                static member inline bottom = Interop.mkPlotAttr "yanchor" "bottom"

            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type yaxis =
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkPlotAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkPlotAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkPlotAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkPlotAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkPlotAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkPlotAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkPlotAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkPlotAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkPlotAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkPlotAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkPlotAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkPlotAttr "spikedash" value
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        static member inline spikemode (values: seq<string>) = Interop.mkPlotAttr "spikemode" values
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkPlotAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkPlotAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkPlotAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkPlotAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkPlotAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkPlotAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkPlotAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkPlotAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkPlotAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkPlotAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkPlotAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkPlotAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkPlotAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkPlotAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value

    module yaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkPlotAttr "type" "-"
            static member inline linear = Interop.mkPlotAttr "type" "linear"
            static member inline log = Interop.mkPlotAttr "type" "log"
            static member inline date = Interop.mkPlotAttr "type" "date"
            static member inline category = Interop.mkPlotAttr "type" "category"
            static member inline multicategory = Interop.mkPlotAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline true' = Interop.mkPlotAttr "autorange" true
            static member inline false' = Interop.mkPlotAttr "autorange" false
            static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline normal = Interop.mkPlotAttr "rangemode" "normal"
            static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
            static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline range = Interop.mkPlotAttr "constrain" "range"
            static member inline domain = Interop.mkPlotAttr "constrain" "domain"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline left = Interop.mkPlotAttr "constraintoward" "left"
            static member inline center = Interop.mkPlotAttr "constraintoward" "center"
            static member inline right = Interop.mkPlotAttr "constraintoward" "right"
            static member inline top = Interop.mkPlotAttr "constraintoward" "top"
            static member inline middle = Interop.mkPlotAttr "constraintoward" "middle"
            static member inline bottom = Interop.mkPlotAttr "constraintoward" "bottom"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
            static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
            static member inline array = Interop.mkPlotAttr "tickmode" "array"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline outside = Interop.mkPlotAttr "ticks" "outside"
            static member inline inside = Interop.mkPlotAttr "ticks" "inside"
            static member inline none = Interop.mkPlotAttr "ticks" ""

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline labels = Interop.mkPlotAttr "tickson" "labels"
            static member inline boundaries = Interop.mkPlotAttr "tickson" "boundaries"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline true' = Interop.mkPlotAttr "mirror" true
            static member inline ticks = Interop.mkPlotAttr "mirror" "ticks"
            static member inline false' = Interop.mkPlotAttr "mirror" false
            static member inline all = Interop.mkPlotAttr "mirror" "all"
            static member inline allticks = Interop.mkPlotAttr "mirror" "allticks"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline data = Interop.mkPlotAttr "spikesnap" "data"
            static member inline cursor = Interop.mkPlotAttr "spikesnap" "cursor"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
            static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
            static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
            static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
            static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
            static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
            static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkPlotAttr "showexponent" "all"
            static member inline first = Interop.mkPlotAttr "showexponent" "first"
            static member inline last = Interop.mkPlotAttr "showexponent" "last"
            static member inline none = Interop.mkPlotAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline none = Interop.mkPlotAttr "exponentformat" "none"
            static member inline e = Interop.mkPlotAttr "exponentformat" "e"
            static member inline E = Interop.mkPlotAttr "exponentformat" "E"
            static member inline power = Interop.mkPlotAttr "exponentformat" "power"
            static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
            static member inline B = Interop.mkPlotAttr "exponentformat" "B"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkPlotAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline top = Interop.mkPlotAttr "side" "top"
            static member inline bottom = Interop.mkPlotAttr "side" "bottom"
            static member inline left = Interop.mkPlotAttr "side" "left"
            static member inline right = Interop.mkPlotAttr "side" "right"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkPlotAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
            static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
            static member inline array = Interop.mkPlotAttr "categoryorder" "array"
            static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
            static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
            static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
            static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
            static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
            static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
            static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
            static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
            static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
            static member inline julian = Interop.mkPlotAttr "calendar" "julian"
            static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
            static member inline persian = Interop.mkPlotAttr "calendar" "persian"
            static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
            static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
            static member inline thai = Interop.mkPlotAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkPlotAttr "text" value

        module title =
            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type tickfont =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkPlotAttr "family" value
            static member inline size (value: int) = Interop.mkPlotAttr "size" value
            static member inline size (value: float) = Interop.mkPlotAttr "size" value
            static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type ternary =
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: int) = Interop.mkPlotAttr "sum" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: float) = Interop.mkPlotAttr "sum" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module ternary =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this ternary subplot .
            static member inline row (value: int) = Interop.mkPlotAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this ternary subplot .
            static member inline column (value: int) = Interop.mkPlotAttr "column" value

        [<Erase>]
        type aaxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkPlotAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkPlotAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module aaxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type baxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkPlotAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkPlotAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module baxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type caxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkPlotAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkPlotAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module caxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type scene =
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module scene =
        /// If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
        [<Erase>]
        type aspectmode =
            static member inline auto = Interop.mkPlotAttr "aspectmode" "auto"
            static member inline cube = Interop.mkPlotAttr "aspectmode" "cube"
            static member inline data = Interop.mkPlotAttr "aspectmode" "data"
            static member inline manual = Interop.mkPlotAttr "aspectmode" "manual"

        /// Determines the mode of drag interactions for this scene.
        [<Erase>]
        type dragmode =
            static member inline orbit = Interop.mkPlotAttr "dragmode" "orbit"
            static member inline turntable = Interop.mkPlotAttr "dragmode" "turntable"
            static member inline zoom = Interop.mkPlotAttr "dragmode" "zoom"
            static member inline pan = Interop.mkPlotAttr "dragmode" "pan"
            static member inline false' = Interop.mkPlotAttr "dragmode" false

        /// Determines the mode of hover interactions for this scene.
        [<Erase>]
        type hovermode =
            static member inline closest = Interop.mkPlotAttr "hovermode" "closest"
            static member inline false' = Interop.mkPlotAttr "hovermode" false

        module camera =
            [<Erase>]
            type up =
                static member inline x (value: int) = Interop.mkPlotAttr "x" value
                static member inline x (value: float) = Interop.mkPlotAttr "x" value
                static member inline y (value: int) = Interop.mkPlotAttr "y" value
                static member inline y (value: float) = Interop.mkPlotAttr "y" value
                static member inline z (value: int) = Interop.mkPlotAttr "z" value
                static member inline z (value: float) = Interop.mkPlotAttr "z" value

            [<Erase>]
            type center =
                static member inline x (value: int) = Interop.mkPlotAttr "x" value
                static member inline x (value: float) = Interop.mkPlotAttr "x" value
                static member inline y (value: int) = Interop.mkPlotAttr "y" value
                static member inline y (value: float) = Interop.mkPlotAttr "y" value
                static member inline z (value: int) = Interop.mkPlotAttr "z" value
                static member inline z (value: float) = Interop.mkPlotAttr "z" value

            [<Erase>]
            type eye =
                static member inline x (value: int) = Interop.mkPlotAttr "x" value
                static member inline x (value: float) = Interop.mkPlotAttr "x" value
                static member inline y (value: int) = Interop.mkPlotAttr "y" value
                static member inline y (value: float) = Interop.mkPlotAttr "y" value
                static member inline z (value: int) = Interop.mkPlotAttr "z" value
                static member inline z (value: float) = Interop.mkPlotAttr "z" value

            module projection =
                /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
                [<Erase>]
                type type' =
                    static member inline perspective = Interop.mkPlotAttr "type" "perspective"
                    static member inline orthographic = Interop.mkPlotAttr "type" "orthographic"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this scene subplot .
            static member inline row (value: int) = Interop.mkPlotAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this scene subplot .
            static member inline column (value: int) = Interop.mkPlotAttr "column" value

        [<Erase>]
        type aspectratio =
            static member inline x (value: int) = Interop.mkPlotAttr "x" value
            static member inline x (value: float) = Interop.mkPlotAttr "x" value
            static member inline y (value: int) = Interop.mkPlotAttr "y" value
            static member inline y (value: float) = Interop.mkPlotAttr "y" value
            static member inline z (value: int) = Interop.mkPlotAttr "z" value
            static member inline z (value: float) = Interop.mkPlotAttr "z" value

        [<Erase>]
        type xaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkPlotAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkPlotAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkPlotAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkPlotAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkPlotAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkPlotAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkPlotAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkPlotAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module xaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
                static member inline array = Interop.mkPlotAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkPlotAttr "type" "-"
                static member inline linear = Interop.mkPlotAttr "type" "linear"
                static member inline log = Interop.mkPlotAttr "type" "log"
                static member inline date = Interop.mkPlotAttr "type" "date"
                static member inline category = Interop.mkPlotAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkPlotAttr "autorange" true
                static member inline false' = Interop.mkPlotAttr "autorange" false
                static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkPlotAttr "rangemode" "normal"
                static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkPlotAttr "mirror" true
                static member inline ticks = Interop.mkPlotAttr "mirror" "ticks"
                static member inline false' = Interop.mkPlotAttr "mirror" false
                static member inline all = Interop.mkPlotAttr "mirror" "all"
                static member inline allticks = Interop.mkPlotAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
                static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
                static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
                static member inline julian = Interop.mkPlotAttr "calendar" "julian"
                static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
                static member inline persian = Interop.mkPlotAttr "calendar" "persian"
                static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
                static member inline thai = Interop.mkPlotAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type yaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkPlotAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkPlotAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkPlotAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkPlotAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkPlotAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkPlotAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkPlotAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkPlotAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module yaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
                static member inline array = Interop.mkPlotAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkPlotAttr "type" "-"
                static member inline linear = Interop.mkPlotAttr "type" "linear"
                static member inline log = Interop.mkPlotAttr "type" "log"
                static member inline date = Interop.mkPlotAttr "type" "date"
                static member inline category = Interop.mkPlotAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkPlotAttr "autorange" true
                static member inline false' = Interop.mkPlotAttr "autorange" false
                static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkPlotAttr "rangemode" "normal"
                static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkPlotAttr "mirror" true
                static member inline ticks = Interop.mkPlotAttr "mirror" "ticks"
                static member inline false' = Interop.mkPlotAttr "mirror" false
                static member inline all = Interop.mkPlotAttr "mirror" "all"
                static member inline allticks = Interop.mkPlotAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
                static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
                static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
                static member inline julian = Interop.mkPlotAttr "calendar" "julian"
                static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
                static member inline persian = Interop.mkPlotAttr "calendar" "persian"
                static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
                static member inline thai = Interop.mkPlotAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type zaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkPlotAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkPlotAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkPlotAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkPlotAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkPlotAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkPlotAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkPlotAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkPlotAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkPlotAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkPlotAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module zaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
                static member inline array = Interop.mkPlotAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkPlotAttr "type" "-"
                static member inline linear = Interop.mkPlotAttr "type" "linear"
                static member inline log = Interop.mkPlotAttr "type" "log"
                static member inline date = Interop.mkPlotAttr "type" "date"
                static member inline category = Interop.mkPlotAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkPlotAttr "autorange" true
                static member inline false' = Interop.mkPlotAttr "autorange" false
                static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkPlotAttr "rangemode" "normal"
                static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkPlotAttr "mirror" true
                static member inline ticks = Interop.mkPlotAttr "mirror" "ticks"
                static member inline false' = Interop.mkPlotAttr "mirror" false
                static member inline all = Interop.mkPlotAttr "mirror" "all"
                static member inline allticks = Interop.mkPlotAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
                static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
                static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
                static member inline julian = Interop.mkPlotAttr "calendar" "julian"
                static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
                static member inline persian = Interop.mkPlotAttr "calendar" "persian"
                static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
                static member inline thai = Interop.mkPlotAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type geo =
        /// Sets whether or not the coastlines are drawn.
        static member inline showcoastlines (value: bool) = Interop.mkPlotAttr "showcoastlines" value
        /// Sets the coastline color.
        static member inline coastlinecolor (value: string) = Interop.mkPlotAttr "coastlinecolor" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: int) = Interop.mkPlotAttr "coastlinewidth" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: float) = Interop.mkPlotAttr "coastlinewidth" value
        /// Sets whether or not land masses are filled in color.
        static member inline showland (value: bool) = Interop.mkPlotAttr "showland" value
        /// Sets the land mass color.
        static member inline landcolor (value: string) = Interop.mkPlotAttr "landcolor" value
        /// Sets whether or not oceans are filled in color.
        static member inline showocean (value: bool) = Interop.mkPlotAttr "showocean" value
        /// Sets the ocean color
        static member inline oceancolor (value: string) = Interop.mkPlotAttr "oceancolor" value
        /// Sets whether or not lakes are drawn.
        static member inline showlakes (value: bool) = Interop.mkPlotAttr "showlakes" value
        /// Sets the color of the lakes.
        static member inline lakecolor (value: string) = Interop.mkPlotAttr "lakecolor" value
        /// Sets whether or not rivers are drawn.
        static member inline showrivers (value: bool) = Interop.mkPlotAttr "showrivers" value
        /// Sets color of the rivers.
        static member inline rivercolor (value: string) = Interop.mkPlotAttr "rivercolor" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: int) = Interop.mkPlotAttr "riverwidth" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: float) = Interop.mkPlotAttr "riverwidth" value
        /// Sets whether or not country boundaries are drawn.
        static member inline showcountries (value: bool) = Interop.mkPlotAttr "showcountries" value
        /// Sets line color of the country boundaries.
        static member inline countrycolor (value: string) = Interop.mkPlotAttr "countrycolor" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: int) = Interop.mkPlotAttr "countrywidth" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: float) = Interop.mkPlotAttr "countrywidth" value
        /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
        static member inline showsubunits (value: bool) = Interop.mkPlotAttr "showsubunits" value
        /// Sets the color of the subunits boundaries.
        static member inline subunitcolor (value: string) = Interop.mkPlotAttr "subunitcolor" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: int) = Interop.mkPlotAttr "subunitwidth" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: float) = Interop.mkPlotAttr "subunitwidth" value
        /// Sets whether or not a frame is drawn around the map.
        static member inline showframe (value: bool) = Interop.mkPlotAttr "showframe" value
        /// Sets the color the frame.
        static member inline framecolor (value: string) = Interop.mkPlotAttr "framecolor" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: int) = Interop.mkPlotAttr "framewidth" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: float) = Interop.mkPlotAttr "framewidth" value
        /// Set the background color of the map
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module geo =
        /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
        [<Erase>]
        type resolution =
            static member inline _110 = Interop.mkPlotAttr "resolution" 110
            static member inline _50 = Interop.mkPlotAttr "resolution" 50

        /// Set the scope of the map.
        [<Erase>]
        type scope =
            static member inline world = Interop.mkPlotAttr "scope" "world"
            static member inline usa = Interop.mkPlotAttr "scope" "usa"
            static member inline europe = Interop.mkPlotAttr "scope" "europe"
            static member inline asia = Interop.mkPlotAttr "scope" "asia"
            static member inline africa = Interop.mkPlotAttr "scope" "africa"
            static member inline northAmerica = Interop.mkPlotAttr "scope" "north america"
            static member inline southAmerica = Interop.mkPlotAttr "scope" "south america"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline row (value: int) = Interop.mkPlotAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline column (value: int) = Interop.mkPlotAttr "column" value

        [<Erase>]
        type projection =
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<int>) = Interop.mkPlotAttr "parallels" values
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<float>) = Interop.mkPlotAttr "parallels" values
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: int) = Interop.mkPlotAttr "scale" value
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: float) = Interop.mkPlotAttr "scale" value

        module projection =
            /// Sets the projection type.
            [<Erase>]
            type type' =
                static member inline equirectangular = Interop.mkPlotAttr "type" "equirectangular"
                static member inline mercator = Interop.mkPlotAttr "type" "mercator"
                static member inline orthographic = Interop.mkPlotAttr "type" "orthographic"
                static member inline naturalEarth = Interop.mkPlotAttr "type" "natural earth"
                static member inline kavrayskiy7 = Interop.mkPlotAttr "type" "kavrayskiy7"
                static member inline miller = Interop.mkPlotAttr "type" "miller"
                static member inline robinson = Interop.mkPlotAttr "type" "robinson"
                static member inline eckert4 = Interop.mkPlotAttr "type" "eckert4"
                static member inline azimuthalEqualArea = Interop.mkPlotAttr "type" "azimuthal equal area"
                static member inline azimuthalEquidistant = Interop.mkPlotAttr "type" "azimuthal equidistant"
                static member inline conicEqualArea = Interop.mkPlotAttr "type" "conic equal area"
                static member inline conicConformal = Interop.mkPlotAttr "type" "conic conformal"
                static member inline conicEquidistant = Interop.mkPlotAttr "type" "conic equidistant"
                static member inline gnomonic = Interop.mkPlotAttr "type" "gnomonic"
                static member inline stereographic = Interop.mkPlotAttr "type" "stereographic"
                static member inline mollweide = Interop.mkPlotAttr "type" "mollweide"
                static member inline hammer = Interop.mkPlotAttr "type" "hammer"
                static member inline transverseMercator = Interop.mkPlotAttr "type" "transverse mercator"
                static member inline albersUsa = Interop.mkPlotAttr "type" "albers usa"
                static member inline winkelTripel = Interop.mkPlotAttr "type" "winkel tripel"
                static member inline aitoff = Interop.mkPlotAttr "type" "aitoff"
                static member inline sinusoidal = Interop.mkPlotAttr "type" "sinusoidal"

            [<Erase>]
            type rotation =
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: int) = Interop.mkPlotAttr "lon" value
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: float) = Interop.mkPlotAttr "lon" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: int) = Interop.mkPlotAttr "lat" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: float) = Interop.mkPlotAttr "lat" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: int) = Interop.mkPlotAttr "roll" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: float) = Interop.mkPlotAttr "roll" value

        [<Erase>]
        type center =
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: int) = Interop.mkPlotAttr "lon" value
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: float) = Interop.mkPlotAttr "lon" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: int) = Interop.mkPlotAttr "lat" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: float) = Interop.mkPlotAttr "lat" value

        [<Erase>]
        type lonaxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value

        [<Erase>]
        type lataxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value

    [<Erase>]
    type mapbox =
        /// Sets the mapbox access token to be used for this mapbox map. Alternatively, the mapbox access token can be set in the configuration options under `mapboxAccessToken`. Note that accessToken are only required when `style` (e.g with values : basic, streets, outdoors, light, dark, satellite, satellite-streets ) and/or a layout layer references the Mapbox server.
        static member inline accesstoken (value: string) = Interop.mkPlotAttr "accesstoken" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: bool) = Interop.mkPlotAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<bool>) = Interop.mkPlotAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: string) = Interop.mkPlotAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<string>) = Interop.mkPlotAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: int) = Interop.mkPlotAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<int>) = Interop.mkPlotAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: float) = Interop.mkPlotAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<float>) = Interop.mkPlotAttr "style" values
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: int) = Interop.mkPlotAttr "zoom" value
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: float) = Interop.mkPlotAttr "zoom" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: int) = Interop.mkPlotAttr "bearing" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: float) = Interop.mkPlotAttr "bearing" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: int) = Interop.mkPlotAttr "pitch" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: float) = Interop.mkPlotAttr "pitch" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module mapbox =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this mapbox subplot .
            static member inline row (value: int) = Interop.mkPlotAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this mapbox subplot .
            static member inline column (value: int) = Interop.mkPlotAttr "column" value

        [<Erase>]
        type center =
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: int) = Interop.mkPlotAttr "lon" value
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: float) = Interop.mkPlotAttr "lon" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: int) = Interop.mkPlotAttr "lat" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: float) = Interop.mkPlotAttr "lat" value

    [<Erase>]
    type polar =
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<int>) = Interop.mkPlotAttr "sector" values
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<float>) = Interop.mkPlotAttr "sector" values
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: int) = Interop.mkPlotAttr "hole" value
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: float) = Interop.mkPlotAttr "hole" value
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module polar =
        /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
        [<Erase>]
        type gridshape =
            static member inline circular = Interop.mkPlotAttr "gridshape" "circular"
            static member inline linear = Interop.mkPlotAttr "gridshape" "linear"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkPlotAttr "x" values
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkPlotAttr "x" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkPlotAttr "y" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkPlotAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this polar subplot .
            static member inline row (value: int) = Interop.mkPlotAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this polar subplot .
            static member inline column (value: int) = Interop.mkPlotAttr "column" value

        [<Erase>]
        type radialaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkPlotAttr "range" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: int) = Interop.mkPlotAttr "angle" value
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: float) = Interop.mkPlotAttr "angle" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module radialaxis =
            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkPlotAttr "type" "-"
                static member inline linear = Interop.mkPlotAttr "type" "linear"
                static member inline log = Interop.mkPlotAttr "type" "log"
                static member inline date = Interop.mkPlotAttr "type" "date"
                static member inline category = Interop.mkPlotAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkPlotAttr "autorange" true
                static member inline false' = Interop.mkPlotAttr "autorange" false
                static member inline reversed = Interop.mkPlotAttr "autorange" "reversed"

            /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
            [<Erase>]
            type rangemode =
                static member inline tozero = Interop.mkPlotAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkPlotAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkPlotAttr "rangemode" "normal"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
                static member inline array = Interop.mkPlotAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

            /// Determines on which side of radial axis line the tick and tick labels appear.
            [<Erase>]
            type side =
                static member inline clockwise = Interop.mkPlotAttr "side" "clockwise"
                static member inline counterclockwise = Interop.mkPlotAttr "side" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkPlotAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkPlotAttr "calendar" "chinese"
                static member inline coptic = Interop.mkPlotAttr "calendar" "coptic"
                static member inline discworld = Interop.mkPlotAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkPlotAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkPlotAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkPlotAttr "calendar" "islamic"
                static member inline julian = Interop.mkPlotAttr "calendar" "julian"
                static member inline mayan = Interop.mkPlotAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkPlotAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkPlotAttr "calendar" "nepali"
                static member inline persian = Interop.mkPlotAttr "calendar" "persian"
                static member inline jalali = Interop.mkPlotAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkPlotAttr "calendar" "taiwan"
                static member inline thai = Interop.mkPlotAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkPlotAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

        [<Erase>]
        type angularaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkPlotAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkPlotAttr "categoryarray" values
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: int) = Interop.mkPlotAttr "period" value
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: float) = Interop.mkPlotAttr "period" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: int) = Interop.mkPlotAttr "rotation" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: float) = Interop.mkPlotAttr "rotation" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkPlotAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkPlotAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkPlotAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkPlotAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkPlotAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkPlotAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkPlotAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkPlotAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkPlotAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkPlotAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module angularaxis =
            /// Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkPlotAttr "type" "-"
                static member inline linear = Interop.mkPlotAttr "type" "linear"
                static member inline category = Interop.mkPlotAttr "type" "category"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkPlotAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkPlotAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkPlotAttr "categoryorder" "category descending"
                static member inline array = Interop.mkPlotAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkPlotAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkPlotAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkPlotAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkPlotAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkPlotAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkPlotAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkPlotAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkPlotAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkPlotAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkPlotAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkPlotAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkPlotAttr "categoryorder" "median descending"

            /// Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
            [<Erase>]
            type thetaunit =
                static member inline radians = Interop.mkPlotAttr "thetaunit" "radians"
                static member inline degrees = Interop.mkPlotAttr "thetaunit" "degrees"

            /// Sets the direction corresponding to positive angles.
            [<Erase>]
            type direction =
                static member inline counterclockwise = Interop.mkPlotAttr "direction" "counterclockwise"
                static member inline clockwise = Interop.mkPlotAttr "direction" "clockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkPlotAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkPlotAttr "layer" "below traces"

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkPlotAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkPlotAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: int) = Interop.mkPlotAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: float) = Interop.mkPlotAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this radial axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the radial axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this radial axis.
        static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkPlotAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkPlotAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value

    module radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the radial axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkPlotAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkPlotAttr "tickorientation" "vertical"

    [<Erase>]
    type angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<int>) = Interop.mkPlotAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<float>) = Interop.mkPlotAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkPlotAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkPlotAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this angular axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkPlotAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the angular axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this angular axis.
        static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkPlotAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkPlotAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkPlotAttr "visible" value

    module angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the angular axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkPlotAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkPlotAttr "tickorientation" "vertical"

    [<Erase>]
    type legend =
        /// Sets the legend background color.
        static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
        /// Sets the color of the border enclosing the legend.
        static member inline bordercolor (value: string) = Interop.mkPlotAttr "bordercolor" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: int) = Interop.mkPlotAttr "borderwidth" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: float) = Interop.mkPlotAttr "borderwidth" value
        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        static member inline traceorder (values: seq<string>) = Interop.mkPlotAttr "traceorder" values
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: int) = Interop.mkPlotAttr "tracegroupgap" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: float) = Interop.mkPlotAttr "tracegroupgap" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: int) = Interop.mkPlotAttr "x" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: float) = Interop.mkPlotAttr "x" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: int) = Interop.mkPlotAttr "y" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: float) = Interop.mkPlotAttr "y" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPlotAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPlotAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPlotAttr "uirevision" values

    module legend =
        /// Sets the orientation of the legend.
        [<Erase>]
        type orientation =
            static member inline v = Interop.mkPlotAttr "orientation" "v"
            static member inline h = Interop.mkPlotAttr "orientation" "h"

        /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
        [<Erase>]
        type itemsizing =
            static member inline trace = Interop.mkPlotAttr "itemsizing" "trace"
            static member inline constant = Interop.mkPlotAttr "itemsizing" "constant"

        /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
        [<Erase>]
        type itemclick =
            static member inline toggle = Interop.mkPlotAttr "itemclick" "toggle"
            static member inline toggleothers = Interop.mkPlotAttr "itemclick" "toggleothers"
            static member inline false' = Interop.mkPlotAttr "itemclick" false

        /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
        [<Erase>]
        type itemdoubleclick =
            static member inline toggle = Interop.mkPlotAttr "itemdoubleclick" "toggle"
            static member inline toggleothers = Interop.mkPlotAttr "itemdoubleclick" "toggleothers"
            static member inline false' = Interop.mkPlotAttr "itemdoubleclick" false

        /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkPlotAttr "xanchor" "auto"
            static member inline left = Interop.mkPlotAttr "xanchor" "left"
            static member inline center = Interop.mkPlotAttr "xanchor" "center"
            static member inline right = Interop.mkPlotAttr "xanchor" "right"

        /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkPlotAttr "yanchor" "auto"
            static member inline top = Interop.mkPlotAttr "yanchor" "top"
            static member inline middle = Interop.mkPlotAttr "yanchor" "middle"
            static member inline bottom = Interop.mkPlotAttr "yanchor" "bottom"

        /// Sets the vertical alignment of the symbols with respect to their associated text.
        [<Erase>]
        type valign =
            static member inline top = Interop.mkPlotAttr "valign" "top"
            static member inline middle = Interop.mkPlotAttr "valign" "middle"
            static member inline bottom = Interop.mkPlotAttr "valign" "bottom"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkPlotAttr "family" value
            static member inline size (value: int) = Interop.mkPlotAttr "size" value
            static member inline size (value: float) = Interop.mkPlotAttr "size" value
            static member inline color (value: string) = Interop.mkPlotAttr "color" value

    [<Erase>]
    type colorscale =
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequential (values: seq<string>) = Interop.mkPlotAttr "sequential" values
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequentialminus (values: seq<string>) = Interop.mkPlotAttr "sequentialminus" values
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        static member inline diverging (values: seq<string>) = Interop.mkPlotAttr "diverging" values

    [<Erase>]
    type coloraxis =
        /// Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        static member inline cauto (value: bool) = Interop.mkPlotAttr "cauto" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: int) = Interop.mkPlotAttr "cmin" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: float) = Interop.mkPlotAttr "cmin" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: int) = Interop.mkPlotAttr "cmax" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: float) = Interop.mkPlotAttr "cmax" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: int) = Interop.mkPlotAttr "cmid" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: float) = Interop.mkPlotAttr "cmid" value
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        static member inline colorscale (values: seq<string>) = Interop.mkPlotAttr "colorscale" values
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        static member inline autocolorscale (value: bool) = Interop.mkPlotAttr "autocolorscale" value
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        static member inline reversescale (value: bool) = Interop.mkPlotAttr "reversescale" value
        /// Determines whether or not a colorbar is displayed for this trace.
        static member inline showscale (value: bool) = Interop.mkPlotAttr "showscale" value

    module coloraxis =
        [<Erase>]
        type colorbar =
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: int) = Interop.mkPlotAttr "thickness" value
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: float) = Interop.mkPlotAttr "thickness" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: int) = Interop.mkPlotAttr "len" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: float) = Interop.mkPlotAttr "len" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: int) = Interop.mkPlotAttr "x" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: float) = Interop.mkPlotAttr "x" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: int) = Interop.mkPlotAttr "xpad" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: float) = Interop.mkPlotAttr "xpad" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: int) = Interop.mkPlotAttr "y" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: float) = Interop.mkPlotAttr "y" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: int) = Interop.mkPlotAttr "ypad" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: float) = Interop.mkPlotAttr "ypad" value
            /// Sets the axis line color.
            static member inline outlinecolor (value: string) = Interop.mkPlotAttr "outlinecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: int) = Interop.mkPlotAttr "outlinewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: float) = Interop.mkPlotAttr "outlinewidth" value
            /// Sets the axis line color.
            static member inline bordercolor (value: string) = Interop.mkPlotAttr "bordercolor" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: int) = Interop.mkPlotAttr "borderwidth" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: float) = Interop.mkPlotAttr "borderwidth" value
            /// Sets the color of padded area.
            static member inline bgcolor (value: string) = Interop.mkPlotAttr "bgcolor" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkPlotAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkPlotAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkPlotAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkPlotAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkPlotAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkPlotAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkPlotAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkPlotAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkPlotAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkPlotAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkPlotAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkPlotAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkPlotAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkPlotAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkPlotAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkPlotAttr "tickformat" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkPlotAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkPlotAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkPlotAttr "separatethousands" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkPlotAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkPlotAttr "ticktextsrc" value

        module colorbar =
            /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
            [<Erase>]
            type thicknessmode =
                static member inline fraction = Interop.mkPlotAttr "thicknessmode" "fraction"
                static member inline pixels = Interop.mkPlotAttr "thicknessmode" "pixels"

            /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
            [<Erase>]
            type lenmode =
                static member inline fraction = Interop.mkPlotAttr "lenmode" "fraction"
                static member inline pixels = Interop.mkPlotAttr "lenmode" "pixels"

            /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
            [<Erase>]
            type xanchor =
                static member inline left = Interop.mkPlotAttr "xanchor" "left"
                static member inline center = Interop.mkPlotAttr "xanchor" "center"
                static member inline right = Interop.mkPlotAttr "xanchor" "right"

            /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
            [<Erase>]
            type yanchor =
                static member inline top = Interop.mkPlotAttr "yanchor" "top"
                static member inline middle = Interop.mkPlotAttr "yanchor" "middle"
                static member inline bottom = Interop.mkPlotAttr "yanchor" "bottom"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkPlotAttr "tickmode" "auto"
                static member inline linear = Interop.mkPlotAttr "tickmode" "linear"
                static member inline array = Interop.mkPlotAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkPlotAttr "ticks" "outside"
                static member inline inside = Interop.mkPlotAttr "ticks" "inside"
                static member inline none = Interop.mkPlotAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkPlotAttr "showtickprefix" "all"
                static member inline first = Interop.mkPlotAttr "showtickprefix" "first"
                static member inline last = Interop.mkPlotAttr "showtickprefix" "last"
                static member inline none = Interop.mkPlotAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkPlotAttr "showticksuffix" "all"
                static member inline first = Interop.mkPlotAttr "showticksuffix" "first"
                static member inline last = Interop.mkPlotAttr "showticksuffix" "last"
                static member inline none = Interop.mkPlotAttr "showticksuffix" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkPlotAttr "exponentformat" "none"
                static member inline e = Interop.mkPlotAttr "exponentformat" "e"
                static member inline E = Interop.mkPlotAttr "exponentformat" "E"
                static member inline power = Interop.mkPlotAttr "exponentformat" "power"
                static member inline SI = Interop.mkPlotAttr "exponentformat" "SI"
                static member inline B = Interop.mkPlotAttr "exponentformat" "B"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkPlotAttr "showexponent" "all"
                static member inline first = Interop.mkPlotAttr "showexponent" "first"
                static member inline last = Interop.mkPlotAttr "showexponent" "last"
                static member inline none = Interop.mkPlotAttr "showexponent" "none"

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkPlotAttr "family" value
                static member inline size (value: int) = Interop.mkPlotAttr "size" value
                static member inline size (value: float) = Interop.mkPlotAttr "size" value
                static member inline color (value: string) = Interop.mkPlotAttr "color" value

            [<Erase>]
            type title =
                /// Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkPlotAttr "text" value

            module title =
                /// Determines the location of color bar's title with respect to the color bar. Note that the title's location used to be set by the now deprecated `titleside` attribute.
                [<Erase>]
                type side =
                    static member inline right = Interop.mkPlotAttr "side" "right"
                    static member inline top = Interop.mkPlotAttr "side" "top"
                    static member inline bottom = Interop.mkPlotAttr "side" "bottom"

                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkPlotAttr "family" value
                    static member inline size (value: int) = Interop.mkPlotAttr "size" value
                    static member inline size (value: float) = Interop.mkPlotAttr "size" value
                    static member inline color (value: string) = Interop.mkPlotAttr "color" value

