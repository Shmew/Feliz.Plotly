[<RequireQualifiedAccess>]
module Samples.MultipleAxes.MultipleYAxes

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1; 2; 3 ]
                scatter.y [ 4; 5; 6 ]
                scatter.name "yaxis data"
            ]
            traces.scatter [
                scatter.x [ 2; 3; 4 ]
                scatter.y [ 40; 50; 60 ]
                scatter.name "yaxis2 data"
                scatter.yaxis "y2"
            ]
            traces.scatter [
                scatter.x [ 4; 5; 6 ]
                scatter.y [ 40000; 50000; 60000 ]
                scatter.name "yaxis3 data"
                scatter.yaxis "y3"
            ]
            traces.scatter [
                scatter.x [ 5; 6; 7 ]
                scatter.y [ 400000; 500000; 600000 ]
                scatter.name "yaxis4 data"
                scatter.yaxis "y4"
            ]
        ]
        plot.layout [
            layout.width 800
            layout.title [
                title.text "multiple y-axes example"
            ]
            layout.xaxis [
                xaxis.domain [ 0.3; 0.7 ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "yaxis title"
                    title.font [
                        font.color "#1f77b4"
                    ]
                ]
                yaxis.tickfont [
                    tickfont.color "#1f77b4"
                ]
            ]
            layout.yaxis2 [
                yaxis2.title [
                    title.text "yaxis2 title"
                    title.font [
                        font.color "#ff7f0e"
                    ]
                ]
                yaxis2.tickfont [
                    tickfont.color "#ff7f0e"
                ]
                yaxis2.anchor.free
                yaxis2.overlaying.custom "y"
                yaxis2.side.left
                yaxis2.position 0.15
            ]
            layout.yaxis3 [
                yaxis3.title [
                    title.text "yaxis3 title"
                    title.font [
                        font.color "#d62728"
                    ]
                ]
                yaxis3.tickfont [
                    tickfont.color "#d62728"
                ]
                yaxis3.anchor.custom "x"
                yaxis3.overlaying.custom "y"
                yaxis3.side.right
            ]
            layout.yaxis4 [
                yaxis4.title [
                    title.text "yaxis4 title"
                    title.font [
                        font.color "#9467bd"
                    ]
                ]
                yaxis4.tickfont [
                    tickfont.color "#9467bd"
                ]
                yaxis4.anchor.free
                yaxis4.overlaying.custom "y"
                yaxis4.side.right
                yaxis4.position 0.85
            ]
        ]
    ]
