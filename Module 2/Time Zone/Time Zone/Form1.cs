using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class timeZoneForm : Form
    {
        public timeZoneForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; //this is the name of the choice
            //-1 to make sure somethign has been selected
            if (cityListBox.SelectedIndex !=-1)
            {
                //get the selected item
                city = cityListBox.SelectedItem.ToString();

                //figure out the time zone
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Easter";
                        break;
                }
            }
            else
            {
                //in case they hit ok without selecting a city
                MessageBox.Show("Select a city first");
            }
        }
    }
}
