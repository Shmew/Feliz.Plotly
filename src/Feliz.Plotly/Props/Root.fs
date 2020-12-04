namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type root =
    /// sets the color of the root node for a sunburst or a treemap trace. this has no effect when a colorscale is used to set the markers.
    static member inline color (value: string) = Interop.mkRootAttr "color" value

[<Erase;RequireQualifiedAccess>]
module root =
    /// sets the color of the root node for a sunburst or a treemap trace. this has no effect when a colorscale is used to set the markers.
    [<Erase>]
    type color =
        /// sets the color of the root node for a sunburst or a treemap trace. this has no effect when a colorscale is used to set the markers.
        static member inline rgb (r,g,b) = Interop.mkRootAttr "color" (Feliz.color.rgb(r,g,b))
        /// sets the color of the root node for a sunburst or a treemap trace. this has no effect when a colorscale is used to set the markers.
        static member inline rgba (r,g,b,a) = Interop.mkRootAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// sets the color of the root node for a sunburst or a treemap trace. this has no effect when a colorscale is used to set the markers.
        static member inline hsl (h,s,l) = Interop.mkRootAttr "color" (Feliz.color.hsl(h,s,l))

