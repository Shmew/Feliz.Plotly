namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type header =
    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    static member inline align (properties: #IHeaderProperty list) = Interop.mkHeaderAttr "align" (properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  align .
    static member inline alignsrc (value: string) = Interop.mkHeaderAttr "alignsrc" value
    static member inline fill (properties: #IFillProperty list) = Interop.mkHeaderAttr "fill" (createObj !!properties)
    static member inline font (properties: #IFontProperty list) = Interop.mkHeaderAttr "font" (createObj !!properties)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: bool) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: System.DateTime) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTime>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: float) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: int) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (value: string) = Interop.mkHeaderAttr "format" (value |> Array.singleton)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<bool>>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool list>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool []>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<string>>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string list>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string []>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<int>>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int list>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int []>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<seq<float>>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float list>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float []>) = Interop.mkHeaderAttr "format" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<PlotData>) = Interop.mkHeaderAttr "format" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<bool option>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<System.DateTime option>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<int option>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<float option>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
    static member inline format (values: seq<string option>) = Interop.mkHeaderAttr "format" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  format .
    static member inline formatsrc (value: string) = Interop.mkHeaderAttr "formatsrc" value
    /// The height of cells.
    static member inline height (value: int) = Interop.mkHeaderAttr "height" value
    /// The height of cells.
    static member inline height (value: float) = Interop.mkHeaderAttr "height" value
    static member inline line (properties: #ILineProperty list) = Interop.mkHeaderAttr "line" (createObj !!properties)
    /// Prefix for cell values.
    static member inline prefix (value: string) = Interop.mkHeaderAttr "prefix" value
    /// Prefix for cell values.
    static member inline prefix (values: seq<string>) = Interop.mkHeaderAttr "prefix" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  prefix .
    static member inline prefixsrc (value: string) = Interop.mkHeaderAttr "prefixsrc" value
    /// Suffix for cell values.
    static member inline suffix (value: string) = Interop.mkHeaderAttr "suffix" value
    /// Suffix for cell values.
    static member inline suffix (values: seq<string>) = Interop.mkHeaderAttr "suffix" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  suffix .
    static member inline suffixsrc (value: string) = Interop.mkHeaderAttr "suffixsrc" value
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: bool) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: System.DateTime) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTime>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: float) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: int) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (value: string) = Interop.mkHeaderAttr "values" (value |> Array.singleton)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<bool>>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool list>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool []>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<string>>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string list>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string []>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<int>>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int list>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int []>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<seq<float>>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float list>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float []>) = Interop.mkHeaderAttr "values" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<PlotData>) = Interop.mkHeaderAttr "values" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<bool option>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<System.DateTime option>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<int option>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<float option>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
    static member inline values (values: seq<string option>) = Interop.mkHeaderAttr "values" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  values .
    static member inline valuessrc (value: string) = Interop.mkHeaderAttr "valuessrc" value

[<RequireQualifiedAccess>]
module header =
    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    [<Erase>]
    type align =
        static member inline center = Interop.mkHeaderAttr "align" "center"
        static member inline left = Interop.mkHeaderAttr "align" "left"
        static member inline right = Interop.mkHeaderAttr "align" "right"

