# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-hovertext
[<RequireQualifiedAccess>]
module Samples.Bar.HoverText

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "Liam"; "Sophie"; "Jacob"; "Mia"; "William"; "Olivia" ]
                bar.y [ 8.0; 8.0; 12.0; 12.0; 13.0; 20.0 ]
                bar.text [ "4.17 below the mean"; "4.17 below the mean"; "0.17 below the mean"; "0.17 below the mean"; "0.83 above the mean"; "7.83 above the mean" ]
                bar.marker [
                    marker.color (color.rgb(142, 124, 195))
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Number of Graphs Made this Week"
                title.font [
                    font.family "Raleway, sans-serif"
                ]
            ]
            layout.showlegend false
            layout.xaxis [
                xaxis.tickangle -45
            ]
            layout.yaxis [
                yaxis.zeroline false
                yaxis.gridwidth 2
            ]
            layout.bargap 0.05
        ]
    ]
```