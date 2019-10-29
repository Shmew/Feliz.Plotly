﻿# Feliz.Plotly - Tables

Taken from [Plotly - Tables](https://plot.ly/javascript/table/)

```fsharp:plotly-chart-table-basic
[<RequireQualifiedAccess>]
module Samples.Table.Basic

open Fable.Core
open Feliz
open Feliz.Plotly

let values =
    [ U4.Case3 [| "Salaries"; "Office"; "Merchandise"; "Legal"; "<b>TOTAL</b>" |]
      U4.Case1 [| 1200000; 20000; 80000; 2000; 12120000 |]
      U4.Case1 [| 1300000; 20000; 70000; 2000; 130902000 |]
      U4.Case1 [| 1300000; 20000; 120000; 2000; 131222000 |]
      U4.Case1 [| 1400000; 20000; 90000; 2000; 14102000 |] ]

let headers =
    [ [ "<b>EXPENSES</b>" ]
      [ "<b>Q1</b>" ]
      [ "<b>Q2</b>" ] 
      [ "<b>Q3</b>" ]
      [ "<b>Q4</b>" ] ]

let chart () =
    Plotly.plot [
        plot.traces [
            traces.table [
                table.header [
                    header.values headers
                    header.align.center
                    header.line [
                        line.width 1
                        line.color colors.black
                    ]
                    header.fill [
                        fill.color colors.gray
                    ]
                    header.font [
                        font.family "Arial"
                        font.size 12
                        font.color colors.white
                    ]
                ]
                table.cells [
                    cells.values values
                    cells.align.center
                    cells.line [
                        line.color colors.black
                        line.width 1
                    ]
                    cells.font [
                        font.family "Arial"
                        font.size 11
                        font.color colors.black
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.height 350
        ]
    ]
```