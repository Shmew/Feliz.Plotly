namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type tickformatstop =
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (value: bool) = Interop.mkTickformatstopAttr "dtickrange" (value |> Array.singleton |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (values: seq<bool>) = Interop.mkTickformatstopAttr "dtickrange" (values |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (value: System.DateTime) = Interop.mkTickformatstopAttr "dtickrange" (value |> Array.singleton |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (values: seq<System.DateTime>) = Interop.mkTickformatstopAttr "dtickrange" (values |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (value: float) = Interop.mkTickformatstopAttr "dtickrange" (value |> Array.singleton |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (values: seq<float>) = Interop.mkTickformatstopAttr "dtickrange" (values |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (value: int) = Interop.mkTickformatstopAttr "dtickrange" (value |> Array.singleton |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (values: seq<int>) = Interop.mkTickformatstopAttr "dtickrange" (values |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (value: string) = Interop.mkTickformatstopAttr "dtickrange" (value |> Array.singleton |> ResizeArray)
    /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
    static member inline dtickrange (values: seq<string>) = Interop.mkTickformatstopAttr "dtickrange" (values |> ResizeArray)
    /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
    static member inline enabled (value: bool) = Interop.mkTickformatstopAttr "enabled" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkTickformatstopAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkTickformatstopAttr "templateitemname" value
    /// string - dtickformat for described zoom level, the same as *tickformat*
    static member inline value (value: string) = Interop.mkTickformatstopAttr "value" value

