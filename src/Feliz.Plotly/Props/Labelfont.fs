namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type labelfont =
    static member inline color (value: string) = Interop.mkLabelfontAttr "color" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (value: string) = Interop.mkLabelfontAttr "family" value
    static member inline size (value: int) = Interop.mkLabelfontAttr "size" value
    static member inline size (value: float) = Interop.mkLabelfontAttr "size" value

[<Erase;RequireQualifiedAccess>]
module labelfont =
    [<Erase>]
    type color =
        static member inline rgb (r,g,b) = Interop.mkLabelfontAttr "color" (Feliz.color.rgb(r,g,b))
        static member inline rgba (r,g,b,a) = Interop.mkLabelfontAttr "color" (Feliz.color.rgba(r,g,b,a))
        static member inline hsl (h,s,l) = Interop.mkLabelfontAttr "color" (Feliz.color.hsl(h,s,l))

