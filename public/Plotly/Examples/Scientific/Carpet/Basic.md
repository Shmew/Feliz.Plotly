# Feliz.Plotly - Carpet Plots

Taken from [Plotly - Carpet Plots](https://plot.ly/javascript/carpet-plot/)

```fsharp:plotly-chart-carpet-basic
[<RequireQualifiedAccess>]
module Samples.Carpet.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.carpet [
                carpet.a [ 4.;  4.;  4.;  4.5;  4.5;  4.5;  5.;  5.;  5.;  6.;  6.;  6. ]
                carpet.b [ 1;  2;  3;  1;  2;  3;  1;  2;  3;  1;  2;  3 ]
                carpet.y [ 2.;  3.5;  4.;  3.;  4.5;  5.;  5.5;  6.5;  7.5;  8.;  8.5;  10. ]
            ]
        ]
    ]
```