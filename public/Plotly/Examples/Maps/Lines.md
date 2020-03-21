# Feliz.Plotly - Lines on Maps

Taken from [Plotly - Lines on Maps](https://plot.ly/javascript/lines-on-maps/)

```fsharp:plotly-chart-maps-lines
[<RequireQualifiedAccess>]
module Samples.Maps.Lines

open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

let plotColors =
    [| color.rgb(213,62,79); color.rgb(244,109,67); color.rgb(253,174,97)
       color.rgb(254,224,139); color.rgb(255,255,191); color.rgb(230,245,152)
       color.rgb(171,221,164); color.rgb(102,194,165); color.rgb(50,136,189) |]

let plotTraceBase (lineColor: string) (lat: float []) (lon: float []) = 
    traces.scattergeo [
        scattergeo.lon lon
        scattergeo.lat lat
        scattergeo.mode.lines
        scattergeo.line [
            line.width 2
            line.color lineColor
        ]
    ]

let render (data: (string * float [] []) []) =
    Plotly.plot [
        plot.traces [
            yield!
                data
                |> Array.choose (fun (plotColor, latLon) ->
                    match latLon with
                    | [| lat; lon |] -> Some (plotTraceBase plotColor lat lon)
                    | _ -> None)
        ]
        plot.layout [
            layout.geo [
                geo.projection [
                    projection.type'.orthographic
                    projection.rotation [
                        rotation.lon -100
                        rotation.lat 40
                    ]
                ]
                geo.showocean true
                geo.oceancolor (color.rgb(0, 255, 255))
                
                geo.showland true
                geo.landcolor (color.rgb(230, 145, 56))

                geo.showlakes true
                geo.lakecolor (color.rgb(0, 255, 255))

                geo.showcountries true
                geo.lonaxis [
                    lonaxis.showgrid true
                    lonaxis.gridcolor (color.rgb(102, 102, 102))
                ]
                geo.lataxis [
                    lataxis.showgrid true
                    lataxis.gridcolor (color.rgb(102, 102, 102))
                ]
            ]
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState [||]
    let path = "https://raw.githubusercontent.com/plotly/datasets/master/globe_contours.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                responseText.Trim().Split('\n') 
                |> Array.map (fun s -> s.Split(','))
                |> Array.tail
                |> Array.map (Array.map float)
                |> Array.transpose
                |> Array.take 18
                |> Array.chunkBySize 2
                |> Array.zip plotColors
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