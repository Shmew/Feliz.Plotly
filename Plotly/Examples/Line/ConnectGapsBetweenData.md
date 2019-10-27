# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-connectgapsbetweendata
[<RequireQualifiedAccess>]
module Samples.Line.ConnectGapsBetweenData

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1 .. 8]
                scatter.y [ 10; 15; 17; 14; 12; 10; 15 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.connectgaps true
            ]
            traces.scatter [
                scatter.x [ 1 .. 8 ]
                scatter.y [ 16; 13; 10; 8; 11; 12 ]
                scatter.mode.lines
                scatter.connectgaps true
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Connect the Gaps Between Data"
            ]
            layout.showlegend false
        ]
    ]
```