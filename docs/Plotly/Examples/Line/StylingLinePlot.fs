[<RequireQualifiedAccess>]
module Samples.Line.StylingLinePlot

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.lines
                scatter.name "Red"
                scatter.line [
                    scatter.line.color (colors.rgb(219, 64, 82))
                    scatter.line.width 3
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.lines
                scatter.name "Blue"
                scatter.line [
                    scatter.line.color (colors.rgb(55, 128, 191))
                    scatter.line.width 1
                ]
            ]
        ]
        plot.layout [
            layout.width 500
            layout.height 500
        ]
    ]
