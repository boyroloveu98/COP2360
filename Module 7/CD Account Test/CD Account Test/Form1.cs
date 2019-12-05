using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the GetCDDAta method accepts a CDAccount object
        // as an argument. It assigns the data entered by
        // the user to the object's props

            private void GetCDData (CDAccount account)
        {
            //temp values to hold the interest rate and balance
            decimal interestRate;
            decimal balance;

            //get the accoutn number.
            account.AccountNumber = accountNumberTextBox.Text;

            //get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;

            //get the interest rate
            if(decimal.TryParse(interestRateTextBox.Text, out interestRate)){
                account.InterestRate = interestRate;

                //get the balance.
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    //display the error message
                    MessageBox.Show("Invalid balance");
                }
            }
            else
            {
                //display the erro message
                MessageBox.Show("invalid interest rate");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // create a cdaccoutn object
            CDAccount myAccount = new CDAccount();

            //get the cdaccount data
            GetCDData(myAccount);

            //display the data
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }
    }
}
