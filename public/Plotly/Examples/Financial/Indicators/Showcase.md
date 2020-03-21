# Feliz.Plotly - Indicators

Taken from [Plotly - Indicators](https://plot.ly/javascript/indicator/)

```fsharp:plotly-chart-indicators-showcase
[<RequireQualifiedAccess>]
module Samples.Indicators.Showcase

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.indicator [
                indicator.value 200
                indicator.delta [
                    delta.reference 160
                ]
                indicator.gauge [
                    gauge.axis [
                        axis.visible false
                        axis.range [ 0; 250 ]
                    ]
                ]
                indicator.domain [
                    domain.row 0
                    domain.column 0
                ]
            ]
            traces.indicator [
                indicator.mode [
                    indicator.mode.number
                    indicator.mode.delta
                ]
                indicator.value 300
                indicator.domain [
                    domain.row 0
                    domain.column 1
                ]
            ]
            traces.indicator [
                indicator.value 120
                indicator.gauge [
                    gauge.shape.bullet
                    gauge.axis [
                        axis.visible false
                        axis.range [ -200; 200 ]
                    ]
                ]
                indicator.domain [
                    domain.row 1
                    domain.column 0
                ]
            ]
            traces.indicator [
                indicator.mode.delta
                indicator.value 40
                indicator.domain [
                    domain.row 1
                    domain.column 1
                ]
            ]
        ]
        plot.layout [
            layout.width 800
            layout.height 400
            layout.grid [
                grid.rows 2
                grid.columns 2
                grid.pattern.independent
            ]
            layout.template [
                template.traces [
                    traces.indicator [
                        indicator.title [
                            title.text "Speed"
                        ]
                        indicator.mode [
                            indicator.mode.number
                            indicator.mode.delta
                            indicator.mode.gauge
                        ]
                        indicator.delta [
                            delta.reference 90
                        ]
                    ]
                ]
            ]
        ]
    ]
```