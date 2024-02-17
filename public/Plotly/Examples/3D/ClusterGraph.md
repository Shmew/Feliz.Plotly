# Feliz.Plotly - 3D Cluster Graph

Taken from [Plotly - 3D Cluster Graph](https://plot.ly/javascript/3d-point-clustering/)

```fsharp:plotly-chart-3d-clustergraph
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.ClusterGraph

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CsvData =
    { Headers: string []
      X: float []
      Y: float []
      Z: float [] }

    member this.AddDataSet (data: string []) =
        { this with
            X = Array.append this.X (data.[0] |> float |> Array.singleton)
            Y = Array.append this.Y (data.[1] |> float |> Array.singleton)
            Z = Array.append this.Z (data.[2] |> float |> Array.singleton) }

module CsvData =
    let empty =
        { Headers = [||]
          X = [||]
          Y = [||]
          Z = [||] }

let render (data: CsvData) =
    Plotly.plot [
        plot.traces [
            traces.scatter3d [
                scatter3d.x data.X
                scatter3d.y data.Y
                scatter3d.z data.Z
                scatter3d.mode.markers
                scatter3d.marker [
                    marker.color.rgb (23, 190, 207)
                    marker.size 2
                ]
            ]
            traces.mesh3d [
                mesh3d.alphahull 7
                mesh3d.opacity 0.1
                mesh3d.x data.X
                mesh3d.y data.Y
                mesh3d.z data.Z
            ]
        ]
        plot.layout [
            layout.autosize true
            layout.height 400
            layout.scene [
                scene.aspectratio [
                    aspectratio.x 1
                    aspectratio.y 1
                    aspectratio.z 1
                ]
                scene.camera [
                    camera.center [
                        center.x 0
                        center.y 0
                        center.z 0
                    ]
                    camera.eye [
                        eye.x 1.25
                        eye.y 1.25
                        eye.z 1.25
                    ]
                    camera.up [
                        up.x 0
                        up.y 0
                        up.z 1
                    ]
                ]
                scene.xaxis [
                    xaxis.type'.linear
                    xaxis.zeroline false
                ]
                scene.yaxis [
                    yaxis.type'.linear
                    yaxis.zeroline false
                ]
                scene.zaxis [
                    zaxis.type'.linear
                    zaxis.zeroline false
                ]
            ]
            layout.title "3D Point Clustering"
            layout.width 477
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CsvData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/alpha_shape.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map (fun s -> s.Split(','))

                fullData
                |> Array.tail
                |> Array.fold (fun (state: CsvData) (values: string []) -> state.AddDataSet values) content
                |> fun newContent -> { newContent with Headers = fullData |> Array.head }
                |> setContent
                setError(None)
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    React.useEffect(loadDataset, [| path :> obj |])

    match isLoading, error with
    | true, _ -> input.centeredSpinner
    | false, None -> render content
    | _, Some error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ])

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```
