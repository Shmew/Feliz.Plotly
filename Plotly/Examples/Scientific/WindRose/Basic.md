# Feliz.Plotly - Wind Rose Plots

Taken from [Plotly - Wind Rose Plots](https://plot.ly/javascript/wind-rose-charts/)

```fsharp:plotly-chart-windrose-basic
[<RequireQualifiedAccess>]
module Samples.WindRose.Basic

open Feliz
open Feliz.Plotly

let thetaData = [ "North"; "N-E"; "East"; "S-E"; "South"; "S-W"; "West"; "N-W" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.barpolar [
                barpolar.r [ 77.5; 72.5; 70.0; 45.0; 22.5; 42.5; 40.0; 62.5 ]
                barpolar.theta thetaData
                barpolar.name "11-14 m/s"
                barpolar.marker [
                    marker.color (color.rgb(106, 81, 163))
                ]
            ]
            traces.barpolar [
                barpolar.r [ 57.5; 50.0; 45.0; 35.0; 20.0; 22.5; 37.5; 55.0 ]
                barpolar.theta thetaData
                barpolar.name "8-11 m/s"
                barpolar.marker [
                    marker.color (color.rgb(158, 154, 200))
                ]
            ]
            traces.barpolar [
                barpolar.r [ 40.0; 30.0; 30.0; 35.0; 7.5; 7.5; 32.5; 40.0 ]
                barpolar.theta thetaData
                barpolar.name "5-8 m/s"
                barpolar.marker [
                    marker.color (color.rgb(203, 201, 226))
                ]
            ]
            traces.barpolar [
                barpolar.r [ 20.0; 7.5; 15.0; 22.5; 2.5; 2.5; 12.5; 22.5 ]
                barpolar.theta thetaData
                barpolar.name "< 5 m/s"
                barpolar.marker [
                    marker.color (color.rgb(242, 240, 247))
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Wind Speed Distribution in Laurel, NE"
                title.font [
                    font.size 16
                ]
            ]
            layout.legend [
                legend.font [
                    font.size 16
                ]
            ]
            layout.polar [
                polar.barmode.overlay
                polar.bargap 0
                polar.radialaxis [
                    radialaxis.ticksuffix "%"
                    radialaxis.angle 45
                    radialaxis.dtick 20
                ]
                polar.angularaxis [
                    angularaxis.direction.clockwise
                ]
            ]
        ]
    ]
```