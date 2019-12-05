# Feliz.Plotly - Pie Charts

Taken from [Plotly - Pie Charts](https://plot.ly/javascript/pie-charts/)

```fsharp:plotly-chart-pie-subplots
[<RequireQualifiedAccess>]
module Samples.Pie.Subplots

open Feliz
open Feliz.Plotly

let labels = [ "1st"; "2nd"; "3rd"; "4th"; "5th" ]

let values =
    [ [ 38; 27; 18; 10; 7 ]
      [ 28; 26; 21; 15; 10 ]
      [ 38; 19; 16; 14; 13 ]
      [ 31; 24; 19; 18; 8 ] ]

let piecolor =
    [ [ color.rgb(56, 75, 126); color.rgb(18, 36, 37); color.rgb(34, 53, 101); color.rgb(36, 55, 57); color.rgb(6, 4, 4) ]
      [ color.rgb(177, 127, 38); color.rgb(205, 152, 36); color.rgb(99, 79, 37); color.rgb(129, 180, 179); color.rgb(124, 103, 37) ]
      [ color.rgb(33, 75, 99); color.rgb(79, 129, 102); color.rgb(151, 179, 100); color.rgb(175, 49, 35); color.rgb(36, 73, 147) ]
      [ color.rgb(146, 123, 21); color.rgb(177, 180, 34); color.rgb(206, 206, 40); color.rgb(175, 51, 21); color.rgb(35, 36, 21) ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pie [
                pie.values values.[0]
                pie.labels labels
                pie.name "Starry Night"
                pie.marker [
                    marker.colors piecolor.[0]
                ]
                pie.domain [
                    domain.row 0
                    domain.column 0
                ]
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[1]
                pie.labels labels
                pie.name "Sunflowers"
                pie.marker [
                    marker.colors piecolor.[1]
                ]
                pie.domain [
                    domain.row 1
                    domain.column 0
                ]
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[2]
                pie.labels labels
                pie.name "Irises"
                pie.marker [
                    marker.colors piecolor.[2]
                ]
                pie.domain [
                    domain.row 0
                    domain.column 1
                ]
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[3]
                pie.labels labels
                pie.name "The Night Cafe"
                pie.marker [
                    marker.colors piecolor.[3]
                ]
                pie.domain [
                    domain.row 1
                    domain.column 1
                ]
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.textinfo.none
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.height 400
            layout.width 500
            layout.grid [
                grid.rows 2
                grid.columns 2
            ]
        ]
    ]
```