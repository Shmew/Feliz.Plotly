# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-basic
[<RequireQualifiedAccess>]
module Samples.Bar.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
            ]
        ]
    ]
```