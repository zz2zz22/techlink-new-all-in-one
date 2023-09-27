using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
/*
#################################################################
#                             _`				                #
#                          _ooOoo_				                #
#                         o8888888o				                #
#                         88" . "88				                #
#                         (| -_- |)				                #
#                         O\  =  /O				                #
#                      ____/`---'\____				            #
#                    .'  \\|     |//  `.			            #
#                   /  \\|||  :  |||//  \			            #
#                  /  _||||| -:- |||||_  \			            #
#                  |   | \\\  -  /'| |   |			            #
#                  | \_|  `\`---'//  |_/ |			            #
#                  \  .-\__ `-. -'__/-.  /			            #
#                ___`. .'  /--.--\  `. .'___			        #
#             ."" '<  `.___\_<|>_/___.' _> \"".			        #
#            | | :  `- \`. ;`. _/; .'/ /  .' ; |		        #
#            \  \ `-.   \_\_`. _.'_/_/  -' _.' /		        #
#=============`-.`___`-.__\ \___  /__.-'_.'_.-'=================#
                           `= --= -'                    

            TRỜI PHẬT PHÙ HỘ CODE CON KHÔNG BI BUG

          _.-/`)
         // / / )
      .=// / / / )
     //`/ / / / /
     // /     ` /
   ||         /
    \\       /
     ))    .'
         //    /
         /

*/
namespace techlink_new_all_in_one.View.CustomControl
{
    public partial class CTServerProductsCountDown : UserControl
    {
        CountDownTimer countDownTimer;
        Stopwatch stopWatch;
        System.Windows.Forms.Timer t1;
        SqlSoft sqlSoft = new SqlSoft();
        string resultUUID, realtimeQty, ngQty;
        int secondCount = 0;
        DateTime b1Start, b1End, b2Start, b2End, b3Start, b3End, b4Start, b4End;
        bool isCheckBreak = false;
        DateTime planStart, planEnd;

        private string _uuid;
        private string _product_no;
        private string _station_uuid;
        private string _countdown;
        private int _target;
        private int _realtime_qty;
        private int _ng_qty;
        private double _time_left;
        private DateTime _plan_start;
        private DateTime _plan_end;

        public CTServerProductsCountDown(string uuid)
        {
            InitializeComponent();
            resultUUID = uuid;
            LoadControl();
        }

        private void LoadControl()
        {
            DataTable dt = new DataTable();
            sqlSoft.sqlDataAdapterFillDatatable("select product_no, station_uuid, product_target, total_time, time_left, plan_start, plan_end from big_hose_countdown_result where uuid = '" + resultUUID + "'", ref dt);
            if (dt.Rows.Count > 0)
            {
                this.UUID = resultUUID;
                this.ProductNo = dt.Rows[0]["product_no"].ToString();
                this.StationUUID = dt.Rows[0]["station_uuid"].ToString();
                if (double.TryParse(dt.Rows[0]["time_left"].ToString(), out double time))
                    this.TimeLeft = time;
                else
                    this.TimeLeft = 0;
                planStart = Convert.ToDateTime(dt.Rows[0]["plan_start"].ToString());

                planEnd = Convert.ToDateTime(dt.Rows[0]["plan_end"].ToString());

                if (int.TryParse(dt.Rows[0]["product_target"].ToString(), out int currentTarget))
                {
                    this.ProductTarget = currentTarget;
                }
                lbStationName.Text = sqlSoft.sqlExecuteScalarString("select station_name from station_info where uuid = '" + this.StationUUID + "'");

                DataTable dtStationBreak = new DataTable();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string nextDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                sqlSoft.sqlDataAdapterFillDatatable("select * from station_breaktime_range where station_uuid = '" + this.StationUUID + "'", ref dtStationBreak);

                if (dtStationBreak.Rows.Count > 0)
                {
                    try
                    {
                        b1Start = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_1_start"].ToString());
                        b1End = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_1_end"].ToString());
                        b2Start = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_2_start"].ToString());
                        b2End = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_2_end"].ToString());
                        b3Start = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_3_start"].ToString());
                        b3End = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_3_end"].ToString());
                        b4Start = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_4_start"].ToString());
                        b4End = Convert.ToDateTime(date + " " + dtStationBreak.Rows[0]["break_4_end"].ToString());
                        isCheckBreak = true;
                    }
                    catch(Exception)
                    {
                        isCheckBreak = false;
                    }
                }
                else
                {
                    isCheckBreak = false;
                }

                if (double.TryParse(dt.Rows[0]["total_time"].ToString(), out double runTimeSecond))
                {
                    countDownTimer = new CountDownTimer();
                    if (this.TimeLeft != 0)
                        countDownTimer.SetTime(0, this.TimeLeft);
                    else
                        countDownTimer.SetTime(0, runTimeSecond);
                    countDownTimer.Start();
                    countDownTimer.TimeChanged += () => TimerProcessTrigger();
                    countDownTimer.CountDownFinished += () => FinishProcess();
                    countDownTimer.StepMs = 1000;
                    pbxPause.Image = Properties.Resources.cd_play;
                }
            }
        }

        [Category("Custom Props")]
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        [Category("Custom Props")]
        public string ProductNo
        {
            get { return _product_no; }
            set { _product_no = value; lbProductNo.Text = value; }
        }

        [Category("Custom Props")]
        public string StationUUID
        {
            get { return _station_uuid; }
            set { _station_uuid = value; }
        }

