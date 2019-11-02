using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class stadiumRevForm : Form
    {
        //created constants since these values dont change
        const decimal CLASS_A_COST = 15m;
        const decimal CLASS_B_COST = 12m;
        const decimal CLASS_C_COST = 9m;

        private decimal total = 0m;

        public stadiumRevForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //get this one out of the way early
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing the fields
            this.classASeatQtyInput.Text = "";
            this.classBSeatQtyInput.Text = "";
            this.classCSeatQtyInput.Text = "";
            this.classARevDisplay.Text = "";
            this.classBRevDisplay.Text = "";
            this.classCRevDisplay.Text = "";
            this.totalRevDisplay.Text = "";

            classASeatQtyInput.Focus();
        }

        private void calcRevButton_Click(object sender, EventArgs e)
        {
            //ensure error handling
            try
            {
                //turn all inputs into decimalss
                var classASeatQty = decimal.Parse(this.classASeatQtyInput.Text);
                var classBSeatQty = decimal.Parse(this.classBSeatQtyInput.Text);
                var classCSeatQty = decimal.Parse(this.classCSeatQtyInput.Text);
                
                // establish the revenue for calc and display
                var classARevenue = CLASS_A_COST * classASeatQty;
                var classBRevenue = CLASS_B_COST * classBSeatQty;
                var classCRevenue = CLASS_C_COST * classCSeatQty;
                
                // establish total revnue earned
                total = classARevenue + classBRevenue + classCRevenue;

                //show the user the data after calculation
                this.classARevDisplay.Text = classARevenue.ToString("c");
                this.classBRevDisplay.Text = classBRevenue.ToString("c");
                this.classCRevDisplay.Text = classCRevenue.ToString("c");
                this.totalRevDisplay.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                //show errors if they input something wrong
                MessageBox.Show(ex.Message);
            }
        }

        private void ticketsSoldGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
