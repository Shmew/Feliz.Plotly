namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type aggregate =
    static member inline aggregations (properties: #IAggregationsProperty list) = Interop.mkAggregateAttr "aggregations" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Determines whether this aggregate transform is enabled or disabled.
    static member inline enabled (value: bool) = Interop.mkAggregateAttr "enabled" value
    /// Sets the grouping target to which the aggregation is applied. Data points with matching group values will be coalesced into one point, using the supplied aggregation functions to reduce data in other data arrays. If a string, `groups` is assumed to be a reference to a data array in the parent trace object. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate about the marker color array. If an array, `groups` is itself the data array by which we aggregate.
    static member inline groups (value: string) = Interop.mkAggregateAttr "groups" value
    /// Sets the grouping target to which the aggregation is applied. Data points with matching group values will be coalesced into one point, using the supplied aggregation functions to reduce data in other data arrays. If a string, `groups` is assumed to be a reference to a data array in the parent trace object. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate about the marker color array. If an array, `groups` is itself the data array by which we aggregate.
    static member inline groups (values: seq<string>) = Interop.mkAggregateAttr "groups" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  groups .
    static member inline groupssrc (value: string) = Interop.mkAggregateAttr "groupssrc" value

