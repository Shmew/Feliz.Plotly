# Feliz.Plotly - Tri-Surf Plots

Taken from [Plotly - Tri-Surf Plots](https://plot.ly/javascript/trisurf/)

```fsharp:plotly-chart-3d-trisurf
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.TriSurf

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.mesh3d [
                mesh3d.x [ 0; 1; 0; 0 ]
                mesh3d.y [ 0; 0; 1; 0 ]
                mesh3d.z [ 0; 0; 0; 1 ]
                mesh3d.i [ 0; 0; 0; 1 ]
                mesh3d.j [ 1; 2; 3; 2 ]
                mesh3d.k [ 2; 3; 1; 3 ]
                mesh3d.facecolor [
                    color.rgb(0, 0, 0)
                    color.rgb(255, 0, 0)
                    color.rgb(0, 255, 0)
                    color.rgb(0, 0, 255)
                ]
                mesh3d.flatshading true
            ]
        ]
    ]
```