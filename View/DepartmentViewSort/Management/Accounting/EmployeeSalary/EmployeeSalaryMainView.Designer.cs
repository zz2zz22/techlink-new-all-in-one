namespace techlink_new_all_in_one
{
    partial class EmployeeSalaryMainView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnCalculateSalary = new XanderUI.XUIButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImportHRData = new XanderUI.XUIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxSettingSheet = new System.Windows.Forms.GroupBox();
            this.cbxPCCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxHRBonus = new System.Windows.Forms.ComboBox();
            this.cbxBirthdayBonus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPeriodBonus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxLateFineInfo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxChooseKPI = new System.Windows.Forms.ComboBox();
            this.cbxChooseUpdateInfo = new System.Windows.Forms.ComboBox();
            this.btnImportSalaryBase = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChooseBasicInfoSheet = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxSettingSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.Cyan;
            this.mainPage.Controls.Add(this.tableLayoutPanelMain);
            this.mainPage.Location = new System.Drawing.Point(4, 29);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(997, 611);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Trang chính 主页";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxMain, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSettingSheet, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(991, 605);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.btnCalculateSalary);
            this.groupBoxMain.Controls.Add(this.label10);
            this.groupBoxMain.Controls.Add(this.btnImportHRData);
            this.groupBoxMain.Controls.Add(this.label9);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.Location = new System.Drawing.Point(543, 3);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(445, 599);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Thao tác chính 主要经营";
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCalculateSalary.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnCalculateSalary.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCalculateSalary.ButtonText = "Button";
            this.btnCalculateSalary.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCalculateSalary.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculateSalary.CornerRadius = 5;
            this.btnCalculateSalary.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCalculateSalary.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCalculateSalary.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculateSalary.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCalculateSalary.Location = new System.Drawing.Point(10, 216);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(209, 70);
            this.btnCalculateSalary.TabIndex = 4;
            this.btnCalculateSalary.TextColor = System.Drawing.Color.Black;
            this.btnCalculateSalary.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(418, 38);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tiến hành tính lương theo bản công từ TongxiangEHR:\r\n根据公众从汤克克斯（Tongxiangehr）进行工资计" +
    "算:";
            // 
            // btnImportHRData
            // 
            this.btnImportHRData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImportHRData.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnImportHRData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImportHRData.ButtonText = "Button";
            this.btnImportHRData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImportHRData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportHRData.CornerRadius = 5;
            this.btnImportHRData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportHRData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImportHRData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportHRData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImportHRData.Location = new System.Drawing.Point(10, 79);
            this.btnImportHRData.Name = "btnImportHRData";
            this.btnImportHRData.Size = new System.Drawing.Size(209, 70);
            this.btnImportHRData.TabIndex = 2;
            this.btnImportHRData.TextColor = System.Drawing.Color.Black;
            this.btnImportHRData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportHRData.Click += new System.EventHandler(this.btnImportHRData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 38);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhập file thông tin chấm công từ \"TongXiang\":\r\n从\"TongXiang\"导入计时信息文件：";
            // 
            // groupBoxSettingSheet
            // 
            this.groupBoxSettingSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxSettingSheet.Controls.Add(this.cbxPCCC);
            this.groupBoxSettingSheet.Controls.Add(this.label8);
            this.groupBoxSettingSheet.Controls.Add(this.cbxHRBonus);
            this.groupBoxSettingSheet.Controls.Add(this.cbxBirthdayBonus);
            this.groupBoxSettingSheet.Controls.Add(this.label11);
            this.groupBoxSettingSheet.Controls.Add(this.label7);
            this.groupBoxSettingSheet.Controls.Add(this.cbxPeriodBonus);
            this.groupBoxSettingSheet.Controls.Add(this.label6);
            this.groupBoxSettingSheet.Controls.Add(this.cbxLateFineInfo);
            this.groupBoxSettingSheet.Controls.Add(this.label4);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseKPI);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseUpdateInfo);
            this.groupBoxSettingSheet.Controls.Add(this.btnImportSalaryBase);
            this.groupBoxSettingSheet.Controls.Add(this.label1);
            this.groupBoxSettingSheet.Controls.Add(this.label5);
            this.groupBoxSettingSheet.Controls.Add(this.label3);
            this.groupBoxSettingSheet.Controls.Add(this.label2);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseBasicInfoSheet);
            this.groupBoxSettingSheet.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSettingSheet.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSettingSheet.Name = "groupBoxSettingSheet";
            this.groupBoxSettingSheet.Size = new System.Drawing.Size(534, 599);
            this.groupBoxSettingSheet.TabIndex = 4;
            this.groupBoxSettingSheet.TabStop = false;
            this.groupBoxSettingSheet.Text = "Cài đặt sheet 安装床单";
            // 
            // cbxPCCC
            // 
            this.cbxPCCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPCCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPCCC.FormattingEnabled = true;
            this.cbxPCCC.Location = new System.Drawing.Point(268, 441);
            this.cbxPCCC.Name = "cbxPCCC";
            this.cbxPCCC.Size = new System.Drawing.Size(207, 28);
            this.cbxPCCC.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "PCCC:";
            // 
            // cbxHRBonus
            // 
            this.cbxHRBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHRBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHRBonus.FormattingEnabled = true;
            this.cbxHRBonus.Location = new System.Drawing.Point(268, 393);
            this.cbxHRBonus.Name = "cbxHRBonus";
            this.cbxHRBonus.Size = new System.Drawing.Size(207, 28);
            this.cbxHRBonus.TabIndex = 24;
            // 
            // cbxBirthdayBonus
            // 
            this.cbxBirthdayBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBirthdayBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBirthdayBonus.FormattingEnabled = true;
            this.cbxBirthdayBonus.Location = new System.Drawing.Point(268, 345);
            this.cbxBirthdayBonus.Name = "cbxBirthdayBonus";
            this.cbxBirthdayBonus.Size = new System.Drawing.Size(207, 28);
            this.cbxBirthdayBonus.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 38);
            this.label11.TabIndex = 22;
            this.label11.Text = "Thưởng phạt nhân sự:\r\n人事奖罚:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sinh nhật:\r\n月经:";
            // 
            // cbxPeriodBonus
            // 
            this.cbxPeriodBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPeriodBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodBonus.FormattingEnabled = true;
            this.cbxPeriodBonus.Location = new System.Drawing.Point(268, 296);
            this.cbxPeriodBonus.Name = "cbxPeriodBonus";
            this.cbxPeriodBonus.Size = new System.Drawing.Size(207, 28);
            this.cbxPeriodBonus.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "PC kinh nguyệt:\r\n月经:";
            // 
            // cbxLateFineInfo
            // 
            this.cbxLateFineInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLateFineInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLateFineInfo.FormattingEnabled = true;
            this.cbxLateFineInfo.Location = new System.Drawing.Point(268, 248);
            this.cbxLateFineInfo.Name = "cbxLateFineInfo";
            this.cbxLateFineInfo.Size = new System.Drawing.Size(207, 28);
            this.cbxLateFineInfo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đi trễ, xem cam:\r\n迟到，看相机:";
            // 
            // cbxChooseKPI
            // 
            this.cbxChooseKPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseKPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseKPI.FormattingEnabled = true;
            this.cbxChooseKPI.Location = new System.Drawing.Point(268, 152);
            this.cbxChooseKPI.Name = "cbxChooseKPI";
            this.cbxChooseKPI.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseKPI.TabIndex = 16;
            // 
            // cbxChooseUpdateInfo
            // 
            this.cbxChooseUpdateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseUpdateInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseUpdateInfo.FormattingEnabled = true;
            this.cbxChooseUpdateInfo.Location = new System.Drawing.Point(268, 199);
            this.cbxChooseUpdateInfo.Name = "cbxChooseUpdateInfo";
            this.cbxChooseUpdateInfo.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseUpdateInfo.TabIndex = 15;
            // 
            // btnImportSalaryBase
            // 
            this.btnImportSalaryBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportSalaryBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImportSalaryBase.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnImportSalaryBase.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImportSalaryBase.ButtonText = "Button";
            this.btnImportSalaryBase.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImportSalaryBase.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportSalaryBase.CornerRadius = 5;
            this.btnImportSalaryBase.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportSalaryBase.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImportSalaryBase.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImportSalaryBase.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImportSalaryBase.Location = new System.Drawing.Point(278, 38);
            this.btnImportSalaryBase.Name = "btnImportSalaryBase";
            this.btnImportSalaryBase.Size = new System.Drawing.Size(219, 60);
            this.btnImportSalaryBase.TabIndex = 1;
            this.btnImportSalaryBase.TextColor = System.Drawing.Color.Black;
            this.btnImportSalaryBase.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImportSalaryBase.Click += new System.EventHandler(this.btnImportSalaryBase_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập file thông tin lương thưởng:\r\n导入工资信息文件：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thưởng, phụ cấp:\r\n绩效,达标：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điều chỉnh lương, bồi thường HD:\r\n薪金调整，合同补偿：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dữ liệu (lương) cơ bản:\r\n基本资料：";
            // 
            // cbxChooseBasicInfoSheet
            // 
            this.cbxChooseBasicInfoSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseBasicInfoSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseBasicInfoSheet.FormattingEnabled = true;
            this.cbxChooseBasicInfoSheet.Location = new System.Drawing.Point(268, 108);
            this.cbxChooseBasicInfoSheet.Name = "cbxChooseBasicInfoSheet";
            this.cbxChooseBasicInfoSheet.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseBasicInfoSheet.TabIndex = 3;
            // 
            // EmployeeSalaryMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeSalaryMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EmployeeSalaryMainView";
            this.Load += new System.EventHandler(this.EmployeeSalaryMainView_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxSettingSheet.ResumeLayout(false);
            this.groupBoxSettingSheet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private XanderUI.XUIButton btnImportSalaryBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSettingSheet;
        private System.Windows.Forms.ComboBox cbxChooseBasicInfoSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton btnImportHRData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxChooseUpdateInfo;
        private System.Windows.Forms.ComboBox cbxChooseKPI;
        private System.Windows.Forms.Label label10;
        private XanderUI.XUIButton btnCalculateSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxLateFineInfo;
        private System.Windows.Forms.ComboBox cbxPeriodBonus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxHRBonus;
        private System.Windows.Forms.ComboBox cbxBirthdayBonus;
        private System.Windows.Forms.ComboBox cbxPCCC;
        private System.Windows.Forms.Label label8;
    }
}