namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type insidetextfont =
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (value: string) = Interop.mkInsidetextfontAttr "family" value
    /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
    static member inline family (values: seq<string>) = Interop.mkInsidetextfontAttr "family" (values |> ResizeArray)
    static member inline size (value: int) = Interop.mkInsidetextfontAttr "size" value
    static member inline size (value: float) = Interop.mkInsidetextfontAttr "size" value
    static member inline size (values: seq<int>) = Interop.mkInsidetextfontAttr "size" (values |> ResizeArray)
    static member inline size (values: seq<float>) = Interop.mkInsidetextfontAttr "size" (values |> ResizeArray)
    static member inline color (value: string) = Interop.mkInsidetextfontAttr "color" value
    static member inline color (values: seq<string>) = Interop.mkInsidetextfontAttr "color" (values |> ResizeArray)
    static member inline color (values: seq<int>) = Interop.mkInsidetextfontAttr "color" (values |> Array.ofSeq)
    static member inline color (values: seq<float>) = Interop.mkInsidetextfontAttr "color" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  family .
    static member inline familysrc (value: string) = Interop.mkInsidetextfontAttr "familysrc" value
    /// Sets the source reference on plot.ly for  size .
    static member inline sizesrc (value: string) = Interop.mkInsidetextfontAttr "sizesrc" value
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkInsidetextfontAttr "colorsrc" value

