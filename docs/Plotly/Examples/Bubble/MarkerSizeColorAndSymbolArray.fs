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
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 11; 12; 13 ]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.color [ 
                        colors.hsl(0., 100., 40.)
                        colors.hsl(33., 100., 40.)
                        colors.hsl(66., 100., 40.)
                        colors.hsl(99., 100., 40.) 
                    ]
                    scatter.marker.size [ 12; 22; 32; 42 ]
                    scatter.marker.opacity [ 0.6; 0.7; 0.8; 0.9 ]
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 11; 12; 13; 14 ]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.color (colors.rgb(31,119,180))
                    scatter.marker.size 18
                    scatter.marker.symbols [
                        scatter.marker.symbol.circle
                        scatter.marker.symbol.square
                        scatter.marker.symbol.diamond
                        scatter.marker.symbol.cross
                    ]
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 13; 14; 15 ]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.size 18
                    scatter.marker.line [
                        marker.line.color [
                            colors.rgb(120, 120, 120)
                            colors.rgb(120, 120, 120)
                            colors.red
                            colors.rgb(120, 120, 120)
                        ]
                        marker.line.width [2; 2; 6; 2]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.showlegend false
        ]
    ]
