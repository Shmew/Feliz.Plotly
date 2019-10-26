namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type camera =
    /// Sets the (x,y,z) components of the 'up' camera vector. This vector determines the up direction of this scene with respect to the page. The default is *{x: 0, y: 0, z: 1}* which means that the z axis points up.
    static member inline up (properties: #IUpProperty list) = Interop.mkCameraAttr "up" (createObj !!properties)
    /// Sets the (x,y,z) components of the 'center' camera vector This vector determines the translation (x,y,z) space about the center of this scene. By default, there is no such translation.
    static member inline center (properties: #ICenterProperty list) = Interop.mkCameraAttr "center" (createObj !!properties)
    /// Sets the (x,y,z) components of the 'eye' camera vector. This vector determines the view point about the origin of this scene.
    static member inline eye (properties: #IEyeProperty list) = Interop.mkCameraAttr "eye" (createObj !!properties)
    static member inline projection (properties: #IProjectionProperty list) = Interop.mkCameraAttr "projection" (createObj !!properties)

