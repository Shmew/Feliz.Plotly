# Feliz.SweetAlert - Using CSS Animations

```fsharp:swal-animation
[<RequireQualifiedAccess>]
module Samples.Animation

open Feliz
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type Animate = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.7.2/animate.min.css", Naming.PascalCase>

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
                        swal.title "Custom animation with Animate.css"
                        swal.showClass [
                            showClass.popup [ Animate.Animated; Animate.FadeInDown; Animate.Faster ]
                        ]
                        swal.hideClass [
                            hideClass.popup [ Animate.Animated; Animate.FadeOutUp; Animate.Faster ]
                        ]
                    ]
                prop.text "Fire!"
            ]
        ]
    ])
```