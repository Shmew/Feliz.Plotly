# Feliz.Plotly - OHLC Charts

Taken from [Plotly - OHLC Charts](https://plot.ly/javascript/ohlc-charts/)

```fsharp:plotly-chart-ohlc-basic
[<RequireQualifiedAccess>]
module Samples.OHLC.Basic

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly
open System

type AppleStocks =
    { Headers: string []
      Date: DateTime []
      Open: float []
      High: float []
      Low: float []
      Close: float []
      Volume: float []
      Adjusted: float []
      Down: float []
      MovingAvg: float []
      Up: float []
      Direction: string [] }

    member this.AddDataSet (data: string []) =
        { this with
            Date = Array.append this.Date (data.[0] |> DateTime.Parse |> Array.singleton)
            Open = Array.append this.Open (data.[1] |> float |> Array.singleton)
            High = Array.append this.High (data.[2] |> float |> Array.singleton)
            Low = Array.append this.Low (data.[3] |> float |> Array.singleton)
            Close = Array.append this.Close (data.[4] |> float |> Array.singleton)
            Volume = Array.append this.Volume (data.[5] |> float |> Array.singleton)
            Adjusted = Array.append this.Adjusted (data.[6] |> float |> Array.singleton)
            Down = Array.append this.Down (data.[7] |> float |> Array.singleton)
            MovingAvg = Array.append this.MovingAvg (data.[8] |> float |> Array.singleton)
            Up = Array.append this.Up (data.[9] |> float |> Array.singleton)
            Direction = Array.append this.Direction (data.[10] |> Array.singleton) }

module AppleStocks =
    let empty =
        { Headers = [||]
          Date = [||]
          Open = [||]
          High = [||]
          Low = [||]
          Close = [||]
          Volume = [||]
          Adjusted = [||]
          Down = [||]
          MovingAvg = [||]
          Up = [||]
          Direction = [||] }

let render (data: AppleStocks) =
    Plotly.plot [
        plot.traces [
            traces.ohlc [
                ohlc.x data.Date
                ohlc.close data.Close
                ohlc.high data.High
                ohlc.low data.Low
                ohlc.open' data.Open
                ohlc.increasing [
                    increasing.line [
                        line.color color.black
                    ]
                ]
                ohlc.decreasing [
                    decreasing.line [
                        line.color color.red
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.dragmode.zoom
            layout.showlegend false
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState AppleStocks.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/finance-charts-apple.csv"

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
                |> Array.fold (fun (state: AppleStocks) (values: string []) -> state.AddDataSet values) content
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