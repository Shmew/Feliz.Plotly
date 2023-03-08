module App

open Browser.Dom
open Elmish
open Elmish.React
open Feliz
open Feliz.Markdown
open Fable.SimpleHttp
open Feliz.Router
open Fable.Core.JsInterop
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

type Highlight =
    static member inline highlight (properties: IReactProperty list) =
        Interop.reactApi.createElement(importDefault "react-highlight", createObj !!properties)

type State =
    { CurrentPath : string list
      CurrentTab: string list }

let init () =
    let path =
        match document.URL.Split('#') with
        | [| _ |] -> []
        | [| _; path |] -> path.Split('/') |> List.ofArray |> List.tail
        | _ -> []
    { CurrentPath = path
      CurrentTab = path }, Cmd.none

type Msg =
    | TabToggled of string list
    | UrlChanged of string list

let update msg state =
    match msg with
    | UrlChanged segments ->
        { state with CurrentPath = segments },
        match state.CurrentTab with
        | [ ] when segments.Length > 2 ->
            segments
            |> TabToggled
            |> Cmd.ofMsg
        | _ -> Cmd.none
    | TabToggled tabs ->
        match tabs with
        | [ ] -> { state with CurrentTab = [ ] }, Cmd.none
        | _ -> { state with CurrentTab = tabs }, Cmd.none

let centeredSpinner =
    Html.div [
        prop.style [
            style.textAlign.center
            style.marginLeft length.auto
            style.marginRight length.auto
            style.marginTop 50
        ]
        prop.children [
            Html.li [
                prop.className [
                    FA.Fa
                    FA.FaRefresh
                    FA.FaSpin
                    FA.Fa3X
                ]
            ]
        ]
    ]

