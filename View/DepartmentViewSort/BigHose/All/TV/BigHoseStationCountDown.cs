using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.FontEmbedded;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class BigHoseStationCountDown : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        int flag = 0;
        //Fields
        int lastestRowCount = 0;
        SimpleTcpClient client;
        SqlSoft sqlSoft = new SqlSoft();

        BackgroundWorker bgWorker;
        System.Windows.Forms.Timer tmrCallBgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        object lockObject = new object();

        public BigHoseStationCountDown()
        {
            //Make the GUI ignore the DPI setting
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void LoadComponents()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            sb.Append("select uuid, station_name from station_info where department_uuid = '740MI6H8F3KA08' and uuid in ('740NR8961SWFVO', '740NRGQRF6OFVO', '740NRI0FSPSFVO', '740NRIW5ZJKFVO') order by create_date asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                cboStation.DataSource = dt;
                cboStation.ValueMember = "uuid";
                cboStation.DisplayMember = "station_name";
                cboStation.SelectedIndex = -1;
            }
            else
            {
                Alert("Lỗi kết nối với máy chủ!\r\n连接服务器时出错！", Form_Alert.enmType.Error);
            }
        }
        private void LoadAllCountDownOfStation(string stationUUID)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            flowlpCDProducts.Controls.Clear();
            sb.Append("select uuid from big_hose_countdown_result where plan_start <= '" + currentTime + "' and plan_end >= '" + currentTime + "' and isFinished = 0 and isWorking = 1 and station_uuid = '" + stationUUID + "' order by product_no asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i >= flag && i < flag + 4)
                    {
                        CTBigHoseProductCountdown cTBigHoseProductCountdown = new CTBigHoseProductCountdown(dt.Rows[i]["uuid"].ToString());
                        flowlpCDProducts.Controls.Add(cTBigHoseProductCountdown);
                    }
                }
                flag = flag + 4;
                if (flag >= dt.Rows.Count)
                    flag = 0;
            }
        }
        private void LoadBackgroundWorker()
        {   // this timer calls bgWorker again and again after regular intervals

            tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
            tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
            tmrCallBgWorker.Interval = 10000; //3600000;

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
            LoadAllCountDownOfStation(Properties.Settings.Default.cdStationUUID);
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

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BigHoseStationCountDown_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void cboStation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboStation.SelectedValue.ToString()))
            {
                Properties.Settings.Default.cdStationUUID = cboStation.SelectedValue.ToString();
                Properties.Settings.Default.Save();
                lbStationName.Text = cboStation.SelectedValue.ToString();
                //Nhét logic load bảng thời gian vô
                LoadAllCountDownOfStation(Properties.Settings.Default.cdStationUUID);
                LoadBackgroundWorker();
                tmrCallBgWorker.Start();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
