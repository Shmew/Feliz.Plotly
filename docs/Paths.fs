module Paths

let basicExamples (currentPath: string list) : string list =
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

let mapExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Scatter ] -> [ "Scatter.md" ]
    | [ Urls.Heatmap ] -> [ "Heatmap.md" ]
    | [ Urls.Lines ] -> [ "Lines.md" ]
    | [ Urls.Bubble ] -> [ "Bubble.md" ]
    | [ Urls.FilledArea ] -> [ "FilledArea.md" ]
    | [ Urls.Choropleth ] -> [ "Choropleth.md" ]
    | _ -> []
    |> List.append [ Urls.Maps ]

let statisticalExamples (currentPath: string list) : string list =
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

let scientificExamples (currentPath: string list) : string list =
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

let financialExamples (currentPath: string list) : string list =
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

let threeDimensionalExamples (currentPath: string list) : string list =
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

let subplotExamples (currentPath: string list) : string list =
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

let eventExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Click ] -> [ "Click.md" ]
    | [ Urls.Hover ] -> [ "Hover.md" ]
    | [ Urls.Zoom ] -> [ "Zoom.md" ]
    | [ Urls.DisableZoom ] -> [ "DisableZoom.md" ]
    | [ Urls.DownloadImage ] -> [ "DownloadImage.md" ]
    | _ -> []
    |> List.append [ Urls.Events ]

let transformExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Filter ] -> [ "Filter.md" ]
    | [ Urls.Groupby ] -> [ "Groupby.md" ]
    | [ Urls.Aggregations ] -> [ "Aggregations.md" ]
    | [ Urls.Multiple ] -> [ "Multiple.md" ]
    | _ -> []
    |> List.append [ Urls.Transforms ]

let transitionExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Lorenz ] -> [ "Lorenz.md" ]
    | _ -> []
    |> List.append [ Urls.Transitions ]

let customExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Gantt ] -> [ "Gantt.md" ]
    | [ Urls.WebGLGantt ] -> [ "WebGLGantt.md" ]
    | _ -> []
    |> List.append [ Urls.Custom ]

let localeExamples (currentPath: string list) : string list =
    match currentPath with
    | [ Urls.Config ] -> [ "Config.md" ]
    | [ Urls.ModuleRegistration ] -> [ "ModuleRegistration.md" ]
    | _ -> []
    |> List.append [ Urls.Locales ]