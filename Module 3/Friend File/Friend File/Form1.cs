﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
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

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declare the streamwriter variable
                StreamWriter outputFile;

                //Open the friend.txt in append mode
                // get a streamwriter object
                outputFile = File.AppendText("Friend.txt");

                // write the friend's name to the file
                outputFile.WriteLine(nameTextBox.Text);

                //close the file
                outputFile.Close();
                //clear it out
                nameTextBox.Text = "";
                nameTextBox.Focus();

                //Show the user that it was successful
                MessageBox.Show("Your friend's name was written successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
