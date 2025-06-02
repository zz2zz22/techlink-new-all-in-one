using ClosedXML.Excel;
using com.sun.media.sound;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.Properties;
using FSExcel = Spire.Xls;
using System.Threading;
using techlink_new_all_in_one.View.CustomControl;
using System.IO;
using DocumentFormat.OpenXml.Packaging;

namespace techlink_new_all_in_one
{
    public partial class EmployeeSalaryMainView : Form
    {
        //Fields
        private DataTable dtTimeKeeping;
        private DataTable dtBasicSalary;
        private DataTable dtUpdate;
        private DataTable dtKPI;
        private DataTable dtBonusOrWarning;
        private DataTable dtTaxes;

        private int totalTimeKeepEmployee = 0;
        public EmployeeSalaryMainView()
        {
            InitializeComponent();
        }

        private void AddData2ComboBox(ComboBox cbx, string data)
        {
            cbx.Items.Add(data);
        }

        private void InitAllTable()
        {
            dtTimeKeeping = new DataTable();
            dtTimeKeeping.Columns.Add("emp_code", typeof(string));
            dtTimeKeeping.Columns.Add("date_start", typeof(string));
            dtTimeKeeping.Columns.Add("date_end", typeof(string));
            dtTimeKeeping.Columns.Add("total_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("100_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("130_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("150_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("200_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("210_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("270_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("300_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("390_timekeep", typeof(double));

            dtBasicSalary = new DataTable();
            dtBasicSalary.Columns.Add("emp_code", typeof(string));
            dtBasicSalary.Columns.Add("emp_name", typeof(string));
            dtBasicSalary.Columns.Add("emp_chinese_name", typeof(string));
            dtBasicSalary.Columns.Add("position", typeof(string));
            dtBasicSalary.Columns.Add("bank_account", typeof(string));
            dtBasicSalary.Columns.Add("basic_salary", typeof(double)); // Lương cơ bản
            dtBasicSalary.Columns.Add("position_allowance", typeof(double)); // PC chức vụ
            dtBasicSalary.Columns.Add("responsibility_allowance", typeof(double)); // PC trách nhiệm
            dtBasicSalary.Columns.Add("language_allowance", typeof(double)); // PC ngôn ngữ
            dtBasicSalary.Columns.Add("seniority_allowance", typeof(double)); // PC thâm niên
            dtBasicSalary.Columns.Add("traffic_allowance", typeof(double)); // PC giao thông
            dtBasicSalary.Columns.Add("rental_allowance", typeof(double)); // PC nhà trọ
            dtBasicSalary.Columns.Add("telephone_fee", typeof(double)); // Tiền điện thoại
            dtBasicSalary.Columns.Add("child_support_allowance", typeof(double)); // PC nuôi con nhỏ
            dtBasicSalary.Columns.Add("fire_prevention_and_safety_allowances", typeof(double)); // PC PCCC và an toàn
            dtBasicSalary.Columns.Add("other_bonuses", typeof(double)); // Tiền thưởng khác
            dtBasicSalary.Columns.Add("total_salary", typeof(double));
        }

        private void SalaryCalculation()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename) && !String.IsNullOrEmpty(cbxChooseBasicInfoSheet.Text))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    int count = 0;
                    IXLWorksheet basicSalaryWorksheet = workbook.Worksheet(cbxChooseBasicInfoSheet.Text);
                    Thread backgroundThreadSetBaseSalary = new Thread(new ThreadStart(() =>
                    {
                        if (basicSalaryWorksheet != null)
                        {
                            int i = 4;
                            dtBasicSalary.Clear();
                            do
                            {
                                string bs_emp_code = basicSalaryWorksheet.Cell("A" + i).Value.ToString();
                                string bs_emp_name = basicSalaryWorksheet.Cell("B" + i).Value.ToString();
                                string bs_emp_chinese_name = basicSalaryWorksheet.Cell("T" + i).Value.ToString();
                                string bs_position = basicSalaryWorksheet.Cell("S" + i).Value.ToString();
                                string bs_bank_account = basicSalaryWorksheet.Cell("C" + i).Value.ToString();
                                double bs_result, bs_basic_salary = 0,
                                bs_position_allowance = 0,
                                bs_responsibility_allowance = 0,
                                bs_language_allowance = 0,
                                bs_seniority_allowance = 0,
                                bs_traffic_allowance = 0,
                                bs_rental_allowance = 0,
                                bs_telephone_fee = 0,
                                bs_child_support_allowance = 0,
                                bs_fire_prevention_and_safety_allowances = 0,
                                bs_other_bonuses = 0,
                                bs_total_salary = 0;

                                string exMsg = "Không thể chuyển đổi lương của \"" + bs_emp_code + "\". Vui lòng kiểm tra file dữ liệu!\r\n\"" + bs_emp_code + "\"的工资不能转换。请检查数据文件！";

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("D" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("D" + i).Value.ToString(), out bs_result))
                                    bs_basic_salary = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("E" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("E" + i).Value.ToString(), out bs_result))
                                    bs_position_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("J" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("J" + i).Value.ToString(), out bs_result))
                                    bs_responsibility_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("L" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("L" + i).Value.ToString(), out bs_result))
                                    bs_language_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("F" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("F" + i).Value.ToString(), out bs_result))
                                    bs_seniority_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("G" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("G" + i).Value.ToString(), out bs_result))
                                    bs_traffic_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("H" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("H" + i).Value.ToString(), out bs_result))
                                    bs_rental_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("M" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("M" + i).Value.ToString(), out bs_result))
                                    bs_telephone_fee = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("N" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("N" + i).Value.ToString(), out bs_result))
                                    bs_child_support_allowance = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("O" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("O" + i).Value.ToString(), out bs_result))
                                    bs_fire_prevention_and_safety_allowances = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("I" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("I" + i).Value.ToString(), out bs_result))
                                    bs_other_bonuses = bs_result;
                                else
                                    throw new Exception(exMsg);

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("P" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("P" + i).Value.ToString(), out bs_result))
                                    bs_total_salary = bs_result;
                                else
                                    throw new Exception(exMsg);

                                dtBasicSalary.Rows.Add(bs_emp_code,
                                    bs_emp_name,
                                    bs_emp_chinese_name,
                                    bs_position,
                                    bs_bank_account,
                                    bs_basic_salary,
                                    bs_position_allowance,
                                    bs_responsibility_allowance,
                                    bs_language_allowance,
                                    bs_seniority_allowance,
                                    bs_traffic_allowance,
                                    bs_telephone_fee,
                                    bs_child_support_allowance,
                                    bs_fire_prevention_and_safety_allowances,
                                    bs_other_bonuses,
                                    bs_total_salary);
                                count++;
                                i++;
                            } while (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("A" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetBaseSalary.Start();
                    loading.ShowDialog();

                    if (count < totalTimeKeepEmployee)
                    {
                        DialogResult dialogResult = CTMessageBox.Show("Có " + (totalTimeKeepEmployee - count) + " nhân viên không có thông tin lương cơ bản, bạn có muốn tiếp tục ?\r\n有 " + (totalTimeKeepEmployee - count) + " 名员工没有基本薪资信息，您要继续吗？", "Cảnh báo 警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SetSalaryCalculationData();
                        }
                    }
                    else if (count == totalTimeKeepEmployee)
                    {
                        SetSalaryCalculationData();
                    }
                    else if (count > totalTimeKeepEmployee)
                    {
                        DialogResult dialogResult = CTMessageBox.Show("Có " + (count - totalTimeKeepEmployee) + " nhân viên không có dữ liệu chấm công, bạn có muốn tiếp tục ?\r\n有 " + (count - totalTimeKeepEmployee) + " 名员工没有计时数据，您要继续吗？", "Cảnh báo 警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SetSalaryCalculationData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
            else
            {
                CTMessageBox.Show("Chưa có thông tin lương cơ bản!\r\n还没有基本工资信息！");
            }

        }

        private void SetSalaryCalculationData()
        {
            //Need to disscuss
        }

        private void btnImportSalaryBase_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Nhập file lương cơ bản 导入公式文件";
                fileDialog.DefaultExt = "Excel";
                fileDialog.Filter = "Excel files|*.xlsx;*.xls";
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = false;
                fileDialog.InitialDirectory = "C:\\";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var list_process = Win32Processes.GetProcessesLockingFile(fileDialog.FileName);
                    foreach (var item in list_process)
                    {
                        item.Kill();
                    }
                    XLWorkbook xlWorkBook = new XLWorkbook(fileDialog.FileName);
                    foreach (IXLWorksheet worksheet in xlWorkBook.Worksheets)
                    {
                        AddData2ComboBox(cbxChooseBasicInfoSheet, worksheet.Name);
                        AddData2ComboBox(cbxChooseUpdateInfo, worksheet.Name);
                        AddData2ComboBox(cbxChooseKPI, worksheet.Name);
                        AddData2ComboBox(cbxChooseBonus, worksheet.Name);
                        AddData2ComboBox(cbxChooseReturnTax, worksheet.Name);
                    }
                    xlWorkBook.Dispose();
                    Settings.Default.salaryFilename = fileDialog.FileName;
                    Settings.Default.Save();
                    CTMessageBox.Show("Nhập file thành công, hãy cài đặt sheet tương ứng!\r\n文件导入成功，请安装相应的电子表格！", "Thông báo 通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi nhập file 文件导入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeSalaryMainView_Load(object sender, EventArgs e)
        {
            InitAllTable();

            btnImportSalaryBase.ButtonText = "Nhập thông tin cơ bản\r\n输入基本信息";
            btnImportHRData.ButtonText = "Nhập thông tin chấm công\r\n输入出席信息";
        }

        private void btnImportHRData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Nhập file chấm công TongxiangEHR:";
            fileDialog.DefaultExt = "Excel";
            fileDialog.Filter = "Excel files|*.xlsx;*.xls";
            fileDialog.CheckPathExists = true;
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = "C:\\";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var list_process = Win32Processes.GetProcessesLockingFile(fileDialog.FileName);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                LoadingDialog loading = new LoadingDialog();
                Thread backgroundThreadGetTimekeepingData = new Thread(
                    new ThreadStart(() =>
                    {
                        XLWorkbook workbook = null;
                        try
                        {
                            bool isConverted = false;
                            string dataPath = fileDialog.FileName;
                            if (Path.GetExtension(fileDialog.FileName).Equals(".xls"))
                            {
                                dataPath = SubMethods.ConvertXlsToXLSX(fileDialog.FileName);
                                isConverted = true;
                            }
                            workbook = new XLWorkbook(dataPath);
                            IXLWorksheet worksheet = workbook.Worksheet(1);

                            if (worksheet != null)
                            {
                                int count = 0, i = 3; //Bắt đầu từ hàng thứ 3
                                dtTimeKeeping.Clear();
                                do
                                {
                                    string empCode = worksheet.Cell("F" + i).Value.ToString();
                                    string date_start = worksheet.Cell("D" + i).Value.ToString();
                                    string date_end = worksheet.Cell("E" + i).Value.ToString();
                                    double result,
                                    total_timekeep = 0,
                                    timekeep100 = 0,
                                    timekeep130 = 0,
                                    timekeep150 = 0,
                                    timekeep200 = 0,
                                    timekeep210 = 0,
                                    timekeep270 = 0,
                                    timekeep300 = 0,
                                    timekeep390 = 0;

                                    string exMsg = "Không thể chuyển đổi số giờ công của nhân viên \"" + empCode + "\". Vui lòng kiểm tra file chấm công!\r\n员工\"" + empCode + "\"的工时无法转换。请检查您的考勤档案！";
                                    if (double.TryParse(worksheet.Cell("BI" + i).Value.ToString(), out result))
                                    {
                                        total_timekeep = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BA" + i).Value.ToString(), out result))
                                    {
                                        timekeep100 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BB" + i).Value.ToString(), out result))
                                    {
                                        timekeep130 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BC" + i).Value.ToString(), out result))
                                    {
                                        timekeep150 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BD" + i).Value.ToString(), out result))
                                    {
                                        timekeep200 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BE" + i).Value.ToString(), out result))
                                    {
                                        timekeep210 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BF" + i).Value.ToString(), out result))
                                    {
                                        timekeep270 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BG" + i).Value.ToString(), out result))
                                    {
                                        timekeep300 = result;
                                    }
                                    if (double.TryParse(worksheet.Cell("BH" + i).Value.ToString(), out result))
                                    {
                                        timekeep390 = result;
                                    }

                                    dtTimeKeeping.Rows.Add(empCode,
                                        date_start,
                                        date_end,
                                        total_timekeep,
                                        timekeep100,
                                        timekeep130,
                                        timekeep150,
                                        timekeep200,
                                        timekeep210,
                                        timekeep270,
                                        timekeep300,
                                        timekeep390
                                        );
                                    count++;
                                    i++;
                                } while (!String.IsNullOrEmpty(worksheet.Cell("D" + i).Value.ToString()));

                                totalTimeKeepEmployee = count;

                                workbook.Dispose();
                                if (isConverted)
                                {
                                    try
                                    {
                                        // Check if file exists with its full path
                                        if (File.Exists(dataPath))
                                        {
                                            // If file found, delete it
                                            File.Delete(dataPath);
                                        }
                                    }
                                    catch (IOException ioExp)
                                    {
                                        CTMessageBox.Show(ioExp.Message);
                                    }
                                }
                                loading.BeginInvoke(new Action(() => loading.Close()));
                                CTMessageBox.Show("Đã nhập dữ liệu chấm công của " + count + " nhân viên!\r\n录入"+count+"名员工的考勤数据！", "Thông báo 通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (workbook != null)
                                workbook.Dispose();

                            totalTimeKeepEmployee = 0;

                            loading.BeginInvoke(new Action(() => loading.Close()));

                            CTMessageBox.Show(ex.Message, "Lỗi nhập file 文件导入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                backgroundThreadGetTimekeepingData.Start();
                loading.ShowDialog();
                
                if (totalTimeKeepEmployee > 0)
                    SalaryCalculation();
            }
        }
    }
}
