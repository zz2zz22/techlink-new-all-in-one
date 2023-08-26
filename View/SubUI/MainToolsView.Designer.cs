namespace techlink_new_all_in_one.View.SubUI
{
    partial class MainToolsView
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
            this.flpToolButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTools = new XanderUI.XUIButton();
            this.txbSearchTool = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.SuspendLayout();
            // 
            // flpToolButtons
            // 
            this.flpToolButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpToolButtons.AutoScroll = true;
            this.flpToolButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpToolButtons.Location = new System.Drawing.Point(12, 56);
            this.flpToolButtons.Name = "flpToolButtons";
            this.flpToolButtons.Padding = new System.Windows.Forms.Padding(10);
            this.flpToolButtons.Size = new System.Drawing.Size(923, 490);
            this.flpToolButtons.TabIndex = 3;
            // 
            // btnAddTools
            // 
            this.btnAddTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTools.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddTools.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.plus;
            this.btnAddTools.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddTools.ButtonText = "";
            this.btnAddTools.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnAddTools.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTools.CornerRadius = 15;
            this.btnAddTools.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddTools.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddTools.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTools.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnAddTools.Location = new System.Drawing.Point(881, 3);
            this.btnAddTools.Name = "btnAddTools";
            this.btnAddTools.Size = new System.Drawing.Size(54, 47);
            this.btnAddTools.TabIndex = 12;
            this.btnAddTools.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTools.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddTools.Click += new System.EventHandler(this.btnAddTools_Click);
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
            this.txbSearchTool.Location = new System.Drawing.Point(13, 13);
            this.txbSearchTool.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchTool.Multiline = false;
            this.txbSearchTool.Name = "txbSearchTool";
            this.txbSearchTool.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchTool.PasswordChar = false;
            this.txbSearchTool.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchTool.PlaceholderText = "Tìm công cụ 查找工具";
            this.txbSearchTool.Size = new System.Drawing.Size(555, 36);
            this.txbSearchTool.TabIndex = 2;
            this.txbSearchTool.Texts = "";
            this.txbSearchTool.UnderlinedStyle = false;
            this.txbSearchTool._TextChanged += new System.EventHandler(this.txbSearchTool__TextChanged);
            this.txbSearchTool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchTool_KeyDown);
            // 
            // MainToolsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(947, 558);
            this.Controls.Add(this.btnAddTools);
            this.Controls.Add(this.flpToolButtons);
            this.Controls.Add(this.txbSearchTool);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainToolsView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainToolsView";
            this.Load += new System.EventHandler(this.MainToolsView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.CTTextBox txbSearchTool;
        private System.Windows.Forms.FlowLayoutPanel flpToolButtons;
        private XanderUI.XUIButton btnAddTools;
    }
}