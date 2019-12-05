# Feliz.Plotly - Polar Plots

Taken from [Plotly - Polar Plots](https://plot.ly/javascript/polar-chart/)

```fsharp:plotly-chart-polar-categorical
[<RequireQualifiedAccess>]
module Samples.Polar.Categorical

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterpolar [
                scatterpolar.r [ 5; 4; 2; 4; 5 ]
                scatterpolar.theta [ "a"; "b"; "c"; "d"; "a" ]
                scatterpolar.fill.toself
                scatterpolar.name "angular categories"
            ]
            traces.scatterpolar [
                scatterpolar.r [ "a"; "b"; "c"; "d"; "b"; "f"; "a" ]
                scatterpolar.theta [ 1.; 4.; 2.; 1.5; 1.5; 6.; 5. ]
                scatterpolar.thetaunit.radians
                scatterpolar.fill.toself
                scatterpolar.name "radial categories"
                scatterpolar.subplot 2
            ]
            traces.scatterpolar [
                scatterpolar.r [ 5; 4; 2; 4; 5 ]
                scatterpolar.theta [ "a"; "b"; "c"; "d"; "a" ]
                scatterpolar.fill.toself
                scatterpolar.name "angular categories (w/ categoryarray)"
                scatterpolar.subplot 3
            ]
            traces.scatterpolar [
                scatterpolar.r [ "a"; "b"; "c"; "d"; "b"; "f"; "a"; "a" ]
                scatterpolar.theta [ 45; 90; 180; 200; 300; 15; 20; 45 ]
                scatterpolar.fill.toself
                scatterpolar.name "radial categories (w/ category descending)"
                scatterpolar.subplot 4
            ]
            traces.scatterpolar [
                scatterpolar.r [ 5; 4; 2; 4; 5; 5 ]
                scatterpolar.theta [ "b"; "c"; "d"; "e"; "a"; "b" ]
                scatterpolar.fill.toself
                scatterpolar.name "angular categories (w/ extra category)"
            ]
        ]
        plot.layout [
            layout.width 800
            layout.height 500
            layout.polar [
                polar.domain [
                    domain.x [ 0.; 0.46 ]
                    domain.y [ 0.6; 1. ]
                ]
                polar.radialaxis [
                    radialaxis.angle 45
                ]
                polar.angularaxis [
                    angularaxis.direction.clockwise
                    angularaxis.period 6
                ]
            ]
            layout.polar (2, [
                polar.domain [
                    domain.x [ 0.; 0.46 ]
                    domain.y [ 0.; 0.4 ]
                ]
                polar.radialaxis [
                    radialaxis.angle 180
                    radialaxis.tickangle -180
                ]
            ])
            layout.polar (3, [
                polar.domain [
                    domain.x [ 0.54; 1. ]
                    domain.y [ 0.6; 1. ]
                ]
                polar.sector [ 150; 400 ]
                polar.radialaxis [
                    radialaxis.angle -45
                ]
                polar.angularaxis [
                    angularaxis.categoryarray [ "d"; "a"; "c"; "b" ]
                ]
            ])
            layout.polar (4, [
                polar.domain [
                    domain.x [ 0.54; 1. ]
                    domain.y [ 0.; 0.4 ]
                ]
                polar.radialaxis [
                    radialaxis.categoryorder.categoryDescending
                ]
                polar.angularaxis [
                    angularaxis.thetaunit.radians
                    angularaxis.dtick 0.3141592653589793
                ]
            ])
        ]
    ]
```