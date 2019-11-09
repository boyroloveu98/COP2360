using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        //create a constant filed for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // create variable for gross pay, bonus and the contributions
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                //calculate the total amount of contribution
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                //display the contributions value
                contributionLabel.Text = contributions.ToString("c");
            }

        }
        //the InputIsValid method will convert the user's input and store 
        //it in the arguments that are passed by reference. If the conversion
        //is successful, the method returns true. Otherwise false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            bool inputIsGood = false;

            // try to convert both inputs to a decimal
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    //since both are good then set inputIsGood to true
                    inputIsGood = true;
                }
                else
                {
                    //display an error for the bonus input
                    MessageBox.Show("Bonus amount is invalid");
                    bonusTextBox.Text = "";
                    bonusTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Grosspay amount is invalid.");
                grossPayTextBox.Text = "";
                grossPayTextBox.Focus();
            }
            return inputIsGood;
        }
    }
}
