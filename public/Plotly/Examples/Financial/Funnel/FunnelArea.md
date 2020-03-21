# Feliz.Plotly - Funnel and Funnelarea Charts

Taken from [Plotly - Funnel and Funnelarea Charts](https://plot.ly/javascript/funnel-charts/)

```fsharp:plotly-chart-funnel-funnelarea
[<RequireQualifiedAccess>]
module Samples.Funnel.FunnelArea

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.funnelarea [
                funnelarea.values [ 5 .. -1 .. 1 ]
                funnelarea.text [
                    "The 1st"
                    "The 2nd"
                    "The 3rd"
                    "The 4th"
                    "The 5th"
                ]
                funnelarea.marker [
                    marker.colors [ "59D4E8"; "DDB6C6"; "A696C8"; "67EACA"; "94D2E6" ]
                    marker.line [
                        line.color [ "3E4E88"; "606470"; "3E4E88"; "606470"; "3E4E88" ]
                        line.width [ 2; 1; 5; 0; 3 ]
                    ]
                ]
                funnelarea.textfont [
                    textfont.family "Old Standard TT"
                    textfont.size 13
                    textfont.color color.black
                ]
                funnelarea.opacity 0.65
            ]
        ]
        plot.layout [
            layout.margin [
                margin.l 200
                margin.r 200
            ]
            layout.funnelmode.stack
            layout.showlegend true
        ]
    ]
```