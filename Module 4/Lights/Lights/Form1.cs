using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            //display the 'light on" image
            lightOnPictureBox.Visible = true;  
                      
            //hide the 'light off" image
            lightOffPictureBox.Visible = false;

            //Display the light's state
            lightStateLabel.Text = "On";
        }

        private void TurnLightOff()
        {
            //display the 'light off" image
            lightOnPictureBox.Visible = false;

            //hide the 'light on" image
            lightOffPictureBox.Visible = true;

            //Display the light's state
            lightStateLabel.Text = "Off";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //reverse the state of the light
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }
    }
}
