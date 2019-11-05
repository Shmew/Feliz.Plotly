# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-colored
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Colored

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y [ 1 .. 10 ]
                box.name "Sample A"
                box.marker [
                    marker.color (color.rgb(214, 12, 140))
                ]
            ]
            traces.box [
                box.y [ 2; 3; 3; 3; 3; 5; 6; 6; 7 ]
                box.name "Sample B"
                box.marker [
                    marker.color (color.rgb(0, 128, 128))
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Colored Box Plot"
            ]
        ]
    ]
```