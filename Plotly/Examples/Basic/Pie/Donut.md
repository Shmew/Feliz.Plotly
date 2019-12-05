# Feliz.Plotly - Pie Charts

Taken from [Plotly - Pie Charts](https://plot.ly/javascript/pie-charts/)

```fsharp:plotly-chart-pie-donut
[<RequireQualifiedAccess>]
module Samples.Pie.Donut

open Feliz
open Feliz.Plotly

let labels = ["US"; "China"; "European Union"; "Russian Federation"; "Brazil"; "India"; "Rest of World" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pie [
                pie.values [ 16; 15; 12; 6; 5; 4; 42 ]
                pie.labels labels
                pie.domain [
                    domain.column 0
                ]
                pie.name "GHG Emissions"
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.hole 0.4
            ]
            traces.pie [
                pie.values [ 27; 11; 25; 8; 1; 3; 25 ]
                pie.labels labels
                pie.text "CO2"
                pie.textposition.inside
                pie.domain [
                    domain.column 1
                ]
                pie.name "CO2 Emissions"
                pie.hoverinfo [
                    pie.hoverinfo.name
                    pie.hoverinfo.percent
                    pie.hoverinfo.label
                ]
                pie.hole 0.4
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Global Emissions 1990-2011"
            ]
            layout.annotations [
                annotations.annotation [
                    annotation.font [
                        font.size 20
                    ]
                    annotation.showarrow false
                    annotation.text "GHG"
                    annotation.x 0.17
                    annotation.y 0.5
                ]
                annotations.annotation [
                    annotation.font [
                        font.size 20
                    ]
                    annotation.showarrow false
                    annotation.text "CO2"
                    annotation.x 0.82
                    annotation.y 0.5
                ]
            ]
            layout.height 400
            layout.width 600
            layout.showlegend false
            layout.grid [
                grid.rows 1
                grid.columns 2
            ]
        ]
    ]
```