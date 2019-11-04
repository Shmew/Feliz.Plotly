﻿[<RequireQualifiedAccess>]
module Samples.ParallelCategories.MultiColorLinkedBrushing

open Elmish
open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.ElmishComponents
open Feliz.Plotly
open Zanaptak.TypedCssClasses

module Types =
    type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
    type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

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
        { CarData: CarData
          ColorAction: ColorAction 
          DataLoaded: bool
          Error: string option
          Traces: IPlotProperty list }

    type Msg =
        | LoadData of string
        | SetCarData of CarData
        | SetColorAction of ColorAction
        | SetDataLoaded of bool
        | SetError of string option
        | SetTraces of IPlotProperty list

module State =
    open Types

    let loadDataset path state dispatch = 
        async {
            let! (statusCode, responseText) = Http.get path
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map (fun s -> s.Split(','))

                fullData
                |> Array.tail
                |> Array.fold (fun (state: CarData) (values: string []) -> state.AddDataSet values) state.CarData
                |> fun newContent -> { newContent with Headers = fullData |> Array.head }
                |> SetCarData
                |> dispatch
                dispatch <| SetError None
                dispatch <| SetDataLoaded true
            else
                dispatch <| SetError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    let update msg (state: State) =
        match msg with
        | LoadData path -> state, Cmd.ofSub (loadDataset path state)
        | SetCarData carData -> { state with CarData = carData }, Cmd.none
        | SetColorAction colorAction -> { state with ColorAction = colorAction }, Cmd.none
        | SetDataLoaded b -> { state with DataLoaded = b }, Cmd.none
        | SetError err -> { state with Error = err }, Cmd.none
        | SetTraces t -> { state with Traces = t }, Cmd.none

    let init () =
        { CarData = CarData.empty
          ColorAction = ColorAction.Erase
          DataLoaded = false
          Error = None 
          Traces = [] }, Cmd.ofMsg (LoadData "https://raw.githubusercontent.com/plotly/datasets/master/imports-85.csv")

module View =
    open Types

    let plotData state (plotColors: float []) =
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
                scatter.x state.CarData.Horsepower
                scatter.y state.CarData.HighwayMPG
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
                        dimension.values state.CarData.BodyStyle
                    ]
                    dimensions.dimension [
                        dimension.label "Drive Wheels"
                        dimension.values state.CarData.DriveWheels
                    ]
                    dimensions.dimension [
                        dimension.label "Fuel Type"
                        dimension.values state.CarData.FuelType
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
        |> List.singleton

    let updatePoints state plotColors dispatch (points: ResizeArray<Bindings.Plotly.PlotDatum>) =
        let points = points |> Array.ofSeq

        let colorPre = 
            points
            |> Array.map (fun pObj -> pObj.pointNumber)

        let colors =
            plotColors
            |> Array.mapi (fun i _ ->
                if Array.contains (i |> float) colorPre then
                    JS.console.log state.ColorAction
                    match state.ColorAction with
                    | ColorAction.Erase -> 0.
                    | ColorAction.Red -> 1.
                    | ColorAction.Blue -> 2.
                else 0.)

        plotData state colors
        |> SetTraces
        |> dispatch

    let render state dispatch =
        let plotColors = state.CarData.Horsepower |> Array.map (fun _ -> 0.)

        match state.DataLoaded, state.Error with
        | false, _ ->
            Html.div [
                prop.style [
                    style.textAlign.center
                    style.marginLeft length.auto
                    style.marginRight length.auto
                    style.marginTop 50
                ]
                prop.children [
                    Html.li [
                        prop.className [
                            FA.Fa
                            FA.FaRefresh
                            FA.FaSpin
                            FA.Fa3X
                        ]
                    ]
                ]
            ]
        | true, None -> 
            Html.div [
                Plotly.plot [
                    yield! state.Traces
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
                    plot.onSelected <| fun o -> o.points |> updatePoints state plotColors dispatch
                    plot.onClick <| fun o -> o.points |> updatePoints state plotColors dispatch
                ]
                Html.div [
                    prop.className Bulma.Control
                    prop.style [
                        style.paddingLeft (length.em 8)
                        style.paddingBottom (length.em 1)
                    ]
                    prop.children [
                        Html.button [
                            prop.classes [ Bulma.Button; if state.ColorAction = ColorAction.Erase then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                            prop.onClick <| fun _ -> dispatch (SetColorAction ColorAction.Erase)
                            prop.text "Erase"
                        ]
                        Html.button [
                            prop.classes [ Bulma.Button; if state.ColorAction = ColorAction.Red then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                            prop.onClick <| fun _ -> dispatch (SetColorAction ColorAction.Red)
                            prop.text "Red"
                        ]
                        Html.button [
                            prop.classes [ Bulma.Button; if state.ColorAction = ColorAction.Blue then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                            prop.onClick <| fun _ -> dispatch (SetColorAction ColorAction.Blue)
                            prop.text "Blue"
                        ]
                    ]
                ]
            ]
        | _, Some error ->
            Html.h1 [
                prop.style [ style.color.crimson ]
                prop.text error
            ]

let chart () = React.elmishComponent("Plot", State.init(), State.update, View.render)
