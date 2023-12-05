using org.w3c.dom.css;
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
    public partial class BigHoseMachineInsight : UserControl
    {
        public BigHoseMachineInsight()
        {
            InitializeComponent();
        }

        private string _fName;
        private int _fStatus;

        [Category("Custom Props")]
        public string ControlName
        {
            get { return _fName; }
            set { _fName = value; xuiButton1.ButtonText = value; }
        }
        [Category("Custom Props")]
        public int Status
        {
            get { return _fStatus; }
            set
            {
                _fStatus = value;
                switch (value)
                {
                    case 1:
                        {
                            xuiButton1.BackgroundColor = Color.FromArgb(128, 128, 128);
                            xuiButton1.TextColor = Color.White;
                            break;
                        }
                    case 2:
                        {
                            xuiButton1.BackgroundColor = Color.FromArgb(30, 144, 255);
                            xuiButton1.TextColor = Color.Black;
                            break;
                        }
                    case 3:
                        {
                            xuiButton1.BackgroundColor = Color.FromArgb(255, 215, 0);
                            xuiButton1.TextColor = Color.Black;
                            break;
                        }
                    case 4:
                        {
                            xuiButton1.BackgroundColor = Color.FromArgb(255, 0, 0);
                            xuiButton1.TextColor = Color.White;
                            break;
                        }
                    default:
                        {
                            xuiButton1.BackgroundColor = Color.FromArgb(128, 128, 128);
                            xuiButton1.TextColor = Color.White;
                            break;
                        }
                }
            }
        }
    }
}
