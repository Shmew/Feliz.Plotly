# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-directlabels
[<RequireQualifiedAccess>]
module Samples.Bar.DirectLabels

open Feliz
open Feliz.Plotly

let yData = [ 20; 14; 23 ]

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "Product A"; "Product B"; "Product C" ]
                bar.y yData
                bar.text (yData |> List.map string)
                bar.textposition.auto
                bar.hoverinfo.none
                bar.marker [
                    bar.marker.color (colors.rgb(158, 202, 225))
                    bar.marker.opacity 0.6
                    bar.marker.line [
                        marker.line.color (colors.rgb(8, 48, 107))
                        marker.line.width 1.5
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "January 2013 Sales Report"
            ]
        ]
    ]
```