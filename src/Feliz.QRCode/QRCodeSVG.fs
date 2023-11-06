namespace Feliz.QRCode

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type qrCodeSVG =
    static member inline value (value:string) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "value" value
    static member inline size (size:int) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "size" size
    static member inline bgColor (bgColor:string) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "bgColor" bgColor
    static member inline fgColor (fgColor:string) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "fgColor" fgColor
    static member inline level (level:string) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "level" level
    static member inline includeMargin (includeMargin:bool) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "includeMargin" includeMargin
    static member inline marginSize (marginSize:int) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "marginSize" marginSize
    static member inline imageSettings props : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "imageSettings" (createObj !!props)
    static member inline ref (ref:IRefValue<Browser.Types.SVGSVGElement>) : IQRCodeSVGProp =
        Interop.mkQRCodeSVGProp "ref" ref

[<Erase>]
type imageSettingsSVG =
    static member inline src(src: string ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "src" src
    static member inline height(height: int ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "height" height
    static member inline width(width: int ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "width" width
    static member inline excavate(excavate: bool ) : IImageSettingsProp =
        Interop.mkImageSettingsProp "excavate" excavate
