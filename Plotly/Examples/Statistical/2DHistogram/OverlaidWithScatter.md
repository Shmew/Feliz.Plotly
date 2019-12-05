# Feliz.Plotly - 2D Histograms

Taken from [Plotly - 2D Histograms](https://plot.ly/javascript/2D-Histogram/)

```fsharp:plotly-chart-twodimensionalhistogram-overlaidwithscatter
[<RequireQualifiedAccess>]
module Samples.TwoDimensionalHistogram.OverlaidWithScatter

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 1.))
                scatter.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 1.5))
                scatter.mode.markers
                scatter.marker [
                    marker.symbol.circle
                    marker.opacity 0.7
                    marker.color (color.rgb(200, 111, 200))
                ]
                scatter.showlegend false
            ]
            traces.scatter [
                scatter.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                scatter.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 1.))
                scatter.mode.markers
                scatter.marker [
                    marker.symbol.square
                    marker.opacity 0.7
                    marker.color color.cyan
                ]
                scatter.showlegend false
            ]
            traces.histogram2d [
                histogram2d.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 2.))
                histogram2d.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 3.))
                histogram2d.colorscale (
                    [ color.rgb(0, 225, 100)
                      color.rgb(100, 0, 200) ]
                    |> color.colorscale.sequential
                )
            ]
        ]
    ]
```