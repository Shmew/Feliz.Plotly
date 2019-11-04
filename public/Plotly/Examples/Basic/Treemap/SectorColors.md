# Feliz.Plotly - Treemaps

Taken from [Plotly - Treemaps](https://plot.ly/javascript/treemaps/)

```fsharp:plotly-chart-treemap-sectorcolors
[<RequireQualifiedAccess>]
module Samples.Treemap.SectorColors

open Feliz
open Feliz.Plotly
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

type ColorScheme =
    | Markers
    | Colorway
    | Colorscale

type State =
    { ColorScheme: ColorScheme }

type Msg =
    | ChangeScheme of ColorScheme

let init = { ColorScheme = Markers }

let update (state: State) = function
    | ChangeScheme colorScheme -> { state with ColorScheme = colorScheme }

let labels = [ "A1"; "A2"; "A3"; "A4"; "A5"; "B1"; "B2" ]
let parents = [ ""; "A1"; "A2"; "A3"; "A4"; ""; "B1" ]

let markersChart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
                treemap.marker [
                    marker.colors [
                        color.pink
                        color.royalBlue
                        color.lightGray
                        color.purple
                        color.cyan
                        color.lightGray
                        color.lightBlue
                    ]
                ]
            ]
        ]
    ]

let colorwayChart () =
    Plotly.plot [
        plot.traces [
            traces.treemap [
                treemap.labels labels
                treemap.parents parents
            ]
        ]
        plot.layout [
            layout.treemapcolorway [
                color.pink
                color.lightGray
            ]
        ]
    ]

let colorscaleChart () =
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

let chart = React.functionComponent (fun () ->
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
    ])
```