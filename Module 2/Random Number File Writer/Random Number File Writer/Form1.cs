using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Writer
{
    public partial class randomFileWriterForm : Form
    {
        public randomFileWriterForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateRandomNumsButton_Click(object sender, EventArgs e)
        {
            int qtyRandomNums;

            //declare the streamwriter
            StreamWriter outputFile;
            //specify the initial path for the save button
            saveRandomListOfNumbers.FileName = "numlist";
            //saveRandomListOfNumbers.InitialDirectory = @"C:\\Users\\Matt";
            saveRandomListOfNumbers.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveRandomListOfNumbers.DefaultExt = "txt";

            try
            {
                outputFile = File.CreateText("list.txt");

                //get the amount of random numbers from the user
                if (int.TryParse(numInputTextBox.Text, out qtyRandomNums))
                {
                    //create random Object
                    Random rand = new Random();

                    // use a for loop to generate the requisite amoutn of random #s
                    for (int counter=0; counter < qtyRandomNums; counter++)
                    {
                        //create a random number from 0-100 and push it to the list
                        int randomNumber = rand.Next(101);
                        outputFile.WriteLine(randomNumber.ToString());
                    }
                    outputFile.Close();

                    // I nearly saved twice. this seems more AND less intuitive to have
                    // a function call in the if statement but it worked
                    if (saveRandomListOfNumbers.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Save Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Save Cancelled");
                    }
                }
                else
                {
                    //invalid input from the user
                    MessageBox.Show("try entering an integer this time. Thank you");
                    numInputTextBox.Text = "";
                    numInputTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
