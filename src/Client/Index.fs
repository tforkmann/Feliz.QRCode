module Index

open Fable.Core
open Fable.Import
open Elmish
open Feliz
open Feliz.QRCode
open Browser.Types
open Browser.Dom
open Feliz.Bulma

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none
let downloadStringAsFile (data: string) (filename: string) =
    let a = Browser.Dom.document.createElement("a") :?> Browser.Types.HTMLAnchorElement
    a.href <- data
    a.setAttribute("download", filename)
    a.click()

[<ReactComponent>]
let QRCodeCanvas () =
    let qrCodeRefSmall: IRefValue<HTMLCanvasElement option> = React.useRef (None)
    let qrCodeRefBig: IRefValue<HTMLCanvasElement option> = React.useRef (None)

    let receiveChartRefSmall () =
        match qrCodeRefSmall.current with
        | None -> failwithf "should be some"
        | Some e -> e
    let receiveChartRefBig () =
        match qrCodeRefBig.current with
        | None -> failwithf "should be some"
        | Some e -> e

    let qrCodeCanvasSmall () =
        QRCode.qrCodeCanvas [
            qrCodeCanvas.ref qrCodeRefSmall
            qrCodeCanvas.value "https://www.google.com"
            qrCodeCanvas.size 300
            qrCodeCanvas.bgColor "#ffffff"
            qrCodeCanvas.fgColor "#000000"
            qrCodeCanvas.level "L"
            qrCodeCanvas.includeMargin false
        ]
    let qrCodeCanvasBig () =
        QRCode.qrCodeCanvas [
            qrCodeCanvas.ref qrCodeRefBig
            qrCodeCanvas.value "https://www.google.com"
            qrCodeCanvas.size 1200
            qrCodeCanvas.bgColor "#ffffff"
            qrCodeCanvas.fgColor "#000000"
            qrCodeCanvas.level "L"
            qrCodeCanvas.includeMargin false
        ]
    Html.div [
        qrCodeCanvasSmall ()
        Html.div [
            prop.style [ style.display.none ]
            prop.children [ qrCodeCanvasBig () ]
        ]
        Bulma.button.button [
            button.isFullWidth
            prop.style [ style.color.white; style.backgroundColor.red ]
            prop.onClick (fun _ ->
                let qrCodeCanvas = receiveChartRefSmall()
                let dataURL = qrCodeCanvas.toDataURL("image/png")
                downloadStringAsFile dataURL "qrcode.png"
            )
            prop.text "Download Small PNG"
        ]
        Bulma.button.button [
            button.isFullWidth
            prop.style [ style.color.white; style.backgroundColor.red ]
            prop.onClick (fun _ ->
                let qrCodeCanvas = receiveChartRefBig()
                let dataURL = qrCodeCanvas.toDataURL("image/png")
                downloadStringAsFile dataURL "qrcode.png"
            )
            prop.text "Download Big PNG"
        ]
    ]

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
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            QRCodeCanvas()
        ]
    ]
