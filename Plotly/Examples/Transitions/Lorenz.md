# Feliz.Plotly - Transitions

```fsharp:plotly-chart-transitions-lorenz
[<RequireQualifiedAccess>]
module Samples.Transitions.Lorenz

open Elmish
open Fable.Core
open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

[<Emit("clearTimeout($0)")>]
let clearTimeout (id: int) : unit = jsNative

[<Emit("setTimeout($0, $1)")>]
let setTimeout (f: unit -> unit) (timeout: int) : int = jsNative

let rng = System.Random()

let plotLorenz = React.functionComponent(fun (data: {| x: float list; y: float list |}) ->
    Plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x data.x
                scatter.y data.y
                scatter.mode.markers
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.transition [
                transition.duration 0
                transition.easing.linear
                transition.ordering.tracesFirst
            ]
            layout.xaxis [
                xaxis.range [ -40; 40 ]
                xaxis.showgrid false
                xaxis.showdividers false
                xaxis.showticklabels false
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.range [ 0; 60 ]
                yaxis.showgrid false
                yaxis.showdividers true
                yaxis.showticklabels false
                yaxis.zeroline false
            ]
        ]
        plot.config [
            config.displayModeBar.false'
        ]
    ])

let initX, initY, initZ = 
    List.init 100 (fun _ -> rng.NextDouble() * 2. - 1.),
    List.init 100 (fun _ -> rng.NextDouble() * 2. - 1.),
    List.init 100 (fun _ -> 30. + rng.NextDouble() * 10.)

module Constants =
    let s = 10.
    let b = 8./3.
    let r = 28.
    let dt = 0.015

let calcLorenz data =
    data
    |> List.map (fun (x, y, z) ->
        let dx = Constants.s * (y - x)
        let dy = x * (Constants.r - z) - y
        let dz = x * y - Constants.b * z

        let xh = x + dx * Constants.dt * 0.5
        let yh = y + dy * Constants.dt * 0.5
        let zh = z + dz * Constants.dt * 0.5

        let dx = Constants.s * (yh - xh)
        let dy = xh * (Constants.r - zh) - yh
        let dz = xh * yh - Constants.b * zh

        x + dx * Constants.dt,
        y + dy * Constants.dt,
        z + dz * Constants.dt)

let chart = React.functionComponent(fun () ->
    let data,setData = React.useState(List.zip3 initX initY initZ)
    
    React.useEffect(fun () -> 
        let subId = 
            setTimeout (fun _ -> setData (calcLorenz data)) 0
        React.createDisposable(fun () -> clearTimeout(subId))
    )

    let plotLorenz =
        React.useMemo((fun () ->
            data 
            |> List.unzip3
            |> fun (x, _, y) -> plotLorenz {| x = x; y = y |}
        ), [| data |])

    plotLorenz)
```