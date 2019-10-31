# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-styled
[<RequireQualifiedAccess>]
module Samples.ErrorBar.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0; 1; 2 ]
                scatter.y [ 6; 10; 2 ]
                scatter.errorY [
                    errorY.array [ 1; 2; 3 ]
                    errorY.visible true
                ]
            ]
        ]
    ]
```