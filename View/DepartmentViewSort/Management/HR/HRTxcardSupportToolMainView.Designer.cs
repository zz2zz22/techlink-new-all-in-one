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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddSelectedEmployee = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_NewEmployeeData = new System.Windows.Forms.DataGridView();
            this.btnChooseHRDataFile = new XanderUI.XUIButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChangeSelectedStatus = new XanderUI.XUIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgv_ResignEmployeeData = new System.Windows.Forms.DataGridView();
            this.btnChooseResignDataFile = new XanderUI.XUIButton();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseWorkShiftArrangeFile = new XanderUI.XUIButton();
            this.dtgvEmployeeWorkShift = new System.Windows.Forms.DataGridView();
            this.btnArrangeWorkShift = new XanderUI.XUIButton();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NewEmployeeData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ResignEmployeeData)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthAdd)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeWorkShift)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Controls.Add(this.tabPage3);
            this.xuiFlatTab1.Controls.Add(this.tabPage4);
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnAddSelectedEmployee);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtgv_NewEmployeeData);
            this.tabPage2.Controls.Add(this.btnChooseHRDataFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm nhân viên mới";
            // 
            // btnAddSelectedEmployee
            // 
            this.btnAddSelectedEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelectedEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddSelectedEmployee.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.plus;
            this.btnAddSelectedEmployee.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddSelectedEmployee.ButtonText = "Thêm mới dữ liệu đang chọn";
            this.btnAddSelectedEmployee.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddSelectedEmployee.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSelectedEmployee.CornerRadius = 10;
            this.btnAddSelectedEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelectedEmployee.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddSelectedEmployee.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddSelectedEmployee.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSelectedEmployee.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddSelectedEmployee.Location = new System.Drawing.Point(795, 560);
            this.btnAddSelectedEmployee.Name = "btnAddSelectedEmployee";
            this.btnAddSelectedEmployee.Size = new System.Drawing.Size(194, 52);
            this.btnAddSelectedEmployee.TabIndex = 11;
            this.btnAddSelectedEmployee.TextColor = System.Drawing.Color.Black;
            this.btnAddSelectedEmployee.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddSelectedEmployee.Click += new System.EventHandler(this.btnAddSelectedEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách nhân viên cần nhập mới:";
            // 
            // dtgv_NewEmployeeData
            // 
            this.dtgv_NewEmployeeData.AllowUserToAddRows = false;
            this.dtgv_NewEmployeeData.AllowUserToDeleteRows = false;
            this.dtgv_NewEmployeeData.AllowUserToResizeRows = false;
            this.dtgv_NewEmployeeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_NewEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NewEmployeeData.Location = new System.Drawing.Point(8, 64);
            this.dtgv_NewEmployeeData.Name = "dtgv_NewEmployeeData";
            this.dtgv_NewEmployeeData.ReadOnly = true;
            this.dtgv_NewEmployeeData.RowHeadersVisible = false;
            this.dtgv_NewEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_NewEmployeeData.Size = new System.Drawing.Size(981, 490);
            this.dtgv_NewEmployeeData.TabIndex = 8;
            // 
            // btnChooseHRDataFile
            // 
            this.btnChooseHRDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseHRDataFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChooseHRDataFile.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnChooseHRDataFile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChooseHRDataFile.ButtonText = "Chọn file dữ liệu";
            this.btnChooseHRDataFile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChooseHRDataFile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseHRDataFile.CornerRadius = 10;
            this.btnChooseHRDataFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHRDataFile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseHRDataFile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChooseHRDataFile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseHRDataFile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChooseHRDataFile.Location = new System.Drawing.Point(795, 6);
            this.btnChooseHRDataFile.Name = "btnChooseHRDataFile";
            this.btnChooseHRDataFile.Size = new System.Drawing.Size(194, 52);
            this.btnChooseHRDataFile.TabIndex = 7;
            this.btnChooseHRDataFile.TextColor = System.Drawing.Color.Black;
            this.btnChooseHRDataFile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseHRDataFile.Click += new System.EventHandler(this.btnChooseHRDataFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnChangeSelectedStatus);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dtgv_ResignEmployeeData);
            this.tabPage3.Controls.Add(this.btnChooseResignDataFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(997, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xử lý nghỉ việc";
            // 
            // btnChangeSelectedStatus
            // 
            this.btnChangeSelectedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSelectedStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChangeSelectedStatus.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.cancel;
            this.btnChangeSelectedStatus.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChangeSelectedStatus.ButtonText = "Xử lý nghỉ việc các nhân viên đã chọn";
            this.btnChangeSelectedStatus.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChangeSelectedStatus.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeSelectedStatus.CornerRadius = 10;
            this.btnChangeSelectedStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSelectedStatus.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeSelectedStatus.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChangeSelectedStatus.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeSelectedStatus.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChangeSelectedStatus.Location = new System.Drawing.Point(725, 560);
            this.btnChangeSelectedStatus.Name = "btnChangeSelectedStatus";
            this.btnChangeSelectedStatus.Size = new System.Drawing.Size(264, 52);
            this.btnChangeSelectedStatus.TabIndex = 12;
            this.btnChangeSelectedStatus.TextColor = System.Drawing.Color.Black;
            this.btnChangeSelectedStatus.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeSelectedStatus.Click += new System.EventHandler(this.btnChangeSelectedStatus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Danh sách nhân viên nghỉ việc:";
            // 
            // dtgv_ResignEmployeeData
            // 
            this.dtgv_ResignEmployeeData.AllowUserToAddRows = false;
            this.dtgv_ResignEmployeeData.AllowUserToDeleteRows = false;
            this.dtgv_ResignEmployeeData.AllowUserToResizeRows = false;
            this.dtgv_ResignEmployeeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ResignEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ResignEmployeeData.Location = new System.Drawing.Point(10, 61);
            this.dtgv_ResignEmployeeData.Name = "dtgv_ResignEmployeeData";
            this.dtgv_ResignEmployeeData.ReadOnly = true;
            this.dtgv_ResignEmployeeData.RowHeadersVisible = false;
            this.dtgv_ResignEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ResignEmployeeData.Size = new System.Drawing.Size(981, 493);
            this.dtgv_ResignEmployeeData.TabIndex = 10;
            // 
            // btnChooseResignDataFile
            // 
            this.btnChooseResignDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseResignDataFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChooseResignDataFile.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnChooseResignDataFile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChooseResignDataFile.ButtonText = "Chọn file dữ liệu";
            this.btnChooseResignDataFile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChooseResignDataFile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseResignDataFile.CornerRadius = 10;
            this.btnChooseResignDataFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseResignDataFile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseResignDataFile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChooseResignDataFile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseResignDataFile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChooseResignDataFile.Location = new System.Drawing.Point(795, 3);
            this.btnChooseResignDataFile.Name = "btnChooseResignDataFile";
            this.btnChooseResignDataFile.Size = new System.Drawing.Size(194, 52);
            this.btnChooseResignDataFile.TabIndex = 8;
            this.btnChooseResignDataFile.TextColor = System.Drawing.Color.Black;
            this.btnChooseResignDataFile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseResignDataFile.Click += new System.EventHandler(this.btnChooseResignDataFile_Click);
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
            this.tabPage1.Text = "Cài đặt TxCard";
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
            this.label4.Size = new System.Drawing.Size(481, 40);
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
            this.txbDateIn.Size = new System.Drawing.Size(209, 34);
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
            this.label3.Size = new System.Drawing.Size(298, 40);
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
            this.txbEmployeeCode.Size = new System.Drawing.Size(209, 34);
            this.txbEmployeeCode.TabIndex = 9;
            this.txbEmployeeCode.Texts = "";
            this.txbEmployeeCode.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 407);
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
            this.label1.Location = new System.Drawing.Point(236, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 159);
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
            this.nudMonthAdd.Size = new System.Drawing.Size(212, 29);
            this.nudMonthAdd.TabIndex = 0;
            this.nudMonthAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMonthAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnArrangeWorkShift);
            this.tabPage4.Controls.Add(this.dtgvEmployeeWorkShift);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.btnChooseWorkShiftArrangeFile);
            this.tabPage4.Location = new System.Drawing.Point(4, 20);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(997, 620);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xếp ca nhân viên txcard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh sách nhân viên cần xếp ca:";
            // 
            // btnChooseWorkShiftArrangeFile
            // 
            this.btnChooseWorkShiftArrangeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseWorkShiftArrangeFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChooseWorkShiftArrangeFile.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnChooseWorkShiftArrangeFile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChooseWorkShiftArrangeFile.ButtonText = "Chọn file dữ liệu";
            this.btnChooseWorkShiftArrangeFile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChooseWorkShiftArrangeFile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseWorkShiftArrangeFile.CornerRadius = 10;
            this.btnChooseWorkShiftArrangeFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseWorkShiftArrangeFile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseWorkShiftArrangeFile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChooseWorkShiftArrangeFile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseWorkShiftArrangeFile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChooseWorkShiftArrangeFile.Location = new System.Drawing.Point(795, 3);
            this.btnChooseWorkShiftArrangeFile.Name = "btnChooseWorkShiftArrangeFile";
            this.btnChooseWorkShiftArrangeFile.Size = new System.Drawing.Size(194, 52);
            this.btnChooseWorkShiftArrangeFile.TabIndex = 12;
            this.btnChooseWorkShiftArrangeFile.TextColor = System.Drawing.Color.Black;
            this.btnChooseWorkShiftArrangeFile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChooseWorkShiftArrangeFile.Click += new System.EventHandler(this.btnChooseWorkShiftArrangeFile_Click);
            // 
            // dtgvEmployeeWorkShift
            // 
            this.dtgvEmployeeWorkShift.AllowUserToAddRows = false;
            this.dtgvEmployeeWorkShift.AllowUserToDeleteRows = false;
            this.dtgvEmployeeWorkShift.AllowUserToResizeRows = false;
            this.dtgvEmployeeWorkShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEmployeeWorkShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployeeWorkShift.Location = new System.Drawing.Point(8, 61);
            this.dtgvEmployeeWorkShift.Name = "dtgvEmployeeWorkShift";
            this.dtgvEmployeeWorkShift.ReadOnly = true;
            this.dtgvEmployeeWorkShift.RowHeadersVisible = false;
            this.dtgvEmployeeWorkShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEmployeeWorkShift.Size = new System.Drawing.Size(981, 490);
            this.dtgvEmployeeWorkShift.TabIndex = 14;
            // 
            // btnArrangeWorkShift
            // 
            this.btnArrangeWorkShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArrangeWorkShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnArrangeWorkShift.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.connection;
            this.btnArrangeWorkShift.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnArrangeWorkShift.ButtonText = "Xử lý xếp ca";
            this.btnArrangeWorkShift.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnArrangeWorkShift.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnArrangeWorkShift.CornerRadius = 10;
            this.btnArrangeWorkShift.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangeWorkShift.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnArrangeWorkShift.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnArrangeWorkShift.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnArrangeWorkShift.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnArrangeWorkShift.Location = new System.Drawing.Point(795, 557);
            this.btnArrangeWorkShift.Name = "btnArrangeWorkShift";
            this.btnArrangeWorkShift.Size = new System.Drawing.Size(194, 52);
            this.btnArrangeWorkShift.TabIndex = 15;
            this.btnArrangeWorkShift.TextColor = System.Drawing.Color.Black;
            this.btnArrangeWorkShift.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnArrangeWorkShift.Click += new System.EventHandler(this.btnArrangeWorkShift_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NewEmployeeData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ResignEmployeeData)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthAdd)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeWorkShift)).EndInit();
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
        private XanderUI.XUIButton btnChooseHRDataFile;
        private System.Windows.Forms.DataGridView dtgv_NewEmployeeData;
        private XanderUI.XUIButton btnAddSelectedEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private XanderUI.XUIButton btnChooseResignDataFile;
        private XanderUI.XUIButton btnChangeSelectedStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgv_ResignEmployeeData;
        private System.Windows.Forms.TabPage tabPage4;
        private XanderUI.XUIButton btnArrangeWorkShift;
        private System.Windows.Forms.DataGridView dtgvEmployeeWorkShift;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIButton btnChooseWorkShiftArrangeFile;
    }
}