namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type font =
    static member inline color (value: string) = Interop.mkFontAttr "color" value
    static member inline color (values: seq<string>) = Interop.mkFontAttr "color" (values |> ResizeArray)
    static member inline color (values: seq<int>) = Interop.mkFontAttr "color" (values |> ResizeArray)
    static member inline color (values: seq<float>) = Interop.mkFontAttr "color" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkFontAttr "colorsrc" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (value: string) = Interop.mkFontAttr "family" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (values: seq<string>) = Interop.mkFontAttr "family" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  family .
    static member inline familysrc (value: string) = Interop.mkFontAttr "familysrc" value
    static member inline size (value: int) = Interop.mkFontAttr "size" value
    static member inline size (value: float) = Interop.mkFontAttr "size" value
    static member inline size (values: seq<int>) = Interop.mkFontAttr "size" (values |> ResizeArray)
    static member inline size (values: seq<float>) = Interop.mkFontAttr "size" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  size .
    static member inline sizesrc (value: string) = Interop.mkFontAttr "sizesrc" value

[<Erase;RequireQualifiedAccess>]
module font =
    [<Erase>]
    type color =
        static member inline rgb (r,g,b) = Interop.mkFontAttr "color" (Feliz.color.rgb(r,g,b))
        static member inline rgba (r,g,b,a) = Interop.mkFontAttr "color" (Feliz.color.rgba(r,g,b,a))
        static member inline hsl (h,s,l) = Interop.mkFontAttr "color" (Feliz.color.hsl(h,s,l))

