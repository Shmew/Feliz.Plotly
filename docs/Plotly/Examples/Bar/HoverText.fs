[<RequireQualifiedAccess>]
module Samples.Bar.HoverText

open Feliz
open Feliz.Plotly

module title = Plotly.layout.title

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x [ "Liam"; "Sophie"; "Jacob"; "Mia"; "William"; "Olivia" ]
                bar.y [ 8.0; 8.0; 12.0; 12.0; 13.0; 20.0 ]
                bar.text [ "4.17 below the mean"; "4.17 below the mean"; "0.17 below the mean"; "0.17 below the mean"; "0.83 above the mean"; "7.83 above the mean" ]
                bar.marker [
                    bar.marker.color (colors.rgb(142, 124, 195))
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Number of Graphs Made this Week"
                layout.title.font [
                    title.font.family "Raleway, sans-serif"
                ]
            ]
            layout.showlegend false
            layout.xaxis [
                layout.xaxis.tickangle -45
            ]
            layout.yaxis [
                layout.yaxis.zeroline false
                layout.yaxis.gridwidth 2
            ]
            layout.bar [
                layout.bar.bargap 0.05
            ]
        ]
    ]
