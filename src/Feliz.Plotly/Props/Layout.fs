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
    static member inline font (properties: #ILayoutFontProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
    static member font (properties: (bool * ILayoutFontProperty list) list) = Interop.mkLayoutAttr "font" (properties |> Bindings.Internal.withConditionals)
    static member inline title (properties: #ILayoutTitleProperty list) = Interop.mkLayoutAttr "title" (createObj !!properties)
    static member title (properties: (bool * ILayoutTitleProperty list) list) = Interop.mkLayoutAttr "title" (properties |> Bindings.Internal.withConditionals)
    static member inline margin (properties: #ILayoutMarginProperty list) = Interop.mkLayoutAttr "margin" (createObj !!properties)
    static member margin (properties: (bool * ILayoutMarginProperty list) list) = Interop.mkLayoutAttr "margin" (properties |> Bindings.Internal.withConditionals)
    static member inline modebar (properties: #ILayoutModebarProperty list) = Interop.mkLayoutAttr "modebar" (createObj !!properties)
    static member modebar (properties: (bool * ILayoutModebarProperty list) list) = Interop.mkLayoutAttr "modebar" (properties |> Bindings.Internal.withConditionals)
    static member inline transition (properties: #ILayoutTransitionProperty list) = Interop.mkLayoutAttr "transition" (createObj !!properties)
    static member transition (properties: (bool * ILayoutTransitionProperty list) list) = Interop.mkLayoutAttr "transition" (properties |> Bindings.Internal.withConditionals)
    static member inline hoverlabel (properties: #ILayoutHoverlabelProperty list) = Interop.mkLayoutAttr "hoverlabel" (createObj !!properties)
    static member hoverlabel (properties: (bool * ILayoutHoverlabelProperty list) list) = Interop.mkLayoutAttr "hoverlabel" (properties |> Bindings.Internal.withConditionals)
    static member inline grid (properties: #ILayoutGridProperty list) = Interop.mkLayoutAttr "grid" (createObj !!properties)
    static member grid (properties: (bool * ILayoutGridProperty list) list) = Interop.mkLayoutAttr "grid" (properties |> Bindings.Internal.withConditionals)
    static member inline xaxis (properties: #ILayoutXaxisProperty list) = Interop.mkLayoutAttr "xaxis" (createObj !!properties)
    static member xaxis (properties: (bool * ILayoutXaxisProperty list) list) = Interop.mkLayoutAttr "xaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline yaxis (properties: #ILayoutYaxisProperty list) = Interop.mkLayoutAttr "yaxis" (createObj !!properties)
    static member yaxis (properties: (bool * ILayoutYaxisProperty list) list) = Interop.mkLayoutAttr "yaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline ternary (properties: #ILayoutTernaryProperty list) = Interop.mkLayoutAttr "ternary" (createObj !!properties)
    static member ternary (properties: (bool * ILayoutTernaryProperty list) list) = Interop.mkLayoutAttr "ternary" (properties |> Bindings.Internal.withConditionals)
    static member inline scene (properties: #ILayoutSceneProperty list) = Interop.mkLayoutAttr "scene" (createObj !!properties)
    static member scene (properties: (bool * ILayoutSceneProperty list) list) = Interop.mkLayoutAttr "scene" (properties |> Bindings.Internal.withConditionals)
    static member inline geo (properties: #ILayoutGeoProperty list) = Interop.mkLayoutAttr "geo" (createObj !!properties)
    static member geo (properties: (bool * ILayoutGeoProperty list) list) = Interop.mkLayoutAttr "geo" (properties |> Bindings.Internal.withConditionals)
    static member inline mapbox (properties: #ILayoutMapboxProperty list) = Interop.mkLayoutAttr "mapbox" (createObj !!properties)
    static member mapbox (properties: (bool * ILayoutMapboxProperty list) list) = Interop.mkLayoutAttr "mapbox" (properties |> Bindings.Internal.withConditionals)
    static member inline polar (properties: #ILayoutPolarProperty list) = Interop.mkLayoutAttr "polar" (createObj !!properties)
    static member polar (properties: (bool * ILayoutPolarProperty list) list) = Interop.mkLayoutAttr "polar" (properties |> Bindings.Internal.withConditionals)
    static member inline radialaxis (properties: #ILayoutRadialaxisProperty list) = Interop.mkLayoutAttr "radialaxis" (createObj !!properties)
    static member radialaxis (properties: (bool * ILayoutRadialaxisProperty list) list) = Interop.mkLayoutAttr "radialaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline angularaxis (properties: #ILayoutAngularaxisProperty list) = Interop.mkLayoutAttr "angularaxis" (createObj !!properties)
    static member angularaxis (properties: (bool * ILayoutAngularaxisProperty list) list) = Interop.mkLayoutAttr "angularaxis" (properties |> Bindings.Internal.withConditionals)
    static member inline legend (properties: #ILayoutLegendProperty list) = Interop.mkLayoutAttr "legend" (createObj !!properties)
    static member legend (properties: (bool * ILayoutLegendProperty list) list) = Interop.mkLayoutAttr "legend" (properties |> Bindings.Internal.withConditionals)
    static member inline annotations (properties: #ILayoutAnnotationsProperty list) = Interop.mkLayoutAttr "annotations" (createObj !!properties)
    static member annotations (properties: (bool * ILayoutAnnotationsProperty list) list) = Interop.mkLayoutAttr "annotations" (properties |> Bindings.Internal.withConditionals)
    static member inline shapes (properties: #ILayoutShapesProperty list) = Interop.mkLayoutAttr "shapes" (createObj !!properties)
    static member shapes (properties: (bool * ILayoutShapesProperty list) list) = Interop.mkLayoutAttr "shapes" (properties |> Bindings.Internal.withConditionals)
    static member inline images (properties: #ILayoutImagesProperty list) = Interop.mkLayoutAttr "images" (createObj !!properties)
    static member images (properties: (bool * ILayoutImagesProperty list) list) = Interop.mkLayoutAttr "images" (properties |> Bindings.Internal.withConditionals)
    static member inline updatemenus (properties: #ILayoutUpdatemenusProperty list) = Interop.mkLayoutAttr "updatemenus" (createObj !!properties)
    static member updatemenus (properties: (bool * ILayoutUpdatemenusProperty list) list) = Interop.mkLayoutAttr "updatemenus" (properties |> Bindings.Internal.withConditionals)
    static member inline sliders (properties: #ILayoutSlidersProperty list) = Interop.mkLayoutAttr "sliders" (createObj !!properties)
    static member sliders (properties: (bool * ILayoutSlidersProperty list) list) = Interop.mkLayoutAttr "sliders" (properties |> Bindings.Internal.withConditionals)
    static member inline colorscale (properties: #ILayoutColorscaleProperty list) = Interop.mkLayoutAttr "colorscale" (createObj !!properties)
    static member colorscale (properties: (bool * ILayoutColorscaleProperty list) list) = Interop.mkLayoutAttr "colorscale" (properties |> Bindings.Internal.withConditionals)
    static member inline coloraxis (properties: #ILayoutColoraxisProperty list) = Interop.mkLayoutAttr "coloraxis" (createObj !!properties)
    static member coloraxis (properties: (bool * ILayoutColoraxisProperty list) list) = Interop.mkLayoutAttr "coloraxis" (properties |> Bindings.Internal.withConditionals)
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
    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    [<Erase>]
    type clickmode =
        static member inline none = Interop.mkLayoutAttr "clickmode" "none"
        static member inline event = Interop.mkLayoutAttr "clickmode" "event"
        static member inline select = Interop.mkLayoutAttr "clickmode" "select"
        static member inline selectAndEvent = Interop.mkLayoutAttr "clickmode" "select+event"

    /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
    [<Erase>]
    type dragmode =
        static member inline lasso = Interop.mkLayoutAttr "dragmode" "lasso"
        static member inline orbit = Interop.mkLayoutAttr "dragmode" "orbit"
        static member inline pan = Interop.mkLayoutAttr "dragmode" "pan"
        static member inline select = Interop.mkLayoutAttr "dragmode" "select"
        static member inline turntable = Interop.mkLayoutAttr "dragmode" "turntable"
        static member inline zoom = Interop.mkLayoutAttr "dragmode" "zoom"
        static member inline false' = Interop.mkLayoutAttr "dragmode" "false"

    /// Determines the mode of hover interactions. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
    [<Erase>]
    type hovermode =
        static member inline closest = Interop.mkLayoutAttr "hovermode" "closest"
        static member inline x = Interop.mkLayoutAttr "hovermode" "x"
        static member inline y = Interop.mkLayoutAttr "hovermode" "y"
        static member inline false' = Interop.mkLayoutAttr "hovermode" "false"

    /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
    [<Erase>]
    type selectdirection =
        static member inline any = Interop.mkLayoutAttr "selectdirection" "any"
        static member inline d = Interop.mkLayoutAttr "selectdirection" "d"
        static member inline h = Interop.mkLayoutAttr "selectdirection" "h"
        static member inline v = Interop.mkLayoutAttr "selectdirection" "v"

    /// Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
    [<Erase>]
    type calendar =
        static member inline chinese = Interop.mkLayoutAttr "calendar" "chinese"
        static member inline coptic = Interop.mkLayoutAttr "calendar" "coptic"
        static member inline discworld = Interop.mkLayoutAttr "calendar" "discworld"
        static member inline ethiopian = Interop.mkLayoutAttr "calendar" "ethiopian"
        static member inline gregorian = Interop.mkLayoutAttr "calendar" "gregorian"
        static member inline hebrew = Interop.mkLayoutAttr "calendar" "hebrew"
        static member inline islamic = Interop.mkLayoutAttr "calendar" "islamic"
        static member inline jalali = Interop.mkLayoutAttr "calendar" "jalali"
        static member inline julian = Interop.mkLayoutAttr "calendar" "julian"
        static member inline mayan = Interop.mkLayoutAttr "calendar" "mayan"
        static member inline nanakshahi = Interop.mkLayoutAttr "calendar" "nanakshahi"
        static member inline nepali = Interop.mkLayoutAttr "calendar" "nepali"
        static member inline persian = Interop.mkLayoutAttr "calendar" "persian"
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
        static member inline description (properties: #ILayoutFontDescriptionProperty list) = Interop.mkLayoutFontAttr "description" (createObj !!properties)
        static member description (properties: (bool * ILayoutFontDescriptionProperty list) list) = Interop.mkLayoutFontAttr "description" (properties |> Bindings.Internal.withConditionals)
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        static member inline family (value: string) = Interop.mkLayoutFontAttr "family" value
        static member inline size (value: int) = Interop.mkLayoutFontAttr "size" value
        static member inline size (value: float) = Interop.mkLayoutFontAttr "size" value
        static member inline color (value: string) = Interop.mkLayoutFontAttr "color" value

    [<Erase>]
    type title =
        static member inline font (properties: #ILayoutTitleFontProperty list) = Interop.mkLayoutTitleAttr "font" (createObj !!properties)
        static member font (properties: (bool * ILayoutTitleFontProperty list) list) = Interop.mkLayoutTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
        static member inline pad (properties: #ILayoutTitlePadProperty list) = Interop.mkLayoutTitleAttr "pad" (createObj !!properties)
        static member pad (properties: (bool * ILayoutTitlePadProperty list) list) = Interop.mkLayoutTitleAttr "pad" (properties |> Bindings.Internal.withConditionals)
        /// Sets the plot's title. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
        static member inline text (value: string) = Interop.mkLayoutTitleAttr "text" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: int) = Interop.mkLayoutTitleAttr "x" value
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        static member inline x (value: float) = Interop.mkLayoutTitleAttr "x" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: int) = Interop.mkLayoutTitleAttr "y" value
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        static member inline y (value: float) = Interop.mkLayoutTitleAttr "y" value

    module title =
        /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
        [<Erase>]
        type xref =
            static member inline container = Interop.mkLayoutTitleAttr "xref" "container"
            static member inline paper = Interop.mkLayoutTitleAttr "xref" "paper"

        /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
        [<Erase>]
        type yref =
            static member inline container = Interop.mkLayoutTitleAttr "yref" "container"
            static member inline paper = Interop.mkLayoutTitleAttr "yref" "paper"

        /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkLayoutTitleAttr "xanchor" "auto"
            static member inline center = Interop.mkLayoutTitleAttr "xanchor" "center"
            static member inline left = Interop.mkLayoutTitleAttr "xanchor" "left"
            static member inline right = Interop.mkLayoutTitleAttr "xanchor" "right"

        /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkLayoutTitleAttr "yanchor" "auto"
            static member inline bottom = Interop.mkLayoutTitleAttr "yanchor" "bottom"
            static member inline middle = Interop.mkLayoutTitleAttr "yanchor" "middle"
            static member inline top = Interop.mkLayoutTitleAttr "yanchor" "top"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutTitleFontDescriptionProperty list) = Interop.mkLayoutTitleFontAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutTitleFontDescriptionProperty list) list) = Interop.mkLayoutTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutTitleFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutTitleFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutTitleFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutTitleFontAttr "color" value

        [<Erase>]
        type pad =
            static member inline description (properties: #ILayoutTitlePadDescriptionProperty list) = Interop.mkLayoutTitlePadAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutTitlePadDescriptionProperty list) list) = Interop.mkLayoutTitlePadAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: int) = Interop.mkLayoutTitlePadAttr "t" value
            /// The amount of padding (in px) along the top of the component.
            static member inline t (value: float) = Interop.mkLayoutTitlePadAttr "t" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: int) = Interop.mkLayoutTitlePadAttr "r" value
            /// The amount of padding (in px) on the right side of the component.
            static member inline r (value: float) = Interop.mkLayoutTitlePadAttr "r" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: int) = Interop.mkLayoutTitlePadAttr "b" value
            /// The amount of padding (in px) along the bottom of the component.
            static member inline b (value: float) = Interop.mkLayoutTitlePadAttr "b" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: int) = Interop.mkLayoutTitlePadAttr "l" value
            /// The amount of padding (in px) on the left side of the component.
            static member inline l (value: float) = Interop.mkLayoutTitlePadAttr "l" value

    [<Erase>]
    type margin =
        /// Sets the left margin (in px).
        static member inline l (value: int) = Interop.mkLayoutMarginAttr "l" value
        /// Sets the left margin (in px).
        static member inline l (value: float) = Interop.mkLayoutMarginAttr "l" value
        /// Sets the right margin (in px).
        static member inline r (value: int) = Interop.mkLayoutMarginAttr "r" value
        /// Sets the right margin (in px).
        static member inline r (value: float) = Interop.mkLayoutMarginAttr "r" value
        /// Sets the top margin (in px).
        static member inline t (value: int) = Interop.mkLayoutMarginAttr "t" value
        /// Sets the top margin (in px).
        static member inline t (value: float) = Interop.mkLayoutMarginAttr "t" value
        /// Sets the bottom margin (in px).
        static member inline b (value: int) = Interop.mkLayoutMarginAttr "b" value
        /// Sets the bottom margin (in px).
        static member inline b (value: float) = Interop.mkLayoutMarginAttr "b" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: int) = Interop.mkLayoutMarginAttr "pad" value
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        static member inline pad (value: float) = Interop.mkLayoutMarginAttr "pad" value
        /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
        static member inline autoexpand (value: bool) = Interop.mkLayoutMarginAttr "autoexpand" value

    [<Erase>]
    type modebar =
        /// Sets the background color of the modebar.
        static member inline bgcolor (value: string) = Interop.mkLayoutModebarAttr "bgcolor" value
        /// Sets the color of the icons in the modebar.
        static member inline color (value: string) = Interop.mkLayoutModebarAttr "color" value
        /// Sets the color of the active or hovered on icons in the modebar.
        static member inline activecolor (value: string) = Interop.mkLayoutModebarAttr "activecolor" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutModebarAttr "uirevision" values
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutModebarAttr "uirevision" value
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutModebarAttr "uirevision" values

    module modebar =
        /// Sets the orientation of the modebar.
        [<Erase>]
        type orientation =
            static member inline h = Interop.mkLayoutModebarAttr "orientation" "h"
            static member inline v = Interop.mkLayoutModebarAttr "orientation" "v"

    [<Erase>]
    type transition =
        static member inline description (properties: #ILayoutTransitionDescriptionProperty list) = Interop.mkLayoutTransitionAttr "description" (createObj !!properties)
        static member description (properties: (bool * ILayoutTransitionDescriptionProperty list) list) = Interop.mkLayoutTransitionAttr "description" (properties |> Bindings.Internal.withConditionals)
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: int) = Interop.mkLayoutTransitionAttr "duration" value
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        static member inline duration (value: float) = Interop.mkLayoutTransitionAttr "duration" value

    module transition =
        /// The easing function used for the transition
        [<Erase>]
        type easing =
            static member inline back = Interop.mkLayoutTransitionAttr "easing" "back"
            static member inline backIn = Interop.mkLayoutTransitionAttr "easing" "back-in"
            static member inline backInOut = Interop.mkLayoutTransitionAttr "easing" "back-in-out"
            static member inline backOut = Interop.mkLayoutTransitionAttr "easing" "back-out"
            static member inline bounce = Interop.mkLayoutTransitionAttr "easing" "bounce"
            static member inline bounceIn = Interop.mkLayoutTransitionAttr "easing" "bounce-in"
            static member inline bounceInOut = Interop.mkLayoutTransitionAttr "easing" "bounce-in-out"
            static member inline bounceOut = Interop.mkLayoutTransitionAttr "easing" "bounce-out"
            static member inline circle = Interop.mkLayoutTransitionAttr "easing" "circle"
            static member inline circleIn = Interop.mkLayoutTransitionAttr "easing" "circle-in"
            static member inline circleInOut = Interop.mkLayoutTransitionAttr "easing" "circle-in-out"
            static member inline circleOut = Interop.mkLayoutTransitionAttr "easing" "circle-out"
            static member inline cubic = Interop.mkLayoutTransitionAttr "easing" "cubic"
            static member inline cubicIn = Interop.mkLayoutTransitionAttr "easing" "cubic-in"
            static member inline cubicInOut = Interop.mkLayoutTransitionAttr "easing" "cubic-in-out"
            static member inline cubicOut = Interop.mkLayoutTransitionAttr "easing" "cubic-out"
            static member inline elastic = Interop.mkLayoutTransitionAttr "easing" "elastic"
            static member inline elasticIn = Interop.mkLayoutTransitionAttr "easing" "elastic-in"
            static member inline elasticInOut = Interop.mkLayoutTransitionAttr "easing" "elastic-in-out"
            static member inline elasticOut = Interop.mkLayoutTransitionAttr "easing" "elastic-out"
            static member inline exp = Interop.mkLayoutTransitionAttr "easing" "exp"
            static member inline expIn = Interop.mkLayoutTransitionAttr "easing" "exp-in"
            static member inline expInOut = Interop.mkLayoutTransitionAttr "easing" "exp-in-out"
            static member inline expOut = Interop.mkLayoutTransitionAttr "easing" "exp-out"
            static member inline linear = Interop.mkLayoutTransitionAttr "easing" "linear"
            static member inline linearIn = Interop.mkLayoutTransitionAttr "easing" "linear-in"
            static member inline linearInOut = Interop.mkLayoutTransitionAttr "easing" "linear-in-out"
            static member inline linearOut = Interop.mkLayoutTransitionAttr "easing" "linear-out"
            static member inline quad = Interop.mkLayoutTransitionAttr "easing" "quad"
            static member inline quadIn = Interop.mkLayoutTransitionAttr "easing" "quad-in"
            static member inline quadInOut = Interop.mkLayoutTransitionAttr "easing" "quad-in-out"
            static member inline quadOut = Interop.mkLayoutTransitionAttr "easing" "quad-out"
            static member inline sin = Interop.mkLayoutTransitionAttr "easing" "sin"
            static member inline sinIn = Interop.mkLayoutTransitionAttr "easing" "sin-in"
            static member inline sinInOut = Interop.mkLayoutTransitionAttr "easing" "sin-in-out"
            static member inline sinOut = Interop.mkLayoutTransitionAttr "easing" "sin-out"

        /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
        [<Erase>]
        type ordering =
            static member inline layoutFirst = Interop.mkLayoutTransitionAttr "ordering" "layout first"
            static member inline tracesFirst = Interop.mkLayoutTransitionAttr "ordering" "traces first"

    [<Erase>]
    type hoverlabel =
        static member inline font (properties: #ILayoutHoverlabelFontProperty list) = Interop.mkLayoutHoverlabelAttr "font" (createObj !!properties)
        static member font (properties: (bool * ILayoutHoverlabelFontProperty list) list) = Interop.mkLayoutHoverlabelAttr "font" (properties |> Bindings.Internal.withConditionals)
        /// Sets the background color of all hover labels on graph
        static member inline bgcolor (value: string) = Interop.mkLayoutHoverlabelAttr "bgcolor" value
        /// Sets the border color of all hover labels on graph.
        static member inline bordercolor (value: string) = Interop.mkLayoutHoverlabelAttr "bordercolor" value
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        static member inline namelength (value: int) = Interop.mkLayoutHoverlabelAttr "namelength" value

    module hoverlabel =
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        [<Erase>]
        type align =
            static member inline auto = Interop.mkLayoutHoverlabelAttr "align" "auto"
            static member inline left = Interop.mkLayoutHoverlabelAttr "align" "left"
            static member inline right = Interop.mkLayoutHoverlabelAttr "align" "right"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutHoverlabelFontDescriptionProperty list) = Interop.mkLayoutHoverlabelFontAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutHoverlabelFontDescriptionProperty list) list) = Interop.mkLayoutHoverlabelFontAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutHoverlabelFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutHoverlabelFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutHoverlabelFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutHoverlabelFontAttr "color" value

    [<Erase>]
    type grid =
        static member inline domain (properties: #ILayoutGridDomainProperty list) = Interop.mkLayoutGridAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutGridDomainProperty list) list) = Interop.mkLayoutGridAttr "domain" (properties |> Bindings.Internal.withConditionals)
        /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline rows (value: int) = Interop.mkLayoutGridAttr "rows" value
        /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        static member inline columns (value: int) = Interop.mkLayoutGridAttr "columns" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: int) = Interop.mkLayoutGridAttr "xgap" value
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        static member inline xgap (value: float) = Interop.mkLayoutGridAttr "xgap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: int) = Interop.mkLayoutGridAttr "ygap" value
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        static member inline ygap (value: float) = Interop.mkLayoutGridAttr "ygap" value

    module grid =
        /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
        [<Erase>]
        type roworder =
            static member inline bottomToTop = Interop.mkLayoutGridAttr "roworder" "bottom to top"
            static member inline topToBottom = Interop.mkLayoutGridAttr "roworder" "top to bottom"

        /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
        [<Erase>]
        type pattern =
            static member inline coupled = Interop.mkLayoutGridAttr "pattern" "coupled"
            static member inline independent = Interop.mkLayoutGridAttr "pattern" "independent"

        /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
        [<Erase>]
        type xside =
            static member inline bottomPlot = Interop.mkLayoutGridAttr "xside" "bottom plot"
            static member inline bottom = Interop.mkLayoutGridAttr "xside" "bottom"
            static member inline topPlot = Interop.mkLayoutGridAttr "xside" "top plot"
            static member inline top = Interop.mkLayoutGridAttr "xside" "top"

        /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
        [<Erase>]
        type yside =
            static member inline leftPlot = Interop.mkLayoutGridAttr "yside" "left plot"
            static member inline left = Interop.mkLayoutGridAttr "yside" "left"
            static member inline rightPlot = Interop.mkLayoutGridAttr "yside" "right plot"
            static member inline right = Interop.mkLayoutGridAttr "yside" "right"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<int>) = Interop.mkLayoutGridDomainAttr "x" values
            /// Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline x (values: seq<float>) = Interop.mkLayoutGridDomainAttr "x" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<int>) = Interop.mkLayoutGridDomainAttr "y" values
            /// Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges.
            static member inline y (values: seq<float>) = Interop.mkLayoutGridDomainAttr "y" values

    [<Erase>]
    type xaxis =
        static member inline title (properties: #ILayoutXaxisTitleProperty list) = Interop.mkLayoutXaxisAttr "title" (createObj !!properties)
        static member title (properties: (bool * ILayoutXaxisTitleProperty list) list) = Interop.mkLayoutXaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
        static member inline tickfont (properties: #ILayoutXaxisTickfontProperty list) = Interop.mkLayoutXaxisAttr "tickfont" (createObj !!properties)
        static member tickfont (properties: (bool * ILayoutXaxisTickfontProperty list) list) = Interop.mkLayoutXaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
        static member inline tickformatstops (properties: #ILayoutXaxisTickformatstopsProperty list) = Interop.mkLayoutXaxisAttr "tickformatstops" (createObj !!properties)
        static member tickformatstops (properties: (bool * ILayoutXaxisTickformatstopsProperty list) list) = Interop.mkLayoutXaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
        static member inline rangeslider (properties: #ILayoutXaxisRangesliderProperty list) = Interop.mkLayoutXaxisAttr "rangeslider" (createObj !!properties)
        static member rangeslider (properties: (bool * ILayoutXaxisRangesliderProperty list) list) = Interop.mkLayoutXaxisAttr "rangeslider" (properties |> Bindings.Internal.withConditionals)
        static member inline rangeselector (properties: #ILayoutXaxisRangeselectorProperty list) = Interop.mkLayoutXaxisAttr "rangeselector" (createObj !!properties)
        static member rangeselector (properties: (bool * ILayoutXaxisRangeselectorProperty list) list) = Interop.mkLayoutXaxisAttr "rangeselector" (properties |> Bindings.Internal.withConditionals)
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkLayoutXaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkLayoutXaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkLayoutXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkLayoutXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkLayoutXaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkLayoutXaxisAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkLayoutXaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkLayoutXaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkLayoutXaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkLayoutXaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkLayoutXaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkLayoutXaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkLayoutXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkLayoutXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkLayoutXaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkLayoutXaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkLayoutXaxisAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkLayoutXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkLayoutXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkLayoutXaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkLayoutXaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkLayoutXaxisAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkLayoutXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkLayoutXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkLayoutXaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkLayoutXaxisAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkLayoutXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkLayoutXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkLayoutXaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkLayoutXaxisAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkLayoutXaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkLayoutXaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkLayoutXaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkLayoutXaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkLayoutXaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkLayoutXaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkLayoutXaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkLayoutXaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkLayoutXaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkLayoutXaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkLayoutXaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkLayoutXaxisAttr "spikedash" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkLayoutXaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkLayoutXaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkLayoutXaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkLayoutXaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkLayoutXaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkLayoutXaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkLayoutXaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkLayoutXaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkLayoutXaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkLayoutXaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkLayoutXaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkLayoutXaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkLayoutXaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkLayoutXaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkLayoutXaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkLayoutXaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkLayoutXaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkLayoutXaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkLayoutXaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkLayoutXaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkLayoutXaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkLayoutXaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkLayoutXaxisAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkLayoutXaxisAnchorAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkLayoutXaxisOverlayingAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkLayoutXaxisAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkLayoutXaxisAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkLayoutXaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkLayoutXaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkLayoutXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkLayoutXaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkLayoutXaxisAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutXaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutXaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutXaxisAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkLayoutXaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkLayoutXaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkLayoutXaxisAttr "categoryarraysrc" value

    module xaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkLayoutXaxisAttr "type" "-"
            static member inline category = Interop.mkLayoutXaxisAttr "type" "category"
            static member inline date = Interop.mkLayoutXaxisAttr "type" "date"
            static member inline linear = Interop.mkLayoutXaxisAttr "type" "linear"
            static member inline log = Interop.mkLayoutXaxisAttr "type" "log"
            static member inline multicategory = Interop.mkLayoutXaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline reversed = Interop.mkLayoutXaxisAttr "autorange" "reversed"
            static member inline false' = Interop.mkLayoutXaxisAttr "autorange" "false"
            static member inline true' = Interop.mkLayoutXaxisAttr "autorange" "true"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline nonnegative = Interop.mkLayoutXaxisAttr "rangemode" "nonnegative"
            static member inline normal = Interop.mkLayoutXaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkLayoutXaxisAttr "rangemode" "tozero"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline domain = Interop.mkLayoutXaxisAttr "constrain" "domain"
            static member inline range = Interop.mkLayoutXaxisAttr "constrain" "range"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline bottom = Interop.mkLayoutXaxisAttr "constraintoward" "bottom"
            static member inline center = Interop.mkLayoutXaxisAttr "constraintoward" "center"
            static member inline left = Interop.mkLayoutXaxisAttr "constraintoward" "left"
            static member inline middle = Interop.mkLayoutXaxisAttr "constraintoward" "middle"
            static member inline right = Interop.mkLayoutXaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkLayoutXaxisAttr "constraintoward" "top"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline array = Interop.mkLayoutXaxisAttr "tickmode" "array"
            static member inline auto = Interop.mkLayoutXaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkLayoutXaxisAttr "tickmode" "linear"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline none = Interop.mkLayoutXaxisAttr "ticks" ""
            static member inline inside = Interop.mkLayoutXaxisAttr "ticks" "inside"
            static member inline outside = Interop.mkLayoutXaxisAttr "ticks" "outside"

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline boundaries = Interop.mkLayoutXaxisAttr "tickson" "boundaries"
            static member inline labels = Interop.mkLayoutXaxisAttr "tickson" "labels"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline all = Interop.mkLayoutXaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkLayoutXaxisAttr "mirror" "allticks"
            static member inline ticks = Interop.mkLayoutXaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkLayoutXaxisAttr "mirror" "false"
            static member inline true' = Interop.mkLayoutXaxisAttr "mirror" "true"

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        [<Erase>]
        type spikemode =
            static member inline across = Interop.mkLayoutXaxisAttr "spikemode" "across"
            static member inline acrossAndToaxis = Interop.mkLayoutXaxisAttr "spikemode" "across+toaxis"
            static member inline marker = Interop.mkLayoutXaxisAttr "spikemode" "marker"
            static member inline markerAndAcross = Interop.mkLayoutXaxisAttr "spikemode" "marker+across"
            static member inline markerAndAcrossToaxis = Interop.mkLayoutXaxisAttr "spikemode" "marker+across+toaxis"
            static member inline markerAndToaxis = Interop.mkLayoutXaxisAttr "spikemode" "marker+toaxis"
            static member inline toaxis = Interop.mkLayoutXaxisAttr "spikemode" "toaxis"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline cursor = Interop.mkLayoutXaxisAttr "spikesnap" "cursor"
            static member inline data = Interop.mkLayoutXaxisAttr "spikesnap" "data"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkLayoutXaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkLayoutXaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkLayoutXaxisAttr "showexponent" "all"
            static member inline first = Interop.mkLayoutXaxisAttr "showexponent" "first"
            static member inline last = Interop.mkLayoutXaxisAttr "showexponent" "last"
            static member inline none = Interop.mkLayoutXaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline B = Interop.mkLayoutXaxisAttr "exponentformat" "B"
            static member inline E = Interop.mkLayoutXaxisAttr "exponentformat" "E"
            static member inline SI = Interop.mkLayoutXaxisAttr "exponentformat" "SI"
            static member inline e = Interop.mkLayoutXaxisAttr "exponentformat" "e"
            static member inline none = Interop.mkLayoutXaxisAttr "exponentformat" "none"
            static member inline power = Interop.mkLayoutXaxisAttr "exponentformat" "power"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkLayoutXaxisAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline bottom = Interop.mkLayoutXaxisAttr "side" "bottom"
            static member inline left = Interop.mkLayoutXaxisAttr "side" "left"
            static member inline right = Interop.mkLayoutXaxisAttr "side" "right"
            static member inline top = Interop.mkLayoutXaxisAttr "side" "top"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkLayoutXaxisAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkLayoutXaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkLayoutXaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline array = Interop.mkLayoutXaxisAttr "categoryorder" "array"
            static member inline categoryAscending = Interop.mkLayoutXaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkLayoutXaxisAttr "categoryorder" "category descending"
            static member inline maxAscending = Interop.mkLayoutXaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkLayoutXaxisAttr "categoryorder" "max descending"
            static member inline meanAscending = Interop.mkLayoutXaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkLayoutXaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkLayoutXaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkLayoutXaxisAttr "categoryorder" "median descending"
            static member inline minAscending = Interop.mkLayoutXaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkLayoutXaxisAttr "categoryorder" "min descending"
            static member inline sumAscending = Interop.mkLayoutXaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkLayoutXaxisAttr "categoryorder" "sum descending"
            static member inline totalAscending = Interop.mkLayoutXaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkLayoutXaxisAttr "categoryorder" "total descending"
            static member inline trace = Interop.mkLayoutXaxisAttr "categoryorder" "trace"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline chinese = Interop.mkLayoutXaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkLayoutXaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkLayoutXaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkLayoutXaxisAttr "calendar" "ethiopian"
            static member inline gregorian = Interop.mkLayoutXaxisAttr "calendar" "gregorian"
            static member inline hebrew = Interop.mkLayoutXaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkLayoutXaxisAttr "calendar" "islamic"
            static member inline jalali = Interop.mkLayoutXaxisAttr "calendar" "jalali"
            static member inline julian = Interop.mkLayoutXaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkLayoutXaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkLayoutXaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkLayoutXaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkLayoutXaxisAttr "calendar" "persian"
            static member inline taiwan = Interop.mkLayoutXaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkLayoutXaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkLayoutXaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            static member inline font (properties: #ILayoutXaxisTitleFontProperty list) = Interop.mkLayoutXaxisTitleAttr "font" (createObj !!properties)
            static member font (properties: (bool * ILayoutXaxisTitleFontProperty list) list) = Interop.mkLayoutXaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkLayoutXaxisTitleAttr "text" value

        module title =
            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutXaxisTitleFontDescriptionProperty list) = Interop.mkLayoutXaxisTitleFontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutXaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutXaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutXaxisTitleFontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutXaxisTitleFontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutXaxisTitleFontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutXaxisTitleFontAttr "color" value

        [<Erase>]
        type tickfont =
            static member inline description (properties: #ILayoutXaxisTickfontDescriptionProperty list) = Interop.mkLayoutXaxisTickfontAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutXaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutXaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutXaxisTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutXaxisTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutXaxisTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutXaxisTickfontAttr "color" value

        [<Erase>]
        type rangeslider =
            static member inline yaxis (properties: #ILayoutXaxisRangesliderYaxisProperty list) = Interop.mkLayoutXaxisRangesliderAttr "yaxis" (createObj !!properties)
            static member yaxis (properties: (bool * ILayoutXaxisRangesliderYaxisProperty list) list) = Interop.mkLayoutXaxisRangesliderAttr "yaxis" (properties |> Bindings.Internal.withConditionals)
            /// Sets the background color of the range slider.
            static member inline bgcolor (value: string) = Interop.mkLayoutXaxisRangesliderAttr "bgcolor" value
            /// Sets the border color of the range slider.
            static member inline bordercolor (value: string) = Interop.mkLayoutXaxisRangesliderAttr "bordercolor" value
            /// Sets the border width of the range slider.
            static member inline borderwidth (value: int) = Interop.mkLayoutXaxisRangesliderAttr "borderwidth" value
            /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
            static member inline autorange (value: bool) = Interop.mkLayoutXaxisRangesliderAttr "autorange" value
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutXaxisRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutXaxisRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutXaxisRangesliderAttr "range" values
            /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutXaxisRangesliderAttr "range" values
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: int) = Interop.mkLayoutXaxisRangesliderAttr "thickness" value
            /// The height of the range slider as a fraction of the total plot area height.
            static member inline thickness (value: float) = Interop.mkLayoutXaxisRangesliderAttr "thickness" value
            /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
            static member inline visible (value: bool) = Interop.mkLayoutXaxisRangesliderAttr "visible" value

        module rangeslider =
            [<Erase>]
            type yaxis =
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<bool>) = Interop.mkLayoutXaxisRangesliderYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<int>) = Interop.mkLayoutXaxisRangesliderYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<float>) = Interop.mkLayoutXaxisRangesliderYaxisAttr "range" values
                /// Sets the range of this axis for the rangeslider.
                static member inline range (values: seq<string>) = Interop.mkLayoutXaxisRangesliderYaxisAttr "range" values

            module yaxis =
                /// Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used.
                [<Erase>]
                type rangemode =
                    static member inline auto = Interop.mkLayoutXaxisRangesliderAttr "rangemode" "auto"
                    static member inline fixed' = Interop.mkLayoutXaxisRangesliderAttr "rangemode" "fixed"
                    static member inline match' = Interop.mkLayoutXaxisRangesliderAttr "rangemode" "match"

        [<Erase>]
        type rangeselector =
            static member inline buttons (properties: #ILayoutXaxisRangeselectorButtonsProperty list) = Interop.mkLayoutXaxisRangeselectorAttr "buttons" (createObj !!properties)
            static member buttons (properties: (bool * ILayoutXaxisRangeselectorButtonsProperty list) list) = Interop.mkLayoutXaxisRangeselectorAttr "buttons" (properties |> Bindings.Internal.withConditionals)
            static member inline font (properties: #ILayoutXaxisRangeselectorFontProperty list) = Interop.mkLayoutXaxisRangeselectorAttr "font" (createObj !!properties)
            static member font (properties: (bool * ILayoutXaxisRangeselectorFontProperty list) list) = Interop.mkLayoutXaxisRangeselectorAttr "font" (properties |> Bindings.Internal.withConditionals)
            /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
            static member inline visible (value: bool) = Interop.mkLayoutXaxisRangeselectorAttr "visible" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "x" value
            /// Sets the x position (in normalized coordinates) of the range selector.
            static member inline x (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "x" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "y" value
            /// Sets the y position (in normalized coordinates) of the range selector.
            static member inline y (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "y" value
            /// Sets the background color of the range selector buttons.
            static member inline bgcolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "bgcolor" value
            /// Sets the background color of the active range selector button.
            static member inline activecolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "activecolor" value
            /// Sets the color of the border enclosing the range selector.
            static member inline bordercolor (value: string) = Interop.mkLayoutXaxisRangeselectorAttr "bordercolor" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: int) = Interop.mkLayoutXaxisRangeselectorAttr "borderwidth" value
            /// Sets the width (in px) of the border enclosing the range selector.
            static member inline borderwidth (value: float) = Interop.mkLayoutXaxisRangeselectorAttr "borderwidth" value

        module rangeselector =
            /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
            [<Erase>]
            type xanchor =
                static member inline auto = Interop.mkLayoutXaxisAttr "xanchor" "auto"
                static member inline center = Interop.mkLayoutXaxisAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutXaxisAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutXaxisAttr "xanchor" "right"

            /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
            [<Erase>]
            type yanchor =
                static member inline auto = Interop.mkLayoutXaxisAttr "yanchor" "auto"
                static member inline bottom = Interop.mkLayoutXaxisAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutXaxisAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutXaxisAttr "yanchor" "top"

            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutXaxisRangeselectorFontDescriptionProperty list) = Interop.mkLayoutXaxisRangeselectorFontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutXaxisRangeselectorFontDescriptionProperty list) list) = Interop.mkLayoutXaxisRangeselectorFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutXaxisRangeselectorFontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutXaxisRangeselectorFontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutXaxisRangeselectorFontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutXaxisRangeselectorFontAttr "color" value

    [<Erase>]
    type yaxis =
        static member inline title (properties: #ILayoutYaxisTitleProperty list) = Interop.mkLayoutYaxisAttr "title" (createObj !!properties)
        static member title (properties: (bool * ILayoutYaxisTitleProperty list) list) = Interop.mkLayoutYaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
        static member inline tickfont (properties: #ILayoutYaxisTickfontProperty list) = Interop.mkLayoutYaxisAttr "tickfont" (createObj !!properties)
        static member tickfont (properties: (bool * ILayoutYaxisTickfontProperty list) list) = Interop.mkLayoutYaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
        static member inline tickformatstops (properties: #ILayoutYaxisTickformatstopsProperty list) = Interop.mkLayoutYaxisAttr "tickformatstops" (createObj !!properties)
        static member tickformatstops (properties: (bool * ILayoutYaxisTickformatstopsProperty list) list) = Interop.mkLayoutYaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        static member inline visible (value: bool) = Interop.mkLayoutYaxisAttr "visible" value
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        static member inline color (value: string) = Interop.mkLayoutYaxisAttr "color" value
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<bool>) = Interop.mkLayoutYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<int>) = Interop.mkLayoutYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<float>) = Interop.mkLayoutYaxisAttr "range" values
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline range (values: seq<string>) = Interop.mkLayoutYaxisAttr "range" values
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        static member inline fixedrange (value: bool) = Interop.mkLayoutYaxisAttr "fixedrange" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        static member inline scaleanchor (value: string) = Interop.mkLayoutYaxisAttr "scaleanchor" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: int) = Interop.mkLayoutYaxisAttr "scaleratio" value
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        static member inline scaleratio (value: float) = Interop.mkLayoutYaxisAttr "scaleratio" value
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        static member inline matches (value: string) = Interop.mkLayoutYaxisAttr "matches" value
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        static member inline nticks (value: int) = Interop.mkLayoutYaxisAttr "nticks" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: bool) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<bool>) = Interop.mkLayoutYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: string) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<string>) = Interop.mkLayoutYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: int) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<int>) = Interop.mkLayoutYaxisAttr "tick0" values
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (value: float) = Interop.mkLayoutYaxisAttr "tick0" value
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        static member inline tick0 (values: seq<float>) = Interop.mkLayoutYaxisAttr "tick0" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: bool) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<bool>) = Interop.mkLayoutYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: string) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<string>) = Interop.mkLayoutYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: int) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<int>) = Interop.mkLayoutYaxisAttr "dtick" values
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (value: float) = Interop.mkLayoutYaxisAttr "dtick" value
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        static member inline dtick (values: seq<float>) = Interop.mkLayoutYaxisAttr "dtick" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<bool>) = Interop.mkLayoutYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<string>) = Interop.mkLayoutYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<int>) = Interop.mkLayoutYaxisAttr "tickvals" values
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        static member inline tickvals (values: seq<float>) = Interop.mkLayoutYaxisAttr "tickvals" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<bool>) = Interop.mkLayoutYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<string>) = Interop.mkLayoutYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<int>) = Interop.mkLayoutYaxisAttr "ticktext" values
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        static member inline ticktext (values: seq<float>) = Interop.mkLayoutYaxisAttr "ticktext" values
        /// Sets the tick length (in px).
        static member inline ticklen (value: int) = Interop.mkLayoutYaxisAttr "ticklen" value
        /// Sets the tick length (in px).
        static member inline ticklen (value: float) = Interop.mkLayoutYaxisAttr "ticklen" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: int) = Interop.mkLayoutYaxisAttr "tickwidth" value
        /// Sets the tick width (in px).
        static member inline tickwidth (value: float) = Interop.mkLayoutYaxisAttr "tickwidth" value
        /// Sets the tick color.
        static member inline tickcolor (value: string) = Interop.mkLayoutYaxisAttr "tickcolor" value
        /// Determines whether or not the tick labels are drawn.
        static member inline showticklabels (value: bool) = Interop.mkLayoutYaxisAttr "showticklabels" value
        /// Determines whether long tick labels automatically grow the figure margins.
        static member inline automargin (value: bool) = Interop.mkLayoutYaxisAttr "automargin" value
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        static member inline showspikes (value: bool) = Interop.mkLayoutYaxisAttr "showspikes" value
        /// Sets the spike color. If undefined, will use the series color
        static member inline spikecolor (value: string) = Interop.mkLayoutYaxisAttr "spikecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: int) = Interop.mkLayoutYaxisAttr "spikethickness" value
        /// Sets the width (in px) of the zero line.
        static member inline spikethickness (value: float) = Interop.mkLayoutYaxisAttr "spikethickness" value
        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        static member inline spikedash (value: string) = Interop.mkLayoutYaxisAttr "spikedash" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: int) = Interop.mkLayoutYaxisAttr "tickangle" value
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        static member inline tickangle (value: float) = Interop.mkLayoutYaxisAttr "tickangle" value
        /// Sets a tick label prefix.
        static member inline tickprefix (value: string) = Interop.mkLayoutYaxisAttr "tickprefix" value
        /// Sets a tick label suffix.
        static member inline ticksuffix (value: string) = Interop.mkLayoutYaxisAttr "ticksuffix" value
        /// If \"true\", even 4-digit integers are separated
        static member inline separatethousands (value: bool) = Interop.mkLayoutYaxisAttr "separatethousands" value
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline tickformat (value: string) = Interop.mkLayoutYaxisAttr "tickformat" value
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        static member inline hoverformat (value: string) = Interop.mkLayoutYaxisAttr "hoverformat" value
        /// Determines whether or not a line bounding this axis is drawn.
        static member inline showline (value: bool) = Interop.mkLayoutYaxisAttr "showline" value
        /// Sets the axis line color.
        static member inline linecolor (value: string) = Interop.mkLayoutYaxisAttr "linecolor" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: int) = Interop.mkLayoutYaxisAttr "linewidth" value
        /// Sets the width (in px) of the axis line.
        static member inline linewidth (value: float) = Interop.mkLayoutYaxisAttr "linewidth" value
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        static member inline showgrid (value: bool) = Interop.mkLayoutYaxisAttr "showgrid" value
        /// Sets the color of the grid lines.
        static member inline gridcolor (value: string) = Interop.mkLayoutYaxisAttr "gridcolor" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: int) = Interop.mkLayoutYaxisAttr "gridwidth" value
        /// Sets the width (in px) of the grid lines.
        static member inline gridwidth (value: float) = Interop.mkLayoutYaxisAttr "gridwidth" value
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        static member inline zeroline (value: bool) = Interop.mkLayoutYaxisAttr "zeroline" value
        /// Sets the line color of the zero line.
        static member inline zerolinecolor (value: string) = Interop.mkLayoutYaxisAttr "zerolinecolor" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: int) = Interop.mkLayoutYaxisAttr "zerolinewidth" value
        /// Sets the width (in px) of the zero line.
        static member inline zerolinewidth (value: float) = Interop.mkLayoutYaxisAttr "zerolinewidth" value
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        static member inline showdividers (value: bool) = Interop.mkLayoutYaxisAttr "showdividers" value
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        static member inline dividercolor (value: string) = Interop.mkLayoutYaxisAttr "dividercolor" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: int) = Interop.mkLayoutYaxisAttr "dividerwidth" value
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        static member inline dividerwidth (value: float) = Interop.mkLayoutYaxisAttr "dividerwidth" value
        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        static member inline anchor (value: string) = Interop.mkLayoutYaxisAnchorAttr "anchor" value
        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        static member inline overlaying (value: string) = Interop.mkLayoutYaxisOverlayingAttr "overlaying" value
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<int>) = Interop.mkLayoutYaxisAttr "domain" values
        /// Sets the domain of this axis (in plot fraction).
        static member inline domain (values: seq<float>) = Interop.mkLayoutYaxisAttr "domain" values
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: int) = Interop.mkLayoutYaxisAttr "position" value
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        static member inline position (value: float) = Interop.mkLayoutYaxisAttr "position" value
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<string>) = Interop.mkLayoutYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<int>) = Interop.mkLayoutYaxisAttr "categoryarray" values
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        static member inline categoryarray (values: seq<float>) = Interop.mkLayoutYaxisAttr "categoryarray" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutYaxisAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutYaxisAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutYaxisAttr "uirevision" values
        /// Sets the source reference on plot.ly for  tickvals .
        static member inline tickvalssrc (value: string) = Interop.mkLayoutYaxisAttr "tickvalssrc" value
        /// Sets the source reference on plot.ly for  ticktext .
        static member inline ticktextsrc (value: string) = Interop.mkLayoutYaxisAttr "ticktextsrc" value
        /// Sets the source reference on plot.ly for  categoryarray .
        static member inline categoryarraysrc (value: string) = Interop.mkLayoutYaxisAttr "categoryarraysrc" value

    module yaxis =
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        [<Erase>]
        type type' =
            static member inline dash = Interop.mkLayoutYaxisAttr "type" "-"
            static member inline category = Interop.mkLayoutYaxisAttr "type" "category"
            static member inline date = Interop.mkLayoutYaxisAttr "type" "date"
            static member inline linear = Interop.mkLayoutYaxisAttr "type" "linear"
            static member inline log = Interop.mkLayoutYaxisAttr "type" "log"
            static member inline multicategory = Interop.mkLayoutYaxisAttr "type" "multicategory"

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        [<Erase>]
        type autorange =
            static member inline reversed = Interop.mkLayoutYaxisAttr "autorange" "reversed"
            static member inline false' = Interop.mkLayoutYaxisAttr "autorange" "false"
            static member inline true' = Interop.mkLayoutYaxisAttr "autorange" "true"

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        [<Erase>]
        type rangemode =
            static member inline nonnegative = Interop.mkLayoutYaxisAttr "rangemode" "nonnegative"
            static member inline normal = Interop.mkLayoutYaxisAttr "rangemode" "normal"
            static member inline tozero = Interop.mkLayoutYaxisAttr "rangemode" "tozero"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        [<Erase>]
        type constrain =
            static member inline domain = Interop.mkLayoutYaxisAttr "constrain" "domain"
            static member inline range = Interop.mkLayoutYaxisAttr "constrain" "range"

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        [<Erase>]
        type constraintoward =
            static member inline bottom = Interop.mkLayoutYaxisAttr "constraintoward" "bottom"
            static member inline center = Interop.mkLayoutYaxisAttr "constraintoward" "center"
            static member inline left = Interop.mkLayoutYaxisAttr "constraintoward" "left"
            static member inline middle = Interop.mkLayoutYaxisAttr "constraintoward" "middle"
            static member inline right = Interop.mkLayoutYaxisAttr "constraintoward" "right"
            static member inline top = Interop.mkLayoutYaxisAttr "constraintoward" "top"

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        [<Erase>]
        type tickmode =
            static member inline array = Interop.mkLayoutYaxisAttr "tickmode" "array"
            static member inline auto = Interop.mkLayoutYaxisAttr "tickmode" "auto"
            static member inline linear = Interop.mkLayoutYaxisAttr "tickmode" "linear"

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        [<Erase>]
        type ticks =
            static member inline none = Interop.mkLayoutYaxisAttr "ticks" ""
            static member inline inside = Interop.mkLayoutYaxisAttr "ticks" "inside"
            static member inline outside = Interop.mkLayoutYaxisAttr "ticks" "outside"

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        [<Erase>]
        type tickson =
            static member inline boundaries = Interop.mkLayoutYaxisAttr "tickson" "boundaries"
            static member inline labels = Interop.mkLayoutYaxisAttr "tickson" "labels"

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        [<Erase>]
        type mirror =
            static member inline all = Interop.mkLayoutYaxisAttr "mirror" "all"
            static member inline allticks = Interop.mkLayoutYaxisAttr "mirror" "allticks"
            static member inline ticks = Interop.mkLayoutYaxisAttr "mirror" "ticks"
            static member inline false' = Interop.mkLayoutYaxisAttr "mirror" "false"
            static member inline true' = Interop.mkLayoutYaxisAttr "mirror" "true"

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        [<Erase>]
        type spikemode =
            static member inline across = Interop.mkLayoutYaxisAttr "spikemode" "across"
            static member inline acrossAndToaxis = Interop.mkLayoutYaxisAttr "spikemode" "across+toaxis"
            static member inline marker = Interop.mkLayoutYaxisAttr "spikemode" "marker"
            static member inline markerAndAcross = Interop.mkLayoutYaxisAttr "spikemode" "marker+across"
            static member inline markerAndAcrossToaxis = Interop.mkLayoutYaxisAttr "spikemode" "marker+across+toaxis"
            static member inline markerAndToaxis = Interop.mkLayoutYaxisAttr "spikemode" "marker+toaxis"
            static member inline toaxis = Interop.mkLayoutYaxisAttr "spikemode" "toaxis"

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        [<Erase>]
        type spikesnap =
            static member inline cursor = Interop.mkLayoutYaxisAttr "spikesnap" "cursor"
            static member inline data = Interop.mkLayoutYaxisAttr "spikesnap" "data"

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        [<Erase>]
        type showtickprefix =
            static member inline all = Interop.mkLayoutYaxisAttr "showtickprefix" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showtickprefix" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showtickprefix" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showtickprefix" "none"

        /// Same as `showtickprefix` but for tick suffixes.
        [<Erase>]
        type showticksuffix =
            static member inline all = Interop.mkLayoutYaxisAttr "showticksuffix" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showticksuffix" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showticksuffix" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showticksuffix" "none"

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        [<Erase>]
        type showexponent =
            static member inline all = Interop.mkLayoutYaxisAttr "showexponent" "all"
            static member inline first = Interop.mkLayoutYaxisAttr "showexponent" "first"
            static member inline last = Interop.mkLayoutYaxisAttr "showexponent" "last"
            static member inline none = Interop.mkLayoutYaxisAttr "showexponent" "none"

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        [<Erase>]
        type exponentformat =
            static member inline B = Interop.mkLayoutYaxisAttr "exponentformat" "B"
            static member inline E = Interop.mkLayoutYaxisAttr "exponentformat" "E"
            static member inline SI = Interop.mkLayoutYaxisAttr "exponentformat" "SI"
            static member inline e = Interop.mkLayoutYaxisAttr "exponentformat" "e"
            static member inline none = Interop.mkLayoutYaxisAttr "exponentformat" "none"
            static member inline power = Interop.mkLayoutYaxisAttr "exponentformat" "power"

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        [<Erase>]
        type anchor =
            static member inline free = Interop.mkLayoutYaxisAttr "anchor" "free"

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        [<Erase>]
        type side =
            static member inline bottom = Interop.mkLayoutYaxisAttr "side" "bottom"
            static member inline left = Interop.mkLayoutYaxisAttr "side" "left"
            static member inline right = Interop.mkLayoutYaxisAttr "side" "right"
            static member inline top = Interop.mkLayoutYaxisAttr "side" "top"

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        [<Erase>]
        type overlaying =
            static member inline free = Interop.mkLayoutYaxisAttr "overlaying" "free"

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        [<Erase>]
        type layer =
            static member inline aboveTraces = Interop.mkLayoutYaxisAttr "layer" "above traces"
            static member inline belowTraces = Interop.mkLayoutYaxisAttr "layer" "below traces"

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        [<Erase>]
        type categoryorder =
            static member inline array = Interop.mkLayoutYaxisAttr "categoryorder" "array"
            static member inline categoryAscending = Interop.mkLayoutYaxisAttr "categoryorder" "category ascending"
            static member inline categoryDescending = Interop.mkLayoutYaxisAttr "categoryorder" "category descending"
            static member inline maxAscending = Interop.mkLayoutYaxisAttr "categoryorder" "max ascending"
            static member inline maxDescending = Interop.mkLayoutYaxisAttr "categoryorder" "max descending"
            static member inline meanAscending = Interop.mkLayoutYaxisAttr "categoryorder" "mean ascending"
            static member inline meanDescending = Interop.mkLayoutYaxisAttr "categoryorder" "mean descending"
            static member inline medianAscending = Interop.mkLayoutYaxisAttr "categoryorder" "median ascending"
            static member inline medianDescending = Interop.mkLayoutYaxisAttr "categoryorder" "median descending"
            static member inline minAscending = Interop.mkLayoutYaxisAttr "categoryorder" "min ascending"
            static member inline minDescending = Interop.mkLayoutYaxisAttr "categoryorder" "min descending"
            static member inline sumAscending = Interop.mkLayoutYaxisAttr "categoryorder" "sum ascending"
            static member inline sumDescending = Interop.mkLayoutYaxisAttr "categoryorder" "sum descending"
            static member inline totalAscending = Interop.mkLayoutYaxisAttr "categoryorder" "total ascending"
            static member inline totalDescending = Interop.mkLayoutYaxisAttr "categoryorder" "total descending"
            static member inline trace = Interop.mkLayoutYaxisAttr "categoryorder" "trace"

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        [<Erase>]
        type calendar =
            static member inline chinese = Interop.mkLayoutYaxisAttr "calendar" "chinese"
            static member inline coptic = Interop.mkLayoutYaxisAttr "calendar" "coptic"
            static member inline discworld = Interop.mkLayoutYaxisAttr "calendar" "discworld"
            static member inline ethiopian = Interop.mkLayoutYaxisAttr "calendar" "ethiopian"
            static member inline gregorian = Interop.mkLayoutYaxisAttr "calendar" "gregorian"
            static member inline hebrew = Interop.mkLayoutYaxisAttr "calendar" "hebrew"
            static member inline islamic = Interop.mkLayoutYaxisAttr "calendar" "islamic"
            static member inline jalali = Interop.mkLayoutYaxisAttr "calendar" "jalali"
            static member inline julian = Interop.mkLayoutYaxisAttr "calendar" "julian"
            static member inline mayan = Interop.mkLayoutYaxisAttr "calendar" "mayan"
            static member inline nanakshahi = Interop.mkLayoutYaxisAttr "calendar" "nanakshahi"
            static member inline nepali = Interop.mkLayoutYaxisAttr "calendar" "nepali"
            static member inline persian = Interop.mkLayoutYaxisAttr "calendar" "persian"
            static member inline taiwan = Interop.mkLayoutYaxisAttr "calendar" "taiwan"
            static member inline thai = Interop.mkLayoutYaxisAttr "calendar" "thai"
            static member inline ummalqura = Interop.mkLayoutYaxisAttr "calendar" "ummalqura"

        [<Erase>]
        type title =
            static member inline font (properties: #ILayoutYaxisTitleFontProperty list) = Interop.mkLayoutYaxisTitleAttr "font" (createObj !!properties)
            static member font (properties: (bool * ILayoutYaxisTitleFontProperty list) list) = Interop.mkLayoutYaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
            /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
            static member inline text (value: string) = Interop.mkLayoutYaxisTitleAttr "text" value

        module title =
            [<Erase>]
            type font =
                static member inline description (properties: #ILayoutYaxisTitleFontDescriptionProperty list) = Interop.mkLayoutYaxisTitleFontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutYaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutYaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutYaxisTitleFontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutYaxisTitleFontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutYaxisTitleFontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutYaxisTitleFontAttr "color" value

        [<Erase>]
        type tickfont =
            static member inline description (properties: #ILayoutYaxisTickfontDescriptionProperty list) = Interop.mkLayoutYaxisTickfontAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutYaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutYaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutYaxisTickfontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutYaxisTickfontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutYaxisTickfontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutYaxisTickfontAttr "color" value

    [<Erase>]
    type ternary =
        static member inline domain (properties: #ILayoutTernaryDomainProperty list) = Interop.mkLayoutTernaryAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutTernaryDomainProperty list) list) = Interop.mkLayoutTernaryAttr "domain" (properties |> Bindings.Internal.withConditionals)
        static member inline aaxis (properties: #ILayoutTernaryAaxisProperty list) = Interop.mkLayoutTernaryAttr "aaxis" (createObj !!properties)
        static member aaxis (properties: (bool * ILayoutTernaryAaxisProperty list) list) = Interop.mkLayoutTernaryAttr "aaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline baxis (properties: #ILayoutTernaryBaxisProperty list) = Interop.mkLayoutTernaryAttr "baxis" (createObj !!properties)
        static member baxis (properties: (bool * ILayoutTernaryBaxisProperty list) list) = Interop.mkLayoutTernaryAttr "baxis" (properties |> Bindings.Internal.withConditionals)
        static member inline caxis (properties: #ILayoutTernaryCaxisProperty list) = Interop.mkLayoutTernaryAttr "caxis" (createObj !!properties)
        static member caxis (properties: (bool * ILayoutTernaryCaxisProperty list) list) = Interop.mkLayoutTernaryAttr "caxis" (properties |> Bindings.Internal.withConditionals)
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkLayoutTernaryAttr "bgcolor" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: int) = Interop.mkLayoutTernaryAttr "sum" value
        /// The number each triplet should sum to, and the maximum range of each axis
        static member inline sum (value: float) = Interop.mkLayoutTernaryAttr "sum" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutTernaryAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryAttr "uirevision" values

    module ternary =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutTernaryDomainAttr "x" values
            /// Sets the horizontal domain of this ternary subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutTernaryDomainAttr "x" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutTernaryDomainAttr "y" values
            /// Sets the vertical domain of this ternary subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutTernaryDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this ternary subplot .
            static member inline row (value: int) = Interop.mkLayoutTernaryDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this ternary subplot .
            static member inline column (value: int) = Interop.mkLayoutTernaryDomainAttr "column" value

        [<Erase>]
        type aaxis =
            static member inline title (properties: #ILayoutTernaryAaxisTitleProperty list) = Interop.mkLayoutTernaryAaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutTernaryAaxisTitleProperty list) list) = Interop.mkLayoutTernaryAaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutTernaryAaxisTickfontProperty list) = Interop.mkLayoutTernaryAaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutTernaryAaxisTickfontProperty list) list) = Interop.mkLayoutTernaryAaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutTernaryAaxisTickformatstopsProperty list) = Interop.mkLayoutTernaryAaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutTernaryAaxisTickformatstopsProperty list) list) = Interop.mkLayoutTernaryAaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryAaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryAaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryAaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryAaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryAaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryAaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryAaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryAaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryAaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryAaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryAaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryAaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryAaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryAaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryAaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryAaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryAaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryAaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryAaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryAaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryAaxisAttr "ticktextsrc" value

        module aaxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutTernaryAaxisTitleFontProperty list) = Interop.mkLayoutTernaryAaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutTernaryAaxisTitleFontProperty list) list) = Interop.mkLayoutTernaryAaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutTernaryAaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutTernaryAaxisTitleFontDescriptionProperty list) = Interop.mkLayoutTernaryAaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutTernaryAaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutTernaryAaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutTernaryAaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutTernaryAaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutTernaryAaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutTernaryAaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutTernaryAaxisTickfontDescriptionProperty list) = Interop.mkLayoutTernaryAaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutTernaryAaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutTernaryAaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutTernaryAaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutTernaryAaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutTernaryAaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutTernaryAaxisTickfontAttr "color" value

        [<Erase>]
        type baxis =
            static member inline title (properties: #ILayoutTernaryBaxisTitleProperty list) = Interop.mkLayoutTernaryBaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutTernaryBaxisTitleProperty list) list) = Interop.mkLayoutTernaryBaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutTernaryBaxisTickfontProperty list) = Interop.mkLayoutTernaryBaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutTernaryBaxisTickfontProperty list) list) = Interop.mkLayoutTernaryBaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutTernaryBaxisTickformatstopsProperty list) = Interop.mkLayoutTernaryBaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutTernaryBaxisTickformatstopsProperty list) list) = Interop.mkLayoutTernaryBaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryBaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryBaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryBaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryBaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryBaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryBaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryBaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryBaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryBaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryBaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryBaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryBaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryBaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryBaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryBaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryBaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryBaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryBaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryBaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryBaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryBaxisAttr "ticktextsrc" value

        module baxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutTernaryBaxisTitleFontProperty list) = Interop.mkLayoutTernaryBaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutTernaryBaxisTitleFontProperty list) list) = Interop.mkLayoutTernaryBaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutTernaryBaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutTernaryBaxisTitleFontDescriptionProperty list) = Interop.mkLayoutTernaryBaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutTernaryBaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutTernaryBaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutTernaryBaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutTernaryBaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutTernaryBaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutTernaryBaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutTernaryBaxisTickfontDescriptionProperty list) = Interop.mkLayoutTernaryBaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutTernaryBaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutTernaryBaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutTernaryBaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutTernaryBaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutTernaryBaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutTernaryBaxisTickfontAttr "color" value

        [<Erase>]
        type caxis =
            static member inline title (properties: #ILayoutTernaryCaxisTitleProperty list) = Interop.mkLayoutTernaryCaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutTernaryCaxisTitleProperty list) list) = Interop.mkLayoutTernaryCaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutTernaryCaxisTickfontProperty list) = Interop.mkLayoutTernaryCaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutTernaryCaxisTickfontProperty list) list) = Interop.mkLayoutTernaryCaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutTernaryCaxisTickformatstopsProperty list) = Interop.mkLayoutTernaryCaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutTernaryCaxisTickformatstopsProperty list) list) = Interop.mkLayoutTernaryCaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutTernaryCaxisAttr "color" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutTernaryCaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutTernaryCaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutTernaryCaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutTernaryCaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutTernaryCaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutTernaryCaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutTernaryCaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutTernaryCaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutTernaryCaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutTernaryCaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutTernaryCaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutTernaryCaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutTernaryCaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutTernaryCaxisAttr "gridwidth" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: int) = Interop.mkLayoutTernaryCaxisAttr "min" value
            /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
            static member inline min (value: float) = Interop.mkLayoutTernaryCaxisAttr "min" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutTernaryCaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutTernaryCaxisAttr "uirevision" values
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutTernaryCaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutTernaryCaxisAttr "ticktextsrc" value

        module caxis =
            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutTernaryAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutTernaryAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutTernaryAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutTernaryAttr "ticks" ""
                static member inline inside = Interop.mkLayoutTernaryAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutTernaryAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutTernaryAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutTernaryAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutTernaryAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutTernaryAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutTernaryAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutTernaryAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutTernaryAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutTernaryAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutTernaryAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutTernaryAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutTernaryAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutTernaryAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutTernaryAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutTernaryAttr "layer" "below traces"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutTernaryCaxisTitleFontProperty list) = Interop.mkLayoutTernaryCaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutTernaryCaxisTitleFontProperty list) list) = Interop.mkLayoutTernaryCaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutTernaryCaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutTernaryCaxisTitleFontDescriptionProperty list) = Interop.mkLayoutTernaryCaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutTernaryCaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutTernaryCaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutTernaryCaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutTernaryCaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutTernaryCaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutTernaryCaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutTernaryCaxisTickfontDescriptionProperty list) = Interop.mkLayoutTernaryCaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutTernaryCaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutTernaryCaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutTernaryCaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutTernaryCaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutTernaryCaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutTernaryCaxisTickfontAttr "color" value

    [<Erase>]
    type scene =
        static member inline _arrayAttrRegexps (properties: #ILayoutScene_arrayAttrRegexpsProperty list) = Interop.mkLayoutSceneAttr "_arrayAttrRegexps" (createObj !!properties)
        static member _arrayAttrRegexps (properties: (bool * ILayoutScene_arrayAttrRegexpsProperty list) list) = Interop.mkLayoutSceneAttr "_arrayAttrRegexps" (properties |> Bindings.Internal.withConditionals)
        static member inline camera (properties: #ILayoutSceneCameraProperty list) = Interop.mkLayoutSceneAttr "camera" (createObj !!properties)
        static member camera (properties: (bool * ILayoutSceneCameraProperty list) list) = Interop.mkLayoutSceneAttr "camera" (properties |> Bindings.Internal.withConditionals)
        static member inline domain (properties: #ILayoutSceneDomainProperty list) = Interop.mkLayoutSceneAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutSceneDomainProperty list) list) = Interop.mkLayoutSceneAttr "domain" (properties |> Bindings.Internal.withConditionals)
        static member inline aspectratio (properties: #ILayoutSceneAspectratioProperty list) = Interop.mkLayoutSceneAttr "aspectratio" (createObj !!properties)
        static member aspectratio (properties: (bool * ILayoutSceneAspectratioProperty list) list) = Interop.mkLayoutSceneAttr "aspectratio" (properties |> Bindings.Internal.withConditionals)
        static member inline xaxis (properties: #ILayoutSceneXaxisProperty list) = Interop.mkLayoutSceneAttr "xaxis" (createObj !!properties)
        static member xaxis (properties: (bool * ILayoutSceneXaxisProperty list) list) = Interop.mkLayoutSceneAttr "xaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline yaxis (properties: #ILayoutSceneYaxisProperty list) = Interop.mkLayoutSceneAttr "yaxis" (createObj !!properties)
        static member yaxis (properties: (bool * ILayoutSceneYaxisProperty list) list) = Interop.mkLayoutSceneAttr "yaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline zaxis (properties: #ILayoutSceneZaxisProperty list) = Interop.mkLayoutSceneAttr "zaxis" (createObj !!properties)
        static member zaxis (properties: (bool * ILayoutSceneZaxisProperty list) list) = Interop.mkLayoutSceneAttr "zaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline annotations (properties: #ILayoutSceneAnnotationsProperty list) = Interop.mkLayoutSceneAttr "annotations" (createObj !!properties)
        static member annotations (properties: (bool * ILayoutSceneAnnotationsProperty list) list) = Interop.mkLayoutSceneAttr "annotations" (properties |> Bindings.Internal.withConditionals)
        static member inline bgcolor (value: string) = Interop.mkLayoutSceneAttr "bgcolor" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutSceneAttr "uirevision" values
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutSceneAttr "uirevision" value
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutSceneAttr "uirevision" values

    module scene =
        /// If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
        [<Erase>]
        type aspectmode =
            static member inline auto = Interop.mkLayoutSceneAttr "aspectmode" "auto"
            static member inline cube = Interop.mkLayoutSceneAttr "aspectmode" "cube"
            static member inline data = Interop.mkLayoutSceneAttr "aspectmode" "data"
            static member inline manual = Interop.mkLayoutSceneAttr "aspectmode" "manual"

        /// Determines the mode of drag interactions for this scene.
        [<Erase>]
        type dragmode =
            static member inline orbit = Interop.mkLayoutSceneAttr "dragmode" "orbit"
            static member inline pan = Interop.mkLayoutSceneAttr "dragmode" "pan"
            static member inline turntable = Interop.mkLayoutSceneAttr "dragmode" "turntable"
            static member inline zoom = Interop.mkLayoutSceneAttr "dragmode" "zoom"
            static member inline false' = Interop.mkLayoutSceneAttr "dragmode" "false"

        /// Determines the mode of hover interactions for this scene.
        [<Erase>]
        type hovermode =
            static member inline closest = Interop.mkLayoutSceneAttr "hovermode" "closest"
            static member inline false' = Interop.mkLayoutSceneAttr "hovermode" "false"

        [<Erase>]
        type camera = 
            static member inline up (properties: #ILayoutSceneCameraUpProperty list) = Interop.mkLayoutSceneCameraAttr "up" (createObj !!properties)
            static member up (properties: (bool * ILayoutSceneCameraUpProperty list) list) = Interop.mkLayoutSceneCameraAttr "up" (properties |> Bindings.Internal.withConditionals)
            static member inline center (properties: #ILayoutSceneCameraCenterProperty list) = Interop.mkLayoutSceneCameraAttr "center" (createObj !!properties)
            static member center (properties: (bool * ILayoutSceneCameraCenterProperty list) list) = Interop.mkLayoutSceneCameraAttr "center" (properties |> Bindings.Internal.withConditionals)
            static member inline eye (properties: #ILayoutSceneCameraEyeProperty list) = Interop.mkLayoutSceneCameraAttr "eye" (createObj !!properties)
            static member eye (properties: (bool * ILayoutSceneCameraEyeProperty list) list) = Interop.mkLayoutSceneCameraAttr "eye" (properties |> Bindings.Internal.withConditionals)
            static member inline projection (properties: #ILayoutSceneCameraProjectionProperty list) = Interop.mkLayoutSceneCameraAttr "projection" (createObj !!properties)
            static member projection (properties: (bool * ILayoutSceneCameraProjectionProperty list) list) = Interop.mkLayoutSceneCameraAttr "projection" (properties |> Bindings.Internal.withConditionals)

        module camera =
            [<Erase>]
            type up =
                static member inline description (properties: #ILayoutSceneCameraUpDescriptionProperty list) = Interop.mkLayoutSceneCameraUpAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneCameraUpDescriptionProperty list) list) = Interop.mkLayoutSceneCameraUpAttr "description" (properties |> Bindings.Internal.withConditionals)
                static member inline x (value: int) = Interop.mkLayoutSceneCameraUpAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutSceneCameraUpAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutSceneCameraUpAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutSceneCameraUpAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutSceneCameraUpAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutSceneCameraUpAttr "z" value

            [<Erase>]
            type center =
                static member inline description (properties: #ILayoutSceneCameraCenterDescriptionProperty list) = Interop.mkLayoutSceneCameraCenterAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneCameraCenterDescriptionProperty list) list) = Interop.mkLayoutSceneCameraCenterAttr "description" (properties |> Bindings.Internal.withConditionals)
                static member inline x (value: int) = Interop.mkLayoutSceneCameraCenterAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutSceneCameraCenterAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutSceneCameraCenterAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutSceneCameraCenterAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutSceneCameraCenterAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutSceneCameraCenterAttr "z" value

            [<Erase>]
            type eye =
                static member inline description (properties: #ILayoutSceneCameraEyeDescriptionProperty list) = Interop.mkLayoutSceneCameraEyeAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneCameraEyeDescriptionProperty list) list) = Interop.mkLayoutSceneCameraEyeAttr "description" (properties |> Bindings.Internal.withConditionals)
                static member inline x (value: int) = Interop.mkLayoutSceneCameraEyeAttr "x" value
                static member inline x (value: float) = Interop.mkLayoutSceneCameraEyeAttr "x" value
                static member inline y (value: int) = Interop.mkLayoutSceneCameraEyeAttr "y" value
                static member inline y (value: float) = Interop.mkLayoutSceneCameraEyeAttr "y" value
                static member inline z (value: int) = Interop.mkLayoutSceneCameraEyeAttr "z" value
                static member inline z (value: float) = Interop.mkLayoutSceneCameraEyeAttr "z" value

            module projection =
                /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
                [<Erase>]
                type type' =
                    static member inline orthographic = Interop.mkLayoutSceneCameraProjectionAttr "type" "orthographic"
                    static member inline perspective = Interop.mkLayoutSceneCameraProjectionAttr "type" "perspective"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutSceneDomainAttr "x" values
            /// Sets the horizontal domain of this scene subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutSceneDomainAttr "x" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutSceneDomainAttr "y" values
            /// Sets the vertical domain of this scene subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutSceneDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this scene subplot .
            static member inline row (value: int) = Interop.mkLayoutSceneDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this scene subplot .
            static member inline column (value: int) = Interop.mkLayoutSceneDomainAttr "column" value

        [<Erase>]
        type aspectratio =
            static member inline impliedEdits (properties: #ILayoutSceneAspectratioImpliedEditsProperty list) = Interop.mkLayoutSceneAspectratioAttr "impliedEdits" (createObj !!properties)
            static member impliedEdits (properties: (bool * ILayoutSceneAspectratioImpliedEditsProperty list) list) = Interop.mkLayoutSceneAspectratioAttr "impliedEdits" (properties |> Bindings.Internal.withConditionals)
            static member inline description (properties: #ILayoutSceneAspectratioDescriptionProperty list) = Interop.mkLayoutSceneAspectratioAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutSceneAspectratioDescriptionProperty list) list) = Interop.mkLayoutSceneAspectratioAttr "description" (properties |> Bindings.Internal.withConditionals)
            static member inline x (value: int) = Interop.mkLayoutSceneAspectratioAttr "x" value
            static member inline x (value: float) = Interop.mkLayoutSceneAspectratioAttr "x" value
            static member inline y (value: int) = Interop.mkLayoutSceneAspectratioAttr "y" value
            static member inline y (value: float) = Interop.mkLayoutSceneAspectratioAttr "y" value
            static member inline z (value: int) = Interop.mkLayoutSceneAspectratioAttr "z" value
            static member inline z (value: float) = Interop.mkLayoutSceneAspectratioAttr "z" value

        module aspectratio =
            [<Erase>]
            type impliedEdits = 
                static member inline aspectmode (properties: #ILayoutSceneAspectratioImpliedEditsAspectmodeProperty list) = Interop.mkLayoutSceneAspectratioImpliedEditsAttr "aspectmode" (createObj !!properties)
                static member aspectmode (properties: (bool * ILayoutSceneAspectratioImpliedEditsAspectmodeProperty list) list) = Interop.mkLayoutSceneAspectratioImpliedEditsAttr "aspectmode" (properties |> Bindings.Internal.withConditionals)

        [<Erase>]
        type xaxis =
            static member inline title (properties: #ILayoutSceneXaxisTitleProperty list) = Interop.mkLayoutSceneXaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutSceneXaxisTitleProperty list) list) = Interop.mkLayoutSceneXaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutSceneXaxisTickfontProperty list) = Interop.mkLayoutSceneXaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutSceneXaxisTickfontProperty list) list) = Interop.mkLayoutSceneXaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutSceneXaxisTickformatstopsProperty list) = Interop.mkLayoutSceneXaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutSceneXaxisTickformatstopsProperty list) list) = Interop.mkLayoutSceneXaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneXaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneXaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneXaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneXaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneXaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneXaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneXaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneXaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneXaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneXaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneXaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneXaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneXaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneXaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneXaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneXaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneXaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneXaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneXaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneXaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneXaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneXaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneXaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneXaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneXaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneXaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneXaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneXaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneXaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneXaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneXaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneXaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneXaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneXaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneXaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneXaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneXaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneXaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneXaxisAttr "ticktextsrc" value

        module xaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneXaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneXaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneXaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneXaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneXaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutSceneXaxisTitleFontProperty list) = Interop.mkLayoutSceneXaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutSceneXaxisTitleFontProperty list) list) = Interop.mkLayoutSceneXaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutSceneXaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutSceneXaxisTitleFontDescriptionProperty list) = Interop.mkLayoutSceneXaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutSceneXaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutSceneXaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutSceneXaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutSceneXaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutSceneXaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutSceneXaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutSceneXaxisTickfontDescriptionProperty list) = Interop.mkLayoutSceneXaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneXaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutSceneXaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutSceneXaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutSceneXaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutSceneXaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutSceneXaxisTickfontAttr "color" value

        [<Erase>]
        type yaxis =
            static member inline title (properties: #ILayoutSceneYaxisTitleProperty list) = Interop.mkLayoutSceneYaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutSceneYaxisTitleProperty list) list) = Interop.mkLayoutSceneYaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutSceneYaxisTickfontProperty list) = Interop.mkLayoutSceneYaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutSceneYaxisTickfontProperty list) list) = Interop.mkLayoutSceneYaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutSceneYaxisTickformatstopsProperty list) = Interop.mkLayoutSceneYaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutSceneYaxisTickformatstopsProperty list) list) = Interop.mkLayoutSceneYaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneYaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneYaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneYaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneYaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneYaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneYaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneYaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneYaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneYaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneYaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneYaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneYaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneYaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneYaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneYaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneYaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneYaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneYaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneYaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneYaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneYaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneYaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneYaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneYaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneYaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneYaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneYaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneYaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneYaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneYaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneYaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneYaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneYaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneYaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneYaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneYaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneYaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneYaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneYaxisAttr "ticktextsrc" value

        module yaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneYaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneYaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneYaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneYaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneYaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutSceneYaxisTitleFontProperty list) = Interop.mkLayoutSceneYaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutSceneYaxisTitleFontProperty list) list) = Interop.mkLayoutSceneYaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutSceneYaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutSceneYaxisTitleFontDescriptionProperty list) = Interop.mkLayoutSceneYaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutSceneYaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutSceneYaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutSceneYaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutSceneYaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutSceneYaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutSceneYaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutSceneYaxisTickfontDescriptionProperty list) = Interop.mkLayoutSceneYaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneYaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutSceneYaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutSceneYaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutSceneYaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutSceneYaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutSceneYaxisTickfontAttr "color" value

        [<Erase>]
        type zaxis =
            static member inline title (properties: #ILayoutSceneZaxisTitleProperty list) = Interop.mkLayoutSceneZaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutSceneZaxisTitleProperty list) list) = Interop.mkLayoutSceneZaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutSceneZaxisTickfontProperty list) = Interop.mkLayoutSceneZaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutSceneZaxisTickfontProperty list) list) = Interop.mkLayoutSceneZaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutSceneZaxisTickformatstopsProperty list) = Interop.mkLayoutSceneZaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutSceneZaxisTickformatstopsProperty list) list) = Interop.mkLayoutSceneZaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutSceneZaxisAttr "visible" value
            /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
            static member inline showspikes (value: bool) = Interop.mkLayoutSceneZaxisAttr "showspikes" value
            /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
            static member inline spikesides (value: bool) = Interop.mkLayoutSceneZaxisAttr "spikesides" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: int) = Interop.mkLayoutSceneZaxisAttr "spikethickness" value
            /// Sets the thickness (in px) of the spikes.
            static member inline spikethickness (value: float) = Interop.mkLayoutSceneZaxisAttr "spikethickness" value
            /// Sets the color of the spikes.
            static member inline spikecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "spikecolor" value
            /// Sets whether or not this axis' wall has a background color.
            static member inline showbackground (value: bool) = Interop.mkLayoutSceneZaxisAttr "showbackground" value
            /// Sets the background color of this axis' wall.
            static member inline backgroundcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "backgroundcolor" value
            /// Sets whether or not this axis is labeled
            static member inline showaxeslabels (value: bool) = Interop.mkLayoutSceneZaxisAttr "showaxeslabels" value
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutSceneZaxisAttr "color" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "categoryarray" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "range" values
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutSceneZaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutSceneZaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutSceneZaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutSceneZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutSceneZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutSceneZaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutSceneZaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutSceneZaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutSceneZaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutSceneZaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutSceneZaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutSceneZaxisAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutSceneZaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutSceneZaxisAttr "tickangle" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutSceneZaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutSceneZaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutSceneZaxisAttr "separatethousands" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutSceneZaxisAttr "tickformat" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutSceneZaxisAttr "hoverformat" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutSceneZaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutSceneZaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutSceneZaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutSceneZaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutSceneZaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutSceneZaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutSceneZaxisAttr "gridwidth" value
            /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
            static member inline zeroline (value: bool) = Interop.mkLayoutSceneZaxisAttr "zeroline" value
            /// Sets the line color of the zero line.
            static member inline zerolinecolor (value: string) = Interop.mkLayoutSceneZaxisAttr "zerolinecolor" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: int) = Interop.mkLayoutSceneZaxisAttr "zerolinewidth" value
            /// Sets the width (in px) of the zero line.
            static member inline zerolinewidth (value: float) = Interop.mkLayoutSceneZaxisAttr "zerolinewidth" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutSceneZaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutSceneZaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutSceneZaxisAttr "ticktextsrc" value

        module zaxis =
            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutSceneAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutSceneAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutSceneAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutSceneAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutSceneAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutSceneAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutSceneAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutSceneAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutSceneAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutSceneAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutSceneAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutSceneAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutSceneAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutSceneAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutSceneAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutSceneAttr "categoryorder" "trace"

            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutSceneZaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutSceneZaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutSceneZaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutSceneZaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutSceneZaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutSceneAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutSceneAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "autorange" "true"

            /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutSceneAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutSceneAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutSceneAttr "rangemode" "tozero"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutSceneAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutSceneAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutSceneAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutSceneAttr "ticks" ""
                static member inline inside = Interop.mkLayoutSceneAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutSceneAttr "ticks" "outside"

            /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
            [<Erase>]
            type mirror =
                static member inline all = Interop.mkLayoutSceneAttr "mirror" "all"
                static member inline allticks = Interop.mkLayoutSceneAttr "mirror" "allticks"
                static member inline ticks = Interop.mkLayoutSceneAttr "mirror" "ticks"
                static member inline false' = Interop.mkLayoutSceneAttr "mirror" "false"
                static member inline true' = Interop.mkLayoutSceneAttr "mirror" "true"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutSceneAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutSceneAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutSceneAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutSceneAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutSceneAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutSceneAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutSceneAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutSceneAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutSceneAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutSceneAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutSceneAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutSceneAttr "exponentformat" "power"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutSceneAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutSceneAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutSceneAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutSceneAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutSceneAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutSceneAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutSceneAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutSceneAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutSceneAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutSceneAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutSceneAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutSceneAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutSceneAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutSceneAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutSceneAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutSceneAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutSceneZaxisTitleFontProperty list) = Interop.mkLayoutSceneZaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutSceneZaxisTitleFontProperty list) list) = Interop.mkLayoutSceneZaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutSceneZaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutSceneZaxisTitleFontDescriptionProperty list) = Interop.mkLayoutSceneZaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutSceneZaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutSceneZaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutSceneZaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutSceneZaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutSceneZaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutSceneZaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutSceneZaxisTickfontDescriptionProperty list) = Interop.mkLayoutSceneZaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutSceneZaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutSceneZaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutSceneZaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutSceneZaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutSceneZaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutSceneZaxisTickfontAttr "color" value

    [<Erase>]
    type geo =
        static member inline domain (properties: #ILayoutGeoDomainProperty list) = Interop.mkLayoutGeoAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutGeoDomainProperty list) list) = Interop.mkLayoutGeoAttr "domain" (properties |> Bindings.Internal.withConditionals)
        static member inline projection (properties: #ILayoutGeoProjectionProperty list) = Interop.mkLayoutGeoAttr "projection" (createObj !!properties)
        static member projection (properties: (bool * ILayoutGeoProjectionProperty list) list) = Interop.mkLayoutGeoAttr "projection" (properties |> Bindings.Internal.withConditionals)
        static member inline center (properties: #ILayoutGeoCenterProperty list) = Interop.mkLayoutGeoAttr "center" (createObj !!properties)
        static member center (properties: (bool * ILayoutGeoCenterProperty list) list) = Interop.mkLayoutGeoAttr "center" (properties |> Bindings.Internal.withConditionals)
        static member inline lonaxis (properties: #ILayoutGeoLonaxisProperty list) = Interop.mkLayoutGeoAttr "lonaxis" (createObj !!properties)
        static member lonaxis (properties: (bool * ILayoutGeoLonaxisProperty list) list) = Interop.mkLayoutGeoAttr "lonaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline lataxis (properties: #ILayoutGeoLataxisProperty list) = Interop.mkLayoutGeoAttr "lataxis" (createObj !!properties)
        static member lataxis (properties: (bool * ILayoutGeoLataxisProperty list) list) = Interop.mkLayoutGeoAttr "lataxis" (properties |> Bindings.Internal.withConditionals)
        /// Sets whether or not the coastlines are drawn.
        static member inline showcoastlines (value: bool) = Interop.mkLayoutGeoAttr "showcoastlines" value
        /// Sets the coastline color.
        static member inline coastlinecolor (value: string) = Interop.mkLayoutGeoAttr "coastlinecolor" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: int) = Interop.mkLayoutGeoAttr "coastlinewidth" value
        /// Sets the coastline stroke width (in px).
        static member inline coastlinewidth (value: float) = Interop.mkLayoutGeoAttr "coastlinewidth" value
        /// Sets whether or not land masses are filled in color.
        static member inline showland (value: bool) = Interop.mkLayoutGeoAttr "showland" value
        /// Sets the land mass color.
        static member inline landcolor (value: string) = Interop.mkLayoutGeoAttr "landcolor" value
        /// Sets whether or not oceans are filled in color.
        static member inline showocean (value: bool) = Interop.mkLayoutGeoAttr "showocean" value
        /// Sets the ocean color
        static member inline oceancolor (value: string) = Interop.mkLayoutGeoAttr "oceancolor" value
        /// Sets whether or not lakes are drawn.
        static member inline showlakes (value: bool) = Interop.mkLayoutGeoAttr "showlakes" value
        /// Sets the color of the lakes.
        static member inline lakecolor (value: string) = Interop.mkLayoutGeoAttr "lakecolor" value
        /// Sets whether or not rivers are drawn.
        static member inline showrivers (value: bool) = Interop.mkLayoutGeoAttr "showrivers" value
        /// Sets color of the rivers.
        static member inline rivercolor (value: string) = Interop.mkLayoutGeoAttr "rivercolor" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: int) = Interop.mkLayoutGeoAttr "riverwidth" value
        /// Sets the stroke width (in px) of the rivers.
        static member inline riverwidth (value: float) = Interop.mkLayoutGeoAttr "riverwidth" value
        /// Sets whether or not country boundaries are drawn.
        static member inline showcountries (value: bool) = Interop.mkLayoutGeoAttr "showcountries" value
        /// Sets line color of the country boundaries.
        static member inline countrycolor (value: string) = Interop.mkLayoutGeoAttr "countrycolor" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: int) = Interop.mkLayoutGeoAttr "countrywidth" value
        /// Sets line width (in px) of the country boundaries.
        static member inline countrywidth (value: float) = Interop.mkLayoutGeoAttr "countrywidth" value
        /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
        static member inline showsubunits (value: bool) = Interop.mkLayoutGeoAttr "showsubunits" value
        /// Sets the color of the subunits boundaries.
        static member inline subunitcolor (value: string) = Interop.mkLayoutGeoAttr "subunitcolor" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: int) = Interop.mkLayoutGeoAttr "subunitwidth" value
        /// Sets the stroke width (in px) of the subunits boundaries.
        static member inline subunitwidth (value: float) = Interop.mkLayoutGeoAttr "subunitwidth" value
        /// Sets whether or not a frame is drawn around the map.
        static member inline showframe (value: bool) = Interop.mkLayoutGeoAttr "showframe" value
        /// Sets the color the frame.
        static member inline framecolor (value: string) = Interop.mkLayoutGeoAttr "framecolor" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: int) = Interop.mkLayoutGeoAttr "framewidth" value
        /// Sets the stroke width (in px) of the frame.
        static member inline framewidth (value: float) = Interop.mkLayoutGeoAttr "framewidth" value
        /// Set the background color of the map
        static member inline bgcolor (value: string) = Interop.mkLayoutGeoAttr "bgcolor" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutGeoAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutGeoAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutGeoAttr "uirevision" values

    module geo =
        /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
        [<Erase>]
        type resolution =
            static member inline _110 = Interop.mkLayoutGeoAttr "resolution" "110"
            static member inline _50 = Interop.mkLayoutGeoAttr "resolution" "50"

        /// Set the scope of the map.
        [<Erase>]
        type scope =
            static member inline africa = Interop.mkLayoutGeoAttr "scope" "africa"
            static member inline asia = Interop.mkLayoutGeoAttr "scope" "asia"
            static member inline europe = Interop.mkLayoutGeoAttr "scope" "europe"
            static member inline northAmerica = Interop.mkLayoutGeoAttr "scope" "north america"
            static member inline southAmerica = Interop.mkLayoutGeoAttr "scope" "south america"
            static member inline usa = Interop.mkLayoutGeoAttr "scope" "usa"
            static member inline world = Interop.mkLayoutGeoAttr "scope" "world"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<int>) = Interop.mkLayoutGeoDomainAttr "x" values
            /// Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline x (values: seq<float>) = Interop.mkLayoutGeoDomainAttr "x" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<int>) = Interop.mkLayoutGeoDomainAttr "y" values
            /// Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline y (values: seq<float>) = Interop.mkLayoutGeoDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline row (value: int) = Interop.mkLayoutGeoDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both.
            static member inline column (value: int) = Interop.mkLayoutGeoDomainAttr "column" value

        [<Erase>]
        type projection =
            static member inline rotation (properties: #ILayoutGeoProjectionRotationProperty list) = Interop.mkLayoutGeoProjectionAttr "rotation" (createObj !!properties)
            static member rotation (properties: (bool * ILayoutGeoProjectionRotationProperty list) list) = Interop.mkLayoutGeoProjectionAttr "rotation" (properties |> Bindings.Internal.withConditionals)
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<int>) = Interop.mkLayoutGeoProjectionAttr "parallels" values
            /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
            static member inline parallels (values: seq<float>) = Interop.mkLayoutGeoProjectionAttr "parallels" values
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: int) = Interop.mkLayoutGeoProjectionAttr "scale" value
            /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
            static member inline scale (value: float) = Interop.mkLayoutGeoProjectionAttr "scale" value

        module projection =
            /// Sets the projection type.
            [<Erase>]
            type type' =
                static member inline aitoff = Interop.mkLayoutGeoProjectionAttr "type" "aitoff"
                static member inline albersUsa = Interop.mkLayoutGeoProjectionAttr "type" "albers usa"
                static member inline azimuthalEqualArea = Interop.mkLayoutGeoProjectionAttr "type" "azimuthal equal area"
                static member inline azimuthalEquidistant = Interop.mkLayoutGeoProjectionAttr "type" "azimuthal equidistant"
                static member inline conicConformal = Interop.mkLayoutGeoProjectionAttr "type" "conic conformal"
                static member inline conicEqualArea = Interop.mkLayoutGeoProjectionAttr "type" "conic equal area"
                static member inline conicEquidistant = Interop.mkLayoutGeoProjectionAttr "type" "conic equidistant"
                static member inline eckert4 = Interop.mkLayoutGeoProjectionAttr "type" "eckert4"
                static member inline equirectangular = Interop.mkLayoutGeoProjectionAttr "type" "equirectangular"
                static member inline gnomonic = Interop.mkLayoutGeoProjectionAttr "type" "gnomonic"
                static member inline hammer = Interop.mkLayoutGeoProjectionAttr "type" "hammer"
                static member inline kavrayskiy7 = Interop.mkLayoutGeoProjectionAttr "type" "kavrayskiy7"
                static member inline mercator = Interop.mkLayoutGeoProjectionAttr "type" "mercator"
                static member inline miller = Interop.mkLayoutGeoProjectionAttr "type" "miller"
                static member inline mollweide = Interop.mkLayoutGeoProjectionAttr "type" "mollweide"
                static member inline naturalEarth = Interop.mkLayoutGeoProjectionAttr "type" "natural earth"
                static member inline orthographic = Interop.mkLayoutGeoProjectionAttr "type" "orthographic"
                static member inline robinson = Interop.mkLayoutGeoProjectionAttr "type" "robinson"
                static member inline sinusoidal = Interop.mkLayoutGeoProjectionAttr "type" "sinusoidal"
                static member inline stereographic = Interop.mkLayoutGeoProjectionAttr "type" "stereographic"
                static member inline transverseMercator = Interop.mkLayoutGeoProjectionAttr "type" "transverse mercator"
                static member inline winkelTripel = Interop.mkLayoutGeoProjectionAttr "type" "winkel tripel"

            [<Erase>]
            type rotation =
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: int) = Interop.mkLayoutGeoProjectionRotationAttr "lon" value
                /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
                static member inline lon (value: float) = Interop.mkLayoutGeoProjectionRotationAttr "lon" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: int) = Interop.mkLayoutGeoProjectionRotationAttr "lat" value
                /// Rotates the map along meridians (in degrees North).
                static member inline lat (value: float) = Interop.mkLayoutGeoProjectionRotationAttr "lat" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: int) = Interop.mkLayoutGeoProjectionRotationAttr "roll" value
                /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
                static member inline roll (value: float) = Interop.mkLayoutGeoProjectionRotationAttr "roll" value

        [<Erase>]
        type center =
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: int) = Interop.mkLayoutGeoCenterAttr "lon" value
            /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
            static member inline lon (value: float) = Interop.mkLayoutGeoCenterAttr "lon" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: int) = Interop.mkLayoutGeoCenterAttr "lat" value
            /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
            static member inline lat (value: float) = Interop.mkLayoutGeoCenterAttr "lat" value

        [<Erase>]
        type lonaxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLayoutGeoLonaxisAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLayoutGeoLonaxisAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLayoutGeoLonaxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLayoutGeoLonaxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLayoutGeoLonaxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLayoutGeoLonaxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLayoutGeoLonaxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLayoutGeoLonaxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLayoutGeoLonaxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLayoutGeoLonaxisAttr "gridwidth" value

        [<Erase>]
        type lataxis =
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<int>) = Interop.mkLayoutGeoLataxisAttr "range" values
            /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
            static member inline range (values: seq<float>) = Interop.mkLayoutGeoLataxisAttr "range" values
            /// Sets whether or not graticule are shown on the map.
            static member inline showgrid (value: bool) = Interop.mkLayoutGeoLataxisAttr "showgrid" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: int) = Interop.mkLayoutGeoLataxisAttr "tick0" value
            /// Sets the graticule's starting tick longitude/latitude.
            static member inline tick0 (value: float) = Interop.mkLayoutGeoLataxisAttr "tick0" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: int) = Interop.mkLayoutGeoLataxisAttr "dtick" value
            /// Sets the graticule's longitude/latitude tick step.
            static member inline dtick (value: float) = Interop.mkLayoutGeoLataxisAttr "dtick" value
            /// Sets the graticule's stroke color.
            static member inline gridcolor (value: string) = Interop.mkLayoutGeoLataxisAttr "gridcolor" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: int) = Interop.mkLayoutGeoLataxisAttr "gridwidth" value
            /// Sets the graticule's stroke width (in px).
            static member inline gridwidth (value: float) = Interop.mkLayoutGeoLataxisAttr "gridwidth" value

    [<Erase>]
    type mapbox =
        static member inline _arrayAttrRegexps (properties: #ILayoutMapbox_arrayAttrRegexpsProperty list) = Interop.mkLayoutMapboxAttr "_arrayAttrRegexps" (createObj !!properties)
        static member _arrayAttrRegexps (properties: (bool * ILayoutMapbox_arrayAttrRegexpsProperty list) list) = Interop.mkLayoutMapboxAttr "_arrayAttrRegexps" (properties |> Bindings.Internal.withConditionals)
        static member inline domain (properties: #ILayoutMapboxDomainProperty list) = Interop.mkLayoutMapboxAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutMapboxDomainProperty list) list) = Interop.mkLayoutMapboxAttr "domain" (properties |> Bindings.Internal.withConditionals)
        static member inline center (properties: #ILayoutMapboxCenterProperty list) = Interop.mkLayoutMapboxAttr "center" (createObj !!properties)
        static member center (properties: (bool * ILayoutMapboxCenterProperty list) list) = Interop.mkLayoutMapboxAttr "center" (properties |> Bindings.Internal.withConditionals)
        static member inline layers (properties: #ILayoutMapboxLayersProperty list) = Interop.mkLayoutMapboxAttr "layers" (createObj !!properties)
        static member layers (properties: (bool * ILayoutMapboxLayersProperty list) list) = Interop.mkLayoutMapboxAttr "layers" (properties |> Bindings.Internal.withConditionals)
        /// Sets the mapbox access token to be used for this mapbox map. Alternatively, the mapbox access token can be set in the configuration options under `mapboxAccessToken`. Note that accessToken are only required when `style` (e.g with values : basic, streets, outdoors, light, dark, satellite, satellite-streets ) and/or a layout layer references the Mapbox server.
        static member inline accesstoken (value: string) = Interop.mkLayoutMapboxAttr "accesstoken" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: bool) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<bool>) = Interop.mkLayoutMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: string) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<string>) = Interop.mkLayoutMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: int) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<int>) = Interop.mkLayoutMapboxAttr "style" values
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (value: float) = Interop.mkLayoutMapboxAttr "style" value
        /// Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron, carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
        static member inline style (values: seq<float>) = Interop.mkLayoutMapboxAttr "style" values
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: int) = Interop.mkLayoutMapboxAttr "zoom" value
        /// Sets the zoom level of the map (mapbox.zoom).
        static member inline zoom (value: float) = Interop.mkLayoutMapboxAttr "zoom" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: int) = Interop.mkLayoutMapboxAttr "bearing" value
        /// Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing).
        static member inline bearing (value: float) = Interop.mkLayoutMapboxAttr "bearing" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: int) = Interop.mkLayoutMapboxAttr "pitch" value
        /// Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch).
        static member inline pitch (value: float) = Interop.mkLayoutMapboxAttr "pitch" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutMapboxAttr "uirevision" values
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutMapboxAttr "uirevision" value
        /// Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutMapboxAttr "uirevision" values

    module mapbox =
        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutMapboxDomainAttr "x" values
            /// Sets the horizontal domain of this mapbox subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutMapboxDomainAttr "x" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutMapboxDomainAttr "y" values
            /// Sets the vertical domain of this mapbox subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutMapboxDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this mapbox subplot .
            static member inline row (value: int) = Interop.mkLayoutMapboxDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this mapbox subplot .
            static member inline column (value: int) = Interop.mkLayoutMapboxDomainAttr "column" value

        [<Erase>]
        type center =
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: int) = Interop.mkLayoutMapboxCenterAttr "lon" value
            /// Sets the longitude of the center of the map (in degrees East).
            static member inline lon (value: float) = Interop.mkLayoutMapboxCenterAttr "lon" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: int) = Interop.mkLayoutMapboxCenterAttr "lat" value
            /// Sets the latitude of the center of the map (in degrees North).
            static member inline lat (value: float) = Interop.mkLayoutMapboxCenterAttr "lat" value

    [<Erase>]
    type polar =
        static member inline domain (properties: #ILayoutPolarDomainProperty list) = Interop.mkLayoutPolarAttr "domain" (createObj !!properties)
        static member domain (properties: (bool * ILayoutPolarDomainProperty list) list) = Interop.mkLayoutPolarAttr "domain" (properties |> Bindings.Internal.withConditionals)
        static member inline radialaxis (properties: #ILayoutPolarRadialaxisProperty list) = Interop.mkLayoutPolarAttr "radialaxis" (createObj !!properties)
        static member radialaxis (properties: (bool * ILayoutPolarRadialaxisProperty list) list) = Interop.mkLayoutPolarAttr "radialaxis" (properties |> Bindings.Internal.withConditionals)
        static member inline angularaxis (properties: #ILayoutPolarAngularaxisProperty list) = Interop.mkLayoutPolarAttr "angularaxis" (createObj !!properties)
        static member angularaxis (properties: (bool * ILayoutPolarAngularaxisProperty list) list) = Interop.mkLayoutPolarAttr "angularaxis" (properties |> Bindings.Internal.withConditionals)
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<int>) = Interop.mkLayoutPolarAttr "sector" values
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        static member inline sector (values: seq<float>) = Interop.mkLayoutPolarAttr "sector" values
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: int) = Interop.mkLayoutPolarAttr "hole" value
        /// Sets the fraction of the radius to cut out of the polar subplot.
        static member inline hole (value: float) = Interop.mkLayoutPolarAttr "hole" value
        /// Set the background color of the subplot
        static member inline bgcolor (value: string) = Interop.mkLayoutPolarAttr "bgcolor" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarAttr "uirevision" values
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutPolarAttr "uirevision" value
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarAttr "uirevision" values

    module polar =
        /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
        [<Erase>]
        type gridshape =
            static member inline circular = Interop.mkLayoutPolarAttr "gridshape" "circular"
            static member inline linear = Interop.mkLayoutPolarAttr "gridshape" "linear"

        [<Erase>]
        type domain =
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<int>) = Interop.mkLayoutPolarDomainAttr "x" values
            /// Sets the horizontal domain of this polar subplot (in plot fraction).
            static member inline x (values: seq<float>) = Interop.mkLayoutPolarDomainAttr "x" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<int>) = Interop.mkLayoutPolarDomainAttr "y" values
            /// Sets the vertical domain of this polar subplot (in plot fraction).
            static member inline y (values: seq<float>) = Interop.mkLayoutPolarDomainAttr "y" values
            /// If there is a layout grid, use the domain for this row in the grid for this polar subplot .
            static member inline row (value: int) = Interop.mkLayoutPolarDomainAttr "row" value
            /// If there is a layout grid, use the domain for this column in the grid for this polar subplot .
            static member inline column (value: int) = Interop.mkLayoutPolarDomainAttr "column" value

        [<Erase>]
        type radialaxis =
            static member inline title (properties: #ILayoutPolarRadialaxisTitleProperty list) = Interop.mkLayoutPolarRadialaxisAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutPolarRadialaxisTitleProperty list) list) = Interop.mkLayoutPolarRadialaxisAttr "title" (properties |> Bindings.Internal.withConditionals)
            static member inline tickfont (properties: #ILayoutPolarRadialaxisTickfontProperty list) = Interop.mkLayoutPolarRadialaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutPolarRadialaxisTickfontProperty list) list) = Interop.mkLayoutPolarRadialaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutPolarRadialaxisTickformatstopsProperty list) = Interop.mkLayoutPolarRadialaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutPolarRadialaxisTickformatstopsProperty list) list) = Interop.mkLayoutPolarRadialaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "visible" value
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "range" values
            /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline range (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "range" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "categoryarray" values
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: int) = Interop.mkLayoutPolarRadialaxisAttr "angle" value
            /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
            static member inline angle (value: float) = Interop.mkLayoutPolarRadialaxisAttr "angle" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutPolarRadialaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutPolarRadialaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutPolarRadialaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutPolarRadialaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutPolarRadialaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutPolarRadialaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutPolarRadialaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutPolarRadialaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutPolarRadialaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutPolarRadialaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutPolarRadialaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutPolarRadialaxisAttr "ticktextsrc" value

        module radialaxis =
            /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutPolarRadialaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutPolarRadialaxisAttr "type" "category"
                static member inline date = Interop.mkLayoutPolarRadialaxisAttr "type" "date"
                static member inline linear = Interop.mkLayoutPolarRadialaxisAttr "type" "linear"
                static member inline log = Interop.mkLayoutPolarRadialaxisAttr "type" "log"

            /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
            [<Erase>]
            type autorange =
                static member inline reversed = Interop.mkLayoutPolarAttr "autorange" "reversed"
                static member inline false' = Interop.mkLayoutPolarAttr "autorange" "false"
                static member inline true' = Interop.mkLayoutPolarAttr "autorange" "true"

            /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
            [<Erase>]
            type rangemode =
                static member inline nonnegative = Interop.mkLayoutPolarAttr "rangemode" "nonnegative"
                static member inline normal = Interop.mkLayoutPolarAttr "rangemode" "normal"
                static member inline tozero = Interop.mkLayoutPolarAttr "rangemode" "tozero"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutPolarAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutPolarAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutPolarAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutPolarAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutPolarAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutPolarAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutPolarAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutPolarAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutPolarAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutPolarAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutPolarAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutPolarAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutPolarAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutPolarAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutPolarAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutPolarAttr "categoryorder" "trace"

            /// Determines on which side of radial axis line the tick and tick labels appear.
            [<Erase>]
            type side =
                static member inline clockwise = Interop.mkLayoutPolarAttr "side" "clockwise"
                static member inline counterclockwise = Interop.mkLayoutPolarAttr "side" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutPolarAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutPolarAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutPolarAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutPolarAttr "ticks" ""
                static member inline inside = Interop.mkLayoutPolarAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutPolarAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutPolarAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutPolarAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutPolarAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutPolarAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutPolarAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutPolarAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutPolarAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutPolarAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutPolarAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutPolarAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutPolarAttr "layer" "below traces"

            /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
            [<Erase>]
            type calendar =
                static member inline chinese = Interop.mkLayoutPolarAttr "calendar" "chinese"
                static member inline coptic = Interop.mkLayoutPolarAttr "calendar" "coptic"
                static member inline discworld = Interop.mkLayoutPolarAttr "calendar" "discworld"
                static member inline ethiopian = Interop.mkLayoutPolarAttr "calendar" "ethiopian"
                static member inline gregorian = Interop.mkLayoutPolarAttr "calendar" "gregorian"
                static member inline hebrew = Interop.mkLayoutPolarAttr "calendar" "hebrew"
                static member inline islamic = Interop.mkLayoutPolarAttr "calendar" "islamic"
                static member inline jalali = Interop.mkLayoutPolarAttr "calendar" "jalali"
                static member inline julian = Interop.mkLayoutPolarAttr "calendar" "julian"
                static member inline mayan = Interop.mkLayoutPolarAttr "calendar" "mayan"
                static member inline nanakshahi = Interop.mkLayoutPolarAttr "calendar" "nanakshahi"
                static member inline nepali = Interop.mkLayoutPolarAttr "calendar" "nepali"
                static member inline persian = Interop.mkLayoutPolarAttr "calendar" "persian"
                static member inline taiwan = Interop.mkLayoutPolarAttr "calendar" "taiwan"
                static member inline thai = Interop.mkLayoutPolarAttr "calendar" "thai"
                static member inline ummalqura = Interop.mkLayoutPolarAttr "calendar" "ummalqura"

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutPolarRadialaxisTitleFontProperty list) = Interop.mkLayoutPolarRadialaxisTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutPolarRadialaxisTitleFontProperty list) list) = Interop.mkLayoutPolarRadialaxisTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutPolarRadialaxisTitleAttr "text" value

            module title =
                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutPolarRadialaxisTitleFontDescriptionProperty list) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutPolarRadialaxisTitleFontDescriptionProperty list) list) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutPolarRadialaxisTitleFontAttr "color" value

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutPolarRadialaxisTickfontDescriptionProperty list) = Interop.mkLayoutPolarRadialaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutPolarRadialaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutPolarRadialaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutPolarRadialaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutPolarRadialaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutPolarRadialaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutPolarRadialaxisTickfontAttr "color" value

        [<Erase>]
        type angularaxis =
            static member inline tickfont (properties: #ILayoutPolarAngularaxisTickfontProperty list) = Interop.mkLayoutPolarAngularaxisAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutPolarAngularaxisTickfontProperty list) list) = Interop.mkLayoutPolarAngularaxisAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutPolarAngularaxisTickformatstopsProperty list) = Interop.mkLayoutPolarAngularaxisAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutPolarAngularaxisTickformatstopsProperty list) list) = Interop.mkLayoutPolarAngularaxisAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
            static member inline visible (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "visible" value
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" values
            /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
            static member inline categoryarray (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "categoryarray" values
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: int) = Interop.mkLayoutPolarAngularaxisAttr "period" value
            /// Set the angular period. Has an effect only when `angularaxis.type` is *category*.
            static member inline period (value: float) = Interop.mkLayoutPolarAngularaxisAttr "period" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: int) = Interop.mkLayoutPolarAngularaxisAttr "rotation" value
            /// Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),
            static member inline rotation (value: float) = Interop.mkLayoutPolarAngularaxisAttr "rotation" value
            /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline hoverformat (value: string) = Interop.mkLayoutPolarAngularaxisAttr "hoverformat" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: string) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: int) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" values
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (value: float) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" value
            /// Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`.
            static member inline uirevision (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "uirevision" values
            /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
            static member inline color (value: string) = Interop.mkLayoutPolarAngularaxisAttr "color" value
            /// Determines whether or not a line bounding this axis is drawn.
            static member inline showline (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showline" value
            /// Sets the axis line color.
            static member inline linecolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "linecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "linewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline linewidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "linewidth" value
            /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
            static member inline showgrid (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showgrid" value
            /// Sets the color of the grid lines.
            static member inline gridcolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "gridcolor" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "gridwidth" value
            /// Sets the width (in px) of the grid lines.
            static member inline gridwidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "gridwidth" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutPolarAngularaxisAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutPolarAngularaxisAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutPolarAngularaxisAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutPolarAngularaxisAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutPolarAngularaxisAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "showticklabels" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutPolarAngularaxisAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutPolarAngularaxisAttr "separatethousands" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutPolarAngularaxisAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutPolarAngularaxisAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickformat" value
            /// Sets the source reference on plot.ly for  categoryarray .
            static member inline categoryarraysrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "categoryarraysrc" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutPolarAngularaxisAttr "ticktextsrc" value

        module angularaxis =
            /// Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
            [<Erase>]
            type type' =
                static member inline dash = Interop.mkLayoutPolarAngularaxisAttr "type" "-"
                static member inline category = Interop.mkLayoutPolarAngularaxisAttr "type" "category"
                static member inline linear = Interop.mkLayoutPolarAngularaxisAttr "type" "linear"

            /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
            [<Erase>]
            type categoryorder =
                static member inline array = Interop.mkLayoutPolarAttr "categoryorder" "array"
                static member inline categoryAscending = Interop.mkLayoutPolarAttr "categoryorder" "category ascending"
                static member inline categoryDescending = Interop.mkLayoutPolarAttr "categoryorder" "category descending"
                static member inline maxAscending = Interop.mkLayoutPolarAttr "categoryorder" "max ascending"
                static member inline maxDescending = Interop.mkLayoutPolarAttr "categoryorder" "max descending"
                static member inline meanAscending = Interop.mkLayoutPolarAttr "categoryorder" "mean ascending"
                static member inline meanDescending = Interop.mkLayoutPolarAttr "categoryorder" "mean descending"
                static member inline medianAscending = Interop.mkLayoutPolarAttr "categoryorder" "median ascending"
                static member inline medianDescending = Interop.mkLayoutPolarAttr "categoryorder" "median descending"
                static member inline minAscending = Interop.mkLayoutPolarAttr "categoryorder" "min ascending"
                static member inline minDescending = Interop.mkLayoutPolarAttr "categoryorder" "min descending"
                static member inline sumAscending = Interop.mkLayoutPolarAttr "categoryorder" "sum ascending"
                static member inline sumDescending = Interop.mkLayoutPolarAttr "categoryorder" "sum descending"
                static member inline totalAscending = Interop.mkLayoutPolarAttr "categoryorder" "total ascending"
                static member inline totalDescending = Interop.mkLayoutPolarAttr "categoryorder" "total descending"
                static member inline trace = Interop.mkLayoutPolarAttr "categoryorder" "trace"

            /// Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
            [<Erase>]
            type thetaunit =
                static member inline degrees = Interop.mkLayoutPolarAttr "thetaunit" "degrees"
                static member inline radians = Interop.mkLayoutPolarAttr "thetaunit" "radians"

            /// Sets the direction corresponding to positive angles.
            [<Erase>]
            type direction =
                static member inline clockwise = Interop.mkLayoutPolarAttr "direction" "clockwise"
                static member inline counterclockwise = Interop.mkLayoutPolarAttr "direction" "counterclockwise"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutPolarAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutPolarAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutPolarAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutPolarAttr "ticks" ""
                static member inline inside = Interop.mkLayoutPolarAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutPolarAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutPolarAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutPolarAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showticksuffix" "none"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutPolarAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutPolarAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutPolarAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutPolarAttr "showexponent" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutPolarAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutPolarAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutPolarAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutPolarAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutPolarAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutPolarAttr "exponentformat" "power"

            /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
            [<Erase>]
            type layer =
                static member inline aboveTraces = Interop.mkLayoutPolarAttr "layer" "above traces"
                static member inline belowTraces = Interop.mkLayoutPolarAttr "layer" "below traces"

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutPolarAngularaxisTickfontDescriptionProperty list) = Interop.mkLayoutPolarAngularaxisTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutPolarAngularaxisTickfontDescriptionProperty list) list) = Interop.mkLayoutPolarAngularaxisTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutPolarAngularaxisTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutPolarAngularaxisTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutPolarAngularaxisTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutPolarAngularaxisTickfontAttr "color" value

    [<Erase>]
    type radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<int>) = Interop.mkLayoutRadialaxisAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this radial axis.
        static member inline range (values: seq<float>) = Interop.mkLayoutRadialaxisAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkLayoutRadialaxisAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkLayoutRadialaxisAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: int) = Interop.mkLayoutRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (an angle with respect to the origin) of the radial axis.
        static member inline orientation (value: float) = Interop.mkLayoutRadialaxisAttr "orientation" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this radial axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkLayoutRadialaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the radial axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkLayoutRadialaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: int) = Interop.mkLayoutRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticklen (value: float) = Interop.mkLayoutRadialaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this radial axis.
        static member inline tickcolor (value: string) = Interop.mkLayoutRadialaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this radial axis.
        static member inline ticksuffix (value: string) = Interop.mkLayoutRadialaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkLayoutRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkLayoutRadialaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkLayoutRadialaxisAttr "visible" value

    module radialaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the radial axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkLayoutRadialaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkLayoutRadialaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<int>) = Interop.mkLayoutAngularaxisAttr "range" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Defines the start and end point of this angular axis.
        static member inline range (values: seq<float>) = Interop.mkLayoutAngularaxisAttr "range" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<int>) = Interop.mkLayoutAngularaxisAttr "domain" values
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        static member inline domain (values: seq<float>) = Interop.mkLayoutAngularaxisAttr "domain" values
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the line bounding this angular axis will be shown on the figure.
        static member inline showline (value: bool) = Interop.mkLayoutAngularaxisAttr "showline" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not the angular axis ticks will feature tick labels.
        static member inline showticklabels (value: bool) = Interop.mkLayoutAngularaxisAttr "showticklabels" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: int) = Interop.mkLayoutAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticklen (value: float) = Interop.mkLayoutAngularaxisAttr "ticklen" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the color of the tick lines on this angular axis.
        static member inline tickcolor (value: string) = Interop.mkLayoutAngularaxisAttr "tickcolor" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the length of the tick lines on this angular axis.
        static member inline ticksuffix (value: string) = Interop.mkLayoutAngularaxisAttr "ticksuffix" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: int) = Interop.mkLayoutAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots.
        static member inline endpadding (value: float) = Interop.mkLayoutAngularaxisAttr "endpadding" value
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Determines whether or not this axis will be visible.
        static member inline visible (value: bool) = Interop.mkLayoutAngularaxisAttr "visible" value

    module angularaxis =
        /// Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets the orientation (from the paper perspective) of the angular axis tick labels.
        [<Erase>]
        type tickorientation =
            static member inline horizontal = Interop.mkLayoutAngularaxisAttr "tickorientation" "horizontal"
            static member inline vertical = Interop.mkLayoutAngularaxisAttr "tickorientation" "vertical"

    [<Erase>]
    type legend =
        static member inline font (properties: #ILayoutLegendFontProperty list) = Interop.mkLayoutLegendAttr "font" (createObj !!properties)
        static member font (properties: (bool * ILayoutLegendFontProperty list) list) = Interop.mkLayoutLegendAttr "font" (properties |> Bindings.Internal.withConditionals)
        /// Sets the legend background color.
        static member inline bgcolor (value: string) = Interop.mkLayoutLegendAttr "bgcolor" value
        /// Sets the color of the border enclosing the legend.
        static member inline bordercolor (value: string) = Interop.mkLayoutLegendAttr "bordercolor" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: int) = Interop.mkLayoutLegendAttr "borderwidth" value
        /// Sets the width (in px) of the border enclosing the legend.
        static member inline borderwidth (value: float) = Interop.mkLayoutLegendAttr "borderwidth" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: int) = Interop.mkLayoutLegendAttr "tracegroupgap" value
        /// Sets the amount of vertical space (in px) between legend groups.
        static member inline tracegroupgap (value: float) = Interop.mkLayoutLegendAttr "tracegroupgap" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: int) = Interop.mkLayoutLegendAttr "x" value
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        static member inline x (value: float) = Interop.mkLayoutLegendAttr "x" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: int) = Interop.mkLayoutLegendAttr "y" value
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        static member inline y (value: float) = Interop.mkLayoutLegendAttr "y" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: bool) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<bool>) = Interop.mkLayoutLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: string) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<string>) = Interop.mkLayoutLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: int) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<int>) = Interop.mkLayoutLegendAttr "uirevision" values
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (value: float) = Interop.mkLayoutLegendAttr "uirevision" value
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        static member inline uirevision (values: seq<float>) = Interop.mkLayoutLegendAttr "uirevision" values

    module legend =
        /// Sets the orientation of the legend.
        [<Erase>]
        type orientation =
            static member inline h = Interop.mkLayoutLegendAttr "orientation" "h"
            static member inline v = Interop.mkLayoutLegendAttr "orientation" "v"

        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        [<Erase>]
        type traceorder =
            static member inline normal = Interop.mkLayoutLegendAttr "traceorder" "normal"
            static member inline grouped = Interop.mkLayoutLegendAttr "traceorder" "grouped"
            static member inline groupedAndReversed = Interop.mkLayoutLegendAttr "traceorder" "grouped+reversed"
            static member inline reversed = Interop.mkLayoutLegendAttr "traceorder" "reversed"

        /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
        [<Erase>]
        type itemsizing =
            static member inline constant = Interop.mkLayoutLegendAttr "itemsizing" "constant"
            static member inline trace = Interop.mkLayoutLegendAttr "itemsizing" "trace"

        /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
        [<Erase>]
        type itemclick =
            static member inline toggle = Interop.mkLayoutLegendAttr "itemclick" "toggle"
            static member inline toggleothers = Interop.mkLayoutLegendAttr "itemclick" "toggleothers"
            static member inline false' = Interop.mkLayoutLegendAttr "itemclick" "false"

        /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
        [<Erase>]
        type itemdoubleclick =
            static member inline toggle = Interop.mkLayoutLegendAttr "itemdoubleclick" "toggle"
            static member inline toggleothers = Interop.mkLayoutLegendAttr "itemdoubleclick" "toggleothers"
            static member inline false' = Interop.mkLayoutLegendAttr "itemdoubleclick" "false"

        /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
        [<Erase>]
        type xanchor =
            static member inline auto = Interop.mkLayoutLegendAttr "xanchor" "auto"
            static member inline center = Interop.mkLayoutLegendAttr "xanchor" "center"
            static member inline left = Interop.mkLayoutLegendAttr "xanchor" "left"
            static member inline right = Interop.mkLayoutLegendAttr "xanchor" "right"

        /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
        [<Erase>]
        type yanchor =
            static member inline auto = Interop.mkLayoutLegendAttr "yanchor" "auto"
            static member inline bottom = Interop.mkLayoutLegendAttr "yanchor" "bottom"
            static member inline middle = Interop.mkLayoutLegendAttr "yanchor" "middle"
            static member inline top = Interop.mkLayoutLegendAttr "yanchor" "top"

        /// Sets the vertical alignment of the symbols with respect to their associated text.
        [<Erase>]
        type valign =
            static member inline bottom = Interop.mkLayoutLegendAttr "valign" "bottom"
            static member inline middle = Interop.mkLayoutLegendAttr "valign" "middle"
            static member inline top = Interop.mkLayoutLegendAttr "valign" "top"

        [<Erase>]
        type font =
            static member inline description (properties: #ILayoutLegendFontDescriptionProperty list) = Interop.mkLayoutLegendFontAttr "description" (createObj !!properties)
            static member description (properties: (bool * ILayoutLegendFontDescriptionProperty list) list) = Interop.mkLayoutLegendFontAttr "description" (properties |> Bindings.Internal.withConditionals)
            /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            static member inline family (value: string) = Interop.mkLayoutLegendFontAttr "family" value
            static member inline size (value: int) = Interop.mkLayoutLegendFontAttr "size" value
            static member inline size (value: float) = Interop.mkLayoutLegendFontAttr "size" value
            static member inline color (value: string) = Interop.mkLayoutLegendFontAttr "color" value

    [<Erase>]
    type colorscale =
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequential (values: seq<string>) = Interop.mkLayoutColorscaleAttr "sequential" values
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        static member inline sequentialminus (values: seq<string>) = Interop.mkLayoutColorscaleAttr "sequentialminus" values
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        static member inline diverging (values: seq<string>) = Interop.mkLayoutColorscaleAttr "diverging" values

    [<Erase>]
    type coloraxis =
        static member inline description (properties: #ILayoutColoraxisDescriptionProperty list) = Interop.mkLayoutColoraxisAttr "description" (createObj !!properties)
        static member description (properties: (bool * ILayoutColoraxisDescriptionProperty list) list) = Interop.mkLayoutColoraxisAttr "description" (properties |> Bindings.Internal.withConditionals)
        static member inline colorbar (properties: #ILayoutColoraxisColorbarProperty list) = Interop.mkLayoutColoraxisAttr "colorbar" (createObj !!properties)
        static member colorbar (properties: (bool * ILayoutColoraxisColorbarProperty list) list) = Interop.mkLayoutColoraxisAttr "colorbar" (properties |> Bindings.Internal.withConditionals)
        /// Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        static member inline cauto (value: bool) = Interop.mkLayoutColoraxisAttr "cauto" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: int) = Interop.mkLayoutColoraxisAttr "cmin" value
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        static member inline cmin (value: float) = Interop.mkLayoutColoraxisAttr "cmin" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: int) = Interop.mkLayoutColoraxisAttr "cmax" value
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        static member inline cmax (value: float) = Interop.mkLayoutColoraxisAttr "cmax" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: int) = Interop.mkLayoutColoraxisAttr "cmid" value
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        static member inline cmid (value: float) = Interop.mkLayoutColoraxisAttr "cmid" value
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        static member inline colorscale (values: seq<string>) = Interop.mkLayoutColoraxisAttr "colorscale" values
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        static member inline autocolorscale (value: bool) = Interop.mkLayoutColoraxisAttr "autocolorscale" value
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        static member inline reversescale (value: bool) = Interop.mkLayoutColoraxisAttr "reversescale" value
        /// Determines whether or not a colorbar is displayed for this trace.
        static member inline showscale (value: bool) = Interop.mkLayoutColoraxisAttr "showscale" value

    module coloraxis =
        [<Erase>]
        type colorbar =
            static member inline tickfont (properties: #ILayoutColoraxisColorbarTickfontProperty list) = Interop.mkLayoutColoraxisColorbarAttr "tickfont" (createObj !!properties)
            static member tickfont (properties: (bool * ILayoutColoraxisColorbarTickfontProperty list) list) = Interop.mkLayoutColoraxisColorbarAttr "tickfont" (properties |> Bindings.Internal.withConditionals)
            static member inline tickformatstops (properties: #ILayoutColoraxisColorbarTickformatstopsProperty list) = Interop.mkLayoutColoraxisColorbarAttr "tickformatstops" (createObj !!properties)
            static member tickformatstops (properties: (bool * ILayoutColoraxisColorbarTickformatstopsProperty list) list) = Interop.mkLayoutColoraxisColorbarAttr "tickformatstops" (properties |> Bindings.Internal.withConditionals)
            static member inline title (properties: #ILayoutColoraxisColorbarTitleProperty list) = Interop.mkLayoutColoraxisColorbarAttr "title" (createObj !!properties)
            static member title (properties: (bool * ILayoutColoraxisColorbarTitleProperty list) list) = Interop.mkLayoutColoraxisColorbarAttr "title" (properties |> Bindings.Internal.withConditionals)
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: int) = Interop.mkLayoutColoraxisColorbarAttr "thickness" value
            /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
            static member inline thickness (value: float) = Interop.mkLayoutColoraxisColorbarAttr "thickness" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: int) = Interop.mkLayoutColoraxisColorbarAttr "len" value
            /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
            static member inline len (value: float) = Interop.mkLayoutColoraxisColorbarAttr "len" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: int) = Interop.mkLayoutColoraxisColorbarAttr "x" value
            /// Sets the x position of the color bar (in plot fraction).
            static member inline x (value: float) = Interop.mkLayoutColoraxisColorbarAttr "x" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: int) = Interop.mkLayoutColoraxisColorbarAttr "xpad" value
            /// Sets the amount of padding (in px) along the x direction.
            static member inline xpad (value: float) = Interop.mkLayoutColoraxisColorbarAttr "xpad" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: int) = Interop.mkLayoutColoraxisColorbarAttr "y" value
            /// Sets the y position of the color bar (in plot fraction).
            static member inline y (value: float) = Interop.mkLayoutColoraxisColorbarAttr "y" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: int) = Interop.mkLayoutColoraxisColorbarAttr "ypad" value
            /// Sets the amount of padding (in px) along the y direction.
            static member inline ypad (value: float) = Interop.mkLayoutColoraxisColorbarAttr "ypad" value
            /// Sets the axis line color.
            static member inline outlinecolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "outlinecolor" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "outlinewidth" value
            /// Sets the width (in px) of the axis line.
            static member inline outlinewidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "outlinewidth" value
            /// Sets the axis line color.
            static member inline bordercolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "bordercolor" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "borderwidth" value
            /// Sets the width (in px) or the border enclosing this color bar.
            static member inline borderwidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "borderwidth" value
            /// Sets the color of padded area.
            static member inline bgcolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "bgcolor" value
            /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
            static member inline nticks (value: int) = Interop.mkLayoutColoraxisColorbarAttr "nticks" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" values
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tick0" value
            /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
            static member inline tick0 (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "tick0" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: string) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: int) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" values
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (value: float) = Interop.mkLayoutColoraxisColorbarAttr "dtick" value
            /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
            static member inline dtick (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "dtick" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" values
            /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
            static member inline tickvals (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "tickvals" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<bool>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<string>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<int>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" values
            /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
            static member inline ticktext (values: seq<float>) = Interop.mkLayoutColoraxisColorbarAttr "ticktext" values
            /// Sets the tick length (in px).
            static member inline ticklen (value: int) = Interop.mkLayoutColoraxisColorbarAttr "ticklen" value
            /// Sets the tick length (in px).
            static member inline ticklen (value: float) = Interop.mkLayoutColoraxisColorbarAttr "ticklen" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tickwidth" value
            /// Sets the tick width (in px).
            static member inline tickwidth (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tickwidth" value
            /// Sets the tick color.
            static member inline tickcolor (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickcolor" value
            /// Determines whether or not the tick labels are drawn.
            static member inline showticklabels (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "showticklabels" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: int) = Interop.mkLayoutColoraxisColorbarAttr "tickangle" value
            /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
            static member inline tickangle (value: float) = Interop.mkLayoutColoraxisColorbarAttr "tickangle" value
            /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
            static member inline tickformat (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickformat" value
            /// Sets a tick label prefix.
            static member inline tickprefix (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickprefix" value
            /// Sets a tick label suffix.
            static member inline ticksuffix (value: string) = Interop.mkLayoutColoraxisColorbarAttr "ticksuffix" value
            /// If \"true\", even 4-digit integers are separated
            static member inline separatethousands (value: bool) = Interop.mkLayoutColoraxisColorbarAttr "separatethousands" value
            /// Sets the source reference on plot.ly for  tickvals .
            static member inline tickvalssrc (value: string) = Interop.mkLayoutColoraxisColorbarAttr "tickvalssrc" value
            /// Sets the source reference on plot.ly for  ticktext .
            static member inline ticktextsrc (value: string) = Interop.mkLayoutColoraxisColorbarAttr "ticktextsrc" value

        module colorbar =
            /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
            [<Erase>]
            type thicknessmode =
                static member inline fraction = Interop.mkLayoutColoraxisAttr "thicknessmode" "fraction"
                static member inline pixels = Interop.mkLayoutColoraxisAttr "thicknessmode" "pixels"

            /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
            [<Erase>]
            type lenmode =
                static member inline fraction = Interop.mkLayoutColoraxisAttr "lenmode" "fraction"
                static member inline pixels = Interop.mkLayoutColoraxisAttr "lenmode" "pixels"

            /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
            [<Erase>]
            type xanchor =
                static member inline center = Interop.mkLayoutColoraxisAttr "xanchor" "center"
                static member inline left = Interop.mkLayoutColoraxisAttr "xanchor" "left"
                static member inline right = Interop.mkLayoutColoraxisAttr "xanchor" "right"

            /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
            [<Erase>]
            type yanchor =
                static member inline bottom = Interop.mkLayoutColoraxisAttr "yanchor" "bottom"
                static member inline middle = Interop.mkLayoutColoraxisAttr "yanchor" "middle"
                static member inline top = Interop.mkLayoutColoraxisAttr "yanchor" "top"

            /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
            [<Erase>]
            type tickmode =
                static member inline array = Interop.mkLayoutColoraxisAttr "tickmode" "array"
                static member inline auto = Interop.mkLayoutColoraxisAttr "tickmode" "auto"
                static member inline linear = Interop.mkLayoutColoraxisAttr "tickmode" "linear"

            /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
            [<Erase>]
            type ticks =
                static member inline none = Interop.mkLayoutColoraxisAttr "ticks" ""
                static member inline inside = Interop.mkLayoutColoraxisAttr "ticks" "inside"
                static member inline outside = Interop.mkLayoutColoraxisAttr "ticks" "outside"

            /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
            [<Erase>]
            type showtickprefix =
                static member inline all = Interop.mkLayoutColoraxisAttr "showtickprefix" "all"
                static member inline first = Interop.mkLayoutColoraxisAttr "showtickprefix" "first"
                static member inline last = Interop.mkLayoutColoraxisAttr "showtickprefix" "last"
                static member inline none = Interop.mkLayoutColoraxisAttr "showtickprefix" "none"

            /// Same as `showtickprefix` but for tick suffixes.
            [<Erase>]
            type showticksuffix =
                static member inline all = Interop.mkLayoutColoraxisAttr "showticksuffix" "all"
                static member inline first = Interop.mkLayoutColoraxisAttr "showticksuffix" "first"
                static member inline last = Interop.mkLayoutColoraxisAttr "showticksuffix" "last"
                static member inline none = Interop.mkLayoutColoraxisAttr "showticksuffix" "none"

            /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
            [<Erase>]
            type exponentformat =
                static member inline B = Interop.mkLayoutColoraxisAttr "exponentformat" "B"
                static member inline E = Interop.mkLayoutColoraxisAttr "exponentformat" "E"
                static member inline SI = Interop.mkLayoutColoraxisAttr "exponentformat" "SI"
                static member inline e = Interop.mkLayoutColoraxisAttr "exponentformat" "e"
                static member inline none = Interop.mkLayoutColoraxisAttr "exponentformat" "none"
                static member inline power = Interop.mkLayoutColoraxisAttr "exponentformat" "power"

            /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
            [<Erase>]
            type showexponent =
                static member inline all = Interop.mkLayoutColoraxisAttr "showexponent" "all"
                static member inline first = Interop.mkLayoutColoraxisAttr "showexponent" "first"
                static member inline last = Interop.mkLayoutColoraxisAttr "showexponent" "last"
                static member inline none = Interop.mkLayoutColoraxisAttr "showexponent" "none"

            [<Erase>]
            type tickfont =
                static member inline description (properties: #ILayoutColoraxisColorbarTickfontDescriptionProperty list) = Interop.mkLayoutColoraxisColorbarTickfontAttr "description" (createObj !!properties)
                static member description (properties: (bool * ILayoutColoraxisColorbarTickfontDescriptionProperty list) list) = Interop.mkLayoutColoraxisColorbarTickfontAttr "description" (properties |> Bindings.Internal.withConditionals)
                /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                static member inline family (value: string) = Interop.mkLayoutColoraxisColorbarTickfontAttr "family" value
                static member inline size (value: int) = Interop.mkLayoutColoraxisColorbarTickfontAttr "size" value
                static member inline size (value: float) = Interop.mkLayoutColoraxisColorbarTickfontAttr "size" value
                static member inline color (value: string) = Interop.mkLayoutColoraxisColorbarTickfontAttr "color" value

            [<Erase>]
            type title =
                static member inline font (properties: #ILayoutColoraxisColorbarTitleFontProperty list) = Interop.mkLayoutColoraxisColorbarTitleAttr "font" (createObj !!properties)
                static member font (properties: (bool * ILayoutColoraxisColorbarTitleFontProperty list) list) = Interop.mkLayoutColoraxisColorbarTitleAttr "font" (properties |> Bindings.Internal.withConditionals)
                /// Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
                static member inline text (value: string) = Interop.mkLayoutColoraxisColorbarTitleAttr "text" value

            module title =
                /// Determines the location of color bar's title with respect to the color bar. Note that the title's location used to be set by the now deprecated `titleside` attribute.
                [<Erase>]
                type side =
                    static member inline bottom = Interop.mkLayoutColoraxisColorbarAttr "side" "bottom"
                    static member inline right = Interop.mkLayoutColoraxisColorbarAttr "side" "right"
                    static member inline top = Interop.mkLayoutColoraxisColorbarAttr "side" "top"

                [<Erase>]
                type font =
                    static member inline description (properties: #ILayoutColoraxisColorbarTitleFontDescriptionProperty list) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "description" (createObj !!properties)
                    static member description (properties: (bool * ILayoutColoraxisColorbarTitleFontDescriptionProperty list) list) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "description" (properties |> Bindings.Internal.withConditionals)
                    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
                    static member inline family (value: string) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "family" value
                    static member inline size (value: int) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "size" value
                    static member inline size (value: float) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "size" value
                    static member inline color (value: string) = Interop.mkLayoutColoraxisColorbarTitleFontAttr "color" value

