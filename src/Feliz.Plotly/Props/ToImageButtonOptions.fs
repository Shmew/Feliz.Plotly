namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type toImageButtonOptions =
    /// Sets the image file name.
    static member inline fileName (value: string) = Interop.mkToImageButtonOptionsAttr "filename" value
    /// Sets the image height.
    static member inline height (value: float) = Interop.mkToImageButtonOptionsAttr "height" value
    /// Sets the image height.
    static member inline height (value: int) = Interop.mkToImageButtonOptionsAttr "height" value
    /// Sets the image scale, modifies the size of the title/legend/axis/canvas sizes by this value.
    static member inline scale (value: float) = Interop.mkToImageButtonOptionsAttr "scale" value
    /// Sets the image scale, modifies the size of the title/legend/axis/canvas sizes by this value.
    static member inline scale (value: int) = Interop.mkToImageButtonOptionsAttr "scale" value
    /// Sets the image width.
    static member inline width (value: float) = Interop.mkToImageButtonOptionsAttr "width" value
    /// Sets the image width.
    static member inline width (value: int) = Interop.mkToImageButtonOptionsAttr "width" value

[<Erase;RequireQualifiedAccess>]
module toImageButtonOptions =
    [<Erase>]
    type format =
        static member inline jpeg (value: string) = Interop.mkToImageButtonOptionsAttr "format" value
        static member inline png (value: string) = Interop.mkToImageButtonOptionsAttr "format" value
        static member inline svg (value: string) = Interop.mkToImageButtonOptionsAttr "format" value
        static member inline webp (value: string) = Interop.mkToImageButtonOptionsAttr "format" value
