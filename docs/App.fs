module App

open Browser.Dom
open Elmish
open Elmish.React
open Feliz
open Fable.SimpleHttp
open Feliz.Router
open Feliz.UseElmish
open Zanaptak.TypedCssClasses

open HTML

type Bulma = CssClasses<"https://cdn.jsdelivr.net/npm/bulma@0.9.4/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css", Naming.PascalCase>

module MarkdownLoader =
    type State =
        | Initial
        | Loading
        | Errored of string
        | LoadedMarkdown of content: string

    type Msg =
        | StartLoading of path: string list
        | Loaded of Result<string, int * string>

    let init (path: string list) : State * Cmd<Msg> =
        Initial, Cmd.ofMsg (StartLoading path)

    let resolvePath = function
    | [ one: string ] when one.StartsWith "http" -> one
    | segments -> String.concat "/" segments

    let update (msg: Msg) (state: State) : State * Cmd<Msg> =
        match msg with
        | StartLoading path ->
            let loadMarkdownAsync() =
                async {
                    let! (statusCode, responseText) = Http.get (resolvePath path)
                    if statusCode = 200
                    then return Loaded (Ok responseText)
                    else return Loaded (Error (statusCode, responseText))
                }

            Loading, Cmd.OfAsync.perform loadMarkdownAsync () id

        | Loaded (Ok content) ->
            LoadedMarkdown content, Cmd.none

        | Loaded (Error (status, _)) ->
            LoadedMarkdown $"Status {status}: could not load markdown", Cmd.none

    let render (input: {| state: State; path: string list |}) : ReactElement =
        match input.state with
        | Initial ->
            console.log "Initial state"
            console.log input.path

            Html.none
        | Loading ->
            console.log "Loading state"
            console.log input.path

            centeredSpinner
        | LoadedMarkdown content ->
            console.log "Loaded state"
            console.log input.path

            console.log content
            renderMarkdown {| path = (resolvePath input.path); content = content |}
        | Errored error ->
            Html.h1 [
                prop.style [ style.color.crimson ]
                prop.text error
            ]

type State = {
    CurrentPath : string list
    CurrentTab: string list
    MarkdownLoader: MarkdownLoader.State
}

type Msg =
    | TabToggled of string list
    | UrlChanged of string list
    | MarkdownMsg of MarkdownLoader.Msg

let init () : State * Cmd<Msg> =
    let path =
        match document.URL.Split('#') with
        | [| _ |] -> []
        | [| _; path |] -> path.Split('/') |> List.ofArray |> List.tail
        | _ -> []
    { CurrentPath = path
      CurrentTab = path
      MarkdownLoader = MarkdownLoader.Initial
    }, Cmd.none

let update (msg: Msg) (state: State) : State * Cmd<Msg> =
    match msg with
    | UrlChanged segments ->
        console.log "UrlChanged"
        console.log segments

        { state with CurrentPath = segments },
        match state.CurrentTab with
        | [ ] when segments.Length > 2 ->
            Cmd.ofMsg <| TabToggled segments
        | _ -> Cmd.none

    | TabToggled tabs ->
        console.log "TabToggled"
        match tabs with
        | [ ] -> { state with CurrentTab = [ ] }, Cmd.none
        | _ -> { state with CurrentTab = tabs }, Cmd.none

    | MarkdownMsg msg->
        console.log "MarkdownMsg"
        console.log msg
        let (updated, cmd) = MarkdownLoader.update msg state.MarkdownLoader

        let state = { state with MarkdownLoader = updated }

        state, Cmd.map MarkdownMsg cmd

