# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-underlyingdata
[<RequireQualifiedAccess>]
module Samples.BoxPlot.UnderlyingData

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y [ 0; 1; 1; 2; 3; 5; 8; 13; 21 ]
                box.boxpoints.all
                box.jitter 0.3
                box.pointpos -1.8
            ]
        ]
    ]
```