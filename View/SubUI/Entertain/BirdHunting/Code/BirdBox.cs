using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techlink_new_all_in_one.View.SubUI.Entertain.BirdHunting.Code
{
    public partial class BirdBox : PictureBox
    {
        public string Status { get; set; }
        public string Direction { get; set; }

        public BirdBox()
        {
            Status = "Alive";
            Direction = "Forward";
        }
    }
}
