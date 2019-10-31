# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-stacked
[<RequireQualifiedAccess>]
module Samples.Histogram.Stacked

open Feliz
open Feliz.Plotly

let rng = System.Random()

let dataX = [ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble())

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram [
                histogram.x dataX
            ]
            traces.histogram [
                histogram.x dataX
            ]
        ]
        plot.layout [
            layout.barmode.stack
        ]
    ]
```