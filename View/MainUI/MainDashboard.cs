using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;
using techlink_new_all_in_one.View.SubUI;
using XanderUI;

namespace techlink_new_all_in_one
{
    public partial class MainDashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Fields
        private XUIButton currentBtn;
        private Panel leftBorderBtn;
        public static Form currentChildForm;
        public static Panel mainPanel;
        public static Label titleLabel;

        public MainDashboard()
        { 
            //Make the GUI ignore the DPI setting
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();

            mainPanel = this.panelDesktop;
            titleLabel = this.lblTitleChildForm;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Button text
            btnDashboard.ButtonText = "Công cụ chính\r\n主要工具";
            btnSideTool.ButtonText = "Công cụ quản lý\r\n管理工具";
            btnMainConfig.ButtonText = "Cài đặt chung\r\n常规设置";
            btnUserConfig.ButtonText = "Cài đặt tài khoản\r\n帐号设定";
            btnEntertainTool.ButtonText = "Giải trí";

            if (UserData.user_name != "admin")
                btnEntertainTool.Hide();
        }

        //Struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //////////////////////////////////////////////////////////
        //METHODS
        //////////////////////////////////////////////////////////
        
        #region Methods
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (XUIButton)senderBtn;
                currentBtn.BackgroundColor = Color.FromArgb(37, 36, 81);
                currentBtn.TextColor = color;
                currentBtn.ImagePosition = XUIButton.imgPosition.Right;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackgroundColor = Color.FromArgb(255, 128, 255);
                currentBtn.TextColor = Color.Black;
                currentBtn.ImagePosition = XUIButton.imgPosition.Left;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Màn hình chính\r\n主屏幕";
        }

        public static void OpenChildForm(Form childForm, string title)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                if (currentChildForm.IsDisposed)
                {
                    currentChildForm = childForm;
                    //End
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(childForm);
                    mainPanel.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    titleLabel.Text = title;
                }
            }
            else
            {
                currentChildForm = childForm;
                //End
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                mainPanel.Controls.Add(childForm);
                mainPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                titleLabel.Text = title;
            }
            
        }
        #endregion

        //////////////////////////////////////////////////////////
        //METHODS
        //////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////
        //EVENT HANDLER
        //////////////////////////////////////////////////////////
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new MainToolsView(), "Công cụ chính\r\n主要工具");
        }

        private void btnSideTool_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new SubToolsView(), " Công cụ quản lý\r\n管理工具");
        }

        private void btnMainConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ProgramSettingView(), "Cài đặt chung\r\n常规设置");
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new AccountSettingView(), "Cài đặt tài khoản\r\n帐号设定");
        }
        private void btnEntertainTool_Click(object sender, EventArgs e)
        {
            if (UserData.user_permission == "99")
            {
                ActivateButton(sender, RGBColors.color5);
                OpenChildForm(new EntertainForm(), "Giải trí");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn đăng xuất và trở lại màn hình đăng nhập ?\r\n想要注销并返回登录屏幕？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Alert("Đăng xuất thành công!\r\n退出成功！", Form_Alert.enmType.Success);
                this.Close();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
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

        

        //////////////////////////////////////////////////////////
        //EVENT HANDLER
        //////////////////////////////////////////////////////////
    }
}
