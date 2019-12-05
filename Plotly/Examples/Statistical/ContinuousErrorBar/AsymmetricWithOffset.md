# Feliz.Plotly - Continuous Error Bars

Taken from [Plotly - Continuous Error Bars](https://plot.ly/javascript/continuous-error-bars/)

```fsharp:plotly-chart-continuouserrorbar-asymmetricwithoffset
[<RequireQualifiedAccess>]
module Samples.ContinuousErrorBar.AsymmetricWithOffset

open Feliz
open Feliz.Plotly
open System

let randomDates (dates: (int * int * int) list) (count: int) =
    dates
    |> Seq.ofList // See https://github.com/fable-compiler/Fable/issues/1934
    |> Seq.chunkBySize 2
    |> Seq.map List.ofArray
    |> List.ofSeq
    |> List.collect (fun dates ->
        [ 1 .. count ]
        |> List.collect (fun i ->
        match dates with
        | [ (y,m,d); (y2,m2,d2) ] ->
            let startDate = DateTime(y,m,d).Ticks
            let endDate = DateTime(y2,m2,d2).Ticks
            (startDate - endDate) 
            |> (fun n -> n * (i |> int64))
            |> ((+) startDate)
            |> DateTime
            |> List.singleton
        | _ -> [ ]))

let randomNumber num mul =
    let rng = Random()
    [ 1 .. num ]
    |> List.map (fun _ -> rng.Next() * mul)

let chart () =
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x (randomDates [ (2001, 01, 01); (2001, 02, 01) ] 50)
                scatter.y (randomNumber 50 20)
                scatter.line [
                    line.width 0
                ]
                scatter.marker [
                    marker.color "#444"
                ]
                scatter.mode.lines
                scatter.name "Lower Bound"
            ]
            traces.scatter [
                scatter.x (randomDates [ (2001, 01, 01); (2001, 02, 01) ] 50)
                scatter.y (randomNumber 50 21)
                scatter.fill.tonexty
                scatter.fillcolor (color.rgba(68, 68, 68, 0.3))
                scatter.line [
                    line.color (color.rgb(31, 118, 180))
                ]
                scatter.mode.lines
                scatter.name "Measurement"
            ]
            traces.scatter [
                scatter.x (randomDates [ (2001, 01, 01); (2001, 02, 01) ] 50)
                scatter.y (randomNumber 50 22)
                scatter.fill.tonexty
                scatter.fillcolor (color.rgba(68, 68, 68, 0.3))
                scatter.line [
                    line.width 0
                ]
                scatter.marker [
                    marker.color "#444"
                ]
                scatter.mode.lines
                scatter.name "Upper Bound"
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.title [
                title.text "Continuous, variable value error bars<br>Notice the hover text!"
            ]
            layout.yaxis [
                yaxis.title [
                    title.text "Wind speed (m/s)"
                ]
            ]
        ]
    ]
```