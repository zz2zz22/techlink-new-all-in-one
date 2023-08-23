using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.FontEmbedded;
using techlink_new_all_in_one.Properties;
using techlink_new_all_in_one.View.SubUI;

namespace techlink_new_all_in_one
{
    public partial class MainLoginView : Form
    {
        //Fields
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public int playAnimationFlag;
        public bool isAnimationReverse;
        System.Timers.Timer _timer;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        UserAuthentication userAuthentication = new UserAuthentication();

        List<System.Drawing.Image> textChangeAni = new List<System.Drawing.Image>();
        List<System.Drawing.Image> txbUsernameFocusAni = new List<System.Drawing.Image>();
        List<System.Drawing.Image> txbPasswordFocusAni = new List<System.Drawing.Image>();
        List<System.Drawing.Image> playAnimationList = new List<System.Drawing.Image>();

        //Constuctor
        public MainLoginView()
        {
            InitializeComponent();

            LoadTextboxAnimation();
            LoadTxbUsernameFocusAni();
            LoadTxbPasswordFocusAni();
        }

        //Method
        private void LoadTextboxAnimation()
        {
            textChangeAni.Add(Resources.textbox_user_1);
            textChangeAni.Add(Resources.textbox_user_2);
            textChangeAni.Add(Resources.textbox_user_3);
            textChangeAni.Add(Resources.textbox_user_4);
            textChangeAni.Add(Resources.textbox_user_5);
            textChangeAni.Add(Resources.textbox_user_6);
            textChangeAni.Add(Resources.textbox_user_7);
            textChangeAni.Add(Resources.textbox_user_8);
            textChangeAni.Add(Resources.textbox_user_9);
            textChangeAni.Add(Resources.textbox_user_10);
            textChangeAni.Add(Resources.textbox_user_11);
            textChangeAni.Add(Resources.textbox_user_12);
            textChangeAni.Add(Resources.textbox_user_13);
            textChangeAni.Add(Resources.textbox_user_14);
            textChangeAni.Add(Resources.textbox_user_15);
            textChangeAni.Add(Resources.textbox_user_16);
            textChangeAni.Add(Resources.textbox_user_17);
            textChangeAni.Add(Resources.textbox_user_18);
            textChangeAni.Add(Resources.textbox_user_19);
            textChangeAni.Add(Resources.textbox_user_20);
            textChangeAni.Add(Resources.textbox_user_21);
            textChangeAni.Add(Resources.textbox_user_22);
            textChangeAni.Add(Resources.textbox_user_23);
            textChangeAni.Add(Resources.textbox_user_24);
        }

        private void LoadTxbUsernameFocusAni()
        {
            txbUsernameFocusAni.Add(Resources.idle);
            txbUsernameFocusAni.Add(Resources.username_focus_1);
            txbUsernameFocusAni.Add(Resources.username_focus_2);
            txbUsernameFocusAni.Add(Resources.username_focus_3);
            txbUsernameFocusAni.Add(Resources.username_focus_4);
            txbUsernameFocusAni.Add(Resources.username_focus_5);
        }

        private void LoadTxbPasswordFocusAni()
        {
            txbPasswordFocusAni.Add(Resources.idle);
            txbPasswordFocusAni.Add(Resources.password_enter_1);
            txbPasswordFocusAni.Add(Resources.password_enter_2);
            txbPasswordFocusAni.Add(Resources.password_enter_3);
            txbPasswordFocusAni.Add(Resources.password_enter_4);
            txbPasswordFocusAni.Add(Resources.password_enter_5);
            txbPasswordFocusAni.Add(Resources.password_enter_6);
        }

        public void LoginSuccess()
        {
            if (userAuthentication.checkAccount(txbUsername.Text.TrimEnd(), txbPassword.Text.TrimEnd(), switchChangeMode.SwitchState))
            {
                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.FormClosed += mainDashboardFormClosed;
                mainDashboard.Show();
                txbUsername.Text = String.Empty;
                txbPassword.Text = String.Empty;
                label1.Focus();
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                label1.Focus();
            }
        }

