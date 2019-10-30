# Feliz.Plotly - Filled Area Plots

Taken from [Plotly - Filled Area Plots](https://plot.ly/javascript/filled-area-plots/#stacked-area-chart)

```fsharp:plotly-chart-filledarea-overlaidwithoutboundary
[<RequireQualifiedAccess>]
module Samples.FilledArea.OverlaidWithoutBoundary

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 0; 2; 3; 5 ]
                scatter.fill.tozeroy
                scatter.mode.none
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 3; 5; 1; 7 ]
                scatter.fill.tonexty
                scatter.mode.none
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Overlaid Chart Without Boundary Lines"
            ]
        ]
    ]
```