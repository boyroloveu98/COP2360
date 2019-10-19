using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class formBody : Form
    {
        public formBody()
        {
            InitializeComponent();
        }

        private void card10Spades_Click(object sender, EventArgs e)
        {
            cardName.Text = "Ten of Spades";//tells user the name ofthe card in the label
        }

        private void cardJackSpades_Click(object sender, EventArgs e)
        {
            cardName.Text = "Jack of Spades";//tells user the name ofthe card in the label
        }

        private void cardQueenSpades_Click(object sender, EventArgs e)
        {
            cardName.Text = "Queen of Spades";//tells user the name ofthe card in the label
        }

        private void cardKingSpades_Click(object sender, EventArgs e)
        {
            cardName.Text = "King of Spades";//tells user the name ofthe card in the label
        }

        private void cardAceSpades_Click(object sender, EventArgs e)
        {
            cardName.Text = "Ace of Spades";//tells user the name ofthe card in the label
        }
    }
}
