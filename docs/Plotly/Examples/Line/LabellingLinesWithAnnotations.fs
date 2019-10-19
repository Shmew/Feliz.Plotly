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
        [ layout.annotations.annotation [
            annotation.xref.paper
            annotation.x 0.05
            annotation.y yData.[i].Head
            annotation.xanchor.right
            annotation.yanchor.middle
            annotation.text (sprintf "%s %i%s" labels.[i] yData.[i].Head "%")
            annotation.font [
                annotation.font.family "Arial"
                annotation.font.size 16
                annotation.font.color colors.black
            ]
            annotation.showarrow false
          ]
          layout.annotations.annotation [
            annotation.xref.paper
            annotation.x 0.95
            annotation.y yData.[i].[11]
            annotation.xanchor.left
            annotation.yanchor.middle
            annotation.text (sprintf "%i%s" yData.[i].[11] "%")
            annotation.font [
                annotation.font.family "Arial"
                annotation.font.size 16
                annotation.font.color colors.black
            ]
            annotation.showarrow false
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
                layout.annotations.annotation [
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.x 0.5
                    annotation.y 1.05
                    annotation.xanchor.center
                    annotation.yanchor.bottom
                    annotation.text "Main Source for News"
                    annotation.font [
                        annotation.font.family "Arial"
                        annotation.font.size 30
                        annotation.font.color (colors.rgb(37, 37, 37))
                    ]
                    annotation.showarrow false
                ]
                layout.annotations.annotation [
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.x 0.5
                    annotation.y -0.1
                    annotation.xanchor.center
                    annotation.yanchor.top
                    annotation.text "Source: Pew Research Center & Storytelling with data"
                    annotation.font [
                        annotation.font.family "Arial"
                        annotation.font.size 12
                        annotation.font.color (colors.rgb(150, 150, 150))
                    ]
                    annotation.showarrow false
                ]
                yield! dataAnnotations
            ]
        ]
    ]
