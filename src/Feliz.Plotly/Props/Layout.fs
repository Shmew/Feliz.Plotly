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
    static member inline autosize (value: bool) = Interop.mkLayoutAttr "autosize" value
    /// Sets the plot's width (in px).
    static member inline width (value: int) = Interop.mkLayoutAttr "width" value
    /// Sets the plot's width (in px).
    static member inline width (value: float) = Interop.mkLayoutAttr "width" value
    /// Sets the plot's height (in px).
    static member inline height (value: int) = Interop.mkLayoutAttr "height" value
    /// Sets the plot's height (in px).
    static member inline height (value: float) = Interop.mkLayoutAttr "height" value
    /// Sets the color of paper where the graph is drawn.
    static member inline paper_bgcolor (value: string) = Interop.mkLayoutAttr "paper_bgcolor" value
    /// Sets the color of plotting area in-between x and y axes.
    static member inline plot_bgcolor (value: string) = Interop.mkLayoutAttr "plot_bgcolor" value
    /// Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default.
    static member inline separators (value: string) = Interop.mkLayoutAttr "separators" value
    /// Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the plotly service (at https://plot.ly or on-premise).
    static member inline hidesources (value: bool) = Interop.mkLayoutAttr "hidesources" value
    /// Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`.
    static member inline showlegend (value: bool) = Interop.mkLayoutAttr "showlegend" value
    /// Sets the default trace colors.
    static member inline colorway (values: seq<string>) = Interop.mkLayoutAttr "colorway" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: bool) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<bool>) = Interop.mkLayoutAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: string) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<string>) = Interop.mkLayoutAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: int) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<int>) = Interop.mkLayoutAttr "datarevision" values
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: float) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<float>) = Interop.mkLayoutAttr "datarevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: bool) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<bool>) = Interop.mkLayoutAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: string) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<string>) = Interop.mkLayoutAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: int) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<int>) = Interop.mkLayoutAttr "uirevision" values
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: float) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<float>) = Interop.mkLayoutAttr "uirevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: bool) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<bool>) = Interop.mkLayoutAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: string) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<string>) = Interop.mkLayoutAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: int) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<int>) = Interop.mkLayoutAttr "editrevision" values
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: float) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<float>) = Interop.mkLayoutAttr "editrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: bool) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<bool>) = Interop.mkLayoutAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: string) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<string>) = Interop.mkLayoutAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: int) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<int>) = Interop.mkLayoutAttr "selectionrevision" values
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: float) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<float>) = Interop.mkLayoutAttr "selectionrevision" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: bool) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<bool>) = Interop.mkLayoutAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: string) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<string>) = Interop.mkLayoutAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: int) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<int>) = Interop.mkLayoutAttr "template" values
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (value: float) = Interop.mkLayoutAttr "template" value
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (values: seq<float>) = Interop.mkLayoutAttr "template" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: bool) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<bool>) = Interop.mkLayoutAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: string) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<string>) = Interop.mkLayoutAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: int) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<int>) = Interop.mkLayoutAttr "meta" values
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (value: float) = Interop.mkLayoutAttr "meta" value
    /// Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}.
    static member inline meta (values: seq<float>) = Interop.mkLayoutAttr "meta" values
    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    static member inline clickmode (values: seq<string>) = Interop.mkLayoutAttr "clickmode" values
    /// Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict.
    static member inline hoverdistance (value: int) = Interop.mkLayoutAttr "hoverdistance" value
    /// Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills.
    static member inline spikedistance (value: int) = Interop.mkLayoutAttr "spikedistance" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: int) = Interop.mkLayoutAttr "orientation" value
    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Rotates the entire polar by the given angle in legacy polar charts.
    static member inline orientation (value: float) = Interop.mkLayoutAttr "orientation" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkLayoutAttr "metasrc" value

