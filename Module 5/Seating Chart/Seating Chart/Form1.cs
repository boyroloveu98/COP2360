using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            //variables for the selected row and column
            int row, col;

            //constants for the maximum row and column subscripts
            const int MAX_ROW = 5;
            const int MAX_COL = 3;

            //create an array with the seat prices
            decimal[,] prices =
            {
                {450m, 450m,450m,450m},
                {425m, 425m,425m,425m},
                {400m, 400m,400m,400m},
                {375m, 375m,375m,375m},
                {375m, 375m,375m,375m},
                {350m, 350m,350m,350m},
            };

            // get the selected row number
            if (int.TryParse(txtRow.Text, out row))
                {
                //get selected column number
                if(int.TryParse(txtCol.Text,out col))
                {
                    //make sure the row is within range
                    if(row>=0 && row <= MAX_ROW)
                    {
                        //make sure tha the column is within range
                        if (col >= 0 && col <= MAX_COL)
                        {
                            //display the selected seats price
                            priceLabel.Text = prices[row, col].ToString("c");
                        }
                        else
                        {
                            //Error message for invalid column
                            MessageBox.Show("column must be 0 through " + MAX_COL);
                        }
                    }
                    else
                    {
                        //Error message for invalid row
                        MessageBox.Show("column must be 0 through " + MAX_ROW);
                    }
                }
                else
                {
                    //Error message for nonint column
                    MessageBox.Show("Enter an integer for the column");
                }
            }
            else
            {
                //Error message for nonint row
                MessageBox.Show("Enter an integer for the row");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //shut down the app
            this.Close();
        }
    }
}
