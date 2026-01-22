namespace techlink_new_all_in_one
{
    partial class HRTxcardSupportToolMainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRTxcardSupportToolMainView));
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDateIn = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.btnUpdate = new XanderUI.XUIButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmployeeCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMonth = new XanderUI.XUIButton();
            this.nudMonthAdd = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.OnlyTopLine = true;
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1005, 644);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TxCard";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbDateIn);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbEmployeeCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay đổi trạng thái nhân viên nghỉ việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(568, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập ngày vào xưởng của nhân viên theo cú pháp (năm-tháng-ngày) \r\nVí dụ: 2025-02-" +
    "26";
            // 
            // txbDateIn
            // 
            this.txbDateIn.BackColor = System.Drawing.SystemColors.Window;
            this.txbDateIn.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDateIn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDateIn.BorderRadius = 0;
            this.txbDateIn.BorderSize = 2;
            this.txbDateIn.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDateIn.ForeColor = System.Drawing.Color.DimGray;
            this.txbDateIn.Location = new System.Drawing.Point(372, 177);
            this.txbDateIn.Margin = new System.Windows.Forms.Padding(4);
            this.txbDateIn.Multiline = false;
            this.txbDateIn.Name = "txbDateIn";
            this.txbDateIn.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDateIn.PasswordChar = false;
            this.txbDateIn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDateIn.PlaceholderText = "2025-02-26";
            this.txbDateIn.Size = new System.Drawing.Size(209, 36);
            this.txbDateIn.TabIndex = 12;
            this.txbDateIn.Texts = "";
            this.txbDateIn.UnderlinedStyle = false;
            this.txbDateIn._TextChanged += new System.EventHandler(this.txbDateIn__TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.update;
            this.btnUpdate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUpdate.ButtonText = "Cập nhật";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUpdate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.CornerRadius = 10;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUpdate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(369, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 66);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập mã nhân viên cần thay đổi trạng thái\r\n bao gồm tiền tố TL- hoặc TV-";
            // 
            // txbEmployeeCode
            // 
            this.txbEmployeeCode.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmployeeCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbEmployeeCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbEmployeeCode.BorderRadius = 0;
            this.txbEmployeeCode.BorderSize = 2;
            this.txbEmployeeCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeCode.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmployeeCode.Location = new System.Drawing.Point(372, 42);
            this.txbEmployeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmployeeCode.Multiline = false;
            this.txbEmployeeCode.Name = "txbEmployeeCode";
            this.txbEmployeeCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmployeeCode.PasswordChar = false;
            this.txbEmployeeCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmployeeCode.PlaceholderText = "TL-14042";
            this.txbEmployeeCode.Size = new System.Drawing.Size(209, 36);
            this.txbEmployeeCode.TabIndex = 9;
            this.txbEmployeeCode.Texts = "";
            this.txbEmployeeCode.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 402);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddMonth);
            this.groupBox1.Controls.Add(this.nudMonthAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bổ sung tháng Txcard";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 154);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMonth.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.plus;
            this.btnAddMonth.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddMonth.ButtonText = "Thêm tháng";
            this.btnAddMonth.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddMonth.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMonth.CornerRadius = 10;
            this.btnAddMonth.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonth.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMonth.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddMonth.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMonth.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddMonth.Location = new System.Drawing.Point(18, 83);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(212, 66);
            this.btnAddMonth.TabIndex = 6;
            this.btnAddMonth.TextColor = System.Drawing.Color.Black;
            this.btnAddMonth.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMonth.Click += new System.EventHandler(this.btnAddMonth_Click);
            // 
            // nudMonthAdd
            // 
            this.nudMonthAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonthAdd.Location = new System.Drawing.Point(18, 29);
            this.nudMonthAdd.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudMonthAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthAdd.Name = "nudMonthAdd";
            this.nudMonthAdd.Size = new System.Drawing.Size(212, 34);
            this.nudMonthAdd.TabIndex = 0;
            this.nudMonthAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMonthAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khác";
            // 
            // HRTxcardSupportToolMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.xuiFlatTab1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HRTxcardSupportToolMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HRTxcardSupportToolMainView";
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMonthAdd;
        private XanderUI.XUIButton btnAddMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private View.CustomControl.CTTextBox txbEmployeeCode;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btnUpdate;
        private System.Windows.Forms.Label label4;
        private View.CustomControl.CTTextBox txbDateIn;
    }
}