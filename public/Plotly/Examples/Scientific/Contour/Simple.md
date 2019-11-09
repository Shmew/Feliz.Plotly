# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-simple
[<RequireQualifiedAccess>]
module Samples.Contour.Simple

open Feliz
open Feliz.Plotly
open System

let xData, yData =
    [ 0. .. 99. ]
    |> List.map (fun i -> -2. * Math.PI + 4. * Math.PI * i / 100.)
    |> fun res -> res,res

let zData =
    xData
    |> List.map (fun x ->
        yData
        |> List.map (fun y ->
            let r2 = x * x + y * y
            Math.Sin(x) * Math.Cos(y) * Math.Sin(r2) / Math.Log(r2 + 1.)))

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contour [
                contour.z zData
                contour.x xData
                contour.y yData
            ]
        ]
    ]
```