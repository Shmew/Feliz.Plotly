# Feliz.Plotly - Heatmap Plots

Taken from [Plotly - Heatmap Plots](https://plot.ly/javascript/heatmaps/)

```fsharp:plotly-chart-heatmap-annotated
[<RequireQualifiedAccess>]
module Samples.Heatmap.Annotated

open Feliz
open Feliz.Plotly

let xData = [ "A"; "B"; "C"; "D"; "E" ]
let yData = [ "W"; "X"; "Y"; "Z" ]
let zData =
    [ [ 0.; 0.; 0.75; 0.75; 0. ]
      [ 0.; 0.; 0.75; 0.75; 0. ]
      [ 0.75; 0.75; 0.75; 0.75; 0.75 ]
      [ 0.; 0.; 0.; 0.75; 0. ] ]

let annotations =
    yData
    |> List.map2 (fun zList y ->
        xData
        |> List.map2 (fun z x ->
            annotations.annotation [ 
                annotation.xref.x 1
                annotation.yref.y 1
                annotation.x x
                annotation.y y
                annotation.text (string z)
                annotation.font [
                font.family font.arial
                font.size 12
                font.color (if z <= 0. then color.black else color.white)
                ]
                annotation.showarrow false
                if z <= 0. then annotation.bgcolor (color.rgb(50, 171, 96))
            ]
        ) zList
    ) zData
    |> List.concat

let chart () =
    Plotly.plot [
        plot.traces [
            traces.heatmap [
                heatmap.x xData
                heatmap.y yData
                heatmap.z zData
                heatmap.colorscale ([ "#3D9970"; "#001f3f" ] |> color.colorscale.sequential)
                heatmap.showscale false
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Annotated Heatmap"
            ]
            layout.annotations annotations
            layout.xaxis [
                xaxis.ticks.none
                xaxis.side.top
            ]
            layout.yaxis [
                yaxis.ticks.none
                yaxis.ticksuffix " "
            ]
            layout.width 700
            layout.height 700
            layout.autosize false
        ]
    ]
```