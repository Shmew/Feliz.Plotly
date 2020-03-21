namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type uniformtext =
    /// Sets the minimum text size between traces of the same type.
    static member inline minsize (value: int) = Interop.mkUniformtextAttr "minsize" value
    /// Sets the minimum text size between traces of the same type.
    static member inline minsize (value: float) = Interop.mkUniformtextAttr "minsize" value

[<RequireQualifiedAccess>]
module uniformtext =
    /// Determines how the font size for various text elements are uniformed between each trace type. If the computed text sizes were smaller than the minimum size defined by `uniformtext.minsize` using *hide* option hides the text; and using *show* option shows the text without further downscaling. Please note that if the size defined by `minsize` is greater than the font size defined by trace, then the `minsize` is used.
    [<Erase>]
    type mode =
        static member inline hide = Interop.mkUniformtextAttr "mode" "hide"
        static member inline show = Interop.mkUniformtextAttr "mode" "show"
        static member inline false' = Interop.mkUniformtextAttr "mode" false

