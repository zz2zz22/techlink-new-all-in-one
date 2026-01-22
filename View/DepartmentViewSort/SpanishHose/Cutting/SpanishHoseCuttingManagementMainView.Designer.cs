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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpanishHoseCuttingManagementMainView));
            this.lb1 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.dtgvSearchProduct = new System.Windows.Forms.DataGridView();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.lb9 = new System.Windows.Forms.Label();
            this.dtgvCheckData = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.xuiFlatTabMain = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxChooseMaterialType = new System.Windows.Forms.ComboBox();
            this.txbEmpCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLPSelectedData = new System.Windows.Forms.TableLayoutPanel();
            this.lbSelectedMaterialCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSelectedProductCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new XanderUI.XUIButton();
            this.txbQuantity = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbWeight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvSearchMaterial = new System.Windows.Forms.DataGridView();
            this.txbSearchProduct = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.txbSearchMaterial = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCheckData = new XanderUI.XUIButton();
            this.btnSaveExcel = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckData)).BeginInit();
            this.xuiFlatTabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLPSelectedData.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchMaterial)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(5, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(181, 44);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Tìm mã thành phẩm:\r\n找到成品代码:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(338, 224);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(22, 22);
            this.lbQuantity.TabIndex = 39;
            this.lbQuantity.Text = "...";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(6, 443);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(201, 44);
            this.lb7.TabIndex = 31;
            this.lb7.Text = "Mã nhân viên sản xuất:\r\n生产员工工号:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(12, 220);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(71, 44);
            this.lb5.TabIndex = 27;
            this.lb5.Text = "Số tấm:\r\n片数:";
            // 
            // dtgvSearchProduct
            // 
            this.dtgvSearchProduct.AllowUserToAddRows = false;
            this.dtgvSearchProduct.AllowUserToDeleteRows = false;
            this.dtgvSearchProduct.AllowUserToResizeColumns = false;
            this.dtgvSearchProduct.AllowUserToResizeRows = false;
            this.dtgvSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSearchProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSearchProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSearchProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearchProduct.Location = new System.Drawing.Point(9, 91);
            this.dtgvSearchProduct.MultiSelect = false;
            this.dtgvSearchProduct.Name = "dtgvSearchProduct";
            this.dtgvSearchProduct.ReadOnly = true;
            this.dtgvSearchProduct.RowHeadersVisible = false;
            this.dtgvSearchProduct.RowHeadersWidth = 51;
            this.dtgvSearchProduct.RowTemplate.Height = 30;
            this.dtgvSearchProduct.Size = new System.Drawing.Size(416, 150);
            this.dtgvSearchProduct.TabIndex = 26;
            this.dtgvSearchProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSearchProduct_CellClick);
            // 
            // lb11
            // 
            this.lb11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(8, 571);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(48, 44);
            this.lb11.TabIndex = 30;
            this.lb11.Text = "Đến:\r\n到:";
            // 
            // lb10
            // 
            this.lb10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(8, 514);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(34, 44);
            this.lb10.TabIndex = 29;
            this.lb10.Text = "Từ:\r\n从:";
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(62, 571);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(230, 27);
            this.dtpDateOut.TabIndex = 28;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(62, 516);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(230, 27);
            this.dtpDateIn.TabIndex = 27;
            // 
            // lb9
            // 
            this.lb9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb9.AutoSize = true;
            this.lb9.BackColor = System.Drawing.Color.Transparent;
            this.lb9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(6, 469);
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
            this.dtgvCheckData.Location = new System.Drawing.Point(6, 6);
            this.dtgvCheckData.MultiSelect = false;
            this.dtgvCheckData.Name = "dtgvCheckData";
            this.dtgvCheckData.ReadOnly = true;
            this.dtgvCheckData.RowHeadersVisible = false;
            this.dtgvCheckData.RowHeadersWidth = 51;
            this.dtgvCheckData.RowTemplate.Height = 24;
            this.dtgvCheckData.Size = new System.Drawing.Size(983, 457);
            this.dtgvCheckData.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // xuiFlatTabMain
            // 
            this.xuiFlatTabMain.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTabMain.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTabMain.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTabMain.Controls.Add(this.tabPage1);
            this.xuiFlatTabMain.Controls.Add(this.tabPage2);
            this.xuiFlatTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTabMain.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTabMain.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTabMain.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTabMain.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTabMain.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTabMain.Name = "xuiFlatTabMain";
            this.xuiFlatTabMain.OnlyTopLine = true;
            this.xuiFlatTabMain.PageColor = System.Drawing.Color.White;
            this.xuiFlatTabMain.SelectedIndex = 0;
            this.xuiFlatTabMain.Size = new System.Drawing.Size(1005, 644);
            this.xuiFlatTabMain.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chính 主页";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lb6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxChooseMaterialType);
            this.panel2.Controls.Add(this.txbEmpCode);
            this.panel2.Controls.Add(this.lbQuantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tableLPSelectedData);
            this.panel2.Controls.Add(this.lb7);
            this.panel2.Controls.Add(this.lb5);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txbQuantity);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(432, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 614);
            this.panel2.TabIndex = 45;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb6.Location = new System.Drawing.Point(6, 290);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(192, 44);
            this.lb6.TabIndex = 29;
            this.lb6.Text = "Khối lượng (đơn vị kg):\r\n重量（公斤）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 44);
            this.label5.TabIndex = 44;
            this.label5.Text = "Số PCS:\r\nPCS:";
            // 
            // cbxChooseMaterialType
            // 
            this.cbxChooseMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseMaterialType.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChooseMaterialType.FormattingEnabled = true;
            this.cbxChooseMaterialType.Items.AddRange(new object[] {
            "SILICONES",
            "FS"});
            this.cbxChooseMaterialType.Location = new System.Drawing.Point(212, 150);
            this.cbxChooseMaterialType.Name = "cbxChooseMaterialType";
            this.cbxChooseMaterialType.Size = new System.Drawing.Size(179, 32);
            this.cbxChooseMaterialType.TabIndex = 3;
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
            this.txbEmpCode.Location = new System.Drawing.Point(212, 443);
            this.txbEmpCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmpCode.Multiline = false;
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmpCode.PasswordChar = false;
            this.txbEmpCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmpCode.PlaceholderText = "TL/TV -";
            this.txbEmpCode.Size = new System.Drawing.Size(148, 36);
            this.txbEmpCode.TabIndex = 5;
            this.txbEmpCode.Texts = "";
            this.txbEmpCode.UnderlinedStyle = true;
            this.txbEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmpCode_KeyDown);
            this.txbEmpCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 44);
            this.label3.TabIndex = 42;
            this.label3.Text = "Chọn loại nguyên liệu:\r\n选择成分类型：";
            // 
            // tableLPSelectedData
            // 
            this.tableLPSelectedData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLPSelectedData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLPSelectedData.ColumnCount = 2;
            this.tableLPSelectedData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1343F));
            this.tableLPSelectedData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.8657F));
            this.tableLPSelectedData.Controls.Add(this.lbSelectedMaterialCode, 1, 1);
            this.tableLPSelectedData.Controls.Add(this.label4, 0, 1);
            this.tableLPSelectedData.Controls.Add(this.lbSelectedProductCode, 1, 0);
            this.tableLPSelectedData.Controls.Add(this.label2, 0, 0);
            this.tableLPSelectedData.Location = new System.Drawing.Point(6, 13);
            this.tableLPSelectedData.Name = "tableLPSelectedData";
            this.tableLPSelectedData.RowCount = 2;
            this.tableLPSelectedData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLPSelectedData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLPSelectedData.Size = new System.Drawing.Size(551, 125);
            this.tableLPSelectedData.TabIndex = 41;
            // 
            // lbSelectedMaterialCode
            // 
            this.lbSelectedMaterialCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSelectedMaterialCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelectedMaterialCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedMaterialCode.Location = new System.Drawing.Point(150, 64);
            this.lbSelectedMaterialCode.Name = "lbSelectedMaterialCode";
            this.lbSelectedMaterialCode.Size = new System.Drawing.Size(395, 58);
            this.lbSelectedMaterialCode.TabIndex = 3;
            this.lbSelectedMaterialCode.Text = "...";
            this.lbSelectedMaterialCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 58);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nguyên liệu\r\n原材料代码";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelectedProductCode
            // 
            this.lbSelectedProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbSelectedProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelectedProductCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedProductCode.Location = new System.Drawing.Point(150, 3);
            this.lbSelectedProductCode.Name = "lbSelectedProductCode";
            this.lbSelectedProductCode.Size = new System.Drawing.Size(395, 58);
            this.lbSelectedProductCode.TabIndex = 1;
            this.lbSelectedProductCode.Text = "...";
            this.lbSelectedProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thành phẩm\r\n成品代码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "HOÀN TẤT 结束";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(163, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 69);
            this.btnSave.TabIndex = 33;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txbQuantity.Location = new System.Drawing.Point(91, 224);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Multiline = false;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbQuantity.PasswordChar = false;
            this.txbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbQuantity.PlaceholderText = "0";
            this.txbQuantity.Size = new System.Drawing.Size(88, 36);
            this.txbQuantity.TabIndex = 4;
            this.txbQuantity.Texts = "";
            this.txbQuantity.UnderlinedStyle = true;
            this.txbQuantity._TextChanged += new System.EventHandler(this.txbQuantity__TextChanged);
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lbWeight);
            this.panel3.Location = new System.Drawing.Point(6, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 89);
            this.panel3.TabIndex = 40;
            // 
            // lbWeight
            // 
            this.lbWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.White;
            this.lbWeight.Location = new System.Drawing.Point(0, 0);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(545, 89);
            this.lbWeight.TabIndex = 30;
            this.lbWeight.Text = "0.0";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.dtgvSearchMaterial);
            this.panel1.Controls.Add(this.txbSearchProduct);
            this.panel1.Controls.Add(this.txbSearchMaterial);
            this.panel1.Controls.Add(this.dtgvSearchProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 614);
            this.panel1.TabIndex = 44;
            // 
            // dtgvSearchMaterial
            // 
            this.dtgvSearchMaterial.AllowUserToAddRows = false;
            this.dtgvSearchMaterial.AllowUserToDeleteRows = false;
            this.dtgvSearchMaterial.AllowUserToResizeColumns = false;
            this.dtgvSearchMaterial.AllowUserToResizeRows = false;
            this.dtgvSearchMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSearchMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSearchMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSearchMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearchMaterial.Location = new System.Drawing.Point(9, 337);
            this.dtgvSearchMaterial.Name = "dtgvSearchMaterial";
            this.dtgvSearchMaterial.ReadOnly = true;
            this.dtgvSearchMaterial.RowHeadersVisible = false;
            this.dtgvSearchMaterial.RowHeadersWidth = 51;
            this.dtgvSearchMaterial.RowTemplate.Height = 30;
            this.dtgvSearchMaterial.Size = new System.Drawing.Size(416, 272);
            this.dtgvSearchMaterial.TabIndex = 43;
            this.dtgvSearchMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSearchMaterial_CellClick);
            // 
            // txbSearchProduct
            // 
            this.txbSearchProduct.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchProduct.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSearchProduct.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSearchProduct.BorderRadius = 12;
            this.txbSearchProduct.BorderSize = 2;
            this.txbSearchProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchProduct.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchProduct.Location = new System.Drawing.Point(9, 48);
            this.txbSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchProduct.Multiline = false;
            this.txbSearchProduct.Name = "txbSearchProduct";
            this.txbSearchProduct.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchProduct.PasswordChar = false;
            this.txbSearchProduct.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchProduct.PlaceholderText = "Nhập mã và nhấn enter";
            this.txbSearchProduct.Size = new System.Drawing.Size(416, 36);
            this.txbSearchProduct.TabIndex = 1;
            this.txbSearchProduct.Texts = "";
            this.txbSearchProduct.UnderlinedStyle = false;
            this.txbSearchProduct._TextChanged += new System.EventHandler(this.txbSearchCode__TextChanged);
            this.txbSearchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchProduct_KeyDown);
            // 
            // txbSearchMaterial
            // 
            this.txbSearchMaterial.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchMaterial.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSearchMaterial.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSearchMaterial.BorderRadius = 12;
            this.txbSearchMaterial.BorderSize = 2;
            this.txbSearchMaterial.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchMaterial.Location = new System.Drawing.Point(9, 294);
            this.txbSearchMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchMaterial.Multiline = false;
            this.txbSearchMaterial.Name = "txbSearchMaterial";
            this.txbSearchMaterial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchMaterial.PasswordChar = false;
            this.txbSearchMaterial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchMaterial.PlaceholderText = "Nhập mã và nhấn enter";
            this.txbSearchMaterial.Size = new System.Drawing.Size(416, 36);
            this.txbSearchMaterial.TabIndex = 2;
            this.txbSearchMaterial.Texts = "";
            this.txbSearchMaterial.UnderlinedStyle = false;
            this.txbSearchMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchMaterial_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tìm mã nguyên liệu:\r\n查找材料代码:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnCheckData);
            this.tabPage2.Controls.Add(this.btnSaveExcel);
            this.tabPage2.Controls.Add(this.lb10);
            this.tabPage2.Controls.Add(this.lb11);
            this.tabPage2.Controls.Add(this.dtpDateIn);
            this.tabPage2.Controls.Add(this.dtpDateOut);
            this.tabPage2.Controls.Add(this.lb9);
            this.tabPage2.Controls.Add(this.dtgvCheckData);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xuất báo biểu 报纸";
            // 
            // btnCheckData
            // 
            this.btnCheckData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnCheckData.Location = new System.Drawing.Point(368, 469);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(222, 69);
            this.btnCheckData.TabIndex = 31;
            this.btnCheckData.TextColor = System.Drawing.Color.Black;
            this.btnCheckData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnSaveExcel.Location = new System.Drawing.Point(368, 543);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(222, 69);
            this.btnSaveExcel.TabIndex = 32;
            this.btnSaveExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // SpanishHoseCuttingManagementMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.xuiFlatTabMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SpanishHoseCuttingManagementMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SpanishHoseCuttingManagementMainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpanishHoseCuttingManagementMainView_FormClosing);
            this.Load += new System.EventHandler(this.SpanishHoseCuttingManagementMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckData)).EndInit();
            this.xuiFlatTabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLPSelectedData.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchMaterial)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.DataGridView dtgvSearchProduct;
        private System.Windows.Forms.Label lb7;
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
        private View.CustomControl.CTTextBox txbSearchProduct;
        private View.CustomControl.CTTextBox txbEmpCode;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbQuantity;
        private XanderUI.XUIFlatTab xuiFlatTabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvSearchMaterial;
        private View.CustomControl.CTTextBox txbSearchMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLPSelectedData;
        private System.Windows.Forms.Label lbSelectedMaterialCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSelectedProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChooseMaterialType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}