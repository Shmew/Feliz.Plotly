# Feliz.SweetAlert - Basic Alerts with Titles

```fsharp:swal-simple-withtitles
[<RequireQualifiedAccess>]
module Samples.Simple.WithTitles

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
                prop.onClick <| fun _ -> Swal.Simple.basic("Ooo a title!", "Howdy!")
                prop.text "Basic"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.error("Ooo a title!", "Howdy!")
                prop.text "Error"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.info("Ooo a title!", "Howdy!")
                prop.text "Info"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.question("Ooo a title!", "Howdy!")
                prop.text "Question"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.success("Ooo a title!", "Howdy!")
                prop.text "Success"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ; Bulma.IsLarge ]
                prop.onClick <| fun _ -> Swal.Simple.warning("Ooo a title!", "Howdy!")
                prop.text "Warning"
            ]
        ]
    ])
```