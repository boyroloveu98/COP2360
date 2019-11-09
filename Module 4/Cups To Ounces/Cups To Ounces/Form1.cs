using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create the CupsToOunces method that takes a number
        // that number is the number of cups for the argument
        // this will return the number of ounces in the cup value
        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // create the variable that will hold the number of cups
            double cups, ounces;

            //get the number of cups from the user
            if(double.TryParse(cupsTextBox.Text, out cups))
            {
                //conver the cups to ounces
                ounces = CupsToOunces(cups);

                //display the value
                ouncesLabel.Text = ounces.ToString("n1");
            }
            else
            {
                //error mah dude
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
