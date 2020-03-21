namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type lighting =
    /// Ambient light increases overall color visibility but can wash out the image.
    static member inline ambient (value: int) = Interop.mkLightingAttr "ambient" value
    /// Ambient light increases overall color visibility but can wash out the image.
    static member inline ambient (value: float) = Interop.mkLightingAttr "ambient" value
    /// Represents the extent that incident rays are reflected in a range of angles.
    static member inline diffuse (value: int) = Interop.mkLightingAttr "diffuse" value
    /// Represents the extent that incident rays are reflected in a range of angles.
    static member inline diffuse (value: float) = Interop.mkLightingAttr "diffuse" value
    /// Epsilon for face normals calculation avoids math issues arising from degenerate geometry.
    static member inline facenormalsepsilon (value: int) = Interop.mkLightingAttr "facenormalsepsilon" value
    /// Epsilon for face normals calculation avoids math issues arising from degenerate geometry.
    static member inline facenormalsepsilon (value: float) = Interop.mkLightingAttr "facenormalsepsilon" value
    /// Represents the reflectance as a dependency of the viewing angle; e.g. paper is reflective when viewing it from the edge of the paper (almost 90 degrees), causing shine.
    static member inline fresnel (value: int) = Interop.mkLightingAttr "fresnel" value
    /// Represents the reflectance as a dependency of the viewing angle; e.g. paper is reflective when viewing it from the edge of the paper (almost 90 degrees), causing shine.
    static member inline fresnel (value: float) = Interop.mkLightingAttr "fresnel" value
    /// Alters specular reflection; the rougher the surface, the wider and less contrasty the shine.
    static member inline roughness (value: int) = Interop.mkLightingAttr "roughness" value
    /// Alters specular reflection; the rougher the surface, the wider and less contrasty the shine.
    static member inline roughness (value: float) = Interop.mkLightingAttr "roughness" value
    /// Represents the level that incident rays are reflected in a single direction, causing shine.
    static member inline specular (value: int) = Interop.mkLightingAttr "specular" value
    /// Represents the level that incident rays are reflected in a single direction, causing shine.
    static member inline specular (value: float) = Interop.mkLightingAttr "specular" value
    /// Epsilon for vertex normals calculation avoids math issues arising from degenerate geometry.
    static member inline vertexnormalsepsilon (value: int) = Interop.mkLightingAttr "vertexnormalsepsilon" value
    /// Epsilon for vertex normals calculation avoids math issues arising from degenerate geometry.
    static member inline vertexnormalsepsilon (value: float) = Interop.mkLightingAttr "vertexnormalsepsilon" value

