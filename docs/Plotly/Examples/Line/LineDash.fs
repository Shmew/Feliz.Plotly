[<RequireQualifiedAccess>]
module Samples.Line.LineDash

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
            ]
            data.scatter [
                scatter.x [ 2; 3; 4; 5 ]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.markersAndLines
            ]
        ]
    ]
