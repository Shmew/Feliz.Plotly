namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type groupby =
    /// Determines whether this group-by transform is enabled or disabled.
    static member inline enabled (value: bool) = Interop.mkGroupbyAttr "enabled" value
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: bool) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<bool>) = Interop.mkGroupbyAttr "groups" (values |> Array.ofSeq)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: string) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<string>) = Interop.mkGroupbyAttr "groups" (values |> Array.ofSeq)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: int) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<int>) = Interop.mkGroupbyAttr "groups" (values |> Array.ofSeq)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: float) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<float>) = Interop.mkGroupbyAttr "groups" (values |> Array.ofSeq)
    /// Pattern by which grouped traces are named. If only one trace is present, defaults to the group name (`\"%{group}\"`), otherwise defaults to the group name with trace name (`\"%{group} (%{trace})\"`). Available escape sequences are `%{group}`, which inserts the group name, and `%{trace}`, which inserts the trace name. If grouping GDP data by country when more than one trace is present, for example, the default \"%{group} (%{trace})\" would return \"Monaco (GDP per capita)\".
    static member inline nameformat (value: string) = Interop.mkGroupbyAttr "nameformat" value
    static member inline styles (properties: #IStylesProperty list) = Interop.mkGroupbyAttr "styles" (createObj !!properties)
    /// Sets the source reference on plot.ly for  groups .
    static member inline groupssrc (value: string) = Interop.mkGroupbyAttr "groupssrc" value

