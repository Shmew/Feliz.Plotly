namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type framesEntry =
    /// An identifier that specifies the group to which the frame belongs, used by animate to select a subset of frames.
    static member inline group (value: string) = Interop.mkFramesEntryAttr "group" value
    /// A label by which to identify the frame
    static member inline name (value: string) = Interop.mkFramesEntryAttr "name" value
    /// The name of the frame into which this frame's properties are merged before applying. This is used to unify properties and avoid needing to specify the same values for the same properties in multiple frames.
    static member inline baseframe (value: string) = Interop.mkFramesEntryAttr "baseframe" value
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (value: bool) = Interop.mkFramesEntryAttr "data" value
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (values: seq<bool>) = Interop.mkFramesEntryAttr "data" (values |> Array.ofSeq)
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (value: string) = Interop.mkFramesEntryAttr "data" value
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (values: seq<string>) = Interop.mkFramesEntryAttr "data" (values |> Array.ofSeq)
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (value: int) = Interop.mkFramesEntryAttr "data" value
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (values: seq<int>) = Interop.mkFramesEntryAttr "data" (values |> Array.ofSeq)
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (value: float) = Interop.mkFramesEntryAttr "data" value
    /// A list of traces this frame modifies. The format is identical to the normal trace definition.
    static member inline data (values: seq<float>) = Interop.mkFramesEntryAttr "data" (values |> Array.ofSeq)
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (value: bool) = Interop.mkFramesEntryAttr "layout" value
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (values: seq<bool>) = Interop.mkFramesEntryAttr "layout" (values |> Array.ofSeq)
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (value: string) = Interop.mkFramesEntryAttr "layout" value
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (values: seq<string>) = Interop.mkFramesEntryAttr "layout" (values |> Array.ofSeq)
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (value: int) = Interop.mkFramesEntryAttr "layout" value
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (values: seq<int>) = Interop.mkFramesEntryAttr "layout" (values |> Array.ofSeq)
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (value: float) = Interop.mkFramesEntryAttr "layout" value
    /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
    static member inline layout (values: seq<float>) = Interop.mkFramesEntryAttr "layout" (values |> Array.ofSeq)

