# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-lineshapeoptionsinterpolation
[<RequireQualifiedAccess>]
module Samples.Line.LineShapeOptionsInterpolation

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 1; 3; 2; 3; 1 ]
                scatter.mode.markersAndLines
                scatter.name "Linear"
                scatter.line [
                    scatter.line.shape.linear
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 6; 8; 7; 8; 6 ]
                scatter.mode.markersAndLines
                scatter.name "Spline"
                scatter.text 
                    [ "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object"
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" 
                      "tweak line smoothness&lt;br&gt;with \"smoothing\" in line object" ]
                scatter.line [
                    scatter.line.shape.spline
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 16; 18; 17; 18; 16 ]
                scatter.mode.markersAndLines
                scatter.name "hvh"
                scatter.line [
                    scatter.line.shape.hvh
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 21; 23; 22; 23; 21 ]
                scatter.mode.markersAndLines
                scatter.name "vh"
                scatter.line [
                    scatter.line.shape.vh
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 26; 28; 27; 28; 26 ]
                scatter.mode.markersAndLines
                scatter.name "hv"
                scatter.line [
                    scatter.line.shape.hv
                ]
            ]
        ]
        plot.layout [
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