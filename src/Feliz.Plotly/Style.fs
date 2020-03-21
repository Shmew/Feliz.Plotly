namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type style =
    /// The group value which receives these styles.
    static member inline target (value: string) = Interop.mkStyleAttr "target" value
    /// The group value which receives these styles.
    static member inline target (values: seq<string>) = Interop.mkStyleAttr "target" (values |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<string option>) = Interop.mkStyleAttr "target" (values |> Seq.map Bindings.optToString |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<string>>) = Interop.mkStyleAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<string option>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<string list>) = Interop.mkStyleAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<string option list>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<string []>) = Interop.mkStyleAttr "target" (values |> Seq.map ResizeArray |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<string option []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int>) = Interop.mkStyleAttr "target" (values |> Seq.map string |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int option>) = Interop.mkStyleAttr "target" (values |> Seq.map Bindings.optToString |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<int>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<int option>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int option list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<int option []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float>) = Interop.mkStyleAttr "target" (values |> Seq.map string |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float option>) = Interop.mkStyleAttr "target" (values |> Seq.map Bindings.optToString |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<float>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<float option>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float option list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<float option []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<System.DateTime>) = Interop.mkStyleAttr "target" (values |> Seq.map string |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<System.DateTime option>) = Interop.mkStyleAttr "target" (values |> Seq.map Bindings.optToString |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool>) = Interop.mkStyleAttr "target" (values |> Seq.map string |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool option>) = Interop.mkStyleAttr "target" (values |> Seq.map Bindings.optToString |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<bool>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<seq<bool option>>) = Interop.mkStyleAttr "target" (values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool option list>) = Interop.mkStyleAttr "target" (values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)
    /// The group value which receives these styles.
    static member inline target (values: seq<bool option []>) = Interop.mkStyleAttr "target" (values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatterProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IBarProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IBoxProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IHeatmapProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IHistogramProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IHistogram2dProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IHistogram2dcontourProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IContourProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatterternaryProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IViolinProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IFunnelProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IWaterfallProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IImageProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IPieProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ISunburstProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ITreemapProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IFunnelareaProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatter3dProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ISurfaceProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IIsosurfaceProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IVolumeProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IMesh3dProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IConeProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IStreamtubeProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScattergeoProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IChoroplethProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatterglProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ISplomProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IPointcloudProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IHeatmapglProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IParcoordsProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IParcatsProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScattermapboxProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IChoroplethmapboxProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IDensitymapboxProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ISankeyProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IIndicatorProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ITableProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ICarpetProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScattercarpetProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IContourcarpetProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IOhlcProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: ICandlestickProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatterpolarProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IScatterpolarglProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IBarpolarProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (properties: IAreaProperty list) = Interop.mkStyleAttr "value" (createObj !!properties)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: bool) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<bool>) = Interop.mkStyleAttr "value" (values |> ResizeArray)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: System.DateTime) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<System.DateTime>) = Interop.mkStyleAttr "value" (values |> ResizeArray)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: int) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<int>) = Interop.mkStyleAttr "value" (values |> ResizeArray)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: float) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<float>) = Interop.mkStyleAttr "value" (values |> ResizeArray)
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (value: string) = Interop.mkStyleAttr "value" value
    /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
    static member inline value (values: seq<string>) = Interop.mkStyleAttr "value" (values |> ResizeArray)

[<RequireQualifiedAccess>]
module style =
    /// The group value which receives these styles.
    [<Erase>]
    type target =
        /// The group value which receives these styles.
        static member inline i = Interop.mkStyleAttr "target" "i"
        /// The group value which receives these styles.
        static member inline j = Interop.mkStyleAttr "target" "j"
        /// The group value which receives these styles.
        static member inline k = Interop.mkStyleAttr "target" "k"
        /// The group value which receives these styles.
        static member inline u = Interop.mkStyleAttr "target" "u"
        /// The group value which receives these styles.
        static member inline v = Interop.mkStyleAttr "target" "v"
        /// The group value which receives these styles.
        static member inline w = Interop.mkStyleAttr "target" "w"
        /// The group value which receives these styles.
        static member inline x = Interop.mkStyleAttr "target" "x"
        /// The group value which receives these styles.
        static member inline y = Interop.mkStyleAttr "target" "y"
        /// The group value which receives these styles.
        static member inline z = Interop.mkStyleAttr "target" "z"

