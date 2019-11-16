using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //the readscores method reads the scores from the 
        //test scores.txt file into the scoreList parameter
        private void ReadScores(List<int> scoresList)
        {
            try
            {
                //open Testscores.txt file
                StreamReader inputFile = File.OpenText("TestScores.txt");

                //read the scores into the list 
                while (!inputFile.EndOfStream)
                {
                    scoresList.Add(int.Parse(inputFile.ReadLine()));
                }
                //close the file
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //The display scores method disoplays the contents of the 
        //scoreslist parameter in the list box control
        private  void DisplayScores(List<int> scoresList)
        {
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        //the Average method returns the average of the values
        // in the scoresList Parameter
        private double Average(List<int> scoresList)
        {
            int total = 0;              //accumulator
            double average;             //to hold avg

            //calculate the total of the scores
            foreach(int score in scoresList)
            {
                total += score;
            }

            //calculate the average of the scores
            average = (double) total / scoresList.Count;

            //return the average
            return average;
        }

        //the Above average method returns the number of above average
        //scores in the scorelist
        private int AboveAverage(List<int> scoresList)
        {
            int numAbove = 0;               //accumulator

            //get the average score
            double avg = Average(scoresList);

            //count the number of above average scores
            foreach(int score in scoresList)
            {
                if (score > avg)
                {
                    numAbove++; 
                }
            }

            // return the number of above average scores
            return numAbove;
        }

        //the Belowaverage method returns the number of below average
        //scores in the scorelist
        private int BelowAverage(List<int> scoresList)
        {
            int numBelow = 0;               //accumulator

            //get the average score
            double avg = Average(scoresList);

            //count the number of below average scores
            foreach (int score in scoresList)
            {
                if (score < avg)
                {
                    numBelow++;
                }
            }

            // return the number of above average scores
            return numBelow;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;            //to thold the average scores
            int numAboveAverage;            //number of above average scores
            int numBelowAverage;            //number of below average scores

            //create a list to hold the scores
            List<int> scoresList = new List<int>();

            //read the scores from the file into the lsit
            ReadScores(scoresList);

            // display the scores
            DisplayScores(scoresList);

            //display the average score
            averageScore = Average(scoresList);
            AverageLabel.Text = averageScore.ToString("n1");

            //display the number of above average scores
            numAboveAverage = AboveAverage(scoresList);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            //display the number of below average scores
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //shut the club down
            this.Close();
        }

    }
}
