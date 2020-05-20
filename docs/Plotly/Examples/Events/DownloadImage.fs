[<RequireQualifiedAccess>]
module Samples.Events.DownloadImage

open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

let chart () =
    Html.div [
        Plotly.plot [
            plot.traces [
                traces.bar [
                    bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                    bar.y [ 20; 14; 23 ]
                ]
            ]
            plot.divId "myChart"
        ]
        Html.div [
            prop.className Bulma.Control
            prop.style [
                style.paddingLeft (length.em 4)
                style.paddingBottom (length.em 1)
            ]
            prop.children [
                Html.button [
                    prop.classes [ 
                        Bulma.Button
                        Bulma.HasBackgroundPrimary
                        Bulma.HasTextWhite 
                    ]
                    prop.style [
                        style.maxWidth (length.em 5)
                    ]
                    prop.onClick <| fun _ -> 
                        Plotly.downloadImage("myChart", [
                            downloadImage.fileName "DownloadImageExample"
                            downloadImage.format.webp
                            downloadImage.height 500
                            downloadImage.width 500
                        ])
                    prop.text "Download"
                ]
            ]
        ]
    ]
    