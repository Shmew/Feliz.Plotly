# Feliz.Plotly - Inset Plots

Taken from [Plotly - Inset Plots](https://plot.ly/javascript/insets/)

```fsharp:plotly-chart-subplots-inset
[<RequireQualifiedAccess>]
module Samples.Subplots.Inset

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 4; 3; 2 ]
            ]
            traces.scatter [
                scatter.x [ 20; 30; 40 ]
                scatter.y [ 30; 40; 50 ]
                scatter.xaxis 2
                scatter.yaxis 2
            ]
        ]
        plot.layout [
            layout.xaxis (2, [
                xaxis.domain [ 0.6; 0.95 ]
                xaxis.anchor.x 2
            ])
            layout.yaxis (2, [
                yaxis.domain [ 0.6; 0.95 ]
                yaxis.anchor.y 2
            ])
        ]
    ]
```