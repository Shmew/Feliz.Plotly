namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type textfont =
    static member inline color (value: string) = Interop.mkTextfontAttr "color" value
    static member inline color (values: seq<string>) = Interop.mkTextfontAttr "color" (values |> ResizeArray)
    static member inline color (values: seq<int>) = Interop.mkTextfontAttr "color" (values |> ResizeArray)
    static member inline color (values: seq<float>) = Interop.mkTextfontAttr "color" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkTextfontAttr "colorsrc" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (value: string) = Interop.mkTextfontAttr "family" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (values: seq<string>) = Interop.mkTextfontAttr "family" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  family .
    static member inline familysrc (value: string) = Interop.mkTextfontAttr "familysrc" value
    static member inline size (value: int) = Interop.mkTextfontAttr "size" value
    static member inline size (value: float) = Interop.mkTextfontAttr "size" value
    static member inline size (values: seq<int>) = Interop.mkTextfontAttr "size" (values |> ResizeArray)
    static member inline size (values: seq<float>) = Interop.mkTextfontAttr "size" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  size .
    static member inline sizesrc (value: string) = Interop.mkTextfontAttr "sizesrc" value

[<Erase;RequireQualifiedAccess>]
module textfont =
    [<Erase>]
    type color =
        static member inline rgb (r,g,b) = Interop.mkTextfontAttr "color" (Feliz.color.rgb(r,g,b))
        static member inline rgba (r,g,b,a) = Interop.mkTextfontAttr "color" (Feliz.color.rgba(r,g,b,a))
        static member inline hsl (h,s,l) = Interop.mkTextfontAttr "color" (Feliz.color.hsl(h,s,l))

