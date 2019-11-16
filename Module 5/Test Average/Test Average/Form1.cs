using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the Average method acceots an int array argument
        // and returns the average of the values in the array.
        private double Average (int[] iArray)
        {
            int total = 0; //Accumulator initialized to 0
            double average; // variable to hold the average
            
            //Step through the array, adding each element to the accumulator
            for (int index =0; index<iArray.Length;index++)
            {
                total += iArray[index];
            }

            //calculates the average
            average = total / iArray.Length;

            //return the average
            return average;
        }

        // the highest method accepts an int array as an argument
        // and returns the highest value in the array
        private int Highest(int[] iArray)
        {
            //declare the variable to hold the highest value, and
            // initializes it with the first value in the array.
            int highest = iArray[0];

            //step through the rest of the array, beginning at element 1.
            //When a value greater than the highest is found assign that value
            //to the highest variable
            for (int index = 1; index<iArray.Length;index++)
            {
                if( iArray[index] >highest)
                {
                    highest = iArray[index];
                }
                //return the highest variable
            }
            return highest;
        }

        // the lowest method accepts an int array as an argument
        // and returns the lowest value in the array
        private int Lowest(int[] iArray)
        {
            //declare the variable to hold the lowest value, and
            // initializes it with the first value in the array.
            int lowest = iArray[0];

            //step through the rest of the array, beginning at element 1.
            //When a value less than the lowest is found assign that value
            //to the lowest variable
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
                //return the highest variable
            }
            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                //local variables
                const int SIZE = 5;             //Number of tests
                int[] scores = new int[SIZE];   //Array of tet scores
                int index = 0;                  //loop counter
                int highestScore;               //holds highest scrore
                int lowestScore;                //holds lowest scrore
                double averageScore;            //to hold the average score
                StreamReader inputFile;         // for the file input

                //open the file and get a streamreader object
                inputFile = File.OpenText("TestScores.Txt");

                //read the test scores into the array
                while (!inputFile.EndOfStream && index<scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                //close the file
                inputFile.Close();

                //display the test scores
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                //get the higheest, lowest, and average scores
                highestScore = Highest(scores);
                lowestScore = Lowest(scores);
                averageScore = Average(scores);

                //display the values
                highScoreLabel.Text = highestScore.ToString();
                lowScoreLabel.Text = lowestScore.ToString();
                averageScoreLabel.Text = averageScore.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

    }
}
