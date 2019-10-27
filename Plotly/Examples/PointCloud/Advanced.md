# Feliz.Plotly - Point Cloud

Taken from [Plotly - Point Cloud](https://plot.ly/javascript/pointcloud/)

```fsharp:plotly-chart-pointcloud-advanced
[<RequireQualifiedAccess>]
module Samples.Pie.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pie [
                pie.values [ 19; 26; 55]
                pie.labels [ "Residential"; "Non-Residential"; "Utility" ]
            ]
        ]
        plot.layout [
            layout.height 400
            layout.width 500
        ]
    ]
```