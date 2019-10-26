# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-widths
[<RequireQualifiedAccess>]
module Samples.Bar.Widths

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ 1.; 2.; 3.; 5.5; 10. ]
                bar.y [ 10; 8; 6; 4; 2 ]
                bar.width [ 0.8; 0.8; 0.8; 3.5; 4. ]
            ]
        ]
    ]
```