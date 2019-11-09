# Feliz.Plotly - Carpet Contour Plots

Taken from [Plotly - Carpet Contour Plots](https://plot.ly/javascript/carpet-contour/)

```fsharp:plotly-chart-carpetcontour-multipletraces
[<RequireQualifiedAccess>]
module Samples.CarpetContour.MultipleTraces

open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.Plotly

type CarpetData =
    { a: float list
      b: float list
      x: float list list
      y: float list list }

module CarpetData =
    let empty =
        { a = []
          b = []
          x = []
          y = [] }

type ContourCarpetData =
    { z: float list list }

module ContourCarpetData =
    let empty = { z = [ ] }

type ScatterData =
    { x: string list
      y: float list }

module ScatterData =
    let empty = { x = [ ]; y = [ ] }

type ScatterDataWithText =
    { x: float list
      y: float list
      text: string list }

module ScatterDataWithText =
    let empty = { x = [ ]; y = [ ]; text = [ ] }

type PlotData =
    { Carpet: CarpetData
      ContourCarpet: ContourCarpetData
      ContourCarpet2: ContourCarpetData
      ContourCarpet3: ContourCarpetData
      Scatter: ScatterData
      Scatter2: ScatterData
      ScatterWithText: ScatterDataWithText }

module PlotData =
    let empty =
        { Carpet = CarpetData.empty
          ContourCarpet = ContourCarpetData.empty
          ContourCarpet2 = ContourCarpetData.empty
          ContourCarpet3 = ContourCarpetData.empty
          Scatter = ScatterData.empty
          Scatter2 = ScatterData.empty
          ScatterWithText = ScatterDataWithText.empty }

let ofOption error = function Some s -> Ok s | None -> Error error

type ResultBuilder() =
    member __.Return(x) = Ok x

    member __.ReturnFrom(m: Result<_, _>) = m

    member __.Bind(m, f) = Result.bind f m
    member __.Bind((m, error): (Option<'T> * 'E), f) = m |> ofOption error |> Result.bind f

    member __.Zero() = None

let result = new ResultBuilder()

let render (data: PlotData) =
    Plotly.plot [
        plot.traces [
            traces.carpet [
                carpet.a data.Carpet.a
                carpet.b data.Carpet.b
                carpet.x data.Carpet.x
                carpet.y data.Carpet.y
                carpet.aaxis [
                    aaxis.startline true
                    aaxis.startlinewidth 2
                    aaxis.endline true
                    aaxis.endlinewidth 2
                    aaxis.showticklabels.none
                    aaxis.smoothing 0
                    aaxis.showgrid false
                ]
                carpet.baxis [
                    baxis.startline false
                    baxis.endline false
                    baxis.showticklabels.none
                    baxis.smoothing 0
                    baxis.showgrid false
                ]
            ]
            traces.contourcarpet [
                contourcarpet.z data.ContourCarpet.z
                contourcarpet.autocolorscale false
                contourcarpet.zmax 1
                contourcarpet.name "Pressure"
                contourcarpet.colorscale color.colorscale.viridis
                contourcarpet.zmax -8
                contourcarpet.colorbar [
                    colorbar.y 0
                    colorbar.yanchor.bottom
                    colorbar.len 0.75
                    colorbar.title [
                        title.text "Pressure coefficient, c<sub>p</sub>"
                        title.side.right
                    ]
                ]
                contourcarpet.contours [
                    contours.start -1
                    contours.size 0.025
                    contours.end' 1.
                    contours.showlines false
                ]
                contourcarpet.line [
                    line.smoothing 0
                ]
                contourcarpet.autocontour false
                contourcarpet.zauto false
            ]
            traces.contourcarpet [
                contourcarpet.z data.ContourCarpet2.z
                contourcarpet.opacity 0.3
                contourcarpet.showlegend true
                contourcarpet.name "Steamlines"
                contourcarpet.autocontour true
                contourcarpet.ncontours 50
                contourcarpet.contours [
                    contours.coloring.none
                ]
                contourcarpet.line [
                    line.color color.white
                    line.width 1
                ]
            ]
            traces.contourcarpet [
                contourcarpet.z data.ContourCarpet3.z
                contourcarpet.showlegend true
                contourcarpet.name "Pressure<br>contours"
                contourcarpet.autocontour false
                contourcarpet.contours [
                    contours.size 0.25
                    contours.start -4
                    contours.coloring.none
                    contours.end' 1
                    contours.showlines true
                ]
                contourcarpet.line [
                    line.color (color.rgba(0, 0, 0, 0.5))
                    line.smoothing 1
                ]
            ]
            traces.scatter [
                scatter.legendgroup "g1"
                scatter.name "Surface<br>pressure"
                scatter.mode.lines
                scatter.hoverinfo.skip
                scatter.x data.Scatter.x
                scatter.y data.Scatter.y
                scatter.line [
                    line.color (color.rgba(255, 0, 0, 0.5))
                    line.width 1
                    line.shape.spline
                    line.smoothing 1
                ]
                scatter.fill.toself
                scatter.fillcolor (color.rgba(255, 0, 0, 0.2))
            ]
            traces.scatter [
                scatter.showlegend false
                scatter.legendgroup "g1"
                scatter.mode.lines
                scatter.hoverinfo.skip
                scatter.x data.Scatter2.x
                scatter.y data.Scatter2.y
                scatter.line [
                    line.color (color.rgba(255, 0, 0, 0.3))
                    line.width 1
                ]
            ]
            traces.scatter [
                scatter.showlegend false
                scatter.legendgroup "g1"
                scatter.name "cp"
                scatter.text data.ScatterWithText.text
                scatter.mode.lines
                scatter.x data.ScatterWithText.x
                scatter.y data.ScatterWithText.y
                scatter.line [
                    line.color (color.rgba(255, 0, 0, 0.2))
                    line.width 0
                ]
            ]
        ]
        plot.layout [
            layout.dragmode.pan
            layout.height 700
            layout.yaxis [
                yaxis.zeroline false
                yaxis.range [ -1.8; 1.8 ]
                yaxis.showgrid false
            ]
            layout.xaxis [
                xaxis.zeroline false
                xaxis.scaleratio 1
                xaxis.scaleanchor.y 1
                xaxis.range [ -3.8; 3.8 ]
                xaxis.showgrid false
            ]
            layout.title [
                title.text "Flow over a Karman-Trefftz airfoil"
            ]
            layout.hovermode.closest
            layout.margin [
                margin.r 60
                margin.b 40
                margin.l 40
                margin.t 80
            ]
            layout.width 900
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState PlotData.empty
    let path = "https://raw.githubusercontent.com/bcdunbar/datasets/master/airfoil_data.json"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText
                |> SimpleJson.tryParse
                |> function
                | Some(JArray [ jCarpet; jCCarpet; jCCarpet2; jCCarpet3; jScatter; jScatter2; jScatterText ]) ->
                    result {
                        let! c = jCarpet |> Json.tryConvertFromJsonAs<CarpetData>
                        let! cC = jCCarpet |> Json.tryConvertFromJsonAs<ContourCarpetData>
                        let! cC2 = jCCarpet2 |> Json.tryConvertFromJsonAs<ContourCarpetData>
                        let! cC3 = jCCarpet3 |> Json.tryConvertFromJsonAs<ContourCarpetData>
                        let! jS = jScatter |> Json.tryConvertFromJsonAs<ScatterData>
                        let! jS2 = jScatter2 |> Json.tryConvertFromJsonAs<ScatterData>
                        let! jST = jScatterText |> Json.tryConvertFromJsonAs<ScatterDataWithText>

                        let builtData = 
                            { Carpet = c
                              ContourCarpet = cC
                              ContourCarpet2 = cC2
                              ContourCarpet3 = cC3 
                              Scatter = jS
                              Scatter2 = jS2
                              ScatterWithText = jST }

                        return builtData
                    }
                    |> function
                    | Ok res -> 
                        res
                        |> setContent
                        setError(None)
                    | Error e ->
                        setError(Some (sprintf "Status %d: Failed parsing JSON object:\n%s" statusCode e))
                | _ -> setError(Some "Failed to parse JSON Object")
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