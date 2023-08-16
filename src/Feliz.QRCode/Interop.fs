namespace Feliz.QRCode

open Fable.Core
open Fable.Core.JsInterop
open Browser.Types

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkQRCodeCanvasProp (key: string) (value: obj) : IQRCodeCanvasProp = unbox (key, value)
    let inline mkImageSettingsPropProp (key: string) (value: obj) : IImageSettingsProp = unbox (key, value)

    let qrcodecanvas: obj = import "QRCodeCanvas" "qrcode.react"