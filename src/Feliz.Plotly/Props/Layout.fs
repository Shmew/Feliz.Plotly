namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type layout =
    static member inline annotations (properties: #IAnnotationsProperty list) = Interop.mkLayoutAttr "annotations" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Determines whether or not a layout width or height that has been left undefined by the user is initialized on each relayout. Note that, regardless of this attribute, an undefined layout width or height is always initialized on the first call to plot.
    static member inline autosize (value: bool) = Interop.mkLayoutAttr "autosize" value
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline bargap (value: int) = Interop.mkLayoutAttr "bargap" value
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline bargap (value: float) = Interop.mkLayoutAttr "bargap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline bargroupgap (value: int) = Interop.mkLayoutAttr "bargroupgap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline bargroupgap (value: float) = Interop.mkLayoutAttr "bargroupgap" value
    /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
    static member inline boxgap (value: int) = Interop.mkLayoutAttr "boxgap" value
    /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
    static member inline boxgap (value: float) = Interop.mkLayoutAttr "boxgap" value
    /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
    static member inline boxgroupgap (value: int) = Interop.mkLayoutAttr "boxgroupgap" value
    /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
    static member inline boxgroupgap (value: float) = Interop.mkLayoutAttr "boxgroupgap" value
    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    static member inline clickmode (properties: #ILayoutProperty list) = Interop.mkLayoutAttr "clickmode" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    static member inline coloraxis (id: int, properties: IColoraxisProperty list) = Interop.mkLayoutAttr (sprintf "coloraxis%i" id) (createObj !!properties)
    static member inline coloraxis (properties: #IColoraxisProperty list) = Interop.mkLayoutAttr "coloraxis" (createObj !!properties)
    static member inline colorscale (properties: #IColorscaleProperty list) = Interop.mkLayoutAttr "colorscale" (createObj !!properties)
    /// Sets the default trace colors.
    static member inline colorway (value: string) = Interop.mkLayoutAttr "colorway" (value |> Array.singleton |> ResizeArray)
    /// Sets the default trace colors.
    static member inline colorway (values: seq<string>) = Interop.mkLayoutAttr "colorway" (values |> ResizeArray)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: bool) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<bool>) = Interop.mkLayoutAttr "datarevision" (values |> ResizeArray)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: System.DateTime) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<System.DateTime>) = Interop.mkLayoutAttr "datarevision" (values |> ResizeArray)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: int) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<int>) = Interop.mkLayoutAttr "datarevision" (values |> ResizeArray)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: float) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<float>) = Interop.mkLayoutAttr "datarevision" (values |> ResizeArray)
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (value: string) = Interop.mkLayoutAttr "datarevision" value
    /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
    static member inline datarevision (values: seq<string>) = Interop.mkLayoutAttr "datarevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: bool) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<bool>) = Interop.mkLayoutAttr "editrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: System.DateTime) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<System.DateTime>) = Interop.mkLayoutAttr "editrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: int) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<int>) = Interop.mkLayoutAttr "editrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: float) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<float>) = Interop.mkLayoutAttr "editrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (value: string) = Interop.mkLayoutAttr "editrevision" value
    /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
    static member inline editrevision (values: seq<string>) = Interop.mkLayoutAttr "editrevision" (values |> ResizeArray)
    /// If `true`, the funnelarea slice colors (whether given by `funnelareacolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
    static member inline extendfunnelareacolors (value: bool) = Interop.mkLayoutAttr "extendfunnelareacolors" value
    /// If `true`, the pie slice colors (whether given by `piecolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
    static member inline extendpiecolors (value: bool) = Interop.mkLayoutAttr "extendpiecolors" value
    /// If `true`, the sunburst slice colors (whether given by `sunburstcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
    static member inline extendsunburstcolors (value: bool) = Interop.mkLayoutAttr "extendsunburstcolors" value
    /// If `true`, the treemap slice colors (whether given by `treemapcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
    static member inline extendtreemapcolors (value: bool) = Interop.mkLayoutAttr "extendtreemapcolors" value
    /// Sets the global font. Note that fonts used in traces and other layout components inherit from the global font.
    static member inline font (properties: #IFontProperty list) = Interop.mkLayoutAttr "font" (createObj !!properties)
    /// Sets the default funnelarea slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendfunnelareacolors`.
    static member inline funnelareacolorway (value: string) = Interop.mkLayoutAttr "funnelareacolorway" (value |> Array.singleton |> ResizeArray)
    /// Sets the default funnelarea slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendfunnelareacolors`.
    static member inline funnelareacolorway (values: seq<string>) = Interop.mkLayoutAttr "funnelareacolorway" (values |> ResizeArray)
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline funnelgap (value: int) = Interop.mkLayoutAttr "funnelgap" value
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline funnelgap (value: float) = Interop.mkLayoutAttr "funnelgap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline funnelgroupgap (value: int) = Interop.mkLayoutAttr "funnelgroupgap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline funnelgroupgap (value: float) = Interop.mkLayoutAttr "funnelgroupgap" value
    static member inline geo (id: int, properties: IGeoProperty list) = Interop.mkLayoutAttr (sprintf "geo%i" id) (createObj !!properties)
    static member inline geo (properties: #IGeoProperty list) = Interop.mkLayoutAttr "geo" (createObj !!properties)
    static member inline grid (properties: #IGridProperty list) = Interop.mkLayoutAttr "grid" (createObj !!properties)
    /// Sets the plot's height (in px).
    static member inline height (value: int) = Interop.mkLayoutAttr "height" value
    /// Sets the plot's height (in px).
    static member inline height (value: float) = Interop.mkLayoutAttr "height" value
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (value: bool) = Interop.mkLayoutAttr "hiddenlabels" (value |> Array.singleton)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<bool>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (value: System.DateTime) = Interop.mkLayoutAttr "hiddenlabels" (value |> Array.singleton)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<System.DateTime>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (value: float) = Interop.mkLayoutAttr "hiddenlabels" (value |> Array.singleton)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<float>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (value: int) = Interop.mkLayoutAttr "hiddenlabels" (value |> Array.singleton)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<int>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (value: string) = Interop.mkLayoutAttr "hiddenlabels" (value |> Array.singleton)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<string>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<seq<bool>>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<bool list>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<bool []>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<seq<string>>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<string list>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<string []>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<seq<int>>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<int list>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<int []>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<seq<float>>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<float list>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<float []>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map ResizeArray |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<PlotData>) = Interop.mkLayoutAttr "hiddenlabels" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<bool option>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<System.DateTime option>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<int option>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<float option>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
    static member inline hiddenlabels (values: seq<string option>) = Interop.mkLayoutAttr "hiddenlabels" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hiddenlabels .
    static member inline hiddenlabelssrc (value: string) = Interop.mkLayoutAttr "hiddenlabelssrc" value
    /// Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise).
    static member inline hidesources (value: bool) = Interop.mkLayoutAttr "hidesources" value
    /// Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict.
    static member inline hoverdistance (value: int) = Interop.mkLayoutAttr "hoverdistance" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkLayoutAttr "hoverlabel" (createObj !!properties)
    static member inline images (properties: #IImagesProperty list) = Interop.mkLayoutAttr "images" (createObj !!properties)
    static member inline legend (properties: #ILegendProperty list) = Interop.mkLayoutAttr "legend" (createObj !!properties)
    static member inline mapbox (id: int, properties: IMapboxProperty list) = Interop.mkLayoutAttr (sprintf "mapbox%i" id) (createObj !!properties)
    static member inline mapbox (properties: #IMapboxProperty list) = Interop.mkLayoutAttr "mapbox" (createObj !!properties)
    static member inline margin (properties: #IMarginProperty list) = Interop.mkLayoutAttr "margin" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkLayoutAttr "metasrc" value
    static member inline modebar (properties: #IModebarProperty list) = Interop.mkLayoutAttr "modebar" (createObj !!properties)
    /// Sets the background color of the paper where the graph is drawn.
    static member inline paperBgcolor (value: string) = Interop.mkLayoutAttr "paper_bgcolor" value
    /// Sets the default pie slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendpiecolors`.
    static member inline piecolorway (value: string) = Interop.mkLayoutAttr "piecolorway" (value |> Array.singleton |> ResizeArray)
    /// Sets the default pie slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendpiecolors`.
    static member inline piecolorway (values: seq<string>) = Interop.mkLayoutAttr "piecolorway" (values |> ResizeArray)
    /// Sets the background color of the plotting area in-between x and y axes.
    static member inline plotBgcolor (value: string) = Interop.mkLayoutAttr "plot_bgcolor" value
    static member inline polar (id: int, properties: IPolarProperty list) = Interop.mkLayoutAttr (sprintf "polar%i" id) (createObj !!properties)
    static member inline polar (properties: #IPolarProperty list) = Interop.mkLayoutAttr "polar" (createObj !!properties)
    static member inline scene (id: int, properties: ISceneProperty list) = Interop.mkLayoutAttr (sprintf "scene%i" id) (createObj !!properties)
    static member inline scene (properties: #ISceneProperty list) = Interop.mkLayoutAttr "scene" (createObj !!properties)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: bool) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<bool>) = Interop.mkLayoutAttr "selectionrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: System.DateTime) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<System.DateTime>) = Interop.mkLayoutAttr "selectionrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: int) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<int>) = Interop.mkLayoutAttr "selectionrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: float) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<float>) = Interop.mkLayoutAttr "selectionrevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (value: string) = Interop.mkLayoutAttr "selectionrevision" value
    /// Controls persistence of user-driven changes in selected points from all traces.
    static member inline selectionrevision (values: seq<string>) = Interop.mkLayoutAttr "selectionrevision" (values |> ResizeArray)
    /// Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default.
    static member inline separators (value: string) = Interop.mkLayoutAttr "separators" value
    static member inline shapes (properties: #IShapesProperty list) = Interop.mkLayoutAttr "shapes" (createObj !!properties)
    /// Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`.
    static member inline showlegend (value: bool) = Interop.mkLayoutAttr "showlegend" value
    static member inline sliders (properties: #ISlidersProperty list) = Interop.mkLayoutAttr "sliders" (createObj !!properties)
    /// Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills.
    static member inline spikedistance (value: int) = Interop.mkLayoutAttr "spikedistance" value
    /// Sets the default sunburst slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendsunburstcolors`.
    static member inline sunburstcolorway (value: string) = Interop.mkLayoutAttr "sunburstcolorway" (value |> Array.singleton |> ResizeArray)
    /// Sets the default sunburst slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendsunburstcolors`.
    static member inline sunburstcolorway (values: seq<string>) = Interop.mkLayoutAttr "sunburstcolorway" (values |> ResizeArray)
    /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
    static member inline template (properties: #ITemplateProperty list) = Interop.mkLayoutAttr "template" (createObj !!properties)
    static member inline ternary (id: int, properties: ITernaryProperty list) = Interop.mkLayoutAttr (sprintf "ternary%i" id) (createObj !!properties)
    static member inline ternary (properties: #ITernaryProperty list) = Interop.mkLayoutAttr "ternary" (createObj !!properties)
    static member inline title (properties: #ITitleProperty list) = Interop.mkLayoutAttr "title" (createObj !!properties)
    static member inline title (value: string) = Interop.mkLayoutAttr "title" (createObj !!((Interop.mkTitleAttr "text" value) |> Array.singleton))
    /// Sets transition options used during Plotly.react updates.
    static member inline transition (properties: #ITransitionProperty list) = Interop.mkLayoutAttr "transition" (createObj !!properties)
    /// Sets the default treemap slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendtreemapcolors`.
    static member inline treemapcolorway (value: string) = Interop.mkLayoutAttr "treemapcolorway" (value |> Array.singleton |> ResizeArray)
    /// Sets the default treemap slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendtreemapcolors`.
    static member inline treemapcolorway (values: seq<string>) = Interop.mkLayoutAttr "treemapcolorway" (values |> ResizeArray)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: bool) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<bool>) = Interop.mkLayoutAttr "uirevision" (values |> ResizeArray)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: System.DateTime) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkLayoutAttr "uirevision" (values |> ResizeArray)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: int) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<int>) = Interop.mkLayoutAttr "uirevision" (values |> ResizeArray)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: float) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<float>) = Interop.mkLayoutAttr "uirevision" (values |> ResizeArray)
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (value: string) = Interop.mkLayoutAttr "uirevision" value
    /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
    static member inline uirevision (values: seq<string>) = Interop.mkLayoutAttr "uirevision" (values |> ResizeArray)
    static member inline uniformtext (properties: #IUniformtextProperty list) = Interop.mkLayoutAttr "uniformtext" (createObj !!properties)
    static member inline updatemenus (properties: #IUpdatemenusProperty list) = Interop.mkLayoutAttr "updatemenus" (createObj !!properties)
    /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
    static member inline violingap (value: int) = Interop.mkLayoutAttr "violingap" value
    /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
    static member inline violingap (value: float) = Interop.mkLayoutAttr "violingap" value
    /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
    static member inline violingroupgap (value: int) = Interop.mkLayoutAttr "violingroupgap" value
    /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
    static member inline violingroupgap (value: float) = Interop.mkLayoutAttr "violingroupgap" value
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline waterfallgap (value: int) = Interop.mkLayoutAttr "waterfallgap" value
    /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
    static member inline waterfallgap (value: float) = Interop.mkLayoutAttr "waterfallgap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline waterfallgroupgap (value: int) = Interop.mkLayoutAttr "waterfallgroupgap" value
    /// Sets the gap (in plot fraction) between bars of the same location coordinate.
    static member inline waterfallgroupgap (value: float) = Interop.mkLayoutAttr "waterfallgroupgap" value
    /// Sets the plot's width (in px).
    static member inline width (value: int) = Interop.mkLayoutAttr "width" value
    /// Sets the plot's width (in px).
    static member inline width (value: float) = Interop.mkLayoutAttr "width" value
    static member inline xaxis (id: int, properties: IXaxisProperty list) = Interop.mkLayoutAttr (sprintf "xaxis%i" id) (createObj !!properties)
    static member inline xaxis (properties: #IXaxisProperty list) = Interop.mkLayoutAttr "xaxis" (createObj !!properties)
    static member inline yaxis (id: int, properties: IYaxisProperty list) = Interop.mkLayoutAttr (sprintf "yaxis%i" id) (createObj !!properties)
    static member inline yaxis (properties: #IYaxisProperty list) = Interop.mkLayoutAttr "yaxis" (createObj !!properties)

[<RequireQualifiedAccess>]
module layout =
    /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
    [<Erase>]
    type barmode =
        static member inline group = Interop.mkLayoutAttr "barmode" "group"
        static member inline overlay = Interop.mkLayoutAttr "barmode" "overlay"
        static member inline relative = Interop.mkLayoutAttr "barmode" "relative"
        static member inline stack = Interop.mkLayoutAttr "barmode" "stack"

    /// Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
    [<Erase>]
    type barnorm =
        static member inline none = Interop.mkLayoutAttr "barnorm" ""
        static member inline fraction = Interop.mkLayoutAttr "barnorm" "fraction"
        static member inline percent = Interop.mkLayoutAttr "barnorm" "percent"

    /// Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
    [<Erase>]
    type boxmode =
        static member inline group = Interop.mkLayoutAttr "boxmode" "group"
        static member inline overlay = Interop.mkLayoutAttr "boxmode" "overlay"

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

    /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
    [<Erase>]
    type clickmode =
        static member inline none = Interop.mkLayoutAttr "clickmode" "none"
        static member inline event = Interop.mkLayoutAttr "clickmode" "event"
        static member inline select = Interop.mkLayoutAttr "clickmode" "select"

    /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
    [<Erase>]
    type dragmode =
        static member inline lasso = Interop.mkLayoutAttr "dragmode" "lasso"
        static member inline orbit = Interop.mkLayoutAttr "dragmode" "orbit"
        static member inline pan = Interop.mkLayoutAttr "dragmode" "pan"
        static member inline select = Interop.mkLayoutAttr "dragmode" "select"
        static member inline turntable = Interop.mkLayoutAttr "dragmode" "turntable"
        static member inline zoom = Interop.mkLayoutAttr "dragmode" "zoom"
        static member inline false' = Interop.mkLayoutAttr "dragmode" false

    /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
    [<Erase>]
    type funnelmode =
        static member inline group = Interop.mkLayoutAttr "funnelmode" "group"
        static member inline overlay = Interop.mkLayoutAttr "funnelmode" "overlay"
        static member inline stack = Interop.mkLayoutAttr "funnelmode" "stack"

    /// Determines the mode of hover interactions. If *closest*, a single hoverlabel will appear for the *closest* point within the `hoverdistance`. If *x* (or *y*), multiple hoverlabels will appear for multiple points at the *closest* x- (or y-) coordinate within the `hoverdistance`, with the caveat that no more than one hoverlabel will appear per trace. If *x unified* (or *y unified*), a single hoverlabel will appear multiple points at the closest x- (or y-) coordinate within the `hoverdistance` with the caveat that no more than one hoverlabel will appear per trace. In this mode, spikelines are enabled by default perpendicular to the specified axis. If false, hover interactions are disabled. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
    [<Erase>]
    type hovermode =
        static member inline closest = Interop.mkLayoutAttr "hovermode" "closest"
        static member inline xUnified = Interop.mkLayoutAttr "hovermode" "x unified"
        static member inline x = Interop.mkLayoutAttr "hovermode" "x"
        static member inline yUnified = Interop.mkLayoutAttr "hovermode" "y unified"
        static member inline y = Interop.mkLayoutAttr "hovermode" "y"
        static member inline false' = Interop.mkLayoutAttr "hovermode" false

    /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
    [<Erase>]
    type selectdirection =
        static member inline any = Interop.mkLayoutAttr "selectdirection" "any"
        static member inline d = Interop.mkLayoutAttr "selectdirection" "d"
        static member inline h = Interop.mkLayoutAttr "selectdirection" "h"
        static member inline v = Interop.mkLayoutAttr "selectdirection" "v"

    /// Determines how violins at the same location coordinate are displayed on the graph. If *group*, the violins are plotted next to one another centered around the shared location. If *overlay*, the violins are plotted over one another, you might need to set *opacity* to see them multiple violins. Has no effect on traces that have *width* set.
    [<Erase>]
    type violinmode =
        static member inline group = Interop.mkLayoutAttr "violinmode" "group"
        static member inline overlay = Interop.mkLayoutAttr "violinmode" "overlay"

    /// Determines how bars at the same location coordinate are displayed on the graph. With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
    [<Erase>]
    type waterfallmode =
        static member inline group = Interop.mkLayoutAttr "waterfallmode" "group"
        static member inline overlay = Interop.mkLayoutAttr "waterfallmode" "overlay"

