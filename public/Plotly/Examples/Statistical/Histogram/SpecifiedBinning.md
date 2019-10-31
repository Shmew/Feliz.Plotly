# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-specifiedbinning
[<RequireQualifiedAccess>]
module Samples.Histogram.SpecifiedBinning

open Feliz
open Feliz.Plotly

let dataX = ["Apples";"Apples";"Apples";"Organges"; "Bananas"]
let dataY = ["5";"10";"3";"10";"5"]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram [
                histogram.histfunc.count
                histogram.y dataY
                histogram.x dataX
                histogram.name "count"
            ]
            traces.histogram [
                histogram.histfunc.sum
                histogram.y dataY
                histogram.x dataX
                histogram.name "sum"
            ]
        ]
    ]
```