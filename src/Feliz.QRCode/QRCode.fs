namespace Feliz.QRCode

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IQRCodeProp.
[<Erase>]
type QRCode =
    /// Creates a new QRCode component.

    static member inline qrCodeCanvas(props: IQRCodeCanvasProp seq) =
        Interop.reactApi.createElement (Interop.qrCodeCanvas, createObj !!props)

    static member inline qrCodeSVG(props: IQRCodeSVGProp seq) =
        Interop.reactApi.createElement (Interop.qrCodeSVG, createObj !!props)

    static member inline toDataURL(element: ReactElement) : string=
        let canvas = Interop.renderToStaticMarkup element
        canvas.toDataURL()

    static member inline children(children: ReactElement list) =
        unbox<IQRCodeProp> (prop.children children)