/// A collapsable nested menu for the sidebar...
/// keeps internal state on whether the items should be visible or not based on the collapsed state
let nestedMenuList' (input: {| state: State; name: string; basePath: string list; elems: (string list -> ReactElement) list; dispatch: Msg -> unit |}) : ReactElement =
    let collapsed =
        match input.state.CurrentTab with
        | [ ] -> false
        | _ ->
            input.basePath
            |> List.indexed
            |> List.forall (fun (i, segment) ->
                List.tryItem i input.state.CurrentTab
                |> Option.map ((=) segment)
                |> Option.defaultValue false)

    Html.li [
        Html.anchor [
            prop.className Bulma.IsUnselectable
            prop.onClick <| fun _ ->
                match collapsed with
                | true -> input.dispatch <| TabToggled (input.basePath |> List.rev |> List.tail |> List.rev)
                | false -> input.dispatch <| TabToggled input.basePath
            prop.children [
                Html.i [
                    prop.style [ style.marginRight 10 ]
                    prop.className [
                        FA.Fa
                        if not collapsed then FA.FaAngleDown else FA.FaAngleUp
                    ]
                ]
                Html.span input.name
            ]
        ]

        Html.ul [
            prop.className Bulma.MenuList
            prop.style [
                if not collapsed then yield! [ style.display.none ]
            ]
            prop.children (input.elems |> List.map (fun f -> f input.basePath))
        ]
    ]

