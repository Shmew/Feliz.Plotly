# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-graphandaxestitles
[<RequireQualifiedAccess>]
module Samples.Line.GraphAndAxesTitles

open Feliz
open Feliz.Plotly

module xaxis = Plotly.layout.xaxis
module yaxis = Plotly.layout.yaxis

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
            ]
            data.scatter [
                scatter.x [ 2; 3; 4; 5 ]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.markersAndLines
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Title of the Graph"
            ]
            layout.xaxis [
                layout.xaxis.title [
                    xaxis.title.text "x-axis title"
                ]
            ]
            layout.yaxis [
                layout.yaxis.title [
                    yaxis.title.text "y-axis title"
                ]
            ]
        ]
    ]
```