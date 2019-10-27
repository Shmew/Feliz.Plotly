﻿[<RequireQualifiedAccess>]
module Samples.Table.FromCSV

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
            ]
        ]
    ]