namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type y =
    /// Sets whether or not projections are shown along the y axis.
    static member inline show (value: bool) = Interop.mkYAttr "show" value
    /// Sets the projection color.
    static member inline opacity (value: int) = Interop.mkYAttr "opacity" value
    /// Sets the projection color.
    static member inline opacity (value: float) = Interop.mkYAttr "opacity" value
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: int) = Interop.mkYAttr "scale" value
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: float) = Interop.mkYAttr "scale" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: int) = Interop.mkYAttr "start" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: float) = Interop.mkYAttr "start" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: int) = Interop.mkYAttr "end" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: float) = Interop.mkYAttr "end" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: int) = Interop.mkYAttr "size" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: float) = Interop.mkYAttr "size" value
    static member inline project (properties: #IProjectProperty list) = Interop.mkYAttr "project" (createObj !!properties)
    /// Sets the color of the contour lines.
    static member inline color (value: string) = Interop.mkYAttr "color" value
    /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
    static member inline usecolormap (value: bool) = Interop.mkYAttr "usecolormap" value
    /// Sets the width of the contour lines.
    static member inline width (value: int) = Interop.mkYAttr "width" value
    /// Sets the width of the contour lines.
    static member inline width (value: float) = Interop.mkYAttr "width" value
    /// Determines whether or not contour lines about the y dimension are highlighted on hover.
    static member inline highlight (value: bool) = Interop.mkYAttr "highlight" value
    /// Sets the color of the highlighted contour lines.
    static member inline highlightcolor (value: string) = Interop.mkYAttr "highlightcolor" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: int) = Interop.mkYAttr "highlightwidth" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: float) = Interop.mkYAttr "highlightwidth" value
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: bool) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool>) = Interop.mkYAttr "locations" (values |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: System.DateTime) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkYAttr "locations" (values |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: float) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float>) = Interop.mkYAttr "locations" (values |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: int) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int>) = Interop.mkYAttr "locations" (values |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: string) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string>) = Interop.mkYAttr "locations" (values |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool list>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<string>>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string list>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<int>>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int list>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int option []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<float>>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float list>) = Interop.mkYAttr "locations" (values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<PlotData>) = Interop.mkYAttr "locations" (values |> Seq.map PlotData.asDataResize |> Array.ofSeq)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool option>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<System.DateTime option>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int option>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float option>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string option>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: int) = Interop.mkYAttr "fill" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: float) = Interop.mkYAttr "fill" value
    /// Sets the source reference on plot.ly for  locations .
    static member inline locationssrc (value: string) = Interop.mkYAttr "locationssrc" value

