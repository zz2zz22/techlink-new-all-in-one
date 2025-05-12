using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice
{
    class RawPrinterHelper
    {
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter(string src, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter")]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter")]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter")]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter")]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter")]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        public static bool SendStringToPrinter(string printerName, string data)
        {
            IntPtr pBytes;
            IntPtr hPrinter = IntPtr.Zero;
            int dwWritten = 0;
            DOCINFOA di = new DOCINFOA { pDocName = "Label Print", pDataType = "RAW" };

            if (OpenPrinter(printerName, out hPrinter, IntPtr.Zero))
            {
                if (StartDocPrinter(hPrinter, 1, ref di))
                {
                    if (StartPagePrinter(hPrinter))
                    {
                        pBytes = Marshal.StringToCoTaskMemAnsi(data);
                        WritePrinter(hPrinter, pBytes, data.Length, out dwWritten);
                        Marshal.FreeCoTaskMem(pBytes);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            return (dwWritten == data.Length);
        }

        public void PrintQRLabelTSPL(string productCode, int quantity, string lotInput, bool isPqc)
        {
            string printerName = "TSC TE200"; // Ensure this matches your installed printer name // "Gprinter GP-1324D" "TSC TE200"
            string dept = string .Empty;
            string lot = lotInput.Trim();
            string name = SubMethods.RemoveVietnameseUnicode(UserData.UserName.Split(' ').Last());
            string code = UserData.UserCode;
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string data = productCode + "#" + quantity + "#" + lot;
            // TSPL Commands to print a label with a QR Code
            if (isPqc)
            {
                productCode = String.Empty;
                dept = "PQC";
            }
            else
                dept = "FQC";

            string tsplCommand = $@"
SIZE 65 mm, 45 mm
GAP 2 mm, 0
CLS
TEXT 10,40,""2"",0,2,2,""{productCode}""
TEXT 10,120,""3"",0,1,1,""LOT: {lot}""
TEXT 10,150,""3"",0,1,1,""SL: {quantity}""
TEXT 10,180,""3"",0,1,1,""{dept}: {name}""
TEXT 10,210,""3"",0,1,1,""MA SO: {code}""
TEXT 10,240,""3"",0,1,1,""DATE: {date}""
TEXT 10,270,""3"",0,1,1,""RESULT: OK""
QRCODE 310,120,H,6,A,0,M2,S1,""{data}""
PRINT 1,1
";

            RawPrinterHelper.SendStringToPrinter(printerName, tsplCommand);
        }
    }
}
