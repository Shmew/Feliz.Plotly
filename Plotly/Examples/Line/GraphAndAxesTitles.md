# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-graphandaxestitles
[<RequireQualifiedAccess>]
module Samples.Line.GraphAndAxesTitles

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4; 5 ]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Title of the Graph"
            ]
            layout.xaxis [
                xaxis.title [
                    title.text "x-axis title"
                ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "y-axis title"
                ]
            ]
        ]
    ]
```