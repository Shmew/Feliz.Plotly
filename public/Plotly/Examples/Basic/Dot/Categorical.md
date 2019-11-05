# Feliz.Plotly - Dot Plots

Taken from [Plotly - Dot Plots](https://plot.ly/javascript/dot-plots/)

```fsharp:plotly-chart-dot-categorical
[<RequireQualifiedAccess>]
module Samples.Dot.Categorical

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

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x votingPop
                scatter.y country
                scatter.mode.markers
                scatter.name "Percent of estimated voting age population"
                scatter.marker [
                    marker.color (color.rgba(156, 165, 196, 0.95))
                    marker.line [
                        line.color (color.rgba(156, 165, 196, 1.0))
                        line.width 1
                    ]
                    marker.symbol.circle
                    marker.size 16
                ]
            ]
            traces.scatter [
                scatter.x regVoters
                scatter.y country
                scatter.mode.markers
                scatter.name "Percent of estimated registered voters"
                scatter.marker [
                    marker.color (color.rgba(204, 204, 204, 0.95))
                    marker.line [
                        line.color (color.rgba(217, 217, 217, 1.0))
                        line.width 1
                    ]
                    marker.symbol.circle
                    marker.size 16
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Votes cast for ten lowest voting age population in OECD countries"
            ]
            layout.xaxis [
                xaxis.showgrid false
                xaxis.showline true
                xaxis.linecolor (color.rgb(102, 102, 102))
                xaxis.title [
                    title.font [
                        font.color (color.rgb(204, 204, 204))
                    ]
                ]
                xaxis.tickfont [
                    tickfont.color (color.rgb(102, 102, 102))
                ]
                xaxis.tickmode.linear
                xaxis.dtick 10
                xaxis.ticks.outside
                xaxis.tickcolor (color.rgb(102, 102, 102))
            ]
            layout.margin [
                margin.l 140
                margin.r 40
                margin.b 50
                margin.t 80
            ]
            layout.legend [
                legend.font [
                    font.size 10
                ]
                legend.yanchor.middle
                legend.xanchor.right
            ]
            layout.height 600
            layout.width 1200
            layout.paperBgcolor (color.rgb(254, 247, 234))
            layout.plotBgcolor (color.rgb(254, 247, 234))
            layout.hovermode.closest
        ]
    ]
```