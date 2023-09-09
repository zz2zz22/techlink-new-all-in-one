using System;
using System.Drawing;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic.FontEmbedded;

namespace techlink_new_all_in_one.View.CustomControl
{
    public partial class CTProductCountdown : UserControl
    {
        public CTProductCountdown(string stationName, string productNo)
        {
            InitializeComponent();
            lbStationName.Text = stationName;
            lbProductNo.Text = productNo;
        }

        private void CTProductCountdown_Load(object sender, EventArgs e)
        {
            CustomFont.LoadCustomFont();
            lbStationName.Font = new Font(CustomFont.pfc.Families[0], 20, FontStyle.Bold);
        }
    }
}
