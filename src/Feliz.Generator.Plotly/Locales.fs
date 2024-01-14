namespace Fable.Plotly.Generator

module Locales =
    open Domain
    open Fake.IO
    open Fake.IO.FileSystemOperators
    open Fake.IO.Globbing.Operators
    open System.IO
    open System.Text.RegularExpressions

    let read () =
        let localeRegex = Regex("var locale=(.*?);\"undefined.*")

        !! (__SOURCE_DIRECTORY__ @@ "../../node_modules/plotly.js/dist/plotly-locale-*.js")
        |> List.ofSeq
        |> List.map (fun s ->
            let raw = localeRegex.Match(File.readAsString s).Groups.Item(1).Value

            FileInfo(s).Name.Split('.').[0],
            raw)

    let generate (locales: (string * string) list) =
        let getPath name = __SOURCE_DIRECTORY__ @@ "../Feliz.Plotly/Locales" @@ (sprintf "%s.js") name

        locales
        |> List.iter (fun (name, localeStr) ->
            sprintf "export function locale() { return %s }" localeStr
            |> File.writeString false (getPath name)
        )

    let buildType (locales: string list) =
        let createLocaleFunction (name: string) =
            let formattedName =
                name.Replace("plotly-locale-", "").Split("-")
                |> List.ofArray
                |> function
                | [] -> failwith "Invalid locale file"
                | [ name ] -> name
                | [ baseName; extName ] -> baseName + extName.ToUpperInvariant()
                | baseName::extNames ->
                    extNames
                    |> List.map String.upperFirst
                    |> String.concat ""
                    |> sprintf "%s%s" baseName

            sprintf "static member %s : ILocalesProperty = (import \"locale\" \"./Locales/%s.js\")()"
                formattedName name

        let localeFunctions =
            locales
            |> List.map (fun name -> "", createLocaleFunction name)

        CustomPropertyType.create "Locales"
        |> CustomPropertyType.addFunctions localeFunctions