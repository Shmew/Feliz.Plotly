namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type cells =
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool>) = Interop.mkCellsAttr "values" (values |> Array.ofSeq)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string>) = Interop.mkCellsAttr "values" (values |> Array.ofSeq)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int>) = Interop.mkCellsAttr "values" (values |> Array.ofSeq)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float>) = Interop.mkCellsAttr "values" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool>) = Interop.mkCellsAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string>) = Interop.mkCellsAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int>) = Interop.mkCellsAttr "format" (values |> Array.ofSeq)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float>) = Interop.mkCellsAttr "format" (values |> Array.ofSeq)
    /// Prefix for cell values.
    static member inline prefix (value: string) = Interop.mkCellsAttr "prefix" value
    /// Prefix for cell values.
    static member inline prefix (values: seq<string>) = Interop.mkCellsAttr "prefix" (values |> Array.ofSeq)
    /// Suffix for cell values.
    static member inline suffix (value: string) = Interop.mkCellsAttr "suffix" value
    /// Suffix for cell values.
    static member inline suffix (values: seq<string>) = Interop.mkCellsAttr "suffix" (values |> Array.ofSeq)
    /// The height of cells.
    static member inline height (value: int) = Interop.mkCellsAttr "height" value
    /// The height of cells.
    static member inline height (value: float) = Interop.mkCellsAttr "height" value
    static member inline line (properties: #ILineProperty list) = Interop.mkCellsAttr "line" (createObj !!properties)
    static member inline fill (properties: #IFillProperty list) = Interop.mkCellsAttr "fill" (createObj !!properties)
    static member inline font (properties: #IFontProperty list) = Interop.mkCellsAttr "font" (createObj !!properties)
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkCellsAttr "valuessrc" value
    /// Sets the source reference on plot.ly for  format .
    static member inline formatsrc (value: string) = Interop.mkCellsAttr "formatsrc" value
    /// Sets the source reference on plot.ly for  prefix .
    static member inline prefixsrc (value: string) = Interop.mkCellsAttr "prefixsrc" value
    /// Sets the source reference on plot.ly for  suffix .
    static member inline suffixsrc (value: string) = Interop.mkCellsAttr "suffixsrc" value
    /// Sets the source reference on plot.ly for  align .
    static member inline alignsrc (value: string) = Interop.mkCellsAttr "alignsrc" value

[<AutoOpen>]
module cells =
    /// Use a list of enumerated values
    let inline aligns (properties: #ICellsProperty list) = properties |> List.map (Bindings.getKV >> snd) |> ResizeArray |> Interop.mkCellsAttr "align"

    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans more two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    [<Erase>]
    type align =
        static member inline center = Interop.mkCellsAttr "align" "center"
        static member inline left = Interop.mkCellsAttr "align" "left"
        static member inline right = Interop.mkCellsAttr "align" "right"

