using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneArmedBandits.Properties;

namespace OneArmedBandits
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        private Image[] wheelImages = { Resources.will_smith, Resources.kirby, Resources.Kante, Resources.morgan_freeman, Resources.obama, Resources.steve_harvey, Resources.mrs_obama, Resources.black_kid, Resources.bill_cosby, Resources.xxx };

        private WheelOfFruit[] theWheels = new WheelOfFruit[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void updatePictureBoxes()
        {
            pictureBoc1.Image = wheelImages[(int)intWheels[0].getCurrentFruit()];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < theWheels.Length; i++)
            {
                theWheels[i] = new WheelOfFruit();
            }
            playStart();
            updatePictureBoxes();
        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
