# Feliz.Plotly - Polar Plots

Taken from [Plotly - Polar Plots](https://plot.ly/javascript/polar-chart/)

```fsharp:plotly-chart-polar-directions
[<RequireQualifiedAccess>]
module Samples.Polar.Directions

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterpolar [
                scatterpolar.mode [
                    scatterpolar.mode.lines
                    scatterpolar.mode.markers
                ]
                scatterpolar.r [ 1 .. 5 ]
                scatterpolar.theta [ 0; 90; 180; 360; 0 ]
                scatterpolar.line [
                    line.color "#FF66AB"
                ]
                scatterpolar.marker [
                    marker.color "#8090C7"
                    marker.symbol.square
                    marker.size 8
                ]
            ]
            traces.scatterpolar [
                scatterpolar.mode [
                    scatterpolar.mode.lines
                    scatterpolar.mode.markers
                ]
                scatterpolar.r [ 1 .. 5 ]
                scatterpolar.theta [ 0; 90; 180; 360; 0 ]
                scatterpolar.line [
                    line.color "#FF66AB"
                ]
                scatterpolar.marker [
                    marker.color "#8090C7"
                    marker.symbol.square
                    marker.size 8
                ]
                scatterpolar.subplot 2
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.polar [
                polar.domain [
                    domain.x [ 0.; 0.4 ]
                    domain.y [ 0; 1 ]
                ]
                polar.radialaxis [
                    radialaxis.tickfont [
                        tickfont.size 8
                    ]
                ]
                polar.angularaxis [
                    angularaxis.tickfont [
                        tickfont.size 8
                    ]
                    angularaxis.rotation 90
                    angularaxis.direction.counterclockwise
                ]
            ]
            layout.polar (2, [
                polar.domain [
                    domain.x [ 0.6; 1. ]
                    domain.y [ 0; 1 ]
                ]
                polar.radialaxis [
                    radialaxis.tickfont [
                        tickfont.size 8
                    ]
                ]
                polar.angularaxis [
                    angularaxis.tickfont [
                        tickfont.size 8
                    ]
                    angularaxis.direction.clockwise
                ]
            ])
        ]
    ]
```