# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-lineshapeoptionsinterpolation
[<RequireQualifiedAccess>]
module Samples.Line.LineShapeOptionsInterpolation

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 1; 3; 2; 3; 1 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "Linear"
                scatter.line [
                    line.shape.linear
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 6; 8; 7; 8; 6 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "Spline"
                scatter.text 
                    [ "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object"
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" ]
                scatter.line [
                    line.shape.spline
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 16; 18; 17; 18; 16 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "hvh"
                scatter.line [
                    line.shape.hvh
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 21; 23; 22; 23; 21 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "vh"
                scatter.line [
                    line.shape.vh
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 26; 28; 27; 28; 26 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "hv"
                scatter.line [
                    line.shape.hv
                ]
            ]
        ]
        plot.layout [
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