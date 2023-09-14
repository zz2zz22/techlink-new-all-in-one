namespace techlink_new_all_in_one
{
    partial class StationCountDownServer
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
            this.txbSearchTool = new techlink_new_all_in_one.View.CustomControl.CTTextBox();
            this.flpCDProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearchTool
            // 
            this.txbSearchTool.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchTool.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txbSearchTool.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.txbSearchTool.BorderRadius = 12;
            this.txbSearchTool.BorderSize = 2;
            this.txbSearchTool.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTool.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchTool.Location = new System.Drawing.Point(4, 4);
            this.txbSearchTool.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchTool.Multiline = false;
            this.txbSearchTool.Name = "txbSearchTool";
            this.txbSearchTool.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSearchTool.PasswordChar = false;
            this.txbSearchTool.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchTool.PlaceholderText = "Tìm mã hàng 查找产品代码";
            this.txbSearchTool.Size = new System.Drawing.Size(555, 36);
            this.txbSearchTool.TabIndex = 16;
            this.txbSearchTool.Texts = "";
            this.txbSearchTool.UnderlinedStyle = false;
            this.txbSearchTool._TextChanged += new System.EventHandler(this.txbSearchTool__TextChanged);
            this.txbSearchTool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchTool_KeyDown);
            // 
            // flpCDProducts
            // 
            this.flpCDProducts.BackColor = System.Drawing.Color.Cyan;
            this.flpCDProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCDProducts.Location = new System.Drawing.Point(0, 44);
            this.flpCDProducts.Name = "flpCDProducts";
            this.flpCDProducts.Size = new System.Drawing.Size(1138, 585);
            this.flpCDProducts.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearchTool);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 44);
            this.panel1.TabIndex = 21;
            // 
            // StationCountDownServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1138, 629);
            this.Controls.Add(this.flpCDProducts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StationCountDownServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StationCountDownServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StationCountDownServer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StationCountDownServer_FormClosed);
            this.Load += new System.EventHandler(this.StationCountDownServer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpCDProducts;
        private View.CustomControl.CTTextBox txbSearchTool;
        private System.Windows.Forms.Panel panel1;
    }
}