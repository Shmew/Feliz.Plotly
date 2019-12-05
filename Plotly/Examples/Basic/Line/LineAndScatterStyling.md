# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-lineandscatterstyling
[<RequireQualifiedAccess>]
module Samples.Line.LineAndScatterStyling

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
                scatter.marker [
                    marker.color (color.rgb(219, 64, 82))
                    marker.size 12
                ]
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4; 5 ]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
                scatter.line [
                    line.color (color.rgb(55, 128, 191))
                    line.width 3
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.marker [
                    marker.color (color.rgb(128, 0, 128))
                    marker.size 8
                ]
                scatter.line [
                    line.color (color.rgb(128, 0, 128))
                    line.width 1
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Line and Scatter Styling"
            ]
        ]
    ]
```