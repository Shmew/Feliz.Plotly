# Feliz.Plotly - Time Series

Taken from [Plotly - Time Series](https://plot.ly/javascript/time-series/)

```fsharp:plotly-chart-timeseries-rangeslider
[<RequireQualifiedAccess>]
module Samples.TimeSeries.RangeSlider

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
            traces.scatter [
                scatter.mode.lines
                scatter.name "AAPL High"
                scatter.x data.Date
                scatter.y data.High
                scatter.line [
                    line.color "#17BECF"
                ]
            ]
            traces.scatter [
                scatter.mode.lines
                scatter.name "AAPL Low"
                scatter.x data.Date
                scatter.y data.Low
                scatter.line [
                    line.color "#7F7F7F"
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Time Series with Rangeslider"
            ]
            layout.xaxis [
                xaxis.autorange.true'
                xaxis.range [ DateTime(2015, 2, 17); DateTime(2017, 2, 16) ]
                xaxis.rangeselector [
                    rangeselector.buttons [
                        buttons.button [
                            button.count 1
                            button.label "1m"
                            button.step.month
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.count 6
                            button.label "6m"
                            button.step.month
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.step.all
                        ]
                    ]
                ]
                xaxis.rangeslider [
                    rangeslider.range [ DateTime(2015, 2, 17); DateTime(2017, 2, 16) ]
                ]
                xaxis.type'.date
            ]
            layout.yaxis [
                yaxis.autorange.true'
                yaxis.range [ 86.8700008333; 138.870004167 ]
                yaxis.type'.linear
            ]
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