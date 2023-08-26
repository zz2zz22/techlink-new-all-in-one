namespace techlink_new_all_in_one.View.CustomControl
{
    partial class ProgressDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new XanderUI.XUIFlatProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_announce = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(245)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_announce);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 226);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(294, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 42);
            this.panel2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.progressBar1.BarThickness = 5;
            this.progressBar1.CompleteColor = System.Drawing.Color.Yellow;
            this.progressBar1.InocmpletedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 36);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Text = "xuiFlatProgressBar1";
            this.progressBar1.Value = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::techlink_new_all_in_one.Properties.Resources.papaz_roast;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_announce
            // 
            this.lb_announce.AutoSize = true;
            this.lb_announce.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_announce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_announce.Location = new System.Drawing.Point(294, 91);
            this.lb_announce.Name = "lb_announce";
            this.lb_announce.Size = new System.Drawing.Size(187, 19);
            this.lb_announce.TabIndex = 2;
            this.lb_announce.Text = "Loading ... Please wait...";
            // 
            // ProgressDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(644, 250);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(644, 250);
            this.MinimumSize = new System.Drawing.Size(644, 250);
            this.Name = "ProgressDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIFlatProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_announce;
        private System.Windows.Forms.Panel panel2;
    }
}