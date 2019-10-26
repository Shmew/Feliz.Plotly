[<RequireQualifiedAccess>]
module Samples.FilledArea.SelectHover

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0.; 0.5; 1.; 1.5; 2. ]
                scatter.y [ 0; 1; 2; 1; 0 ]
                scatter.fill.toself
                scatter.fillcolor (colors.rgb(171, 99, 250))
                scatter.line [
                    line.color (colors.rgb(171, 99, 250))
                ]
                scatter.text "Points + Fills"
                scatter.hoverinfo.text
            ]
            traces.scatter [
                scatter.x [ 3.; 3.5; 4.; 4.5; 5. ]
                scatter.y [ 0; 1; 2; 1; 0 ]
                scatter.fill.toself
                scatter.fillcolor (colors.rgb(231, 99, 250))
                scatter.line [
                    line.color (colors.rgb(231, 99, 250))
                ]
                scatter.text "Points only"
                scatter.hoverinfo.text
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Hover on <i>Points</i> or <i>Fill</i>"
            ]
        ]
    ]
