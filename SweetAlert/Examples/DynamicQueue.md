# Feliz.SweetAlert - Dynamic Queueing

```fsharp:swal-dynamicqueue
[<RequireQualifiedAccess>]
module Samples.DynamicQueue

open Fable.Core
open Feliz
open Feliz.SweetAlert
open Fable.SimpleJson
open Fable.SimpleHttp
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>

type RespJson =
    { ip: string }

let getIp _ =
    promise {
        let! (statusCode, responseText) = 
            Http.get "https://api.ipify.org?format=json"
            |> Async.StartAsPromise

        return
            if statusCode = 200 then
                responseText
                |> Json.parseAs<RespJson>
                |> fun res -> 
                    [ swal.text res.ip
                      swal.icon.info]
            else [ swal.text "Uh oh! (probably blocked by AdBlocker)"; swal.icon.error ]
            |> Swal.insertQueueStep
    }

let render = React.functionComponent (fun () ->
    Html.div [
        prop.className Bulma.Control
        prop.style [
            style.paddingLeft (length.em 8)
            style.paddingBottom (length.em 1)
        ]
        prop.children [
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ -> 
                    Swal.queue [
                        [ swal.title "Your public IP"
                          swal.confirmButtonText "Show my public IP"
                          swal.text "Your IP will be fetched via Fable.SimpleHttp!"
                          swal.showLoaderOnConfirm true
                          swal.preConfirm<obj,JS.Promise<int>> getIp ]
                    ]
                prop.text "Fire!"
            ]
        ]
    ])
```