# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-horizontal
[<RequireQualifiedAccess>]
module Samples.Histogram.Horizontal

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram [
                histogram.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram.marker [
                    marker.color color.pink
                ]
            ]
        ]
    ]
```