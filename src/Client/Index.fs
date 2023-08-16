module Index

open Elmish
open Feliz
open Feliz.QRCode

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none

[<ReactComponent>]
let QRCodeCanvas () =
    QRCode.qrcodecanvas [
        qrCodeCanvas.value "https://www.google.com"
        qrCodeCanvas.size 600
        qrCodeCanvas.bgColor "#ffffff"
        qrCodeCanvas.fgColor "#000000"
        qrCodeCanvas.level "L"
        qrCodeCanvas.includeMargin false
        qrCodeCanvas.imageSettings [
            imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettings.height 24
            imageSettings.width 24
            imageSettings.excavate true
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            QRCodeCanvas()
        ]
    ]
