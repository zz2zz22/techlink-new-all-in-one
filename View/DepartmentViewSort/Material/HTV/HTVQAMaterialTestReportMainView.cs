using ClosedXML.Excel;
using NPOI.HSSF.UserModel;   // for .xls
using NPOI.SS.UserModel;     // common interfaces
using NPOI.XSSF.UserModel;   // for .xlsx
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;

namespace techlink_new_all_in_one
{
    public partial class HTVQAMaterialTestReportMainView : Form
    {
        //Fields
        private DataTable dtTestValue;

        private string fileName;

        public HTVQAMaterialTestReportMainView()
        {
            InitializeComponent();
        }

        private void InitAllTable()
        {
            dtTestValue = new DataTable();
            dtTestValue.Columns.Add("lot_code", typeof(string)); //B
            dtTestValue.Columns.Add("hardness_0h", typeof(float)); //C
            dtTestValue.Columns.Add("hardness_200C_4h", typeof(float)); //D
            dtTestValue.Columns.Add("tear_strengh_die_B_0h", typeof(float)); //F
            dtTestValue.Columns.Add("tensile_strengh_0h", typeof(float)); //G
            dtTestValue.Columns.Add("elongation_0h", typeof(float)); //H
            dtTestValue.Columns.Add("plasticity_0h", typeof(float)); //I
            dtTestValue.Columns.Add("plasticity_150_5h", typeof(float));  //K
            dtTestValue.Columns.Add("tc90", typeof(float)); //W
            dtTestValue.Columns.Add("change_plasticity_150_5h", typeof(float)); //L
            dtTestValue.Columns.Add("density_0h", typeof(float)); //M
        }

