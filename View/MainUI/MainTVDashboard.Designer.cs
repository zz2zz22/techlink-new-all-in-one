namespace techlink_new_all_in_one
{
    partial class MainTVDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTVDashboard));
            this.flpToolButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new XanderUI.XUIButton();
            this.btnMinimize = new XanderUI.XUIButton();
            this.btnClose = new XanderUI.XUIButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.txbSearchTool = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpToolButtons
            // 
            this.flpToolButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpToolButtons.AutoScroll = true;
            this.flpToolButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpToolButtons.Location = new System.Drawing.Point(3, 50);
            this.flpToolButtons.Name = "flpToolButtons";
            this.flpToolButtons.Padding = new System.Windows.Forms.Padding(10);
            this.flpToolButtons.Size = new System.Drawing.Size(819, 431);
            this.flpToolButtons.TabIndex = 14;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.lbVersion);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 573);
            this.panelMenu.TabIndex = 16;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(3, 545);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(60, 19);
            this.lbVersion.TabIndex = 11;
            this.lbVersion.Text = "label1";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 89);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(211, 81);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(825, 80);
            this.panelTitleBar.TabIndex = 17;
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.maximized;
            this.btnMaximize.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMaximize.ButtonText = "";
            this.btnMaximize.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.CornerRadius = 15;
            this.btnMaximize.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaximize.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnMaximize.Location = new System.Drawing.Point(740, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 35);
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.minimize_button;
            this.btnMinimize.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.CornerRadius = 15;
            this.btnMinimize.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnMinimize.Location = new System.Drawing.Point(696, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnClose.Location = new System.Drawing.Point(784, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(825, 9);
            this.panelShadow.TabIndex = 18;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Cyan;
            this.panelDesktop.Controls.Add(this.txbSearchTool);
            this.panelDesktop.Controls.Add(this.flpToolButtons);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(825, 484);
            this.panelDesktop.TabIndex = 19;
            // 
            // txbSearchTool
            // 
            this.txbSearchTool.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchTool.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txbSearchTool.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.txbSearchTool.BorderRadius = 12;
            this.txbSearchTool.BorderSize = 2;
            this.txbSearchTool.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTool.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchTool.Location = new System.Drawing.Point(7, 7);
            this.txbSearchTool.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchTool.Multiline = false;
            this.txbSearchTool.Name = "txbSearchTool";
            this.txbSearchTool.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchTool.PasswordChar = false;
            this.txbSearchTool.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchTool.PlaceholderText = "Tìm công cụ 查找工具";
            this.txbSearchTool.Size = new System.Drawing.Size(555, 36);
            this.txbSearchTool.TabIndex = 13;
            this.txbSearchTool.Texts = "";
            this.txbSearchTool.UnderlinedStyle = false;
            this.txbSearchTool._TextChanged += new System.EventHandler(this.txbSearchTool__TextChanged);
            this.txbSearchTool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchTool_KeyDown);
            // 
            // MainTVDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1045, 573);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainTVDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo TV 电视报道";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainTVDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpToolButtons;
        private View.CustomControl.CTTextBox txbSearchTool;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private XanderUI.XUIButton btnMaximize;
        private XanderUI.XUIButton btnMinimize;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}