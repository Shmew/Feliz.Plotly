[<RequireQualifiedAccess>]
module Samples.HorizontalBar.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ 20; 14; 23 ]
                bar.y [ "giraffes"; "orangutans"; "monkeys" ]
                bar.orientation.h
            ]
        ]
    ]
