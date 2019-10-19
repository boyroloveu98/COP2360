using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Flags : Form
    {
        public Flags()
        {
            InitializeComponent();
        }

        private void coffeeImage_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "This is really a picture of coffee. Not a country";
        }

        private void movieNight_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "this is really a picture of Buzz and Woody watchign a movie";
        }

        private void calvinHobbesExplorer_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "This is really an image of calvin and hobbes exploring"; 
        }
    }
}
