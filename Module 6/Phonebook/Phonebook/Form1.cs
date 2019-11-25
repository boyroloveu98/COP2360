using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // field to hold a list of PhonebookEntry objects
        private List<PhoneBookEntry> phoneList =
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        //the Readfile method reads the contents of the phonelist.txt file and stores it as
        //phonebook entry objects in the phonelist
        private void Readfile()
        {
            try
            {
                StreamReader inputFile;         // to read the file
                string line;                    //string to hold the line from the file

                //create an instance of the PBE structure
                PhoneBookEntry entry = new PhoneBookEntry();

                // create a delimeter array
                char[] delim = { ',' };

                //open the PhoneList file
                inputFile = File.OpenText("Phonelist.txt");

                //read each line from the file
                while (!inputFile.EndOfStream)
                {
                    //read the lines from the file
                    line = inputFile.ReadLine();

                    //tokenise the values
                    string[] tokens = line.Split(delim);

                    //store the tokens in the entry object
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    //add that entry to the list
                    phoneList.Add(entry);
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //the DisplayNames method shows the lsitof names in the
        //nameListBox control
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //best button ever
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read the phonList.txt file
            Readfile();

            //display the names
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = nameListBox.SelectedIndex;

            //display the corresponding phone number
            phoneLabel.Text = phoneList[index].phone;
        }
    }
}
