[<RequireQualifiedAccess>]
module Samples.Scatter.ColorDimension

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.y (5 |> List.replicate 40)
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.size 40
                    scatter.marker.color ([0..39] |> List.map string) // TODO: Accept ints and floats for color field?
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Scatter Plot with a Color Dimension"
            ]
        ]
    ]
