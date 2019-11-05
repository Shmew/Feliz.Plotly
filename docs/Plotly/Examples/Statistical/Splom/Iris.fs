[<RequireQualifiedAccess>]
module Samples.Splom.Iris

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type IrisData =
    { Headers: string []
      SepalLength: float [] 
      SepalWidth: float []
      PetalLength: float []
      PetalWidth: float []
      Class: string [] }
    member this.AddDataSet (data: string []) =
        { this with
            SepalLength = Array.append this.SepalLength (data.[0] |> float |> Array.singleton)
            SepalWidth = Array.append this.SepalWidth (data.[1] |> float |> Array.singleton)
            PetalLength = Array.append this.PetalLength (data.[2] |> float |> Array.singleton)
            PetalWidth = Array.append this.PetalWidth (data.[3] |> float |> Array.singleton)
            Class = Array.append this.Class (data.[4] |> Array.singleton) }

module IrisData =
    let empty =
        { Headers = [||]
          SepalLength = [||]
          SepalWidth = [||]
          PetalLength = [||]
          PetalWidth = [||]
          Class = [||] }

let render (data: IrisData) =
    JS.console.log (data.Class)
    let plotColors =
        data.Class
        |> Array.map (fun c ->
            match c.Trim() with
            | "Iris-setosa" -> 0.
            | "Iris-versicolor" -> 0.5
            | "Iris-virginica" -> 1.
            | _ -> failwith "Check your data")

    let plotColorcale =
        [ ["0.0"; "#19d3f3"]
          ["0.333"; "#19d3f3"]
          ["0.333"; "#e763fa"]
          ["0.666"; "#e763fa"]
          ["0.666"; "#636efa"]
          ["1.0"; "#636efa"] ]

    Plotly.plot [
        plot.traces [
            traces.splom [
                splom.dimensions [
                    dimensions.dimension [
                        dimension.label "sepal length"
                        dimension.values data.SepalLength
                    ]
                    dimensions.dimension [
                        dimension.label "sepal width"
                        dimension.values data.SepalWidth
                    ]
                    dimensions.dimension [
                        dimension.label "petal length"
                        dimension.values data.PetalLength
                    ]
                    dimensions.dimension [
                        dimension.label "petal width"
                        dimension.values data.PetalWidth
                    ]
                ]
                splom.text data.Class
                splom.marker [
                    marker.color plotColors
                    marker.colorscale plotColorcale
                    marker.size 7
                    marker.line [
                        line.color color.white
                        line.width 0.5
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Iris Data set"
            ]
            layout.height 800
            layout.width 800
            layout.autosize false
            layout.hovermode.closest
            layout.dragmode.select
            layout.plotBgcolor (color.rgba(240, 240, 240, 0.95))
            layout.xaxis [
                xaxis.showline false
                xaxis.zeroline false
                xaxis.gridcolor "#ffff"
                xaxis.ticklen 4
            ]
            layout.yaxis [
                yaxis.showline false
                yaxis.zeroline false
                yaxis.gridcolor "#ffff"
                yaxis.ticklen 4
            ]
            layout.xaxis2 [
                xaxis2.showline false
                xaxis2.zeroline false
                xaxis2.gridcolor "#ffff"
                xaxis2.ticklen 4
            ]
            layout.yaxis2 [
                yaxis2.showline false
                yaxis2.zeroline false
                yaxis2.gridcolor "#ffff"
                yaxis2.ticklen 4
            ]
            layout.xaxis3 [
                xaxis3.showline false
                xaxis3.zeroline false
                xaxis3.gridcolor "#ffff"
                xaxis3.ticklen 4
            ]
            layout.yaxis3 [
                yaxis3.showline false
                yaxis3.zeroline false
                yaxis3.gridcolor "#ffff"
                yaxis3.ticklen 4
            ]
            layout.xaxis4 [
                xaxis4.showline false
                xaxis4.zeroline false
                xaxis4.gridcolor "#ffff"
                xaxis4.ticklen 4
            ]
            layout.yaxis4 [
                yaxis4.showline false
                yaxis4.zeroline false
                yaxis4.gridcolor "#ffff"
                yaxis4.ticklen 4
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState IrisData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/iris-data.csv"

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
                |> Array.fold (fun (state: IrisData) (values: string []) -> state.AddDataSet values) content
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
