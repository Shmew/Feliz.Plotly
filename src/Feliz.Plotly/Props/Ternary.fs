namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type ternary =
    static member inline domain (properties: #IDomainProperty list) = Interop.mkTernaryAttr "domain" (createObj !!properties)
    /// Set the background color of the subplot
    static member inline bgcolor (value: string) = Interop.mkTernaryAttr "bgcolor" value
    /// The number each triplet should sum to, and the maximum range of each axis
    static member inline sum (value: int) = Interop.mkTernaryAttr "sum" value
    /// The number each triplet should sum to, and the maximum range of each axis
    static member inline sum (value: float) = Interop.mkTernaryAttr "sum" value
    static member inline aaxis (properties: #IAaxisProperty list) = Interop.mkTernaryAttr "aaxis" (createObj !!properties)
    static member inline baxis (properties: #IBaxisProperty list) = Interop.mkTernaryAttr "baxis" (createObj !!properties)
    static member inline caxis (properties: #ICaxisProperty list) = Interop.mkTernaryAttr "caxis" (createObj !!properties)
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkTernaryAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkTernaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkTernaryAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkTernaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkTernaryAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkTernaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkTernaryAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkTernaryAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkTernaryAttr "uirevision" value
    /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkTernaryAttr "uirevision" (values |> Array.ofSeq)

