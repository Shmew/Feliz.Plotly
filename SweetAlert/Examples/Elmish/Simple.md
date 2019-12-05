# Feliz.SweetAlert - Simple Elmish Alerts

```fsharp:swal-elmish-simple
[<RequireQualifiedAccess>]
module Samples.Elmish.Simple

open Elmish
open Feliz
open Feliz.ElmishComponents
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

type Model = { Text: string }

let init () = { Text = "Howdy!" }, Cmd.none

type Msg =
    | SendAlert

let update msg model =
    match msg with
    | SendAlert ->
        model, Cmd.Swal.Simple.success("From Elmish", model.Text)
        
let view = React.functionComponent (fun (input: {| model: Model; dispatch: Msg -> unit |}) ->
    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> input.dispatch SendAlert
                prop.text "Fire!"
            ]
        ]
    ])

let render () = React.elmishComponent("ElmishBasic",init(), update, (fun model dispatch -> view {| model = model; dispatch = dispatch |}))
```