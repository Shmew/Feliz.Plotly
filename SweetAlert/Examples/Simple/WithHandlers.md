# Feliz.SweetAlert - Basic Alerts with Handling

```fsharp:swal-simple-withhandlers
[<RequireQualifiedAccess>]
module Samples.Simple.WithHandlers

open Feliz
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

let render = React.functionComponent (fun () ->
    let state,setState = React.useState ""
    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.div [ prop.text state ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> 
                    Swal.Simple.success("Ooo a title!", "Howdy!", SweetAlertResult.ofValue <| fun _ -> setState "You closed it!")
                prop.text "Fire!"
            ]
        ]
    ])
```