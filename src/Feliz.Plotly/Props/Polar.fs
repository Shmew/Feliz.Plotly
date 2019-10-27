namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type polar =
    static member inline domain (properties: #IDomainProperty list) = Interop.mkPolarAttr "domain" (createObj !!properties)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (value: int) = Interop.mkPolarAttr "sector" (value |> Array.singleton)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (values: seq<int>) = Interop.mkPolarAttr "sector" (values |> Array.ofSeq)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (value: float) = Interop.mkPolarAttr "sector" (value |> Array.singleton)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (values: seq<float>) = Interop.mkPolarAttr "sector" (values |> Array.ofSeq)
    /// Sets the fraction of the radius to cut out of the polar subplot.
    static member inline hole (value: int) = Interop.mkPolarAttr "hole" value
    /// Sets the fraction of the radius to cut out of the polar subplot.
    static member inline hole (value: float) = Interop.mkPolarAttr "hole" value
    /// Set the background color of the subplot
    static member inline bgcolor (value: string) = Interop.mkPolarAttr "bgcolor" value
    static member inline radialaxis (properties: #IRadialaxisProperty list) = Interop.mkPolarAttr "radialaxis" (createObj !!properties)
    static member inline angularaxis (properties: #IAngularaxisProperty list) = Interop.mkPolarAttr "angularaxis" (createObj !!properties)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkPolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkPolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkPolarAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkPolarAttr "uirevision" (values |> Array.ofSeq)

[<AutoOpen>]
module polar =
    /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
    [<Erase>]
    type gridshape =
        static member inline circular = Interop.mkPolarAttr "gridshape" "circular"
        static member inline linear = Interop.mkPolarAttr "gridshape" "linear"

