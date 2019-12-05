# Feliz.Plotly - Point Cloud

Taken from [Plotly - Point Cloud](https://plot.ly/javascript/pointcloud/)

```fsharp:plotly-chart-pointcloud-basic
[<RequireQualifiedAccess>]
module Samples.PointCloud.Basic

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pointcloud [
                pointcloud.xy [ 1; 2; 3; 4; 5; 6; 0; 4 ]
            ]
        ]
    ]
```