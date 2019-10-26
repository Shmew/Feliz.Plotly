[<RequireQualifiedAccess>]
module Samples.Line.NamedLineAndScatter

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
                scatter.name "Scatter"
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4; 5]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
                scatter.name "Lines"
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.markersAndLines
                scatter.name "Scatter + Lines"
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Adding Names to Line and Scatter Plot"
            ]
        ]
    ]