let samples =
    let basicSamples =
        let scatter =
            [ "plotly-chart-scatter-basic", Samples.Scatter.Basic.chart()
              "plotly-chart-scatter-datalabelshover", Samples.Scatter.DataLabelsHover.chart()
              "plotly-chart-scatter-datalabelsonplot", Samples.Scatter.DataLabelsOnPlot.chart()
              "plotly-chart-scatter-colordimension", Samples.Scatter.ColorDimension.chart() ]

        let bubble =
            [ "plotly-chart-bubble-basic", Samples.Bubble.Basic.chart()
              "plotly-chart-bubble-hovertext", Samples.Bubble.HoverText.chart()
              "plotly-chart-bubble-markersizeandcolor", Samples.Bubble.MarkerSizeAndColor.chart()
              "plotly-chart-bubble-sizescaling", Samples.Bubble.SizeScaling.chart()
              "plotly-chart-bubble-markersizecolorandsymbolarray", Samples.Bubble.MarkerSizeColorAndSymbolArray.chart() ]

        let dot =
            [ "plotly-chart-dot-categorical", Samples.Dot.Categorical.chart() ]

        let line =
            [ "plotly-chart-line-basic", Samples.Line.Basic.chart()
              "plotly-chart-line-namedlineandscatter", Samples.Line.NamedLineAndScatter.chart()
              "plotly-chart-line-lineandscatterstyling", Samples.Line.LineAndScatterStyling.chart()
              "plotly-chart-line-stylinglineplot", Samples.Line.StylingLinePlot.chart()
              "plotly-chart-line-coloredandstyledscatter", Samples.Line.ColoredAndStyledScatter.chart()
              "plotly-chart-line-lineshapeoptionsinterpolation", Samples.Line.LineShapeOptionsInterpolation.chart()
              "plotly-chart-line-graphandaxestitles", Samples.Line.GraphAndAxesTitles.chart()
              "plotly-chart-line-linedash", Samples.Line.LineDash.chart()
              "plotly-chart-line-connectgapsbetweendata", Samples.Line.ConnectGapsBetweenData.chart()
              "plotly-chart-line-labellinglineswithannotations", Samples.Line.LabellingLinesWithAnnotations.chart() ]

        let bar =
            [ "plotly-chart-bar-basic", Samples.Bar.Basic.chart()
              "plotly-chart-bar-grouped", Samples.Bar.Grouped.chart()
              "plotly-chart-bar-stacked", Samples.Bar.Stacked.chart()
              "plotly-chart-bar-hovertext", Samples.Bar.HoverText.chart()
              "plotly-chart-bar-directlabels", Samples.Bar.DirectLabels.chart()
              "plotly-chart-bar-groupeddirectlabels", Samples.Bar.GroupedDirectLabels.chart()
              "plotly-chart-bar-rotatedlabels", Samples.Bar.RotatedLabels.chart()
              "plotly-chart-bar-colors", Samples.Bar.Colors.chart()
              "plotly-chart-bar-widths", Samples.Bar.Widths.chart()
              "plotly-chart-bar-base", Samples.Bar.Base.chart()
              "plotly-chart-bar-coloredandstyled", Samples.Bar.ColoredAndStyled.chart()
              "plotly-chart-bar-waterfall", Samples.Bar.Waterfall.chart()
              "plotly-chart-bar-relativebarmode", Samples.Bar.RelativeBarmode.chart() ]

        let filledArea =
            [ "plotly-chart-filledarea-basic", Samples.FilledArea.Basic.chart()
              "plotly-chart-filledarea-overlaidwithoutboundary", Samples.FilledArea.OverlaidWithoutBoundary.chart()
              "plotly-chart-filledarea-stackedarea", Samples.FilledArea.StackedArea.chart()
              "plotly-chart-filledarea-normalizedstackedarea", Samples.FilledArea.NormalizedStackedArea.chart()
              "plotly-chart-filledarea-selecthover", Samples.FilledArea.SelectHover.chart() ]

        let horiontalBar =
            [ "plotly-chart-horizontalbar-basic", Samples.HorizontalBar.Basic.chart()
              "plotly-chart-horizontalbar-colored", Samples.HorizontalBar.Colored.chart()
              "plotly-chart-horizontalbar-barwithlineplot", Samples.HorizontalBar.BarWithLinePlot.chart() ]

        let pie =
            [ "plotly-chart-pie-basic", Samples.Pie.Basic.chart()
              "plotly-chart-pie-subplots", Samples.Pie.Subplots.chart()
              "plotly-chart-pie-donut", Samples.Pie.Donut.chart() ]

        let sunburst =
            [ "plotly-chart-sunburst-basic", Samples.Sunburst.Basic.chart()
              "plotly-chart-sunburst-branchvalues", Samples.Sunburst.Branchvalues.chart()
              "plotly-chart-sunburst-repeatedlabels", Samples.Sunburst.RepeatedLabels.chart()
              "plotly-chart-sunburst-largenumberslices", Samples.Sunburst.LargeNumberSlices.chart(centeredSpinner) ]

        let sankey =
            [ "plotly-chart-sankey-basic", Samples.Sankey.Basic.chart()
              "plotly-chart-sankey-styled", Samples.Sankey.Styled.chart(centeredSpinner) ]

        let pointCloud =
            [ "plotly-chart-pointcloud-basic", Samples.PointCloud.Basic.chart()
              "plotly-chart-pointcloud-styled", Samples.PointCloud.Styled.chart() ]

        let treemap =
            [ "plotly-chart-treemap-basic", Samples.Treemap.Basic.chart()
              "plotly-chart-treemap-differentattributes", Samples.Treemap.DifferentAttributes.chart()
              "plotly-chart-treemap-sectorcolors", Samples.Treemap.SectorColors.chart()
              "plotly-chart-treemap-nestedlayers", Samples.Treemap.NestedLayers.chart(centeredSpinner) ]

        let table =
            [ "plotly-chart-table-basic", Samples.Table.Basic.chart()
              "plotly-chart-table-styled", Samples.Table.Styled.chart()
              "plotly-chart-table-fromcsv", Samples.Table.FromCSV.chart(centeredSpinner)
              "plotly-chart-table-changingsizes", Samples.Table.ChangingSizes.chart()
              "plotly-chart-table-alternatingrowcolors", Samples.Table.AlternatingRowColors.chart() ]

        let multipleChartTypes =
            [ "plotly-chart-multiplecharttypes-lineandbar", Samples.MultipleChartTypes.LineAndBar.chart()
              "plotly-chart-multiplecharttypes-contourandscatter", Samples.MultipleChartTypes.ContourAndScatter.chart() ]

        [ scatter
          bubble
          dot
          line
          bar
          filledArea
          horiontalBar
          pie
          sunburst
          sankey
          pointCloud
          treemap
          table
          multipleChartTypes ]
        |> List.concat

    let statisticalExamples =
        let errorBars =
            [ "plotly-chart-errorbar-basic", Samples.ErrorBar.Basic.chart()
              "plotly-chart-errorbar-withbarchart", Samples.ErrorBar.WithBarChart.chart()
              "plotly-chart-errorbar-horizontal", Samples.ErrorBar.Horizontal.chart()
              "plotly-chart-errorbar-asymmetric", Samples.ErrorBar.Asymmetric.chart()
              "plotly-chart-errorbar-styled", Samples.ErrorBar.Styled.chart()
              "plotly-chart-errorbar-percentageofyvalue", Samples.ErrorBar.PercentageOfYValue.chart()
              "plotly-chart-errorbar-asymmetricwithoffset", Samples.ErrorBar.AsymmetricWithOffset.chart() ]

        let continuousErrorBars =
            [ "plotly-chart-continuouserrorbar-filledlines", Samples.ContinuousErrorBar.FilledLines.chart()
              "plotly-chart-continuouserrorbar-asymmetricwithoffset", Samples.ContinuousErrorBar.AsymmetricWithOffset.chart() ]

        let boxPlots =
            [ "plotly-chart-boxplot-basic", Samples.BoxPlot.Basic.chart()
              "plotly-chart-boxplot-underlyingdata", Samples.BoxPlot.UnderlyingData.chart()
              "plotly-chart-boxplot-horizontal", Samples.BoxPlot.Horizontal.chart()
              "plotly-chart-boxplot-grouped", Samples.BoxPlot.Grouped.chart()
              "plotly-chart-boxplot-styledoutliers", Samples.BoxPlot.StyledOutliers.chart()
              "plotly-chart-boxplot-styledmeanandstddev", Samples.BoxPlot.StyledMeanAndStdDev.chart()
              "plotly-chart-boxplot-groupedhorizontal", Samples.BoxPlot.GroupedHorizontal.chart()
              "plotly-chart-boxplot-colored", Samples.BoxPlot.Colored.chart()
              "plotly-chart-boxplot-styled", Samples.BoxPlot.Styled.chart()
              "plotly-chart-boxplot-rainbow", Samples.BoxPlot.Rainbow.chart() ]

        let histograms =
            [ "plotly-chart-histogram-basic", Samples.Histogram.Basic.chart()
              "plotly-chart-histogram-horizontal", Samples.Histogram.Horizontal.chart()
              "plotly-chart-histogram-overlaid", Samples.Histogram.Overlaid.chart()
              "plotly-chart-histogram-stacked", Samples.Histogram.Stacked.chart()
              "plotly-chart-histogram-styled", Samples.Histogram.Styled.chart()
              "plotly-chart-histogram-cumulative", Samples.Histogram.Cumulative.chart()
              "plotly-chart-histogram-normalized", Samples.Histogram.Normalized.chart()
              "plotly-chart-histogram-specifiedbinning", Samples.Histogram.SpecifiedBinning.chart() ]

        let twoDimensionalHistograms =
            [ "plotly-chart-twodimensionalhistogram-bivariatenormaldistribution", Samples.TwoDimensionalHistogram.BivariateNormalDistribution.chart()
              "plotly-chart-twodimensionalhistogram-binningandstyling", Samples.TwoDimensionalHistogram.BinningAndStyling.chart()
              "plotly-chart-twodimensionalhistogram-overlaidwithscatter", Samples.TwoDimensionalHistogram.OverlaidWithScatter.chart() ]

        let twoDimensionalDensity =
            [ "plotly-chart-twodimensionaldensity-withhistogramsubplots", Samples.TwoDimensionalDensity.WithHistogramSubplots.chart() ]

        let spcControl =
            [ "plotly-chart-spccontrol-basic", Samples.SPCControl.Basic.chart()
              "plotly-chart-spccontrol-distribution", Samples.SPCControl.Distribution.chart() ]

        let violin =
            [ "plotly-chart-violin-basic", Samples.Violin.Basic.chart(centeredSpinner)
              "plotly-chart-violin-multipletraces", Samples.Violin.MultipleTraces.chart(centeredSpinner)
              "plotly-chart-violin-grouped", Samples.Violin.Grouped.chart(centeredSpinner)
              "plotly-chart-violin-horizontal", Samples.Violin.Horizontal.chart(centeredSpinner)
              "plotly-chart-violin-split", Samples.Violin.Split.chart(centeredSpinner)
              "plotly-chart-violin-advanced", Samples.Violin.Advanced.chart() ]

        let parallelCategories =
            [ "plotly-chart-parallelcategories-basic", Samples.ParallelCategories.Basic.chart()
              "plotly-chart-parallelcategories-withcounts", Samples.ParallelCategories.WithCounts.chart()
              "plotly-chart-parallelcategories-multicolor", Samples.ParallelCategories.MultiColor.chart(centeredSpinner)
              "plotly-chart-parallelcategories-linkedbrushing", Samples.ParallelCategories.LinkedBrushing.chart(centeredSpinner)
              "plotly-chart-parallelcategories-multicolorlinkedbrushing", Samples.ParallelCategories.MultiColorLinkedBrushing.chart() ]

        let splom =
            [ "plotly-chart-splom-iris", Samples.Splom.Iris.chart(centeredSpinner)
              "plotly-chart-splom-diabetes", Samples.Splom.Diabetes.chart(centeredSpinner) ]

        let twoDimensionalHistogramContour =
            [ "plotly-chart-twodimensionalhistogramcontour-basic", Samples.TwoDimensionalHistogramContour.Basic.chart()
              "plotly-chart-twodimensionalhistogramcontour-colorscale", Samples.TwoDimensionalHistogramContour.Colorscale.chart()
              "plotly-chart-twodimensionalhistogramcontour-styled", Samples.TwoDimensionalHistogramContour.Styled.chart() ]

        [ errorBars
          continuousErrorBars
          boxPlots
          histograms
          twoDimensionalHistograms
          twoDimensionalDensity
          spcControl
          violin
          parallelCategories
          splom
          twoDimensionalHistogramContour ]
        |> List.concat

    let scientificExamples =
        let carpet =
            [ "plotly-chart-carpet-addaandbaxis", Samples.Carpet.AddAAndBAxis.chart()
              "plotly-chart-carpet-basic", Samples.Carpet.Basic.chart()
              "plotly-chart-carpet-styleaandbaxis", Samples.Carpet.StyleAAndBAxis.chart() ]

        let carpetContour =
            [ "plotly-chart-carpetcontour-basic", Samples.CarpetContour.Basic.chart()
              "plotly-chart-carpetcontour-multipletraces", Samples.CarpetContour.MultipleTraces.chart(centeredSpinner) ]

        let carpetScatter =
            [ "plotly-chart-carpetscatter-basic", Samples.CarpetScatter.Basic.chart()
              "plotly-chart-carpetscatter-multipletraces", Samples.CarpetScatter.MultipleTraces.chart() ]

        let contour =
            [ "plotly-chart-contour-basic", Samples.Contour.Basic.chart()
              "plotly-chart-contour-colorbarsize", Samples.Contour.ColorbarSize.chart()
              "plotly-chart-contour-colorbartitle", Samples.Contour.ColorbarTitle.chart()
              "plotly-chart-contour-colorscale", Samples.Contour.Colorscale.chart()
              "plotly-chart-contour-connectinggapsinzmatrix", Samples.Contour.ConnectingGapsInZMatrix.chart()
              "plotly-chart-contour-customcolorscale", Samples.Contour.CustomColorscale.chart()
              "plotly-chart-contour-customsizeandrange", Samples.Contour.CustomSizeAndRange.chart()
              "plotly-chart-contour-customspacing", Samples.Contour.CustomSpacing.chart()
              "plotly-chart-contour-lines", Samples.Contour.Lines.chart()
              "plotly-chart-contour-linelabels", Samples.Contour.LineLabels.chart()
              "plotly-chart-contour-settingxandycoordinates", Samples.Contour.SettingXAndYCoordinates.chart()
              "plotly-chart-contour-simple", Samples.Contour.Simple.chart()
              "plotly-chart-contour-smoothcoloring", Samples.Contour.SmoothColoring.chart()
              "plotly-chart-contour-smoothinglines", Samples.Contour.SmoothingLines.chart()
              "plotly-chart-contour-stylingcolorbar", Samples.Contour.StylingColorbar.chart() ]

        let heatmap =
            [ "plotly-chart-heatmap-annotated", Samples.Heatmap.Annotated.chart()
              "plotly-chart-heatmap-basic", Samples.Heatmap.Basic.chart()
              "plotly-chart-heatmap-unequalblocksizes", Samples.Heatmap.UnequalBlockSizes.chart()
              "plotly-chart-heatmap-withcategoricalaxislabels", Samples.Heatmap.WithCategoricalAxisLabels.chart()
              "plotly-chart-heatmap-webgl", Samples.Heatmap.WebGL.chart() ]

        let log =
            [ "plotly-chart-log-logarithmicaxes", Samples.Log.LogarithmicAxes.chart() ]

        let parallelCoordinates =
            [ "plotly-chart-parallelcoordinates-addingdimensions", Samples.ParallelCoordinates.AddingDimensions.chart(centeredSpinner)
              "plotly-chart-parallelcoordinates-advanced", Samples.ParallelCoordinates.Advanced.chart(centeredSpinner)
              "plotly-chart-parallelcoordinates-annotated", Samples.ParallelCoordinates.Annotated.chart(centeredSpinner)
              "plotly-chart-parallelcoordinates-basic", Samples.ParallelCoordinates.Basic.chart() ]

        let polar =
            [ "plotly-chart-polar-area", Samples.Polar.Area.chart()
              "plotly-chart-polar-categorical", Samples.Polar.Categorical.chart()
              "plotly-chart-polar-directions", Samples.Polar.Directions.chart()
              "plotly-chart-polar-line", Samples.Polar.Line.chart(centeredSpinner)
              "plotly-chart-polar-sector", Samples.Polar.Sector.chart()
              "plotly-chart-polar-subplots", Samples.Polar.Subplots.chart()
              "plotly-chart-polar-webgl", Samples.Polar.WebGL.chart(centeredSpinner) ]

        let radar =
            [ "plotly-chart-radar-basic", Samples.Radar.Basic.chart()
              "plotly-chart-radar-multipletraces", Samples.Radar.MultipleTraces.chart() ]

        let ternary =
            [ "plotly-chart-ternary-soiltypes", Samples.Ternary.SoilTypes.chart(centeredSpinner)
              "plotly-chart-ternary-withmarkers", Samples.Ternary.WithMarkers.chart() ]

        let ternaryContour =
            [ "plotly-chart-ternarycontour-filled", Samples.TernaryContour.Filled.chart(centeredSpinner) ]

        let windRose =
            [ "plotly-chart-windrose-basic", Samples.WindRose.Basic.chart() ]

        [ carpet
          carpetContour
          carpetScatter
          contour
          log
          heatmap
          parallelCoordinates
          polar
          radar
          ternary
          ternaryContour
          windRose ]
        |> List.concat

    let financialExamples =
        let candlestick =
            [ "plotly-chart-candlestick-basic", Samples.Candlestick.Basic.chart()
              "plotly-chart-candlestick-rangebreaks", Samples.Candlestick.RangeBreaks.chart() ]

        let funnel =
            [ "plotly-chart-funnel-basic", Samples.Funnel.Basic.chart()
              "plotly-chart-funnel-funnelarea", Samples.Funnel.FunnelArea.chart() ]

        let indicators =
            [ "plotly-chart-indicators-showcase", Samples.Indicators.Showcase.chart()
              "plotly-chart-indicators-overlay", Samples.Indicators.Overlay.chart() ]

        let ohlc =
            [ "plotly-chart-ohlc-basic", Samples.OHLC.Basic.chart(centeredSpinner) ]

        let timeSeries =
            [ "plotly-chart-timeseries-basic", Samples.TimeSeries.Basic.chart(centeredSpinner)
              "plotly-chart-timeseries-setrange", Samples.TimeSeries.SetRange.chart(centeredSpinner)
              "plotly-chart-timeseries-rangeslider", Samples.TimeSeries.RangeSlider.chart(centeredSpinner) ]

        let waterfall =
            [ "plotly-chart-waterfall-basic", Samples.Waterfall.Basic.chart()
              "plotly-chart-waterfall-multicategory", Samples.Waterfall.MultiCategory.chart()
              "plotly-chart-waterfall-horizontal", Samples.Waterfall.Horizontal.chart()
              "plotly-chart-waterfall-styled", Samples.Waterfall.Styled.chart() ]

        [ candlestick; funnel; indicators; ohlc; timeSeries; waterfall ]
        |> List.concat

    let mapExamples =
        [ "plotly-chart-maps-scatter", Samples.Maps.Scatter.chart(centeredSpinner)
          "plotly-chart-maps-heatmap", Samples.Maps.Heatmap.chart()
          "plotly-chart-maps-lines", Samples.Maps.Lines.chart(centeredSpinner)
          "plotly-chart-maps-bubble", Samples.Maps.Bubble.chart(centeredSpinner)
          "plotly-chart-maps-filledarea", Samples.Maps.FilledArea.chart()
          "plotly-chart-maps-choropleth", Samples.Maps.Choropleth.chart(centeredSpinner) ]

    let threeDimensionalExamples =
        [ "plotly-chart-3d-scatter", Samples.ThreeDimensional.Scatter.chart(centeredSpinner)
          "plotly-chart-3d-ribbon", Samples.ThreeDimensional.Ribbon.chart(centeredSpinner)
          "plotly-chart-3d-surface", Samples.ThreeDimensional.Surface.chart(centeredSpinner)
          "plotly-chart-3d-mesh", Samples.ThreeDimensional.Mesh.chart()
          "plotly-chart-3d-line", Samples.ThreeDimensional.Line.chart(centeredSpinner)
          "plotly-chart-3d-trisurf", Samples.ThreeDimensional.TriSurf.chart()
          "plotly-chart-3d-clustergraph", Samples.ThreeDimensional.ClusterGraph.chart(centeredSpinner)
          "plotly-chart-3d-cone", Samples.ThreeDimensional.Cone.chart()
          "plotly-chart-3d-streamtube", Samples.ThreeDimensional.Streamtube.chart(centeredSpinner)
          "plotly-chart-3d-isosurface", Samples.ThreeDimensional.Isosurface.chart(centeredSpinner) ]

    let subplotExamples =
        let multipleAxes =
            [ "plotly-chart-multipleaxes-twoyaxes", Samples.MultipleAxes.TwoYAxes.chart()
              "plotly-chart-multipleaxes-multipleyaxes", Samples.MultipleAxes.MultipleYAxes.chart() ]

        [ yield! multipleAxes
          "plotly-chart-subplots-inset", Samples.Subplots.Inset.chart()
          "plotly-chart-subplots-mixed", Samples.Subplots.Mixed.chart(centeredSpinner) ]

    let eventExamples =
        [ "plotly-chart-events-click", Samples.Events.Click.chart()
          "plotly-chart-events-hover", Samples.Events.Hover.chart()
          "plotly-chart-events-zoom", Samples.Events.Zoom.chart()
          "plotly-chart-events-disablezoom", Samples.Events.DisableZoom.chart(centeredSpinner)
          "plotly-chart-events-downloadimage", Samples.Events.DownloadImage.chart() ]

    let transformExamples =
        [ "plotly-chart-transforms-filter", Samples.Transforms.Filter.chart()
          "plotly-chart-transforms-groupby", Samples.Transforms.Groupby.chart()
          "plotly-chart-transforms-aggregations", Samples.Transforms.Aggregations.chart()
          "plotly-chart-transforms-multiple", Samples.Transforms.Multiple.chart(centeredSpinner) ]

    let transitionExamples =
        [ "plotly-chart-transitions-lorenz", Samples.Transitions.Lorenz.chart() ]

    let customExamples =
        [ "plotly-chart-custom-gantt", Samples.Custom.Gantt.chart()
          "plotly-chart-custom-webglgantt", Samples.Custom.WebGLGantt.chart() ]

    let localeExamples =
        [ "plotly-chart-locales-config", Samples.Locales.Config.chart()
          "plotly-chart-locales-moduleregistration", Samples.Locales.ModuleRegistration.chart() ]

    [ basicSamples; statisticalExamples; scientificExamples; financialExamples
      mapExamples; threeDimensionalExamples; subplotExamples; eventExamples
      transformExamples; transitionExamples; customExamples; localeExamples ]
    |> List.concat

