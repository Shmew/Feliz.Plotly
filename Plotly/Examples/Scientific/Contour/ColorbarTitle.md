# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-colorbartitle
[<RequireQualifiedAccess>]
module Samples.Contour.ColorbarTitle

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
                    colorbar.title [
                        title.text "Colorbar Title"
                        title.align.right
                        title.font [
                            font.size 14
                            font.family "Arial, sans-serif" // Improve this in Feliz
                        ]
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Colorbar with a Title"
            ]
        ]
    ]
```