namespace Feliz.QRCode

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkQRCodeCanvasProp (key: string) (value: obj) : IQRCodeCanvasProp = unbox (key, value)
    let inline mkQRCodeSVGProp (key: string) (value: obj) : IQRCodeSVGProp = unbox (key, value)
    let inline mkImageSettingsProp (key: string) (value: obj) : IImageSettingsProp = unbox (key, value)

    let qrCodeCanvas: obj = import "QRCodeCanvas" "qrcode.react"
    let qrCodeSVG: obj = import "QRCodeSVG" "qrcode.react"
