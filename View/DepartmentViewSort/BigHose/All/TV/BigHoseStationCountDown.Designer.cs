namespace techlink_new_all_in_one
{
    partial class BigHoseStationCountDown
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new XanderUI.XUIButton();
            this.btnMinimize = new XanderUI.XUIButton();
            this.btnClose = new XanderUI.XUIButton();
            this.flowlpCDProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnHome);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1183, 80);
            this.panelTitleBar.TabIndex = 18;
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = global::techlink_new_all_in_one.Properties.Resources.LogoTechlinkN;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(229, 80);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 15;
            this.btnHome.TabStop = false;
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
            this.btnMaximize.Location = new System.Drawing.Point(1098, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 35);
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnMinimize.Location = new System.Drawing.Point(1054, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnClose.Location = new System.Drawing.Point(1142, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // flowlpCDProducts
            // 
            this.flowlpCDProducts.BackColor = System.Drawing.Color.Cyan;
            this.flowlpCDProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowlpCDProducts.Location = new System.Drawing.Point(0, 80);
            this.flowlpCDProducts.Name = "flowlpCDProducts";
            this.flowlpCDProducts.Size = new System.Drawing.Size(1183, 567);
            this.flowlpCDProducts.TabIndex = 19;
            // 
            // BigHoseStationCountDown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1183, 647);
            this.Controls.Add(this.flowlpCDProducts);
            this.Controls.Add(this.panelTitleBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BigHoseStationCountDown";
            this.Text = "BigHoseStationCountDown";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BigHoseStationCountDown_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private XanderUI.XUIButton btnMaximize;
        private XanderUI.XUIButton btnMinimize;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowlpCDProducts;
    }
}