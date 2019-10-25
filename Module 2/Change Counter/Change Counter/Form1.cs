using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // initialize the  constant fields
        decimal FIVE_CENTS_VALUE = .05m;
        decimal TEN_CENTS_VALUE = .1m;
        decimal TWENTY_FIVE_CENTS_VALUE = .25m;
        decimal FIFTY_CENTS_VALUE = .50m;

        //field variable to hold the total for the screen
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //adds 5 cents to the total
            total += FIVE_CENTS_VALUE;
            //sets new total to the value of the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //adds 10 cents to the total
            total += TEN_CENTS_VALUE;
            //sets new total to the value of the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //adds 25 cents to the total
            total += TWENTY_FIVE_CENTS_VALUE;
            //sets new total to the value of the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //adds 50 cents to the total
            total += FIFTY_CENTS_VALUE;
            //sets new total to the value of the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //wanted to add a clear button jsut because
            totalLabel.Text = "";
        }
    }
}
