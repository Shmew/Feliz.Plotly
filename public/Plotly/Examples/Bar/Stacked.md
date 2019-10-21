# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-stacked
[<RequireQualifiedAccess>]
module Samples.Bar.Stacked

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
                bar.name "SF Zoo"
            ]
            data.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 12; 18; 29 ]
                bar.name "LA Zoo"
            ]
            
        ]
        plot.layout [
            layout.bar [
                layout.bar.barmode.stack
            ]
        ]
    ]
```