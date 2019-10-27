# Feliz.Plotly - Pie Charts

Taken from [Plotly - Pie Charts](https://plot.ly/javascript/pie-charts/)

```fsharp:plotly-chart-pie-basic
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