let githubPath (rawPath: string) =
    let parts = rawPath.Split('/')
    if parts.Length > 5
    then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
    else rawPath

/// Renders a code block from markdown using react-highlight.
/// Injects sample React components when the code block has language of the format <language>:<sample-name>
let codeBlockRenderer' = React.functionComponent(fun (input: {| codeProps: Markdown.ICodeProperties |}) ->
    let className = input.codeProps.className
    if className <> null && className.Contains(":") then
        let languageParts = className.Split(':')
        let sampleName = languageParts.[1]
        let sampleApp =
            samples
            |> List.tryFind (fun (name, _) -> name = sampleName)
            |> Option.map snd
            |> Option.defaultValue (Html.h1 [
                prop.style [ style.color.crimson ];
                prop.text (sprintf "Could not find sample app '%s'" sampleName)
            ])

        Html.div [
            prop.children [
                sampleApp
                Highlight.highlight [
                    prop.className "fsharp"
                    prop.children input.codeProps.children
                ]
            ]
        ]
    else
        Highlight.highlight [
            prop.className "fsharp"
            prop.children input.codeProps.children
        ]
)

let codeBlockRenderer (codeProps: Markdown.ICodeProperties) = codeBlockRenderer' {| codeProps = codeProps |}

let renderMarkdown = React.functionComponent(fun (input: {| path: string; content: string |}) ->
    Html.div [
        prop.className [ Bulma.Content; "scrollbar" ]
        prop.style [
            style.width (length.percent 100)
            style.padding (0,20)
        ]
        prop.children [
            if input.path.StartsWith "https://raw.githubusercontent.com" then
                Html.h2 [
                    Html.i [ prop.className [ FA.Fa; FA.FaGithub ] ]
                    Html.anchor [
                        prop.style [ style.marginLeft 10; style.color.lightGreen ]
                        prop.href (githubPath input.path)
                        prop.text "View on Github"
                    ]
                ]

            Markdown.markdown [
                markdown.children input.content
                markdown.escapeHtml false
                markdown.components [
                    markdown.components.code codeBlockRenderer
                ]
            ]
        ]
    ]
)

