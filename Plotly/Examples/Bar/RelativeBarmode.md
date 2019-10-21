# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-relativebarmode
[<RequireQualifiedAccess>]
module Samples.Bar.RelativeBarmode

open Feliz
open Feliz.Plotly

module xaxis = Plotly.layout.xaxis
module yaxis = Plotly.layout.yaxis

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ 1; 4; 9; 16 ]
                bar.name "Trace1"
            ]
            data.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ 6.; -8.; -4.5; 8. ]
                bar.name "Trace2"
            ]
            data.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ -15.; -3.; 4.5; -8.]
                bar.name "Trace3"
            ]
            data.bar [
                bar.x [ 1; 2; 3; 4 ]
                bar.y [ -1; 3; -3; -4 ]
                bar.name "Trace4"
            ]
        ]
        plot.layout [
            layout.xaxis [
                layout.xaxis.title [
                    xaxis.title.text "X axis"
                ]
            ]
            layout.yaxis [
                layout.yaxis.title [
                    yaxis.title.text "Y axis"
                ]
            ]
            layout.bar [
                layout.bar.barmode.relative
            ]
            layout.title [
                layout.title.text "Relative Barmode"
            ]
        ]
    ]
```