module layout =
    /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
    [<Erase>]
    type dragmode =
        static member inline zoom = Interop.mkLayoutAttr "dragmode" "zoom"
        static member inline pan = Interop.mkLayoutAttr "dragmode" "pan"
        static member inline select = Interop.mkLayoutAttr "dragmode" "select"
        static member inline lasso = Interop.mkLayoutAttr "dragmode" "lasso"
        static member inline orbit = Interop.mkLayoutAttr "dragmode" "orbit"
        static member inline turntable = Interop.mkLayoutAttr "dragmode" "turntable"
        static member inline false' = Interop.mkLayoutAttr "dragmode" false

    /// Determines the mode of hover interactions. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
    [<Erase>]
    type hovermode =
        static member inline x = Interop.mkLayoutAttr "hovermode" "x"
        static member inline y = Interop.mkLayoutAttr "hovermode" "y"
        static member inline closest = Interop.mkLayoutAttr "hovermode" "closest"
        static member inline false' = Interop.mkLayoutAttr "hovermode" false

    /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
    [<Erase>]
    type selectdirection =
        static member inline h = Interop.mkLayoutAttr "selectdirection" "h"
        static member inline v = Interop.mkLayoutAttr "selectdirection" "v"
        static member inline d = Interop.mkLayoutAttr "selectdirection" "d"
        static member inline any = Interop.mkLayoutAttr "selectdirection" "any"

    /// Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
    [<Erase>]
    type calendar =
        static member inline gregorian = Interop.mkLayoutAttr "calendar" "gregorian"
        static member inline chinese = Interop.mkLayoutAttr "calendar" "chinese"
        static member inline coptic = Interop.mkLayoutAttr "calendar" "coptic"
        static member inline discworld = Interop.mkLayoutAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkLayoutAttr "calendar" "ethiopian"
        static member inline hebrew = Interop.mkLayoutAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkLayoutAttr "calendar" "islamic"
        static member inline julian = Interop.mkLayoutAttr "calendar" "julian"
        static member inline mayan = Interop.mkLayoutAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkLayoutAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkLayoutAttr "calendar" "nepali"
        static member inline persian = Interop.mkLayoutAttr "calendar" "persian"
        static member inline jalali = Interop.mkLayoutAttr "calendar" "jalali"
        static member inline taiwan = Interop.mkLayoutAttr "calendar" "taiwan"
        static member inline thai = Interop.mkLayoutAttr "calendar" "thai"
        static member inline ummalqura = Interop.mkLayoutAttr "calendar" "ummalqura"

    /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the direction corresponding to positive angles in legacy polar charts.
    [<Erase>]
    type direction =
        static member inline clockwise = Interop.mkLayoutAttr "direction" "clockwise"
        static member inline counterclockwise = Interop.mkLayoutAttr "direction" "counterclockwise"

    [<Erase>]
    type font =
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        static member inline family (value: string) = Interop.mkFontAttr "family" value
        static member inline size (value: int) = Interop.mkFontAttr "size" value
        static member inline size (value: float) = Interop.mkFontAttr "size" value
        static member inline color (value: string) = Interop.mkFontAttr "color" value

    [<Erase>]
    type title =
        /// Sets the plot's title. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
        static member inline text (value: string) = Interop.mkTitleAttr "text" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: int) = Interop.mkTitleAttr "x" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: float) = Interop.mkTitleAttr "x" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: int) = Interop.mkTitleAttr "y" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: float) = Interop.mkTitleAttr "y" value

    module title =
        /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
        [<Erase>]
        type xref =
            static member inline container = Interop.mkTitleAttr "xref" "container"
            static member inline paper = Interop.mkTitleAttr "xref" "paper"

        /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
        [<Erase>]
        type yref =
            static member inline container = Interop.mkTitleAttr "yref" "container"
            static member inline paper = Interop.mkTitleAttr "yref" "paper"

        /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkTitleAttr "xanchor" "auto"
            static member inline left = Interop.mkTitleAttr "xanchor" "left"
            static member inline center = Interop.mkTitleAttr "xanchor" "center"
            static member inline right = Interop.mkTitleAttr "xanchor" "right"

        /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkTitleAttr "yanchor" "auto"
            static member inline top = Interop.mkTitleAttr "yanchor" "top"
            static member inline middle = Interop.mkTitleAttr "yanchor" "middle"
            static member inline bottom = Interop.mkTitleAttr "yanchor" "bottom"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkFontAttr "family" value
            static member inline size (value: int) = Interop.mkFontAttr "size" value
            static member inline size (value: float) = Interop.mkFontAttr "size" value
            static member inline color (value: string) = Interop.mkFontAttr "color" value

        [<Erase>]
        type pad =
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: int) = Interop.mkPadAttr "t" value
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: float) = Interop.mkPadAttr "t" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: int) = Interop.mkPadAttr "r" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: float) = Interop.mkPadAttr "r" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: int) = Interop.mkPadAttr "b" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: float) = Interop.mkPadAttr "b" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: int) = Interop.mkPadAttr "l" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: float) = Interop.mkPadAttr "l" value

    [<Erase>]
    type margin =
        /// Sets the left margin (in px).
        static member inline l (value: int) = Interop.mkMarginAttr "l" value
        /// Sets the left margin (in px).
        static member inline l (value: float) = Interop.mkMarginAttr "l" value
        /// Sets the right margin (in px).
        static member inline r (value: int) = Interop.mkMarginAttr "r" value
        /// Sets the right margin (in px).
        static member inline r (value: float) = Interop.mkMarginAttr "r" value
        /// Sets the top margin (in px).
        static member inline t (value: int) = Interop.mkMarginAttr "t" value
        /// Sets the top margin (in px).
        static member inline t (value: float) = Interop.mkMarginAttr "t" value
        /// Sets the bottom margin (in px).
        static member inline b (value: int) = Interop.mkMarginAttr "b" value
        /// Sets the bottom margin (in px).
        static member inline b (value: float) = Interop.mkMarginAttr "b" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: int) = Interop.mkMarginAttr "pad" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: float) = Interop.mkMarginAttr "pad" value
        /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
        static member inline autoexpand (value: bool) = Interop.mkMarginAttr "autoexpand" value

    [<Erase>]
    type modebar =
        /// Sets the background color of the modebar.
        static member inline bgcolor (value: string) = Interop.mkModebarAttr "bgcolor" value
        /// Sets the color of the icons in the modebar.
        static member inline color (value: string) = Interop.mkModebarAttr "color" value
        /// Sets the color of the active or hovered on icons in the modebar.
        static member inline activecolor (value: string) = Interop.mkModebarAttr "activecolor" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkModebarAttr "uirevision" values

    module modebar =
        /// Sets the orientation of the modebar.
        [<Erase>]
        type orientation =
            static member inline v = Interop.mkModebarAttr "orientation" "v"
            static member inline h = Interop.mkModebarAttr "orientation" "h"

    [<Erase>]
    type transition =
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: int) = Interop.mkTransitionAttr "duration" value
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: float) = Interop.mkTransitionAttr "duration" value

    module transition =
        /// The easing function used for the transition
        [<Erase>]
        type easing =
            static member inline linear = Interop.mkTransitionAttr "easing" "linear"
            static member inline quad = Interop.mkTransitionAttr "easing" "quad"
            static member inline cubic = Interop.mkTransitionAttr "easing" "cubic"
            static member inline sin = Interop.mkTransitionAttr "easing" "sin"
            static member inline exp = Interop.mkTransitionAttr "easing" "exp"
            static member inline circle = Interop.mkTransitionAttr "easing" "circle"
            static member inline elastic = Interop.mkTransitionAttr "easing" "elastic"
            static member inline back = Interop.mkTransitionAttr "easing" "back"
            static member inline bounce = Interop.mkTransitionAttr "easing" "bounce"
            static member inline linearIn = Interop.mkTransitionAttr "easing" "linear-in"
            static member inline quadIn = Interop.mkTransitionAttr "easing" "quad-in"
            static member inline cubicIn = Interop.mkTransitionAttr "easing" "cubic-in"
            static member inline sinIn = Interop.mkTransitionAttr "easing" "sin-in"
            static member inline expIn = Interop.mkTransitionAttr "easing" "exp-in"
            static member inline circleIn = Interop.mkTransitionAttr "easing" "circle-in"
            static member inline elasticIn = Interop.mkTransitionAttr "easing" "elastic-in"
            static member inline backIn = Interop.mkTransitionAttr "easing" "back-in"
            static member inline bounceIn = Interop.mkTransitionAttr "easing" "bounce-in"
            static member inline linearOut = Interop.mkTransitionAttr "easing" "linear-out"
            static member inline quadOut = Interop.mkTransitionAttr "easing" "quad-out"
            static member inline cubicOut = Interop.mkTransitionAttr "easing" "cubic-out"
            static member inline sinOut = Interop.mkTransitionAttr "easing" "sin-out"
            static member inline expOut = Interop.mkTransitionAttr "easing" "exp-out"
            static member inline circleOut = Interop.mkTransitionAttr "easing" "circle-out"
            static member inline elasticOut = Interop.mkTransitionAttr "easing" "elastic-out"
            static member inline backOut = Interop.mkTransitionAttr "easing" "back-out"
            static member inline bounceOut = Interop.mkTransitionAttr "easing" "bounce-out"
            static member inline linearInOut = Interop.mkTransitionAttr "easing" "linear-in-out"
            static member inline quadInOut = Interop.mkTransitionAttr "easing" "quad-in-out"
            static member inline cubicInOut = Interop.mkTransitionAttr "easing" "cubic-in-out"
            static member inline sinInOut = Interop.mkTransitionAttr "easing" "sin-in-out"
            static member inline expInOut = Interop.mkTransitionAttr "easing" "exp-in-out"
            static member inline circleInOut = Interop.mkTransitionAttr "easing" "circle-in-out"
            static member inline elasticInOut = Interop.mkTransitionAttr "easing" "elastic-in-out"
            static member inline backInOut = Interop.mkTransitionAttr "easing" "back-in-out"
            static member inline bounceInOut = Interop.mkTransitionAttr "easing" "bounce-in-out"

        /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
        [<Erase>]
        type ordering =
            static member inline layoutFirst = Interop.mkTransitionAttr "ordering" "layout first"
            static member inline tracesFirst = Interop.mkTransitionAttr "ordering" "traces first"

    [<Erase>]
    type hoverlabel =
        /// Sets the background color of all hover labels on graph
        static member inline bgcolor (value: string) = Interop.mkHoverlabelAttr "bgcolor" value
        /// Sets the border color of all hover labels on graph.
        static member inline bordercolor (value: string) = Interop.mkHoverlabelAttr "bordercolor" value
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        static member inline namelength (value: int) = Interop.mkHoverlabelAttr "namelength" value

    module hoverlabel =
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        [<Erase>]
        type align =
            static member inline left = Interop.mkHoverlabelAttr "align" "left"
            static member inline right = Interop.mkHoverlabelAttr "align" "right"
            static member inline auto = Interop.mkHoverlabelAttr "align" "auto"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkFontAttr "family" value
            static member inline size (value: int) = Interop.mkFontAttr "size" value
            static member inline size (value: float) = Interop.mkFontAttr "size" value
            static member inline color (value: string) = Interop.mkFontAttr "color" value

    [<Erase>]
    type grid =
        /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline rows (value: int) = Interop.mkGridAttr "rows" value
        /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline columns (value: int) = Interop.mkGridAttr "columns" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: int) = Interop.mkGridAttr "xgap" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: float) = Interop.mkGridAttr "xgap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: int) = Interop.mkGridAttr "ygap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: float) = Interop.mkGridAttr "ygap" value

    module grid =
        /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
        [<Erase>]
        type roworder =
            static member inline topToBottom = Interop.mkGridAttr "roworder" "top to bottom"
            static member inline bottomToTop = Interop.mkGridAttr "roworder" "bottom to top"

        /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
        [<Erase>]
        type pattern =
            static member inline independent = Interop.mkGridAttr "pattern" "independent"
            static member inline coupled = Interop.mkGridAttr "pattern" "coupled"

        /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
        [<Erase>]
        type xside =
            static member inline bottom = Interop.mkGridAttr "xside" "bottom"
            static member inline bottomPlot = Interop.mkGridAttr "xside" "bottom plot"
            static member inline topPlot = Interop.mkGridAttr "xside" "top plot"
            static member inline top = Interop.mkGridAttr "xside" "top"

        /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
        [<Erase>]
        type yside =
            static member inline left = Interop.mkGridAttr "yside" "left"
            static member inline leftPlot = Interop.mkGridAttr "yside" "left plot"
            static member inline rightPlot = Interop.mkGridAttr "yside" "right plot"
            static member inline right = Interop.mkGridAttr "yside" "right"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values

    [<Erase>]
    type xaxis =
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkXaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkXaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkXaxisAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkXaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkXaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkXaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkXaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkXaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkXaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkXaxisAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkXaxisAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkXaxisAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkXaxisAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkXaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkXaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkXaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkXaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkXaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkXaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkXaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkXaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkXaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkXaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkXaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkXaxisAttr "spikedash" value
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        static member inline spikemode (values: seq<string>) = Interop.mkXaxisAttr "spikemode" values
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkXaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkXaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkXaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkXaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkXaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkXaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkXaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkXaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkXaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkXaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkXaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkXaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkXaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkXaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkXaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkXaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkXaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkXaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkXaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkXaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkXaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkXaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkXaxisAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkXaxisAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkXaxisAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkXaxisAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkXaxisAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkXaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkXaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkXaxisAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkXaxisAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkXaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkXaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkXaxisAttr "categoryarraysrc" value

    module xaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkXaxisAttr "type" "-"
            static member inline linear = Interop.mkXaxisAttr "type" "linear"
            static member inline log = Interop.mkXaxisAttr "type" "log"
            static member inline date = Interop.mkXaxisAttr "type" "date"
            static member inline category = Interop.mkXaxisAttr "type" "category"
            static member inline multicategory = Interop.mkXaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline true' = Interop.mkXaxisAttr "autorange" true
            static member inline false' = Interop.mkXaxisAttr "autorange" false
            static member inline reversed = Interop.mkXaxisAttr "autorange" "reversed"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline normal = Interop.mkXaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkXaxisAttr "rangemode" "tozero"
            static member inline nonnegative = Interop.mkXaxisAttr "rangemode" "nonnegative"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline range = Interop.mkXaxisAttr "constrain" "range"
            static member inline domain = Interop.mkXaxisAttr "constrain" "domain"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline left = Interop.mkXaxisAttr "constraintoward" "left"
            static member inline center = Interop.mkXaxisAttr "constraintoward" "center"
            static member inline right = Interop.mkXaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkXaxisAttr "constraintoward" "top"
            static member inline middle = Interop.mkXaxisAttr "constraintoward" "middle"
            static member inline bottom = Interop.mkXaxisAttr "constraintoward" "bottom"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline auto = Interop.mkXaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkXaxisAttr "tickmode" "linear"
            static member inline array = Interop.mkXaxisAttr "tickmode" "array"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline outside = Interop.mkXaxisAttr "ticks" "outside"
            static member inline inside = Interop.mkXaxisAttr "ticks" "inside"
            static member inline none = Interop.mkXaxisAttr "ticks" ""

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline labels = Interop.mkXaxisAttr "tickson" "labels"
            static member inline boundaries = Interop.mkXaxisAttr "tickson" "boundaries"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline true' = Interop.mkXaxisAttr "mirror" true
            static member inline ticks = Interop.mkXaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkXaxisAttr "mirror" false
            static member inline all = Interop.mkXaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkXaxisAttr "mirror" "allticks"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline data = Interop.mkXaxisAttr "spikesnap" "data"
            static member inline cursor = Interop.mkXaxisAttr "spikesnap" "cursor"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkXaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkXaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkXaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkXaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkXaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkXaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkXaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkXaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkXaxisAttr "showexponent" "all"
            static member inline first = Interop.mkXaxisAttr "showexponent" "first"
            static member inline last = Interop.mkXaxisAttr "showexponent" "last"
            static member inline none = Interop.mkXaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline none = Interop.mkXaxisAttr "exponentformat" "none"
            static member inline e = Interop.mkXaxisAttr "exponentformat" "e"
            static member inline E = Interop.mkXaxisAttr "exponentformat" "E"
            static member inline power = Interop.mkXaxisAttr "exponentformat" "power"
            static member inline SI = Interop.mkXaxisAttr "exponentformat" "SI"
            static member inline B = Interop.mkXaxisAttr "exponentformat" "B"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkXaxisAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline top = Interop.mkXaxisAttr "side" "top"
            static member inline bottom = Interop.mkXaxisAttr "side" "bottom"
            static member inline left = Interop.mkXaxisAttr "side" "left"
            static member inline right = Interop.mkXaxisAttr "side" "right"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkXaxisAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkXaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkXaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline trace = Interop.mkXaxisAttr "categoryorder" "trace"
            static member inline categoryAscending = Interop.mkXaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkXaxisAttr "categoryorder" "category descending"
            static member inline array = Interop.mkXaxisAttr "categoryorder" "array"
            static member inline totalAscending = Interop.mkXaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkXaxisAttr "categoryorder" "total descending"
            static member inline minAscending = Interop.mkXaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkXaxisAttr "categoryorder" "min descending"
            static member inline maxAscending = Interop.mkXaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkXaxisAttr "categoryorder" "max descending"
            static member inline sumAscending = Interop.mkXaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkXaxisAttr "categoryorder" "sum descending"
            static member inline meanAscending = Interop.mkXaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkXaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkXaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkXaxisAttr "categoryorder" "median descending"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline gregorian = Interop.mkXaxisAttr "calendar" "gregorian"
            static member inline chinese = Interop.mkXaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkXaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkXaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkXaxisAttr "calendar" "ethiopian"
            static member inline hebrew = Interop.mkXaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkXaxisAttr "calendar" "islamic"
            static member inline julian = Interop.mkXaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkXaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkXaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkXaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkXaxisAttr "calendar" "persian"
            static member inline jalali = Interop.mkXaxisAttr "calendar" "jalali"
            static member inline taiwan = Interop.mkXaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkXaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkXaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkTitleAttr "text" value

        module title =
            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkFontAttr "family" value
                static member inline size (value: int) = Interop.mkFontAttr "size" value
                static member inline size (value: float) = Interop.mkFontAttr "size" value
                static member inline color (value: string) = Interop.mkFontAttr "color" value

        [<Erase>]
        type tickfont =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type rangeslider =
            /// Sets the background color of the range slider.
            static member inline bgcolor (value: string) = Interop.mkRangesliderAttr "bgcolor" value
            /// Sets the border color of the range slider.
            static member inline bordercolor (value: string) = Interop.mkRangesliderAttr "bordercolor" value
            /// Sets the border width of the range slider.
            static member inline borderwidth (value: int) = Interop.mkRangesliderAttr "borderwidth" value
            /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
            static member inline autorange (value: bool) = Interop.mkRangesliderAttr "autorange" value
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkRangesliderAttr "range" values
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: int) = Interop.mkRangesliderAttr "thickness" value
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: float) = Interop.mkRangesliderAttr "thickness" value
            /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
            static member inline visible (value: bool) = Interop.mkRangesliderAttr "visible" value

        module rangeslider =
            [<Erase>]
            type yaxis =
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<bool>) = Interop.mkYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<int>) = Interop.mkYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<float>) = Interop.mkYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<string>) = Interop.mkYaxisAttr "range" values

            module yaxis =
                /// Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used.
                [<Erase>]
                type rangemode =
                    static member inline auto = Interop.mkYaxisAttr "rangemode" "auto"
                    static member inline fixed' = Interop.mkYaxisAttr "rangemode" "fixed"
                    static member inline match' = Interop.mkYaxisAttr "rangemode" "match"

        [<Erase>]
        type rangeselector =
            /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
            static member inline visible (value: bool) = Interop.mkRangeselectorAttr "visible" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: int) = Interop.mkRangeselectorAttr "x" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: float) = Interop.mkRangeselectorAttr "x" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: int) = Interop.mkRangeselectorAttr "y" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: float) = Interop.mkRangeselectorAttr "y" value
            /// Sets the background color of the range selector buttons.
            static member inline bgcolor (value: string) = Interop.mkRangeselectorAttr "bgcolor" value
            /// Sets the background color of the active range selector button.
            static member inline activecolor (value: string) = Interop.mkRangeselectorAttr "activecolor" value
            /// Sets the color of the border enclosing the range selector.
            static member inline bordercolor (value: string) = Interop.mkRangeselectorAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: int) = Interop.mkRangeselectorAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: float) = Interop.mkRangeselectorAttr "borderwidth" value

        module rangeselector =
            /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkRangeselectorAttr "xanchor" "auto"
                static member inline left = Interop.mkRangeselectorAttr "xanchor" "left"
                static member inline center = Interop.mkRangeselectorAttr "xanchor" "center"
                static member inline right = Interop.mkRangeselectorAttr "xanchor" "right"

            /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkRangeselectorAttr "yanchor" "auto"
                static member inline top = Interop.mkRangeselectorAttr "yanchor" "top"
                static member inline middle = Interop.mkRangeselectorAttr "yanchor" "middle"
                static member inline bottom = Interop.mkRangeselectorAttr "yanchor" "bottom"

            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkFontAttr "family" value
                static member inline size (value: int) = Interop.mkFontAttr "size" value
                static member inline size (value: float) = Interop.mkFontAttr "size" value
                static member inline color (value: string) = Interop.mkFontAttr "color" value

    [<Erase>]
    type yaxis =
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkYaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkYaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkYaxisAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkYaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkYaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkYaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkYaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkYaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkYaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkYaxisAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkYaxisAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkYaxisAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkYaxisAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkYaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkYaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkYaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkYaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkYaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkYaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkYaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkYaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkYaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkYaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkYaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkYaxisAttr "spikedash" value
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        static member inline spikemode (values: seq<string>) = Interop.mkYaxisAttr "spikemode" values
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkYaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkYaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkYaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkYaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkYaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkYaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkYaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkYaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkYaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkYaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkYaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkYaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkYaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkYaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkYaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkYaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkYaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkYaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkYaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkYaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkYaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkYaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkYaxisAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkYaxisAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkYaxisAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkYaxisAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkYaxisAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkYaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkYaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkYaxisAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkYaxisAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkYaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkYaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkYaxisAttr "categoryarraysrc" value

    module yaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkYaxisAttr "type" "-"
            static member inline linear = Interop.mkYaxisAttr "type" "linear"
            static member inline log = Interop.mkYaxisAttr "type" "log"
            static member inline date = Interop.mkYaxisAttr "type" "date"
            static member inline category = Interop.mkYaxisAttr "type" "category"
            static member inline multicategory = Interop.mkYaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline true' = Interop.mkYaxisAttr "autorange" true
            static member inline false' = Interop.mkYaxisAttr "autorange" false
            static member inline reversed = Interop.mkYaxisAttr "autorange" "reversed"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline normal = Interop.mkYaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkYaxisAttr "rangemode" "tozero"
            static member inline nonnegative = Interop.mkYaxisAttr "rangemode" "nonnegative"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline range = Interop.mkYaxisAttr "constrain" "range"
            static member inline domain = Interop.mkYaxisAttr "constrain" "domain"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline left = Interop.mkYaxisAttr "constraintoward" "left"
            static member inline center = Interop.mkYaxisAttr "constraintoward" "center"
            static member inline right = Interop.mkYaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkYaxisAttr "constraintoward" "top"
            static member inline middle = Interop.mkYaxisAttr "constraintoward" "middle"
            static member inline bottom = Interop.mkYaxisAttr "constraintoward" "bottom"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline auto = Interop.mkYaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkYaxisAttr "tickmode" "linear"
            static member inline array = Interop.mkYaxisAttr "tickmode" "array"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline outside = Interop.mkYaxisAttr "ticks" "outside"
            static member inline inside = Interop.mkYaxisAttr "ticks" "inside"
            static member inline none = Interop.mkYaxisAttr "ticks" ""

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline labels = Interop.mkYaxisAttr "tickson" "labels"
            static member inline boundaries = Interop.mkYaxisAttr "tickson" "boundaries"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline true' = Interop.mkYaxisAttr "mirror" true
            static member inline ticks = Interop.mkYaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkYaxisAttr "mirror" false
            static member inline all = Interop.mkYaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkYaxisAttr "mirror" "allticks"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline data = Interop.mkYaxisAttr "spikesnap" "data"
            static member inline cursor = Interop.mkYaxisAttr "spikesnap" "cursor"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkYaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkYaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkYaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkYaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkYaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkYaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkYaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkYaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkYaxisAttr "showexponent" "all"
            static member inline first = Interop.mkYaxisAttr "showexponent" "first"
            static member inline last = Interop.mkYaxisAttr "showexponent" "last"
            static member inline none = Interop.mkYaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline none = Interop.mkYaxisAttr "exponentformat" "none"
            static member inline e = Interop.mkYaxisAttr "exponentformat" "e"
            static member inline E = Interop.mkYaxisAttr "exponentformat" "E"
            static member inline power = Interop.mkYaxisAttr "exponentformat" "power"
            static member inline SI = Interop.mkYaxisAttr "exponentformat" "SI"
            static member inline B = Interop.mkYaxisAttr "exponentformat" "B"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkYaxisAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline top = Interop.mkYaxisAttr "side" "top"
            static member inline bottom = Interop.mkYaxisAttr "side" "bottom"
            static member inline left = Interop.mkYaxisAttr "side" "left"
            static member inline right = Interop.mkYaxisAttr "side" "right"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkYaxisAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkYaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkYaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline trace = Interop.mkYaxisAttr "categoryorder" "trace"
            static member inline categoryAscending = Interop.mkYaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkYaxisAttr "categoryorder" "category descending"
            static member inline array = Interop.mkYaxisAttr "categoryorder" "array"
            static member inline totalAscending = Interop.mkYaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkYaxisAttr "categoryorder" "total descending"
            static member inline minAscending = Interop.mkYaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkYaxisAttr "categoryorder" "min descending"
            static member inline maxAscending = Interop.mkYaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkYaxisAttr "categoryorder" "max descending"
            static member inline sumAscending = Interop.mkYaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkYaxisAttr "categoryorder" "sum descending"
            static member inline meanAscending = Interop.mkYaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkYaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkYaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkYaxisAttr "categoryorder" "median descending"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline gregorian = Interop.mkYaxisAttr "calendar" "gregorian"
            static member inline chinese = Interop.mkYaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkYaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkYaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkYaxisAttr "calendar" "ethiopian"
            static member inline hebrew = Interop.mkYaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkYaxisAttr "calendar" "islamic"
            static member inline julian = Interop.mkYaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkYaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkYaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkYaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkYaxisAttr "calendar" "persian"
            static member inline jalali = Interop.mkYaxisAttr "calendar" "jalali"
            static member inline taiwan = Interop.mkYaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkYaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkYaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkTitleAttr "text" value

        module title =
            [<Erase>]
            type font =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkFontAttr "family" value
                static member inline size (value: int) = Interop.mkFontAttr "size" value
                static member inline size (value: float) = Interop.mkFontAttr "size" value
                static member inline color (value: string) = Interop.mkFontAttr "color" value

        [<Erase>]
        type tickfont =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkTickfontAttr "color" value

    [<Erase>]
    type ternary =
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkTernaryAttr "bgcolor" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: int) = Interop.mkTernaryAttr "sum" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: float) = Interop.mkTernaryAttr "sum" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkTernaryAttr "uirevision" values

    module ternary =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this ternary subplot .
            static member inline row (value: int) = Interop.mkDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this ternary subplot .
            static member inline column (value: int) = Interop.mkDomainAttr "column" value

        [<Erase>]
        type aaxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkAaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkAaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkAaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkAaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkAaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkAaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkAaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkAaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkAaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkAaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkAaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkAaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkAaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkAaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkAaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkAaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkAaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkAaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkAaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkAaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkAaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkAaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkAaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkAaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkAaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkAaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkAaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkAaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkAaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkAaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkAaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkAaxisAttr "ticktextsrc" value

        module aaxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkAaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkAaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkAaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkAaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkAaxisAttr "ticks" "inside"
                static member inline none = Interop.mkAaxisAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkAaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkAaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkAaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkAaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkAaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkAaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkAaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkAaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkAaxisAttr "showexponent" "all"
                static member inline first = Interop.mkAaxisAttr "showexponent" "first"
                static member inline last = Interop.mkAaxisAttr "showexponent" "last"
                static member inline none = Interop.mkAaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkAaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkAaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkAaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkAaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkAaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkAaxisAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkAaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkAaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type baxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkBaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkBaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkBaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkBaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkBaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkBaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkBaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkBaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkBaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkBaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkBaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkBaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkBaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkBaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkBaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkBaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkBaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkBaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkBaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkBaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkBaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkBaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkBaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkBaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkBaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkBaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkBaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkBaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkBaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkBaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkBaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkBaxisAttr "ticktextsrc" value

        module baxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkBaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkBaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkBaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkBaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkBaxisAttr "ticks" "inside"
                static member inline none = Interop.mkBaxisAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkBaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkBaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkBaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkBaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkBaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkBaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkBaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkBaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkBaxisAttr "showexponent" "all"
                static member inline first = Interop.mkBaxisAttr "showexponent" "first"
                static member inline last = Interop.mkBaxisAttr "showexponent" "last"
                static member inline none = Interop.mkBaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkBaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkBaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkBaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkBaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkBaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkBaxisAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkBaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkBaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type caxis =
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkCaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkCaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkCaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkCaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkCaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkCaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkCaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkCaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkCaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkCaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkCaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkCaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkCaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkCaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkCaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkCaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkCaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkCaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkCaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkCaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkCaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkCaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkCaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkCaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkCaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkCaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkCaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkCaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkCaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkCaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkCaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkCaxisAttr "ticktextsrc" value

        module caxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkCaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkCaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkCaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkCaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkCaxisAttr "ticks" "inside"
                static member inline none = Interop.mkCaxisAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkCaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkCaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkCaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkCaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkCaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkCaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkCaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkCaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkCaxisAttr "showexponent" "all"
                static member inline first = Interop.mkCaxisAttr "showexponent" "first"
                static member inline last = Interop.mkCaxisAttr "showexponent" "last"
                static member inline none = Interop.mkCaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkCaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkCaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkCaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkCaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkCaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkCaxisAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkCaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkCaxisAttr "layer" "below traces"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

    [<Erase>]
    type scene =
        static member inline bgcolor (value: string) = Interop.mkSceneAttr "bgcolor" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkSceneAttr "uirevision" values

    module scene =
        /// If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
        [<Erase>]
        type aspectmode =
            static member inline auto = Interop.mkSceneAttr "aspectmode" "auto"
            static member inline cube = Interop.mkSceneAttr "aspectmode" "cube"
            static member inline data = Interop.mkSceneAttr "aspectmode" "data"
            static member inline manual = Interop.mkSceneAttr "aspectmode" "manual"

        /// Determines the mode of drag interactions for this scene.
        [<Erase>]
        type dragmode =
            static member inline orbit = Interop.mkSceneAttr "dragmode" "orbit"
            static member inline turntable = Interop.mkSceneAttr "dragmode" "turntable"
            static member inline zoom = Interop.mkSceneAttr "dragmode" "zoom"
            static member inline pan = Interop.mkSceneAttr "dragmode" "pan"
            static member inline false' = Interop.mkSceneAttr "dragmode" false

        /// Determines the mode of hover interactions for this scene.
        [<Erase>]
        type hovermode =
            static member inline closest = Interop.mkSceneAttr "hovermode" "closest"
            static member inline false' = Interop.mkSceneAttr "hovermode" false

        module camera =
            [<Erase>]
            type up =
                static member inline x (value: int) = Interop.mkUpAttr "x" value
                static member inline x (value: float) = Interop.mkUpAttr "x" value
                static member inline y (value: int) = Interop.mkUpAttr "y" value
                static member inline y (value: float) = Interop.mkUpAttr "y" value
                static member inline z (value: int) = Interop.mkUpAttr "z" value
                static member inline z (value: float) = Interop.mkUpAttr "z" value

            [<Erase>]
            type center =
                static member inline x (value: int) = Interop.mkCenterAttr "x" value
                static member inline x (value: float) = Interop.mkCenterAttr "x" value
                static member inline y (value: int) = Interop.mkCenterAttr "y" value
                static member inline y (value: float) = Interop.mkCenterAttr "y" value
                static member inline z (value: int) = Interop.mkCenterAttr "z" value
                static member inline z (value: float) = Interop.mkCenterAttr "z" value

            [<Erase>]
            type eye =
                static member inline x (value: int) = Interop.mkEyeAttr "x" value
                static member inline x (value: float) = Interop.mkEyeAttr "x" value
                static member inline y (value: int) = Interop.mkEyeAttr "y" value
                static member inline y (value: float) = Interop.mkEyeAttr "y" value
                static member inline z (value: int) = Interop.mkEyeAttr "z" value
                static member inline z (value: float) = Interop.mkEyeAttr "z" value

            module projection =
                /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
                [<Erase>]
                type type' =
                    static member inline perspective = Interop.mkProjectionAttr "type" "perspective"
                    static member inline orthographic = Interop.mkProjectionAttr "type" "orthographic"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this scene subplot .
            static member inline row (value: int) = Interop.mkDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this scene subplot .
            static member inline column (value: int) = Interop.mkDomainAttr "column" value

        [<Erase>]
        type aspectratio =
            static member inline x (value: int) = Interop.mkAspectratioAttr "x" value
            static member inline x (value: float) = Interop.mkAspectratioAttr "x" value
            static member inline y (value: int) = Interop.mkAspectratioAttr "y" value
            static member inline y (value: float) = Interop.mkAspectratioAttr "y" value
            static member inline z (value: int) = Interop.mkAspectratioAttr "z" value
            static member inline z (value: float) = Interop.mkAspectratioAttr "z" value

        [<Erase>]
        type xaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkXaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkXaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkXaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkXaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkXaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkXaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkXaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkXaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkXaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkXaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkXaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkXaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkXaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkXaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkXaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkXaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkXaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkXaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkXaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkXaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkXaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkXaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkXaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkXaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkXaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkXaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkXaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkXaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkXaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkXaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkXaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkXaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkXaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkXaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkXaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkXaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkXaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkXaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkXaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkXaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkXaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkXaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkXaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkXaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkXaxisAttr "ticktextsrc" value

        module xaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkXaxisAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkXaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkXaxisAttr "categoryorder" "category descending"
                static member inline array = Interop.mkXaxisAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkXaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkXaxisAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkXaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkXaxisAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkXaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkXaxisAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkXaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkXaxisAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkXaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkXaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkXaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkXaxisAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkXaxisAttr "type" "-"
                static member inline linear = Interop.mkXaxisAttr "type" "linear"
                static member inline log = Interop.mkXaxisAttr "type" "log"
                static member inline date = Interop.mkXaxisAttr "type" "date"
                static member inline category = Interop.mkXaxisAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkXaxisAttr "autorange" true
                static member inline false' = Interop.mkXaxisAttr "autorange" false
                static member inline reversed = Interop.mkXaxisAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkXaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkXaxisAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkXaxisAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkXaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkXaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkXaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkXaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkXaxisAttr "ticks" "inside"
                static member inline none = Interop.mkXaxisAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkXaxisAttr "mirror" true
                static member inline ticks = Interop.mkXaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkXaxisAttr "mirror" false
                static member inline all = Interop.mkXaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkXaxisAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkXaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkXaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkXaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkXaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkXaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkXaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkXaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkXaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkXaxisAttr "showexponent" "all"
                static member inline first = Interop.mkXaxisAttr "showexponent" "first"
                static member inline last = Interop.mkXaxisAttr "showexponent" "last"
                static member inline none = Interop.mkXaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkXaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkXaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkXaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkXaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkXaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkXaxisAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkXaxisAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkXaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkXaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkXaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkXaxisAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkXaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkXaxisAttr "calendar" "islamic"
                static member inline julian = Interop.mkXaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkXaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkXaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkXaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkXaxisAttr "calendar" "persian"
                static member inline jalali = Interop.mkXaxisAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkXaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkXaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkXaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type yaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkYaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkYaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkYaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkYaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkYaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkYaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkYaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkYaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkYaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkYaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkYaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkYaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkYaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkYaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkYaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkYaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkYaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkYaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkYaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkYaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkYaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkYaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkYaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkYaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkYaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkYaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkYaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkYaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkYaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkYaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkYaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkYaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkYaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkYaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkYaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkYaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkYaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkYaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkYaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkYaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkYaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkYaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkYaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkYaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkYaxisAttr "ticktextsrc" value

        module yaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkYaxisAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkYaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkYaxisAttr "categoryorder" "category descending"
                static member inline array = Interop.mkYaxisAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkYaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkYaxisAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkYaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkYaxisAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkYaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkYaxisAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkYaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkYaxisAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkYaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkYaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkYaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkYaxisAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkYaxisAttr "type" "-"
                static member inline linear = Interop.mkYaxisAttr "type" "linear"
                static member inline log = Interop.mkYaxisAttr "type" "log"
                static member inline date = Interop.mkYaxisAttr "type" "date"
                static member inline category = Interop.mkYaxisAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkYaxisAttr "autorange" true
                static member inline false' = Interop.mkYaxisAttr "autorange" false
                static member inline reversed = Interop.mkYaxisAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkYaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkYaxisAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkYaxisAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkYaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkYaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkYaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkYaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkYaxisAttr "ticks" "inside"
                static member inline none = Interop.mkYaxisAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkYaxisAttr "mirror" true
                static member inline ticks = Interop.mkYaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkYaxisAttr "mirror" false
                static member inline all = Interop.mkYaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkYaxisAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkYaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkYaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkYaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkYaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkYaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkYaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkYaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkYaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkYaxisAttr "showexponent" "all"
                static member inline first = Interop.mkYaxisAttr "showexponent" "first"
                static member inline last = Interop.mkYaxisAttr "showexponent" "last"
                static member inline none = Interop.mkYaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkYaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkYaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkYaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkYaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkYaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkYaxisAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkYaxisAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkYaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkYaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkYaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkYaxisAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkYaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkYaxisAttr "calendar" "islamic"
                static member inline julian = Interop.mkYaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkYaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkYaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkYaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkYaxisAttr "calendar" "persian"
                static member inline jalali = Interop.mkYaxisAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkYaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkYaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkYaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type zaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkZaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkZaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkZaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkZaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkZaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkZaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkZaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkZaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkZaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkZaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkZaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkZaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkZaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkZaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkZaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkZaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkZaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkZaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkZaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkZaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkZaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkZaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkZaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkZaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkZaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkZaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkZaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkZaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkZaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkZaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkZaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkZaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkZaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkZaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkZaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkZaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkZaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkZaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkZaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkZaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkZaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkZaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkZaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkZaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkZaxisAttr "ticktextsrc" value

        module zaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkZaxisAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkZaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkZaxisAttr "categoryorder" "category descending"
                static member inline array = Interop.mkZaxisAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkZaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkZaxisAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkZaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkZaxisAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkZaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkZaxisAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkZaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkZaxisAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkZaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkZaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkZaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkZaxisAttr "categoryorder" "median descending"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkZaxisAttr "type" "-"
                static member inline linear = Interop.mkZaxisAttr "type" "linear"
                static member inline log = Interop.mkZaxisAttr "type" "log"
                static member inline date = Interop.mkZaxisAttr "type" "date"
                static member inline category = Interop.mkZaxisAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkZaxisAttr "autorange" true
                static member inline false' = Interop.mkZaxisAttr "autorange" false
                static member inline reversed = Interop.mkZaxisAttr "autorange" "reversed"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline normal = Interop.mkZaxisAttr "rangemode" "normal"
                static member inline tozero = Interop.mkZaxisAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkZaxisAttr "rangemode" "nonnegative"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkZaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkZaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkZaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkZaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkZaxisAttr "ticks" "inside"
                static member inline none = Interop.mkZaxisAttr "ticks" ""

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline true' = Interop.mkZaxisAttr "mirror" true
                static member inline ticks = Interop.mkZaxisAttr "mirror" "ticks"
                static member inline false' = Interop.mkZaxisAttr "mirror" false
                static member inline all = Interop.mkZaxisAttr "mirror" "all"
                static member inline allticks = Interop.mkZaxisAttr "mirror" "allticks"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkZaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkZaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkZaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkZaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkZaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkZaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkZaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkZaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkZaxisAttr "showexponent" "all"
                static member inline first = Interop.mkZaxisAttr "showexponent" "first"
                static member inline last = Interop.mkZaxisAttr "showexponent" "last"
                static member inline none = Interop.mkZaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkZaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkZaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkZaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkZaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkZaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkZaxisAttr "exponentformat" "B"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkZaxisAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkZaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkZaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkZaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkZaxisAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkZaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkZaxisAttr "calendar" "islamic"
                static member inline julian = Interop.mkZaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkZaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkZaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkZaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkZaxisAttr "calendar" "persian"
                static member inline jalali = Interop.mkZaxisAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkZaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkZaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkZaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

    [<Erase>]
    type geo =
        /// Sets whether or not the coastlines are drawn.
        static member inline showcoastlines (value: bool) = Interop.mkGeoAttr "showcoastlines" value
        /// Sets the coastline color.
        static member inline coastlinecolor (value: string) = Interop.mkGeoAttr "coastlinecolor" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: int) = Interop.mkGeoAttr "coastlinewidth" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: float) = Interop.mkGeoAttr "coastlinewidth" value
        /// Sets whether or not land masses are filled in color.
        static member inline showland (value: bool) = Interop.mkGeoAttr "showland" value
        /// Sets the land mass color.
        static member inline landcolor (value: string) = Interop.mkGeoAttr "landcolor" value
        /// Sets whether or not oceans are filled in color.
        static member inline showocean (value: bool) = Interop.mkGeoAttr "showocean" value
        /// Sets the ocean color
        static member inline oceancolor (value: string) = Interop.mkGeoAttr "oceancolor" value
        /// Sets whether or not lakes are drawn.
        static member inline showlakes (value: bool) = Interop.mkGeoAttr "showlakes" value
        /// Sets the color of the lakes.
        static member inline lakecolor (value: string) = Interop.mkGeoAttr "lakecolor" value
        /// Sets whether or not rivers are drawn.
        static member inline showrivers (value: bool) = Interop.mkGeoAttr "showrivers" value
        /// Sets color of the rivers.
        static member inline rivercolor (value: string) = Interop.mkGeoAttr "rivercolor" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: int) = Interop.mkGeoAttr "riverwidth" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: float) = Interop.mkGeoAttr "riverwidth" value
        /// Sets whether or not country boundaries are drawn.
        static member inline showcountries (value: bool) = Interop.mkGeoAttr "showcountries" value
        /// Sets line color of the country boundaries.
        static member inline countrycolor (value: string) = Interop.mkGeoAttr "countrycolor" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: int) = Interop.mkGeoAttr "countrywidth" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: float) = Interop.mkGeoAttr "countrywidth" value
        /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
        static member inline showsubunits (value: bool) = Interop.mkGeoAttr "showsubunits" value
        /// Sets the color of the subunits boundaries.
        static member inline subunitcolor (value: string) = Interop.mkGeoAttr "subunitcolor" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: int) = Interop.mkGeoAttr "subunitwidth" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: float) = Interop.mkGeoAttr "subunitwidth" value
        /// Sets whether or not a frame is drawn around the map.
        static member inline showframe (value: bool) = Interop.mkGeoAttr "showframe" value
        /// Sets the color the frame.
        static member inline framecolor (value: string) = Interop.mkGeoAttr "framecolor" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: int) = Interop.mkGeoAttr "framewidth" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: float) = Interop.mkGeoAttr "framewidth" value
        /// Set the background color of the map
        static member inline bgcolor (value: string) = Interop.mkGeoAttr "bgcolor" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkGeoAttr "uirevision" values

    module geo =
        /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
        [<Erase>]
        type resolution =
            static member inline _110 = Interop.mkGeoAttr "resolution" 110
            static member inline _50 = Interop.mkGeoAttr "resolution" 50

        /// Set the scope of the map.
        [<Erase>]
        type scope =
            static member inline world = Interop.mkGeoAttr "scope" "world"
            static member inline usa = Interop.mkGeoAttr "scope" "usa"
            static member inline europe = Interop.mkGeoAttr "scope" "europe"
            static member inline asia = Interop.mkGeoAttr "scope" "asia"
            static member inline africa = Interop.mkGeoAttr "scope" "africa"
            static member inline northAmerica = Interop.mkGeoAttr "scope" "north america"
            static member inline southAmerica = Interop.mkGeoAttr "scope" "south america"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline row (value: int) = Interop.mkDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline column (value: int) = Interop.mkDomainAttr "column" value

        [<Erase>]
        type projection =
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<int>) = Interop.mkProjectionAttr "parallels" values
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<float>) = Interop.mkProjectionAttr "parallels" values
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: int) = Interop.mkProjectionAttr "scale" value
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: float) = Interop.mkProjectionAttr "scale" value

        module projection =
            /// Sets the projection type.
            [<Erase>]
            type type' =
                static member inline equirectangular = Interop.mkProjectionAttr "type" "equirectangular"
                static member inline mercator = Interop.mkProjectionAttr "type" "mercator"
                static member inline orthographic = Interop.mkProjectionAttr "type" "orthographic"
                static member inline naturalEarth = Interop.mkProjectionAttr "type" "natural earth"
                static member inline kavrayskiy7 = Interop.mkProjectionAttr "type" "kavrayskiy7"
                static member inline miller = Interop.mkProjectionAttr "type" "miller"
                static member inline robinson = Interop.mkProjectionAttr "type" "robinson"
                static member inline eckert4 = Interop.mkProjectionAttr "type" "eckert4"
                static member inline azimuthalEqualArea = Interop.mkProjectionAttr "type" "azimuthal equal area"
                static member inline azimuthalEquidistant = Interop.mkProjectionAttr "type" "azimuthal equidistant"
                static member inline conicEqualArea = Interop.mkProjectionAttr "type" "conic equal area"
                static member inline conicConformal = Interop.mkProjectionAttr "type" "conic conformal"
                static member inline conicEquidistant = Interop.mkProjectionAttr "type" "conic equidistant"
                static member inline gnomonic = Interop.mkProjectionAttr "type" "gnomonic"
                static member inline stereographic = Interop.mkProjectionAttr "type" "stereographic"
                static member inline mollweide = Interop.mkProjectionAttr "type" "mollweide"
                static member inline hammer = Interop.mkProjectionAttr "type" "hammer"
                static member inline transverseMercator = Interop.mkProjectionAttr "type" "transverse mercator"
                static member inline albersUsa = Interop.mkProjectionAttr "type" "albers usa"
                static member inline winkelTripel = Interop.mkProjectionAttr "type" "winkel tripel"
                static member inline aitoff = Interop.mkProjectionAttr "type" "aitoff"
                static member inline sinusoidal = Interop.mkProjectionAttr "type" "sinusoidal"

            [<Erase>]
            type rotation =
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: int) = Interop.mkRotationAttr "lon" value
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: float) = Interop.mkRotationAttr "lon" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: int) = Interop.mkRotationAttr "lat" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: float) = Interop.mkRotationAttr "lat" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: int) = Interop.mkRotationAttr "roll" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: float) = Interop.mkRotationAttr "roll" value

        [<Erase>]
        type center =
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: int) = Interop.mkCenterAttr "lon" value
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: float) = Interop.mkCenterAttr "lon" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: int) = Interop.mkCenterAttr "lat" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: float) = Interop.mkCenterAttr "lat" value

        [<Erase>]
        type lonaxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLonaxisAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLonaxisAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLonaxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLonaxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLonaxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLonaxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLonaxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLonaxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLonaxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLonaxisAttr "gridwidth" value

        [<Erase>]
        type lataxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLataxisAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLataxisAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLataxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLataxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLataxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLataxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLataxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLataxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLataxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLataxisAttr "gridwidth" value

    [<Erase>]
    type mapbox =
        /// Sets the mapbox access token to be used for this mapbox map. Alternatively, the mapbox access token can be set in the configuration options under `mapboxAccessToken`. Note that accessToken are only required when `style` (e.g with values : basic, streets, outdoors, light, dark, satellite, satellite-streets ) and/or a layout layer references the Mapbox server.
        static member inline accesstoken (value: string) = Interop.mkMapboxAttr "accesstoken" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: bool) = Interop.mkMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<bool>) = Interop.mkMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: string) = Interop.mkMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<string>) = Interop.mkMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: int) = Interop.mkMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<int>) = Interop.mkMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: float) = Interop.mkMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<float>) = Interop.mkMapboxAttr "style" values
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: int) = Interop.mkMapboxAttr "zoom" value
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: float) = Interop.mkMapboxAttr "zoom" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: int) = Interop.mkMapboxAttr "bearing" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: float) = Interop.mkMapboxAttr "bearing" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: int) = Interop.mkMapboxAttr "pitch" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: float) = Interop.mkMapboxAttr "pitch" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkMapboxAttr "uirevision" values

    module mapbox =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this mapbox subplot .
            static member inline row (value: int) = Interop.mkDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this mapbox subplot .
            static member inline column (value: int) = Interop.mkDomainAttr "column" value

        [<Erase>]
        type center =
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: int) = Interop.mkCenterAttr "lon" value
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: float) = Interop.mkCenterAttr "lon" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: int) = Interop.mkCenterAttr "lat" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: float) = Interop.mkCenterAttr "lat" value

    [<Erase>]
    type polar =
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<int>) = Interop.mkPolarAttr "sector" values
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<float>) = Interop.mkPolarAttr "sector" values
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: int) = Interop.mkPolarAttr "hole" value
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: float) = Interop.mkPolarAttr "hole" value
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkPolarAttr "bgcolor" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkPolarAttr "uirevision" values

    module polar =
        /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
        [<Erase>]
        type gridshape =
            static member inline circular = Interop.mkPolarAttr "gridshape" "circular"
            static member inline linear = Interop.mkPolarAttr "gridshape" "linear"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" values
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this polar subplot .
            static member inline row (value: int) = Interop.mkDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this polar subplot .
            static member inline column (value: int) = Interop.mkDomainAttr "column" value

        [<Erase>]
        type radialaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkRadialaxisAttr "visible" value
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkRadialaxisAttr "range" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkRadialaxisAttr "categoryarray" values
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: int) = Interop.mkRadialaxisAttr "angle" value
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: float) = Interop.mkRadialaxisAttr "angle" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkRadialaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkRadialaxisAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkRadialaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkRadialaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkRadialaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkRadialaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkRadialaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkRadialaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkRadialaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkRadialaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkRadialaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkRadialaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkRadialaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkRadialaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkRadialaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkRadialaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkRadialaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkRadialaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkRadialaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkRadialaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkRadialaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkRadialaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkRadialaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkRadialaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkRadialaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkRadialaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkRadialaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkRadialaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkRadialaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkRadialaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkRadialaxisAttr "ticktextsrc" value

        module radialaxis =
            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkRadialaxisAttr "type" "-"
                static member inline linear = Interop.mkRadialaxisAttr "type" "linear"
                static member inline log = Interop.mkRadialaxisAttr "type" "log"
                static member inline date = Interop.mkRadialaxisAttr "type" "date"
                static member inline category = Interop.mkRadialaxisAttr "type" "category"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline true' = Interop.mkRadialaxisAttr "autorange" true
                static member inline false' = Interop.mkRadialaxisAttr "autorange" false
                static member inline reversed = Interop.mkRadialaxisAttr "autorange" "reversed"

            /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
            [<Erase>]
            type rangemode =
                static member inline tozero = Interop.mkRadialaxisAttr "rangemode" "tozero"
                static member inline nonnegative = Interop.mkRadialaxisAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkRadialaxisAttr "rangemode" "normal"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkRadialaxisAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkRadialaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkRadialaxisAttr "categoryorder" "category descending"
                static member inline array = Interop.mkRadialaxisAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkRadialaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkRadialaxisAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkRadialaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkRadialaxisAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkRadialaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkRadialaxisAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkRadialaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkRadialaxisAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkRadialaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkRadialaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkRadialaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkRadialaxisAttr "categoryorder" "median descending"

            /// Determines on which side of radial axis line the tick and tick labels appear.
            [<Erase>]
            type side =
                static member inline clockwise = Interop.mkRadialaxisAttr "side" "clockwise"
                static member inline counterclockwise = Interop.mkRadialaxisAttr "side" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkRadialaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkRadialaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkRadialaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkRadialaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkRadialaxisAttr "ticks" "inside"
                static member inline none = Interop.mkRadialaxisAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkRadialaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkRadialaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkRadialaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkRadialaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkRadialaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkRadialaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkRadialaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkRadialaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkRadialaxisAttr "showexponent" "all"
                static member inline first = Interop.mkRadialaxisAttr "showexponent" "first"
                static member inline last = Interop.mkRadialaxisAttr "showexponent" "last"
                static member inline none = Interop.mkRadialaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkRadialaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkRadialaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkRadialaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkRadialaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkRadialaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkRadialaxisAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkRadialaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkRadialaxisAttr "layer" "below traces"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline gregorian = Interop.mkRadialaxisAttr "calendar" "gregorian"
                static member inline chinese = Interop.mkRadialaxisAttr "calendar" "chinese"
                static member inline coptic = Interop.mkRadialaxisAttr "calendar" "coptic"
                static member inline discworld = Interop.mkRadialaxisAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkRadialaxisAttr "calendar" "ethiopian"
                static member inline hebrew = Interop.mkRadialaxisAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkRadialaxisAttr "calendar" "islamic"
                static member inline julian = Interop.mkRadialaxisAttr "calendar" "julian"
                static member inline mayan = Interop.mkRadialaxisAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkRadialaxisAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkRadialaxisAttr "calendar" "nepali"
                static member inline persian = Interop.mkRadialaxisAttr "calendar" "persian"
                static member inline jalali = Interop.mkRadialaxisAttr "calendar" "jalali"
                static member inline taiwan = Interop.mkRadialaxisAttr "calendar" "taiwan"
                static member inline thai = Interop.mkRadialaxisAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkRadialaxisAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

        [<Erase>]
        type angularaxis =
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkAngularaxisAttr "visible" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkAngularaxisAttr "categoryarray" values
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: int) = Interop.mkAngularaxisAttr "period" value
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: float) = Interop.mkAngularaxisAttr "period" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: int) = Interop.mkAngularaxisAttr "rotation" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: float) = Interop.mkAngularaxisAttr "rotation" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkAngularaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkAngularaxisAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkAngularaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkAngularaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkAngularaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkAngularaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkAngularaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkAngularaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkAngularaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkAngularaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkAngularaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkAngularaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkAngularaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkAngularaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkAngularaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkAngularaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkAngularaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkAngularaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkAngularaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkAngularaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkAngularaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkAngularaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkAngularaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkAngularaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkAngularaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkAngularaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkAngularaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkAngularaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkAngularaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkAngularaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkAngularaxisAttr "ticktextsrc" value

        module angularaxis =
            /// Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkAngularaxisAttr "type" "-"
                static member inline linear = Interop.mkAngularaxisAttr "type" "linear"
                static member inline category = Interop.mkAngularaxisAttr "type" "category"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline trace = Interop.mkAngularaxisAttr "categoryorder" "trace"
                static member inline categoryAscending = Interop.mkAngularaxisAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkAngularaxisAttr "categoryorder" "category descending"
                static member inline array = Interop.mkAngularaxisAttr "categoryorder" "array"
                static member inline totalAscending = Interop.mkAngularaxisAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkAngularaxisAttr "categoryorder" "total descending"
                static member inline minAscending = Interop.mkAngularaxisAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkAngularaxisAttr "categoryorder" "min descending"
                static member inline maxAscending = Interop.mkAngularaxisAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkAngularaxisAttr "categoryorder" "max descending"
                static member inline sumAscending = Interop.mkAngularaxisAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkAngularaxisAttr "categoryorder" "sum descending"
                static member inline meanAscending = Interop.mkAngularaxisAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkAngularaxisAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkAngularaxisAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkAngularaxisAttr "categoryorder" "median descending"

            /// Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
            [<Erase>]
            type thetaunit =
                static member inline radians = Interop.mkAngularaxisAttr "thetaunit" "radians"
                static member inline degrees = Interop.mkAngularaxisAttr "thetaunit" "degrees"

            /// Sets the direction corresponding to positive angles.
            [<Erase>]
            type direction =
                static member inline counterclockwise = Interop.mkAngularaxisAttr "direction" "counterclockwise"
                static member inline clockwise = Interop.mkAngularaxisAttr "direction" "clockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkAngularaxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkAngularaxisAttr "tickmode" "linear"
                static member inline array = Interop.mkAngularaxisAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkAngularaxisAttr "ticks" "outside"
                static member inline inside = Interop.mkAngularaxisAttr "ticks" "inside"
                static member inline none = Interop.mkAngularaxisAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkAngularaxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkAngularaxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkAngularaxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkAngularaxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkAngularaxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkAngularaxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkAngularaxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkAngularaxisAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkAngularaxisAttr "showexponent" "all"
                static member inline first = Interop.mkAngularaxisAttr "showexponent" "first"
                static member inline last = Interop.mkAngularaxisAttr "showexponent" "last"
                static member inline none = Interop.mkAngularaxisAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkAngularaxisAttr "exponentformat" "none"
                static member inline e = Interop.mkAngularaxisAttr "exponentformat" "e"
                static member inline E = Interop.mkAngularaxisAttr "exponentformat" "E"
                static member inline power = Interop.mkAngularaxisAttr "exponentformat" "power"
                static member inline SI = Interop.mkAngularaxisAttr "exponentformat" "SI"
                static member inline B = Interop.mkAngularaxisAttr "exponentformat" "B"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkAngularaxisAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkAngularaxisAttr "layer" "below traces"

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

    [<Erase>]
    type radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<int>) = Interop.mkRadialaxisAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<float>) = Interop.mkRadialaxisAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkRadialaxisAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkRadialaxisAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: int) = Interop.mkRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: float) = Interop.mkRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this radial axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkRadialaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the radial axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkRadialaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: int) = Interop.mkRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: float) = Interop.mkRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this radial axis.
        static member inline tickcolor (value: string) = Interop.mkRadialaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticksuffix (value: string) = Interop.mkRadialaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkRadialaxisAttr "visible" value

    module radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the radial axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkRadialaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkRadialaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<int>) = Interop.mkAngularaxisAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<float>) = Interop.mkAngularaxisAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkAngularaxisAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkAngularaxisAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this angular axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkAngularaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the angular axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkAngularaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: int) = Interop.mkAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: float) = Interop.mkAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this angular axis.
        static member inline tickcolor (value: string) = Interop.mkAngularaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticksuffix (value: string) = Interop.mkAngularaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkAngularaxisAttr "visible" value

    module angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the angular axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkAngularaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkAngularaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type legend =
        /// Sets the legend background color.
        static member inline bgcolor (value: string) = Interop.mkLegendAttr "bgcolor" value
        /// Sets the color of the border enclosing the legend.
        static member inline bordercolor (value: string) = Interop.mkLegendAttr "bordercolor" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: int) = Interop.mkLegendAttr "borderwidth" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: float) = Interop.mkLegendAttr "borderwidth" value
        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        static member inline traceorder (values: seq<string>) = Interop.mkLegendAttr "traceorder" values
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: int) = Interop.mkLegendAttr "tracegroupgap" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: float) = Interop.mkLegendAttr "tracegroupgap" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: int) = Interop.mkLegendAttr "x" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: float) = Interop.mkLegendAttr "x" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: int) = Interop.mkLegendAttr "y" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: float) = Interop.mkLegendAttr "y" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLegendAttr "uirevision" values

    module legend =
        /// Sets the orientation of the legend.
        [<Erase>]
        type orientation =
            static member inline v = Interop.mkLegendAttr "orientation" "v"
            static member inline h = Interop.mkLegendAttr "orientation" "h"

        /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
        [<Erase>]
        type itemsizing =
            static member inline trace = Interop.mkLegendAttr "itemsizing" "trace"
            static member inline constant = Interop.mkLegendAttr "itemsizing" "constant"

        /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
        [<Erase>]
        type itemclick =
            static member inline toggle = Interop.mkLegendAttr "itemclick" "toggle"
            static member inline toggleothers = Interop.mkLegendAttr "itemclick" "toggleothers"
            static member inline false' = Interop.mkLegendAttr "itemclick" false

        /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
        [<Erase>]
        type itemdoubleclick =
            static member inline toggle = Interop.mkLegendAttr "itemdoubleclick" "toggle"
            static member inline toggleothers = Interop.mkLegendAttr "itemdoubleclick" "toggleothers"
            static member inline false' = Interop.mkLegendAttr "itemdoubleclick" false

        /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkLegendAttr "xanchor" "auto"
            static member inline left = Interop.mkLegendAttr "xanchor" "left"
            static member inline center = Interop.mkLegendAttr "xanchor" "center"
            static member inline right = Interop.mkLegendAttr "xanchor" "right"

        /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkLegendAttr "yanchor" "auto"
            static member inline top = Interop.mkLegendAttr "yanchor" "top"
            static member inline middle = Interop.mkLegendAttr "yanchor" "middle"
            static member inline bottom = Interop.mkLegendAttr "yanchor" "bottom"

        /// Sets the vertical alignment of the symbols with respect to their associated text.
        [<Erase>]
        type valign =
            static member inline top = Interop.mkLegendAttr "valign" "top"
            static member inline middle = Interop.mkLegendAttr "valign" "middle"
            static member inline bottom = Interop.mkLegendAttr "valign" "bottom"

        [<Erase>]
        type font =
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkFontAttr "family" value
            static member inline size (value: int) = Interop.mkFontAttr "size" value
            static member inline size (value: float) = Interop.mkFontAttr "size" value
            static member inline color (value: string) = Interop.mkFontAttr "color" value

    [<Erase>]
    type colorscale =
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequential (values: seq<string>) = Interop.mkColorscaleAttr "sequential" values
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequentialminus (values: seq<string>) = Interop.mkColorscaleAttr "sequentialminus" values
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        static member inline diverging (values: seq<string>) = Interop.mkColorscaleAttr "diverging" values

    [<Erase>]
    type coloraxis =
        /// Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        static member inline cauto (value: bool) = Interop.mkColoraxisAttr "cauto" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: int) = Interop.mkColoraxisAttr "cmin" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: float) = Interop.mkColoraxisAttr "cmin" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: int) = Interop.mkColoraxisAttr "cmax" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: float) = Interop.mkColoraxisAttr "cmax" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: int) = Interop.mkColoraxisAttr "cmid" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: float) = Interop.mkColoraxisAttr "cmid" value
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        static member inline colorscale (values: seq<string>) = Interop.mkColoraxisAttr "colorscale" values
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        static member inline autocolorscale (value: bool) = Interop.mkColoraxisAttr "autocolorscale" value
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        static member inline reversescale (value: bool) = Interop.mkColoraxisAttr "reversescale" value
        /// Determines whether or not a colorbar is displayed for this trace.
        static member inline showscale (value: bool) = Interop.mkColoraxisAttr "showscale" value

    module coloraxis =
        [<Erase>]
        type colorbar =
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: int) = Interop.mkColorbarAttr "thickness" value
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: float) = Interop.mkColorbarAttr "thickness" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: int) = Interop.mkColorbarAttr "len" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: float) = Interop.mkColorbarAttr "len" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: int) = Interop.mkColorbarAttr "x" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: float) = Interop.mkColorbarAttr "x" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: int) = Interop.mkColorbarAttr "xpad" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: float) = Interop.mkColorbarAttr "xpad" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: int) = Interop.mkColorbarAttr "y" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: float) = Interop.mkColorbarAttr "y" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: int) = Interop.mkColorbarAttr "ypad" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: float) = Interop.mkColorbarAttr "ypad" value
            /// Sets the axis line color.
            static member inline outlinecolor (value: string) = Interop.mkColorbarAttr "outlinecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: int) = Interop.mkColorbarAttr "outlinewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: float) = Interop.mkColorbarAttr "outlinewidth" value
            /// Sets the axis line color.
            static member inline bordercolor (value: string) = Interop.mkColorbarAttr "bordercolor" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: int) = Interop.mkColorbarAttr "borderwidth" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: float) = Interop.mkColorbarAttr "borderwidth" value
            /// Sets the color of padded area.
            static member inline bgcolor (value: string) = Interop.mkColorbarAttr "bgcolor" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkColorbarAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkColorbarAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkColorbarAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkColorbarAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkColorbarAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkColorbarAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkColorbarAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkColorbarAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkColorbarAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkColorbarAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkColorbarAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkColorbarAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkColorbarAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkColorbarAttr "tickformat" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkColorbarAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkColorbarAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkColorbarAttr "separatethousands" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkColorbarAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkColorbarAttr "ticktextsrc" value

        module colorbar =
            /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
            [<Erase>]
            type thicknessmode =
                static member inline fraction = Interop.mkColorbarAttr "thicknessmode" "fraction"
                static member inline pixels = Interop.mkColorbarAttr "thicknessmode" "pixels"

            /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
            [<Erase>]
            type lenmode =
                static member inline fraction = Interop.mkColorbarAttr "lenmode" "fraction"
                static member inline pixels = Interop.mkColorbarAttr "lenmode" "pixels"

            /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
            [<Erase>]
            type xanchor =
                static member inline left = Interop.mkColorbarAttr "xanchor" "left"
                static member inline center = Interop.mkColorbarAttr "xanchor" "center"
                static member inline right = Interop.mkColorbarAttr "xanchor" "right"

            /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
            [<Erase>]
            type yanchor =
                static member inline top = Interop.mkColorbarAttr "yanchor" "top"
                static member inline middle = Interop.mkColorbarAttr "yanchor" "middle"
                static member inline bottom = Interop.mkColorbarAttr "yanchor" "bottom"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline auto = Interop.mkColorbarAttr "tickmode" "auto"
                static member inline linear = Interop.mkColorbarAttr "tickmode" "linear"
                static member inline array = Interop.mkColorbarAttr "tickmode" "array"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline outside = Interop.mkColorbarAttr "ticks" "outside"
                static member inline inside = Interop.mkColorbarAttr "ticks" "inside"
                static member inline none = Interop.mkColorbarAttr "ticks" ""

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkColorbarAttr "showtickprefix" "all"
                static member inline first = Interop.mkColorbarAttr "showtickprefix" "first"
                static member inline last = Interop.mkColorbarAttr "showtickprefix" "last"
                static member inline none = Interop.mkColorbarAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkColorbarAttr "showticksuffix" "all"
                static member inline first = Interop.mkColorbarAttr "showticksuffix" "first"
                static member inline last = Interop.mkColorbarAttr "showticksuffix" "last"
                static member inline none = Interop.mkColorbarAttr "showticksuffix" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline none = Interop.mkColorbarAttr "exponentformat" "none"
                static member inline e = Interop.mkColorbarAttr "exponentformat" "e"
                static member inline E = Interop.mkColorbarAttr "exponentformat" "E"
                static member inline power = Interop.mkColorbarAttr "exponentformat" "power"
                static member inline SI = Interop.mkColorbarAttr "exponentformat" "SI"
                static member inline B = Interop.mkColorbarAttr "exponentformat" "B"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkColorbarAttr "showexponent" "all"
                static member inline first = Interop.mkColorbarAttr "showexponent" "first"
                static member inline last = Interop.mkColorbarAttr "showexponent" "last"
                static member inline none = Interop.mkColorbarAttr "showexponent" "none"

            [<Erase>]
            type tickfont =
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkTickfontAttr "color" value

            [<Erase>]
            type title =
                /// Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkTitleAttr "text" value

            module title =
                /// Determines the location of color bar's title with respect to the color bar. Note that the title's location used to be set by the now deprecated `titleside` attribute.
                [<Erase>]
                type side =
                    static member inline right = Interop.mkTitleAttr "side" "right"
                    static member inline top = Interop.mkTitleAttr "side" "top"
                    static member inline bottom = Interop.mkTitleAttr "side" "bottom"

                [<Erase>]
                type font =
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkFontAttr "family" value
                    static member inline size (value: int) = Interop.mkFontAttr "size" value
                    static member inline size (value: float) = Interop.mkFontAttr "size" value
                    static member inline color (value: string) = Interop.mkFontAttr "color" value

