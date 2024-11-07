namespace Feliz.QRCode

open Fable.Core.JsInterop
open Fable.Core
open Feliz
open Fable.React
open Browser.Dom
open Browser.Types

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IQRCodeProp.


[<Erase>]
type QRCode =
    /// Creates a new QRCode component.

    static member inline qrCodeCanvas(props: IQRCodeCanvasProp seq) =
        Interop.reactApi.createElement (Interop.qrCodeCanvas, createObj !!props)

    static member inline qrCodeSVG(props: IQRCodeSVGProp seq) =
        Interop.reactApi.createElement (Interop.qrCodeSVG, createObj !!props)

    static member inline convertToDataURL(element: ReactElement) : string=
        let staticHtml = ReactDomServer.renderToStaticMarkup element
        let tempDiv = document.createElement("div")
        tempDiv.innerHTML <- staticHtml
        let canvas = tempDiv.querySelector("canvas") :?> HTMLCanvasElement
        canvas.toDataURL("image/png")

    static member inline children(children: ReactElement list) =
        unbox<IQRCodeProp> (prop.children children)
