namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type image =
    /// Determines whether or not this image is visible.
    static member inline visible (value: bool) = Interop.mkImageAttr "visible" value
    /// Specifies the URL of the image to be used. The URL must be accessible from the domain where the plot code is run, and can be either relative or absolute.
    static member inline source (value: string) = Interop.mkImageAttr "source" value
    /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
    static member inline sizex (value: int) = Interop.mkImageAttr "sizex" value
    /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
    static member inline sizex (value: float) = Interop.mkImageAttr "sizex" value
    /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
    static member inline sizey (value: int) = Interop.mkImageAttr "sizey" value
    /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
    static member inline sizey (value: float) = Interop.mkImageAttr "sizey" value
    /// Sets the opacity of the image.
    static member inline opacity (value: int) = Interop.mkImageAttr "opacity" value
    /// Sets the opacity of the image.
    static member inline opacity (value: float) = Interop.mkImageAttr "opacity" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: bool) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<bool>) = Interop.mkImageAttr "x" (values |> Array.ofSeq)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: System.DateTime) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<System.DateTime>) = Interop.mkImageAttr "x" (values |> Array.ofSeq)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: int) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<int>) = Interop.mkImageAttr "x" (values |> Array.ofSeq)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: float) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<float>) = Interop.mkImageAttr "x" (values |> Array.ofSeq)
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (value: string) = Interop.mkImageAttr "x" value
    /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
    static member inline x (values: seq<string>) = Interop.mkImageAttr "x" (values |> Array.ofSeq)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: bool) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<bool>) = Interop.mkImageAttr "y" (values |> Array.ofSeq)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: System.DateTime) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<System.DateTime>) = Interop.mkImageAttr "y" (values |> Array.ofSeq)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: int) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<int>) = Interop.mkImageAttr "y" (values |> Array.ofSeq)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: float) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<float>) = Interop.mkImageAttr "y" (values |> Array.ofSeq)
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (value: string) = Interop.mkImageAttr "y" value
    /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
    static member inline y (values: seq<string>) = Interop.mkImageAttr "y" (values |> Array.ofSeq)
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkImageAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkImageAttr "templateitemname" value

[<AutoOpen>]
module image =
    /// Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
    [<Erase>]
    type layer =
        static member inline above = Interop.mkImageAttr "layer" "above"
        static member inline below = Interop.mkImageAttr "layer" "below"

    /// Specifies which dimension of the image to constrain.
    [<Erase>]
    type sizing =
        static member inline contain = Interop.mkImageAttr "sizing" "contain"
        static member inline fill = Interop.mkImageAttr "sizing" "fill"
        static member inline stretch = Interop.mkImageAttr "sizing" "stretch"

    /// Sets the anchor for the x position
    [<Erase>]
    type xanchor =
        static member inline center = Interop.mkImageAttr "xanchor" "center"
        static member inline left = Interop.mkImageAttr "xanchor" "left"
        static member inline right = Interop.mkImageAttr "xanchor" "right"

    /// Sets the anchor for the y position.
    [<Erase>]
    type yanchor =
        static member inline bottom = Interop.mkImageAttr "yanchor" "bottom"
        static member inline middle = Interop.mkImageAttr "yanchor" "middle"
        static member inline top = Interop.mkImageAttr "yanchor" "top"

    /// Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to an x data coordinate If set to *paper*, the `x` position refers to the distance from the left of plot in normalized coordinates where *0* (*1*) corresponds to the left (right).
    [<Erase>]
    type xref =
        static member inline paper = Interop.mkImageAttr "xref" "paper"
        static member inline custom (value: string) = Interop.mkImageAttr "xref" value

    /// Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y data coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plot in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
    [<Erase>]
    type yref =
        static member inline paper = Interop.mkImageAttr "yref" "paper"
        static member inline custom (value: string) = Interop.mkImageAttr "yref" value

