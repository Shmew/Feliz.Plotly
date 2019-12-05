# Feliz.Plotly - Multiple Axes

Taken from [Plotly - Multiple Axes](https://plot.ly/javascript/multiple-axes/)

```fsharp:plotly-chart-multipleaxes-twoyaxes
[<RequireQualifiedAccess>]
module Samples.MultipleAxes.TwoYAxes

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 40; 50; 60 ]
                scatter.name "yaxis data"
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4 ]
                scatter.y [ 4; 5; 6 ]
                scatter.name "yaxis2 data"
                scatter.yaxis 2
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Double Y Axis Example"
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "yaxis title"
                ]
            ]
            layout.yaxis (2, [
                yaxis.title [
                    title.text "yaxis2 title"
                    title.font [
                        font.color (color.rgb(148, 103, 189))
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color (color.rgb(148, 103, 189))
                ]
                yaxis.overlaying.y 1
                yaxis.side.right
            ])
        ]
    ]
```