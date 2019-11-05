# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-stylinglineplot
[<RequireQualifiedAccess>]
module Samples.Line.StylingLinePlot

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.lines
                scatter.name "Red"
                scatter.line [
                    line.color (color.rgb(219, 64, 82))
                    line.width 3
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.lines
                scatter.name "Blue"
                scatter.line [
                    line.color (color.rgb(55, 128, 191))
                    line.width 1
                ]
            ]
        ]
        plot.layout [
            layout.width 500
            layout.height 500
        ]
    ]
```