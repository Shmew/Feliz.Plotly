# Feliz.Plotly - Contour Plots

Taken from [Plotly - Contour Plots](https://plot.ly/javascript/contour-plots/)

```fsharp:plotly-chart-contour-customspacing
[<requirequalifiedaccess>]
module samples.twodimensionaldensity.withhistogramsubplots

open feliz
open feliz.plotly
open system

let rng = random()

let normal () =
    let x = rng.nextdouble() * 2. - 1.
    let y = rng.nextdouble() * 2. - 1.
    let rec boxmullertransform rds =
        if rds = 0. || rds > 1. then x * rds
        else 
            math.sqrt(-2. * math.log(rds) / rds)
            |> boxmullertransform

    x * x + y * y
    |> boxmullertransform

let xdata, ydata =
    let step i = -1. + 2.2 / 1999. * i

    [ 0. .. 1999. ]
    |> list.map 
        (step >>
         fun step ->
            math.pow(step, 3.) + (0.3 * normal()),
            math.pow(step, 6.) + (0.3 * normal()))
    |> list.unzip

let chart () =
    plotly.plot [
        plot.traces [
            traces.scatter [
                scatter.x xdata
                scatter.y ydata
                scatter.mode.markers
                scatter.name "points"
                scatter.marker [
                    marker.color (color.rgb(102, 0, 0))
                    marker.size 2
                    marker.opacity 0.4
                ]
            ]
            traces.histogram2dcontour [
                histogram2dcontour.x xdata
                histogram2dcontour.y ydata
                histogram2dcontour.name "density"
                histogram2dcontour.ncontours 20
                histogram2dcontour.colorscale color.colorscale.hot
                histogram2dcontour.reversescale true
                histogram2dcontour.showscale false
            ]
            traces.histogram [
                histogram.x xdata
                histogram.name "x density"
                histogram.marker [
                    marker.color (color.rgb(102, 0, 0))
                ]
                histogram.yaxis 2
            ]
            traces.histogram [
                histogram.y ydata
                histogram.name "y density"
                histogram.marker [
                    marker.color (color.rgb(102, 0, 0))
                ]
                histogram.xaxis 2
            ]
        ]
        plot.layout [
            layout.showlegend false
            layout.autosize false
            layout.width 600
            layout.height 550
            layout.margin [
                margin.t 50
            ]
            layout.hovermode.closest
            layout.bargap 0
            layout.xaxis [
                xaxis.domain [ 0.; 0.85 ]
                xaxis.anchor.y 1
                xaxis.showgrid false
                xaxis.zeroline false
            ]
            layout.yaxis [
                yaxis.anchor.x 1
                yaxis.domain [ 0.; 0.85 ]
                yaxis.showgrid false
                yaxis.zeroline false
            ]
            layout.xaxis (2, [
                xaxis.anchor.y 2
                xaxis.domain [ 0.85; 1. ]
                xaxis.showgrid false
                xaxis.zeroline false
            ])
            layout.yaxis (2, [
                yaxis.anchor.x 2
                yaxis.domain [ 0.85; 1. ]
                yaxis.showgrid false
                yaxis.zeroline false
            ])
        ]
        plot.debug true
    ]
```