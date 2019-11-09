# Feliz.Plotly - 2D Density Plots

Taken from [Plotly - 2D Density Plots](https://plot.ly/javascript/2d-density-plots/)

```fsharp:plotly-chart-twodimensionaldensity-withhistogramsubplots
[<RequireQualifiedAccess>]
module Samples.TwoDimensionalDensity.WithHistogramSubplots

open Feliz
open Feliz.Plotly
open System

let rng = Random()

let normal () =
    let x = rng.NextDouble() * 2. - 1.
    let y = rng.NextDouble() * 2. - 1.
    let rec boxMullerTransform rds =
        if rds = 0. || rds > 1. then x * rds
        else 
            Math.Sqrt(-2. * Math.Log(rds) / rds)
            |> boxMullerTransform

    x * x + y * y
    |> boxMullerTransform

let xData, yData =
    let step i = -1. + 2.2 / 1999. * i

    [ 0. .. 1999. ]
    |> List.map 
        (step >>
         fun step ->
            Math.Pow(step, 3.) + (0.3 * normal()),
            Math.Pow(step, 6.) + (0.3 * normal()))
    |> List.unzip

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xData
                scatter.y yData
                scatter.mode.markers
                scatter.name "points"
                scatter.marker [
                    marker.color (color.rgb(102, 0, 0))
                    marker.size 2
                    marker.opacity 0.4
                ]
            ]
            traces.histogram2dcontour [
                histogram2dcontour.x xData
                histogram2dcontour.y yData
                histogram2dcontour.name "density"
                histogram2dcontour.ncontours 20
                histogram2dcontour.colorscale color.colorscale.hot
                histogram2dcontour.reversescale true
                histogram2dcontour.showscale false
            ]
            traces.histogram [
                histogram.x xData
                histogram.name "x density"
                histogram.marker [
                    marker.color (color.rgb(102, 0, 0))
                ]
                histogram.yaxis 2
            ]
            traces.histogram [
                histogram.y yData
                histogram.name "y density"
                histogram.marker [
                    marker.color (color.rgb(102, 0, 0))
                ]
                histogram.xaxis 2
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.autosize false
            layout.width 600
            layout.height 550
            layout.margin [
                margin.t 50
            ]
            layout.hovermode.closest
            layout.bargap 0
            layout.xaxis [
                xaxis.domain [ 0.; 0.85 ]
                xaxis.anchor.y 1
                xaxis.showgrid false
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.anchor.x 1
                yaxis.domain [ 0.; 0.85 ]
                yaxis.showgrid false
                yaxis.zeroline false
            ]
            layout.xaxis (2, [
                xaxis.anchor.y 2
                xaxis.domain [ 0.85; 1. ]
                xaxis.showgrid false
                xaxis.zeroline false
            ])
            layout.yaxis (2, [
                yaxis.anchor.x 2
                yaxis.domain [ 0.85; 1. ]
                yaxis.showgrid false
                yaxis.zeroline false
            ])
        ]
    ]
```