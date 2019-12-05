# Feliz.SweetAlert - Basic Alerts

```fsharp:swal-simple-basic
[<RequireQualifiedAccess>]
module Samples.Simple.Basic

open Feliz
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

let render = React.functionComponent (fun () ->
    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.basic "Howdy!"
                prop.text "Basic"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.error "Howdy!"
                prop.text "Error"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.info "Howdy!"
                prop.text "Info"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.question "Howdy!"
                prop.text "Question"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.success "Howdy!"
                prop.text "Success"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.warning "Howdy!"
                prop.text "Warning"
            ]
        ]
    ])
```