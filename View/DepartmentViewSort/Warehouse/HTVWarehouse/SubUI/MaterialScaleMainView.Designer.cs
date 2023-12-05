namespace techlink_new_all_in_one.View.DepartmentViewSort.Warehouse.HTVWarehouse.SubUI
{
    partial class MaterialScaleMainView
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
            this.lbScaleRT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelWeight = new System.Windows.Forms.Panel();
            this.lbTolerance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaterialCode = new System.Windows.Forms.Label();
            this.lbAnnounce = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClose = new XanderUI.XUIButton();
            this.btnFinishAll = new XanderUI.XUIButton();
            this.panelWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbScaleRT
            // 
            this.lbScaleRT.BackColor = System.Drawing.Color.Transparent;
            this.lbScaleRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScaleRT.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScaleRT.ForeColor = System.Drawing.Color.White;
            this.lbScaleRT.Location = new System.Drawing.Point(0, 0);
            this.lbScaleRT.Name = "lbScaleRT";
            this.lbScaleRT.Size = new System.Drawing.Size(768, 158);
            this.lbScaleRT.TabIndex = 0;
            this.lbScaleRT.Text = "0.00";
            this.lbScaleRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 38);
            this.label4.TabIndex = 40;
            this.label4.Text = "Trọng lượng đang cân:\r\n体重正在称重：";
            // 
            // panelWeight
            // 
            this.panelWeight.BackColor = System.Drawing.Color.Black;
            this.panelWeight.Controls.Add(this.lbScaleRT);
            this.panelWeight.Location = new System.Drawing.Point(15, 178);
            this.panelWeight.Name = "panelWeight";
            this.panelWeight.Size = new System.Drawing.Size(768, 158);
            this.panelWeight.TabIndex = 39;
            // 
            // lbTolerance
            // 
            this.lbTolerance.AutoSize = true;
            this.lbTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTolerance.Location = new System.Drawing.Point(287, 80);
            this.lbTolerance.Name = "lbTolerance";
            this.lbTolerance.Size = new System.Drawing.Size(132, 29);
            this.lbTolerance.TabIndex = 38;
            this.lbTolerance.Text = "Tolerance";
            this.lbTolerance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 38);
            this.label3.TabIndex = 37;
            this.label3.Text = "Khoảng trọng lượng đạt yêu cầu:\r\n大概重量范围：";
            // 
            // lbMaterialCode
            // 
            this.lbMaterialCode.AutoSize = true;
            this.lbMaterialCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialCode.Location = new System.Drawing.Point(157, 20);
            this.lbMaterialCode.Name = "lbMaterialCode";
            this.lbMaterialCode.Size = new System.Drawing.Size(30, 25);
            this.lbMaterialCode.TabIndex = 35;
            this.lbMaterialCode.Text = "...";
            // 
            // lbAnnounce
            // 
            this.lbAnnounce.AutoSize = true;
            this.lbAnnounce.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnounce.Location = new System.Drawing.Point(15, 9);
            this.lbAnnounce.Name = "lbAnnounce";
            this.lbAnnounce.Size = new System.Drawing.Size(136, 46);
            this.lbAnnounce.TabIndex = 34;
            this.lbAnnounce.Text = "Mã liệu:\r\nMaterial code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 32;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.cancel;
            this.btnClose.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnClose.ButtonText = "Button";
            this.btnClose.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnClose.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.CornerRadius = 5;
            this.btnClose.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnClose.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnClose.Location = new System.Drawing.Point(727, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 41;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFinishAll
            // 
            this.btnFinishAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFinishAll.ButtonImage = global::techlink_new_all_in_one.Properties.Resources.submit;
            this.btnFinishAll.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnFinishAll.ButtonText = "Finish";
            this.btnFinishAll.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFinishAll.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFinishAll.CornerRadius = 10;
            this.btnFinishAll.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishAll.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFinishAll.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFinishAll.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFinishAll.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFinishAll.Location = new System.Drawing.Point(529, 388);
            this.btnFinishAll.Name = "btnFinishAll";
            this.btnFinishAll.Size = new System.Drawing.Size(254, 71);
            this.btnFinishAll.TabIndex = 31;
            this.btnFinishAll.TextColor = System.Drawing.Color.Black;
            this.btnFinishAll.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFinishAll.Click += new System.EventHandler(this.btnFinishAll_Click);
            // 
            // MaterialScaleMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(792, 471);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelWeight);
            this.Controls.Add(this.lbTolerance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaterialCode);
            this.Controls.Add(this.lbAnnounce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinishAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialScaleMainView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialScaleMainView";
            this.Load += new System.EventHandler(this.MaterialScaleMainView_Load);
            this.panelWeight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScaleRT;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelWeight;
        private System.Windows.Forms.Label lbTolerance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaterialCode;
        private System.Windows.Forms.Label lbAnnounce;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnFinishAll;
        private System.IO.Ports.SerialPort serialPort1;
    }
}