namespace techlink_new_all_in_one
{
    partial class HTVQAMaterialTestReportMainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTVQAMaterialTestReportMainView));
            this.btnSave = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbxChooseDataSheet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportData = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txbReportTitle = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Nhập dữ liệu 输入数据";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(179, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 64);
            this.btnSave.TabIndex = 34;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nhập file dữ liệu test:\r\n上传测试数据文件:";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(12, 277);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(34, 44);
            this.lb10.TabIndex = 38;
            this.lb10.Text = "Từ:\r\n从:";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(298, 277);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(48, 44);
            this.lb11.TabIndex = 39;
            this.lb11.Text = "Đến:\r\n到:";
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(62, 273);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(230, 27);
            this.dtpDateIn.TabIndex = 36;
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(352, 273);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(257, 27);
            this.dtpDateOut.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 40);
            this.label2.TabIndex = 40;
            this.label2.Text = "Chọn thời gian cần xem dữ liệu:\r\n选择时间查看数据:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1005, 222);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // cbxChooseDataSheet
            // 
            this.cbxChooseDataSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseDataSheet.FormattingEnabled = true;
            this.cbxChooseDataSheet.Location = new System.Drawing.Point(317, 418);
            this.cbxChooseDataSheet.Name = "cbxChooseDataSheet";
            this.cbxChooseDataSheet.Size = new System.Drawing.Size(265, 28);
            this.cbxChooseDataSheet.TabIndex = 42;
            this.cbxChooseDataSheet.SelectionChangeCommitted += new System.EventHandler(this.cbxChooseDataSheet_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 40);
            this.label3.TabIndex = 43;
            this.label3.Text = "Chọn bảng tính có chứa dữ liệu cần thiết:\r\n选择包含必要数据的电子表格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 40);
            this.label4.TabIndex = 44;
            this.label4.Text = "Xuất dữ liệu thống kê và biểu đồ:\r\n导出统计数据和图表:\r\n";
            // 
            // btnExportData
            // 
            this.btnExportData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExportData.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.excel;
            this.btnExportData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnExportData.ButtonText = "Xuất báo biểu 报纸";
            this.btnExportData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExportData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExportData.CornerRadius = 5;
            this.btnExportData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExportData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnExportData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExportData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExportData.Location = new System.Drawing.Point(261, 527);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(220, 64);
            this.btnExportData.TabIndex = 45;
            this.btnExportData.TextColor = System.Drawing.Color.Black;
            this.btnExportData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 40);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tên bảng báo cáo:\r\n报告名称";
            // 
            // txbReportTitle
            // 
            this.txbReportTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txbReportTitle.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbReportTitle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbReportTitle.BorderRadius = 0;
            this.txbReportTitle.BorderSize = 2;
            this.txbReportTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReportTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txbReportTitle.Location = new System.Drawing.Point(162, 470);
            this.txbReportTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txbReportTitle.Multiline = false;
            this.txbReportTitle.Name = "txbReportTitle";
            this.txbReportTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbReportTitle.PasswordChar = false;
            this.txbReportTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbReportTitle.PlaceholderText = "";
            this.txbReportTitle.Size = new System.Drawing.Size(319, 36);
            this.txbReportTitle.TabIndex = 47;
            this.txbReportTitle.Texts = "";
            this.txbReportTitle.UnderlinedStyle = false;
            // 
            // HTVQAMaterialTestReportMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.txbReportTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxChooseDataSheet);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.dtpDateIn);
            this.Controls.Add(this.dtpDateOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HTVQAMaterialTestReportMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HTVQAMaterialTestReportMainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbxChooseDataSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton btnExportData;
        private System.Windows.Forms.Label label5;
        private View.CustomControl.CTTextBox txbReportTitle;
    }
}