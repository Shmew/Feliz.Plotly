namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type modebar =
    /// Sets the color of the active or hovered on icons in the modebar.
    static member inline activecolor (value: string) = Interop.mkModebarAttr "activecolor" value
    /// Determines which predefined modebar buttons to add. Please note that these buttons will only be shown if they are compatible with all trace types used in a graph. Similar to `config.modeBarButtonsToAdd` option. This may include *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect*, *eraseshape*.
    static member inline add (value: string) = Interop.mkModebarAttr "add" value
    /// Determines which predefined modebar buttons to add. Please note that these buttons will only be shown if they are compatible with all trace types used in a graph. Similar to `config.modeBarButtonsToAdd` option. This may include *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect*, *eraseshape*.
    static member inline add (values: seq<string>) = Interop.mkModebarAttr "add" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  add .
    static member inline addsrc (value: string) = Interop.mkModebarAttr "addsrc" value
    /// Sets the background color of the modebar.
    static member inline bgcolor (value: string) = Interop.mkModebarAttr "bgcolor" value
    /// Sets the color of the icons in the modebar.
    static member inline color (value: string) = Interop.mkModebarAttr "color" value
    /// Determines which predefined modebar buttons to remove. Similar to `config.modeBarButtonsToRemove` option. This may include *autoScale2d*, *autoscale*, *editInChartStudio*, *editinchartstudio*, *hoverCompareCartesian*, *hovercompare*, *lasso*, *lasso2d*, *orbitRotation*, *orbitrotation*, *pan*, *pan2d*, *pan3d*, *reset*, *resetCameraDefault3d*, *resetCameraLastSave3d*, *resetGeo*, *resetSankeyGroup*, *resetScale2d*, *resetViewMapbox*, *resetViews*, *resetcameradefault*, *resetcameralastsave*, *resetsankeygroup*, *resetscale*, *resetview*, *resetviews*, *select*, *select2d*, *sendDataToCloud*, *senddatatocloud*, *tableRotation*, *tablerotation*, *toImage*, *toggleHover*, *toggleSpikelines*, *togglehover*, *togglespikelines*, *toimage*, *zoom*, *zoom2d*, *zoom3d*, *zoomIn2d*, *zoomInGeo*, *zoomInMapbox*, *zoomOut2d*, *zoomOutGeo*, *zoomOutMapbox*, *zoomin*, *zoomout*.
    static member inline remove (value: string) = Interop.mkModebarAttr "remove" value
    /// Determines which predefined modebar buttons to remove. Similar to `config.modeBarButtonsToRemove` option. This may include *autoScale2d*, *autoscale*, *editInChartStudio*, *editinchartstudio*, *hoverCompareCartesian*, *hovercompare*, *lasso*, *lasso2d*, *orbitRotation*, *orbitrotation*, *pan*, *pan2d*, *pan3d*, *reset*, *resetCameraDefault3d*, *resetCameraLastSave3d*, *resetGeo*, *resetSankeyGroup*, *resetScale2d*, *resetViewMapbox*, *resetViews*, *resetcameradefault*, *resetcameralastsave*, *resetsankeygroup*, *resetscale*, *resetview*, *resetviews*, *select*, *select2d*, *sendDataToCloud*, *senddatatocloud*, *tableRotation*, *tablerotation*, *toImage*, *toggleHover*, *toggleSpikelines*, *togglehover*, *togglespikelines*, *toimage*, *zoom*, *zoom2d*, *zoom3d*, *zoomIn2d*, *zoomInGeo*, *zoomInMapbox*, *zoomOut2d*, *zoomOutGeo*, *zoomOutMapbox*, *zoomin*, *zoomout*.
    static member inline remove (values: seq<string>) = Interop.mkModebarAttr "remove" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  remove .
    static member inline removesrc (value: string) = Interop.mkModebarAttr "removesrc" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTimeOffset) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTimeOffset>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module modebar =
    /// Sets the color of the icons in the modebar.
    [<Erase>]
    type color =
        /// Sets the color of the icons in the modebar.
        static member inline rgb (r,g,b) = Interop.mkModebarAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the icons in the modebar.
        static member inline rgba (r,g,b,a) = Interop.mkModebarAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the icons in the modebar.
        static member inline hsl (h,s,l) = Interop.mkModebarAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the orientation of the modebar.
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkModebarAttr "orientation" "h"
        static member inline v = Interop.mkModebarAttr "orientation" "v"

