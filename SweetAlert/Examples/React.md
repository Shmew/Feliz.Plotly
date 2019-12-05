# Feliz.SweetAlert - Using React Components

```fsharp:swal-react
[<RequireQualifiedAccess>]
module Samples.React

open Fable.Core.JsInterop
open Feliz
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

let render = React.functionComponent (fun () ->
    let url = "https://github.com/Shmew/Feliz.SweetAlert"

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
                        swal.title (titleComp {| text = "Look at this title!" |})
                        swal.icon.info
                        swal.html (bodyComp {| link = url |})
                        swal.showCloseButton true
                        swal.showCancelButton true
                        swal.focusConfirm false
                        swal.confirmButtonText (confirmButtonComp())
                        swal.cancelButtonText (cancelButtonComp())
                    ]
                prop.text "Fire!"
            ]
        ]
    ])
```