module MarkdownLoader =
    open Feliz.UseElmish

    type State =
        | Initial
        | Loading
        | Errored of string
        | LoadedMarkdown of content: string

    type Msg =
        | StartLoading of path: string list
        | Loaded of Result<string, int * string>

    let init (path: string list) = Initial, Cmd.ofMsg (StartLoading path)

    let resolvePath = function
    | [ one: string ] when one.StartsWith "http" -> one
    | segments -> String.concat "/" segments

    let update (msg: Msg) (state: State) =
        match msg with
        | StartLoading path ->
            let loadMarkdownAsync() = async {
                let! (statusCode, responseText) = Http.get (resolvePath path)
                if statusCode = 200
                then return Loaded (Ok responseText)
                else return Loaded (Error (statusCode, responseText))
            }

            Loading, Cmd.OfAsync.perform loadMarkdownAsync () id

        | Loaded (Ok content) ->
            State.LoadedMarkdown content, Cmd.none

        | Loaded (Error (status, _)) ->
            State.LoadedMarkdown (sprintf "Status %d: could not load markdown" status), Cmd.none

    let render = React.functionComponent(fun (input: {| path: string list |}) ->
        let state,_ = React.useElmish(init input.path, update, [| input.path :> obj |])

        match state with
        | Initial -> Html.none
        | Loading -> centeredSpinner
        | LoadedMarkdown content -> renderMarkdown {| path = (resolvePath input.path); content = content |}
        | Errored error ->
            Html.h1 [
                prop.style [ style.color.crimson ]
                prop.text error
            ])

    let inline load (path: string list) = render {| path = path |}

