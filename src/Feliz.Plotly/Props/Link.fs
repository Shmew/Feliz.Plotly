namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type link =
    /// The shown name of the link.
    static member inline label (value: bool) = Interop.mkLinkAttr "label" value
    /// The shown name of the link.
    static member inline label (values: seq<bool>) = Interop.mkLinkAttr "label" (values |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (value: System.DateTime) = Interop.mkLinkAttr "label" value
    /// The shown name of the link.
    static member inline label (values: seq<System.DateTime>) = Interop.mkLinkAttr "label" (values |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (value: int) = Interop.mkLinkAttr "label" value
    /// The shown name of the link.
    static member inline label (values: seq<int>) = Interop.mkLinkAttr "label" (values |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (value: float) = Interop.mkLinkAttr "label" value
    /// The shown name of the link.
    static member inline label (values: seq<float>) = Interop.mkLinkAttr "label" (values |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (value: string) = Interop.mkLinkAttr "label" value
    /// The shown name of the link.
    static member inline label (values: seq<string>) = Interop.mkLinkAttr "label" (values |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<seq<bool>>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<bool list>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<bool []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<seq<string>>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<string list>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<string []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<seq<int>>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<int list>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<int []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<seq<float>>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<float list>) = Interop.mkLinkAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<float []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkLinkAttr "label" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// The shown name of the link.
    static member inline label (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkLinkAttr "label" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (value: string) = Interop.mkLinkAttr "color" value
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (values: seq<string>) = Interop.mkLinkAttr "color" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkLinkAttr "line" (createObj !!properties)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: bool) = Interop.mkLinkAttr "source" value
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool>) = Interop.mkLinkAttr "source" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: System.DateTime) = Interop.mkLinkAttr "source" value
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<System.DateTime>) = Interop.mkLinkAttr "source" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: int) = Interop.mkLinkAttr "source" value
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int>) = Interop.mkLinkAttr "source" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: float) = Interop.mkLinkAttr "source" value
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float>) = Interop.mkLinkAttr "source" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: string) = Interop.mkLinkAttr "source" value
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string>) = Interop.mkLinkAttr "source" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<bool>>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool list>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<string>>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string list>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<int>>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int list>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<float>>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float list>) = Interop.mkLinkAttr "source" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkLinkAttr "source" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkLinkAttr "source" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: bool) = Interop.mkLinkAttr "target" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool>) = Interop.mkLinkAttr "target" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: System.DateTime) = Interop.mkLinkAttr "target" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<System.DateTime>) = Interop.mkLinkAttr "target" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: int) = Interop.mkLinkAttr "target" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int>) = Interop.mkLinkAttr "target" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: float) = Interop.mkLinkAttr "target" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float>) = Interop.mkLinkAttr "target" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: string) = Interop.mkLinkAttr "target" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string>) = Interop.mkLinkAttr "target" (values |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<bool>>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool list>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<string>>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string list>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<int>>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int list>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<float>>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float list>) = Interop.mkLinkAttr "target" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkLinkAttr "target" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkLinkAttr "target" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (value: bool) = Interop.mkLinkAttr "value" value
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool>) = Interop.mkLinkAttr "value" (values |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (value: System.DateTime) = Interop.mkLinkAttr "value" value
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<System.DateTime>) = Interop.mkLinkAttr "value" (values |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (value: int) = Interop.mkLinkAttr "value" value
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int>) = Interop.mkLinkAttr "value" (values |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (value: float) = Interop.mkLinkAttr "value" value
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float>) = Interop.mkLinkAttr "value" (values |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (value: string) = Interop.mkLinkAttr "value" value
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string>) = Interop.mkLinkAttr "value" (values |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<bool>>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool list>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<string>>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string list>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<int>>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int list>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<float>>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float list>) = Interop.mkLinkAttr "value" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkLinkAttr "value" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkLinkAttr "value" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkLinkAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkLinkAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkLinkAttr "hovertemplate" (values |> Array.ofSeq)
    static member inline colorscales (properties: #IColorscalesProperty list) = Interop.mkLinkAttr "colorscales" (createObj !!properties)
    /// Sets the source reference on plot.ly for  label .
    static member inline labelsrc (value: string) = Interop.mkLinkAttr "labelsrc" value
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkLinkAttr "colorsrc" value
    /// Sets the source reference on plot.ly for  source .
    static member inline sourcesrc (value: string) = Interop.mkLinkAttr "sourcesrc" value
    /// Sets the source reference on plot.ly for  target .
    static member inline targetsrc (value: string) = Interop.mkLinkAttr "targetsrc" value
    /// Sets the source reference on plot.ly for  value .
    static member inline valuesrc (value: string) = Interop.mkLinkAttr "valuesrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkLinkAttr "hovertemplatesrc" value

[<AutoOpen>]
module link =
    /// Determines which trace information appear when hovering links. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkLinkAttr "hoverinfo" "all"
        static member inline none = Interop.mkLinkAttr "hoverinfo" "none"
        static member inline skip = Interop.mkLinkAttr "hoverinfo" "skip"

