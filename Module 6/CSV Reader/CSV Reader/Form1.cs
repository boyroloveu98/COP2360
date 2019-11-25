using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string str = "jlo@testmail.com";
            string newStr = "";
            string[] tokens = str.Split('@');
            foreach (string s in tokens)
            {
                newStr += s;
            }
            MessageBox.Show(newStr);
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                StreamReader inputFile;     //to read the file
                string line;                //to hold each line of the CSV
                int count = 0;              // to hold the student counter
                int total;              // accumulator for the sutdent scores
                double average;             // Avg for each student test score

                //create a delim array
                char[] delim = { ',' };

                //open the CSV file
                inputFile = File.OpenText("Grades.Csv");

                while(!inputFile.EndOfStream)
                {
                    //increment the student counter
                    count++;

                    //Read each line of the file and assign it to line
                    line = inputFile.ReadLine();

                    //get the test scores as tokens from the file
                    string[] tokens = line.Split(delim);

                    //SO I learned a lesson by trying to declare the value of the total as 0
                    // without realizing that it was necessary to clear out total for each student
                    total = 0;

                    //calc the value of each line to get the total
                    //for the test scores
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    //calculate the average for each line based
                    // on the number of tests and their totals
                    average = (double)total / tokens.Length;

                    //display the average in the list box before moving to the next
                    averagesListBox.Items.Add("The average for student " + count + " is " +
                        average.ToString("n1"));
                }
                //close the file
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
