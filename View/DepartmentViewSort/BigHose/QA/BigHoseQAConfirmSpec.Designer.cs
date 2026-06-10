namespace techlink_new_all_in_one
{
    partial class BigHoseQAConfirmSpec
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
            this.btn_ConfirmSpec = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnChooseDirectory = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLotNo = new System.Windows.Forms.TextBox();
            this.lbAnnounce = new System.Windows.Forms.Label();
            this.cbx_PrinterSelect = new System.Windows.Forms.ComboBox();
            this.cbx_SelectPrinterName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConfirmSpec
            // 
            this.btn_ConfirmSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConfirmSpec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ConfirmSpec.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.check;
            this.btn_ConfirmSpec.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_ConfirmSpec.ButtonText = "Xác nhận 断言";
            this.btn_ConfirmSpec.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_ConfirmSpec.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_ConfirmSpec.CornerRadius = 7;
            this.btn_ConfirmSpec.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmSpec.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ConfirmSpec.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_ConfirmSpec.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_ConfirmSpec.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ConfirmSpec.Location = new System.Drawing.Point(715, 196);
            this.btn_ConfirmSpec.Name = "btn_ConfirmSpec";
            this.btn_ConfirmSpec.Size = new System.Drawing.Size(198, 61);
            this.btn_ConfirmSpec.TabIndex = 3;
            this.btn_ConfirmSpec.TextColor = System.Drawing.Color.Black;
            this.btn_ConfirmSpec.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ConfirmSpec.Click += new System.EventHandler(this.btn_ConfirmSpec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập số lương PQC \r\n输入PQC工资金额";
            this.label1.Visible = false;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(182, 110);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 25);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.Visible = false;
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDirectory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChooseDirectory.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.control;
            this.btnChooseDirectory.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChooseDirectory.ButtonText = "Set data file";
            this.btnChooseDirectory.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChooseDirectory.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseDirectory.CornerRadius = 12;
            this.btnChooseDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDirectory.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseDirectory.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChooseDirectory.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseDirectory.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnChooseDirectory.Location = new System.Drawing.Point(919, 9);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(74, 39);
            this.btnChooseDirectory.TabIndex = 29;
            this.btnChooseDirectory.TextColor = System.Drawing.Color.Black;
            this.btnChooseDirectory.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nhập số lot:\r\n输入批号";
            // 
            // tbLotNo
            // 
            this.tbLotNo.Location = new System.Drawing.Point(119, 170);
            this.tbLotNo.Name = "tbLotNo";
            this.tbLotNo.Size = new System.Drawing.Size(169, 25);
            this.tbLotNo.TabIndex = 31;
            // 
            // lbAnnounce
            // 
            this.lbAnnounce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnnounce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAnnounce.Location = new System.Drawing.Point(10, 9);
            this.lbAnnounce.Name = "lbAnnounce";
            this.lbAnnounce.Size = new System.Drawing.Size(903, 87);
            this.lbAnnounce.TabIndex = 32;
            this.lbAnnounce.Text = "...";
            this.lbAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_PrinterSelect
            // 
            this.cbx_PrinterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_PrinterSelect.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PrinterSelect.FormattingEnabled = true;
            this.cbx_PrinterSelect.Items.AddRange(new object[] {
            "Raw Command",
            "BIXOLON Printer"});
            this.cbx_PrinterSelect.Location = new System.Drawing.Point(91, 230);
            this.cbx_PrinterSelect.Name = "cbx_PrinterSelect";
            this.cbx_PrinterSelect.Size = new System.Drawing.Size(163, 27);
            this.cbx_PrinterSelect.TabIndex = 33;
            // 
            // cbx_SelectPrinterName
            // 
            this.cbx_SelectPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SelectPrinterName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SelectPrinterName.FormattingEnabled = true;
            this.cbx_SelectPrinterName.Items.AddRange(new object[] {
            "TES Printer",
            "BIXOLON Printer"});
            this.cbx_SelectPrinterName.Location = new System.Drawing.Point(91, 276);
            this.cbx_SelectPrinterName.Name = "cbx_SelectPrinterName";
            this.cbx_SelectPrinterName.Size = new System.Drawing.Size(290, 27);
            this.cbx_SelectPrinterName.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Chế độ in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Máy in";
            // 
            // BigHoseQAConfirmSpec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_SelectPrinterName);
            this.Controls.Add(this.cbx_PrinterSelect);
            this.Controls.Add(this.lbAnnounce);
            this.Controls.Add(this.tbLotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConfirmSpec);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BigHoseQAConfirmSpec";
            this.Text = "BigHoseQAConfirmSpec";
            this.Load += new System.EventHandler(this.BigHoseQAConfirmSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton btn_ConfirmSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private XanderUI.XUIButton btnChooseDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLotNo;
        private System.Windows.Forms.Label lbAnnounce;
        private System.Windows.Forms.ComboBox cbx_PrinterSelect;
        private System.Windows.Forms.ComboBox cbx_SelectPrinterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}