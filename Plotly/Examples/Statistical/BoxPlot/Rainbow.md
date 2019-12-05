# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-rainbow
[<RequireQualifiedAccess>]
module Samples.BoxPlot.Rainbow

open Feliz
open Feliz.Plotly
open System

let rng = Random()

let getRandomArbitrary min max =
    rng.NextDouble() * (max - min) + min

let linspace min max n = 
    let bw = (max - min) / (float n - 1.)
    List.init n <| (float >> (fun num -> num * bw) >> ((+) min))

let boxNumber = 30
let boxColors = linspace 0. 360. boxNumber |> List.map (fun col -> color.hsl(col, 50., 50.))

let yData =
    [ 0. .. (boxNumber-1 |> float) ]
    |> List.map (fun i ->
        [ 0. .. 9. ]
        |> List.map (fun _ ->
            let boxDiv = i / (boxNumber |> float)
            let randomNum = getRandomArbitrary 0. 1.
            3.5 * Math.Sin(Math.PI * boxDiv) + boxDiv + (1.5 + 0.5 * Math.Cos(Math.PI * boxDiv)) * randomNum))

let boxPlots =
    yData
    |> List.map2 (fun (colorValue: string) yData' ->
        traces.box [
            box.y yData'
            box.boxpoints.outliers
            box.marker [
                marker.color colorValue
            ]
        ]) boxColors

let chart () =
    Plotly.plot [
        plot.traces boxPlots
        plot.layout [
            layout.xaxis [
                xaxis.showgrid false
                xaxis.zeroline false
                xaxis.tickangle 60
                xaxis.showticklabels true
            ]
            layout.yaxis [
                yaxis.zeroline false
                yaxis.gridcolor color.white
            ]
            layout.paperBgcolor (color.rgb(233, 233, 233))
            layout.plotBgcolor (color.rgb(233, 233, 233))
            layout.showlegend true
            layout.width 1000
        ]
    ]
```