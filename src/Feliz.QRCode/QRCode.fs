namespace Feliz.QRCode

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IQRCodeProp.
[<Erase>]
type QRCode =
    /// Creates a new QRCode component.

    static member inline qrcodecanvas(props: IQRCodeCanvasProp seq) =
        Interop.reactApi.createElement (Interop.qrcodecanvas, createObj !!props)

    static member inline qrcodesvg(props: IQRCodeSVGProp seq) =
        Interop.reactApi.createElement (Interop.qrcodesvg, createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IQRCodeProp> (prop.children children)
