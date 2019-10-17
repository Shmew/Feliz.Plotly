module App

open Elmish
open Elmish.React
open Feliz
open Feliz.Markdown
open Fable.SimpleHttp
open Feliz.Router
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.Experimental
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

type Highlight =
    static member inline highlight (properties: IReactProperty list) =
        Interop.reactApi.createElement(importDefault "react-highlight", createObj !!properties)

type State = { CurrentPath : string list }

let init () = { CurrentPath = [ ] }, Cmd.none

type Msg = UrlChanged of string list

let update msg state =
    match msg with
    | UrlChanged segments -> { state with CurrentPath = segments }, Cmd.none

let samples = 
    [ "plotly-chart-scatter-basic", Samples.Scatter.Basic.chart()
      "plotly-chart-scatter-datalabelshover", Samples.Scatter.DataLabelsHover.chart() ]

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
        prop.className Bulma.Content
        prop.style [ style.width (length.percent 100); style.padding 20 ]
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
let nestedMenuList' = React.functionComponent <| fun (input: {| name: string; items: Fable.React.ReactElement list |}) ->
    let (collapsed, setCollapsed) = React.useState(false)
    Html.li [
        Html.anchor [
            prop.onClick (fun _ -> setCollapsed(not collapsed))
            prop.children [
                Html.i [
                    prop.style [ style.marginRight 10 ]
                    prop.className [
                        true, FA.Fa;
                        not collapsed, FA.FaAngleUp;
                        collapsed, FA.FaAngleDown;
                    ]
                ]
                Html.span input.name
            ]
        ]

        Html.ul [
            prop.className Bulma.MenuList
            prop.style [ collapsed, [ style.display.none ] ]
            prop.children input.items
        ]
    ]

let nestedMenuList (name: string) (items: Fable.React.ReactElement list) =
    nestedMenuList' {| name = name; items = items |}

let sidebar (state: State) dispatch =
    // top level label
    let menuLabel (content: string) =
        Html.p [
            prop.className Bulma.MenuLabel
            prop.text content
        ]

    // top level menu
    let menuList (items: Fable.React.ReactElement list) =
        Html.ul [
            prop.className Bulma.MenuList
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

    // the actual nav bar
    Html.aside [
        prop.className Bulma.Menu
        prop.children [
            menuLabel "Feliz.Plotly"
            menuList [
                menuItem "Overview" [ ]
                menuItem "Installation" [ Urls.Plotly; Urls.Installation ]
                menuItem "Contributing" [ Urls.Plotly; Urls.Contributing ]
                nestedMenuList "Examples" [
                    nestedMenuList "Scatter" [
                        menuItem "Basic" [ Urls.Plotly; Urls.Charts; Urls.Scatter; Urls.Basic ]
                        menuItem "Data Labels Hover" [ Urls.Plotly; Urls.Charts; Urls.Scatter; Urls.DataLabelsHover ]
                    ]
                ]
            ]
        ]
    ]

let readme = sprintf "https://raw.githubusercontent.com/%s/%s/master/README.md"
let contributing = sprintf "https://raw.githubusercontent.com/Zaid-Ajaj/Feliz/master/public/Feliz/Contributing.md"

let content state dispatch =
    match state.CurrentPath with
    | [ ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Overview; ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Installation ] -> loadMarkdown [ "Plotly"; "Installation.md" ]
    | [ Urls.Plotly; Urls.Contributing ] -> loadMarkdown [ contributing ]
    | [ Urls.Plotly; Urls.Charts; Urls.Scatter; Urls.Basic ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "Basic.md" ]
    | [ Urls.Plotly; Urls.Charts; Urls.Scatter; Urls.DataLabelsHover ] -> loadMarkdown [ "Plotly"; "Examples"; "Scatter" ; "DataLabelsHover.md" ]
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
                prop.children [ content state dispatch ]
            ]
        ]
    ]

let render (state: State) dispatch =
    let application =
        Html.div [
            prop.style [ style.padding 30 ]
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
