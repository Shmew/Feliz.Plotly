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
        [ 0 .. 200 ]
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

    Html.div [
        prop.style [
            style.paddingLeft (length.em 2)
            style.paddingRight (length.em 1)
            style.width (length.percent 100)
            style.height (length.percent 100)
        ]
        prop.children [
            Plotly.plot [
                plot.style [
                    style.minWidth (length.percent 100)
                    //style.height (tasks.Length * 20)
                ]
                plot.traces scatters
                plot.layout [
                    layout.autosize true
                    layout.height (tasks.Length * 20)
                    layout.hovermode.closest
                    layout.margin [
                        margin.r 30
                        margin.pad 10
                        margin.b 10
                    ]
                    layout.showlegend false
                    layout.title [ title.text "Task Schedule" ]
                    layout.xaxis [
                        xaxis.showgrid true
                        xaxis.range [ DateTime(2019, 1, 1); DateTime(2019, 12, 31) ]
                        xaxis.side.top
                        xaxis.tickfont [ tickfont.size 10 ]
                        xaxis.type'.date
                        xaxis.zeroline false
                    ]
                    layout.yaxis [
                        yaxis.automargin true
                        yaxis.autorange.false'
                        yaxis.fixedrange true
                        yaxis.range [ -1; tasks.Length ]
                        yaxis.showgrid true
                        yaxis.tickfont [ tickfont.size 12 ]
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
                    config.showAxisDragHandles false
                ]
            ]
        ]
    ]
