# Feliz.Plotly - 3D Streamtube Plots

Taken from [Plotly - 3D Streamtube Plots](https://plot.ly/javascript/streamtube-plot/)

```fsharp:plotly-chart-3d-streamtube
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Streamtube

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

let render (data: float [] []) =
    let startsX = Array.replicate 16 80
    
    let startsY = 
        Array.replicate 4 [| 20 .. 10 .. 50 |] 
        |> Array.concat
    
    let startsZ =
        Array.replicate 4 (Array.replicate 4 0) 
        |> Array.mapi (fun i aList -> 
            aList |> Array.map (fun _ -> i * 5))
        |> Array.concat

    Plotly.plot [
        plot.traces [
            traces.streamtube [
                streamtube.x data.[3]
                streamtube.y data.[4]
                streamtube.z data.[5]
                streamtube.u data.[0]
                streamtube.v data.[1]
                streamtube.w data.[2]
                
                streamtube.starts [
                    starts.x startsX
                    starts.y startsY
                    starts.z startsZ
                ]
                streamtube.sizeref 0.3
                streamtube.colorscale color.colorscale.portland
                streamtube.showscale false
                streamtube.maxdisplayed 3000
            ]
        ]
        plot.layout [
            layout.scene [
                scene.aspectratio [
                    aspectratio.x 2
                    aspectratio.y 1
                    aspectratio.z 0.3
                ]
            ]
            layout.margin [
                margin.t 20
                margin.b 20
                margin.l 20
                margin.r 20
            ]
            layout.width 600
            layout.height 400
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState [||]
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/streamtube-wind.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map (fun s -> s.Trim().Split(','))

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

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}```