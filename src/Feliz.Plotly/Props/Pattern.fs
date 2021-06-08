namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type pattern =
    /// Sets the background color of the pattern fill. Defaults to a transparent background.
    static member inline bgcolor (value: string) = Interop.mkPatternAttr "bgcolor" value
    /// Sets the background color of the pattern fill. Defaults to a transparent background.
    static member inline bgcolor (values: seq<string>) = Interop.mkPatternAttr "bgcolor" (values |> ResizeArray)
    /// Sets the background color of the pattern fill. Defaults to a transparent background.
    static member inline bgcolor (values: seq<int>) = Interop.mkPatternAttr "bgcolor" (values |> ResizeArray)
    /// Sets the background color of the pattern fill. Defaults to a transparent background.
    static member inline bgcolor (values: seq<float>) = Interop.mkPatternAttr "bgcolor" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  bgcolor .
    static member inline bgcolorsrc (value: string) = Interop.mkPatternAttr "bgcolorsrc" value
    /// Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
    static member inline shape (properties: #IPatternProperty list) = Interop.mkPatternAttr "shape" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  shape .
    static member inline shapesrc (value: string) = Interop.mkPatternAttr "shapesrc" value
    /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
    static member inline size (value: int) = Interop.mkPatternAttr "size" value
    /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
    static member inline size (value: float) = Interop.mkPatternAttr "size" value
    /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
    static member inline size (values: seq<int>) = Interop.mkPatternAttr "size" (values |> ResizeArray)
    /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
    static member inline size (values: seq<float>) = Interop.mkPatternAttr "size" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  size .
    static member inline sizesrc (value: string) = Interop.mkPatternAttr "sizesrc" value
    /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
    static member inline solidity (value: int) = Interop.mkPatternAttr "solidity" value
    /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
    static member inline solidity (value: float) = Interop.mkPatternAttr "solidity" value
    /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
    static member inline solidity (values: seq<int>) = Interop.mkPatternAttr "solidity" (values |> ResizeArray)
    /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
    static member inline solidity (values: seq<float>) = Interop.mkPatternAttr "solidity" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  solidity .
    static member inline soliditysrc (value: string) = Interop.mkPatternAttr "soliditysrc" value

[<Erase;RequireQualifiedAccess>]
module pattern =
    /// Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
    [<Erase>]
    type shape =
        static member inline blank = Interop.mkPatternAttr "shape" ""
        static member inline cross = Interop.mkPatternAttr "shape" "+"
        static member inline horizontalLine = Interop.mkPatternAttr "shape" "-"
        static member inline dot = Interop.mkPatternAttr "shape" "."
        static member inline rightDiagonalLine = Interop.mkPatternAttr "shape" "/"
        static member inline leftDiagonalLine = Interop.mkPatternAttr "shape" "\\"
        static member inline diagonalCross = Interop.mkPatternAttr "shape" "x"
        static member inline verticalLine = Interop.mkPatternAttr "shape" "|"

