# Feliz.Plotly - Mixed Subplots

Taken from [Plotly - Mixed Subplots](https://plot.ly/javascript/mixed-subplots/)

```fsharp:plotly-chart-subplots-mixed
[<RequireQualifiedAccess>]
module Samples.Subplots.Mixed

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type CsvData =
    { Headers: string []
      Number: string []
      Volcano: string []
      Country: string []
      Region: string []
      Latitude: float option []
      Longitude: float option []
      Elevation: float option []
      Type': string []
      Status: string []
      LastKnown: string [] }

    member this.AddDataSet (data: string []) =
        let tryFloat f =
            try float f |> Some
            with _ -> None

        { this with
            Number = Array.append this.Number (data.[0] |> Array.singleton)
            Volcano = Array.append this.Volcano (data.[1] |> Array.singleton)
            Country = Array.append this.Country (data.[2] |> Array.singleton) 
            Region = Array.append this.Region (data.[3] |> Array.singleton) 
            Latitude = Array.append this.Latitude (data.[4] |> tryFloat |> Array.singleton) 
            Longitude = Array.append this.Longitude (data.[5] |> tryFloat |> Array.singleton) 
            Elevation = Array.append this.Elevation (data.[6] |> tryFloat |> Array.singleton) 
            Type' = Array.append this.Type' (data.[7] |> Array.singleton) 
            Status = Array.append this.Status (data.[8] |> Array.singleton) 
            LastKnown = Array.append this.LastKnown (data.[9] |> Array.singleton)  }

module CsvData =
    let empty =
        { Headers = [||]
          Number = [||]
          Volcano = [||]
          Country = [||]
          Region = [||]
          Latitude = [||]
          Longitude = [||]
          Elevation = [||]
          Type' = [||]
          Status = [||]
          LastKnown = [||] }

let render (data: CsvData) =
    Plotly.plot [
        plot.traces [
            traces.scatter3d [
                scatter3d.x data.Status
                scatter3d.y data.Type'
                scatter3d.z data.Elevation
                scatter3d.marker [
                    marker.size 2
                    marker.color (data.Elevation |> Array.map (Option.defaultValue 0.))
                    marker.colorscale color.colorscale.reds
                    marker.line [
                        line.color color.transparent
                    ]
                ]
                scatter3d.mode.markers
                scatter3d.text data.Country
                scatter3d.hoverinfo [
                    scatter3d.hoverinfo.x
                    scatter3d.hoverinfo.y
                    scatter3d.hoverinfo.z
                    scatter3d.hoverinfo.text
                ]
                scatter3d.showlegend false
            ]
            traces.histogram [
                histogram.x data.Elevation
                histogram.hoverinfo [
                    histogram.hoverinfo.x
                    histogram.hoverinfo.y
                ]
                histogram.showlegend false
                histogram.xaxis 2
                histogram.yaxis 2
                histogram.marker [
                    marker.color color.red
                ]
            ]
            traces.scattergeo [
                scattergeo.geo 3
                scattergeo.locationmode.ISO3
                scattergeo.lon data.Longitude
                scattergeo.lat data.Latitude
                scattergeo.hoverinfo.text
                scattergeo.text (data.Elevation |> Array.map string)
                scattergeo.mode.markers
                scattergeo.showlegend false
                scattergeo.marker [
                    marker.size 4
                    marker.color (data.Elevation |> Array.map (Option.defaultValue 0.))
                    marker.colorscale color.colorscale.reds
                    marker.opacity 0.8
                    marker.symbol.circle
                    marker.line [
                        line.width 1
                    ]
                ]
            ]
        ]
        
        plot.layout [
            layout.paperBgcolor color.black
            layout.plotBgcolor color.black
            layout.title "Volcano Database Elevation"
            layout.font [
                font.color color.white
            ]
            layout.annotations [
                annotations.annotation [
                    annotation.x 0
                    annotation.y 0
                    annotation.xref.paper
                    annotation.yref.paper
                    annotation.text "Source: NDAA"
                    annotation.showarrow false
                ]
            ]
            layout.geo (3, [
                geo.domain [
                    domain.x [ 0.; 0.45 ]
                    domain.y [ 0.02; 0.98 ]
                ]
                geo.scope.world
                geo.projection [
                    projection.type'.orthographic
                ]
                geo.showland true
                geo.landcolor (color.rgb(255, 255, 255))
                
                geo.showocean true
                geo.oceancolor (color.rgb(6, 66, 115))
                
                geo.showlakes true
                geo.lakecolor (color.rgb(127, 205, 255))

                geo.subunitcolor (color.rgb(217, 217, 217))
                geo.subunitwidth 0.5
                
                geo.countrycolor (color.rgb(217, 217, 217))
                geo.countrywidth 0.5
                
                geo.bgcolor color.black
            ])
            layout.scene [
                scene.domain [
                    domain.x [ 0.55; 1. ]
                    domain.y [ 0.; 0.6 ]
                ]
                scene.xaxis [
                    xaxis.title "Status"
                    xaxis.showticklabels false
                    xaxis.showgrid true
                    xaxis.gridcolor color.white
                ]
                scene.yaxis [
                    yaxis.title "Type"
                    yaxis.showticklabels false
                    yaxis.showgrid true
                    yaxis.gridcolor color.white
                ]
                scene.zaxis [
                    zaxis.title "Elev"
                    zaxis.showgrid true
                    zaxis.gridcolor color.white
                ]
            ]
            layout.yaxis (2, [
                yaxis.anchor.x 2
                yaxis.domain [ 0.7; 1. ]
                yaxis.showgrid false
            ])
            layout.xaxis (2, [
                xaxis.anchor.y 2
                xaxis.domain [ 0.6; 1. ]
                xaxis.tickangle 45
                xaxis.ticksuffix "m"
            ])
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState CsvData.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/volcano_db.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map (fun s -> s.Trim().Split(','))

                fullData
                |> Array.tail
                |> Array.fold (fun (state: CsvData) (values: string []) -> state.AddDataSet values) content
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