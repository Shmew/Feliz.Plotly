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

let pieColors =
    [ [ colors.rgb(56, 75, 126); colors.rgb(18, 36, 37); colors.rgb(34, 53, 101); colors.rgb(36, 55, 57); colors.rgb(6, 4, 4) ]
      [ colors.rgb(177, 127, 38); colors.rgb(205, 152, 36); colors.rgb(99, 79, 37); colors.rgb(129, 180, 179); colors.rgb(124, 103, 37) ]
      [ colors.rgb(33, 75, 99); colors.rgb(79, 129, 102); colors.rgb(151, 179, 100); colors.rgb(175, 49, 35); colors.rgb(36, 73, 147) ]
      [ colors.rgb(146, 123, 21); colors.rgb(177, 180, 34); colors.rgb(206, 206, 40); colors.rgb(175, 51, 21); colors.rgb(35, 36, 21) ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pie [
                pie.values values.[0]
                pie.labels labels
                pie.name "Starry Night"
                pie.marker [
                    marker.colors pieColors.[0]
                ]
                pie.domain [
                    domain.row 0
                    domain.column 0
                ]
                pie.hoverinfo.nameAndPercentLabel
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[1]
                pie.labels labels
                pie.name "Sunflowers"
                pie.marker [
                    marker.colors pieColors.[1]
                ]
                pie.domain [
                    domain.row 1
                    domain.column 0
                ]
                pie.hoverinfo.nameAndPercentLabel
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[2]
                pie.labels labels
                pie.name "Irises"
                pie.marker [
                    marker.colors pieColors.[2]
                ]
                pie.domain [
                    domain.row 0
                    domain.column 1
                ]
                pie.hoverinfo.nameAndPercentLabel
                pie.textinfo.none
            ]
            traces.pie [
                pie.values values.[3]
                pie.labels labels
                pie.name "The Night Cafe"
                pie.marker [
                    marker.colors pieColors.[3]
                ]
                pie.domain [
                    domain.x [ 0.52; 1. ]
                    domain.y [ 0.; 0.48 ]
                ]
                pie.hoverinfo.nameAndPercentLabel
                pie.textinfo.none
            ]
        ]
        plot.layout [
            layout.height 400
            layout.width 500
            layout.grid [
                grid.rows 2
                grid.columns 2
            ]
        ]
    ]
```