# Feliz.Plotly - 2D Histograms

Taken from [Plotly - 2D Histograms](https://plot.ly/javascript/2D-Histogram/)

```fsharp:plotly-chart-twodimensionalhistogram-binningandstyling
[<RequireQualifiedAccess>]
module Samples.TwoDimensionalHistogram.BinningAndStyling

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram2d [
                histogram2d.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram2d.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 0.1))
                histogram2d.histnorm.probability
                histogram2d.autobinx false
                histogram2d.xbins [
                    xbins.start -3
                    xbins.end' 3
                    xbins.size 0.1
                ]
                histogram2d.autobiny false
                histogram2d.ybins [
                    ybins.start -2.5
                    ybins.end' 4
                    ybins.size 0.1
                ]
                histogram2d.colorscale (
                    [ color.rgb(12, 51, 131)
                      color.rgb(10, 136, 186)
                      color.rgb(242, 211, 56)
                      color.rgb(242, 143, 56)
                      color.rgb(217, 30, 30) ]
                    |> color.colorscale.sequential
                )
            ]
        ]
    ]
```