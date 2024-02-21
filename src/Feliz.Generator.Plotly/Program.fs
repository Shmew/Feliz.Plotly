namespace Fable.Plotly.Generator

module Program =
    open Fake.IO
    open Fake.IO.FileSystemOperators

    let retry maxRuns f =
        let rec retry run count f =
            if run < count then
                try f()
                with _ ->
                    Async.Sleep 1000
                    |> Async.RunSynchronously

                    retry (run + 1) count f
            else f()

        retry 0 maxRuns f

    [<EntryPoint>]
    let main _ =
        let api = ApiParser.parseApi()
        let plotlyFile  = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Plotly.fs"
        let interopFile = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Interop.fs"
        let typesFile   = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Types.fs"
        let propsDir    = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Props"
        let localesDir  = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Locales"
        let localesFile = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Locales.fs"

        fun () -> Shell.cleanDir propsDir
        |> retry 10

        fun () -> Shell.cleanDir localesDir
        |> retry 10

        let locales = Locales.read()

        Locales.generate locales

        locales
        |> List.map fst
        |> Locales.buildType
        |> Render.localesDocument api.GeneratorComponentApi
        |> File.writeString false localesFile

        Render.componentDocument api.GeneratorComponentApi |> File.writeString false plotlyFile

        Render.interopDocument api.GeneratorComponentApi |> File.writeString false interopFile

        Render.typesDocument api.GeneratorComponentApi |> File.writeString false typesFile

        let props =
            api.GeneratorComponentApi
            |> Render.propsDocument true

        let customProps =
            api.GeneratorComponentApi
            |> Render.customPropsDocument true

        props @ customProps
        |> List.sortBy fst
        |> List.iter (fun (name, doc) ->
            let path = propsDir @@ (sprintf "%s.fs" (name |> String.upperFirst))
            File.writeString false path doc)

        0
