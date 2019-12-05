# Feliz.Plotly - Continuous Error Bars

Taken from [Plotly - Continuous Error Bars](https://plot.ly/javascript/continuous-error-bars/)

```fsharp:plotly-chart-continuouserrorbar-filledlines
[<RequireQualifiedAccess>]
module Samples.ContinuousErrorBar.FilledLines

open Feliz
open Feliz.Plotly

let xData = [ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 10; 9; 8; 7; 6; 5; 4; 3; 2; 1 ]
let yData = [ 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0 ]

let xData2 = [ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 10; 9; 8; 7; 6; 5; 4; 3; 2; 1 ]
let yData2 = [ 5.5; 3.; 5.5; 8.; 6.; 3.; 8.; 5.; 6.; 5.5; 4.75; 5.; 4.; 7.; 2.; 4.; 7.; 4.4; 2.; 4.5 ]

let xData3 = [ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 10; 9; 8; 7; 6; 5; 4; 3; 2; 1 ]
let yData3 = [ 11.; 9.; 7.; 5.; 3.; 1.; 3.; 5.; 3.; 1.; -1.; 1.; 3.; 1.; -0.5; 1.; 3.; 5.; 7.; 9. ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xData
                scatter.y yData
                scatter.fill.toself
                scatter.fillcolor (color.rgba(0, 100, 80, 0.2))
                scatter.line [
                    line.color color.transparent
                ]
                scatter.name "Fair"
                scatter.showlegend false
            ]
            traces.scatter [
                scatter.x xData2
                scatter.y yData2
                scatter.fill.toself
                scatter.fillcolor (color.rgba(0, 176, 246, 0.2))
                scatter.line [
                    line.color color.transparent
                ]
                scatter.name "Premium"
                scatter.showlegend false
            ]
            traces.scatter [
                scatter.x xData3
                scatter.y yData3
                scatter.fill.toself
                scatter.fillcolor (color.rgba(231, 107, 243, 0.2))
                scatter.line [
                    line.color color.transparent
                ]
                scatter.name "Fair"
                scatter.showlegend false
            ]
            traces.scatter [
                scatter.x [ 1 .. 10 ]
                scatter.y [ 1 .. 10 ]
                scatter.line [
                    line.color (color.rgb(0, 100, 80))
                ]
                scatter.mode.lines
                scatter.name "Fair"
            ]
            traces.scatter [
                scatter.x [ 1 .. 10 ]
                scatter.y [ 5.; 2.5; 5.; 7.5; 5.; 2.5; 7.5; 4.5; 5.5; 5. ]
                scatter.line [
                    line.color (color.rgb(0, 176, 246))
                ]
                scatter.mode.lines
                scatter.name "Premium"
            ]
            traces.scatter [
                scatter.x [ 1 .. 10 ]
                scatter.y [ 10; 8; 6; 4; 2; 0; 2; 4; 2; 0 ]
                scatter.line [
                    line.color (color.rgb(231, 107, 243))
                ]
                scatter.mode.lines
                scatter.name "Ideal"
            ]
        ]
        plot.layout [
            layout.paperBgcolor (color.rgb(255, 255, 255))
            layout.plotBgcolor (color.rgb(229, 229, 229))
            layout.xaxis [
                xaxis.gridcolor (color.rgb(255, 255, 255))
                xaxis.range [ 1; 10 ]
                xaxis.showgrid true
                xaxis.showline false
                xaxis.showticklabels true
                xaxis.tickcolor (color.rgb(127, 127, 127))
                xaxis.ticks.outside
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.gridcolor (color.rgb(255, 255, 255))
                yaxis.showgrid true
                yaxis.showline false
                yaxis.showticklabels true
                yaxis.tickcolor (color.rgb(127, 127, 127))
                yaxis.ticks.outside
                yaxis.zeroline false
            ]
        ]
    ]
```