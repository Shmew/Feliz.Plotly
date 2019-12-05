# Feliz.Plotly - Radar Plots

Taken from [Plotly - Radar Plots](https://plot.ly/javascript/radar-chart/)

```fsharp:plotly-chart-radar-multipletraces
[<RequireQualifiedAccess>]
module Samples.Radar.MultipleTraces

open Feliz
open Feliz.Plotly

let th = [ "A"; "B"; "C"; "D"; "E"; "A" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterpolar [
                scatterpolar.r [ 39; 28; 8; 7; 28; 39 ]
                scatterpolar.theta th
                scatterpolar.fill.toself
                scatterpolar.name "Group A"
            ]
            traces.scatterpolar [
                scatterpolar.r [ 1.5; 10.; 39.; 31.; 15.; 1.5 ]
                scatterpolar.theta th
                scatterpolar.fill.toself
                scatterpolar.name "Group B"
            ]
        ]
        plot.layout [
            layout.polar [
                polar.radialaxis [
                    radialaxis.visible true
                    radialaxis.range [ 0; 50 ]
                ]
            ]
        ]
    ]
```