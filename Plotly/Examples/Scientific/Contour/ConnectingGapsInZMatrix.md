# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-connectinggapsinzmatrix
[<RequireQualifiedAccess>]
module Samples.Contour.ConnectingGapsInZMatrix

open Feliz
open Feliz.Plotly

let zData =
    [ [ None; None; None; Some 12; Some 13; Some 14; Some 15; Some 16 ]
      [ None; Some 1; None; Some 11; None; None; None; Some 17 ]
      [ None; Some 2; Some 6; Some 7; None; None; None; Some 18 ]
      [ None; Some 3; None; Some 8; None; None; None; Some 19 ]
      [ Some 5; Some 4; Some 10; Some 9; None; None; None; Some 20 ]
      [ None; None; None; Some 27; None; None; None; Some 21 ]
      [ None; None; None; Some 26; Some 25; Some 24; Some 23; Some 22 ] ]
    |> List.map (Seq.ofList >> PlotData.IntOption)

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contour [
                contour.z zData
                contour.showscale false
            ]
            traces.contour [
                contour.z zData
                contour.connectgaps true
                contour.showscale false
                contour.xaxis 2
                contour.yaxis 2
            ]
            traces.heatmap [
                heatmap.z zData
                heatmap.zsmooth.best
                heatmap.showscale false
                heatmap.xaxis 3
                heatmap.yaxis 3
            ]
            traces.heatmap [
                heatmap.z zData
                heatmap.zsmooth.best
                heatmap.showscale false
                heatmap.connectgaps true
                heatmap.xaxis 4
                heatmap.yaxis 4
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Connect the Gaps Between Null Values in the Z Matrix"
            ]
            layout.xaxis [
                xaxis.domain [ 0.; 0.45 ]
                xaxis.anchor.y 1
            ]
            layout.yaxis [
                yaxis.domain [ 0.55; 1. ]
                yaxis.anchor.x 1
            ]
            layout.xaxis (2, [
                xaxis.domain [ 0.55; 1. ]
                xaxis.anchor.y 2
            ])
            layout.yaxis (2, [
                yaxis.domain [ 0.55; 1. ]
                yaxis.anchor.x 2
            ])
            layout.xaxis (3, [
                xaxis.domain [ 0.; 0.45 ]
                xaxis.anchor.y 3
            ])
            layout.yaxis (3, [
                yaxis.domain [ 0.; 0.45 ]
                yaxis.anchor.x 3
            ])
            layout.xaxis (4, [
                xaxis.domain [ 0.55; 1. ]
                xaxis.anchor.y 4
            ])
            layout.yaxis (4, [
                yaxis.domain [ 0.; 0.45 ]
                yaxis.anchor.x 4
            ])
        ]
    ]
```