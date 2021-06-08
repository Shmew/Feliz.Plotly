namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type x =
    /// Sets the color of the contour lines.
    static member inline color (value: string) = Interop.mkXAttr "color" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: int) = Interop.mkXAttr "end" value
    /// Sets the end contour level value. Must be more than `contours.start`
    static member inline end' (value: float) = Interop.mkXAttr "end" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: int) = Interop.mkXAttr "fill" value
    /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
    static member inline fill (value: float) = Interop.mkXAttr "fill" value
    /// Determines whether or not contour lines about the x dimension are highlighted on hover.
    static member inline highlight (value: bool) = Interop.mkXAttr "highlight" value
    /// Sets the color of the highlighted contour lines.
    static member inline highlightcolor (value: string) = Interop.mkXAttr "highlightcolor" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: int) = Interop.mkXAttr "highlightwidth" value
    /// Sets the width of the highlighted contour lines.
    static member inline highlightwidth (value: float) = Interop.mkXAttr "highlightwidth" value
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (value: bool) = Interop.mkXAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<bool>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (value: System.DateTime) = Interop.mkXAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<System.DateTime>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (value: float) = Interop.mkXAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<float>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (value: int) = Interop.mkXAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<int>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (value: string) = Interop.mkXAttr "locations" (value |> Array.singleton |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<string>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<bool list>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<bool []>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<seq<string>>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<string list>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<string []>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<seq<int>>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<int list>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<int []>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<seq<float>>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<float list>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<float []>) = Interop.mkXAttr "locations" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<PlotData>) = Interop.mkXAttr "locations" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<bool option>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<System.DateTime option>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<int option>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<float option>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
    static member inline locations (values: seq<string option>) = Interop.mkXAttr "locations" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  locations .
    static member inline locationssrc (value: string) = Interop.mkXAttr "locationssrc" value
    /// Sets the projection color.
    static member inline opacity (value: int) = Interop.mkXAttr "opacity" value
    /// Sets the projection color.
    static member inline opacity (value: float) = Interop.mkXAttr "opacity" value
    static member inline project (properties: #IProjectProperty list) = Interop.mkXAttr "project" (createObj !!properties)
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: int) = Interop.mkXAttr "scale" value
    /// Sets the scale factor determining the size of the projection marker points.
    static member inline scale (value: float) = Interop.mkXAttr "scale" value
    /// Sets whether or not projections are shown along the x axis.
    static member inline show (value: bool) = Interop.mkXAttr "show" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: int) = Interop.mkXAttr "size" value
    /// Sets the step between each contour level. Must be positive.
    static member inline size (value: float) = Interop.mkXAttr "size" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: int) = Interop.mkXAttr "start" value
    /// Sets the starting contour level value. Must be less than `contours.end`
    static member inline start (value: float) = Interop.mkXAttr "start" value
    /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
    static member inline usecolormap (value: bool) = Interop.mkXAttr "usecolormap" value
    /// Sets the width of the contour lines.
    static member inline width (value: int) = Interop.mkXAttr "width" value
    /// Sets the width of the contour lines.
    static member inline width (value: float) = Interop.mkXAttr "width" value

[<Erase;RequireQualifiedAccess>]
module x =
    /// Sets the color of the contour lines.
    [<Erase>]
    type color =
        /// Sets the color of the contour lines.
        static member inline rgb (r,g,b) = Interop.mkXAttr "color" (Feliz.color.rgb(r,g,b))
        /// Sets the color of the contour lines.
        static member inline rgba (r,g,b,a) = Interop.mkXAttr "color" (Feliz.color.rgba(r,g,b,a))
        /// Sets the color of the contour lines.
        static member inline hsl (h,s,l) = Interop.mkXAttr "color" (Feliz.color.hsl(h,s,l))

