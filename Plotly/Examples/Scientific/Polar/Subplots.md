# Feliz.Plotly - Polar Plots

Taken from [Plotly - Polar Plots](https://plot.ly/javascript/polar-chart/)

```fsharp:plotly-chart-polar-subplots
[<RequireQualifiedAccess>]
module Samples.Polar.Subplots

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterpolar [
                scatterpolar.r [ 1; 2; 3 ]
                scatterpolar.theta [ 50; 100; 200 ]
                scatterpolar.marker [
                    marker.symbol.square
                ]
            ]
            traces.scatterpolar [
                scatterpolar.r [ 1; 2; 3 ]
                scatterpolar.theta [ 1; 2; 3 ]
                scatterpolar.thetaunit.radians
            ]
            traces.scatterpolar [
                scatterpolar.r [ "a"; "b"; "c"; "b" ]
                scatterpolar.theta [ "D"; "C"; "B"; "A" ]
                scatterpolar.subplot 2
            ]
            traces.scatterpolar [
                scatterpolar.r [ 50; 300; 900 ]
                scatterpolar.theta [ 0; 90; 190 ]
                scatterpolar.subplot 3
            ]
            traces.scatterpolar [
                scatterpolar.r [ 3; 3; 4; 3 ]
                scatterpolar.theta [ 0; 45; 90; 270 ]
                scatterpolar.fill.toself
                scatterpolar.subplot 4
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.height 500
            layout.polar [
                polar.domain [
                    domain.x [ 0.; 0.46 ]
                    domain.y [ 0.6; 1. ]
                ]
                polar.radialaxis [
                    radialaxis.range [ 1; 4 ]
                ]
                polar.angularaxis [
                    angularaxis.thetaunit.radians
                ]
            ]
            layout.polar (2, [
                polar.domain [
                    domain.x [ 0.; 0.46 ]
                    domain.y [ 0.; 0.4 ]
                ]
            ])
            layout.polar (3, [
                polar.domain [
                    domain.x [ 0.54; 1. ]
                    domain.y [ 0.6; 1. ]
                ]
                polar.radialaxis [
                    radialaxis.type'.log
                    radialaxis.tickangle 45
                ]
                polar.sector [ 0; 180 ]
            ])
            layout.polar (4, [
                polar.domain [
                    domain.x [ 0.54; 1. ]
                    domain.y [ 0.; 0.4 ]
                ]
                polar.radialaxis [
                    radialaxis.visible false
                    radialaxis.range [ 0; 6 ]
                ]
            ])
        ]
    ]
```