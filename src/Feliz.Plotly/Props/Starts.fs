namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type starts =
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (value: bool) = Interop.mkStartsAttr "x" (value |> Array.singleton)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<bool>) = Interop.mkStartsAttr "x" (values |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (value: System.DateTime) = Interop.mkStartsAttr "x" (value |> Array.singleton)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<System.DateTime>) = Interop.mkStartsAttr "x" (values |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (value: float) = Interop.mkStartsAttr "x" (value |> Array.singleton)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<float>) = Interop.mkStartsAttr "x" (values |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (value: int) = Interop.mkStartsAttr "x" (value |> Array.singleton)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<int>) = Interop.mkStartsAttr "x" (values |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (value: string) = Interop.mkStartsAttr "x" (value |> Array.singleton)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<string>) = Interop.mkStartsAttr "x" (values |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<seq<bool>>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<bool list>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<bool []>) = Interop.mkStartsAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<seq<string>>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<string list>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<string []>) = Interop.mkStartsAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<seq<int>>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<int list>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<int option []>) = Interop.mkStartsAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<seq<float>>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<float list>) = Interop.mkStartsAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<float []>) = Interop.mkStartsAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<PlotData>) = Interop.mkStartsAttr "x" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<bool option>) = Interop.mkStartsAttr "x" (values |> ResizeArray)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<System.DateTime option>) = Interop.mkStartsAttr "x" (values |> ResizeArray)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<int option>) = Interop.mkStartsAttr "x" (values |> ResizeArray)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<float option>) = Interop.mkStartsAttr "x" (values |> ResizeArray)
    /// Sets the x components of the starting position of the streamtubes
    static member inline x (values: seq<string option>) = Interop.mkStartsAttr "x" (values |> ResizeArray)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (value: bool) = Interop.mkStartsAttr "y" (value |> Array.singleton)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<bool>) = Interop.mkStartsAttr "y" (values |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (value: System.DateTime) = Interop.mkStartsAttr "y" (value |> Array.singleton)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<System.DateTime>) = Interop.mkStartsAttr "y" (values |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (value: float) = Interop.mkStartsAttr "y" (value |> Array.singleton)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<float>) = Interop.mkStartsAttr "y" (values |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (value: int) = Interop.mkStartsAttr "y" (value |> Array.singleton)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<int>) = Interop.mkStartsAttr "y" (values |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (value: string) = Interop.mkStartsAttr "y" (value |> Array.singleton)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<string>) = Interop.mkStartsAttr "y" (values |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<seq<bool>>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<bool list>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<bool []>) = Interop.mkStartsAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<seq<string>>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<string list>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<string []>) = Interop.mkStartsAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<seq<int>>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<int list>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<int option []>) = Interop.mkStartsAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<seq<float>>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<float list>) = Interop.mkStartsAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<float []>) = Interop.mkStartsAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<PlotData>) = Interop.mkStartsAttr "y" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<bool option>) = Interop.mkStartsAttr "y" (values |> ResizeArray)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<System.DateTime option>) = Interop.mkStartsAttr "y" (values |> ResizeArray)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<int option>) = Interop.mkStartsAttr "y" (values |> ResizeArray)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<float option>) = Interop.mkStartsAttr "y" (values |> ResizeArray)
    /// Sets the y components of the starting position of the streamtubes
    static member inline y (values: seq<string option>) = Interop.mkStartsAttr "y" (values |> ResizeArray)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (value: bool) = Interop.mkStartsAttr "z" (value |> Array.singleton)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<bool>) = Interop.mkStartsAttr "z" (values |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (value: System.DateTime) = Interop.mkStartsAttr "z" (value |> Array.singleton)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<System.DateTime>) = Interop.mkStartsAttr "z" (values |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (value: float) = Interop.mkStartsAttr "z" (value |> Array.singleton)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<float>) = Interop.mkStartsAttr "z" (values |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (value: int) = Interop.mkStartsAttr "z" (value |> Array.singleton)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<int>) = Interop.mkStartsAttr "z" (values |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (value: string) = Interop.mkStartsAttr "z" (value |> Array.singleton)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<string>) = Interop.mkStartsAttr "z" (values |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<seq<bool>>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<bool list>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<bool []>) = Interop.mkStartsAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<seq<string>>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<string list>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<string []>) = Interop.mkStartsAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<seq<int>>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<int list>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<int option []>) = Interop.mkStartsAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<seq<float>>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<float list>) = Interop.mkStartsAttr "z" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<float []>) = Interop.mkStartsAttr "z" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<PlotData>) = Interop.mkStartsAttr "z" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<bool option>) = Interop.mkStartsAttr "z" (values |> ResizeArray)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<System.DateTime option>) = Interop.mkStartsAttr "z" (values |> ResizeArray)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<int option>) = Interop.mkStartsAttr "z" (values |> ResizeArray)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<float option>) = Interop.mkStartsAttr "z" (values |> ResizeArray)
    /// Sets the z components of the starting position of the streamtubes
    static member inline z (values: seq<string option>) = Interop.mkStartsAttr "z" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkStartsAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkStartsAttr "ysrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkStartsAttr "zsrc" value

