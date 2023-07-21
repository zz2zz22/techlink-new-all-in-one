namespace techlink_new_all_in_one.View.SubUI
{
    partial class ProgramSettingView
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
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.btn_testPort = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.txtDataIn = new System.Windows.Forms.TextBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.flatTabMainProgramSetting = new XanderUI.XUIFlatTab();
            this.tpConnection = new System.Windows.Forms.TabPage();
            this.tpMailling = new System.Windows.Forms.TabPage();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.btnTestMailAll = new XanderUI.XUIButton();
            this.btnTestMailSingle = new XanderUI.XUIButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteRepicent = new XanderUI.XUIButton();
            this.lbChosenRepicent = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbRepicentAddress = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.dtgvRepicentsList = new System.Windows.Forms.DataGridView();
            this.repicent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.txbSenderAddress = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSMTPport = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.txbSMTPServer = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.txbSenderPassword = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.btnSaveMailSettting = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.flatTabMainProgramSetting.SuspendLayout();
            this.tpConnection.SuspendLayout();
            this.tpMailling.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRepicentsList)).BeginInit();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.Black;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.btn_testPort);
            this.xuiCustomGroupbox1.Controls.Add(this.label5);
            this.xuiCustomGroupbox1.Controls.Add(this.label4);
            this.xuiCustomGroupbox1.Controls.Add(this.label3);
            this.xuiCustomGroupbox1.Controls.Add(this.label2);
            this.xuiCustomGroupbox1.Controls.Add(this.cbParityBits);
            this.xuiCustomGroupbox1.Controls.Add(this.cbStopBits);
            this.xuiCustomGroupbox1.Controls.Add(this.cbBaudRate);
            this.xuiCustomGroupbox1.Controls.Add(this.cbDataBits);
            this.xuiCustomGroupbox1.Controls.Add(this.txtDataIn);
            this.xuiCustomGroupbox1.Controls.Add(this.cbComPort);
            this.xuiCustomGroupbox1.Controls.Add(this.label1);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(8, 6);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(473, 254);
            this.xuiCustomGroupbox1.TabIndex = 1;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Kết nối cân điện tử 连接电子秤";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btn_testPort
            // 
            this.btn_testPort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_testPort.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.connection;
            this.btn_testPort.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_testPort.ButtonText = "Thử kết nối";
            this.btn_testPort.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_testPort.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_testPort.CornerRadius = 12;
            this.btn_testPort.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_testPort.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_testPort.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_testPort.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_testPort.Location = new System.Drawing.Point(23, 195);
            this.btn_testPort.Name = "btn_testPort";
            this.btn_testPort.Size = new System.Drawing.Size(190, 44);
            this.btn_testPort.TabIndex = 18;
            this.btn_testPort.TextColor = System.Drawing.Color.Black;
            this.btn_testPort.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_testPort.Click += new System.EventHandler(this.btn_testPort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "BAUD RATE";
            // 
            // cbParityBits
            // 
            this.cbParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Old",
            "Even"});
            this.cbParityBits.Location = new System.Drawing.Point(118, 159);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(121, 31);
            this.cbParityBits.TabIndex = 13;
            this.cbParityBits.SelectionChangeCommitted += new System.EventHandler(this.cbParityBits_SelectionChangeCommitted);
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(118, 129);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 31);
            this.cbStopBits.TabIndex = 12;
            this.cbStopBits.SelectionChangeCommitted += new System.EventHandler(this.cbStopBits_SelectionChangeCommitted);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(118, 69);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 31);
            this.cbBaudRate.TabIndex = 11;
            this.cbBaudRate.SelectionChangeCommitted += new System.EventHandler(this.cbBaudRate_SelectionChangeCommitted);
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(118, 99);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 31);
            this.cbDataBits.TabIndex = 10;
            this.cbDataBits.SelectionChangeCommitted += new System.EventHandler(this.cbDataBits_SelectionChangeCommitted);
            // 
            // txtDataIn
            // 
            this.txtDataIn.Location = new System.Drawing.Point(245, 20);
            this.txtDataIn.Multiline = true;
            this.txtDataIn.Name = "txtDataIn";
            this.txtDataIn.ReadOnly = true;
            this.txtDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataIn.Size = new System.Drawing.Size(204, 219);
            this.txtDataIn.TabIndex = 3;
            this.txtDataIn.TextChanged += new System.EventHandler(this.txtDataIn_TextChanged);
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(104, 26);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(135, 31);
            this.cbComPort.TabIndex = 2;
            this.cbComPort.SelectionChangeCommitted += new System.EventHandler(this.cbComPort_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cổng COM:\r\n通讯端口：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // flatTabMainProgramSetting
            // 
            this.flatTabMainProgramSetting.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.flatTabMainProgramSetting.ActiveTextColor = System.Drawing.Color.White;
            this.flatTabMainProgramSetting.BorderColor = System.Drawing.Color.DodgerBlue;
            this.flatTabMainProgramSetting.Controls.Add(this.tpConnection);
            this.flatTabMainProgramSetting.Controls.Add(this.tpMailling);
            this.flatTabMainProgramSetting.Controls.Add(this.tpDatabase);
            this.flatTabMainProgramSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTabMainProgramSetting.HeaderBackgroundColor = System.Drawing.Color.White;
            this.flatTabMainProgramSetting.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.flatTabMainProgramSetting.InActiveTextColor = System.Drawing.Color.White;
            this.flatTabMainProgramSetting.ItemSize = new System.Drawing.Size(240, 16);
            this.flatTabMainProgramSetting.Location = new System.Drawing.Point(0, 0);
            this.flatTabMainProgramSetting.Name = "flatTabMainProgramSetting";
            this.flatTabMainProgramSetting.OnlyTopLine = true;
            this.flatTabMainProgramSetting.PageColor = System.Drawing.Color.Cyan;
            this.flatTabMainProgramSetting.SelectedIndex = 0;
            this.flatTabMainProgramSetting.Size = new System.Drawing.Size(1005, 644);
            this.flatTabMainProgramSetting.TabIndex = 2;
            // 
            // tpConnection
            // 
            this.tpConnection.BackColor = System.Drawing.Color.Cyan;
            this.tpConnection.Controls.Add(this.xuiCustomGroupbox1);
            this.tpConnection.Location = new System.Drawing.Point(4, 20);
            this.tpConnection.Name = "tpConnection";
            this.tpConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tpConnection.Size = new System.Drawing.Size(997, 620);
            this.tpConnection.TabIndex = 0;
            this.tpConnection.Text = "Kết nối 联系";
            // 
            // tpMailling
            // 
            this.tpMailling.BackColor = System.Drawing.Color.Cyan;
            this.tpMailling.Controls.Add(this.xuiCustomGroupbox3);
            this.tpMailling.Controls.Add(this.xuiCustomGroupbox2);
            this.tpMailling.Location = new System.Drawing.Point(4, 20);
            this.tpMailling.Name = "tpMailling";
            this.tpMailling.Padding = new System.Windows.Forms.Padding(3);
            this.tpMailling.Size = new System.Drawing.Size(997, 620);
            this.tpMailling.TabIndex = 1;
            this.tpMailling.Text = "Mail 邮件";
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.Black;
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.btnTestMailAll);
            this.xuiCustomGroupbox3.Controls.Add(this.btnTestMailSingle);
            this.xuiCustomGroupbox3.Controls.Add(this.label12);
            this.xuiCustomGroupbox3.Controls.Add(this.btnDeleteRepicent);
            this.xuiCustomGroupbox3.Controls.Add(this.lbChosenRepicent);
            this.xuiCustomGroupbox3.Controls.Add(this.label11);
            this.xuiCustomGroupbox3.Controls.Add(this.txbRepicentAddress);
            this.xuiCustomGroupbox3.Controls.Add(this.dtgvRepicentsList);
            this.xuiCustomGroupbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(3, 278);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(991, 339);
            this.xuiCustomGroupbox3.TabIndex = 3;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Cài đặt người nhận 收件人设置";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnTestMailAll
            // 
            this.btnTestMailAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestMailAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTestMailAll.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.multiple_people;
            this.btnTestMailAll.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTestMailAll.ButtonText = "Send All";
            this.btnTestMailAll.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTestMailAll.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTestMailAll.CornerRadius = 12;
            this.btnTestMailAll.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestMailAll.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTestMailAll.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTestMailAll.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTestMailAll.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTestMailAll.Location = new System.Drawing.Point(666, 127);
            this.btnTestMailAll.Name = "btnTestMailAll";
            this.btnTestMailAll.Size = new System.Drawing.Size(283, 81);
            this.btnTestMailAll.TabIndex = 36;
            this.btnTestMailAll.TextColor = System.Drawing.Color.Black;
            this.btnTestMailAll.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnTestMailSingle
            // 
            this.btnTestMailSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestMailSingle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTestMailSingle.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.software_testing;
            this.btnTestMailSingle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTestMailSingle.ButtonText = "Send selected";
            this.btnTestMailSingle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTestMailSingle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTestMailSingle.CornerRadius = 12;
            this.btnTestMailSingle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestMailSingle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTestMailSingle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTestMailSingle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTestMailSingle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTestMailSingle.Location = new System.Drawing.Point(666, 228);
            this.btnTestMailSingle.Name = "btnTestMailSingle";
            this.btnTestMailSingle.Size = new System.Drawing.Size(282, 81);
            this.btnTestMailSingle.TabIndex = 34;
            this.btnTestMailSingle.TextColor = System.Drawing.Color.Black;
            this.btnTestMailSingle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTestMailSingle.Click += new System.EventHandler(this.btnTestMailSingle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 46);
            this.label12.TabIndex = 33;
            this.label12.Text = "Danh sách mail người nhận:\r\n电子邮件收件人列表：";
            // 
            // btnDeleteRepicent
            // 
            this.btnDeleteRepicent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRepicent.BackgroundColor = System.Drawing.Color.Red;
            this.btnDeleteRepicent.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.bin;
            this.btnDeleteRepicent.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeleteRepicent.ButtonText = "Delete repicent";
            this.btnDeleteRepicent.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDeleteRepicent.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteRepicent.CornerRadius = 12;
            this.btnDeleteRepicent.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRepicent.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteRepicent.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeleteRepicent.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteRepicent.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeleteRepicent.Location = new System.Drawing.Point(312, 228);
            this.btnDeleteRepicent.Name = "btnDeleteRepicent";
            this.btnDeleteRepicent.Size = new System.Drawing.Size(236, 81);
            this.btnDeleteRepicent.TabIndex = 31;
            this.btnDeleteRepicent.TextColor = System.Drawing.Color.White;
            this.btnDeleteRepicent.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteRepicent.Click += new System.EventHandler(this.btnDeleteRepicent_Click);
            // 
            // lbChosenRepicent
            // 
            this.lbChosenRepicent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChosenRepicent.AutoSize = true;
            this.lbChosenRepicent.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChosenRepicent.Location = new System.Drawing.Point(346, 166);
            this.lbChosenRepicent.Name = "lbChosenRepicent";
            this.lbChosenRepicent.Size = new System.Drawing.Size(25, 24);
            this.lbChosenRepicent.TabIndex = 30;
            this.lbChosenRepicent.Text = "...";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 46);
            this.label11.TabIndex = 29;
            this.label11.Text = "Địa chỉ mail người nhận:\r\n收件人的电子邮件地址：";
            // 
            // txbRepicentAddress
            // 
            this.txbRepicentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRepicentAddress.BackColor = System.Drawing.Color.Cyan;
            this.txbRepicentAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbRepicentAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbRepicentAddress.BorderRadius = 12;
            this.txbRepicentAddress.BorderSize = 2;
            this.txbRepicentAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRepicentAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txbRepicentAddress.Location = new System.Drawing.Point(287, 72);
            this.txbRepicentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbRepicentAddress.Multiline = false;
            this.txbRepicentAddress.Name = "txbRepicentAddress";
            this.txbRepicentAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbRepicentAddress.PasswordChar = false;
            this.txbRepicentAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRepicentAddress.PlaceholderText = "Nhập và bấm Enter để thêm 输入并按 Enter 键添加";
            this.txbRepicentAddress.Size = new System.Drawing.Size(408, 36);
            this.txbRepicentAddress.TabIndex = 28;
            this.txbRepicentAddress.Texts = "";
            this.txbRepicentAddress.UnderlinedStyle = false;
            this.txbRepicentAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbRepicentAddress_KeyDown);
            // 
            // dtgvRepicentsList
            // 
            this.dtgvRepicentsList.AllowUserToAddRows = false;
            this.dtgvRepicentsList.AllowUserToDeleteRows = false;
            this.dtgvRepicentsList.AllowUserToResizeColumns = false;
            this.dtgvRepicentsList.AllowUserToResizeRows = false;
            this.dtgvRepicentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRepicentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRepicentsList.ColumnHeadersHeight = 29;
            this.dtgvRepicentsList.ColumnHeadersVisible = false;
            this.dtgvRepicentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repicent});
            this.dtgvRepicentsList.Location = new System.Drawing.Point(6, 72);
            this.dtgvRepicentsList.Name = "dtgvRepicentsList";
            this.dtgvRepicentsList.RowHeadersVisible = false;
            this.dtgvRepicentsList.RowHeadersWidth = 35;
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvRepicentsList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRepicentsList.RowTemplate.Height = 35;
            this.dtgvRepicentsList.Size = new System.Drawing.Size(274, 261);
            this.dtgvRepicentsList.TabIndex = 27;
            this.dtgvRepicentsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRepicentsList_CellClick);
            // 
            // repicent
            // 
            this.repicent.HeaderText = "Repicents";
            this.repicent.MinimumWidth = 6;
            this.repicent.Name = "repicent";
            this.repicent.ReadOnly = true;
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.Black;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.txbSenderAddress);
            this.xuiCustomGroupbox2.Controls.Add(this.label6);
            this.xuiCustomGroupbox2.Controls.Add(this.txbSMTPport);
            this.xuiCustomGroupbox2.Controls.Add(this.txbSMTPServer);
            this.xuiCustomGroupbox2.Controls.Add(this.txbSenderPassword);
            this.xuiCustomGroupbox2.Controls.Add(this.btnSaveMailSettting);
            this.xuiCustomGroupbox2.Controls.Add(this.label7);
            this.xuiCustomGroupbox2.Controls.Add(this.label8);
            this.xuiCustomGroupbox2.Controls.Add(this.label9);
            this.xuiCustomGroupbox2.Controls.Add(this.label10);
            this.xuiCustomGroupbox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(3, 3);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(991, 275);
            this.xuiCustomGroupbox2.TabIndex = 2;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Cài đặt host mail 邮件托管设置";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txbSenderAddress
            // 
            this.txbSenderAddress.BackColor = System.Drawing.Color.Cyan;
            this.txbSenderAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSenderAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSenderAddress.BorderRadius = 12;
            this.txbSenderAddress.BorderSize = 2;
            this.txbSenderAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenderAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txbSenderAddress.Location = new System.Drawing.Point(115, 27);
            this.txbSenderAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbSenderAddress.Multiline = false;
            this.txbSenderAddress.Name = "txbSenderAddress";
            this.txbSenderAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSenderAddress.PasswordChar = false;
            this.txbSenderAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSenderAddress.PlaceholderText = "";
            this.txbSenderAddress.Size = new System.Drawing.Size(376, 36);
            this.txbSenderAddress.TabIndex = 25;
            this.txbSenderAddress.Texts = "";
            this.txbSenderAddress.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(730, 46);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nếu mail có tiên miền khác với \"@gmail.com\" vui lòng cài đặt 2 trường server và p" +
    "ort bên dưới!\r\n如果邮件的域名不是“@gmail.com”，请安装下面的服务器和端口字段！";
            // 
            // txbSMTPport
            // 
            this.txbSMTPport.BackColor = System.Drawing.Color.Cyan;
            this.txbSMTPport.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSMTPport.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSMTPport.BorderRadius = 0;
            this.txbSMTPport.BorderSize = 2;
            this.txbSMTPport.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSMTPport.ForeColor = System.Drawing.Color.Gray;
            this.txbSMTPport.Location = new System.Drawing.Point(645, 144);
            this.txbSMTPport.Margin = new System.Windows.Forms.Padding(4);
            this.txbSMTPport.Multiline = false;
            this.txbSMTPport.Name = "txbSMTPport";
            this.txbSMTPport.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSMTPport.PasswordChar = false;
            this.txbSMTPport.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txbSMTPport.PlaceholderText = "";
            this.txbSMTPport.Size = new System.Drawing.Size(157, 36);
            this.txbSMTPport.TabIndex = 23;
            this.txbSMTPport.Texts = "";
            this.txbSMTPport.UnderlinedStyle = true;
            this.txbSMTPport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSMTPport_KeyPress);
            // 
            // txbSMTPServer
            // 
            this.txbSMTPServer.BackColor = System.Drawing.Color.Cyan;
            this.txbSMTPServer.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSMTPServer.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSMTPServer.BorderRadius = 12;
            this.txbSMTPServer.BorderSize = 2;
            this.txbSMTPServer.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSMTPServer.ForeColor = System.Drawing.Color.Gray;
            this.txbSMTPServer.Location = new System.Drawing.Point(134, 144);
            this.txbSMTPServer.Margin = new System.Windows.Forms.Padding(4);
            this.txbSMTPServer.Multiline = false;
            this.txbSMTPServer.Name = "txbSMTPServer";
            this.txbSMTPServer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSMTPServer.PasswordChar = false;
            this.txbSMTPServer.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txbSMTPServer.PlaceholderText = "";
            this.txbSMTPServer.Size = new System.Drawing.Size(360, 36);
            this.txbSMTPServer.TabIndex = 22;
            this.txbSMTPServer.Texts = "";
            this.txbSMTPServer.UnderlinedStyle = false;
            // 
            // txbSenderPassword
            // 
            this.txbSenderPassword.BackColor = System.Drawing.Color.Cyan;
            this.txbSenderPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbSenderPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbSenderPassword.BorderRadius = 12;
            this.txbSenderPassword.BorderSize = 2;
            this.txbSenderPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenderPassword.ForeColor = System.Drawing.Color.Gray;
            this.txbSenderPassword.Location = new System.Drawing.Point(640, 27);
            this.txbSenderPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbSenderPassword.Multiline = false;
            this.txbSenderPassword.Name = "txbSenderPassword";
            this.txbSenderPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSenderPassword.PasswordChar = true;
            this.txbSenderPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txbSenderPassword.PlaceholderText = "";
            this.txbSenderPassword.Size = new System.Drawing.Size(291, 36);
            this.txbSenderPassword.TabIndex = 21;
            this.txbSenderPassword.Texts = "";
            this.txbSenderPassword.UnderlinedStyle = false;
            // 
            // btnSaveMailSettting
            // 
            this.btnSaveMailSettting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMailSettting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveMailSettting.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.connection;
            this.btnSaveMailSettting.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSaveMailSettting.ButtonText = "Save mail config";
            this.btnSaveMailSettting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSaveMailSettting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveMailSettting.CornerRadius = 12;
            this.btnSaveMailSettting.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMailSettting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveMailSettting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSaveMailSettting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveMailSettting.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveMailSettting.Location = new System.Drawing.Point(666, 193);
            this.btnSaveMailSettting.Name = "btnSaveMailSettting";
            this.btnSaveMailSettting.Size = new System.Drawing.Size(319, 76);
            this.btnSaveMailSettting.TabIndex = 18;
            this.btnSaveMailSettting.TextColor = System.Drawing.Color.Black;
            this.btnSaveMailSettting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveMailSettting.Click += new System.EventHandler(this.btnSaveMailSettting_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "SMTP port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "SMTP server:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 48);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mật khẩu:\r\n口令:\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "Người gửi:\r\n邮件发件人:";
            // 
            // tpDatabase
            // 
            this.tpDatabase.BackColor = System.Drawing.Color.Cyan;
            this.tpDatabase.Location = new System.Drawing.Point(4, 20);
            this.tpDatabase.Name = "tpDatabase";
            this.tpDatabase.Size = new System.Drawing.Size(997, 620);
            this.tpDatabase.TabIndex = 2;
            this.tpDatabase.Text = "Cài đặt database 安装数据库";
            // 
            // ProgramSettingView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.flatTabMainProgramSetting);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProgramSettingView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ProgramSettingView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramSettingView_FormClosing);
            this.Load += new System.EventHandler(this.ProgramSettingView_Load);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.flatTabMainProgramSetting.ResumeLayout(false);
            this.tpConnection.ResumeLayout(false);
            this.tpMailling.ResumeLayout(false);
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRepicentsList)).EndInit();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.TextBox txtDataIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private XanderUI.XUIButton btn_testPort;
        private XanderUI.XUIFlatTab flatTabMainProgramSetting;
        private System.Windows.Forms.TabPage tpConnection;
        private System.Windows.Forms.TabPage tpMailling;
        private System.Windows.Forms.TabPage tpDatabase;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private CustomControl.CTTextBox txbSenderPassword;
        private CustomControl.CTTextBox txbSMTPport;
        private CustomControl.CTTextBox txbSMTPServer;
        private System.Windows.Forms.Label label6;
        private CustomControl.CTTextBox txbSenderAddress;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private XanderUI.XUIButton btnSaveMailSettting;
        private System.Windows.Forms.DataGridView dtgvRepicentsList;
        private CustomControl.CTTextBox txbRepicentAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn repicent;
        private XanderUI.XUIButton btnDeleteRepicent;
        private System.Windows.Forms.Label lbChosenRepicent;
        private System.Windows.Forms.Label label12;
        private XanderUI.XUIButton btnTestMailSingle;
        private XanderUI.XUIButton btnTestMailAll;
    }
}