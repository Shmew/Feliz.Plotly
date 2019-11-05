# Feliz.Plotly - Sunburst Charts

Taken from [Plotly - Sunburst Charts](https://plot.ly/javascript/sunburst-charts/)

```fsharp:plotly-chart-sunburst-branchvalues
[<RequireQualifiedAccess>]
module Samples.Sunburst.Branchvalues

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.sunburst [
                sunburst.labels [ "Eve"; "Cain"; "Seth"; "Enos"; "Noam"; "Abel"; "Awan"; "Enoch"; "Azura" ]
                sunburst.parents [ ""; "Eve"; "Eve"; "Seth"; "Seth"; "Eve"; "Eve"; "Awan"; "Eve" ]
                sunburst.values [ 65; 14; 12; 10; 2; 6; 6; 4; 4 ]
                sunburst.outsidetextfont [
                    outsidetextfont.size 20
                    outsidetextfont.color (color.rgb(55, 126, 184))
                ]
                sunburst.leaf [
                    leaf.opacity 0.4
                ]
                sunburst.marker [
                    marker.line [
                        line.width 2
                    ]
                ]
                sunburst.branchvalues.total
            ]
        ]
        plot.layout [
            layout.margin [
                margin.l 0
                margin.r 0
                margin.b 0
                margin.t 0
            ]
        ]
    ]
```