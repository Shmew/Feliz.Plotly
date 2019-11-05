# Feliz.Plotly - Tables

Taken from [Plotly - Tables](https://plot.ly/javascript/table/)

```fsharp:plotly-chart-table-fromcsv
[<RequireQualifiedAccess>]
module Samples.Table.FromCSV

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type BTCMiningData =
    { Headers: string []
      Ids: int [] 
      Date: string []
      NumberTransactions: int []
      OutputVolue: int []
      MarketPrice: int []
      HashRate: int []
      CostPerTransactionUSD: int []
      MiningRevenueUSD: int []
      TransactionFeesBTC: int [] }
    member this.AddDataSet (data: string []) =
        { this with
            Ids = Array.append this.Ids (data.[0] |> int |> Array.singleton)
            Date = Array.append this.Date (data.[1].Substring(0,10) |> Array.singleton)
            NumberTransactions = Array.append this.NumberTransactions (data.[2] |> int |> Array.singleton)
            OutputVolue = Array.append this.OutputVolue (data.[3] |> int |> Array.singleton)
            MarketPrice = Array.append this.MarketPrice (data.[4] |> int |> Array.singleton)
            HashRate = Array.append this.HashRate (data.[5] |> int |> Array.singleton)
            CostPerTransactionUSD = Array.append this.CostPerTransactionUSD (data.[6] |> int |> Array.singleton)
            MiningRevenueUSD = Array.append this.MiningRevenueUSD (data.[7] |> int |> Array.singleton)
            TransactionFeesBTC = Array.append this.TransactionFeesBTC (data.[8] |> int |> Array.singleton) }

    member this.Values =
        [ PlotData.Int this.Ids
          PlotData.String this.Date
          PlotData.Int this.NumberTransactions
          PlotData.Int this.OutputVolue
          PlotData.Int this.MarketPrice
          PlotData.Int this.HashRate
          PlotData.Int this.CostPerTransactionUSD
          PlotData.Int this.MiningRevenueUSD
          PlotData.Int this.TransactionFeesBTC ]

module BTCMiningData =
    let empty =
        { Headers = [||]
          Ids = [||]
          Date = [||]
          NumberTransactions = [||]
          OutputVolue = [||]
          MarketPrice = [||]
          HashRate = [||]
          CostPerTransactionUSD = [||]
          MiningRevenueUSD = [||]
          TransactionFeesBTC = [||] }

let render (data: BTCMiningData)  =
    Plotly.plot [
        plot.traces [
            traces.table [
                table.columnwidth [ 200; 500; 600; 600; 400; 400; 600; 600; 600 ]
                table.header [
                    header.values data.Headers
                    header.align.center
                    header.line [
                        line.width 1
                        line.color (color.rgb(50, 50, 50))
                    ]
                    header.fill [
                        fill.color (color.rgb(235, 100, 230))
                    ]
                    header.font [
                        font.family font.arial
                        font.size 11
                        font.color color.white
                    ]
                ]
                table.cells [
                    cells.values data.Values
                    cells.align.center
                    cells.line [
                        line.color color.black
                        line.width 1
                    ]
                    cells.fill [
                        fill.color [
                            color.rgba(228, 222, 249, 0.65)
                            color.rgb(235, 193, 238)
                            color.rgba(228, 222, 249, 0.65)
                        ]
                    ]
                    cells.font [
                        font.family font.arial
                        font.size 10
                        font.color color.black
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Bitcoin mining stats for 180 days"
            ]
            layout.width 1500
            layout.height 700
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState BTCMiningData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/Mining-BTC-180.csv"

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
                |> Array.fold (fun (state: BTCMiningData) (values: string []) -> state.AddDataSet values) content
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