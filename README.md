# Feliz Binding for [qrcode.react](https://github.com/zpao/qrcode.react)

[![Feliz.QRCode on Nuget](https://buildstats.info/nuget/Feliz.QRCode)](https://www.nuget.org/packages/Feliz.QRCode/)
[![Docs](https://github.com/tforkmann/Feliz.QRCode/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.QRCode/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.QRCode
```

and install the npm package

```
npm install --save qrcode.react
```

or use Femto:
```
femto install Feliz.QRCode
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Example QRCode
Here is an example QRCode
```fs
[<ReactComponent>]
let QRCodeCanvas () =
    QRCode.qrcodecanvas [
        qrCodeCanvas.value "https://www.google.com"
        qrCodeCanvas.size 600
        qrCodeCanvas.bgColor "#ffffff"
        qrCodeCanvas.fgColor "#000000"
        qrCodeCanvas.level "L"
        qrCodeCanvas.includeMargin false
        qrCodeCanvas.imageSettings [
            imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettings.height 24
            imageSettings.width 24
            imageSettings.excavate true
        ]
    ]
```

