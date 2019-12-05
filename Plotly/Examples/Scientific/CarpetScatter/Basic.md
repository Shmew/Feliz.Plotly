# Feliz.Plotly - Carpet Scatter Plots

Taken from [Plotly - Carpet Scatter Plots](https://plot.ly/javascript/carpet-scatter/)

```fsharp:plotly-chart-carpetscatter-basic
[<RequireQualifiedAccess>]
module Samples.CarpetScatter.Basic

open Feliz
open Feliz.Plotly

let aCarpetData =
    [ 4.;  4.;  4.;  4.5;  4.5;  4.5;  5.;  5.;  5.;  6.;  6.;  6. ]
    |> List.map (fun a -> a * 1e-6)

let aScatterData =
    [ 4.; 4.5; 5.; 6. ]
    |> List.map (fun a -> a * 1e-6)

let bCarpetData = 
    [ 1;  2;  3;  1;  2;  3;  1;  2;  3;  1;  2;  3 ]
    |> List.map (float >> fun b -> b * 1e6)

let bScatterData =
    [ 1.5; 2.5; 1.5; 2.5 ]
    |> List.map (fun b -> b * 1e6)

let chart () =
    Plotly.plot [
        plot.traces [
            traces.carpet [
                carpet.a aCarpetData
                carpet.b bCarpetData
                carpet.y [ 2.;  3.5;  4.;  3.;  4.5;  5.;  5.5;  6.5;  7.5;  8.;  8.5;  10. ]
                carpet.aaxis [
                    aaxis.tickprefix "a = "
                    aaxis.ticksuffix "m"
                    aaxis.smoothing 1
                    aaxis.minorgridcount 9
                ]
                carpet.baxis [
                    baxis.tickprefix "b = "
                    baxis.ticksuffix "Pa"
                    baxis.smoothing 1
                    baxis.minorgridcount 9
                ]
            ]
            traces.scattercarpet [
                scattercarpet.a aScatterData
                scattercarpet.b bScatterData
                scattercarpet.line [
                    line.shape.spline
                    line.smoothing 1
                ]
            ]
        ]
    ]
```