# Feliz.Plotly - Aggregations

Taken from [Plotly - Aggregations](https://plot.ly/javascript/aggregations/)

```fsharp:plotly-chart-transforms-aggregations
[<RequireQualifiedAccess>]
module Samples.Transforms.Aggregations

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
                    transforms.aggregate [
                        aggregate.groups subjects
                        aggregate.aggregations [
                            aggregations.aggregation [
                                aggregation.target.y
                                aggregation.func.avg
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
```