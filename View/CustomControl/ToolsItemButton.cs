using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techlink_new_all_in_one.View.CustomControl
{
    public delegate void GlobalMouseClickEventHander(object sender, MouseEventArgs e);
    public partial class ToolsItemButton : UserControl
    {
        public ToolsItemButton()
        {
            InitializeComponent();
            BindControlMouseClicks(this);
        }

        private Image _icon;
        private string _title;
        private string _fName;
        private string _fPermission;
        private string _fStatus;

        private void BindControlMouseClicks(Control con)
        {
            con.MouseClick += delegate (object sender, MouseEventArgs e)
            {
                TriggerMouseClicked(sender, e);
            };
            // bind to controls already added
            foreach (Control i in con.Controls)
            {
                BindControlMouseClicks(i);
            }
            // bind to controls added in the future
            con.ControlAdded += delegate (object sender, ControlEventArgs e)
            {
                BindControlMouseClicks(e.Control);
            };
        }

        private void TriggerMouseClicked(object sender, MouseEventArgs e)
        {
            GlobalMouseClick?.Invoke(sender, e);
        }

        [Category("Action")]
        [Description("Fires when any control on the form is clicked.")]
        public event GlobalMouseClickEventHander GlobalMouseClick;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_icon.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_title.Text = value; }
        }

        [Category("Custom Props")]
        public string FormName
        {
            get { return _fName; }
            set { _fName = value;}
        }

        [Category("Custom Props")]
        public string Permission
        {
            get { return _fPermission; }
            set { _fPermission = value; }
        }
        [Category("Custom Props")]
        public string Status
        {
            get { return _fStatus; }
            set { _fStatus = value; }
        }

        private void ToolsItemButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void ToolsItemButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 153);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 153);
        }

        private void pb_icon_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void pb_icon_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 153);
        }

        private void lbl_title_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void lbl_title_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 153);
        }
    }
}
