# Feliz.Plotly - Groupby

Taken from [Plotly - Groupby](https://plot.ly/javascript/group-by/)

```fsharp:plotly-chart-transforms-groupby
[<RequireQualifiedAccess>]
module Samples.Transforms.Groupby

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
                    transforms.groupby [
                        groupby.groups subjects
                        groupby.styles [
                            styles.style [
                                style.target "Moe"
                                style.value [
                                    scatter.marker [
                                        marker.color color.blue
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Larry"
                                style.value [
                                    scatter.marker [
                                        marker.color color.red
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Curly"
                                style.value [
                                    scatter.marker [
                                        marker.color color.black
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
```