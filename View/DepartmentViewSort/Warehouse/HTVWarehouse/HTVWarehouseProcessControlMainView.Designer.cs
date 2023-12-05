namespace techlink_new_all_in_one
{
    partial class HTVWarehouseProcessControlMainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSetting = new XanderUI.XUIButton();
            this.btnImportFormula = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioScale = new System.Windows.Forms.RadioButton();
            this.radioScan = new System.Windows.Forms.RadioButton();
            this.dtgvMaterialInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveExcel = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetting.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.control;
            this.btnSetting.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetting.ButtonText = "Setting";
            this.btnSetting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.CornerRadius = 5;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnSetting.Location = new System.Drawing.Point(251, 589);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(42, 41);
            this.btnSetting.TabIndex = 32;
            this.btnSetting.TextColor = System.Drawing.Color.Black;
            this.btnSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnImportFormula
            // 
            this.btnImportFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFormula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImportFormula.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnImportFormula.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImportFormula.ButtonText = "Nhập thêm công thức";
            this.btnImportFormula.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImportFormula.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportFormula.CornerRadius = 5;
            this.btnImportFormula.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFormula.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportFormula.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImportFormula.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportFormula.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImportFormula.Location = new System.Drawing.Point(10, 571);
            this.btnImportFormula.Name = "btnImportFormula";
            this.btnImportFormula.Size = new System.Drawing.Size(235, 60);
            this.btnImportFormula.TabIndex = 37;
            this.btnImportFormula.TextColor = System.Drawing.Color.Black;
            this.btnImportFormula.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportFormula.Click += new System.EventHandler(this.btnImportFormula_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.radioScale);
            this.panel2.Controls.Add(this.btnImportFormula);
            this.panel2.Controls.Add(this.radioScan);
            this.panel2.Controls.Add(this.dtgvMaterialInfo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSaveExcel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 644);
            this.panel2.TabIndex = 38;
            // 
            // radioScale
            // 
            this.radioScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioScale.AutoSize = true;
            this.radioScale.Location = new System.Drawing.Point(857, 192);
            this.radioScale.Name = "radioScale";
            this.radioScale.Size = new System.Drawing.Size(135, 44);
            this.radioScale.TabIndex = 37;
            this.radioScale.TabStop = true;
            this.radioScale.Text = "Cân khối lượng\r\n称量质量";
            this.radioScale.UseVisualStyleBackColor = true;
            // 
            // radioScan
            // 
            this.radioScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioScan.AutoSize = true;
            this.radioScan.Checked = true;
            this.radioScan.Location = new System.Drawing.Point(856, 127);
            this.radioScan.Name = "radioScan";
            this.radioScan.Size = new System.Drawing.Size(88, 44);
            this.radioScan.TabIndex = 42;
            this.radioScan.TabStop = true;
            this.radioScan.Text = "Chỉ scan\r\n仅扫描";
            this.radioScan.UseVisualStyleBackColor = true;
            // 
            // dtgvMaterialInfo
            // 
            this.dtgvMaterialInfo.AllowUserToAddRows = false;
            this.dtgvMaterialInfo.AllowUserToDeleteRows = false;
            this.dtgvMaterialInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMaterialInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMaterialInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMaterialInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaterialInfo.EnableHeadersVisualStyles = false;
            this.dtgvMaterialInfo.Location = new System.Drawing.Point(10, 127);
            this.dtgvMaterialInfo.Name = "dtgvMaterialInfo";
            this.dtgvMaterialInfo.ReadOnly = true;
            this.dtgvMaterialInfo.RowHeadersVisible = false;
            this.dtgvMaterialInfo.RowHeadersWidth = 51;
            this.dtgvMaterialInfo.RowTemplate.Height = 45;
            this.dtgvMaterialInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMaterialInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMaterialInfo.Size = new System.Drawing.Size(840, 438);
            this.dtgvMaterialInfo.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Location = new System.Drawing.Point(166, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 68);
            this.panel3.TabIndex = 37;
            // 
            // lbDisplay
            // 
            this.lbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(0, 0);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(825, 68);
            this.lbDisplay.TabIndex = 36;
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 44);
            this.label2.TabIndex = 35;
            this.label2.Text = "Công thức - Số lô:\r\n配方-批号:";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveExcel.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.printer;
            this.btnSaveExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSaveExcel.ButtonText = "Lưu Excel";
            this.btnSaveExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSaveExcel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.CornerRadius = 5;
            this.btnSaveExcel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSaveExcel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveExcel.Location = new System.Drawing.Point(753, 570);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(238, 60);
            this.btnSaveExcel.TabIndex = 33;
            this.btnSaveExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông tin nguyên vật liệu:\r\n原材料信息:";
            // 
            // HTVWarehouseProcessControlMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HTVWarehouseProcessControlMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HTVWarehouseProcessControlMainView";
            this.Load += new System.EventHandler(this.HTVWarehouseProcessControlMainView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaterialInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnImportFormula;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnSetting;
        private XanderUI.XUIButton btnSaveExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.DataGridView dtgvMaterialInfo;
        private System.Windows.Forms.RadioButton radioScan;
        private System.Windows.Forms.RadioButton radioScale;
    }
}