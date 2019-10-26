# Feliz.Plotly - Bubble Charts

Taken from [Plotly - Bubble Charts](https://plot.ly/javascript/bubble-charts/)

```fsharp:plotly-chart-bubble-basic
[<RequireQualifiedAccess>]
module Samples.Bubble.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 11; 12; 13 ]
                scatter.mode.markers
                scatter.marker [
                    marker.size [ 40; 60; 80; 100 ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Marker Size"
            ]
            layout.showlegend false
            layout.height 400
            layout.width 480
        ]
    ]
```