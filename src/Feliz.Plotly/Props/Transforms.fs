namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type transforms =
    static member inline aggregate (properties: #IAggregateProperty list) = Interop.mkTransformsAttr "aggregate" (createObj !!properties)
    static member inline filter (properties: #IFilterProperty list) = Interop.mkTransformsAttr "filter" (createObj !!properties)
    static member inline groupby (properties: #IGroupbyProperty list) = Interop.mkTransformsAttr "groupby" (createObj !!properties)
    static member inline sort (properties: #ISortProperty list) = Interop.mkTransformsAttr "sort" (createObj !!properties)

