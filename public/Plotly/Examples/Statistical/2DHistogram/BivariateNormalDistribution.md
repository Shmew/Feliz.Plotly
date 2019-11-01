# Feliz.Plotly - 2D Histograms

Taken from [Plotly - 2D Histograms](https://plot.ly/javascript/2D-Histogram/)

```fsharp:plotly-chart-twodimensionalhistogram-bivariatenormaldistribution
[<RequireQualifiedAccess>]
module Samples.TwoDimensionalHistogram.BivariateNormalDistribution

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram2d [
                histogram2d.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram2d.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 0.1))
            ]
        ]
    ]
```