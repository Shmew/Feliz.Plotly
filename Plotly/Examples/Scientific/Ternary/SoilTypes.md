# Feliz.Plotly - Ternary Plots

Taken from [Plotly - Ternary Plots](https://plot.ly/javascript/ternary-plots/)

```fsharp:plotly-chart-ternary-soiltypes
[<RequireQualifiedAccess>]
module Samples.Ternary.SoilTypes

open Fable.SimpleHttp
open Fable.SimpleJson
open Feliz
open Feliz.Plotly

type SoilData =
    { clay: float
      sand: float
      silt: float }

type SoilTypes =
    { sand: SoilData list
      loamysand: SoilData list
      sandyloam: SoilData list
      sandyclayloam: SoilData list
      sandyclay: SoilData list
      clay: SoilData list
      clayloam: SoilData list
      siltyclay: SoilData list
      siltyclayloam: SoilData list
      siltyloam: SoilData list
      silt: SoilData list
      loam: SoilData list }

type PlotItem =
    { Label: string
      Clay: float list
      Sand: float list
      Silt: float list }

module PlotItem =
    let create label (data: SoilData list) = 
        let clay, sand, silt =
            data
            |> List.map (fun d ->
                d.clay, d.sand, d.silt)
            |> List.unzip3
        { Label = label
          Clay = clay
          Sand = sand
          Silt = silt }

    let ofSoilTypes soilTypes =
        [ create "sand" soilTypes.sand
          create "loamy sand" soilTypes.loamysand
          create "sandy loam" soilTypes.sandyloam
          create "sandy clay loam" soilTypes.sandyclayloam
          create "sandy clay" soilTypes.sandyclay
          create "clay" soilTypes.clay
          create "clay loam" soilTypes.clayloam
          create "silty clay" soilTypes.siltyclay
          create "silty clay loam" soilTypes.siltyclayloam
          create "silty loam" soilTypes.siltyloam
          create "silt" soilTypes.silt
          create "loam" soilTypes.loam ]

let render (data: PlotItem list) =
    let scatters =
        data 
        |> List.map (fun pItem ->
            traces.scatterternary [
                scatterternary.mode.lines
                scatterternary.name pItem.Label
                scatterternary.a pItem.Clay
                scatterternary.b pItem.Sand
                scatterternary.c pItem.Silt
                scatterternary.line [
                    line.color "#C00"
                ]
            ]
        )

    Plotly.plot [
        plot.traces scatters
        plot.layout [
            layout.ternary [
                ternary.sum 100
                ternary.aaxis [
                    aaxis.title [
                        title.text "Clay"
                        title.font [
                            font.size 20
                        ]
                    ]
                    aaxis.ticksuffix "%"
                    aaxis.min 0.01
                    aaxis.linewidth 2
                    aaxis.ticks.outside
                    aaxis.ticklen 8
                    aaxis.showgrid true
                ]
                ternary.baxis [
                    baxis.title [
                        title.text "Sand"
                        title.font [
                            font.size 20
                        ]
                    ]
                    baxis.ticksuffix "%"
                    baxis.min 0.01
                    baxis.linewidth 2
                    baxis.ticks.outside
                    baxis.ticklen 8
                    baxis.showgrid true
                ]
                ternary.caxis [
                    caxis.title [
                        title.text "Silt"
                        title.font [
                            font.size 20
                        ]
                    ]
                    caxis.ticksuffix "%"
                    caxis.min 0.01
                    caxis.linewidth 2
                    caxis.ticks.outside
                    caxis.ticklen 8
                    caxis.showgrid true
                ]
            ]
            layout.showlegend false
            layout.width 700
            layout.annotations [
                annotations.annotation [
                    annotation.showarrow false
                    annotation.text """Replica of Daven Quinn's <a href="http://bl.ocks.org/davenquinn/988167471993bc2ece29">block</a>"""
                    annotation.x 0.50
                    annotation.y 1.3
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState []
    let path = "https://gist.githubusercontent.com/davenquinn/988167471993bc2ece29/raw/f38d9cb3dd86e315e237fde5d65e185c39c931c2/data.json"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText
                |> SimpleJson.tryParse
                |> Option.map 
                    (SimpleJson.mapKeys (fun k -> k.Replace(" ", "")) 
                     >> Json.tryConvertFromJsonAs<SoilTypes> 
                     >> Result.map (PlotItem.ofSoilTypes))
                |> function
                | Some res ->
                    match res with
                    | Ok pItemL -> pItemL |> setContent
                    | Error e -> setError (Some (sprintf "Error during data transformations:\n%s" e))
                | None -> setError (Some "Failed to parse Json data")
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