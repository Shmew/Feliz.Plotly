module App

open Elmish
open Elmish.React
open Fable.React
open Feliz
open Feliz.Markdown
open Fable.SimpleHttp
open Feliz.Router
open Fable.Core
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
    { CurrentPath = [ ]
      CurrentTab = [ ] }, Cmd.none

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
            [ "plotly-chart-errorbars-basic", Samples.ErrorBar.Basic.chart()
              "plotly-chart-errorbars-withbarchart", Samples.ErrorBar.WithBarChart.chart()
              "plotly-chart-errorbars-horizontal", Samples.ErrorBar.Horizontal.chart()
              "plotly-chart-errorbars-asymmetric", Samples.ErrorBar.Asymmetric.chart()
              "plotly-chart-errorbars-styled", Samples.ErrorBar.Styled.chart()
              "plotly-chart-errorbars-percentageofyvalue", Samples.ErrorBar.PercentageOfYValue.chart()
              "plotly-chart-errorbars-asymmetricwithoffset", Samples.ErrorBar.AsymmetricWithOffset.chart() ]

        let continuousErrorBars =
            [ "plotly-chart-continuouserrorbars-filledlines", Samples.ContinuousErrorBar.FilledLines.chart()
              "plotly-chart-continuouserrorbars-asymmetricwithoffset", Samples.ContinuousErrorBar.AsymmetricWithOffset.chart() ]

        [ errorBars
          continuousErrorBars ]
        |> List.concat

    [ basicSamples; statisticalExamples ]
    |> List.concat

let githubPath (rawPath: string) =
    let parts = rawPath.Split('/')
    if parts.Length > 5
    then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
    else rawPath

/// Renders a code block from markdown using react-highlight.
/// Injects sample React components when the code block has language of the format <language>:<sample-name>
let codeBlockRenderer (codeProps: Markdown.ICodeProperties) =
    if codeProps.language <> null && codeProps.language.Contains ":" then
        let languageParts = codeProps.language.Split(':')
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
            sampleApp
            Highlight.highlight [
                prop.className "fsharp"
                prop.text(codeProps.value)
            ]
        ]
    else
        Highlight.highlight [
            prop.className "fsharp"
            prop.text(codeProps.value)
        ]

let renderMarkdown (path: string) (content: string) =
    Html.div [
        prop.className [ Bulma.Content; "scrollbar" ]
        prop.style [ 
            style.width (length.percent 100)
            style.padding (0,20)
        ]
        prop.children [
            if path.StartsWith "https://raw.githubusercontent.com" then
                Html.h2 [
                    Html.i [ prop.className [ FA.Fa; FA.FaGithub ] ]
                    Html.anchor [
                        prop.style [ style.marginLeft 10; style.color.lightGreen ]
                        prop.href (githubPath path)
                        prop.text "View on Github"
                    ]
                ]

            Markdown.markdown [
                markdown.source content
                markdown.escapeHtml false
                markdown.renderers [
                    markdown.renderers.code codeBlockRenderer
                ]
            ]
        ]
    ]

module MarkdownLoader =

    open Feliz.ElmishComponents

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

    let render path (state: State) dispatch =
        match state with
        | Initial -> Html.none
        | Loading -> centeredSpinner
        | LoadedMarkdown content -> renderMarkdown (resolvePath path) content
        | Errored error ->
            Html.h1 [
                prop.style [ style.color.crimson ]
                prop.text error
            ]

    let loadMarkdown' (path: string list) =
        React.elmishComponent("LoadMarkdown", init path, update, render path)

let loadMarkdown (path: string list) = MarkdownLoader.loadMarkdown' path

// A collapsable nested menu for the sidebar
// keeps internal state on whether the items should be visible or not based on the collapsed state
let nestedMenuList' = FunctionComponent.Of((fun (state: State, name: string, basePath: string list, elems: (string list -> Fable.React.ReactElement) list, dispatch) ->
    let collapsed = 
        match state.CurrentTab with
        | [ ] -> false
        | _ -> 
            basePath 
            |> List.indexed 
            |> List.forall (fun (i, segment) -> 
                List.tryItem i state.CurrentTab 
                |> Option.map ((=) segment) 
                |> Option.defaultValue false) 

    Html.li [
        Html.anchor [
            prop.className Bulma.IsUnselectable
            prop.onClick <| fun _ -> 
                match collapsed with
                | true -> dispatch <| TabToggled (basePath |> List.rev |> List.tail |> List.rev)
                | false -> dispatch <| TabToggled basePath
            prop.children [
                Html.i [
                    prop.style [ style.marginRight 10 ]
                    prop.className [
                        FA.Fa
                        if not collapsed then FA.FaAngleDown else FA.FaAngleUp
                    ]
                ]
                Html.span name
            ]
        ]

        Html.ul [
            prop.className Bulma.MenuList
            prop.style [ 
                if not collapsed then yield! [ style.display.none ] 
            ]
            prop.children (elems |> List.map (fun f -> f basePath))
        ]
    ]), memoizeWith = memoEqualsButFunctions)