let allItems (input: {| state: State; dispatch: Msg -> unit |}) : ReactElement =
    let dispatch = React.useCallback(input.dispatch, [||])

    let menuItem (name: string) (basePath: string list) =
        menuItem'
            {| currentPath = input.state.CurrentPath
               name = name
               path = basePath |}

    let nestedMenuItem (name: string) (extendedPath: string list) (basePath: string list) =
        let path = basePath @ extendedPath
        menuItem'
            {| currentPath = input.state.CurrentPath
               name = name
               path = path |}

    let nestedMenuList (name: string) (basePath: string list) (items: (string list -> ReactElement) list) : ReactElement =
        nestedMenuList'
            {| state = input.state
               name = name
               basePath = basePath
               elems = items
               dispatch = dispatch |}

    let subNestedMenuList (name: string) (basePath: string list) (items: (string list -> ReactElement) list) (addedBasePath: string list) : ReactElement =
        nestedMenuList'
            {| state = input.state
               name = name
               basePath = (addedBasePath @ basePath)
               elems = items
               dispatch = dispatch |}

    Html.div [
        prop.className "scrollbar"
        prop.children [
            menuList [
                menuItem "Overview" [ ]
                menuItem "Installation" [ Urls.Plotly; Urls.Installation ]
                menuItem "Release Notes" [ Urls.Plotly; Urls.ReleaseNotes ]
                menuItem "Reducing Bundle Size" [ Urls.Plotly; Urls.BundleSize ]
                menuItem "Contributing" [ Urls.Plotly; Urls.Contributing ]
                menuLabel "Examples"
                nestedMenuList "Basic" [ Urls.Plotly; Urls.Examples; Urls.Basic ] [
                    subNestedMenuList "Scatter" [ Urls.Scatter ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Data Labels Hover" [ Urls.DataLabelsHover ]
                        nestedMenuItem "Data Labels On Plot" [ Urls.DataLabelsOnPlot ]
                        nestedMenuItem "Color Dimension" [ Urls.ColorDimension ]
                    ]
                    subNestedMenuList "Bubble" [ Urls.Bubble ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "HoverText" [ Urls.HoverText ]
                        nestedMenuItem "Marker Size and Color" [ Urls.MarkerSizeAndColor ]
                        nestedMenuItem "Size Scaling" [ Urls.SizeScaling ]
                        nestedMenuItem "Marker Size Color and Symbol Array" [ Urls.MarkerSizeColorAndSymbolArray ]
                    ]
                    subNestedMenuList "Dot" [ Urls.Dot ] [
                        nestedMenuItem "Categorical" [ Urls.Categorical ]
                    ]
                    subNestedMenuList "Line" [ Urls.Line ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Named Line and Scatter" [ Urls.NamedLineAndScatter ]
                        nestedMenuItem "Line and Scatter Styling" [ Urls.LineAndScatterStyling ]
                        nestedMenuItem "Styling Line Plot" [ Urls.StylingLinePlot ]
                        nestedMenuItem "Colored and Styled Scatter" [ Urls.ColoredAndStyledScatter ]
                        nestedMenuItem "Line Shape Options Interpolation" [ Urls.LineShapeOptionsInterpolation ]
                        nestedMenuItem "Graph and Axes Titles" [ Urls.GraphAndAxesTitles ]
                        nestedMenuItem "Line Dash" [ Urls.LineDash ]
                        nestedMenuItem "Connect Gaps Between Data" [ Urls.ConnectGapsBetweenData ]
                        nestedMenuItem "Labelling Lines With Annotations" [ Urls.LabellingLinesWithAnnotations ]
                    ]
                    subNestedMenuList "Bar" [ Urls.Bar ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Grouped" [ Urls.Grouped ]
                        nestedMenuItem "Stacked" [ Urls.Stacked ]
                        nestedMenuItem "Hover Text" [ Urls.HoverText ]
                        nestedMenuItem "Direct Labels" [ Urls.DirectLabels ]
                        nestedMenuItem "Grouped Direct Labels" [ Urls.GroupedDirectLabels ]
                        nestedMenuItem "Rotated Labels" [ Urls.RotatedLabels ]
                        nestedMenuItem "Colors" [ Urls.Colors ]
                        nestedMenuItem "Widths" [ Urls.Widths ]
                        nestedMenuItem "Base" [ Urls.Base ]
                        nestedMenuItem "Colored and Styled" [ Urls.ColoredAndStyled ]
                        nestedMenuItem "Waterfall" [ Urls.Waterfall ]
                        nestedMenuItem "Relative Barmode" [ Urls.RelativeBarmode ]
                    ]
                    subNestedMenuList "Filled Area" [ Urls.FilledArea ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Overlaid Without Boundary" [ Urls.OverlaidWithoutBoundary ]
                        nestedMenuItem "Stacked Area" [ Urls.StackedArea ]
                        nestedMenuItem "Normalized Stacked Area" [ Urls.NormalizedStackedArea ]
                        nestedMenuItem "Select Hover" [ Urls.SelectHover ]
                    ]
                    subNestedMenuList "Horizontal Bar" [ Urls.HorizontalBar ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Colored" [ Urls.Colored ]
                        nestedMenuItem "Bar With Line Plot" [ Urls.BarWithLinePlot ]
                    ]
                    subNestedMenuList "Pie" [ Urls.Pie ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Subplots" [ Urls.Subplots ]
                        nestedMenuItem "Donut" [ Urls.Donut ]
                    ]
                    subNestedMenuList "Sunburst" [ Urls.Sunburst ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Branch Values" [ Urls.Branchvalues ]
                        nestedMenuItem "Repeated Labels" [ Urls.RepeatedLabels ]
                        nestedMenuItem "Large Number of Slices" [ Urls.LargeNumberSlices ]
                    ]
                    subNestedMenuList "Sankey" [ Urls.Sankey ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                    ]
                    subNestedMenuList "Point Cloud" [ Urls.PointCloud ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                    ]
                    subNestedMenuList "Treemap" [ Urls.Treemap ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Different Attributes" [ Urls.DifferentAttributes ]
                        nestedMenuItem "Sector Colors" [ Urls.SectorColors ]
                        nestedMenuItem "Nested Layers" [ Urls.NestedLayers ]
                    ]
                    subNestedMenuList "Table" [ Urls.Table ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                        nestedMenuItem "From CSV" [ Urls.FromCSV ]
                        nestedMenuItem "Changing Sizes" [ Urls.ChangingSizes ]
                        nestedMenuItem "Alternating Row Colors" [ Urls.AlternatingRowColors ]
                    ]
                    subNestedMenuList "Multiple Chart Types" [ Urls.MultipleChartTypes ] [
                        nestedMenuItem "Line and Bar" [ Urls.LineAndBar ]
                        nestedMenuItem "Contour and Scatter" [ Urls.ContourAndScatter ]
                    ]
                ]
                nestedMenuList "Statistical" [ Urls.Plotly; Urls.Examples; Urls.Statistical ] [
                    subNestedMenuList "Error Bars" [ Urls.ErrorBar ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "With Bar Chart" [ Urls.WithBarChart ]
                        nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                        nestedMenuItem "Asymmetric" [ Urls.Asymmetric ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                        nestedMenuItem "Percentage of Y Value" [ Urls.PercentageOfYValue ]
                        nestedMenuItem "Asymmetric with Offset" [ Urls.AsymmetricWithOffset ]
                    ]
                    subNestedMenuList "Continuous Error Bars" [ Urls.ContinuousErrorBar ] [
                        nestedMenuItem "Filled Lines" [ Urls.FilledLines ]
                        nestedMenuItem "Asymmetric with Offset" [ Urls.AsymmetricWithOffset ]
                    ]
                    subNestedMenuList "Box" [ Urls.BoxPlot ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Underlying Data" [ Urls.UnderlyingData ]
                        nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                        nestedMenuItem "Grouped" [ Urls.Grouped ]
                        nestedMenuItem "Styled Outliers" [ Urls.StyledOutliers ]
                        nestedMenuItem "Styled Mean and Std Dev" [ Urls.StyledMeanAndStdDev ]
                        nestedMenuItem "Grouped Horizontal" [ Urls.GroupedHorizontal ]
                        nestedMenuItem "Colored" [ Urls.Colored ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                        nestedMenuItem "Rainbow" [ Urls.Rainbow ]
                    ]
                    subNestedMenuList "Histogram" [ Urls.Histogram ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                        nestedMenuItem "Overlaid" [ Urls.Overlaid ]
                        nestedMenuItem "Stacked" [ Urls.Stacked ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                        nestedMenuItem "Cumulative" [ Urls.Cumulative ]
                        nestedMenuItem "Normalized" [ Urls.Normalized ]
                        nestedMenuItem "Specified Binning" [ Urls.SpecifiedBinning ]
                    ]
                    subNestedMenuList "2D Histogram" [ Urls.TwoDimensionalHistogram ] [
                        nestedMenuItem "Bivariate Normal Distribution" [ Urls.BivariateNormalDistribution ]
                        nestedMenuItem "Binning and Styling" [ Urls.BinningAndStyling ]
                        nestedMenuItem "Overlaid with Scatter" [ Urls.OverlaidWithScatter ]
                    ]
                    subNestedMenuList "2D Density" [ Urls.TwoDimensionalDensity ] [
                        nestedMenuItem "With Histogram Subplots" [ Urls.WithHistogramSubplots ]
                    ]
                    subNestedMenuList "SPC Control" [ Urls.SPCControl ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Distribution" [ Urls.Distribution ]
                    ]
                    subNestedMenuList "Violin" [ Urls.Violin ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Multiple Traces" [ Urls.MultipleTraces ]
                        nestedMenuItem "Grouped" [ Urls.Grouped ]
                        nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                        nestedMenuItem "Split" [ Urls.Split ]
                        nestedMenuItem "Advanced" [ Urls.Advanced ]
                    ]
                    subNestedMenuList "Parallel Categories" [ Urls.ParallelCategories ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "With Counts" [ Urls.WithCounts ]
                        nestedMenuItem "Multi Color" [ Urls.MultiColor ]
                        nestedMenuItem "Linked Brushing" [ Urls.LinkedBrushing ]
                        nestedMenuItem "Multi Color Linked Brushing" [ Urls.MultiColorLinkedBrushing ]
                    ]
                    subNestedMenuList "Splom" [ Urls.Splom ] [
                        nestedMenuItem "Iris" [ Urls.Iris ]
                        nestedMenuItem "Diabetes" [ Urls.Diabetes ]
                    ]
                    subNestedMenuList "2D Histogram Contour" [ Urls.TwoDimensionalHistogramContour ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Colorscale" [ Urls.Colorscale ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                    ]
                ]
                nestedMenuList "Scientific" [ Urls.Plotly; Urls.Examples; Urls.Scientific ] [
                    subNestedMenuList "Log" [ Urls.Log ] [
                        nestedMenuItem "Logarithmic Axes" [ Urls.LogarithmicAxes ]
                    ]
                    subNestedMenuList "Contour" [ Urls.Contour ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Simple" [ Urls.Simple ]
                        nestedMenuItem "Setting X and Y Coordinates" [ Urls.SettingXAndYCoordinates ]
                        nestedMenuItem "Colorscale" [ Urls.Colorscale ]
                        nestedMenuItem "Custom Size and Range" [ Urls.CustomSizeAndRange ]
                        nestedMenuItem "Custom Spacing" [ Urls.CustomSpacing ]
                        nestedMenuItem "Connecting Gaps In Z Matrix" [ Urls.ConnectingGapsInZMatrix ]
                        nestedMenuItem "Smoothing Lines" [ Urls.SmoothingLines ]
                        nestedMenuItem "Smooth Coloring" [ Urls.SmoothColoring ]
                        nestedMenuItem "Lines" [ Urls.Lines ]
                        nestedMenuItem "Line Labels" [ Urls.LineLabels ]
                        nestedMenuItem "Custom Colorscale" [ Urls.CustomColorscale ]
                        nestedMenuItem "Colorbar Title" [ Urls.ColorbarTitle ]
                        nestedMenuItem "Colorbar Size" [ Urls.ColorbarSize ]
                        nestedMenuItem "Styling Colorbar" [ Urls.StylingColorbar ]
                    ]
                    subNestedMenuList "Heatmap" [ Urls.Heatmap ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Annotated" [ Urls.Annotated ]
                        nestedMenuItem "With Categorical Axis Labels" [ Urls.WithCategoricalAxisLabels ]
                        nestedMenuItem "Unequal Block Sizes" [ Urls.UnequalBlockSizes ]
                        nestedMenuItem "WebGL" [ Urls.WebGL ]
                    ]
                    subNestedMenuList "Wind Rose" [ Urls.WindRose ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                    ]
                    subNestedMenuList "Ternary" [ Urls.Ternary ] [
                        nestedMenuItem "With Markers" [ Urls.WithMarkers ]
                        nestedMenuItem "Soil Types" [ Urls.SoilTypes ]
                    ]
                    subNestedMenuList "Ternary Contour" [ Urls.TernaryContour ] [
                        nestedMenuItem "Filled" [ Urls.Filled ]
                    ]
                    subNestedMenuList "Radar" [ Urls.Radar ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Multiple Traces" [ Urls.MultipleTraces ]
                    ]
                    subNestedMenuList "Parallel Coordinates" [ Urls.ParallelCoordinates ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Adding Dimensions" [ Urls.AddingDimensions ]
                        nestedMenuItem "Annotated" [ Urls.Annotated ]
                        nestedMenuItem "Advanced" [ Urls.Advanced ]
                    ]
                    subNestedMenuList "Carpet" [ Urls.Carpet ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Add A and B Axis" [ Urls.AddAAndBAxis ]
                        nestedMenuItem "Style A and B Axis" [ Urls.StyleAAndBAxis ]
                    ]
                    subNestedMenuList "Carpet Scatter" [ Urls.CarpetScatter ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Multiple Traces" [ Urls.MultipleTraces ]
                    ]
                    subNestedMenuList "Carpet Contour" [ Urls.CarpetContour ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Multiple Traces" [ Urls.MultipleTraces ]
                    ]
                    subNestedMenuList "Polar" [ Urls.Polar ] [
                        nestedMenuItem "Line" [ Urls.Line ]
                        nestedMenuItem "Area" [ Urls.Area ]
                        nestedMenuItem "Categorical" [ Urls.Categorical ]
                        nestedMenuItem "Directions" [ Urls.Directions ]
                        nestedMenuItem "Sector" [ Urls.Sector ]
                        nestedMenuItem "Subplots" [ Urls.Subplots ]
                        nestedMenuItem "WebGL" [ Urls.WebGL ]
                    ]
                ]
                nestedMenuList "Financial" [ Urls.Plotly; Urls.Examples; Urls.Financial ] [
                    subNestedMenuList "Waterfall" [ Urls.Waterfall ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Multi Category" [ Urls.MultiCategory ]
                        nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                        nestedMenuItem "Styled" [ Urls.Styled ]
                    ]
                    subNestedMenuList "Indicators" [ Urls.Indicators ] [
                        nestedMenuItem "Showcase" [ Urls.Showcase ]
                        nestedMenuItem "Overlay" [ Urls.Overlay ]
                    ]
                    subNestedMenuList "Candlestick" [ Urls.Candlestick ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Range Breaks" [ Urls.RangeBreaks ]
                    ]
                    subNestedMenuList "Funnel" [ Urls.Funnel ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Funnel Area" [ Urls.FunnelArea ]
                    ]
                    subNestedMenuList "Time Series" [ Urls.TimeSeries ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                        nestedMenuItem "Set Range" [ Urls.SetRange ]
                        nestedMenuItem "Range Slider" [ Urls.RangeSlider ]
                    ]
                    subNestedMenuList "OHLC" [ Urls.OHLC ] [
                        nestedMenuItem "Basic" [ Urls.Basic ]
                    ]
                ]
                nestedMenuList "Maps" [ Urls.Plotly; Urls.Examples; Urls.Maps ] [
                    nestedMenuItem "Scatter" [ Urls.Scatter ]
                    nestedMenuItem "Heatmap" [ Urls.Heatmap ]
                    nestedMenuItem "Lines" [ Urls.Lines ]
                    nestedMenuItem "Bubble" [ Urls.Bubble ]
                    nestedMenuItem "Filled Area" [ Urls.FilledArea ]
                    nestedMenuItem "Choropleth" [ Urls.Choropleth ]
                ]
                nestedMenuList "3D" [ Urls.Plotly; Urls.Examples; Urls.ThreeDimensional ] [
                    nestedMenuItem "Scatter" [ Urls.Scatter ]
                    nestedMenuItem "Ribbon" [ Urls.Ribbon ]
                    nestedMenuItem "Surface" [ Urls.Surface ]
                    nestedMenuItem "Mesh" [ Urls.Mesh ]
                    nestedMenuItem "Line" [ Urls.Line ]
                    nestedMenuItem "Tri-Surf" [ Urls.TriSurf ]
                    nestedMenuItem "Cluster Graph" [ Urls.ClusterGraph ]
                    nestedMenuItem "Cone" [ Urls.Cone ]
                    nestedMenuItem "Streamtube" [ Urls.Streamtube ]
                    nestedMenuItem "Isosurface" [ Urls.Isosurface ]
                ]
                nestedMenuList "Subplots" [ Urls.Plotly; Urls.Examples; Urls.Subplots ] [
                    subNestedMenuList "Multiple Axes" [ Urls.MultipleAxes ] [
                        nestedMenuItem "Two Y-Axes" [ Urls.TwoYAxes ]
                        nestedMenuItem "Multiple Y-Axes" [ Urls.MultipleYAxes ]
                    ]
                    nestedMenuItem "Inset" [ Urls.Inset ]
                    nestedMenuItem "Mixed" [ Urls.Mixed ]
                ]
                nestedMenuList "Events" [ Urls.Plotly; Urls.Examples; Urls.Events ] [
                    nestedMenuItem "Click" [ Urls.Click ]
                    nestedMenuItem "Hover" [ Urls.Hover ]
                    nestedMenuItem "Zoom" [ Urls.Zoom ]
                    nestedMenuItem "Disable Zoom" [ Urls.DisableZoom ]
                    nestedMenuItem "Downloading Images" [ Urls.DownloadImage ]
                ]
                nestedMenuList "Transforms" [ Urls.Plotly; Urls.Examples; Urls.Transforms ] [
                    nestedMenuItem "Filter" [ Urls.Filter ]
                    nestedMenuItem "Group By" [ Urls.Groupby ]
                    nestedMenuItem "Aggregation" [ Urls.Aggregations ]
                    nestedMenuItem "Multiple Transforms" [ Urls.Multiple ]
                ]
                nestedMenuList "Transitions" [ Urls.Plotly; Urls.Examples; Urls.Transitions ] [
                    nestedMenuItem "Lorenz Attractor" [ Urls.Lorenz ]
                ]
                nestedMenuList "Custom" [ Urls.Plotly; Urls.Examples; Urls.Custom ] [
                    nestedMenuItem "Gantt" [ Urls.Gantt ]
                    nestedMenuItem "WebGL Gantt" [ Urls.WebGLGantt ]
                ]
                nestedMenuList "Locales" [ Urls.Plotly; Urls.Examples; Urls.Locales ] [
                    nestedMenuItem "Config" [ Urls.Config ]
                    nestedMenuItem "Module Registration" [ Urls.ModuleRegistration ]
                ]
            ]
        ]
    ]

let sidebar (input: {| state: State; dispatch: Msg -> unit |}) : ReactElement =
    let dispatch = React.useCallback(input.dispatch, [||])

    // the actual nav bar
    Html.aside [
        prop.className Bulma.Menu
        prop.style [
            style.width (length.perc 100)
        ]
        prop.children [
            menuLabel "Feliz.Plotly"
            allItems {| state = input.state; dispatch = dispatch |}
        ]
    ]

let (|PathPrefix|) (segments: string list) (path: string list) : (string list) option =
    if path.Length > segments.Length then
        match List.splitAt segments.Length path with
        | start,end' when start = segments -> Some end'
        | _ -> None
    else None

let content (input: {| state: State; dispatch: Msg -> unit |}) : ReactElement =
    let contributing = "https://raw.githubusercontent.com/Zaid-Ajaj/Feliz/master/public/Feliz/Contributing.md"

    match input.state.CurrentPath with
    | [ Urls.Plotly; Urls.Overview; ] -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ "Plotly"; "README.md" ] |}
    | [ Urls.Plotly; Urls.Installation ] -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ "Plotly"; "Installation.md" ] |}
    | [ Urls.Plotly; Urls.ReleaseNotes ] -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ "Plotly"; "RELEASE_NOTES.md" ] |}
    | [ Urls.Plotly; Urls.BundleSize ] -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ "Plotly"; "BundleSize.md" ] |}
    | [ Urls.Plotly; Urls.Contributing ] -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ contributing ] |}
    | PathPrefix [ Urls.Plotly; Urls.Examples ] (Some res) ->
        match res with
        | PathPrefix [ Urls.Basic ] (Some innerRes) -> Paths.basicExamples innerRes
        | PathPrefix [ Urls.Statistical ] (Some innerRes) -> Paths.statisticalExamples innerRes
        | PathPrefix [ Urls.Scientific ] (Some innerRes) -> Paths.scientificExamples innerRes
        | PathPrefix [ Urls.Financial ] (Some innerRes) -> Paths.financialExamples innerRes
        | PathPrefix [ Urls.Maps ] (Some innerRes) -> Paths.mapExamples innerRes
        | PathPrefix [ Urls.ThreeDimensional ] (Some innerRes) -> Paths.threeDimensionalExamples innerRes
        | PathPrefix [ Urls.Subplots ] (Some innerRes) -> Paths.subplotExamples innerRes
        | PathPrefix [ Urls.Events ] (Some innerRes) -> Paths.eventExamples innerRes
        | PathPrefix [ Urls.Transforms ] (Some innerRes) -> Paths.transformExamples innerRes
        | PathPrefix [ Urls.Transitions ] (Some innerRes) -> Paths.transitionExamples innerRes
        | PathPrefix [ Urls.Custom ] (Some innerRes) -> Paths.customExamples innerRes
        | PathPrefix [ Urls.Locales ] (Some innerRes) -> Paths.localeExamples innerRes
        | _ -> []
        |> fun path -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ Urls.Plotly; Urls.Examples ] @ path|}
    | _ -> lazyView MarkdownLoader.render {| state = input.state.MarkdownLoader; path = [ "Plotly"; "README.md" ] |}

let main (state: State) (dispatch: Msg -> unit) : ReactElement =
    let dispatch = React.useCallback(dispatch, [||])

    Html.div [
        prop.className [ Bulma.Tile; Bulma.IsAncestor ]
        prop.children [
            Html.div [
                prop.className [ Bulma.Tile; Bulma.Is2 ]
                prop.children [ sidebar {| state = state; dispatch = dispatch |} ]
            ]

            Html.div [
                prop.className Bulma.Tile
                prop.style [ style.paddingTop 30 ]
                prop.children [ content {| state = state; dispatch = dispatch |} ]
            ]
        ]
    ]

[<ReactComponent>]
let View () : ReactElement =
    let state, dispatch = React.useElmish(init, update, [| |])
    let dispatch = React.useCallback(dispatch, [||])

    let application : ReactElement =
        Html.div [
            prop.style [
                style.padding 30
            ]
            prop.children [ main state dispatch ]
        ]

    React.router [
        router.onUrlChanged (UrlChanged >> dispatch)
        router.children application
    ]

let htmlElement= document.getElementById "root"
let root = ReactDOM.createRoot htmlElement

root.render (View())