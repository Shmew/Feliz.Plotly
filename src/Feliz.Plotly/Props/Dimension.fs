namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type dimension =
    /// Determines whether or not this dimension is shown on the graph. Note that even visible false dimension contribute to the default grid generate by this splom trace.
    static member inline visible (value: bool) = Interop.mkDimensionAttr "visible" value
    /// Sets the label corresponding to this splom dimension.
    static member inline label (value: string) = Interop.mkDimensionAttr "label" value
    /// Sets the dimension values to be plotted.
    static member inline values (value: bool) = Interop.mkDimensionAttr "values" value
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<bool>) = Interop.mkDimensionAttr "values" (values |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (value: System.DateTime) = Interop.mkDimensionAttr "values" value
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<System.DateTime>) = Interop.mkDimensionAttr "values" (values |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (value: int) = Interop.mkDimensionAttr "values" value
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<int>) = Interop.mkDimensionAttr "values" (values |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (value: float) = Interop.mkDimensionAttr "values" value
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<float>) = Interop.mkDimensionAttr "values" (values |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (value: string) = Interop.mkDimensionAttr "values" value
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<string>) = Interop.mkDimensionAttr "values" (values |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<seq<bool>>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<bool list>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<bool []>) = Interop.mkDimensionAttr "values" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<seq<string>>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<string list>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<string []>) = Interop.mkDimensionAttr "values" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<seq<int>>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<int list>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<int option []>) = Interop.mkDimensionAttr "values" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<seq<float>>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<float list>) = Interop.mkDimensionAttr "values" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<float []>) = Interop.mkDimensionAttr "values" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDimensionAttr "values" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDimensionAttr "values" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<bool option>) = Interop.mkDimensionAttr "values" (values |> ResizeArray)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<System.DateTime option>) = Interop.mkDimensionAttr "values" (values |> ResizeArray)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<int option>) = Interop.mkDimensionAttr "values" (values |> ResizeArray)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<float option>) = Interop.mkDimensionAttr "values" (values |> ResizeArray)
    /// Sets the dimension values to be plotted.
    static member inline values (values: seq<string option>) = Interop.mkDimensionAttr "values" (values |> ResizeArray)
    static member inline axis (properties: #IAxisProperty list) = Interop.mkDimensionAttr "axis" (createObj !!properties)
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkDimensionAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkDimensionAttr "templateitemname" value
    /// Sets the source reference on plot.ly for  values .
    static member inline valuessrc (value: string) = Interop.mkDimensionAttr "valuessrc" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (value: bool) = Interop.mkDimensionAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<bool>) = Interop.mkDimensionAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (value: System.DateTime) = Interop.mkDimensionAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<System.DateTime>) = Interop.mkDimensionAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (value: int) = Interop.mkDimensionAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<int>) = Interop.mkDimensionAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (value: float) = Interop.mkDimensionAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<float>) = Interop.mkDimensionAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (value: string) = Interop.mkDimensionAttr "tickvals" value
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<string>) = Interop.mkDimensionAttr "tickvals" (values |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<seq<bool>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<bool list>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<bool []>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<seq<string>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<string list>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<string []>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<seq<int>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<int list>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<int option []>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<seq<float>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<float list>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<float []>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDimensionAttr "tickvals" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<bool option>) = Interop.mkDimensionAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<System.DateTime option>) = Interop.mkDimensionAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<int option>) = Interop.mkDimensionAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<float option>) = Interop.mkDimensionAttr "tickvals" (values |> ResizeArray)
    /// Sets the values at which ticks on this axis appear.
    static member inline tickvals (values: seq<string option>) = Interop.mkDimensionAttr "tickvals" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (value: bool) = Interop.mkDimensionAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<bool>) = Interop.mkDimensionAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (value: System.DateTime) = Interop.mkDimensionAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<System.DateTime>) = Interop.mkDimensionAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (value: int) = Interop.mkDimensionAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<int>) = Interop.mkDimensionAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (value: float) = Interop.mkDimensionAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<float>) = Interop.mkDimensionAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (value: string) = Interop.mkDimensionAttr "ticktext" value
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<string>) = Interop.mkDimensionAttr "ticktext" (values |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<seq<bool>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<bool list>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<bool []>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<seq<string>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<string list>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<string []>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<seq<int>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<int list>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<int option []>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<seq<float>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<float list>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<float []>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDimensionAttr "ticktext" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<bool option>) = Interop.mkDimensionAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<System.DateTime option>) = Interop.mkDimensionAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<int option>) = Interop.mkDimensionAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<float option>) = Interop.mkDimensionAttr "ticktext" (values |> ResizeArray)
    /// Sets the text displayed at the ticks position via `tickvals`.
    static member inline ticktext (values: seq<string option>) = Interop.mkDimensionAttr "ticktext" (values |> ResizeArray)
    /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
    static member inline tickformat (value: string) = Interop.mkDimensionAttr "tickformat" value
    /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
    static member inline range (value: int) = Interop.mkDimensionAttr "range" (value |> Array.singleton |> ResizeArray)
    /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
    static member inline range (values: seq<int>) = Interop.mkDimensionAttr "range" (values |> ResizeArray)
    /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
    static member inline range (value: float) = Interop.mkDimensionAttr "range" (value |> Array.singleton |> ResizeArray)
    /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
    static member inline range (values: seq<float>) = Interop.mkDimensionAttr "range" (values |> ResizeArray)
    /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <= toValue`, or if `multiselect` is not disabled, you may give an array of arrays, where each inner array is `[fromValue, toValue]`.
    static member inline constraintrange (value: int) = Interop.mkDimensionAttr "constraintrange" (value |> Array.singleton |> ResizeArray)
    /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <= toValue`, or if `multiselect` is not disabled, you may give an array of arrays, where each inner array is `[fromValue, toValue]`.
    static member inline constraintrange (values: seq<int>) = Interop.mkDimensionAttr "constraintrange" (values |> ResizeArray)
    /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <= toValue`, or if `multiselect` is not disabled, you may give an array of arrays, where each inner array is `[fromValue, toValue]`.
    static member inline constraintrange (value: float) = Interop.mkDimensionAttr "constraintrange" (value |> Array.singleton |> ResizeArray)
    /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <= toValue`, or if `multiselect` is not disabled, you may give an array of arrays, where each inner array is `[fromValue, toValue]`.
    static member inline constraintrange (values: seq<float>) = Interop.mkDimensionAttr "constraintrange" (values |> ResizeArray)
    /// Do we allow multiple selection ranges or just a single range?
    static member inline multiselect (value: bool) = Interop.mkDimensionAttr "multiselect" value
    /// Sets the source reference on plot.ly for  tickvals .
    static member inline tickvalssrc (value: string) = Interop.mkDimensionAttr "tickvalssrc" value
    /// Sets the source reference on plot.ly for  ticktext .
    static member inline ticktextsrc (value: string) = Interop.mkDimensionAttr "ticktextsrc" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: bool) = Interop.mkDimensionAttr "categoryarray" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool>) = Interop.mkDimensionAttr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: System.DateTime) = Interop.mkDimensionAttr "categoryarray" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime>) = Interop.mkDimensionAttr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: int) = Interop.mkDimensionAttr "categoryarray" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int>) = Interop.mkDimensionAttr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: float) = Interop.mkDimensionAttr "categoryarray" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float>) = Interop.mkDimensionAttr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (value: string) = Interop.mkDimensionAttr "categoryarray" value
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string>) = Interop.mkDimensionAttr "categoryarray" (values |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<bool>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool list>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool []>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<string>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string list>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string []>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<int>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int list>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option []>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<seq<float>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float list>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float []>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkDimensionAttr "categoryarray" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<bool option>) = Interop.mkDimensionAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<System.DateTime option>) = Interop.mkDimensionAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<int option>) = Interop.mkDimensionAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<float option>) = Interop.mkDimensionAttr "categoryarray" (values |> ResizeArray)
    /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
    static member inline categoryarray (values: seq<string option>) = Interop.mkDimensionAttr "categoryarray" (values |> ResizeArray)
    /// The display index of dimension, from left to right, zero indexed, defaults to dimension index.
    static member inline displayindex (value: int) = Interop.mkDimensionAttr "displayindex" value
    /// Sets the source reference on plot.ly for  categoryarray .
    static member inline categoryarraysrc (value: string) = Interop.mkDimensionAttr "categoryarraysrc" value

[<AutoOpen>]
module dimension =
    /// Specifies the ordering logic for the categories in the dimension. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
    [<Erase>]
    type categoryorder =
        static member inline array = Interop.mkDimensionAttr "categoryorder" "array"
        static member inline categoryAscending = Interop.mkDimensionAttr "categoryorder" "category ascending"
        static member inline categoryDescending = Interop.mkDimensionAttr "categoryorder" "category descending"
        static member inline trace = Interop.mkDimensionAttr "categoryorder" "trace"

