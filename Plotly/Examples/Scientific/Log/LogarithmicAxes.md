# Feliz.Plotly - Log Plots

Taken from [Plotly - Log Plots](https://plot.ly/javascript/log-plot/)

```fsharp:plotly-chart-log-logarithmicaxes
[<RequireQualifiedAccess>]
module Samples.Log.LogarithmicAxes

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0 .. 10 ]
                scatter.y ([ 0 .. 10 ] |> List.rev)
            ]
            traces.scatter [
                scatter.x [ 0 .. 10 ]
                scatter.y [ 0 .. 10 ]
            ]
        ]
        plot.layout [
            layout.xaxis [
                xaxis.type'.log
                xaxis.autorange.true'
            ]
            layout.yaxis [
                yaxis.type'.log
                yaxis.autorange.true'
            ]
        ]
    ]
```