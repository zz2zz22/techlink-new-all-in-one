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
            this.lbVersion = new System.Windows.Forms.Label();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.btnShowPassword = new System.Windows.Forms.PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxUsername = new System.Windows.Forms.GroupBox();
            this.cbxCompanyCode = new System.Windows.Forms.ComboBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogTV = new XanderUI.XUIButton();
            this.btnLogin = new XanderUI.XUIButton();
            this.btnHelp = new XanderUI.XUIButton();
            this.btnClose = new XanderUI.XUIButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.switchChangeMode = new XanderUI.XUISwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbxPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(3, 591);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(48, 16);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "label1";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxPassword
            // 
            this.gbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.gbxPassword.Controls.Add(this.btnShowPassword);
            this.gbxPassword.Controls.Add(this.txbPassword);
            this.gbxPassword.Controls.Add(this.pictureBox2);
            this.gbxPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPassword.Location = new System.Drawing.Point(81, 354);
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
            this.txbPassword.Location = new System.Drawing.Point(47, 39);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(259, 30);
            this.txbPassword.TabIndex = 0;
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
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
            this.gbxUsername.Controls.Add(this.cbxCompanyCode);
            this.gbxUsername.Controls.Add(this.txbUsername);
            this.gbxUsername.Controls.Add(this.pictureBox1);
            this.gbxUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUsername.Location = new System.Drawing.Point(81, 240);
            this.gbxUsername.Name = "gbxUsername";
            this.gbxUsername.Size = new System.Drawing.Size(360, 75);
            this.gbxUsername.TabIndex = 11;
            this.gbxUsername.TabStop = false;
            this.gbxUsername.Text = "Username";
            // 
            // cbxCompanyCode
            // 
            this.cbxCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompanyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompanyCode.FormattingEnabled = true;
            this.cbxCompanyCode.Items.AddRange(new object[] {
            "TL",
            "LU"});
            this.cbxCompanyCode.Location = new System.Drawing.Point(46, 36);
            this.cbxCompanyCode.Name = "cbxCompanyCode";
            this.cbxCompanyCode.Size = new System.Drawing.Size(85, 33);
            this.cbxCompanyCode.TabIndex = 0;
            this.cbxCompanyCode.SelectionChangeCommitted += new System.EventHandler(this.cbxCompanyCode_SelectionChangeCommitted);
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(137, 36);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(205, 30);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            this.txbUsername.Enter += new System.EventHandler(this.txbUsername_Enter);
            this.txbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUsername_KeyDown);
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            this.txbUsername.Leave += new System.EventHandler(this.txbUsername_Leave);
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
            this.btnLogTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogTV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.btnLogTV.Location = new System.Drawing.Point(144, 505);
            this.btnLogTV.Name = "btnLogTV";
            this.btnLogTV.Size = new System.Drawing.Size(236, 64);
            this.btnLogTV.TabIndex = 1;
            this.btnLogTV.TextColor = System.Drawing.Color.White;
            this.btnLogTV.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogTV.Click += new System.EventHandler(this.btnLogTV_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.btnLogin.Location = new System.Drawing.Point(143, 435);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 64);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TextColor = System.Drawing.Color.DimGray;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnHelp.Location = new System.Drawing.Point(402, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 50);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnClose.Location = new System.Drawing.Point(464, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Baloo Chettan 2", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb1.Location = new System.Drawing.Point(3, 3);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(384, 56);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "TECH-LINK SILICONES";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // switchChangeMode
            // 
            this.switchChangeMode.BackColor = System.Drawing.Color.Transparent;
            this.switchChangeMode.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchChangeMode.HandleOnColor = System.Drawing.Color.Gold;
            this.switchChangeMode.Location = new System.Drawing.Point(364, 318);
            this.switchChangeMode.Name = "switchChangeMode";
            this.switchChangeMode.OffColor = System.Drawing.Color.DarkGray;
            this.switchChangeMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.switchChangeMode.Size = new System.Drawing.Size(60, 30);
            this.switchChangeMode.SwitchState = XanderUI.XUISwitch.State.On;
            this.switchChangeMode.SwitchStyle = XanderUI.XUISwitch.Style.Dark;
            this.switchChangeMode.TabIndex = 16;
            this.switchChangeMode.Text = "xuiSwitch1";
            this.switchChangeMode.Click += new System.EventHandler(this.switchChangeMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đăng nhập bằng mã nhân viên?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.gbxUsername);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.gbxPassword);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogTV);
            this.panel1.Controls.Add(this.lbVersion);
            this.panel1.Controls.Add(this.switchChangeMode);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 616);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::techlink_new_all_in_one.Properties.Resources.idle;
            this.pictureBox3.Location = new System.Drawing.Point(168, 63);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // MainLoginView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 616);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIButton btnLogTV;
        private XanderUI.XUIButton btnLogin;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lb1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbxCompanyCode;
    }
}

