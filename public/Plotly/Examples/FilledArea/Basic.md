# Feliz.Plotly - Filled Area Plots

Taken from [Plotly - Filled Area Plots](https://plot.ly/javascript/filled-area-plots/#stacked-area-chart)

```fsharp:plotly-chart-filledarea-basic
[<RequireQualifiedAccess>]
module Samples.FilledArea.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 0; 2; 3; 5 ]
                scatter.fill.tozeroy
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 3; 5; 1; 7 ]
                scatter.fill.tonexty
            ]
        ]
    ]
```