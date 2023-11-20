module Index

open Fable.Core
open Fable.Import
open Elmish
open Feliz
open Feliz.QRCode
open Fable.SimpleXml
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

open Feliz.Bulma

[<ReactComponent>]
let QRCodeSVG () =

    QRCode.qrCodeSVG [
        qrCodeSVG.value "https://www.google.com"
        qrCodeSVG.size 600
        qrCodeSVG.id "qrcode"
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

    let downloadStringAsFile (data: string) (filename: string) =
        let a = Browser.Dom.document.createElement("a") :?> Browser.Types.HTMLAnchorElement
        a.href <- data
        a.setAttribute("download", filename)
        a.click()

    let downloadSVG () =
        let svgSVGElement = Browser.Dom.document.getElementById "qrcode" :?> Browser.Types.SVGSVGElement
        let fileURI =
            "data:image/svg+xml;charset=utf-8," + ""
            // Browser.Dom.window.encodeURIComponent ("""<?xml version="1.0" encoding="utf-8"?>""" +
            //     Interop.SerializeSVGElement (svgSVGElement))
        downloadStringAsFile fileURI "qrcode.svg"

    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            QRCodeSVG()
            Bulma.button.button [
                button.isFullWidth
                prop.style [ style.color.white; style.backgroundColor.red ]
                prop.onClick (fun _ -> downloadSVG ())
                prop.text "Download SVG"
            ]
        ]
    ]
