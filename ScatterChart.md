# Feliz.Plotly - Line and Scatter Plot

Taken from [Plotly - Line and Scatter Plot](https://plot.ly/javascript/line-and-scatter/)

```fsharp:plotly-examples-scatterchart
[<RequireQualifiedAccess>]
module Samples.ScatterChart

open Feliz
open Feliz.Plotly
open Fable.Core.Experimental

let chart () =
    Plotly.plot [
        plot.data [
            data.scatter [
                data.scatter.x [ 1; 2; 3; 4]
                data.scatter.y [ 10; 15; 13; 17 ]
                data.scatter.mode [ "markers" ]
            ]
            data.scatter [
                data.scatter.x [ 2; 3; 4; 5 ]
                data.scatter.y [ 16; 5; 11; 9 ]
                data.scatter.mode [ "lines" ]
            ]
            data.scatter [
                data.scatter.x [ 1; 2; 3; 4 ]
                data.scatter.y [ 12; 9; 15; 12 ]
                data.scatter.mode [ "lines+markers" ]
            ]
        ]
    ]
```