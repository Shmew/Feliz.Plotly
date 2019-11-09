# Feliz.Plotly - Carpet Plots

Taken from [Plotly - Carpet Plots](https://plot.ly/javascript/carpet-plot/)

```fsharp:plotly-chart-carpet-styleaandbaxis
[<RequireQualifiedAccess>]
module Samples.Carpet.StyleAAndBAxis

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.carpet [
                carpet.a [ 4.;  4.;  4.;  4.5;  4.5;  4.5;  5.;  5.;  5.;  6.;  6.;  6. ]
                carpet.b [ 1;  2;  3;  1;  2;  3;  1;  2;  3;  1;  2;  3 ]
                carpet.y [ 2.;  3.5;  4.;  3.;  4.5;  5.;  5.5;  6.5;  7.5;  8.;  8.5;  10. ]
                carpet.aaxis [
                    aaxis.tickprefix "a = "
                    aaxis.ticksuffix "m"
                    aaxis.smoothing 1
                    aaxis.minorgridcount 9
                    aaxis.minorgridcolor color.white
                    aaxis.gridcolor color.white
                    aaxis.color color.white
                ]
                carpet.baxis [
                    baxis.tickprefix "b = "
                    baxis.ticksuffix "Pa"
                    baxis.smoothing 1
                    baxis.minorgridcount 9
                    baxis.minorgridcolor color.white
                    baxis.gridcolor color.white
                    baxis.color color.white
                ]
            ]
        ]
        plot.layout [
            layout.plotBgcolor color.black
            layout.paperBgcolor color.black
        ]
    ]
```
