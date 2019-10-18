# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-lineshapeoptionsinterpolation
[<RequireQualifiedAccess>]
module Samples.Bubble.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 11; 12; 13 ]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.size [ 40; 60; 80; 100 ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Marker Size"
            ]
            layout.showlegend false
            layout.height 400
            layout.width 480
        ]
    ]
```