        private void PlayAnimation(List<System.Drawing.Image> list, bool isReverse)
        {
            if (_timer != null)
            {
                _timer.Enabled = false;
            }
            _timer = new System.Timers.Timer();
            _timer.Interval = 55;
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(_timer_Elapsed);
            isAnimationReverse = isReverse;
            playAnimationList = list;
            if (isAnimationReverse)
                playAnimationFlag = playAnimationList.Count - 1;
            else
                playAnimationFlag = 0;
            _timer.Enabled = true;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (isAnimationReverse)
            {
                if (playAnimationFlag >= 0)
                {
                    pictureBox3.Image = playAnimationList[playAnimationFlag];
                    playAnimationFlag--;
                }
                else
                {
                    _timer.Enabled = false;
                }
            }
            else
            {
                if (playAnimationFlag < playAnimationList.Count)
                {
                    pictureBox3.Image = playAnimationList[playAnimationFlag];
                    playAnimationFlag++;
                }
                else
                {
                    _timer.Enabled = false;
                }
            }
        }

        //Event handler

        private void mainDashboardFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= mainDashboardFormClosed;
            this.Show();
            this.ShowInTaskbar = true;
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (txbPassword.PasswordChar == '*')
            {
                btnShowPassword.Image = Properties.Resources.eye;
                btnShowPassword.Refresh();
                txbPassword.PasswordChar = '\0';
            }
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (txbPassword.PasswordChar == '\0')
            {
                btnShowPassword.Image = Properties.Resources.hidden;
                btnShowPassword.Refresh();
                txbPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginSuccess();
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSuccess();
            }
        }

        private void btnLogTV_Click(object sender, EventArgs e)
        {
            MainTVDashboard mainTVDashboard = new MainTVDashboard();
            mainTVDashboard.Show();
        }

        private void MainLoginView_Load(object sender, EventArgs e)
        {
            CustomFont.LoadCustomFont();
            lb1.Font = new Font(CustomFont.pfc.Families[0], 22, FontStyle.Bold);
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.Off)
            {
                gbxPassword.Visible = true;
            }
            else
            {
                gbxPassword.Visible = false;
            }

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {

                Version deploy = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

                StringBuilder version = new StringBuilder();
                version.Append("Version: ");
                version.Append(deploy.Major);
                version.Append(".");
                version.Append(deploy.Minor);
                version.Append(".");
                version.Append(deploy.Build);
                version.Append(".");
                version.Append(deploy.Revision);

                lbVersion.Text = version.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn thoát chương trình?\r\n想要退出程序吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void panelPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainLoginView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (HelpForm helpForm = new HelpForm())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    helpForm.Owner = formBackground;
                    helpForm.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally { formBackground.Dispose(); }
        }

        private void switchChangeMode_Click(object sender, EventArgs e)
        {
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.Off)
            {
                gbxPassword.Visible = true;
            }
            else
            {
                gbxPassword.Visible = false;
            }
            ActionTimer actionTimer = new ActionTimer();
            actionTimer.switchActionTimer(switchChangeMode);
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.On)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSuccess();
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (txbUsername.Text.Length > 0 && txbUsername.Text.Length <= 15)
            {
                pictureBox3.Image = textChangeAni[txbUsername.Text.Length - 1];
                pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txbUsername.Text.Length <= 0)
                pictureBox3.Image = Resources.username_focus_5;
            else
                pictureBox3.Image = textChangeAni[22];
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            PlayAnimation(txbPasswordFocusAni, false);
        }

        private void txbUsername_Enter(object sender, EventArgs e)
        {
            if (txbUsername.Text.Length > 0)
            {
                if (_timer != null)
                {
                    _timer.Enabled = false;
                }
                pictureBox3.Image = textChangeAni[txbUsername.Text.Length - 1];
            }
            else
            {
                PlayAnimation(txbUsernameFocusAni, false);
            }
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            PlayAnimation(txbUsernameFocusAni, true);
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            PlayAnimation(txbPasswordFocusAni, true);
        }
    }
}
