using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace techlink_new_all_in_one.MainController.SubLogic.CustomUIShow
{
    public class CTToolTip
    {
        public static void Show(Control textbox, Form frm, string title, string body, int duration = 2000)
        {
            Control ctl = frm.ActiveControl;
            //Point point = new Point();
            //if (ctl != null)
            //{
            //    point = Cursor.Position = ctl.PointToScreen(new Point(20, 10));
            //}
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = title;
            toolTip.Show(body, frm, textbox.Location.X, textbox.Location.Y - 70, duration);
        }
    }
}
