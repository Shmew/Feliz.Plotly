# Feliz.Plotly - Click Events

Taken from [Plotly - Click Events](https://plot.ly/javascript/click-events/)

```fsharp:plotly-chart-events-click
[<RequireQualifiedAccess>]
module Samples.Events.Click

open Fable.Core
open Feliz
open Feliz.Plotly

let rng = System.Random()

let annotationText x y =
    sprintf "x = %i%sy = %.4f" x System.Environment.NewLine y

let getYData i =
    List.init 100 (fun _ -> rng.NextDouble() * (float i))

let xData = [ 1 .. 100 ]

let yData = getYData 1
let yData2 = getYData 2
let yData3 = getYData 3

let chart = React.functionComponent (fun () ->
    let anns,setAnns = React.useState []

    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xData
                scatter.y yData
                scatter.mode.lines
                scatter.name "Jeff"
            ]
            traces.scatter [
                scatter.x xData
                scatter.y yData2
                scatter.mode.lines
                scatter.name "Terren"
            ]
            traces.scatter [
                scatter.x xData
                scatter.y yData3
                scatter.mode.lines
                scatter.name "Arthur"
            ]
        ]
        plot.layout [
            layout.hovermode.closest // When this value is set click and hover events always return a singleton in `ev.points`
            layout.title "Annotations on click"
            layout.annotations anns
        ]
        plot.onClick <| fun ev ->
            ev.points 
            |> List.ofSeq
            |> List.choose (fun datum -> 
                match datum.x, datum.y with
                | Events.Int x, Events.Float y ->
                    annotations.annotation [
                        annotation.x x
                        annotation.y y
                        annotation.text (annotationText x y)
                    ]
                    |> Some
                | _ -> None)
            |> setAnns
    ])
```