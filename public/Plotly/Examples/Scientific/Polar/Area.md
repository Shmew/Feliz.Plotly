# Feliz.Plotly - Polar Plots

Taken from [Plotly - Polar Plots](https://plot.ly/javascript/polar-chart/)

```fsharp:plotly-chart-polar-area
[<RequireQualifiedAccess>]
module Samples.Polar.Area

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterpolar [
                scatterpolar.r [ 0.; 1.5; 1.5; 0.; 2.5; 2.5; 0. ]
                scatterpolar.theta [ 0; 10; 25; 0; 205; 215; 0 ]
                scatterpolar.mode.lines
                scatterpolar.fill.toself
                scatterpolar.fillcolor "#709BFF"
                scatterpolar.line [
                    line.color color.black
                ]
            ]
            traces.scatterpolar [
                scatterpolar.r [ 0.; 3.5; 3.5; 0. ]
                scatterpolar.theta [ 0; 55; 75; 0 ]
                scatterpolar.mode.lines
                scatterpolar.fill.toself
                scatterpolar.fillcolor "#E4FF87"
                scatterpolar.line [
                    line.color color.black
                ]
            ]
            traces.scatterpolar [
                scatterpolar.r [ 0.; 4.5; 4.5; 0.; 4.5; 4.5; 0. ]
                scatterpolar.theta [ 0; 100; 120; 0; 305; 320; 0 ]
                scatterpolar.mode.lines
                scatterpolar.fill.toself
                scatterpolar.fillcolor "#FFAA70"
                scatterpolar.line [
                    line.color color.black
                ]
            ]
            traces.scatterpolar [
                scatterpolar.r [ 0; 4; 4; 0 ]
                scatterpolar.theta [ 0; 165; 195; 0 ]
                scatterpolar.mode.lines
                scatterpolar.fill.toself
                scatterpolar.fillcolor "#FFDF70"
                scatterpolar.line [
                    line.color color.black
                ]
            ]
            traces.scatterpolar [
                scatterpolar.r [ 0; 3; 3; 0 ]
                scatterpolar.theta [ 0.; 262.5; 277.5; 0. ]
                scatterpolar.mode.lines
                scatterpolar.fill.toself
                scatterpolar.fillcolor "#B6FFB4"
                scatterpolar.line [
                    line.color color.black
                ]
            ]
        ]
        plot.layout [
            layout.showlegend true
            layout.polar [
                polar.radialaxis [
                    radialaxis.visible true
                    radialaxis.range [ 0; 5 ]
                ]
            ]
        ]
    ]
```