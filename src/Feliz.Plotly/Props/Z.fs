namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type z =
    /// Sets the color of the contour lines.
    static member inline color (value: string) = Interop.mkZAttr "color" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: int) = Interop.mkZAttr "end" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: float) = Interop.mkZAttr "end" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: int) = Interop.mkZAttr "fill" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: float) = Interop.mkZAttr "fill" value
    /// Determines whether or not contour lines about the z dimension are highlighted on hover.
    static member inline highlight (value: bool) = Interop.mkZAttr "highlight" value
    /// Sets the color of the highlighted contour lines.
    static member inline highlightcolor (value: string) = Interop.mkZAttr "highlightcolor" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: int) = Interop.mkZAttr "highlightwidth" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: float) = Interop.mkZAttr "highlightwidth" value
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (value: bool) = Interop.mkZAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<bool>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (value: System.DateTime) = Interop.mkZAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (value: float) = Interop.mkZAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<float>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (value: int) = Interop.mkZAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<int>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (value: string) = Interop.mkZAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<string>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<bool list>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<bool []>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<seq<string>>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<string list>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<string []>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<seq<int>>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<int list>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<int []>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<seq<float>>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<float list>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<float []>) = Interop.mkZAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<PlotData>) = Interop.mkZAttr "locations" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<bool option>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<System.DateTime option>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<int option>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<float option>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
    static member inline locations (values: seq<string option>) = Interop.mkZAttr "locations" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  locations .
    static member inline locationssrc (value: string) = Interop.mkZAttr "locationssrc" value
    /// Sets the projection color.
    static member inline opacity (value: int) = Interop.mkZAttr "opacity" value
    /// Sets the projection color.
    static member inline opacity (value: float) = Interop.mkZAttr "opacity" value
    static member inline project (properties: #IProjectProperty list) = Interop.mkZAttr "project" (createObj !!properties)
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: int) = Interop.mkZAttr "scale" value
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: float) = Interop.mkZAttr "scale" value
    /// Sets whether or not projections are shown along the z axis.
    static member inline show (value: bool) = Interop.mkZAttr "show" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: int) = Interop.mkZAttr "size" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: float) = Interop.mkZAttr "size" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: int) = Interop.mkZAttr "start" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: float) = Interop.mkZAttr "start" value
    /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
    static member inline usecolormap (value: bool) = Interop.mkZAttr "usecolormap" value
    /// Sets the width of the contour lines.
    static member inline width (value: int) = Interop.mkZAttr "width" value
    /// Sets the width of the contour lines.
    static member inline width (value: float) = Interop.mkZAttr "width" value

[<Erase;RequireQualifiedAccess>]
module z =
    /// Sets the color of the contour lines.
    [<Erase>]
    type color =
        /// Sets the color of the contour lines.
        static member inline rgb (r,g,b) = Interop.mkZAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the contour lines.
        static member inline rgba (r,g,b,a) = Interop.mkZAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the contour lines.
        static member inline hsl (h,s,l) = Interop.mkZAttr "color" (Feliz.color.hsl(h,s,l))

