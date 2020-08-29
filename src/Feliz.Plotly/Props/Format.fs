namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type format =
    /// The days in order of Sunday to Saturday.
    static member inline days (value: seq<string>) = Interop.mkFormatAttr "days" (ResizeArray value)
    /// The short form of days in order of Sunday to Saturday.
    static member inline shortDays (value: seq<string>) = Interop.mkFormatAttr "shortDays" (ResizeArray value)
    /// The months in order of January to December.
    static member inline months (value: seq<string>) = Interop.mkFormatAttr "months" (ResizeArray value)
    /// The short form of months in order of January to December.
    static member inline shortMonths (value: seq<string>) = Interop.mkFormatAttr "shortMonths" (ResizeArray value)
    /// The date in javascript format syntax (such as %d.%m.%Y).
    static member inline date (value: string) = Interop.mkFormatAttr "date" value
