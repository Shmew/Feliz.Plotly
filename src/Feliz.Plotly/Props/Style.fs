namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type style =
    /// The group value which receives these styles.
    static member inline target (value: string) = Interop.mkStyleAttr "target" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: bool) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<bool>) = Interop.mkStyleAttr "value" (values |> Array.ofSeq)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: System.DateTime) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<System.DateTime>) = Interop.mkStyleAttr "value" (values |> Array.ofSeq)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: int) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<int>) = Interop.mkStyleAttr "value" (values |> Array.ofSeq)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: float) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<float>) = Interop.mkStyleAttr "value" (values |> Array.ofSeq)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: string) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<string>) = Interop.mkStyleAttr "value" (values |> Array.ofSeq)

