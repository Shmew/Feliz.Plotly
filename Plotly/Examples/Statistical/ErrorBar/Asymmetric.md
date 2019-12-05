# Feliz.Plotly - Error Bars

Taken from [Plotly - Error Bars](https://plot.ly/javascript/error-bars/)

```fsharp:plotly-chart-errorbar-asymmetric
[<RequireQualifiedAccess>]
module Samples.ErrorBar.Asymmetric

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 2; 1; 3; 4 ]
                scatter.errorY [
                    errorY.symmetric false
                    errorY.array [ 0.1; 0.2; 0.1; 0.1 ]
                    errorY.arrayminus [ 0.2; 0.4; 1.; 0.2 ]
                ]
            ]
        ]
    ]
```