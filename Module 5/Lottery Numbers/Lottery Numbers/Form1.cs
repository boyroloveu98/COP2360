using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //create an array to hold the numbers
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            //create a random object
            Random rand = new Random();

            //Fill the array with random numbers, in the range
            // of 0 => 99
             for ( int index = 0; index< lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            //Display the array elements in the Label controls
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString(); 
        }
    }
}
