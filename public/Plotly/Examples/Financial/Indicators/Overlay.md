# Feliz.Plotly - Indicators

Taken from [Plotly - Indicators](https://plot.ly/javascript/indicator/)

```fsharp:plotly-chart-indicators-overlay
[<RequireQualifiedAccess>]
module Samples.Indicators.Overlay

open Feliz
open Feliz.Plotly

let yData =
    [ 325; 324; 405; 400; 424; 404; 417; 432; 419; 394; 410; 426; 413; 419; 404; 408 
      401; 377; 368; 361; 356; 359; 375; 397; 394; 418; 437; 450; 430; 442; 424; 443
      420; 418; 423; 423; 426; 440; 437; 436; 447; 460; 478; 472; 450; 456; 436; 418
      429; 412; 429; 442; 464; 447; 434; 457; 474; 480; 499; 497; 480; 502; 512; 492 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.indicator [
                indicator.mode [
                    indicator.mode.number
                    indicator.mode.delta
                ]
                indicator.value 492
                indicator.delta [
                    delta.reference 512
                    delta.valueformat ".0f"
                ]
                indicator.domain [
                    domain.y [ 0; 1 ]
                    domain.y [ 0.25; 0.75 ]
                ]
                indicator.title [
                    title.text "Users Online"
                ]
            ]
            traces.scatter [
                scatter.y yData
            ]
        ]
        plot.layout [
            layout.width 600
            layout.height 450
            layout.xaxis [
                xaxis.range [ 0; 62 ]
            ]
        ]
    ]
```