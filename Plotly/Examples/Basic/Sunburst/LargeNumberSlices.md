# Feliz.Plotly - Sunburst Charts

Taken from [Plotly - Sunburst Charts](https://plot.ly/javascript/sunburst-charts/)

```fsharp:plotly-chart-sunburst-largenumberslices
[<RequireQualifiedAccess>]
module Samples.Sunburst.LargeNumberSlices

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
            traces.sunburst [
                sunburst.maxdepth 3
                sunburst.ids data.Ids
                sunburst.labels data.Labels
                sunburst.parents data.Parents
            ]
        ]
        plot.layout [
            layout.margin [
                margin.l 0
                margin.r 0
                margin.b 0
                margin.t 0
            ]
            layout.sunburstcolorway [
                "#636efa"
                "#EF553B"
                "#00cc96"
                "#ab63fa"
                "#19d3f3"
                "#e763fa"
                "#FECB52"
                "#FFA15A"
                "#FF6692"
                "#B6E880"
            ]
            layout.extendsunburstcolors true
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CoffeeData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/coffee-flavors.csv"

    let loadDataset() = 
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