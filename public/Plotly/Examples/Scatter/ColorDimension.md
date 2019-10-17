# Feliz.Plotly - Line and Scatter Plot

Taken from [Plotly - Line and Scatter Plot](https://plot.ly/javascript/line-and-scatter/)

```fsharp:plotly-chart-scatter-colordimension
[<RequireQualifiedAccess>]
module Samples.Scatter.ColorDimension

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.y (5 |> List.replicate 40)
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.size 40
                    scatter.marker.color [0..39]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Scatter Plot with a Color Dimension"
            ]
        ]
    ]
```