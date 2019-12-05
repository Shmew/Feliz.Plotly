# Feliz.Plotly - Sunburst Charts

Taken from [Plotly - Sunburst Charts](https://plot.ly/javascript/sunburst-charts/)

```fsharp:plotly-chart-sunburst-repeatedlabels
[<RequireQualifiedAccess>]
module Samples.Sunburst.RepeatedLabels

open Feliz
open Feliz.Plotly

let ids =
    [ "North America"
      "Europe"
      "Australia"
      "North America - Football"
      "Soccer"
      "North America - Rugby"
      "Europe - Football"
      "Rugby"
      "Europe - American Football"
      "Australia - Football"
      "Association"
      "Australian Rules"
      "Autstralia - American Football"
      "Australia - Rugby"
      "Rugby League" 
      "Rugby Union" ]


let labels =
    [ "North<br>America" 
      "Europe" 
      "Australia" 
      "Football" 
      "Soccer" 
      "Rugby"
      "Football" 
      "Rugby" 
      "American<br>Football" 
      "Football" 
      "Association"
      "Australian<br>Rules" 
      "American<br>Football" 
      "Rugby" 
      "Rugby<br>League"
      "Rugby<br>Union" ]

let parents =
    [ ""
      "" 
      "" 
      "North America" 
      "North America" 
      "North America" 
      "Europe"
      "Europe" 
      "Europe"
      "Australia" 
      "Australia - Football" 
      "Australia - Football"
      "Australia - Football" 
      "Australia - Football" 
      "Australia - Rugby"
      "Australia - Rugby" ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.sunburst [
                sunburst.labels labels
                sunburst.parents parents
                sunburst.ids ids
                sunburst.outsidetextfont [
                    outsidetextfont.size 20
                    outsidetextfont.color (color.rgb(55, 126, 184))
                ]
                sunburst.marker [
                    marker.line [
                        line.width 2
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.margin [
                margin.l 0
                margin.r 0
                margin.b 0
                margin.t 0
            ]
            layout.sunburstcolorway [
                color.rgb(99, 110, 250)
                color.rgb(239, 85, 59)
                color.rgb(0, 204, 150)
            ]
        ]
    ]
```