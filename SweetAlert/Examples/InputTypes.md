# Feliz.SweetAlert - Input Types

```fsharp:swal-inputtypes
[<RequireQualifiedAccess>]
module Samples.InputTypes

open Feliz
open Feliz.SweetAlert
open Zanaptak.TypedCssClasses

type Bulma = CssClasses<"https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.5/css/bulma.min.css", Naming.PascalCase>
type FA = CssClasses<"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", Naming.PascalCase>

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
                    Swal.fire ([
                        swal.title "Enter some text!"
                        swal.input.text
                        swal.showCancelButton true
                        swal.inputValidator (function
                            | Some _ -> None
                            | _ -> Some "That's not right!"
                        )
                    ], SweetAlertResult.ofValue (sprintf "You entered %s" >> Swal.Simple.basic))
                prop.text "Text"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Input email address"
                        swal.input.email
                        swal.inputPlaceholder "Enter your email address"
                    ], SweetAlertResult.ofValue (sprintf "Entered email: %s" >> Swal.Simple.basic))
                prop.text "Email"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.input.url
                        swal.inputPlaceholder "Enter the URL"
                    ], SweetAlertResult.ofValue (sprintf "Entered URL: %s" >> Swal.Simple.basic))
                prop.text "Url"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Enter your password"
                        swal.input.password
                        swal.inputAttributes [
                            prop.maxLength 10
                            prop.autoCapitalize.off
                            Interop.mkAttr "autoCorrect" "off"
                        ]
                        swal.inputPlaceholder "Enter your password"
                    ], SweetAlertResult.ofValue (sprintf "Entered password: %s" >> Swal.Simple.basic))
                prop.text "Password"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.input.textArea
                        swal.inputPlaceholder "Type your message here..."
                        swal.showCancelButton true
                    ], SweetAlertResult.ofValue Swal.Simple.basic)
                prop.text "Textarea"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Select field validation"
                        swal.input.select
                        swal.inputPlaceholder "Select a fruit"
                        swal.inputOptions [
                            "apples", "Apples"
                            "bananas", "Bananas"
                            "grapes", "Grapes"
                            "oranges", "Oranges"
                        ]
                        swal.showCancelButton true
                        swal.inputValidator (fun str ->
                            promise {
                                return
                                    match str with
                                    | Some "oranges" -> None
                                    | _ -> Some "You need to select oranges :)"
                            }
                        )
                    ], SweetAlertResult.ofValue (sprintf "You selected: %s" >> Swal.Simple.basic))
                prop.text "Select"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Select color"
                        swal.input.radio
                        swal.inputOptions (
                            promise {
                                do! Promise.sleep 2000
                                return
                                    [ "#FF0000", "Red"
                                      "#00FF00", "Green"
                                      "#0000FF", "Blue" ]
                            }
                        )
                        swal.inputValidator (function
                            | None -> Some "You need to choose something!" 
                            | _ -> None)
                    ], SweetAlertResult.ofValue (sprintf "You selected: %s" >> Swal.Simple.basic))
                prop.text "Radio"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Terms and conditions"
                        swal.input.checkbox
                        swal.inputValue 1
                        swal.inputPlaceholder "I agree with the terms and conditions"
                        swal.confirmButtonText (
                            React.fragment [
                                Html.p "Continue"
                                Html.i [ prop.classes [ FA.Fa; FA.FaArrowRight ] ]
                            ]
                        )
                        swal.inputValidator (function
                            | None -> Some "You need to agree with T&C"
                            | _ -> None
                        )
                    ], SweetAlertResult.ofValue (fun _ -> Swal.Simple.basic "You agreed with T&C! :)"))
                prop.text "Checkbox"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire ([
                        swal.title "Select image"
                        swal.input.file
                        swal.inputAttributes [
                            prop.accept "image/*"
                        ]
                    ], SweetAlertResult.ofValue (fun img ->
                        async {
                            let fr = Browser.Dom.FileReader.Create()
                            fr.onload <- (fun e -> 
                                Swal.fire [
                                    swal.title "Your uplaoded picture"
                                    swal.imageUrl (unbox<string> fr.result)
                                    swal.imageAlt "The uploaded picture"
                                ]
                            )
                            fr.readAsDataURL(img)  
                        } |> Async.StartImmediate))
                prop.text "File"
            ]
            Html.button [
                prop.classes [ Bulma.Button; Bulma.HasBackgroundPrimary; Bulma.HasTextWhite; Bulma.IsLarge ]
                prop.onClick <| fun _ ->
                    Swal.fire [
                        swal.title "How old are you?"
                        swal.icon.question
                        swal.input.range
                        swal.inputAttributes [
                            prop.min 8
                            prop.max 120
                            prop.step 1
                        ]
                        swal.inputValue 25
                    ]
                prop.text "Range"
            ]
        ]
    ])
```