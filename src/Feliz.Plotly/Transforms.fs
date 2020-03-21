namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type transforms =
    static member inline aggregate (properties: #IAggregateProperty list) = Interop.mkTransformsAttr "aggregate" (createObj !!(properties @ [ unbox (Interop.mkAggregateAttr "type" "aggregate") ]))
    static member inline filter (properties: #IFilterProperty list) = Interop.mkTransformsAttr "filter" (createObj !!(properties @ [ unbox (Interop.mkFilterAttr "type" "filter") ]))
    static member inline groupby (properties: #IGroupbyProperty list) = Interop.mkTransformsAttr "groupby" (createObj !!(properties @ [ unbox (Interop.mkGroupbyAttr "type" "groupby") ]))
    static member inline sort (properties: #ISortProperty list) = Interop.mkTransformsAttr "sort" (createObj !!(properties @ [ unbox (Interop.mkSortAttr "type" "sort") ]))

