# Feliz.Plotly - Error Bars

Taken from [Plotly - Error Bars](https://plot.ly/javascript/error-bars/)

```fsharp:plotly-chart-errorbar-horizontal
[<RequireQualifiedAccess>]
module Samples.ErrorBar.Horizontal

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 2; 1; 3; 4 ]
                scatter.errorX [
                    errorX.type'.percent
                    errorX.value 10
                ]
            ]
        ]
    ]
```