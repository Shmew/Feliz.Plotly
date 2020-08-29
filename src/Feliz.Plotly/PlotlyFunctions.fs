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

[<Erase>]
type toImage =
    /// Sets the height of the image.
    static member inline height (value: float) = Interop.mkToImageAttr "height" value
    /// Sets the height of the image.
    static member inline height (value: int) = Interop.mkToImageAttr "height" value
    
    /// Sets the width of the image.
    static member inline width (value: float) = Interop.mkToImageAttr "width" value
    /// Sets the width of the image.
    static member inline width (value: int) = Interop.mkToImageAttr "width" value

[<Erase;RequireQualifiedAccess>]
module toImage =
    /// Sets the image format.
    [<Erase>]
    type format =
        static member inline jpeg = Interop.mkToImageAttr "format" "jpeg"
        static member inline jpg = Interop.mkToImageAttr "format" "jpg"
        static member inline png = Interop.mkToImageAttr "format" "png"
        static member inline svg = Interop.mkToImageAttr "format" "svg"
        static member inline webp = Interop.mkToImageAttr "format" "webp"

[<AutoOpen;Erase>]
module PlotlyFunctions =
    type Plotly with
        /// Triggers a request to download the image of a Plotly plot.
        static member inline downloadImage (element: #HTMLElement, settings: IDownloadImageProperty list) = Bindings.plotly.downloadImage(U2.Case1(element), createObj !!settings)
        /// Triggers a request to download the image of a Plotly plot.
        static member inline downloadImage (divId: string, settings: IDownloadImageProperty list) = Bindings.plotly.downloadImage(U2.Case2(divId), createObj !!settings)

        /// Triggers a request to generate an image url of a Plotly plot.
        static member inline toImage (element: #HTMLElement, settings: IToImageProperty list) = 
            Bindings.plotly.toImage(U2.Case1(element), createObj !!settings)
            |> Async.AwaitPromise
        /// Triggers a request to generate an image url of a Plotly plot.
        static member inline toImage (divId: string, settings: IToImageProperty list) = 
            Bindings.plotly.toImage(U2.Case2(divId), createObj !!settings)
            |> Async.AwaitPromise

        /// Registers a plotly locale module.
        ///
        /// Any plotly graph that sets the config locale to the same name as 
        /// the registered module will use that localization configuration.
        static member inline useLocale (name: string) (locale: ILocaleProperty list) =
            React.useEffect((fun () ->
                createObj !![
                    "moduleType" ==> "locale"
                    "name" ==> name
                    yield! (unbox locale)
                ]
                |> Bindings.plotly.register 
            ), [| locale :> obj |])

        /// Registers a plotly locale module.
        ///
        /// Any plotly graph that sets the config locale to the same name as 
        /// the registered module will use that localization configuration.
        ///
        /// Predefined locales can be found in the Feliz.Plotly.Locales namespace
        static member inline useLocales (locale: ILocalesProperty) =
            React.useEffect((fun () -> Bindings.plotly.register locale), [| locale :> obj |])
        /// Registers a plotly locale module.
        ///
        /// Any plotly graph that sets the config locale to the same name as 
        /// the registered module will use that localization configuration.
        ///
        /// Predefined locales can be found in the Feliz.Plotly.Locales namespace
        static member inline useLocales (locales: ILocalesProperty list) =
            React.useEffect((fun () ->
                locales 
                |> List.iter (fun locale -> Bindings.plotly.register locale)
            ), [| locales :> obj |])
