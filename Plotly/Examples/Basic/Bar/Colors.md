# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-colors
[<RequireQualifiedAccess>]
module Samples.Bar.Colors

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "Feature A"; "Feature B"; "Feature C"; "Feature D"; "Feature E" ]
                bar.y [ 20; 14; 23; 25; 22 ]
                bar.marker [
                    marker.color [ 
                        color.rgba(204,204,204,1.)
                        color.rgba(222, 45, 38, 0.8)
                        color.rgba(204, 204, 204, 1)
                        color.rgba(204, 204, 204, 1.)
                        color.rgba(204, 204, 204, 1.) 
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Least Used Feature"
            ]
        ]
    ]
```