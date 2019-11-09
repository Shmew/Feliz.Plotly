[<RequireQualifiedAccess>]
module Samples.Log.LogarithmicAxes

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0 .. 10 ]
                scatter.y ([ 0 .. 10 ] |> List.rev)
            ]
            traces.scatter [
                scatter.x [ 0 .. 10 ]
                scatter.y [ 0 .. 10 ]
            ]
        ]
        plot.layout [
            layout.xaxis [
                xaxis.type'.log
                xaxis.autorange.true'
            ]
            layout.yaxis [
                yaxis.type'.log
                yaxis.autorange.true'
            ]
        ]
    ]
