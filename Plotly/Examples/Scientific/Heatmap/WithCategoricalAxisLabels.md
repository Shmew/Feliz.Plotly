# Feliz.Plotly - Heatmap Plots

Taken from [Plotly - Heatmap Plots](https://plot.ly/javascript/heatmaps/)

```fsharp:plotly-chart-heatmap-withcategoricalaxislabels
[<RequireQualifiedAccess>]
module Samples.Heatmap.WithCategoricalAxisLabels

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.heatmap [
                heatmap.z [
                    [ 1; 20; 30; 50; 1 ]
                    [ 20; 1; 60; 80; 30 ]
                    [ 30; 60; 1; -10; 20 ]
                ]
                heatmap.x [ "Monday"; "Tuesday"; "Wednesday"; "Thursday"; "Friday" ]
                heatmap.y [ "Morning"; "Afternoon"; "Evening" ]
            ]
        ]
    ]
```