[<RequireQualifiedAccess>]
module Samples.Bar.Base

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "2016"; "2017"; "2018" ]
                bar.y [ 500; 600; 700 ]
                bar.base' [ -500; -600; -700 ]
                bar.marker [
                    bar.marker.color colors.red
                ]
                bar.name "expenses"
            ]
            data.bar [
                bar.x [ "2016"; "2017"; "2018" ]
                bar.y [ 300; 400; 700 ]
                bar.base' 0
                bar.marker [
                    bar.marker.color colors.blue
                ]
                bar.name "revenue"
            ]
        ]
    ]