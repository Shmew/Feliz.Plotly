# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-styled
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Styled

open Feliz
open Feliz.Plotly
open System

let names =
    [ "Carmelo<br>Anthony"; "Dwyane<br>Wade";"Deron<br>Williams"; "Brook<br>Lopez";
      "Damian<br>Lillard"; "David<br>West"; "Blake<br>Griffin"; "David<br>Lee";
      "Demar<br>Derozan" ]

let rng = Random()

let getRandom num mul =
    [ 0 .. num ]
    |> List.map (fun _ -> rng.NextDouble() * mul)

let yData =
    [ getRandom 30 10.
      getRandom 30 20.
      getRandom 30 25.
      getRandom 30 40.
      getRandom 30 45.
      getRandom 30 30.
      getRandom 30 20.
      getRandom 30 15.
      getRandom 30 43. ]

let colorValues =
    [ color.rgba(93, 164, 214, 0.5); color.rgba(255, 144, 14, 0.5)
      color.rgba(44, 160, 101, 0.5); color.rgba(255, 65, 54, 0.5)
      color.rgba(207, 114, 255, 0.5); color.rgba(127, 96, 0, 0.5)
      color.rgba(255, 140, 184, 0.5); color.rgba(79, 90, 117, 0.5)
      color.rgba(222, 223, 0, 0.5) ]

let boxPlots =
    yData
    |> List.map3 (fun name colorValue yData' ->
        traces.box [
            box.y yData'
            box.name name
            box.boxpoints.all
            box.jitter 0.5
            box.whiskerwidth 0.2
            box.fillcolor colorValue
            box.marker [
                marker.size 2
            ]
            box.line [
                line.width 1
            ]
        ]
    ) names colorValues

let chart () =
    Plotly.plot [
        plot.traces boxPlots
        plot.layout [
            layout.title [
                title.text "Points Scored by the Top 9 Scoring NBA Players in 2012"
            ]
            layout.yaxis [
                yaxis.autorange.true'
                yaxis.showgrid true
                yaxis.zeroline true
                yaxis.dtick 5
                yaxis.gridcolor (color.rgb(255, 255, 255))
                yaxis.gridwidth 1
                yaxis.zerolinecolor (color.rgb(255, 255, 255))
                yaxis.zerolinewidth 2
            ]
            layout.margin [
                margin.l 40
                margin.r 30
                margin.b 80
                margin.t 100
            ]
            layout.paperBgcolor (color.rgb(243, 243, 243))
            layout.plotBgcolor (color.rgb(243, 243, 243))
            layout.showlegend false
        ]
    ]
```