# Feliz.Plotly - Parallel Categories

This example is not fully complete, needs events implemented.

Taken from [Plotly - Parallel Categories](https://plot.ly/javascript/parallel-categories-diagram/)

```fsharp:plotly-chart-parallelcategories-multicolorlinkedbrushing2
[<RequireQualifiedAccess>]
module Samples.ParallelCategories.MultiColorLinkedBrushing2

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

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
            BodyStyle = Array.append this.BodyStyle (data.[6] |> Array.singleton)
            DriveWheels = Array.append this.DriveWheels (data.[7] |> Array.singleton)
            FuelType = Array.append this.FuelType (data.[3] |> Array.singleton) }

module CarData =
    let empty =
        { Headers = [||]
          HighwayMPG = [||]
          Horsepower = [||]
          BodyStyle = [||]
          DriveWheels = [||]
          FuelType = [||] }

[<RequireQualifiedAccess>]
type ColorAction =
    | Erase
    | Red
    | Blue

type State =
    { Data: IPlotProperty option
      Layout: IPlotProperty option }

let plot' = React.functionComponent (fun (input: {| carData: CarData; colorAction: ColorAction |}) ->
    let (plotState, setPlotState) = React.useState({ Data = None; Layout = None })

    let plotData (plotColors: float []) =
        let plotColorscale =
            [ color.gray
              color.gray
              color.fireBrick
              color.fireBrick
              color.blue
              color.blue ]
            |> color.colorscale.sequential

        plot.traces [
            traces.scatter [
                scatter.x input.carData.Horsepower
                scatter.y input.carData.HighwayMPG
                scatter.mode.markers
                scatter.marker [
                    marker.color plotColors
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
                        dimension.values input.carData.BodyStyle
                    ]
                    dimensions.dimension [
                        dimension.label "Drive Wheels"
                        dimension.values input.carData.DriveWheels
                    ]
                    dimensions.dimension [
                        dimension.label "Fuel Type"
                        dimension.values input.carData.FuelType
                    ]
                ]
                parcats.domain [
                    domain.y [ 0.; 0.4 ]
                ]
                parcats.line [
                    line.color plotColors
                    line.colorscale plotColorscale
                    line.cmin -0.5
                    line.cmax 2.5
                    line.shape.hspline
                ]
                parcats.labelfont [
                    labelfont.size 14
                ]
            ]
        ]

    let plotLayout =
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

    let plotColors = input.carData.Horsepower |> Array.map (fun _ -> 0.)

    let initPlot () = 
        { Data = plotData plotColors |> Some
          Layout = Some plotLayout }
        |> setPlotState

    React.useEffect(initPlot, [| input.carData :> obj; input.colorAction :> obj |])

    let updatePoints (points: ResizeArray<Bindings.Plotly.PlotDatum>) =
        let points = points |> Array.ofSeq

        let colorPre = 
            points
            |> Array.map (fun pObj -> pObj.pointNumber)
        let colors =
            plotColors
            |> Array.mapi (fun i _ ->
                if Array.contains (i |> float) colorPre then
                    JS.console.log input.colorAction
                    match input.colorAction with
                    | ColorAction.Erase -> 0.
                    | ColorAction.Red -> 1.
                    | ColorAction.Blue -> 2.
                else 0.)

        { plotState with Data = plotData colors |> Some }
        |> setPlotState
    
    Plotly.plot [
        if plotState.Data.IsSome then plotState.Data.Value
        if plotState.Layout.IsSome then plotState.Layout.Value
        plot.onSelected <| fun o -> o.points |> updatePoints
        plot.onClick <| fun o -> o.points |> updatePoints
    ]
)

let render (data: CarData) (colorAction: ColorAction)  =
    plot' {| carData = data; colorAction = colorAction |}

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CarData.empty
    let colorAction, setColorAction = React.useState ColorAction.Erase
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/imports-85.csv"

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
                |> Array.fold (fun (state: CarData) (values: string []) -> state.AddDataSet values) content
                |> fun newContent -> { newContent with Headers = fullData |> Array.head }
                |> setContent
                setError(None)
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    React.useEffect(loadDataset, [| path :> obj |])

    let buildContent () =
        Html.div [
            render content colorAction
            Html.div [
                prop.className Bulma.Control
                prop.style [
                    style.paddingLeft (length.em 8)
                    style.paddingBottom (length.em 1)
                ]
                prop.children [
                    Html.button [
                        prop.classes [ Bulma.Button; if colorAction = ColorAction.Erase then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                        prop.onClick <| fun _ -> setColorAction ColorAction.Erase
                        prop.text "Erase"
                    ]
                    Html.button [
                        prop.classes [ Bulma.Button; if colorAction = ColorAction.Red then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                        prop.onClick <| fun _ -> setColorAction ColorAction.Red
                        prop.text "Red"
                    ]
                    Html.button [
                        prop.classes [ Bulma.Button; if colorAction = ColorAction.Blue then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                        prop.onClick <| fun _ -> setColorAction ColorAction.Blue
                        prop.text "Blue"
                    ]
                ]
            ]
        ]

    match isLoading, error with
    | true, _ -> input.centeredSpinner
    | false, None -> 
        buildContent()
    | _, Some error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ])

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```