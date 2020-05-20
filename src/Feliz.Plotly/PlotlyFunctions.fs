namespace Feliz.Plotly

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type downloadImage =
    /// Sets the file name.
    static member inline fileName (value: string) = Interop.mkDownloadImageAttr "filename" value
    
    /// Sets the height of the image.
    static member inline height (value: float) = Interop.mkDownloadImageAttr "height" value
    /// Sets the height of the image.
    static member inline height (value: int) = Interop.mkDownloadImageAttr "height" value
    
    /// Sets the width of the image.
    static member inline width (value: float) = Interop.mkDownloadImageAttr "width" value
    /// Sets the width of the image.
    static member inline width (value: int) = Interop.mkDownloadImageAttr "width" value

[<Erase;RequireQualifiedAccess>]
module downloadImage =
    /// Sets the image format.
    [<Erase>]
    type format =
        static member inline jpeg = Interop.mkDownloadImageAttr "format" "jpeg"
        static member inline jpg = Interop.mkDownloadImageAttr "format" "jpg"
        static member inline png = Interop.mkDownloadImageAttr "format" "png"
        static member inline svg = Interop.mkDownloadImageAttr "format" "svg"
        static member inline webp = Interop.mkDownloadImageAttr "format" "webp"

[<AutoOpen;Erase>]
module PlotlyFunctions =
    type Plotly with
        /// Triggers a request to download the image of a Plotly plot.
        static member inline downloadImage (element: #HTMLElement, settings: IDownloadImageProperty list) = Bindings.plotly.downloadImage(U2.Case1(element), createObj !!settings)
        /// Triggers a request to download the image of a Plotly plot.
        static member inline downloadImage (divId: string, settings: IDownloadImageProperty list) = Bindings.plotly.downloadImage(U2.Case2(divId), createObj !!settings)
