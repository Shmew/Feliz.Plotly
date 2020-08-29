namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type template =
    /// Create the plotly template traces.
    static member inline traces (properties: ITracesProperty list) = Interop.mkTemplateAttr "data" (createObj !!(Bindings.convertTracesToTemplate properties))
    /// Create the plotly template layout.
    static member inline layout (properties: #ILayoutProperty list) = Interop.mkTemplateAttr "layout" (createObj !!properties)
