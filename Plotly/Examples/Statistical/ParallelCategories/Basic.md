# Feliz.Plotly - Parallel Categories

Taken from [Plotly - Parallel Categories](https://plot.ly/javascript/parallel-categories-diagram/)

```fsharp:plotly-chart-parallelcategories-basic
[<RequireQualifiedAccess>]
module Samples.ParallelCategories.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.parcats [
                parcats.dimensions [
                    dimensions.dimension [
                        dimension.label "Hair"
                        dimension.values ["Black"; "Black"; "Black"; "Brown"; "Brown"; "Brown"; "Red"; "Brown"]
                    ]
                    dimensions.dimension [
                        dimension.label "Eye"
                        dimension.values ["Brown"; "Brown"; "Brown"; "Brown"; "Brown"; "Blue"; "Blue"; "Blue"]
                    ]
                    dimensions.dimension [
                        dimension.label "Sex"
                        dimension.values ["Female"; "Female"; "Female"; "Male"; "Female"; "Male"; "Male"; "Male"]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.width 600
        ]
    ]
```