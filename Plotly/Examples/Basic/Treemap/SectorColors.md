# Feliz.Plotly - Treemaps

Taken from [Plotly - Treemaps](https://plot.ly/javascript/treemaps/)

```fsharp:plotly-chart-treemap-sectorcolors
[<RequireQualifiedAccess>]
module Samples.Treemap.SectorColors

open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type private Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

type private ColorScheme =
    | Markers
    | Colorway
    | Colorscale

type private State =
    { ColorScheme: ColorScheme }

type private Msg =
    | ChangeScheme of ColorScheme

let private init = { ColorScheme = Markers }

let private update (state: State) = function
    | ChangeScheme colorScheme -> { state with ColorScheme = colorScheme }

let private labels = [ "A1"; "A2"; "A3"; "A4"; "A5"; "B1"; "B2" ]
let private parents = [ ""; "A1"; "A2"; "A3"; "A4"; ""; "B1" ]

let private markersChart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
                treemap.marker [
                    marker.colors [
                        colors.pink
                        colors.royalBlue
                        colors.lightGray
                        colors.purple
                        colors.cyan
                        colors.lightGray
                        colors.lightBlue
                    ]
                ]
            ]
        ]
    ]

let private colorwayChart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
            ]
        ]
        plot.layout [
            layout.treemapcolorway [
                colors.pink
                colors.lightGray
            ]
        ]
    ]

let private colorscaleChart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
                treemap.values [ "11"; "12"; "13"; "14"; "15"; "20"; "30" ]
                treemap.marker [
                    marker.colorscale "Blues"
                ]
            ]
        ]
    ]

let chart = React.functionComponent <| fun () ->
    let (state, dispatch) = React.useReducer(update, init)

    Html.div [
        match state.ColorScheme with
        | Markers -> markersChart()
        | Colorway -> colorwayChart()
        | Colorscale -> colorscaleChart()
        Html.div [
            prop.className Bulma.Control
            prop.style [
                style.paddingLeft (length.em 8)
                style.paddingBottom (length.em 1)
            ]
            prop.children [
                Html.button [
                    prop.classes [ Bulma.Button; if state.ColorScheme = Markers then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                    prop.onClick <| fun _ -> dispatch (ChangeScheme Markers)
                    prop.text "Marker Colors"
                ]
                Html.button [
                    prop.classes [ Bulma.Button; if state.ColorScheme = Colorway then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                    prop.onClick <| fun _ -> dispatch (ChangeScheme Colorway)
                    prop.text "Layout Colorway"
                ]
                Html.button [
                    prop.classes [ Bulma.Button; if state.ColorScheme = Colorscale then yield! [ Bulma.IsActive; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite ] ]
                    prop.onClick <| fun _ -> dispatch (ChangeScheme Colorscale)
                    prop.text "Marker Colorscale"
                ]
            ]
        ]
    ]
```