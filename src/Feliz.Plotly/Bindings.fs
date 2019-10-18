namespace Feliz.Plotly

module Bindings =
    open Fable.Core.JsInterop
    open Fable.React

    let plotly: obj = importAll "plotly.js"
    let plotFactory: obj -> obj = importDefault "react-plotly.js/factory.js"
    let plotComponent = plotFactory plotly
    let createPlot props: ReactElement = 
        ReactBindings.React.createElement (plotComponent, props, [])

    let getKV value : string * obj = unbox value

    let extractData (properties: #IDataProperty list) =
        properties 
        |> List.map (getKV >> snd) 
        |> ResizeArray 
        |> Interop.mkPlotAttr "data"

    let extractDataConditionals (properties: (bool * 'a list) list) =
        properties
        |> List.filter fst
        |> List.collect snd
        |> unbox
        |> extractData
        |> Interop.mkPlotAttr "data"

    let withConditionals (properties: (bool * 'a list) list) =
        properties
        |> List.filter fst
        |> List.collect snd
        |> unbox
        |> createObj
