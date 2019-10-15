[<RequireQualifiedAccess>]
module Samples.ScatterChart

open Feliz
open Feliz.Plotly
open Fable.Core.Experimental

let test = 
    plot.data [
        data.scatter [
            data.scatter.x [ 1; 2; 3; 4]
            data.scatter.y [ 10; 15; 13; 17 ]
            data.scatter.mode [ "markers" ]
        ]
        data.scatter [
            data.scatter.x [ 2; 3; 4; 5 ]
            data.scatter.y [ 16; 5; 11; 9 ]
            data.scatter.mode [ "lines" ]
        ]
        data.scatter [
            data.scatter.x [ 1; 2; 3; 4 ]
            data.scatter.y [ 12; 9; 15; 12 ]
            data.scatter.mode [ "lines+markers" ]
        ]
    ]

let chart () =
    Plotly.plot [
        test
        plot.layout [
            layout.plot_bgcolor colors.aqua
        ]
        plot.config [
            config.displaylogo false
        ]
        plot.debug true
        plot.className "wowie zowie"
        plot.onInitialized(fun _ plotHtml -> Fable.Core.JS.console.log plotHtml)
    ]
