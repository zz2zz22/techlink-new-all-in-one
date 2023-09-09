namespace techlink_new_all_in_one
{
    partial class BigHoseDailyTargetInput
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
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.btnImportProductTarget = new XanderUI.XUIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.productTargetList = new System.Windows.Forms.DataGridView();
            this.btnBrowseProductTarget = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.btnImportProductCD = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCDSheets = new System.Windows.Forms.ComboBox();
            this.productCDList = new System.Windows.Forms.DataGridView();
            this.btnBrowseCDSetting = new System.Windows.Forms.Button();
            this.txbCDFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTargetList)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCDList)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage3);
            this.xuiFlatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.OnlyTopLine = true;
            this.xuiFlatTab1.PageColor = System.Drawing.Color.Cyan;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1005, 644);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cyan;
            this.tabPage1.Controls.Add(this.xuiCustomGroupbox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(997, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Target mã hàng 目标项目代码";
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.Gray;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.btnImportProductTarget);
            this.xuiCustomGroupbox1.Controls.Add(this.label8);
            this.xuiCustomGroupbox1.Controls.Add(this.cboSheet);
            this.xuiCustomGroupbox1.Controls.Add(this.productTargetList);
            this.xuiCustomGroupbox1.Controls.Add(this.btnBrowseProductTarget);
            this.xuiCustomGroupbox1.Controls.Add(this.txtFilename);
            this.xuiCustomGroupbox1.Controls.Add(this.label1);
            this.xuiCustomGroupbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.Padding = new System.Windows.Forms.Padding(1);
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(997, 620);
            this.xuiCustomGroupbox1.TabIndex = 2;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Nhập target mã hàng 输入目标商品代码";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.Maroon;
            // 
            // btnImportProductTarget
            // 
            this.btnImportProductTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportProductTarget.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImportProductTarget.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.download;
            this.btnImportProductTarget.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImportProductTarget.ButtonText = "Nhập dữ liệu";
            this.btnImportProductTarget.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImportProductTarget.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportProductTarget.CornerRadius = 10;
            this.btnImportProductTarget.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportProductTarget.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImportProductTarget.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportProductTarget.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImportProductTarget.Location = new System.Drawing.Point(734, 73);
            this.btnImportProductTarget.Name = "btnImportProductTarget";
            this.btnImportProductTarget.Size = new System.Drawing.Size(254, 64);
            this.btnImportProductTarget.TabIndex = 10;
            this.btnImportProductTarget.TextColor = System.Drawing.Color.Black;
            this.btnImportProductTarget.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportProductTarget.Click += new System.EventHandler(this.btnImportProductTarget_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sheet:";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(74, 111);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(241, 31);
            this.cboSheet.TabIndex = 8;
            this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
            // 
            // productTargetList
            // 
            this.productTargetList.AllowUserToAddRows = false;
            this.productTargetList.AllowUserToDeleteRows = false;
            this.productTargetList.AllowUserToResizeColumns = false;
            this.productTargetList.AllowUserToResizeRows = false;
            this.productTargetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTargetList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productTargetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTargetList.Location = new System.Drawing.Point(9, 147);
            this.productTargetList.Margin = new System.Windows.Forms.Padding(4);
            this.productTargetList.Name = "productTargetList";
            this.productTargetList.ReadOnly = true;
            this.productTargetList.RowHeadersVisible = false;
            this.productTargetList.RowHeadersWidth = 51;
            this.productTargetList.RowTemplate.Height = 24;
            this.productTargetList.Size = new System.Drawing.Size(979, 464);
            this.productTargetList.TabIndex = 7;
            // 
            // btnBrowseProductTarget
            // 
            this.btnBrowseProductTarget.Location = new System.Drawing.Point(564, 73);
            this.btnBrowseProductTarget.Name = "btnBrowseProductTarget";
            this.btnBrowseProductTarget.Size = new System.Drawing.Size(43, 30);
            this.btnBrowseProductTarget.TabIndex = 6;
            this.btnBrowseProductTarget.Text = "...";
            this.btnBrowseProductTarget.UseVisualStyleBackColor = true;
            this.btnBrowseProductTarget.Click += new System.EventHandler(this.btnBrowseProductTarget_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Enabled = false;
            this.txtFilename.Location = new System.Drawing.Point(8, 73);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(552, 30);
            this.txtFilename.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn file excel target:\r\n选择目标Excel文件:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Cyan;
            this.tabPage3.Controls.Add(this.xuiCustomGroupbox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 620);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Cài đặt đếm ngược 倒计时设置";
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.Gray;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.btnImportProductCD);
            this.xuiCustomGroupbox2.Controls.Add(this.label2);
            this.xuiCustomGroupbox2.Controls.Add(this.cboCDSheets);
            this.xuiCustomGroupbox2.Controls.Add(this.productCDList);
            this.xuiCustomGroupbox2.Controls.Add(this.btnBrowseCDSetting);
            this.xuiCustomGroupbox2.Controls.Add(this.txbCDFileName);
            this.xuiCustomGroupbox2.Controls.Add(this.label3);
            this.xuiCustomGroupbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(3, 3);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.Padding = new System.Windows.Forms.Padding(1);
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(991, 614);
            this.xuiCustomGroupbox2.TabIndex = 3;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Nhập cài đặt đếm ngược 输入倒计时设置";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.Maroon;
            // 
            // btnImportProductCD
            // 
            this.btnImportProductCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportProductCD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImportProductCD.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.download;
            this.btnImportProductCD.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImportProductCD.ButtonText = "Nhập dữ liệu";
            this.btnImportProductCD.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImportProductCD.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportProductCD.CornerRadius = 10;
            this.btnImportProductCD.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportProductCD.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImportProductCD.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportProductCD.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImportProductCD.Location = new System.Drawing.Point(728, 73);
            this.btnImportProductCD.Name = "btnImportProductCD";
            this.btnImportProductCD.Size = new System.Drawing.Size(254, 64);
            this.btnImportProductCD.TabIndex = 10;
            this.btnImportProductCD.TextColor = System.Drawing.Color.Black;
            this.btnImportProductCD.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportProductCD.Click += new System.EventHandler(this.btnImportProductCD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sheet:";
            // 
            // cboCDSheets
            // 
            this.cboCDSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCDSheets.FormattingEnabled = true;
            this.cboCDSheets.Location = new System.Drawing.Point(74, 111);
            this.cboCDSheets.Name = "cboCDSheets";
            this.cboCDSheets.Size = new System.Drawing.Size(241, 31);
            this.cboCDSheets.TabIndex = 8;
            this.cboCDSheets.SelectionChangeCommitted += new System.EventHandler(this.cboCDSheets_SelectionChangeCommitted);
            // 
            // productCDList
            // 
            this.productCDList.AllowUserToAddRows = false;
            this.productCDList.AllowUserToDeleteRows = false;
            this.productCDList.AllowUserToResizeColumns = false;
            this.productCDList.AllowUserToResizeRows = false;
            this.productCDList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCDList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCDList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCDList.Location = new System.Drawing.Point(9, 147);
            this.productCDList.Margin = new System.Windows.Forms.Padding(4);
            this.productCDList.Name = "productCDList";
            this.productCDList.ReadOnly = true;
            this.productCDList.RowHeadersVisible = false;
            this.productCDList.RowHeadersWidth = 51;
            this.productCDList.RowTemplate.Height = 24;
            this.productCDList.Size = new System.Drawing.Size(973, 458);
            this.productCDList.TabIndex = 7;
            // 
            // btnBrowseCDSetting
            // 
            this.btnBrowseCDSetting.Location = new System.Drawing.Point(564, 73);
            this.btnBrowseCDSetting.Name = "btnBrowseCDSetting";
            this.btnBrowseCDSetting.Size = new System.Drawing.Size(43, 30);
            this.btnBrowseCDSetting.TabIndex = 6;
            this.btnBrowseCDSetting.Text = "...";
            this.btnBrowseCDSetting.UseVisualStyleBackColor = true;
            this.btnBrowseCDSetting.Click += new System.EventHandler(this.btnBrowseCDSetting_Click);
            // 
            // txbCDFileName
            // 
            this.txbCDFileName.Enabled = false;
            this.txbCDFileName.Location = new System.Drawing.Point(8, 73);
            this.txbCDFileName.Name = "txbCDFileName";
            this.txbCDFileName.ReadOnly = true;
            this.txbCDFileName.Size = new System.Drawing.Size(552, 30);
            this.txbCDFileName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn file excel target:\r\n选择目标Excel文件:";
            // 
            // BigHoseDailyTargetInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.xuiFlatTab1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BigHoseDailyTargetInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DailyTargetInput";
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTargetList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCDList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUIButton btnImportProductTarget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.DataGridView productTargetList;
        private System.Windows.Forms.Button btnBrowseProductTarget;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private XanderUI.XUIButton btnImportProductCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCDSheets;
        private System.Windows.Forms.DataGridView productCDList;
        private System.Windows.Forms.Button btnBrowseCDSetting;
        private System.Windows.Forms.TextBox txbCDFileName;
        private System.Windows.Forms.Label label3;
    }
}