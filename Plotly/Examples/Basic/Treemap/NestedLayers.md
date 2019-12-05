# Feliz.Plotly - Treemaps

Taken from [Plotly - Treemaps](https://plot.ly/javascript/treemaps/)

```fsharp:plotly-chart-treemap-nestedlayers
[<RequireQualifiedAccess>]
module Samples.Treemap.NestedLayers

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CoffeeData =
    { Ids: string [] 
      Labels: string []
      Parents: string [] }
    member this.AddDataSet (data: string []) =
        { this with
            Ids = Array.append this.Ids (data.[0] |> Array.singleton)
            Labels = Array.append this.Labels (data.[1] |> Array.singleton)
            Parents = Array.append this.Parents (data.[2] |> Array.singleton) }

module CoffeeData =
    let empty =
        { Ids = [||] 
          Labels = [||]
          Parents = [||] }

let render (data: CoffeeData)  =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.ids data.Ids
                treemap.labels data.Labels
                treemap.parents data.Parents
            ]
        ]
        plot.layout [
            layout.width 1000
            layout.height 700
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CoffeeData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/coffee-flavors.csv"

    React.useEffect(fun _ ->
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText.Trim().Split('\n') 
                |> Array.map (fun s -> s.Split(','))
                |> Array.tail
                |> Array.fold (fun (state: CoffeeData) (values: string []) -> state.AddDataSet values) content
                |> setContent
                setError(None)
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

        React.createDisposable(ignore)
    ,path)

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