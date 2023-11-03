namespace Feliz.QRCode

open Fable.Core
open Fable.Core.JsInterop
open Browser.Types

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkQRCodeCanvasProp (key: string) (value: obj) : IQRCodeCanvasProp = unbox (key, value)
    let inline mkQRCodeSVGProp (key: string) (value: obj) : IQRCodeSVGProp = unbox (key, value)
    let inline mkImageSettingsProp (key: string) (value: obj) : IImageSettingsProp = unbox (key, value)

    let qrcodecanvas: obj = import "QRCodeCanvas" "qrcode.react"
    let qrcodesvg: obj = import "QRCodeSVG" "qrcode.react"
