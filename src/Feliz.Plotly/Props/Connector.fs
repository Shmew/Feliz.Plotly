namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type connector =
    /// Sets the fill color.
    static member inline fillcolor (value: string) = Interop.mkConnectorAttr "fillcolor" value
    static member inline line (properties: #ILineProperty list) = Interop.mkConnectorAttr "line" (createObj !!properties)
    /// Determines if connector regions and lines are drawn.
    static member inline visible (value: bool) = Interop.mkConnectorAttr "visible" value

[<AutoOpen>]
module connector =
    /// Sets the shape of connector lines.
    [<Erase>]
    type mode =
        static member inline between = Interop.mkConnectorAttr "mode" "between"
        static member inline spanning = Interop.mkConnectorAttr "mode" "spanning"

