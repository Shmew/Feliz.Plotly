# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-smoothinglines
[<RequireQualifiedAccess>]
module Samples.Contour.SmoothingLines

open Feliz
open Feliz.Plotly

let zData =
    [ [ 2; 4; 7; 12; 13; 14; 15; 16 ]
      [ 3; 1; 6; 11; 12; 13; 16; 17 ]
      [ 4; 2; 7; 7; 11; 14; 17; 18 ]
      [ 5; 3; 8; 8; 13; 15; 18; 19 ]
      [ 7; 4; 10; 9; 16; 18; 20; 19 ]
      [ 9; 10; 5; 27; 23; 21; 21; 21 ]
      [ 11; 14; 17; 26; 25; 24; 23; 22 ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contour [
                contour.z zData
                contour.line [
                    line.smoothing 0
                ]
            ]
            traces.contour [
                contour.z zData
                contour.line [
                    line.smoothing 0.85
                ]
                contour.xaxis 2
                contour.yaxis 2
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Smoothing Contour Lines"
            ]
            layout.xaxis [
                xaxis.domain [ 0.; 0.45 ]
                xaxis.anchor.y 1
            ]
            layout.yaxis [
                yaxis.domain [ 0.; 1. ]
                yaxis.anchor.x 1
            ]
            layout.xaxis (2, [
                xaxis.domain [ 0.55; 1. ]
                xaxis.anchor.y 2
            ])
            layout.yaxis (2, [
                yaxis.domain [ 0.; 1. ]
                yaxis.anchor.x 2
            ])
        ]
    ]
```