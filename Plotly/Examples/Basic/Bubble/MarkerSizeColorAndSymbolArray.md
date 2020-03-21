# Feliz.Plotly - Bubble Charts

Taken from [Plotly - Bubble Charts](https://plot.ly/javascript/bubble-charts/)

```fsharp:plotly-chart-bubble-markersizecolorandsymbolarray
[<RequireQualifiedAccess>]
module Samples.Bubble.MarkerSizeColorAndSymbolArray

open Feliz
open Feliz.Plotly
open System

let desiredMaximumMarkerSize = 40.
let size = [ 400.; 600.; 800.; 1000. ]
let sizeRef = 
    size 
    |> List.max
    |> fun x -> x * 2.0
    |> fun res ->  res / Math.Pow(desiredMaximumMarkerSize, 2.0)

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 11; 12; 13 ]
                scatter.mode.markers
                scatter.marker [
                    marker.color [ 
                        color.hsl(0., 100., 40.)
                        color.hsl(33., 100., 40.)
                        color.hsl(66., 100., 40.)
                        color.hsl(99., 100., 40.) 
                    ]
                    marker.size [ 12; 22; 32; 42 ]
                    marker.opacity [ 0.6; 0.7; 0.8; 0.9 ]
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 11; 12; 13; 14 ]
                scatter.mode.markers
                scatter.marker [
                    marker.color (color.rgb(31,119,180))
                    marker.size 18
                    marker.symbol [
                        marker.symbol.circle
                        marker.symbol.square
                        marker.symbol.diamond
                        marker.symbol.cross
                    ]
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 13; 14; 15 ]
                scatter.mode.markers
                scatter.marker [
                    marker.size 18
                    marker.line [
                        line.color [
                            color.rgb(120, 120, 120)
                            color.rgb(120, 120, 120)
                            color.red
                            color.rgb(120, 120, 120)
                        ]
                        line.width [2; 2; 6; 2]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.showlegend false
        ]
    ]
```