        [Category("Custom Props")]
        public string CountDown
        {
            get { return _countdown; }
            set { _countdown = value; }
        }
        [Category("Custom Props")]
        public int ProductTarget
        {
            get { return _target; }
            set { _target = value; }
        }
        [Category("Custom Props")]
        public int RealtimeQty
        {
            get { return _realtime_qty; }
            set { _realtime_qty = value; }
        }
        [Category("Custom Props")]
        public int NGQty
        {
            get { return _ng_qty; }
            set { _ng_qty = value; }
        }
        [Category("Custom Props")]
        public double TimeLeft
        {
            get { return _time_left; }
            set { _time_left = value; }
        }


        private void CheckInBreakTime(double remainingTime, bool isEarly)
        {
            if (isCheckBreak)
            {
                DateTime currentTime = DateTime.Now;
                if ((b1Start < currentTime && currentTime < b1End) ||
                    (b2Start < currentTime && currentTime < b2End) ||
                    (b3Start < currentTime && currentTime < b3End) ||
                    (b4Start < currentTime && currentTime < b4End))
                {
                    if (isEarly)
                    {
                        sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set time_left = " + remainingTime + ", update_date = '" + currentTime.ToString("yyyy-MM-dd HH:mm:ss") + "' where uuid = '" + this.UUID + "'", null, null);
                        if (countDownTimer.IsRunning)
                            countDownTimer.Pause();
                    }
                    else
                    {
                        sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set over_time = " + remainingTime + ", update_date = '" + currentTime.ToString("yyyy-MM-dd HH:mm:ss") + "' where uuid = '" + this.UUID + "'", null, null);
                        if (stopWatch.IsRunning)
                            stopWatch.Stop();
                    }
                }
                else
                {
                    if (isEarly)
                    {
                        if (!countDownTimer.IsRunning)
                            countDownTimer.Continue();
                    }
                    else
                    {
                        if (!stopWatch.IsRunning)
                            stopWatch.Start();
                    }
                }
            }
        }
        private void CheckOutOfTime(double remainingTime)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime > planEnd)
            {
                sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set isLate = 1, isFinished = 1, time_left = " + remainingTime + ", update_date = '" + currentTime.ToString("yyyy-MM-dd HH:mm:ss") + "' where uuid = '" + this.UUID + "'", null, null);

                Parent.Controls.Remove(this);
            }
        }
        private void CheckFinish(double remainingTime, bool isEarly)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            realtimeQty = sqlSoft.sqlExecuteScalarString("select realtime_qty from big_hose_countdown_result where uuid = '" + this.UUID + "'");
            if (int.TryParse(realtimeQty, out int rQty))
                this.RealtimeQty = rQty;
            else
                this.RealtimeQty = 0;
            ngQty = sqlSoft.sqlExecuteScalarString("select ng_qty from big_hose_countdown_result where uuid = '" + this.UUID + "'");
            if (int.TryParse(ngQty, out int nQty))
                this.RealtimeQty = nQty;
            else
                this.RealtimeQty = 0;
            if (this.ProductTarget == (this.RealtimeQty + this.NGQty))
            {
                if (isEarly)
                {
                    sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set isFinished = 1, isEarly = 1, time_left = " + remainingTime + ", update_date = '" + date + "' where uuid = '" + this.UUID + "'", null, null);
                    countDownTimer.Delete();
                    countDownTimer.Dispose();
                }
                else
                {
                    sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set isFinished = 1, isOvertime = 1, over_time = " + remainingTime + ", update_date = '" + date + "' where uuid = '" + this.UUID + "'", null, null);
                    stopWatch.Stop();
                    stopWatch = null;
                }
                Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void FinishProcess()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set isOvertime = 1, time_left = 0, update_date = '" + date + "' where uuid = '" + this.UUID + "'", null, null);
            //Update remaining time in second

            stopWatch = new Stopwatch();
            stopWatch.Start();

            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
            t1.Start();
        }
        private void T1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSW = TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds);
            lbCountDown.Text = timeSW.ToString(@"hh\:mm\:ss");
            if (sqlSoft.sqlExecuteScalarString("select isFinished from big_hose_countdown_result where uuid = '" + this.UUID + "'") != "1")
            {
                CheckInBreakTime(timeSW.TotalSeconds, false);
                CheckOutOfTime(timeSW.TotalSeconds);
                CheckFinish(timeSW.TotalSeconds, false);
            }
        }

        private void TimerProcessTrigger()
        {
            if (sqlSoft.sqlExecuteScalarString("select isFinished from big_hose_countdown_result where uuid = '" + this.UUID + "'") != "1")
            {
                lbCountDown.Text = countDownTimer.TimeLeftStr;
                this.CountDown = lbCountDown.Text;
                double remainingTime = countDownTimer.TimeLeftInSecond;
                CheckInBreakTime(remainingTime, true);
                CheckOutOfTime(remainingTime);
                CheckFinish(remainingTime, true);
                sqlSoft.sqlExecuteNonQuery("update big_hose_countdown_result set time_left = " + remainingTime + ", update_date = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where uuid = '" + this.UUID + "'", null, null);
                //Update remaining time in second
            }
        }

        private void pbxPause_Click(object sender, EventArgs e)
        {
            if (countDownTimer.IsRunning)
            {
                countDownTimer.Pause();
                pbxPause.Image = Properties.Resources.cd_pause;
            }
            else
            {
                countDownTimer.Continue();
                pbxPause.Image = Properties.Resources.cd_play;
            }
        }
    }
}
