# Feliz.Plotly - Sankey Diagrams

Taken from [Plotly - Sankey Diagrams](https://plot.ly/javascript/sankey-diagram/)

```fsharp:plotly-chart-sankey-styled
[<RequireQualifiedAccess>]
module Samples.Sankey.Styled

open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.Plotly

module JsonParsing =
    type EnergyNode =
        { label: string [] }

    type EnergyLink =
        { source: int []
          target: int []
          value: float []
          label: string [] }

    type EnergyData =
        { node: EnergyNode
          link: EnergyLink }

    type EnergyJson =
        { data: EnergyData [] }

type EnergyData =
    { NodeLabel: string []
      LinkSource: int []
      LinkTarget: int []
      LinkValue: float []
      LinkLabel: string [] }

module EnergyData =
    let empty =
        { NodeLabel = [||]
          LinkSource = [||]
          LinkTarget = [||]
          LinkValue = [||]
          LinkLabel = [||] }

let render (data: EnergyData) =
    Plotly.plot [
        plot.traces [
            traces.sankey [
                sankey.domain [
                    domain.x [ 0; 1 ]
                    domain.y [ 0; 1 ]
                ]
                sankey.orientation.h
                sankey.valueformat ".0f"
                sankey.valuesuffix "TWh"
                sankey.node [
                    node.pad 15
                    node.thickness 15
                    node.line [
                        line.color color.black
                        line.width 0.5
                    ]
                    node.label data.NodeLabel
                ]
                sankey.link [
                    link.source data.LinkSource
                    link.target data.LinkTarget
                    link.value data.LinkValue
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Energy forecast for 2050<br>Source: Department of Energy \
                & Climate Change, Tom Counsell via <a href='https://bost.ocks.org/mike\
                /sankey/'>Mike Bostock</a>"
            ]
            layout.width 1118
            layout.height 772
            layout.font [
                font.size 10
                font.color color.white
            ]
            layout.paperBgcolor color.black
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState EnergyData.empty
    let path = "https://raw.githubusercontent.com/plotly/plotly.js/master/test/image/mocks/sankey_energy_dark.json"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText
                |> Json.tryParseAs<JsonParsing.EnergyJson>
                |> Result.bind (fun eJson -> 
                    match eJson.data |> Array.tryHead with
                    | Some data -> Ok data
                    | None -> Error "Failed to parse Data array")
                |> function
                | Ok res -> 
                    { NodeLabel = res.node.label 
                      LinkSource = res.link.source
                      LinkTarget = res.link.target
                      LinkValue = res.link.value
                      LinkLabel = res.link.label }
                    |> setContent
                    setError(None)
                | Error e ->
                    setError(Some (sprintf "Status %d: Failed parsing JSON object:\n%s" statusCode e))
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