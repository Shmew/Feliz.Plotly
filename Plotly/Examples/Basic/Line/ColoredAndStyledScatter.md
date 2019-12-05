# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-coloredandstyledscatter
[<RequireQualifiedAccess>]
module Samples.Line.ColoredAndStyledScatter

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 52698; 43117 ]
                scatter.y [ 53; 31 ]
                scatter.mode.markers
                scatter.name "North America"
                scatter.text [ "United States"; "Canada" ]
                scatter.marker [
                    marker.color (color.rgb(164, 194, 244))
                    marker.size 12
                    marker.line [
                        line.color color.white
                        line.width 0.5
                    ]
                ]
            ]
            traces.scatter [
                scatter.x [ 39317; 37236; 35650; 30066; 29570; 27159; 23557; 21046; 18007 ]
                scatter.y [ 33; 20; 13; 19; 27; 19; 49; 44; 38 ]
                scatter.mode.markers
                scatter.name "Europe"
                scatter.text [ "Germany"; "Britain"; "France"; "Spain"; "Italy"; "Czech Rep."; "Greece"; "Poland" ]
                scatter.marker [
                    marker.color (color.rgb(255, 217, 102))
                    marker.size 12
                ]
            ]
            traces.scatter [
                scatter.x [ 42952; 37037; 33106; 17478; 9813; 5253; 4692; 3899 ]
                scatter.y [ 23; 42; 54; 89; 14; 99; 93; 70 ]
                scatter.mode.markers
                scatter.name "Asia/Pacific"
                scatter.text [ "Australia"; "Japan"; "South Korea"; "Malaysia"; "China"; "Indonesia"; "Philippines"; "India" ]
                scatter.marker [
                    marker.color (color.rgb(234, 153, 153))
                    marker.size 12
                ]
            ]
            traces.scatter [
                scatter.x [ 19097; 18601; 15595; 13546; 12026; 7434; 5419 ]
                scatter.y [ 43; 47; 56; 80; 86; 93; 80 ]
                scatter.mode.markers
                scatter.name "Asia/Pacific"
                scatter.text [ "Chile"; "Argentina"; "Mexico"; "Venezuela"; "Venezuela"; "El Salvador"; "Bolivia" ]
                scatter.marker [
                    marker.color (color.rgb(142, 124, 195))
                    marker.size 12
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Quarter 1 Growth"
            ]
            layout.xaxis [
                xaxis.title [
                    title.text "GDP per Capita"
                ]
                xaxis.showgrid false
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "Percent"
                ]
                yaxis.showline false
            ]
        ]
    ]
```