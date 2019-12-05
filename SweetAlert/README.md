# Feliz.SweetAlert (alpha) [![Nuget](https://img.shields.io/nuget/v/Feliz.SweetAlert.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.SweetAlert)

Fable bindings for [sweetalert2](https://github.com/sweetalert2/sweetalert2) and [sweetalert2-react-content](https://github.com/sweetalert2/sweetalert2-react-content) with [Feliz](https://github.com/Zaid-Ajaj/Feliz) style api for use within React applications.

Implemented as both normal functions and Elmish commands, for maximum flexibility.

See the full documentation with live examples: [https://shmew.github.io/Feliz.SweetAlert](https://shmew.github.io/Feliz.SweetAlert/)

A quick look:

```fs
Html.button [
    prop.onClick <| fun _ -> Swal.fire [ swal.text "Howdy!" ]
    prop.text "Fire!"
]
```

With React components and Elmish:

```fs
open Elmish
open Fable.Core.JsInterop
open Feliz
open Feliz.ElmishComponents
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

let titleComp = React.functionComponent (fun (input: {| text: string |}) -> 
    Html.p [ 
        prop.className Bulma.ModalCardTitle

        prop.children (
            Html.strong [ 
                Html.u [ prop.text input.text ] 
            ]
        )
    ])

let bodyComp = React.functionComponent (fun (input: {| link: string |}) ->
    Html.div [
        prop.className Bulma.ModalCardBody
        
        prop.children (
            Html.a [
                prop.href input.link
                prop.target.blank
                prop.text "Back to the repo!"
            ]
        )
    ])

let confirmButtonComp = React.functionComponent (fun () ->
    React.fragment [
        Html.p [
            prop.classes [ FA.Fa; FA.FaThumbsUp ]
    
        ]
        Html.p [
            prop.text "Great!"
        ]
    ])

let cancelButtonComp = React.functionComponent ( fun () ->
    React.fragment [
        Html.p [
            prop.classes [ FA.Fa; FA.FaThumbsDown ]
    
        ]
        Html.p [
            prop.text "Not so great."
        ]
    ])

type Model = { Text: string }

let init () = { Text = "Howdy!" }, Cmd.none

type Msg =
    | GetResponse of string
    | SendAlert of string

let update msg model =
    match msg with
    | GetResponse rsp -> { model with Text = rsp }, Cmd.none
    | SendAlert url ->
        model, Cmd.Swal.fire ([
            swal.title (titleComp {| text = "Look at this title!" |})
            swal.icon.info
            swal.html (bodyComp {| link = url |})
            swal.showCloseButton true
            swal.showCancelButton true
            swal.focusConfirm false
            swal.confirmButtonText (confirmButtonComp())
            swal.cancelButtonText (cancelButtonComp())
        ], (fun res -> 
            match res with
            | SweetAlertResult.ResultValue _ -> Some (GetResponse "I'm glad you like it!")
            | _ -> None))

let view = React.functionComponent (fun (input: {| model: Model; dispatch: Msg -> unit |}) ->
    let url = "https://github.com/Shmew/Feliz.SweetAlert"

    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.div [
                Html.p input.model.Text
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> input.dispatch (SendAlert url)
                prop.text "Fire!"
            ]
        ]
    ])

let render () = React.elmishComponent("ElmishWithReact",init(), update, (fun model dispatch -> view {| model = model; dispatch = dispatch |}))
```

If you do not use [Feliz](https://github.com/Zaid-Ajaj/Feliz) or need inline alerts there are alternative bindings over at [Elmish.SweetAlert](https://github.com/Zaid-Ajaj/Elmish.SweetAlert).
