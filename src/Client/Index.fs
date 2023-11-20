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
    QRCode.qrCodeCanvas [
        qrCodeCanvas.value "https://www.google.com"
        qrCodeCanvas.size 600
        qrCodeCanvas.bgColor "#ffffff"
        qrCodeCanvas.fgColor "#000000"
        qrCodeCanvas.level "L"
        qrCodeCanvas.includeMargin false
        qrCodeCanvas.imageSettings [
            imageSettingsCanvas.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettingsCanvas.height 24
            imageSettingsCanvas.width 24
            imageSettingsCanvas.excavate true
        ]
    ]

[<ReactComponent>]
let QRCodeSVG () =

    QRCode.qrCodeSVG [
        qrCodeSVG.value "https://www.google.com"
        qrCodeSVG.size 600
        qrCodeSVG.bgColor "#ffffff"
        qrCodeSVG.fgColor "#000000"
        qrCodeSVG.level "L"
        qrCodeSVG.includeMargin false
        qrCodeSVG.imageSettings [
            imageSettingsSVG.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettingsSVG.height 24
            imageSettingsSVG.width 24
            imageSettingsSVG.excavate true
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            QRCodeSVG()
        ]
    ]