let sidebar (state: State) dispatch =
    let nestedMenuList (name: string) (basePath: string list) (items: (string list -> Fable.React.ReactElement) list) =
        nestedMenuList'(state, name, basePath, items, dispatch)

    let subNestedMenuList (name: string) (basePath: string list) (items: (string list -> Fable.React.ReactElement) list) (addedBasePath: string list) =
        nestedMenuList'(state, name, (addedBasePath @ basePath), items, dispatch)

    // top level label
    let menuLabel (content: string) =
        Html.p [
            prop.className [ Bulma.MenuLabel; Bulma.IsUnselectable ]
            prop.text content
        ]

    // top level menu
    let menuList (items: Fable.React.ReactElement list) =
        Html.ul [
            prop.className Bulma.MenuList
            prop.style [ style.width (length.percent 95) ]
            prop.children items
        ]

    let menuItem (name: string) (path: string list) =
        Html.li [
            Html.anchor [
                prop.className [
                    state.CurrentPath = path, Bulma.IsActive
                    state.CurrentPath = path, Bulma.HasBackgroundPrimary
                ]
                prop.text name
                prop.href (sprintf "#/%s" (String.concat "/" path))
            ]
        ]

    let nestedMenuItem (name: string) (extendedPath: string list) (basePath: string list) =
        let path = basePath @ extendedPath
        Html.li [
            Html.anchor [
                prop.className [
                    state.CurrentPath = path, Bulma.IsActive
                    state.CurrentPath = path, Bulma.HasBackgroundPrimary
                ]
                prop.text name
                prop.href (sprintf "#/%s" (String.concat "/" path))
            ]
        ]

    let allItems =
        Html.div [
            prop.className "scrollbar"
            prop.children [
                menuList [
                    menuItem "Overview" [ ]
                    menuItem "Installation" [ Urls.Plotly; Urls.Installation ]
                    menuItem "Contributing" [ Urls.Plotly; Urls.Contributing ]
                    menuLabel "Examples"
                    nestedMenuList "Basic Plot Types" [ Urls.Plotly; Urls.Examples; Urls.Basic ] [
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
                    nestedMenuList "Statistical Plot Types" [ Urls.Plotly; Urls.Examples; Urls.Statistical ] [
                        subNestedMenuList "Error Bars" [ Urls.ErrorBars ] [
                            nestedMenuItem "Basic" [ Urls.Basic ]
                            nestedMenuItem "With Bar Chart" [ Urls.WithBarChart ]
                            nestedMenuItem "Horizontal" [ Urls.Horizontal ]
                            nestedMenuItem "Asymmetric" [ Urls.Asymmetric ]
                            nestedMenuItem "Styled" [ Urls.Styled ]
                            nestedMenuItem "Percentage of Y Value" [ Urls.PercentageOfYValue ]
                            nestedMenuItem "Asymmetric with Offset" [ Urls.AsymmetricWithOffset ]
                        ]
                        subNestedMenuList "Continuous Error Bars" [ Urls.ContinuousErrorBars ] [
                            nestedMenuItem "Filled Lines" [ Urls.FilledLines ]
                            nestedMenuItem "Asymmetric with Offset" [ Urls.AsymmetricWithOffset ]
                        ]
                    ]
                ]
            ]
        ]

    // the actual nav bar
    Html.aside [
        prop.className Bulma.Menu
        prop.style [
            style.width (length.perc 100)
        ]
        prop.children [ menuLabel "Feliz.Plotly"; allItems ]
    ]

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
        | _ -> [ ]
        |> List.append [ Urls.Scatter ]
    | Urls.Bubble :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.HoverText ] -> [ "HoverText.md" ]
        | [ Urls.MarkerSizeAndColor ] -> [ "MarkerSizeAndColor.md" ]
        | [ Urls.SizeScaling ] -> [ "SizeScaling.md" ]
        | [ Urls.MarkerSizeColorAndSymbolArray ] -> [ "MarkerSizeColorAndSymbolArray.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Bubble ]
    | Urls.Dot :: rest ->
        match rest with
        | [ Urls.Categorical ] -> [ "Categorical.md" ]
        | _ -> [ ]
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
        | _ -> [ ]
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
        | _ -> [ ]
        |> List.append [ Urls.Bar ]
    | Urls.FilledArea :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.OverlaidWithoutBoundary ] -> [ "OverlaidWithoutBoundary.md" ]
        | [ Urls.StackedArea ] -> [ "StackedArea.md" ]
        | [ Urls.NormalizedStackedArea ] -> [ "NormalizedStackedArea.md" ]
        | [ Urls.SelectHover ] -> [ "SelectHover.md" ]
        | _ -> [ ]
        |> List.append [ Urls.FilledArea ]
    | Urls.HorizontalBar :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Colored ] -> [ "Colored.md" ]
        | [ Urls.BarWithLinePlot ] -> [ "BarWithLinePlot.md" ]
        | _ -> [ ]
        |> List.append [ Urls.HorizontalBar ]
    | Urls.Pie :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Subplots ] -> [ "Subplots.md" ]
        | [ Urls.Donut ] -> [ "Donut.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Pie ]
    | Urls.Sunburst :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Branchvalues ] -> [ "Branchvalues.md" ]
        | [ Urls.RepeatedLabels ] -> [ "RepeatedLabels.md" ]
        | [ Urls.LargeNumberSlices ] -> [ "LargeNumberSlices.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Sunburst ]
    | Urls.Sankey :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Sankey ]
    | Urls.PointCloud :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | _ -> [ ]
        |> List.append [ Urls.PointCloud ]
    | Urls.Treemap :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.DifferentAttributes ] -> [ "DifferentAttributes.md" ]
        | [ Urls.SectorColors ] -> [ "SectorColors.md" ]
        | [ Urls.NestedLayers ] -> [ "NestedLayers.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Treemap ]
    | Urls.Table :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.FromCSV ] -> [ "FromCSV.md" ]
        | [ Urls.ChangingSizes ] -> [ "ChangingSizes.md" ]
        | [ Urls.AlternatingRowColors ] -> [ "AlternatingRowColors.md" ]
        | _ -> [ ]
        |> List.append [ Urls.Table ]
    | Urls.MultipleChartTypes :: rest ->
        match rest with
        | [ Urls.LineAndBar ] -> [ "LineAndBar.md" ]
        | [ Urls.ContourAndScatter ] -> [ "ContourAndScatter.md" ]
        | _ -> [ ]
        |> List.append [ Urls.MultipleChartTypes ]
    | _ -> [ ]
    |> fun path ->
        if path |> List.isEmpty then []
        else [ Urls.Basic ] @ path

