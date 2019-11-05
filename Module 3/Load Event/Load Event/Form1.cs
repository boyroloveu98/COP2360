using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //my favorite button 
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold a country name
                string countryName;

                //Declare a StreamReader Variable
                StreamReader inputFile;

                //Open the file and get a streamreader object
                inputFile = File.OpenText("Countries.txt");

                //read the contents of the file
                while (!inputFile.EndOfStream)
                {
                    //get a country name
                    countryName = inputFile.ReadLine();

                    //add the country to the Listbox
                    countriesListBox.Items.Add(countryName);
                }
                //close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //show the error
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("prepare to see the stuff");
        }
    }
}
