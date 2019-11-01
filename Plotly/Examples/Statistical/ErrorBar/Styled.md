# Feliz.Plotly - Error Bars

Taken from [Plotly - Error Bars](https://plot.ly/javascript/error-bars/)

```fsharp:plotly-chart-errorbar-styled
[<RequireQualifiedAccess>]
module Samples.ErrorBar.Styled

open Feliz
open Feliz.Plotly

let linspace min max n = 
    let bw = (max - min) / (float n - 1.)
    List.init n <| (float >> (fun  num -> num * bw) >> ((+) min))

let theoX = linspace -4. 4. 100

let sincx = 
    theoX
    |> List.map (fun x -> System.Math.Sin(x) / x)

let dataX = [ -3.8; -3.03; -1.91; -1.46; -0.89; -0.24; -0.0; 0.41; 0.89; 1.01; 1.91; 2.28; 2.79; 3.56 ]
let dataY = [ -0.02; 0.04; -0.01; -0.27; 0.36; 0.75; 1.03; 0.65; 0.28; 0.02; -0.11; 0.16; 0.04; -0.15 ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x theoX
                scatter.y sincx
                scatter.name "sinc(x)"
            ]
            traces.scatter [
                scatter.x dataX
                scatter.y dataY
                scatter.mode.markers
                scatter.name "measured"
                scatter.errorY [
                    errorY.type'.constant
                    errorY.value 0.1
                    errorY.color "#85144B"
                    errorY.thickness 1.5
                    errorY.width 3
                ]
                scatter.errorX [
                    errorX.type'.constant
                    errorX.value 0.2
                    errorX.color "#85144B"
                    errorX.thickness 1.5
                    errorX.width 3
                ]
                scatter.marker [
                    marker.color "#85144B"
                    marker.size 8
                ]
            ]
        ]
    ]
```