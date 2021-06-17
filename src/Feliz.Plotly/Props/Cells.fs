namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type cells =
    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    static member inline align (properties: #ICellsProperty list) = Interop.mkCellsAttr "align" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  align .
    static member inline alignsrc (value: string) = Interop.mkCellsAttr "alignsrc" value
    static member inline fill (properties: #IFillProperty list) = Interop.mkCellsAttr "fill" (createObj !!properties)
    static member inline font (properties: #IFontProperty list) = Interop.mkCellsAttr "font" (createObj !!properties)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: bool) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: System.DateTime) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: System.DateTimeOffset) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTime>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTimeOffset>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: float) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: int) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: string) = Interop.mkCellsAttr "format" (value |> Array.singleton |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<bool>>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool list>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool []>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<string>>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string list>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string []>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<int>>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int list>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int []>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<float>>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float list>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float []>) = Interop.mkCellsAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<PlotData>) = Interop.mkCellsAttr "format" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTime option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTimeOffset option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string option>) = Interop.mkCellsAttr "format" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  format .
    static member inline formatsrc (value: string) = Interop.mkCellsAttr "formatsrc" value
    /// The height of cells.
    static member inline height (value: int) = Interop.mkCellsAttr "height" value
    /// The height of cells.
    static member inline height (value: float) = Interop.mkCellsAttr "height" value
    static member inline line (properties: #ILineProperty list) = Interop.mkCellsAttr "line" (createObj !!properties)
    /// Prefix for cell values.
    static member inline prefix (value: string) = Interop.mkCellsAttr "prefix" value
    /// Prefix for cell values.
    static member inline prefix (values: seq<string>) = Interop.mkCellsAttr "prefix" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  prefix .
    static member inline prefixsrc (value: string) = Interop.mkCellsAttr "prefixsrc" value
    /// Suffix for cell values.
    static member inline suffix (value: string) = Interop.mkCellsAttr "suffix" value
    /// Suffix for cell values.
    static member inline suffix (values: seq<string>) = Interop.mkCellsAttr "suffix" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  suffix .
    static member inline suffixsrc (value: string) = Interop.mkCellsAttr "suffixsrc" value
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: bool) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: System.DateTime) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: System.DateTimeOffset) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTime>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTimeOffset>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: float) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: int) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: string) = Interop.mkCellsAttr "values" (value |> Array.singleton |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<bool>>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool list>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool []>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<string>>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string list>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string []>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<int>>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int list>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int []>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<float>>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float list>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float []>) = Interop.mkCellsAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<PlotData>) = Interop.mkCellsAttr "values" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTime option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTimeOffset option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string option>) = Interop.mkCellsAttr "values" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  values .
    static member inline valuessrc (value: string) = Interop.mkCellsAttr "valuessrc" value

[<Erase;RequireQualifiedAccess>]
module cells =
    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    [<Erase>]
    type align =
        static member inline center = Interop.mkCellsAttr "align" "center"
        static member inline left = Interop.mkCellsAttr "align" "left"
        static member inline right = Interop.mkCellsAttr "align" "right"