let statisticalExamples (currentPath: string list) =
    match currentPath with
    | Urls.ErrorBars :: rest ->
        match rest with
        | [ Urls.Basic ] -> [ "Basic.md" ]
        | [ Urls.WithBarChart ] -> [ "WithBarChart.md" ]
        | [ Urls.Horizontal ] -> [ "Horizontal.md" ]
        | [ Urls.Asymmetric ] -> [ "Asymmetric.md" ]
        | [ Urls.Styled ] -> [ "Styled.md" ]
        | [ Urls.PercentageOfYValue ] -> [ "PercentageOfYValue.md" ]
        | [ Urls.AsymmetricWithOffset ] -> [ "AsymmetricWithOffset.md" ]
        | _ -> [ ]
        |> List.append [ Urls.ErrorBars ]
    | Urls.ContinuousErrorBars :: rest ->
        match rest with
        | [ Urls.FilledLines ] -> [ "FilledLines.md" ]
        | [ Urls.AsymmetricWithOffset ] -> [ "AsymmetricWithOffset.md" ]
        | _ -> [ ]
        |> List.append [ Urls.ContinuousErrorBars ]
    | _ -> [ ]
    |> fun path ->
        if path |> List.isEmpty then []
        else [ Urls.Statistical ] @ path

let content state dispatch =
    let tryTakePath (basePath: string list) (path: string list) =
        let num = path.Length
        if basePath.Length >= num then
            basePath |> List.take num = path
        else false

    match state.CurrentPath with
    | [ Urls.Plotly; Urls.Overview; ] -> lazyView loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Installation ] -> lazyView loadMarkdown [ "Plotly"; "Installation.md" ]
    | [ Urls.Plotly; Urls.Contributing ] -> lazyView loadMarkdown [ contributing ]
    | _ when tryTakePath state.CurrentPath [ Urls.Plotly; Urls.Examples ] -> 
        match state.CurrentPath |> List.skip 2 with
        | basicPath when tryTakePath basicPath [ Urls.Basic ] -> basicPath |> List.skip 1 |> basicExamples
        | statisicalPath when tryTakePath statisicalPath [ Urls.Statistical ] -> statisicalPath |> List.skip 1 |> statisticalExamples
        | _ -> [ ]
        |> fun path ->
            if path |> List.isEmpty then Html.div [ for segment in state.CurrentPath -> Html.p segment ]
            else [ Urls.Plotly; Urls.Examples ] @ path |> (lazyView loadMarkdown)
    | _ -> lazyView loadMarkdown [ "Plotly"; "README.md" ]

let main state dispatch =
    Html.div [
        prop.className [ Bulma.Tile; Bulma.IsAncestor ]
        prop.children [
            Html.div [
                prop.className [ Bulma.Tile; Bulma.Is2 ]
                prop.children [ sidebar state dispatch ]
            ]

            Html.div [
                prop.className Bulma.Tile
                prop.style [ style.paddingTop 30 ]
                prop.children [ content state dispatch ]
            ]
        ]
    ]

let render (state: State) dispatch =
    let application =
        Html.div [
            prop.style [ 
                style.padding 30
            ]
            prop.children [ main state dispatch ]
        ]

    Router.router [
        Router.onUrlChanged (UrlChanged >> dispatch)
        Router.application application
    ]

Program.mkProgram init update render
|> Program.withReactSynchronous "root"
|> Program.withConsoleTrace
|> Program.run
