namespace techlink_new_all_in_one
{
    partial class MainLoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginView));
            this.lbLoginName = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.btnShowPassword = new System.Windows.Forms.PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxUsername = new System.Windows.Forms.GroupBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogTV = new XanderUI.XUIButton();
            this.btnLogin = new XanderUI.XUIButton();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.btnHelp = new XanderUI.XUIButton();
            this.btnClose = new XanderUI.XUIButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.switchChangeMode = new XanderUI.XUISwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginName.Location = new System.Drawing.Point(12, 33);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(112, 44);
            this.lbLoginName.TabIndex = 10;
            this.lbLoginName.Text = "Login";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(3, 9);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(60, 19);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "label1";
            // 
            // gbxPassword
            // 
            this.gbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.gbxPassword.Controls.Add(this.btnShowPassword);
            this.gbxPassword.Controls.Add(this.txbPassword);
            this.gbxPassword.Controls.Add(this.pictureBox2);
            this.gbxPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPassword.Location = new System.Drawing.Point(13, 196);
            this.gbxPassword.Name = "gbxPassword";
            this.gbxPassword.Size = new System.Drawing.Size(360, 75);
            this.gbxPassword.TabIndex = 12;
            this.gbxPassword.TabStop = false;
            this.gbxPassword.Text = "Password";
            this.gbxPassword.Visible = false;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowPassword.Image = global::techlink_new_all_in_one.Properties.Resources.hidden;
            this.btnShowPassword.Location = new System.Drawing.Point(320, 24);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(37, 48);
            this.btnShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowPassword.TabIndex = 3;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(47, 35);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(259, 30);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::techlink_new_all_in_one.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(3, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gbxUsername
            // 
            this.gbxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbxUsername.Controls.Add(this.txbUsername);
            this.gbxUsername.Controls.Add(this.pictureBox1);
            this.gbxUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUsername.Location = new System.Drawing.Point(13, 80);
            this.gbxUsername.Name = "gbxUsername";
            this.gbxUsername.Size = new System.Drawing.Size(360, 75);
            this.gbxUsername.TabIndex = 11;
            this.gbxUsername.TabStop = false;
            this.gbxUsername.Text = "Username";
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(46, 35);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(260, 30);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUsername_KeyDown);
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::techlink_new_all_in_one.Properties.Resources.user_info;
            this.pictureBox1.Location = new System.Drawing.Point(3, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogTV
            // 
            this.btnLogTV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogTV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogTV.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.news_reporter;
            this.btnLogTV.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogTV.ButtonText = "TV REPORT";
            this.btnLogTV.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLogTV.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogTV.CornerRadius = 5;
            this.btnLogTV.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogTV.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogTV.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLogTV.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogTV.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogTV.Location = new System.Drawing.Point(70, 360);
            this.btnLogTV.Name = "btnLogTV";
            this.btnLogTV.Size = new System.Drawing.Size(236, 64);
            this.btnLogTV.TabIndex = 15;
            this.btnLogTV.TextColor = System.Drawing.Color.White;
            this.btnLogTV.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogTV.Click += new System.EventHandler(this.btnLogTV_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Red;
            this.btnLogin.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.password;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogin.ButtonText = "LOG IN";
            this.btnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLogin.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.CornerRadius = 5;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(70, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 64);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.Transparent;
            this.panelPicture.BackgroundImage = global::techlink_new_all_in_one.Properties.Resources.bg_techlink;
            this.panelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture.Controls.Add(this.btnHelp);
            this.panelPicture.Controls.Add(this.lbVersion);
            this.panelPicture.Controls.Add(this.btnClose);
            this.panelPicture.Controls.Add(this.lb1);
            this.panelPicture.Controls.Add(this.lb2);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPicture.Location = new System.Drawing.Point(383, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(441, 436);
            this.panelPicture.TabIndex = 13;
            this.panelPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPicture_MouseMove);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHelp.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.question;
            this.btnHelp.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHelp.ButtonText = "";
            this.btnHelp.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.CornerRadius = 15;
            this.btnHelp.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHelp.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnHelp.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnHelp.Location = new System.Drawing.Point(320, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 50);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.cancel;
            this.btnClose.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnClose.ButtonText = "";
            this.btnClose.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnClose.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.CornerRadius = 15;
            this.btnClose.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnClose.Location = new System.Drawing.Point(382, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb1.Location = new System.Drawing.Point(21, 59);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(397, 56);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "TECH-LINK SILICONES";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(70, 115);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(291, 23);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "https://www.tech-link.com.hk/en";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchChangeMode
            // 
            this.switchChangeMode.BackColor = System.Drawing.Color.Transparent;
            this.switchChangeMode.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchChangeMode.HandleOnColor = System.Drawing.Color.Gold;
            this.switchChangeMode.Location = new System.Drawing.Point(243, 160);
            this.switchChangeMode.Name = "switchChangeMode";
            this.switchChangeMode.OffColor = System.Drawing.Color.DarkGray;
            this.switchChangeMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.switchChangeMode.Size = new System.Drawing.Size(60, 30);
            this.switchChangeMode.SwitchState = XanderUI.XUISwitch.State.Off;
            this.switchChangeMode.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.switchChangeMode.TabIndex = 16;
            this.switchChangeMode.Text = "xuiSwitch1";
            this.switchChangeMode.Click += new System.EventHandler(this.switchChangeMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đăng nhập để chỉnh sửa?";
            // 
            // MainLoginView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchChangeMode);
            this.Controls.Add(this.btnLogTV);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.gbxPassword);
            this.Controls.Add(this.gbxUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainLoginView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập 登录";
            this.Load += new System.EventHandler(this.MainLoginView_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainLoginView_MouseMove);
            this.gbxPassword.ResumeLayout(false);
            this.gbxPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxUsername.ResumeLayout(false);
            this.gbxUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton btnLogTV;
        private System.Windows.Forms.Label lbLoginName;
        private XanderUI.XUIButton btnLogin;
        private System.Windows.Forms.Panel panelPicture;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.GroupBox gbxPassword;
        private System.Windows.Forms.PictureBox btnShowPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnHelp;
        private XanderUI.XUISwitch switchChangeMode;
        private System.Windows.Forms.Label label1;
    }
}

