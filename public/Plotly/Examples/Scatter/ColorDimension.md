# Feliz.Plotly - Line and Scatter Plot

Taken from [Plotly - Line and Scatter Plot](https://plot.ly/javascript/line-and-scatter/)

```fsharp:plotly-chart-scatter-colordimension
[<RequireQualifiedAccess>]
module Samples.Scatter.ColorDimension

open Feliz
open Feliz.Plotly

let chart () =
    let yPlots = 5 |> List.replicate 40 // Some reason this doesn't work?
    Plotly.plot [
        plot.data [
            data.scatter [
                scatter.y [5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5; 5]
                scatter.mode.markers
                scatter.marker [
                    scatter.marker.size 40
                    scatter.marker.color ["0"; "1"; "2"; "3"; "4"; "5"; "6"; "7"; "8"; "9"; "10"; "11"; "12"; "13";
                    "14"; "15"; "16"; "17"; "18"; "19"; "20"; "21"; "22"; "23"; "24"; "25";
                    "26"; "27"; "28"; "29"; "30"; "31"; "32"; "33"; "34"; "35"; "36"; "37";
                    "38"; "39"] // TODO: Accept ints and floats for color field?
                ]
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "Scatter Plot with a Color Dimension"
            ]
        ]
    ]
```