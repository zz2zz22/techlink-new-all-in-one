namespace techlink_new_all_in_one
{
    partial class ExtrusionCalenderManagementMainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtrusionCalenderManagementMainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new XanderUI.XUIButton();
            this.btnReturnMaterial = new XanderUI.XUIButton();
            this.txbEmpCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCodeList = new System.Windows.Forms.ComboBox();
            this.txbSearchCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSelectMaterial = new System.Windows.Forms.Label();
            this.btnSaveExcel = new XanderUI.XUIButton();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.dtgvHistoryList = new System.Windows.Forms.DataGridView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReturnMaterial);
            this.panel1.Controls.Add(this.txbEmpCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxCodeList);
            this.panel1.Controls.Add(this.txbSearchCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 644);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lbWeight);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(6, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 151);
            this.panel3.TabIndex = 37;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.White;
            this.lbWeight.Location = new System.Drawing.Point(213, 38);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(142, 96);
            this.lbWeight.TabIndex = 18;
            this.lbWeight.Text = "0.0";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Khối lượng (đơn vị kg):\r\n重量（公斤）：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.plus;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Lưu thông tin";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(308, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 69);
            this.btnSave.TabIndex = 3;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturnMaterial
            // 
            this.btnReturnMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturnMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturnMaterial.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.cycle;
            this.btnReturnMaterial.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReturnMaterial.ButtonText = "Trả liệu";
            this.btnReturnMaterial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReturnMaterial.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnMaterial.CornerRadius = 5;
            this.btnReturnMaterial.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMaterial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnMaterial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReturnMaterial.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnMaterial.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnReturnMaterial.Location = new System.Drawing.Point(6, 555);
            this.btnReturnMaterial.Name = "btnReturnMaterial";
            this.btnReturnMaterial.Size = new System.Drawing.Size(235, 69);
            this.btnReturnMaterial.TabIndex = 22;
            this.btnReturnMaterial.TextColor = System.Drawing.Color.Black;
            this.btnReturnMaterial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnMaterial.Click += new System.EventHandler(this.btnReturnMaterial_Click);
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.BackColor = System.Drawing.Color.Cyan;
            this.txbEmpCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbEmpCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbEmpCode.BorderRadius = 10;
            this.txbEmpCode.BorderSize = 2;
            this.txbEmpCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpCode.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmpCode.Location = new System.Drawing.Point(271, 236);
            this.txbEmpCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmpCode.Multiline = false;
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmpCode.PasswordChar = false;
            this.txbEmpCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmpCode.PlaceholderText = "TL / TV -";
            this.txbEmpCode.Size = new System.Drawing.Size(182, 36);
            this.txbEmpCode.TabIndex = 2;
            this.txbEmpCode.Texts = "";
            this.txbEmpCode.UnderlinedStyle = true;
            this.txbEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpCode_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 40);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhập mã nhân viên sản xuất:\r\n输入生产员工代码:";
            // 
            // cbxCodeList
            // 
            this.cbxCodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodeList.FormattingEnabled = true;
            this.cbxCodeList.Location = new System.Drawing.Point(11, 126);
            this.cbxCodeList.Name = "cbxCodeList";
            this.cbxCodeList.Size = new System.Drawing.Size(401, 33);
            this.cbxCodeList.TabIndex = 1;
            // 
            // txbSearchCode
            // 
            this.txbSearchCode.BackColor = System.Drawing.Color.Cyan;
            this.txbSearchCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSearchCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSearchCode.BorderRadius = 10;
            this.txbSearchCode.BorderSize = 2;
            this.txbSearchCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCode.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchCode.Location = new System.Drawing.Point(232, 12);
            this.txbSearchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchCode.Multiline = false;
            this.txbSearchCode.Name = "txbSearchCode";
            this.txbSearchCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchCode.PasswordChar = false;
            this.txbSearchCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchCode.PlaceholderText = "";
            this.txbSearchCode.Size = new System.Drawing.Size(297, 36);
            this.txbSearchCode.TabIndex = 0;
            this.txbSearchCode.Texts = "";
            this.txbSearchCode.UnderlinedStyle = false;
            this.txbSearchCode._TextChanged += new System.EventHandler(this.txbSearchCode__TextChanged);
            this.txbSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn mã hàng từ danh sách đã tìm:\r\n从搜索列表中选择项目编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập mã hàng cần tìm:\r\n输入您要查找的商品代码:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbSelectMaterial);
            this.panel2.Controls.Add(this.btnSaveExcel);
            this.panel2.Controls.Add(this.lb11);
            this.panel2.Controls.Add(this.lb10);
            this.panel2.Controls.Add(this.lb9);
            this.panel2.Controls.Add(this.dtpDateOut);
            this.panel2.Controls.Add(this.dtpDateIn);
            this.panel2.Controls.Add(this.dtgvHistoryList);
            this.panel2.Controls.Add(this.txbSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(550, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 644);
            this.panel2.TabIndex = 1;
            // 
            // lbSelectMaterial
            // 
            this.lbSelectMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectMaterial.AutoSize = true;
            this.lbSelectMaterial.Location = new System.Drawing.Point(171, 336);
            this.lbSelectMaterial.Name = "lbSelectMaterial";
            this.lbSelectMaterial.Size = new System.Drawing.Size(22, 23);
            this.lbSelectMaterial.TabIndex = 34;
            this.lbSelectMaterial.Text = "...";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveExcel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSaveExcel.ButtonImage")));
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
            this.btnSaveExcel.Location = new System.Drawing.Point(140, 555);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(301, 69);
            this.btnSaveExcel.TabIndex = 3;
            this.btnSaveExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // lb11
            // 
            this.lb11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(111, 488);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(48, 44);
            this.lb11.TabIndex = 32;
            this.lb11.Text = "Đến:\r\n到:";
            // 
            // lb10
            // 
            this.lb10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(111, 444);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(34, 44);
            this.lb10.TabIndex = 31;
            this.lb10.Text = "Từ:\r\n从:";
            // 
            // lb9
            // 
            this.lb9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb9.AutoSize = true;
            this.lb9.BackColor = System.Drawing.Color.Transparent;
            this.lb9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(111, 384);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(330, 44);
            this.lb9.TabIndex = 26;
            this.lb9.Text = "Chọn thời gian để xem hoặc xuất Excel:\r\n选择查看或者导出EXCEL表的时间:";
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(159, 488);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(230, 27);
            this.dtpDateOut.TabIndex = 2;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(159, 444);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(230, 27);
            this.dtpDateIn.TabIndex = 1;
            // 
            // dtgvHistoryList
            // 
            this.dtgvHistoryList.AllowUserToAddRows = false;
            this.dtgvHistoryList.AllowUserToDeleteRows = false;
            this.dtgvHistoryList.AllowUserToResizeColumns = false;
            this.dtgvHistoryList.AllowUserToResizeRows = false;
            this.dtgvHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistoryList.Location = new System.Drawing.Point(3, 58);
            this.dtgvHistoryList.Name = "dtgvHistoryList";
            this.dtgvHistoryList.RowHeadersVisible = false;
            this.dtgvHistoryList.RowHeadersWidth = 51;
            this.dtgvHistoryList.RowTemplate.Height = 24;
            this.dtgvHistoryList.Size = new System.Drawing.Size(447, 275);
            this.dtgvHistoryList.TabIndex = 15;
            this.dtgvHistoryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHistoryList_CellClick);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(159, 12);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(265, 30);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 46);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dữ liệu vừa nhập:\r\n导入数据：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ExtrusionCalenderManagementMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExtrusionCalenderManagementMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExtrusionCalenderManagementMainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtrusionCalenderManagementMainView_FormClosing);
            this.Load += new System.EventHandler(this.ExtrusionCalenderManagementMainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCodeList;
        private View.CustomControl.CTTextBox txbSearchCode;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label6;
        private View.CustomControl.CTTextBox txbEmpCode;
        private XanderUI.XUIButton btnReturnMaterial;
        private XanderUI.XUIButton btnSave;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvHistoryList;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb10;
        private XanderUI.XUIButton btnSaveExcel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbSelectMaterial;
        private System.Windows.Forms.Panel panel3;
    }
}