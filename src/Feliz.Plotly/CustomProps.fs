namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open System.ComponentModel

[<Erase>]
type modeBarButtons =
    static member inline autoScale2d = unbox<IModeBarButtonsProperty> "autoScale2d"
    static member inline editInChartStudio = unbox<IModeBarButtonsProperty> "editInChartStudio"
    static member inline hoverClosest3d = unbox<IModeBarButtonsProperty> "hoverClosest3d"
    static member inline hoverClosestCartesian = unbox<IModeBarButtonsProperty> "hoverClosestCartesian"
    static member inline hoverClosestGeo = unbox<IModeBarButtonsProperty> "hoverClosestGeo"
    static member inline hoverClosestPie = unbox<IModeBarButtonsProperty> "hoverClosestPie"
    static member inline hoverCompareCartesian = unbox<IModeBarButtonsProperty> "hoverCompareCartesian"
    static member inline lasso2d = unbox<IModeBarButtonsProperty> "lasso2d"
    static member inline orbitRotation = unbox<IModeBarButtonsProperty> "orbitRotation"
    static member inline pan2d = unbox<IModeBarButtonsProperty> "pan2d"
    static member inline pan3d = unbox<IModeBarButtonsProperty> "pan3d"
    static member inline resetCameraDefault3d = unbox<IModeBarButtonsProperty> "resetCameraDefault3d"
    static member inline resetCameraLastSave3d = unbox<IModeBarButtonsProperty> "resetCameraLastSave3d"
    static member inline resetGeo = unbox<IModeBarButtonsProperty> "resetGeo"
    static member inline resetScale2d = unbox<IModeBarButtonsProperty> "resetScale2d"
    static member inline resetViewMapbox = unbox<IModeBarButtonsProperty> "resetViewMapbox"
    static member inline resetViews = unbox<IModeBarButtonsProperty> "resetViews"
    static member inline resetViewSankey = unbox<IModeBarButtonsProperty> "resetViewSankey"
    static member inline sendDataToCloud = unbox<IModeBarButtonsProperty> "sendDataToCloud"
    static member inline select2d = unbox<IModeBarButtonsProperty> "select2d"
    static member inline tableRotation = unbox<IModeBarButtonsProperty> "tableRotation"
    static member inline toggleHover = unbox<IModeBarButtonsProperty> "toggleHover"
    static member inline toggleSpikelines = unbox<IModeBarButtonsProperty> "toggleSpikelines"
    static member inline toImage = unbox<IModeBarButtonsProperty> "toImage"
    static member inline zoom2d = unbox<IModeBarButtonsProperty> "zoom2d"
    static member inline zoom3d = unbox<IModeBarButtonsProperty> "zoom3d"
    static member inline zoomIn2d = unbox<IModeBarButtonsProperty> "zoomIn2d"
    static member inline zoomInGeo = unbox<IModeBarButtonsProperty> "zoomInGeo"
    static member inline zoomOutGeo = unbox<IModeBarButtonsProperty> "zoomOutGeo"
    static member inline zoomOut2d = unbox<IModeBarButtonsProperty> "zoomOut2d"
    /// Convert a custom buttons.button to a modeBarButton
    static member inline fromButton (button: IButtonsProperty) = unbox<IModeBarButtonsProperty> button
    /// Convert a list of buttons.button to a list of modeBarButtons
    static member inline fromButton (properties: #IButtonProperty list) = Interop.mkModeBarButtonsAttr "button" (createObj !!properties)

[<Erase>]
type measure =
    static member inline absolute = unbox<IMeasureProperty> "absolute"
    static member inline relative = unbox<IMeasureProperty> "relative"
    static member inline total = unbox<IMeasureProperty> "total"

[<Erase>]
type template =
    /// Create the plotly template traces
    static member inline traces (properties: ITracesProperty list) = Interop.mkTemplateAttr "data" (createObj !!(Bindings.convertTracesToTemplate properties))
    /// Create the plotly template layout
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkTemplateAttr "layout" (createObj !!properties)
