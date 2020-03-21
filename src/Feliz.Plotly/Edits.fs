namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type edits =
    /// Determines if the main anchor of the annotation is editable. The main anchor corresponds to the text (if no arrow) or the arrow (which drags the whole thing leaving the arrow length & direction unchanged).
    static member inline annotationPosition (value: bool) = Interop.mkEditsAttr "annotationPosition" value
    /// Has only an effect for annotations with arrows. Enables changing the length and direction of the arrow.
    static member inline annotationTail (value: bool) = Interop.mkEditsAttr "annotationTail" value
    /// Enables editing annotation text.
    static member inline annotationText (value: bool) = Interop.mkEditsAttr "annotationText" value
    /// Enables editing axis title text.
    static member inline axisTitleText (value: bool) = Interop.mkEditsAttr "axisTitleText" value
    /// Enables moving colorbars.
    static member inline colorbarPosition (value: bool) = Interop.mkEditsAttr "colorbarPosition" value
    /// Enables editing colorbar title text.
    static member inline colorbarTitleText (value: bool) = Interop.mkEditsAttr "colorbarTitleText" value
    /// Enables moving the legend.
    static member inline legendPosition (value: bool) = Interop.mkEditsAttr "legendPosition" value
    /// Enables editing the trace name fields from the legend
    static member inline legendText (value: bool) = Interop.mkEditsAttr "legendText" value
    /// Enables moving shapes.
    static member inline shapePosition (value: bool) = Interop.mkEditsAttr "shapePosition" value
    /// Enables editing the global layout title.
    static member inline titleText (value: bool) = Interop.mkEditsAttr "titleText" value

