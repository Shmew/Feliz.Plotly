# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-stylingcolorbar
[<RequireQualifiedAccess>]
module Samples.Contour.StylingColorbar

open Feliz
open Feliz.Plotly

let zData =
    [ [ 10.; 10.625; 12.5; 15.625; 20. ]
      [ 5.625; 6.25; 8.125; 11.25; 15.625 ]
      [ 2.5; 3.125; 5.0; 8.125; 12.5 ]
      [ 0.625; 1.25; 3.125; 6.25; 10.625 ]
      [ 0.; 0.625; 2.5; 5.625; 10. ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contour [
                contour.z zData
                contour.colorbar [
                    colorbar.ticks.outside
                    colorbar.dtick 1
                    colorbar.tickwidth 2
                    colorbar.ticklen 10
                    colorbar.tickcolor color.gray
                    colorbar.showticklabels true
                    colorbar.tickfont [
                        tickfont.size 15
                    ]
                    colorbar.xpad 50
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Styling Colorbar Ticks for Contour Plots"
            ]
        ]
    ]
```