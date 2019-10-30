# Feliz.Plotly - Treemaps

Taken from [Plotly - Treemaps](https://plot.ly/javascript/treemaps/)

```fsharp:plotly-chart-treemap-differentattributes
[<RequireQualifiedAccess>]
module Samples.Treemap.DifferentAttributes

open Feliz
open Feliz.Plotly

let labels = [ "Eve"; "Cain"; "Seth"; "Enos"; "Noam"; "Abel"; "Awan"; "Enoch"; "Azura" ]
let parents = [ ""; "Eve"; "Eve"; "Seth"; "Seth"; "Eve"; "Eve"; "Awan"; "Eve" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
                treemap.values [ 10; 14; 12; 10; 2; 6; 6; 1; 4 ]
                treemap.textinfo [
                    treemap.textinfo.label
                    treemap.textinfo.value
                    treemap.textinfo.percentParent
                    treemap.textinfo.percentEntry
                ]
                treemap.domain [
                    domain.row 1
                    domain.column 0
                ]
                treemap.outsidetextfont [
                    outsidetextfont.size 20
                    outsidetextfont.color "#377eb8"
                ]
                treemap.marker [
                    marker.line [
                        line.width 2
                    ]
                ]
                treemap.pathbar [
                    pathbar.visible false
                ]
            ]
            traces.treemap [
                treemap.branchvalues.total
                treemap.labels labels
                treemap.parents parents
                treemap.values [ 65; 14; 12; 10; 2; 6; 6; 1; 4 ]
                treemap.textinfo [
                    treemap.textinfo.label
                    treemap.textinfo.value
                    treemap.textinfo.percentParent
                    treemap.textinfo.percentEntry
                ]
                treemap.domain [
                    domain.row 1
                    domain.column 1
                ]
                treemap.outsidetextfont [
                    outsidetextfont.size 20
                    outsidetextfont.color "#377eb8"
                ]
                treemap.marker [
                    marker.line [
                        line.width 2
                    ]
                ]
                treemap.pathbar [
                    pathbar.visible false
                ]
            ]
        ]
        plot.layout [
            layout.width 1000
            layout.grid [
                grid.columns 2
                grid.rows 1
            ]
            layout.annotations [
                annotations.annotation [
                    annotation.showarrow false
                    annotation.text "branchvalues: <b>remainder</b>"
                    annotation.x 0.25
                    annotation.xanchor.center
                    annotation.y 1.1
                    annotation.yanchor.bottom
                ]
                annotations.annotation [
                    annotation.showarrow false
                    annotation.text "branchvalues: <b>total</b>"
                    annotation.x 0.75
                    annotation.xanchor.center
                    annotation.y 1.1
                    annotation.yanchor.bottom
                ]
            ]
        ]
    ]
```