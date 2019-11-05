# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-rotatedlabels
[<RequireQualifiedAccess>]
module Samples.Bar.RotatedLabels

open Feliz
open Feliz.Plotly

let xData = [ "Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun"; "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec" ]
let yData = [ 20; 14; 25; 16; 18; 22; 19; 15; 12; 16; 14; 17 ]
let yData2 = [ 19; 14; 22; 14; 16; 19; 15; 14; 10; 12; 12; 16 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x xData
                bar.y yData
                bar.text "Primary Product"
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    marker.color (color.rgb(49, 130, 189))
                    marker.opacity 0.7
                ]
            ]
            traces.bar [
                bar.x xData
                bar.y yData2
                bar.text "Secondary Product"
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    marker.color (color.rgb(204, 204, 204))
                    marker.opacity 0.5
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "2013 Sales Report"
            ]
            layout.xaxis [
                xaxis.tickangle -45
            ]
            layout.barmode.group
        ]
    ]
```