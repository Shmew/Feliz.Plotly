[<RequireQualifiedAccess>]
module Samples.ParallelCategories.MultiColorLinkedBrushing

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CarData =
    { Headers: string []
      HighwayMPG: int []
      Horsepower: int option []
      BodyStyle: string []
      DriveWheels: string []
      FuelType: string [] }
    member this.AddDataSet (data: string []) =
        { this with
            HighwayMPG = Array.append this.HighwayMPG (data.[23] |> int |> Array.singleton)
            Horsepower = 
                match data.[21] with
                | hp when hp |> string = "NA" -> None
                | hp -> hp |> int |> Some
                |> Array.singleton
                |> Array.append this.Horsepower 
            BodyStyle = Array.append this.BodyStyle (data.[5] |> Array.singleton)
            DriveWheels = Array.append this.DriveWheels (data.[6] |> Array.singleton)
            FuelType = Array.append this.FuelType (data.[3] |> Array.singleton) }

module CarData =
    let empty =
        { Headers = [||]
          HighwayMPG = [||]
          Horsepower = [||]
          BodyStyle = [||]
          DriveWheels = [||]
          FuelType = [||] }

let render (data: CarData)  =
    let plotColor =  data.Horsepower |> Array.map (fun _ -> 0) 

    let plotColorscale =
        [ colors.gray
          colors.gray
          colors.fireBrick
          colors.fireBrick
          colors.blue
          colors.blue ]
        |> colors.colorscale.sequential

    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x data.Horsepower
                scatter.y data.HighwayMPG
                scatter.mode.markers
                scatter.marker [
                    marker.color plotColor
                    marker.colorscale plotColorscale
                    marker.cmin -0.5
                    marker.cmax 2.5
                    marker.showscale true
                    marker.colorbar [
                        colorbar.tickmode.array
                        colorbar.tickvals [ 0; 1; 2 ]
                        colorbar.ticktext [ "None"; "Red"; "Blue" ]
                    ]
                ]
            ]
            traces.parcats [
                parcats.dimensions [
                    dimensions.dimension [
                        dimension.label "Body Style"
                        dimension.values data.BodyStyle
                    ]
                    dimensions.dimension [
                        dimension.label "Drive Wheels"
                        dimension.values data.DriveWheels
                    ]
                    dimensions.dimension [
                        dimension.label "Fuel Type"
                        dimension.values data.FuelType
                    ]
                ]
                parcats.domain [
                    domain.y [ 0.; 0.4 ]
                ]
                parcats.line [
                    line.color plotColor
                    line.colorscale plotColorscale
                    line.cmin -0.5
                    line.cmax 2.5
                    line.shape.spline
                ]
                parcats.labelfont [
                    labelfont.size 14
                ]
            ]
        ]
        plot.layout [
            layout.width 600
            layout.height 800
            layout.xaxis [
                xaxis.title [
                    title.text "Horsepower"
                ]
            ]
            layout.yaxis [
                yaxis.domain [ 0.6; 1. ]
                yaxis.title [
                    title.text "MPG"
                ]
            ]
            layout.dragmode.lasso
            layout.hovermode.closest
        ]
        plot.onSelected (fun _ -> ())
        plot.onClick (fun _ -> ())
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CarData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/imports-85.csv"

    React.useEffect(fun _ ->
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
                |> Array.fold (fun (state: CarData) (values: string []) -> state.AddDataSet values) content
                |> fun newContent -> { newContent with Headers = fullData |> Array.head }
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
