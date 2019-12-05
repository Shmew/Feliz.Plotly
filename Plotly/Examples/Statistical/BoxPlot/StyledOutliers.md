# Feliz.Plotly - Box Plots

Taken from [Plotly - Box Plots](https://plot.ly/javascript/box-plots/)

```fsharp:plotly-chart-boxplot-styledoutliers
[<RequireQualifiedAccess>]
module Samples.BoxPlot.StyledOutliers

open Feliz
open Feliz.Plotly

let yData = [ 0.75; 5.25; 5.5; 6.; 6.2; 6.6; 6.80; 7.0; 7.2; 7.5; 7.5; 7.75; 8.15; 8.15; 8.65; 8.93; 9.2; 9.5; 10.; 10.25; 11.5; 12.; 16.; 20.90; 22.3; 23.25 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.box [
                box.y yData
                box.name "All Points"
                box.jitter 0.3
                box.pointpos -1.8
                box.marker [
                    marker.color (color.rgb(7, 40, 89))
                ]
                box.boxpoints.all
            ]
            traces.box [
                box.y yData
                box.name "Only Whiskers"
                box.marker [
                    marker.color (color.rgb(9, 56, 125))
                ]
                box.boxpoints.false'
            ]
            traces.box [
                box.y yData
                box.name "Suspected Outlier"
                box.marker [
                    marker.color (color.rgb(8, 81, 156))
                    marker.outliercolor (color.rgba(219, 64, 82, 0.6))
                    marker.line [
                        line.outliercolor (color.rgba(219, 64, 82, 0.6))
                        line.outlierwidth 2
                    ]
                ]
                box.boxpoints.suspectedoutliers
            ]
            traces.box [
                box.y yData
                box.name "Whiskers and Outliers"
                box.marker [
                    marker.color (color.rgb(107, 174, 214))
                ]
                box.boxpoints.outliers
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Box Plot Styling Outliers"
            ]
        ]
    ]
```