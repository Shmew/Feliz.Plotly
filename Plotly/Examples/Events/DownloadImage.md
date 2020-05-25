# Feliz.Plotly - Downloading Images Programmatically

```fsharp:plotly-chart-events-downloadimage
open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

let plot = React.functionComponent(fun () ->
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
            ]
        ]
        plot.divId "myChart"
    ])

let buttons = React.functionComponent(fun () ->
    let imgSrc,setImgSrc = React.useState(None)

    Html.div [
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
                            // this is the default
                            downloadImage.format.png
                            downloadImage.height 500
                            downloadImage.width 500
                        ])
                    prop.text "Download"
                ]
                Html.button [
                    prop.classes [ 
                        Bulma.Button
                        Bulma.HasBackgroundPrimary
                        Bulma.HasTextWhite 
                    ]
                    prop.style [
                        style.maxWidth (length.em 8)
                    ]
                    prop.onClick <| fun _ -> 
                        async {
                            let! imgUrl =
                                Plotly.toImage("myChart", [
                                    // this is the default
                                    toImage.format.png
                                    toImage.height 500
                                    toImage.width 500
                                ])
                            Browser.Dom.window.alert(imgUrl)
                            setImgSrc(Some imgUrl)
                        }
                        |> Async.StartImmediate
                    prop.text "To Image URL"
                ]
            ]
        ]
        if imgSrc.IsSome then
            Html.img [
                prop.src imgSrc.Value
            ]
    ])

let chart () =
    Html.div [
        plot()
        buttons()
    ]
```