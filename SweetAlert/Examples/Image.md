# Feliz.SweetAlert - Loading Images

```fsharp:swal-image
[<RequireQualifiedAccess>]
module Samples.Image

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
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> 
                    Swal.fire [
                        swal.title "Modal with a custom image"
                        swal.imageUrl "https://unsplash.it/400/200"
                        swal.imageWidth 400
                        swal.imageHeight 200
                        swal.imageAlt "Custom image"
                    ]
                prop.text "Fire!"
            ]
        ]
    ])
```