[<RequireQualifiedAccess>]
module Samples.Bar.ColoredAndStyled

open Feliz
open Feliz.Plotly

let xData = [ 1995; 1996; 1997; 1998; 1999; 2000; 2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2012 ]
let yData = [ 219; 146; 112; 127; 124; 180; 236; 207; 236; 263; 350; 430; 474; 526; 488; 537; 500; 439 ]
let yData2 = [ 16; 13; 10; 11; 28; 37; 43; 55; 56; 88; 105; 156; 270; 299; 340; 403; 549; 499 ]

module xaxis = Plotly.layout.xaxis
module yaxis = Plotly.layout.yaxis
module title = Plotly.layout.yaxis.title

let chart () =
    Plotly.plot [
        plot.data [
            data.bar [
                bar.x xData
                bar.y yData
                bar.marker [
                    bar.marker.color (colors.rgb(55, 83, 109))
                ]
                bar.name "Rest of World"
            ]
            data.bar [
                bar.x xData
                bar.y yData2
                bar.marker [
                    bar.marker.color (colors.rgb(26, 118, 255))
                ]
                bar.name "China"
            ]
        ]
        plot.layout [
            layout.title [
                layout.title.text "US Export of Plastic Scrap"
            ]
            layout.xaxis [
                layout.xaxis.tickfont [
                    xaxis.tickfont.size 14
                    xaxis.tickfont.color (colors.rgb(107, 107, 107))
                ]
            ]
            layout.yaxis [
                layout.yaxis.title [
                    yaxis.title.text "USD (millions)"
                    yaxis.title.font [
                        title.font.size 16
                        title.font.color (colors.rgb(107, 107, 107))
                    ]
                    //yaxis.tickfont [  // Having trouble resolving the namespace
                    //    tickfont.size 16
                    //    tickfont.color (colors.rgb(107, 107, 107))
                    //]
                ]
            ]
            layout.legend [
                layout.legend.x 0
                layout.legend.y 1.
                layout.legend.bgcolor (colors.rgba(255, 255, 255, 0.))
                layout.legend.bordercolor (colors.rgba(255, 255, 255, 0.))
            ]
            layout.bar [
                bar.barmode.group
                bar.bargap 0.15
                bar.bargroupgap 0.1
            ]
        ]
    ]
