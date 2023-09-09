namespace techlink_new_all_in_one.View.CustomControl
{
    partial class CTProductCountdown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCountdown = new System.Windows.Forms.Panel();
            this.lbCDTimer = new System.Windows.Forms.Label();
            this.tblpStationInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelR4 = new System.Windows.Forms.Panel();
            this.lbDefectQty = new System.Windows.Forms.Label();
            this.panelR4_1 = new System.Windows.Forms.Panel();
            this.lbR4 = new System.Windows.Forms.Label();
            this.panelR3 = new System.Windows.Forms.Panel();
            this.lbCurrentQty = new System.Windows.Forms.Label();
            this.panelR3_1 = new System.Windows.Forms.Panel();
            this.lbR3 = new System.Windows.Forms.Label();
            this.panelR2 = new System.Windows.Forms.Panel();
            this.lbProductTarget = new System.Windows.Forms.Label();
            this.panelR2_1 = new System.Windows.Forms.Panel();
            this.lbR2 = new System.Windows.Forms.Label();
            this.panelR1 = new System.Windows.Forms.Panel();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.panelR1_1 = new System.Windows.Forms.Panel();
            this.lbR1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbStationName = new System.Windows.Forms.Label();
            this.panelCountdown.SuspendLayout();
            this.tblpStationInfo.SuspendLayout();
            this.panelR4.SuspendLayout();
            this.panelR4_1.SuspendLayout();
            this.panelR3.SuspendLayout();
            this.panelR3_1.SuspendLayout();
            this.panelR2.SuspendLayout();
            this.panelR2_1.SuspendLayout();
            this.panelR1.SuspendLayout();
            this.panelR1_1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCountdown
            // 
            this.panelCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelCountdown.Controls.Add(this.lbCDTimer);
            this.panelCountdown.Controls.Add(this.tblpStationInfo);
            this.panelCountdown.Controls.Add(this.panelHeader);
            this.panelCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCountdown.Location = new System.Drawing.Point(0, 0);
            this.panelCountdown.Name = "panelCountdown";
            this.panelCountdown.Size = new System.Drawing.Size(581, 282);
            this.panelCountdown.TabIndex = 1;
            // 
            // lbCDTimer
            // 
            this.lbCDTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbCDTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCDTimer.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDTimer.ForeColor = System.Drawing.Color.Black;
            this.lbCDTimer.Location = new System.Drawing.Point(0, 188);
            this.lbCDTimer.Name = "lbCDTimer";
            this.lbCDTimer.Size = new System.Drawing.Size(581, 94);
            this.lbCDTimer.TabIndex = 17;
            this.lbCDTimer.Text = "00 : 00 : 00";
            this.lbCDTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblpStationInfo
            // 
            this.tblpStationInfo.BackColor = System.Drawing.Color.Transparent;
            this.tblpStationInfo.ColumnCount = 4;
            this.tblpStationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpStationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpStationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpStationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpStationInfo.Controls.Add(this.panelR4, 3, 0);
            this.tblpStationInfo.Controls.Add(this.panelR3, 2, 0);
            this.tblpStationInfo.Controls.Add(this.panelR2, 1, 0);
            this.tblpStationInfo.Controls.Add(this.panelR1, 0, 0);
            this.tblpStationInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblpStationInfo.Location = new System.Drawing.Point(0, 52);
            this.tblpStationInfo.Name = "tblpStationInfo";
            this.tblpStationInfo.RowCount = 1;
            this.tblpStationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpStationInfo.Size = new System.Drawing.Size(581, 136);
            this.tblpStationInfo.TabIndex = 1;
            // 
            // panelR4
            // 
            this.panelR4.BackColor = System.Drawing.Color.Red;
            this.panelR4.Controls.Add(this.lbDefectQty);
            this.panelR4.Controls.Add(this.panelR4_1);
            this.panelR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelR4.Location = new System.Drawing.Point(467, 3);
            this.panelR4.Name = "panelR4";
            this.panelR4.Size = new System.Drawing.Size(111, 130);
            this.panelR4.TabIndex = 3;
            // 
            // lbDefectQty
            // 
            this.lbDefectQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefectQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDefectQty.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefectQty.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbDefectQty.Location = new System.Drawing.Point(0, 46);
            this.lbDefectQty.Name = "lbDefectQty";
            this.lbDefectQty.Size = new System.Drawing.Size(111, 84);
            this.lbDefectQty.TabIndex = 17;
            this.lbDefectQty.Text = "...";
            this.lbDefectQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR4_1
            // 
            this.panelR4_1.BackColor = System.Drawing.Color.Red;
            this.panelR4_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR4_1.Controls.Add(this.lbR4);
            this.panelR4_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelR4_1.Location = new System.Drawing.Point(0, 0);
            this.panelR4_1.Name = "panelR4_1";
            this.panelR4_1.Size = new System.Drawing.Size(111, 46);
            this.panelR4_1.TabIndex = 3;
            // 
            // lbR4
            // 
            this.lbR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR4.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbR4.Location = new System.Drawing.Point(0, 0);
            this.lbR4.Name = "lbR4";
            this.lbR4.Size = new System.Drawing.Size(109, 44);
            this.lbR4.TabIndex = 16;
            this.lbR4.Text = "DEFECT";
            this.lbR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR3
            // 
            this.panelR3.BackColor = System.Drawing.Color.YellowGreen;
            this.panelR3.Controls.Add(this.lbCurrentQty);
            this.panelR3.Controls.Add(this.panelR3_1);
            this.panelR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelR3.Location = new System.Drawing.Point(351, 3);
            this.panelR3.Name = "panelR3";
            this.panelR3.Size = new System.Drawing.Size(110, 130);
            this.panelR3.TabIndex = 2;
            // 
            // lbCurrentQty
            // 
            this.lbCurrentQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCurrentQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentQty.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentQty.ForeColor = System.Drawing.Color.Black;
            this.lbCurrentQty.Location = new System.Drawing.Point(0, 46);
            this.lbCurrentQty.Name = "lbCurrentQty";
            this.lbCurrentQty.Size = new System.Drawing.Size(110, 84);
            this.lbCurrentQty.TabIndex = 17;
            this.lbCurrentQty.Text = "...";
            this.lbCurrentQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR3_1
            // 
            this.panelR3_1.BackColor = System.Drawing.Color.YellowGreen;
            this.panelR3_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR3_1.Controls.Add(this.lbR3);
            this.panelR3_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelR3_1.Location = new System.Drawing.Point(0, 0);
            this.panelR3_1.Name = "panelR3_1";
            this.panelR3_1.Size = new System.Drawing.Size(110, 46);
            this.panelR3_1.TabIndex = 2;
            // 
            // lbR3
            // 
            this.lbR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR3.ForeColor = System.Drawing.Color.Black;
            this.lbR3.Location = new System.Drawing.Point(0, 0);
            this.lbR3.Name = "lbR3";
            this.lbR3.Size = new System.Drawing.Size(108, 44);
            this.lbR3.TabIndex = 16;
            this.lbR3.Text = "Qty.";
            this.lbR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR2
            // 
            this.panelR2.BackColor = System.Drawing.Color.LightYellow;
            this.panelR2.Controls.Add(this.lbProductTarget);
            this.panelR2.Controls.Add(this.panelR2_1);
            this.panelR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelR2.Location = new System.Drawing.Point(235, 3);
            this.panelR2.Name = "panelR2";
            this.panelR2.Size = new System.Drawing.Size(110, 130);
            this.panelR2.TabIndex = 1;
            // 
            // lbProductTarget
            // 
            this.lbProductTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProductTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductTarget.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductTarget.ForeColor = System.Drawing.Color.Black;
            this.lbProductTarget.Location = new System.Drawing.Point(0, 46);
            this.lbProductTarget.Name = "lbProductTarget";
            this.lbProductTarget.Size = new System.Drawing.Size(110, 84);
            this.lbProductTarget.TabIndex = 17;
            this.lbProductTarget.Text = "...";
            this.lbProductTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR2_1
            // 
            this.panelR2_1.BackColor = System.Drawing.Color.LightYellow;
            this.panelR2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR2_1.Controls.Add(this.lbR2);
            this.panelR2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelR2_1.Location = new System.Drawing.Point(0, 0);
            this.panelR2_1.Name = "panelR2_1";
            this.panelR2_1.Size = new System.Drawing.Size(110, 46);
            this.panelR2_1.TabIndex = 1;
            // 
            // lbR2
            // 
            this.lbR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR2.ForeColor = System.Drawing.Color.Black;
            this.lbR2.Location = new System.Drawing.Point(0, 0);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(108, 44);
            this.lbR2.TabIndex = 16;
            this.lbR2.Text = "Target";
            this.lbR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelR1
            // 
            this.panelR1.BackColor = System.Drawing.Color.CadetBlue;
            this.panelR1.Controls.Add(this.lbProductNo);
            this.panelR1.Controls.Add(this.panelR1_1);
            this.panelR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelR1.Location = new System.Drawing.Point(3, 3);
            this.panelR1.Name = "panelR1";
            this.panelR1.Size = new System.Drawing.Size(226, 130);
            this.panelR1.TabIndex = 0;
            // 
            // lbProductNo
            // 
            this.lbProductNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProductNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductNo.ForeColor = System.Drawing.Color.White;
            this.lbProductNo.Location = new System.Drawing.Point(0, 46);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(226, 84);
            this.lbProductNo.TabIndex = 1;
            this.lbProductNo.Text = "...";
            this.lbProductNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelR1_1
            // 
            this.panelR1_1.BackColor = System.Drawing.Color.CadetBlue;
            this.panelR1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR1_1.Controls.Add(this.lbR1);
            this.panelR1_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelR1_1.Location = new System.Drawing.Point(0, 0);
            this.panelR1_1.Name = "panelR1_1";
            this.panelR1_1.Size = new System.Drawing.Size(226, 46);
            this.panelR1_1.TabIndex = 0;
            // 
            // lbR1
            // 
            this.lbR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbR1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR1.ForeColor = System.Drawing.Color.White;
            this.lbR1.Location = new System.Drawing.Point(0, 0);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(224, 44);
            this.lbR1.TabIndex = 0;
            this.lbR1.Text = "Mã hàng 普鲁";
            this.lbR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lbStationName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(581, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // lbStationName
            // 
            this.lbStationName.BackColor = System.Drawing.Color.Transparent;
            this.lbStationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStationName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationName.ForeColor = System.Drawing.Color.Black;
            this.lbStationName.Location = new System.Drawing.Point(0, 0);
            this.lbStationName.Name = "lbStationName";
            this.lbStationName.Size = new System.Drawing.Size(581, 52);
            this.lbStationName.TabIndex = 1;
            this.lbStationName.Text = "Cuốn ống 卷筒";
            this.lbStationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CTProductCountdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelCountdown);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CTProductCountdown";
            this.Size = new System.Drawing.Size(581, 282);
            this.Load += new System.EventHandler(this.CTProductCountdown_Load);
            this.panelCountdown.ResumeLayout(false);
            this.tblpStationInfo.ResumeLayout(false);
            this.panelR4.ResumeLayout(false);
            this.panelR4_1.ResumeLayout(false);
            this.panelR3.ResumeLayout(false);
            this.panelR3_1.ResumeLayout(false);
            this.panelR2.ResumeLayout(false);
            this.panelR2_1.ResumeLayout(false);
            this.panelR1.ResumeLayout(false);
            this.panelR1_1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCountdown;
        private System.Windows.Forms.Label lbCDTimer;
        private System.Windows.Forms.TableLayoutPanel tblpStationInfo;
        private System.Windows.Forms.Panel panelR4;
        private System.Windows.Forms.Label lbDefectQty;
        private System.Windows.Forms.Panel panelR4_1;
        private System.Windows.Forms.Label lbR4;
        private System.Windows.Forms.Panel panelR3;
        private System.Windows.Forms.Label lbCurrentQty;
        private System.Windows.Forms.Panel panelR3_1;
        private System.Windows.Forms.Label lbR3;
        private System.Windows.Forms.Panel panelR2;
        private System.Windows.Forms.Label lbProductTarget;
        private System.Windows.Forms.Panel panelR2_1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Panel panelR1;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.Panel panelR1_1;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbStationName;
    }
}
