[<RequireQualifiedAccess>]
module Samples.Line.LineAndScatterStyling

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 10; 15; 13; 17 ]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.color (colors.rgb(219, 64, 82))
                    scatter.marker.size 12
                ]
            ]
            data.scatter [
                scatter.x [ 2; 3; 4; 5 ]
                scatter.y [ 16; 5; 11; 9 ]
                scatter.mode.lines
                scatter.line [
                    scatter.line.color (colors.rgb(55, 128, 191))
                    scatter.line.width 3
                ]
            ]
            data.scatter [
                scatter.x [ 1; 2; 3; 4 ]
                scatter.y [ 12; 9; 15; 12 ]
                scatter.mode.markersAndLines
                scatter.marker [
                    scatter.marker.color (colors.rgb(128, 0, 128))
                    scatter.marker.size 8
                ]
                scatter.line [
                    scatter.line.color (colors.rgb(128, 0, 128))
                    scatter.line.width 1
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Line and Scatter Styling"
            ]
        ]
    ]
