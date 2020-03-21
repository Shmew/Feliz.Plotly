# Feliz.Plotly - 3D Line Plots

Taken from [Plotly - 3D Line Plots](https://plot.ly/javascript/3d-line-plots/)

```fsharp:plotly-chart-3d-line
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Line

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CsvData =
    { Headers: string []
      X: float []
      Y: float []
      Z: float []
      Colors: int [] }

    member this.AddDataSet (data: string []) =
        { this with
            X = Array.append this.X (data.[0] |> float |> Array.singleton)
            Y = Array.append this.Y (data.[1] |> float |> Array.singleton)
            Z = Array.append this.Z (data.[2] |> float |> Array.singleton)
            Colors = Array.append this.Colors (data.[3] |> int |> Array.singleton) }

module CsvData =
    let empty =
        { Headers = [||]
          X = [||]
          Y = [||]
          Z = [||]
          Colors = [||] }

let render (data: CsvData) =
    Plotly.plot [
        plot.traces [
            traces.scatter3d [
                scatter3d.mode.lines
                scatter3d.x data.X
                scatter3d.y data.Y
                scatter3d.z data.Z
                scatter3d.opacity 1
                scatter3d.line [
                    line.width 6
                    line.color data.Colors
                    line.reversescale false
                ]
            ]
        ]
        plot.layout [
            layout.height 640
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CsvData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/3d-line1.csv"

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