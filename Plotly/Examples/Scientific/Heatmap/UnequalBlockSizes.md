# Feliz.Plotly - Heatmap Plots

Taken from [Plotly - Heatmap Plots](https://plot.ly/javascript/heatmaps/)

```fsharp:plotly-chart-heatmap-unequalblocksizes
[<RequireQualifiedAccess>]
module Samples.Heatmap.UnequalBlockSizes

open Feliz
open Feliz.Plotly
open System

let linspace min max n = 
    let bw = (max - min) / (float n - 1.)
    List.init n <| (float >> (fun num -> num * bw) >> ((+) min))

let xRaw, yRaw =
    linspace ((-Math.PI) / 13.) (4. * Math.PI) 1000
    |> List.map (fun i ->
        let r = 1.120529 * Math.Exp(-0.306349 * i)
        (r * Math.Cos i), (r * Math.Sin i))
    |> List.unzip

let yShift = (1.1 - (List.max yRaw) - (List.min yRaw)) / 2.

let xData, yData =
    (xRaw |> List.map (fun x -> (-x) + xRaw.Head)),
    (yRaw |> List.map (fun y -> y - yRaw.Head + yShift))

let xHeat, yHeat =
    let phi = (1. + Math.Sqrt(5.)) / 2.
    let phiPow n =  1. / Math.Pow(phi, n)    

    [ 0.; 1.; 1. + phiPow 4.; 1. + phiPow 3.; phi ],
    [ 0.; phiPow 3.; (phiPow 3. + phiPow 4.); phiPow 2.; 1. ]
    |> List.map (fun y -> y + yShift)

let zHeat =
    [ [ 13; 3; 3; 5 ]
      [ 13; 2; 1; 5 ]
      [ 13; 10; 11; 12 ]
      [ 13; 8; 8; 8 ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xData
                scatter.y yData
                scatter.line [
                    line.color color.white
                    line.width 3
                ]
            ]
            traces.heatmap [
                heatmap.x xHeat
                heatmap.y yHeat
                heatmap.z zHeat
                heatmap.colorscale color.colorscale.viridis
                heatmap.colorbar [
                    colorbar.nticks 3
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Heatmap with Unequal Block Sizes"
            ]
            layout.margin [
                margin.t 200
                margin.r 200
                margin.b 200
                margin.l 200
            ]
            layout.xaxis [
                xaxis.range [ 0.; 1.6 ]
                xaxis.autorange.false'
                xaxis.showgrid false
                xaxis.showline false
                xaxis.zeroline false
                xaxis.showticklabels false
                xaxis.ticks.none
            ]
            layout.yaxis [
                yaxis.range [ 0.; 1.6 ]
                yaxis.autorange.false'
                yaxis.showgrid false
                yaxis.showline false
                yaxis.zeroline false
                yaxis.showticklabels false
                yaxis.ticks.none
            ]
            layout.showlegend false
            layout.width 700
            layout.height 700
            layout.autosize false
        ]
    ]
```