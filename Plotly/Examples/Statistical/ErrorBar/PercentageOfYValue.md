# Feliz.Plotly - Error Bars

Taken from [Plotly - Error Bars](https://plot.ly/javascript/error-bars/)

```fsharp:plotly-chart-errorbar-percentageofyvalue
[<RequireQualifiedAccess>]
module Samples.ErrorBar.PercentageOfYValue

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0; 1; 2 ]
                scatter.y [ 6; 10; 2 ]
                scatter.errorY [
                    errorY.type'.percent
                    errorY.value 50
                    errorY.visible true
                ]
            ]
        ]
    ]
```