# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-horizontal
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Horizontal

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.x [ 1 .. 10 ]
                box.name "Set 1"
            ]
            traces.box [
                box.x [ 2; 3; 3; 3; 3; 5; 6; 6; 7 ]
                box.name "Set 2"
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Horizontal Box Plot"
            ]
        ]
    ]
```