// A collapsable nested menu for the sidebar
// keeps internal state on whether the items should be visible or not based on the collapsed state
let nestedMenuList' = React.functionComponent(fun (input: {| state: State; name: string; basePath: string list; elems: (string list -> Fable.React.ReactElement) list; dispatch: Msg -> unit |}) ->
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
    ])

// top level label
let menuLabel' = React.functionComponent (fun (input: {| content: string |}) ->
    Html.p [
        prop.className [ Bulma.MenuLabel; Bulma.IsUnselectable ]
        prop.text input.content
    ])

// top level menu
let menuList' = React.functionComponent(fun (input: {| items: Fable.React.ReactElement list |}) ->
    Html.ul [
        prop.className Bulma.MenuList
        prop.style [ style.width (length.percent 95) ]
        prop.children input.items
    ])

let menuItem' = React.functionComponent(fun (input: {| currentPath: string list; name: string; path: string list |}) ->
    Html.li [
        Html.anchor [
            prop.className [
                if input.currentPath = input.path then Bulma.IsActive
                if input.currentPath = input.path then Bulma.HasBackgroundPrimary
            ]
            prop.text input.name
            prop.href (sprintf "#/%s" (String.concat "/" input.path))
        ]
    ])

let menuLabel (content: string) =
    menuLabel' {| content = content |}

let menuList (items: Fable.React.ReactElement list) =
    menuList' {| items = items |}

let allItems = React.functionComponent(fun (input: {| state: State; dispatch: Msg -> unit |} ) ->
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

    let nestedMenuList (name: string) (basePath: string list) (items: (string list -> Fable.React.ReactElement) list) =
        nestedMenuList'
            {| state = input.state
               name = name
               basePath = basePath
               elems = items
               dispatch = dispatch |}

    let subNestedMenuList (name: string) (basePath: string list) (items: (string list -> Fable.React.ReactElement) list) (addedBasePath: string list) =
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
    ])

let sidebar = React.functionComponent(fun (input: {| state: State; dispatch: Msg -> unit |}) ->
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
    ])

let readme = sprintf "https://raw.githubusercontent.com/%s/%s/master/README.md"
let contributing = sprintf "https://raw.githubusercontent.com/Zaid-Ajaj/Feliz/master/public/Feliz/Contributing.md"

