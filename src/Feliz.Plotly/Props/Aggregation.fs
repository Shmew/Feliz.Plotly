namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type aggregation =
    /// A reference to the data array in the parent trace to aggregate. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate over the marker color array. The referenced array must already exist, unless `func` is *count*, and each array may only be referenced once.
    static member inline target (value: string) = Interop.mkAggregationAttr "target" value
    /// Determines whether this aggregation function is enabled or disabled.
    static member inline enabled (value: bool) = Interop.mkAggregationAttr "enabled" value

[<AutoOpen>]
module aggregation =
    /// Sets the aggregation function. All values from the linked `target`, corresponding to the same value in the `groups` array, are collected and reduced by this function. *count* is simply the number of values in the `groups` array, so does not even require the linked array to exist. *first* (*last*) is just the first (last) linked value. Invalid values are ignored, so for example in *avg* they do not contribute to either the numerator or the denominator. Any data type (numeric, date, category) may be aggregated with any function, even though in certain cases it is unlikely to make sense, for example a sum of dates or average of categories. *median* will return the average of the two central values if there is an even count. *mode* will return the first value to reach the maximum count, in case of a tie. *change* will return the difference between the first and last linked values. *range* will return the difference between the min and max linked values.
    [<Erase>]
    type func =
        static member inline avg = Interop.mkAggregationAttr "func" "avg"
        static member inline change = Interop.mkAggregationAttr "func" "change"
        static member inline count = Interop.mkAggregationAttr "func" "count"
        static member inline first = Interop.mkAggregationAttr "func" "first"
        static member inline last = Interop.mkAggregationAttr "func" "last"
        static member inline max = Interop.mkAggregationAttr "func" "max"
        static member inline median = Interop.mkAggregationAttr "func" "median"
        static member inline min = Interop.mkAggregationAttr "func" "min"
        static member inline mode = Interop.mkAggregationAttr "func" "mode"
        static member inline range = Interop.mkAggregationAttr "func" "range"
        static member inline rms = Interop.mkAggregationAttr "func" "rms"
        static member inline stddev = Interop.mkAggregationAttr "func" "stddev"
        static member inline sum = Interop.mkAggregationAttr "func" "sum"

    /// *stddev* supports two formula variants: *sample* (normalize by N-1) and *population* (normalize by N).
    [<Erase>]
    type funcmode =
        static member inline population = Interop.mkAggregationAttr "funcmode" "population"
        static member inline sample = Interop.mkAggregationAttr "funcmode" "sample"

