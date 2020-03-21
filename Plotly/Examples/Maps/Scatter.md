# Feliz.Plotly - Mapbox Map Layers

Taken from [Plotly - Mapbox Map Layers](https://plot.ly/javascript/mapbox-layers/)

```fsharp:plotly-chart-maps-scatter
[<RequireQualifiedAccess>]
module Samples.Maps.Scatter

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type Precipitation =
    { Headers: string []
      Hrapx: float []
      Hrapy: float []
      Lat: float []
      Lon: float []
      Globvalue: string [] }

    member this.AddDataSet (data: string []) =
        { this with
            Hrapx = Array.append this.Hrapx (data.[0] |> float |> Array.singleton)
            Hrapy = Array.append this.Hrapy (data.[1] |> float |> Array.singleton)
            Lat = Array.append this.Lat (data.[2] |> float |> Array.singleton)
            Lon = Array.append this.Lon (data.[3] |> float |> Array.singleton)
            Globvalue = Array.append this.Globvalue (data.[4] |> string |> Array.singleton) }

module Precipitation =
    let empty =
        { Headers = [||]
          Hrapx = [||]
          Hrapy = [||]
          Lat = [||]
          Lon = [||]
          Globvalue = [||] }

let render (data: Precipitation) =
    Plotly.plot [
        plot.traces [
            traces.scattermapbox [
                scattermapbox.text data.Globvalue
                scattermapbox.lon data.Lon
                scattermapbox.lat data.Lat
                scattermapbox.marker [
                    marker.color color.fuchsia
                    marker.size 4
                ]
            ]
        ]
        plot.layout [
            layout.dragmode.zoom
            layout.mapbox [
                mapbox.style "white-bg"
                mapbox.layers [
                    layers.layer [
                        layer.below "traces"
                        layer.sourcetype.raster
                        layer.source "https://basemap.nationalmap.gov/arcgis/rest/services/USGSImageryOnly/MapServer/tile/{z}/{y}/{x}"
                    ]
                    layers.layer [
                        layer.sourcetype.raster
                        layer.source "https://geo.weather.gc.ca/geomet/?SERVICE=WMS&VERSION=1.3.0&REQUEST=GetMap&BBOX={bbox-epsg-3857}&CRS=EPSG:3857&WIDTH=1000&HEIGHT=1000&LAYERS=RADAR_1KM_RDBR&TILED=true&FORMAT=image/png"
                        layer.below "traces"
                    ]
                ]
                mapbox.center [
                    center.lat 38
                    center.lon -90
                ]
                mapbox.zoom 4
            ]
            layout.showlegend false
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState Precipitation.empty
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/2015_06_30_precipitation.csv"

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