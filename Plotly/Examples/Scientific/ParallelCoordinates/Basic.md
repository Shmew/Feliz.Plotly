# Feliz.Plotly - Parallel Coordinate Plots

Taken from [Plotly - Parallel Coordinate Plots](https://plot.ly/javascript/parallel-coordinates-plot/)

```fsharp:plotly-chart-parallelcoordinates-basic
[<RequireQualifiedAccess>]
module Samples.ParallelCoordinates.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.parcoords [
                parcoords.line [
                    line.color color.blue
                ]
                parcoords.dimensions [
                    dimensions.dimension [
                        dimension.range [ 1; 5 ]
                        dimension.constraintrange [ 1; 2 ]
                        dimension.label "A"
                        dimension.values [ 1; 4 ]
                    ]
                    dimensions.dimension [
                        dimension.range [ 1; 5 ]
                        dimension.label "B"
                        dimension.values [ 3; 1; 5 ]
                        dimension.tickvals [ 1.5; 3.; 4.5 ]
                    ]
                    dimensions.dimension [
                        dimension.range [ 1; 5 ]
                        dimension.label "C"
                        dimension.values [ 2; 4 ]
                        dimension.tickvals [ 1 .. 4 ]
                        dimension.ticktext [ "text 1"; "text 2"; "text 3"; "text 4"; "text 5" ]
                    ]
                    dimensions.dimension [
                        dimension.range [ 1; 5 ]
                        dimension.label "D"
                        dimension.values [ 4; 2 ]
                    ]
                ]
            ]
        ]
    ]
```