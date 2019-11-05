namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type legend =
    /// Sets the legend background color.
    static member inline bgcolor (value: string) = Interop.mkLegendAttr "bgcolor" value
    /// Sets the color of the border enclosing the legend.
    static member inline bordercolor (value: string) = Interop.mkLegendAttr "bordercolor" value
    /// Sets the width (in px) of the border enclosing the legend.
    static member inline borderwidth (value: int) = Interop.mkLegendAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the legend.
    static member inline borderwidth (value: float) = Interop.mkLegendAttr "borderwidth" value
    /// Sets the font used to text the legend items.
    static member inline font (properties: #IFontProperty list) = Interop.mkLegendAttr "font" (createObj !!properties)
    /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
    static member inline traceorder (properties: #ILegendProperty list) = Interop.mkLegendAttr "traceorder" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the amount of vertical space (in px) between legend groups.
    static member inline tracegroupgap (value: int) = Interop.mkLegendAttr "tracegroupgap" value
    /// Sets the amount of vertical space (in px) between legend groups.
    static member inline tracegroupgap (value: float) = Interop.mkLegendAttr "tracegroupgap" value
    /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
    static member inline x (value: int) = Interop.mkLegendAttr "x" value
    /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
    static member inline x (value: float) = Interop.mkLegendAttr "x" value
    /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
    static member inline y (value: int) = Interop.mkLegendAttr "y" value
    /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
    static member inline y (value: float) = Interop.mkLegendAttr "y" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (value: bool) = Interop.mkLegendAttr "uirevision" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<bool>) = Interop.mkLegendAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (value: System.DateTime) = Interop.mkLegendAttr "uirevision" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkLegendAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (value: int) = Interop.mkLegendAttr "uirevision" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<int>) = Interop.mkLegendAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (value: float) = Interop.mkLegendAttr "uirevision" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<float>) = Interop.mkLegendAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (value: string) = Interop.mkLegendAttr "uirevision" value
    /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
    static member inline uirevision (values: seq<string>) = Interop.mkLegendAttr "uirevision" (values |> Array.ofSeq)

[<AutoOpen>]
module legend =
    /// Sets the orientation of the legend.
    [<Erase>]
    type orientation =
        static member inline h = Interop.mkLegendAttr "orientation" "h"
        static member inline v = Interop.mkLegendAttr "orientation" "v"

    /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
    [<Erase>]
    type traceorder =
        static member inline normal = Interop.mkLegendAttr "traceorder" "normal"
        static member inline grouped = Interop.mkLegendAttr "traceorder" "grouped"
        static member inline reversed = Interop.mkLegendAttr "traceorder" "reversed"

    /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
    [<Erase>]
    type itemsizing =
        static member inline constant = Interop.mkLegendAttr "itemsizing" "constant"
        static member inline trace = Interop.mkLegendAttr "itemsizing" "trace"

    /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
    [<Erase>]
    type itemclick =
        static member inline toggle = Interop.mkLegendAttr "itemclick" "toggle"
        static member inline toggleothers = Interop.mkLegendAttr "itemclick" "toggleothers"
        static member inline false' = Interop.mkLegendAttr "itemclick" false

    /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
    [<Erase>]
    type itemdoubleclick =
        static member inline toggle = Interop.mkLegendAttr "itemdoubleclick" "toggle"
        static member inline toggleothers = Interop.mkLegendAttr "itemdoubleclick" "toggleothers"
        static member inline false' = Interop.mkLegendAttr "itemdoubleclick" false

    /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkLegendAttr "xanchor" "auto"
        static member inline center = Interop.mkLegendAttr "xanchor" "center"
        static member inline left = Interop.mkLegendAttr "xanchor" "left"
        static member inline right = Interop.mkLegendAttr "xanchor" "right"

    /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkLegendAttr "yanchor" "auto"
        static member inline bottom = Interop.mkLegendAttr "yanchor" "bottom"
        static member inline middle = Interop.mkLegendAttr "yanchor" "middle"
        static member inline top = Interop.mkLegendAttr "yanchor" "top"

    /// Sets the vertical alignment of the symbols with respect to their associated text.
    [<Erase>]
    type valign =
        static member inline bottom = Interop.mkLegendAttr "valign" "bottom"
        static member inline middle = Interop.mkLegendAttr "valign" "middle"
        static member inline top = Interop.mkLegendAttr "valign" "top"

