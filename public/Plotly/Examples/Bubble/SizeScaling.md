# Feliz.Plotly - Bubble Charts

Taken from [Plotly - Bubble Charts](https://plot.ly/javascript/bubble-charts/)

```fsharp:plotly-chart-bubble-sizescaling
[<RequireQualifiedAccess>]
module Samples.Bubble.SizeScaling

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
                scatter.text ["A<br>size: 40"; "B<br>size: 60"; "C<br>size: 80"; "D<br>size: 100"]
                scatter.mode.markers
                scatter.marker [
                    marker.size [ 400; 600; 800; 1000 ]
                    marker.sizemode.area
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 14; 15; 16; 17 ]
                scatter.text ["A</br>size: 40</br>sixeref: 0.2"; "B</br>size: 60</br>sixeref: 0.2"; "C</br>size: 80</br>sixeref: 0.2"; "D</br>size: 100</br>sixeref: 0.2"]
                scatter.mode.markers
                scatter.marker [
                    marker.size [ 400; 600; 800; 1000 ]
                    marker.sizeref 2
                    marker.sizemode.area
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 20; 21; 22; 23 ]
                scatter.text ["A</br>size: 40</br>sixeref: 2"; "B</br>size: 60</br>sixeref: 2"; "C</br>size: 80</br>sixeref: 2"; "D</br>size: 100</br>sixeref: 2"]
                scatter.mode.markers
                scatter.marker [
                    marker.size [ 400; 600; 800; 1000 ]
                    marker.sizeref 0.2
                    marker.sizemode.area
                ]
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 26; 27; 28; 29 ]
                scatter.text ["A</br>size: 40</br>sixeref: 1.25"; "B</br>size: 60</br>sixeref: 1.25"; "C</br>size: 80</br>sixeref: 1.25"; "D</br>size: 100</br>sixeref: 1.25"]
                scatter.mode.markers
                scatter.marker [
                    marker.size size
                    marker.sizeref sizeRef
                    marker.sizemode.area
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Bubble Chart Size Scaling"
            ]
            layout.showlegend false
            layout.height 600
            layout.width 600
        ]
    ]
```