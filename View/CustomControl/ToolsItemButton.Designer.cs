namespace techlink_new_all_in_one.View.CustomControl
{
    partial class ToolsItemButton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 157);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(11, 15);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(132, 124);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            this.pb_icon.MouseEnter += new System.EventHandler(this.pb_icon_MouseEnter);
            this.pb_icon.MouseLeave += new System.EventHandler(this.pb_icon_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(152, 0);
            this.lbl_title.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbl_title.Size = new System.Drawing.Size(70, 35);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "label1";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.MouseEnter += new System.EventHandler(this.lbl_title_MouseEnter);
            this.lbl_title.MouseLeave += new System.EventHandler(this.lbl_title_MouseLeave);
            // 
            // ToolsItemButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ToolsItemButton";
            this.Size = new System.Drawing.Size(395, 157);
            this.MouseEnter += new System.EventHandler(this.ToolsItemButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ToolsItemButton_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_title;
    }
}
