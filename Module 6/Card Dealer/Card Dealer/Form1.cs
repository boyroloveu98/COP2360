﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Dealer
{
    public partial class Form1 : Form
    {
        // Dictionary to simulate a deck of cards
        private Dictionary<string, int> deck = new Dictionary<string, int>()
        {
            // Spades
            {"Ace of Spades",1}, {"2 of Spades",2}, {"3 of Spades",3},
            {"4 of Spades",4}, {"5 of Spades",5}, {"6 of Spades",6},
            {"7 of Spades",7}, {"8 of Spades",8}, {"9 of Spades",9},
            {"10 of Spades",10}, {"Jack of Spades",10}, {"Queen of Spades",10},
            {"King of Spades", 10},

            // Hearts
            {"Ace of Hearts",1}, {"2 of Hearts",2}, {"3 of Hearts",3},
            {"4 of Hearts",4}, {"5 of Hearts",5}, {"6 of Hearts",6},
            {"7 of Hearts",7}, {"8 of Hearts",8}, {"9 of Hearts",9},
            {"10 of Hearts",10}, {"Jack of Hearts",10}, {"Queen of Hearts",10},
            {"King of Hearts", 10},

            // Clubs
            {"Ace of Clubs",1}, {"2 of Clubs",2}, {"3 of Clubs",3},
            {"4 of Clubs",4}, {"5 of Clubs",5}, {"6 of Clubs",6},
            {"7 of Clubs",7}, {"8 of Clubs",8}, {"9 of Clubs",9},
            {"10 of Clubs",10}, {"Jack of Clubs",10}, {"Queen of Clubs",10},
            {"King of Clubs", 10},

            // Diamonds
            {"Ace of Diamonds",1}, {"2 of Diamonds",2}, {"3 of Diamonds",3},
            {"4 of Diamonds",4}, {"5 of Diamonds",5}, {"6 of Diamonds",6},
            {"7 of Diamonds",7}, {"8 of Diamonds",8}, {"9 of Diamonds",9},
            {"10 of Diamonds",10}, {"Jack of Diamonds",10}, {"Queen of Diamonds",10},
            {"King of Diamonds", 10}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //update teh number of cards left in the deck
            cardsLeftLabel.Text = deck.Count.ToString();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            int numCards = 0;               //Number of cards to deal
            int handValue = 0;              //Value of the  dealt cards
            Random rand = new Random();     //Random number generator

            //clear the list box of previous dealt cards
            dealtCardsListBox.Items.Clear();

            //clear the value of the hand
            valueLabel.Text = "";

            // get the number of cards to deal
            if (int.TryParse(numCardsTextBox.Text, out numCards))
            {
                //ensure that the number is still within range
                if(numCards>0 && numCards <= deck.Count)
                {
                    //deal the cards
                    for(int count=0; count< numCards; count++)
                    {
                        //get the random number
                        int randNumber = rand.Next(deck.Count);

                        //get the card at the random position
                        var card = deck.ElementAt(randNumber);

                        //show the card
                        dealtCardsListBox.Items.Add(card.Key);

                        //Update and display the hand value
                        handValue += card.Value;
                        valueLabel.Text = handValue.ToString();

                        //remove the selected card from the deck
                        deck.Remove(card.Key);

                        //update the remaining cards in the deck label
                        cardsLeftLabel.Text = deck.Count.ToString();
                    }
                }
                else
                {
                    //error Message to cover out of range 
                    if(deck.Count == 0)
                    {
                        MessageBox.Show("The deck is empty");
                    }
                    else
                    {
                        MessageBox.Show("Enter a number in the range of " +
                            "1 through " + deck.Count.ToString());
                    }
                }
            }
            else
            {
                //error for non int value
                MessageBox.Show("Enter and integer");
            }
        }
    }
}
