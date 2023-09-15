namespace techlink_new_all_in_one
{
    partial class HSEDeviceManagementMainView
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
            this.tabInsight = new System.Windows.Forms.TabPage();
            this.panelInsight = new System.Windows.Forms.Panel();
            this.btnSaveDetailExcel = new XanderUI.XUIButton();
            this.dtgvShowDetailData = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.tblpDeviceInsight = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbNotHaveManagerQty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbNotCheckedDeviceQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCheckedDeviceQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbValidDeviceQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbOverExpDeviceQty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNearExpDeviceQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalDeviceQty = new System.Windows.Forms.Label();
            this.labelIS1 = new System.Windows.Forms.Label();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.panelDevice = new System.Windows.Forms.Panel();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnFastCheckData = new XanderUI.XUIButton();
            this.cbxCheckType = new System.Windows.Forms.ComboBox();
            this.xuiFlatTab1.SuspendLayout();
            this.tabInsight.SuspendLayout();
            this.panelInsight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowDetailData)).BeginInit();
            this.tblpDeviceInsight.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            this.tabDevice.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabInsight);
            this.xuiFlatTab1.Controls.Add(this.tabMaintenance);
            this.xuiFlatTab1.Controls.Add(this.tabDevice);
            this.xuiFlatTab1.Controls.Add(this.tabSetting);
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
            // tabInsight
            // 
            this.tabInsight.BackColor = System.Drawing.Color.White;
            this.tabInsight.Controls.Add(this.panelInsight);
            this.tabInsight.Location = new System.Drawing.Point(4, 20);
            this.tabInsight.Name = "tabInsight";
            this.tabInsight.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsight.Size = new System.Drawing.Size(997, 620);
            this.tabInsight.TabIndex = 0;
            this.tabInsight.Text = "Thống kê 统计";
            // 
            // panelInsight
            // 
            this.panelInsight.BackColor = System.Drawing.Color.Cyan;
            this.panelInsight.Controls.Add(this.cbxCheckType);
            this.panelInsight.Controls.Add(this.btnFastCheckData);
            this.panelInsight.Controls.Add(this.btnSaveDetailExcel);
            this.panelInsight.Controls.Add(this.dtgvShowDetailData);
            this.panelInsight.Controls.Add(this.lb1);
            this.panelInsight.Controls.Add(this.tblpDeviceInsight);
            this.panelInsight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsight.Location = new System.Drawing.Point(3, 3);
            this.panelInsight.Name = "panelInsight";
            this.panelInsight.Size = new System.Drawing.Size(991, 614);
            this.panelInsight.TabIndex = 0;
            // 
            // btnSaveDetailExcel
            // 
            this.btnSaveDetailExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetailExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaveDetailExcel.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.excel;
            this.btnSaveDetailExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSaveDetailExcel.ButtonText = "Xuất excel thống kê";
            this.btnSaveDetailExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSaveDetailExcel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveDetailExcel.CornerRadius = 10;
            this.btnSaveDetailExcel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetailExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveDetailExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSaveDetailExcel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveDetailExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveDetailExcel.Location = new System.Drawing.Point(666, 350);
            this.btnSaveDetailExcel.Name = "btnSaveDetailExcel";
            this.btnSaveDetailExcel.Size = new System.Drawing.Size(320, 66);
            this.btnSaveDetailExcel.TabIndex = 4;
            this.btnSaveDetailExcel.TextColor = System.Drawing.Color.Black;
            this.btnSaveDetailExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dtgvShowDetailData
            // 
            this.dtgvShowDetailData.AllowUserToAddRows = false;
            this.dtgvShowDetailData.AllowUserToDeleteRows = false;
            this.dtgvShowDetailData.AllowUserToResizeRows = false;
            this.dtgvShowDetailData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvShowDetailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowDetailData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShowDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowDetailData.EnableHeadersVisualStyles = false;
            this.dtgvShowDetailData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvShowDetailData.Location = new System.Drawing.Point(3, 422);
            this.dtgvShowDetailData.MultiSelect = false;
            this.dtgvShowDetailData.Name = "dtgvShowDetailData";
            this.dtgvShowDetailData.ReadOnly = true;
            this.dtgvShowDetailData.RowHeadersVisible = false;
            this.dtgvShowDetailData.RowHeadersWidth = 51;
            this.dtgvShowDetailData.RowTemplate.Height = 30;
            this.dtgvShowDetailData.RowTemplate.ReadOnly = true;
            this.dtgvShowDetailData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShowDetailData.Size = new System.Drawing.Size(983, 187);
            this.dtgvShowDetailData.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(5, 3);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(271, 46);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Thống kê sơ bộ thông tin thiết bị\r\n设备信息初步统计";
            // 
            // tblpDeviceInsight
            // 
            this.tblpDeviceInsight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpDeviceInsight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblpDeviceInsight.ColumnCount = 4;
            this.tblpDeviceInsight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDeviceInsight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDeviceInsight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDeviceInsight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpDeviceInsight.Controls.Add(this.panel8, 3, 1);
            this.tblpDeviceInsight.Controls.Add(this.panel7, 2, 1);
            this.tblpDeviceInsight.Controls.Add(this.panel6, 1, 1);
            this.tblpDeviceInsight.Controls.Add(this.panel5, 0, 1);
            this.tblpDeviceInsight.Controls.Add(this.panel4, 3, 0);
            this.tblpDeviceInsight.Controls.Add(this.panel3, 2, 0);
            this.tblpDeviceInsight.Controls.Add(this.panel2, 1, 0);
            this.tblpDeviceInsight.Controls.Add(this.panel1, 0, 0);
            this.tblpDeviceInsight.Location = new System.Drawing.Point(3, 52);
            this.tblpDeviceInsight.Name = "tblpDeviceInsight";
            this.tblpDeviceInsight.RowCount = 2;
            this.tblpDeviceInsight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDeviceInsight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDeviceInsight.Size = new System.Drawing.Size(983, 292);
            this.tblpDeviceInsight.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(740, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 137);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.lbNotHaveManagerQty);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(495, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 137);
            this.panel7.TabIndex = 6;
            // 
            // lbNotHaveManagerQty
            // 
            this.lbNotHaveManagerQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNotHaveManagerQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotHaveManagerQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotHaveManagerQty.Location = new System.Drawing.Point(0, 67);
            this.lbNotHaveManagerQty.Name = "lbNotHaveManagerQty";
            this.lbNotHaveManagerQty.Size = new System.Drawing.Size(237, 70);
            this.lbNotHaveManagerQty.TabIndex = 7;
            this.lbNotHaveManagerQty.Text = "0";
            this.lbNotHaveManagerQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 67);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chưa có người quản lý\r\n还没有经理";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.lbNotCheckedDeviceQty);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(250, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 137);
            this.panel6.TabIndex = 5;
            // 
            // lbNotCheckedDeviceQty
            // 
            this.lbNotCheckedDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNotCheckedDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotCheckedDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotCheckedDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbNotCheckedDeviceQty.Name = "lbNotCheckedDeviceQty";
            this.lbNotCheckedDeviceQty.Size = new System.Drawing.Size(237, 70);
            this.lbNotCheckedDeviceQty.TabIndex = 6;
            this.lbNotCheckedDeviceQty.Text = "0";
            this.lbNotCheckedDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 67);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chưa được kiểm tra\r\n尚未测试";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.lbCheckedDeviceQty);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 137);
            this.panel5.TabIndex = 4;
            // 
            // lbCheckedDeviceQty
            // 
            this.lbCheckedDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCheckedDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCheckedDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckedDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbCheckedDeviceQty.Name = "lbCheckedDeviceQty";
            this.lbCheckedDeviceQty.Size = new System.Drawing.Size(237, 70);
            this.lbCheckedDeviceQty.TabIndex = 5;
            this.lbCheckedDeviceQty.Text = "0";
            this.lbCheckedDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 67);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đã kiểm tra\r\n已检查";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lbValidDeviceQty);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(740, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 137);
            this.panel4.TabIndex = 3;
            // 
            // lbValidDeviceQty
            // 
            this.lbValidDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValidDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbValidDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbValidDeviceQty.Name = "lbValidDeviceQty";
            this.lbValidDeviceQty.Size = new System.Drawing.Size(238, 70);
            this.lbValidDeviceQty.TabIndex = 4;
            this.lbValidDeviceQty.Text = "0";
            this.lbValidDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 67);
            this.label3.TabIndex = 1;
            this.label3.Text = "Còn hạn sử dụng\r\n仍然过期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.lbOverExpDeviceQty);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(495, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 137);
            this.panel3.TabIndex = 2;
            // 
            // lbOverExpDeviceQty
            // 
            this.lbOverExpDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOverExpDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOverExpDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverExpDeviceQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbOverExpDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbOverExpDeviceQty.Name = "lbOverExpDeviceQty";
            this.lbOverExpDeviceQty.Size = new System.Drawing.Size(237, 70);
            this.lbOverExpDeviceQty.TabIndex = 3;
            this.lbOverExpDeviceQty.Text = "0";
            this.lbOverExpDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đã quá hạn bảo trì\r\n维护已逾期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lbNearExpDeviceQty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 137);
            this.panel2.TabIndex = 1;
            // 
            // lbNearExpDeviceQty
            // 
            this.lbNearExpDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNearExpDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNearExpDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNearExpDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbNearExpDeviceQty.Name = "lbNearExpDeviceQty";
            this.lbNearExpDeviceQty.Size = new System.Drawing.Size(237, 70);
            this.lbNearExpDeviceQty.TabIndex = 2;
            this.lbNearExpDeviceQty.Text = "0";
            this.lbNearExpDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gần đến hạn bảo trì\r\n维护即将到期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbTotalDeviceQty);
            this.panel1.Controls.Add(this.labelIS1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 137);
            this.panel1.TabIndex = 0;
            // 
            // lbTotalDeviceQty
            // 
            this.lbTotalDeviceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalDeviceQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalDeviceQty.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDeviceQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTotalDeviceQty.Location = new System.Drawing.Point(0, 67);
            this.lbTotalDeviceQty.Name = "lbTotalDeviceQty";
            this.lbTotalDeviceQty.Size = new System.Drawing.Size(237, 70);
            this.lbTotalDeviceQty.TabIndex = 1;
            this.lbTotalDeviceQty.Text = "0";
            this.lbTotalDeviceQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIS1
            // 
            this.labelIS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIS1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelIS1.Location = new System.Drawing.Point(0, 0);
            this.labelIS1.Name = "labelIS1";
            this.labelIS1.Size = new System.Drawing.Size(237, 67);
            this.labelIS1.TabIndex = 0;
            this.labelIS1.Text = "Tống số thiết bị\r\n设备总数";
            this.labelIS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.BackColor = System.Drawing.Color.White;
            this.tabMaintenance.Controls.Add(this.panelMaintenance);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 20);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaintenance.Size = new System.Drawing.Size(997, 620);
            this.tabMaintenance.TabIndex = 1;
            this.tabMaintenance.Text = "Bảo trì 保养";
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.BackColor = System.Drawing.Color.Cyan;
            this.panelMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaintenance.Location = new System.Drawing.Point(3, 3);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(991, 614);
            this.panelMaintenance.TabIndex = 0;
            // 
            // tabDevice
            // 
            this.tabDevice.BackColor = System.Drawing.Color.White;
            this.tabDevice.Controls.Add(this.panelDevice);
            this.tabDevice.Location = new System.Drawing.Point(4, 20);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Size = new System.Drawing.Size(997, 620);
            this.tabDevice.TabIndex = 2;
            this.tabDevice.Text = "Thiết bị 设备";
            // 
            // panelDevice
            // 
            this.panelDevice.BackColor = System.Drawing.Color.Cyan;
            this.panelDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDevice.Location = new System.Drawing.Point(0, 0);
            this.panelDevice.Name = "panelDevice";
            this.panelDevice.Size = new System.Drawing.Size(997, 620);
            this.panelDevice.TabIndex = 1;
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.White;
            this.tabSetting.Controls.Add(this.panelSetting);
            this.tabSetting.Location = new System.Drawing.Point(4, 20);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(997, 620);
            this.tabSetting.TabIndex = 3;
            this.tabSetting.Text = "Cài đặt 安设";
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Cyan;
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(997, 620);
            this.panelSetting.TabIndex = 1;
            // 
            // btnFastCheckData
            // 
            this.btnFastCheckData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFastCheckData.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.information;
            this.btnFastCheckData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnFastCheckData.ButtonText = "Xem nhanh";
            this.btnFastCheckData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFastCheckData.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFastCheckData.CornerRadius = 10;
            this.btnFastCheckData.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCheckData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFastCheckData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFastCheckData.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFastCheckData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFastCheckData.Location = new System.Drawing.Point(8, 350);
            this.btnFastCheckData.Name = "btnFastCheckData";
            this.btnFastCheckData.Size = new System.Drawing.Size(249, 66);
            this.btnFastCheckData.TabIndex = 5;
            this.btnFastCheckData.TextColor = System.Drawing.Color.Black;
            this.btnFastCheckData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFastCheckData.Click += new System.EventHandler(this.btnFastCheckData_Click);
            // 
            // cbxCheckType
            // 
            this.cbxCheckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCheckType.FormattingEnabled = true;
            this.cbxCheckType.Items.AddRange(new object[] {
            "Tổng số thiết bị 设备总数",
            "Gần đến hạn bảo trì 维护即将到期",
            "Đã quá hạn bảo trì 维护已逾期",
            "Còn hạn sử dụng 仍然过期",
            "Đã kiểm tra 已检查",
            "Chưa được kiểm tra 尚未测试"});
            this.cbxCheckType.Location = new System.Drawing.Point(263, 367);
            this.cbxCheckType.Name = "cbxCheckType";
            this.cbxCheckType.Size = new System.Drawing.Size(346, 31);
            this.cbxCheckType.TabIndex = 6;
            // 
            // HSEDeviceManagementMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1005, 644);
            this.Controls.Add(this.xuiFlatTab1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HSEDeviceManagementMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HSEDeviceManagementMainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HSEDeviceManagementMainView_FormClosing);
            this.Load += new System.EventHandler(this.HSEDeviceManagementMainView_Load);
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabInsight.ResumeLayout(false);
            this.panelInsight.ResumeLayout(false);
            this.panelInsight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowDetailData)).EndInit();
            this.tblpDeviceInsight.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabMaintenance.ResumeLayout(false);
            this.tabDevice.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabInsight;
        private System.Windows.Forms.TabPage tabMaintenance;
        private System.Windows.Forms.Panel panelInsight;
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.TabPage tabDevice;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Panel panelDevice;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.TableLayoutPanel tblpDeviceInsight;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbValidDeviceQty;
        private System.Windows.Forms.Label lbOverExpDeviceQty;
        private System.Windows.Forms.Label lbNearExpDeviceQty;
        private System.Windows.Forms.Label lbTotalDeviceQty;
        private System.Windows.Forms.Label lbNotHaveManagerQty;
        private System.Windows.Forms.Label lbNotCheckedDeviceQty;
        private System.Windows.Forms.Label lbCheckedDeviceQty;
        private System.Windows.Forms.DataGridView dtgvShowDetailData;
        private XanderUI.XUIButton btnSaveDetailExcel;
        private XanderUI.XUIButton btnFastCheckData;
        private System.Windows.Forms.ComboBox cbxCheckType;
    }
}