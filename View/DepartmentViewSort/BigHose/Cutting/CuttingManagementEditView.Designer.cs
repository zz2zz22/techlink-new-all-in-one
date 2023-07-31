namespace techlink_new_all_in_one
{
    partial class CuttingManagementEditView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new XanderUI.XUIButton();
            this.btnEdit = new XanderUI.XUIButton();
            this.btnDelete = new XanderUI.XUIButton();
            this.btnAdd = new XanderUI.XUIButton();
            this.txbReceiver = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSender = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbWeight = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQuantity = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbClothNo = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProductNo = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new XanderUI.XUIButton();
            this.dtgvShowData = new System.Windows.Forms.DataGridView();
            this.txbSearchKey = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImport = new XanderUI.XUIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.DataGridView();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
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
            this.xuiFlatTab1.PageColor = System.Drawing.Color.Cyan;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1005, 644);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cyan;
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txbReceiver);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txbSender);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txbWeight);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txbQuantity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txbClothNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txbProductNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpCreateDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.dtgvShowData);
            this.tabPage1.Controls.Add(this.txbSearchKey);
            this.tabPage1.Controls.Add(this.dtpSearchDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chỉnh sửa 编辑";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRefresh.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.cycle;
            this.btnRefresh.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRefresh.ButtonText = "Button";
            this.btnRefresh.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnRefresh.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.CornerRadius = 5;
            this.btnRefresh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRefresh.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnRefresh.Location = new System.Drawing.Point(439, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 55);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.update;
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "Chỉnh sửa";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.CornerRadius = 10;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(623, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 50);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundColor = System.Drawing.Color.Red;
            this.btnDelete.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.bin;
            this.btnDelete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDelete.ButtonText = "Xóa bỏ";
            this.btnDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDelete.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.CornerRadius = 10;
            this.btnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDelete.Location = new System.Drawing.Point(810, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 50);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.TextColor = System.Drawing.Color.Yellow;
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.plus;
            this.btnAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAdd.ButtonText = "Thêm mới";
            this.btnAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAdd.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.CornerRadius = 10;
            this.btnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAdd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdd.Location = new System.Drawing.Point(810, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 50);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbReceiver
            // 
            this.txbReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbReceiver.BackColor = System.Drawing.Color.Cyan;
            this.txbReceiver.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbReceiver.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbReceiver.BorderRadius = 10;
            this.txbReceiver.BorderSize = 2;
            this.txbReceiver.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReceiver.ForeColor = System.Drawing.Color.DimGray;
            this.txbReceiver.Location = new System.Drawing.Point(629, 436);
            this.txbReceiver.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceiver.Multiline = false;
            this.txbReceiver.Name = "txbReceiver";
            this.txbReceiver.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbReceiver.PasswordChar = false;
            this.txbReceiver.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbReceiver.PlaceholderText = "";
            this.txbReceiver.Size = new System.Drawing.Size(179, 36);
            this.txbReceiver.TabIndex = 23;
            this.txbReceiver.Texts = "";
            this.txbReceiver.UnderlinedStyle = false;
            this.txbReceiver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbReceiver_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Người nhận nguyên liệu:";
            // 
            // txbSender
            // 
            this.txbSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSender.BackColor = System.Drawing.Color.Cyan;
            this.txbSender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSender.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSender.BorderRadius = 10;
            this.txbSender.BorderSize = 2;
            this.txbSender.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSender.ForeColor = System.Drawing.Color.DimGray;
            this.txbSender.Location = new System.Drawing.Point(629, 362);
            this.txbSender.Margin = new System.Windows.Forms.Padding(4);
            this.txbSender.Multiline = false;
            this.txbSender.Name = "txbSender";
            this.txbSender.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSender.PasswordChar = false;
            this.txbSender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSender.PlaceholderText = "";
            this.txbSender.Size = new System.Drawing.Size(179, 36);
            this.txbSender.TabIndex = 21;
            this.txbSender.Texts = "";
            this.txbSender.UnderlinedStyle = false;
            this.txbSender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSender_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Người nhập dữ liệu:";
            // 
            // txbWeight
            // 
            this.txbWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbWeight.BackColor = System.Drawing.Color.Cyan;
            this.txbWeight.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbWeight.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbWeight.BorderRadius = 10;
            this.txbWeight.BorderSize = 2;
            this.txbWeight.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWeight.ForeColor = System.Drawing.Color.DimGray;
            this.txbWeight.Location = new System.Drawing.Point(730, 275);
            this.txbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txbWeight.Multiline = false;
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbWeight.PasswordChar = false;
            this.txbWeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbWeight.PlaceholderText = "";
            this.txbWeight.Size = new System.Drawing.Size(176, 36);
            this.txbWeight.TabIndex = 19;
            this.txbWeight.Texts = "";
            this.txbWeight.UnderlinedStyle = true;
            this.txbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWeight_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Khối lượng:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantity.BackColor = System.Drawing.Color.Cyan;
            this.txbQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbQuantity.BorderRadius = 10;
            this.txbQuantity.BorderSize = 2;
            this.txbQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txbQuantity.Location = new System.Drawing.Point(730, 231);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Multiline = false;
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbQuantity.PasswordChar = false;
            this.txbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbQuantity.PlaceholderText = "";
            this.txbQuantity.Size = new System.Drawing.Size(176, 36);
            this.txbQuantity.TabIndex = 17;
            this.txbQuantity.Texts = "";
            this.txbQuantity.UnderlinedStyle = true;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "PCS:";
            // 
            // txbClothNo
            // 
            this.txbClothNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbClothNo.BackColor = System.Drawing.Color.Cyan;
            this.txbClothNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbClothNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbClothNo.BorderRadius = 10;
            this.txbClothNo.BorderSize = 2;
            this.txbClothNo.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClothNo.ForeColor = System.Drawing.Color.DimGray;
            this.txbClothNo.Location = new System.Drawing.Point(629, 190);
            this.txbClothNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbClothNo.Multiline = false;
            this.txbClothNo.Name = "txbClothNo";
            this.txbClothNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbClothNo.PasswordChar = false;
            this.txbClothNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbClothNo.PlaceholderText = "";
            this.txbClothNo.Size = new System.Drawing.Size(297, 36);
            this.txbClothNo.TabIndex = 15;
            this.txbClothNo.Texts = "";
            this.txbClothNo.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã lớp vải:";
            // 
            // txbProductNo
            // 
            this.txbProductNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProductNo.BackColor = System.Drawing.Color.Cyan;
            this.txbProductNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbProductNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbProductNo.BorderRadius = 10;
            this.txbProductNo.BorderSize = 2;
            this.txbProductNo.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductNo.ForeColor = System.Drawing.Color.DimGray;
            this.txbProductNo.Location = new System.Drawing.Point(629, 111);
            this.txbProductNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbProductNo.Multiline = false;
            this.txbProductNo.Name = "txbProductNo";
            this.txbProductNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbProductNo.PasswordChar = false;
            this.txbProductNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbProductNo.PlaceholderText = "";
            this.txbProductNo.Size = new System.Drawing.Size(297, 36);
            this.txbProductNo.TabIndex = 13;
            this.txbProductNo.Texts = "";
            this.txbProductNo.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã thành phẩm:";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreateDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(629, 42);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(360, 30);
            this.dtpCreateDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày tạo:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.search_flat;
            this.btnSearch.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "Button";
            this.btnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSearch.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.CornerRadius = 5;
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnSearch.Location = new System.Drawing.Point(279, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtgvShowData
            // 
            this.dtgvShowData.AllowUserToAddRows = false;
            this.dtgvShowData.AllowUserToDeleteRows = false;
            this.dtgvShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowData.EnableHeadersVisualStyles = false;
            this.dtgvShowData.Location = new System.Drawing.Point(8, 87);
            this.dtgvShowData.Name = "dtgvShowData";
            this.dtgvShowData.ReadOnly = true;
            this.dtgvShowData.RowHeadersVisible = false;
            this.dtgvShowData.RowHeadersWidth = 51;
            this.dtgvShowData.RowTemplate.Height = 35;
            this.dtgvShowData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShowData.Size = new System.Drawing.Size(609, 527);
            this.dtgvShowData.TabIndex = 8;
            this.dtgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowData_CellClick);
            // 
            // txbSearchKey
            // 
            this.txbSearchKey.BackColor = System.Drawing.SystemColors.Control;
            this.txbSearchKey.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSearchKey.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSearchKey.BorderRadius = 10;
            this.txbSearchKey.BorderSize = 2;
            this.txbSearchKey.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchKey.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchKey.Location = new System.Drawing.Point(9, 42);
            this.txbSearchKey.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchKey.Multiline = false;
            this.txbSearchKey.Name = "txbSearchKey";
            this.txbSearchKey.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchKey.PasswordChar = false;
            this.txbSearchKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchKey.PlaceholderText = "";
            this.txbSearchKey.Size = new System.Drawing.Size(263, 36);
            this.txbSearchKey.TabIndex = 7;
            this.txbSearchKey.Texts = "";
            this.txbSearchKey.UnderlinedStyle = false;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(9, 7);
            this.dtpSearchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(166, 27);
            this.dtpSearchDate.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cyan;
            this.tabPage2.Controls.Add(this.btnImport);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cboSheet);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.txtFilename);
            this.tabPage2.Controls.Add(this.lb1);
            this.tabPage2.Controls.Add(this.customerBindingSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt 安设";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImport.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.download;
            this.btnImport.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImport.ButtonText = "Nhập dữ liệu";
            this.btnImport.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImport.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImport.CornerRadius = 10;
            this.btnImport.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImport.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImport.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImport.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImport.Location = new System.Drawing.Point(426, 548);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(254, 64);
            this.btnImport.TabIndex = 8;
            this.btnImport.TextColor = System.Drawing.Color.Black;
            this.btnImport.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 548);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sheet:";
            // 
            // cboSheet
            // 
            this.cboSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(85, 545);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(241, 31);
            this.cboSheet.TabIndex = 6;
            this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(641, 489);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 27);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilename.Location = new System.Drawing.Point(13, 489);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(622, 30);
            this.txtFilename.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(9, 466);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(75, 23);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Tên file:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.AllowUserToAddRows = false;
            this.customerBindingSource.AllowUserToDeleteRows = false;
            this.customerBindingSource.AllowUserToResizeColumns = false;
            this.customerBindingSource.AllowUserToResizeRows = false;
            this.customerBindingSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerBindingSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerBindingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerBindingSource.Location = new System.Drawing.Point(9, 7);
            this.customerBindingSource.Margin = new System.Windows.Forms.Padding(4);
            this.customerBindingSource.Name = "customerBindingSource";
            this.customerBindingSource.ReadOnly = true;
            this.customerBindingSource.RowHeadersVisible = false;
            this.customerBindingSource.RowHeadersWidth = 51;
            this.customerBindingSource.RowTemplate.Height = 24;
            this.customerBindingSource.Size = new System.Drawing.Size(978, 455);
            this.customerBindingSource.TabIndex = 1;
            // 
            // CuttingManagementEditView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.xuiFlatTab1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CuttingManagementEditView";
            this.Text = "CuttingManagementEditView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CuttingManagementEditView_FormClosing);
            this.Load += new System.EventHandler(this.CuttingManagementEditView_Load);
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private XanderUI.XUIButton btnSearch;
        private System.Windows.Forms.DataGridView dtgvShowData;
        private View.CustomControl.CTTextBox txbSearchKey;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private View.CustomControl.CTTextBox txbProductNo;
        private View.CustomControl.CTTextBox txbQuantity;
        private System.Windows.Forms.Label label4;
        private View.CustomControl.CTTextBox txbClothNo;
        private System.Windows.Forms.Label label3;
        private View.CustomControl.CTTextBox txbWeight;
        private System.Windows.Forms.Label label5;
        private View.CustomControl.CTTextBox txbReceiver;
        private System.Windows.Forms.Label label7;
        private View.CustomControl.CTTextBox txbSender;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUIButton btnAdd;
        private XanderUI.XUIButton btnDelete;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIButton btnRefresh;
        private System.Windows.Forms.DataGridView customerBindingSource;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSheet;
        private XanderUI.XUIButton btnImport;
    }
}