        private void AddData2ComboBox(ComboBox cbx, string data)
        {
            cbx.Items.Add(data);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Nhập file thông tin test nguyên vật liệu 输入文件测试信息";
                fileDialog.DefaultExt = "Excel";
                fileDialog.Filter = "Excel files|*.xlsx;*.xls";
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = false;
                fileDialog.InitialDirectory = "C:\\";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = String.Empty;
                    var list_process = Win32Processes.GetProcessesLockingFile(fileDialog.FileName);
                    foreach (var item in list_process)
                    {
                        item.Kill();
                    }
                    IWorkbook workbook;
                    using (var fs = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        if (Path.GetExtension(fileName).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                        {
                            workbook = new HSSFWorkbook(fs); // old Excel 97-2003
                        }
                        else
                        {
                            workbook = new XSSFWorkbook(fs); // new Excel 2007+
                        }
                    }
                    for (int i = 0; i < workbook.NumberOfSheets; i++)
                    {
                        string sheetName = workbook.GetSheetName(i);
                        AddData2ComboBox(cbxChooseDataSheet, sheetName);
                    }
                    workbook.Dispose();
                    fileName = fileDialog.FileName;
                    CTMessageBox.Show("Nhập file thành công, hãy cài đặt sheet tương ứng!\r\n文件导入成功，请安装相应的电子表格！", "Thông báo 通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message);
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            if (dtTestValue != null && dtTestValue.Rows.Count > 0)
            {
                List<HTVQAReportVariables> listReport = new List<HTVQAReportVariables>();
                for (int i = 0; i < dtTestValue.Rows.Count; i++)
                {
                    HTVQAReportVariables reportVariables = new HTVQAReportVariables();
                    //dtTestValue = new DataTable();
                    //dtTestValue.Columns.Add("lot_code", typeof(string)); //B
                    //dtTestValue.Columns.Add("hardness_0h", typeof(float)); //C
                    //dtTestValue.Columns.Add("hardness_200C_4h", typeof(float)); //D
                    //dtTestValue.Columns.Add("tear_strengh_die_B_0h", typeof(float)); //F
                    //dtTestValue.Columns.Add("tensile_strengh_0h", typeof(float)); //G
                    //dtTestValue.Columns.Add("elongation_0h", typeof(float)); //H
                    //dtTestValue.Columns.Add("plasticity_0h", typeof(float)); //I
                    //dtTestValue.Columns.Add("plasticity_150_5h", typeof(float));  //K
                    //dtTestValue.Columns.Add("tc90", typeof(float)); //W
                    //dtTestValue.Columns.Add("change_plasticity_150_5h", typeof(float)); //L
                    //dtTestValue.Columns.Add("density_0h", typeof(float)); //M
                    reportVariables.lot_code = dtTestValue.Rows[i]["lot_code"].ToString();
                    reportVariables.hardness_0h = float.Parse(dtTestValue.Rows[i]["hardness_0h"].ToString());
                    reportVariables.hardness_200C_4h = float.Parse(dtTestValue.Rows[i]["hardness_200C_4h"].ToString());
                    reportVariables.tear_strengh_die_B_0h = float.Parse(dtTestValue.Rows[i]["tear_strengh_die_B_0h"].ToString());
                    reportVariables.tensile_strengh_0h = float.Parse(dtTestValue.Rows[i]["tensile_strengh_0h"].ToString());
                    reportVariables.elongation_0h = float.Parse(dtTestValue.Rows[i]["elongation_0h"].ToString());
                    reportVariables.plasticity_0h = float.Parse(dtTestValue.Rows[i]["plasticity_0h"].ToString());
                    reportVariables.plasticity_150_5h = float.Parse(dtTestValue.Rows[i]["plasticity_150_5h"].ToString());
                    reportVariables.tc90 = float.Parse(dtTestValue.Rows[i]["tc90"].ToString());
                    reportVariables.change_plasticity_150_5h = float.Parse(dtTestValue.Rows[i]["change_plasticity_150_5h"].ToString());
                    reportVariables.density_0h = float.Parse(dtTestValue.Rows[i]["density_0h"].ToString());

                    listReport.Add(reportVariables);
                }
                ExcelSave.SaveExcel_HTVQAReport(listReport, txbReportTitle.Texts.Trim());

                cbxChooseDataSheet.Items.Clear();
                txbReportTitle.Texts = string.Empty;
                label1.Focus();

            }
            else
            {
                CTMessageBox.Show("Chưa nhập file dữ liệu hoặc không có dữ liệu khi đọc. Vui lòng kiểm tra lại dữ liệu và thanh thời gian lọc!\r\n尚未输入数据文件，也没有阅读时没有数据。请检查数据和过滤时间栏！", "Cảnh báo 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxChooseDataSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                if (dtTestValue != null)
                {
                    dtTestValue.Clear();
                }
                string dataSheetName = cbxChooseDataSheet.Text;
                LoadingDialog loading = new LoadingDialog();
                int countRow = 0;

                try
                {
                    var list_process = Win32Processes.GetProcessesLockingFile(fileName);
                    foreach (var item in list_process)
                    {
                        item.Kill();
                    }
                    InitAllTable();
                    Thread backgroundThreadSetTestData = new Thread(new ThreadStart(() =>
                    {
                        try
                        {
                            IWorkbook workbook;
                            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                            {
                                if (Path.GetExtension(fileName).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                                {
                                    workbook = new HSSFWorkbook(fs); // old Excel 97-2003
                                }
                                else
                                {
                                    workbook = new XSSFWorkbook(fs); // new Excel 2007+
                                }
                            }

                            IFormulaEvaluator evaluator = workbook.GetCreationHelper().CreateFormulaEvaluator();

                            ISheet sheet = workbook.GetSheet(dataSheetName);
                            if (sheet == null)
                                throw new Exception("Worksheet not found");

                            int i = 7; // NPOI is 0-based (row 8 in Excel)
                            DateTime dateSearchStart = dtpDateIn.Value;
                            DateTime dateSearchStop = dtpDateOut.Value;

                            while (true)
                            {
                                IRow row = sheet.GetRow(i);
                                if (row == null || row.GetCell(0) == null || string.IsNullOrWhiteSpace(row.GetCell(0).ToString()))
                                    break; // End when first column is empty

                                if (!DateTime.TryParse(row.GetCell(0).ToString(), out DateTime testDate))
                                    throw new Exception($"Invalid date at row {i + 1}");

                                if (dateSearchStart <= testDate && testDate <= dateSearchStop)
                                {
                                    // Columns that must have data (C, D, F, G, H, I, K, W, L, M)
                                    int[] requiredCols = { 2, 3, 5, 6, 7, 8, 10, 22, 11, 12 };
                                    bool skipRow = false;

                                    foreach (int col in requiredCols)
                                    {
                                        if (IsCellEmpty(row.GetCell(col), evaluator))
                                        {
                                            skipRow = true;
                                            break;
                                        }
                                    }

                                    if (!skipRow)
                                    {
                                        string lotCode = row.GetCell(1)?.ToString() ?? "";

                                        float hardNess0h = ParseFloat(row.GetCell(2), "C", i, evaluator);
                                        float hardNess200C4h = ParseFloat(row.GetCell(3), "D", i, evaluator);
                                        float tearStrenghDieB0h = ParseFloat(row.GetCell(5), "F", i, evaluator);
                                        float tensileStrengh0h = ParseFloat(row.GetCell(6), "G", i, evaluator);
                                        float elonggation0h = ParseFloat(row.GetCell(7), "H", i, evaluator);
                                        float plasticity0h = ParseFloat(row.GetCell(8), "I", i, evaluator);
                                        float plasticity1505h = ParseFloat(row.GetCell(10), "K", i, evaluator);
                                        float tc90 = ParseFloat(row.GetCell(22), "W", i, evaluator);
                                        float changePlasticity1505h = ParseFloat(row.GetCell(11), "L", i, evaluator);
                                        float density0h = ParseFloat(row.GetCell(12), "M", i, evaluator);

                                        dtTestValue.Rows.Add(
                                            lotCode,
                                            hardNess0h,
                                            hardNess200C4h,
                                            tearStrenghDieB0h,
                                            tensileStrengh0h,
                                            elonggation0h,
                                            plasticity0h,
                                            plasticity1505h,
                                            tc90,
                                            changePlasticity1505h,
                                            density0h);

                                        countRow++;
                                    }
                                }
                                i++;
                            }

                            loading.BeginInvoke(new Action(() => loading.Close()));
                        }
                        catch (Exception)
                        {
                            loading.BeginInvoke(new Action(() => loading.Close()));
                            throw;
                        }
                    }));
                    backgroundThreadSetTestData.Start();
                    loading.ShowDialog();


                    if (countRow > 0)
                    {

                    }
                    else
                    {
                        dtTestValue.Clear();
                        throw new Exception("Không tìm thấy dữ liệu trong khoảng thời gian cần xuất hoặc trang tính bị trống!\r\n在出口期间找不到数据，否则珠宝是空的！");
                    }
                }
                catch (Exception ex)
                {
                    CTMessageBox.Show(ex.Message, "Cảnh báo 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng nhập file dữ liệu vào hệ thống.\r\n请在系统中输入数据文件。", "Cảnh báo 警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Helper: check if a cell is empty after evaluating formulas
        bool IsCellEmpty(ICell cell, IFormulaEvaluator evaluator)
        {
            if (cell == null) return true;

            if (cell.CellType == CellType.Formula)
            {
                var evaluated = evaluator.Evaluate(cell);
                if (evaluated == null) return true;

                if (evaluated.CellType == CellType.Numeric && evaluated.NumberValue != 0)
                    return false;
                if (evaluated.CellType == CellType.String && !string.IsNullOrWhiteSpace(evaluated.StringValue))
                    return false;

                return true;
            }
            else
            {
                return string.IsNullOrWhiteSpace(cell.ToString());
            }
        }

        // Helper: parse float values including formula results
        float ParseFloat(ICell cell, string colLetter, int rowIndex, IFormulaEvaluator evaluator)
        {
            if (cell == null) return 0;

            if (cell.CellType == CellType.Formula)
            {
                var evaluated = evaluator.Evaluate(cell);
                if (evaluated == null) return 0;

                if (evaluated.CellType == CellType.Numeric)
                    return (float)evaluated.NumberValue;
                if (evaluated.CellType == CellType.String &&
                    float.TryParse(evaluated.StringValue, out float fVal))
                    return fVal;

                return 0;
            }

            if (cell.CellType == CellType.Numeric)
                return (float)cell.NumericCellValue;

            if (!string.IsNullOrWhiteSpace(cell.ToString()) &&
                float.TryParse(cell.ToString(), out float value))
                return value;

            return 0;
        }
    }
}