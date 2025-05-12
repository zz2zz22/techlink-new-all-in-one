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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalaryMainView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.panelExplainMain = new System.Windows.Forms.Panel();
            this.btnStartCalculate = new XanderUI.XUIButton();
            this.btnImportHRData = new XanderUI.XUIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxSettingSheet = new System.Windows.Forms.GroupBox();
            this.cbxChooseReturnTax = new System.Windows.Forms.ComboBox();
            this.cbxChooseBonus = new System.Windows.Forms.ComboBox();
            this.cbxChooseKPI = new System.Windows.Forms.ComboBox();
            this.cbxChooseUpdateInfo = new System.Windows.Forms.ComboBox();
            this.btnImportSalaryBase = new XanderUI.XUIButton();
            this.panelNoteExplain = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNoteTextUpdate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChooseBasicInfoSheet = new System.Windows.Forms.ComboBox();
            this.taxPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.panelExplainMain.SuspendLayout();
            this.groupBoxSettingSheet.SuspendLayout();
            this.panelNoteExplain.SuspendLayout();
            this.panelNoteTextUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.taxPage);
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
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxMain, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSettingSheet, 1, 0);
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
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.panelExplainMain);
            this.groupBoxMain.Controls.Add(this.btnStartCalculate);
            this.groupBoxMain.Controls.Add(this.btnImportHRData);
            this.groupBoxMain.Controls.Add(this.label9);
            this.groupBoxMain.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(445, 599);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Thao tác chính 主要经营";
            // 
            // panelExplainMain
            // 
            this.panelExplainMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExplainMain.Controls.Add(this.dataGridView1);
            this.panelExplainMain.Location = new System.Drawing.Point(10, 38);
            this.panelExplainMain.Name = "panelExplainMain";
            this.panelExplainMain.Size = new System.Drawing.Size(429, 393);
            this.panelExplainMain.TabIndex = 4;
            // 
            // btnStartCalculate
            // 
            this.btnStartCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCalculate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartCalculate.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.excel;
            this.btnStartCalculate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnStartCalculate.ButtonText = "Button";
            this.btnStartCalculate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnStartCalculate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStartCalculate.CornerRadius = 5;
            this.btnStartCalculate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartCalculate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnStartCalculate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStartCalculate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnStartCalculate.Location = new System.Drawing.Point(230, 517);
            this.btnStartCalculate.Name = "btnStartCalculate";
            this.btnStartCalculate.Size = new System.Drawing.Size(209, 70);
            this.btnStartCalculate.TabIndex = 3;
            this.btnStartCalculate.TextColor = System.Drawing.Color.Black;
            this.btnStartCalculate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartCalculate.Click += new System.EventHandler(this.btnStartCalculate_Click);
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
            this.btnImportHRData.Location = new System.Drawing.Point(10, 517);
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
            this.label9.Location = new System.Drawing.Point(11, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 38);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhập file thông tin chấm công từ \"TongXiang\":\r\n从\"TongXiang\"导入计时信息文件：";
            // 
            // groupBoxSettingSheet
            // 
            this.groupBoxSettingSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettingSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseReturnTax);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseBonus);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseKPI);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseUpdateInfo);
            this.groupBoxSettingSheet.Controls.Add(this.btnImportSalaryBase);
            this.groupBoxSettingSheet.Controls.Add(this.panelNoteExplain);
            this.groupBoxSettingSheet.Controls.Add(this.label1);
            this.groupBoxSettingSheet.Controls.Add(this.label7);
            this.groupBoxSettingSheet.Controls.Add(this.label6);
            this.groupBoxSettingSheet.Controls.Add(this.label5);
            this.groupBoxSettingSheet.Controls.Add(this.panelNoteTextUpdate);
            this.groupBoxSettingSheet.Controls.Add(this.label3);
            this.groupBoxSettingSheet.Controls.Add(this.label2);
            this.groupBoxSettingSheet.Controls.Add(this.cbxChooseBasicInfoSheet);
            this.groupBoxSettingSheet.Location = new System.Drawing.Point(454, 3);
            this.groupBoxSettingSheet.Name = "groupBoxSettingSheet";
            this.groupBoxSettingSheet.Size = new System.Drawing.Size(534, 599);
            this.groupBoxSettingSheet.TabIndex = 4;
            this.groupBoxSettingSheet.TabStop = false;
            this.groupBoxSettingSheet.Text = "Cài đặt sheet 安装床单";
            // 
            // cbxChooseReturnTax
            // 
            this.cbxChooseReturnTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseReturnTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseReturnTax.FormattingEnabled = true;
            this.cbxChooseReturnTax.Location = new System.Drawing.Point(251, 517);
            this.cbxChooseReturnTax.Name = "cbxChooseReturnTax";
            this.cbxChooseReturnTax.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseReturnTax.TabIndex = 18;
            // 
            // cbxChooseBonus
            // 
            this.cbxChooseBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseBonus.FormattingEnabled = true;
            this.cbxChooseBonus.Location = new System.Drawing.Point(251, 455);
            this.cbxChooseBonus.Name = "cbxChooseBonus";
            this.cbxChooseBonus.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseBonus.TabIndex = 17;
            // 
            // cbxChooseKPI
            // 
            this.cbxChooseKPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseKPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseKPI.FormattingEnabled = true;
            this.cbxChooseKPI.Location = new System.Drawing.Point(251, 393);
            this.cbxChooseKPI.Name = "cbxChooseKPI";
            this.cbxChooseKPI.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseKPI.TabIndex = 16;
            // 
            // cbxChooseUpdateInfo
            // 
            this.cbxChooseUpdateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseUpdateInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseUpdateInfo.FormattingEnabled = true;
            this.cbxChooseUpdateInfo.Location = new System.Drawing.Point(251, 273);
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
            // panelNoteExplain
            // 
            this.panelNoteExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteExplain.Controls.Add(this.label10);
            this.panelNoteExplain.Controls.Add(this.label8);
            this.panelNoteExplain.Location = new System.Drawing.Point(10, 123);
            this.panelNoteExplain.Name = "panelNoteExplain";
            this.panelNoteExplain.Size = new System.Drawing.Size(512, 80);
            this.panelNoteExplain.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 46);
            this.label10.TabIndex = 6;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(512, 80);
            this.label8.TabIndex = 5;
            this.label8.Text = "* Chọn các sheet (bảng tính) trong file nhập ở trên cho các mục ở dưới\r\n* 在上面的输入文" +
    "件中选择以下项目的工作表（电子表格）";
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
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sheet có hoàn thuế TNCN:\r\n表有个人所得税退税：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sheet có thưởng phạt nhân sự:\r\n表对人员有奖惩：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sheet có tiền thưởng, phụ cấp:\r\n选择包含奖金和津贴的表格：";
            // 
            // panelNoteTextUpdate
            // 
            this.panelNoteTextUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteTextUpdate.Controls.Add(this.label4);
            this.panelNoteTextUpdate.Location = new System.Drawing.Point(10, 314);
            this.panelNoteTextUpdate.Name = "panelNoteTextUpdate";
            this.panelNoteTextUpdate.Size = new System.Drawing.Size(512, 64);
            this.panelNoteTextUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Thông tin cập nhật bao gồm phép năm, trợ cấp thôi việc, điều chỉnh lương, bồi th" +
    "ường hợp đồng)\r\n（更新信息包括年度许可、遣散费支持、薪资调整、定期补偿）";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sheet có thông tin cập nhật:\r\n表已更新信息：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sheet có thông tin lương nhân viên:\r\n表有员工工资信息：";
            // 
            // cbxChooseBasicInfoSheet
            // 
            this.cbxChooseBasicInfoSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChooseBasicInfoSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseBasicInfoSheet.FormattingEnabled = true;
            this.cbxChooseBasicInfoSheet.Location = new System.Drawing.Point(290, 209);
            this.cbxChooseBasicInfoSheet.Name = "cbxChooseBasicInfoSheet";
            this.cbxChooseBasicInfoSheet.Size = new System.Drawing.Size(207, 28);
            this.cbxChooseBasicInfoSheet.TabIndex = 3;
            // 
            // taxPage
            // 
            this.taxPage.BackColor = System.Drawing.Color.Cyan;
            this.taxPage.Location = new System.Drawing.Point(4, 29);
            this.taxPage.Name = "taxPage";
            this.taxPage.Padding = new System.Windows.Forms.Padding(3);
            this.taxPage.Size = new System.Drawing.Size(997, 611);
            this.taxPage.TabIndex = 1;
            this.taxPage.Text = "Cài đặt thuế 税务设置";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 393);
            this.dataGridView1.TabIndex = 0;
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
            this.panelExplainMain.ResumeLayout(false);
            this.groupBoxSettingSheet.ResumeLayout(false);
            this.groupBoxSettingSheet.PerformLayout();
            this.panelNoteExplain.ResumeLayout(false);
            this.panelNoteTextUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage taxPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private XanderUI.XUIButton btnImportSalaryBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSettingSheet;
        private System.Windows.Forms.ComboBox cbxChooseBasicInfoSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelNoteTextUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelNoteExplain;
        private System.Windows.Forms.Label label8;
        private XanderUI.XUIButton btnImportHRData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelExplainMain;
        private XanderUI.XUIButton btnStartCalculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxChooseUpdateInfo;
        private System.Windows.Forms.ComboBox cbxChooseKPI;
        private System.Windows.Forms.ComboBox cbxChooseBonus;
        private System.Windows.Forms.ComboBox cbxChooseReturnTax;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}