# Feliz.Plotly - Horizontal Bar Charts

Taken from [Plotly - Horizontal Bar Charts](https://plot.ly/javascript/horizontal-bar-charts/)

```fsharp:plotly-chart-horizontalbar-colored
[<RequireQualifiedAccess>]
module Samples.HorizontalBar.Colored

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ 20; 14; 23 ]
                bar.y [ "giraffes"; "orangutans"; "monkeys" ]
                bar.name "SF Zoo"
                bar.orientation.h
                bar.marker [
                    marker.color (color.rgba(55, 128, 191, 0.6))
                ]
            ]
            traces.bar [
                bar.x [ 12; 18; 29 ]
                bar.y [ "giraffes"; "orangutans"; "monkeys" ]
                bar.name "LA Zoo"
                bar.orientation.h
                bar.marker [
                    marker.color (color.rgba(255, 153, 51, 0.6))
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Colored Bar Chart"
            ]
            layout.barmode.stack
        ]
    ]
```