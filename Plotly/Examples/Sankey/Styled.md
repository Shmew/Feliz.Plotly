# Feliz.Plotly - Sankey Diagrams

Taken from [Plotly - Sankey Diagrams](https://plot.ly/javascript/sankey-diagram/)

```fsharp:plotly-chart-sankey-styled
[<RequireQualifiedAccess>]
module Samples.Sankey.Styled

open Fable.React
open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.Plotly

module private JsonParsing =
    type EnergyNode =
        { Pad: int
          Thickness: int
          Line: obj
          Label: string [] }

    type EnergyLink =
        { Source: int []
          Target: int []
          Value: float []
          Label: string [] }

    type EnergyData =
        { Type: string
          Domain: obj
          Orientation: string
          Valueformat: string
          Valuesuffix: string
          Node: EnergyNode
          Link: EnergyLink }

    type EnergyJson =
        { Data: EnergyData []
          Layout: obj }

type private EnergyData =
    { NodeLabel: string []
      LinkSource: int []
      LinkTarget: int []
      LinkValue: float []
      LinkLabel: string [] }

module private EnergyData =
    let empty =
        { NodeLabel = [||]
          LinkSource = [||]
          LinkTarget = [||]
          LinkValue = [||]
          LinkLabel = [||] }

let private render (data: EnergyData) =
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
                        line.color colors.black
                        line.width 0.5
                    ]
                    node.label data.NodeLabel
                    node.color colors.blue
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
                font.color colors.white
            ]
            layout.plotBgcolor colors.black
            layout.paperBgcolor colors.black
        ]
    ]

let private chart' = React.functionComponent <| fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState EnergyData.empty
    let path = "https://raw.githubusercontent.com/plotly/plotly.js/master/test/image/mocks/sankey_energy_dark.json"

    React.useEffect(fun _ ->
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText
                |> Json.tryParseAs<JsonParsing.EnergyJson>
                |> Result.bind (fun eJson -> 
                    match eJson.Data |> Array.tryHead with
                    | Some data -> Ok data
                    | None -> Error "Failed to parse Data array")
                |> function
                | Ok res -> 
                    { NodeLabel = res.Node.Label 
                      LinkSource = res.Link.Source
                      LinkTarget = res.Link.Target
                      LinkValue = res.Link.Value
                      LinkLabel = res.Link.Label }
                    |> setContent
                    setError(None)
                | Error e ->
                    setError(Some (sprintf "Status %d: Failed parsing JSON object:\n%s" statusCode e))
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
        ]

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```