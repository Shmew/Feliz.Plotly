# Feliz.Plotly - Waterfall Charts

Taken from [Plotly - Waterfall Charts](https://plot.ly/javascript/waterfall-charts/)

```fsharp:plotly-chart-waterfall-multicategory
[<RequireQualifiedAccess>]
module Samples.Waterfall.MultiCategory

open Feliz
open Feliz.Plotly

let xData = 
    [ [ "2016"; "2017"; "2017"; "2017"; "2017"; "2018"; "2018"; "2018"; "2018" ]
      [ "initial"; "q1"; "q2"; "q3"; "total"; "q1"; "q2"; "q3"; "total" ] ]

let measureData = 
    [ measure.absolute; measure.relative; measure.relative; measure.relative
      measure.total; measure.relative; measure.relative; measure.relative; measure.total ]

let yData = [ Some 1; Some 2; Some 3; Some -1; None; Some 1; Some 2; Some -4; None ]
    
let xData2 =
    [ ["2016"; "2017"; "2017"; "2017"; "2017"; "2018"; "2018"; "2018"; "2018"]
      ["initial"; "q1"; "q2"; "q3"; "total"; "q1"; "q2"; "q3"; "total" ] ]
    
let measureData2 =
    [ measure.absolute; measure.relative; measure.relative; measure.relative; measure.total
      measure.relative; measure.relative; measure.relative; measure.total ]
    
let yData2 = [ Some 1.1; Some 2.2; Some 3.3; Some -1.1; None; Some 1.1; Some 2.2; Some -4.4; None ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.waterfall [
                waterfall.x xData
                waterfall.measure measureData
                waterfall.y yData
                waterfall.base' 1000
            ]
            traces.waterfall [
                waterfall.x xData2
                waterfall.measure measureData2
                waterfall.y yData2
                waterfall.base' 1000
            ]
        ]
        plot.layout [
            layout.waterfallgroupgap 0.5
            layout.xaxis [
                xaxis.title [
                    title.text "MULTI-CATEGORY"
                ]
                xaxis.tickfont [
                    tickfont.size 16
                ]
                xaxis.ticks.outside
            ]
        ]
    ]
```