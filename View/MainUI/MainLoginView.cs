using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using techlink_new_all_in_one.MainController;
using techlink_new_all_in_one.View.CustomUI;
using techlink_new_all_in_one.View.SubUI;
using techlink_new_all_in_one.MainController.SubLogic;
using System.Drawing.Drawing2D;

namespace techlink_new_all_in_one
{
    public partial class MainLoginView : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        UserAuthentication userAuthentication = new UserAuthentication();

        public MainLoginView()
        {
            InitializeComponent();
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
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                txbUsername.Focus();
            }
        }

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
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.On)
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
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.On)
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
            if (switchChangeMode.SwitchState == XanderUI.XUISwitch.State.Off)
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
    }
}
