namespace Feliz.Plotly

module Bindings =
    open Browser.Types
    open Fable.Core
    open Fable.Core.JsInterop
    open Fable.React

    type Plotly =
        abstract downloadImage: U2<#HTMLElement,string> * obj -> unit

    let plotly: Plotly = importAll "plotly.js/dist/plotly"
    let plotFactory: Plotly -> obj = importDefault "react-plotly.js/factory.js"
    let plotComponent = plotFactory plotly
    let createPlot props: ReactElement = 
        ReactBindings.React.createElement (plotComponent, props, [])
    
    let getKV value : string * obj = unbox value

    let extractTraces (properties: #ITracesProperty list) =
        properties 
        |> List.map (getKV >> snd) 
        |> ResizeArray 
        |> Interop.mkPlotAttr "data"
                    
    let convertTracesToTemplate (traces: ITracesProperty list) =
        traces
        |> List.map (unbox<string * obj> >> (fun (name, props) -> name, Array.singleton props))
    
    let inline optToString (value: 'T Option) =
        match value with
        | Some v -> string v
        | _ -> "None"        
