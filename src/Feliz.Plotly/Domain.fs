namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type domain =
    /// If there is a layout grid, use the domain for this column in the grid for this pie trace .
    static member inline column (value: int) = Interop.mkDomainAttr "column" value
    /// If there is a layout grid, use the domain for this row in the grid for this pie trace .
    static member inline row (value: int) = Interop.mkDomainAttr "row" value
    /// Sets the horizontal domain of this pie trace (in plot fraction).
    static member inline x (value: int) = Interop.mkDomainAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the horizontal domain of this pie trace (in plot fraction).
    static member inline x (values: seq<int>) = Interop.mkDomainAttr "x" (values |> ResizeArray)
    /// Sets the horizontal domain of this pie trace (in plot fraction).
    static member inline x (value: float) = Interop.mkDomainAttr "x" (value |> Array.singleton |> ResizeArray)
    /// Sets the horizontal domain of this pie trace (in plot fraction).
    static member inline x (values: seq<float>) = Interop.mkDomainAttr "x" (values |> ResizeArray)
    /// Sets the vertical domain of this pie trace (in plot fraction).
    static member inline y (value: int) = Interop.mkDomainAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the vertical domain of this pie trace (in plot fraction).
    static member inline y (values: seq<int>) = Interop.mkDomainAttr "y" (values |> ResizeArray)
    /// Sets the vertical domain of this pie trace (in plot fraction).
    static member inline y (value: float) = Interop.mkDomainAttr "y" (value |> Array.singleton |> ResizeArray)
    /// Sets the vertical domain of this pie trace (in plot fraction).
    static member inline y (values: seq<float>) = Interop.mkDomainAttr "y" (values |> ResizeArray)

