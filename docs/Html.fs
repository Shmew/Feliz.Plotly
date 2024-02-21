module HTML

open Fable.Core.JsInterop
open Feliz
open Feliz.Markdown
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdn.jsdelivr.net/npm/bulma@0.9.4/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css", Naming.PascalCase>

type Highlight =
    static member inline highlight (properties: IReactProperty list) : ReactElement =
        Interop.reactApi.createElement(importDefault "react-highlight", createObj !!properties)

let centeredSpinner : ReactElement =
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

let samples : (string * ReactElement) list =
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

        scatter @
        bubble @
        dot @
        line @
        bar @
        filledArea @
        horiontalBar @
        pie @
        sunburst @
        sankey @
        pointCloud @
        treemap @
        table @
        multipleChartTypes

    let statisticalExamples : (string * ReactElement) list =
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

        errorBars @
        continuousErrorBars @
        boxPlots @
        histograms @
        twoDimensionalHistograms @
        twoDimensionalDensity @
        spcControl @
        violin @
        parallelCategories @
        splom @
        twoDimensionalHistogramContour

    let scientificExamples : (string * ReactElement) list =
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

        carpet @
        carpetContour @
        carpetScatter @
        contour @
        log @
        heatmap @
        parallelCoordinates @
        polar @
        radar @
        ternary @
        ternaryContour @
        windRose

    let financialExamples : (string * ReactElement) list =
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

        candlestick @ funnel @ indicators @ ohlc @ timeSeries @ waterfall

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

    let subplotExamples : (string * ReactElement) list =
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

    basicSamples @
    statisticalExamples @
    scientificExamples @
    financialExamples @
    mapExamples @
    threeDimensionalExamples @
    subplotExamples @
    eventExamples @
    transformExamples @
    transitionExamples @
    customExamples @
    localeExamples

/// Renders a code block from markdown using react-highlight.
/// Injects sample React components when the code block has language of the format <language>:<sample-name>
let codeBlockRenderer (codeProps: Markdown.ICodeProperties) : ReactElement =
    let className = codeProps.className

    if className <> null && className.Contains(":") then
        let languageParts = className.Split(':')
        let sampleName = languageParts[1]
        let sampleApp =
            samples
            |> List.tryFind (fun (name, _) -> name = sampleName)
            |> Option.map snd
            |> Option.defaultValue (Html.h1 [
                prop.style [ style.color.crimson ];
                prop.text $"Could not find sample app '{sampleName}'"
            ])

        Html.div [
            prop.children [
                sampleApp
                Highlight.highlight [
                    prop.className "fsharp"
                    prop.children codeProps.children
                ]
            ]
        ]
    else
        Highlight.highlight [
            prop.className "fsharp"
            prop.children codeProps.children
        ]

let renderMarkdown (input: {| path: string; content: string |}) : ReactElement =
    let githubPath (rawPath: string) : string =
        let parts = rawPath.Split('/')
        if parts.Length > 5
        then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
        else rawPath

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

// top level label
let menuLabel (content : string) : ReactElement =
    Html.p [
        prop.className [ Bulma.MenuLabel; Bulma.IsUnselectable ]
        prop.text content
    ]

// top level menu
let menuList (items: ReactElement list) : ReactElement =
    Html.ul [
        prop.className Bulma.MenuList
        prop.style [ style.width (length.percent 95) ]
        prop.children items
    ]

let menuItem' (input: {| currentPath: string list; name: string; path: string list |}) : ReactElement =
    Html.li [
        Html.anchor [
            prop.className [
                if input.currentPath = input.path then Bulma.IsActive
                if input.currentPath = input.path then Bulma.HasBackgroundPrimary
            ]
            prop.text input.name
            prop.href (sprintf "#/%s" (String.concat "/" input.path))
        ]
    ]
