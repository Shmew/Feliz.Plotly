# Feliz.Plotly - Sankey Diagrams

Taken from [Plotly - Sankey Diagrams](https://plot.ly/javascript/sankey-diagram/)

```fsharp:plotly-chart-sankey-basic
[<RequireQualifiedAccess>]
module Samples.Sankey.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.sankey [
                sankey.orientation.h
                sankey.node [
                    node.pad 15
                    node.thickness 30
                    node.line [
                        line.color color.black
                        line.width 0.5
                    ]
                    node.label [ "A1"; "A2"; "B1"; "B2"; "C1"; "C2" ]
                    node.color color.blue
                ]
                sankey.link [
                    link.source [ 0; 1; 0; 2; 3; 3 ]
                    link.target [ 2; 3; 3; 4; 4; 5 ]
                    link.value [ 8; 4; 2; 8; 4; 2 ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Basic Sankey"
            ]
            layout.font [
                font.size 10
            ]
        ]
    ]
```