# Feliz.Plotly - SPC Control Charts

Taken from [Plotly - SPC Control Charts](https://plot.ly/javascript/spc-control-charts/)

```fsharp:plotly-chart-spccontrol-distribution
[<RequireQualifiedAccess>]
module Samples.SPCControl.Distribution

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1 .. 9 ]
                scatter.y [ 4; 2; -1; 4; -5; -7; 0; 3; 8 ]
                scatter.mode [
                    scatter.mode.lines
                    scatter.mode.markers
                ]
                scatter.name "Data"
                scatter.showlegend true
                scatter.hoverinfo.all
                scatter.line [
                    line.color color.blue
                    line.width 2
                ]
                scatter.marker [
                    marker.color color.blue
                    marker.size 8
                    marker.symbol.circle
                ]
            ]
            traces.scatter [
                scatter.x [ 6; 9 ]
                scatter.y [ -7; 8 ]
                scatter.mode.markers
                scatter.name "Violation"
                scatter.showlegend true
                scatter.marker [
                    marker.color (color.rgb(255, 65, 54))
                    marker.line [
                        line.width 3
                    ]
                    marker.opacity 0.5
                    marker.size 12
                    marker.symbol.circleOpen
                ]
            ]
            traces.scatter [
                scatter.x [ Some 0.5; Some 10.; None; Some 0.5; Some 10. ]
                scatter.y [ Some -5; Some -5; None; Some 5; Some 5 ]
                scatter.mode.lines
                scatter.name "LCL/UCL"
                scatter.showlegend true
                scatter.line [
                    line.color color.red
                    line.width 2
                    line.dash.dash
                ]
            ]
            traces.scatter [
                scatter.x [ 0.5; 10. ]
                scatter.y [ 0; 0 ]
                scatter.mode.lines
                scatter.name "Center"
                scatter.showlegend true
                scatter.line [
                    line.color color.gray
                    line.width 2
                ]
            ]
            traces.histogram [
                histogram.x [ 1 .. 9 ]
                histogram.y [ 4; 2; -1; 4; -5; -7; 0; 3; 8 ]
                histogram.orientation.h
                histogram.name "Distribution"
                histogram.marker [
                    marker.color color.blue
                    marker.line [
                        line.color color.white
                        line.width 1
                    ]
                ]
                histogram.xaxis 2
                histogram.yaxis 2
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Basic SPC Chart With Distribution"
            ]
            layout.xaxis [
                xaxis.domain [ 0.; 0.7 ]
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.range [ -10; 10 ]
                yaxis.zeroline false
            ]
            layout.xaxis (2, [
                xaxis.domain [ 0.8; 1. ]
            ])
            layout.yaxis (2, [
                yaxis.anchor.x 2
                yaxis.showticklabels false
            ])
        ]
    ]
```