# Feliz.Plotly - Parallel Coordinate Plots

Taken from [Plotly - Parallel Coordinate Plots](https://plot.ly/javascript/parallel-coordinates-plot/)

```fsharp:plotly-chart-parallelcoordinates-advanced
[<RequireQualifiedAccess>]
module Samples.ParallelCoordinates.Advanced

open Fable.Core
open Fable.SimpleHttp
open Feliz
open Feliz.Plotly

type PlotData =
    { Headers: string []
      ColorValue: int [] 
      BlockHeight: int []
      BlockWidth: int []
      CycMaterial: float []
      BlockMaterial: int []
      TotalWeight: int []
      AssemblyPW: int []
      HstW: int []
      MinHW: int []
      MinWD: int []
      RFBlock: int [] }
    member this.AddDataSet (data: string []) =
        { this with
            ColorValue = Array.append this.ColorValue (data.[0] |> int |> Array.singleton)
            BlockHeight = Array.append this.BlockHeight (data.[1] |> int |> Array.singleton)
            BlockWidth = Array.append this.BlockWidth (data.[2] |> int |> Array.singleton)
            CycMaterial = Array.append this.CycMaterial (data.[3] |> float |> Array.singleton)
            BlockMaterial = Array.append this.BlockMaterial (data.[4] |> int |> Array.singleton)
            TotalWeight = Array.append this.TotalWeight (data.[5] |> int |> Array.singleton)
            AssemblyPW = Array.append this.AssemblyPW (data.[6] |> int |> Array.singleton)
            HstW = Array.append this.HstW (data.[7] |> int |> Array.singleton)
            MinHW = Array.append this.MinHW (data.[8] |> int |> Array.singleton)
            MinWD = Array.append this.MinWD (data.[9] |> int |> Array.singleton)
            RFBlock = Array.append this.RFBlock (data.[10] |> int |> Array.singleton) }

module PlotData =
    let empty =
        { Headers = [||]
          ColorValue = [||]
          BlockHeight = [||]
          BlockWidth = [||]
          CycMaterial = [||]
          BlockMaterial = [||]
          TotalWeight = [||]
          AssemblyPW = [||]
          HstW = [||]
          MinHW = [||]
          MinWD = [||]
          RFBlock = [||] }

let render (data: PlotData) =
    Plotly.plot [
        plot.traces [
            traces.parcoords [
                parcoords.line [
                    line.showscale true
                    line.reversescale true
                    line.color data.ColorValue
                    line.colorscale color.colorscale.jet
                    line.cmin -4000
                    line.cmax -100
                ]
                parcoords.dimensions [
                    dimensions.dimension [
                        dimension.constraintrange [ 100000; 150000 ]
                        dimension.range [ 32000 ; 227900 ]
                        dimension.label "Block height"
                        dimension.values data.BlockHeight
                    ]
                    dimensions.dimension [
                        dimension.range [ 0; 700000 ]
                        dimension.label "Block width"
                        dimension.values data.BlockWidth
                    ]
                    dimensions.dimension [
                        dimension.tickvals [ 0.; 0.5; 1.; 2.; 3. ]
                        dimension.ticktext [ "A"; "AB"; "B"; "Y"; "Z" ]
                        dimension.label "Cylinder material"
                        dimension.values data.CycMaterial
                    ]
                    dimensions.dimension [
                        dimension.tickvals [ 0 .. 3 ]
                        dimension.range [ -1; 4 ]
                        dimension.label "Block material"
                        dimension.values data.BlockMaterial
                    ]
                    dimensions.dimension [
                        dimension.range [ 134; 3154 ]
                        dimension.label "Total weight"
                        dimension.visible true
                        dimension.values data.TotalWeight
                    ]
                    dimensions.dimension [
                        dimension.range [ 9; 19984 ]
                        dimension.label "Assembly penalty weight"
                        dimension.values data.AssemblyPW
                    ]
                    dimensions.dimension [
                        dimension.range [ 49000; 568000 ]
                        dimension.label "Height st width"
                        dimension.values data.HstW
                    ]
                    dimensions.dimension [
                        dimension.range [ -28000; 196430 ]
                        dimension.label "Min height width"
                        dimension.values data.MinHW
                    ]
                    dimensions.dimension [
                        dimension.range [ 98453; 501789 ]
                        dimension.label "Min width diameter"
                        dimension.values data.MinWD
                    ]
                    dimensions.dimension [
                        dimension.range [ 1417; 107154 ]
                        dimension.label "RF Block"
                        dimension.values data.RFBlock
                    ]
                ]
            ]
        ]
        plot.layout [
            layout.width 1300
        ]
    ]

let chart' = React.functionComponent (fun (input: {| centeredSpinner: ReactElement |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState PlotData.empty
    let path = "https://raw.githubusercontent.com/bcdunbar/datasets/master/parcoords_data.csv"

    let loadDataset() = 
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
                let fullData =
                    responseText.Trim().Split('\n') 
                    |> Array.map ((fun s -> s.Replace(".00E+05","")) >> (fun s -> s.Split(',')))

                fullData
                |> Array.tail
                |> Array.fold (fun (state: PlotData) (values: string []) -> state.AddDataSet values) content
                |> fun newContent -> { newContent with Headers = fullData |> Array.head }
                |> setContent
                setError(None)
            else
                setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

    React.useEffect(loadDataset, [| path :> obj |])

    match isLoading, error with
    | true, _ -> input.centeredSpinner
    | false, None -> render content
    | _, Some error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ])

let chart (centeredSpinner: ReactElement) = chart' {| centeredSpinner = centeredSpinner |}
```