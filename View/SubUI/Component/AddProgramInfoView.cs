using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;

namespace techlink_new_all_in_one.View.SubUI.Component
{
    public partial class AddProgramInfoView : Form
    {
        public AddProgramInfoView()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pb_image.Image = image;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlSoft sqlSoft = new SqlSoft();
            if (pb_image.Image != null)
            {
                string name = txbNameVN.Texts + "\r\n\r\n" + txbNameTQ.Texts;
                sqlSoft.sqlInsertProgramInfo(name, txbPermission.Texts, txbDescription.Texts, txbFormName.Texts, pb_image.Image, txbType.Texts);
                this.Close();
            }
        }
    }
}
