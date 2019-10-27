[<RequireQualifiedAccess>]
module Samples.PointCloud.Advanced

open Fable.Core
open Feliz
open Feliz.Plotly
open System

let pointCount = 1e6
let scaleX = 2000.
let scaleY = 1000.
let speed = 0.3

let pseudoGaussian () =
    let rng = Random()
    [0..5]
    |> List.sumBy (fun _ -> rng.NextDouble())
    |> (-) 3.

let dataGenerator sd =
    let f = 20. / 360. * 2. * Math.PI
    let sin = Math.Sin f
    let cos = Math.Cos f

    [(0.)..pointCount]
    |> List.collect (fun _ ->
        let x = scaleX * pseudoGaussian() * sd
        let y = scaleY * pseudoGaussian() * sd

        [ x * cos - y * sin + scaleX * 0.5
          x * sin + y * cos + scaleY * 0.5 ])

let geom = dataGenerator(0.2)

let indicies = [|0..(pointCount - 1. |> int)|]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.pointcloud [
                pointcloud.marker [
                    marker.sizemin 0.05
                    marker.sizemax 30
                    marker.color colors.darkBlue
                    marker.opacity 1
                    marker.blend true
                ]
                pointcloud.opacity 1
                pointcloud.xy (dataGenerator(0.2))
                pointcloud.indices indicies
                pointcloud.xbounds [ 0.; scaleX ]
                pointcloud.ybounds [ 0.; scaleY ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Point Cloud - updating 1 million points in every single frame"
            ]
            layout.autosize false
            layout.width 1000
            layout.height 600
            layout.hovermode.false'
            layout.dragmode.pan
        ]
    ]
