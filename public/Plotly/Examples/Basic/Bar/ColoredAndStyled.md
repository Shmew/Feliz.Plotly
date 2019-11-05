# Feliz.Plotly - Bar Charts

Taken from [Plotly - Bar Charts](https://plot.ly/javascript/bar-charts/)

```fsharp:plotly-chart-bar-coloredandstyled
[<RequireQualifiedAccess>]
module Samples.Bar.ColoredAndStyled

open Feliz
open Feliz.Plotly

let xData = [ 1995; 1996; 1997; 1998; 1999; 2000; 2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2012 ]
let yData = [ 219; 146; 112; 127; 124; 180; 236; 207; 236; 263; 350; 430; 474; 526; 488; 537; 500; 439 ]
let yData2 = [ 16; 13; 10; 11; 28; 37; 43; 55; 56; 88; 105; 156; 270; 299; 340; 403; 549; 499 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x xData
                bar.y yData
                bar.marker [
                    marker.color (color.rgb(55, 83, 109))
                ]
                bar.name "Rest of World"
            ]
            traces.bar [
                bar.x xData
                bar.y yData2
                bar.marker [
                    marker.color (color.rgb(26, 118, 255))
                ]
                bar.name "China"
            ]
        ]
        plot.layout [
            layout.title [
                title.text "US Export of Plastic Scrap"
            ]
            layout.xaxis [
                xaxis.tickfont [
                    tickfont.size 14
                    tickfont.color (color.rgb(107, 107, 107))
                ]
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "USD (millions)"
                    title.font [
                        font.size 16
                        font.color (color.rgb(107, 107, 107))
                    ]
                ]
                yaxis.tickfont [ 
                    tickfont.size 16
                    tickfont.color (color.rgb(107, 107, 107))
                ]
            ]
            layout.legend [
                legend.x 0
                legend.y 1.
                legend.bgcolor (color.rgba(255, 255, 255, 0.))
                legend.bordercolor (color.rgba(255, 255, 255, 0.))
            ]
            layout.barmode.group
            layout.bargap 0.15
            layout.bargroupgap 0.1
        ]
    ]
```