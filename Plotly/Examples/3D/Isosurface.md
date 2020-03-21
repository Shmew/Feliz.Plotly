# Feliz.Plotly - 3D Isosurface Plots

Taken from [Plotly - 3D Isosurface Plots](https://plot.ly/javascript/3d-isosurface-plots/)

```fsharp:plotly-chart-3d-isosurface
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Isosurface

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

let render (data: float [] []) =
    Plotly.plot [
        plot.traces [
            traces.isosurface [
                isosurface.x data.[0]
                isosurface.y data.[1]
                isosurface.z data.[2]
                isosurface.value data.[3]
                isosurface.isomin -1
                isosurface.isomax 10
                isosurface.surface [
                    surface.show true
                    surface.count 4
                    surface.fill 1
                    surface.pattern.odd
                ]
                isosurface.caps [
                    caps.x [
                        x.show true
                    ]
                    caps.y [
                        y.show true
                    ]
                    caps.z [
                        z.show true
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.scene [
                scene.camera [
                    camera.eye [
                        eye.x 1.86
                        eye.y 0.61
                        eye.z 0.98
                    ]
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState [||]
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/clebsch-cubic.csv"

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
                |> Array.map (Array.tail >> (Array.map float))
                |> Array.transpose
                |> setContent
                setError(None)
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    React.useEffect(loadDataset, [| path :> obj |])

    match isLoading, error with
    | true, _ -> input.centeredSpinner
    | false, None when Array.isEmpty content |> not -> render content
    | _, Some error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ]
    | _ -> Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text "Failed to load data."
        ])

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```