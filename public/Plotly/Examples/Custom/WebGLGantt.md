# Feliz.Plotly - Custom Charts

```fsharp:plotly-chart-custom-webglgantt
[<RequireQualifiedAccess>]
module Samples.Custom.WebGLGantt

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
        [ 0 .. 2000 ]
        |> List.map (fun i -> 
            let month = rng.Next(1,12)
            let start = rng.Next(1, 29) 
            { Task = sprintf "Task %i" i
              Start = DateTime(2019, (if month > 1 then month-1 else month), start)
              Finish = DateTime(2019, month, rng.Next(start, 30)) })
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
            traces.scattergl [
                scattergl.x cps.x
                scattergl.y cps.y
                scattergl.mode.none
                scattergl.fill.toself
                scattergl.hoverinfo.name
                scattergl.name task.name
            ])

    Plotly.plot [
        plot.style [
            style.minWidth (length.vh 50)
            style.minHeight (length.vh 70)
        ]
        plot.traces scatters
        plot.layout [
            layout.autosize true
            layout.hovermode.closest
            layout.margin [
                margin.r 30
                margin.pad 10
            ]
            layout.showlegend false
            layout.title [
                title.text "Task Schedule"
            ]
            layout.xaxis [
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
                xaxis.showgrid true
                xaxis.tickfont [
                    tickfont.size 10
                ]
                xaxis.type'.date
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.automargin true
                yaxis.autorange.false'
                yaxis.fixedrange true
                yaxis.range [ -1; tasks.Length ]
                yaxis.showgrid true
                yaxis.tickfont [
                    tickfont.size 12
                ]
                yaxis.ticktext (tasks |> List.map (fun t -> t.name + "  "))
                yaxis.tickvals [ 0 .. (tasks.Length-1) ]
                yaxis.zeroline false
            ]
        ]
        plot.config [
            config.autosizable true
            config.displaylogo false
            config.doubleClick.resetAndAutosize
            config.modeBarButtonsToRemove [
                modeBarButtons.autoScale2d
                modeBarButtons.hoverCompareCartesian
                modeBarButtons.hoverClosestCartesian
                modeBarButtons.toggleSpikelines
                modeBarButtons.zoomIn2d
                modeBarButtons.zoomOut2d
            ]
            config.responsive true
            config.scrollZoom.true'
            config.showAxisDragHandles false
        ]
    ]
```