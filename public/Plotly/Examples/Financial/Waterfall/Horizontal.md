# Feliz.Plotly - Waterfall Charts

Taken from [Plotly - Waterfall Charts](https://plot.ly/javascript/waterfall-charts/)

```fsharp:plotly-chart-waterfall-horizontal
[<RequireQualifiedAccess>]
module Samples.Waterfall.Horizontal

open Feliz
open Feliz.Plotly

let xData =
    [ Some 375; Some 128; Some 78; Some 27; None; Some -327
      Some -12; Some -78; Some -12; None; Some 32; Some 89
      None; Some -45; None ]

let measureData = 
    [ measure.relative; measure.relative; measure.relative; measure.relative
      measure.total; measure.relative; measure.relative; measure.relative
      measure.relative; measure.total; measure.relative; measure.relative
      measure.total; measure.relative; measure.total ]

let yData =
    [ "Sales"; "Consulting"; "Maintenance"; "Other revenue"
      "Net revenue"; "Purchases"; "Material expenses";
      "Personnel expenses"; "Other expenses"; "Operating profit"
      "Investment income"; "Financial income"; "Profit before tax"
      "Income tax (15%)"; "Profit after tax" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.waterfall [
                waterfall.name "2018"
                waterfall.orientation.h
                waterfall.x xData
                waterfall.measure measureData
                waterfall.y yData
                waterfall.base' 1000
                waterfall.connector [
                    connector.mode.between
                    connector.line [
                        line.width 4
                        line.color (color.rgb(0, 0, 0))
                        line.dash.custom [ 0 ]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Profit and loss statement 2018<br>waterfall chart displaying positive and negative"
            ]
            layout.yaxis [
                yaxis.type'.category
                yaxis.autorange.reversed
            ]
            layout.xaxis [
                xaxis.type'.linear
            ]
            layout.margin [
                margin.l 150
            ]
            layout.showlegend true
        ]
    ]
```