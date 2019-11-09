[<RequireQualifiedAccess>]
module Samples.Heatmap.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.heatmap [
                heatmap.z [ 
                    [ 1; 20; 30 ]
                    [ 20; 1; 60 ]
                    [ 30; 60; 1 ]
                ]
            ]
        ]
    ]
