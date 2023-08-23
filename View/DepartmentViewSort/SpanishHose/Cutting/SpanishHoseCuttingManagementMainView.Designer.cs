namespace techlink_new_all_in_one
{
    partial class SpanishHoseCuttingManagementMainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpanishHoseCuttingManagementMainView));
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbChooseProduct = new System.Windows.Forms.Label();
            this.txbEmpCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb6 = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txbQuantity = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.txbSearchCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.btnSave = new XanderUI.XUIButton();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.dtgvShowSearchResult = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveExcel = new XanderUI.XUIButton();
            this.btnCheckData = new XanderUI.XUIButton();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.lb9 = new System.Windows.Forms.Label();
            this.dtgvCheckData = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowSearchResult)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckData)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(181, 44);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Tìm mã thành phẩm:\r\n找到成品代码:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.lbChooseProduct);
            this.panel1.Controls.Add(this.txbEmpCode);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txbQuantity);
            this.panel1.Controls.Add(this.txbSearchCode);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lb7);
            this.panel1.Controls.Add(this.lb5);
            this.panel1.Controls.Add(this.dtgvShowSearchResult);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 644);
            this.panel1.TabIndex = 11;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(268, 334);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 39;
            // 
            // lbChooseProduct
            // 
            this.lbChooseProduct.AutoSize = true;
            this.lbChooseProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseProduct.Location = new System.Drawing.Point(240, 18);
            this.lbChooseProduct.Name = "lbChooseProduct";
            this.lbChooseProduct.Size = new System.Drawing.Size(12, 25);
            this.lbChooseProduct.TabIndex = 38;
            this.lbChooseProduct.Text = "\r\n";
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.BackColor = System.Drawing.Color.Cyan;
            this.txbEmpCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbEmpCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbEmpCode.BorderRadius = 0;
            this.txbEmpCode.BorderSize = 2;
            this.txbEmpCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpCode.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmpCode.Location = new System.Drawing.Point(211, 486);
            this.txbEmpCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmpCode.Multiline = false;
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmpCode.PasswordChar = false;
            this.txbEmpCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmpCode.PlaceholderText = "TL/TV -";
            this.txbEmpCode.Size = new System.Drawing.Size(170, 36);
            this.txbEmpCode.TabIndex = 37;
            this.txbEmpCode.Texts = "";
            this.txbEmpCode.UnderlinedStyle = true;
            this.txbEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmpCode_KeyDown);
            this.txbEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpCode_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lb6);
            this.panel3.Controls.Add(this.lbWeight);
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 100);
            this.panel3.TabIndex = 36;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.Color.White;
            this.lb6.Location = new System.Drawing.Point(4, 2);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(192, 44);
            this.lb6.TabIndex = 29;
            this.lb6.Text = "Khối lượng (đơn vị kg):\r\n重量（公斤）：";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.White;
            this.lbWeight.Location = new System.Drawing.Point(296, 13);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(106, 72);
            this.lbWeight.TabIndex = 30;
            this.lbWeight.Text = "0.0";
            // 
            // txbQuantity
            // 
            this.txbQuantity.BackColor = System.Drawing.Color.Cyan;
            this.txbQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbQuantity.BorderRadius = 0;
            this.txbQuantity.BorderSize = 2;
            this.txbQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txbQuantity.Location = new System.Drawing.Point(90, 320);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Multiline = false;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbQuantity.PasswordChar = false;
            this.txbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbQuantity.PlaceholderText = "0";
            this.txbQuantity.Size = new System.Drawing.Size(121, 36);
            this.txbQuantity.TabIndex = 35;
            this.txbQuantity.Texts = "";
            this.txbQuantity.UnderlinedStyle = true;
            this.txbQuantity._TextChanged += new System.EventHandler(this.txbQuantity__TextChanged);
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // txbSearchCode
            // 
            this.txbSearchCode.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSearchCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSearchCode.BorderRadius = 12;
            this.txbSearchCode.BorderSize = 2;
            this.txbSearchCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCode.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchCode.Location = new System.Drawing.Point(16, 57);
            this.txbSearchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchCode.Multiline = false;
            this.txbSearchCode.Name = "txbSearchCode";
            this.txbSearchCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchCode.PasswordChar = false;
            this.txbSearchCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchCode.PlaceholderText = "Nhập mã thành phẩm cần tìm";
            this.txbSearchCode.Size = new System.Drawing.Size(442, 36);
            this.txbSearchCode.TabIndex = 34;
            this.txbSearchCode.Texts = "";
            this.txbSearchCode.UnderlinedStyle = false;
            this.txbSearchCode._TextChanged += new System.EventHandler(this.txbSearchCode__TextChanged);
            this.txbSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchCode_KeyDown);
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
            this.btnSave.Location = new System.Drawing.Point(245, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 69);
            this.btnSave.TabIndex = 33;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(3, 478);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(201, 44);
            this.lb7.TabIndex = 31;
            this.lb7.Text = "Mã nhân viên sản xuất:\r\n生产员工工号:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(12, 316);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(71, 44);
            this.lb5.TabIndex = 27;
            this.lb5.Text = "Số tấm:\r\n片数:";
            // 
            // dtgvShowSearchResult
            // 
            this.dtgvShowSearchResult.AllowUserToAddRows = false;
            this.dtgvShowSearchResult.AllowUserToDeleteRows = false;
            this.dtgvShowSearchResult.AllowUserToResizeColumns = false;
            this.dtgvShowSearchResult.AllowUserToResizeRows = false;
            this.dtgvShowSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvShowSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShowSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowSearchResult.Location = new System.Drawing.Point(3, 100);
            this.dtgvShowSearchResult.MultiSelect = false;
            this.dtgvShowSearchResult.Name = "dtgvShowSearchResult";
            this.dtgvShowSearchResult.ReadOnly = true;
            this.dtgvShowSearchResult.RowHeadersVisible = false;
            this.dtgvShowSearchResult.RowHeadersWidth = 51;
            this.dtgvShowSearchResult.RowTemplate.Height = 30;
            this.dtgvShowSearchResult.Size = new System.Drawing.Size(501, 213);
            this.dtgvShowSearchResult.TabIndex = 26;
            this.dtgvShowSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowSearchResult_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveExcel);
            this.panel2.Controls.Add(this.btnCheckData);
            this.panel2.Controls.Add(this.lb11);
            this.panel2.Controls.Add(this.lb10);
            this.panel2.Controls.Add(this.dtpDateOut);
            this.panel2.Controls.Add(this.dtpDateIn);
            this.panel2.Controls.Add(this.lb9);
            this.panel2.Controls.Add(this.dtgvCheckData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(509, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 644);
            this.panel2.TabIndex = 12;
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
            this.btnSaveExcel.Location = new System.Drawing.Point(246, 563);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(238, 69);
            this.btnSaveExcel.TabIndex = 32;
            this.btnSaveExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnCheckData
            // 
            this.btnCheckData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheckData.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.information;
            this.btnCheckData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCheckData.ButtonText = "Xem nhanh";
            this.btnCheckData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCheckData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.CornerRadius = 5;
            this.btnCheckData.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCheckData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCheckData.Location = new System.Drawing.Point(6, 563);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(222, 69);
            this.btnCheckData.TabIndex = 31;
            this.btnCheckData.TextColor = System.Drawing.Color.Black;
            this.btnCheckData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // lb11
            // 
            this.lb11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(156, 475);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(48, 44);
            this.lb11.TabIndex = 30;
            this.lb11.Text = "Đến:\r\n到:";
            // 
            // lb10
            // 
            this.lb10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(156, 431);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(34, 44);
            this.lb10.TabIndex = 29;
            this.lb10.Text = "Từ:\r\n从:";
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(210, 471);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(230, 27);
            this.dtpDateOut.TabIndex = 28;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(210, 427);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(230, 27);
            this.dtpDateIn.TabIndex = 27;
            // 
            // lb9
            // 
            this.lb9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb9.AutoSize = true;
            this.lb9.BackColor = System.Drawing.Color.Transparent;
            this.lb9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(154, 380);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(330, 44);
            this.lb9.TabIndex = 25;
            this.lb9.Text = "Chọn thời gian để xem hoặc xuất Excel:\r\n选择查看或者导出EXCEL表的时间:";
            // 
            // dtgvCheckData
            // 
            this.dtgvCheckData.AllowUserToAddRows = false;
            this.dtgvCheckData.AllowUserToDeleteRows = false;
            this.dtgvCheckData.AllowUserToResizeColumns = false;
            this.dtgvCheckData.AllowUserToResizeRows = false;
            this.dtgvCheckData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCheckData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvCheckData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCheckData.Location = new System.Drawing.Point(6, 3);
            this.dtgvCheckData.MultiSelect = false;
            this.dtgvCheckData.Name = "dtgvCheckData";
            this.dtgvCheckData.ReadOnly = true;
            this.dtgvCheckData.RowHeadersVisible = false;
            this.dtgvCheckData.RowHeadersWidth = 51;
            this.dtgvCheckData.RowTemplate.Height = 24;
            this.dtgvCheckData.Size = new System.Drawing.Size(487, 372);
            this.dtgvCheckData.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SpanishHoseCuttingManagementMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SpanishHoseCuttingManagementMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SpanishHoseCuttingManagementMainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpanishHoseCuttingManagementMainView_FormClosing);
            this.Load += new System.EventHandler(this.SpanishHoseCuttingManagementMainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowSearchResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.DataGridView dtgvShowSearchResult;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvCheckData;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private XanderUI.XUIButton btnSave;
        private XanderUI.XUIButton btnSaveExcel;
        private XanderUI.XUIButton btnCheckData;
        private View.CustomControl.CTTextBox txbQuantity;
        private View.CustomControl.CTTextBox txbSearchCode;
        private System.Windows.Forms.Panel panel3;
        private View.CustomControl.CTTextBox txbEmpCode;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbChooseProduct;
        private System.Windows.Forms.Label lbQuantity;
    }
}