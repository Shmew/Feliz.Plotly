# Feliz.Plotly - Waterfall Charts

Taken from [Plotly - Waterfall Charts](https://plot.ly/javascript/waterfall-charts/)

```fsharp:plotly-chart-waterfall-basic
[<RequireQualifiedAccess>]
module Samples.Waterfall.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.waterfall [
                waterfall.name "2018"
                waterfall.orientation.v
                waterfall.measure [
                    measure.relative
                    measure.relative
                    measure.total
                    measure.relative
                    measure.relative
                    measure.total
                ]
                waterfall.x [
                    "Sales"
                    "Consulting"
                    "Net revenue"
                    "Purchases"
                    "Other expenses"
                    "Profit before tax"
                ]
                waterfall.textposition.outside
                waterfall.text [
                    "+60"
                    "+80"
                    ""
                    "-40"
                    "-20"
                    "Total"
                ]
                waterfall.y [ 60 ; 80; 0; -40; -20; 0 ]
                waterfall.connector [
                    connector.line [
                        line.color (color.rgb(63, 63, 63))
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Profit and loss statement 2018"
            ]
            layout.xaxis [
                xaxis.type'.category
            ]
            layout.yaxis [
                yaxis.type'.linear
            ]
            layout.width 750
            layout.height 500
            layout.showlegend true
        ]
    ]
```