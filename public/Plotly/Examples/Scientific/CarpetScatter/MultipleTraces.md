# Feliz.Plotly - Carpet Scatter Plots

Taken from [Plotly - Carpet Scatter Plots](https://plot.ly/javascript/carpet-scatter/)

```fsharp:plotly-chart-carpetscatter-multipletraces
[<RequireQualifiedAccess>]
module Samples.CarpetScatter.MultipleTraces

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.carpet [
                carpet.a [ 0.1; 0.2; 0.3 ]
                carpet.b [ 1; 2; 3 ]
                carpet.y [
                    [ 1.; 2.2; 3. ]
                    [ 1.5; 2.7; 3.5 ]
                    [ 1.7; 2.9; 3.7 ]
                ]
                carpet.cheaterslope 1
                carpet.aaxis [
                    aaxis.title [
                        title.text "a"
                    ]
                    aaxis.tickmode.linear
                    aaxis.dtick 0.05
                    aaxis.minorgridcount 9
                ]
                carpet.baxis [
                    baxis.title [
                        title.text "b"
                    ]
                    baxis.tickmode.linear
                    baxis.dtick 0.5
                    baxis.minorgridcount 9
                ]
            ]
            traces.scattercarpet [
                scattercarpet.name "b = 1.5"
                scattercarpet.a [ 0.05; 0.15; 0.25; 0.35 ]
                scattercarpet.b [ 1.5; 1.5; 1.5; 1.5 ]
            ]
            traces.scattercarpet [
                scattercarpet.name "b = 2"
                scattercarpet.a [ 0.05; 0.15; 0.25; 0.35 ]
                scattercarpet.b [ 2; 2; 2; 2 ]
            ]
            traces.scattercarpet [
                scattercarpet.name "b = 2.5"
                scattercarpet.a [ 0.05; 0.15; 0.25; 0.35 ]
                scattercarpet.b [ 2.5; 2.5; 2.5; 2.5 ]
            ]
            traces.scattercarpet [
                scattercarpet.name "a = 0.15"
                scattercarpet.a [ 0.15; 0.15; 0.15; 0.15 ]
                scattercarpet.b [ 0.5; 1.5; 2.5; 3.5 ]
                scattercarpet.line [
                    line.smoothing 1
                    line.shape.spline
                ]
            ]
            traces.scattercarpet [
                scattercarpet.name "a = 0.2"
                scattercarpet.a [ 0.2; 0.2; 0.2; 0.2 ]
                scattercarpet.b [ 0.5; 1.5; 2.5; 3.5 ]
                scattercarpet.line [
                    line.smoothing 1
                    line.shape.spline
                ]
                scattercarpet.marker [
                    marker.size [ 10; 20; 30; 40 ]
                    marker.color [ "#000"; "#f00"; "#ff0"; "#fff" ]
                ]
            ]
            traces.scattercarpet [
                scattercarpet.name "a = 0.25"
                scattercarpet.a [ 0.25; 0.25; 0.25; 0.25 ]
                scattercarpet.b [ 0.5; 1.5; 2.5; 3.5 ]
                scattercarpet.line [
                    line.smoothing 1
                    line.shape.spline
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "scattercarpet extrapolation, clipping, and smoothing"
            ]
            layout.hovermode.closest
        ]
    ]
```