namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type projection =
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (value: int) = Interop.mkProjectionAttr "parallels" (value |> Array.singleton |> ResizeArray)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (values: seq<int>) = Interop.mkProjectionAttr "parallels" (values |> ResizeArray)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (value: float) = Interop.mkProjectionAttr "parallels" (value |> Array.singleton |> ResizeArray)
    /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
    static member inline parallels (values: seq<float>) = Interop.mkProjectionAttr "parallels" (values |> ResizeArray)
    static member inline rotation (properties: #IRotationProperty list) = Interop.mkProjectionAttr "rotation" (createObj !!properties)
    /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
    static member inline scale (value: int) = Interop.mkProjectionAttr "scale" value
    /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
    static member inline scale (value: float) = Interop.mkProjectionAttr "scale" value
    static member inline x (properties: #IXProperty list) = Interop.mkProjectionAttr "x" (createObj !!properties)
    static member inline y (properties: #IYProperty list) = Interop.mkProjectionAttr "y" (createObj !!properties)
    static member inline z (properties: #IZProperty list) = Interop.mkProjectionAttr "z" (createObj !!properties)

[<Erase;RequireQualifiedAccess>]
module projection =
    /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
    [<Erase>]
    type type' =
        static member inline aitoff = Interop.mkProjectionAttr "type" "aitoff"
        static member inline albersUsa = Interop.mkProjectionAttr "type" "albers usa"
        static member inline azimuthalEqualArea = Interop.mkProjectionAttr "type" "azimuthal equal area"
        static member inline azimuthalEquidistant = Interop.mkProjectionAttr "type" "azimuthal equidistant"
        static member inline conicConformal = Interop.mkProjectionAttr "type" "conic conformal"
        static member inline conicEqualArea = Interop.mkProjectionAttr "type" "conic equal area"
        static member inline conicEquidistant = Interop.mkProjectionAttr "type" "conic equidistant"
        static member inline eckert4 = Interop.mkProjectionAttr "type" "eckert4"
        static member inline equirectangular = Interop.mkProjectionAttr "type" "equirectangular"
        static member inline gnomonic = Interop.mkProjectionAttr "type" "gnomonic"
        static member inline hammer = Interop.mkProjectionAttr "type" "hammer"
        static member inline kavrayskiy7 = Interop.mkProjectionAttr "type" "kavrayskiy7"
        static member inline mercator = Interop.mkProjectionAttr "type" "mercator"
        static member inline miller = Interop.mkProjectionAttr "type" "miller"
        static member inline mollweide = Interop.mkProjectionAttr "type" "mollweide"
        static member inline naturalEarth = Interop.mkProjectionAttr "type" "natural earth"
        static member inline orthographic = Interop.mkProjectionAttr "type" "orthographic"
        static member inline perspective = Interop.mkProjectionAttr "type" "perspective"
        static member inline robinson = Interop.mkProjectionAttr "type" "robinson"
        static member inline sinusoidal = Interop.mkProjectionAttr "type" "sinusoidal"
        static member inline stereographic = Interop.mkProjectionAttr "type" "stereographic"
        static member inline transverseMercator = Interop.mkProjectionAttr "type" "transverse mercator"
        static member inline winkelTripel = Interop.mkProjectionAttr "type" "winkel tripel"

