using ClosedXML.Excel;
using com.sun.media.sound;
using DocumentFormat.OpenXml.Packaging;
using javax.accessibility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.Properties;
using techlink_new_all_in_one.View.CustomControl;
using FSExcel = Spire.Xls;

namespace techlink_new_all_in_one
{
    public partial class EmployeeSalaryMainView : Form
    {
        //Fields
        private DataTable dtTimeKeeping;
        private DataTable dtBasicSalary;
        private DataTable dtUpdate;
        private DataTable dtKPI;
        private DataTable dtLate;
        private DataTable dtPeriod;
        private DataTable dtBirthdayBonus;
        private DataTable dtHRBonus;
        private DataTable dtPCCCBonus;

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
            dtTimeKeeping.Columns.Add("emp_name", typeof(string));
            dtTimeKeeping.Columns.Add("emp_department", typeof(string));
            dtTimeKeeping.Columns.Add("annual_leave", typeof(double));
            dtTimeKeeping.Columns.Add("annual_leave4h", typeof(int));
            dtTimeKeeping.Columns.Add("annual_leave5h", typeof(int));
            dtTimeKeeping.Columns.Add("annual_leave8h", typeof(int));
            dtTimeKeeping.Columns.Add("annual_leave10h", typeof(int));
            dtTimeKeeping.Columns.Add("total_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("total_workdate", typeof(double));
            dtTimeKeeping.Columns.Add("actual_workdate", typeof(double));
            dtTimeKeeping.Columns.Add("100_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("130_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("150_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("200_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("210_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("270_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("300_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("390_timekeep", typeof(double));
            dtTimeKeeping.Columns.Add("currentTime", typeof(string));
            dtTimeKeeping.Columns.Add("saturday_leave", typeof(double));

            dtBasicSalary = new DataTable();
            dtBasicSalary.Columns.Add("emp_code", typeof(string));
            dtBasicSalary.Columns.Add("position", typeof(string));
            dtBasicSalary.Columns.Add("v_position", typeof(string));
            dtBasicSalary.Columns.Add("basic_salary", typeof(double)); // Lương cơ bản
            dtBasicSalary.Columns.Add("position_allowance", typeof(double)); // PC chức vụ
            dtBasicSalary.Columns.Add("skill_allowance", typeof(double)); // PC kỹ năng
            dtBasicSalary.Columns.Add("language_allowance", typeof(double)); // PC ngôn ngữ
            dtBasicSalary.Columns.Add("seniority_allowance", typeof(double)); // PC thâm niên
            dtBasicSalary.Columns.Add("traffic_allowance", typeof(double)); // PC giao thông
            dtBasicSalary.Columns.Add("rental_allowance", typeof(double)); // PC nhà trọ
            dtBasicSalary.Columns.Add("telephone_fee", typeof(double)); // Tiền điện thoại
            dtBasicSalary.Columns.Add("child_support_allowance", typeof(double)); // PC nuôi con nhỏ
            dtBasicSalary.Columns.Add("fire_prevention_and_safety_allowances", typeof(double)); // PC PCCC và an toàn
            dtBasicSalary.Columns.Add("other_bonuses", typeof(double)); // Tiền thưởng khác

            dtUpdate = new DataTable();
            dtUpdate.Columns.Add("emp_code", typeof(string));
            dtUpdate.Columns.Add("annual_leave", typeof(double));
            dtUpdate.Columns.Add("resignation", typeof(double));
            dtUpdate.Columns.Add("salary_update", typeof(double));
            dtUpdate.Columns.Add("contractual_compensation", typeof(double));

            dtKPI = new DataTable();
            dtKPI.Columns.Add("emp_code", typeof(string));
            dtKPI.Columns.Add("kpi_bonus", typeof(double));
            dtKPI.Columns.Add("productivity_bonus", typeof(double));
            dtKPI.Columns.Add("container_close_allowance", typeof(double));
            dtKPI.Columns.Add("job_bonus", typeof(double));
            dtKPI.Columns.Add("productivity_manage_bonus", typeof(double));

            dtLate = new DataTable();
            dtLate.Columns.Add("emp_code", typeof(string));
            dtLate.Columns.Add("late_fine", typeof(double));

            dtPeriod = new DataTable();
            dtPeriod.Columns.Add("emp_code", typeof(string));
            dtPeriod.Columns.Add("period_bonus", typeof(double));

            dtBirthdayBonus = new DataTable();
            dtBirthdayBonus.Columns.Add("emp_code", typeof(string));
            dtBirthdayBonus.Columns.Add("birthday_bonus", typeof(double));

            dtHRBonus = new DataTable();
            dtHRBonus.Columns.Add("emp_code", typeof(string));
            dtHRBonus.Columns.Add("HR_bonus", typeof(double));

            dtPCCCBonus = new DataTable();
            dtPCCCBonus.Columns.Add("emp_code", typeof(string));
            dtPCCCBonus.Columns.Add("pccc_bonus", typeof(double));
        }

        private void BasicSalaryGet()
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
                                string bs_position = basicSalaryWorksheet.Cell("U" + i).Value.ToString();
                                string bs_v_position = basicSalaryWorksheet.Cell("AF" + i).Value.ToString();
                                double bs_result, bs_basic_salary = 0,
                                bs_position_allowance = 0,
                                bs_skill_allowance = 0,
                                bs_language_allowance = 0,
                                bs_seniority_allowance = 0,
                                bs_traffic_allowance = 0,
                                bs_rental_allowance = 0,
                                bs_telephone_fee = 0,
                                bs_child_support_allowance = 0,
                                bs_fire_prevention_and_safety_allowances = 0,
                                bs_other_bonuses = 0;

                                string exMsg = "Không thể chuyển đổi lương của \"" + bs_emp_code + "\". Vui lòng kiểm tra file dữ liệu!\r\n\"" + bs_emp_code + "\"的工资不能转换。请检查数据文件！";

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("D" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("D" + i).Value.ToString(), out bs_result))
                                    bs_basic_salary = bs_result;
                                else
                                    bs_basic_salary = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("E" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("E" + i).Value.ToString(), out bs_result))
                                    bs_position_allowance = bs_result;
                                else
                                    bs_position_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("K" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("K" + i).Value.ToString(), out bs_result))
                                    bs_skill_allowance = bs_result;
                                else
                                    bs_skill_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("N" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("N" + i).Value.ToString(), out bs_result))
                                    bs_language_allowance = bs_result;
                                else
                                    bs_language_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("F" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("F" + i).Value.ToString(), out bs_result))
                                    bs_seniority_allowance = bs_result;
                                else
                                    bs_seniority_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("G" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("G" + i).Value.ToString(), out bs_result))
                                    bs_traffic_allowance = bs_result;
                                else
                                    bs_traffic_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("H" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("H" + i).Value.ToString(), out bs_result))
                                    bs_rental_allowance = bs_result;
                                else
                                    bs_rental_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("O" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("O" + i).Value.ToString(), out bs_result))
                                    bs_telephone_fee = bs_result;
                                else
                                    bs_telephone_fee = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("P" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("P" + i).Value.ToString(), out bs_result))
                                    bs_child_support_allowance = bs_result;
                                else
                                    bs_child_support_allowance = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("Q" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("Q" + i).Value.ToString(), out bs_result))
                                    bs_fire_prevention_and_safety_allowances = bs_result;
                                else
                                    bs_fire_prevention_and_safety_allowances = 0;

                                if (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("I" + i).Value.ToString()) && double.TryParse(basicSalaryWorksheet.Cell("I" + i).Value.ToString(), out bs_result))
                                    bs_other_bonuses = bs_result;
                                else
                                    bs_other_bonuses = 0;

                                dtBasicSalary.Rows.Add(bs_emp_code,
                                    bs_position,
                                    bs_v_position,
                                    bs_basic_salary,
                                    bs_position_allowance,
                                    bs_skill_allowance,
                                    bs_language_allowance,
                                    bs_seniority_allowance,
                                    bs_traffic_allowance,
                                    bs_rental_allowance,
                                    bs_telephone_fee,
                                    bs_child_support_allowance,
                                    bs_fire_prevention_and_safety_allowances,
                                    bs_other_bonuses);
                                count++;
                                i++;
                            } while (!String.IsNullOrEmpty(basicSalaryWorksheet.Cell("A" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetBaseSalary.Start();
                    loading.ShowDialog();
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

        private void GetUpdateSheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename) && !String.IsNullOrEmpty(cbxChooseUpdateInfo.Text))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet updateSheet = workbook.Worksheet(cbxChooseUpdateInfo.Text);
                    Thread backgroundThreadSetUpdate = new Thread(new ThreadStart(() =>
                    {
                        if (updateSheet != null)
                        {
                            int i = 3;
                            dtUpdate.Clear();
                            do
                            {
                                string ud_emp_code = updateSheet.Cell("B" + i).Value.ToString();
                                double bs_result, ud_annual_leave = 0,
                                ud_resignation = 0,
                                ud_salary_update = 0,
                                ud_contractual_compensation = 0;

                                var annual_leave_cell = updateSheet.Cell("F" + i);
                                if (!String.IsNullOrEmpty(annual_leave_cell.CachedValue.ToString()) && double.TryParse(annual_leave_cell.CachedValue.ToString(), out bs_result))
                                    ud_annual_leave = bs_result;
                                else
                                    ud_annual_leave = 0;

                                var resignation_cell = updateSheet.Cell("G" + i);
                                if (!String.IsNullOrEmpty(resignation_cell.CachedValue.ToString()) && double.TryParse(resignation_cell.CachedValue.ToString(), out bs_result))
                                    ud_resignation = bs_result;
                                else
                                    ud_resignation = 0;

                                var salary_update_cell = updateSheet.Cell("H" + i);
                                if (!String.IsNullOrEmpty(salary_update_cell.CachedValue.ToString()) && double.TryParse(salary_update_cell.CachedValue.ToString(), out bs_result))
                                    ud_salary_update = bs_result;
                                else
                                    ud_salary_update = 0;

                                var contractual_compensation_cell = updateSheet.Cell("I" + i);
                                if (!String.IsNullOrEmpty(contractual_compensation_cell.CachedValue.ToString()) && double.TryParse(contractual_compensation_cell.CachedValue.ToString(), out bs_result))
                                    ud_contractual_compensation = bs_result;
                                else
                                    ud_contractual_compensation = 0;

                                dtUpdate.Rows.Add(ud_emp_code,
                                    ud_annual_leave,
                                    ud_resignation,
                                    ud_salary_update,
                                    ud_contractual_compensation);
                                i++;
                            } while (!String.IsNullOrEmpty(updateSheet.Cell("B" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetUpdate.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
            else
            {
                CTMessageBox.Show("Chưa có thông tin cập nhật！");
            }
        }

        private void GetKPISheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename) && !String.IsNullOrEmpty(cbxChooseKPI.Text))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet kpiSheet = workbook.Worksheet(cbxChooseKPI.Text);
                    Thread backgroundThreadSetKPI = new Thread(new ThreadStart(() =>
                    {
                        if (kpiSheet != null)
                        {
                            int i = 3;
                            dtKPI.Clear();
                            do
                            {
                                string kpi_emp_code = kpiSheet.Cell("A" + i).Value.ToString();
                                double bs_result, kpi_kpi = 0,
                                kpi_productivity_bonus = 0,
                                kpi_container_close_allowance = 0,
                                kpi_job_bonus = 0,
                                kpi_productivity_manage_bonus = 0;

                                var kpi_cell = kpiSheet.Cell("F" + i);
                                if (!String.IsNullOrEmpty(kpi_cell.CachedValue.ToString()) && double.TryParse(kpi_cell.CachedValue.ToString(), out bs_result))
                                    kpi_kpi = bs_result;
                                else
                                    kpi_kpi = 0;

                                var productivity_bonus_cell = kpiSheet.Cell("E" + i);
                                if (!String.IsNullOrEmpty(productivity_bonus_cell.CachedValue.ToString()) && double.TryParse(productivity_bonus_cell.CachedValue.ToString(), out bs_result))
                                    kpi_productivity_bonus = bs_result;
                                else
                                    kpi_productivity_bonus = 0;

                                var container_close_allowance_cell = kpiSheet.Cell("C" + i);
                                if (!String.IsNullOrEmpty(container_close_allowance_cell.CachedValue.ToString()) && double.TryParse(container_close_allowance_cell.CachedValue.ToString(), out bs_result))
                                    kpi_container_close_allowance = bs_result;
                                else
                                    kpi_container_close_allowance = 0;

                                var job_bonus_cell = kpiSheet.Cell("D" + i);
                                if (!String.IsNullOrEmpty(job_bonus_cell.CachedValue.ToString()) && double.TryParse(job_bonus_cell.CachedValue.ToString(), out bs_result))
                                    kpi_job_bonus = bs_result;
                                else
                                    kpi_job_bonus = 0;

                                var productivity_manage_bonus_cell = kpiSheet.Cell("G" + i);
                                if (!String.IsNullOrEmpty(productivity_manage_bonus_cell.CachedValue.ToString()) && double.TryParse(productivity_manage_bonus_cell.CachedValue.ToString(), out bs_result))
                                    kpi_productivity_manage_bonus = bs_result;
                                else
                                    kpi_productivity_manage_bonus = 0;

                                dtKPI.Rows.Add(kpi_emp_code,
                                    kpi_kpi,
                                    kpi_productivity_bonus,
                                    kpi_container_close_allowance,
                                    kpi_job_bonus,
                                    kpi_productivity_manage_bonus);
                                i++;
                            } while (!String.IsNullOrEmpty(kpiSheet.Cell("A" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetKPI.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
            else
            {
                CTMessageBox.Show("Chưa có thông tin KPI！");
            }
        }

        private void GetLateSheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet lateFineSheet = workbook.Worksheet(cbxLateFineInfo.Text);
                    Thread backgroundThreadSetLateFine = new Thread(new ThreadStart(() =>
                    {
                        if (lateFineSheet != null)
                        {
                            int i = 2;
                            dtLate.Clear();
                            do
                            {
                                string late_emp_code = lateFineSheet.Cell("B" + i).Value.ToString();
                                double result, late_fine = 0;

                                var late_fine_cell = lateFineSheet.Cell("L" + i);
                                if (!String.IsNullOrEmpty(late_fine_cell.CachedValue.ToString()) && double.TryParse(late_fine_cell.CachedValue.ToString(), out result))
                                    late_fine = result;
                                else
                                    late_fine = 0;

                                dtLate.Rows.Add(late_emp_code,
                                    late_fine);
                                i++;
                            } while (!String.IsNullOrEmpty(lateFineSheet.Cell("B" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetLateFine.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
        }

        private void GetPeriodSheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet periodSheet = workbook.Worksheet(cbxPeriodBonus.Text);
                    Thread backgroundThreadSetPeriodBonus = new Thread(new ThreadStart(() =>
                    {
                        if (periodSheet != null)
                        {
                            int i = 4;
                            dtPeriod.Clear();
                            do
                            {
                                string period_emp_code = periodSheet.Cell("A" + i).Value.ToString();
                                double result, period_bonus = 0;

                                var period_cell = periodSheet.Cell("E" + i);
                                if (!String.IsNullOrEmpty(period_cell.CachedValue.ToString()) && double.TryParse(period_cell.CachedValue.ToString(), out result))
                                    period_bonus = result;
                                else
                                    period_bonus = 0;

                                dtPeriod.Rows.Add(period_emp_code,
                                    period_bonus);
                                i++;
                            } while (!String.IsNullOrEmpty(periodSheet.Cell("A" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetPeriodBonus.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
        }

        private void GetBirthdaySheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet birthdaySheet = workbook.Worksheet(cbxBirthdayBonus.Text);
                    Thread backgroundThreadSetBirthdayBonus = new Thread(new ThreadStart(() =>
                    {
                        if (birthdaySheet != null)
                        {
                            int i = 3;
                            dtHRBonus.Clear();
                            do
                            {
                                string birthday_emp_code = birthdaySheet.Cell("B" + i).Value.ToString();
                                double result, birthday_bonus = 0;

                                var birthday_bonus_cell = birthdaySheet.Cell("G" + i);
                                if (!String.IsNullOrEmpty(birthday_bonus_cell.CachedValue.ToString()) && double.TryParse(birthday_bonus_cell.CachedValue.ToString(), out result))
                                    birthday_bonus = result;
                                else
                                    birthday_bonus = 0;

                                dtBirthdayBonus.Rows.Add(birthday_emp_code,
                                    birthday_bonus);
                                i++;
                            } while (!String.IsNullOrEmpty(birthdaySheet.Cell("B" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetBirthdayBonus.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
        }

        private void GetHRBonusSheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet hrBonusSheet = workbook.Worksheet(cbxHRBonus.Text);
                    Thread backgroundThreadSetHRBonus = new Thread(new ThreadStart(() =>
                    {
                        if (hrBonusSheet != null)
                        {
                            int i = 3;
                            dtHRBonus.Clear();
                            do
                            {
                                string hr_emp_code = hrBonusSheet.Cell("B" + i).Value.ToString();
                                double result, hr_bonus = 0;

                                var hr_cell = hrBonusSheet.Cell("H" + i);
                                if (!String.IsNullOrEmpty(hr_cell.CachedValue.ToString()) && double.TryParse(hr_cell.CachedValue.ToString(), out result))
                                    hr_bonus = result;
                                else
                                    hr_bonus = 0;

                                dtHRBonus.Rows.Add(hr_emp_code,
                                    hr_bonus);
                                i++;
                            } while (!String.IsNullOrEmpty(hrBonusSheet.Cell("B" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetHRBonus.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
        }

        private void GetPCCCSheet()
        {
            if (!String.IsNullOrEmpty(Settings.Default.salaryFilename))
            {
                XLWorkbook workbook = new XLWorkbook(Settings.Default.salaryFilename);
                LoadingDialog loading = new LoadingDialog();
                try
                {
                    IXLWorksheet pcccBonusSheet = workbook.Worksheet(cbxPCCC.Text);
                    Thread backgroundThreadSetPCCCBonus = new Thread(new ThreadStart(() =>
                    {
                        if (pcccBonusSheet != null)
                        {
                            int i = 3;
                            dtPCCCBonus.Clear();
                            do
                            {
                                string pccc_emp_code = pcccBonusSheet.Cell("A" + i).Value.ToString();
                                double result, pccc_bonus = 0;

                                var pccc_cell = pcccBonusSheet.Cell("E" + i);
                                if (!String.IsNullOrEmpty(pccc_cell.CachedValue.ToString()) && double.TryParse(pccc_cell.CachedValue.ToString(), out result))
                                    pccc_bonus = result;
                                else
                                    pccc_bonus = 0;

                                dtPCCCBonus.Rows.Add(pccc_emp_code,
                                    pccc_bonus);
                                i++;
                            } while (!String.IsNullOrEmpty(pcccBonusSheet.Cell("A" + i).Value.ToString()));
                        }
                        loading.BeginInvoke(new Action(() => loading.Close()));
                    }));
                    backgroundThreadSetPCCCBonus.Start();
                    loading.ShowDialog();
                }
                catch (Exception ex)
                {
                    loading.BeginInvoke(new Action(() => loading.Close()));
                    CTMessageBox.Show(ex.Message);
                }
            }
        }

        static int GetWorkHoursInMonth(int year, int month)
        {
            int totalHours = 0;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DayOfWeek dow = new DateTime(year, month, day).DayOfWeek;

                if (dow >= DayOfWeek.Monday && dow <= DayOfWeek.Thursday)
                {
                    totalHours += 10;
                }
                else if (dow == DayOfWeek.Friday)
                {
                    totalHours += 8;
                }
            }

            return totalHours;
        }

        static int GetWorkDayInMonth(DateTime date)
        {
            int workDayCount = 0;

            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DayOfWeek dow = new DateTime(date.Year, date.Month, day).DayOfWeek;

                if (dow >= DayOfWeek.Monday && dow <= DayOfWeek.Friday)
                {
                    workDayCount++;
                }
            }

            return workDayCount;
        }
        private void SetSalaryCalculationData()
        {
            BasicSalaryGet();
            if (!string.IsNullOrEmpty(cbxChooseUpdateInfo.Text))
                GetUpdateSheet();
            if (!string.IsNullOrEmpty(cbxChooseKPI.Text))
                GetKPISheet();
            if (!string.IsNullOrEmpty(cbxLateFineInfo.Text))
                GetLateSheet();
            if (!string.IsNullOrEmpty(cbxPeriodBonus.Text))
                GetPeriodSheet();
            if (!string.IsNullOrEmpty(cbxBirthdayBonus.Text))
                GetBirthdaySheet();
            if (!string.IsNullOrEmpty(cbxHRBonus.Text))
                GetHRBonusSheet();
            if (!string.IsNullOrEmpty(cbxPCCC.Text))
                GetPCCCSheet();
            //Lấy thông tin thưởng phạt, hoàn thuế
            if (dtBasicSalary.Rows.Count > 0 && dtTimeKeeping.Rows.Count > 0)
            {
                List<EmployeeSalary> listEmpSalary = new List<EmployeeSalary>();
                for (int i = 0; i < dtTimeKeeping.Rows.Count; i++)
                {
                    EmployeeSalary es = new EmployeeSalary();
                    string empCode = dtTimeKeeping.Rows[i]["emp_code"].ToString();
                    es.MaSo = empCode;
                    es.Ten = dtTimeKeeping.Rows[i]["emp_name"].ToString();
                    es.BoPhan = dtTimeKeeping.Rows[i]["emp_department"].ToString();

                    var matchedRows = dtBasicSalary.AsEnumerable()
.Where(row => row.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));

                    foreach (var row in matchedRows)
                    {
                        double result,
                                annual_leave = 0,
                                total_timekeep = 0,
                                total_workdate = 0,
                                actual_workdate = 0,
                                timekeep100 = 0,
                                timekeep130 = 0,
                                timekeep150 = 0,
                                timekeep200 = 0,
                                timekeep210 = 0,
                                timekeep270 = 0,
                                timekeep300 = 0,
                                timekeep390 = 0,
                                saturday_leave = 0;
                        int altime, al4h = 0, al5h = 0, al8h = 0, al10h = 0, total_worker_workdate = 0;
                        string currentTime;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["annual_leave"].ToString(), out result))
                            annual_leave = result;

                        if (int.TryParse(dtTimeKeeping.Rows[i]["annual_leave4h"].ToString(), out altime))
                            al4h = altime;
                        if (int.TryParse(dtTimeKeeping.Rows[i]["annual_leave5h"].ToString(), out altime))
                            al5h = altime;
                        if (int.TryParse(dtTimeKeeping.Rows[i]["annual_leave8h"].ToString(), out altime))
                            al8h = altime;
                        if (int.TryParse(dtTimeKeeping.Rows[i]["annual_leave10h"].ToString(), out altime))
                            al10h = altime;

                        if (double.TryParse(dtTimeKeeping.Rows[i]["total_timekeep"].ToString(), out result))
                            total_timekeep = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["total_workdate"].ToString(), out result))
                            total_workdate = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["actual_workdate"].ToString(), out result))
                            actual_workdate = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["100_timekeep"].ToString(), out result))
                            timekeep100 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["130_timekeep"].ToString(), out result))
                            timekeep130 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["150_timekeep"].ToString(), out result))
                            timekeep150 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["200_timekeep"].ToString(), out result))
                            timekeep200 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["210_timekeep"].ToString(), out result))
                            timekeep210 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["270_timekeep"].ToString(), out result))
                            timekeep270 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["300_timekeep"].ToString(), out result))
                            timekeep300 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["390_timekeep"].ToString(), out result))
                            timekeep390 = result;
                        if (double.TryParse(dtTimeKeeping.Rows[i]["saturday_leave"].ToString(), out result))
                            saturday_leave = result;
                        currentTime = dtTimeKeeping.Rows[i]["currentTime"].ToString();
                        es.SoNgayLamViec = actual_workdate + saturday_leave;
                        es.PhepNam = annual_leave;
                        es.Gio100 = timekeep100;
                        es.Gio130 = timekeep130;
                        es.Gio150 = timekeep150;
                        es.Gio200 = timekeep200;
                        es.Gio210 = timekeep210;
                        es.Gio270 = timekeep270;
                        es.Gio300 = timekeep300;

                        bool isOT = false;
                        if (es.Gio130 > 0 || es.Gio150 > 0 || es.Gio200 > 0 || es.Gio210 > 0 || es.Gio270 > 0 || es.Gio300 > 0 || es.Gio390 > 0)
                            isOT = true;

                        // Extract year and month using DateTime.ParseExact
                        DateTime date = DateTime.ParseExact(currentTime, "yyyy年MM月", CultureInfo.InvariantCulture);
                        if (es.BoPhan.Trim() == "Bếp 厨房" || es.BoPhan.Trim() == "Tạp Vụ 清洁工")
                        {
                            es.SoNgayChamCong = total_workdate;
                        }
                        else if (row["position"].ToString().Contains("副课长") || !isOT || row["v_position"].ToString().Contains("Văn phòng"))
                        {

                            es.SoNgayChamCong = total_workdate;
                        }
                        else
                        {
                            es.SoNgayChamCong = GetWorkDayInMonth(date);
                        }

                        if (double.TryParse(row["basic_salary"].ToString(), out double basicSalary))
                        {
                            es.LuongCB = basicSalary;
                        }
                        else
                        {
                            es.LuongCB = 0;
                        }
                        if (String.IsNullOrEmpty(row["position_allowance"].ToString()) || row["position_allowance"].ToString().Contains('-'))
                            es.PCChucVu = 0;
                        else
                            es.PCChucVu = double.Parse(row["position_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["skill_allowance"].ToString()) || row["skill_allowance"].ToString().Contains('-'))
                            es.PCKyNang = 0;
                        else
                            es.PCKyNang = double.Parse(row["skill_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["language_allowance"].ToString()) || row["language_allowance"].ToString().Contains('-'))
                            es.PCNgonNgu = 0;
                        else
                            es.PCNgonNgu = double.Parse(row["language_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["seniority_allowance"].ToString()) || row["seniority_allowance"].ToString().Contains('-'))
                            es.PCThamNien = 0;
                        else
                            es.PCThamNien = double.Parse(row["seniority_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["traffic_allowance"].ToString()) || row["traffic_allowance"].ToString().Contains('-'))
                            es.PCGiaoThong = 0;
                        else
                            es.PCGiaoThong = double.Parse(row["traffic_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["rental_allowance"].ToString()) || row["rental_allowance"].ToString().Contains('-'))
                            es.PCNhaTro = 0;
                        else
                            es.PCNhaTro = double.Parse(row["rental_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["telephone_fee"].ToString()) || row["telephone_fee"].ToString().Contains('-'))
                            es.TienDienThoai = 0;
                        else
                            es.TienDienThoai = double.Parse(row["telephone_fee"].ToString());

                        if (String.IsNullOrEmpty(row["child_support_allowance"].ToString()) || row["child_support_allowance"].ToString().Contains('-'))
                            es.PCConNho = 0;
                        else
                            es.PCConNho = double.Parse(row["child_support_allowance"].ToString());

                        if (String.IsNullOrEmpty(row["other_bonuses"].ToString()) || row["other_bonuses"].ToString().Contains('-'))
                            es.TienThuong = 0;
                        else
                            es.TienThuong = double.Parse(row["other_bonuses"].ToString());


                        es.TongLuong = es.LuongCB + es.PCChucVu + es.PCNgonNgu + es.PCThamNien
                            + es.PCGiaoThong + es.PCNhaTro + es.TienDienThoai + es.PCKyNang
                            + es.PCConNho + es.TienThuong;


                        // Extract year and month using DateTime.ParseExact
                        total_worker_workdate = GetWorkHoursInMonth(date.Year, date.Month);

                        int baseHour = 0;
                        if (total_worker_workdate > 208)
                        {
                            baseHour = 208;
                        }
                        else
                        {
                            baseHour = total_worker_workdate;
                        }

                        double baseSum = es.LuongCB + es.PCChucVu + es.PCKyNang + es.PCThamNien;

                        if (es.BoPhan.Trim() == "Bếp 厨房" || es.BoPhan.Trim() == "Tạp Vụ 清洁工")
                        {
                            es.Luong100 = ((baseSum / es.SoNgayChamCong / 8) * es.Gio100)
                                + ((baseSum / es.SoNgayChamCong) * es.PhepNam);
                            es.Luong130 = (baseSum / es.SoNgayChamCong / 8 * 1.3) * es.Gio130;
                            //Lương 150% trở lên thì cố định 208 giờ công 8 giờ 1 ngày chia ra là 26 ngày thay vì lấy ngày công chuẩn
                            es.Luong150 = (baseSum / 26 / 8 * 1.5) * es.Gio150;
                            es.Luong200 = (baseSum / 26 / 8 * 2) * es.Gio200;
                            es.Luong210 = (baseSum / 26 / 8 * 2.1) * es.Gio210;
                            es.Luong270 = (baseSum / 26 / 8 * 2.7) * es.Gio270;
                            es.Luong300 = (baseSum / 26 / 8 * 3) * es.Gio300;
                            es.Luong390 = (baseSum / 26 / 8 * 3.9) * es.Gio390;

                            es.TTTongLuong = es.Luong100 + es.Luong130;
                            es.LuongOT = es.Luong150 + es.Luong200 + es.Luong210 + es.Luong270 + es.Luong300 + es.Luong390;
                            es.TTPCThamNien = 0;
                            es.TTPCChucVu = 0;
                        }
                        else if (row["position"].ToString().Contains("副课长") || !isOT || row["v_position"].ToString().Contains("Văn phòng"))
                        {
                            es.TTTongLuong = es.LuongCB / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                            es.TTPCThamNien = es.PCThamNien / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                            es.TTPCChucVu = es.PCChucVu / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                        }
                        else
                        {
                            es.Luong100 = ((baseSum / baseHour) * es.Gio100) + (baseSum / baseHour) * (al10h * 10) + (baseSum / baseHour) * (al8h * 8);
                            es.Luong130 = (baseSum / baseHour * 1.3) * es.Gio130;
                            es.Luong150 = (baseSum / 208 * 1.5) * es.Gio150;
                            es.Luong200 = (baseSum / 208 * 2) * es.Gio200;
                            es.Luong270 = (baseSum / 208 * 2.7) * es.Gio270;
                            es.Luong300 = (baseSum / 208 * 3) * es.Gio300;
                            es.Luong390 = (baseSum / 208 * 3.9) * es.Gio390;

                            es.TTTongLuong = es.Luong100 + es.Luong130;
                            es.LuongOT = es.Luong150 + es.Luong200 + es.Luong210 + es.Luong270 + es.Luong300 + es.Luong390;
                            es.TTPCThamNien = 0;
                            es.TTPCChucVu = 0;
                        }


                        if (es.SoNgayLamViec + es.PhepNam >= es.SoNgayChamCong)
                            es.TTChuyenCan = 200000;
                        else if (es.SoNgayLamViec + es.PhepNam >= es.SoNgayChamCong - 0.5)
                            es.TTChuyenCan = 150000;
                        else if (es.SoNgayLamViec + es.PhepNam >= es.SoNgayChamCong - 1)
                            es.TTChuyenCan = 100000;
                        //Chỉnh lại chuyên cần theo thực tế

                        es.TTPCNgonNgu = es.PCNgonNgu / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                        es.TTPCGiaoThong = es.PCGiaoThong / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                        es.TTPCNhaTro = es.PCNhaTro / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                        es.TTTienDienThoai = es.TienDienThoai / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam);
                        if (es.SoNgayLamViec > 1)
                            es.TTPCConNho = es.PCConNho;
                        else
                            es.TTPCConNho = 0;

                        es.TTTienThuong = es.TienThuong / es.SoNgayChamCong * (es.SoNgayLamViec + es.PhepNam); //Cần tính lại ngày đi làm thực tế


                        var matchedRowsUpdate = dtUpdate.AsEnumerable()
.Where(rowUpdate => rowUpdate.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowUpdate in matchedRowsUpdate)
                            {
                                if(es.ThanhToanPhepNam == 0)
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["annual_leave"].ToString()) || rowUpdate["annual_leave"].ToString().Contains('-'))
                                        es.ThanhToanPhepNam = 0;
                                    else
                                        es.ThanhToanPhepNam = double.Parse(rowUpdate["annual_leave"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["annual_leave"].ToString()) || rowUpdate["annual_leave"].ToString().Contains('-'))
                                        es.ThanhToanPhepNam += 0;
                                    else
                                        es.ThanhToanPhepNam += double.Parse(rowUpdate["annual_leave"].ToString());
                                }

                                if (es.TroCapThoiViec == 0)
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["resignation"].ToString()) || rowUpdate["resignation"].ToString().Contains('-'))
                                        es.TroCapThoiViec = 0;
                                    else
                                        es.TroCapThoiViec = double.Parse(rowUpdate["resignation"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["resignation"].ToString()) || rowUpdate["resignation"].ToString().Contains('-'))
                                        es.TroCapThoiViec += 0;
                                    else
                                        es.TroCapThoiViec += double.Parse(rowUpdate["resignation"].ToString());
                                }

                                if (es.DieuChinhLuong == 0)
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["salary_update"].ToString()) || rowUpdate["salary_update"].ToString().Contains('-'))
                                        es.DieuChinhLuong = 0;
                                    else
                                        es.DieuChinhLuong = double.Parse(rowUpdate["salary_update"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["salary_update"].ToString()) || rowUpdate["salary_update"].ToString().Contains('-'))
                                        es.DieuChinhLuong += 0;
                                    else
                                        es.DieuChinhLuong += double.Parse(rowUpdate["salary_update"].ToString());
                                }

                                if (es.BoiThuongHopDong == 0)
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["contractual_compensation"].ToString()) || rowUpdate["contractual_compensation"].ToString().Contains('-'))
                                        es.BoiThuongHopDong = 0;
                                    else
                                        es.BoiThuongHopDong = double.Parse(rowUpdate["contractual_compensation"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowUpdate["contractual_compensation"].ToString()) || rowUpdate["contractual_compensation"].ToString().Contains('-'))
                                        es.BoiThuongHopDong += 0;
                                    else
                                        es.BoiThuongHopDong += double.Parse(rowUpdate["contractual_compensation"].ToString());
                                }
                            }
                        }

                        //dtKPI = new DataTable();
                        //dtUpdate.Columns.Add("emp_code", typeof(string));
                        //dtUpdate.Columns.Add("kpi", typeof(double));
                        //dtUpdate.Columns.Add("productivity_bonus", typeof(double));
                        //dtUpdate.Columns.Add("container_close_allowance", typeof(double));
                        //dtUpdate.Columns.Add("job_bonus", typeof(double));

                        var matchedRowsKPI = dtKPI.AsEnumerable()
.Where(rowKPI => rowKPI.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowKPI in matchedRowsKPI)
                            {
                                if (es.ThuongDatMucTieu == 0)
                                {
                                    if (String.IsNullOrEmpty(rowKPI["kpi_bonus"].ToString()) || rowKPI["kpi_bonus"].ToString().Contains('-'))
                                        es.ThuongDatMucTieu = 0;
                                    else
                                        es.ThuongDatMucTieu = double.Parse(rowKPI["kpi_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowKPI["kpi_bonus"].ToString()) || rowKPI["kpi_bonus"].ToString().Contains('-'))
                                        es.ThuongDatMucTieu += 0;
                                    else
                                        es.ThuongDatMucTieu += double.Parse(rowKPI["kpi_bonus"].ToString());
                                }

                                if (es.ThuongNangSuat == 0)
                                {
                                    if (String.IsNullOrEmpty(rowKPI["productivity_bonus"].ToString()) || rowKPI["productivity_bonus"].ToString().Contains('-'))
                                        es.ThuongNangSuat = 0;
                                    else
                                        es.ThuongNangSuat = double.Parse(rowKPI["productivity_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowKPI["productivity_bonus"].ToString()) || rowKPI["productivity_bonus"].ToString().Contains('-'))
                                        es.ThuongNangSuat += 0;
                                    else
                                        es.ThuongNangSuat += double.Parse(rowKPI["productivity_bonus"].ToString());
                                }

                                if (es.PCDongCont == 0)
                                {
                                    if (String.IsNullOrEmpty(rowKPI["container_close_allowance"].ToString()) || rowKPI["container_close_allowance"].ToString().Contains('-'))
                                        es.PCDongCont = 0;
                                    else
                                        es.PCDongCont = double.Parse(rowKPI["container_close_allowance"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowKPI["container_close_allowance"].ToString()) || rowKPI["container_close_allowance"].ToString().Contains('-'))
                                        es.PCDongCont += 0;
                                    else
                                        es.PCDongCont += double.Parse(rowKPI["container_close_allowance"].ToString());
                                }

                                if (es.PCMoiTruong == 0)
                                {
                                    if (String.IsNullOrEmpty(rowKPI["job_bonus"].ToString()) || rowKPI["job_bonus"].ToString().Contains('-'))
                                        es.PCMoiTruong = 0;
                                    else
                                        es.PCMoiTruong = double.Parse(rowKPI["job_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowKPI["job_bonus"].ToString()) || rowKPI["job_bonus"].ToString().Contains('-'))
                                        es.PCMoiTruong += 0;
                                    else
                                        es.PCMoiTruong += double.Parse(rowKPI["job_bonus"].ToString());
                                }

                                if (es.PCQuanLyNangSuat == 0)
                                {
                                    if (String.IsNullOrEmpty(rowKPI["productivity_manage_bonus"].ToString()) || rowKPI["productivity_manage_bonus"].ToString().Contains('-'))
                                        es.PCQuanLyNangSuat = 0;
                                    else
                                        es.PCQuanLyNangSuat = double.Parse(rowKPI["productivity_manage_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowKPI["productivity_manage_bonus"].ToString()) || rowKPI["productivity_manage_bonus"].ToString().Contains('-'))
                                        es.PCQuanLyNangSuat += 0;
                                    else
                                        es.PCQuanLyNangSuat += double.Parse(rowKPI["productivity_manage_bonus"].ToString());
                                }
                            }
                        }


                        var matchedLate = dtLate.AsEnumerable()
.Where(rowLate => rowLate.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowLate in matchedLate)
                            {
                                if (es.DiTreXemCam == 0)
                                {
                                    if (String.IsNullOrEmpty(rowLate["late_fine"].ToString()) || rowLate["late_fine"].ToString().Contains('-'))
                                        es.DiTreXemCam = 0;
                                    else
                                    {
                                        double lateFine = double.Parse(rowLate["late_fine"].ToString());
                                        if (lateFine <= es.TTChuyenCan)
                                        {
                                            es.DiTreXemCam = lateFine * -1;
                                        }
                                        else if (lateFine > es.TTChuyenCan)
                                        {
                                            es.DiTreXemCam = es.TTChuyenCan * -1;
                                        }
                                        else
                                            es.DiTreXemCam = 0;
                                    }
                                }
                                else
                                {
                                    double lateFine = double.Parse(rowLate["late_fine"].ToString());
                                    if (lateFine <= es.TTChuyenCan)
                                    {
                                        es.DiTreXemCam += lateFine * -1;
                                    }
                                    else if (lateFine > es.TTChuyenCan)
                                    {
                                        es.DiTreXemCam += es.TTChuyenCan * -1;
                                    }
                                }
                            }
                        }

                        var matchedPeriod = dtPeriod.AsEnumerable()
.Where(rowPeriod => rowPeriod.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowPeriod in matchedPeriod)
                            {
                                if(es.PCHanhKinh == 0)
                                {
                                    if (String.IsNullOrEmpty(rowPeriod["period_bonus"].ToString()) || rowPeriod["period_bonus"].ToString().Contains('-'))
                                        es.PCHanhKinh = 0;
                                    else
                                        es.PCHanhKinh = double.Parse(rowPeriod["period_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowPeriod["period_bonus"].ToString()) || rowPeriod["period_bonus"].ToString().Contains('-'))
                                        es.PCHanhKinh += 0;
                                    else
                                        es.PCHanhKinh += double.Parse(rowPeriod["period_bonus"].ToString());
                                }
                            }
                        }

                        var matchedBirthday = dtBirthdayBonus.AsEnumerable()
.Where(rowBirthday => rowBirthday.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowBirthday in matchedBirthday)
                            {
                                if (es.PCSinhNhat == 0)
                                {
                                    if (String.IsNullOrEmpty(rowBirthday["birthday_bonus"].ToString()) || rowBirthday["birthday_bonus"].ToString().Contains('-'))
                                        es.PCSinhNhat = 0;
                                    else
                                        es.PCSinhNhat = double.Parse(rowBirthday["birthday_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowBirthday["birthday_bonus"].ToString()) || rowBirthday["birthday_bonus"].ToString().Contains('-'))
                                        es.PCSinhNhat += 0;
                                    else
                                        es.PCSinhNhat += double.Parse(rowBirthday["birthday_bonus"].ToString());
                                }
                                   
                            }
                        }

                        var matchedHR = dtHRBonus.AsEnumerable()
.Where(rowHR => rowHR.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowHR in matchedHR)
                            {
                                if (es.ThuongPhatNhanSu == 0)
                                {
                                    if (String.IsNullOrEmpty(rowHR["HR_bonus"].ToString()) || rowHR["HR_bonus"].ToString().Contains('-'))
                                        es.ThuongPhatNhanSu = 0;
                                    else
                                        es.ThuongPhatNhanSu = double.Parse(rowHR["HR_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowHR["HR_bonus"].ToString()) || rowHR["HR_bonus"].ToString().Contains('-'))
                                        es.ThuongPhatNhanSu += 0;
                                    else
                                        es.ThuongPhatNhanSu += double.Parse(rowHR["HR_bonus"].ToString());
                                }
                            }
                        }

                        if (es.SoNgayLamViec + es.PhepNam >= es.SoNgayChamCong)
                            es.KhauTru = 0;
                        else
                        {
                            if (es.BoPhan.Trim() == "Bếp 厨房" || es.BoPhan.Trim() == "Tạp Vụ 清洁工")
                            {
                                es.KhauTru = -1 * ((es.ThuongNangSuat / es.SoNgayChamCong) * (es.SoNgayChamCong - es.SoNgayLamViec - es.PhepNam));
                            }
                            else
                            {
                                es.KhauTru = -1 * ((es.ThuongNangSuat + es.PCQuanLyNangSuat / es.SoNgayChamCong) * (es.SoNgayChamCong - es.SoNgayLamViec - es.PhepNam));
                            }
                        }

                        var matchedRowsPCCC = dtPCCCBonus.AsEnumerable()
.Where(rowPCCC => rowPCCC.ItemArray.Any(field => field.ToString().Trim().Equals(empCode)));
                        {
                            foreach (var rowPCCC in matchedRowsPCCC)
                            {
                                if (es.PCPCCC == 0)
                                {
                                    if (String.IsNullOrEmpty(rowPCCC["pccc_bonus"].ToString()) || rowPCCC["pccc_bonus"].ToString().Contains('-'))
                                        es.PCPCCC = 0;
                                    else
                                        es.PCPCCC = double.Parse(rowPCCC["pccc_bonus"].ToString());
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(rowPCCC["pccc_bonus"].ToString()) || rowPCCC["pccc_bonus"].ToString().Contains('-'))
                                        es.PCPCCC += 0;
                                    else
                                        es.PCPCCC += double.Parse(rowPCCC["pccc_bonus"].ToString());
                                }
                            }
                        }


                        if (es.BoPhan.Trim() == "Bếp 厨房" || es.BoPhan.Trim() == "Tạp Vụ 清洁工")
                        {
                            es.KhauTru = -1 * ((es.ThuongNangSuat / es.SoNgayChamCong) * (es.SoNgayChamCong - es.SoNgayLamViec - es.PhepNam));
                        }
                        else if (row["position"].ToString().Contains("副课长") || !isOT || row["v_position"].ToString().Contains("Văn phòng"))
                        {
                            es.KhauTru = -1 * ((es.ThuongNangSuat + es.PCQuanLyNangSuat / es.SoNgayChamCong) * (es.SoNgayChamCong - es.SoNgayLamViec - es.PhepNam));
                        }
                        else
                        {
                            es.KhauTru = -1 * ((es.ThuongNangSuat / es.SoNgayChamCong) * (es.SoNgayChamCong - es.SoNgayLamViec - es.PhepNam));
                        }
                        es.LuongNhanDuoc = es.TTTongLuong + es.LuongOT + es.TTChuyenCan + es.TTPCChucVu + es.TTPCNgonNgu + es.TTPCThamNien + es.TTPCGiaoThong
    + es.TTPCNhaTro + es.TTPCConNho + es.TTTienThuong + es.TTTienDienThoai + es.ThuongDatMucTieu + es.ThuongNangSuat + es.PCQuanLyNangSuat
    + es.ThuongPhatNhanSu + es.KhauTru + es.PCDongCont + es.PCMoiTruong + es.DiTreXemCam + es.ThanhToanPhepNam + es.TroCapThoiViec + es.DieuChinhLuong
    + es.PCPCCC + es.PCSinhNhat + es.PCHanhKinh + es.BoiThuongHopDong;


                        listEmpSalary.Add(es);
                    }

                }
                ExcelSave.SaveExcel_AccountantEmployeeSalary(listEmpSalary);
            }
            //}
            //catch (Exception ex)
            //{
            //    CTMessageBox.Show("Lỗi trong quá trình tính toán! Vui lòng thử lại.\nChi tiết lỗi : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                        AddData2ComboBox(cbxLateFineInfo, worksheet.Name);
                        AddData2ComboBox(cbxPeriodBonus, worksheet.Name);
                        AddData2ComboBox(cbxBirthdayBonus, worksheet.Name);
                        AddData2ComboBox(cbxHRBonus, worksheet.Name);
                        AddData2ComboBox(cbxPCCC, worksheet.Name);
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

        string GetValueByColumnName(IXLWorksheet ws, string colName, int headerRow, int dataRow)
        {
            int colNum = ws.Row(headerRow)
                           .CellsUsed()
                           .First(c => c.GetString().Trim() == colName)
                           .Address.ColumnNumber;
            return ws.Cell(dataRow, colNum).GetString();
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
                                    string empCode = GetValueByColumnName(worksheet, "工号", 2, i);
                                    string empName = GetValueByColumnName(worksheet, "姓名", 2, i);
                                    string empDepartment = GetValueByColumnName(worksheet, "部门", 2, i);
                                    string currentTime = GetValueByColumnName(worksheet, "周期", 2, i);
                                    double result,
                                    annual_leave = 0,
                                    aL4h = 0,
                                    aL5h = 0,
                                    aL8h = 0,
                                    aL10h = 0,
                                    total_timekeep = 0,
                                    total_workdate = 0,
                                    actual_workdate = 0,
                                    timekeep100 = 0,
                                    timekeep130 = 0,
                                    timekeep150 = 0,
                                    timekeep200 = 0,
                                    timekeep210 = 0,
                                    timekeep270 = 0,
                                    timekeep300 = 0,
                                    timekeep390 = 0,
                                    saturday_leave = 0;

                                    string exMsg = "Không thể chuyển đổi số giờ công của nhân viên \"" + empCode + "\". Vui lòng kiểm tra file chấm công!\r\n员工\"" + empCode + "\"的工时无法转换。请检查您的考勤档案！";
                                    if (double.TryParse(GetValueByColumnName(worksheet, "应出勤天数", 2, i), out result))
                                    {
                                        total_workdate = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "实出勤天数", 2, i), out result))
                                    {
                                        actual_workdate = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时合计", 2, i), out result))
                                    {
                                        total_timekeep = result;
                                    }


                                    if (double.TryParse(GetValueByColumnName(worksheet, "Phép năm年假天数", 2, i), out result))
                                    {
                                        annual_leave = result;
                                    }
                                    aL4h = worksheet.Row(i).Cells().Count(cell => cell.Value.ToString().Contains("Phép n?m年假4H"));
                                    aL5h = worksheet.Row(i).Cells().Count(cell => cell.Value.ToString().Contains("Phép n?m年假5H"));
                                    aL8h = worksheet.Row(i).Cells().Count(cell => cell.Value.ToString().Contains("Phép n?m年假8H"));
                                    aL10h = worksheet.Row(i).Cells().Count(cell => cell.Value.ToString().Contains("Phép n?m年假10H"));

                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x100%)", 2, i), out result))
                                    {
                                        timekeep100 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x130%)", 2, i), out result))
                                    {
                                        timekeep130 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x150%)", 2, i), out result))
                                    {
                                        timekeep150 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x200%)", 2, i), out result))
                                    {
                                        timekeep200 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x210%)", 2, i), out result))
                                    {
                                        timekeep210 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x270%)", 2, i), out result))
                                    {
                                        timekeep270 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x300%)", 2, i), out result))
                                    {
                                        timekeep300 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "工时(x390%)", 2, i), out result))
                                    {
                                        timekeep390 = result;
                                    }
                                    if (double.TryParse(GetValueByColumnName(worksheet, "Phép thứ bảy (TX)周六有薪天数", 2, i), out result))
                                    {
                                        saturday_leave = result;
                                    }

                                    dtTimeKeeping.Rows.Add(empCode,
                                        empName,
                                        empDepartment,
                                        annual_leave,
                                        aL4h,
                                        aL5h,
                                        aL8h,
                                        aL10h,
                                        total_timekeep,
                                        total_workdate,
                                        actual_workdate,
                                        timekeep100,
                                        timekeep130,
                                        timekeep150,
                                        timekeep200,
                                        timekeep210,
                                        timekeep270,
                                        timekeep300,
                                        timekeep390,
                                        currentTime,
                                        saturday_leave);
                                    count++;
                                    i++;
                                } while (!String.IsNullOrEmpty(GetValueByColumnName(worksheet, "工号", 2, i)));

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
                                CTMessageBox.Show("Đã nhập dữ liệu chấm công của " + count + " nhân viên!\r\n录入" + count + "名员工的考勤数据！", "Thông báo 通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            SetSalaryCalculationData();
        }
    }
}
