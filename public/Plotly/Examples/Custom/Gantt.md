# Feliz.Plotly - Custom Charts

```fsharp:plotly-chart-custom-gantt
[<RequireQualifiedAccess>]
module Samples.Custom.Gantt

open Feliz
open Feliz.Plotly
open System

let rng = Random()

type GanttData =
    { Task: string
      Start: System.DateTime
      Finish: System.DateTime } 

type Task =
    { x0: System.DateTime
      x1: System.DateTime
      y0: float
      y1: float
      name: string }

let chart () =
    let tasks =
        [ 0 .. 20 ]
        |> List.map (fun i -> 
            let start = rng.Next(1, 29) 
            { Task = sprintf "Task %i" i
              Start = DateTime(2019, 11, start)
              Finish = DateTime(2019, 11, rng.Next(start, 30)) })
        |> List.rev
        |> List.mapi (fun i gd ->
            { x0 = gd.Start
              x1 = gd.Finish
              y0 = (float i) - 0.4
              y1 = (float i) + 0.4
              name = gd.Task })

    let getCornerPoints task =
        {| x = [ task.x0; task.x1; task.x1; task.x0 ]
           y = [ task.y0; task.y0; task.y1; task.y1 ] |}

    let scatters =
        tasks
        |> List.map (fun task ->
            let cps = getCornerPoints task
            traces.scatter [
                scatter.x cps.x
                scatter.y cps.y
                scatter.mode.none
                scatter.fill.toself
                scatter.hoverinfo.name
                scatter.name task.name
            ])

    Plotly.plot [
        plot.traces (scatters)
        plot.layout [
            layout.title [
                title.text "Gantt Chart"
            ]
            layout.showlegend false
            layout.height 800
            layout.width 1000
            layout.shapes []
            layout.hovermode.closest
            layout.yaxis [
                yaxis.showgrid true
                yaxis.ticktext (tasks |> List.map (fun t -> t.name))
                yaxis.tickvals [ 0 .. (tasks.Length-1) ]
                yaxis.range [ -1; tasks.Length ]
                yaxis.autorange.false'
                yaxis.zeroline false
            ]
            layout.xaxis [
                xaxis.showgrid true
                xaxis.zeroline false
                xaxis.rangeselector [
                    rangeselector.buttons [
                        buttons.button [
                            button.count 7
                            button.label "1w"
                            button.step.day
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.count 1
                            button.label "1m"
                            button.step.month
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.count 6
                            button.label "6m"
                            button.step.month
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.count 1
                            button.label "YTD"
                            button.step.year
                            button.stepmode.todate
                        ]
                        buttons.button [
                            button.count 1
                            button.label "1y"
                            button.step.year
                            button.stepmode.backward
                        ]
                        buttons.button [
                            button.step.all
                        ]
                    ]
                ]
                xaxis.type'.date
            ]
        ]
    ]
```