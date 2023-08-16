module Docs.Pages.Use

open Feliz
open Elmish
open Docs.SharedView

[<ReactComponent>]
let UseView () =
    React.fragment [
        Html.divClassed "description" [ Html.text "After installation just open proper namespace:" ]
        Html.divClassed "max-w-xl" [ linedMockupCode "open Feliz.QRCode" ]
        Html.divClassed
            "description"
            [ Html.text "Now you can start using library. Everything important starts with "
              Html.code [
                  prop.className "code"
                  prop.text "QRCode.*"
              ]
              Html.text " module." ]
    ]