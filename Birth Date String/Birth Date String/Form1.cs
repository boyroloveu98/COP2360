using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class birthDateForm : Form
    {
        public birthDateForm()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //declare a string variabel
            string output;

            //concat input to built the string
            output = dayOfWeekTextBox.Text + ", " +
                monthTextBox.Text + " " +
                dayOfMonthTextBox.Text + ", " +
                yearTextBox.Text;

            dataOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            dataOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
