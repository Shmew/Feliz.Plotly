# Feliz.Plotly - Violin Plot

Taken from [Plotly - Violin Plot](https://plot.ly/javascript/violin/)

```fsharp:plotly-chart-violin-advanced
[<RequireQualifiedAccess>]
module Samples.Violin.Advanced

open Feliz
open Feliz.Plotly

let xData = 
    [ 10.07; 34.83; 10.65; 12.43; 24.08; 13.42; 12.48; 29.8; 14.52; 11.38; 20.27
      11.17; 12.26; 18.26; 8.51; 10.33; 14.15; 13.16; 17.47; 27.05; 16.43; 8.35
      18.64; 11.87; 19.81; 43.11; 13.0; 12.74; 13.0; 16.4; 16.47; 18.78 ]

let xData2 = 
    [ 27.2; 22.76; 17.29; 19.44; 16.66; 32.68; 15.98; 13.03; 18.28; 24.71; 21.16
      11.69; 14.26; 15.95; 8.52; 22.82; 19.08; 16.0; 34.3; 41.19; 9.78; 7.51
      28.44; 15.48; 16.58; 7.56; 10.34; 13.51; 18.71; 20.53 ]

let xData3 = 
    [ 5.75; 16.32; 22.75; 11.35; 15.38; 13.42; 15.98; 16.27; 10.09 ]

let xData4 = 
    [ 28.97; 22.49; 40.17; 27.28; 12.03; 21.01; 12.46; 12.16; 8.58; 13.42 ]

let xData5 = 
    [ 20.29; 15.77; 19.65; 15.06; 20.69; 16.93; 26.41; 16.45; 3.07; 17.07; 26.86
      25.28; 14.73; 44.3; 22.42; 20.92; 14.31; 7.25; 10.59; 10.63; 12.76; 13.27
      28.17; 12.9; 30.14; 22.12; 35.83; 27.18 ]

let xData6 = 
    [ 20.65; 17.92; 39.42; 19.82; 17.81; 13.37; 12.69; 21.7; 9.55; 18.35; 17.78
      24.06; 16.31; 18.69; 31.27; 16.04; 38.01; 11.24; 48.27; 20.29; 13.81; 11.02
      18.29; 17.59; 20.08; 20.23; 15.01; 12.02; 10.51; 17.92; 15.36; 20.49; 25.21
      18.24; 14.0; 50.81; 15.81; 26.59; 38.73; 24.27; 30.06; 25.89; 48.33; 28.15
      11.59; 7.74; 20.45; 13.28; 24.01; 15.69; 11.61; 10.77; 15.53; 10.07; 12.6
      32.83; 29.03; 22.67; 17.82 ]

let xData7 = 
    [ 16.99; 24.59; 35.26; 14.83; 10.33; 16.97; 10.29; 34.81; 25.71; 17.31; 29.85
      25.0; 13.39; 16.21; 17.51; 9.6; 20.9; 18.15 ]

let xData8 = 
    [ 10.34; 21.01; 23.68; 25.29; 8.77; 26.88; 15.04; 14.78; 10.27; 15.42; 18.43
      21.58; 16.29; 17.46; 13.94; 9.68; 30.4; 18.29; 22.23; 32.4; 28.55; 18.04
      12.54; 9.94; 25.56; 19.49; 38.07; 23.95; 29.93; 14.07; 13.13; 17.26; 24.55
      19.77; 48.17; 16.49; 21.5; 12.66; 13.81; 24.52; 20.76; 31.71; 7.25; 31.85
      16.82; 32.9; 17.89; 14.48; 34.63; 34.65; 23.33; 45.35; 23.17; 40.55; 20.69
      30.46; 23.1; 15.69 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.violin [
                violin.text "sample length: 32"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "F"
                violin.scalegroup "F"
                violin.points.all
                violin.pointpos 1
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#bebada"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.positive
                violin.name "F"
                violin.span 0
                violin.line [
                    line.color "#bebada"
                ]
                violin.y0 "Thursday"
                violin.x xData
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 30"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "M"
                violin.scalegroup "M"
                violin.points.all
                violin.pointpos -0.6
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#8dd3c7"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.negative
                violin.name "M"
                violin.span 0
                violin.line [
                    line.color "#8dd3c7"
                ]
                violin.y0 "Thursday"
                violin.x xData2
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 9"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "F"
                violin.scalegroup "F"
                violin.points.all
                violin.pointpos 0.4
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#bebada"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.positive
                violin.name "F"
                violin.span 0
                violin.line [
                    line.color "#bebada"
                ]
                violin.y0 "Friday"
                violin.x xData3
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 10"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "M"
                violin.scalegroup "M"
                violin.points.all
                violin.pointpos -0.3
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#8dd3c7"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.negative
                violin.name "M"
                violin.span 0
                violin.line [
                    line.color "#8dd3c7"
                ]
                violin.y0 "Friday"
                violin.x xData4
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 28"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "F"
                violin.scalegroup "F"
                violin.points.all
                violin.pointpos 0.55
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#bebada"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend true
                violin.side.positive
                violin.name "F"
                violin.span 0
                violin.line [
                    line.color "#bebada"
                ]
                violin.y0 "Saturday"
                violin.x xData5
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 59"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "M"
                violin.scalegroup "M"
                violin.points.all
                violin.pointpos -1.1
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#8dd3c7"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend true
                violin.side.negative
                violin.name "M"
                violin.span 0
                violin.line [
                    line.color "#8dd3c7"
                ]
                violin.y0 "Saturday"
                violin.x xData6
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 18"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "F"
                violin.scalegroup "F"
                violin.points.all
                violin.pointpos 0.45
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#bebada"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.positive
                violin.name "F"
                violin.span 0
                violin.line [
                    line.color "#bebada"
                ]
                violin.y0 "Sunday"
                violin.x xData7
                violin.orientation.h
            ]
            traces.violin [
                violin.text "sample length: 58"
                violin.hoveron [
                    violin.hoveron.points
                    violin.hoveron.kde
                ]
                violin.meanline [
                    meanline.visible true
                ]
                violin.legendgroup "M"
                violin.scalegroup "M"
                violin.points.all
                violin.pointpos -0.9
                violin.box [
                    box.visible.true'
                ]
                violin.jitter 0
                violin.scalemode.count
                violin.marker [
                    marker.line [
                        line.color "#8dd3c7"
                        line.width 2
                    ]
                    marker.symbol.lineNs
                ]
                violin.showlegend false
                violin.side.negative
                violin.name "M"
                violin.span 0
                violin.line [
                    line.color "#8dd3c7"
                ]
                violin.y0 "Sunday"
                violin.x xData8
                violin.orientation.h
            ]
        ]
        plot.layout [
            layout.hovermode.closest
            layout.height 700
            layout.width 600
            layout.yaxis [
                yaxis.showgrid true
            ]
            layout.title [
                title.text "Total bill distribution<br><i>scaled by number of bills per gender"
            ]
            layout.legend [
                legend.tracegroupgap 0
            ]
            layout.violingap 0
            layout.violingroupgap 0
            layout.violinmode.overlay
        ]
    ]
```