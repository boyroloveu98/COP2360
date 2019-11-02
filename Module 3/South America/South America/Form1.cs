using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace South_America
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

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold acountry name
                string countryName;
                //Declare a StreamReader variable
                StreamReader inputFile;

                //open the file and get  a streamreader object
                inputFile = File.OpenText("Countries.txt");

                //clear out the lsitbox
                countriesListBox.Items.Clear();

                //read the files contents
                while(!inputFile.EndOfStream)
                {
                    //get a country name
                    countryName = inputFile.ReadLine();

                    //add the country name to the Listbox
                    countriesListBox.Items.Add(countryName);
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
