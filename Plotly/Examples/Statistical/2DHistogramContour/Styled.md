# Feliz.Plotly - 2D Histogram Contour

Taken from [Plotly - 2D Histogram Contour](https://plot.ly/javascript/2d-histogram-contour/)

```fsharp:plotly-chart-twodimensionalhistogramcontour-styled
[<RequireQualifiedAccess>]
module Samples.TwoDimensionalHistogramContour.Styled

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram2dcontour [
                histogram2dcontour.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram2dcontour.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() + 0.1))
                histogram2dcontour.colorscale color.colorscale.blues
                histogram2dcontour.contours [
                    contours.showlabels true
                    contours.labelfont [
                        labelfont.family "Raleway"
                        labelfont.color color.white
                    ]
                ]
                histogram2dcontour.hoverlabel [
                    hoverlabel.bgcolor color.white
                    hoverlabel.bordercolor color.black
                    hoverlabel.font [
                        font.family "Raleway"
                        font.color color.black
                    ]
                ]
            ]
        ]
    ]
```