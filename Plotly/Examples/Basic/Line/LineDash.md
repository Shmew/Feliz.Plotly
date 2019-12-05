# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-linedash
[<RequireQualifiedAccess>]
module Samples.Line.LineDash

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 1; 3; 2; 3; 1 ]
                scatter.mode.lines
                scatter.name "Solid"
                scatter.line [
                    line.dash.solid
                    line.width 4
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 6; 8; 7; 8; 6 ]
                scatter.mode.lines
                scatter.name "dashdot"
                scatter.line [
                    line.dash.dashdot
                    line.width 4
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 11; 13; 12; 13; 11 ]
                scatter.mode.lines
                scatter.name "Solid"
                scatter.line [
                    line.dash.solid
                    line.width 4
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 16; 18; 17; 18; 16 ]
                scatter.mode.lines
                scatter.name "dot"
                scatter.line [
                    line.dash.dot
                    line.width 4
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Line Dash"
            ]
            layout.xaxis [
                xaxis.range [ 0.75; 5.25 ]
                xaxis.autorange.false'
            ]
            layout.yaxis [
                yaxis.range [ 0.; 18.5 ]
                yaxis.autorange.false'
            ]
            layout.legend [
                legend.y 0.5
                legend.traceorder.reversed
                legend.font [
                    font.size 16
                ]
            ]
        ]
    ]
```