# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-normalized
[<RequireQualifiedAccess>]
module Samples.Histogram.Normalized

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram [
                histogram.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram.histnorm.probability
                histogram.marker [
                    marker.color (color.rgb(255, 255, 100))
                ]
            ]
        ]
    ]
```