using DocumentFormat.OpenXml.Drawing;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice;
using techlink_new_all_in_one.MainController.SubLogic.LogFile;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.Properties;
using techlink_new_all_in_one.View.CustomControl;
using Excel = Microsoft.Office.Interop.Excel;
using Path = System.IO.Path;
using Rectangle = System.Drawing.Rectangle;

namespace techlink_new_all_in_one
{
    public partial class BigHoseQAConfirmSpec : Form, IMessageFilter
    {
        /*
#################################################################
#                             _`				                #
#                          _ooOoo_				                #
#                         o8888888o				                #
#                         88" . "88				                #
#                         (| -_- |)				                #
#                         O\  =  /O				                #
#                      ____/`---'\____				            #
#                    .'  \\|     |//  `.			            #
#                   /  \\|||  :  |||//  \			            #
#                  /  _||||| -:- |||||_  \			            #
#                  |   | \\\  -  /'| |   |			            #
#                  | \_|  `\`---'//  |_/ |			            #
#                  \  .-\__ `-. -'__/-.  /			            #
#                ___`. .'  /--.--\  `. .'___			        #
#             ."" '<  `.___\_<|>_/___.' _> \"".			        #
#            | | :  `- \`. ;`. _/; .'/ /  .' ; |		        #
#            \  \ `-.   \_\_`. _.'_/_/  -' _.' /		        #
#=============`-.`___`-.__\ \___  /__.-'_.'_.-'=================#
                           `= --= -'                    

            TRỜI PHẬT PHÙ HỘ CODE CON KHÔNG BI BUG

          _.-/`)
         // / / )
      .=// / / / )
     //`/ / / / /
     // /     ` /
   ||         /
    \\       /
     ))    .'
         //    /
         /

*/
        private Bitmap excelImage;
        private const float ZoomFactor = 2.0f; // Zoom level

        // Global variables to track images and current index
        private List<string> imagePaths = new List<string>();
        private int currentPageIndex = 0;

        private bool isPQC = false;
        private string productCode = string.Empty;
        private int mqcQuantity = 0;
        private string mqcLot = String.Empty;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private readonly StringBuilder _buffer = new StringBuilder();
        const int WM_CHAR = 0x0102;
        int _keyCount = 0;
        const int SCAN_MIN_LENGTH = 8;
        const double SECONDS_PER_CHARACTER_MIN_PERIOD = 0.3;

        public BigHoseQAConfirmSpec()
        {
            InitializeComponent();

            // Add message filter to hook WM_KEYDOWN events.
            Application.AddMessageFilter(this);
            Disposed += (sender, e) => Application.RemoveMessageFilter(this);
        }
        //Methods

        public bool PreFilterMessage(ref Message m)
        {
            // Get the currently active control
            Control activeControl = Form.ActiveForm?.ActiveControl;

            // Ignore input if a TextBox, ComboBox, or similar control is focused
            if (activeControl is TextBox || activeControl is NumericUpDown)
            {
                return false; // Let normal processing continue for regular input
            }
            // SOLUTION DO THIS (Thanks Jimi!)
            if (m.Msg.Equals(WM_CHAR)) detectScan((char)m.WParam);
            // NOT THIS
            // if(m.Msg.Equals(WM_KEYDOWN)) detectScan((char)m.WParam);
            return false;
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.qaSpecDirectory = dialog.FileName;
                Settings.Default.Save();
            }
        }

