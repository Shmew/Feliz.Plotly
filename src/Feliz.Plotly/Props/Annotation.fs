namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type annotation =
    /// Determines whether or not this annotation is visible.
    static member inline visible (value: bool) = Interop.mkAnnotationAttr "visible" value
    /// Sets the annotation's x position.
    static member inline x (value: bool) = Interop.mkAnnotationAttr "x" value
    /// Sets the annotation's x position.
    static member inline x (values: seq<bool>) = Interop.mkAnnotationAttr "x" (values |> Array.ofSeq)
    /// Sets the annotation's x position.
    static member inline x (value: string) = Interop.mkAnnotationAttr "x" value
    /// Sets the annotation's x position.
    static member inline x (values: seq<string>) = Interop.mkAnnotationAttr "x" (values |> Array.ofSeq)
    /// Sets the annotation's x position.
    static member inline x (value: int) = Interop.mkAnnotationAttr "x" value
    /// Sets the annotation's x position.
    static member inline x (values: seq<int>) = Interop.mkAnnotationAttr "x" (values |> Array.ofSeq)
    /// Sets the annotation's x position.
    static member inline x (value: float) = Interop.mkAnnotationAttr "x" value
    /// Sets the annotation's x position.
    static member inline x (values: seq<float>) = Interop.mkAnnotationAttr "x" (values |> Array.ofSeq)
    /// Sets the annotation's y position.
    static member inline y (value: bool) = Interop.mkAnnotationAttr "y" value
    /// Sets the annotation's y position.
    static member inline y (values: seq<bool>) = Interop.mkAnnotationAttr "y" (values |> Array.ofSeq)
    /// Sets the annotation's y position.
    static member inline y (value: string) = Interop.mkAnnotationAttr "y" value
    /// Sets the annotation's y position.
    static member inline y (values: seq<string>) = Interop.mkAnnotationAttr "y" (values |> Array.ofSeq)
    /// Sets the annotation's y position.
    static member inline y (value: int) = Interop.mkAnnotationAttr "y" value
    /// Sets the annotation's y position.
    static member inline y (values: seq<int>) = Interop.mkAnnotationAttr "y" (values |> Array.ofSeq)
    /// Sets the annotation's y position.
    static member inline y (value: float) = Interop.mkAnnotationAttr "y" value
    /// Sets the annotation's y position.
    static member inline y (values: seq<float>) = Interop.mkAnnotationAttr "y" (values |> Array.ofSeq)
    /// Sets the annotation's z position.
    static member inline z (value: bool) = Interop.mkAnnotationAttr "z" value
    /// Sets the annotation's z position.
    static member inline z (values: seq<bool>) = Interop.mkAnnotationAttr "z" (values |> Array.ofSeq)
    /// Sets the annotation's z position.
    static member inline z (value: string) = Interop.mkAnnotationAttr "z" value
    /// Sets the annotation's z position.
    static member inline z (values: seq<string>) = Interop.mkAnnotationAttr "z" (values |> Array.ofSeq)
    /// Sets the annotation's z position.
    static member inline z (value: int) = Interop.mkAnnotationAttr "z" value
    /// Sets the annotation's z position.
    static member inline z (values: seq<int>) = Interop.mkAnnotationAttr "z" (values |> Array.ofSeq)
    /// Sets the annotation's z position.
    static member inline z (value: float) = Interop.mkAnnotationAttr "z" value
    /// Sets the annotation's z position.
    static member inline z (values: seq<float>) = Interop.mkAnnotationAttr "z" (values |> Array.ofSeq)
    /// Sets the x component of the arrow tail about the arrow head (in pixels).
    static member inline ax (value: int) = Interop.mkAnnotationAttr "ax" value
    /// Sets the x component of the arrow tail about the arrow head (in pixels).
    static member inline ax (value: float) = Interop.mkAnnotationAttr "ax" value
    /// Sets the y component of the arrow tail about the arrow head (in pixels).
    static member inline ay (value: int) = Interop.mkAnnotationAttr "ay" value
    /// Sets the y component of the arrow tail about the arrow head (in pixels).
    static member inline ay (value: float) = Interop.mkAnnotationAttr "ay" value
    /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
    static member inline xshift (value: int) = Interop.mkAnnotationAttr "xshift" value
    /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
    static member inline xshift (value: float) = Interop.mkAnnotationAttr "xshift" value
    /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
    static member inline yshift (value: int) = Interop.mkAnnotationAttr "yshift" value
    /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
    static member inline yshift (value: float) = Interop.mkAnnotationAttr "yshift" value
    /// Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also supported.
    static member inline text (value: string) = Interop.mkAnnotationAttr "text" value
    /// Sets the angle at which the `text` is drawn with respect to the horizontal.
    static member inline textangle (value: int) = Interop.mkAnnotationAttr "textangle" value
    /// Sets the angle at which the `text` is drawn with respect to the horizontal.
    static member inline textangle (value: float) = Interop.mkAnnotationAttr "textangle" value
    /// Sets the annotation text font.
    static member inline font (properties: #IFontProperty list) = Interop.mkAnnotationAttr "font" (createObj !!properties)
    /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
    static member inline width (value: int) = Interop.mkAnnotationAttr "width" value
    /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
    static member inline width (value: float) = Interop.mkAnnotationAttr "width" value
    /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
    static member inline height (value: int) = Interop.mkAnnotationAttr "height" value
    /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
    static member inline height (value: float) = Interop.mkAnnotationAttr "height" value
    /// Sets the opacity of the annotation (text + arrow).
    static member inline opacity (value: int) = Interop.mkAnnotationAttr "opacity" value
    /// Sets the opacity of the annotation (text + arrow).
    static member inline opacity (value: float) = Interop.mkAnnotationAttr "opacity" value
    /// Sets the background color of the annotation.
    static member inline bgcolor (value: string) = Interop.mkAnnotationAttr "bgcolor" value
    /// Sets the color of the border enclosing the annotation `text`.
    static member inline bordercolor (value: string) = Interop.mkAnnotationAttr "bordercolor" value
    /// Sets the padding (in px) between the `text` and the enclosing border.
    static member inline borderpad (value: int) = Interop.mkAnnotationAttr "borderpad" value
    /// Sets the padding (in px) between the `text` and the enclosing border.
    static member inline borderpad (value: float) = Interop.mkAnnotationAttr "borderpad" value
    /// Sets the width (in px) of the border enclosing the annotation `text`.
    static member inline borderwidth (value: int) = Interop.mkAnnotationAttr "borderwidth" value
    /// Sets the width (in px) of the border enclosing the annotation `text`.
    static member inline borderwidth (value: float) = Interop.mkAnnotationAttr "borderwidth" value
    /// Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided.
    static member inline showarrow (value: bool) = Interop.mkAnnotationAttr "showarrow" value
    /// Sets the color of the annotation arrow.
    static member inline arrowcolor (value: string) = Interop.mkAnnotationAttr "arrowcolor" value
    /// Sets the end annotation arrow head style.
    static member inline arrowhead (value: int) = Interop.mkAnnotationAttr "arrowhead" value
    /// Sets the start annotation arrow head style.
    static member inline startarrowhead (value: int) = Interop.mkAnnotationAttr "startarrowhead" value
    /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
    static member inline arrowsize (value: int) = Interop.mkAnnotationAttr "arrowsize" value
    /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
    static member inline arrowsize (value: float) = Interop.mkAnnotationAttr "arrowsize" value
    /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
    static member inline startarrowsize (value: int) = Interop.mkAnnotationAttr "startarrowsize" value
    /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
    static member inline startarrowsize (value: float) = Interop.mkAnnotationAttr "startarrowsize" value
    /// Sets the width (in px) of annotation arrow line.
    static member inline arrowwidth (value: int) = Interop.mkAnnotationAttr "arrowwidth" value
    /// Sets the width (in px) of annotation arrow line.
    static member inline arrowwidth (value: float) = Interop.mkAnnotationAttr "arrowwidth" value
    /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
    static member inline standoff (value: int) = Interop.mkAnnotationAttr "standoff" value
    /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
    static member inline standoff (value: float) = Interop.mkAnnotationAttr "standoff" value
    /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
    static member inline startstandoff (value: int) = Interop.mkAnnotationAttr "startstandoff" value
    /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
    static member inline startstandoff (value: float) = Interop.mkAnnotationAttr "startstandoff" value
    /// Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear.
    static member inline hovertext (value: string) = Interop.mkAnnotationAttr "hovertext" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkAnnotationAttr "hoverlabel" (createObj !!properties)
    /// Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`.
    static member inline captureevents (value: bool) = Interop.mkAnnotationAttr "captureevents" value
    /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
    static member inline name (value: string) = Interop.mkAnnotationAttr "name" value
    /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
    static member inline templateitemname (value: string) = Interop.mkAnnotationAttr "templateitemname" value
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (value: bool) = Interop.mkAnnotationAttr "xclick" value
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (values: seq<bool>) = Interop.mkAnnotationAttr "xclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (value: string) = Interop.mkAnnotationAttr "xclick" value
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (values: seq<string>) = Interop.mkAnnotationAttr "xclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (value: int) = Interop.mkAnnotationAttr "xclick" value
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (values: seq<int>) = Interop.mkAnnotationAttr "xclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (value: float) = Interop.mkAnnotationAttr "xclick" value
    /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
    static member inline xclick (values: seq<float>) = Interop.mkAnnotationAttr "xclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (value: bool) = Interop.mkAnnotationAttr "yclick" value
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (values: seq<bool>) = Interop.mkAnnotationAttr "yclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (value: string) = Interop.mkAnnotationAttr "yclick" value
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (values: seq<string>) = Interop.mkAnnotationAttr "yclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (value: int) = Interop.mkAnnotationAttr "yclick" value
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (values: seq<int>) = Interop.mkAnnotationAttr "yclick" (values |> Array.ofSeq)
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (value: float) = Interop.mkAnnotationAttr "yclick" value
    /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
    static member inline yclick (values: seq<float>) = Interop.mkAnnotationAttr "yclick" (values |> Array.ofSeq)

[<AutoOpen>]
module annotation =
    /// Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
    [<Erase>]
    type xanchor =
        static member inline auto = Interop.mkAnnotationAttr "xanchor" "auto"
        static member inline center = Interop.mkAnnotationAttr "xanchor" "center"
        static member inline left = Interop.mkAnnotationAttr "xanchor" "left"
        static member inline right = Interop.mkAnnotationAttr "xanchor" "right"

    /// Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
    [<Erase>]
    type yanchor =
        static member inline auto = Interop.mkAnnotationAttr "yanchor" "auto"
        static member inline bottom = Interop.mkAnnotationAttr "yanchor" "bottom"
        static member inline middle = Interop.mkAnnotationAttr "yanchor" "middle"
        static member inline top = Interop.mkAnnotationAttr "yanchor" "top"

    /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans more two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
    [<Erase>]
    type align =
        static member inline center = Interop.mkAnnotationAttr "align" "center"
        static member inline left = Interop.mkAnnotationAttr "align" "left"
        static member inline right = Interop.mkAnnotationAttr "align" "right"

    /// Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
    [<Erase>]
    type valign =
        static member inline bottom = Interop.mkAnnotationAttr "valign" "bottom"
        static member inline middle = Interop.mkAnnotationAttr "valign" "middle"
        static member inline top = Interop.mkAnnotationAttr "valign" "top"

    /// Sets the annotation arrow head position.
    [<Erase>]
    type arrowside =
        static member inline none = Interop.mkAnnotationAttr "arrowside" "none"
        static member inline end' = Interop.mkAnnotationAttr "arrowside" "end"
        static member inline start = Interop.mkAnnotationAttr "arrowside" "start"
        static member inline startAndEnd = Interop.mkAnnotationAttr "arrowside" "start+end"

    /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ax` is a relative offset in pixels  from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
    [<Erase>]
    type axref =
        static member inline pixel = Interop.mkAnnotationAttr "axref" "pixel"
        static member inline custom (value: string) = Interop.mkAnnotationAttr "axref" value

    /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ay` is a relative offset in pixels  from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
    [<Erase>]
    type ayref =
        static member inline pixel = Interop.mkAnnotationAttr "ayref" "pixel"
        static member inline custom (value: string) = Interop.mkAnnotationAttr "ayref" value

    /// Sets the annotation's x coordinate axis. If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate If set to *paper*, the `x` position refers to the distance from the left side of the plotting area in normalized coordinates where 0 (1) corresponds to the left (right) side.
    [<Erase>]
    type xref =
        static member inline paper = Interop.mkAnnotationAttr "xref" "paper"
        static member inline custom (value: string) = Interop.mkAnnotationAttr "xref" value

    /// Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where 0 (1) corresponds to the bottom (top).
    [<Erase>]
    type yref =
        static member inline paper = Interop.mkAnnotationAttr "yref" "paper"
        static member inline custom (value: string) = Interop.mkAnnotationAttr "yref" value

    /// Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
    [<Erase>]
    type clicktoshow =
        static member inline onoff = Interop.mkAnnotationAttr "clicktoshow" "onoff"
        static member inline onout = Interop.mkAnnotationAttr "clicktoshow" "onout"
        static member inline false' = Interop.mkAnnotationAttr "clicktoshow" "false"

