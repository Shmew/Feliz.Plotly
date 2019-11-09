# Feliz.Plotly - Carpet Contour Plots

Taken from [Plotly - Carpet Contour Plots](https://plot.ly/javascript/carpet-contour/)

```fsharp:plotly-chart-carpetcontour-basic
[<RequireQualifiedAccess>]
module Samples.CarpetContour.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contourcarpet [
                contourcarpet.a [ 0; 1; 2; 3; 0; 1; 2; 3; 0; 1; 2; 3 ]
                contourcarpet.b [ 4; 4; 4; 4; 5; 5; 5; 5; 6; 6; 6; 6 ]
                contourcarpet.z [ 1.; 1.96; 2.56; 3.0625; 4.; 5.0625; 1.; 7.5625; 9.; 12.25; 15.21; 14.0625 ]
                contourcarpet.autocontour false
                contourcarpet.contours [
                    contours.start 1
                    contours.end' 14
                    contours.size 1
                ]
                contourcarpet.line [
                    line.width 2
                    line.smoothing 0
                ]
                contourcarpet.colorbar [
                    colorbar.len 0.4
                    colorbar.y 0.25
                ]
            ]
            traces.carpet [
                carpet.a [ 0; 1; 2; 3; 0; 1; 2; 3; 0; 1; 2; 3 ]
                carpet.b [ 4; 4; 4; 4; 5; 5; 5; 5; 6; 6; 6; 6 ]
                carpet.x [ 2.; 3.; 4.; 5.; 2.2; 3.1; 4.1; 5.1; 1.5; 2.5; 3.5; 4.5 ]
                carpet.y [ 1.; 1.4; 1.6; 1.75; 2.; 2.5; 2.7; 2.75; 3.; 3.5; 3.7; 3.75 ]
                carpet.aaxis [
                    aaxis.tickprefix "a = "
                    aaxis.smoothing 0
                    aaxis.minorgridcount 9
                    aaxis.type'.linear
                ]
                carpet.baxis [
                    baxis.tickprefix "b = "
                    baxis.smoothing 0
                    baxis.minorgridcount 9
                    baxis.type'.linear
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Cheater plot with 1d input"
            ]
            layout.margin [
                margin.t 40 
                margin.r 30
                margin.b 30
                margin.l 30
            ]
            layout.yaxis [
                yaxis.range [ 0.388; 4.361 ]
            ]
            layout.xaxis [
                xaxis.range [ 0.667; 5.932 ]
            ]
        ]
    ]
```