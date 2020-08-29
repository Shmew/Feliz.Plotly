namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type locale =
    /// Add a dictionary to use for localization.
    static member inline dictionary (entries: seq<(string * string)>) = Interop.mkLocaleAttr "dictionary" (createObj !!entries)
    /// Add a dictionary to use for localization.
    static member inline dictionary (entries: Map<string,string>) = Interop.mkLocaleAttr "dictionary" (createObj !!(List.ofSeq entries))
    /// The formatting of dates and times.
    static member inline format (properties: IFormatProperty list) = Interop.mkLocaleAttr "format" (createObj !!properties)
