[<RequireQualifiedAccess>]
module Samples.Scatter.DataLabelsOnPlot

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 1; 2; 3; 4; 5 ]
                scatter.y [ 1; 6; 3; 6; 1 ]
                scatter.mode.textAndMarkers
                scatter.name "Team A"
                scatter.text [ "A-1"; "A-2"; "A-3"; "A-4"; "A-5"]
                scatter.textposition.topCenter
                scatter.textfont [
                    scatter.textfont.family "Raleway, sans-serif"
                ]
                scatter.marker [
                    scatter.marker.size 12
                ]
            ]
            data.scatter [
                scatter.x [ 1.5; 2.5; 3.5; 4.5; 5.5 ]
                scatter.y [ 4; 1; 7; 1; 4 ]
                scatter.mode.textAndMarkers
                scatter.name "Team B"
                scatter.text ["B-a" ; "B-b" ; "B-c" ; "B-d" ; "B-e" ]
                scatter.textposition.bottomCenter
                scatter.textfont [
                    scatter.textfont.family "Times New Roman"
                ]
                scatter.marker [
                    scatter.marker.size 12
                ]
            ]
        ]
        plot.layout [
            layout.xaxis [
                layout.xaxis.range [ 0.75; 5.25 ]
            ]
            layout.yaxis [
                layout.yaxis.range [ 0; 8 ]
            ]
            layout.title [
                layout.title.text "Data Labels on the Plot"
            ]
        ]
    ]
