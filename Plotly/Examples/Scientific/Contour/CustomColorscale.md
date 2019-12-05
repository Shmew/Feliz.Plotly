# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-customcolorscale
[<RequireQualifiedAccess>]
module Samples.Contour.CustomColorscale

open Feliz
open Feliz.Plotly

let zData =
    [ [ 10.; 10.625; 12.5; 15.625; 20. ]
      [ 5.625; 6.25; 8.125; 11.25; 15.625 ]
      [ 2.5; 3.125; 5.0; 8.125; 12.5 ]
      [ 0.625; 1.25; 3.125; 6.25; 10.625 ]
      [ 0.; 0.625; 2.5; 5.625; 10. ] ]

let plotColorscale =
    let scales = [ 0.; 0.25; 0.45; 0.65; 0.85; 1. ]
    let colors = 
        [ color.rgb(166,206,227)
          color.rgb(31,120,180)
          color.rgb(178,223,138)
          color.rgb(51,160,44)
          color.rgb(251,154,153)
          color.rgb(227,26,28) ]

    color.colorscale.custom scales colors

let chart () =
    Plotly.plot [
        plot.traces [
            traces.contour [
                contour.z zData
                contour.colorscale plotColorscale
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Custom Contour Plot Colorscale"
            ]
        ]
    ]
```