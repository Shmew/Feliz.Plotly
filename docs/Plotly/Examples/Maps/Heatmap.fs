[<RequireQualifiedAccess>]
module Samples.Maps.Heatmap

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.densitymapbox [
                densitymapbox.lon [ 10; 20; 30 ]
                densitymapbox.lat [ 15; 25; 35 ]
                densitymapbox.z [ 1; 3; 2 ]
            ]
        ]
        plot.layout [
            layout.width 600
            layout.height 400
            layout.mapbox [
                mapbox.style "stamen-terrain"
            ]
        ]
    ]
