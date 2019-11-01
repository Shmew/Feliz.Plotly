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
                    marker.color (colors.rgb(200, 111, 200))
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
                    marker.color colors.cyan
                ]
                scatter.showlegend false
            ]
            traces.histogram2d [
                histogram2d.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 2.))
                histogram2d.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 3.))
                histogram2d.colorscale (
                    [ colors.rgb(0, 225, 100)
                      colors.rgb(100, 0, 200) ]
                    |> colors.colorscale.sequential
                )
            ]
        ]
    ]
