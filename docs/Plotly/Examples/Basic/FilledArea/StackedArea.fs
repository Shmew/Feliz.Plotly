[<RequireQualifiedAccess>]
module Samples.FilledArea.StackedArea

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 2; 1; 4 ]
                scatter.stackgroup "one"
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 1; 1; 2 ]
                scatter.stackgroup "one"
            ]
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 3; 0; 2 ]
                scatter.stackgroup "one"
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Stacked and Filled Line Chart"
            ]
        ]
    ]
