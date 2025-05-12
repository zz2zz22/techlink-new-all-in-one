using sun.java2d.cmm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainController.SubLogic.QRPrinterDevice;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class HSEDeviceManagementMainView : Form
    {
        //Fields
        System.Windows.Forms.Timer tmrCallBgWorker;
        BackgroundWorker bgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        object lockObject = new object();
        bool isMTFind2Filter, isBGRunning;
        SqlDeviceMaintenance sqlDevice = new SqlDeviceMaintenance();

        private int chooseIndex;

        //Constructor
        public HSEDeviceManagementMainView()
        {
            InitializeComponent();
        }

        //Methods
        private void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void GetLocationData(ComboBox cbx)
        {
            cbx.Items.Clear();
            string query = "select distinct device_location from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' order by device_location asc";
            sqlDevice.getComboBoxData(query, ref cbx);
        }
        private void GetManagerData(ComboBox cbx)
        {
            cbx.Items.Clear();
            string query = "select distinct device_manager from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' order by device_manager asc";
            sqlDevice.getComboBoxData(query, ref cbx);
        }

        private void LoadSearchDeviceData(ComboBox cbxLocation, ComboBox cbxManager, DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            StringBuilder stringBuilder = new StringBuilder();
            string location = cbxLocation.Text.Trim();
            string manager = cbxManager.Text.Trim();
            if (!string.IsNullOrEmpty(location) && !string.IsNullOrEmpty(manager))
            {
                stringBuilder.Append("select * from pccc_info where device_location = '" + location + "' and device_manager = '" + manager + "' and device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'");
            }
            else if (string.IsNullOrEmpty(location) && !string.IsNullOrEmpty(manager))
            {
                stringBuilder.Append("select * from pccc_info where device_manager = '" + manager + "' and device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'");
            }
            else if (!string.IsNullOrEmpty(location) && string.IsNullOrEmpty(manager))
            {
                stringBuilder.Append("select * from pccc_info where device_location = '" + location + "' and device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'");
            }
            else
            {
                stringBuilder.Append("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'");
            }
            sqlDevice.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);

            if (dataGridView.InvokeRequired)
            {
                MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadSearchDeviceData(cbxLocation, cbxManager, dataGridView));
                dataGridView.Invoke(AssignMethodToControl);
            }
            else
            {
                dataGridView.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    dataGridView.DataSource = dt;
                    dataGridView.Columns["device_uuid"].Visible = false;
                    dataGridView.Columns["device_type_uuid"].Visible = false;
                    dataGridView.Columns["device_group_uuid"].Visible = false;
                    dataGridView.Columns["maximum_extend_date"].Visible = false;
                    dataGridView.Columns["newest_maintenance_info"].Visible = false;
                    dataGridView.Columns["newest_check_info"].Visible = false;
                    dataGridView.Columns["installed_date"].Visible = false;
                    dataGridView.Columns["update_date"].Visible = false;

                    dataGridView.Columns["device_type_name"].HeaderText = "Loại thiết bị\r\n设备类型";
                    dataGridView.Columns["device_location"].HeaderText = "Vị trí lắp đặt\r\n安装位置";
                    dataGridView.Columns["device_manager"].HeaderText = "Người quản lý\r\n装置经理";
                    dataGridView.Columns["expire_date"].HeaderText = "Ngày hết hạn\r\n到期日";
                    dataGridView.Columns["expire_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dataGridView.Columns["newest_maintenance_date"].HeaderText = "Ngày bảo trì gần nhất\r\n最近一次维护日期";
                    dataGridView.Columns["newest_maintenance_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dataGridView.Columns["newest_check_date"].HeaderText = "Ngày kiểm tra gần nhất\r\n上次设备检查日期";
                    dataGridView.Columns["newest_check_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dataGridView.ClearSelection();
                }
                if (!isMTFind2Filter)
                {
                    cbxLocation.SelectedIndex = -1;
                    cbxManager.SelectedIndex = -1;
                }
            }
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

        #region Insight Methods
        private void InitDatagridviewData(DataTable importDT)
        {
            if (dtgvShowDetailData.InvokeRequired)
            {
                MethodInvoker AssignMethodToControl = new MethodInvoker(() => InitDatagridviewData(importDT));
                dtgvShowDetailData.Invoke(AssignMethodToControl);
            }
            else
            {
                dtgvShowDetailData.DataSource = null;
                if (importDT != null && importDT.Rows.Count > 0)
                {
                    dtgvShowDetailData.DataSource = importDT;
                    dtgvShowDetailData.Columns["device_uuid"].Visible = false;
                    dtgvShowDetailData.Columns["device_type_uuid"].Visible = false;
                    dtgvShowDetailData.Columns["device_group_uuid"].Visible = false;
                    dtgvShowDetailData.Columns["maximum_extend_date"].Visible = false;
                    dtgvShowDetailData.Columns["newest_maintenance_info"].Visible = false;
                    dtgvShowDetailData.Columns["newest_check_info"].Visible = false;
                    dtgvShowDetailData.Columns["installed_date"].Visible = false;
                    dtgvShowDetailData.Columns["update_date"].Visible = false;

                    dtgvShowDetailData.Columns["device_type_name"].HeaderText = "Loại thiết bị\r\n设备类型";
                    dtgvShowDetailData.Columns["device_location"].HeaderText = "Vị trí lắp đặt\r\n安装位置";
                    dtgvShowDetailData.Columns["device_manager"].HeaderText = "Người quản lý\r\n负责人员";
                    dtgvShowDetailData.Columns["expire_date"].HeaderText = "Ngày hết hạn\r\n到期日期";
                    dtgvShowDetailData.Columns["expire_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dtgvShowDetailData.Columns["newest_maintenance_date"].HeaderText = "Ngày bảo trì gần nhất\r\n最近一次维护日期";
                    dtgvShowDetailData.Columns["newest_maintenance_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dtgvShowDetailData.Columns["newest_check_date"].HeaderText = "Ngày kiểm tra gần nhất\r\n上次设备检查日期";

                    dtgvShowDetailData.ClearSelection();
                }
            }
        }
        private void LoadInsightData()
        {
            try
            {
                string totalDeviceQty = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'");
                string nearExpire = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and DATEADD(WEEK, -2, expire_date) < GETDATE() and expire_date > GETDATE()");
                string overExpire = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and expire_date < GETDATE()");
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                string checkedDevice = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' <= newest_check_date and '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "' >= newest_check_date");
                string notCheckedDevice = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where (device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' > newest_check_date) or (newest_check_date IS NULL and device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO')");
                string notHaveManager = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and device_manager IS NULL or device_manager like 'null'");

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

                //SL gần hết hạn
                if (lbNearExpDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbNearExpDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(nearExpire))
                        lbNearExpDeviceQty.Text = "0";
                    else
                        lbNearExpDeviceQty.Text = nearExpire;
                }

                //SL đã quá hạn
                if (lbOverExpDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbOverExpDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(overExpire))
                        lbOverExpDeviceQty.Text = "0";
                    else
                        lbOverExpDeviceQty.Text = overExpire;
                }

                //SL còn hạn
                if (lbValidDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbValidDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (!string.IsNullOrEmpty(nearExpire) && !string.IsNullOrEmpty(overExpire) && !string.IsNullOrEmpty(totalDeviceQty))
                        lbValidDeviceQty.Text = (Convert.ToInt32(totalDeviceQty) - (Convert.ToInt32(nearExpire) + Convert.ToInt32(overExpire))).ToString();
                    else
                        lbValidDeviceQty.Text = "0";
                }

                //SL đã kiểm tra trong tháng
                if (lbCheckedDeviceQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbCheckedDeviceQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(checkedDevice))
                        lbCheckedDeviceQty.Text = "0";
                    else
                        lbCheckedDeviceQty.Text = checkedDevice;
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

                //SL chưa có người quản lý
                if (lbNotHaveManagerQty.InvokeRequired)
                {
                    MethodInvoker AssignMethodToControl = new MethodInvoker(() => LoadInsightData());
                    lbNotHaveManagerQty.Invoke(AssignMethodToControl);
                }
                else
                {
                    if (string.IsNullOrEmpty(notHaveManager))
                        lbNotHaveManagerQty.Text = "0";
                    else
                        lbNotHaveManagerQty.Text = notHaveManager;
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi khi lấy dữ liệu thống kê thiết bị!\r\n获取设备统计数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private HSEDeviceInsightDetail getData(int i, DataTable data, int type)
        {
            HSEDeviceInsightDetail obj = new HSEDeviceInsightDetail();
            obj.data_type = type;
            obj.device_type = data.Rows[i]["device_type_name"].ToString();
            obj.device_location = data.Rows[i]["device_location"].ToString();
            obj.device_manager = data.Rows[i]["device_manager"].ToString();
            obj.install_date = data.Rows[i]["installed_date"].ToString();
            obj.expired_date = data.Rows[i]["expire_date"].ToString();
            obj.newest_maintenance_date = data.Rows[i]["newest_maintenance_date"].ToString();
            obj.newest_checked_date = data.Rows[i]["newest_check_date"].ToString();
            obj.check_status = sqlDevice.sqlExecuteScalarString("select check_overall_status from pccc_check_info where check_uuid = '"+ data.Rows[i]["newest_check_info"].ToString() +"'");
            obj.check_desc = sqlDevice.sqlExecuteScalarString("select check_description from pccc_check_info where check_uuid = '" + data.Rows[i]["newest_check_info"].ToString() +"'");
            obj.check_emp = sqlDevice.sqlExecuteScalarString("select check_employee from pccc_check_info where check_uuid = '" + data.Rows[i]["newest_check_info"].ToString() +"'");
            return obj;
        }

        private void GetTotalDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtTotalDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'", ref dtTotalDeviceData);
                if (detail != null)
                {
                    if (dtTotalDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtTotalDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtTotalDeviceData, 1));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtTotalDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetNearExpDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtNearExpDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and DATEADD(WEEK, -2, expire_date) < GETDATE() and expire_date > GETDATE() order by expire_date asc", ref dtNearExpDeviceData);
                if (detail != null)
                {
                    if (dtNearExpDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtNearExpDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtNearExpDeviceData, 2));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtNearExpDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetOverExpDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtOverExpDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and expire_date < GETDATE() order by expire_date asc", ref dtOverExpDeviceData);
                if (detail != null)
                {
                    if (dtOverExpDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtOverExpDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtOverExpDeviceData, 3));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtOverExpDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetValidDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtValidDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and DATEADD(WEEK, -2, expire_date) > GETDATE() and expire_date > GETDATE() order by expire_date asc", ref dtValidDeviceData);
                if (detail != null)
                {
                    if (dtValidDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtValidDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtValidDeviceData, 4));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtValidDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetCheckedDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtCheckedDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                DateTime now = DateTime.Now;
                if (chooseIndex == 1)
                {
                    now = DateTime.Now.AddMonths(-1);
                }
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' <= newest_check_date and '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "' >= newest_check_date order by newest_check_date desc", ref dtCheckedDeviceData);
                if (detail != null)
                {
                    if (dtCheckedDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtCheckedDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtCheckedDeviceData, 5));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtCheckedDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetNotCheckedDeviceData(List<HSEDeviceInsightDetail> detail)
        {
            DataTable dtNotCheckedDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                DateTime now = DateTime.Now;
                if (chooseIndex == 1)
                {
                    now = DateTime.Now.AddMonths(-1);
                }
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where (device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' > newest_check_date) or (newest_check_date IS NULL and device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO') order by newest_check_date asc", ref dtNotCheckedDeviceData);
                if (detail != null)
                {
                    if (dtNotCheckedDeviceData.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtNotCheckedDeviceData.Rows.Count; i++)
                        {
                            detail.Add(getData(i, dtNotCheckedDeviceData, 6));
                        }
                    }
                }
                else
                {
                    InitDatagridviewData(dtNotCheckedDeviceData);
                }
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        #endregion

        #region Setting Methods
        private void GetDeviceTypeData(ComboBox cbx)
        {
            DataTable dt = new DataTable();
            StringBuilder sqlGetTypeList = new StringBuilder();
            sqlGetTypeList.Append("select device_type_uuid, device_type_name from pccc_type_info where device_group_uuid = '6GL4FSYCUO0BNO'");
            sqlDevice.sqlDataAdapterFillDatatable(sqlGetTypeList.ToString(), ref dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = "device_type_name";
            cbx.ValueMember = "device_type_uuid";
            cbx.SelectedIndex = -1;
        }
        private void GetExistLocationData()
        {
            DataTable dt = new DataTable();
            string query = "select distinct device_location from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' order by device_location asc";
            sqlDevice.sqlDataAdapterFillDatatable(query, ref dt);
            dtgvShowExistLocation.DataSource = null;
            if (dt.Rows.Count > 0)
            {
                dtgvShowExistLocation.DataSource = dt;
                dtgvShowExistLocation.Columns["device_location"].HeaderText = "Vị trí đã được scan\r\n该位置已被扫描";
                dtgvShowExistLocation.ClearSelection();
            }
        }
        private void GetDeviceTypeDataToEdit()
        {
            DataTable dt = new DataTable();
            string query = "select device_type_uuid, device_type_name, maximum_exp_date from pccc_type_info where device_group_uuid = '6GL4FSYCUO0BNO' order by device_type_name asc";
            sqlDevice.sqlDataAdapterFillDatatable(query, ref dt);
            dtgvDeviceType.DataSource = null;
            if (dt.Rows.Count > 0)
            {
                dtgvDeviceType.DataSource = dt;
                dtgvDeviceType.Columns["device_type_uuid"].Visible = false;
                dtgvDeviceType.Columns["device_type_name"].HeaderText = "Loại thiết bị\r\n设备类型";
                dtgvDeviceType.Columns["maximum_exp_date"].HeaderText = "Thời hạn sử dụng tối đa\r\n最长保质期";
                dtgvDeviceType.ClearSelection();
            }
        }
        #endregion

        //Event Handler
        private void HSEDeviceManagementMainView_Load(object sender, EventArgs e)
        {
            btnSaveDetailExcel.ButtonText = "Xuất Excel thống kê\r\n导出Excel统计数据";
            btnFastCheckData.ButtonText = "Xem nhanh\r\n快速查看数据";
            btnPrintDeviceQR.ButtonText = "In tem thiết bị\r\n打印设备标签";
            btnDeleteDevice.ButtonText = "Xóa\r\n删除";
            btnPrintExistLocation.ButtonText = "In vị trí đã chọn\r\n打印所选位置";
            btnPrintNewLocation.ButtonText = "In vị trí mới\r\n打印新位置";
            btnPrintNewDeviceQR.ButtonText = "In tem thiết bị mới\r\n打印新设备标签";
            btnAddNewDeviceType.ButtonText = "Thêm mới loại\r\n添加新类别";
            btnEditDeviceTypeExp.ButtonText = "Chỉnh sửa thời hạn\r\n编辑截止日期";
            btnDeleteDeviceType.ButtonText = "Xóa loại thiết bị\r\n删除设备类型";
            cbxCheckType.SelectedIndex = 0;
            LoadInsightData();

            checkMTOneFilter.Checked = true;
            isMTFind2Filter = false;

            //Load data vào combo box
            cbxChooseMonth.Items.Clear();
            string currentMonth = "Tháng " + DateTime.Now.Month + " / " + DateTime.Now.Month + "月";
            cbxChooseMonth.Items.Add(currentMonth);
            string pastMonth = "Tháng " + DateTime.Now.AddMonths(-1).Month + " / " + DateTime.Now.AddMonths(-1).Month + "月";
            cbxChooseMonth.Items.Add(pastMonth);
            cbxChooseMonth.SelectedIndex = 0;
            chooseIndex = cbxChooseMonth.SelectedIndex;

            GetLocationData(cbxMTSearchByLocation);
            GetManagerData(cbxMTSearchByManager);
            GetDeviceTypeData(cbxAddDeviceType);
            GetExistLocationData();
            GetDeviceTypeDataToEdit();

            LoadBackgroundWorker();
            tmrCallBgWorker.Start();
            isBGRunning = true;
        }
        private void HSEDeviceManagementMainView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnFastCheckData_Click(object sender, EventArgs e)
        {
            tmrCallBgWorker.Stop();
            switch (cbxCheckType.SelectedIndex)
            {
                case 0:
                    GetTotalDeviceData(null); break;
                case 1:
                    GetNearExpDeviceData(null); break;
                case 2:
                    GetOverExpDeviceData(null); break;
                case 3:
                    GetValidDeviceData(null); break;
                case 4:
                    GetCheckedDeviceData(null); break;
                case 5:
                    GetNotCheckedDeviceData(null); break;
                default:
                    GetTotalDeviceData(null); break;
            }
            tmrCallBgWorker.Start();
        }

        private void btnSaveDetailExcel_Click(object sender, EventArgs e)
        {
            try
            {
                tmrCallBgWorker.Stop();
                List<HSEDeviceInsightDetail> details = new List<HSEDeviceInsightDetail>();
                GetTotalDeviceData(details);
                GetNearExpDeviceData(details);
                GetOverExpDeviceData(details);
                GetValidDeviceData(details);
                GetCheckedDeviceData(details);
                GetNotCheckedDeviceData(details);
                ExcelSave.SaveExcel_HSEInsightDetail(details);
                tmrCallBgWorker.Start();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi xuất file excel:\n\rExcel导出错误：" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HSEDeviceManagementMainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
            bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged -= BW_ProgressChanged;
            bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            GC.Collect();
        }

        private void cbxChooseMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chooseIndex = cbxChooseMonth.SelectedIndex;
        }

        private void cbxMTSearchByLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadSearchDeviceData(cbxMTSearchByLocation, cbxMTSearchByManager, dtgvCheckDevice);
        }

        private void cbxMTSearchByManager_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadSearchDeviceData(cbxMTSearchByLocation, cbxMTSearchByManager, dtgvCheckDevice);
        }

        private void checkMTOneFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMTOneFilter.Checked)
            {
                isMTFind2Filter = false;
                checkMTTwoFilter.Checked = false;
                cbxMTSearchByLocation.SelectedIndex = -1;
                cbxMTSearchByManager.SelectedIndex = -1;
                dtgvCheckDevice.DataSource = null;
            }
        }

        private void checkMTTwoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMTTwoFilter.Checked)
            {
                isMTFind2Filter = true;
                checkMTOneFilter.Checked = false;
            }
        }

        private void btnPrintDeviceQR_Click(object sender, EventArgs e)
        {
            if (dtgvCheckDevice.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dtgvCheckDevice.SelectedRows)
                {
                    PritingLabel pritingLabel = new PritingLabel();
                    PcccDevice pcccDevice = new PcccDevice
                    {
                        UUID = r.Cells[0].Value.ToString(),
                        Type = r.Cells[2].Value.ToString()
                    };

                    pritingLabel.PrintLabelHSEDeviceQRCodeItem(pcccDevice, 1);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng tìm và chọn các thiết bị cần in tem!\r\n请查找并选择需要打印印章的设备！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            int rowCount = dtgvCheckDevice.SelectedRows.Count;
            if (rowCount > 0)
            {
                DialogResult dialogResult = CTMessageBox.Show("Bạn chắc chắc muốn xóa " + rowCount + " thiết bị đang chọn ?\r\n您确定要删除所选的 " + rowCount + " 个设备吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult1 = CTMessageBox.Show("Thực hiện xóa sẽ không thể hoàn tác. Bạn chắc chắn muốn xóa ?\r\n删除操作无法撤消。你确定你要删除 ？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dtgvCheckDevice.SelectedRows)
                        {
                            StringBuilder sqlDeleteDevice = new StringBuilder();
                            sqlDeleteDevice.Append("delete from pccc_info where device_uuid = '" + r.Cells[0].Value.ToString() + "'");
                            sqlDevice.sqlExecuteNonQuery(sqlDeleteDevice.ToString(), null, null);
                        }
                        CTMessageBox.Show("Hoàn tất xóa " + rowCount + " thiết bị khỏi hệ thống\r\n已完成从系统中删除 " + rowCount + " 台设备", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng tìm và chọn các thiết bị cần xóa!\r\n请找到并选择要擦除的设备！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (cbxChooseEditParameter.SelectedIndex == -1)
            {
                CTMessageBox.Show("Vui chọn trường dữ liệu cần chỉnh sửa!\r\n请选择要编辑的数据字​​段！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!string.IsNullOrEmpty(txbEditData.Texts.Trim()))
                {
                    int rowCount = dtgvCheckDevice.SelectedRows.Count;
                    if (rowCount > 0)
                    {
                        DialogResult dialogResult = CTMessageBox.Show("Bạn muốn chỉnh sửa dữ liệu của " + rowCount + " thiết bị đã chọn?\r\n想要编辑 3 个选定设备的数据？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow r in dtgvCheckDevice.SelectedRows)
                            {
                                string value = string.Empty;
                                string query = string.Empty;
                                var charsToRemove = new string[] { "@", "'", "=" };
                                foreach (var c in charsToRemove)
                                    value = SubMethods.RemoveVietnameseUnicode(txbEditData.Texts.Trim().Replace(c, string.Empty));
                                switch (cbxChooseEditParameter.SelectedIndex)
                                {
                                    case 0:
                                        query = "update pccc_info set device_manager = '" + value + "' where device_uuid = '" + r.Cells[0].Value.ToString() + "'";
                                        break;
                                    case 1:
                                        query = "update pccc_info set device_location = '" + value + "' where device_uuid = '" + r.Cells[0].Value.ToString() + "'";
                                        break;
                                }
                                sqlDevice.sqlExecuteNonQuery(query.ToString(), null, null);
                            }
                            GetLocationData(cbxMTSearchByLocation);
                            GetManagerData(cbxMTSearchByManager);
                            LoadSearchDeviceData(cbxMTSearchByLocation, cbxMTSearchByManager, dtgvCheckDevice);
                            CTMessageBox.Show("Hoàn tất chỉnh sửa " + rowCount + " thiết bị\r\n已完成 " + rowCount + " 台设备的编辑", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        CTMessageBox.Show("Vui lòng tìm và chọn các thiết bị cần chỉnh sửa!\r\n请找到并选择需要编辑的设备！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    CTMessageBox.Show("Vui lòng nhập dữ liệu cần chỉnh sửa!\r\n请输入要编辑的数据！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbEditData.Focus();
                }
            }
        }

        private void btnPrintNewDeviceQR_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (cbxAddDeviceType.SelectedIndex > -1)
            {
                try
                {
                    StringBuilder sqlInsertNewDevice = new StringBuilder();
                    int DSTT = Convert.ToInt32(nudNumberOfDevicePrint.Value);
                    string Dtypeuuid = cbxAddDeviceType.SelectedValue.ToString();
                    string Dtypename = sqlDevice.sqlExecuteScalarString("select device_type_name from pccc_type_info where device_type_uuid = '" + Dtypeuuid + "'");
                    string DmaxExp = sqlDevice.sqlExecuteScalarString("select maximum_exp_date from pccc_type_info where device_type_uuid = '" + Dtypeuuid + "'");

                    if (DSTT > 0)
                    {
                        DialogResult dialogResult = CTMessageBox.Show("In " + DSTT + " tem thiết bị \"" + Dtypename + "\"?\r\n打印 " + DSTT + " 个\"" + Dtypename + "\"设备印章？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ProgressDialog progressDialog = new ProgressDialog();
                            Thread backgroundThread = new Thread(
                                new ThreadStart(() =>
                                {
                                    for (int i = 0; i < DSTT; i++)
                                    {
                                        string newDeviceUUID = UUIDGenerator.getAscId();
                                        sqlInsertNewDevice.Append("insert into pccc_info ");
                                        sqlInsertNewDevice.Append(@"( device_uuid, device_type_uuid, device_type_name, device_group_uuid, maximum_extend_date, ");
                                        sqlInsertNewDevice.Append(@" device_location, device_manager, installed_date, expire_date, newest_maintenance_info,newest_maintenance_date, newest_check_info,newest_check_date) ");
                                        sqlInsertNewDevice.Append(" values ( ");
                                        sqlInsertNewDevice.Append(" '" + newDeviceUUID + "', '" + Dtypeuuid + "', N'" + Dtypename + "', '6GL4FSYCUO0BNO' , " + DmaxExp + ", ");
                                        sqlInsertNewDevice.Append(" NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");

                                        sqlDevice.sqlExecuteNonQuery(sqlInsertNewDevice.ToString(), null, null);

                                        PritingLabel pritingLabel = new PritingLabel();
                                        PcccDevice pcccDevice = new PcccDevice
                                        {
                                            UUID = newDeviceUUID,
                                            Type = Dtypename
                                        };
                                        pritingLabel.PrintLabelHSEDeviceQRCodeItem(pcccDevice, 1);

                                        count++;
                                        progressDialog.UpdateProgress(100 * i / DSTT, "Đang in tem thiết bị ... \r\n打印设备标签...");
                                    }
                                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                                }));
                            backgroundThread.Start();
                            progressDialog.ShowDialog();
                        }
                    }
                    else
                    {
                        CTMessageBox.Show("Vui lòng nhập số lượng!\r\n请输入数量！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    CTMessageBox.Show("Lỗi khi tạo thiết bị mới:\r\n创建新设备时出错：\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng chọn loại thiết bị\r\n请选择设备类型", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintExistLocation_Click(object sender, EventArgs e)
        {
            if (dtgvShowExistLocation.SelectedRows.Count > 0)
            {
                int DSTT = Convert.ToInt32(nudNumberOfLocationPrint.Value);
                if (DSTT > 0)
                {
                    DialogResult dialogResult = CTMessageBox.Show("In tem cho các vị trí đã chọn?\r\n为选定地点打印邮票？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dtgvShowExistLocation.SelectedRows)
                        {
                            for (int i = 0; i < DSTT; i++)
                            {
                                PritingLabel pritingLabel = new PritingLabel();
                                PcccLocation pcccLocation = new PcccLocation
                                {
                                    Location = r.Cells[0].Value.ToString(),
                                };

                                pritingLabel.PrintLabelHSEQRLocation(pcccLocation, 1);
                            }
                        }
                    }
                }
                else
                {
                    CTMessageBox.Show("Vui lòng nhập số lượng!\r\n请输入数量！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng tìm và chọn các vị trí cần in tem!\r\n请找到并选择打印邮票的地点！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintNewLocation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbInsertNewLocation.Texts.Trim()))
            {
                int DSTT = Convert.ToInt32(nudNumberOfLocationPrint.Value);
                if (DSTT > 0)
                {
                    DialogResult dialogResult = CTMessageBox.Show("In tem vị trí đã nhập ?\r\n打印输入的位置标记？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < DSTT; i++)
                        {
                            PritingLabel pritingLabel = new PritingLabel();
                            PcccLocation pcccLocation = new PcccLocation
                            {
                                Location = SubMethods.RemoveVietnameseUnicode(txbInsertNewLocation.Texts.Trim())
                            };
                            pritingLabel.PrintLabelHSEQRLocation(pcccLocation, 1);
                        }
                    }
                }
                else
                {
                    CTMessageBox.Show("Vui lòng nhập số lượng!\r\n请输入数量！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng nhập vị trí mới!\r\n请输入新位置！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSearchLocation__TextChanged(object sender, EventArgs e)
        {
            (dtgvShowExistLocation.DataSource as DataTable).DefaultView.RowFilter = string.Format("device_location LIKE '%{0}%'", SubMethods.RemoveVietnameseUnicode(txbSearchLocation.Texts.Trim()));
        }

        private void txbSearchDeviceType__TextChanged(object sender, EventArgs e)
        {
            (dtgvDeviceType.DataSource as DataTable).DefaultView.RowFilter = string.Format("device_type_name LIKE '%{0}%'", SubMethods.RemoveVietnameseUnicode(txbSearchDeviceType.Texts.Trim()));
        }

        private void btnAddNewDeviceType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbAddNewDeviceType.Texts.Trim()) && !string.IsNullOrEmpty(txbAddNewDTExp.Texts.Trim()))
            {
                DialogResult dialogResult = CTMessageBox.Show("Thêm mới loại thiết bị ?\r\n添加新的设备类型？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    StringBuilder sqlInsertNewDeviceType = new StringBuilder();
                    sqlInsertNewDeviceType.Append("insert into pccc_type_info ");
                    sqlInsertNewDeviceType.Append(@"(device_type_uuid, device_group_uuid, device_type_name, maximum_exp_date) ");
                    sqlInsertNewDeviceType.Append(" values ");
                    sqlInsertNewDeviceType.Append("( '" + UUIDGenerator.getAscId() + "', '6GL4FSYCUO0BNO', N'" + txbAddNewDeviceType.Texts.Trim() + "', '" + txbAddNewDTExp.Texts.Trim() + "')");
                    sqlDevice.sqlExecuteNonQuery(sqlInsertNewDeviceType.ToString(), null, null);
                    GetDeviceTypeDataToEdit();
                    txbAddNewDeviceType.Texts = String.Empty;
                    txbAddNewDTExp.Texts = String.Empty;
                    dtgvDeviceType.Focus();
                    Alert("Đã hoàn tất thêm loại thiết bị!\r\n添加设备类型完成！", Form_Alert.enmType.Success);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng nhập đủ thông tin\r\n请输入完整信息", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditDeviceTypeExp_Click(object sender, EventArgs e)
        {
            int count = dtgvDeviceType.SelectedRows.Count;
            if (count > 0)
            {
                if (!string.IsNullOrEmpty(txbEditDeviceTypeExp.Texts.Trim()))
                {
                    DialogResult dialogResult = CTMessageBox.Show("Chỉnh sửa thời hạn cho " + count + " loại thiết bị đã chọn?\r\n编辑 " + count + " 种选定设备类型的截止日期？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dtgvDeviceType.SelectedRows)
                        {
                            string query = "update pccc_type_info set maximum_exp_date = '" + txbEditDeviceTypeExp.Texts.Trim() + "' where device_type_uuid = '" + r.Cells[0].Value.ToString() + "'";
                            sqlDevice.sqlExecuteNonQuery(query, null, null);
                        }
                        GetDeviceTypeDataToEdit();
                        txbEditDeviceTypeExp.Texts = String.Empty;
                        dtgvDeviceType.Focus();
                        Alert("Đã hoàn tất chỉnh sửa " + count + " loại thiết bị!\r\n" + count + "种装备编辑完成！", Form_Alert.enmType.Success);
                    }
                }
                else
                {
                    CTMessageBox.Show("Vui lòng nhập thời hạn cần cập nhật\r\n请输入更新截止日期", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng tìm và chọn các loại thiết bị cần cập nhật!\r\n请查找并选择需要更新的设备类型！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbEditDeviceTypeExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddNewDTExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbAddNewDeviceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as CTTextBox).Texts.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDeleteDeviceType_Click(object sender, EventArgs e)
        {
            int count = dtgvDeviceType.SelectedRows.Count;
            if (count > 0)
            {
                DialogResult dialogResult = CTMessageBox.Show("Xóa " + count + " loại thiết bị đã chọn?\r\n删除 " + count + " 个选定的设备类型？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dtgvDeviceType.SelectedRows)
                    {
                        string query = "delete pccc_type_info where device_type_uuid = '" + r.Cells[0].Value.ToString() + "'";
                        sqlDevice.sqlExecuteNonQuery(query, null, null);
                    }
                    GetDeviceTypeDataToEdit();
                    Alert("Đã hoàn tất xóa " + count + " loại thiết bị!\r\n已完成" + count + "种设备类型的删除！", Form_Alert.enmType.Success);
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng tìm và chọn các loại thiết bị cần xóa!\r\n请找到并选择要擦除的设备类型！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xuiFlatTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    if (!isBGRunning)
                    {
                        tmrCallBgWorker.Start();
                        LoadInsightData();
                        isBGRunning = true;
                    }
                    break;
                case 1:
                    if (isBGRunning)
                    {
                        tmrCallBgWorker.Stop();
                        isBGRunning = false;
                    }
                    break;
                case 2:
                    if (isBGRunning)
                    {
                        tmrCallBgWorker.Stop();
                        isBGRunning = false;
                    }
                    break;
            }
        }
    }
}
