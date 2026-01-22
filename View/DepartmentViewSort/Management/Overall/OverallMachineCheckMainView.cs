using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{ 
    public partial class OverallMachineCheckMainView : Form
    {
        //Fields
        System.Windows.Forms.Timer tmrCallBgWorker;
        BackgroundWorker bgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        object lockObject = new object();

        DataTableCollection tables;
        SqlDeviceMaintenance sqlDevice = new SqlDeviceMaintenance();
        public OverallMachineCheckMainView()
        {
            InitializeComponent();
        }

        //Methods
        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        #region BackgroundWorker
        private void LoadBackgroundWorker()
        {   // this timer calls bgWorker again and again after regular intervals
            tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
            tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
            tmrCallBgWorker.Interval = 5000; //3600000 = 1 hour/60000 = 1 minute

            // this is our worker
            bgWorker = new BackgroundWorker();

            // work happens in this method
            bgWorker.DoWork += new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged += BW_ProgressChanged;
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            bgWorker.WorkerReportsProgress = true;
        }
        private void timer_nextRun_Tick(object sender, EventArgs e)
        {
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    // if bgworker is not busy the call the worker
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
            else
            {
                // as the bgworker is busy we will start a timer that will try to call the bgworker again after some time
                tmrEnsureWorkerGetsCalled = new System.Threading.Timer(new TimerCallback(tmrEnsureWorkerGetsCalled_Callback), null, 0, 10);
            }
        }
        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            LoadInsightData();
        }
        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e) { }
        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { }
        void tmrEnsureWorkerGetsCalled_Callback(object obj)
        {
            // this timer was started as the bgworker was busy before now it will try to call the bgworker again
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
                tmrEnsureWorkerGetsCalled = null;
            }
        }
        #endregion

        private void LoadAllDeviceData(DataGridView dataGridView, bool isCompact)
        {
            DataTable dt = new DataTable();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from property_info");
            sqlDevice.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);

            if (dataGridView.InvokeRequired)
            {
                MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadAllDeviceData(dataGridView, isCompact));
                dataGridView.Invoke(AssignMethodToControl);
            }
            else
            {
                dataGridView.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    dataGridView.DataSource = dt;
                    dataGridView.Columns["code"].HeaderText = "Mã thiết bị\r\n设备代码";
                    dataGridView.Columns["name"].HeaderText = "Tên thiết bị\r\n设备名称";
                    dataGridView.Columns["detail"].HeaderText = "Chi tiết\r\n细节";
                    dataGridView.Columns["department_name"].HeaderText = "Bộ phận\r\n部分";
                    dataGridView.Columns["manager"].HeaderText = "Người quản lý\r\n经理";

                    dataGridView.Columns["uuid"].Visible = false;
                    dataGridView.Columns["check_type_id"].Visible = false;
                    if (isCompact)
                    {
                        dataGridView.Columns["check_date"].Visible = false;
                        dataGridView.Columns["check_result"].Visible = false;
                        dataGridView.Columns["maintenance_date"].Visible = false;
                        dataGridView.Columns["update_date"].Visible = false;
                    }
                    else
                    {
                        dataGridView.Columns["check_date"].HeaderText = "Ngày kiểm tra\r\n检查日期";
                        dataGridView.Columns["check_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                        dataGridView.Columns["check_result"].HeaderText = "Kết quả kiểm tra\r\n测试结果";
                        dataGridView.Columns["check_result"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                        dataGridView.Columns["maintenance_date"].HeaderText = "Ngày bảo trì\r\n维护日期";
                        dataGridView.Columns["maintenance_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                        dataGridView.Columns["update_date"].HeaderText = "Ngày cập nhật\r\n更新日期";
                        dataGridView.Columns["update_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    }
                    dataGridView.Columns["check_history"].Visible = false;
                    dataGridView.Columns["maintenance_history"].Visible = false;

                    dataGridView.ClearSelection();
                }
            }
        }

        private void LoadInsightData()
        {
            try
            {
                string totalDeviceQty = sqlDevice.sqlExecuteScalarString("select COUNT(uuid) from property_info");
                string passCheck = sqlDevice.sqlExecuteScalarString("select COUNT(uuid) from property_info where check_result = 'OK'");
                string notPassCheck = sqlDevice.sqlExecuteScalarString("select COUNT(uuid) from property_info where check_result = 'NG'");
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                string maintenanceDevice = sqlDevice.sqlExecuteScalarString("select COUNT(uuid) from property_info where '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' <= maintenance_date and '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "' >= maintenance_date");
                string notCheckedDevice = sqlDevice.sqlExecuteScalarString("select COUNT(uuid) from property_info where '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' > check_date or check_date IS NULL");

                //SL tổng
                if (lbTotalDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbTotalDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(totalDeviceQty))
                        lbTotalDeviceQty.Text = "0";
                    else
                        lbTotalDeviceQty.Text = totalDeviceQty;
                }

                //SL đạt chất lượng
                if (lbPassCheckQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbPassCheckQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(passCheck))
                        lbPassCheckQty.Text = "0";
                    else
                        lbPassCheckQty.Text = passCheck;
                }

                //SL không đạt 
                if (lbNotPassCheckQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbNotPassCheckQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(notPassCheck))
                        lbNotPassCheckQty.Text = "0";
                    else
                        lbNotPassCheckQty.Text = notPassCheck;
                }

                

                //SL đã kiểm tra trong tháng
                if (lbMaintenanceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbMaintenanceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(maintenanceDevice))
                        lbMaintenanceQty.Text = "0";
                    else
                        lbMaintenanceQty.Text = maintenanceDevice;
                }

                //SL còn hạn
                if (lbCheckedDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbMaintenanceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (!string.IsNullOrEmpty(notCheckedDevice) && !string.IsNullOrEmpty(totalDeviceQty))
                        lbMaintenanceQty.Text = (Convert.ToInt32(totalDeviceQty) - Convert.ToInt32(notCheckedDevice)).ToString();
                    else
                        lbMaintenanceQty.Text = "0";
                }

                //SL chưa kiểm tra trong tháng
                if (lbNotCheckedDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbNotCheckedDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(notCheckedDevice))
                        lbNotCheckedDeviceQty.Text = "0";
                    else
                        lbNotCheckedDeviceQty.Text = notCheckedDevice;
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi khi lấy dữ liệu thống kê thiết bị!\r\n获取设备统计数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFastCheckData_Click(object sender, EventArgs e)
        {
            LoadAllDeviceData(dtgvShowDetailData, false);
        }

        private void OverallMachineCheckMainView_Load(object sender, EventArgs e)
        {
            LoadInsightData();
            LoadAllDeviceData(dtgvShowDetailData, false);
            LoadAllDeviceData(dtgvCheckDevice, true);

            LoadBackgroundWorker();
            tmrCallBgWorker.Start();
        }

        private void OverallMachineCheckMainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                tmrCallBgWorker.Stop();
                tmrCallBgWorker.Dispose();
            }
        }

        private void OverallMachineCheckMainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
            bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged -= BW_ProgressChanged;
            bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            GC.Collect();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            LoadAllDeviceData(dtgvCheckDevice, true);
        }

        private void btnPrintExistLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcelData(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error importing data: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportExcelData(string filePath)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // First worksheet
                int rowCount = worksheet.LastRowUsed().RowNumber();

                int insertedCount = 0;
                int updatedCount = 0;

                // Skip header row, start from row 2
                for (int row = 2; row <= rowCount; row++)
                {
                    try
                    {
                        // Read data from Excel using ClosedXML
                        var machineCode = worksheet.Cell(row, 5).Value.ToString();
                        var machineName = worksheet.Cell(row, 6).Value.ToString();
                        var machineDetail = worksheet.Cell(row, 7).Value.ToString();
                        var machineType = worksheet.Cell(row, 4).Value.ToString();
                        var machineDepartment = worksheet.Cell(row, 2).Value.ToString();
                        var machineManager = worksheet.Cell(row, 8).Value.ToString();

                        // Skip empty rows
                        if (string.IsNullOrWhiteSpace(machineCode))
                            continue;

                        // Check if machine code already exists
                        bool exists = CheckMachineCodeExists(machineCode);

                        if (exists)
                        {
                            // Update existing record
                            UpdateMachineRecord(machineCode, machineName, machineDetail, machineType, machineDepartment, machineManager);
                            updatedCount++;
                        }
                        else
                        {
                            // Insert new record
                            InsertMachineRecord(UUIDGenerator.getAscId(), machineCode, machineName, machineDetail, machineType, machineDepartment, machineManager);
                            insertedCount++;
                        }

                        // Update progress
                        Application.DoEvents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing row {row}: {ex.Message}", "Row Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show($"Import completed successfully!\n\nNew records inserted: {insertedCount}\nRecords updated: {updatedCount}",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckMachineCodeExists(string machineCode)
        {
            string query = "SELECT COUNT(*) FROM property_info WHERE code = '" + machineCode + "'";
            string result = sqlDevice.sqlExecuteScalarString(query);

            if (int.TryParse(result, out int count))
            {
                return count > 0;
            }
            return false;
        }

        private void InsertMachineRecord(string machineId, string machineCode, string machineName, string machineDetail, string machineType, string machineDepartment, string machineManager)
        {
            string query = $@"INSERT INTO property_info (uuid, code, name, detail, type, department_name, manager, check_type_id, check_date, check_history, check_result, maintenance_history, maintenance_date, update_date) 
                           VALUES ('{machineId}', '{machineCode}', N'{machineName}', N'{machineDetail}', '{machineType}', N'{machineDepartment}', N'{machineManager}', '', '', '', '', '', '', '')";

            sqlDevice.sqlExecuteNonQuery(query, "", "Error inserting machine record");
        }

        private void UpdateMachineRecord(string machineCode, string machineName, string machineDetail, string machineType, string machineDepartment, string machineManager)
        {
            string query = $@"UPDATE property_info 
                           SET name = '{machineName}',
                           detail = '{machineDetail}',
                           type = '{machineType}',
                           department_name = '{machineDepartment}',
                           manager = '{machineManager}',
                           WHERE code = '{machineCode}'";

            sqlDevice.sqlExecuteNonQuery(query, "", "Error updating machine record");
        }
    }
}
