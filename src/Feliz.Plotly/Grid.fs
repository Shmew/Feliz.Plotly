namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type grid =
    /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
    static member inline columns (value: int) = Interop.mkGridAttr "columns" value
    static member inline domain (properties: #IDomainProperty list) = Interop.mkGridAttr "domain" (createObj !!properties)
    /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
    static member inline rows (value: int) = Interop.mkGridAttr "rows" value
    /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
    static member inline xgap (value: int) = Interop.mkGridAttr "xgap" value
    /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
    static member inline xgap (value: float) = Interop.mkGridAttr "xgap" value
    /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
    static member inline ygap (value: int) = Interop.mkGridAttr "ygap" value
    /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
    static member inline ygap (value: float) = Interop.mkGridAttr "ygap" value

[<RequireQualifiedAccess>]
module grid =
    /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
    [<Erase>]
    type pattern =
        static member inline coupled = Interop.mkGridAttr "pattern" "coupled"
        static member inline independent = Interop.mkGridAttr "pattern" "independent"

    /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
    [<Erase>]
    type roworder =
        static member inline bottomToTop = Interop.mkGridAttr "roworder" "bottom to top"
        static member inline topToBottom = Interop.mkGridAttr "roworder" "top to bottom"

    /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
    [<Erase>]
    type xside =
        static member inline bottomPlot = Interop.mkGridAttr "xside" "bottom plot"
        static member inline bottom = Interop.mkGridAttr "xside" "bottom"
        static member inline topPlot = Interop.mkGridAttr "xside" "top plot"
        static member inline top = Interop.mkGridAttr "xside" "top"

    /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
    [<Erase>]
    type yside =
        static member inline leftPlot = Interop.mkGridAttr "yside" "left plot"
        static member inline left = Interop.mkGridAttr "yside" "left"
        static member inline rightPlot = Interop.mkGridAttr "yside" "right plot"
        static member inline right = Interop.mkGridAttr "yside" "right"

