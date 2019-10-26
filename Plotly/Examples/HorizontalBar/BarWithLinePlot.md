# Feliz.Plotly - Horizontal Bar Charts

Taken from [Plotly - Horizontal Bar Charts](https://plot.ly/javascript/horizontal-bar-charts/)

```fsharp:plotly-chart-horizontalbar-barwithlineplot
[<RequireQualifiedAccess>]
module Samples.HorizontalBar.BarWithLinePlot

open Feliz
open Feliz.Plotly

let xSavings =
    [ 1.3586
      2.2623000000000002
      4.9821999999999997
      6.5096999999999996
      7.4812000000000003
      7.5133000000000001
      15.2148
      17.520499999999998 ]

let xNetWorth =
    [ 93453.919999999998
      81666.570000000007
      69889.619999999995
      78381.529999999999
      141395.29999999999
      92969.020000000004
      66090.179999999993
      122379.3 ]

let y = 
    [ "Japan"
      "United Kingdom"
      "Canada"
      "Netherlands"
      "United States"
      "Belgium"
      "Sweden"
      "Switzerland" ]

let dataAnns =
    y
    |> List.map3 (fun savings networth y ->
        [ annotations.annotation [
            annotation.xref.custom "x1"
            annotation.yref.custom "y1"
            annotation.x (savings + 2.3)
            annotation.y (y + "%")
            annotation.font [
                font.family "Arial"
                font.size 12
                font.color (colors.rgb(50, 171, 96))
            ]
            annotation.showarrow false
          ] 
          annotations.annotation [
            annotation.xref.custom "x2"
            annotation.yref.custom "y1"
            annotation.x (networth - 20000.)
            annotation.y y
            annotation.text (sprintf "%0.2f M" networth)
            annotation.font [
                font.family "Arial"
                font.size 12
                font.color (colors.rgb(128, 0, 128))
            ]
            annotation.showarrow false
          ]
        ]
    ) xSavings xNetWorth
    |> List.concat

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x xSavings
                bar.y y
                bar.xaxis "x1"
                bar.yaxis "y1"
                bar.marker [
                    marker.color (colors.rgba(50, 171, 96, 0.6))
                    marker.line [
                        line.color (colors.rgba(50, 171, 96, 1.0))
                        line.width 1
                    ]
                ]
                bar.name "Household savings, percentage of household disposable income"
                bar.orientation.h
            ]
            traces.scatter [
                scatter.x xNetWorth
                scatter.y y
                scatter.xaxis "x2"
                scatter.yaxis "y1"
                scatter.mode.markersAndLines
                scatter.line [
                    line.color (colors.rgb(128, 0, 128))
                ]
                scatter.name "Household net worth, Million USD/capita"
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Household Savings & Net Worth for Eight OECD Countries"
            ]
            layout.xaxis [
                xaxis.range [ 0; 20 ]
                xaxis.domain [ 0.; 0.5 ]
                xaxis.zeroline false
                xaxis.showline false
                xaxis.showticklabels true
                xaxis.showgrid true
            ]
            layout.xaxis [
                xaxis.range [ 25000; 150000 ]
                xaxis.domain [ 0.5; 1. ]
                xaxis.zeroline false
                xaxis.showline false
                xaxis.showticklabels true
                xaxis.showgrid true
                xaxis.side.top
                xaxis.dtick 25000
            ]
            layout.legend [
                legend.x 0.029
                legend.y 1.238
                legend.font [
                    font.size 10
                ]
            ]
            layout.margin [
                margin.l 100
                margin.r 20
                margin.t 200
                margin.b 70
            ]
            layout.width 600
            layout.height 600
            layout.paperBgcolor (colors.rgb(248, 248, 255))
            layout.plotBgcolor (colors.rgb(248, 248, 255))
            layout.annotations [
                annotations.annotation [
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.x -0.2
                    annotation.y -0.109
                    annotation.text 
                        "OECD (2015); Household savings (indicator); \
                        Household net worth (indicator). doi: \
                        10.1787/cfc6f499-en (Accessed on 05 June 2015)"
                    annotation.showarrow false
                    annotation.font [
                        font.family "Arial"
                        font.size 10
                        font.color (colors.rgb(150, 150, 150))
                    ]
                ]
                yield! dataAnns
            ]
        ]
    ]
```