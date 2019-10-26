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
      CurrentTab: string option }

let init () = 
    { CurrentPath = [ ]
      CurrentTab = None }, Cmd.none

type Msg =
    | TabToggled of string option
    | UrlChanged of string list

let update msg state =
    match msg with
    | UrlChanged segments -> 
        { state with CurrentPath = segments }, 
        match state.CurrentTab with
        | None when segments.Length > 2 -> 
            segments 
            |> List.tryItem(segments.Length - 2)
            |> TabToggled
            |> Cmd.ofMsg
        | _ -> Cmd.none
    | TabToggled tabOpt ->
        match tabOpt with
        | Some(tab) -> { state with CurrentTab = Some tab }, Cmd.none
        | None -> { state with CurrentTab = None }, Cmd.none

let samples = 
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
        [ "plotly-chart-dot-basic", Samples.Dot.Basic.chart() ]

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

    [ scatter
      bubble
      dot
      line
      bar
      filledArea ]
    |> List.concat

let githubPath (rawPath: string) =
    let parts = rawPath.Split('/')
    if parts.Length > 5
    then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
    else rawPath

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

let loadMarkdown' = React.functionComponent <| fun (input: {| path: string list |}) ->
    let isLoading, setLoading = React.useState false
    let error, setError = React.useState<Option<string>> None
    let content, setContent = React.useState ""
    let path =
        match input.path with
        | [ one ] when one.StartsWith "http" -> one
        | segments -> String.concat "/" segments

    React.useEffect(fun _ ->
        setLoading(true)
        async {
            let! (statusCode, responseText) = Http.get path
            setLoading(false)
            if statusCode = 200 then
              setContent(responseText)
              setError(None)
            else
              setError(Some (sprintf "Status %d: could not load %s" statusCode path))
        }
        |> Async.StartImmediate

        React.createDisposable(ignore)
    ,path)

    match isLoading, error with
    | true, _ -> centeredSpinner
    | false, None -> renderMarkdown path content
    | _, Some error ->
        Html.h1 [
            prop.style [ style.color.crimson ]
            prop.text error
        ]

let loadMarkdown (path: string list) = loadMarkdown' {| path = path |}

// A collapsable nested menu for the sidebar
// keeps internal state on whether the items should be visible or not based on the collapsed state
let nestedMenuList' = FunctionComponent.Of((fun (state: State, name: string, elems: ReactElement list, dispatch) ->
    let collapsed = 
        match state.CurrentTab with
        | Some tab -> tab = name
        | None -> false
    Html.li [
        Html.anchor [
            prop.className Bulma.IsUnselectable
            prop.onClick <| fun _ -> 
                match collapsed with
                | true -> dispatch <| TabToggled None
                | false -> dispatch <| TabToggled (Some name)
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
            prop.children elems
        ]
    ]), memoizeWith = memoEqualsButFunctions)

let sidebar (state: State) dispatch =
    let nestedMenuList (name: string) (items: Fable.React.ReactElement list) =
        nestedMenuList'(state, name, items, dispatch)

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

    let allItems =
        Html.div [
            prop.className "scrollbar"
            prop.children [
                menuList [
                    menuItem "Overview" [ ]
                    menuItem "Installation" [ Urls.Plotly; Urls.Installation ]
                    menuItem "Contributing" [ Urls.Plotly; Urls.Contributing ]
                    menuLabel "Examples"
                    nestedMenuList "Scatter" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.Basic ]
                        menuItem "Data Labels Hover" [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.DataLabelsHover ]
                        menuItem "Data Labels On Plot" [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.DataLabelsOnPlot ]
                        menuItem "Color Dimension" [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.ColorDimension ]
                    ]
                    nestedMenuList "Bubble" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.Basic ]
                        menuItem "HoverText" [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.HoverText ]
                        menuItem "Marker Size and Color" [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.MarkerSizeAndColor ]
                        menuItem "Size Scaling" [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.SizeScaling ]
                        menuItem "Marker Size Color and Symbol Array" [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.MarkerSizeColorAndSymbolArray ]
                    ]
                    nestedMenuList "Dot" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.Dot; Urls.Basic ]
                    ]
                    nestedMenuList "Line" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.Basic ]
                        menuItem "Named Line and Scatter" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.NamedLineAndScatter ]
                        menuItem "Line and Scatter Styling" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineAndScatterStyling ]
                        menuItem "Styling Line Plot" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.StylingLinePlot ]
                        menuItem "Colored and Styled Scatter" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.ColoredAndStyledScatter ]
                        menuItem "Line Shape Options Interpolation" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineShapeOptionsInterpolation ]
                        menuItem "Graph and Axes Titles" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.GraphAndAxesTitles ]
                        menuItem "Line Dash" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineDash ]
                        menuItem "Connect Gaps Between Data" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.ConnectGapsBetweenData ]
                        menuItem "Labelling Lines With Annotations" [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LabellingLinesWithAnnotations ]
                    ]
                    nestedMenuList "Bar" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Basic ]
                        menuItem "Grouped" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Grouped ]
                        menuItem "Stacked" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Stacked ]
                        menuItem "Hover Text" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.HoverText ]
                        menuItem "Direct Labels" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.DirectLabels ]
                        menuItem "Grouped Direct Labels" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.GroupedDirectLabels ]
                        menuItem "Rotated Labels" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.RotatedLabels ]
                        menuItem "Colors" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Colors ]
                        menuItem "Widths" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Widths ]
                        menuItem "Base" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Base ]
                        menuItem "Colored and Styled" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.ColoredAndStyled ]
                        menuItem "Waterfall" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Waterfall ]
                        menuItem "Relative Barmode" [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.RelativeBarmode ]
                    ]
                    nestedMenuList "Filled Area" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.Basic ]
                        menuItem "Overlaid Without Boundary" [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.OverlaidWithoutBoundary ]
                        menuItem "Stacked Area" [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.StackedArea ]
                        menuItem "Normalized Stacked Area" [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.NormalizedStackedArea ]
                        menuItem "Select Hover" [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.SelectHover ]
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

