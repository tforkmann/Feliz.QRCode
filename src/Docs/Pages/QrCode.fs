module Docs.Pages.QrCodeView

open Feliz
open Feliz.Bulma
open Feliz.QRCode
open Docs.SharedView

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

let QRCode =
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            QRCodeCanvas()
        ]
    ]


let code =
    """
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
    """

let title = Html.text "QR Code"

[<ReactComponent>]
let QRCodeView () =
    Html.div [
        Bulma.content [
            codedView title code QRCode
        ]
        fixDocsView "QRCode" false
    ]