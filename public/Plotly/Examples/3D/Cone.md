# Feliz.Plotly - 3D Cone Plots

Taken from [Plotly - 3D Cone Plots](https://plot.ly/javascript/cone-plot/)

```fsharp:plotly-chart-3d-cone
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Cone

open Feliz
open Feliz.Plotly

let chart () =
    let plotTraces =
        [ "base", 1, []
          "opacity:0.3", 2, [ cone.opacity 0.3 ]
          "lighting.ambient:0.3", 3, [ cone.lighting [ lighting.ambient 0.3 ] ]
          "lighting.diffuse:0.3", 4, [ cone.lighting [ lighting.diffuse 0.3 ] ]
          "lighting.specular:2", 5, [ cone.lighting [ lighting.specular 2 ] ]
          "lighting.roughness:1", 6, [ cone.lighting [ lighting.roughness 1 ] ] 
          "lighting.fresnel:2", 7, [ cone.lighting [ lighting.fresnel 2 ] ]
          "lighting.position x:0,y:0,z:1e5", 8, 
          [ cone.lightposition [  
                lightposition.x 0
                lightposition.y 0
                lightposition.z 1e5 ] ] ]
        |> List.map (fun (name, i, props) ->
            traces.cone [
                cone.name name
                cone.x (List.replicate 3 i)
                cone.y [ 1; 2; 3 ]
                cone.z [ 1; 1; 1 ]
                cone.u [ 1; 2; 3 ]
                cone.v [ 1; 1; 2 ]
                cone.w [ 4; 4; 1 ]
                cone.hoverinfo [
                    cone.hoverinfo.u
                    cone.hoverinfo.v
                    cone.hoverinfo.w
                    cone.hoverinfo.name
                ]
                cone.showscale false
                yield! props
            ])

    Plotly.plot [
        plot.traces plotTraces
        plot.layout [
            layout.scene [
                scene.aspectmode.data
                scene.camera [
                    camera.eye [
                        eye.x 0.05
                        eye.z -2.6
                        eye.z 2
                    ]
                ]
            ]
            layout.width 500
            layout.height 500
        ]
    ]
```