[<RequireQualifiedAccess>]
module Samples.Contour.CustomSpacing

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
                contour.colorscale color.colorscale.jet
                contour.autocontour false
                contour.dx 10
                contour.x0 5
                contour.dy 10
                contour.y0 10
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Customizing Spacing Between X and Y Axis Ticks"
            ]
        ]
    ]
