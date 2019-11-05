# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-waterfall
[<RequireQualifiedAccess>]
module Samples.Bar.Waterfall

open Feliz
open Feliz.Plotly

let xData = 
    [ "Product<br>Revenue"
      "Services<br>Revenue"
      "Total<br>Revenue"
      "Fixed<br>Costs";
      "Variable<br>Costs"
      "Total<br>Costs"
      "Total" ]

let yData = [ 400; 660; 660; 590; 400; 400; 340 ]
let textList = [ "$430K"; "$260K"; "$690K"; "$-120K"; "$-200K"; "$-320K"; "$370K" ]

let ann =
    [0..6]
    |> List.map (fun i ->
        annotations.annotation [
            annotation.x xData.[i]
            annotation.y yData.[i]
            annotation.text textList.[i]
            annotation.font [
                font.family font.arial
                font.size 14
                font.color (color.rgba(245, 246, 249, 1))
            ]
            annotation.showarrow false
        ])

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x xData
                bar.y [ 0; 430; 0; 570; 370; 370; 0 ]
                bar.marker [
                    marker.color (color.rgba(1, 1, 1, 0.))
                ]
            ]
            traces.bar [
                bar.x xData
                bar.y [ 430; 260; 690; 0; 0; 0; 0 ]
                bar.marker [
                    marker.color (color.rgba(55, 128, 191, 0.7))
                    marker.line [
                        line.color (color.rgba(55, 128, 191, 1.0))
                        line.width 2
                    ]
                ]
            ]
            traces.bar [
                bar.x xData
                bar.y [ 0; 0; 0; 120; 200; 320; 0 ]
                bar.marker [
                    marker.color (color.rgba(219, 64, 82, 0.7))
                    marker.line [
                        line.color (color.rgba(219, 64, 82, 1.0))
                        line.width 2
                    ]
                ]
            ]
            traces.bar [
                bar.x xData
                bar.y [0; 0; 0; 0; 0; 0; 370]
                bar.marker [
                    marker.color (color.rgba(50, 171, 96, 0.7))
                    marker.line [
                        line.color (color.rgba(50, 171, 96, 1.0))
                        line.width 2
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Annual Profit 2015"
            ]
            layout.barmode.stack
            layout.paperBgcolor (color.rgba(245, 246, 249, 1))
            layout.plotBgcolor (color.rgba(245, 246, 249, 1))
            layout.width 600
            layout.height 600
            layout.showlegend false
            layout.annotations ann
        ]
    ]
```