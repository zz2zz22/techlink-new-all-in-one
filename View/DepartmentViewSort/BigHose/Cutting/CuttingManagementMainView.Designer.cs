namespace techlink_new_all_in_one
{
    partial class CuttingManagementMainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCutQty = new System.Windows.Forms.Label();
            this.btnConfirm = new XanderUI.XUIButton();
            this.txbRawQty = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.cbxDetailMat = new System.Windows.Forms.ComboBox();
            this.txbMatCode = new System.Windows.Forms.ComboBox();
            this.panelWeight = new System.Windows.Forms.Panel();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchHisEmp = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmpReceiveCode = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckData = new XanderUI.XUIButton();
            this.btnCheckExcel = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvCheckHistory = new System.Windows.Forms.DataGridView();
            this.lbAnnouce = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panelWeight.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbCutQty);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txbRawQty);
            this.panel1.Controls.Add(this.cbxDetailMat);
            this.panel1.Controls.Add(this.txbMatCode);
            this.panel1.Controls.Add(this.panelWeight);
            this.panel1.Controls.Add(this.btnSearchHisEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbEmpReceiveCode);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 644);
            this.panel1.TabIndex = 0;
            // 
            // lbCutQty
            // 
            this.lbCutQty.AutoSize = true;
            this.lbCutQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbCutQty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCutQty.Location = new System.Drawing.Point(169, 329);
            this.lbCutQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCutQty.Name = "lbCutQty";
            this.lbCutQty.Size = new System.Drawing.Size(27, 29);
            this.lbCutQty.TabIndex = 25;
            this.lbCutQty.Text = "0";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.check;
            this.btnConfirm.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirm.ButtonText = "Button";
            this.btnConfirm.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnConfirm.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.CornerRadius = 5;
            this.btnConfirm.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirm.Location = new System.Drawing.Point(228, 555);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(272, 76);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txbRawQty
            // 
            this.txbRawQty.BackColor = System.Drawing.Color.Cyan;
            this.txbRawQty.BorderColor = System.Drawing.Color.Gray;
            this.txbRawQty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbRawQty.BorderRadius = 10;
            this.txbRawQty.BorderSize = 2;
            this.txbRawQty.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRawQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRawQty.Location = new System.Drawing.Point(156, 273);
            this.txbRawQty.Margin = new System.Windows.Forms.Padding(4);
            this.txbRawQty.Multiline = false;
            this.txbRawQty.Name = "txbRawQty";
            this.txbRawQty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbRawQty.PasswordChar = false;
            this.txbRawQty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRawQty.PlaceholderText = "Nhập số lượng";
            this.txbRawQty.Size = new System.Drawing.Size(206, 36);
            this.txbRawQty.TabIndex = 6;
            this.txbRawQty.Texts = "";
            this.txbRawQty.UnderlinedStyle = false;
            this.txbRawQty._TextChanged += new System.EventHandler(this.txbRawQty__TextChanged);
            this.txbRawQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRawQty_KeyPress);
            // 
            // cbxDetailMat
            // 
            this.cbxDetailMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDetailMat.FormattingEnabled = true;
            this.cbxDetailMat.Location = new System.Drawing.Point(156, 208);
            this.cbxDetailMat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxDetailMat.Name = "cbxDetailMat";
            this.cbxDetailMat.Size = new System.Drawing.Size(330, 31);
            this.cbxDetailMat.TabIndex = 5;
            this.cbxDetailMat.SelectionChangeCommitted += new System.EventHandler(this.cbxDetailMat_SelectionChangeCommitted);
            // 
            // txbMatCode
            // 
            this.txbMatCode.FormattingEnabled = true;
            this.txbMatCode.Location = new System.Drawing.Point(156, 146);
            this.txbMatCode.Name = "txbMatCode";
            this.txbMatCode.Size = new System.Drawing.Size(330, 31);
            this.txbMatCode.TabIndex = 4;
            this.txbMatCode.SelectedIndexChanged += new System.EventHandler(this.txbMatCode_SelectedIndexChanged);
            this.txbMatCode.TextChanged += new System.EventHandler(this.txbMatCode_TextChanged);
            this.txbMatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMatCode_KeyDown);
            // 
            // panelWeight
            // 
            this.panelWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWeight.BackColor = System.Drawing.Color.Black;
            this.panelWeight.Controls.Add(this.lbWeight);
            this.panelWeight.Controls.Add(this.label5);
            this.panelWeight.ForeColor = System.Drawing.Color.Black;
            this.panelWeight.Location = new System.Drawing.Point(11, 387);
            this.panelWeight.Name = "panelWeight";
            this.panelWeight.Size = new System.Drawing.Size(489, 140);
            this.panelWeight.TabIndex = 20;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.White;
            this.lbWeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWeight.Location = new System.Drawing.Point(223, 34);
            this.lbWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(138, 72);
            this.lbWeight.TabIndex = 19;
            this.lbWeight.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Trọng lượng (kg):\r\n重量(kg):";
            // 
            // btnSearchHisEmp
            // 
            this.btnSearchHisEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchHisEmp.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.time;
            this.btnSearchHisEmp.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearchHisEmp.ButtonText = "Button";
            this.btnSearchHisEmp.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSearchHisEmp.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchHisEmp.CornerRadius = 5;
            this.btnSearchHisEmp.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchHisEmp.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearchHisEmp.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchHisEmp.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchHisEmp.Location = new System.Drawing.Point(174, 58);
            this.btnSearchHisEmp.Name = "btnSearchHisEmp";
            this.btnSearchHisEmp.Size = new System.Drawing.Size(312, 68);
            this.btnSearchHisEmp.TabIndex = 3;
            this.btnSearchHisEmp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchHisEmp.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchHisEmp.Click += new System.EventHandler(this.btnSearchHisEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(10, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng cắt:\r\n裁出的数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số lượng gốc:\r\n原数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã liệu vải:\r\n布码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã thành phẩm:\r\n成品代码";
            // 
            // txbEmpReceiveCode
            // 
            this.txbEmpReceiveCode.BackColor = System.Drawing.Color.Cyan;
            this.txbEmpReceiveCode.BorderColor = System.Drawing.Color.Gray;
            this.txbEmpReceiveCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbEmpReceiveCode.BorderRadius = 10;
            this.txbEmpReceiveCode.BorderSize = 2;
            this.txbEmpReceiveCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpReceiveCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEmpReceiveCode.Location = new System.Drawing.Point(184, 13);
            this.txbEmpReceiveCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmpReceiveCode.Multiline = false;
            this.txbEmpReceiveCode.Name = "txbEmpReceiveCode";
            this.txbEmpReceiveCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmpReceiveCode.PasswordChar = false;
            this.txbEmpReceiveCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmpReceiveCode.PlaceholderText = "TL/TV - ";
            this.txbEmpReceiveCode.Size = new System.Drawing.Size(252, 36);
            this.txbEmpReceiveCode.TabIndex = 2;
            this.txbEmpReceiveCode.Texts = "";
            this.txbEmpReceiveCode.UnderlinedStyle = false;
            this.txbEmpReceiveCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmpReceiveCode_KeyPress);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb1.Location = new System.Drawing.Point(11, 9);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(167, 46);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Mã nhân viên nhận:\r\n接货的员工编号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheckData);
            this.panel2.Controls.Add(this.btnCheckExcel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpInDate);
            this.panel2.Controls.Add(this.dtpOutDate);
            this.panel2.Controls.Add(this.dtgvCheckHistory);
            this.panel2.Controls.Add(this.lbAnnouce);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(507, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 644);
            this.panel2.TabIndex = 1;
            // 
            // btnCheckData
            // 
            this.btnCheckData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckData.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.information;
            this.btnCheckData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCheckData.ButtonText = "Button";
            this.btnCheckData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCheckData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.CornerRadius = 5;
            this.btnCheckData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCheckData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCheckData.Location = new System.Drawing.Point(186, 474);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(300, 76);
            this.btnCheckData.TabIndex = 27;
            this.btnCheckData.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // btnCheckExcel
            // 
            this.btnCheckExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckExcel.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.excel;
            this.btnCheckExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCheckExcel.ButtonText = "Button";
            this.btnCheckExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCheckExcel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckExcel.CornerRadius = 5;
            this.btnCheckExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCheckExcel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCheckExcel.Location = new System.Drawing.Point(186, 556);
            this.btnCheckExcel.Name = "btnCheckExcel";
            this.btnCheckExcel.Size = new System.Drawing.Size(300, 76);
            this.btnCheckExcel.TabIndex = 26;
            this.btnCheckExcel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheckExcel.Click += new System.EventHandler(this.btnCheckExcel_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 46);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cho đến:\r\n直到 ：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 46);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thời gian từ:\r\n时间从 :";
            // 
            // dtpInDate
            // 
            this.dtpInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInDate.Location = new System.Drawing.Point(230, 346);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(256, 30);
            this.dtpInDate.TabIndex = 22;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOutDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutDate.Location = new System.Drawing.Point(230, 413);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(256, 30);
            this.dtpOutDate.TabIndex = 23;
            // 
            // dtgvCheckHistory
            // 
            this.dtgvCheckHistory.AllowUserToAddRows = false;
            this.dtgvCheckHistory.AllowUserToDeleteRows = false;
            this.dtgvCheckHistory.AllowUserToResizeColumns = false;
            this.dtgvCheckHistory.AllowUserToResizeRows = false;
            this.dtgvCheckHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCheckHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCheckHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCheckHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCheckHistory.GridColor = System.Drawing.Color.Black;
            this.dtgvCheckHistory.Location = new System.Drawing.Point(10, 59);
            this.dtgvCheckHistory.Name = "dtgvCheckHistory";
            this.dtgvCheckHistory.ReadOnly = true;
            this.dtgvCheckHistory.RowHeadersVisible = false;
            this.dtgvCheckHistory.RowHeadersWidth = 51;
            this.dtgvCheckHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvCheckHistory.RowTemplate.Height = 24;
            this.dtgvCheckHistory.Size = new System.Drawing.Size(476, 281);
            this.dtgvCheckHistory.TabIndex = 21;
            // 
            // lbAnnouce
            // 
            this.lbAnnouce.AutoSize = true;
            this.lbAnnouce.Location = new System.Drawing.Point(6, 9);
            this.lbAnnouce.Name = "lbAnnouce";
            this.lbAnnouce.Size = new System.Drawing.Size(240, 46);
            this.lbAnnouce.TabIndex = 20;
            this.lbAnnouce.Text = "Lịch sử nhận nguyên vật liệu:\r\n物料接收历史：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // CuttingManagementMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CuttingManagementMainView";
            this.Text = "CuttingManagementMainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CuttingManagementMainView_FormClosing);
            this.Load += new System.EventHandler(this.CuttingManagementMainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWeight.ResumeLayout(false);
            this.panelWeight.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private View.CustomControl.CTTextBox txbEmpReceiveCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnSearchHisEmp;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panelWeight;
        private View.CustomControl.CTTextBox txbRawQty;
        private System.Windows.Forms.ComboBox cbxDetailMat;
        private System.Windows.Forms.ComboBox txbMatCode;
        private System.Windows.Forms.Label lbWeight;
        private XanderUI.XUIButton btnConfirm;
        private System.Windows.Forms.Label lbCutQty;
        private System.Windows.Forms.Label lbAnnouce;
        private System.Windows.Forms.DataGridView dtgvCheckHistory;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIButton btnCheckExcel;
        private XanderUI.XUIButton btnCheckData;
    }
}