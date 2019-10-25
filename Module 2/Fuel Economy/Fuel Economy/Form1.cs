using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class fuelEconForm : Form
    {
        public fuelEconForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            miles = double.Parse(milesTextBox.Text);
            gallons = double.Parse(gallonsTextBox.Text);
            mpg = miles / gallons;

            mpgLabel.Text = mpg.ToString();
        }
    }
}
