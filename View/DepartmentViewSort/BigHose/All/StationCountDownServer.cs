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
using System.Windows.Controls;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.View.CustomControl;

namespace techlink_new_all_in_one
{
    public partial class StationCountDownServer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SimpleTcpServer server;
        CTServerProductsCountDown c;
        SqlSoft sqlSoft = new SqlSoft();
        DataTable saveListUUID;

        BackgroundWorker bgWorker;
        System.Windows.Forms.Timer tmrCallBgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        object lockObject = new object();

        public StationCountDownServer()
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txbSearchTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (CTServerProductsCountDown c in flpCDProducts.Controls)
                {
                    if (!c.ProductNo.ToLower().Contains(txbSearchTool.Texts.ToLower()))
                    {
                        c.Hide();
                    }
                    else
                    {
                        c.Show();
                    }
                }
            }
        }

        private void txbSearchTool__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSearchTool.Texts.Trim()))
            {
                foreach (CTServerProductsCountDown c in flpCDProducts.Controls)
                {
                    c.Show();
                }
            }
        }

        private void StationCountDownServer_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.cdHostIP) && !string.IsNullOrEmpty(Properties.Settings.Default.cdHostPort))
            {
                server = new SimpleTcpServer();
                server.Delimiter = 0x13;
                server.StringEncoder = Encoding.UTF8;
                server.DataReceived += Server_DataReceived;
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(Properties.Settings.Default.cdHostIP);
                server.Start(ip, Convert.ToInt32(Properties.Settings.Default.cdHostPort));

                tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
                tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
                tmrCallBgWorker.Interval = 1000; //3600000;

                bgWorker = new BackgroundWorker();

                bgWorker.DoWork += new DoWorkEventHandler(BW_DoWork);
                bgWorker.ProgressChanged += BW_ProgressChanged;
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
                bgWorker.WorkerReportsProgress = true;

                tmrCallBgWorker.Start();
            }
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
            runLoop();
        }
        private void runLoop()
        {
            if (flpCDProducts.InvokeRequired)
            {
                MethodInvoker AssignMethodToControl = new MethodInvoker(() => runLoop());
                flpCDProducts.Invoke(AssignMethodToControl);
            }
            else
            {
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DataTable dt = new DataTable();
                sqlSoft.sqlDataAdapterFillDatatable("select uuid from big_hose_countdown_result where isWorking = 1 and isFinished = 0 and plan_start <= '" + currentTime + "' and plan_end >= '" + currentTime + "'", ref dt);
                if (dt.Rows.Count > 0)
                {
                    CTServerProductsCountDown[] listItems = new CTServerProductsCountDown[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow[] foundAuthors;
                        if (saveListUUID != null)
                            foundAuthors = saveListUUID.Select("uuid = '" + dt.Rows[i]["uuid"].ToString() + "'");
                        else
                            foundAuthors = null;
                        if (foundAuthors == null || foundAuthors.Length == 0)
                        {
                            listItems[i] = new CTServerProductsCountDown(dt.Rows[i]["uuid"].ToString());
                            listItems[i].Name = dt.Rows[i]["uuid"].ToString();

                            flpCDProducts.Controls.Add(listItems[i]);
                        }
                        else
                        {
                            dt.Rows.Remove(foundAuthors[0]);
                        }
                        dt.AcceptChanges();
                        saveListUUID = dt;
                    }
                }
            }
        }
        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        { }

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

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            foreach(CTServerProductsCountDown a in flpCDProducts.Controls.OfType<CTServerProductsCountDown>().Where(a => e.MessageString.Contains(a.Name)))
            a.Invoke((MethodInvoker)delegate ()
            {
                e.Reply(a.CountDown);
            });
        }

        private void StationCountDownServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
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

        private void StationCountDownServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
            bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged -= BW_ProgressChanged;
            bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
        }
    }
}
