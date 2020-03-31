namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type y =
    /// Sets the color of the contour lines.
    static member inline color (value: string) = Interop.mkYAttr "color" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: int) = Interop.mkYAttr "end" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: float) = Interop.mkYAttr "end" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: int) = Interop.mkYAttr "fill" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: float) = Interop.mkYAttr "fill" value
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
    static member inline locations (values: seq<bool>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: System.DateTime) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: float) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: int) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (value: string) = Interop.mkYAttr "locations" (value |> Array.singleton)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string>) = Interop.mkYAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool list>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<bool []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<string>>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string list>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<string []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<int>>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int list>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<int []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<seq<float>>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float list>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<float []>) = Interop.mkYAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
    static member inline locations (values: seq<PlotData>) = Interop.mkYAttr "locations" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
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
    /// Sets the source reference on Chart Studio Cloud for  locations .
    static member inline locationssrc (value: string) = Interop.mkYAttr "locationssrc" value
    /// Sets the projection color.
    static member inline opacity (value: int) = Interop.mkYAttr "opacity" value
    /// Sets the projection color.
    static member inline opacity (value: float) = Interop.mkYAttr "opacity" value
    static member inline project (properties: #IProjectProperty list) = Interop.mkYAttr "project" (createObj !!properties)
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: int) = Interop.mkYAttr "scale" value
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: float) = Interop.mkYAttr "scale" value
    /// Sets whether or not projections are shown along the y axis.
    static member inline show (value: bool) = Interop.mkYAttr "show" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: int) = Interop.mkYAttr "size" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: float) = Interop.mkYAttr "size" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: int) = Interop.mkYAttr "start" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: float) = Interop.mkYAttr "start" value
    /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
    static member inline usecolormap (value: bool) = Interop.mkYAttr "usecolormap" value
    /// Sets the width of the contour lines.
    static member inline width (value: int) = Interop.mkYAttr "width" value
    /// Sets the width of the contour lines.
    static member inline width (value: float) = Interop.mkYAttr "width" value

[<RequireQualifiedAccess>]
module y =
    /// Sets the color of the contour lines.
    [<Erase>]
    type color =
        /// Sets the color of the contour lines.
        static member inline rgb (r,g,b) = Interop.mkYAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the contour lines.
        static member inline rgba (r,g,b,a) = Interop.mkYAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the contour lines.
        static member inline hsl (h,s,l) = Interop.mkYAttr "color" (Feliz.color.hsl(h,s,l))

