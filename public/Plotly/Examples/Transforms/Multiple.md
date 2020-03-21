# Feliz.Plotly - Multiple Transforms

Taken from [Plotly - Multiple Transforms](https://plot.ly/javascript/multiple-transforms/)

```fsharp:plotly-chart-transforms-multiple
[<RequireQualifiedAccess>]
module Samples.Transforms.Multiple

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CsvData =
    { Headers: string []
      Country: string []
      Year: int []
      Population: float []
      Continent: string []
      LifeExpectancy: float []
      GDPPerCapita: float [] }

    member this.AddDataSet (data: string []) =
        { this with
            Country = Array.append this.Country (data.[0] |> Array.singleton)
            Year = Array.append this.Year (data.[1] |> int |> Array.singleton)
            Population = Array.append this.Population (data.[2] |> float |> Array.singleton)
            Continent = Array.append this.Continent (data.[3] |> Array.singleton)
            LifeExpectancy = Array.append this.LifeExpectancy (data.[4] |> float |> Array.singleton)
            GDPPerCapita = Array.append this.GDPPerCapita (data.[5] |> float |> Array.singleton) }

module CsvData =
    let empty =
        { Headers = [||]
          Country = [||]
          Year = [||]
          Population = [||]
          Continent = [||]
          LifeExpectancy = [||]
          GDPPerCapita = [||] }

let render (data: CsvData) =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.mode.markers
                scatter.x data.LifeExpectancy
                scatter.y data.GDPPerCapita
                scatter.text data.Continent
                scatter.marker [
                    marker.size data.Population
                    marker.sizemode.area
                    marker.sizeref 200000
                ]
                scatter.transforms [
                    transforms.filter [
                        filter.target data.Year
                        filter.operation.eq
                        filter.value 2007
                    ]
                    transforms.groupby [
                        groupby.groups data.Continent
                        groupby.styles [
                            styles.style [
                                style.target "Asia"
                                style.value [
                                    scatter.marker [
                                        marker.color color.red
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Europe"
                                style.value [
                                    scatter.marker [
                                        marker.color color.blue
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Americas"
                                style.value [
                                    scatter.marker [
                                        marker.color color.orange
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Africa"
                                style.value [
                                    scatter.marker [
                                        marker.color color.green
                                    ]
                                ]
                            ]
                            styles.style [
                                style.target "Oceania"
                                style.value [
                                    scatter.marker [
                                        marker.color color.purple
                                    ]
                                ]
                            ]
                        ]
                    ]
                    transforms.aggregate [
                        aggregate.groups data.Continent
                        aggregate.aggregations [
                            aggregations.aggregation [
                                aggregation.target "x"
                                aggregation.func.avg
                                aggregation.enabled true
                            ]
                            aggregations.aggregation [
                                aggregation.target "y"
                                aggregation.func.avg
                                aggregation.enabled true
                            ]
                            aggregations.aggregation [
                                aggregation.target "marker.size"
                                aggregation.func.sum
                                aggregation.enabled true
                            ]
                        ]
                        aggregate.enabled true
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title "<b>Gapminder</b><br>2007 Average GDP Per Cap & Life Exp. by Continent"
            layout.yaxis [
                yaxis.type'.log
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CsvData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/gapminderDataFiveYear.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map (fun s -> 
                        let res = s.Trim().Split(',')

                        match (try res |> Array.take 2 |> Some with _ -> None) with
                        | Some [| elem1; elem2 |] when elem1.StartsWith('"') && elem2.EndsWith('"') ->
                            elem1.Remove(0,1) + (elem2.Remove(elem2.Length-1,1))
                            |> Array.singleton
                            |> Array.append 
                            <| (res.[2..])
                        | _ -> res)

                fullData
                |> Array.tail
                |> Array.fold (fun (state: CsvData) (values: string []) -> 
                    printfn "%A" values
                    state.AddDataSet values) content
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