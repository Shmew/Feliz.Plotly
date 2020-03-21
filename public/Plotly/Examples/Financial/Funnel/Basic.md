# Feliz.Plotly - Funnel and Funnelarea Charts

Taken from [Plotly - Funnel and Funnelarea Charts](https://plot.ly/javascript/funnel-charts/)

```fsharp:plotly-chart-funnel-basic
[<RequireQualifiedAccess>]
module Samples.Funnel.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.funnel [
                funnel.y [
                    "Website visit"
                    "Downloads"
                    "Potential customers"
                    "Invoice sent"
                    "Closed delas"
                ]
                funnel.x [ 13873; 10533; 5443; 2703; 908 ]
                funnel.hoverinfo [
                    funnel.hoverinfo.x
                    funnel.hoverinfo.percentPrevious
                    funnel.hoverinfo.percentInitial
                ]
            ]
        ]
        plot.layout [
            layout.margin [
                margin.l 150
            ]
            layout.width 700
            layout.height 500
        ]
    ]
```