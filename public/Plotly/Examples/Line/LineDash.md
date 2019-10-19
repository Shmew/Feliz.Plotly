# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-linedash
[<RequireQualifiedAccess>]
module Samples.Line.LineDash

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 1; 3; 2; 3; 1 ]
                scatter.mode.lines
                scatter.name "Solid"
                scatter.line [
                    scatter.line.dash "solid" // TODO: see about turning this into an enum
                    scatter.line.width 4
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 6; 8; 7; 8; 6 ]
                scatter.mode.lines
                scatter.name "dashdot"
                scatter.line [
                    scatter.line.dash "dashdot"
                    scatter.line.width 4
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 11; 13; 12; 13; 11 ]
                scatter.mode.lines
                scatter.name "Solid"
                scatter.line [
                    scatter.line.dash "solid"
                    scatter.line.width 4
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 16; 18; 17; 18; 16 ]
                scatter.mode.lines
                scatter.name "dot"
                scatter.line [
                    scatter.line.dash "dot"
                    scatter.line.width 4
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Line Dash"
            ]
            layout.xaxis [
                layout.xaxis.range [ 0.75; 5.25 ]
                layout.xaxis.autorange.false'
            ]
            layout.yaxis [
                layout.yaxis.range [ 0.; 18.5 ]
                layout.yaxis.autorange.false'
            ]
            layout.legend [
                layout.legend.y 0.5
                layout.legend.traceorder.reversed
                layout.legend.font [
                    legend.font.size 16
                ]
            ]
        ]
    ]
```