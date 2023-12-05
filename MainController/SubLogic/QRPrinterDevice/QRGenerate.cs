using System.Drawing;
using System.Text;
using ZXing;
using ZXing.Common;
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

        public Image GeneratingBarcode(string Barcode)
        {
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 200,
                    Width = 200,
                },
            };
            Image bitmap = writer.Write(Barcode);
            return bitmap; 
        }
    }
}
