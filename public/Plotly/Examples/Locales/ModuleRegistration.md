# Feliz.Plotly - Locale Module Registration

Localization can also be changed at a site-wide level through
the use of Plotly module registration which is exposed as hooks.

You will notice that the modebars will change based on the button clicked below.

```fsharp:plotly-chart-locales-moduleregistration
[<RequireQualifiedAccess>]
module Samples.Locales.ModuleRegistration

open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

let chart = React.functionComponent(fun () ->
    let toggledLang,setToggledLang = React.useState false

    Plotly.useLocale "example" [
        locale.format [
            format.days [
                "Sunday-Changed"
                "Monday-Changed"
                "Tuesday-Changed"
                "Wednesday-Changed"
                "Thursday-Changed"
                "Friday-Changed"
                "Saturday-Changed"
            ]
        ]
    ]
    
    Plotly.useLocales [
        Locales.de
        Locales.fr
    ]

    React.fragment [
        Plotly.plot [
            plot.traces [
                traces.bar [
                    bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                    bar.y [ 20; 14; 23 ]
                ]
            ]
            plot.config [
                if toggledLang then config.locale.fr
                else config.locale.de
            ]
        ]
        Html.div [
            prop.className Bulma.Control
            prop.style [
                style.paddingLeft (length.em 8)
                style.paddingBottom (length.em 1)
            ]
            prop.children [
                Html.button [
                    prop.classes [ Bulma.Button; if not toggledLang then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                    prop.onClick <| fun _ -> setToggledLang false
                    prop.text "German"
                ]
                Html.button [
                    prop.classes [ Bulma.Button; if toggledLang then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                    prop.onClick <| fun _ -> setToggledLang true
                    prop.text "French"
                ]
            ]
        ]
    ])
```