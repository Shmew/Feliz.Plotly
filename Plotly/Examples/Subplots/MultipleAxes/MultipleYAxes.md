# Feliz.Plotly - Multiple Axes

Taken from [Plotly - Multiple Axes](https://plot.ly/javascript/multiple-axes/)

```fsharp:plotly-chart-multipleaxes-multipleyaxes
[<RequireQualifiedAccess>]
module Samples.MultipleAxes.MultipleYAxes

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 4; 5; 6 ]
                scatter.name "yaxis data"
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4 ]
                scatter.y [ 40; 50; 60 ]
                scatter.name "yaxis2 data"
                scatter.yaxis 2
            ]
            traces.scatter [
                scatter.x [ 4; 5; 6 ]
                scatter.y [ 40000; 50000; 60000 ]
                scatter.name "yaxis3 data"
                scatter.yaxis 3
            ]
            traces.scatter [
                scatter.x [ 5; 6; 7 ]
                scatter.y [ 400000; 500000; 600000 ]
                scatter.name "yaxis4 data"
                scatter.yaxis 4
            ]
        ]
        plot.layout [
            layout.width 800
            layout.title [
                title.text "multiple y-axes example"
            ]
            layout.xaxis [
                xaxis.domain [ 0.3; 0.7 ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "yaxis title"
                    title.font [
                        font.color "#1f77b4"
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color "#1f77b4"
                ]
            ]
            layout.yaxis (2, [
                yaxis.title [
                    title.text "yaxis2 title"
                    title.font [
                        font.color "#ff7f0e"
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color "#ff7f0e"
                ]
                yaxis.anchor.free
                yaxis.overlaying.y 1
                yaxis.side.left
                yaxis.position 0.15
            ])
            layout.yaxis (3, [
                yaxis.title [
                    title.text "yaxis3 title"
                    title.font [
                        font.color "#d62728"
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color "#d62728"
                ]
                yaxis.anchor.x 1
                yaxis.overlaying.y 1
                yaxis.side.right
            ])
            layout.yaxis (4, [
                yaxis.title [
                    title.text "yaxis4 title"
                    title.font [
                        font.color "#9467bd"
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color "#9467bd"
                ]
                yaxis.anchor.free
                yaxis.overlaying.y 1
                yaxis.side.right
                yaxis.position 0.85
            ])
        ]
    ]
```