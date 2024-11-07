namespace Feliz.QRCode

open Fable.Core
open Fable.Core.JsInterop
open Feliz


[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkQRCodeCanvasProp (key: string) (value: obj) : IQRCodeCanvasProp = unbox (key, value)
    let inline mkQRCodeSVGProp (key: string) (value: obj) : IQRCodeSVGProp = unbox (key, value)
    let inline mkImageSettingsProp (key: string) (value: obj) : IImageSettingsProp = unbox (key, value)

    let qrCodeCanvas: obj = import "QRCodeCanvas" "qrcode.react"
    let qrCodeSVG: obj = import "QRCodeSVG" "qrcode.react"
    let renderToStaticMarkup (reactElement:ReactElement): Browser.Types.HTMLCanvasElement = import "renderToStaticMarkup" "react-dom/server"
