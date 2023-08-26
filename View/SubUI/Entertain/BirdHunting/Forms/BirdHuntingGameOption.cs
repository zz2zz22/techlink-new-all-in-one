using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.View.SubUI.Entertain.BirdHunting.Code;
using techlink_new_all_in_one.View.SubUI.Entertain.BirdHunting.Forms;

namespace techlink_new_all_in_one
{
    public partial class BirdHuntingGameOption : Form
    {
        #region Define as Singleton
        private static BirdHuntingGameOption _Instance;

        public static BirdHuntingGameOption Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BirdHuntingGameOption();
                }

                return (_Instance);
            }
        }

        public BirdHuntingGameOption()
        {
            InitializeComponent();
        }
        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void BirdHuntingGameOption_Load(object sender, EventArgs e)
        {
            cmbGun.SelectedIndex = 0;
            cmbBird.SelectedIndex = 0;
        }

        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGun.SelectedItem.ToString() == "9mm Glock 17")
            {
                pbGun.Image = Properties.Resources.Glock_Gun;
            }
            else if (cmbGun.SelectedItem.ToString() == "M1 Garand Single")
            {
                pbGun.Image = Properties.Resources.M1Garand_Gun;
            }
            else if (cmbGun.SelectedItem.ToString() == "ShotGun")
            {
                pbGun.Image = Properties.Resources.Shotgun;
            }
        }

        private void cmbBird_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBird.SelectedItem.ToString() == "Parrot")
            {
                pbBird.Image = Properties.Resources.bird3;
            }
            else if (cmbBird.SelectedItem.ToString() == "Stork")
            {
                pbBird.Image = Properties.Resources.Stork_Bird;
            }
            else if (cmbBird.SelectedItem.ToString() == "Crow")
            {
                pbBird.Image = Properties.Resources.bird2;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Guns SelectedGun = Guns.Shotgun;
            Birds SelectedBird = Birds.Parrot;

            if (cmbGun.SelectedItem.ToString() == "9mm Glock 17")
            {
                SelectedGun = Guns.Glock;
            }
            else if (cmbGun.SelectedItem.ToString() == "M1 Garand Single")
            {
                SelectedGun = Guns.M1Grand;
            }
            else if (cmbGun.SelectedItem.ToString() == "ShotGun")
            {
                SelectedGun = Guns.Shotgun;
            }

            if (cmbBird.SelectedItem.ToString() == "Parrot")
            {
                SelectedBird = Birds.Parrot;
            }
            else if (cmbBird.SelectedItem.ToString() == "Stork")
            {
                SelectedBird = Birds.Stork;
            }
            else if (cmbBird.SelectedItem.ToString() == "Crow")
            {
                SelectedBird = Birds.Crow;
            }

            BirdHuntingPlayGame playGameForm = new BirdHuntingPlayGame(SelectedGun, SelectedBird);
            this.Hide();
            playGameForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
