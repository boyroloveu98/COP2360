using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_toss
{
    public partial class coinToss : Form
    {
        public coinToss()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //variable to tell which side is up
            int sideUp;

            //create a random object
            Random rand = new Random();

            //get a random integer in the range of 0 through 1
            //0 means tails up, 1 means heads up
            sideUp = rand.Next(2);

            //display which side is up
            if (sideUp == 0)
            {
                //Display tails side
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            } else
            {
                //Display heads side
                tailsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
            }
        }
    }
}
