# Feliz.Plotly - Choropleth Maps

Taken from [Plotly - Choropleth Maps](https://plot.ly/javascript/choropleth-maps)

```fsharp:plotly-chart-maps-choropleth
[<RequireQualifiedAccess>]
module Samples.Maps.Choropleth

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type Precipitation =
    { Headers: string []
      Location: string []
      Alcohol: float [] }

    member this.AddDataSet (data: string []) =
        { this with
            Location = Array.append this.Location (data.[0] |> Array.singleton)
            Alcohol = Array.append this.Alcohol (data.[1] |> float |> Array.singleton) }

module Precipitation =
    let empty =
        { Headers = [||]
          Location = [||]
          Alcohol = [||] }

let render (data: Precipitation) =
    Plotly.plot [
        plot.traces [
            traces.choropleth [
                choropleth.locationmode.countryNames
                choropleth.locations data.Location
                choropleth.z data.Alcohol
                choropleth.text data.Location
                choropleth.autocolorscale true
            ]
        ]
        plot.layout [
            layout.title [
                title.text "Pure alcohol consumption<br>among adults (age 15+) in 2010"
            ]
            layout.geo [
                geo.projection [
                    projection.type'.robinson
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState Precipitation.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/2010_alcohol_consumption_by_country.csv"

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
                |> Array.fold (fun (state: Precipitation) (values: string []) -> state.AddDataSet values) content
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