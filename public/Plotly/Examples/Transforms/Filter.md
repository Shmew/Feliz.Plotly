# Feliz.Plotly - Filter

Taken from [Plotly - Filter](https://plot.ly/javascript/filter/)

```fsharp:plotly-chart-transforms-filter
[<RequireQualifiedAccess>]
module Samples.Transforms.Filter

open Feliz
open Feliz.Plotly

let subjects =
    [ "Moe"; "Larry"; "Curly"; "Moe"
      "Larry"; "Curly"; "Moe"; "Larry"
      "Curly"; "Moe"; "Larry"; "Curly" ]

let scores =
    [ 1; 6; 2; 8; 2; 9; 4; 5; 1; 5; 2; 8 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x subjects
                scatter.y scores
                scatter.mode.markers
                scatter.transforms [
                    transforms.filter [
                        filter.target.y
                        filter.operation.gt
                        filter.value 4
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title "Filter Scores > 4"
        ]
    ]
```