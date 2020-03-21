# Feliz.Plotly - 3D Scatter Plots

Taken from [Plotly - 3D Scatter Plots](https://plot.ly/javascript/3d-scatter-plots/)

```fsharp:plotly-chart-3d-scatter
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Scatter

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CsvData =
    { Headers: string []
      X1: float []
      Y1: float []
      Z1: float []
      X2: float option []
      Y2: float option []
      Z2: float option [] }

    member this.AddDataSet (data: string []) =
        let emptyToNoneFloat input = 
            try float input |> Some 
            with _ -> None

        { this with
            X1 = Array.append this.X1 (data.[0] |> float |> Array.singleton)
            Y1 = Array.append this.Y1 (data.[1] |> float |> Array.singleton)
            Z1 = Array.append this.Z1 (data.[2] |> float |> Array.singleton)
            X2 = Array.append this.X2 (data.[3] |> emptyToNoneFloat |> Array.singleton)
            Y2 = Array.append this.Y2 (data.[4] |> emptyToNoneFloat |> Array.singleton)
            Z2 = Array.append this.Z2 (data.[5] |> emptyToNoneFloat |> Array.singleton) }

module CsvData =
    let empty =
        { Headers = [||]
          X1 = [||]
          Y1 = [||]
          Z1 = [||]
          X2 = [||]
          Y2 = [||]
          Z2 = [||] }

let render (data: CsvData) =
    Plotly.plot [
        plot.traces [
            traces.scatter3d [
                scatter3d.x data.X1
                scatter3d.y data.Y1
                scatter3d.z data.Z1
                scatter3d.mode.markers
                scatter3d.marker [
                    marker.size 12
                    marker.line [
                        line.color (color.rgba(217, 217, 217, 0.14))
                        line.width 0.5
                    ]
                    marker.opacity 0.8
                ]
            ]
            traces.scatter3d [
                scatter3d.x data.X2
                scatter3d.y data.Y2
                scatter3d.z data.Z2
                scatter3d.mode.markers
                scatter3d.marker [
                    marker.color (color.rgb(127, 127, 127))
                    marker.size 12
                    marker.symbol.circle
                    marker.line [
                        line.color (color.rgb(204, 204, 204))
                        line.width 1
                    ]
                    marker.opacity 0.8
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CsvData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/3d-scatter.csv"

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