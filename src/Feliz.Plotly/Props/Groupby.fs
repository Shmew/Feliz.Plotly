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
    static member inline groups (value: bool) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<bool>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: System.DateTime) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<System.DateTime>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: float) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<float>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: int) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<int>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (value: string) = Interop.mkGroupbyAttr "groups" (value |> Array.singleton |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<string>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<seq<bool>>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<bool list>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<bool []>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<seq<string>>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<string list>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<string []>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<seq<int>>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<int list>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<int []>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<seq<float>>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<float list>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<float []>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<PlotData>) = Interop.mkGroupbyAttr "groups" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<bool option>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<System.DateTime option>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<int option>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<float option>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
    static member inline groups (values: seq<string option>) = Interop.mkGroupbyAttr "groups" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  groups .
    static member inline groupssrc (value: string) = Interop.mkGroupbyAttr "groupssrc" value
    /// Pattern by which grouped traces are named. If only one trace is present, defaults to the group name (`\"%{group}\"`), otherwise defaults to the group name with trace name (`\"%{group} (%{trace})\"`). Available escape sequences are `%{group}`, which inserts the group name, and `%{trace}`, which inserts the trace name. If grouping GDP data by country when more than one trace is present, for example, the default \"%{group} (%{trace})\" would return \"Monaco (GDP per capita)\".
    static member inline nameformat (value: string) = Interop.mkGroupbyAttr "nameformat" value
    static member inline styles (properties: #IStylesProperty list) = Interop.mkGroupbyAttr "styles" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)