let content state dispatch =
    match state.CurrentPath with
    | [ ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Overview; ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Installation ] -> loadMarkdown [ "Plotly"; "Installation.md" ]
    | [ Urls.Plotly; Urls.Contributing ] -> loadMarkdown [ contributing ]
    | [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.DataLabelsHover ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "DataLabelsHover.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.DataLabelsOnPlot ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "DataLabelsOnPlot.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Scatter; Urls.ColorDimension ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "ColorDimension.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Bubble" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.HoverText ] -> loadMarkdown [ "Plotly"; "Examples"; "Bubble" ; "HoverText.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.MarkerSizeAndColor ] -> loadMarkdown [ "Plotly"; "Examples"; "Bubble" ; "MarkerSizeAndColor.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.SizeScaling ] -> loadMarkdown [ "Plotly"; "Examples"; "Bubble" ; "SizeScaling.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bubble; Urls.MarkerSizeColorAndSymbolArray ] -> loadMarkdown [ "Plotly"; "Examples"; "Bubble" ; "MarkerSizeColorAndSymbolArray.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Dot; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Dot" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.NamedLineAndScatter ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "NamedLineAndScatter.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineAndScatterStyling ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "LineAndScatterStyling.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.StylingLinePlot ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "StylingLinePlot.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.ColoredAndStyledScatter ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "ColoredAndStyledScatter.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineShapeOptionsInterpolation ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "LineShapeOptionsInterpolation.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.GraphAndAxesTitles ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "GraphAndAxesTitles.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LineDash ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "LineDash.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.ConnectGapsBetweenData ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "ConnectGapsBetweenData.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Line; Urls.LabellingLinesWithAnnotations ] -> loadMarkdown [ "Plotly"; "Examples"; "Line" ; "LabellingLinesWithAnnotations.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Grouped ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Grouped.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Stacked ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Stacked.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.HoverText ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "HoverText.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.DirectLabels ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "DirectLabels.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.GroupedDirectLabels ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "GroupedDirectLabels.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.RotatedLabels ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "RotatedLabels.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Colors ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Colors.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Widths ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Widths.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Base ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Base.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.ColoredAndStyled ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "ColoredAndStyled.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.Waterfall ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "Waterfall.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.Bar; Urls.RelativeBarmode ] -> loadMarkdown [ "Plotly"; "Examples"; "Bar" ; "RelativeBarmode.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "FilledArea" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.OverlaidWithoutBoundary ] -> loadMarkdown [ "Plotly"; "Examples"; "FilledArea" ; "OverlaidWithoutBoundary.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.StackedArea ] -> loadMarkdown [ "Plotly"; "Examples"; "FilledArea" ; "StackedArea.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.NormalizedStackedArea ] -> loadMarkdown [ "Plotly"; "Examples"; "FilledArea" ; "NormalizedStackedArea.md" ]
    | [ Urls.Plotly; Urls.Examples; Urls.FilledArea; Urls.SelectHover ] -> loadMarkdown [ "Plotly"; "Examples"; "FilledArea" ; "SelectHover.md" ]
    | segments -> Html.div [ for segment in segments -> Html.p segment ]

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
