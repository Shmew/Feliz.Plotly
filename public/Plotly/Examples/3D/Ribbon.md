# Feliz.Plotly - Ribbon Plots

Taken from [Plotly - Ribbon Plots](https://plot.ly/javascript/ribbon-plots/)

```fsharp:plotly-chart-3d-ribbon
[<RequireQualifiedAccess>]
module Samples.ThreeDimensional.Ribbon

open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.Plotly

type RibbonData =
    { x: int [] []
      y: int [] []
      z: float [] []
      cmax: float
      cmin: float
      colorscale: string [] []
      name: string
      showscale: bool
      type': string
      uid: string
      xsrc: string
      ysrc: string
      zsrc: string }

type RibbonJson =
    { data: RibbonData []
      layout: string }
    
let render (data: RibbonData list) =
    let plotTraces =
        data
        |> List.map (fun d ->
            traces.surface [
                surface.x d.x
                surface.y d.y
                surface.z d.z
                surface.name ""
                surface.colorscale d.colorscale
                surface.showscale false
            ]   
        )
    
    Plotly.plot [
        plot.traces plotTraces
        plot.layout [
            layout.autosize true
            layout.height 600
            layout.width 600
            layout.scene [
                scene.xaxis [
                    xaxis.title [
                        title.text "Sample #"
                    ]
                ]
                scene.yaxis [
                    yaxis.title [
                        title.text "Wavelength"
                    ]
                ]
                scene.zaxis [
                    zaxis.title [
                        title.text "OD"
                    ]
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState None
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/3d-ribbon.json"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText
                |> SimpleJson.parse
                |> SimpleJson.mapKeys (function
                    | "type" -> "type'"
                    | key -> key)
                |> SimpleJson.mapbyKey(fun k v -> if k = "layout" then Json.JString "" else v)
                |> Json.tryConvertFromJsonAs<RibbonJson>
                |> function
                | Ok res -> 
                    res.data
                    |> List.ofArray
                    |> Some
                    |> setContent
                    setError(None)
                | Error e ->
                    setError(Some (sprintf "Status %d: Failed parsing JSON object:\n%s" statusCode e))
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    React.useEffect(loadDataset, [| path :> obj |])

    match isLoading, error, content with
    | true, _, _ -> input.centeredSpinner
    | false, None, Some content -> render content
    | _, Some error, _ ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ]
    | _ ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text "Internal error with parsing json data"
        ])

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```