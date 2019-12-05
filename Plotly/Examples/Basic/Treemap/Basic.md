# Feliz.Plotly - Treemaps

Taken from [Plotly - Treemaps](https://plot.ly/javascript/treemaps/)

```fsharp:plotly-chart-treemap-basic
[<RequireQualifiedAccess>]
module Samples.Treemap.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels [ "Eve"; "Cain"; "Seth"; "Enos"; "Noam"; "Abel"; "Awan"; "Enoch"; "Azura" ]
                treemap.parents [ ""; "Eve"; "Eve"; "Seth"; "Seth"; "Eve"; "Eve"; "Awan"; "Eve" ]
            ]
        ]
    ]
```