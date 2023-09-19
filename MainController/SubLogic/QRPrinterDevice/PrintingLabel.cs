﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techlink_new_all_in_one.MainModel.SaveVariables;

namespace techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice
{
    class PritingLabel
    {
        public const int ISerial = 0;
        public const int IParallel = 1;
        public const int IUsb = 2;
        public const int ILan = 3;
        public const int IBluetooth = 5;
        private string ByteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }
        // String -> byte[] 
        private byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }
        private bool ConnectPrinter()
        {
            string strPort = "";
            int nInterface = ISerial;
            int nBaudrate = 115200, nDatabits = 8, nParity = 0, nStopbits = 0;
            int nStatus = (int)SLCS_ERROR_CODE.ERR_CODE_NO_ERROR;

            //if (rdoIF_Serial.Checked)
            //{
            //    // SERIAL (COM)
            //    nInterface = ISerial;
            //    strPort = cmbSerial_Port.Text;
            //    nBaudrate = Convert.ToInt32(cmbSerial_Baudrate.Text);
            //    nDatabits = Convert.ToInt32(cmbSerial_Databits.Text);
            //    nParity = cmbSerial_Parity.SelectedIndex;
            //    nStopbits = cmbSerial_Stopbits.SelectedIndex;
            //}
            //else if (rdoIF_Bluetooth.Checked)
            //{
            //    // BLUETOOTH (COM)
            //    nInterface = IBluetooth;
            //    strPort = cmbSerial_Port.Text;
            //}
            //else if (rdoIF_Parallel.Checked)
            //{
            //    // PARALLEL (LPT)
            //    nInterface = IParallel;
            //    strPort = cmbLPT_Port.Text;
            //}
            //else if (rdoIF_Usb.Checked)
            //{
            // USB
            nInterface = IUsb;
            //}
            //else if (rdoIF_Lan.Checked)
            //{
            //    // NETWORK
            //    nInterface = ILan;
            //    strPort = txtNet_IPAddr.Text;
            //    nBaudrate = Convert.ToInt32(txtNet_PortNum.Text);
            //}

            nStatus = BXLLApi.ConnectPrinterEx(nInterface, strPort, nBaudrate, nDatabits, nParity, nStopbits);

            if (nStatus != (int)SLCS_ERROR_CODE.ERR_CODE_NO_ERROR)
            {
                BXLLApi.DisconnectPrinter();
                throw new Exception(GetStatusMsg(nStatus));
            }
            return true;
        }
        private string GetStatusMsg(int nStatus)
        {
            string errMsg = "";
            switch ((SLCS_ERROR_CODE)nStatus)
            {
                case SLCS_ERROR_CODE.ERR_CODE_NO_ERROR: errMsg = "No Error"; break;
                case SLCS_ERROR_CODE.ERR_CODE_NO_PAPER: errMsg = "Paper Empty"; break;
                case SLCS_ERROR_CODE.ERR_CODE_COVER_OPEN: errMsg = "Cover Open"; break;
                case SLCS_ERROR_CODE.ERR_CODE_CUTTER_JAM: errMsg = "Cutter jammed"; break;
                case SLCS_ERROR_CODE.ERR_CODE_TPH_OVER_HEAT: errMsg = "TPH overheat"; break;
                case SLCS_ERROR_CODE.ERR_CODE_AUTO_SENSING: errMsg = "Gap detection Error (Auto-sensing failure)"; break;
                case SLCS_ERROR_CODE.ERR_CODE_NO_RIBBON: errMsg = "Ribbon End"; break;
                case SLCS_ERROR_CODE.ERR_CODE_BOARD_OVER_HEAT: errMsg = "Board overheat"; break;
                case SLCS_ERROR_CODE.ERR_CODE_MOTOR_OVER_HEAT: errMsg = "Motor overheat"; break;
                case SLCS_ERROR_CODE.ERR_CODE_WAIT_LABEL_TAKEN: errMsg = "Waiting for the label to be taken"; break;
                case SLCS_ERROR_CODE.ERR_CODE_CONNECT: errMsg = "Port open error"; break;
                case SLCS_ERROR_CODE.ERR_CODE_GETNAME: errMsg = "Unknown (or Not supported) printer name"; break;
                case SLCS_ERROR_CODE.ERR_CODE_OFFLINE: errMsg = "Offline (The printer is in an error status)"; break;
                default: errMsg = "Unknown error"; break;
            }
            return errMsg;
        }

        private void SendPrinterSettingCommand()
        {
            // 203 DPI : 1mm is about 7.99 dots
            // 300 DPI : 1mm is about 11.81 dots
            // 600 DPI : 1mm is about 23.62 dots
            int dotsPer1mm = (int)Math.Round((float)BXLLApi.GetPrinterDPI() / 25.4f);
            int nPaper_Width = Convert.ToInt32(91 * dotsPer1mm);
            int nPaper_Height = Convert.ToInt32(61 * dotsPer1mm);
            int nMarginX = Convert.ToInt32(3 * dotsPer1mm);
            int nMarginY = Convert.ToInt32(3 * dotsPer1mm);
            int nSpeed = (int)SLCS_PRINT_SPEED.PRINTER_SETTING_SPEED;
            int nDensity = Convert.ToInt32(14);
            int nOrientation = (int)SLCS_ORIENTATION.TOP2BOTTOM;

            int nSensorType = (int)SLCS_MEDIA_TYPE.GAP;
            //if (rdoBmark.Checked) nSensorType = (int)SLCS_MEDIA_TYPE.BLACKMARK;
            //else if (rdoContinuous.Checked) nSensorType = (int)SLCS_MEDIA_TYPE.CONTINUOUS;

            //	Clear Buffer of Printer
            BXLLApi.ClearBuffer();

            // Rewinder is only available for XT series printers (XT5-40, XT5-43, XT5-46)
            //if (rdoRewind.Checked)
            //{
            //    BXLLApi.PrintDirect("RWDy", true);
            //}

            //	Set Label and Printer
            //BXLLApi.SetConfigOfPrinter(BXLLApi.SPEED_50, 17, BXLLApi.TOP, false, 0, true);
            BXLLApi.SetConfigOfPrinter(nSpeed, nDensity, nOrientation, false, 1, true);

            // Select international character set and code table.To
            BXLLApi.SetCharacterset((int)SLCS_INTERNATIONAL_CHARSET.ICS_CHINA, (int)SLCS_CODEPAGE.FCP_CP1252);

            /* 
                1 Inch : 25.4mm
                1 mm   :  7.99 Dots (XT5-40, SLP-TX400, SLP-DX420, SLP-DX220, SLP-DL410, SLP-T400, SLP-D420, SLP-D220, SRP-770/770II/770III)
                1 mm   :  7.99 Dots (SPP-L310, SPP-L410, SPP-L3000, SPP-L4000) 
                1 mm   :  7.99 Dots (XD3-40d, XD3-40t, XD5-40d, XD5-40t, XD5-40LCT)
                1 mm   : 11.81 Dots (XT5-43, SLP-TX403, SLP-DX423, SLP-DX223, SLP-DL413, SLP-T403, SLP-D423, SLP-D223)
                1 mm   : 11.81 Dots (XD5-43d, XD5-43t, XD5-43LCT)
                1 mm   : 23.62 Dots (XT5-46)
            */

            BXLLApi.SetPaper(nMarginX, nMarginY, nPaper_Width, nPaper_Height, nSensorType, 0, 2 * dotsPer1mm);

            // Direct thermal
            //    if (true)
            BXLLApi.PrintDirect("STd", true);
            //else // Thermal transfer
            //    BXLLApi.PrintDirect("STt", true);
        }


        public void PrintLabelHSEDeviceQRCodeItem(PcccDevice labelItem, int Prints)
        {
            if (!ConnectPrinter())
                return;

            int multiplier = 1;
            // 203 DPI : 1mm is about 7.99 dots
            // 300 DPI : 1mm is about 11.81 dots
            // 600 DPI : 1mm is about 23.62 dots
            int resolution = BXLLApi.GetPrinterDPI();
            int dotsPer1mm = (int)Math.Round((float)resolution / 25.4f);
            if (resolution >= 600)
                multiplier = 3;

            SendPrinterSettingCommand();

            // Prints string using TrueFont
            //  P1 : Horizontal position (X) [dot]
            //  P2 : Vertical position (Y) [dot]
            //  P3 : Font Name
            //  P4 : Font Size
            //  P5 : Rotation : (0 : 0 degree , 1 : 90 degree, 2 : 180 degree, 3 : 270 degree)
            //  P6 : Italic
            //  P7 : Bold
            //  P8 : Underline
            //  P9 : RLE (Run-length encoding)
            //BXLLApi.PrintTrueFontLib(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);
            //   BXLLApi.PrintTrueFont(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);

            //	Draw Lines
            //if (labelItem.Type.Contains("XZFTB"))
            //{
            //    //MessageBox.Show("Bình chữa cháy dạng cầu --> Hình ảnh mã sẽ được lưu Clipboard để thêm vào file word!");
            //    QRGenerate qRGenerate = new QRGenerate();
            //    Clipboard.SetImage(qRGenerate.GeneratingQRCode(labelItem.UUID));
            //}

            string[] labelTypeString = labelItem.Type.Split('-');
            if (labelTypeString.Length > 1)
            {
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 7 * dotsPer1mm, "Microsoft YaHei", 32, 0, false, false, true, "Loại thiết bị 设备类型: ", false);
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 12 * dotsPer1mm, "Arial", 32, 0, false, false, false, labelTypeString[0], false);
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 17 * dotsPer1mm, "Arial", 32, 0, false, false, false, labelTypeString[1], false);

                BXLLApi.PrintQRCode(52 * dotsPer1mm, 12 * dotsPer1mm, (int)SLCS_QRCODE_MODEL.QRMODEL_2, (int)SLCS_QRCODE_ECC_LEVEL.QRECCLEVEL_H, (int)SLCS_QRCODE_SIZE.QRSIZE_9, (int)SLCS_ROTATION.ROTATE_0, labelItem.UUID);
            }
            else
            {
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 7 * dotsPer1mm, "Microsoft YaHei", 32, 0, false, false, true, "Loại thiết bị 设备类型: ", false);
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 12 * dotsPer1mm, "Arial", 32, 0, false, false, false, labelItem.Type, false);

                BXLLApi.PrintQRCode(52 * dotsPer1mm, 12 * dotsPer1mm, (int)SLCS_QRCODE_MODEL.QRMODEL_2, (int)SLCS_QRCODE_ECC_LEVEL.QRECCLEVEL_H, (int)SLCS_QRCODE_SIZE.QRSIZE_9, (int)SLCS_ROTATION.ROTATE_0, labelItem.UUID);
            }

            BXLLApi.Prints(1, Prints);

            //	Print Command
            // Disconnect printer
            BXLLApi.DisconnectPrinter();
        }
        public void PrintLabelHSEQRLocation(PcccLocation labelLocation, int Prints)
        {
            if (!ConnectPrinter())
                return;

            int multiplier = 1;
            // 203 DPI : 1mm is about 7.99 dots
            // 300 DPI : 1mm is about 11.81 dots
            // 600 DPI : 1mm is about 23.62 dots
            int resolution = BXLLApi.GetPrinterDPI();
            int dotsPer1mm = (int)Math.Round((float)resolution / 25.4f);
            if (resolution >= 600)
                multiplier = 3;

            SendPrinterSettingCommand();

            // Prints string using TrueFont
            //  P1 : Horizontal position (X) [dot]
            //  P2 : Vertical position (Y) [dot]
            //  P3 : Font Name
            //  P4 : Font Size
            //  P5 : Rotation : (0 : 0 degree , 1 : 90 degree, 2 : 180 degree, 3 : 270 degree)
            //  P6 : Italic
            //  P7 : Bold
            //  P8 : Underline
            //  P9 : RLE (Run-length encoding)
            //BXLLApi.PrintTrueFontLib(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);
            //   BXLLApi.PrintTrueFont(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);

            //	Draw Lines
            string[] location = labelLocation.Location.Split('-');
            string labelQR = labelLocation.Location;
            BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 7 * dotsPer1mm, "Microsoft YaHei", 32, 0, false, false, true, "Vị trí 位:", false);
            int line = 17;
            for (int i = 0; i < location.Length; i++)
            {
                BXLLApi.PrintTrueFontW(10 * dotsPer1mm, line * dotsPer1mm, "Arial", 32, 0, false, false, false, location[i].Trim(), false);
                line += 5;
            }

            BXLLApi.PrintQRCode(50 * dotsPer1mm, 10 * dotsPer1mm, (int)SLCS_QRCODE_MODEL.QRMODEL_2, (int)SLCS_QRCODE_ECC_LEVEL.QRECCLEVEL_H, (int)SLCS_QRCODE_SIZE.QRSIZE_9, (int)SLCS_ROTATION.ROTATE_0, labelQR);

            BXLLApi.Prints(1, Prints);

            //	Print Command
            // Disconnect printer
            BXLLApi.DisconnectPrinter();
        }

        public void PrintLabelQRCodeEmployee(string EmpName, int Prints)
        {
            if (!ConnectPrinter())
                return;

            int multiplier = 1;
            // 203 DPI : 1mm is about 7.99 dots
            // 300 DPI : 1mm is about 11.81 dots
            // 600 DPI : 1mm is about 23.62 dots
            int resolution = BXLLApi.GetPrinterDPI();
            int dotsPer1mm = (int)Math.Round((float)resolution / 25.4f);
            if (resolution >= 600)
                multiplier = 3;

            SendPrinterSettingCommand();

            // Prints string using TrueFont
            //  P1 : Horizontal position (X) [dot]
            //  P2 : Vertical position (Y) [dot]
            //  P3 : Font Name
            //  P4 : Font Size
            //  P5 : Rotation : (0 : 0 degree , 1 : 90 degree, 2 : 180 degree, 3 : 270 degree)
            //  P6 : Italic
            //  P7 : Bold
            //  P8 : Underline
            //  P9 : RLE (Run-length encoding)
            //BXLLApi.PrintTrueFontLib(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);
            //   BXLLApi.PrintTrueFont(2 * dotsPer1mm, 5 * dotsPer1mm, "Arial", 14, 0, true, true, false, "Sample Label-1", false);

            //	Draw Lines
            BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 7 * dotsPer1mm, "Microsoft YaHei", 32, 0, false, false, true, "Tên nhân viên 员工姓名:", false);
            BXLLApi.PrintTrueFontW(10 * dotsPer1mm, 12 * dotsPer1mm, "Microsoft YaHei", 32, 0, false, false, false, EmpName, false);

            BXLLApi.PrintQRCode(50 * dotsPer1mm, 10 * dotsPer1mm, (int)SLCS_QRCODE_MODEL.QRMODEL_2, (int)SLCS_QRCODE_ECC_LEVEL.QRECCLEVEL_H, (int)SLCS_QRCODE_SIZE.QRSIZE_9, (int)SLCS_ROTATION.ROTATE_0, "loginSetting;" + SubMethods.RemoveVietnameseUnicode(EmpName));

            BXLLApi.Prints(1, Prints);

            //	Print Command
            // Disconnect printer
            BXLLApi.DisconnectPrinter();
        }
    }
}