        private void detectScan(char @char)
        {
            Debug.WriteLine(@char);
            if (_keyCount == 0) _buffer.Clear();
            int charCountCapture = ++_keyCount;

            _buffer.Append(@char);
            Task
                .Delay(TimeSpan.FromSeconds(SECONDS_PER_CHARACTER_MIN_PERIOD))
                .GetAwaiter()
                .OnCompleted(() =>
                {
                    if (charCountCapture.Equals(_keyCount))
                    {
                        _keyCount = 0;
                        if (_buffer.Length > SCAN_MIN_LENGTH)
                        {
                            if (!String.IsNullOrEmpty(Properties.Settings.Default.qaSpecDirectory))
                            {
                                nudQuantity.Value = 0;
                                label1.Visible = false;
                                nudQuantity.Visible = false;
                                pictureBoxPreview.Focus();
                                try
                                {
                                    // Ensure all Excel processes are killed
                                    System.Diagnostics.Process[] excelProcesses = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                                    foreach (var process in excelProcesses)
                                    {
                                        try
                                        {
                                            process.Kill();
                                            process.WaitForExit();
                                        }
                                        catch { /* Ignore errors */ }
                                    }

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    bool fileFound = false;
                                    int countSharp = 0;
                                    string folderPath = Properties.Settings.Default.qaSpecDirectory; // Change this to your folder path
                                    string keyword;

                                    LoadingDialog loading = new LoadingDialog();
                                    Thread backgroundThreadLoadDT = new Thread(
                                    new ThreadStart(() =>
                                    {
                                        countSharp = _buffer.ToString().Count(f => f == '#');
                                        if (countSharp > 0)
                                        {
                                            string[] data = _buffer.ToString().Trim().Split('#');
                                            keyword = data[0].ToString(); // Change this to your keyword
                                            if (int.TryParse(data[1].ToString(), out int quantity))
                                                mqcQuantity = quantity;
                                            else
                                                MessageBox.Show("Dữ liệu sai vui lòng quét lại mã PQC");
                                            mqcLot = data[2].ToString();
                                            isPQC = false;
                                        }
                                        else
                                        {
                                            keyword = _buffer.ToString().Trim();
                                            isPQC = true;
                                        }
                                        // Search for all Excel files in the folder
                                        var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".xls") || s.EndsWith(".xlsx"));
                                        fileFound = false;
                                        foreach (var file in files)
                                        {
                                            string fileName = System.IO.Path.GetFileName(file);

                                            if (fileName.IndexOf(keyword.Trim(), StringComparison.OrdinalIgnoreCase) >= 0 && (fileName.IndexOf("成品规格表", StringComparison.OrdinalIgnoreCase) >= 0 || fileName.IndexOf("Spec", StringComparison.OrdinalIgnoreCase) >= 0)) // Partial match check
                                            {
                                                fileFound = true;
                                                productCode = keyword;
                                                ShowExcelPreview(file);
                                                break;
                                            }
                                        }
                                        loading.BeginInvoke(new Action(() => loading.Close()));
                                    }));
                                    backgroundThreadLoadDT.Start();
                                    loading.ShowDialog();
                                    if(!fileFound)
                                    {
                                        CTMessageBox.Show("Không thấy file trùng với mã đã quét");
                                    }
                                    else
                                    {
                                        if (isPQC)
                                        {
                                            label1.Visible = true;
                                            label2.Visible = true;
                                            nudQuantity.Visible = true;
                                            tbLotNo.Visible = true;
                                        }
                                        else
                                        {
                                            label1.Visible = false;
                                            label2.Visible = false;
                                            nudQuantity.Visible = false;
                                            tbLotNo.Visible = false;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    isPQC = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    nudQuantity.Visible = false;
                                    tbLotNo.Visible = false;
                                    MessageBox.Show($"Error: {ex.Message}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng cài đặt đường dẫn file.");
                            }
                        }
                    }
                });
        }
        private void ShowExcelPreview(string filePath)
        {
            try
            {
                // Ensure the file is not locked
                if (IsFileLocked(filePath))
                {
                    MessageBox.Show("The file is already in use by another process. Please close it and try again.", "File Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Dispose of previous image
                if (pictureBoxPreview.Image != null)
                {
                    pictureBoxPreview.Image.Dispose();
                    pictureBoxPreview.Image = null;
                }

                // Ensure no orphan Excel processes remain
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                {
                    if (process.MainWindowHandle == IntPtr.Zero)
                    {
                        process.Kill();
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath, ReadOnly: true);
                Excel.Worksheet worksheet = workbook.Sheets[1];

                int totalPages = 1;
                imagePaths.Clear();
                currentPageIndex = 0;
                worksheet.Unprotect();

                // Ensure Normal View mode
                excelApp.ActiveWindow.View = Excel.XlWindowView.xlNormalView;


                for (int i = 1; i <= totalPages; i++)
                {
                    worksheet.PageSetup.FirstPageNumber = i;
                    worksheet.PageSetup.Order = Excel.XlOrder.xlDownThenOver;
                    Excel.Range printArea = string.IsNullOrEmpty(worksheet.PageSetup.PrintArea)
    ? worksheet.UsedRange
    : worksheet.Range[worksheet.PageSetup.PrintArea];

                    if (printArea == null || printArea.Cells.Count < 1)
                    {
                        MessageBox.Show("Invalid print area or empty range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    worksheet.Activate();
                    printArea.CopyPicture(Excel.XlPictureAppearance.xlScreen, Excel.XlCopyPictureFormat.xlBitmap);

                    Excel.Chart chart = workbook.Charts.Add();
                    chart.Paste();

                    string dateName = DateTime.Now.ToString("ddMMyyHHmmss");
                    string tempImagePath = Path.Combine(Path.GetTempPath(), $"{dateName}_{i}.png");
                    chart.Export(tempImagePath, "PNG", false);

                    if (File.Exists(tempImagePath))
                    {
                        imagePaths.Add(tempImagePath);
                    }
                    else
                    {
                        MessageBox.Show("Failed to export image from Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ReleaseComObject(chart);
                }

                if (imagePaths.Count > 0)
                {
                    LoadPreviewPage(0);
                }

                workbook.Close(false);
                ReleaseComObject(worksheet);
                ReleaseComObject(workbook);
                excelApp.Quit();
                ReleaseComObject(excelApp);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                foreach (var process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                {
                    if (process.MainWindowHandle == IntPtr.Zero)
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to check if a file is locked
        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }

        // Helper method to release COM objects
        void ReleaseComObject(object obj)
        {
            if (obj != null)
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
        }

        private void LoadPreviewPage(int pageIndex)
        {
            if (pageIndex >= 0 && pageIndex < imagePaths.Count)
            {
                string imagePath = imagePaths[pageIndex];

                // Check if file exists before loading
                if (!File.Exists(imagePath))
                {
                    MessageBox.Show("Image file not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentPageIndex = pageIndex;

                // Dispose of previous image before loading a new one
                if (excelImage != null)
                {
                    excelImage.Dispose();
                    excelImage = null;
                }

                try
                {
                    excelImage = new Bitmap(imagePath);
                    if (excelImage != null)
                    {
                        pictureBoxPreview.Image = new Bitmap(excelImage, pictureBoxPreview.Size); // Resize the image
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBoxPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (excelImage == null) return;

            int zoomSize = 200; // Zoom area size (width & height)
            int zoomedWidth = zoomSize;  // Keep zoomed size equal to zoom area size
            int zoomedHeight = zoomSize;

            // Convert mouse position from PictureBox scale to actual image scale
            int x = e.X * excelImage.Width / pictureBoxPreview.Width;
            int y = e.Y * excelImage.Height / pictureBoxPreview.Height;

            // Ensure zoom area doesn't exceed image boundaries
            x = Math.Max(0, Math.Min(x - zoomSize / 2, excelImage.Width - zoomSize));
            y = Math.Max(0, Math.Min(y - zoomSize / 2, excelImage.Height - zoomSize));

            // Define zoom area in the original image
            Rectangle zoomArea = new Rectangle(x, y, zoomSize, zoomSize);

            // Create a new Bitmap for the zoomed-in area
            Bitmap zoomedImage = new Bitmap(zoomSize, zoomSize);

            using (Graphics g = Graphics.FromImage(zoomedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(excelImage, new Rectangle(0, 0, zoomedWidth, zoomedHeight), zoomArea, GraphicsUnit.Pixel);
            }

            // Set zoomed image to the panel
            if (panelZoom.BackgroundImage != null)
            {
                panelZoom.BackgroundImage.Dispose();
            }
            panelZoom.BackgroundImage = zoomedImage;
        }

        private void btn_ConfirmSpec_Click(object sender, EventArgs e)
        {
            // Kill any remaining Excel processes
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
            {
                if (process.MainWindowHandle == IntPtr.Zero) // Only close invisible instances
                {
                    process.Kill();
                }
            }
            PritingLabel pritingLabel = new PritingLabel();
            RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
            if (isPQC)
            {
                if (nudQuantity.Value > 0)
                {
                    switch (cbx_PrinterSelect.SelectedIndex)
                    {
                        case 0:
                            rawPrinterHelper.PrintQRLabelTSPL(productCode, (int)nudQuantity.Value, tbLotNo.Text, isPQC);
                            break;
                        case 1:
                            pritingLabel.PrintLabelQRPQC(productCode, (int)nudQuantity.Value, tbLotNo.Text, isPQC);
                            break;
                        default:
                            rawPrinterHelper.PrintQRLabelTSPL(productCode, (int)nudQuantity.Value, tbLotNo.Text, isPQC);
                            break;
                    }
                    SystemLog.Output(SystemLog.MSG_TYPE.Nor, "Print result", productCode + ";" + mqcQuantity + ";PQC");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng thành phẩm.");
                }
            }
            else
            {
                switch (cbx_PrinterSelect.SelectedIndex)
                {
                    case 0:
                        rawPrinterHelper.PrintQRLabelTSPL(productCode, mqcQuantity, mqcLot, isPQC);
                        break;
                    case 1:
                        pritingLabel.PrintLabelQRPQC(productCode, mqcQuantity, mqcLot, isPQC);
                        break;
                    default:
                        rawPrinterHelper.PrintQRLabelTSPL(productCode, mqcQuantity, mqcLot, isPQC);
                        break;
                }
                SystemLog.Output(SystemLog.MSG_TYPE.Nor, "Print result", productCode + ";" + mqcQuantity + ";FQC");
            }
            pictureBoxPreview.Focus();
            lbAnnounce.Text = "Số tem PQC đã in: " + SystemLog.logcount("Print result", "PQC") + "\nSố tem FQC đã in: " + SystemLog.logcount("Print result", "FQC");
        }

        private void BigHoseQAConfirmSpec_Load(object sender, EventArgs e)
        {
            cbx_PrinterSelect.SelectedIndex = 0;
            lbAnnounce.Text = "Số tem PQC đã in: " + SystemLog.logcount("Print result", "PQC") + "\nSố tem FQC đã in: " + SystemLog.logcount("Print result", "FQC");
        }
    }
}
