namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type polar =
    static member inline angularaxis (properties: #IAngularaxisProperty list) = Interop.mkPolarAttr "angularaxis" (createObj !!properties)
    /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
    static member inline bargap (value: int) = Interop.mkPolarAttr "bargap" value
    /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
    static member inline bargap (value: float) = Interop.mkPolarAttr "bargap" value
    /// Set the background color of the subplot
    static member inline bgcolor (value: string) = Interop.mkPolarAttr "bgcolor" value
    static member inline domain (properties: #IDomainProperty list) = Interop.mkPolarAttr "domain" (createObj !!properties)
    /// Sets the fraction of the radius to cut out of the polar subplot.
    static member inline hole (value: int) = Interop.mkPolarAttr "hole" value
    /// Sets the fraction of the radius to cut out of the polar subplot.
    static member inline hole (value: float) = Interop.mkPolarAttr "hole" value
    static member inline radialaxis (properties: #IRadialaxisProperty list) = Interop.mkPolarAttr "radialaxis" (createObj !!properties)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (value: int) = Interop.mkPolarAttr "sector" (value |> Array.singleton |> ResizeArray)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (values: seq<int>) = Interop.mkPolarAttr "sector" (values |> ResizeArray)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (value: float) = Interop.mkPolarAttr "sector" (value |> Array.singleton |> ResizeArray)
    /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
    static member inline sector (values: seq<float>) = Interop.mkPolarAttr "sector" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTimeOffset) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTimeOffset>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkPolarAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkPolarAttr "uirevision" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module polar =
    /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
    [<Erase>]
    type barmode =
        static member inline group = Interop.mkPolarAttr "barmode" "group"
        static member inline overlay = Interop.mkPolarAttr "barmode" "overlay"
        static member inline relative = Interop.mkPolarAttr "barmode" "relative"
        static member inline stack = Interop.mkPolarAttr "barmode" "stack"

    /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
    [<Erase>]
    type gridshape =
        static member inline circular = Interop.mkPolarAttr "gridshape" "circular"
        static member inline linear = Interop.mkPolarAttr "gridshape" "linear"

