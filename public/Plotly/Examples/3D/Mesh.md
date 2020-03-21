# Feliz.Plotly - 3D Mesh Plots

Taken from [Plotly - 3D Mesh Plots](https://plot.ly/javascript/3d-mesh/)

```fsharp:plotly-chart-3d-mesh
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Mesh

open Feliz
open Feliz.Plotly

let rng = System.Random()

let xData,yData,zData =
    [ 0 .. 49 ]
    |> List.fold (fun (x,y,z) _ ->
        (rng.NextDouble()::x,rng.NextDouble()::y,rng.NextDouble()::z)
    ) ([],[],[])

let chart () =
    Plotly.plot [
        plot.traces [
            traces.mesh3d [
                mesh3d.opacity 0.8
                mesh3d.color (color.rgb(300, 100, 200))
                mesh3d.x xData
                mesh3d.y yData
                mesh3d.z zData
            ]
        ]
    ]
```