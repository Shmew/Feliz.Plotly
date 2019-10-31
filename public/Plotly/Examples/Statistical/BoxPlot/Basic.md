# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-basic
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Basic

open Feliz
open Feliz.Plotly
open System

let yData, yData2 =
    let rng = Random()
    [ 0 .. 49 ]
    |> List.map (fun _ -> (rng.NextDouble(), (rng.NextDouble()+0.1)))
    |> List.unzip

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y yData
            ]
            traces.box [
                box.y yData2
            ]
        ]
    ]
```