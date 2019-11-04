# Feliz.Plotly - Bubble Charts

Taken from [Plotly - Bubble Charts](https://plot.ly/javascript/bubble-charts/)

```fsharp:plotly-chart-bubble-hovertext
[<RequireQualifiedAccess>]
module Samples.Bubble.HoverText

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 11; 12; 13 ]
                scatter.text ["A<br>size: 40"; "B<br>size: 60"; "C<br>size: 80"; "D<br>size: 100"]
                scatter.mode.markers
                scatter.marker [
                    marker.color [ color.rgb(93, 164, 214); color.rgb(255, 144, 14); color.rgb(44, 160, 101); color.rgb(255, 65, 54) ]
                    marker.opacity [ 1.; 0.8; 0.6; 0.4 ]
                    marker.size [ 40; 60; 80; 100 ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Hover Text"
            ]
            layout.showlegend false
            layout.height 400
            layout.width 480
        ]
    ]
```