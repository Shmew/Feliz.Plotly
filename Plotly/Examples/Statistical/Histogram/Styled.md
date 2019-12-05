# Feliz.Plotly - Histograms

Taken from [Plotly - Histograms](https://plot.ly/javascript/histograms/)

```fsharp:plotly-chart-histogram-styled
[<RequireQualifiedAccess>]
module Samples.Histogram.Styled

open Feliz
open Feliz.Plotly

let rng = System.Random()

let chart () =
    Plotly.plot [
        plot.traces [
            traces.histogram [
                histogram.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 5.))
                histogram.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble()))
                histogram.name "control"
                histogram.autobinx false
                histogram.histnorm.none
                histogram.marker [
                    marker.color (color.rgba(255, 100, 102, 0.7))
                    marker.line [
                        line.color (color.rgba(255, 100, 102, 1.))
                        line.width 1
                    ]
                ]
                histogram.opacity 0.5
                histogram.xbins [
                    xbins.end' 2.8
                    xbins.size 0.06
                    xbins.start 0.5
                ]
            ]
            traces.histogram [
                histogram.x ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 10.))
                histogram.y ([ 0 .. 499 ] |> List.map (fun _ -> rng.NextDouble() * 2.))
                histogram.name "experimental"
                histogram.autobinx false
                histogram.marker [
                    marker.color (color.rgba(100, 200, 102, 0.7))
                    marker.line [
                        line.color (color.rgba(100, 200, 102, 1.))
                        line.width 1
                    ]
                ]
                histogram.opacity 0.75
                histogram.xbins [
                    xbins.end' 4
                    xbins.size 0.06
                    xbins.start -3.2
                ]
            ]
        ]
        plot.layout [
            layout.bargap 0.05
            layout.bargroupgap 0.2
            layout.barmode.overlay
            layout.title [
                title.text "Sampled Results"
            ]
            layout.xaxis [
                xaxis.title [
                    title.text "Value"
                ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "Count"
                ]
            ]
        ]
    ]
```