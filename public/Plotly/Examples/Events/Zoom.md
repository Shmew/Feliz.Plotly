# Feliz.Plotly - Zoom Events

Taken from [Plotly - Zoom Events](https://plot.ly/javascript/zoom-events/)

```fsharp:plotly-chart-events-zoom
[<RequireQualifiedAccess>]
module Samples.Events.Zoom

open Fable.Core
open Feliz
open Feliz.Plotly

let rng = System.Random()

[<Emit("alert($0)")>]
let alert s = jsNative

let xData = [ 1 .. 100 ]
let yData = xData |> List.map (fun _ -> rng.NextDouble())

let chart = React.functionComponent (fun () ->
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xData
                scatter.y yData
                scatter.mode.lines
            ]
        ]
        plot.layout [
            layout.title "Click-drag to zoom"
        ]
        plot.onRelayout <| fun ev ->
            match ev.``xaxis.range[0]``, ev.``xaxis.range[1]`` with
            | Events.Int x, Events.Int x2 ->
                sprintf "Xaxis Start: %i%sXaxis End: %i" 
                    x System.Environment.NewLine x2
                |> alert
            | _ -> ()
    ])
```