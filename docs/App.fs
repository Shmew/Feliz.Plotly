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

let init() = { CurrentPath = [ ] }

type Msg = UrlChanged of string list

let update msg state =
    match msg with
    | UrlChanged segments -> { state with CurrentPath = segments }

[
    style.display.flex
    style.display.none
    style.fontSize 20
    style.borderRadius 15
    style.textAlign.center
    style.alignContent.flexStart
    style.textDecorationColor.blue
    style.visibility.hidden
    style.textDecoration.lineThrough
    style.position.sticky
    style.borderBottomWidth 20
    style.borderBottomWidth (length.em 10)
    style.borderBottomColor colors.red
    style.borderBottomStyle borderStyle.dashed
    style.borderStyle.dotted
    style.margin(length.em 1, length.em 0)
    style.marginBottom 10
    style.marginBottom (length.em 1)
    style.boxShadow(10, 10, colors.black)
    style.boxShadow(10, 10, 10, colors.black)
    style.boxShadow(0, 0, 10, colors.black)
    style.boxShadow(0, 0, 10, 10, colors.darkGray)
    style.boxShadow.none
    style.height length.auto
    style.borderRadius 20
    style.borderRadius (length.rem 10)
    style.margin 10
    style.backgroundRepeat.repeatX
    style.backgroundPosition.fixedNoScroll
    style.margin (length.px 10)
    style.margin(10, 10, 10, 20)
    style.margin(10, 10, 10)
    style.margin(10, 10)
    style.width 10
    style.height 100
    style.height (length.vh 50)
    style.height (length.percent 100)
    style.backgroundColor.fuchsia
    style.backgroundColor "#FFFFFF"
    style.border(3, borderStyle.dashed, colors.crimson)
    style.borderColor.blue
    style.transform.scale3D(20, 20, 20)
    style.transform.translateX(100)
    style.transform.translateY(100)
    style.transform.translateZ(100)
    style.textTransform.capitalize
    style.textTransform.lowercase
    style.fontStretch.extraCondensed
    style.fontVariant.smallCaps
    style.fontStyle.italic
    style.fontSize 20
    style.fontSize (length.em 2)
    style.color.crimson
    style.color "#000000"
]
|> List.iter (fun x -> Browser.Dom.console.log(createObj [!!x]))

type ICodeProperties =
    abstract language : string
    abstract value : string

let apps = 
    [ "feliz-charts-scatterchart", Samples.ScatterChart.chart() ]

let githubPath (rawPath: string) =
    let parts = rawPath.Split('/')
    if parts.Length > 5
    then sprintf "http://www.github.com/%s/%s" parts.[3] parts.[4]
    else rawPath

let loadMarkdown (path: string list) =
    let markdown = React.functionComponent <| fun _ ->
        let isLoading, setLoading = React.useState false
        let error, setError = React.useState<Option<string>> None
        let content, setContent = React.useState ""
        let path =
            match path with
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
        )

        if isLoading then
            Html.div [
                prop.style [
                    style.textAlign.center;
                    style.marginLeft length.auto
                    style.marginRight length.auto
                    style.marginTop 50
                ]

                prop.children [
                    Html.li [ prop.className [ FA.Fa; FA.FaRefresh; FA.FaSpin; FA.Fa3X ] ]
                ]
            ]
        else
            match error with
            | Some error -> Html.h1 [ prop.style [ style.color.crimson ]; prop.text error ]
            | None ->
                Html.div [
                    prop.className "content"
                    prop.style [ style.width (length.percent 100); style.padding 20 ]
                    prop.children [
                        if path.StartsWith "https://raw.githubusercontent.com" then
                            yield Html.h1 [
                                Html.i [ prop.className [ FA.Fa; FA.FaGithub ] ]
                                Html.anchor [
                                    prop.style [ style.marginLeft 10; style.color.lightGreen ]
                                    prop.href (githubPath path)
                                    prop.text "View on Github"
                                ]
                            ]
                        yield Markdown.markdown [
                            prop.custom("source", content)
                            prop.custom("renderers", createObj [
                                "code" ==> fun (props: ICodeProperties) ->
                                    if props.language <> null && props.language.Contains ":" then
                                        let languageParts = props.language.Split(':')
                                        let sampleName = languageParts.[1]
                                        let sampleApp =
                                            apps
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
                                                prop.text(props.value)
                                            ]
                                        ]
                                    else
                                        Highlight.highlight [
                                            prop.className "fsharp"
                                            prop.text(props.value)
                                        ]
                            ])
                        ]
                    ]
                ]
    markdown()

// A collapsable nested menu for the sidebar
// keeps internal state on whether the items should be visible or not based on the collapsed state
let nestedMenuList (name: string) (items: Fable.React.ReactElement list) =
    let statefulComponent =
        React.functionComponent("NestedMenuList", fun () ->
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

                        Html.span name
                    ]
                ]

                Html.ul [
                    prop.className Bulma.MenuList
                    prop.style [ collapsed, [ style.display.none ] ]
                    prop.children items
                ]
            ]
        )

    statefulComponent()

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
                menuItem "Syntax" [ Urls.Plotly; Urls.Syntax ]
                menuItem "Conditionals" [ Urls.Plotly; Urls.ConditionalStyling ]
                menuItem "Contributing" [ Urls.Plotly; Urls.Contributing ]
                nestedMenuList "Examples" [
                    nestedMenuList "Standard" [
                        menuItem "Scatter Chart" [ Urls.Plotly; Urls.Charts; Urls.ScatterChart ]
                        menuItem "Line Chart" [ Urls.Plotly; Urls.Charts; Urls.LineChart ]
                    ]
                ]
            ]
        ]
    ]

let readme = sprintf "https://raw.githubusercontent.com/%s/%s/master/README.md"
let contributing = sprintf "https://raw.githubusercontent.com/Zaid-Ajaj/Feliz/public/Contributing.md"

let content state dispatch =
    match state.CurrentPath with
    | [ ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Overview; ] -> loadMarkdown [ "Plotly"; "README.md" ]
    | [ Urls.Plotly; Urls.Installation ] -> loadMarkdown [ "Plotly"; "Installation.md" ]
    | [ Urls.Plotly; Urls.Contributing ] -> loadMarkdown [ contributing ]
    | [ Urls.Plotly; Urls.ConditionalStyling ] -> loadMarkdown [ "Plotly"; "ConditionalStyling.md" ]
    | segments -> Html.div [ for segment in segments -> Html.p segment ]

let main state dispatch =
    Html.div [
        prop.className [ Bulma.Tile; Bulma.IsAncestor ]
        prop.children [
            Html.div [
                prop.className [ Bulma.Tile; Bulma.Is3 ]
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
            prop.style [ style.padding 50 ]
            prop.children [ main state dispatch ]
        ]

    Router.router [
        Router.onUrlChanged (UrlChanged >> dispatch)
        Router.application application
    ]

Program.mkSimple init update render
|> Program.withReactSynchronous "root"
|> Program.withConsoleTrace
|> Program.run
