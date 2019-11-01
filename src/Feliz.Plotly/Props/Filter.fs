namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type filter =
    /// Determines whether this filter transform is enabled or disabled.
    static member inline enabled (value: bool) = Interop.mkFilterAttr "enabled" value
    /// Sets the filter target by which the filter is applied. If a string, `target` is assumed to be a reference to a data array in the parent trace object. To filter about nested variables, use *.* to access them. For example, set `target` to *marker.color* to filter about the marker color array. If an array, `target` is then the data array by which the filter is applied.
    static member inline target (value: string) = Interop.mkFilterAttr "target" value
    /// Sets the filter target by which the filter is applied. If a string, `target` is assumed to be a reference to a data array in the parent trace object. To filter about nested variables, use *.* to access them. For example, set `target` to *marker.color* to filter about the marker color array. If an array, `target` is then the data array by which the filter is applied.
    static member inline target (values: seq<string>) = Interop.mkFilterAttr "target" (values |> ResizeArray)
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (value: bool) = Interop.mkFilterAttr "value" value
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (values: seq<bool>) = Interop.mkFilterAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (value: System.DateTime) = Interop.mkFilterAttr "value" value
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (values: seq<System.DateTime>) = Interop.mkFilterAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (value: int) = Interop.mkFilterAttr "value" value
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (values: seq<int>) = Interop.mkFilterAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (value: float) = Interop.mkFilterAttr "value" value
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (values: seq<float>) = Interop.mkFilterAttr "value" (values |> Array.ofSeq)
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (value: string) = Interop.mkFilterAttr "value" value
    /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements.
    static member inline value (values: seq<string>) = Interop.mkFilterAttr "value" (values |> Array.ofSeq)
    /// Determines whether or not gaps in data arrays produced by the filter operation are preserved. Setting this to *true* might be useful when plotting a line chart with `connectgaps` set to *false*.
    static member inline preservegaps (value: bool) = Interop.mkFilterAttr "preservegaps" value
    /// Sets the source reference on plot.ly for  target .
    static member inline targetsrc (value: string) = Interop.mkFilterAttr "targetsrc" value

[<AutoOpen>]
module filter =
    /// Sets the filter operation. *=* keeps items equal to `value` *!=* keeps items not equal to `value` *<* keeps items less than `value` *<=* keeps items less than or equal to `value` *>* keeps items greater than `value` *>=* keeps items greater than or equal to `value` *[]* keeps items inside `value[0]` to `value[1]` including both bounds *()* keeps items inside `value[0]` to `value[1]` excluding both bounds *[)* keeps items inside `value[0]` to `value[1]` including `value[0]` but excluding `value[1] *(]* keeps items inside `value[0]` to `value[1]` excluding `value[0]` but including `value[1] *][* keeps items outside `value[0]` to `value[1]` and equal to both bounds *)(* keeps items outside `value[0]` to `value[1]` *](* keeps items outside `value[0]` to `value[1]` and equal to `value[0]` *)[* keeps items outside `value[0]` to `value[1]` and equal to `value[1]` *{}* keeps items present in a set of values *}{* keeps items not present in a set of values
    [<Erase>]
    type operation =
        static member inline notEq = Interop.mkFilterAttr "operation" "!="
        static member inline exclusiveRange = Interop.mkFilterAttr "operation" "()"
        static member inline rightIncLeftExcRange = Interop.mkFilterAttr "operation" "(]"
        static member inline exclusiveBounds = Interop.mkFilterAttr "operation" ")("
        static member inline leftExcRightIncBounds = Interop.mkFilterAttr "operation" ")["
        static member inline lt = Interop.mkFilterAttr "operation" "<"
        static member inline ltEq = Interop.mkFilterAttr "operation" "<="
        static member inline eq = Interop.mkFilterAttr "operation" "="
        static member inline gt = Interop.mkFilterAttr "operation" ">"
        static member inline gtEq = Interop.mkFilterAttr "operation" ">="
        static member inline leftIncLRightExcRange = Interop.mkFilterAttr "operation" "[)"
        static member inline rightExcLeftIncBounds = Interop.mkFilterAttr "operation" "]("
        static member inline keepPresent = Interop.mkFilterAttr "operation" "{}"
        static member inline filterPresent = Interop.mkFilterAttr "operation" "}{"
        static member inline custom (value: string) = Interop.mkFilterAttr "operation" value

    /// Sets the calendar system to use for `value`, if it is a date.
    [<Erase>]
    type valuecalendar =
        static member inline chinese = Interop.mkFilterAttr "valuecalendar" "chinese"
        static member inline coptic = Interop.mkFilterAttr "valuecalendar" "coptic"
        static member inline discworld = Interop.mkFilterAttr "valuecalendar" "discworld"
        static member inline ethiopian = Interop.mkFilterAttr "valuecalendar" "ethiopian"
        static member inline gregorian = Interop.mkFilterAttr "valuecalendar" "gregorian"
        static member inline hebrew = Interop.mkFilterAttr "valuecalendar" "hebrew"
        static member inline islamic = Interop.mkFilterAttr "valuecalendar" "islamic"
        static member inline jalali = Interop.mkFilterAttr "valuecalendar" "jalali"
        static member inline julian = Interop.mkFilterAttr "valuecalendar" "julian"
        static member inline mayan = Interop.mkFilterAttr "valuecalendar" "mayan"
        static member inline nanakshahi = Interop.mkFilterAttr "valuecalendar" "nanakshahi"
        static member inline nepali = Interop.mkFilterAttr "valuecalendar" "nepali"
        static member inline persian = Interop.mkFilterAttr "valuecalendar" "persian"
        static member inline taiwan = Interop.mkFilterAttr "valuecalendar" "taiwan"
        static member inline thai = Interop.mkFilterAttr "valuecalendar" "thai"
        static member inline ummalqura = Interop.mkFilterAttr "valuecalendar" "ummalqura"

    /// Sets the calendar system to use for `target`, if it is an array of dates. If `target` is a string (eg *x*) we use the corresponding trace attribute (eg `xcalendar`) if it exists, even if `targetcalendar` is provided.
    [<Erase>]
    type targetcalendar =
        static member inline chinese = Interop.mkFilterAttr "targetcalendar" "chinese"
        static member inline coptic = Interop.mkFilterAttr "targetcalendar" "coptic"
        static member inline discworld = Interop.mkFilterAttr "targetcalendar" "discworld"
        static member inline ethiopian = Interop.mkFilterAttr "targetcalendar" "ethiopian"
        static member inline gregorian = Interop.mkFilterAttr "targetcalendar" "gregorian"
        static member inline hebrew = Interop.mkFilterAttr "targetcalendar" "hebrew"
        static member inline islamic = Interop.mkFilterAttr "targetcalendar" "islamic"
        static member inline jalali = Interop.mkFilterAttr "targetcalendar" "jalali"
        static member inline julian = Interop.mkFilterAttr "targetcalendar" "julian"
        static member inline mayan = Interop.mkFilterAttr "targetcalendar" "mayan"
        static member inline nanakshahi = Interop.mkFilterAttr "targetcalendar" "nanakshahi"
        static member inline nepali = Interop.mkFilterAttr "targetcalendar" "nepali"
        static member inline persian = Interop.mkFilterAttr "targetcalendar" "persian"
        static member inline taiwan = Interop.mkFilterAttr "targetcalendar" "taiwan"
        static member inline thai = Interop.mkFilterAttr "targetcalendar" "thai"
        static member inline ummalqura = Interop.mkFilterAttr "targetcalendar" "ummalqura"

