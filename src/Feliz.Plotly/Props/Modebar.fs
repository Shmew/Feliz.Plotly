namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type modebar =
    /// Sets the color of the active or hovered on icons in the modebar.
    static member inline activecolor (value: string) = Interop.mkModebarAttr "activecolor" value
    /// Sets the background color of the modebar.
    static member inline bgcolor (value: string) = Interop.mkModebarAttr "bgcolor" value
    /// Sets the color of the icons in the modebar.
    static member inline color (value: string) = Interop.mkModebarAttr "color" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkModebarAttr "uirevision" value
    /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkModebarAttr "uirevision" (values |> ResizeArray)

[<Erase;RequireQualifiedAccess>]
module modebar =
    /// Sets the color of the icons in the modebar.
    [<Erase>]
    type color =
        /// Sets the color of the icons in the modebar.
        static member inline rgb (r,g,b) = Interop.mkModebarAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the icons in the modebar.
        static member inline rgba (r,g,b,a) = Interop.mkModebarAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the icons in the modebar.
        static member inline hsl (h,s,l) = Interop.mkModebarAttr "color" (Feliz.color.hsl(h,s,l))

    /// Sets the orientation of the modebar.
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkModebarAttr "orientation" "h"
        static member inline v = Interop.mkModebarAttr "orientation" "v"

