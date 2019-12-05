# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-groupedhorizontal
[<RequireQualifiedAccess>]
module Samples.BoxPlot.GroupedHorizontal

open Feliz
open Feliz.Plotly

let yData = 
    [ "day 1"; "day 1"; "day 1"; "day 1"; "day 1"; "day 1"
      "day 2"; "day 2"; "day 2"; "day 2"; "day 2"; "day 2" ]

let xData = [ 0.2; 0.2; 0.6; 1.0; 0.5; 0.4; 0.2; 0.7; 0.9; 0.1; 0.5; 0.3 ]
let xData2 = [ 0.6; 0.7; 0.3; 0.6; 0.0; 0.5; 0.7; 0.9; 0.5; 0.8; 0.7; 0.2 ]
let xData3 = [ 0.1; 0.3; 0.1; 0.9; 0.6; 0.6; 0.9; 1.0; 0.3; 0.6; 0.8; 0.5 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y yData
                box.x xData
                box.name "kale"
                box.marker [
                    marker.color "#3D9970"
                ]
                box.boxmean.false'
                box.orientation.h
            ]
            traces.box [
                box.y yData
                box.x xData2
                box.name "radishes"
                box.marker [
                    marker.color "#FF4136"
                ]
                box.boxmean.false'
                box.orientation.h
            ]
            traces.box [
                box.y yData
                box.x xData3
                box.name "carrots"
                box.marker [
                    marker.color "#FF851B"
                ]
                box.boxmean.false'
                box.orientation.h
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Grouped Horizontal Box Plot"
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "normalized moisture"
                ]
                yaxis.zeroline false
            ]
            layout.boxmode.group
        ]
    ]
```