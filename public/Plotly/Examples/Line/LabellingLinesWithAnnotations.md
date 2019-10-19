# Feliz.Plotly - Line Charts

Taken from [Plotly - Line Charts](https://plot.ly/javascript/line-charts/)

```fsharp:plotly-chart-line-labellinglineswithannotations
[<RequireQualifiedAccess>]
module Samples.Line.LabellingLinesWithAnnotations

open Feliz
open Feliz.Plotly

let xData = 
    [2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2013]
    |> List.replicate 4

let yData =
    [ [ 74; 82; 80; 74; 73; 72; 74; 70; 70; 66; 66; 69]
      [ 45; 42; 50; 46; 36; 36; 34; 35; 32; 31; 31; 28]
      [ 13; 14; 20; 24; 20; 24; 24; 40; 35; 41; 43; 50]
      [ 18; 21; 18; 21; 16; 14; 13; 18; 17; 16; 19; 23] ]

let plotColors = 
    [ colors.rgba(67, 67, 67, 1.)
      colors.rgba(115, 115, 115, 1.)
      colors.rgba(49, 130, 189, 1.)
      colors.rgba(189, 189, 189, 1.) ]

let lineSize = [ 2; 2; 4; 2 ]

let labels = ["Television"; "Newspaper"; "Internet"; "Radio"]

module layout = Plotly.layout
module annotations = layout.annotations
module xaxis = layout.xaxis

let data' =
    [ 0 .. 3 ]
    |> List.collect (fun i ->
        [ data.scatter [
            scatter.x xData.[i]
            scatter.y yData.[i]
            scatter.mode.lines
            scatter.line [
                scatter.line.color plotColors.[i]
                scatter.line.width lineSize.[i]
            ]
          ]
          data.scatter [
            scatter.x xData.[i]
            scatter.y yData.[i]
            scatter.mode.markers
            scatter.marker [
                scatter.marker.color plotColors.[i]
                scatter.marker.size 12
            ]
          ] ])

let dataAnnotations =
    [ 0 .. xData.Length-1 ]
    |> List.collect (fun i ->
        [ layout.annotations [
            layout.annotations.xref.paper
            layout.annotations.y 0.05
            layout.annotations.y yData.[i].Head
            layout.annotations.xanchor.right
            layout.annotations.yanchor.middle
            layout.annotations.text (sprintf "%s %i%s" labels.[i] yData.[i].Head "%")
            layout.annotations.font [
                annotations.font.family "Arial"
                annotations.font.size 16
                annotations.font.color colors.black
            ]
            layout.annotations.showarrow false
          ]
          layout.annotations [
            layout.annotations.xref.paper
            layout.annotations.x 0.95
            layout.annotations.y yData.[i].[11]
            layout.annotations.xanchor.left
            layout.annotations.yanchor.middle
            layout.annotations.text (sprintf "%i%s" yData.[i].[11] "%")
            layout.annotations.font [
                annotations.font.family "Arial"
                annotations.font.size 16
                annotations.font.color colors.black
            ]
            layout.annotations.showarrow false
          ]  
        ])

let chart () =
    Plotly.plot [
        plot.data data'
        plot.layout [
            layout.showlegend false
            layout.autosize false
            layout.height 400
            layout.width 1300
            layout.xaxis [
                layout.xaxis.showline true
                layout.xaxis.showgrid false
                layout.xaxis.showticklabels true
                layout.xaxis.linecolor (colors.rgb(204, 204, 204))
                layout.xaxis.linewidth 2
                layout.xaxis.ticks.outside
                layout.xaxis.tickcolor (colors.rgb(204, 204, 204))
                layout.xaxis.tickwidth 2
                layout.xaxis.ticklen 5
                layout.xaxis.tickfont [
                    xaxis.tickfont.family "Arial"
                    xaxis.tickfont.size 12
                    xaxis.tickfont.color (colors.rgb(82, 82, 82))
                ]
            ]
            layout.yaxis [
                layout.yaxis.showgrid false
                layout.yaxis.zeroline false
                layout.yaxis.showline false
                layout.yaxis.showticklabels false
            ]
            layout.margin [
                layout.margin.l 100
                layout.margin.r 20
                layout.margin.t 100
            ]
            layout.annotations [
                layout.annotations.xref.paper
                layout.annotations.yref.paper
                layout.annotations.x 0.5
                layout.annotations.y 1.2
                layout.annotations.xanchor.center
                layout.annotations.yanchor.middle
                layout.annotations.text "Main Source for News"
                layout.annotations.font [
                    annotations.font.family "Arial"
                    annotations.font.size 30
                    annotations.font.color (colors.rgb(37, 37, 37))
                ]
                layout.annotations.showarrow false
            ]
            layout.annotations [
                layout.annotations.xref.paper
                layout.annotations.yref.paper
                layout.annotations.x 0.5
                layout.annotations.y -0.1
                layout.annotations.xanchor.center
                layout.annotations.yanchor.top
                layout.annotations.text "Source: Pew Research Center & Storytelling with data"
                layout.annotations.font [
                    annotations.font.family "Arial"
                    annotations.font.size 30
                    annotations.font.color (colors.rgb(150, 150, 150))
                ]
                layout.annotations.showarrow false
            ]
            yield! dataAnnotations
        ]
    ]
```