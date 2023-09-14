using com.sun.tools.doclets.formats.html;
using SimpleTCP;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic.FontEmbedded;
using techlink_new_all_in_one.MainModel;

namespace techlink_new_all_in_one.View.CustomControl
{
    public partial class CTBigHoseProductCountdown : UserControl
    {
        BackgroundWorker bgWorker;
        System.Windows.Forms.Timer tmrCallBgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;
        object lockObject = new object();

        string controlUUID = null;

        SimpleTcpClient tcpClient;

        SqlSoft sqlSoft = new SqlSoft();

        public CTBigHoseProductCountdown(string uuid)
        {
            InitializeComponent();
            
            controlUUID = uuid;
            CustomFont.LoadCustomFont();
            lbStationName.Font = new Font(CustomFont.pfc.Families[0], 20, FontStyle.Bold);

            string hostIP = sqlSoft.sqlExecuteScalarString("select countdown_host_ip from base_program_setting");
            string hostPort = sqlSoft.sqlExecuteScalarString("select countdown_host_port from base_program_setting");

            if(!string.IsNullOrEmpty(hostIP) && !string.IsNullOrEmpty(hostPort))
            {
                DataTable dataTable = new DataTable();
                sqlSoft.sqlDataAdapterFillDatatable("select station_uuid, product_no, product_target from big_hose_countdown_result where uuid = '" + controlUUID + "'", ref dataTable);
                lbStationName.Text = sqlSoft.sqlExecuteScalarString("select station_name from station_info where uuid = '" + dataTable.Rows[0]["station_uuid"].ToString() + "'"); 
                lbProductNo.Text = dataTable.Rows[0]["product_no"].ToString();
                lbProductTarget.Text = dataTable.Rows[0]["product_target"].ToString();

                tcpClient = new SimpleTcpClient();
                tcpClient.Connect(hostIP, Convert.ToInt32(hostPort));
                tcpClient.StringEncoder = Encoding.UTF8;
                tcpClient.DataReceived += Client_DataReceived;

                tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
                tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
                tmrCallBgWorker.Interval = 500; //3600000;

                // this is our worker
                bgWorker = new BackgroundWorker();

                // work happens in this method
                bgWorker.DoWork += new DoWorkEventHandler(BW_DoWork);
                bgWorker.ProgressChanged += BW_ProgressChanged;
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
                bgWorker.WorkerReportsProgress = true;

                tmrCallBgWorker.Start();
            }
            else
            {
                Parent.Controls.Remove(this);
                this.Dispose();
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
        private void BW_DoWork(object sender, DoWorkEventArgs e)//Bg worker load nhiệt độ
        {
            var worker = sender as BackgroundWorker;
            tcpClient.WriteLineAndGetReply(controlUUID, TimeSpan.FromSeconds(3));
            
            if (sqlSoft.sqlExecuteScalarString("select isFinished from big_hose_countdown_result where uuid = '" + controlUUID + "'") == "1")
            {
                tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
                bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
                bgWorker.ProgressChanged -= BW_ProgressChanged;
                bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
                tmrCallBgWorker.Stop();
                Parent.Controls.Remove(this);
                this.Dispose();
            }
        }
        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
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

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            lbCDTimer.Invoke((MethodInvoker)delegate ()
            {
                lbCDTimer.Text = e.MessageString;
                string realtimeQty = sqlSoft.sqlExecuteScalarString("select realtime_qty from big_hose_countdown_result where uuid = '" + controlUUID + "'");
                if (!string.IsNullOrEmpty(realtimeQty))
                    lbCurrentQty.Text = realtimeQty;
                else
                    lbCurrentQty.Text = "0";
                string ngQty = sqlSoft.sqlExecuteScalarString("select ng_qty from big_hose_countdown_result where uuid = '" + controlUUID + "'");
                if (!string.IsNullOrEmpty(ngQty))
                    lbDefectQty.Text = ngQty;
                else
                    lbDefectQty.Text = "0";
            });
        }
    }
}
