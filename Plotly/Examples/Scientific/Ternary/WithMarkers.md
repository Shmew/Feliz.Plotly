# Feliz.Plotly - Ternary Plots

Taken from [Plotly - Ternary Plots](https://plot.ly/javascript/ternary-plots/)

```fsharp:plotly-chart-ternary-withmarkers
[<RequireQualifiedAccess>]
module Samples.Ternary.WithMarkers

open Feliz
open Feliz.Plotly

type TernaryData =
    { Journalist: int
      Developer: int
      Designer: int
      Label: string }
    
[<RequireQualifiedAccess>]
module TernaryData =
    let create journalist developer designer label =
        { Journalist = journalist
          Developer = developer
          Designer = designer
          Label = label }

    let journalist tData = tData.Journalist
    let developer tData = tData.Developer
    let designer tData = tData.Designer
    let label tData = tData.Label

type TernarySet =
    { Data: TernaryData list }
    member this.Journalists =
        this.Data |> List.map (fun t -> t.Journalist)
    member this.Developers =
        this.Data |> List.map (fun t -> t.Developer)
    member this.Designers =
        this.Data |> List.map (fun t -> t.Designer)
    member this.Labels =
        this.Data |> List.map (fun t -> t.Label)

[<RequireQualifiedAccess>]
module TernarySet =
    let create dataSet = { Data = dataSet }

let plotData = 
    [ TernaryData.create 75 25 0 "point 1"
      TernaryData.create 70 10 20 "point 2"
      TernaryData.create 75 20 5 "point 3"
      TernaryData.create 5 60 35 "point 4"
      TernaryData.create 10 80 10 "point 5"
      TernaryData.create 10 90 0 "point 6"
      TernaryData.create 20 70 10 "point 7"
      TernaryData.create 10 20 70 "point 8"
      TernaryData.create 15 5 80 "point 9"
      TernaryData.create 10 10 80 "point 10"
      TernaryData.create 20 10 70 "point 11" ]
    |> TernarySet.create

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatterternary [
                scatterternary.mode.markers
                scatterternary.a plotData.Journalists
                scatterternary.b plotData.Developers
                scatterternary.c plotData.Designers
                scatterternary.text plotData.Labels
                scatterternary.marker [
                    marker.symbol._100
                    marker.color (color.rgba(0, 0, 0, 0.))
                    marker.size 14
                    marker.line [
                        line.color "#DB7365"
                        line.width 2
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.ternary [
                ternary.bgcolor "#FFF1E0"
                ternary.sum 100
                ternary.aaxis [
                    aaxis.title [
                        title.text "Journalist"
                        title.font [
                            font.size 20
                        ]
                    ]
                    aaxis.tickangle 0
                    aaxis.tickfont [
                        tickfont.size 15
                    ]
                    aaxis.tickcolor (color.rgba(0, 0, 0, 0.))
                    aaxis.ticklen 5
                    aaxis.showline true
                    aaxis.showgrid true
                ]
                ternary.baxis [
                    baxis.title [
                        title.text "<br>Developer"
                        title.font [
                            font.size 20
                        ]
                    ]
                    baxis.tickangle 45
                    baxis.tickfont [
                        tickfont.size 15
                    ]
                    baxis.tickcolor (color.rgba(0, 0, 0, 0.))
                    baxis.ticklen 5
                    baxis.showline true
                    baxis.showgrid true
                ]
                ternary.caxis [
                    caxis.title [
                        title.text "<br>Designer"
                        title.font [
                            font.size 20
                        ]
                    ]
                    caxis.tickangle -45
                    caxis.tickfont [
                        tickfont.size 15
                    ]
                    caxis.tickcolor (color.rgba(0, 0, 0, 0.))
                    caxis.ticklen 5
                    caxis.showline true
                    caxis.showgrid true
                ]
            ]
            layout.annotations [
                annotations.annotation [
                    annotation.showarrow false
                    annotation.text """Replica of Tom Pearson's <a href="http://bl.ocks.org/tomgp/7674234">block</a>"""
                    annotation.x 0.5
                    annotation.y 1.3
                    annotation.font [
                        font.size 15
                    ]
                ]
            ]
            layout.paperBgcolor "#FFF1E0"
        ]
    ]
```