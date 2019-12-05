# Feliz.SweetAlert - Timeouts

```fsharp:swal-closetimer
[<RequireQualifiedAccess>]
module Samples.CloseTimer

open Fable.Core
open Feliz
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

[<Emit("setTimeout($0, $1)")>]
let setInterval (f: unit -> unit) (timeout: int) : int = jsNative

[<Emit("clearInterval($0)")>]
let clearInterval (f: int) : unit = jsNative 

let closeTimer = React.functionComponent(fun () ->
    let timeLeft, setTimeLeft = React.useState(Some 2000)

    let subscribeToTimeout() =
        let subscriptionId = setInterval(fun () -> Swal.getTimerLeft() |> setTimeLeft) 100
        { new System.IDisposable with member _.Dispose() = clearInterval(subscriptionId) }

    React.useEffect(subscribeToTimeout)

    Html.p (sprintf "I will close in %i miliseconds." (timeLeft |> Option.defaultValue 0)))

let render = React.functionComponent (fun () ->
    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> 
                    Swal.fire [
                        swal.title "Auto close alert!"
                        swal.html (closeTimer())
                        swal.timer 2000
                        swal.onBeforeOpen(fun _ -> Swal.showLoading())
                    ]
                prop.text "Fire!"
            ]
        ]
    ])
```