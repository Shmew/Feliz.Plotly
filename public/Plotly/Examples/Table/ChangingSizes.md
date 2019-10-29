# Feliz.Plotly - Tables

Taken from [Plotly - Tables](https://plot.ly/javascript/table/)

```fsharp:plotly-chart-table-changingsizes
[<RequireQualifiedAccess>]
module Samples.Table.ChangingSizes

open Fable.Core
open Feliz
open Feliz.Plotly

let values =
    [ [ "Salaries"; "Office"; "Merchandise"; "Legal"; "<b>TOTAL<br>EXPENSES</b>" ]
      [ "Lorem ipsum dolor sit amet, tollit discere inermis pri ut. Eos ea iusto timeam, an prima laboramus vim. Id usu aeterno adversarium, summo mollis timeam vel ad"
        "Lorem ipsum dolor sit amet, tollit discere inermis pri ut. Eos ea iusto timeam, an prima laboramus vim. Id usu aeterno adversarium, summo mollis timeam vel ad"
        "Lorem ipsum dolor sit amet, tollit discere inermis pri ut. Eos ea iusto timeam, an prima laboramus vim. Id usu aeterno adversarium, summo mollis timeam vel ad"
        "Lorem ipsum dolor sit amet, tollit discere inermis pri ut. Eos ea iusto timeam, an prima laboramus vim. Id usu aeterno adversarium, summo mollis timeam vel ad"
        "Lorem ipsum dolor sit amet, tollit discere inermis pri ut. Eos ea iusto timeam, an prima laboramus vim. Id usu aeterno adversarium, summo mollis timeam vel ad" ] ]

let headers =
    [ [ "<b>EXPENSES</b><br>as of July 2017" ]
      [ "<b>DESCRIPTION</b>" ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.table [
                table.columnwidth [ 80; 400 ]
                table.header [
                    header.values headers
                    header.aligns [
                        header.align.center
                        header.align.left
                    ]
                    header.height 40
                    header.line [
                        line.width 1
                        line.color "#506784"
                    ]
                    header.fill [
                        fill.color "#119DFF"
                    ]
                    header.font [
                        font.family "Arial"
                        font.size 12
                        font.color colors.white
                    ]
                ]
                table.cells [
                    cells.values values
                    cells.aligns [
                        cells.align.left
                        cells.align.center
                    ]
                    cells.height 30
                    cells.line [
                        line.color "#506784"
                        line.width 1
                    ]
                    cells.fill [
                        fill.color [ "#25FEFD"; colors.white ]
                    ]
                    cells.font [
                        font.family "Arial"
                        font.size 11
                        font.color "#506784"
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.width 1000
        ]
    ]
```