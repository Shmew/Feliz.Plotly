# Feliz.Plotly - Filled Area Plots

Taken from [Plotly - Filled Area Plots](https://plot.ly/javascript/filled-area-plots/#stacked-area-chart)

The sample on the site doesn't seem to be quite correct anymore.

```fsharp:plotly-chart-filledarea-selecthover
[<RequireQualifiedAccess>]
module Samples.FilledArea.SelectHover

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 0.; 0.5; 1.; 1.5; 2. ]
                scatter.y [ 0; 1; 2; 1; 0 ]
                scatter.fill.toself
                scatter.fillcolor (color.rgb(171, 99, 250))
                scatter.line [
                    line.color (color.rgb(171, 99, 250))
                ]
                scatter.text "Points + Fills"
                scatter.hoverinfo.text
            ]
            traces.scatter [
                scatter.x [ 3.; 3.5; 4.; 4.5; 5. ]
                scatter.y [ 0; 1; 2; 1; 0 ]
                scatter.fill.toself
                scatter.fillcolor (color.rgb(231, 99, 250))
                scatter.line [
                    line.color (color.rgb(231, 99, 250))
                ]
                scatter.text "Points only"
                scatter.hoverinfo.text
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Hover on <i>Points</i> or <i>Fill</i>"
            ]
        ]
    ]
```