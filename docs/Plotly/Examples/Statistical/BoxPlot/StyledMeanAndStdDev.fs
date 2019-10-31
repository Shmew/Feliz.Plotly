[<RequireQualifiedAccess>]
module Samples.BoxPlot.StyledMeanAndStdDev

open Feliz
open Feliz.Plotly

let yData = [ 2.37; 2.16; 4.82; 1.73; 1.04; 0.23; 1.32; 2.91; 0.11; 4.51; 0.51; 3.75; 1.35; 2.98; 4.50; 0.18; 4.66; 1.30; 2.06; 1.19 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y yData
                box.name "Only Mean"
                box.marker [
                    marker.color (colors.rgb(8, 81, 156))
                ]
                box.boxmean.true'
            ]
            traces.box [
                box.y yData
                box.name "Mean and Standard Deviation"
                box.marker [
                    marker.color (colors.rgb(10, 140, 208))
                ]
                box.boxmean.sd
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Box Plot Styling Mean and Standard Deviation"
            ]
        ]
    ]
