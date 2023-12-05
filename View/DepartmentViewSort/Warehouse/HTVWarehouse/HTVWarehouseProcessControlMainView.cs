using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice;
using System.Diagnostics;
using Spire.Xls;
using System.Drawing.Printing;
using techlink_new_all_in_one.View.DepartmentViewSort.Warehouse.HTVWarehouse.SubUI;
using techlink_new_all_in_one.Properties;

namespace techlink_new_all_in_one
{
    public partial class HTVWarehouseProcessControlMainView : Form, IMessageFilter
    {
        private readonly StringBuilder _buffer = new StringBuilder();
        const int WM_CHAR = 0x0102;
        int _keyCount = 0;
        const int SCAN_MIN_LENGTH = 8;
        const double SECONDS_PER_CHARACTER_MIN_PERIOD = 0.3;
        string message = String.Empty, caption = String.Empty;

        private static Workbook workbook;
        private static Worksheet materialSheet;

        public HTVWarehouseProcessControlMainView()
        {
            InitializeComponent();
            // Add message filter to hook WM_KEYDOWN events.
            Application.AddMessageFilter(this);
            Disposed += (sender, e) => Application.RemoveMessageFilter(this);
        }
        public bool PreFilterMessage(ref Message m)
        {
            // SOLUTION DO THIS (Thanks Jimi!)
            if (m.Msg.Equals(WM_CHAR)) detectScan((char)m.WParam);
            // NOT THIS
            // if(m.Msg.Equals(WM_KEYDOWN)) detectScan((char)m.WParam);
            return false;
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
                            string result = _buffer.ToString();

                            if (materialSheet != null)
                            {
                                if (result.ToLower().StartsWith("s") && !String.IsNullOrEmpty(result))
                                {
                                    string[] data = result.Split(';');
                                    if (data.Length > 1)
                                    {
                                        DataTable dt = TemporaryVariables.materialDT;
                                        if (radioScan.Checked)
                                        {
                                            for (int i = 0; i < dt.Rows.Count; i++)
                                            {
                                                if (dt.Rows[i]["mat_name"].ToString() == data[1].Trim())
                                                {
                                                    double weight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                                                    double total = Convert.ToDouble(data[2]) + Convert.ToDouble(dt.Rows[i]["actual_weight"].ToString());
                                                    if(total > weight)
                                                        total = weight;
                                                    if (CheckString2Weight(total.ToString(), dt.Rows[i]["weight"].ToString(), dt.Rows[i]["tolerance"].ToString()))
                                                    {
                                                        dt.Rows[i]["lot_no"] = data[4];
                                                        dt.Rows[i]["actual_weight"] = total.ToString();
                                                        dt.Rows[i]["barcode"] = "s" + dt.Rows[i]["mat_name"].ToString() + ";" + total.ToString() + ";" + data[4] + "e";
                                                        LoadDTGV(dt);
                                                        TemporaryVariables.materialDT = dt;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        message = "Không thể thêm nguyên vật liệu vì sẽ quá trọng lượng yêu cầu!\r\n不能添加额外的材料，因为它会超过所需的重量！";
                                                        caption = "Lỗi / 错误";
                                                        CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (radioScale.Checked)
                                            {
                                                TemporaryVariables.materialCode = data[1].Trim();
                                                TemporaryVariables.isInputQuantity = false;

                                                double upTolerance = 0, downTolerance = 0, initTolerance, initWeight, currentActualWeight;
                                                for (int i = 0; i < dt.Rows.Count; i++)
                                                {
                                                    if (dt.Rows[i]["mat_name"].ToString() == data[1].Trim())
                                                    {
                                                        TemporaryVariables.lotNo = data[4];
                                                        initTolerance = Convert.ToDouble(dt.Rows[i]["tolerance"].ToString());
                                                        initWeight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                                                        upTolerance = initWeight + initTolerance;
                                                        downTolerance = initWeight - initTolerance;
                                                        if (downTolerance < 0)
                                                            downTolerance = 0;
                                                        MaterialScaleMainView quantityInput = new MaterialScaleMainView(TemporaryVariables.materialCode, upTolerance, downTolerance);
                                                        quantityInput.FormClosed += quantityInputFormClosed;
                                                        quantityInput.ShowDialog();
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }

                            }
                            else
                            {
                                message = "Vui lòng chọn một công thức trước!\r\n请先选择一个食谱！";
                                caption = "Lỗi / 错误";
                                CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            message = "Không thể nhận dạng mã QR!\r\n无法识别二维码！";
                            caption = "Lỗi / 错误";
                            CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                });
        }
        private void quantityInputFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= quantityInputFormClosed;
            if (TemporaryVariables.isInputQuantity)
            {
                TemporaryVariables.isInputQuantity = false;
                DataTable dt = TemporaryVariables.materialDT;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["mat_name"].ToString() == TemporaryVariables.materialCode)
                    {
                        dt.Rows[i]["lot_no"] = TemporaryVariables.lotNo;
                        TemporaryVariables.lotNo = String.Empty;
                        dt.Rows[i]["actual_weight"] = TemporaryVariables.inputQuantity;
                        dt.Rows[i]["barcode"] = "s" + dt.Rows[i]["mat_name"].ToString() + ";" + TemporaryVariables.inputQuantity + ";" + TemporaryVariables.lotNo + "e";
                        TemporaryVariables.inputQuantity = 0;
                        LoadDTGV(dt);
                        TemporaryVariables.materialDT = dt;
                    }
                }
            }
        }

        private void OpenDirectory()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Properties.Settings.Default.folder_directory;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Properties.Settings.Default.folder_directory = dialog.FileName;
                Properties.Settings.Default.Save();
            }
            LoadItemFilePath(Properties.Settings.Default.folder_directory);
        }
        private void LoadItemFilePath(string path)
        {
            try
            {
                //dtgvShowSearchResult.DataSource = null;
                DataTable dt = new DataTable();
                DataTable dts = new DataTable();
                dt.Columns.Add("file_name", typeof(string));
                dt.Columns.Add("file_path", typeof(string));
                dts.Columns.Add("file_name", typeof(string));
                dts.Columns.Add("file_path", typeof(string));
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".xls", StringComparison.OrdinalIgnoreCase));
                foreach (string fileName in files)
                {
                    dt.Rows.Add(Path.GetFileNameWithoutExtension(fileName), fileName);
                }

                //dtgvShowSearchResult.DataSource = dt;
                //dtgvShowSearchResult.Columns["file_name"].HeaderText = "Tên tệp\r\n产品型号名称";
                //dtgvShowSearchResult.Columns["file_path"].Visible = false;
            }
            catch (Exception ex)
            {
                message = "Không thể tải dữ liệu tệp!\r\n上传产品型号失败！" + "\r\n\r\n" + ex.Message;
                caption = "Lỗi / 错误";
                CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private bool CheckWeightOK(string actualWeight, string total, string tolerance)
        {
            double weight1 = Convert.ToDouble(actualWeight);
            double weight2 = Convert.ToDouble(total);
            double s = Convert.ToDouble(tolerance);

            if (weight1 <= (weight2 + s) && weight1 >= (weight2 - s))
                return true;
            else
                return false;
        }
        private bool CheckString2Weight(string a, string b, string tolerance)
        {
            double weight1 = Convert.ToDouble(a);
            double weight2 = Convert.ToDouble(b);
            double s = Convert.ToDouble(tolerance);

            if (weight1 <= (weight2 + s))
                return true;
            else
            {
                return false;
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void LoadDTGV(DataTable dt)
        {
            dtgvMaterialInfo.DataSource = null;
            dtgvMaterialInfo.DataSource = dt;
            dtgvMaterialInfo.Columns["mat_name"].HeaderText = "Tên nguyên liệu\r\n原料名稱";
            dtgvMaterialInfo.Columns["lot_no"].HeaderText = "Số lô nguyên liệu\r\n原料批號";
            dtgvMaterialInfo.Columns["weight"].HeaderText = "Số lượng(Kg)\r\n投料重(Kg)";
            dtgvMaterialInfo.Columns["tolerance"].HeaderText = "Dung sai cung cấp liệu\r\n投料公差";
            dtgvMaterialInfo.Columns["actual_weight"].HeaderText = "Khối lượng thực tế (Kg)\r\n实际重量 (Kg)";
            dtgvMaterialInfo.Columns["barcode"].Visible = false;
            dtgvMaterialInfo.ClearSelection();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenDirectory();
        }

        private void dtgvShowSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgvShowSearchResult.SelectedCells.Count > 0)
            //{
            //    try
            //    {
            //        string formulaName, lotNo;
            //        int selectedrowindex = dtgvShowSearchResult.SelectedCells[0].RowIndex;
            //        DataGridViewRow selectedRow = dtgvShowSearchResult.Rows[selectedrowindex];

            //        //Save variable to Datatable

            //        DataTable matDT = new DataTable();

            //        TemporaryVariables.InitMaterialDT();
            //        workbook = new Workbook();
            //        workbook.LoadFromFile(Convert.ToString(selectedRow.Cells["file_path"].Value));
            //        materialSheet = workbook.Worksheets[0];

            //        if (materialSheet != null)
            //        {
            //            formulaName = materialSheet.Range["C3"].Value.ToString();
            //            string lotNoLine = materialSheet.Range["J3"].Value.ToString();
            //            lotNo = lotNoLine.Substring(lotNoLine.IndexOf(":") + 1);
            //            lbDisplay.Text = formulaName + " - " + lotNo;

            //            matDT = materialSheet.ExportDataTable(materialSheet.Range["A7:M22"], false, true);
            //            if (matDT.Rows.Count > 0)
            //            {
            //                for (int i = 0; i < matDT.Rows.Count; i++)
            //                {
            //                    if (!String.IsNullOrEmpty(matDT.Rows[i][0].ToString())
            //                        && !String.IsNullOrEmpty(matDT.Rows[i][6].ToString())
            //                        && !String.IsNullOrEmpty(matDT.Rows[i][8].ToString()))
            //                    {
            //                        TemporaryVariables.materialDT.Rows.Add(
            //                                matDT.Rows[i][0].ToString(),
            //                                matDT.Rows[i][2].ToString(),
            //                                Convert.ToDouble(matDT.Rows[i][6].ToString()),
            //                                Convert.ToDouble(matDT.Rows[i][8].ToString()),
            //                                0);
            //                    }
            //                }
            //                LoadDTGV(TemporaryVariables.materialDT);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        dtgvMaterialInfo.DataSource = null;
            //        message = "Lỗi khi tải dữ liệu excel!\r\n下载EXCEL失败!" + "\r\n\r\n" + ex.Message;
            //        caption = "Lỗi / 错误";
            //        CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }


        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            bool isFinished = true;
            DataTable dt = TemporaryVariables.materialDT;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!CheckWeightOK(dt.Rows[i]["actual_weight"].ToString(), dt.Rows[i]["weight"].ToString(), dt.Rows[i]["tolerance"].ToString()))
                {
                    isFinished = false;
                }
            }
            if (isFinished)
            {
                QRGenerate qR = new QRGenerate();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    for (int i = 6; i < 24; i++)
                    {
                        if (materialSheet.Range["A" + i].Value == dt.Rows[j]["mat_name"].ToString())
                        {
                            materialSheet.Range["C" + i].Value = dt.Rows[j]["lot_no"].ToString();
                            materialSheet.Range["J" + i].Style.VerticalAlignment = VerticalAlignType.Top;
                            ExcelPicture picture = materialSheet.Pictures.Add(i, 10, qR.GeneratingBarcode(dt.Rows[j]["barcode"].ToString()));
                            materialSheet.Range["J" + i].RowHeight = 160;
                            picture.LeftColumnOffset = 30;
                            picture.TopRowOffset = 30;
                        }
                    }
                }
                //Get the PageSetup object of the first worksheet
                Spire.Xls.PageSetup pageSetup = materialSheet.PageSetup;

                //Set page margins
                pageSetup.TopMargin = 0.3;
                pageSetup.BottomMargin = 0.3;
                pageSetup.LeftMargin = 0.3;
                pageSetup.RightMargin = 0.3;

                //Set printing quality (dpi)
                pageSetup.PrintQuality = 300;

                //Allow to print worksheet in black & white mode
                pageSetup.BlackAndWhite = true;

                //Set the printing order
                pageSetup.Order = OrderType.OverThenDown;
                //Fit worksheet on one page
                pageSetup.IsFitToPage = false;
                //Create a PrintDialog object
                PrintDialog dialog = new PrintDialog();
                dialog.AllowCurrentPage = true;
                dialog.AllowSomePages = true;
                dialog.AllowSelection = true;
                dialog.UseEXDialog = true;
                dialog.PrinterSettings.Duplex = Duplex.Simplex;

                workbook.PrintDialog = dialog;
                PrintDocument printDocument = workbook.PrintDocument;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                message = "Chưa hoàn thành cân nguyên vật liệu!\r\n原料称量尚未完成!";
                caption = "Lỗi / 错误";
                CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFormula_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Nhập file công thức / 导入公式文件";
                fileDialog.DefaultExt = "Excel";
                fileDialog.Filter = "Excel files|*.xlsx;*.xls";
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = true;
                fileDialog.InitialDirectory = Properties.Settings.Default.folder_directory; //"C:\\";

                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string _file in fileDialog.FileNames)
                    {
                        FileInfo d = new FileInfo(_file);
                        string path = Path.Combine(Properties.Settings.Default.folder_directory + "\\" + d.Name);
                        if (File.Exists(path))
                        {
                            //File.Delete(Path.Combine(Properties.Settings.Default.folder_directory + "\\" + d.Name));
                            try
                            {
                                string formulaName, lotNo;
                                //Save variable to Datatable
                                DataTable matDT = new DataTable();

                                TemporaryVariables.InitMaterialDT();
                                workbook = new Workbook();
                                workbook.LoadFromFile(path);
                                materialSheet = workbook.Worksheets[0];

                                if (materialSheet != null)
                                {
                                    string LongName = materialSheet.Range["A3"].Value.ToString();
                                    formulaName = LongName.Substring(LongName.IndexOf(":") + 1);
                                    string lotNoLine = materialSheet.Range["H3"].Value.ToString();
                                    lotNo = lotNoLine.Substring(lotNoLine.IndexOf(":") + 1);
                                    lbDisplay.Text = formulaName + " - " + lotNo;

                                    matDT = materialSheet.ExportDataTable(materialSheet.Range["A6:L22"], false, true);
                                    if (matDT.Rows.Count > 0)
                                    {
                                        for (int i = 0; i < matDT.Rows.Count; i++)
                                        {
                                            if (!String.IsNullOrEmpty(matDT.Rows[i][0].ToString())
                                                && !String.IsNullOrEmpty(matDT.Rows[i][6].ToString())
                                                && !String.IsNullOrEmpty(matDT.Rows[i][8].ToString()))
                                            {
                                                TemporaryVariables.materialDT.Rows.Add(
                                                        matDT.Rows[i][0].ToString(),
                                                        matDT.Rows[i][2].ToString(),
                                                        Convert.ToDouble(matDT.Rows[i][6].ToString()),
                                                        Convert.ToDouble(matDT.Rows[i][8].ToString()),
                                                        0);
                                            }
                                        }
                                        LoadDTGV(TemporaryVariables.materialDT);

                                        message = "Thêm công thức thành công!\r\n更多成功秘诀！";
                                        caption = "Thông tin / 信息";
                                        CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadItemFilePath(Properties.Settings.Default.folder_directory);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                dtgvMaterialInfo.DataSource = null;
                                message = "Lỗi khi tải dữ liệu excel!\r\n下载EXCEL失败!" + "\r\n\r\n" + ex.Message;
                                caption = "Lỗi / 错误";
                                CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //File.Move(_file, Path.Combine(Properties.Settings.Default.folder_directory + "\\" + d.Name));
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Thêm công thức thất bại !\r\n更多失败的食谱！" + "\r\n\r\n" + ex.Message;
                caption = "Lỗi / 错误";
                CTMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HTVWarehouseProcessControlMainView_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.folder_directory))
            {
                LoadItemFilePath(Properties.Settings.Default.folder_directory);
            }
        }
    }
}
