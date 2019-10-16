# Feliz.Plotly (pre-alpha) [![Nuget](https://img.shields.io/nuget/v/Feliz.Plotly.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.Plotly)

Fable bindings for [plotly.js](https://github.com/plotly/plotly.js) with [Feliz](https://github.com/Zaid-Ajaj/Feliz) style api for use within React applications.

Lets you build visualizations in an easy, discoverable, and safe fashion.

A quick look:

```fs
open Feliz
open Feliz.Plotly

Plotly.plot [
    plot.data [
        data.scatter [
            data.scatter.x [ 1; 2; 3; 4]
            data.scatter.y [ 10; 15; 13; 17 ]
            data.scatter.mode.markers
        ]
        data.scatter [
            data.scatter.x [ 2; 3; 4; 5 ]
            data.scatter.y [ 16; 5; 11; 9 ]
            data.scatter.mode.lines
        ]
        data.scatter [
            data.scatter.x [ 1; 2; 3; 4 ]
            data.scatter.y [ 12; 9; 15; 12 ]
            data.scatter.mode.markersAndLines
        ]
    ]
]
```

This library is generated from the plotly.js json schema, so while things get ironed out please log an issue if you find something that seems off!