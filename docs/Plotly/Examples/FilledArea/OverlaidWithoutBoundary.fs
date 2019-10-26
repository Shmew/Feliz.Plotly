[<RequireQualifiedAccess>]
module Samples.FilledArea.OverlaidWithoutBoundary

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 0; 2; 3; 5 ]
                scatter.fill.tozeroy
                scatter.mode.none
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 3; 5; 1; 7 ]
                scatter.fill.tonexty
                scatter.mode.none
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Overlaid Chart Without Boundary Lines"
            ]
        ]
    ]