let basicExamples (currentPath: string list) =
    match currentPath with
    | Urls.Scatter :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.DataLabelsHover ] -> [ "DataLabelsHover.md" ]
        | [ Urls.DataLabelsOnPlot ] -> [ "DataLabelsOnPlot.md" ]
        | [ Urls.ColorDimension ] -> [ "ColorDimension.md" ]
        | _ -> []
        |> List.append [ Urls.Scatter ]
    | Urls.Bubble :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.HoverText ] -> [ "HoverText.md" ]
        | [ Urls.MarkerSizeAndColor ] -> [ "MarkerSizeAndColor.md" ]
        | [ Urls.SizeScaling ] -> [ "SizeScaling.md" ]
        | [ Urls.MarkerSizeColorAndSymbolArray ] -> [ "MarkerSizeColorAndSymbolArray.md" ]
        | _ -> []
        |> List.append [ Urls.Bubble ]
    | Urls.Dot :: rest ->
        match rest with
        | [ Urls.Categorical ] -> [ "Categorical.md" ]
        | _ -> []
        |> List.append [ Urls.Dot ]
    | Urls.Line :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.NamedLineAndScatter ] -> [ "NamedLineAndScatter.md" ]
        | [ Urls.LineAndScatterStyling ] -> [ "LineAndScatterStyling.md" ]
        | [ Urls.StylingLinePlot ] -> [ "StylingLinePlot.md" ]
        | [ Urls.ColoredAndStyledScatter ] -> [ "ColoredAndStyledScatter.md" ]
        | [ Urls.LineShapeOptionsInterpolation ] -> [ "LineShapeOptionsInterpolation.md" ]
        | [ Urls.GraphAndAxesTitles ] -> [ "GraphAndAxesTitles.md" ]
        | [ Urls.LineDash ] -> [ "LineDash.md" ]
        | [ Urls.ConnectGapsBetweenData ] -> [ "ConnectGapsBetweenData.md" ]
        | [ Urls.LabellingLinesWithAnnotations ] -> [ "LabellingLinesWithAnnotations.md" ]
        | _ -> []
        |> List.append [ Urls.Line ]
    | Urls.Bar :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Grouped ] -> [ "Grouped.md" ]
        | [ Urls.Stacked ] -> [ "Stacked.md" ]
        | [ Urls.HoverText ] -> [ "HoverText.md" ]
        | [ Urls.DirectLabels ] -> [ "DirectLabels.md" ]
        | [ Urls.GroupedDirectLabels ] -> [ "GroupedDirectLabels.md" ]
        | [ Urls.RotatedLabels ] -> [ "RotatedLabels.md" ]
        | [ Urls.Colors ] -> [ "Colors.md" ]
        | [ Urls.Widths ] -> [ "Widths.md" ]
        | [ Urls.Base ] -> [ "Base.md" ]
        | [ Urls.ColoredAndStyled ] -> [ "ColoredAndStyled.md" ]
        | [ Urls.Waterfall ] -> [ "Waterfall.md" ]
        | [ Urls.RelativeBarmode ] -> [ "RelativeBarmode.md" ]
        | _ -> []
        |> List.append [ Urls.Bar ]
    | Urls.FilledArea :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.OverlaidWithoutBoundary ] -> [ "OverlaidWithoutBoundary.md" ]
        | [ Urls.StackedArea ] -> [ "StackedArea.md" ]
        | [ Urls.NormalizedStackedArea ] -> [ "NormalizedStackedArea.md" ]
        | [ Urls.SelectHover ] -> [ "SelectHover.md" ]
        | _ -> []
        |> List.append [ Urls.FilledArea ]
    | Urls.HorizontalBar :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Colored ] -> [ "Colored.md" ]
        | [ Urls.BarWithLinePlot ] -> [ "BarWithLinePlot.md" ]
        | _ -> []
        |> List.append [ Urls.HorizontalBar ]
    | Urls.Pie :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Subplots ] -> [ "Subplots.md" ]
        | [ Urls.Donut ] -> [ "Donut.md" ]
        | _ -> []
        |> List.append [ Urls.Pie ]
    | Urls.Sunburst :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Branchvalues ] -> [ "Branchvalues.md" ]
        | [ Urls.RepeatedLabels ] -> [ "RepeatedLabels.md" ]
        | [ Urls.LargeNumberSlices ] -> [ "LargeNumberSlices.md" ]
        | _ -> []
        |> List.append [ Urls.Sunburst ]
    | Urls.Sankey :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> []
        |> List.append [ Urls.Sankey ]
    | Urls.PointCloud :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> []
        |> List.append [ Urls.PointCloud ]
    | Urls.Treemap :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.DifferentAttributes ] -> [ "DifferentAttributes.md" ]
        | [ Urls.SectorColors ] -> [ "SectorColors.md" ]
        | [ Urls.NestedLayers ] -> [ "NestedLayers.md" ]
        | _ -> []
        |> List.append [ Urls.Treemap ]
    | Urls.Table :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.FromCSV ] -> [ "FromCSV.md" ]
        | [ Urls.ChangingSizes ] -> [ "ChangingSizes.md" ]
        | [ Urls.AlternatingRowColors ] -> [ "AlternatingRowColors.md" ]
        | _ -> []
        |> List.append [ Urls.Table ]
    | Urls.MultipleChartTypes :: rest ->
        match rest with
        | [ Urls.LineAndBar ] -> [ "LineAndBar.md" ]
        | [ Urls.ContourAndScatter ] -> [ "ContourAndScatter.md" ]
        | _ -> []
        |> List.append [ Urls.MultipleChartTypes ]
    | _ -> []
    |> List.append [ Urls.Basic ]

