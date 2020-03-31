namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type link =
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (value: string) = Interop.mkLinkAttr "color" value
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (values: seq<string>) = Interop.mkLinkAttr "color" (values |> ResizeArray)
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (values: seq<int>) = Interop.mkLinkAttr "color" (values |> ResizeArray)
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    static member inline color (values: seq<float>) = Interop.mkLinkAttr "color" (values |> ResizeArray)
    static member inline colorscales (properties: #IColorscalesProperty list) = Interop.mkLinkAttr "colorscales" (createObj !!properties)
    /// Sets the source reference on Chart Studio Cloud for  color .
    static member inline colorsrc (value: string) = Interop.mkLinkAttr "colorsrc" value
    /// Assigns extra data to each link.
    static member inline customdata (value: bool) = Interop.mkLinkAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<bool>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (value: System.DateTime) = Interop.mkLinkAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (value: float) = Interop.mkLinkAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<float>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (value: int) = Interop.mkLinkAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<int>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (value: string) = Interop.mkLinkAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<string>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<bool list>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<bool []>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<seq<string>>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<string list>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<string []>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<seq<int>>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<int list>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<int []>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<seq<float>>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<float list>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<float []>) = Interop.mkLinkAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<PlotData>) = Interop.mkLinkAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<bool option>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<int option>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<float option>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data to each link.
    static member inline customdata (values: seq<string option>) = Interop.mkLinkAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkLinkAttr "customdatasrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkLinkAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkLinkAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkLinkAttr "hovertemplate" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkLinkAttr "hovertemplatesrc" value
    /// The shown name of the link.
    static member inline label (value: bool) = Interop.mkLinkAttr "label" (value |> Array.singleton)
    /// The shown name of the link.
    static member inline label (values: seq<bool>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (value: System.DateTime) = Interop.mkLinkAttr "label" (value |> Array.singleton)
    /// The shown name of the link.
    static member inline label (values: seq<System.DateTime>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (value: float) = Interop.mkLinkAttr "label" (value |> Array.singleton)
    /// The shown name of the link.
    static member inline label (values: seq<float>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (value: int) = Interop.mkLinkAttr "label" (value |> Array.singleton)
    /// The shown name of the link.
    static member inline label (values: seq<int>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (value: string) = Interop.mkLinkAttr "label" (value |> Array.singleton)
    /// The shown name of the link.
    static member inline label (values: seq<string>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<seq<bool>>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<bool list>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<bool []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<seq<string>>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<string list>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<string []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<seq<int>>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<int list>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<int []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<seq<float>>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<float list>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<float []>) = Interop.mkLinkAttr "label" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<PlotData>) = Interop.mkLinkAttr "label" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<bool option>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<System.DateTime option>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<int option>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<float option>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// The shown name of the link.
    static member inline label (values: seq<string option>) = Interop.mkLinkAttr "label" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  label .
    static member inline labelsrc (value: string) = Interop.mkLinkAttr "labelsrc" value
    static member inline line (properties: #ILineProperty list) = Interop.mkLinkAttr "line" (createObj !!properties)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: bool) = Interop.mkLinkAttr "source" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: System.DateTime) = Interop.mkLinkAttr "source" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<System.DateTime>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: float) = Interop.mkLinkAttr "source" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: int) = Interop.mkLinkAttr "source" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (value: string) = Interop.mkLinkAttr "source" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<bool>>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool list>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<string>>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string list>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<int>>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int list>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<seq<float>>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float list>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float []>) = Interop.mkLinkAttr "source" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<PlotData>) = Interop.mkLinkAttr "source" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<bool option>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<System.DateTime option>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<int option>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<float option>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the source node.
    static member inline source (values: seq<string option>) = Interop.mkLinkAttr "source" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  source .
    static member inline sourcesrc (value: string) = Interop.mkLinkAttr "sourcesrc" value
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: bool) = Interop.mkLinkAttr "target" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: System.DateTime) = Interop.mkLinkAttr "target" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<System.DateTime>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: float) = Interop.mkLinkAttr "target" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: int) = Interop.mkLinkAttr "target" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (value: string) = Interop.mkLinkAttr "target" (value |> Array.singleton)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<bool>>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool list>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<string>>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string list>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<int>>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int list>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<seq<float>>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float list>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float []>) = Interop.mkLinkAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<PlotData>) = Interop.mkLinkAttr "target" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<bool option>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<System.DateTime option>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<int option>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<float option>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    static member inline target (values: seq<string option>) = Interop.mkLinkAttr "target" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  target .
    static member inline targetsrc (value: string) = Interop.mkLinkAttr "targetsrc" value
    /// A numeric value representing the flow volume value.
    static member inline value (value: bool) = Interop.mkLinkAttr "value" (value |> Array.singleton)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (value: System.DateTime) = Interop.mkLinkAttr "value" (value |> Array.singleton)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<System.DateTime>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (value: float) = Interop.mkLinkAttr "value" (value |> Array.singleton)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (value: int) = Interop.mkLinkAttr "value" (value |> Array.singleton)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (value: string) = Interop.mkLinkAttr "value" (value |> Array.singleton)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<bool>>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool list>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<string>>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string list>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<int>>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int list>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<seq<float>>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float list>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float []>) = Interop.mkLinkAttr "value" (values |> Seq.map ResizeArray |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<PlotData>) = Interop.mkLinkAttr "value" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<bool option>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<System.DateTime option>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<int option>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<float option>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// A numeric value representing the flow volume value.
    static member inline value (values: seq<string option>) = Interop.mkLinkAttr "value" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  value .
    static member inline valuesrc (value: string) = Interop.mkLinkAttr "valuesrc" value

[<RequireQualifiedAccess>]
module link =
    /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
    [<Erase>]
    type color =
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        static member inline rgb (r,g,b) = Interop.mkLinkAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        static member inline rgba (r,g,b,a) = Interop.mkLinkAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        static member inline hsl (h,s,l) = Interop.mkLinkAttr "color" (Feliz.color.hsl(h,s,l))

    /// Determines which trace information appear when hovering links. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkLinkAttr "hoverinfo" "all"
        static member inline none = Interop.mkLinkAttr "hoverinfo" "none"
        static member inline skip = Interop.mkLinkAttr "hoverinfo" "skip"

    /// An integer number `[0..nodes.length - 1]` that represents the target node.
    [<Erase>]
    type target =
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline i = Interop.mkLinkAttr "target" "i"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline j = Interop.mkLinkAttr "target" "j"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline k = Interop.mkLinkAttr "target" "k"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline u = Interop.mkLinkAttr "target" "u"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline v = Interop.mkLinkAttr "target" "v"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline w = Interop.mkLinkAttr "target" "w"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline x = Interop.mkLinkAttr "target" "x"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline y = Interop.mkLinkAttr "target" "y"
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        static member inline z = Interop.mkLinkAttr "target" "z"

