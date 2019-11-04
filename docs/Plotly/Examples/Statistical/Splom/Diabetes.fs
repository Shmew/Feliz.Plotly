﻿[<RequireQualifiedAccess>]
module Samples.Splom.Diabetes

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type DiabetesData =
    { Headers: string []
      Pregnancies: float [] 
      Glucose: float []
      BloodPressure: float []
      SkinThickness: float []
      Insulin: float []
      BMI: float []
      PedigreeFunction: float []
      Age: float []
      Outcome: float [] }
    member this.AddDataSet (data: string []) =
        { this with
            Pregnancies = Array.append this.Pregnancies (data.[0] |> float |> Array.singleton)
            Glucose = Array.append this.Glucose (data.[1] |> float |> Array.singleton)
            BloodPressure = Array.append this.BloodPressure (data.[2] |> float |> Array.singleton)
            SkinThickness = Array.append this.SkinThickness (data.[3] |> float |> Array.singleton)
            Insulin = Array.append this.Insulin (data.[4] |> float |> Array.singleton)
            BMI = Array.append this.BMI (data.[5] |> float |> Array.singleton)
            PedigreeFunction = Array.append this.PedigreeFunction (data.[6] |> float |> Array.singleton)
            Age = Array.append this.Age (data.[7] |> float |> Array.singleton)
            Outcome = Array.append this.Outcome (data.[8] |> float |> Array.singleton) }

module DiabetesData =
    let empty =
        { Headers = [||]
          Pregnancies = [||]
          Glucose = [||]
          BloodPressure = [||]
          SkinThickness = [||]
          Insulin = [||]
          BMI = [||] 
          PedigreeFunction = [||] 
          Age = [||] 
          Outcome = [||] }

let render (data: DiabetesData)  =
    let plotText =
        data.Outcome
        |> Array.map (fun o ->
            match o with
            | 0. -> "Diabetic"
            | 1. -> "Non-Diabetic"
            | _ -> failwith "Check your data")

    let plotColorcale =
        [ ["0"; "#119dff"]
          ["0.5"; "#119dff"]
          ["0.5"; "#ef553b"]
          ["1"; "#ef553b"] ]

    Plotly.plot [
        plot.traces [
            traces.splom [
                splom.dimensions [
                    dimensions.dimension [
                        dimension.label "Pregnancies"
                        dimension.values data.Pregnancies
                    ]
                    dimensions.dimension [
                        dimension.label "Glucose"
                        dimension.values data.Glucose
                    ]
                    dimensions.dimension [
                        dimension.label "BloodPressure"
                        dimension.values data.BloodPressure
                    ]
                    dimensions.dimension [
                        dimension.label "SkinThickness"
                        dimension.values data.SkinThickness
                    ]
                    dimensions.dimension [
                        dimension.label "Insulin"
                        dimension.values data.Insulin
                    ]
                    dimensions.dimension [
                        dimension.label "BMI"
                        dimension.values data.BMI
                    ]
                    dimensions.dimension [
                        dimension.label "PedigreeFunction"
                        dimension.values data.PedigreeFunction
                    ]
                    dimensions.dimension [
                        dimension.label "Age"
                        dimension.values data.Age
                    ]
                ]
                splom.text plotText
                splom.marker [
                    marker.color (data.Outcome |> Array.map string)
                    marker.colorscale plotColorcale
                    marker.size 5
                    marker.line [
                        line.color color.white
                        line.width 0.5
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text 
                    "Scatterplot Matrix (SPLOM) for Diabetes Dataset<br>Data \
                     source: <a href='https://www.kaggle.com/uciml/pima-indians\
                     -diabetes-database/data'>[1]</a>"
            ]
            layout.height 1000
            layout.width 1000
            layout.autosize false
            layout.hovermode.closest
            layout.dragmode.select
            layout.plotBgcolor (color.rgba(240, 240, 240, 0.95))
            layout.xaxis [
                xaxis.showline false
                xaxis.zeroline false
                xaxis.gridcolor "#ffff"
                xaxis.ticklen 2
                xaxis.tickfont [
                    tickfont.size 10
                ]
                xaxis.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.yaxis [
                yaxis.showline false
                yaxis.zeroline false
                yaxis.gridcolor "#ffff"
                yaxis.ticklen 2
                yaxis.tickfont [
                    tickfont.size 10
                ]
                yaxis.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.xaxis2 [
                xaxis2.showline false
                xaxis2.zeroline false
                xaxis2.gridcolor "#ffff"
                xaxis2.ticklen 2
                xaxis2.tickfont [
                    tickfont.size 10
                ]
                xaxis2.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.yaxis2 [
                yaxis2.showline false
                yaxis2.zeroline false
                yaxis2.gridcolor "#ffff"
                yaxis2.ticklen 2
                yaxis2.tickfont [
                    tickfont.size 10
                ]
                yaxis2.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.xaxis3 [
                xaxis3.showline false
                xaxis3.zeroline false
                xaxis3.gridcolor "#ffff"
                xaxis3.ticklen 2
                xaxis3.tickfont [
                    tickfont.size 10
                ]
                xaxis3.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.yaxis3 [
                yaxis3.showline false
                yaxis3.zeroline false
                yaxis3.gridcolor "#ffff"
                yaxis3.ticklen 2
                yaxis3.tickfont [
                    tickfont.size 10
                ]
                yaxis3.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.xaxis4 [
                xaxis4.showline false
                xaxis4.zeroline false
                xaxis4.gridcolor "#ffff"
                xaxis4.ticklen 2
                xaxis4.tickfont [
                    tickfont.size 10
                ]
                xaxis4.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
            layout.yaxis4 [
                yaxis4.showline false
                yaxis4.zeroline false
                yaxis4.gridcolor "#ffff"
                yaxis4.ticklen 2
                yaxis4.tickfont [
                    tickfont.size 10
                ]
                yaxis4.title [
                    title.font [
                        font.size 12
                    ]
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState DiabetesData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/diabetes.csv"

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
                |> Array.fold (fun (state: DiabetesData) (values: string []) -> state.AddDataSet values) content
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
