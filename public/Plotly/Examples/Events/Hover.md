# Feliz.Plotly - Hover Events

Taken from [Plotly - Hover Events](https://plot.ly/javascript/hover-events/)

```fsharp:plotly-chart-events-hover
[<RequireQualifiedAccess>]
module Samples.Events.Hover

open Fable.Core
open Feliz
open Feliz.Plotly

let rng = System.Random()

let getYData i =
    List.init 100 (fun _ -> rng.NextDouble() * (float i))

let plotElem = React.memo(fun (input: {| callback: (int * float) option -> unit |}) ->
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x [ 1 .. 100 ]
                scatter.y (getYData 1)
                scatter.mode.lines
                scatter.name "Jeff"
            ]
            traces.scatter [
                scatter.x [ 1 .. 100 ]
                scatter.y (getYData 2)
                scatter.mode.lines
                scatter.name "Terren"
            ]
            traces.scatter [
                scatter.x [ 1 .. 100 ]
                scatter.y (getYData 3)
                scatter.mode.lines
                scatter.name "Arthur"
            ]
        ]
        plot.layout [
            layout.hovermode.closest
            layout.title "Capturing hover event data"
        ]
        plot.onHover <| fun ev ->
            ev.points 
            |> List.ofSeq
            |> List.tryFind (fun datum -> datum.x.IsSome && datum.y.IsSome)
            |> Option.iter(fun datum -> 
                match datum.x, datum.y with
                | Events.Int x, Events.Float y -> (x,y) |> Some |> input.callback
                | _ -> None |> input.callback)
    ])

let chart = React.functionComponent (fun () ->
    let hoverPoint,setHoverPoint = React.useState None

    let setPointCallback = React.useCallback(setHoverPoint)

    Html.div [
        Html.div [
            match hoverPoint with
            | Some(x,y) ->
                prop.text (sprintf "Hovered points: (%i, %f)" x y)
            | None -> ()
        ]
        plotElem {| callback = setPointCallback |}
    ])
```