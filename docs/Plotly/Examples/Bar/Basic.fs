[<RequireQualifiedAccess>]
module Samples.Bar.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
            ]
        ]
    ]
