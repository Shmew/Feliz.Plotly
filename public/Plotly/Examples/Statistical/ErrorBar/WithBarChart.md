# Feliz.Plotly - Error Bars

Taken from [Plotly - Error Bars](https://plot.ly/javascript/error-bars/)

```fsharp:plotly-chart-errorbar-withbarchart
[<RequireQualifiedAccess>]
module Samples.ErrorBar.WithBarChart

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "Trial 1"; "Trial 2"; "Trial 3" ]
                bar.y [ 3; 6; 4 ]
                bar.name "Control"
                bar.errorY [
                    errorY.array [ 1.; 0.5; 1.5 ]
                    errorY.visible true
                ]
            ]
            traces.bar [
                bar.x [ "Trial 1"; "Trial 2"; "Trial 3" ]
                bar.y [ 4; 7; 3 ]
                bar.name "Experimental"
                bar.errorY [
                    errorY.array [ 0.5; 1.; 2. ]
                    errorY.visible true
                ]
            ]
        ]
        plot.layout [
            layout.barmode.group
        ]
    ]
```