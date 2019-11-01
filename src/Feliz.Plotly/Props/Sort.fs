namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type sort =
    /// Determines whether this sort transform is enabled or disabled.
    static member inline enabled (value: bool) = Interop.mkSortAttr "enabled" value
    /// Sets the target by which the sort transform is applied. If a string, *target* is assumed to be a reference to a data array in the parent trace object. To sort about nested variables, use *.* to access them. For example, set `target` to *marker.size* to sort about the marker size array. If an array, *target* is then the data array by which the sort transform is applied.
    static member inline target (value: string) = Interop.mkSortAttr "target" value
    /// Sets the target by which the sort transform is applied. If a string, *target* is assumed to be a reference to a data array in the parent trace object. To sort about nested variables, use *.* to access them. For example, set `target` to *marker.size* to sort about the marker size array. If an array, *target* is then the data array by which the sort transform is applied.
    static member inline target (values: seq<string>) = Interop.mkSortAttr "target" (values |> ResizeArray)
    /// Sets the source reference on plot.ly for  target .
    static member inline targetsrc (value: string) = Interop.mkSortAttr "targetsrc" value

[<AutoOpen>]
module sort =
    /// Sets the sort transform order.
    [<Erase>]
    type order =
        static member inline ascending = Interop.mkSortAttr "order" "ascending"
        static member inline descending = Interop.mkSortAttr "order" "descending"

