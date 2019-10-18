[<RequireQualifiedAccess>]
module Samples.Dot.Basic

open Feliz
open Feliz.Plotly

let country = 
    [ "Switzerland (2011)"
      "Chile (2013)"
      "Japan (2014)"
      "United States (2012)"
      "Slovenia (2014)"
      "Canada (2011)"
      "Poland (2010)"
      "Estonia (2015)"
      "Luxembourg (2013)"
      "Portugal (2011)" ]

let votingPop = [40.; 45.7; 52.; 53.6; 54.1; 54.2; 54.5; 54.7; 55.1; 56.6]

let regVoters = [49.1; 42.; 52.7; 84.3; 51.7; 61.1; 55.3; 64.2; 91.1; 58.9]

// How to get around having to use this?
module xaxis = Plotly.layout.xaxis
module title = xaxis.title
module legend = Plotly.layout.legend

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x votingPop
                scatter.y country
                scatter.mode.markers
                scatter.name "Percent of estimated voting age population"
                scatter.marker [
                    scatter.marker.color (colors.rgba(156, 165, 196, 0.95))
                    scatter.marker.line [
                        marker.line.color (colors.rgba(156, 165, 196, 1.0))
                        marker.line.width 1
                    ]
                    scatter.marker.symbol.circle
                    scatter.marker.size 16
                ]
            ]
            data.scatter [
                scatter.x regVoters
                scatter.y country
                scatter.mode.markers
                scatter.name "Percent of estimated registered voters"
                scatter.marker [
                    scatter.marker.color (colors.rgba(204, 204, 204, 0.95))
                    scatter.marker.line [
                        marker.line.color (colors.rgba(217, 217, 217, 1.0))
                        marker.line.width 1
                    ]
                    scatter.marker.symbol.circle
                    scatter.marker.size 16
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Votes cast for ten lowest voting age population in OECD countries"
            ]
            layout.xaxis [
                layout.xaxis.showgrid false
                layout.xaxis.showline true
                layout.xaxis.linecolor (colors.rgb(102, 102, 102))
                layout.xaxis.title [
                    xaxis.title.font [
                        title.font.color (colors.rgb(204, 204, 204))
                    ]
                ]
                layout.xaxis.tickfont [
                    xaxis.tickfont.color (colors.rgb(102, 102, 102))
                ]
                layout.xaxis.tickmode.linear
                layout.xaxis.dtick 10
                layout.xaxis.ticks.outside
                layout.xaxis.tickcolor (colors.rgb(102, 102, 102))
            ]
            layout.margin [
                layout.margin.l 140
                layout.margin.r 40
                layout.margin.b 50
                layout.margin.t 80
            ]
            layout.legend [
                layout.legend.font [
                    legend.font.size 10
                ]
                layout.legend.yanchor.middle
                layout.legend.xanchor.right
            ]
            layout.showlegend false
            layout.height 600
            layout.width 600
            layout.paperBgcolor (colors.rgb(254, 247, 234))
            layout.plotBgcolor (colors.rgb(254, 247, 234))
            layout.hovermode.closest
        ]
    ]
