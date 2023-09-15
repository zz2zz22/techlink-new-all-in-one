using System;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
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
        SqlDeviceMaintenance sqlDevice = new SqlDeviceMaintenance();

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
        #region BackgroundWorker
        private void LoadBackgroundWorker()
        {   // this timer calls bgWorker again and again after regular intervals
            tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
            tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
            tmrCallBgWorker.Interval = 1000; //3600000 = 1 hour/60000 = 1 minute

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

                    dtgvShowDetailData.Columns["device_type_name"].HeaderText = "Loại thiết bị\r\n设备类型";
                    dtgvShowDetailData.Columns["device_location"].HeaderText = "Vị trí lắp đặt\r\n安装位置";
                    dtgvShowDetailData.Columns["device_manager"].HeaderText = "Người quản lý\r\n装置经理";
                    dtgvShowDetailData.Columns["expire_date"].HeaderText = "Ngày hết hạn\r\n到期日";
                    dtgvShowDetailData.Columns["expire_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                    dtgvShowDetailData.Columns["newest_check_date"].HeaderText = "Ngày kiểm tra gần nhất\r\n上次设备检查日期";
                    dtgvShowDetailData.Columns["newest_check_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
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
                string notCheckedDevice = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' > newest_check_date");
                string notHaveManager = sqlDevice.sqlExecuteScalarString("select COUNT(device_uuid) from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and device_manager IS NOT NULL or device_manager NOT like 'null'");

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
                    if (!string.IsNullOrEmpty(nearExpire) && !string.IsNullOrEmpty(overExpire))
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
        private void GetTotalDeviceData()
        {
            DataTable dtTotalDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO'", ref dtTotalDeviceData);
                InitDatagridviewData(dtTotalDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetNearExpDeviceData()
        {
            DataTable dtNearExpDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and DATEADD(WEEK, -2, expire_date) < GETDATE() and expire_date > GETDATE() order by expire_date asc", ref dtNearExpDeviceData);
                InitDatagridviewData(dtNearExpDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetOverExpDeviceData()
        {
            DataTable dtOverExpDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and expire_date < GETDATE() order by expire_date asc", ref dtOverExpDeviceData);
                InitDatagridviewData(dtOverExpDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetValidDeviceData()
        {
            DataTable dtValidDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and DATEADD(WEEK, -2, expire_date) > GETDATE() and expire_date > GETDATE() order by expire_date asc", ref dtValidDeviceData);
                InitDatagridviewData(dtValidDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetCheckedDeviceData()
        {
            DataTable dtCheckedDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' <= newest_check_date and '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "' >= newest_check_date order by newest_check_date desc", ref dtCheckedDeviceData);
                InitDatagridviewData(dtCheckedDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        private void GetNotCheckedDeviceData()
        {
            DataTable dtNotCheckedDeviceData = new DataTable();
            LoadingDialog loading = new LoadingDialog();
            Thread backgroundThreadLoadDT = new Thread(
            new ThreadStart(() =>
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                sqlDevice.sqlDataAdapterFillDatatable("select * from pccc_info where device_location IS NOT NULL and device_group_uuid = '6GL4FSYCUO0BNO' and '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' > newest_check_date order by newest_check_date asc", ref dtNotCheckedDeviceData);
                InitDatagridviewData(dtNotCheckedDeviceData);
                loading.BeginInvoke(new Action(() => loading.Close()));
            }));
            backgroundThreadLoadDT.Start();
            loading.ShowDialog();
        }
        #endregion

        //Event Handler
        private void HSEDeviceManagementMainView_Load(object sender, EventArgs e)
        {
            btnSaveDetailExcel.ButtonText = "Xuất Excel thống kê\r\n导出Excel统计数据";
            btnFastCheckData.ButtonText = "Xem nhanh\r\n快速查看数据";
            cbxCheckType.SelectedIndex = 0;
            LoadBackgroundWorker();
            tmrCallBgWorker.Start();
        }
        private void HSEDeviceManagementMainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
            bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged -= BW_ProgressChanged;
            bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);

        }

        private void btnFastCheckData_Click(object sender, EventArgs e)
        {
            switch (cbxCheckType.SelectedIndex)
            {
                case 0:
                    GetTotalDeviceData(); break;
                case 1:
                    GetNearExpDeviceData(); break;
                case 2:
                    GetOverExpDeviceData(); break;
                case 3:
                    GetValidDeviceData(); break;
                case 4:
                    GetCheckedDeviceData(); break;
                case 5:
                    GetNotCheckedDeviceData(); break;
                default:
                    GetTotalDeviceData(); break;
            }
        }
    }
}
