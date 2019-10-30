namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type node =
    /// The shown name of the node.
    static member inline label (value: bool) = Interop.mkNodeAttr "label" value
    /// The shown name of the node.
    static member inline label (values: seq<bool>) = Interop.mkNodeAttr "label" (values |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (value: System.DateTime) = Interop.mkNodeAttr "label" value
    /// The shown name of the node.
    static member inline label (values: seq<System.DateTime>) = Interop.mkNodeAttr "label" (values |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (value: int) = Interop.mkNodeAttr "label" value
    /// The shown name of the node.
    static member inline label (values: seq<int>) = Interop.mkNodeAttr "label" (values |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (value: float) = Interop.mkNodeAttr "label" value
    /// The shown name of the node.
    static member inline label (values: seq<float>) = Interop.mkNodeAttr "label" (values |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (value: string) = Interop.mkNodeAttr "label" value
    /// The shown name of the node.
    static member inline label (values: seq<string>) = Interop.mkNodeAttr "label" (values |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<seq<bool>>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<bool list>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<bool []>) = Interop.mkNodeAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<seq<string>>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<string list>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<string []>) = Interop.mkNodeAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<seq<int>>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<int list>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<int []>) = Interop.mkNodeAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<seq<float>>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<float list>) = Interop.mkNodeAttr "label" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<float []>) = Interop.mkNodeAttr "label" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkNodeAttr "label" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// The shown name of the node.
    static member inline label (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkNodeAttr "label" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Groups of nodes. Each group is defined by an array with the indices of the nodes it contains. Multiple groups can be specified.
    static member inline groups (value: int) = Interop.mkNodeAttr "groups" (value |> Array.singleton)
    /// Groups of nodes. Each group is defined by an array with the indices of the nodes it contains. Multiple groups can be specified.
    static member inline groups (values: seq<int>) = Interop.mkNodeAttr "groups" (values |> Array.ofSeq)
    /// Groups of nodes. Each group is defined by an array with the indices of the nodes it contains. Multiple groups can be specified.
    static member inline groups (value: float) = Interop.mkNodeAttr "groups" (value |> Array.singleton)
    /// Groups of nodes. Each group is defined by an array with the indices of the nodes it contains. Multiple groups can be specified.
    static member inline groups (values: seq<float>) = Interop.mkNodeAttr "groups" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (value: bool) = Interop.mkNodeAttr "x" value
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<bool>) = Interop.mkNodeAttr "x" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (value: System.DateTime) = Interop.mkNodeAttr "x" value
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<System.DateTime>) = Interop.mkNodeAttr "x" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (value: int) = Interop.mkNodeAttr "x" value
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<int>) = Interop.mkNodeAttr "x" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (value: float) = Interop.mkNodeAttr "x" value
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<float>) = Interop.mkNodeAttr "x" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (value: string) = Interop.mkNodeAttr "x" value
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<string>) = Interop.mkNodeAttr "x" (values |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<seq<bool>>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<bool list>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<bool []>) = Interop.mkNodeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<seq<string>>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<string list>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<string []>) = Interop.mkNodeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<seq<int>>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<int list>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<int []>) = Interop.mkNodeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<seq<float>>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<float list>) = Interop.mkNodeAttr "x" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<float []>) = Interop.mkNodeAttr "x" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkNodeAttr "x" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// The normalized horizontal position of the node.
    static member inline x (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkNodeAttr "x" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (value: bool) = Interop.mkNodeAttr "y" value
    /// The normalized vertical position of the node.
    static member inline y (values: seq<bool>) = Interop.mkNodeAttr "y" (values |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (value: System.DateTime) = Interop.mkNodeAttr "y" value
    /// The normalized vertical position of the node.
    static member inline y (values: seq<System.DateTime>) = Interop.mkNodeAttr "y" (values |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (value: int) = Interop.mkNodeAttr "y" value
    /// The normalized vertical position of the node.
    static member inline y (values: seq<int>) = Interop.mkNodeAttr "y" (values |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (value: float) = Interop.mkNodeAttr "y" value
    /// The normalized vertical position of the node.
    static member inline y (values: seq<float>) = Interop.mkNodeAttr "y" (values |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (value: string) = Interop.mkNodeAttr "y" value
    /// The normalized vertical position of the node.
    static member inline y (values: seq<string>) = Interop.mkNodeAttr "y" (values |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<seq<bool>>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<bool list>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<bool []>) = Interop.mkNodeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<seq<string>>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<string list>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<string []>) = Interop.mkNodeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<seq<int>>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<int list>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<int []>) = Interop.mkNodeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<seq<float>>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<float list>) = Interop.mkNodeAttr "y" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<float []>) = Interop.mkNodeAttr "y" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<U4<int [], float [], string [], bool []>>) = Interop.mkNodeAttr "y" (values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)
    /// The normalized vertical position of the node.
    static member inline y (values: seq<U4<int list, float list, string list, bool list>>) = Interop.mkNodeAttr "y" (values |> Seq.map U4.mapListToResize |> Array.ofSeq)
    /// Sets the `node` color. It can be a single value, or an array for specifying color for each `node`. If `node.color` is omitted, then the default `Plotly` color palette will be cycled through to have a variety of colors. These defaults are not fully opaque, to allow some visibility of what is beneath the node.
    static member inline color (value: string) = Interop.mkNodeAttr "color" value
    /// Sets the `node` color. It can be a single value, or an array for specifying color for each `node`. If `node.color` is omitted, then the default `Plotly` color palette will be cycled through to have a variety of colors. These defaults are not fully opaque, to allow some visibility of what is beneath the node.
    static member inline color (values: seq<string>) = Interop.mkNodeAttr "color" (values |> Array.ofSeq)
    static member inline line (properties: #ILineProperty list) = Interop.mkNodeAttr "line" (createObj !!properties)
    /// Sets the padding (in px) between the `nodes`.
    static member inline pad (value: int) = Interop.mkNodeAttr "pad" value
    /// Sets the padding (in px) between the `nodes`.
    static member inline pad (value: float) = Interop.mkNodeAttr "pad" value
    /// Sets the thickness (in px) of the `nodes`.
    static member inline thickness (value: int) = Interop.mkNodeAttr "thickness" value
    /// Sets the thickness (in px) of the `nodes`.
    static member inline thickness (value: float) = Interop.mkNodeAttr "thickness" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkNodeAttr "hoverlabel" (createObj !!properties)
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkNodeAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkNodeAttr "hovertemplate" (values |> Array.ofSeq)
    /// Sets the source reference on plot.ly for  label .
    static member inline labelsrc (value: string) = Interop.mkNodeAttr "labelsrc" value
    /// Sets the source reference on plot.ly for  x .
    static member inline xsrc (value: string) = Interop.mkNodeAttr "xsrc" value
    /// Sets the source reference on plot.ly for  y .
    static member inline ysrc (value: string) = Interop.mkNodeAttr "ysrc" value
    /// Sets the source reference on plot.ly for  color .
    static member inline colorsrc (value: string) = Interop.mkNodeAttr "colorsrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkNodeAttr "hovertemplatesrc" value

[<AutoOpen>]
module node =
    /// Determines which trace information appear when hovering nodes. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkNodeAttr "hoverinfo" "all"
        static member inline none = Interop.mkNodeAttr "hoverinfo" "none"
        static member inline skip = Interop.mkNodeAttr "hoverinfo" "skip"

