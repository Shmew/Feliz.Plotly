# Feliz.Plotly - Filled Area on Maps

Taken from [Plotly - Filled Area on Maps](https://plot.ly/javascript/filled-area-on-mapbox/)

```fsharp:plotly-chart-maps-filledarea
[<RequireQualifiedAccess>]
module Samples.Maps.FilledArea

open Feliz
open Feliz.Plotly

let lon =
    [ Some -10; Some -10; Some 8; Some 8; Some -10
      None; Some 30; Some 30; Some 50; Some 50
      Some 30; None; Some 100; Some 100; Some 80
      Some 80; Some 100 ]
    
let lat =
    [ Some 30; Some 6; Some 6; Some 30; Some 30
      None; Some 20; Some 30; Some 30; Some 20
      Some 20; None; Some 40; Some 50; Some 50
      Some 40; Some 40]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scattermapbox [
                scattermapbox.mode.lines
                scattermapbox.lon lon
                scattermapbox.lat lat
                scattermapbox.fill.toself
            ]
        ]
        plot.layout [
            layout.mapbox [
                mapbox.style "stamen-terrain"
                mapbox.center [
                    center.lon 40
                    center.lat 20
                ]
                mapbox.zoom 1.5
            ]
            layout.showlegend false
            layout.height 700
            layout.width 700
        ]
    ]
```