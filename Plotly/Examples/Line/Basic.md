# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-basic
[<RequireQualifiedAccess>]
module Samples.Line.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 16; 5; 11; 9 ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.markersAndLines
            ]
        ]
    ]
```