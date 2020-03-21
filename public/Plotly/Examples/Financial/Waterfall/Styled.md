# Feliz.Plotly - Waterfall Charts

Taken from [Plotly - Waterfall Charts](https://plot.ly/javascript/waterfall-charts/)

```fsharp:plotly-chart-waterfall-styled
[<RequireQualifiedAccess>]
module Samples.Waterfall.Styled

open Feliz
open Feliz.Plotly

let xData = 
    [ ["2016"; "2017"; "2017"; "2017"; "2017"; "2018"; "2018"; "2018"; "2018"];
      ["initial"; "q1"; "q2"; "q3"; "total"; "q1"; "q2"; "q3"; "total" ] ]

let measureData = 
    [ measure.absolute; measure.relative; measure.relative
      measure.relative; measure.total; measure.relative
      measure.relative; measure.relative; measure.total ]

let yData =
    [ Some 10; Some 20; Some 30; Some -10
      None; Some 10; Some 20; Some -40; None ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.waterfall [
                waterfall.x xData
                waterfall.measure measureData
                waterfall.y yData
                waterfall.base' 300
                waterfall.decreasing [
                    decreasing.marker [
                        marker.color color.maroon
                        marker.line [
                            line.color color.red
                            line.width 2
                        ]
                    ]
                ]
                waterfall.increasing [
                    increasing.marker [
                        marker.color color.teal   
                    ]
                ]
                waterfall.totals [
                    totals.marker [
                        marker.color color.deepSkyBlue
                        marker.line [
                            line.color color.blue
                            line.width 3
                        ]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Profit and loss statement"
            ]
            layout.waterfallgap 0.3
            layout.xaxis [
                xaxis.title [
                    title.text ""
                ]
                xaxis.tickfont [
                    tickfont.size 15
                ]
                xaxis.ticks.outside
            ]
        ]
    ]
```