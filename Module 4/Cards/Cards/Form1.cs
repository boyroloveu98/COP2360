using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the showcard method accepts a string that names
        //the selected card and displays the card
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        // The showAceSpades method makes the ace of spades
        // visible and the other cards invisible.
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowTenHearts method makes the ten of hearts
        // visible and the other cards invisible.
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowKingClubs method makes the king of clubs
        // visible and the other cards invisible.
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            //if a card is selected in the list box, show the card to the user
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from the list box");
            }
        }
    }
}
