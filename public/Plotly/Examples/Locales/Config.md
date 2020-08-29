# Feliz.Plotly - Locales in Config

You can configure localization on a per-plot basis through
inline locale registration.

You can see that the modebar buttons have a `-Changed` suffix.

```fsharp:plotly-chart-locales-config
[<RequireQualifiedAccess>]
module Samples.Locales.Config

open Feliz
open Feliz.Plotly

let chart () =
    Plotly.plot [
        plot.traces [
            traces.bar [
                bar.x [ "giraffes"; "orangutans"; "monkeys" ]
                bar.y [ 20; 14; 23 ]
            ]
        ]
        plot.config [
            config.locale "example"
            config.locales [
                locales.locale "example" [
                    locale.dictionary [
                        "Autoscale", "Autoscale-Changed"
                        "Box Select", "Box Select-Changed"
                        "Compare data on hover", "Compare data on hover-Changed"
                        "Download plot as a png", "Download plot as a png-Changed"
                        "Lasso Select", "Lasso Select-Changed"
                        "Pan", "Pan-Changed"
                        "Produced with Plotly", "Produced with Plotly and Feliz"
                        "Reset axes", "Reset axes-Changed"
                        "Show closest data on hover", "Show closest data on hover-Changed"
                        "Toggle Spike Lines", "Toggle Spike Lines-Changed"
                        "Zoom", "Zoom-Changed"
                        "Zoom in", "Zoom in-Changed"
                        "Zoom out", "Zoom out-Changed"
                    ]
                ]
            ]
        ]
    ]
```