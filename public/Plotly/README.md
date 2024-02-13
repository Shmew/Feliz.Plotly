# Feliz.Plotly [![Nuget](https://img.shields.io/nuget/v/Feliz.Plotly.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.Plotly)

Fable bindings for [plotly.js](https://github.com/plotly/plotly.js) and [react-plotly.js](https://github.com/plotly/react-plotly.js) with [Feliz](https://github.com/Zaid-Ajaj/Feliz) style api for use within React applications.

Lets you build visualizations in an easy, discoverable, and safe fashion.

See the full documentation with live examples [here](https://EverybodyKurts.github.io/Feliz.Plotly/).

A quick look:

```fs
open Feliz
open Feliz.Plotly

Plotly.plot [
    plot.traces [
        traces.scatter [
            scatter.x [ 1; 2; 3; 4 ]
            scatter.y [ 10; 15; 13; 17 ]
            scatter.mode.markers
        ]
        traces.scatter [
            scatter.x [ 2; 3; 4; 5 ]
            scatter.y [ 16; 5; 11; 9 ]
            scatter.mode.lines
        ]
        traces.scatter [
            scatter.x [ 1; 2; 3; 4 ]
            scatter.y [ 12; 9; 15; 12 ]
            scatter.mode [
                scatter.mode.lines
                scatter.mode.markers
            ]
        ]
    ]
]
```
