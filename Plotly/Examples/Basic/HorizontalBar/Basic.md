# Feliz.Plotly - Horizontal Bar Charts

Taken from [Plotly - Horizontal Bar Charts](https://plot.ly/javascript/horizontal-bar-charts/)

```fsharp:plotly-chart-horizontalbar-basic
[<RequireQualifiedAccess>]
module Samples.HorizontalBar.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ 20; 14; 23 ]
                bar.y [ "giraffes"; "orangutans"; "monkeys" ]
                bar.orientation.h
            ]
        ]
    ]
```