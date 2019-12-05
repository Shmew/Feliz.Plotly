# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-grouped
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Grouped

open Feliz
open Feliz.Plotly

let xData = 
    [ "day 1"; "day 1"; "day 1"; "day 1"; "day 1"; "day 1"
      "day 2"; "day 2"; "day 2"; "day 2"; "day 2"; "day 2" ]

let yData = [ 0.2; 0.2; 0.6; 1.0; 0.5; 0.4; 0.2; 0.7; 0.9; 0.1; 0.5; 0.3 ]
let yData2 = [ 0.6; 0.7; 0.3; 0.6; 0.0; 0.5; 0.7; 0.9; 0.5; 0.8; 0.7; 0.2 ]
let yData3 = [ 0.1; 0.3; 0.1; 0.9; 0.6; 0.6; 0.9; 1.0; 0.3; 0.6; 0.8; 0.5 ]

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
            ]
            traces.box [
                box.y yData2
                box.x xData
                box.name "radishes"
                box.marker [
                    marker.color "#FF4136"
                ]
            ]
            traces.box [
                box.y yData3
                box.x xData
                box.name "carrots"
                box.marker [
                    marker.color "#FF851B"
                ]
            ]
        ]
        plot.layout [
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