# Feliz.Plotly - Filled Area Plots

Taken from [Plotly - Filled Area Plots](https://plot.ly/javascript/filled-area-plots/#stacked-area-chart)

```fsharp:plotly-chart-filledarea-normalizedstackedarea
[<RequireQualifiedAccess>]
module Samples.FilledArea.NormalizedStackedArea

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 2; 1; 4 ]
                scatter.stackgroup "one"
                scatter.groupnorm.percent
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 1; 1; 2 ]
                scatter.stackgroup "one"
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 3; 0; 2 ]
                scatter.stackgroup "one"
            ]
        ]
        plot.layout [
            layout.title [
            title.text "Normalized Stacked and Filled Line Chart"
            ]
        ]
    ]
```