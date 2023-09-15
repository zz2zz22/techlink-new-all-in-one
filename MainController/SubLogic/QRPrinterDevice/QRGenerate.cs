using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice
{
    public class QRGenerate
    {
        public Image GeneratingQRCode(string QR)
        {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.Height = 500;
            options.Width = 500;
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options = options;
            Image QRImage = barcodeWriter.Write(QR);
            return QRImage;
        }
    }
}
