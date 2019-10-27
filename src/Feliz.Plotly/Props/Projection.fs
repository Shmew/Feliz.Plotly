namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type projection =
    static member inline x (properties: #IXProperty list) = Interop.mkProjectionAttr "x" (createObj !!properties)
    static member inline y (properties: #IYProperty list) = Interop.mkProjectionAttr "y" (createObj !!properties)
    static member inline z (properties: #IZProperty list) = Interop.mkProjectionAttr "z" (createObj !!properties)
    static member inline rotation (properties: #IRotationProperty list) = Interop.mkProjectionAttr "rotation" (createObj !!properties)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (value: int) = Interop.mkProjectionAttr "parallels" (value |> Array.singleton)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (values: seq<int>) = Interop.mkProjectionAttr "parallels" (values |> Array.ofSeq)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (value: float) = Interop.mkProjectionAttr "parallels" (value |> Array.singleton)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (values: seq<float>) = Interop.mkProjectionAttr "parallels" (values |> Array.ofSeq)
    /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
    static member inline scale (value: int) = Interop.mkProjectionAttr "scale" value
    /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
    static member inline scale (value: float) = Interop.mkProjectionAttr "scale" value

[<AutoOpen>]
module projection =
    /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
    [<Erase>]
    type type' =
        static member inline orthographic = Interop.mkProjectionAttr "type" "orthographic"
        static member inline perspective = Interop.mkProjectionAttr "type" "perspective"

