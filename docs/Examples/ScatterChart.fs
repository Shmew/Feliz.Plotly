[<RequireQualifiedAccess>]
module Samples.ScatterChart

open Feliz
open Feliz.Plotly
open Fable.Core.Experimental

let xData =
    [ 2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2013 ]
    |> List.replicate 4

let yData =
    [ [ 74; 82; 80; 74; 73; 72; 74; 70; 70; 66; 66; 69 ]
      [ 45; 42; 50; 46; 36; 36; 34; 35; 32; 31; 31; 28 ]
      [ 13; 14; 20; 24; 20; 24; 24; 40; 35; 41; 43; 50 ]
      [ 18; 21; 18; 21; 16; 14; 13; 18; 17; 16; 19; 23 ] ]

//let colors = 
//    [ colors.rgb(67,67,67)
//      colors.rgb(115,115,115)
//      colors.rgb(49,130,189)
//      colors.rgb(189,189,189) ]

Plotly.plot [
    Plot.data [
        data.scatter [
            data.scatter.line [
                data.scatter.line.color (colors.rgb(67, 67, 67))
                data.scatter.line.width 2.    
            ]
            data.scatter.x <| xData.[0]
            data.scatter.y <| yData.[0]
            // need to implement implicit scatter type I think
            data.scatter.mode [ "lines" ]
        ]
    ]
    Plot.layout [
        layout.xaxis [
            layout.xaxis.showline true
            layout.xaxis.showgrid false
            layout.xaxis.showticklabels true
            layout.xaxis.linecolor <| colors.rgb(204,204,204)
            layout.xaxis.linewidth 2
            layout.xaxis.ticks.outside
            layout.xaxis.tickcolor <| colors.rgb(204,204,204)
            layout.xaxis.tickwidth 2
            layout.xaxis.tickfont [
                layout.xaxis.tickfont.color <| colors.rgb(82,82,82)
                layout.xaxis.tickfont.family "Arial"
                layout.xaxis.tickfont.size 12
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
        layout.showlegend false
        layout.height 400
        layout.width 1300
        layout.autosize false
    ]
]
