# Feliz.Plotly - WebGL Heatmap Plots

```fsharp:plotly-chart-heatmap-webgl
[<RequireQualifiedAccess>]
module Samples.Heatmap.WebGL

open Feliz
open Feliz.Plotly

let rng = System.Random()

let zData =
    Array.init 500 (fun _ -> Array.init 500 (fun _ -> rng.Next(0, 255) |> float))
    |> Array.concat
    |> Array.map (fun i ->
        [ 0. .. 3. ]
        |> List.map (fun f -> i * 4. + f)
        |> List.sum)
    |> Array.chunkBySize 500

let chart () =
    Plotly.plot [
        plot.traces [
            traces.heatmapgl [
                heatmapgl.z zData
                heatmapgl.colorscale color.colorscale.picnic
            ]
        ]
    ]```