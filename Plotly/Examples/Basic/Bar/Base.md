# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-base
[<RequireQualifiedAccess>]
module Samples.Bar.Base

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "2016"; "2017"; "2018" ]
                bar.y [ 500; 600; 700 ]
                bar.base' [ -500; -600; -700 ]
                bar.marker [
                    marker.color color.red
                ]
                bar.name "expenses"
            ]
            traces.bar [
                bar.x [ "2016"; "2017"; "2018" ]
                bar.y [ 300; 400; 700 ]
                bar.base' 0
                bar.marker [
                    marker.color color.blue
                ]
                bar.name "revenue"
            ]
        ]
    ]
```