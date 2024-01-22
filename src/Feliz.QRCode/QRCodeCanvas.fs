namespace Feliz.QRCode

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type qrCodeCanvas =
    static member inline value (value:string) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "value" value
    static member inline size (size:int) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "size" size
    static member inline bgColor (bgColor:string) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "bgColor" bgColor
    static member inline fgColor (fgColor:string) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "fgColor" fgColor
    static member inline level (level:Level) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "level" level
    static member inline includeMargin (includeMargin:bool) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "includeMargin" includeMargin
    static member inline marginSize (marginSize:int) : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "marginSize" marginSize
    static member inline imageSettings props : IQRCodeCanvasProp =
        Interop.mkQRCodeCanvasProp "imageSettings" (createObj !!props)

[<Erase>]
type imageSettingsCanvas =
    static member inline src(src: string ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "src" src
    static member inline height(height: int ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "height" height
    static member inline width(width: int ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "width" width
    static member inline heightFloat(height: float ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "height" height
    static member inline widthFloat(width: float ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "width" width
    static member inline excavate(excavate: bool ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "excavate" excavate
