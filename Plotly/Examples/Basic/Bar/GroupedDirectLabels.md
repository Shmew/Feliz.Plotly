# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-groupeddirectlabels
[<RequireQualifiedAccess>]
module Samples.Bar.GroupedDirectLabels

open Feliz
open Feliz.Plotly

let xData = [ "Product A"; "Product B"; "Product C" ]
let yData = [ 20; 14; 23 ]
let yData2 = [ 24; 16; 20 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x xData
                bar.y yData
                bar.text (yData |> List.map string)
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    marker.color (color.rgb(158, 202, 225))
                    marker.opacity 0.6
                    marker.line [
                        line.color (color.rgb(8, 48, 107))
                        line.width 1.5
                    ]
                ]
            ]
            traces.bar [
                bar.x xData
                bar.y yData2
                bar.text (yData |> List.map string)
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    marker.color (color.rgba(58, 200, 224, 0.5))
                    marker.line [
                        line.color (color.rgb(8, 48, 107))
                        line.width 1.5
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "January 2013 Sales Report"
            ]
        ]
    ]
```