using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ;
            InitializeComponent();
        }

        // The get filename method gets a filename from the 
        // user and assigns it to the variable passed as 
        // an argument
        private void GetFileName(out string selectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        // the GetCountries method accepts a filename as an 
        // argument. It opens the specified file and displays 
        // its contents in the countriesListBox control.
        private void GetCountries(string filename)
        {
            try
            {
                // Decclare a variable to hold a country name.
                string countryName;

                //declare a Streamreader variable
                StreamReader inputFile;

                // open the file and get a streamReader object
                inputFile = File.OpenText(filename);

                // clear out anything that is currently in the list box
                countriesListBox.Items.Clear();

                // read the contents of the file
                while (!inputFile.EndOfStream)
                {
                    // Get the name of a country
                    countryName = inputFile.ReadLine();

                    // once it's been read ad the name of the country to the listbox
                    countriesListBox.Items.Add(countryName);
                }

                //close the file
                inputFile.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;  // self explanatory

            //get the filename from the user
            GetFileName(out fileName);

            //get the countries from that file
            GetCountries(fileName);
        }
    }
}
