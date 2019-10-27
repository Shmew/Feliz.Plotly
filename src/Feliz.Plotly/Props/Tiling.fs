namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type tiling =
    /// When using *squarify* `packing` algorithm, according to https://github.com/d3/d3-hierarchy/blob/master/README.md#squarify_ratio this option specifies the desired aspect ratio of the generated rectangles. The ratio must be specified as a number greater than or equal to one. Note that the orientation of the generated rectangles (tall or wide) is not implied by the ratio; for example, a ratio of two will attempt to produce a mixture of rectangles whose width:height ratio is either 2:1 or 1:2. When using *squarify*, unlike d3 which uses the Golden Ratio i.e. 1.618034, Plotly applies 1 to increase squares in treemap layouts.
    static member inline squarifyratio (value: int) = Interop.mkTilingAttr "squarifyratio" value
    /// When using *squarify* `packing` algorithm, according to https://github.com/d3/d3-hierarchy/blob/master/README.md#squarify_ratio this option specifies the desired aspect ratio of the generated rectangles. The ratio must be specified as a number greater than or equal to one. Note that the orientation of the generated rectangles (tall or wide) is not implied by the ratio; for example, a ratio of two will attempt to produce a mixture of rectangles whose width:height ratio is either 2:1 or 1:2. When using *squarify*, unlike d3 which uses the Golden Ratio i.e. 1.618034, Plotly applies 1 to increase squares in treemap layouts.
    static member inline squarifyratio (value: float) = Interop.mkTilingAttr "squarifyratio" value
    /// Determines if the positions obtained from solver are flipped on each axis.
    static member inline flip (properties: #ITilingProperty list) = Interop.mkTilingAttr "flip" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the inner padding (in px).
    static member inline pad (value: int) = Interop.mkTilingAttr "pad" value
    /// Sets the inner padding (in px).
    static member inline pad (value: float) = Interop.mkTilingAttr "pad" value

[<AutoOpen>]
module tiling =
    /// Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
    [<Erase>]
    type packing =
        static member inline binary = Interop.mkTilingAttr "packing" "binary"
        static member inline dice = Interop.mkTilingAttr "packing" "dice"
        static member inline diceSlice = Interop.mkTilingAttr "packing" "dice-slice"
        static member inline slice = Interop.mkTilingAttr "packing" "slice"
        static member inline sliceDice = Interop.mkTilingAttr "packing" "slice-dice"
        static member inline squarify = Interop.mkTilingAttr "packing" "squarify"

    /// Determines if the positions obtained from solver are flipped on each axis.
    [<Erase>]
    type flip =
        static member inline x = Interop.mkTilingAttr "flip" "x"
        static member inline y = Interop.mkTilingAttr "flip" "y"

