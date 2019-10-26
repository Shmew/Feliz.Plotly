# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-relativebarmode
[<RequireQualifiedAccess>]
module Samples.Bar.RelativeBarmode

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ 1; 4; 9; 16 ]
                bar.name "Trace1"
            ]
            traces.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ 6.; -8.; -4.5; 8. ]
                bar.name "Trace2"
            ]
            traces.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ -15.; -3.; 4.5; -8.]
                bar.name "Trace3"
            ]
            traces.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ -1; 3; -3; -4 ]
                bar.name "Trace4"
            ]
        ]
        plot.layout [
            layout.xaxis [
                xaxis.title [
                    title.text "X axis"
                ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "Y axis"
                ]
            ]
            layout.barmode.relative
            layout.title [
                title.text "Relative Barmode"
            ]
        ]
    ]
```