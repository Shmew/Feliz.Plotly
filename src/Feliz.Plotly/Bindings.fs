namespace Feliz.Plotly

module Bindings =
    open Fable.Core.JsInterop
    open Fable.React

    let plotly: obj = importAll "plotly.js/dist/plotly"
    let plotFactory: obj -> obj = importDefault "react-plotly.js/factory.js"
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
