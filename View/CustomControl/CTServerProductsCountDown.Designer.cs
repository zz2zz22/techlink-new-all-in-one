namespace techlink_new_all_in_one.View.CustomControl
{
    partial class CTServerProductsCountDown
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
            this.lbCountDown = new System.Windows.Forms.Label();
            this.lbStationName = new System.Windows.Forms.Label();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.pbxPause = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPause)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCountDown
            // 
            this.lbCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lbCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.Location = new System.Drawing.Point(0, 0);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(405, 76);
            this.lbCountDown.TabIndex = 2;
            this.lbCountDown.Text = "00 : 00 : 00";
            this.lbCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStationName
            // 
            this.lbStationName.BackColor = System.Drawing.Color.Transparent;
            this.lbStationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStationName.Location = new System.Drawing.Point(3, 47);
            this.lbStationName.Name = "lbStationName";
            this.lbStationName.Size = new System.Drawing.Size(293, 47);
            this.lbStationName.TabIndex = 1;
            this.lbStationName.Text = "station name";
            this.lbStationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProductNo
            // 
            this.lbProductNo.BackColor = System.Drawing.Color.Transparent;
            this.lbProductNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductNo.Location = new System.Drawing.Point(3, 0);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(293, 47);
            this.lbProductNo.TabIndex = 2;
            this.lbProductNo.Text = "product code";
            this.lbProductNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxPause
            // 
            this.pbxPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPause.Image = global::techlink_new_all_in_one.Properties.Resources.cd_play;
            this.pbxPause.Location = new System.Drawing.Point(0, 0);
            this.pbxPause.Name = "pbxPause";
            this.pbxPause.Size = new System.Drawing.Size(104, 94);
            this.pbxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPause.TabIndex = 0;
            this.pbxPause.TabStop = false;
            this.pbxPause.Click += new System.EventHandler(this.pbxPause_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 96);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbProductNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStationName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 94);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxPause);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 94);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbCountDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 76);
            this.panel3.TabIndex = 4;
            // 
            // CTServerProductsCountDown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CTServerProductsCountDown";
            this.Size = new System.Drawing.Size(405, 172);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPause)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbStationName;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.PictureBox pbxPause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
