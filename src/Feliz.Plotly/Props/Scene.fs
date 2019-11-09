namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type scene =
    static member inline bgcolor (value: string) = Interop.mkSceneAttr "bgcolor" value
    static member inline camera (properties: #ICameraProperty list) = Interop.mkSceneAttr "camera" (createObj !!properties)
    static member inline domain (properties: #IDomainProperty list) = Interop.mkSceneAttr "domain" (createObj !!properties)
    /// Sets this scene's axis aspectratio.
    static member inline aspectratio (properties: #IAspectratioProperty list) = Interop.mkSceneAttr "aspectratio" (createObj !!properties)
    static member inline xaxis (anchorId: int) = Interop.mkSceneAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    static member inline xaxis (properties: #IXaxisProperty list) = Interop.mkSceneAttr "xaxis" (createObj !!properties)
    static member inline yaxis (anchorId: int) = Interop.mkSceneAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    static member inline yaxis (properties: #IYaxisProperty list) = Interop.mkSceneAttr "yaxis" (createObj !!properties)
    static member inline zaxis (properties: #IZaxisProperty list) = Interop.mkSceneAttr "zaxis" (createObj !!properties)
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkSceneAttr "uirevision" value
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkSceneAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkSceneAttr "uirevision" value
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkSceneAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkSceneAttr "uirevision" value
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkSceneAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkSceneAttr "uirevision" value
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkSceneAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkSceneAttr "uirevision" value
    /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkSceneAttr "uirevision" (values |> Array.ofSeq)
    static member inline annotations (properties: #IAnnotationsProperty list) = Interop.mkSceneAttr "annotations" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)

[<AutoOpen>]
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
        static member inline pan = Interop.mkSceneAttr "dragmode" "pan"
        static member inline turntable = Interop.mkSceneAttr "dragmode" "turntable"
        static member inline zoom = Interop.mkSceneAttr "dragmode" "zoom"
        static member inline false' = Interop.mkSceneAttr "dragmode" false

    /// Determines the mode of hover interactions for this scene.
    [<Erase>]
    type hovermode =
        static member inline closest = Interop.mkSceneAttr "hovermode" "closest"
        static member inline false' = Interop.mkSceneAttr "hovermode" false

