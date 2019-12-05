using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Student
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

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //variables to hold input
            string name, id, track;

            //get the student's name and ID
            name = inputNameLabel.Text;
            id = idTextBox.Text;

            //get the student's academic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "information Systems";
            }
            else
            {
                track = "Software Engineer";
            }

            //create a compsci student object
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //display the student's required hours
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }
    }
}
