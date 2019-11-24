# Feliz.Plotly - Transitions

```fsharp:plotly-chart-transitions-basic
[<RequireQualifiedAccess>]
module Samples.Transitions.Basic

open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

let chart = React.functionComponent(fun () ->
    let xData,setXData = React.useState([ 1; 2; 3; 4 ])

    Html.fragment [
        Plotly.plot [
            plot.traces [
                traces.scatter [
                    scatter.x [ 1; 2; 3; 4 ]
                    scatter.y [ 10; 15; 13; 17 ]
                    scatter.mode.markers
                ]
                traces.scatter [
                    scatter.x xData
                    scatter.y [ 16; 5; 11; 9 ]
                    scatter.mode.lines
                ]
                traces.scatter [
                    scatter.x [ 1; 2; 3; 4 ]
                    scatter.y [ 12; 9; 15; 12 ]
                    scatter.mode [
                        scatter.mode.lines
                        scatter.mode.markers
                    ]
                ]
            ]
            plot.layout [
                layout.transition [
                    transition.duration 2000
                    transition.easing.cubicInOut
                    transition.ordering.tracesFirst
                ]
            ]
        ]
        Html.div [
            prop.className Bulma.Control
            prop.style [
                style.paddingLeft (length.em 8)
                style.paddingBottom (length.em 1)
            ]
            prop.children [
                Html.button [
                    prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ]
                    prop.onClick <| fun _ -> 
                        if xData = [ 1; 2; 3; 4] then [ 2; 3; 4; 5] 
                        else [ 1; 2; 3; 4 ]
                        |> setXData
                    prop.text "Transition!"
                ]
            ]
        ]
    ])
```