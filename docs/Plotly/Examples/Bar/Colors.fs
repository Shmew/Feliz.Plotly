[<RequireQualifiedAccess>]
module Samples.Bar.Colors

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "Feature A"; "Feature B"; "Feature C"; "Feature D"; "Feature E" ]
                bar.y [ 20; 14; 23; 25; 22 ]
                bar.marker [
                    bar.marker.color [ 
                        colors.rgba(204,204,204,1.)
                        colors.rgba(222, 45, 38, 0.8)
                        colors.rgba(204, 204, 204, 1)
                        colors.rgba(204, 204, 204, 1.)
                        colors.rgba(204, 204, 204, 1.) 
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Least Used Feature"
            ]
        ]
    ]