let statisticalExamples (currentPath: string list) =
    match currentPath with
    | Urls.ErrorBar :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.WithBarChart ] -> [ "WithBarChart.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Asymmetric ] -> [ "Asymmetric.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.PercentageOfYValue ] -> [ "PercentageOfYValue.md" ]
        | [ Urls.AsymmetricWithOffset ] -> [ "AsymmetricWithOffset.md" ]
        | _ -> []
        |> List.append [ Urls.ErrorBar ]
    | Urls.ContinuousErrorBar :: rest ->
        match rest with
        | [ Urls.FilledLines ] -> [ "FilledLines.md" ]
        | [ Urls.AsymmetricWithOffset ] -> [ "AsymmetricWithOffset.md" ]
        | _ -> []
        |> List.append [ Urls.ContinuousErrorBar ]
    | Urls.BoxPlot :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.UnderlyingData ] -> [ "UnderlyingData.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Grouped ] -> [ "Grouped.md" ]
        | [ Urls.StyledOutliers ] -> [ "StyledOutliers.md" ]
        | [ Urls.StyledMeanAndStdDev ] -> [ "StyledMeanAndStdDev.md" ]
        | [ Urls.GroupedHorizontal ] -> [ "GroupedHorizontal.md" ]
        | [ Urls.Colored ] -> [ "Colored.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.Rainbow ] -> [ "Rainbow.md" ]
        | _ -> []
        |> List.append [ Urls.BoxPlot ]
    | Urls.Histogram :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Overlaid ] -> [ "Overlaid.md" ]
        | [ Urls.Stacked ] -> [ "Stacked.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.Cumulative ] -> [ "Cumulative.md" ]
        | [ Urls.Normalized ] -> [ "Normalized.md" ]
        | [ Urls.SpecifiedBinning ] -> [ "SpecifiedBinning.md" ]
        | _ -> []
        |> List.append [ Urls.Histogram ]
    | Urls.TwoDimensionalHistogram :: rest ->
        match rest with
        | [ Urls.BivariateNormalDistribution ] -> [ "BivariateNormalDistribution.md" ]
        | [ Urls.BinningAndStyling ] -> [ "BinningAndStyling.md" ]
        | [ Urls.OverlaidWithScatter ] -> [ "OverlaidWithScatter.md" ]
        | _ -> []
        |> List.append [ Urls.TwoDimensionalHistogram ]
    | Urls.TwoDimensionalDensity :: rest ->
        match rest with
        | [ Urls.WithHistogramSubplots ] -> [ "WithHistogramSubplots.md" ]
        | _ -> []
        |> List.append [ Urls.TwoDimensionalDensity ]
    | Urls.SPCControl :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Distribution ] -> [ "Distribution.md" ]
        | _ -> []
        |> List.append [ Urls.SPCControl ]
    | Urls.Violin :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.MultipleTraces ] -> [ "MultipleTraces.md" ]
        | [ Urls.Grouped ] -> [ "Grouped.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Split ] -> [ "Split.md" ]
        | [ Urls.Advanced ] -> [ "Advanced.md" ]
        | _ -> []
        |> List.append [ Urls.Violin ]
    | Urls.ParallelCategories :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.WithCounts ] -> [ "WithCounts.md" ]
        | [ Urls.MultiColor ] -> [ "MultiColor.md" ]
        | [ Urls.LinkedBrushing ] -> [ "LinkedBrushing.md" ]
        | [ Urls.MultiColorLinkedBrushing ] -> [ "MultiColorLinkedBrushing.md" ]
        | _ -> []
        |> List.append [ Urls.ParallelCategories ]
    | Urls.Splom :: rest ->
        match rest with
        | [ Urls.Iris ] -> [ "Iris.md" ]
        | [ Urls.Diabetes ] -> [ "Diabetes.md" ]
        | _ -> []
        |> List.append [ Urls.Splom ]
    | Urls.TwoDimensionalHistogramContour :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Colorscale ] -> [ "Colorscale.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> []
        |> List.append [ Urls.TwoDimensionalHistogramContour ]
    | _ -> []
    |> List.append [ Urls.Statistical ]

let scientificExamples (currentPath: string list) =
    match currentPath with
    | Urls.Log :: rest ->
        match rest with
        | [ Urls.LogarithmicAxes ] -> [ "LogarithmicAxes.md" ]
        | _ -> []
        |> List.append [ Urls.Log ]
    | Urls.Contour :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Simple ] -> [ "Simple.md" ]
        | [ Urls.SettingXAndYCoordinates ] -> [ "SettingXAndYCoordinates.md" ]
        | [ Urls.Colorscale ] -> [ "Colorscale.md" ]
        | [ Urls.CustomSizeAndRange ] -> [ "CustomSizeAndRange.md" ]
        | [ Urls.CustomSpacing ] -> [ "CustomSpacing.md" ]
        | [ Urls.ConnectingGapsInZMatrix ] -> [ "ConnectingGapsInZMatrix.md" ]
        | [ Urls.SmoothingLines ] -> [ "SmoothingLines.md" ]
        | [ Urls.SmoothColoring ] -> [ "SmoothColoring.md" ]
        | [ Urls.Lines ] -> [ "Lines.md" ]
        | [ Urls.LineLabels ] -> [ "LineLabels.md" ]
        | [ Urls.CustomColorscale ] -> [ "CustomColorscale.md" ]
        | [ Urls.ColorbarTitle ] -> [ "ColorbarTitle.md" ]
        | [ Urls.ColorbarSize ] -> [ "ColorbarSize.md" ]
        | [ Urls.StylingColorbar ] -> [ "StylingColorbar.md" ]
        | _ -> []
        |> List.append [ Urls.Contour ]
    | Urls.Heatmap :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Annotated ] -> [ "Annotated.md" ]
        | [ Urls.WithCategoricalAxisLabels ] -> [ "WithCategoricalAxisLabels.md" ]
        | [ Urls.UnequalBlockSizes ] -> [ "UnequalBlockSizes.md" ]
        | [ Urls.WebGL ] -> [ "WebGL.md" ]
        | _ -> []
        |> List.append [ Urls.Heatmap ]
    | Urls.WindRose :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | _ -> []
        |> List.append [ Urls.WindRose ]
    | Urls.Ternary :: rest ->
        match rest with
        | [ Urls.WithMarkers ] -> [ "WithMarkers.md" ]
        | [ Urls.SoilTypes ] -> [ "SoilTypes.md" ]
        | _ -> []
        |> List.append [ Urls.Ternary ]
    | Urls.TernaryContour :: rest ->
        match rest with
        | [ Urls.Filled ] -> [ "Filled.md" ]
        | _ -> []
        |> List.append [ Urls.TernaryContour ]
    | Urls.Radar :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.MultipleTraces ] -> [ "MultipleTraces.md" ]
        | _ -> []
        |> List.append [ Urls.Radar ]
    | Urls.ParallelCoordinates :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.AddingDimensions ] -> [ "AddingDimensions.md" ]
        | [ Urls.Annotated ] -> [ "Annotated.md" ]
        | [ Urls.Advanced ] -> [ "Advanced.md" ]
        | _ -> []
        |> List.append [ Urls.ParallelCoordinates ]
    | Urls.Carpet :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.AddAAndBAxis ] -> [ "AddAAndBAxis.md" ]
        | [ Urls.StyleAAndBAxis ] -> [ "StyleAAndBAxis.md" ]
        | _ -> []
        |> List.append [ Urls.Carpet ]
    | Urls.CarpetScatter :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.MultipleTraces ] -> [ "MultipleTraces.md" ]
        | _ -> []
        |> List.append [ Urls.CarpetScatter ]
    | Urls.CarpetContour :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.MultipleTraces ] -> [ "MultipleTraces.md" ]
        | _ -> []
        |> List.append [ Urls.CarpetContour ]
    | Urls.Polar :: rest ->
        match rest with
        | [ Urls.Line ] -> [ "Line.md" ]
        | [ Urls.Area ] -> [ "Area.md" ]
        | [ Urls.Categorical ] -> [ "Categorical.md" ]
        | [ Urls.Directions ] -> [ "Directions.md" ]
        | [ Urls.Sector ] -> [ "Sector.md" ]
        | [ Urls.Subplots ] -> [ "Subplots.md" ]
        | [ Urls.WebGL ] -> [ "WebGL.md" ]
        | _ -> []
        |> List.append [ Urls.Polar ]
    | _ -> []
    |> List.append [ Urls.Scientific ]

let financialExamples (currentPath: string list) =
    match currentPath with
    | Urls.Waterfall :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.MultiCategory ] -> [ "MultiCategory.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> []
        |> List.append [ Urls.Waterfall ]
    | Urls.Indicators :: rest ->
        match rest with
        | [ Urls.Showcase ] -> [ "Showcase.md" ]
        | [ Urls.Overlay ] -> [ "Overlay.md" ]
        | _ -> []
        |> List.append [ Urls.Indicators ]
    | Urls.Candlestick :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.RangeBreaks ] -> [ "RangeBreaks.md" ]
        | _ -> []
        |> List.append [ Urls.Candlestick ]
    | Urls.Funnel :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.FunnelArea ] -> [ "FunnelArea.md" ]
        | _ -> []
        |> List.append [ Urls.Funnel ]
    | Urls.TimeSeries :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.SetRange ] -> [ "SetRange.md" ]
        | [ Urls.RangeSlider ] -> [ "RangeSlider.md" ]
        | _ -> []
        |> List.append [ Urls.TimeSeries ]
    | Urls.OHLC :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | _ -> []
        |> List.append [ Urls.OHLC ]
    | _ -> []
    |> List.append [ Urls.Financial ]

let mapExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Scatter ] -> [ "Scatter.md" ]
    | [ Urls.Heatmap ] -> [ "Heatmap.md" ]
    | [ Urls.Lines ] -> [ "Lines.md" ]
    | [ Urls.Bubble ] -> [ "Bubble.md" ]
    | [ Urls.FilledArea ] -> [ "FilledArea.md" ]
    | [ Urls.Choropleth ] -> [ "Choropleth.md" ]
    | _ -> []
    |> List.append [ Urls.Maps ]

let threeDimensionalExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Scatter ] -> [ "Scatter.md" ]
    | [ Urls.Ribbon ] -> [ "Ribbon.md" ]
    | [ Urls.Surface ] -> [ "Surface.md" ]
    | [ Urls.Mesh ] -> [ "Mesh.md" ]
    | [ Urls.Line ] -> [ "Line.md" ]
    | [ Urls.TriSurf ] -> [ "TriSurf.md" ]
    | [ Urls.ClusterGraph ] -> [ "ClusterGraph.md" ]
    | [ Urls.Cone ] -> [ "Cone.md" ]
    | [ Urls.Streamtube ] -> [ "Streamtube.md" ]
    | [ Urls.Isosurface ] -> [ "Isosurface.md" ]
    | _ -> []
    |> List.append [ Urls.ThreeDimensional ]

let subplotExamples (currentPath: string list) =
    match currentPath with
    | Urls.MultipleAxes :: rest ->
        match rest with
        | [ Urls.TwoYAxes ] -> [ "TwoYAxes.md" ]
        | [ Urls.MultipleYAxes ] -> [ "MultipleYAxes.md" ]
        | _ -> []
        |> List.append [ Urls.MultipleAxes ]
    | [ Urls.Inset ] -> [ "Inset.md" ]
    | [ Urls.Mixed ] -> [ "Mixed.md" ]
    | _ -> []
    |> List.append [ Urls.Subplots ]

let eventExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Click ] -> [ "Click.md" ]
    | [ Urls.Hover ] -> [ "Hover.md" ]
    | [ Urls.Zoom ] -> [ "Zoom.md" ]
    | [ Urls.DisableZoom ] -> [ "DisableZoom.md" ]
    | [ Urls.DownloadImage ] -> [ "DownloadImage.md" ]
    | _ -> []
    |> List.append [ Urls.Events ]

let transformExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Filter ] -> [ "Filter.md" ]
    | [ Urls.Groupby ] -> [ "Groupby.md" ]
    | [ Urls.Aggregations ] -> [ "Aggregations.md" ]
    | [ Urls.Multiple ] -> [ "Multiple.md" ]
    | _ -> []
    |> List.append [ Urls.Transforms ]

let transitionExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Lorenz ] -> [ "Lorenz.md" ]
    | _ -> []
    |> List.append [ Urls.Transitions ]

let customExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Gantt ] -> [ "Gantt.md" ]
    | [ Urls.WebGLGantt ] -> [ "WebGLGantt.md" ]
    | _ -> []
    |> List.append [ Urls.Custom ]

let localeExamples (currentPath: string list) =
    match currentPath with
    | [ Urls.Config ] -> [ "Config.md" ]
    | [ Urls.ModuleRegistration ] -> [ "ModuleRegistration.md" ]
    | _ -> []
    |> List.append [ Urls.Locales ]

let (|PathPrefix|) (segments: string list) (path: string list) =
    if path.Length > segments.Length then
        match List.splitAt segments.Length path with
        | start,end' when start = segments -> Some end'
        | _ -> None
    else None

let content = React.functionComponent(fun (input: {| state: State; dispatch: Msg -> unit |}) ->
    match input.state.CurrentPath with
    | [ Urls.Plotly; Urls.Overview; ] -> lazyView MarkdownLoader.load [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Installation ] -> lazyView MarkdownLoader.load [ "Plotly"; "Installation.md" ]
    | [ Urls.Plotly; Urls.ReleaseNotes ] -> lazyView MarkdownLoader.load [ "Plotly"; "RELEASE_NOTES.md" ]
    | [ Urls.Plotly; Urls.BundleSize ] -> lazyView MarkdownLoader.load [ "Plotly"; "BundleSize.md" ]
    | [ Urls.Plotly; Urls.Contributing ] -> lazyView MarkdownLoader.load [ contributing ]
    | PathPrefix [ Urls.Plotly; Urls.Examples ] (Some res) ->
        match res with
        | PathPrefix [ Urls.Basic ] (Some innerRes) -> basicExamples innerRes
        | PathPrefix [ Urls.Statistical ] (Some innerRes) -> statisticalExamples innerRes
        | PathPrefix [ Urls.Scientific ] (Some innerRes) -> scientificExamples innerRes
        | PathPrefix [ Urls.Financial ] (Some innerRes) -> financialExamples innerRes
        | PathPrefix [ Urls.Maps ] (Some innerRes) -> mapExamples innerRes
        | PathPrefix [ Urls.ThreeDimensional ] (Some innerRes) -> threeDimensionalExamples innerRes
        | PathPrefix [ Urls.Subplots ] (Some innerRes) -> subplotExamples innerRes
        | PathPrefix [ Urls.Events ] (Some innerRes) -> eventExamples innerRes
        | PathPrefix [ Urls.Transforms ] (Some innerRes) -> transformExamples innerRes
        | PathPrefix [ Urls.Transitions ] (Some innerRes) -> transitionExamples innerRes
        | PathPrefix [ Urls.Custom ] (Some innerRes) -> customExamples innerRes
        | PathPrefix [ Urls.Locales ] (Some innerRes) -> localeExamples innerRes
        | _ -> []
        |> fun path -> [ Urls.Plotly; Urls.Examples ] @ path |> lazyView MarkdownLoader.load
    | _ -> lazyView MarkdownLoader.load [ "Plotly"; "README.md" ])

let main = React.functionComponent(fun (input: {| state: State; dispatch: Msg -> unit |}) ->
    let dispatch = React.useCallback(input.dispatch, [||])

    Html.div [
        prop.className [ Bulma.Tile; Bulma.IsAncestor ]
        prop.children [
            Html.div [
                prop.className [ Bulma.Tile; Bulma.Is2 ]
                prop.children [ sidebar {| state = input.state; dispatch = dispatch |} ]
            ]

            Html.div [
                prop.className Bulma.Tile
                prop.style [ style.paddingTop 30 ]
                prop.children [ content {| state = input.state; dispatch = dispatch |} ]
            ]
        ]
    ])

let render' = React.functionComponent(fun (input: {| state: State; dispatch: Msg -> unit |}) ->
    let dispatch = React.useCallback(input.dispatch, [||])

    let application =
        Html.div [
            prop.style [
                style.padding 30
            ]
            prop.children [ main {| state = input.state; dispatch = dispatch |} ]
        ]

    React.router [
        router.onUrlChanged (UrlChanged >> dispatch)
        router.children application
    ])

let render (state: State) dispatch = render' {| state = state; dispatch = dispatch |}

Program.mkProgram init update render
|> Program.withReactSynchronous "root"
|> Program.withConsoleTrace
|> Program.run
