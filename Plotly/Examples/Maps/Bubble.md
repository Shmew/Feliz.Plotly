# Feliz.Plotly - Bubble Maps

Taken from [Plotly - Bubble Maps](https://plot.ly/javascript/bubble-maps/)

```fsharp:plotly-chart-maps-bubble
[<RequireQualifiedAccess>]
module Samples.Maps.Bubble

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type USCities =
    { Headers: string []
      Names: string []
      Population: int []
      Lat: float []
      Lon: float [] }

    member this.AddDataSet (data: string []) =
        { this with
            Names = Array.append this.Names (data.[0] |> Array.singleton)
            Population = Array.append this.Population (data.[1] |> int |> Array.singleton)
            Lat = Array.append this.Lat (data.[2] |> float |> Array.singleton)
            Lon = Array.append this.Lon (data.[3] |> float |> Array.singleton) }

module USCities =
    let empty =
        { Headers = [||]
          Names = [||]
          Population = [||]
          Lat = [||]
          Lon = [||] }

let render (data: USCities) =
    let hoverText, bubbleSize =
        List.foldBack2 (fun name pop (hoverText, bubbleSize) ->
            ((sprintf "%s pop: %i" name pop)::hoverText, (pop / 50000)::bubbleSize)
        ) (data.Names |> List.ofArray) (data.Population |> List.ofArray) ([], [])
        
    Plotly.plot [
        plot.traces [
            traces.scattergeo [
                scattergeo.locationmode.USAStates
                scattergeo.lat data.Lat
                scattergeo.lon data.Lon
                scattergeo.hoverinfo.text
                scattergeo.text hoverText
                scattergeo.marker [
                    marker.size bubbleSize
                    marker.line [
                        line.color color.black
                        line.width 2
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.title [
                title.text "2014 US City Population"
            ]
            layout.showlegend false
            layout.geo [
                geo.scope.usa
                geo.projection [
                    projection.type'.albersUsa
                ]
                geo.showland true
                geo.landcolor (color.rgb(217, 217, 217))
                
                geo.subunitwidth 1
                geo.subunitcolor (color.rgb(255, 255, 255))
                
                geo.countrywidth 1
                geo.countrycolor (color.rgb(255, 255, 255))
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState USCities.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/2014_us_cities.csv"

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
                |> Array.fold (fun (state: USCities) (values: string []) -> state.AddDataSet values) content
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