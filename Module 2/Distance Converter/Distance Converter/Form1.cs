using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class distanceConverterForm : Form
    {

        public distanceConverterForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Decimal convertedNumber; //this will be the input from the user
            string fromChoice; //value in 'from list'
            string toChoice; //value in 'to list'
            try
            {
                if (decimal.TryParse(conversionTextBox.Text, out convertedNumber))
                    {
                        if (fromListBox.SelectedIndex !=-1)
                        {
                            fromChoice = fromListBox.SelectedItem.ToString();
                            toChoice = toListBox.SelectedItem.ToString();

                            //figure out what is being converted

                            switch (fromChoice)
                            {
                            case "Inches":
                                //If Inches was chosen as the value then check the to value
                                if (toChoice == "Inches")
                                {
                                    convertedValueLabel.Text = (conversionTextBox.Text);
                                }
                                else if (toChoice == "Feet")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) / 12);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                else if (toChoice == "Yards")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) / 36);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                break;
                            case "Feet":
                                //If Feet is chosen as the value then check the to value
                                if (toChoice == "Feet")
                                {
                                    convertedValueLabel.Text = (conversionTextBox.Text);
                                }
                                else if (toChoice == "Inches")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) * 12);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                else if (toChoice == "Yards")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) / 3);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                break;
                            case "Yards":
                                //If yards are chosen as the value then check the to value
                                if (toChoice == "Yards")
                                {
                                    convertedValueLabel.Text = (conversionTextBox.Text);
                                }
                                else if (toChoice == "Inches")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) * 36);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                else if (toChoice == "Feet")
                                {
                                    convertedNumber = (decimal.Parse(conversionTextBox.Text) *3);
                                    convertedValueLabel.Text = convertedNumber.ToString("n4");
                                }
                                break;
                            }

                        }
                    }
                 else
                    {
                        MessageBox.Show("Try entering only numbers this time.");
                        conversionTextBox.Focus();
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {

            const int MAX = 5;
            int i;
            for (i = 1; i <= MAX; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
