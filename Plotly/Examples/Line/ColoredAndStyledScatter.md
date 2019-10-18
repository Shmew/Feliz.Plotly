# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-coloredandstyledscatter
[<RequireQualifiedAccess>]
module Samples.Line.ColoredAndStyledScatter

open Feliz
open Feliz.Plotly

module xaxis = Plotly.layout.xaxis
module yaxis = Plotly.layout.yaxis

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.x [ 52698; 43117 ]
                scatter.y [ 53; 31 ]
                scatter.mode.markers
                scatter.name "North America"
                scatter.text [ "United States"; "Canada" ]
                scatter.marker [
                    scatter.marker.color (colors.rgb(164, 194, 244))
                    scatter.marker.size 12
                    scatter.marker.line [
                        marker.line.color colors.white
                        marker.line.width 0.5
                    ]
                ]
            ]
            data.scatter [
                scatter.x [ 39317; 37236; 35650; 30066; 29570; 27159; 23557; 21046; 18007 ]
                scatter.y [ 33; 20; 13; 19; 27; 19; 49; 44; 38 ]
                scatter.mode.markers
                scatter.name "Europe"
                scatter.text [ "Germany"; "Britain"; "France"; "Spain"; "Italy"; "Czech Rep."; "Greece"; "Poland" ]
                scatter.marker [
                    scatter.marker.color (colors.rgb(255, 217, 102))
                    scatter.marker.size 12
                ]
            ]
            data.scatter [
                scatter.x [ 42952; 37037; 33106; 17478; 9813; 5253; 4692; 3899 ]
                scatter.y [ 23; 42; 54; 89; 14; 99; 93; 70 ]
                scatter.mode.markers
                scatter.name "Asia/Pacific"
                scatter.text [ "Australia"; "Japan"; "South Korea"; "Malaysia"; "China"; "Indonesia"; "Philippines"; "India" ]
                scatter.marker [
                    scatter.marker.color (colors.rgb(234, 153, 153))
                    scatter.marker.size 12
                ]
            ]
            data.scatter [
                scatter.x [ 19097; 18601; 15595; 13546; 12026; 7434; 5419 ]
                scatter.y [ 43; 47; 56; 80; 86; 93; 80 ]
                scatter.mode.markers
                scatter.name "Asia/Pacific"
                scatter.text [ "Chile"; "Argentina"; "Mexico"; "Venezuela"; "Venezuela"; "El Salvador"; "Bolivia" ]
                scatter.marker [
                    scatter.marker.color (colors.rgb(142, 124, 195))
                    scatter.marker.size 12
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Quarter 1 Growth"
            ]
            layout.xaxis [
                layout.xaxis.title [
                    xaxis.title.text "GDP per Capita"
                ]
                layout.xaxis.showgrid false
                layout.xaxis.zeroline false
            ]
            layout.yaxis [
                layout.yaxis.title [
                    yaxis.title.text "Percent"
                ]
                layout.yaxis.showline false
            ]
        ]
    ]
```