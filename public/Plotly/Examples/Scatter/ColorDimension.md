# Feliz.Plotly - Line and Scatter Plot

Taken from [Plotly - Line and Scatter Plot](https://plot.ly/javascript/line-and-scatter/)

```fsharp:plotly-chart-scatter-colordimension
[<RequireQualifiedAccess>]
module Samples.Scatter.ColorDimension

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.y (5 |> List.replicate 40)
                scatter.mode.markers
                scatter.marker [
                    marker.size 40
                    marker.color [0..39]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Scatter Plot with a Color Dimension"
            ]
        ]
    ]
```